using Shelves.BusinessLayer.Parts.Abstract;

namespace Shelves.BusinessLayer.Parts
{
	public class Inhouse : Part
	{
		public int machineID;


		public void setMachineID(int newMachineID) {}
		public int getMachineID() => machineID;


		public Inhouse() => base.Init();
	}
}
