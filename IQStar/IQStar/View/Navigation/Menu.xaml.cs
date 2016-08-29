using IQStar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IQStar.View.Navigation
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
  
            ObservableCollection<MenuItemList> Lista = new ObservableCollection<MenuItemList>() { new MenuItemList() { Nazwa="Gra",Ico= "gra.png"},
                new MenuItemList() { Nazwa="Tablica wyników",Ico= "wyniki.png"},
               new MenuItemList() { Nazwa="Lista odznak",Ico= "odznaki.png"},
               new MenuItemList() { Nazwa="Statystyki",Ico= "statystyki.png"},
               new MenuItemList() { Nazwa="Znajomi" ,Ico= "znajomi.png"}};

            ListView listView = new ListView
            {
                ItemsSource = Lista,
                ItemTemplate = new DataTemplate(() => {
                    var stac = new StackLayout { Orientation = StackOrientation.Horizontal, Padding = 10 };
                    var nameLabel = new Label { FontSize = 24, TextColor = Color.White };
                    nameLabel.SetBinding(Label.TextProperty, "Nazwa");
                    var img = new Image();
                    img.SetBinding(Image.SourceProperty, "Ico");
                    stac.Children.Add(img);
                    stac.Children.Add(nameLabel);

                    return new ViewCell { View = stac };
                }),
                HasUnevenRows = true,
                SeparatorColor = Color.White
               
            };

            this.Master = new ContentPage
            {
                Title = "Menu",
                Content = listView,
                Icon = "hamburger.png"
            };

            listView.ItemTapped += (sender, e) =>
            {
                var gotoPage = new Page();
                var itemMenu = e.Item as MenuItemList;
                switch (itemMenu.Nazwa)
                {
                    case "Gra":
                        gotoPage = new WyborGry();
                        break;
                    case "Tablica wyników":
                        gotoPage = new TablicaWynikow();
                        break;
                    case "Lista odznak":
                        gotoPage = new ListaOdznak();
                        break;
                    case "Statystyki":
                        gotoPage = new Statystyki();
                        break;
                    case "Znajomi":
                        gotoPage = new Znajomi();
                        break;

                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new WyborGry());
        }
    }
}
