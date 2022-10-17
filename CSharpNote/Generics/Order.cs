using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNote.Generics
{
	internal class Order<T> where T: Product
	{
		private readonly List<OrderItem<T>> _orderItems;

		public Order()
		{
			_orderItems = new List<OrderItem<T>>();

		}

		public Order(List<OrderItem<T>> orderItems)
		{
			_orderItems = orderItems;
		}
	}
}
