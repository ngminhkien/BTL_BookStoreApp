using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms.DataVisualization.Charting;
using Services;
using Repositories.Entities;
using Microsoft.IdentityModel.Tokens;

namespace BTL_BookStoreApp
{
    internal class FuncrionAnalytics
    {
        public void DrawRevenueByMonth(int year, Panel targetPanel)
        {
            // Xóa biểu đồ cũ nếu có
            targetPanel.Controls.Clear();

            // Truy vấn dữ liệu: tổng doanh thu theo tháng trong năm
            var revenueByMonth = new CabinetService<SalesInvoiceDetail>().GetAllWithInclude(d => d.Invoice, d => d.Book)
                .Where(d => d.Invoice.InvoiceDate.HasValue && d.Invoice.InvoiceDate.Value.Year == year)
                .GroupBy(d => d.Invoice.InvoiceDate!.Value.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    TotalRevenue = g.Sum(x => (x.Quantity ?? 0) * (x.Book.SelltPrince))
                })
                .OrderBy(x => x.Month)
                .ToList();

            // Tạo biểu đồ
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            ChartArea chartArea = new ChartArea("MainArea");
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Doanh thu (VNĐ)")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SeaGreen,
                Font = new Font("Segoe UI", 10),
                IsValueShownAsLabel = true
            };

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in revenueByMonth)
            {
                string monthName = new DateTime(year, item.Month, 1).ToString("MMM");
                series.Points.AddXY(monthName, item.TotalRevenue);
            }

            // Thêm series và tiêu đề vào chart
            chart.Series.Add(series);
            chart.Titles.Add($"Biểu đồ thể hiện doanh thu theo tháng ({year})");

            // Thêm chart vào panel được truyền vào
            targetPanel.Controls.Add(chart);
        }


        public void DrawBooksSoldByCategory(Panel targetPanel)
        {
            targetPanel.SuspendLayout();
            targetPanel.Controls.Clear();

            var salesByCategory = new CabinetService<SalesInvoiceDetail>()
                .GetAllWithInclude(d => d.Book, d => d.Book.BookCategory)
                .Where(d => d.Book != null && d.Book.BookCategory != null
                    && !string.IsNullOrEmpty(d.Book.BookCategory.BookGenreType)
                    && d.Quantity.HasValue)
                .GroupBy(d => d.Book.BookCategory.BookGenreType)
                .Select(g => new
                {
                    Category = g.Key,
                    TotalQuantity = g.Sum(x => x.Quantity ?? 0)
                })
                .Where(x => x.TotalQuantity > 0)
                .ToList();

            if (!salesByCategory.Any())
            {
                Label noDataLabel = new Label
                {
                    Text = "Không có dữ liệu để hiển thị.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic)
                };
                targetPanel.Controls.Add(noDataLabel);
                targetPanel.ResumeLayout();
                return;
            }

            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            ChartArea chartArea = new ChartArea("PieArea");
            chart.ChartAreas.Add(chartArea);

            // Thêm legend
            chart.Legends.Add(new Legend("Legend")
            {
                Docking = Docking.Right,
                Font = new Font("Segoe UI", 9),
                Alignment = StringAlignment.Near
            });

            Series series = new Series("Thể loại sách")
            {
                ChartType = SeriesChartType.Pie,
                Font = new Font("Segoe UI", 10),
                IsValueShownAsLabel = false,
                LabelForeColor = Color.Black
            };

            foreach (var item in salesByCategory)
            {
                var point = series.Points.AddXY(item.Category, item.TotalQuantity);
                // Thêm chú thích (legend text) cho từng phần
                series.Points.Last().LegendText = item.Category;
            }

            chart.Series.Add(series);
            chart.Titles.Add("Biểu đồ thể hiện cơ cấu lượng sách được bán ra theo loại sách");

            targetPanel.Controls.Add(chart);
            targetPanel.ResumeLayout();
        }

        public void ShowBookstoreStatistics(Panel targetPanel)
        {
            targetPanel.SuspendLayout();
            targetPanel.Controls.Clear();

            var bookService = new CabinetService<Repositories.Entities.Book>();
            var salesDetailService = new CabinetService<SalesInvoiceDetail>();
            var importDetailService = new CabinetService<PurchaseInvoiceDetail>();

            var allBooks = bookService.GetAll();
            var salesDetails = salesDetailService.GetAllWithInclude(d => d.Book);
            var importDetails = importDetailService.GetAllWithInclude(d => d.Book);

            // 1. Cuốn sách bán ra nhiều nhất
            var topSoldBook = salesDetails
                .Where(d => d.Book != null && d.Quantity.HasValue)
                .GroupBy(d => d.Book)
                .Select(g => new
                {
                    BookName = g.Key.BookName,
                    TotalSold = g.Sum(x => x.Quantity ?? 0)
                })
                .OrderByDescending(x => x.TotalSold)
                .FirstOrDefault();

            string topSoldText = topSoldBook != null
                ? $"📚 Sách bán chạy nhất: {topSoldBook.BookName} ({topSoldBook.TotalSold} cuốn)"
                : "📚 Sách bán chạy nhất: Không có dữ liệu.";

            // 2. Tổng doanh thu
            double totalRevenue = salesDetails
                .Where(d => d.Quantity.HasValue)
                .Sum(d => (d.Quantity ?? 0) * (d.Book.SelltPrince));

            // 3. Tổng chi phí nhập hàng
            double totalImportCost = importDetails
                .Where(d => d.Quantity.HasValue )
                .Sum(d => (d.Quantity ?? 0) * (d.Book.ImportPrince));

            // 4. Lợi nhuận
            double profit = totalRevenue - totalImportCost;

            // 5. Hiển thị ra panel
            var stats = new List<string>
    {
        topSoldText,
        $"💰 Tổng doanh thu: {totalRevenue:N0} VNĐ",
        $"📦 Tổng chi phí nhập hàng: {totalImportCost:N0} VNĐ",
        $"📈 Lợi nhuận: {profit:N0} VNĐ"
    };

            int y = 10;
            foreach (var stat in stats)
            {
                Label label = new Label
                {
                    Text = stat,
                    AutoSize = true,
                    Location = new Point(10, y),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                targetPanel.Controls.Add(label);
                y += label.Height + 10;
            }

            targetPanel.ResumeLayout();
        }

        public void DrawRevenueByEmployee(int year, Panel targetPanel)
        {
            // Xóa biểu đồ cũ nếu có
            targetPanel.Controls.Clear();

            // Truy vấn dữ liệu: tổng doanh thu theo từng nhân viên trong năm
            var revenueByEmployee = new CabinetService<SalesInvoiceDetail>().GetAllWithInclude(d => d.Invoice, d => d.Book)
                .Where(d => d.Invoice.InvoiceDate.HasValue && d.Invoice.InvoiceDate.Value.Year == year)
                .GroupBy(d => d.Invoice.EmployeeId)
                .Select(g => new
                {
                    EmployeeId = g.Key,
                    TotalRevenue = g.Sum(x => (x.Quantity ?? 0) * (x.Book.SelltPrince))
                })
                .OrderByDescending(x => x.TotalRevenue)
                .ToList();

            // Tạo biểu đồ
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            ChartArea chartArea = new ChartArea("MainArea");
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Doanh thu (VNĐ)")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.OrangeRed,
                Font = new Font("Segoe UI", 10),
                IsValueShownAsLabel = true,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in revenueByEmployee)
            {
                series.Points.AddXY(item.EmployeeId, item.TotalRevenue);
            }

            // Thêm series và tiêu đề vào chart
            chart.Series.Add(series);
            chart.Titles.Add($"Biểu đồ gấp khúc doanh thu theo nhân viên ({year})");

            // Thêm chart vào panel
            targetPanel.Controls.Add(chart);
        }



    }
}
