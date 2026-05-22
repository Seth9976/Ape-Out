using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace Il2CppTMPro
{
	// Token: 0x0200005D RID: 93
	public class TMP_UpdateManager : Object
	{
		// Token: 0x06000BB0 RID: 2992 RVA: 0x00032050 File Offset: 0x00030250
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_UpdateManager()
		{
			Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_UpdateManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr);
			TMP_UpdateManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "s_Instance");
			TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutQueueLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutRebuildQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicQueueLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicRebuildQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextObjectForUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForGraphicRebuildMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForCullingUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextObjectForUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextElementForGraphicRebuildMarker");
			TMP_UpdateManager.NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664641);
			TMP_UpdateManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664642);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664643);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664644);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664645);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664646);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664647);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664648);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664649);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664650);
			TMP_UpdateManager.NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664651);
			TMP_UpdateManager.NativeMethodInfoPtr_DoRebuilds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664652);
			TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664653);
			TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664654);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664655);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664656);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664657);
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000322EC File Offset: 0x000304EC
		public unsafe static TMP_UpdateManager instance
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 463932, RefRangeEnd = 463943, XrefRangeStart = 463920, XrefRangeEnd = 463932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00032320 File Offset: 0x00030520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 463982, RefRangeEnd = 463983, XrefRangeStart = 463943, XrefRangeEnd = 463982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_UpdateManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0003235C File Offset: 0x0003055C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 463995, RefRangeEnd = 463999, XrefRangeStart = 463983, XrefRangeEnd = 463995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextObjectForUpdate(TMP_Text textObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00032394 File Offset: 0x00030594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 463999, XrefRangeEnd = 464007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x000323D8 File Offset: 0x000305D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464007, XrefRangeEnd = 464019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00032410 File Offset: 0x00030610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464019, XrefRangeEnd = 464027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00032454 File Offset: 0x00030654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464027, XrefRangeEnd = 464039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0003248C File Offset: 0x0003068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464039, XrefRangeEnd = 464047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000324D0 File Offset: 0x000306D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464047, XrefRangeEnd = 464059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForCullingUpdate(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00032508 File Offset: 0x00030708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464059, XrefRangeEnd = 464067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForCullingUpdate(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0003254C File Offset: 0x0003074C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464067, XrefRangeEnd = 464068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCameraPreCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00032580 File Offset: 0x00030780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 464085, RefRangeEnd = 464086, XrefRangeStart = 464068, XrefRangeEnd = 464085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoRebuilds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_DoRebuilds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x000325B4 File Offset: 0x000307B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 464092, RefRangeEnd = 464098, XrefRangeStart = 464086, XrefRangeEnd = 464092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000325EC File Offset: 0x000307EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 464118, RefRangeEnd = 464120, XrefRangeStart = 464098, XrefRangeEnd = 464118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterTextElementForRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00032624 File Offset: 0x00030824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464120, XrefRangeEnd = 464127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00032668 File Offset: 0x00030868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464127, XrefRangeEnd = 464134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000326AC File Offset: 0x000308AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 464167, RefRangeEnd = 464169, XrefRangeStart = 464134, XrefRangeEnd = 464167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0000771C File Offset: 0x0000591C
		public TMP_UpdateManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000326F0 File Offset: 0x000308F0
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00007725 File Offset: 0x00005925
		public unsafe static TMP_UpdateManager s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00032718 File Offset: 0x00030918
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00007737 File Offset: 0x00005937
		public unsafe HashSet<int> m_LayoutQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00032748 File Offset: 0x00030948
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00007756 File Offset: 0x00005956
		public unsafe List<TMP_Text> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00032778 File Offset: 0x00030978
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00007775 File Offset: 0x00005975
		public unsafe HashSet<int> m_GraphicQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000327A8 File Offset: 0x000309A8
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00007794 File Offset: 0x00005994
		public unsafe List<TMP_Text> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000327D8 File Offset: 0x000309D8
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x000077B3 File Offset: 0x000059B3
		public unsafe HashSet<int> m_InternalUpdateLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00032808 File Offset: 0x00030A08
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000077D2 File Offset: 0x000059D2
		public unsafe List<TMP_Text> m_InternalUpdateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00032838 File Offset: 0x00030A38
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x000077F1 File Offset: 0x000059F1
		public unsafe HashSet<int> m_CullingUpdateLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00032868 File Offset: 0x00030A68
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x00007810 File Offset: 0x00005A10
		public unsafe List<TMP_Text> m_CullingUpdateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00032898 File Offset: 0x00030A98
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0000782F File Offset: 0x00005A2F
		public unsafe static ProfilerMarker k_RegisterTextObjectForUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000328B4 File Offset: 0x00030AB4
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x0000783D File Offset: 0x00005A3D
		public unsafe static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&value));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000328D0 File Offset: 0x00030AD0
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0000784B File Offset: 0x00005A4B
		public unsafe static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000328EC File Offset: 0x00030AEC
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00007859 File Offset: 0x00005A59
		public unsafe static ProfilerMarker k_UnregisterTextObjectForUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00032908 File Offset: 0x00030B08
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00007867 File Offset: 0x00005A67
		public unsafe static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&value));
			}
		}

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutQueueLookup;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicQueueLookup;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalUpdateLookup;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalUpdateQueue;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateLookup;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateQueue;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_DoRebuilds_Private_Void_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;
	}
}
