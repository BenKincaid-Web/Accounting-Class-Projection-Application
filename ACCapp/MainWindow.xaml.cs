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

namespace ACCwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            answer2();
        }

        private void answer2() {
            string answerTwoDefault;

            answerTwoDefault = answerTwo.Text = "35";
        }
        
        private void computeButton_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c, totalA, totalB, totalC;
            double cFinal, total, remA, remB, remC;
            bool a1, b1, c1;

            a1 = int.TryParse(answerOne.Text, out a);
            b1 = int.TryParse(answerTwo.Text, out b);
            c1 = int.TryParse(answerThree.Text, out c);

            cFinal = 20 - (c * 3.85);

            total = a + b + cFinal;

            totalA = 492;
            totalB = 420;
            totalC = 365;

            remA = totalA - total;
            remB = totalB - total;
            remC = totalC - total;

            answerA.Text = remA.ToString();
            answerB.Text = remB.ToString();
            answerC.Text = remC.ToString(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This program was created by Ben Kincaid in accordance with the 'Final Grade Projection Tool' developed by Professor Erwin Walker for Accounting 231 Section 04 for California State University of Dominguez Hills. WPF with c# was used to develop this program.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            answerOne.Clear();
            answer2();
            answerThree.Clear();
            answerA.Text = "";
            answerB.Text = "";
            answerC.Text = ""; 

        }
    }
}
