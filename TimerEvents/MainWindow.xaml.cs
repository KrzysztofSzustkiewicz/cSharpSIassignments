using System;
using System.Runtime.Remoting.Channels;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace TimerEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private DispatcherTimer _timer;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 30);
            _timer.Tick += new EventHandler(dispatcherTimer_Tick);
            _timer.Start();
        }
        
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            myProgressBar.Value += 10;
            if (myProgressBar.Value >= 100)
            {
                _timer.Stop();
            }
        }

        private void gay_him(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Tick += new EventHandler(gayMessage);
            _timer.Start();
        }

        private void gayMessage(object sender, EventArgs e)
        {
            gaybutton.Content = "słodziaczek";
            _timer.Stop();
        }

        private void no_gay(object sender, MouseEventArgs mouseEventArgs)
        {
            _timer = new DispatcherTimer();
            _timer.Tick += new EventHandler(delegate(object sender1, EventArgs e1)
            {
                gaybutton.Content = "Adam to";
                _timer.Stop();
            });
            _timer.Start();
        }
    }
}
