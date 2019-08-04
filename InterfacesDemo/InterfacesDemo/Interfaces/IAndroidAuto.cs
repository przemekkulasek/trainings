using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo.Interfaces
{
    public interface IAndroidAuto : IMultimediaSystem
    {
        void UseAndroidMaps();
        void RunAndroidApp(string appName);
    }
}
