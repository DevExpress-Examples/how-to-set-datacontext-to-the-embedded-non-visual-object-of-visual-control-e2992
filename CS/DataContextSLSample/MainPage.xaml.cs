using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DataContextSLSample {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            string connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb;Persist Security Info=True";
            DataStoreModel sourceData = new DataStoreModel(connection);
            DataStoreViewModel sourceDataModel = new DataStoreViewModel(sourceData);

            this.MyVisualControl.DataContext = sourceDataModel;
        }
    }
}
