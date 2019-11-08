using System;
using System.Collections.Generic;
using System.Text;

namespace P04_HospitalOOP
{
    public class Doctor
    {

        public Doctor(string name)
        {
            this.FullName = name;
            this.Patients = new List<Patient>();
        }

        public string FullName { get; set; }
        public List<Patient> Patients { get; set; }

        public override string ToString()
        {
            //return base.ToString();

            //todo








        }



    }
}
