﻿using CalculadoraGa1.Model;
using CalculadoraGa1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CalculadoraGa1
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            string[] lista = { "abc", "abc", "abcd" };
            ItemsListView.ItemsSource = lista;

        }
    }
}
