using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PicturePicker
{
	/// <summary>
	/// A page that is loaded in the root frame of the app's main window.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MainPage"/> class.
		/// </summary>
		public MainPage()
		{
			this.InitializeComponent();
			ViewModel = new MainViewModel();
		}

		/// <summary>
		/// Gets the view-model.
		/// </summary>
		public MainViewModel ViewModel
		{
			get;
		}

		/// <summary>
		/// Handler for the Click event of the button for selecting a file.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event arguments.</param>
		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			await ViewModel.SelectFileAsync();
		}
	}
}
