using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplestMathGame
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();
        int answer;
        int totalQuestions = 0;
        StringBuilder correct = new StringBuilder();
        StringBuilder falsed = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            GenerateQuestions();
        }

        private void GenerateQuestions()
        {
            AnswerTextBox.Clear();
            int a = randomNumber.Next(11), b = randomNumber.Next(11); 
            int mathOpperator = randomNumber.Next(4);
            switch (mathOpperator)
            {
                //mathOpperator is +
                case 0:
                    answer = a + b;
                    MathQuestionLbl.Text = $"{a} + {b} =   ?";
                    break;
                //mathOpperator is -
                case 1:
                    answer = a - b;
                    MathQuestionLbl.Text = $"{a} - {b} =   ?";
                    break;
                //mathOpperator is *
                case 2:
                    answer = a * b;
                    MathQuestionLbl.Text = $"{a} * {b} =   ?";
                    break;
                //mathOpperator is /
                case 3:
                    if (b == 0)
                        b = randomNumber.Next(1, 11);
                    answer = a / b;
                    MathQuestionLbl.Text = $"{a} / {b} =   ?";
                    break;
                default:
                    throw new NotImplementedException(); 
            }
            PrintStatus();
        }

        private void PrintStatus()
        {
            CorrectDashLbl.Text = correct.ToString();
            FalseDashLbl.Text = falsed.ToString();
            TotalNumLbl.Text = totalQuestions.ToString();
        }

        private void CheckAnswerBtn_Click(object sender, EventArgs e)
        {
            totalQuestions++;
            short userAnswer;
            if(Int16.TryParse(AnswerTextBox.Text, out userAnswer) && (userAnswer == answer))
            {
                correct.Append("/");
                PrintStatus();
            }
            else
            {
                falsed.Append("/");
                PrintStatus();
            }
            GenerateQuestions();
        }

        private void AnswerTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CheckAnswerBtn_Click(sender, e);
        }
    }
}
