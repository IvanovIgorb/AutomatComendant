# AutomatComendant
        /// </summary>
        public class Student
        {
            private string name;
            public int Name
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

            private string room;
            public string Room
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
            public static Student studen = new Student();
            public static List<string> studentsList = new List<string>();
        }
