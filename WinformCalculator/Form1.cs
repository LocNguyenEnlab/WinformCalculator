using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCalculator
{
    public partial class Form1 : Form
    {
        public string _expressions = "";
        public string _numbers = "";
        public string _result = "";
        public string _operator = "";

        public Form1()
        {
            InitializeComponent();
        }

        #region methods
        public new void Show()
        {
            tbScreen.Text = _expressions + Environment.NewLine;
            tbScreen.Text += _result;
        }

        public void Calculate()
        {
            if (_numbers == "")
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _expressions = "";
                _result = "";
                Show();
            } else
            {
                if (_result == "")
                {
                    _result = _numbers;
                }
                else
                {
                    double x = Convert.ToDouble(_result);
                    double y = Convert.ToDouble(_numbers);
                    if (_operator == "+")
                    {
                        _result = (x + y).ToString();
                    }
                    else if (_operator == "-")
                    {
                        _result = (x - y).ToString();
                    }
                    else if (_operator == "*")
                    {
                        _result = (x * y).ToString();
                    }
                    else if (_operator == "/")
                    {
                        _result = (x / y).ToString();
                    }
                    
                }
                _expressions = _result;
                _numbers = "";
                _operator = "";
            }
        }
        #endregion

        #region events
        private void Btn1_Click(object sender, EventArgs e)
        {
            _expressions += "1";
            _numbers += "1";
            Show();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            _expressions += "2";
            _numbers += "2";
            Show();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            _expressions += "3";
            _numbers += "3";
            Show();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            _expressions += "4";
            _numbers += "4";
            Show();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            _expressions += "5";
            _numbers += "5";
            Show();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            _expressions += "6";
            _numbers += "6";
            Show();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            _expressions += "7";
            _numbers += "7";
            Show();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            _expressions += "8";
            _numbers += "8";
            Show();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            _expressions += "9";
            _numbers += "9";
            Show();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            _expressions += "0";
            _numbers += "0";
            Show();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (_expressions.Length != 0)
            {
                _expressions = _expressions.Remove(_expressions.Count() - 1);
                _numbers = _numbers.Remove(_numbers.Count() - 1);
            }
            else
            {
                _expressions = "";
                _numbers = "";
            }
            Show();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _expressions = "";
            _numbers = "";
            _result = "";
            Show();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (_expressions == "")
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else 
            {                
                Calculate();
                _expressions += "/";
                _operator = "/";
                Show();
            }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (_expressions == "")
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                Calculate();
                _expressions += "*";
                _operator = "*";
                Show();
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (_expressions == "")
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                Calculate();
                _expressions += "-";
                _operator = "-";
                Show();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_expressions == "")
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                Calculate();
                _expressions += "+";
                _operator = "+";
                Show();
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Calculate();
            _numbers = _result;
            Show();
            _result = "";
        }
        #endregion
    }
}
