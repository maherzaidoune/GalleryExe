using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalleryExe
{
    class EmbeddedResources : IMarkupExtension
    {
        public String resource { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(resource);
        }
    }
}
