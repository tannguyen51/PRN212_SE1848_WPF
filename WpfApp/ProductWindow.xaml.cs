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
using BussinessObject;
using Services;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService= new ProductService();
        public ProductWindow()
        {
            InitializeComponent();
            productService.GenerateSampleDataset();
            lvProduct.ItemsSource = productService.GetProducts();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSaveProduct_Click(object sender, RoutedEventArgs e)
        {
            Product p =  new Product();
            
            p.Id = int.Parse(txtId.Text);
            p.Name = txtName.Text;
            p.Quantity = int.Parse(txtQuantity.Text);
            p.Price = int.Parse(txtPrice.Text);

            bool kq = productService.SaveProduct(p);
            if (kq)
            {
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = productService.GetProducts();
            }

        }
    }
}
