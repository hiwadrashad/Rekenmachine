using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rekenmachine
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void secondClicked(object sender, EventArgs e)
        {
            textvalue.Text = "this works";
        }

        public void piClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("0") && currentvalue.Length == 1)
            {
                textvalue.Text = "3.1416";
            }
            string[] operators = { "+", "-", "x", "/" };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "3.1416";
                textvalue.Text = currentvalue;
            }
        }

        public void eClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("0") && currentvalue.Length == 1)
            {
                textvalue.Text = "2.7183";
            }
            string[] operators = { "+", "-", "x", "/" };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "2.7183";
                textvalue.Text = currentvalue;
            }
        }

        public void ceClicked(object sender, EventArgs e)
        {
            textvalue.Text = "0";
        }

        public void deloneClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                if (currentvalue.Length == 1)
                {
                    textvalue.Text = "0";
                }
                else
                {
                    currentvalue = currentvalue.Remove(currentvalue.Length - 1);
                    textvalue.Text = currentvalue;
                }
            }


        }


        public void squareClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "sqr(" + currentvalue + ")";
                        textvalue.Text = currentvalue;
                    }
                }
            }

        }

        public void logClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "1/(" + currentvalue + ")";
                        textvalue.Text = currentvalue;
                    }
                }
            }
        }

        public void absClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "abs/(" + currentvalue + ")";
                        textvalue.Text = currentvalue;
                    }
                }
            }
        }

        public void expClicked(object sender, EventArgs e)
        {

        }

        public void modClicked(object sender, EventArgs e)
        {

        }

        public void sqrtClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "√/(" + currentvalue + ")";
                        textvalue.Text = currentvalue;
                    }
                }
            }
        }

        public void parenthesisopenClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("0") && currentvalue.Length == 1)
            {
                textvalue.Text = "(";
            }
            string[] operators = { "+", "-", "x", "/" };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "(";
                textvalue.Text = currentvalue;
            }
        }
        public void parenthesisclosedClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("0") && currentvalue.Length == 1)
            {
                textvalue.Text = "(";
            }
            string[] operators = { "+", "-", "x", "/" };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "(";
                textvalue.Text = currentvalue;
            }
        }
        public void factorialClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("0") && currentvalue.Length == 1)
            {
            }
            string[] operators = { "+", "-", "x", "/" };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "(";
                textvalue.Text = currentvalue;
            }
        }
        public void divideClicked(object sender, EventArgs e)
        {

        }

        public void exponentClicked(object sender, EventArgs e)
        {

        }
        public void sevenClicked(object sender, EventArgs e)
        {

        }
        public void eightClicked(object sender, EventArgs e)
        {

        }
        public void nineClicked(object sender, EventArgs e)
        {

        }

        public void multipliedClicked(object sender, EventArgs e)
        {

        }

        public void poweroftenClicked(object sender, EventArgs e)
        {

        }
        public void fourClicked(object sender, EventArgs e)
        {

        }
        public void fiveClicked(object sender, EventArgs e)
        {

        }
        public void sixClicked(object sender, EventArgs e)
        {

        }

        public void minusClicked(object sender, EventArgs e)
        {

        }
        public void logarithmicClicked(object sender, EventArgs e)
        {

        }
        public void oneClicked(object sender, EventArgs e)
        {

        }
        public void twoClicked(object sender, EventArgs e)
        {

        }
        public void threeClicked(object sender, EventArgs e)
        {

        }

        public void plusClicked(object sender, EventArgs e)
        {

        }

        public void inClicked(object sender, EventArgs e)
        {

        }
        public void negateClicked(object sender, EventArgs e)
        {

        }
        public void zeroClicked(object sender, EventArgs e)
        {

        }
        public void decimalClicked(object sender, EventArgs e)
        {

        }

        public void calculateClicked(object sender, EventArgs e)
        {

        }
    }
}
