﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ScriptsClassLibrary;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bacteria
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void ButtonGenerater_Click(object sender, RoutedEventArgs e) => VariableMover.MethodForMovingVariables(CenterScrin_GridNull, TextBoxGenerator, TextBlockGenerator);
    }
}