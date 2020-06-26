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
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(Employee empl = null)
        {
            InitializeComponent();
            if(empl != null)
            {
                ((AddOrEditEmployeeViewModel)BindingContext).Employee = empl;
            }
        }
    }
}