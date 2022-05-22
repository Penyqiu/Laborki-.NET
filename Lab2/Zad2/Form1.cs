using System;
using System.Numerics;
using System.Windows.Forms;

namespace Zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            var arguments = ParseArguments(this.FirstArgument.Text, this.SecondArgument.Text);
            if (arguments is null) return;
            var (first, second) = arguments.Value;

            this.Result.Text = (first + second).ToString();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            var arguments = ParseArguments(this.FirstArgument.Text, this.SecondArgument.Text);
            if (arguments is null) return;
            var (first, second) = arguments.Value;

            this.Result.Text = (first - second).ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            var arguments = ParseArguments(this.FirstArgument.Text, this.SecondArgument.Text);
            if (arguments is null) return;
            var (first, second) = arguments.Value;

            this.Result.Text = (first * second).ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            var arguments = ParseArguments(this.FirstArgument.Text, this.SecondArgument.Text);
            if (arguments is null) return;
            var (first, second) = arguments.Value;

            this.Result.Text = (first / second).ToString();
        }

        (BigInteger, BigInteger)? ParseArguments(string first, string second)
        {
            if (! BigInteger.TryParse(first, out var firstArgument))
            {
                return null;
            }

            if (! BigInteger.TryParse(second, out var secondArgument))
            {
                return null;
            }

            return (firstArgument, secondArgument);
        }
    }
}