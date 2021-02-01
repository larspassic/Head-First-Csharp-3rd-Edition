using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace aNoiseAnnoysAnOyster
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            x > 0
            x < 1
            x > 1
            x > 3
            x < 4
            
            x = x + 1;
            x = x + 2;
            x = x - 2;
            x = x - 1;

            poem = poem + " ";
            poem = poem + "a";
            poem = poem + "n";
            poem = poem + "an";

            poem = poem + "noys ";
            poem = poem + "oise ";
            poem = poem + " oyster ";
            poem = poem + "annoys";
            poem = poem + "noise";

            
            
            
            
            
            //attempt 1 - easy mode - least complicated solution??
            x > 0
            x < 1 //used
            x > 1 //used
            x > 3
            x < 4 //used - peeked answer
            
            x = x + 1;
            x = x + 2; //used
            x = x - 2;
            x = x - 1; //used
            
            poem = poem + "a"; //used - peeked answer
            poem = poem + " "; //used - peeked answer
            poem = poem + "n"; //used
            poem = poem + "an"; 

            poem = poem + "noys "; //used
            poem = poem + "oise ";
            poem = poem + " oyster "; //used
            poem = poem + "annoys";
            poem = poem + "noise";

            
            
            
            
            
            
            
            //most complex - most possible uses of each??
            x > 0
            x < 1
            x > 1
            x > 3
            x < 4
            
            x = x + 1;
            x = x + 2;
            x = x - 2;
            x = x - 1;

            poem = poem + " "; //2
            poem = poem + "a"; //3
            poem = poem + "n"; //3
            poem = poem + "an"; //2

            poem = poem + "noys "; //1
            poem = poem + "oise "; //1
            poem = poem + " oyster "; //1
            poem = poem + "annoys"; //1
            poem = poem + "noise"; //1
        }
    }
}
