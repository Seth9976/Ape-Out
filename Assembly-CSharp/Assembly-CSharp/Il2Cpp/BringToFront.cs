using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200008F RID: 143
	public class BringToFront : MonoBehaviour
	{
		// Token: 0x06001152 RID: 4434 RVA: 0x000663CC File Offset: 0x000645CC
		// Note: this type is marked as 'beforefieldinit'.
		static BringToFront()
		{
			Il2CppClassPointerStore<BringToFront>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BringToFront");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BringToFront>.NativeClassPtr);
			BringToFront.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BringToFront>.NativeClassPtr, 100664774);
			BringToFront.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BringToFront>.NativeClassPtr, 100664775);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00066424 File Offset: 0x00064624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48977, XrefRangeEnd = 48987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BringToFront.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00066458 File Offset: 0x00064658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BringToFront()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BringToFront>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BringToFront.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0000CBB3 File Offset: 0x0000ADB3
		public BringToFront(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
