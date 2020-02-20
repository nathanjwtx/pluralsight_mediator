using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocationProximity
{
    public class Marker : Label
    {
        private MarkerMediator _mediator;
        private Point mouseDownLocation;

        internal void SetMediator(MarkerMediator mediator)
        {
            this._mediator = mediator;
        }

        public Marker()
        {
            Text = "{Drag me}";
            TextAlign = ContentAlignment.MiddleCenter;
            MouseDown += OnMouseDown;
            MouseMove += OnMouseMove;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Text = Location.ToString();
                Left = e.X + Left - mouseDownLocation.X;
                Top = e.Y + Top - mouseDownLocation.Y;
                _mediator.Send(Location, this);
            }
        }

        public void ReceiveLocation(Point location)
        {
            var distance = CalcDistance(location);
            if (distance < 100 && BackColor != Color.Red)
            {
                BackColor = Color.Red;
            }
            else if (distance >= 100 && BackColor != Color.Green)
            {
                BackColor = Color.Green;
            }

            // local function
            double CalcDistance(Point point) =>
                Math.Sqrt(Math.Pow(point.X - Location.X, 2) + Math.Pow(point.Y - Location.Y, 2));
        }
    }
}