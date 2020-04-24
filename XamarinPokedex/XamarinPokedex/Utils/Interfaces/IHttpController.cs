using System;
using System.Net.Http;

namespace XamarinPokedex.Utils.Interfaces
{
    public interface IHttpController
    {
        HttpClient Client { get; set; }
        HttpClient GetClient(Uri uri);
    }
}