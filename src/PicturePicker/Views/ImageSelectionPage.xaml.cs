using ImagePicker.Core.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Windows.UI.Xaml.Controls;

namespace PicturePicker.Views
{
	/// <summary>
	/// A page that provides a control for selecting an image.
	/// </summary>
	public sealed partial class ImageSelectionPage : Page
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImageSelectionPage"/> class.
		/// </summary>
		public ImageSelectionPage()
		{
			this.InitializeComponent();
			ViewModel = Ioc.Default.GetRequiredService<ImageSelectionViewModel>();
		}

		/// <summary>
		/// Gets the view-model.
		/// </summary>
		public ImageSelectionViewModel ViewModel
		{
			get;
		}
	}
}
