using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C9 RID: 201
	[StructLayout(2)]
	public struct BloodData
	{
		// Token: 0x0600173E RID: 5950 RVA: 0x00075C60 File Offset: 0x00073E60
		// Note: this type is marked as 'beforefieldinit'.
		static BloodData()
		{
			Il2CppClassPointerStore<BloodData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BloodData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodData>.NativeClassPtr);
			BloodData.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodData>.NativeClassPtr, "on");
			BloodData.NativeFieldInfoPtr_cameraReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodData>.NativeClassPtr, "cameraReady");
			BloodData.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodData>.NativeClassPtr, "timer");
			BloodData.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodData>.NativeClassPtr, "pos");
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00010AAB File Offset: 0x0000ECAB
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeFieldInfoPtr_cameraReady;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04000DDB RID: 3547
		[FieldOffset(0)]
		public byte on;

		// Token: 0x04000DDC RID: 3548
		[FieldOffset(1)]
		public byte cameraReady;

		// Token: 0x04000DDD RID: 3549
		[FieldOffset(4)]
		public float timer;

		// Token: 0x04000DDE RID: 3550
		[FieldOffset(8)]
		public Vector2 pos;
	}
}
