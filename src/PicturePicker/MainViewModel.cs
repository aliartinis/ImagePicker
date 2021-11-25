using Microsoft.Toolkit.Mvvm.ComponentModel;
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
	public class MainViewModel : ObservableObject
	{
		private string fileName;
		private string fileType;

		public MainViewModel()
		{
			PictureSelectorService = new PictureSelectorService();
		}

		public PictureSelectorService PictureSelectorService
		{
			get;
		}

		public string FileName
		{
			get => fileName;
			set => SetProperty(ref fileName, value);
		}

		public string FileType
		{
			get => fileType;
			set => SetProperty(ref fileType, value);
		}

		public async Task SelectFileAsync()
		{
			PictureModel model = await PictureSelectorService.SelectFileAsync();

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
	}
}
