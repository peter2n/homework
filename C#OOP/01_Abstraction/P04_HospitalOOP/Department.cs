using System;
using System.Collections.Generic;
using System.Text;

namespace P04_HospitalOOP
{
    public class Department
    {
        public Department(string departmentName)
        {
            this.Name = departmentName;
            List<Room> Rooms = new List<Room>();
        }

        public string Name { get; set; }
        public List<Room> Rooms { get; set; }

        public bool IsFull()
        {
            return (Rooms.Count >= 20 && Rooms[19].IsFull());
        }

        public override string ToString()
        {
            //return base.ToString();

            //TODO


        }

    }
}
