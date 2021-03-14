using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Simple_Calculator
{
    public partial class Form1 : Form
    {
        private StringBuilder _commandHelper = new StringBuilder();
        private List<long> _numbers = new List<long>();

        public Form1()
        {
            InitializeComponent();
        }

        private void RemoveZeroFromLabel()
        {
            if (ResultLbl.Text == "0")
                ResultLbl.Text = "";
        }

        private void EnableAllOperationButtons()
        {
            MinusBtn.Enabled = true;
            PlusBtn.Enabled = true;
            MultiplyBtn.Enabled = true;
            DivideBtn.Enabled = true;
            EqualslBtn.Enabled = true;
        }

        private void DisableAllOperationButtons()
        {
            MinusBtn.Enabled = false;
            PlusBtn.Enabled = false;
            MultiplyBtn.Enabled = false;
            DivideBtn.Enabled = false;
            EqualslBtn.Enabled = false;
        }

        private void AddDataToLabel(char data)
        {
            if (data == '+' || data == '-' || data == '/' || data == '*')
                ResultLbl.Text += " ";

            ResultLbl.Text += data;

            if (data == '+' || data == '-' || data == '/' || data == '*')
                ResultLbl.Text += " ";

        }
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('0');            
        }
        private void OneBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('1');


            ZeroBtn.Enabled = true;
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('2');

            ZeroBtn.Enabled = true;

        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('3');            

            ZeroBtn.Enabled = true;
        }
        private void FourBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('4');

            ZeroBtn.Enabled = true;

        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('5');

            ZeroBtn.Enabled = true;

        }
        private void SixBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('6');

            ZeroBtn.Enabled = true;

        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('7');

            ZeroBtn.Enabled = true;

        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('8');

            ZeroBtn.Enabled = true;

        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            RemoveZeroFromLabel();
            EnableAllOperationButtons();
            AddDataToLabel('9');            

            ZeroBtn.Enabled = true;

        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            ZeroBtn.Enabled = false;
            AddDataToLabel('/');
            DisableAllOperationButtons();
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            ZeroBtn.Enabled = false;
            AddDataToLabel('*');
            DisableAllOperationButtons();

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            ZeroBtn.Enabled = false;
            AddDataToLabel('+');
            DisableAllOperationButtons();

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            ZeroBtn.Enabled = false;
            AddDataToLabel('-');
            DisableAllOperationButtons();
        }

        private void PickNumbersAndCommands()
        {
            StringBuilder resultHelper = new StringBuilder();
            resultHelper.Append(ResultLbl.Text).Append(", ");

            int i = 0;

            if (resultHelper[0] == '-')
                i = 1;

            for (; i < resultHelper.Length; i++)
            {
                if (resultHelper[i] == '+' || resultHelper[i] == '-' || resultHelper[i] == '/' || resultHelper[i] == '*')
                {
                    _commandHelper.Append(resultHelper[i]);
                    resultHelper[i] = ',';
                }
            }

            string temp = resultHelper.ToString();
            foreach (string str in temp.Split(','))
            {
                if (long.TryParse(str, out long number))
                    _numbers.Add(number);
            }
            
        }
        private void EqualslBtn_Click(object sender, EventArgs e)
        {
            ZeroBtn.Enabled = false;
            PickNumbersAndCommands();            
            CalculatorHelper.CalculateDivideAndMultiply(ref _numbers, ref _commandHelper);
            string result = CalculatorHelper.CalculateSameCommands(_numbers, _commandHelper);
            _numbers.Clear();
            _commandHelper.Clear();
            ResultLbl.Text = result;

        }

        private void CEBtn_Click(object sender, EventArgs e)
        {
            if(!(ResultLbl.Text.Length == 1 && ResultLbl.Text == "0"))
            {
                ResultLbl.Text = "0";
                DisableAllOperationButtons();
                ZeroBtn.Enabled = false;
            }            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (ResultLbl.Text.Length == 1)
                ResultLbl.Text = "0";
            else
            {
                if (ResultLbl.Text[ResultLbl.Text.Length - 1] == ' ')
                {
                    ResultLbl.Text = ResultLbl.Text.Substring(0, ResultLbl.Text.Length - 3);
                    ZeroBtn.Enabled = true;
                    EnableAllOperationButtons();
                }
                else if (!(ResultLbl.Text.Length == 1 && ResultLbl.Text == "0"))
                {
                    ResultLbl.Text = ResultLbl.Text.Substring(0, ResultLbl.Text.Length - 1);

                    if (ResultLbl.Text[ResultLbl.Text.Length - 1] == ' ')
                    {
                        ZeroBtn.Enabled = false;
                        DisableAllOperationButtons();
                    }


                }

                if (ResultLbl.Text.Length == 0)
                    ResultLbl.Text = "0";


            }
        }
    }
}
