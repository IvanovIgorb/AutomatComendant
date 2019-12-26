using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat_comendant
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public class Student
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string group;
            public string Group
            {
                get { return group; }
                set { group = value; }
            }

            private int room;
            public int Room
            {
                get { return room; }
                set { room = value; }
            }

            private string inventory;
            public string Inventory
            {
                get { return inventory; }
                set { inventory = value; }
            }
            public int F;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }

        public static Student studen = new Student();
        public static List<string> students = new List<string>();
 

    }
}

