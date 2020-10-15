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
using System.Windows.Shapes;
using System.IO;
using ClassLibrary3;

namespace ltr
{
   
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Proizv prv = new Proizv(TBa.Text, TBb.Text);
                label.Content = prv.getProizv();
            }
            catch
            {
                label.Content = "Введен неверный символ";
            }

        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            try
            {
                StreamWriter File = new StreamWriter("Slogenie.txt");
                File.WriteLine(label.Content);
                File.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                 ("Ошибка" + ex.Message);
            }
        }
    }
    
}
