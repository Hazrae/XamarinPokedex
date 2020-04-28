using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPokedex.Models
{
    public class Sprites
    {
		private string _back_default;

		public string Back_Default
		{
			get { return _back_default; }
			set { _back_default = value; }
		}

		private string _front_default;

		public string Front_Default
		{
			get { return _front_default; }
			set { _front_default = value; }
		}
	}
}
