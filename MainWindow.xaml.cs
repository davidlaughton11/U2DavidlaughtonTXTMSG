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

namespace U2DavidLaughtonTXTMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string intput;

        public MainWindow()
        {
            InitializeComponent();
        }
        // If statements
        // Spilt in textbox with string   
        
      
        private void BtnShortToLong_Click(object sender, RoutedEventArgs e)
        {
            //Make a textbox and get the text
            //Use .replace to replace the text 
            string input = txtShortformInput.Text;
            input = input.Replace("CUZ", "because"); Console.WriteLine(input);
            input = input.Replace("CU", "See you"); Console.WriteLine(input);
            input = input.Replace(":-)", "I’m happy"); Console.WriteLine(input);
            input = input.Replace(":-(", "I’m unhappy"); Console.WriteLine(input);
            input = input.Replace(";-)", "wink"); Console.WriteLine(input);
            input = input.Replace(":-P", "stick out my tongue"); Console.WriteLine(input);
            input = input.Replace("(˜.˜)", "sleepy"); Console.WriteLine(input);
            input = input.Replace("TA", "totally awesome"); Console.WriteLine(input);
            input = input.Replace("CCC", "Canadian Computing Competition"); Console.WriteLine(input);
            input = input.Replace("TTYL", "talk to you later"); Console.WriteLine(input);
            input = input.Replace("TY", "thank-you"); Console.WriteLine(input);
            input = input.Replace("YW", "you’re welcome"); Console.WriteLine(input);
            

            string output = input;
            txtOutput.Content = output;
        }
    }
}
