using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Calculator;
using System.Windows.Media.Animation;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string expression = "";
        string ans = "0";
        string display = "";
        public MainWindow()
        {
            InitializeComponent();
            Expression.Text = display;
            Output.Text = ans;
        }
        private void Num_Click(object sender, RoutedEventArgs e)
        {
            if (expression == "0")
                expression = "";
            string button = sender.ToString();
            string key = button.Substring(button.Length - 1, 1);
            string value = ButtonMapping.NumberMapping[key];
            expression += value;
            display = expression;
            Expression.Text = display;
            Output.Text = ans;
        }
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            string button = sender.ToString();
            string key = button.Substring(button.Length - 1, 1);
            string value = ButtonMapping.OperatorMapping[key];
            expression += value;
            display = expression;
            Expression.Text = display;
            Output.Text = ans;
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (expression.Length > 1)
                expression = expression.Substring(0, expression.Length - 1);
            else
            {
                expression = "";
                ans = "0";
            }
            Expression.Text = expression;
            Output.Text = ans;
        }

        private void Eq_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            ans = dt.Compute(expression, "").ToString();
            expression = ans;
            Output.Text = ans;
            Expression.Text = expression;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            expression = "";
            ans = "0";
            Output.Text = ans;
            Expression.Text = expression;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
