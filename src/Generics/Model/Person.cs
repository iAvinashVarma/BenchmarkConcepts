using System;
using System.ComponentModel.DataAnnotations;

namespace Generics.Model
{
	public class Person
	{
		[Key]
		public virtual int Id { get; set; }

		public string Name { get; set; }
	}
}
