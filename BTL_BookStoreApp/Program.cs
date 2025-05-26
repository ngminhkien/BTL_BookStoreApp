using BTL_BookStoreApp.AccountView;
using BTL_BookStoreApp.BillView;
using BTL_BookStoreApp.Book;
using BTL_BookStoreApp.BookView;
using BTL_BookStoreApp.MenuView;
using Repositories;
using Repositories.Entities;

namespace BTL_BookStoreApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //DbdesignQlchBansachContext context = new DbdesignQlchBansachContext();
            //var bookForm = new BookManagerMainUI(context);
            Application.Run(new MenuForm());
        }
    }
}