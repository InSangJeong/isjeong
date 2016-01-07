using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generic
{
    public class Rectangle<T> : IRectangle<T>
    {
        public T start_x;
        public T StartX 
        {
            get
            {
                return start_x;
            }
            set
            {
                this.start_x = StartX;
                setSize();
            }
        }
        public T start_y;
        public T StartY
        {
            get
            {
                return start_y;
            }
            set
            {
                this.start_y = StartY;
                setSize();
            }
        }
        public T end_x;
        public T EndX
        {
            get
            {
                return end_x;
            }
            set
            {
                this.end_x = EndX;
                setSize();
            }
        }
        public T end_y;
        public T EndY
        {
            get
            {
                return end_y;
            }
            set
            {
                this.end_y = EndY;
                setSize();
            }
        }

        public T Width { get; private set; }
        public T Height { get; private set; }

        

        private Rectangle()
        {
        }
        public Rectangle(T startx, T starty, T endx, T endy)
        {
            this.start_x = startx;
            this.end_x = endx;
            this.start_y = starty;
            this.end_y = endy;

            setSize();
           
        }

        private void setSize()
        {
           // this.Width = Calculator<T>.Difference(this.EndX, this.StartX);
           // this.Height= Calculator<T>.Difference(this.EndY, this.StartY);
        }
        public void printSize()
        {
            //Console.WriteLine(string.Format("Width : {0}, Height : {1}", this.Width, this.Height));
        }
    }
}
