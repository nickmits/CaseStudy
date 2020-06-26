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
    public partial class AddOrEditEmployeePage : ContentPage
    {
        public AddOrEditEmployeePage(Employee empl = null)
        {
            InitializeComponent();

            if(empl != null)
            {
                ((AddOrEditEmployeeViewModel)BindingContext).Employee = empl;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Employee employee = ((AddOrEditEmployeeViewModel)BindingContext).Employee;

            MessagingCenter.Send(this, "AddOrEditEmployee", employee);

            Navigation.PopAsync();
        }
    }
}