using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200016E RID: 366
	[StructLayout(2)]
	public struct BatchVisibility
	{
		// Token: 0x06001BA7 RID: 7079 RVA: 0x00067B44 File Offset: 0x00065D44
		// Note: this type is marked as 'beforefieldinit'.
		static BatchVisibility()
		{
			Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr);
			BatchVisibility.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, "offset");
			BatchVisibility.NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, "instancesCount");
			BatchVisibility.NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, "visibleCount");
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, ref this));
		}

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeFieldInfoPtr_instancesCount;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeFieldInfoPtr_visibleCount;

		// Token: 0x04001581 RID: 5505
		[FieldOffset(0)]
		public readonly int offset;

		// Token: 0x04001582 RID: 5506
		[FieldOffset(4)]
		public readonly int instancesCount;

		// Token: 0x04001583 RID: 5507
		[FieldOffset(8)]
		public int visibleCount;
	}
}
