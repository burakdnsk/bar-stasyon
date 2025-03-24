using System;
namespace barİstasyon.Domain.Entities
{
	public class Coffee
	{

		public int CoffeeID { get; set; }

		public int BaseID { get; set; }

		public Base Base { get; set; }

		public string CoverImageURL { get; set; }

		public int WaterML { get; set; }

		public int CoffeeML { get; set; }

		public int MilkML { get; set; }

		public int FoamML { get; set; }

		public bool SugarOrSweetener { get; set; }

		public bool Extraİngredients { get; set; }

		public int BrewingTime { get; set; }

		public string BrewingType { get; set; }

		public string BigimageURL { get; set; }

		public List<CoffeeFeature> CoffeeFeatures { get; set; }

		public List<CoffeeDescription> CoffeeDescriptions { get; set; }

        public List<CoffeePricing> CoffeePricings { get; set; }
    }
}

