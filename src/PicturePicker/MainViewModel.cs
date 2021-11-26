using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PicturePicker
{
	/// <summary>
	/// A view-model for the app's main page.
	/// </summary>
	public class MainViewModel : ObservableObject
	{
		#region Backing fields
		/// <summary>
		/// Backing field for <see cref="FileName"/>.
		/// </summary>
		private string fileName;

		/// <summary>
		/// Backing field for <see cref="FileType"/>.
		/// </summary>
		private string fileType;
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="MainViewModel"/> class.
		/// </summary>
		public MainViewModel()
		{
			ImageFileService = new ImageFileService();
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
		/// Gets or sets the image file name.
		/// </summary>
		public string FileName
		{
			get => fileName;
			set => SetProperty(ref fileName, value);
		}

		/// <summary>
		/// Gets or sets the image file type.
		/// </summary>
		public string FileType
		{
			get => fileType;
			set => SetProperty(ref fileType, value);
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
			ImageFileModel model = await ImageFileService.SelectFileAsync();

			// Update the properties with the new data.
			if (model != null)
			{
				FileName = model.Name;
				FileType = model.Type;
			}
			else
			{
				FileName = "";
				FileType = "";
			}
		}
		#endregion
	}
}
