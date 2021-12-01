using ImagePicker.Core.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace ImagePicker.Core.ViewModels
{
	/// <summary>
	/// A view-model for a view displaying details of an image.
	/// </summary>
	public class ImageDetailsViewModel : ObservableRecipient, IRecipient<PropertyChangedMessage<ImageFileModel>>
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
		/// <inheritdoc/>
		public void Receive(PropertyChangedMessage<ImageFileModel> message)
		{
			if (message.Sender.GetType() == typeof(ImageSelectionViewModel) &&
				message.PropertyName == nameof(ImageSelectionViewModel.SelectedImage))
			{
				var model = message.NewValue;
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
