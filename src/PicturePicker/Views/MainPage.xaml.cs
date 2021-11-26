using ImagePicker.Core.ViewModels;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Windows.UI.Xaml.Controls;

namespace ImagePicker.Views
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

			// Provides a new instance of the view-model while taking care of its dependencies.
			ViewModel = Ioc.Default.GetRequiredService<MainViewModel>();
		}

		/// <summary>
		/// Gets the view-model.
		/// </summary>
		public MainViewModel ViewModel
		{
			get;
		}
	}
}
