﻿using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace PicturePicker
{
	/// <summary>
	/// A service for selecting image files and obtaining their details.
	/// </summary>
	public class ImageFileService
	{
		/// <summary>
		/// Prompts the user to choose an image file and returns its details after selection.
		/// </summary>
		/// <returns>An asynchronous opertation which, upon completion, returns details of the user selected image.</returns>
		public async Task<ImageFileModel> SelectFileAsync()
		{
			// Prepare the UI control that lets the user choose a file.
			FileOpenPicker openPicker = new FileOpenPicker();
			openPicker.ViewMode = PickerViewMode.Thumbnail;
			openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
			openPicker.FileTypeFilter.Add(".jpg");
			openPicker.FileTypeFilter.Add(".jpeg");
			openPicker.FileTypeFilter.Add(".png");

			// Show the control and get the object representing the selected file.
			StorageFile file = await openPicker.PickSingleFileAsync();

			// Prepare the model to be returned to callee.
			ImageFileModel model = null;
			if (file != null)
			{
				model = new ImageFileModel();
				model.Name = file.DisplayName;
				model.Type = file.FileType;
			}

			return model;
		}
	}
}
