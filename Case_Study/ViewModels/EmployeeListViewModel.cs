using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Case_Study
{
    public class EmployeeListViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public EmployeeListViewModel()
        {
            Employees = new ObservableCollection<Employee>();

            Employees.Add(new Employee(1, "Mark", "Zuckerberg", "+526 5626-252-54254", "Str Zk 2", "Software Engineer"));
            Employees.Add(new Employee(2, "Bill", "Gates", "+541 45298 6526462", "Str Bk 14", "Product Manager"));
            Employees.Add(new Employee(3,"Steve", "Jobs", "+765 5682 64164", "str stj", "Team Leader"));
            Employees.Add(new Employee(4, "Charlotte", "Vitte", "+8742742", "Str hf 8", "A"));
            Employees.Add(new Employee(5, "Nick", "Mitselos", "+84454545474", "Str NCM 4", "B"));
            Employees.Add(new Employee(6, "Pan", "Pot", "+477 4445 854554", "Str ppt 2", "CEO"));
            Employees.Add(new Employee(7, "Elon", "Musk", "+477 4445 854554", "Str ppt 2", "CEO"));

            MessagingCenter.Subscribe<AddOrEditEmployeePage, Employee>(this, "AddOrEditEmployee", 
                (page, employee) =>
                {
                    if(employee.Id == 0)
                    {
                        employee.Id = Employees.Count + 1;
                        Employees.Add(employee);
                    }
                    else
                    {
                        Employee employeeToEdit = Employees.Where(empl => empl.Id == employee.Id).FirstOrDefault();
                        int newIndex = Employees.IndexOf(employeeToEdit);
                        Employees.Remove(employeeToEdit);

                        Employees.Add(employee);
                        int oldIndex = Employees.IndexOf(employee);

                        Employees.Move(oldIndex, newIndex);
                        //get the employee from the previous screen and replacing the old employee with the new that has been sent
                    }
                }
                );       
        }

    }
}
