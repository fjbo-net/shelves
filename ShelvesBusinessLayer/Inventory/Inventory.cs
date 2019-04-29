using System;
using System.Linq;
using System.Collections.Generic;

using Shelves.BusinessLayer.Products;
using Shelves.BusinessLayer.Parts;
using Shelves.BusinessLayer.Parts.Abstract;

namespace Shelves.BusinessLayer.Inventory
{
	public class Inventory
	{
		private Inventory() { }


		public static Inventory Instance = new Inventory();


		private List<Product> Products = new List<Product>();
		private List<Part> allParts = new List<Part>();

		public void addProduct(Product newProduct) {
			// TODO :: FJBO: Implement validation for this method.
			this.Products.Add(newProduct);
		}
		public void addProducts(IEnumerable<Product> newProducts)
		{
			foreach (var product in newProducts) addProduct(product);
		}
		public bool removeProduct(int byId) => false;

		public Product lookupProduct(int byId) {
			try
			{
				return getProducts().Where(product => product.getID() == byId).Single();
			} catch
			{
				return null;
			}
		}

		public List<Product> lookupProducts(string searchTerm) => (List<Product>)lookupProducts(getProducts(), searchTerm);

		public static IList<Product> lookupProducts(IList<Product> productList, string searchTerm)
		{
			searchTerm = searchTerm.ToLower();

			return productList
			.Where(product =>
				product.getID().ToString().ToLower().Contains(searchTerm) ||
				product.getName().ToLower().Contains(searchTerm) ||
				product.getPrice().ToString().ToLower().Contains(searchTerm) ||
				product.getInStock().ToString().ToLower().Contains(searchTerm) ||
				product.getMin().ToString().ToLower().Contains(searchTerm) ||
				product.getMax().ToString().ToLower().Contains(searchTerm))
			.ToList();
		}

		public void updateProduct(int ProductId, Product updatedProduct) {
			// TODO :: FJBO: implement validation for this method.

		}
		public List<Product> getProducts() => Products;

		public void addPart(Part newPart)
		{
			// TODO :: FJBO: implement validation for this method.
			this.allParts.Add(newPart);
		}
		public void addParts(IEnumerable<Part> newParts)
		{
			foreach (var part in newParts) addPart(part);
		}
		public bool removePart(int byId) => false;
		public Part lookupPart(int byId)
		{
			try
			{
				return getParts().Where(part => part.getID() == byId).Single();
			} catch
			{
				return null;
			}
		}

		public static IList<Part> lookupParts(IList<Part> partList, string searchTerm) {
			searchTerm = searchTerm.ToLower();

			return partList.Where(part =>
				part.getPartID().ToString().ToLower().Contains(searchTerm)
				|| part.getName().ToLower().Contains(searchTerm.ToLower())
				|| part.getPrice().ToString().ToLower().Contains(searchTerm.ToLower())
				|| part.getInStock().ToString().ToLower().Contains(searchTerm)
				|| part.getMin().ToString().ToLower().Contains(searchTerm)
				|| part.getMax().ToString().ToLower().Contains(searchTerm))
			.ToList();
		}

		public List<Part> lookupParts(string searchTerm) => (List<Part>) lookupParts(getParts(), searchTerm);

        public void updatePart(int partId, Part updatedPart) { }

		public List<Part> getParts() => allParts;
    }
}
