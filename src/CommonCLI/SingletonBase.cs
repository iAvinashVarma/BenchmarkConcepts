using System;

namespace CommonCLI
{
	public abstract class SingletonBase<T> where T : SingletonBase<T>, new()
	{
		private static bool IsInstanceCreated = false;

		private static readonly Lazy<T> LazyInstance = new Lazy<T>(() =>
		{
			T instance = new T();
			IsInstanceCreated = true;
			return instance;
		});

		protected SingletonBase()
		{
			if(IsInstanceCreated)
			{
				throw new InvalidOperationException($"Constructing a {typeof(T).Name} manually is not allowed, use the Instance property.");
			}
		}

		public static T Instance
		{
			get
			{
				return LazyInstance.Value;
			}
		}
	}
}
