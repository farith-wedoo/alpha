using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeDoo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class home : ContentPage
    {
        public home()
        {
            InitializeComponent();
        }

        async void onFrameCitizenReporterTapped(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Category());

        }

        async void onFrameCitizenReporterTapped1(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new History());

        }
    }
}