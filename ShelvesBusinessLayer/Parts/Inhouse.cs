using Shelves.BusinessLayer.Parts.Abstract;

namespace Shelves.BusinessLayer.Parts
{
	public class Inhouse : Part
	{
		public int machineID;


		public void setMachineID(int newMachineID) => machineID = newMachineID;
		public void setMachineID(string newMachineID)
		{
			int newValue;
			if (int.TryParse(newMachineID, out newValue)) setMachineID(newValue);
		}
		public int getMachineID() => machineID;


		public Inhouse() => base.Init();
		public Inhouse(string name, int inventoryLevel, double price, int min, int max, int machineId) : this()
		{
			setName(name);
			setPrice(price);
			setMin(min);
			setMax(max);
			setInStock(inventoryLevel);
			setMachineID(machineId);
		}
	}
}
