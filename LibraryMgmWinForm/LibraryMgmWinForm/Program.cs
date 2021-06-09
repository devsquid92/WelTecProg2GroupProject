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
        public static string newUserIssItems = "[]";


        public static string showUserInfoId;
        public static string showUserInfoFName;
        public static string showUserInfoLName;
        public static string showUserInfoDepartment;

        public static List<string> showIssuedItems;



        public static string editUserInfoId;
        public static string editUserInfoFName;
        public static string editUserInfoLName;
        public static string editUserInfoDepartment;

        public static string storedItem;
        

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
