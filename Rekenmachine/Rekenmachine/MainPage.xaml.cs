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
            string[] operators = { "+", "-", "x", "/","^" };
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
            string[] operators = { "+", "-", "x", "/", "^" };
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
                string[] operators = { "+", "-", "x", "/", "^" };
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
                string[] operators = { "+", "-", "x", "/", "^" };
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
                string[] operators = { "+", "-", "x", "/", "^" };
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
                string[] operators = { "+", "-", "x", "/", "^" };
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
            string[] operators = { "+", "-", "x", "/", "^" };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "(";
                textvalue.Text = currentvalue;
            }
        }
        public void parenthesisclosedClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.Length == 1))
            {

                string[] operators = { "+", "-", "x", "/", "^" };
                if (operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == (currentvalue.Count(a => a == ')') + 1))
                    {
                        currentvalue = currentvalue + ")";
                        textvalue.Text = currentvalue;
                    }
                }
            }
        }
        public void factorialClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "fact/(" + currentvalue + ")";
                        textvalue.Text = currentvalue;
                    }
                }
            }
        }
        public void divideClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    currentvalue = currentvalue + "/";
                    textvalue.Text = currentvalue;
                }
            }
        }
        public void exponentClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    currentvalue = currentvalue + "/";
                    textvalue.Text = currentvalue;
                }
            }
        }
        public void sevenClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "7";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "7";
                textvalue.Text = currentvalue;
            }

        }
        public void eightClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "8";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "8";
                textvalue.Text = currentvalue;
            }
        }
        public void nineClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "9";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "9";
                textvalue.Text = currentvalue;
            }
        }

        public void multipliedClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!((currentvalue.StartsWith("0") && currentvalue.Length == 1)))
            {

            }
        }
        public void poweroftenClicked(object sender, EventArgs e)
        {

        }
        public void fourClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "4";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "4";
                textvalue.Text = currentvalue;
            }
        }
        public void fiveClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "5";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "5";
                textvalue.Text = currentvalue;
            }
        }
        public void sixClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "6";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "6";
                textvalue.Text = currentvalue;
            }
        }

        public void minusClicked(object sender, EventArgs e)
        {

        }
        public void logarithmicClicked(object sender, EventArgs e)
        {

        }
        public void oneClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "1";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "1";
                textvalue.Text = currentvalue;
            }
        }
        public void twoClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "2";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "2";
                textvalue.Text = currentvalue;
            }
        }
        public void threeClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if ((currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                textvalue.Text = "3";
            }
            if (!currentvalue.EndsWith(")"))
            {
                currentvalue = currentvalue + "3";
                textvalue.Text = currentvalue;
            }
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
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0")))
            {
                if (!currentvalue.EndsWith(")"))
                {
                    currentvalue = currentvalue + "0";
                    textvalue.Text = currentvalue;
                }
            }
    
        }
        public void decimalClicked(object sender, EventArgs e)
        {

        }

        public void calculateClicked(object sender, EventArgs e)
        {

        }
    }
}
