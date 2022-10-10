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
using Microsoft.Win32;
using System.Threading;

namespace Practicum4_tadk2
{
    /// <summary>
    /// Логика взаимодействия для save.xaml
    /// </summary>
    public partial class save : Window
    {
        public save()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "Изображения (.jpg)|*.jpg";
            
            if ((bool) dlg.ShowDialog()) 
            {
                if (dlg.FileName.Length > 0) {
                    txt_filename.Text = dlg.FileName;
                }
            }
        }
    }
}
