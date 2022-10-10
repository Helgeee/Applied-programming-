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

namespace Practicum4_tadk1
{
    /// <summary>
    /// Логика взаимодействия для Sqrt.xaml
    /// </summary>
    public partial class Sqrt : Window
    {
        public Sqrt()
        {
            InitializeComponent();
        }
        public Sqrt(string title) //: this()
        {
            InitializeComponent(); // Переопределяя конструктор мы должны вызывать метод InitializeComponent
            Title = title;
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem btn = sender as MenuItem;

            switch (btn.Name)
            {
                case "averege":
                    this.Close();
                    Average window = new Average(btn.Header.ToString());
                    window.ShowDialog();
                    break;
                case "sqrt":/*
                    this.Close();
                    Sqrt sqrt = new Sqrt(btn.Header.ToString());
                    sqrt.ShowDialog();*/
                    break;
                case "list":
                    this.Close();
                    List list = new List(btn.Header.ToString());
                    list.ShowDialog();
                    break;
                case "files":
                    this.Close();
                    Files files = new Files(btn.Header.ToString());
                    files.ShowDialog();
                    break;
                case "exit":
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = txt_a.Text != "" ? Double.Parse(txt_a.Text) : 1.0;
            double b = txt_b.Text != "" ? Double.Parse(txt_b.Text) : 1.0;
            double c = txt_b.Text != "" ? Double.Parse(txt_b.Text) : 1.0;
            double b2 = Math.Pow(b, 2);
            double D = Math.Pow(b, 2) - (4 * a * c);

            if (D > 0)
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(D))/(2*a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                result.Text = "Ответ:\n";
                result.Text += "x1 = " + Math.Round(x1, 2).ToString() + "\n";
                result.Text += "x2 = " + Math.Round(x2, 2).ToString() + "\n";

            }
            else if (D < 0)
            {
                result.Text = "Ответ:\n";
                result.Text += "уравнение не имеет корней\n";
            }
            else if (D == 0) {
                double x = -b / (2 * a);
                result.Text = "Ответ:\n";
                result.Text += "x = " + x.ToString() + "\n";
            }
        }
    }
}
