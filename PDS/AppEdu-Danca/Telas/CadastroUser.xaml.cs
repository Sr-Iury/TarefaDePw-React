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

namespace AppEdu_Danca.Telas
{
    /// <summary>
    /// Lógica interna para CadastroUser.xaml
    /// </summary>
    public partial class CadastroUser : Window
    {
        public CadastroUser()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var LoginUser = new LoginUser();
            this.Close();
            LoginUser.ShowDialog();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
