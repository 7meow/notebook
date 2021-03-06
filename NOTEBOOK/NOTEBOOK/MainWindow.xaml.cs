﻿using System;
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

namespace NOTEBOOK
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // 存檔
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 反應
            if (result == true)
            {
                // 寫入檔案
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            // 開啟檔案
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 反應
            if (result == true)
            {
                // 寫入檔案
                Textarea.Text = System.IO.File.ReadAllText(dig.FileName);
            }

        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Clear();
        }


        private void Color_Click(object sender, RoutedEventArgs e)
        {

        }

        // 改變字體大小
        private void FontSmall_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 12;
        }

        private void FontNormal_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 24;
        }

        private void FontBig_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 36;
        }

        // 改變字體顏色
        private void Whtie_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.White;
            Textarea.Foreground = Brushes.Black;
        }

        private void DarkGray_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.DarkGray;
            Textarea.Foreground = Brushes.White;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.LightBlue;
            Textarea.Foreground = Brushes.DarkBlue;
        }

        private void Pink_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.LightPink;
            Textarea.Foreground = Brushes.DarkRed;
        }

       
    }
}
    