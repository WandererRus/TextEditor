using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;


namespace WpfApp5
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

        private void main_mi_create_Click(object sender, RoutedEventArgs e)
        {
            //rtb_editor.Document.Blocks.Clear();            
        }

        private void main_mi_open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() != null)
                {

                    StreamReader sr = new StreamReader(ofd.OpenFile());
                    FlowDocument fd = new FlowDocument();
                    string line;
                    if (sr != null)
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            fd.Blocks.Add(new Paragraph(new Run(line)));
                        }
                        rtb_editor.Document = fd;
                        sr.Close();
                    }
                }
                
            }
            catch
            {
                
            }
        }

        private void main_mi_save_Click(object sender, RoutedEventArgs e)
        {
           /* StreamWriter sw = new StreamWriter("document.txt", false ,Encoding.UTF8);
            foreach (Paragraph block in rtb_editor.Document.Blocks)
            {
                foreach (Run r in block.Inlines)
                {
                    sw.WriteLine(r.Text);
                }
            }             
            
            sw.Close();*/
        }

        private void main_mi_saveAs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void main_mi_settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void main_mi_print_Click(object sender, RoutedEventArgs e)
        {

        }

        private void main_mi_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void rtb_editor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
