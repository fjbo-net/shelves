using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelves.BusinessLayer.Inventory
{
	public interface IInventoryItem
	{
		int getID();
		void setID(int newId);

		string getName();
		void setName(string newName);

		int getInStock();
		void setInStock(int newInStock);

		double getPrice();
		void setPrice(double newPrice);


		ListViewItem ToListViewItem();
	}
}
