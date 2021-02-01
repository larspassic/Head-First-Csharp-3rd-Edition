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

namespace BuildAnAppFromTheGroundUp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //this is a comment

            string name = "Quentin";

            int x = 3;

            x = x * 17;

            double d = Math.PI / 2;

            myLabel.Text = "name is " + name
                + "\nx is " + x
                + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Bobbo Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                myLabel.Text = "x is 3 and the name is Joe";
            }

            myLabel.Text = "this line runs no matter what";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //set up variable named count
            int count = 0;

            //while count is less than ten - meaning, after count becomes 10, exit the loop
            while (count < 10)
            {
                count = count + 1;
            }

            //count starts here as 10
            //i=0 count=9
            //i=1 count=8
            //i=2 count=7
            //i=3 count=6
            //i=4 count=5
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            myLabel.Text = "The answer is " + count;

            //fun panic attack infinite loop
            //while (true) { int i = 1; }

            /*
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }

                q = p - q;
            }
             */
        }

        
    }
}
