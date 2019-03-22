using System;
namespace Torizon.Devices.Gpio
{
    public enum GpioOpenStatus
    {
	PinOpened,
	PinUnavailable,
	SharingViolation,
	MuxingConflict,
	UnknownError
    }
}
