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
    public partial class Category : ContentPage
    {
        public Category()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new home());

        }
    }
}