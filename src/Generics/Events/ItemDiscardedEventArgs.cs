using System;

namespace Generics.Events
{
	public class ItemDiscardedEventArgs<T> : EventArgs
	{
		public ItemDiscardedEventArgs(T discardedItem, T newItem)
		{
			ItemDiscarded = discardedItem;
			NewItem = newItem;
		}

		public T ItemDiscarded { get; set; }

		public T NewItem { get; set; }
	}
}
