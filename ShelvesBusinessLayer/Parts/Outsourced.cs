using Shelves.BusinessLayer.Parts.Abstract;

namespace Shelves.BusinessLayer.Parts
{
	public class Outsourced:Part
	{
		public string companyName;


		public void setCompanyName(string newCompanyName) => companyName = newCompanyName;
		public string getCompanyName() => companyName;


		public Outsourced() => base.Init();
		public Outsourced(string name, int inventoryLevel, double price, int min, int max, string companyName) : this()
		{
			setName(name);
			setInStock(inventoryLevel);
			setPrice(price);
			setMin(min);
			setMax(max);
			setCompanyName(companyName);
		}
	}
}
