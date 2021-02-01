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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            
            //attempt 1
            int x = 0;
            string poem = "";
            
            while (x < 4) { //x starts as zero, so this condition MUST be either x<1 or x<4, or the while loop will not even start.
                            //since probability says we will be dealing with positive numbers, x<4 will give this loop the most longevity.
                            //peeked answer and this is x<4
                
                poem = poem + "a"; //peeked answer
                
                if (x < 1) { //pre-set
                    
                    poem = poem + " "; //if we're going to use this on the first run then it should probably be space
                                       //peeked answer
                }
                
                poem = poem + "n"; //this is happening on the first run so i guess let's just try "noise"
                                       //using "noise" on first run is not working
                                       //this must be either "noise" or "n" or some maths.
                                       //going with "n"
                
                if (x < 1) { //may as well pick something that is true on first run?
                    poem = poem + "oise "; //need "oise " so using it
                    
                    x = x - 1;          //on first run we currently have "a noise " so next we need "annoys"
                                        //we can either get it now or on the next loop - nevermind, next loop will start with an "a" 
                                        //next loop is going to give us "a n"
                                        //if we make x=1 then we will get the if below, as well as "an" on next run
                                        //plan is to make x=-1 now, then iterate +2 at the end.
                                        //next two runs should add "an+noys " then "an+ oyster "
                }
                
                if ( x == 1 ) { //pre-set
                    poem = poem + "noys ";
                }
                
                if (x > 1) { 
                    poem = poem + " oyster ";
                }
                
                x = x + 2; //probably an iterator
            }
            output.Text = poem;
        }
    }
}
