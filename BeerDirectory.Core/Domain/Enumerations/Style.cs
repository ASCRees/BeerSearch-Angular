namespace BeerDirectory.Core.Domain.Enumerations
{
	public class Style : Enumeration
	{
		public Style(int value, string displayName) : base(value, displayName)
		{
		}
		
		public static readonly Style Porter
			= new Style(0, "Porter");
		public static readonly Style AmericanPaleAle
			= new Style(1, "American Pale Ale");
		public static readonly Style AmericanLager
			= new Style(2, "American Lager");
		public static readonly Style OldAle
			= new Style(3, "Old Ale");
		public static readonly Style FruitBeer
			= new Style(4, "Fruit Beer");
		
	}
}