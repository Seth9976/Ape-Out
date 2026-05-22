using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014E RID: 334
	[StructLayout(2)]
	public struct InputRecord
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x0008D928 File Offset: 0x0008BB28
		// Note: this type is marked as 'beforefieldinit'.
		static InputRecord()
		{
			Il2CppClassPointerStore<InputRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InputRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRecord>.NativeClassPtr);
			InputRecord.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "EventType");
			InputRecord.NativeFieldInfoPtr_KeyDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "KeyDown");
			InputRecord.NativeFieldInfoPtr_RepeatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "RepeatCount");
			InputRecord.NativeFieldInfoPtr_VirtualKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualKeyCode");
			InputRecord.NativeFieldInfoPtr_VirtualScanCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualScanCode");
			InputRecord.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "Character");
			InputRecord.NativeFieldInfoPtr_ControlKeyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "ControlKeyState");
			InputRecord.NativeFieldInfoPtr_pad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad1");
			InputRecord.NativeFieldInfoPtr_pad2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad2");
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000081E9 File Offset: 0x000063E9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeFieldInfoPtr_EventType;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeFieldInfoPtr_KeyDown;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeFieldInfoPtr_RepeatCount;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeFieldInfoPtr_VirtualKeyCode;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeFieldInfoPtr_VirtualScanCode;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeFieldInfoPtr_ControlKeyState;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeFieldInfoPtr_pad1;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeFieldInfoPtr_pad2;

		// Token: 0x040015A7 RID: 5543
		[FieldOffset(0)]
		public short EventType;

		// Token: 0x040015A8 RID: 5544
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool KeyDown;

		// Token: 0x040015A9 RID: 5545
		[FieldOffset(4)]
		public short RepeatCount;

		// Token: 0x040015AA RID: 5546
		[FieldOffset(6)]
		public short VirtualKeyCode;

		// Token: 0x040015AB RID: 5547
		[FieldOffset(8)]
		public short VirtualScanCode;

		// Token: 0x040015AC RID: 5548
		[FieldOffset(10)]
		public char Character;

		// Token: 0x040015AD RID: 5549
		[FieldOffset(12)]
		public int ControlKeyState;

		// Token: 0x040015AE RID: 5550
		[FieldOffset(16)]
		public int pad1;

		// Token: 0x040015AF RID: 5551
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool pad2;
	}
}
