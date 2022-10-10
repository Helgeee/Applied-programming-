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
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List()
        {
            InitializeComponent();
        }
        public List(string title) //: this()
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
                case "sqrt":
                    this.Close();
                    Sqrt sqrt = new Sqrt(btn.Header.ToString());
                    sqrt.ShowDialog();
                    break;
                case "list":
                    /*this.Close();
                    List list = new List(btn.Header.ToString());
                    list.ShowDialog();*/
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

            string surname = txt_surmave.Text == "" ? "Не задано" : txt_surmave.Text;
            string name = txt_name.Text == "" ? "Не задано" : txt_name.Text;
            string birthdate = txt_birthdate.Text == "" ? "Не задано" : txt_birthdate.Text;
            int cnt = listItems.Items.Cast<object>().Count() + 1;
            listItems.Items.Add(new Person {ID = cnt, Surname = surname, Name = name, Birthdate = birthdate });
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
