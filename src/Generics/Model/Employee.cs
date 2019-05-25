using Generics.DataAccess.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace Generics.Model
{
	public class Employee : Person, IEntity
	{
		[Key]
		public override int Id { get; set; }

		public virtual void DoWork(Action<string> action)
		{
			action.Invoke("Doing real work.");
		}

		public virtual void Speak<T>()
		{
			Console.WriteLine(typeof(T).Name);
		}

		public bool IsValid()
		{
			return true;
		}
	}
}
