using System;

namespace Torizon.Devices.Gpio
{
    // TODO from Microsoft GpioPin : IGpioPin, IDisposable
    public sealed class GpioPin
    {
        // TODO find a way to put this event
        //public event TypedEventHandler<GpioPin, GpioPinValueChangedEventArgs> ValueChanged;

        public TimeSpan DebounceTimeout { get; set; }
        public int PinNumber { get; }
        public GpioSharingMode SharingMode { get; }

        public GpioPin()
        {
        }

        public GpioPinDriveMode GetDriveMode()
        {
            return new GpioPinDriveMode();
        }

        public bool IsDriveModeSupported(GpioPinDriveMode driveMode)
        {
            return false; 
        }

        public GpioPinValue Read() 
        {
            return GpioPinValue.Low;
        }

        public void SetDriveMode(GpioPinDriveMode value) { }

        public void Write(GpioPinValue value) { }
    }
}
