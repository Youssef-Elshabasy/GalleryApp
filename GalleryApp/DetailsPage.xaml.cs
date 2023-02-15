using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GalleryApp
{	
	public partial class DetailsPage : ContentPage
	{
		public IReadOnlyCollection<GalleryImage> Gallery { get; private set; }

		public DetailsPage(IReadOnlyCollection<GalleryImage> gallery, int selectedImagePos)
		{
			Gallery = gallery;
			InitializeComponent();
			BindingContext = this;
			detailsView.Position = selectedImagePos;
		}

		private void OnTappedFavorite(object sender, EventArgs args)
			=> (detailsView.CurrentItem as GalleryImage).ToggleFavorite();
    }
}
