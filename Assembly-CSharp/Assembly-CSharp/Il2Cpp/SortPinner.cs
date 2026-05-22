using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200019C RID: 412
	public class SortPinner : MonoBehaviour
	{
		// Token: 0x06002FEB RID: 12267 RVA: 0x000B8530 File Offset: 0x000B6730
		// Note: this type is marked as 'beforefieldinit'.
		static SortPinner()
		{
			Il2CppClassPointerStore<SortPinner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SortPinner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortPinner>.NativeClassPtr);
			SortPinner.NativeFieldInfoPtr_toPinRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, "toPinRends");
			SortPinner.NativeFieldInfoPtr_pinToRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, "pinToRend");
			SortPinner.NativeFieldInfoPtr_sortOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, "sortOffset");
			SortPinner.NativeFieldInfoPtr_lastSortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, "lastSortOrder");
			SortPinner.NativeFieldInfoPtr_lastSortingLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, "lastSortingLayerID");
			SortPinner.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, 100667044);
			SortPinner.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, 100667045);
			SortPinner.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, 100667046);
			SortPinner.NativeMethodInfoPtr_SetSortingOrderAndID_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, 100667047);
			SortPinner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortPinner>.NativeClassPtr, 100667048);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x000B8628 File Offset: 0x000B6828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83896, XrefRangeEnd = 83897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortPinner.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x000B865C File Offset: 0x000B685C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83897, XrefRangeEnd = 83902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortPinner.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x000B8690 File Offset: 0x000B6890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortPinner.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000B86C4 File Offset: 0x000B68C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83912, RefRangeEnd = 83915, XrefRangeStart = 83902, XrefRangeEnd = 83912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSortingOrderAndID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortPinner.NativeMethodInfoPtr_SetSortingOrderAndID_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000B86F8 File Offset: 0x000B68F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortPinner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortPinner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortPinner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00021032 File Offset: 0x0001F232
		public SortPinner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x000B8734 File Offset: 0x000B6934
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x0002103B File Offset: 0x0001F23B
		public unsafe Il2CppReferenceArray<Renderer> toPinRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_toPinRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_toPinRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x000B8764 File Offset: 0x000B6964
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x0002105A File Offset: 0x0001F25A
		public unsafe Renderer pinToRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_pinToRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_pinToRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000B8794 File Offset: 0x000B6994
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x00021079 File Offset: 0x0001F279
		public unsafe int sortOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_sortOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_sortOffset)) = value;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000B87BC File Offset: 0x000B69BC
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x00021094 File Offset: 0x0001F294
		public unsafe int lastSortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_lastSortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_lastSortOrder)) = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x000B87E4 File Offset: 0x000B69E4
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x000210AF File Offset: 0x0001F2AF
		public unsafe int lastSortingLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_lastSortingLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortPinner.NativeFieldInfoPtr_lastSortingLayerID)) = value;
			}
		}

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeFieldInfoPtr_toPinRends;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeFieldInfoPtr_pinToRend;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeFieldInfoPtr_sortOffset;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeFieldInfoPtr_lastSortOrder;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeFieldInfoPtr_lastSortingLayerID;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_SetSortingOrderAndID_Private_Void_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
