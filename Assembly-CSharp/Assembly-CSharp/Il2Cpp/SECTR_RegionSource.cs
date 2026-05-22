using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x02000045 RID: 69
	public class SECTR_RegionSource : SECTR_PointSource
	{
		// Token: 0x06000AA5 RID: 2725 RVA: 0x00053A3C File Offset: 0x00051C3C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_RegionSource()
		{
			Il2CppClassPointerStore<SECTR_RegionSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_RegionSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_RegionSource>.NativeClassPtr);
			SECTR_RegionSource.NativeFieldInfoPtr_Raycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_RegionSource>.NativeClassPtr, "Raycast");
			SECTR_RegionSource.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_RegionSource>.NativeClassPtr, 100664181);
			SECTR_RegionSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_RegionSource>.NativeClassPtr, 100664182);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00053AA8 File Offset: 0x00051CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40328, XrefRangeEnd = 40377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_RegionSource.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00053ADC File Offset: 0x00051CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_RegionSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_RegionSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_RegionSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00008AE7 File Offset: 0x00006CE7
		public SECTR_RegionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00053B18 File Offset: 0x00051D18
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public unsafe bool Raycast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_RegionSource.NativeFieldInfoPtr_Raycast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_RegionSource.NativeFieldInfoPtr_Raycast)) = value;
			}
		}

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_Raycast;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
