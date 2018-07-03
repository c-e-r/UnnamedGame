using System;
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

namespace UnnamedGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Console console = new Console();

        public MainWindow()
        {

            InitializeComponent();
            DataContext = new UnnamedDataContext();


            console.Inlines.Add(new Run("test") { Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 255)) });
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");
            console.Append("yes!\n");

            Path p;
            p = new Path();
            p.Stroke = Brushes.Black;
            p.Fill = Brushes.MediumAquamarine;
            p.StrokeThickness = 4;
            p.HorizontalAlignment = HorizontalAlignment.Left;
            p.VerticalAlignment = VerticalAlignment.Center;
            EllipseGeometry e = new EllipseGeometry();
            e.RadiusX = 25;
            e.RadiusY = 25;
            p.Data = e;
            //this.Content = p;

            Polygon poly = new Polygon();
            poly.Stroke = Brushes.Black;
            poly.Fill = Brushes.LightCyan;
            poly.StrokeThickness = 4;


            poly.Points.Add(new Point(50, 100));
            poly.Points.Add(new Point(100, 50));
            poly.Points.Add(new Point(200, 200));
            poly.Points.Add(new Point(200, 50));

            //this.Content = poly;
            //this.Content = new Hexagon(150, 150, 25).hex;

            int r = 10;
            int strokeWidth = 2;
            int x = 100;
            int y = 100;


            ObservableCollection<String> MyCollection = new ObservableCollection<String>();
            MyCollection.Add("asfsdg");
            MyCollection.Add("dgfsrgs");


             

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            console.Append("\no!");

        }

        private Boolean AutoScroll = true;

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;

            // User scroll event : set or unset auto-scroll mode
            if (e.ExtentHeightChange == 0)
            {   // Content unchanged : user scroll event
                if (scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
                {   // Scroll bar is in bottom
                    // Set auto-scroll mode
                    AutoScroll = true;
                }
                else
                {   // Scroll bar isn't in bottom
                    // Unset auto-scroll mode
                    AutoScroll = false;
                }
            }

            // Content scroll event : auto-scroll eventually
            if (AutoScroll && e.ExtentHeightChange != 0)
            {   // Content changed and auto-scroll mode set
                // Autoscroll
                scrollViewer.ScrollToVerticalOffset(scrollViewer.ExtentHeight);
            }
        }
    }
}
