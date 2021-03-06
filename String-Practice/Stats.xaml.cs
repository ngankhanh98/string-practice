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
using System.Windows.Shapes;

namespace String_Practice
{
    /// <summary>
    /// Interaction logic for Stats.xaml
    /// </summary>
    public partial class Stats : Window
    {
        public Stats(Dictionary<string, int>dic)
        {
            InitializeComponent();
            string stats = "";

            foreach(var entry in dic)
            {
                stats += (entry.Key + " : ");
                stats += (entry.Value.ToString() + "\n");
            }
            txtStats.Text = stats;
        }

        
    }
}
