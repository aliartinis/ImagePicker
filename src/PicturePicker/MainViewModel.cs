using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace PicturePicker
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string FileName
		{
			get;
			set;
		}

		public string FileType
		{
			get;
			set;
		}

		public async Task SelectFileAsync()
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
				FileName = file.DisplayName;
				FileType = file.FileType;
			}
			else
			{
				FileName = "";
				FileType = "";
			}

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FileName"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FileType"));
		}
	}
}
