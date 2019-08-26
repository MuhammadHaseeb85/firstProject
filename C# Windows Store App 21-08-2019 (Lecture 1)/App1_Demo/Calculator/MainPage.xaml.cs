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

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double firstnumber;
        string operation;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null) 
            {
                Txt1.Text = "1";
            }
            else
            {
                Txt1.Text = Txt1.Text + "1";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "4";
            }
            else
            {
                Txt1.Text = Txt1.Text + "4";
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "3";
            }
            else
            {
                Txt1.Text = Txt1.Text + "3";
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "5";
            }
            else
            {
                Txt1.Text = Txt1.Text + "5";
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "6";
            }
            else
            {
                Txt1.Text = Txt1.Text + "6";
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "7";
            }
            else
            {
                Txt1.Text = Txt1.Text + "7";
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "8";
            }
            else
            {
                Txt1.Text = Txt1.Text + "8";
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "9";
            }
            else
            {
                Txt1.Text = Txt1.Text + "9";
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (Txt1.Text == "0" && Txt1.Text != null)
            {
                Txt1.Text = "0";
            }
            else
            {
                Txt1.Text = Txt1.Text + "0";
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = Convert.ToDouble(Txt1.Text);
            Txt1.Text = "";
            operation = "+";
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Txt1.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double secondnumber;
            double result;

            secondnumber = Convert.ToDouble(Txt1.Text);
            if(operation =="+")
            {
                result = (firstnumber + secondnumber);
                Txt1.Text = result.ToString();
                firstnumber = result;
            }
            else if(operation == "-")
            {
                result = (firstnumber - secondnumber);
                Txt1.Text = result.ToString();
                firstnumber = result;
            }
            else if (operation == "/")
            {
                result = (firstnumber / secondnumber);
                Txt1.Text = result.ToString();
                firstnumber = result;
            }
            else if (operation == "*")
            {
                result = (firstnumber * secondnumber);
                Txt1.Text = result.ToString();
                firstnumber = result;
            }
            else if (operation == "%")
            {
                result = (firstnumber % secondnumber);
                Txt1.Text = result.ToString();
                firstnumber = result;
            }
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = Convert.ToDouble(Txt1.Text);
            Txt1.Text = "";
            operation = "-";
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = Convert.ToDouble(Txt1.Text);
            Txt1.Text = "";
            operation = "*";
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = Convert.ToDouble(Txt1.Text);
            Txt1.Text = "";
            operation = "/";
        }

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = Convert.ToDouble(Txt1.Text);
            Txt1.Text = "";
            operation = "%";
        }
    }
}
