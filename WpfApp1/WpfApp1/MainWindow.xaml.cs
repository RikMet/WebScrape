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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int CalculateFunction(string inputtext)
        {
            
            var result = inputtext.Split(' ');
            var found = false;
            var listofResults = new List<int>();
            var calculatedNumber = 0;
            var returnnumber = 0;

            #region newRegion                               

            int counter = 0;
            while (true)
            {
                returnnumber = NumberProcesser(result, returnnumber, listofResults);
                counter++;
            }
            #endregion
            return returnnumber;
        }

        public int NumberProcesser(string[] result, int calculatedNumber, List<int> listofResults)
        {            
            foreach (var number in result)
            {
                if (number.StartsWith("+"))
                {
                    var resultingadditionnumber = number.Split('+');
                    calculatedNumber += int.Parse(resultingadditionnumber[1]);
                }
                if (number.StartsWith("-"))
                {
                    var resultingadditionnumber = number.Split('-');
                    calculatedNumber -= int.Parse(resultingadditionnumber[1]);
                }

                if (listofResults.IndexOf(calculatedNumber) != -1)
                {
                    var answer = calculatedNumber;
                    break;
                    
                }
                listofResults.Add(calculatedNumber);

            }

            return calculatedNumber;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var inputtext = MyTextBox.Text;
            MyTextBoxResult.Text =  "Result: " + CalculateFunction2(inputtext);
        }

        public int CalculateFunction2(string inputtext)
        {

            var result = inputtext.Split(' ');
            var found = false;
            var listofResults = new List<int>();
            var calculatedNumber = 0;
            var returnnumber = 0;

            #region newRegion                               

            int counter = 0;
           
            #endregion
            return returnnumber;
        }

        public int StringProcessor(string[] input)
        {

            foreach (var line in input)
            {
                bool exactlyTwo = false;
                bool exactlyThree = false;
                if (ExcactlyTwo(line))
                {
                    exactlyTwo = true;
                }

                if (ExcactlyThree(line))
                {
                    exactlyThree = true;
                }
            }


            return -1;
        }

        private bool ExcactlyTwo(string line)
        {
            throw new NotImplementedException();
        }

        private bool ExcactlyThree(string line)
        {
            throw new NotImplementedException();
        }

       
    }
}
