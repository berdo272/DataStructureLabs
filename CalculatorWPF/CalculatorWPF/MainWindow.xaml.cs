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
using CalculatorWPF;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorViewModel cvm;
        public MainWindow()
        {
           InitializeComponent();
           cvm = new CalculatorViewModel();

           DataContext = cvm;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int Box1Length;
            int Box2Length;
            bool tryparse1;
            bool tryparse2;
            int temp1;
            int temp2;

            Box1Length = this.textBox.GetLineLength(0);
            Box2Length = this.textBox1.GetLineLength(0);

            tryparse1 = Int32.TryParse(this.textBox.GetLineText(0) , out temp1 );
            tryparse2 = Int32.TryParse(this.textBox1.GetLineText(0), out temp2);

            cvm._firstNumber = temp1;
            cvm._secondNumber = temp2;

            if (Box1Length > 0 && Box2Length > 0 && this.listBox.SelectedItem != null && tryparse1 == true && tryparse2 == true)
            {
                Calulations calc = new Calulations();
                int DataCatch;
                
                cvm._firstNumber = Convert.ToInt32(this.textBox.GetLineText(0));
                cvm._secondNumber = Convert.ToInt32(this.textBox1.GetLineText(0));
                cvm._userChosenMathOperator = this.listBox.SelectedItem.ToString();

                DataCatch = (calc.CalculateOutput(cvm._firstNumber.Value, cvm._secondNumber.Value, cvm._userChosenMathOperator));
                cvm._output = DataCatch;

                MessageBox.Show("The result of your calculation is " + cvm._OutputToString);
            }
            else
            {
                MessageBox.Show("Please enter a valid value for both numbers and select an operator before calculating.");
            }
        }
    }
    
}
