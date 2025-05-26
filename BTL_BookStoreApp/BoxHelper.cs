using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Repositories;

namespace BTL_BookStoreApp
{
    internal class BoxHelper
    {
        public void LoadToComboBox<T>(
            ComboBox comboBox,
            List<T> source,
            Func<T, string> getId,
            Func<T, string> getName,
            string specialItemName = "Other...")
        {
            var items = source
                .Select(item => new SpecialItem
                {
                    Id = getId(item),
                    Name = getName(item)
                })
                .ToList();

            items.Add(new SpecialItem
            {
                Id = "-1",
                Name = specialItemName
            });

            comboBox.DataSource = null;
            comboBox.DataSource = items;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

        public void LoadToComboBox2<T>(
            ComboBox comboBox,
            List<T> source,
            Func<T, string> getId,
            Func<T, string> getName,
            string specialItemName = "Other...")
        {
            List<SpecialItem> items = new();
            items.Add(new SpecialItem
            {
                Id = "-1",
                Name = specialItemName
            });

            var tmp = source
            .Select(item => new SpecialItem
            {
                Id = getId(item),
                Name = getName(item)
            })
            .ToList();

            foreach ( var x in tmp )
            {
                items.Add(x);
            }

            comboBox.DataSource = null;
            comboBox.DataSource = items;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

        //hàm xử lí Datetime?
        public static DateTime? ParseFromMaskedTextBox(MaskedTextBox mtb)
        {
            if (DateTime.TryParseExact(
                    mtb.Text.Trim(),
                    "MM/dd/yyyy HH:mm",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime result))
            {
                return result;
            }
            throw new FormatException("Incorrect format MM/dd/yyyy HH:mm.");
        }

        //hàm báo lỗi phone
        public static bool ValidatePhone(MaskedTextBox mtb)
        {
            string rawPhone = mtb.Text.Replace(".", "").Trim();

            if (rawPhone.Length != 10)
            {
                MessageBox.Show("The phone number must be full of 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtb.Focus();
                return false;
            }

            string prefix = rawPhone.Substring(0, 2);
            if (prefix != "03" && prefix != "08" && prefix != "09")
            {
                MessageBox.Show("The phone number must start with 03, 08 or 09", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtb.Focus();
                return false;
            }

            return true;
        }
        //*cách dùng
        //        if (!ValidationHelper.ValidatePhone(mtbPhone))
        //{
        //    return; // dừng lại nếu không hợp lệ
        //}

        //// tiếp tục xử lý nếu hợp lệ

        public static bool IsValidInput(params TextBox[] boxes)
        {
            foreach (TextBox box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    MessageBox.Show("Please fill in the infomation", "Lack of data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    box.Focus();
                    return false;
                }
            }
            return true;
        }

        //if (!IsValidInput(txtName, txtPhone, txtAddress)) return;
        

    }
}

