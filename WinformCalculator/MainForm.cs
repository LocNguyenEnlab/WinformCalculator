﻿using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformCalculator
{
    public partial class MainForm : Form
    {
        private StringBuilder _expressions;
        private StringBuilder _numbers;
        private StringBuilder _result;
        private StringBuilder _operator;


        public MainForm()
        {
            InitializeComponent();
            _expressions = new StringBuilder();
            _numbers = new StringBuilder();
            _result = new StringBuilder();
            _operator = new StringBuilder();
        }

        #region methods
        public new void Show()
        {
            tbScreen.Text = _expressions.ToString() + Environment.NewLine;
            tbScreen.Text += _result.ToString();
        }

        public void Calculate()
        {
            if (_numbers.Length == 0)
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _expressions.Clear();
                _result.Clear();
                Show();
            }
            else
            {
                if (_result.Length == 0)
                {
                    _result.Append(_numbers);
                }
                else
                {
                    double x = Convert.ToDouble(_result.ToString());
                    double y = Convert.ToDouble(_numbers.ToString());
                    if (_operator.ToString() == "+")
                    {
                        _result.Clear();
                        _result.Append((x + y).ToString());
                    }
                    else if (_operator.ToString() == "-")
                    {
                        _result.Clear();
                        _result.Append((x - y).ToString());
                    }
                    else if (_operator.ToString() == "*")
                    {
                        _result.Clear();
                        _result.Append((x * y).ToString());
                    }
                    else if (_operator.ToString() == "/")
                    {
                        _result.Clear();
                        _result.Append((x / y).ToString());
                    }
                    
                }
                _numbers.Clear();
                _operator.Clear();
            }
        }
        #endregion

        #region events
        private void Btn1_Click(object sender, EventArgs e)
        {
            _expressions.Append("1");
            _numbers.Append("1");
            Show();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            _expressions.Append("2");
            _numbers.Append("2");
            Show();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            _expressions.Append("3");
            _numbers.Append("3");
            Show();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            _expressions.Append("4");
            _numbers.Append("4");
            Show();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            _expressions.Append("5");
            _numbers.Append("5");
            Show();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            _expressions.Append("6");
            _numbers.Append("6");
            Show();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            _expressions.Append("7");
            _numbers.Append("7");
            Show();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            _expressions.Append("8");
            _numbers.Append("8");
            Show();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            _expressions.Append("9");
            _numbers.Append("9");
            Show();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            _expressions.Append("0");
            _numbers.Append("0");
            Show();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (_numbers.Length != 0)
            {
                _expressions.Remove(_expressions.Length - 1, 1);
                _numbers.Remove(_numbers.Length - 1, 1);
            }
            else if (_expressions.Length != 0)
            {
                _expressions.Remove(_expressions.Length - 1, 1);
            }
            Show();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _expressions.Clear();
            _numbers.Clear();
            _result.Clear();
            Show();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (_expressions.Length == 0)
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {                
                Calculate();
                _expressions.Clear();
                _expressions.Append(_result);
                _expressions.Append("/");
                _operator.Append("/");
                Show();
            }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (_expressions.Length == 0)
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                Calculate();
                _expressions.Clear();
                _expressions.Append(_result);
                _expressions.Append("*");
                _operator.Append("*");
                Show();
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (_expressions.Length == 0)
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                Calculate();
                _expressions.Clear();
                _expressions.Append(_result);
                _expressions.Append("-");
                _operator.Append("-");
                Show();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_expressions.Length == 0)
            {
                MessageBox.Show("Invalid expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                Calculate();
                _expressions.Clear();
                _expressions.Append(_result);
                _expressions.Append("+");
                _operator.Append("+");
                Show();
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Calculate();
            _numbers.Clear();
            _numbers.Append(_result);
            Show();
            _result.Clear();
        }
        #endregion
    }
}
