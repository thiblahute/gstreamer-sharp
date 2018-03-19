// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Controller {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ControlPoint : IEquatable<ControlPoint> {

		public ulong Timestamp;
		public double Value;

		public static Gst.Controller.ControlPoint Zero = new Gst.Controller.ControlPoint ();

		public static Gst.Controller.ControlPoint New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Controller.ControlPoint.Zero;
			return (Gst.Controller.ControlPoint) Marshal.PtrToStructure (raw, typeof (Gst.Controller.ControlPoint));
		}

		[DllImport("libgstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_control_point_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_control_point_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public bool Equals (ControlPoint other)
		{
			return true && Timestamp.Equals (other.Timestamp) && Value.Equals (other.Value);
		}

		public override bool Equals (object other)
		{
			return other is ControlPoint && Equals ((ControlPoint) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Timestamp.GetHashCode () ^ Value.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Controller.ControlPoint boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Controller.ControlPoint.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Controller.ControlPoint (GLib.Value val)
		{
			return (Gst.Controller.ControlPoint) val.Val;
		}
#endregion
	}
}