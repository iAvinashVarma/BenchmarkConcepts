using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics.Ioc
{
	public class Container
	{
		Dictionary<Type, Type> _map = new Dictionary<Type, Type>();

		public Container()
		{
		}

		public ContainerBuilder For<TSource>()
		{
			return For(typeof(TSource));
		}

		public ContainerBuilder For(Type sourceType)
		{
			return new ContainerBuilder(this, sourceType);
		}

		public TSource Resolve<TSource>()
		{
			return (TSource)Resolve(typeof(TSource));
		}

		public object Resolve(Type sourceType)
		{
			if(_map.ContainsKey(sourceType))
			{
				var destinationType = _map[sourceType];
				return CreateInstance(destinationType);
			}
			else
			{
				throw new InvalidOperationException($"Could not resolve {sourceType}.");
			}
		}

		private object CreateInstance(Type destinationType)
		{
			var parameters = destinationType.GetConstructors()
												.OrderByDescending(c => c.GetParameters().Count())
												.First()
												.GetParameters()
												.Select(p => Resolve(p.ParameterType))
												.ToArray();
			return Activator.CreateInstance(destinationType, parameters);
		}

		public class ContainerBuilder
		{
			private readonly Container _container;
			private readonly Type _sourceType;

			public ContainerBuilder(Container container, Type sourceType)
			{
				_container = container;
				_sourceType = sourceType;
			}

			public ContainerBuilder Use<TDestination>()
			{
				return Use(typeof(TDestination));
			}

			public ContainerBuilder Use(Type destinationType)
			{
				_container._map.Add(_sourceType, destinationType);
				return this;
			}
		}
	}
}