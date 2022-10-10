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
using System.Threading;
using System.Windows.Threading;

namespace Practicum4_tadk2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string FileName;
        protected Thread newWindowThread;
        protected save Save;
        public MainWindow Aplication;
        public MainWindow()
        {
            InitializeComponent();
            this.FileName = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            newWindowThread = new Thread(new ThreadStart(fornewthread));
            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.IsBackground = true;
            newWindowThread.Start();
        }
        private void fornewthread()
        {
            Save = new save();
            Save.Show();
            
            Save.Closed += (sender2, e2) => Save.Dispatcher.InvokeShutdown();
            Dispatcher.Run();
        }

        private void taskList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
                image.Source = new BitmapImage(new Uri(Save.txt_filename.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public string Picture 
        {
            get { return "@C:/Users/vvgav/Desktop/JfSBHlK1PSc.jpg"; }
        }
    }
}
