using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMgmWinForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static string newItemName = null;
        public static string newUserId = null;
        public static string newUserFName;
        public static string newUserLName;
        public static string newUserDept;
        public static string newUserIssItems = "Null"; // must do: fix Users.class issitems - string builder do not accept null value

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibraryManagement());
        }
    }
}
