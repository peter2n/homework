using System;
using System.Collections.Generic;
using System.Text;

namespace P04_HospitalOOP
{
    public class Room
    {
        public Room()
        {
            List<Patient> Patients = new List<Patient>();
        }

        public List<Patient> Patients { get; set; }

        public bool IsFull()
        {
            return (Patients.Count >= 3);
        }


    }
}
