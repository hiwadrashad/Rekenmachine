using org.mariuszgromada.math.mxparser;
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
            Models.Model assignedValue = new Models.Model()
            {
                Value = "0"
            };
            BindingContext = assignedValue;
        }

        public void secondClicked(object sender, EventArgs e)
        {

        }

        public void piClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if (currentValue.StartsWith("0") && currentValue.Length == 1)
                {
                    textvalue.Text = "3.1416";
                }
                else
                {
                    string[] operators = { "+", "-", "x", "/", "^", "." };
                    if (operators.Any(a => currentValue.EndsWith(a)))
                    {
                        currentValue = currentValue + "3.1416";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }
        }

        public void eClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if (currentValue.StartsWith("0") && currentValue.Length == 1)
                {
                    textvalue.Text = "2.7183";
                }
                else
                {
                    string[] operators = { "+", "-", "x", "/", "^", "." };
                    if (operators.Any(a => currentValue.EndsWith(a)))
                    {
                        currentValue = currentValue + "2.7183";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }

        public void ceClicked(object sender, EventArgs e)
        {
            try
            {
                textvalue.Text = "0";

            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }

        public void deloneClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                if (currentValue.Length == 1)
                {
                    textvalue.Text = "0";

                }
                else
                {
                    currentValue = currentValue.Remove(currentValue.Length - 1);
                    textvalue.Text = currentValue;
 
                }
            }

            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }


        public void squareClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = "sqr(" + currentValue + ")";
                            textvalue.Text = currentValue;

                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }

        public void logClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = "1/(" + currentValue + ")";
                            textvalue.Text = currentValue;

                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

   
            }
        }

        public void absClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = "abs(" + currentValue + ")";
                            textvalue.Text = currentValue;

    
                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


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
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = "√(" + currentValue + ")";
                            textvalue.Text = currentValue;

                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

   
            }
        }

        public void parenthesisopenClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (currentValue.StartsWith("0") && currentValue.Length == 1)
            {
                textvalue.Text = "(";
            }
            string[] operators = { "+", "-", "x", "/", "^", "." };
            if (operators.Any(a => currentValue.EndsWith(a)))
            {
                currentValue = currentValue + "(";
                    textvalue.Text = currentValue;

                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void parenthesisclosedClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if (!(currentValue.Length == 1))
                {

                    string[] operators = { "+", "-", "x", "/", "^", "." };
                    if (operators.Any(a => currentValue.EndsWith(a)))
                    {
                        if (currentValue.Count(a => a == '(') == (currentValue.Count(a => a == ')') + 1))
                        {
                            currentValue = currentValue + ")";
                            textvalue.Text = currentValue;

                        }
                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void factorialClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = "fact(" + currentValue + ")";
                            textvalue.Text = currentValue;

   
                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void divideClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    currentValue = currentValue + "/";
                        textvalue.Text = currentValue;


                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void exponentClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
           if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    currentValue = currentValue + "/";
                        textvalue.Text = currentValue;

     
                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }
        }
        public void sevenClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "7";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "7";
                        textvalue.Text = currentValue;

         
                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }

        }
        public void eightClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "8";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "8";
                        textvalue.Text = currentValue;

       
                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void nineClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "9";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "9";
                        textvalue.Text = currentValue;


                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }

        public void multipliedClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!((currentValue.StartsWith("0") && currentValue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^" };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    currentValue = currentValue + "x";
                        textvalue.Text = currentValue;


                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }
        }
        public void poweroftenClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!((currentValue.StartsWith("0") && currentValue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = currentValue + "x";
                            textvalue.Text = currentValue;


                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void fourClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "4";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "4";
                        textvalue.Text = currentValue;


                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }
        }
        public void fiveClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "5";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "5";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void sixClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "6";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "6";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }

        public void minusClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!((currentValue.StartsWith("0") && currentValue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    currentValue = currentValue + "-";
                        textvalue.Text = currentValue;

     
                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void logarithmicClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = "log(" + currentValue + ")";
                            textvalue.Text = currentValue;


                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }
        public void oneClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "1";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "1";
                        textvalue.Text = currentValue;

         
                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

 
            }
        }
        public void twoClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "2";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "2";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

     
            }
        }
        public void threeClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
                if ((currentValue.StartsWith("0") && currentValue.Length == 1))
                {
                    textvalue.Text = "3";
                }
                else
                {
                    if (!currentValue.EndsWith(")"))
                    {
                        currentValue = currentValue + "3";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";


            }
        }

        public void plusClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!((currentValue.StartsWith("0") && currentValue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    currentValue = currentValue + "+";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }
        }

        public void inClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0") && currentValue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^" ,"."};
                if (!operators.Any(a => currentValue.EndsWith(a)))
                {
                    if (currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')'))
                    {
                        currentValue = "ln(" + currentValue + ")";
                            textvalue.Text = currentValue;

      
                        }
                    }
            }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

  
            }
        }
        public void negateClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (currentValue.StartsWith("-"))
            {
                currentValue = currentValue.Substring(1, currentValue.Length - 1);
                textvalue.Text = currentValue;
            }
            else
            {
                currentValue = "-" + currentValue;
                    textvalue.Text = currentValue;

                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }
        }
        public void zeroClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if (!(currentValue.StartsWith("0")))
            {
                if (!currentValue.EndsWith(")"))
                {
                    currentValue = currentValue + "0";
                        textvalue.Text = currentValue;

                    }
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }

        }
        public void decimalClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            var lastpart = currentValue.Split(new Char[] {'+','-','x','/','^','(',')' }).LastOrDefault();
            if (lastpart != null)
            {
                if (lastpart.Count(a => a == '.') < 1)
                {
                    currentValue = currentValue + ".";
                        textvalue.Text = currentValue;

         
                    }
                };
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                textvalue.Text = "Something went wrong";

            }
        }

        public void calculateClicked(object sender, EventArgs e)
        {
            try
            {
                var currentValue = textvalue.Text;
            if ((currentValue.Count(a => a == '(') == currentValue.Count(a => a == ')')))
            {
                
                Expression ex = new Expression (currentValue);
                var Value = ex.calculate();

                    textvalue.Text = Value.ToString();

                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                                textvalue.Text = "Something went wrong";


            }
        }
    }
}
