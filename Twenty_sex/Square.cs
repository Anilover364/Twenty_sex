using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Twenty_sex
{
    internal class Square
    {
        protected int _x, _y,_side1;
        protected Brush _stroke;
        protected GeometryGroup _group;
        protected System.Windows.Shapes.Path _path;
        protected RectangleGeometry _square;
        public Brush Stroke 
        {
            get { return _stroke; }
            set { _stroke = value; _path.Stroke = _stroke; }
        }
        public int x => _x;
        public int y => _y;
        public int side1 => _side1;
        public Square(int x, int y, Canvas canvas)
        {
            _x = x;
            _y = y;
            _side1 = 150;
            _stroke = Brushes.Black;
            _path = new System.Windows.Shapes.Path();
            _square = new RectangleGeometry();
            _group = new GeometryGroup();
            _square.Rect = new System.Windows.Rect(0, 0, _side1, _side1);
            _path.Stroke = _stroke;
            _group.Children.Add(_square);
            _path.Data = _group;
            canvas.Children.Add(_path);
            Canvas.SetLeft(_path, _x);
            Canvas.SetTop(_path, _y);
        }
        public void SetLoc() 
        {
            Canvas.SetLeft(_path, _x);
            Canvas.SetTop(_path, _y);
        }
        public void Show()
        {
            _path.Visibility = Visibility.Visible;
        }
        public void Hide()
        {
            _path.Visibility = Visibility.Hidden;
        }
        public void MoveXY(int x, int y)
        {
            _x = x; _y = y;
            SetLoc();
        }
    }
    class Rect : Square 
    {

        public Rect(int x, int y, Canvas canvas) : base(x, y, canvas) 
        {
        _square.Rect=new System.Windows.Rect(0,0,_side1*2,side1);

        }
       
    }
    class RUSSIA : Rect 
    {
        //RectangleGeometry _rectBlue;
        //RectangleGeometry _rectRed;

  
        public RUSSIA(int x, int y, Canvas canvas) : base(x, y, canvas) 
        {
            //_rectBlue = new RectangleGeometry();
            //_rectRed = new RectangleGeometry();
            //_rectBlue.Rect = new System.Windows.Rect(0, 50, _side1 * 2, side1-100);
           
            //_group.Children.Add(_rectBlue);
            //_rectRed.Rect = new System.Windows.Rect(0, 100, _side1 * 2, side1 - 100);
            //_group.Children.Add(_rectRed);

            _path.Fill = new LinearGradientBrush(
        new GradientStopCollection
        {
            new GradientStop(Colors.White, 0.0),
            new GradientStop(Colors.Blue, 0.33),
            new GradientStop(Colors.Red, 0.66)
        },
        startPoint: new Point(0, 0),
        endPoint: new Point(0, 1));
        }
       
    }
}
