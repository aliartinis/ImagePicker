using ImagePicker.Core.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

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
			ViewModel = Ioc.Default.GetRequiredService<ImageDetailsViewModel>();
			Loaded += OnLoaded;
			Unloaded += OnUnloaded;
		}

		/// <summary>
		/// Invoked when the Loaded event is raised.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event arguments.</param>
		private void OnLoaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			ViewModel.IsActive = true;
		}

		/// <summary>
		/// Invoked when the Unloaded event is raised.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event arguments.</param>
		private void OnUnloaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
		{
			ViewModel.IsActive = false;
		}

		/// <summary>
		/// Gets the view-model.
		/// </summary>
		public ImageDetailsViewModel ViewModel
		{
			get; 
		}
	}
}
