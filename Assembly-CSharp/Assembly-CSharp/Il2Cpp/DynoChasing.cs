using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000BB RID: 187
	public class DynoChasing : GuardChasing
	{
		// Token: 0x06001680 RID: 5760 RVA: 0x00073BF4 File Offset: 0x00071DF4
		// Note: this type is marked as 'beforefieldinit'.
		static DynoChasing()
		{
			Il2CppClassPointerStore<DynoChasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DynoChasing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr);
			DynoChasing.NativeFieldInfoPtr_dynoTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr, "dynoTimer");
			DynoChasing.NativeFieldInfoPtr_throwin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr, "throwin");
			DynoChasing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr, 100665183);
			DynoChasing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr, 100665184);
			DynoChasing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr, 100665185);
			DynoChasing.NativeMethodInfoPtr_GetThrowPt_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr, 100665186);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00073C9C File Offset: 0x00071E9C
		[CallerCount(0)]
		public unsafe DynoChasing(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynoChasing>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynoChasing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00073D04 File Offset: 0x00071F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55790, XrefRangeEnd = 55812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoChasing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00073D40 File Offset: 0x00071F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55812, XrefRangeEnd = 55820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoChasing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00073D7C File Offset: 0x00071F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55857, RefRangeEnd = 55858, XrefRangeStart = 55820, XrefRangeEnd = 55857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetThrowPt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynoChasing.NativeMethodInfoPtr_GetThrowPt_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x000103AC File Offset: 0x0000E5AC
		public DynoChasing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00073DB8 File Offset: 0x00071FB8
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x000103B5 File Offset: 0x0000E5B5
		public unsafe int dynoTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoChasing.NativeFieldInfoPtr_dynoTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoChasing.NativeFieldInfoPtr_dynoTimer)) = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00073DE0 File Offset: 0x00071FE0
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x000103D0 File Offset: 0x0000E5D0
		public unsafe bool throwin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoChasing.NativeFieldInfoPtr_throwin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoChasing.NativeFieldInfoPtr_throwin)) = value;
			}
		}

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeFieldInfoPtr_dynoTimer;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeFieldInfoPtr_throwin;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_GetThrowPt_Public_Vector2_0;
	}
}
