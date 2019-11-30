using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Async_Await
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random m_Random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            MyLabel.Content = "Operation has started.";

            var task1 = HeavyWorkAsync();
            var task2 = HeavyWorkAsync();
            var task3 = HeavyWorkAsync();

            await Task.Delay(8000);
            MyLabel.Content = "Still running...";

            await Task.WhenAll(task1, task2, task3);
            sw.Stop();
            MyLabel.Content = "All 3 tasks completed in " + sw.ElapsedMilliseconds + " ms."; 
        }

        public void HeavyWork()
        {
            // generate value between 0 and 10
            double secondsToSleep = m_Random.NextDouble() * 10;
            // Na izpita smenihme na ( = 1 ). Tova beshe predlojenieto na Kim da testvame i toi ne beshe dovolen!
            // Da porabotq nad tova!! + vij koda po-gore!!


            // simulate important work
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(secondsToSleep));
        }

        public Task HeavyWorkAsync()
        {
            // run HeavyWork asynchronously
            return Task.Run(() => HeavyWork());
        }
    }
}
