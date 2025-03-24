﻿using System;
namespace barİstasyon.Domain.Entities
{
	public class CoffeeFeature
	{
		public int CoffeeFeatureID { get; set; }

		public int CoffeeID { get; set; }

		public Coffee Coffee { get; set;}

		public Feature Feature { get; set; }

		public int FeatureID { get; set; }

		public bool Avaliable { get; set; }

	}

}