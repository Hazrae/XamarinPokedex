using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPokedex.Models
{
    public class PokemonBus
    {
		private int _count;

		public int Count
		{
			get { return _count; }
			set { _count = value; }
		}

		private string _previous;

		public string Previous
		{
			get { return _previous; }
			set { _previous = value; }
		}

		private string _next;

		public string Next
		{
			get { return _next; }
			set { _next = value; }
		}

		private List<Pokemon> _results;

		public List<Pokemon> Results
		{
			get { return _results; }
			set { _results = value; }
		}



	}
}
