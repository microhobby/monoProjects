using System;

namespace Torizon.Devices.Gpio
{
    public enum GpioPinDriveMode
    {
        Input,
        InputPullDown,
        InputPullUp,
        Output,
        OutputOpenDrain,
        OutputOpenDrainPullUp,
        OutputOpenSource,
        OutputOpenSourcePullDown
    }
}
