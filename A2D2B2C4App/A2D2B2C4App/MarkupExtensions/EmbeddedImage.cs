using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A2D2B2C4App.MarkupExtensions
{
    //Deze regel voegen we toe om bij de aanroep de ResourceId= weg te kunnen laten

    [ContentProperty("ResourceId")]
    class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceId))
            {
                return null;
            }
            return ImageSource.FromResource(ResourceId);
        }
    }
}
