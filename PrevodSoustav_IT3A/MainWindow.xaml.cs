using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PrevodSoustav_IT3A
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

    private void btnPrevod_Click(object sender, RoutedEventArgs e)
    {
      string binText = txtVstup.Text;
      if (JeBinarni(binText))
      {
        txtVystup.Text = BinNaDec(binText).ToString();
      }
      else
      {
        MessageBox.Show("NENI");
      }
    }

    private long BinNaDec(string text)
    {
      var opacne = text.Reverse().ToArray();
      long hodnota = 0;
      for(int i = 0; i < opacne.Length; i++)
      {
        hodnota += int.Parse(opacne[i].ToString()) * Convert.ToInt32(Math.Pow(2,i));
      }
      return hodnota;
    }

    private bool JeBinarni(string text)   // 10101010101010
    {
      foreach(var znak in text)
      {
        if(znak != '1' && znak != '0')
        {
          return false;
        }
      }
      return true;
    }
  }
}
