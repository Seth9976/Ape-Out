using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002D RID: 45
	public class PickRandomStartPoint : MonoBehaviour
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x000455BC File Offset: 0x000437BC
		// Note: this type is marked as 'beforefieldinit'.
		static PickRandomStartPoint()
		{
			Il2CppClassPointerStore<PickRandomStartPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PickRandomStartPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickRandomStartPoint>.NativeClassPtr);
			PickRandomStartPoint.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickRandomStartPoint>.NativeClassPtr, 100663790);
			PickRandomStartPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickRandomStartPoint>.NativeClassPtr, 100663791);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00045614 File Offset: 0x00043814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35626, XrefRangeEnd = 35630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickRandomStartPoint.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00045648 File Offset: 0x00043848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PickRandomStartPoint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickRandomStartPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PickRandomStartPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000569C File Offset: 0x0000389C
		public PickRandomStartPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
