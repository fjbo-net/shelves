using System;
using System.Collections.Generic;

using Shelves.BusinessLayer.Entities;
using Shelves.BusinessLayer.Helpers;
using Shelves.BusinessLayer.Products;

namespace ShelvesBusinessLayerTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("(c) 2019 FJBO Shelves. All Rights Reserved.");

			Product product1, product2;

			product1 = new Product();
			product1.setProductID(1);
			product1.setName("Product 1");
			product1.setMin(5);
			product1.setMax(100);
			product1.setInStock(5);
			product1.setPrice(5.00);

			product2 = new Product();
			product2.setProductID(2);
			product2.setName("Product 2");
			product2.setMin(5);
			product2.setMax(100);
			product2.setInStock(10);
			product2.setPrice(10.00);


			Console.ReadKey();
		}
	}
}
