using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Threading;
using System.Diagnostics;

namespace course1._0.Geo__
{


    public class Geo
    {
            public double x, y, z;
        /// <summary>
        /// x - широта
        /// y - долгота
        /// z - высота
        /// </summary>
            public Geo()
            {
                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
                watcher.MovementThreshold = 1.0;
                watcher.TryStart(false, TimeSpan.FromMinutes(1.0));
                Thread.Sleep(100);

                if (watcher.Position.Location.IsUnknown == false)
                {
                    GeoCoordinate coor = watcher.Position.Location;
                    x = coor.Latitude; //55.154 
                y = coor.Longitude; //61.4291 
                z = coor.Altitude; // 218
                }
            }
    }
}
