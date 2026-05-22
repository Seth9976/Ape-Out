using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Data
{
	// Token: 0x0200009E RID: 158
	public sealed class ControllerDataFiles : ScriptableObject
	{
		// Token: 0x060013A5 RID: 5029 RVA: 0x000763AC File Offset: 0x000745AC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerDataFiles()
		{
			Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ControllerDataFiles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr);
			ControllerDataFiles.NativeFieldInfoPtr_defaultHardwareJoystickMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, "defaultHardwareJoystickMap");
			ControllerDataFiles.NativeFieldInfoPtr_hardwareJoystickMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, "hardwareJoystickMaps");
			ControllerDataFiles.NativeFieldInfoPtr_joystickTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, "joystickTemplates");
			ControllerDataFiles.NativeFieldInfoPtr_mmJjXfccyBgITFvkrmRZgCDhtXh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, "mmJjXfccyBgITFvkrmRZgCDhtXh");
			ControllerDataFiles.NativeMethodInfoPtr_get_defaultHardwareJoystickMapGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666570);
			ControllerDataFiles.NativeMethodInfoPtr_get_JoystickTemplates_Public_get_Il2CppReferenceArray_1_HardwareJoystickTemplateMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666571);
			ControllerDataFiles.NativeMethodInfoPtr_set_JoystickTemplates_Public_set_Void_Il2CppReferenceArray_1_HardwareJoystickTemplateMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666572);
			ControllerDataFiles.NativeMethodInfoPtr_get_HardwareJoystickMaps_Public_get_Il2CppReferenceArray_1_HardwareJoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666573);
			ControllerDataFiles.NativeMethodInfoPtr_set_HardwareJoystickMaps_Public_set_Void_Il2CppReferenceArray_1_HardwareJoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666574);
			ControllerDataFiles.NativeMethodInfoPtr_get_DefaultHardwareJoystickMap_Public_get_HardwareJoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666575);
			ControllerDataFiles.NativeMethodInfoPtr_set_DefaultHardwareJoystickMap_Public_set_Void_HardwareJoystickMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666576);
			ControllerDataFiles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666577);
			ControllerDataFiles.NativeMethodInfoPtr_GetJoystickNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666578);
			ControllerDataFiles.NativeMethodInfoPtr_GetEditorJoystickNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666579);
			ControllerDataFiles.NativeMethodInfoPtr_GetJoystickGuids_Public_Il2CppStructArray_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666580);
			ControllerDataFiles.NativeMethodInfoPtr_GetJoystickTemplateNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666581);
			ControllerDataFiles.NativeMethodInfoPtr_GetJoystickTemplateGuids_Public_Il2CppStructArray_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666582);
			ControllerDataFiles.NativeMethodInfoPtr_GetHardwareJoystickMap_Public_HardwareJoystickMap_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666583);
			ControllerDataFiles.NativeMethodInfoPtr_GetJoystickTemplate_Public_HardwareJoystickTemplateMap_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666584);
			ControllerDataFiles.NativeMethodInfoPtr_GetControllerTemplate_Public_IHardwareControllerTemplateMap_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666585);
			ControllerDataFiles.NativeMethodInfoPtr_GetHardwareJoystickOrTemplateMap_Public_IHardwareControllerMap_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666586);
			ControllerDataFiles.NativeMethodInfoPtr_SzKdXPZxhAplwtKcXTjDiBbttio_Internal_ControllerTemplateElementIdentifier_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666587);
			ControllerDataFiles.NativeMethodInfoPtr_wEdgHgfnXhSYKHYnmqwimmNIJCvh_Internal_HardwareJoystickMap_InputManager_Guid_InputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666588);
			ControllerDataFiles.NativeMethodInfoPtr_CTouiXyVafnFyqVouqBvHpzSGNS_Internal_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666589);
			ControllerDataFiles.NativeMethodInfoPtr_kkyQograDygPNNxVCZQnJQOgWFt_Private_HardwareJoystickMap_InputManager_HardwareJoystickMap_BridgedControllerHWInfo_Boolean_byref_InputPlatform_byref_Int32_byref_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666590);
			ControllerDataFiles.NativeMethodInfoPtr_FsOduOOSTscxakCEnNEAKNbjsBC_Private_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666591);
			ControllerDataFiles.NativeMethodInfoPtr_forUZeFAKlauosXgisbaQqKvBJv_Private_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666592);
			ControllerDataFiles.NativeMethodInfoPtr_vgBffJXPVBahUYNNzDLnEcLGDfS_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr, 100666593);
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0007660C File Offset: 0x0007480C
		public unsafe Guid defaultHardwareJoystickMapGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263917, XrefRangeEnd = 263938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_get_defaultHardwareJoystickMapGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x00076648 File Offset: 0x00074848
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x00076688 File Offset: 0x00074888
		public unsafe Il2CppReferenceArray<HardwareJoystickTemplateMap> JoystickTemplates
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_get_JoystickTemplates_Public_get_Il2CppReferenceArray_1_HardwareJoystickTemplateMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickTemplateMap>>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_set_JoystickTemplates_Public_set_Void_Il2CppReferenceArray_1_HardwareJoystickTemplateMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x000766CC File Offset: 0x000748CC
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x0007670C File Offset: 0x0007490C
		public unsafe Il2CppReferenceArray<HardwareJoystickMap> HardwareJoystickMaps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_get_HardwareJoystickMaps_Public_get_Il2CppReferenceArray_1_HardwareJoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickMap>>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_set_HardwareJoystickMaps_Public_set_Void_Il2CppReferenceArray_1_HardwareJoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00076750 File Offset: 0x00074950
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00076790 File Offset: 0x00074990
		public unsafe HardwareJoystickMap DefaultHardwareJoystickMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_get_DefaultHardwareJoystickMap_Public_get_HardwareJoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_set_DefaultHardwareJoystickMap_Public_set_Void_HardwareJoystickMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x000767D4 File Offset: 0x000749D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerDataFiles()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerDataFiles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00076810 File Offset: 0x00074A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263938, XrefRangeEnd = 263969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetJoystickNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetJoystickNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00076850 File Offset: 0x00074A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263969, XrefRangeEnd = 264001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetEditorJoystickNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetEditorJoystickNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00076890 File Offset: 0x00074A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264001, XrefRangeEnd = 264037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Guid> GetJoystickGuids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetJoystickGuids_Public_Il2CppStructArray_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr3) : null;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000768D0 File Offset: 0x00074AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264037, XrefRangeEnd = 264065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetJoystickTemplateNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetJoystickTemplateNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00076910 File Offset: 0x00074B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264065, XrefRangeEnd = 264090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Guid> GetJoystickTemplateGuids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetJoystickTemplateGuids_Public_Il2CppStructArray_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr3) : null;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00076950 File Offset: 0x00074B50
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 264123, RefRangeEnd = 264131, XrefRangeStart = 264090, XrefRangeEnd = 264123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap GetHardwareJoystickMap(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetHardwareJoystickMap_Public_HardwareJoystickMap_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap>(intPtr3) : null;
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0007699C File Offset: 0x00074B9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 264152, RefRangeEnd = 264157, XrefRangeStart = 264131, XrefRangeEnd = 264152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetJoystickTemplate_Public_HardwareJoystickTemplateMap_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickTemplateMap>(intPtr3) : null;
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000769E8 File Offset: 0x00074BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264157, XrefRangeEnd = 264158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IHardwareControllerTemplateMap GetControllerTemplate(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetControllerTemplate_Public_IHardwareControllerTemplateMap_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHardwareControllerTemplateMap>(intPtr3) : null;
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00076A34 File Offset: 0x00074C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264158, XrefRangeEnd = 264171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_GetHardwareJoystickOrTemplateMap_Public_IHardwareControllerMap_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHardwareControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00076A80 File Offset: 0x00074C80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264219, RefRangeEnd = 264221, XrefRangeStart = 264171, XrefRangeEnd = 264219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier SzKdXPZxhAplwtKcXTjDiBbttio(Guid A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_SzKdXPZxhAplwtKcXTjDiBbttio_Internal_ControllerTemplateElementIdentifier_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00076ADC File Offset: 0x00074CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264256, RefRangeEnd = 264258, XrefRangeStart = 264221, XrefRangeEnd = 264256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap_InputManager wEdgHgfnXhSYKHYnmqwimmNIJCvh(Guid A_1, InputSource A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_wEdgHgfnXhSYKHYnmqwimmNIJCvh_Internal_HardwareJoystickMap_InputManager_Guid_InputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr3) : null;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00076B38 File Offset: 0x00074D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264291, RefRangeEnd = 264293, XrefRangeStart = 264258, XrefRangeEnd = 264291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap_InputManager CTouiXyVafnFyqVouqBvHpzSGNS(BridgedControllerHWInfo A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_CTouiXyVafnFyqVouqBvHpzSGNS_Internal_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr3) : null;
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00076B88 File Offset: 0x00074D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264293, XrefRangeEnd = 264308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap_InputManager kkyQograDygPNNxVCZQnJQOgWFt(HardwareJoystickMap A_1, BridgedControllerHWInfo A_2, bool A_3, out InputPlatform A_4, out int A_5, out HardwareJoystickMap.Platform A_6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_5;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_kkyQograDygPNNxVCZQnJQOgWFt_Private_HardwareJoystickMap_InputManager_HardwareJoystickMap_BridgedControllerHWInfo_Boolean_byref_InputPlatform_byref_Int32_byref_Platform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			A_6 = ((intPtr4 == 0) ? null : new HardwareJoystickMap.Platform(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr5) : null;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00076C3C File Offset: 0x00074E3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264330, RefRangeEnd = 264332, XrefRangeStart = 264308, XrefRangeEnd = 264330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap_InputManager FsOduOOSTscxakCEnNEAKNbjsBC(BridgedControllerHWInfo A_1, string A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_FsOduOOSTscxakCEnNEAKNbjsBC_Private_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr3) : null;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00076CA0 File Offset: 0x00074EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264335, RefRangeEnd = 264336, XrefRangeStart = 264332, XrefRangeEnd = 264335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwareJoystickMap_InputManager forUZeFAKlauosXgisbaQqKvBJv(BridgedControllerHWInfo A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_forUZeFAKlauosXgisbaQqKvBJv_Private_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap_InputManager>(intPtr3) : null;
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00076CF0 File Offset: 0x00074EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264355, RefRangeEnd = 264357, XrefRangeStart = 264336, XrefRangeEnd = 264355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void vgBffJXPVBahUYNNzDLnEcLGDfS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerDataFiles.NativeMethodInfoPtr_vgBffJXPVBahUYNNzDLnEcLGDfS_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00008A63 File Offset: 0x00006C63
		public ControllerDataFiles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00076D24 File Offset: 0x00074F24
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x00008A6C File Offset: 0x00006C6C
		public unsafe HardwareJoystickMap defaultHardwareJoystickMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_defaultHardwareJoystickMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HardwareJoystickMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_defaultHardwareJoystickMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00076D54 File Offset: 0x00074F54
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x00008A8B File Offset: 0x00006C8B
		public unsafe Il2CppReferenceArray<HardwareJoystickMap> hardwareJoystickMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_hardwareJoystickMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_hardwareJoystickMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00076D84 File Offset: 0x00074F84
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00008AAA File Offset: 0x00006CAA
		public unsafe Il2CppReferenceArray<HardwareJoystickTemplateMap> joystickTemplates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_joystickTemplates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardwareJoystickTemplateMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_joystickTemplates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00076DB4 File Offset: 0x00074FB4
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x00008AC9 File Offset: 0x00006CC9
		public unsafe bool mmJjXfccyBgITFvkrmRZgCDhtXh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_mmJjXfccyBgITFvkrmRZgCDhtXh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerDataFiles.NativeFieldInfoPtr_mmJjXfccyBgITFvkrmRZgCDhtXh)) = value;
			}
		}

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr_defaultHardwareJoystickMap;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_hardwareJoystickMaps;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr_joystickTemplates;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr_mmJjXfccyBgITFvkrmRZgCDhtXh;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultHardwareJoystickMapGuid_Public_get_Guid_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_get_JoystickTemplates_Public_get_Il2CppReferenceArray_1_HardwareJoystickTemplateMap_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_set_JoystickTemplates_Public_set_Void_Il2CppReferenceArray_1_HardwareJoystickTemplateMap_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_get_HardwareJoystickMaps_Public_get_Il2CppReferenceArray_1_HardwareJoystickMap_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_set_HardwareJoystickMaps_Public_set_Void_Il2CppReferenceArray_1_HardwareJoystickMap_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultHardwareJoystickMap_Public_get_HardwareJoystickMap_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultHardwareJoystickMap_Public_set_Void_HardwareJoystickMap_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickNames_Public_Il2CppStringArray_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_GetEditorJoystickNames_Public_Il2CppStringArray_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickGuids_Public_Il2CppStructArray_1_Guid_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickTemplateNames_Public_Il2CppStringArray_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickTemplateGuids_Public_Il2CppStructArray_1_Guid_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_GetHardwareJoystickMap_Public_HardwareJoystickMap_Guid_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_GetJoystickTemplate_Public_HardwareJoystickTemplateMap_Guid_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerTemplate_Public_IHardwareControllerTemplateMap_Guid_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_GetHardwareJoystickOrTemplateMap_Public_IHardwareControllerMap_Guid_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_SzKdXPZxhAplwtKcXTjDiBbttio_Internal_ControllerTemplateElementIdentifier_Guid_Int32_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_wEdgHgfnXhSYKHYnmqwimmNIJCvh_Internal_HardwareJoystickMap_InputManager_Guid_InputSource_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_CTouiXyVafnFyqVouqBvHpzSGNS_Internal_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_kkyQograDygPNNxVCZQnJQOgWFt_Private_HardwareJoystickMap_InputManager_HardwareJoystickMap_BridgedControllerHWInfo_Boolean_byref_InputPlatform_byref_Int32_byref_Platform_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_FsOduOOSTscxakCEnNEAKNbjsBC_Private_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_String_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_forUZeFAKlauosXgisbaQqKvBJv_Private_HardwareJoystickMap_InputManager_BridgedControllerHWInfo_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_vgBffJXPVBahUYNNzDLnEcLGDfS_Private_Void_0;
	}
}
