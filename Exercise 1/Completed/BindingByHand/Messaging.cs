using System;
using System.Runtime.InteropServices;

namespace BindingByHand {
	public class Messaging {
		static internal System.Reflection.Assembly this_assembly = typeof(Messaging).Assembly;

		const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";

		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend(IntPtr receiever, IntPtr selector);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper(IntPtr receiever, IntPtr selector);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend_IntPtr(IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr(IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static global::System.Double Double_objc_msgSend(IntPtr receiver, IntPtr selector);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public extern static global::System.Double Double_objc_msgSendSuper(IntPtr receiver, IntPtr selector);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static void void_objc_msgSend_Double(IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_Double(IntPtr receiver, IntPtr selector, global::System.Double arg1);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static void void_objc_msgSend(IntPtr receiver, IntPtr selector);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper(IntPtr receiver, IntPtr selector);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static void void_objc_msgSend_bool(IntPtr receiver, IntPtr selector, bool arg1);
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_bool(IntPtr receiver, IntPtr selector, bool arg1);
	}
}
