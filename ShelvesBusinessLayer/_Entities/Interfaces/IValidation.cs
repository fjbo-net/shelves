using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shelves.BusinessLayer.Entities;

namespace Shelves.BusinessLayer.Entities.Interfaces
{
	public interface IValidation<TypeOfValueToValidate>
	{
		List<ValidationCondition<TypeOfValueToValidate>> Conditions { get; set; }

		bool IsValid();
		ValidationResult Validate();
	}
}
