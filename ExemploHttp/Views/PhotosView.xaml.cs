using ExemploHttp.ViewModels;

namespace ExemploHttp.Views;

public partial class PhotosView : ContentPage
{
	public PhotosView()
	{
		InitializeComponent();
		BindingContext = new PhotosViewModel();
	}
}