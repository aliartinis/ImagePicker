using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace PicturePicker
{
	public class PictureSelectorService
	{
		public async Task<PictureModel> SelectFileAsync()
		{
			FileOpenPicker openPicker = new FileOpenPicker();
			openPicker.ViewMode = PickerViewMode.Thumbnail;
			openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
			openPicker.FileTypeFilter.Add(".jpg");
			openPicker.FileTypeFilter.Add(".jpeg");
			openPicker.FileTypeFilter.Add(".png");
			StorageFile file = await openPicker.PickSingleFileAsync();

			PictureModel model = new PictureModel();

			if (file != null)
			{
				model.Name = file.DisplayName;
				model.Type = file.FileType;
			}

			return model;
		}
	}
}
