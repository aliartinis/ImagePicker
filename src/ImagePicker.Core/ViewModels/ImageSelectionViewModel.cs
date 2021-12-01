using ImagePicker.Core.Models;
using ImagePicker.Core.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImagePicker.Core.ViewModels
{
	/// <summary>
	/// A view-model for a view enabling the selection of an image.
	/// </summary>
	public class ImageSelectionViewModel : ObservableRecipient
	{
		#region Backing Fields
		/// <summary>
		/// Backing field for <see cref="SelectedImage"/>.
		/// </summary>
		private ImageFileModel selectedImage;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="ImageSelectionViewModel"/> class.
		/// </summary>
		public ImageSelectionViewModel(IImageFileService imageFileService)
		{
			ImageFileService = imageFileService;
		}
		#endregion

		#region Services
		/// <summary>
		/// Gets the image file service.
		/// </summary>
		public IImageFileService ImageFileService
		{
			get;
		}
		#endregion

		#region Commands
		/// <summary>
		/// Gets the command for selecting an image.
		/// </summary>
		public ICommand SelectImageFileCommand
		{
			get => new AsyncRelayCommand(SelectFileAsync);
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the image file model.
		/// </summary>
		public ImageFileModel SelectedImage
		{
			get => selectedImage;
			set => SetProperty(ref selectedImage, value, true);
		}
		#endregion
		
		#region Methods
		/// <summary>
		/// Retrieve details of the user selected image file.
		/// </summary>
		/// <returns>An asynchronous operation which, upon completion, returns nothing.</returns>
		private async Task SelectFileAsync()
		{
			// Get the image data from the service.
			SelectedImage = await ImageFileService.SelectFileAsync();
		}
		#endregion
	}
}
