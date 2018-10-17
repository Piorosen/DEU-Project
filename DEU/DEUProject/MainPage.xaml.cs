using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DEUProject
{
    public partial class MainPage : TabbedPage
    {
        MainViewModel viewModel;

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        public MainPage()
        {
            BindingContext = viewModel = new MainViewModel();

            InitializeComponent();
        }
    }
}
