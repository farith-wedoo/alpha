using WeDoo.MenuItems;
using WeDoo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeDoo
{

    public partial class MainMenu : MasterDetailPage
    {

        public List<MasterPageItem> menuList { get; set; }

        public MainMenu()
        {
               InitializeComponent();

            menuList = new List<MasterPageItem>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "Home", Icon = "homebutton1.png", TargetType = typeof(home) };
            var page2 = new MasterPageItem() { Title = "Shop By Category", Icon = "list.png", TargetType = typeof(Category) };
            var page3 = new MasterPageItem() { Title = "History", Icon = "history.png", TargetType = typeof(History) };
            var page4 = new MasterPageItem() { Title = "Shopping Cart", Icon = "cart.png", TargetType = typeof(ShoppingCart) };
            var page5 = new MasterPageItem() { Title = "Account", Icon = "account.png", TargetType = typeof(Account) };
            var page6 = new MasterPageItem() { Title = "Customer Support", Icon = "support.png", TargetType = typeof(support) };
            

            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(home)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

       

      
    }
}