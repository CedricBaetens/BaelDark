using System;

namespace Themes.BaelDark
{
	public interface IInterface
	{

	}
	public class Class : IInterface
	{
		public int Property { get; set; }

		private readonly string readonlyString = "Readonly";
		private const string constantString = "Readonly";
		private int _field = 0;

		public void Method(int parameter)
		{
			var local = 1;

			_field = parameter;
			_field = local;
		}
	}

	public static class Extensions
	{
		public static int ExtensionsMethod(this int value)
		{
			return value + 1;
		}
	}

	public enum Enum
	{
		Value1,
		Value2
	}
}


