using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo.Interfaces
{
    public interface IMultimediaSystem
    {
        int NumOfSpeakers { get; }
        int ScreenSize { get; }
        int Volume { get; set; }
        void VolumeUp();
        void VolumeDown();
    }
}
