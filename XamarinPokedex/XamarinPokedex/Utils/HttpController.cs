using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using XamarinPokedex.Utils.Interfaces;

namespace XamarinPokedex.Utils
{
	public class HttpController : IHttpController
	{
		private HttpClient _client;

		public HttpClient Client
		{
			get { return _client; }
			set { _client = value; }
		}


		public HttpClient GetClient(Uri uri)
		{
			_client = new HttpClient();
			Client.BaseAddress = uri;
			return _client;
		}

	}
}
