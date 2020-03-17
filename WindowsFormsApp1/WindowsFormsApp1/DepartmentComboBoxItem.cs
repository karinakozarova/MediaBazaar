namespace WindowsFormsApp1
{
    class DepartmentComboBoxItem
    {
        string name;
        int id;

        public DepartmentComboBoxItem(Department d)
        {
            name = d.Name;
            id = d.DepartmentId;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return name;
        }
    }
}
