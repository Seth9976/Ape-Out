using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FF RID: 255
	[StructLayout(2)]
	public struct TouchScreenKeyboard_InternalConstructorHelperArguments
	{
		// Token: 0x0600157E RID: 5502 RVA: 0x00053FD8 File Offset: 0x000521D8
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard_InternalConstructorHelperArguments()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard_InternalConstructorHelperArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr);
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_keyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "keyboardType");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_autocorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "autocorrection");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "multiline");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "secure");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "alert");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_characterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "characterLimit");
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0000BD3E File Offset: 0x00009F3E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, ref this));
		}

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr_keyboardType;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr_autocorrection;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr_secure;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeFieldInfoPtr_alert;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_characterLimit;

		// Token: 0x040010C2 RID: 4290
		[FieldOffset(0)]
		public uint keyboardType;

		// Token: 0x040010C3 RID: 4291
		[FieldOffset(4)]
		public uint autocorrection;

		// Token: 0x040010C4 RID: 4292
		[FieldOffset(8)]
		public uint multiline;

		// Token: 0x040010C5 RID: 4293
		[FieldOffset(12)]
		public uint secure;

		// Token: 0x040010C6 RID: 4294
		[FieldOffset(16)]
		public uint alert;

		// Token: 0x040010C7 RID: 4295
		[FieldOffset(20)]
		public int characterLimit;
	}
}
