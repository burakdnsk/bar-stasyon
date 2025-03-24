using System;
namespace barİstasyon.Domain.Entities
{
	public class Pricing
	{
		public int PricingID { get; set; }

		public string Name { get; set; }

		public List<CoffeePricing> CoffeePricings { get; set; }
	}
}

