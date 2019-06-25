using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using ConectaCampoBom.Views;
using Xamarin.Forms;

namespace ConectaCampoBom
{
    public partial class MainPage : MasterDetailPage
    {
        private ObservableCollection<MenuModel> menuLista { get; set; }

        //private string videoUrl = "https://archive.org/download/BigBuckBunny_328/BigBuckBunny_512kb.mp4";

        public MainPage()
        {
            InitializeComponent();
            //menuLista = ItemService.GetMenu();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Principal)));
        }

        /*
        private void btnPlayStop_Clicked(object sender, EventArgs e)
        {
            if (btnPlayStop.Text == "Reproduzir")
            {
                btnPlayStop.Text = "Parar";
                CrossMediaManager.Current.Play(videoUrl, Plugin.MediaManager.Abstractions.Enums.MediaFileType.Video);
            }
            else if (btnPlayStop.Text == "Parar")
            {
                btnPlayStop.Text = "Reproduzir";
                CrossMediaManager.Current.Stop();
            }
        }
        */

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuModel)e.SelectedItem;
            Type page = item.Page;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
