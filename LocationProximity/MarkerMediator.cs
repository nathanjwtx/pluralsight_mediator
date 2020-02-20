using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LocationProximity
{
    public class MarkerMediator
    {
        private List<Marker> _markers = new List<Marker>();

        public Marker CreateMarker()
        {
            var m = new Marker();
            m.SetMediator(this);
            _markers.Add(m);
            return m;
        }

        public void Send(Point location, Marker marker)
        {
            _markers.Where(m => m != marker).ToList().ForEach(m => m.ReceiveLocation(location));
        }
    }
}
