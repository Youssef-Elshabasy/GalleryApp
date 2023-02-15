using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace GalleryApp
{
	public class GalleryImage : INotifyPropertyChanged
    {
        public ImageSource Source { get; }

		public ImageSource FavoriteSource
			=> IsFavorite
				? ImageSource.FromResource("GalleryApp.Resources.Icons.Favorite.png")
				: ImageSource.FromResource("GalleryApp.Resources.Icons.Unfavorite.png");

		public bool IsFavorite { get; set; }

		public GalleryImage(ImageSource imageSource)
			=> Source = imageSource;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

		public void ToggleFavorite()
		{
			IsFavorite = !IsFavorite;
			OnPropertyChanged(nameof(IsFavorite));
			OnPropertyChanged(nameof(FavoriteSource));
		}
    }
}

