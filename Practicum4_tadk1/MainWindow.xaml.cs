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

namespace Practicum4_tadk1
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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            
            switch (btn.Name) {
                case "averege":
                    Average window = new Average(btn.Content.ToString());
                    window.ShowDialog();
                    break;
                case "sqrt":
                    Sqrt sqrt = new Sqrt(btn.Content.ToString());
                    sqrt.ShowDialog();
                    break;
                case "list":
                    List list = new List(btn.Content.ToString());
                    list.ShowDialog();
                    break;
                case "files":
                    Files files = new Files(btn.Content.ToString());
                    files.ShowDialog();
                    break;                
                default:
                    break;
            }
            
            
            // Код после метода ShowDialog выполнится только тогда, кода диалоговое окно закроется.
        }

    }
}
