using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPokedex.Models
{
	public class Pokemon
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _url;

		public string Url
		{
			get { return _url; }
			set { _url = value; }
		}



	}

}