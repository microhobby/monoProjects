using System;

namespace Torizon.Devices.Gpio
{
    public sealed class GpioController
    {
        public int PinCount { get; }

        public static GpioController GetDefault() 
        {
            return new GpioController();
        }

        public GpioPin OpenPin(Int32 pinNumber) 
        {
            return new GpioPin();
        }

        public GpioPin OpenPin(Int32 pinNumber, GpioSharingMode sharingMode) 
        {
             return new GpioPin();
        }

	public bool TryOpenPin(Int32 pinNumber, 
				GpioSharingMode sharingMode, 
				GpioPin pin, 
				GpioOpenStatus openStatus) 
	{
		return false;
	}
    }
}
