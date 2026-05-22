using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200002A RID: 42
	public class MaskUtilities : Object
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x0001A0C4 File Offset: 0x000182C4
		// Note: this type is marked as 'beforefieldinit'.
		static MaskUtilities()
		{
			Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MaskUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr);
			MaskUtilities.NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664118);
			MaskUtilities.NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664119);
			MaskUtilities.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664120);
			MaskUtilities.NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664121);
			MaskUtilities.NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664122);
			MaskUtilities.NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664123);
			MaskUtilities.NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664124);
			MaskUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr, 100664125);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001A194 File Offset: 0x00018394
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 525172, RefRangeEnd = 525177, XrefRangeStart = 525113, XrefRangeEnd = 525172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Notify2DMaskStateChanged(Component mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001A1CC File Offset: 0x000183CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 525236, RefRangeEnd = 525242, XrefRangeStart = 525177, XrefRangeEnd = 525236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyStencilStateChanged(Component mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001A204 File Offset: 0x00018404
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 525276, RefRangeEnd = 525280, XrefRangeStart = 525242, XrefRangeEnd = 525276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRootSortOverrideCanvas(Transform start)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001A248 File Offset: 0x00018448
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 525360, RefRangeEnd = 525364, XrefRangeStart = 525280, XrefRangeEnd = 525360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stopAfter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001A29C File Offset: 0x0001849C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 525425, RefRangeEnd = 525427, XrefRangeStart = 525364, XrefRangeEnd = 525425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(father);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001A2F0 File Offset: 0x000184F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525490, RefRangeEnd = 525491, XrefRangeStart = 525427, XrefRangeEnd = 525490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clippable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001A334 File Offset: 0x00018534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525548, RefRangeEnd = 525549, XrefRangeStart = 525491, XrefRangeEnd = 525548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clipper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(masks);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001A37C File Offset: 0x0001857C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00003AF9 File Offset: 0x00001CF9
		public MaskUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_Notify2DMaskStateChanged_Public_Static_Void_Component_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_NotifyStencilStateChanged_Public_Static_Void_Component_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_FindRootSortOverrideCanvas_Public_Static_Transform_Transform_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_GetStencilDepth_Public_Static_Int32_Transform_Transform_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOrSelf_Public_Static_Boolean_Transform_Transform_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_GetRectMaskForClippable_Public_Static_RectMask2D_IClippable_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_GetRectMasksForClip_Public_Static_Void_RectMask2D_List_1_RectMask2D_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
