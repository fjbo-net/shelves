using System.Collections.Generic;
using System.Text;

namespace Shelves.BusinessLayer.Entities
{
	/// <summary>
	/// Represents the result of validating a given value.
	/// </summary>
	public class ValidationResult
	{
		/// <summary>
		/// Defines whether the result of the validation operations is valid or not.
		/// This value should be assigned only during the instantiation of the class.
		/// </summary>
		public readonly bool IsValid;
		/// <summary>
		/// Contains the error messages derived from the validation operations that created this result.
		/// This value should be assigned only during the instantiation of the class.
		/// </summary>
		public readonly List<string> ErrorMessages;


		public string ErrorMessagesAsString(bool multiLine = true) {
			StringBuilder builder = new StringBuilder();

			foreach (string message in ErrorMessages) builder.AppendLine(message);

			return builder.ToString().Trim();
		}

		/// <summary>
		/// Creates an instance of a validation result. Usually used by the Validation helper, but could be used somewhere else.
		/// </summary>
		/// <param name="isValid">Defines whether the result of the validation operations is valid or not.</param>
		/// <param name="errorMessages">Contains the error messages derived from the validation operations that created this result.</param>
		public ValidationResult(bool isValid, List<string> errorMessages = null)
		{
			IsValid = isValid;
			ErrorMessages = errorMessages;
		}
	}
}
