using System;
namespace barİstasyon.Domain.Entities
{
	public class Feature
	{
		public int FeatureID { get; set; }

		public string Name{ get; set;}

		public List<CoffeeFeature> CoffeeFeatures { get; set; }
    }
}

