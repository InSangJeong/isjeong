using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    public class envelope<T> 
    {
        List<Rectangle<T>> shapes = null;

        public T StartX;
        public T StartY;
        public T EndX;
        public T EndY;

    
        Calculator<T> calcul = new Calculator<T>();

        public envelope()
        {
            if (shapes == null)
                shapes = new List<Rectangle<T>>();

            SetEnvelopeSize();
        }

        public envelope(T startx, T starty, T endx, T endy)
        {
            if (shapes == null)
                shapes = new List<Rectangle<T>>();

            Rectangle<T> newShape = new Rectangle<T>(startx, starty, endx, endy);
            shapes.Add(newShape);
            SetEnvelopeSize();
        }

        public void addShape(T startx, T starty, T endx, T endy)
        {
            Rectangle<T> newShape = new Rectangle<T>(startx, starty, endx, endy);
            shapes.Add(newShape);
            SetEnvelopeSize();
        }
        public void SetEnvelopeSize()
        {
            if (shapes.Count > 0)
            {
                //꼭 이렇게 해야하나?
                List<T> startXs = new List<T>();
                List<T> startYs = new List<T>();
                List<T> endXs = new List<T>();
                List<T> endYs = new List<T>();
                foreach (Rectangle<T> rect in shapes)
                {
                    startXs.Add(rect.StartX);
                    startYs.Add(rect.StartY);
                    endXs.Add(rect.EndX);
                    endYs.Add(rect.EndY);
                }

                this.StartX = calcul.Min(startXs);
                this.StartY = calcul.Min(startYs);
                this.EndX = calcul.Max(endXs);
                this.EndY = calcul.Max(endYs);
            }
            else
            {
                this.StartX = calcul.Min(null);
                this.StartY = calcul.Min(null);
                this.EndX = calcul.Max(null);
                this.EndY = calcul.Max(null);
            }
            
        }
        public void showSize()
        {
            Console.WriteLine(string.Format("sx :{0}, sy : {1}, ex : {2}, ey : {3}", this.StartX, this.StartY, this.EndX, this.EndY));
        }
    }
}
