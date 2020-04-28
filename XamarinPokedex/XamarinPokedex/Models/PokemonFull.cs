using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPokedex.Models
{
    public class PokemonFull
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public Sprites Sprites { get; set; }

	}
}
