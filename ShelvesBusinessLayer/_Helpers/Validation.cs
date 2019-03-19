using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shelves.BusinessLayer.Entities;

namespace Shelves.BusinessLayer.Helpers
{
	/// <summary>
	/// Provides a "portable" and highly customizable framework for validating
	/// any types of data.
	/// </summary>
	public static class Validation
	{
		/// <summary>
		/// Validates a passed value (supports any data type) given the specificed list of validation conditions.
		/// </summary>
		/// <typeparam name="TypeToValidate">Specifies the data type of the value to validate.</typeparam>
		/// <param name="valueToValidate">Specifies the value to validate, upon which the given validation conditions will be tested against to.</param>
		/// <param name="conditions">Specifies all the conditions that a value needs to meet in order to be considered a valid value.</param>
		/// <returns>A ValidationResult object.</returns>
		public static ValidationResult Validate<TypeToValidate>(TypeToValidate valueToValidate, List<ValidationCondition<TypeToValidate>> conditions)
		{
			bool isValid = true;
			List<string> errorMessages = new List<string>();

			foreach(ValidationCondition<TypeToValidate> condition in conditions)
			{
				if (!condition.Rule(valueToValidate))
				{
					isValid = false;
					errorMessages.Add(condition.FailMessage);
				}
			}

			return new ValidationResult(isValid, errorMessages);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TypeToValidate">Specifies the data type of the value to validate.</typeparam>
		/// <param name="valueToValidate">Specifies the value to validate, upon which the given validation conditions will be tested against to.</param>
		/// <param name="conditions">Specifies all the conditions that a value needs to meet in order to be considered a valid value.</param>
		/// <returns>A boolean value whether all the conditions were met or not.</returns>
		public static bool IsValid<TypeToValidate>(TypeToValidate valueToValidate, List<ValidationCondition<TypeToValidate>> conditions) => (Validation.Validate<TypeToValidate>(valueToValidate, conditions).IsValid);
	}
}
