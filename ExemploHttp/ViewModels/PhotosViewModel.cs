using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using ExemploHttp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExemploHttp.ViewModels
{
    public partial class PhotosViewModel:ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Photo> photos;

        public ICommand getPhotosCommand { get; }

        private async void getPhotos()
        {
            RestService restService = new RestService();
            Photos = await restService.getPhotosAsync();
        }

        public PhotosViewModel() 
        {
            getPhotosCommand = new Command(getPhotos);
        }
    }
}
