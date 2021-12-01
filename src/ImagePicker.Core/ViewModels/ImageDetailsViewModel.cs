using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ImagePicker.Core.ViewModels
{
	/// <summary>
	/// A view-model for a view displaying details of an image.
	/// </summary>
	public class ImageDetailsViewModel : ObservableObject
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
		/// Initializes a new instance of the <see cref="ImageDetailsViewModel"/> class.
		/// </summary>
		public ImageDetailsViewModel()
		{
			AppState.Instance.PropertyChanged += OnAppStatePropertyChanged;
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
		/// Invoked when the value a property of <see cref="AppState"/> has changed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The event arguments.</param>
		private void OnAppStatePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == nameof(AppState.Instance.ImageFileModel))
			{
				var model = AppState.Instance.ImageFileModel;
				if (model != null)
				{
					FileName = model.Name;
					FileType = model.Type;
				}
				else
				{
					FileName = string.Empty;
					FileType = string.Empty;
				}
			}
		}
		#endregion
	}
}
