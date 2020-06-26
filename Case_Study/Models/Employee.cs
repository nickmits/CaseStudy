using System;
using System.Collections.Generic;
using System.Text;

namespace Case_Study
{
    public class Employee
    {
        //suppose that each employee has unique name..
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Specialty { get; set; }

        public Employee(int id, string name, string surname, string phone , string address, string specialty)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Address = address;
            Specialty = specialty;
        }

        public Employee()
        {
        }
    }
}
