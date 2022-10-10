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

namespace Practicum4_tadk1
{
    /// <summary>
    /// Логика взаимодействия для Average.xaml
    /// </summary>
    public partial class Average : Window
    {
        public Average()
        {
            InitializeComponent();
        }
        public Average(string title) //: this()
        {
            InitializeComponent(); // Переопределяя конструктор мы должны вызывать метод InitializeComponent
            Title = title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Math.Abs(txt_n.Text != "" ? Int32.Parse(txt_n.Text) : 10);
            float[] values = new float[30];

            int max = n;
            int min = 1;
            Random rnd = new Random();

            for (int i = 0; i < 30; i++)
            {
                float d = rnd.Next(min, max);
                values[i] = d;
            }

            dataGrid.Items.Add(new MyRow(
                    String.Join(", ", values),
                    values.Length.ToString(),
                    Math.Round(values.Average(), 2).ToString()
                )
            );
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem btn = sender as MenuItem;

            switch (btn.Name)
            {
                case "averege":
                    /*Average window = new Average(btn.Header.ToString());
                    window.ShowDialog();*/
                    break;
                case "sqrt":
                    this.Close();
                    Sqrt sqrt = new Sqrt(btn.Header.ToString());
                    sqrt.ShowDialog();
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
    }
    class MyRow
    {
        public MyRow(string Id, string Vocalist, string Album)
        {
            this.arr = Id;
            this.cnt = Vocalist;
            this.avg = Album;
        }
        public string arr { get; set; }
        public string cnt { get; set; }
        public string avg { get; set; }
    }
}
