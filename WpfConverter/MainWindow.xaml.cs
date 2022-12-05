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

namespace WpfConverter
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

        #region Валюта
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rateD.Text != "" && sumD.Text != "")
            {
                double rateDollar = Convert.ToDouble(rateD.Text);
                double sumDollar = Convert.ToDouble(sumD.Text);
                double resDouble = rateDollar * sumDollar;
                resSumD.Text = resDouble.ToString();
            }
            else
                resSumD.Text = "Ошибка.";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (rateE.Text != "" && sumD.Text != "")
            {
                double rateEuro = Convert.ToDouble(rateE.Text);
                double sumEuro = Convert.ToDouble(sumE.Text);
                double resDouble = rateEuro * sumEuro;
                resSumE.Text = resDouble.ToString();
            }
            else
                resSumE.Text = "Ошибка.";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (rateRinD.Text != "" && sumRinD.Text != "")
            {
                double rateRubInD = Convert.ToDouble(rateRinD.Text);
                double sumRubInD = Convert.ToDouble(sumRinD.Text);
                double resDouble = rateRubInD * sumRubInD;
                resSumRinD.Text = resDouble.ToString();
            }
            else
                resSumRinD.Text = "Ошибка";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (rateRinE.Text != "" && sumRinE.Text != "")
            {
                double rateRubInEuro = Convert.ToDouble(rateRinE.Text);
                double sumRubInEuro = Convert.ToDouble(sumRinE.Text);
                double resDouble = rateRubInEuro * sumRubInEuro;
                resSumRinE.Text = resDouble.ToString();
            }
            else
                resSumRinE.Text = "Ошибка";
        }

        #endregion
        #region метры
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (mM.Text != "")
                resMM.Text = (Convert.ToDouble(mM.Text) * 1000).ToString();
            else
                resMM.Text = "Ошибка";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (sM.Text != "")
                resSM.Text = (Convert.ToDouble(sM.Text)*100).ToString();
            else
                resSM.Text = "Ошибка";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (dM.Text != "")
                resDM.Text = (Convert.ToDouble(dM.Text)*10).ToString();
            else
                resDM.Text = "Ошибка";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (kM.Text != "")
                resKM.Text = (Convert.ToDouble(dM.Text)/1000).ToString();
            else
                resKM.Text = "Ошибка";
        }
        #endregion
    }
}
