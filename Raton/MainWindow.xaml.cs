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

namespace Raton{
    public partial class MainWindow : Window{
        bool isDrawing = false;
        Point startPoint;
        Line currentLine;
        public MainWindow() => InitializeComponent();
        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e){
            isDrawing = true;
            startPoint = e.GetPosition(dibujo);

            currentLine = new Line{
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                X1 = startPoint.X,
                Y1 = startPoint.Y,
                X2 = startPoint.X,
                Y2 = startPoint.Y
            };
            dibujo.Children.Add(currentLine);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e){
            if (isDrawing){
                Point currentPoint = e.GetPosition(dibujo);
                currentLine.X2 = currentPoint.X;
                currentLine.Y2 = currentPoint.Y;
            }
        }
           private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => isDrawing = false;
    }
}
