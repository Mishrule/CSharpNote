using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote.Generics
{
	internal class OrderItem<T> where T: Product
	{
		public int Id { get; set; }
		public T Product { get; set; }
		public int Quantity { get; set; }
	}
}
