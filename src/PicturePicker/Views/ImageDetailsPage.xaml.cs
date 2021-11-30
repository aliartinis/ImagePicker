using ImagePicker.Core.ViewModels;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PicturePicker.Views
{
	/// <summary>
	/// A page to display details of an image.
	/// </summary>
	public sealed partial class ImageDetailsPage : Page
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImageDetailsPage"/> class.
		/// </summary>
		public ImageDetailsPage()
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
