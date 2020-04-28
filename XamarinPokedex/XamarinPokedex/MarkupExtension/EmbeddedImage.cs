using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPokedex.MarkupExtension
{
    public class EmbeddedImage : IMarkupExtension
    {
        public string Resource { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(Resource);
        }
    }
}
