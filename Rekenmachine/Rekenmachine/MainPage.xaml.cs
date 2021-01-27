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
            Models.Model assignedvalue = new Models.Model()
            {
                value = "0"
            };
            BindingContext = assignedvalue;
        }

        public void secondClicked(object sender, EventArgs e)
        {
            //Models.Model assignedvalue = new Models.Model()
            //{
            //    value = "This works"
            //};
            //BindingContext = assignedvalue;
        }

        public void piClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("0") && currentvalue.Length == 1)
            {
                textvalue.Text = "3.1416";
            }
            string[] operators = { "+", "-", "x", "/","^", "." };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "3.1416";
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
            }
        }

        public void eClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("0") && currentvalue.Length == 1)
            {
                textvalue.Text = "2.7183";
            }
            string[] operators = { "+", "-", "x", "/", "^", "." };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "2.7183";
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
            }
        }

        public void ceClicked(object sender, EventArgs e)
        {
            Models.Model assignedvalue = new Models.Model()
            {
                value = "0"
            };
            BindingContext = assignedvalue;
        }

        public void deloneClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                if (currentvalue.Length == 1)
                {
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = "0"
                    };
                    BindingContext = assignedvalue;
                }
                else
                {
                    currentvalue = currentvalue.Remove(currentvalue.Length - 1);
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
                }
            }


        }


        public void squareClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "sqr(" + currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
                    }
                }
            }

        }

        public void logClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "1/(" + currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
                    }
                }
            }
        }

        public void absClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "abs/(" + currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
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
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "√/(" + currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
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
            string[] operators = { "+", "-", "x", "/", "^", "." };
            if (operators.Any(a => currentvalue.EndsWith(a)))
            {
                currentvalue = currentvalue + "(";
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
            }
        }
        public void parenthesisclosedClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.Length == 1))
            {

                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == (currentvalue.Count(a => a == ')') + 1))
                    {
                        currentvalue = currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
                    }
                }
            }
        }
        public void factorialClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "fact/(" + currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
                    }
                }
            }
        }
        public void divideClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    currentvalue = currentvalue + "/";
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
                }
            }
        }
        public void exponentClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
           if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    currentvalue = currentvalue + "/";
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
            }
        }

        public void multipliedClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!((currentvalue.StartsWith("0") && currentvalue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^" };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    currentvalue = currentvalue + "x";
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
                }
            }
        }
        public void poweroftenClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!((currentvalue.StartsWith("0") && currentvalue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = currentvalue + "x";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
                    }
                }
            }
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
            }
        }

        public void minusClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!((currentvalue.StartsWith("0") && currentvalue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    currentvalue = currentvalue + "-";
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
                }
            }
        }
        public void logarithmicClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "log/(" + currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
                    }
                }
            }
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
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
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
            }
        }

        public void plusClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!((currentvalue.StartsWith("0") && currentvalue.Length == 1)))
            {
                string[] operators = { "+", "-", "x", "/", "^", "." };
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    currentvalue = currentvalue + "+";
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
                }
            }
        }

        public void inClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0") && currentvalue.Length == 1))
            {
                string[] operators = { "+", "-", "x", "/", "^" ,"."};
                if (!operators.Any(a => currentvalue.EndsWith(a)))
                {
                    if (currentvalue.Count(a => a == '(') == currentvalue.Count(a => a == ')'))
                    {
                        currentvalue = "ln/(" + currentvalue + ")";
                        Models.Model assignedvalue = new Models.Model()
                        {
                            value = currentvalue
                        };
                        BindingContext = assignedvalue;
                    }
                }
            }
        }
        public void negateClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (currentvalue.StartsWith("-"))
            {
                currentvalue = currentvalue.Substring(1, currentvalue.Length - 1);
                textvalue.Text = currentvalue;
            }
            else
            {
                currentvalue = "-" + currentvalue;
                Models.Model assignedvalue = new Models.Model()
                {
                    value = currentvalue
                };
                BindingContext = assignedvalue;
            }
        }
        public void zeroClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            if (!(currentvalue.StartsWith("0")))
            {
                if (!currentvalue.EndsWith(")"))
                {
                    currentvalue = currentvalue + "0";
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
                }
            }
    
        }
        public void decimalClicked(object sender, EventArgs e)
        {
            var currentvalue = textvalue.Text;
            var lastpart = currentvalue.Split(new Char[] {'+','-','x','/','^','(',')' }).LastOrDefault();
            if (lastpart != null)
            {
                if (lastpart.Count(a => a == '.') < 1)
                {
                    currentvalue = currentvalue + ".";
                    Models.Model assignedvalue = new Models.Model()
                    {
                        value = currentvalue
                    };
                    BindingContext = assignedvalue;
                }
            };
        }

        public void calculateClicked(object sender, EventArgs e)
        {

        }
    }
}
