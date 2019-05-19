namespace Generics.Concrete
{
	public class CircularBuffer<T> : Buffer<T>
	{
		private int _capacity;

		public CircularBuffer(): this(capacity: 10)
		{

		}

		public CircularBuffer(int capacity = 10)
		{
			_capacity = capacity;
		}

		public override void Write(T value)
		{
			base.Write(value);
			if(_queue.Count > _capacity)
			{
				_queue.Dequeue();
			}
		}

		public bool IsFull => _queue.Count == _capacity;
	}
}
