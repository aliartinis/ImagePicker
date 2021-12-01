using ImagePicker.Core.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace ImagePicker.Core
{
	/// <summary>
	/// Contains data accessible to different modules.
	/// </summary>
	public class AppState : ObservableObject
	{
		/// <summary>
		/// Lazy initialization object for this class.
		/// </summary>
		private static readonly Lazy<AppState> m_instance = new Lazy<AppState>(() => new AppState());
		
		/// <summary>
		/// Backing field for <see cref="ImageFileModel"/>.
		/// </summary>
		private ImageFileModel imageFileModel;

		/// <summary>
		/// Initializes a new instance of the <see cref="AppState"/> class.
		/// </summary>
		private AppState()
		{
		}

		/// <summary>
		/// Gets the only instance of this class.
		/// </summary>
		public static AppState Instance
		{
			get => m_instance.Value;
		}

		/// <summary>
		/// Gets or sets the image file model.
		/// </summary>
		public ImageFileModel ImageFileModel
		{
			get => imageFileModel;
			set => SetProperty(ref imageFileModel, value);
		}
	}
}
