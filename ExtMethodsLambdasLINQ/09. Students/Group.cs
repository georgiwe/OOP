namespace Students
{
    using System;

    public class Group
    {
        public Group(string depName, int group)
        {
            this.DepartmentName = depName;
            this.GroupNum = group;
        }

        public string DepartmentName { get; set; }

        public int GroupNum { get; set; }
    }
}