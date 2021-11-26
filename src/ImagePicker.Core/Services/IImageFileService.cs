using ImagePicker.Core.Models;
using System.Threading.Tasks;

namespace ImagePicker.Core.Services
{
	/// <summary>
	/// Interface for a type dealing with image files.
	/// </summary>
	public interface IImageFileService
	{
		/// <summary>
		/// Prompts the user to choose an image file and returns its details after selection.
		/// </summary>
		/// <returns>An asynchronous opertation which, upon completion, returns an object representing the selected image.</returns>
		Task<ImageFileModel> SelectFileAsync();
	}
}
