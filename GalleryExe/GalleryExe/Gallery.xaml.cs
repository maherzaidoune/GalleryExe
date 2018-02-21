using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalleryExe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Gallery : ContentPage
	{
        public String[] url = {
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvPv8_YGuI6hX9WJ5XQ_iLNYksJzLGcUYUq5Y8oTD-GTGuFNUN",
            "https://upload.wikimedia.org/wikipedia/commons/5/56/Flag_of_Tunisia.png",
            "https://gatornews.org/wp-content/uploads/2016/03/shape8.png",
            "https://vignette.wikia.nocookie.net/althistory/images/a/a7/Tunisia_Coat_of_Arms.png/revision/latest?cb=20150915190108",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS3SRYgUmAb7SuomJy2t5EgtVS8aZxpbh0-392r6KCEvHoGb2o50w",
            "https://1.bp.blogspot.com/-b6dS5EG_v4g/Wg1Syx6n8mI/AAAAAAAAAb4/s0itK4OV_5cDmgMhuc5z7q7R-tYYyp3XQCLcBGAs/s210-p/Tunisia.png"
        };
        int counter = 0;

        public Gallery ()
		{
			InitializeComponent ();
            showImage(counter);
            
            
		}
        public void showImage(int index)
        {
            img.Source = new UriImageSource {
                Uri = new Uri(url[counter]),
                CachingEnabled = false
            };
        }

        public void next(Object sender,EventArgs e)
        {
            if (counter == 5)
                counter = 0;
            else
                counter++;
            showImage(counter);
        }
        public  void previous(Object sender,EventArgs e)
        {
            if (counter == 0)
                counter = 5;
            else
                counter--;
            showImage(counter);
        }
    }
}