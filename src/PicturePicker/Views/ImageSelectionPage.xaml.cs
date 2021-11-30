using ImagePicker.Core.ViewModels;
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
		}

		/// <summary>
		/// Gets or sets the view-model.
		/// </summary>
		public MainViewModel ViewModel
		{
			get;
			set;
		}
	}
}
