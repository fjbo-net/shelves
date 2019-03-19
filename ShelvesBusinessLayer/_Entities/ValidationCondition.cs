using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelves.BusinessLayer.Entities
{
	/// <summary>
	/// Represents a single condition that has to be met by any given value (supports any data type) to be considered valid defined by a Rule (lambda expression).
	/// Examples: the value (int) must be positive [ rule: value => (value >= 0) ], the value (string) must be at least 8 characters long [ rule: value => (value.Length >= 8) ].
	/// </summary>
	/// <typeparam name="TypeOfValue">Specifies the data type of the value that has to meet this condition.</typeparam>
	public class ValidationCondition<TypeOfValue>
	{
		/// <summary>
		/// Defines an informational message for the user. Could be a description of the condition like "value must not be empty".
		/// </summary>
		public string InfoMessage { get; private set; }
		/// <summary>
		/// Defines an error message in case a given value fails this condition. Example: "Please provide a positive value." 
		/// </summary>
		public string FailMessage { get; private set; }
		/// <summary>
		/// Defines the rule to which a given value will be tested against as a lambda expression.
		/// For example: value => (!String.IsNullOrEmpty(value)), checks that a given value (string) is not null or empty.
		/// </summary>
		public Func<TypeOfValue, bool> Rule { get; private set; }

		public ValidationCondition( Func<TypeOfValue, bool> rule,
									string infoMessage = "",
									string failMessage = "") {
			this.Rule = rule;
			if (!string.IsNullOrEmpty(failMessage)) this.FailMessage = failMessage;
			if (!string.IsNullOrEmpty(infoMessage))
			{
				this.InfoMessage = infoMessage;
				if(string.IsNullOrEmpty(failMessage)) this.FailMessage = infoMessage;
			}
		}
	}
}
