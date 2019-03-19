using System;
using System.Collections.Generic;

using Shelves.BusinessLayer.Products;
using Shelves.BusinessLayer.Parts;
using Shelves.BusinessLayer.Parts.Abstract;

namespace Shelves.BusinessLayer.Inventory
{
    public class Inventory
    {
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
			if (this.Products.Count == 0) return null;
			
			return new Product();
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
        public Part lookupPart(int byId) => new Inhouse();
        public void updatePart(int partId, Part updatedPart) { }

		public List<Part> getParts() => allParts;
    }
}
