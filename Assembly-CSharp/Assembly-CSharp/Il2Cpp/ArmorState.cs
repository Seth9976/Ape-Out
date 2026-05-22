using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200006D RID: 109
	public class ArmorState : FatState
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x0005E634 File Offset: 0x0005C834
		// Note: this type is marked as 'beforefieldinit'.
		static ArmorState()
		{
			Il2CppClassPointerStore<ArmorState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ArmorState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArmorState>.NativeClassPtr);
			ArmorState.NativeFieldInfoPtr_outererVestArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorState>.NativeClassPtr, "outererVestArr");
			ArmorState.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorState>.NativeClassPtr, 100664524);
			ArmorState.NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorState>.NativeClassPtr, 100664525);
			ArmorState.NativeMethodInfoPtr_KillVestBit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorState>.NativeClassPtr, 100664526);
			ArmorState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorState>.NativeClassPtr, 100664527);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0005E6C8 File Offset: 0x0005C8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45259, XrefRangeEnd = 45260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArmorState.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0005E704 File Offset: 0x0005C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45260, XrefRangeEnd = 45270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetAllMyShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArmorState.NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0005E740 File Offset: 0x0005C940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45270, XrefRangeEnd = 45317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void KillVestBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArmorState.NativeMethodInfoPtr_KillVestBit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0005E77C File Offset: 0x0005C97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45317, XrefRangeEnd = 45318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArmorState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArmorState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArmorState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0000ADAD File Offset: 0x00008FAD
		public ArmorState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0005E7B8 File Offset: 0x0005C9B8
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0000ADB6 File Offset: 0x00008FB6
		public unsafe Il2CppReferenceArray<GameObject> outererVestArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArmorState.NativeFieldInfoPtr_outererVestArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArmorState.NativeFieldInfoPtr_outererVestArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_outererVestArr;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllMyShit_Public_Virtual_Void_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_KillVestBit_Public_Virtual_Void_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
