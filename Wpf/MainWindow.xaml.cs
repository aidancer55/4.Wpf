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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble = rateEuro * sumEuro;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrn = Convert.ToDouble(rate2.Text);
            double sumGrn = Convert.ToDouble(sum2.Text);
            double resDouble = rateGrn * sumGrn;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateArm = Convert.ToDouble(rate3.Text);
            double sumArm = Convert.ToDouble(sum3.Text);
            double resDouble = rateArm * sumArm;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double lenInch = Convert.ToDouble(length.Text);
            double resInch = lenInch * 0.0254;
            result.Text = resInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double lenFoot = Convert.ToDouble(length1.Text);
            double resFoot = lenFoot * 0.3048;
            result1.Text = resFoot.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double lenMile = Convert.ToDouble(length2.Text);
            double resMile = lenMile * 1609.34;
            result2.Text = resMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double lenVerst = Convert.ToDouble(length3.Text);
            double resVerst = lenVerst * 0.00094;
            result3.Text = resVerst.ToString();
        }
    }
}
