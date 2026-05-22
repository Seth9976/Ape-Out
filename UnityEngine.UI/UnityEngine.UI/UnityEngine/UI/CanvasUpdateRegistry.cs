using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000006 RID: 6
	public class CanvasUpdateRegistry : Object
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00007904 File Offset: 0x00005B04
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasUpdateRegistry()
		{
			Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "CanvasUpdateRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr);
			CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_Instance");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingLayoutUpdate");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingGraphicUpdate");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CanvasUpdateProfilerStrings");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CullingUpdateProfilerString");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_LayoutRebuildQueue");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_GraphicRebuildQueue");
			CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_SortLayoutFunction");
			CanvasUpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663327);
			CanvasUpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663328);
			CanvasUpdateRegistry.NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663329);
			CanvasUpdateRegistry.NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663330);
			CanvasUpdateRegistry.NativeMethodInfoPtr_PerformUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663331);
			CanvasUpdateRegistry.NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663332);
			CanvasUpdateRegistry.NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663333);
			CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663334);
			CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663335);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663336);
			CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663337);
			CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663338);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663339);
			CanvasUpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663340);
			CanvasUpdateRegistry.NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663341);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663342);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663343);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663344);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663345);
			CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663346);
			CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663347);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00007B78 File Offset: 0x00005D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515750, RefRangeEnd = 515751, XrefRangeStart = 515695, XrefRangeEnd = 515750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasUpdateRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00007BB4 File Offset: 0x00005DB4
		public unsafe static CanvasUpdateRegistry instance
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 515763, RefRangeEnd = 515782, XrefRangeStart = 515751, XrefRangeEnd = 515763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00007BE8 File Offset: 0x00005DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 515795, RefRangeEnd = 515797, XrefRangeStart = 515782, XrefRangeEnd = 515795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValidForUpdate(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00007C38 File Offset: 0x00005E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515821, RefRangeEnd = 515822, XrefRangeStart = 515797, XrefRangeEnd = 515821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanInvalidItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007C6C File Offset: 0x00005E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515822, XrefRangeEnd = 515921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_PerformUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00007CA0 File Offset: 0x00005EA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 515949, RefRangeEnd = 515951, XrefRangeStart = 515921, XrefRangeEnd = 515949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParentCount(Transform child)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007CE4 File Offset: 0x00005EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515951, XrefRangeEnd = 515961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007D38 File Offset: 0x00005F38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 515967, RefRangeEnd = 515970, XrefRangeStart = 515961, XrefRangeEnd = 515967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00007D70 File Offset: 0x00005F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515970, XrefRangeEnd = 515976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007DB4 File Offset: 0x00005FB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 515980, RefRangeEnd = 515983, XrefRangeStart = 515976, XrefRangeEnd = 515980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00007E04 File Offset: 0x00006004
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 515989, RefRangeEnd = 516011, XrefRangeStart = 515983, XrefRangeEnd = 515989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00007E3C File Offset: 0x0000603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516011, XrefRangeEnd = 516017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007E80 File Offset: 0x00006080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 516021, RefRangeEnd = 516023, XrefRangeStart = 516017, XrefRangeEnd = 516021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00007ED0 File Offset: 0x000060D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 516064, RefRangeEnd = 516069, XrefRangeStart = 516023, XrefRangeEnd = 516064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00007F08 File Offset: 0x00006108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 516110, RefRangeEnd = 516112, XrefRangeStart = 516069, XrefRangeEnd = 516110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableCanvasElementForRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007F40 File Offset: 0x00006140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516112, XrefRangeEnd = 516130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007F84 File Offset: 0x00006184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516130, XrefRangeEnd = 516148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007FC8 File Offset: 0x000061C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516148, XrefRangeEnd = 516166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000800C File Offset: 0x0000620C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516166, XrefRangeEnd = 516184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00008050 File Offset: 0x00006250
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 516188, RefRangeEnd = 516193, XrefRangeStart = 516184, XrefRangeEnd = 516188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRebuildingLayout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00008080 File Offset: 0x00006280
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 516197, RefRangeEnd = 516201, XrefRangeStart = 516193, XrefRangeEnd = 516197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRebuildingGraphics()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000217F File Offset: 0x0000037F
		public CanvasUpdateRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000080B0 File Offset: 0x000062B0
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002188 File Offset: 0x00000388
		public unsafe static CanvasUpdateRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000080D8 File Offset: 0x000062D8
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000219A File Offset: 0x0000039A
		public unsafe bool m_PerformingLayoutUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00008100 File Offset: 0x00006300
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000021B5 File Offset: 0x000003B5
		public unsafe bool m_PerformingGraphicUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00008128 File Offset: 0x00006328
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000021D0 File Offset: 0x000003D0
		public unsafe Il2CppStringArray m_CanvasUpdateProfilerStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00008158 File Offset: 0x00006358
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000021EF File Offset: 0x000003EF
		public unsafe static string m_CullingUpdateProfilerString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00008178 File Offset: 0x00006378
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002201 File Offset: 0x00000401
		public unsafe IndexedSet<ICanvasElement> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000081A8 File Offset: 0x000063A8
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002220 File Offset: 0x00000420
		public unsafe IndexedSet<ICanvasElement> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000081D8 File Offset: 0x000063D8
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000223F File Offset: 0x0000043F
		public unsafe static Comparison<ICanvasElement> s_SortLayoutFunction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformingLayoutUpdate;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformingGraphicUpdate;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateProfilerString;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_s_SortLayoutFunction;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_PerformUpdate_Private_Void_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0;
	}
}
