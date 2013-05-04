﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using IndustrialMonitoring.Lib;
using SharedLibrary;
using Telerik.Windows.Controls.ChartView;
using IndustrialMonitoring.ProcessDataServiceReference;
using System.Threading;

namespace IndustrialMonitoring
{
    /// <summary>
    /// Interaction logic for ChartLiveData.xaml
    /// </summary>
    public partial class ChartLiveData : UserControl
    {
        private ItemsAIOViewModel _itemsAioViewModel = null;
        private Timer _timer;
        private ObservableCollection<Lib.ChartLiveData> _observableCollection;
        private ItemsLogLatestAIOViewModel _latestData;
        private ProcessDataServiceClient _processDataServiceClient;

        public ChartLiveData()
        {
            InitializeComponent();
        }

        public ItemsAIOViewModel ItemsAioViewModel
        {
            get { return _itemsAioViewModel; }
            set { _itemsAioViewModel = value; }
        }

        public Timer Timer
        {
            get { return _timer; }
            set { _timer = value; }
        }

        public ObservableCollection<Lib.ChartLiveData> ObservableCollection
        {
            get { return _observableCollection; }
            set { _observableCollection = value; }
        }

        public ItemsLogLatestAIOViewModel LatestData
        {
            get { return _latestData; }
            set { _latestData = value; }
        }

        public ProcessDataServiceClient ProcessDataServiceClient
        {
            get { return _processDataServiceClient; }
            set { _processDataServiceClient = value; }
        }

        private void InitChart()
        {
            Chart.Series.Clear();

            if (this.ItemsAioViewModel.ItemType == ItemType.Digital)
            {
                Chart.Series.Add(new AreaSeries());
                AreaSeries series =(AreaSeries) this.Chart.Series[0];
                series.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Date" };
                series.ValueBinding = new PropertyNameDataPointBinding() { PropertyName = "Value" };
                series.Stroke = Brushes.LightGreen;
                series.Fill = Brushes.LightGreen;
                series.StrokeThickness = 2;

                series.ItemsSource = ObservableCollection;
            }
            else if (this.ItemsAioViewModel.ItemType == ItemType.Analog)
            {
                
                Chart.Series.Add(new LineSeries());
                LineSeries series = (LineSeries)this.Chart.Series[0];
                series.CategoryBinding = new PropertyNameDataPointBinding() { PropertyName = "Date" };
                series.ValueBinding = new PropertyNameDataPointBinding() { PropertyName = "Value" };
                series.Stroke = Brushes.Green;
                series.StrokeThickness = 2;

                series.ItemsSource = ObservableCollection;
            }
        }

        private void AIO_OnLoaded(object sender, RoutedEventArgs e)
        {
            TextBlockTitle.Text = this.ItemsAioViewModel.ItemName;
        }

        public void Start()
        {
            Timer=new Timer(ShowLiveData,new object(), 0,this.ItemsAioViewModel.ShowInUITimeInterval * 1000);
            ObservableCollection=new ObservableCollection<Lib.ChartLiveData>();

            InitChart();
        }

        public void Stop()
        {
            Timer.Dispose();
        }

        private void ShowLiveData(object state)
        {
            LatestData = ProcessDataServiceClient.GeItemsLogLatest(this.ItemsAioViewModel.ItemId);

            if (LatestData == null)
            {
                return;
            }

            Dispatcher.Invoke(new Action(ShowLiveDataUI));
        }

        private void ShowLiveDataUI()
        {
            // TODO Parameter
            if (ObservableCollection.Count > 49)
            {
                ObservableCollection.RemoveAt(0);
            }

            ObservableCollection.Add(new Lib.ChartLiveData() { Value = Convert.ToDouble(LatestData.Value), Date = DateTime.Now });

            TextBlockValue.Text = LatestData.Value;  

            System.Diagnostics.Debug.WriteLine("Item Name : {0} , Count ObservableCollection : {1}",
                this.ItemsAioViewModel.ItemName, ObservableCollection.Count);
            
        }

    }
}
