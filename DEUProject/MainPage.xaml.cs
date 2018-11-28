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

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            viewModel.Update();
            await Task.CompletedTask;
        }

        public MainPage()
        {
            BindingContext = viewModel = new MainViewModel();

            InitializeComponent();
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Device.OpenUri(new Uri((e.Item as MainModel).Link));
        }
    }
}
