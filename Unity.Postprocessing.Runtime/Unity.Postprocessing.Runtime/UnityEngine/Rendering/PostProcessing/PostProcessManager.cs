using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000055 RID: 85
	public sealed class PostProcessManager : Object
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x0001245C File Offset: 0x0001065C
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessManager()
		{
			Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr);
			PostProcessManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "s_Instance");
			PostProcessManager.NativeFieldInfoPtr_k_MaxLayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "k_MaxLayerCount");
			PostProcessManager.NativeFieldInfoPtr_m_SortedVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "m_SortedVolumes");
			PostProcessManager.NativeFieldInfoPtr_m_Volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "m_Volumes");
			PostProcessManager.NativeFieldInfoPtr_m_SortNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "m_SortNeeded");
			PostProcessManager.NativeFieldInfoPtr_m_BaseSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "m_BaseSettings");
			PostProcessManager.NativeFieldInfoPtr_m_TempColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "m_TempColliders");
			PostProcessManager.NativeFieldInfoPtr_settingsTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "settingsTypes");
			PostProcessManager.NativeMethodInfoPtr_get_instance_Public_Static_get_PostProcessManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663642);
			PostProcessManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663643);
			PostProcessManager.NativeMethodInfoPtr_CleanBaseTypes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663644);
			PostProcessManager.NativeMethodInfoPtr_ReloadBaseTypes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663645);
			PostProcessManager.NativeMethodInfoPtr_GetActiveVolumes_Public_Void_PostProcessLayer_List_1_PostProcessVolume_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663646);
			PostProcessManager.NativeMethodInfoPtr_GetHighestPriorityVolume_Public_PostProcessVolume_PostProcessLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663647);
			PostProcessManager.NativeMethodInfoPtr_GetHighestPriorityVolume_Public_PostProcessVolume_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663648);
			PostProcessManager.NativeMethodInfoPtr_QuickVolume_Public_PostProcessVolume_Int32_Single_Il2CppReferenceArray_1_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663649);
			PostProcessManager.NativeMethodInfoPtr_SetLayerDirty_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663650);
			PostProcessManager.NativeMethodInfoPtr_UpdateVolumeLayer_Internal_Void_PostProcessVolume_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663651);
			PostProcessManager.NativeMethodInfoPtr_Register_Private_Void_PostProcessVolume_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663652);
			PostProcessManager.NativeMethodInfoPtr_Register_Internal_Void_PostProcessVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663653);
			PostProcessManager.NativeMethodInfoPtr_Unregister_Private_Void_PostProcessVolume_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663654);
			PostProcessManager.NativeMethodInfoPtr_Unregister_Internal_Void_PostProcessVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663655);
			PostProcessManager.NativeMethodInfoPtr_ReplaceData_Private_Void_PostProcessLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663656);
			PostProcessManager.NativeMethodInfoPtr_UpdateSettings_Internal_Void_PostProcessLayer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663657);
			PostProcessManager.NativeMethodInfoPtr_GrabVolumes_Private_List_1_PostProcessVolume_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663658);
			PostProcessManager.NativeMethodInfoPtr_SortByPriority_Private_Static_Void_List_1_PostProcessVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663659);
			PostProcessManager.NativeMethodInfoPtr_IsVolumeRenderedByCamera_Private_Static_Boolean_PostProcessVolume_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, 100663660);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000126A8 File Offset: 0x000108A8
		public unsafe static PostProcessManager instance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 447540, RefRangeEnd = 447546, XrefRangeStart = 447534, XrefRangeEnd = 447540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_get_instance_Public_Static_get_PostProcessManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessManager>(intPtr3) : null;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000126DC File Offset: 0x000108DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447583, RefRangeEnd = 447584, XrefRangeStart = 447546, XrefRangeEnd = 447583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00012718 File Offset: 0x00010918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447601, RefRangeEnd = 447602, XrefRangeStart = 447584, XrefRangeEnd = 447601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanBaseTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_CleanBaseTypes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001274C File Offset: 0x0001094C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447652, RefRangeEnd = 447653, XrefRangeStart = 447602, XrefRangeEnd = 447652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadBaseTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_ReloadBaseTypes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00012780 File Offset: 0x00010980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447653, XrefRangeEnd = 447715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipDisabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipZeroWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_GetActiveVolumes_Public_Void_PostProcessLayer_List_1_PostProcessVolume_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000127F0 File Offset: 0x000109F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447715, XrefRangeEnd = 447734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_GetHighestPriorityVolume_Public_PostProcessVolume_PostProcessLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessVolume>(intPtr3) : null;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00012840 File Offset: 0x00010A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447744, RefRangeEnd = 447745, XrefRangeStart = 447734, XrefRangeEnd = 447744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_GetHighestPriorityVolume_Public_PostProcessVolume_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessVolume>(intPtr3) : null;
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001288C File Offset: 0x00010A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447745, XrefRangeEnd = 447766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessVolume QuickVolume(int layer, float priority, [Optional] Il2CppReferenceArray<PostProcessEffectSettings> settings)
		{
			if (settings == null)
			{
				settings = new Il2CppReferenceArray<PostProcessEffectSettings>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_QuickVolume_Public_PostProcessVolume_Int32_Single_Il2CppReferenceArray_1_PostProcessEffectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessVolume>(intPtr3) : null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00012908 File Offset: 0x00010B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 447777, RefRangeEnd = 447779, XrefRangeStart = 447766, XrefRangeEnd = 447777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerDirty(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_SetLayerDirty_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00012948 File Offset: 0x00010B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447779, XrefRangeEnd = 447781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevLayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_UpdateVolumeLayer_Internal_Void_PostProcessVolume_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000129A8 File Offset: 0x00010BA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 447797, RefRangeEnd = 447801, XrefRangeStart = 447781, XrefRangeEnd = 447797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(PostProcessVolume volume, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_Register_Private_Void_PostProcessVolume_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000129F8 File Offset: 0x00010BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447801, XrefRangeEnd = 447811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(PostProcessVolume volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_Register_Internal_Void_PostProcessVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00012A3C File Offset: 0x00010C3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 447824, RefRangeEnd = 447828, XrefRangeStart = 447811, XrefRangeEnd = 447824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(PostProcessVolume volume, int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_Unregister_Private_Void_PostProcessVolume_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00012A8C File Offset: 0x00010C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447828, XrefRangeEnd = 447838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(PostProcessVolume volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_Unregister_Internal_Void_PostProcessVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00012AD0 File Offset: 0x00010CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447857, RefRangeEnd = 447858, XrefRangeStart = 447838, XrefRangeEnd = 447857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceData(PostProcessLayer postProcessLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(postProcessLayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_ReplaceData_Private_Void_PostProcessLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00012B14 File Offset: 0x00010D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 447921, RefRangeEnd = 447922, XrefRangeStart = 447858, XrefRangeEnd = 447921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(postProcessLayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_UpdateSettings_Internal_Void_PostProcessLayer_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00012B68 File Offset: 0x00010D68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 447959, RefRangeEnd = 447961, XrefRangeStart = 447922, XrefRangeEnd = 447959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PostProcessVolume> GrabVolumes(LayerMask mask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_GrabVolumes_Private_List_1_PostProcessVolume_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PostProcessVolume>>(intPtr3) : null;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00012BB4 File Offset: 0x00010DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447961, XrefRangeEnd = 447967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortByPriority(List<PostProcessVolume> volumes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volumes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_SortByPriority_Private_Static_Void_List_1_PostProcessVolume_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00012BEC File Offset: 0x00010DEC
		[CallerCount(0)]
		public unsafe static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.NativeMethodInfoPtr_IsVolumeRenderedByCamera_Private_Static_Boolean_PostProcessVolume_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000042FA File Offset: 0x000024FA
		public PostProcessVolume QuickVolume(int layer, float priority, params PostProcessEffectSettings[] settings)
		{
			return this.QuickVolume(layer, priority, new Il2CppReferenceArray<PostProcessEffectSettings>(settings));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000430A File Offset: 0x0000250A
		public PostProcessManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00012C40 File Offset: 0x00010E40
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00004313 File Offset: 0x00002513
		public unsafe static PostProcessManager s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PostProcessManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00012C68 File Offset: 0x00010E68
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00004325 File Offset: 0x00002525
		public unsafe static int k_MaxLayerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PostProcessManager.NativeFieldInfoPtr_k_MaxLayerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessManager.NativeFieldInfoPtr_k_MaxLayerCount, (void*)(&value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00012C84 File Offset: 0x00010E84
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00004333 File Offset: 0x00002533
		public unsafe Dictionary<int, List<PostProcessVolume>> m_SortedVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_SortedVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<PostProcessVolume>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_SortedVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00012CB4 File Offset: 0x00010EB4
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00004352 File Offset: 0x00002552
		public unsafe List<PostProcessVolume> m_Volumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_Volumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessVolume>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_Volumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00012CE4 File Offset: 0x00010EE4
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00004371 File Offset: 0x00002571
		public unsafe Dictionary<int, bool> m_SortNeeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_SortNeeded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_SortNeeded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00012D14 File Offset: 0x00010F14
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00004390 File Offset: 0x00002590
		public unsafe List<PostProcessEffectSettings> m_BaseSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_BaseSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PostProcessEffectSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_BaseSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00012D44 File Offset: 0x00010F44
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000043AF File Offset: 0x000025AF
		public unsafe List<Collider> m_TempColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_TempColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_m_TempColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00012D74 File Offset: 0x00010F74
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x000043CE File Offset: 0x000025CE
		public unsafe Dictionary<Type, PostProcessAttribute> settingsTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_settingsTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, PostProcessAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessManager.NativeFieldInfoPtr_settingsTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxLayerCount;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedVolumes;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_m_Volumes;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_m_SortNeeded;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseSettings;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_m_TempColliders;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_settingsTypes;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_PostProcessManager_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_CleanBaseTypes_Private_Void_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_ReloadBaseTypes_Private_Void_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveVolumes_Public_Void_PostProcessLayer_List_1_PostProcessVolume_Boolean_Boolean_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestPriorityVolume_Public_PostProcessVolume_PostProcessLayer_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestPriorityVolume_Public_PostProcessVolume_LayerMask_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_QuickVolume_Public_PostProcessVolume_Int32_Single_Il2CppReferenceArray_1_PostProcessEffectSettings_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerDirty_Internal_Void_Int32_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumeLayer_Internal_Void_PostProcessVolume_Int32_Int32_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_Register_Private_Void_PostProcessVolume_Int32_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Void_PostProcessVolume_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Private_Void_PostProcessVolume_Int32_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Internal_Void_PostProcessVolume_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceData_Private_Void_PostProcessLayer_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSettings_Internal_Void_PostProcessLayer_Camera_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_GrabVolumes_Private_List_1_PostProcessVolume_LayerMask_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_SortByPriority_Private_Static_Void_List_1_PostProcessVolume_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_IsVolumeRenderedByCamera_Private_Static_Boolean_PostProcessVolume_Camera_0;

		// Token: 0x02000086 RID: 134
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.PostProcessManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600071D RID: 1821 RVA: 0x0001B618 File Offset: 0x00019818
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PostProcessManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessManager.__c>.NativeClassPtr);
				PostProcessManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager.__c>.NativeClassPtr, "<>9");
				PostProcessManager.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessManager.__c>.NativeClassPtr, "<>9__12_0");
				PostProcessManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager.__c>.NativeClassPtr, 100663662);
				PostProcessManager.__c.NativeMethodInfoPtr__ReloadBaseTypes_b__12_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessManager.__c>.NativeClassPtr, 100663663);
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x0001B694 File Offset: 0x00019894
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600071F RID: 1823 RVA: 0x0001B6D0 File Offset: 0x000198D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 447528, XrefRangeEnd = 447534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReloadBaseTypes_b__12_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessManager.__c.NativeMethodInfoPtr__ReloadBaseTypes_b__12_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000720 RID: 1824 RVA: 0x00005896 File Offset: 0x00003A96
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x06000721 RID: 1825 RVA: 0x0001B720 File Offset: 0x00019920
			// (set) Token: 0x06000722 RID: 1826 RVA: 0x0000589F File Offset: 0x00003A9F
			public unsafe static PostProcessManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001B748 File Offset: 0x00019948
			// (set) Token: 0x06000724 RID: 1828 RVA: 0x000058B1 File Offset: 0x00003AB1
			public unsafe static Func<Type, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessManager.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessManager.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E8 RID: 1256
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004E9 RID: 1257
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040004EA RID: 1258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004EB RID: 1259
			private static readonly IntPtr NativeMethodInfoPtr__ReloadBaseTypes_b__12_0_Internal_Boolean_Type_0;
		}
	}
}
