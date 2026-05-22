using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000032 RID: 50
	[StructLayout(2)]
	public struct QuaternionOptions
	{
		// Token: 0x06000372 RID: 882 RVA: 0x00017A20 File Offset: 0x00015C20
		// Note: this type is marked as 'beforefieldinit'.
		static QuaternionOptions()
		{
			Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "QuaternionOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr);
			QuaternionOptions.NativeFieldInfoPtr_rotateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, "rotateMode");
			QuaternionOptions.NativeFieldInfoPtr_axisConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, "axisConstraint");
			QuaternionOptions.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, "up");
			QuaternionOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, 100664091);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00017AA0 File Offset: 0x00015CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123504, XrefRangeEnd = 123506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002F10 File Offset: 0x00001110
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_rotateMode;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_axisConstraint;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400030C RID: 780
		[FieldOffset(0)]
		public RotateMode rotateMode;

		// Token: 0x0400030D RID: 781
		[FieldOffset(4)]
		public AxisConstraint axisConstraint;

		// Token: 0x0400030E RID: 782
		[FieldOffset(8)]
		public Vector3 up;
	}
}
