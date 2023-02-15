using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GalleryApp
{
    public partial class GalleryPage : ContentPage
    {
        public ObservableCollection<GalleryImage> Gallery { get; private set; }

        public GalleryPage()
        {
            Gallery = new ObservableCollection<GalleryImage>()
            {
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image1.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image2.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image3.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image4.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image5.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image6.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image7.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image8.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image9.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image10.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image11.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image12.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image13.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image14.jpg")),
                new GalleryImage(ImageSource.FromResource("GalleryApp.Resources.Images.Image15.jpg"))
            };

            InitializeComponent();

            BindingContext = this;
        }

        private void OnTappedImage(object sender, EventArgs args)
        {
            var selectedImage = sender as Image;
            var galleryImage = Gallery.First(gi => gi.Source == selectedImage.Source);
            Navigation.PushAsync(new DetailsPage(Gallery, Gallery.IndexOf(galleryImage)));
        }
    }
}
