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
using System.Windows.Xps.Packaging;
using System.Windows.Xps;
using System.IO;
using GemBox.Document;


namespace Practicum4_tadk1
{
    /// <summary>
    /// Логика взаимодействия для Files.xaml
    /// </summary>
    public partial class Files : Window
    {
        
        public Files()
        {
            InitializeComponent();
        }
        public Files(string title) //: this()
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
                    this.Close();
                    List list = new List(btn.Header.ToString());
                    list.ShowDialog();
                    break;
                case "files":
                    /*this.Close();
                    Files files = new Files(btn.Header.ToString()); openFile
                    files.ShowDialog();*/
                    break;
                case "exit":
                    this.Close();
                    break;
                case "openFile":

                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.DefaultExt = ".txt";
                    dlg.Filter = "Text documents (.txt)|*.txt";
                    bool? result = dlg.ShowDialog();

                    if (result == true)

                    {

                        if (dlg.FileName.Length > 0)

                        {
                            
                            try {
                                ComponentInfo.SetLicense("FREE-LIMITED-KEY");

                                DocumentModel doc = DocumentModel.Load(dlg.FileName, LoadOptions.TxtDefault);
                                reader.Document = doc.ConvertToXpsDocument(SaveOptions.XpsDefault).GetFixedDocumentSequence();
                            }
                            catch (Exception error) {
                                MessageBox.Show("Ошибка при открытии файла:" + error.Message);
                            }
                            
                        }

                    }
                    /*var document = DocumentModel.Load("Document.docx", LoadOptions.DocxDefault);

                    // Convert DOCX to PDF.
                    document.Save("Document.pdf");
                    reader.Document = document.ConvertToXpsDocument(SaveOptions.XpsDefault).GetFixedDocumentSequence();*/
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
