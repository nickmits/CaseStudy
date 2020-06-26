using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Case_Study
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeListPage : ContentPage
    {
        public EmployeeListPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddOrEditEmployeePage());
        }

        private void Tapgesturerecognizer_Tapped_Edit(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
            Employee employee = ((EmployeeListViewModel)BindingContext).Employees.
                Where(emp => emp.Id == (int)tappedEventArgs.Parameter).
                FirstOrDefault();

            Navigation.PushAsync(new AddOrEditEmployeePage(employee));
        }
        private void TapGestureRecognizer_Tapped_Delete(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Employee employee = ((EmployeeListViewModel)BindingContext).Employees.
                Where(emp => emp.Id == (int)tappedEventArgs.Parameter).
                FirstOrDefault();
            ((EmployeeListViewModel)BindingContext).Employees.Remove(employee);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Employee employee = ((EmployeeListViewModel)BindingContext).Employees.
                Where(emp => emp.Id == (int)tappedEventArgs.Parameter).
                FirstOrDefault();
            Navigation.PushAsync(new ProfilePage(employee));
        }

    }
}