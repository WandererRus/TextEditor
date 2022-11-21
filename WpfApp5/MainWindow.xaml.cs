﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
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
            rtb_editor.Document.Blocks.Clear();            
        }

        private void main_mi_open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FlowDocument fd = new FlowDocument();
                StreamReader sr = new StreamReader("document.txt");
                while (sr.ReadLine() != null)
                {
                    fd.Blocks.Add(new Paragraph ( new Run(sr.ReadLine())));
                }
                rtb_editor.Document = fd;
            }
            catch
            {
                
            }
        }

        private void main_mi_save_Click(object sender, RoutedEventArgs e)
        {

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
