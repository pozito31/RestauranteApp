using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;


namespace RestauranteApp.ViewModel
{
    public class OrderViewModel: BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }

        public List<Pick> MenuList { get; set; }
        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());
        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick {Title="", Image="IMG01.png", Description="", Price=""}, 
                new Pick {Title="", Image="IMG04.png", Description="", Price=""},
                new Pick {Title="", Image="IMG05.png", Description="", Price=""}
            };
        }
    }
}
