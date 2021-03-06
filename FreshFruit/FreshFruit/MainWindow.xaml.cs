﻿using FreshFruit.controller;
using FreshFruit.model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller dion;
        public MainWindow()
        {
            InitializeComponent();

            Bucket cartFruit = new Bucket(2);
            BucketController bucketController = new BucketController(cartFruit, this);

            dion = new Seller("Dion", bucketController);
            ListBoxBucket.ItemsSource = cartFruit.findAll();
        }


        private void AddApple_Click(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            dion.addFruit(apple);
        }

        private void AddGrape_Click(object sender, RoutedEventArgs e)
        {
            Fruit grape = new Fruit("Grape");
            dion.addFruit(grape);
        }

        private void AddBanana_Click(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            dion.addFruit(banana);
        }

        private void AddOrange_Click(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            dion.addFruit(orange);
        }

        public void onFailed (string msg)
        {
            MessageBox.Show(msg, "Warning");
        }

        public void onSucceed (string msg)
        {
            ListBoxBucket.Items.Refresh();
        }

    }
}
