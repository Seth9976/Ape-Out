using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200008B RID: 139
	public class BoatWallPropPicker : MonoBehaviour
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x00065B74 File Offset: 0x00063D74
		// Note: this type is marked as 'beforefieldinit'.
		static BoatWallPropPicker()
		{
			Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BoatWallPropPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr);
			BoatWallPropPicker.NativeFieldInfoPtr_openProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr, "openProp");
			BoatWallPropPicker.NativeFieldInfoPtr_closedProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr, "closedProp");
			BoatWallPropPicker.NativeFieldInfoPtr_answer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr, "answer");
			BoatWallPropPicker.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr, "num");
			BoatWallPropPicker.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr, 100664755);
			BoatWallPropPicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr, 100664756);
			BoatWallPropPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr, 100664757);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00065C30 File Offset: 0x00063E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48765, XrefRangeEnd = 48798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatWallPropPicker.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00065C64 File Offset: 0x00063E64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatWallPropPicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00065C98 File Offset: 0x00063E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoatWallPropPicker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatWallPropPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatWallPropPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0000C9DA File Offset: 0x0000ABDA
		public BoatWallPropPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00065CD4 File Offset: 0x00063ED4
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x0000C9E3 File Offset: 0x0000ABE3
		public unsafe GameObject openProp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_openProp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_openProp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x00065D04 File Offset: 0x00063F04
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x0000CA02 File Offset: 0x0000AC02
		public unsafe GameObject closedProp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_closedProp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_closedProp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00065D34 File Offset: 0x00063F34
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x0000CA21 File Offset: 0x0000AC21
		public unsafe int answer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_answer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_answer)) = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00065D5C File Offset: 0x00063F5C
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x0000CA3C File Offset: 0x0000AC3C
		public unsafe int num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatWallPropPicker.NativeFieldInfoPtr_num)) = value;
			}
		}

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeFieldInfoPtr_openProp;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeFieldInfoPtr_closedProp;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeFieldInfoPtr_answer;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
