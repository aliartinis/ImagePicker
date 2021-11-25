using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace PicturePicker
{
	public class MainViewModel
	{
		public async Task<string> SelectFileAsync()
		{
			FileOpenPicker openPicker = new FileOpenPicker();
			openPicker.ViewMode = PickerViewMode.Thumbnail;
			openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
			openPicker.FileTypeFilter.Add(".jpg");
			openPicker.FileTypeFilter.Add(".jpeg");
			openPicker.FileTypeFilter.Add(".png");
			StorageFile file = await openPicker.PickSingleFileAsync();

			if (file != null)
			{
				return file.DisplayName;
			}
			else
			{
				return "";
			}
		}
	}
}
