// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void DeepNotifyHandler(object o, DeepNotifyArgs args);

	public class DeepNotifyArgs : GLib.SignalArgs {
		public GLib.Object PropObject{
			get {
				return (GLib.Object) Args [0];
			}
		}

		public IntPtr Prop{
			get {
				return (IntPtr) Args [1];
			}
		}

	}
}
