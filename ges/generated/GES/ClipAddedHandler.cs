// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void ClipAddedHandler(object o, ClipAddedArgs args);

	public class ClipAddedArgs : GLib.SignalArgs {
		public GES.Clip Clip{
			get {
				return (GES.Clip) Args [0];
			}
		}

	}
}
