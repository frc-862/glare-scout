package crc64c91c44f0dad89297;


public class UsbSerialPortInfo
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.os.Parcelable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_GetCreator:()Landroid/os/Parcelable$Creator;:__export__\n" +
			"n_describeContents:()I:GetDescribeContentsHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_writeToParcel:(Landroid/os/Parcel;I)V:GetWriteToParcel_Landroid_os_Parcel_IHandler:Android.OS.IParcelableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Hoho.Android.UsbSerial.Util.UsbSerialPortInfo, UsbSerialForAndroid", UsbSerialPortInfo.class, __md_methods);
	}


	public UsbSerialPortInfo ()
	{
		super ();
		if (getClass () == UsbSerialPortInfo.class)
			mono.android.TypeManager.Activate ("Hoho.Android.UsbSerial.Util.UsbSerialPortInfo, UsbSerialForAndroid", "", this, new java.lang.Object[] {  });
	}

	public UsbSerialPortInfo (com.hoho.android.usbserial.driver.UsbSerialPort p0)
	{
		super ();
		if (getClass () == UsbSerialPortInfo.class)
			mono.android.TypeManager.Activate ("Hoho.Android.UsbSerial.Util.UsbSerialPortInfo, UsbSerialForAndroid", "Hoho.Android.UsbSerial.Driver.IUsbSerialPort, UsbSerialForAndroid", this, new java.lang.Object[] { p0 });
	}

	public UsbSerialPortInfo (android.os.Parcel p0)
	{
		super ();
		if (getClass () == UsbSerialPortInfo.class)
			mono.android.TypeManager.Activate ("Hoho.Android.UsbSerial.Util.UsbSerialPortInfo, UsbSerialForAndroid", "Android.OS.Parcel, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public static android.os.Parcelable.Creator CREATOR = GetCreator ();

	public static android.os.Parcelable.Creator GetCreator ()
	{
		return n_GetCreator ();
	}

	private static native android.os.Parcelable.Creator n_GetCreator ();


	public int describeContents ()
	{
		return n_describeContents ();
	}

	private native int n_describeContents ();


	public void writeToParcel (android.os.Parcel p0, int p1)
	{
		n_writeToParcel (p0, p1);
	}

	private native void n_writeToParcel (android.os.Parcel p0, int p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
