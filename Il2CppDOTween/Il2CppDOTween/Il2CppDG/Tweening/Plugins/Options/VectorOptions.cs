using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x0200003A RID: 58
	[StructLayout(2)]
	public struct VectorOptions
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00017FD8 File Offset: 0x000161D8
		// Note: this type is marked as 'beforefieldinit'.
		static VectorOptions()
		{
			Il2CppClassPointerStore<VectorOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "VectorOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr);
			VectorOptions.NativeFieldInfoPtr_axisConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, "axisConstraint");
			VectorOptions.NativeFieldInfoPtr_snapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, "snapping");
			VectorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, 100664099);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00018044 File Offset: 0x00016244
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000030CB File Offset: 0x000012CB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VectorOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_axisConstraint;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_snapping;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000329 RID: 809
		[FieldOffset(0)]
		public AxisConstraint axisConstraint;

		// Token: 0x0400032A RID: 810
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool snapping;
	}
}
