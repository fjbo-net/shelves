using Shelves.BusinessLayer.Parts.Abstract;

namespace Shelves.BusinessLayer.Parts
{
	public class Outsourced:Part
	{
		public string companyName;


		public void setCompanyName(string newCompanyName) => companyName = newCompanyName;
		public string getCompanyName() => companyName;


		public Outsourced() => base.Init();
	}
}
