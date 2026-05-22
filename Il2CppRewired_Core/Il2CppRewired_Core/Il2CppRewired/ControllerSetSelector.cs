using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public sealed class ControllerSetSelector : Object
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0003403C File Offset: 0x0003223C
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerSetSelector()
		{
			Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerSetSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr);
			ControllerSetSelector.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, "_type");
			ControllerSetSelector.NativeFieldInfoPtr__controllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, "_controllerType");
			ControllerSetSelector.NativeFieldInfoPtr__guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, "_guid");
			ControllerSetSelector.NativeFieldInfoPtr__hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, "_hardwareIdentifier");
			ControllerSetSelector.NativeFieldInfoPtr__controllerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, "_controllerId");
			ControllerSetSelector.NativeFieldInfoPtr_qJwkTVdSMTmQwSJSfIMLZHxAEBY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, "qJwkTVdSMTmQwSJSfIMLZHxAEBY");
			ControllerSetSelector.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663571);
			ControllerSetSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663572);
			ControllerSetSelector.NativeMethodInfoPtr__ctor_Public_Void_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663573);
			ControllerSetSelector.NativeMethodInfoPtr__ctor_Internal_Void_Type_ControllerType_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663574);
			ControllerSetSelector.NativeMethodInfoPtr_get_hasControllerType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663575);
			ControllerSetSelector.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663576);
			ControllerSetSelector.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663577);
			ControllerSetSelector.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663578);
			ControllerSetSelector.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663579);
			ControllerSetSelector.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663580);
			ControllerSetSelector.NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663581);
			ControllerSetSelector.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663582);
			ControllerSetSelector.NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663583);
			ControllerSetSelector.NativeMethodInfoPtr_get_controllerTemplateTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663584);
			ControllerSetSelector.NativeMethodInfoPtr_set_controllerTemplateTypeGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663585);
			ControllerSetSelector.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663586);
			ControllerSetSelector.NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663587);
			ControllerSetSelector.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663588);
			ControllerSetSelector.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663589);
			ControllerSetSelector.NativeMethodInfoPtr_Matches_Public_Boolean_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663590);
			ControllerSetSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663591);
			ControllerSetSelector.NativeMethodInfoPtr_zjGkruYCBzDzFlndFHrxYGFULBS_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663592);
			ControllerSetSelector.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663593);
			ControllerSetSelector.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663594);
			ControllerSetSelector.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663595);
			ControllerSetSelector.NativeMethodInfoPtr_SelectAll_Public_Static_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663596);
			ControllerSetSelector.NativeMethodInfoPtr_SelectControllerType_Public_Static_ControllerSetSelector_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663597);
			ControllerSetSelector.NativeMethodInfoPtr_SelectHardwareType_Public_Static_ControllerSetSelector_ControllerType_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663598);
			ControllerSetSelector.NativeMethodInfoPtr_SelectHardwareType_Public_Static_ControllerSetSelector_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663599);
			ControllerSetSelector.NativeMethodInfoPtr_SelectControllerTemplateType_Public_Static_ControllerSetSelector_ControllerType_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663600);
			ControllerSetSelector.NativeMethodInfoPtr_SelectControllerTemplateType_Public_Static_ControllerSetSelector_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663601);
			ControllerSetSelector.NativeMethodInfoPtr_SelectPersistentControllerInstance_Public_Static_ControllerSetSelector_ControllerType_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663602);
			ControllerSetSelector.NativeMethodInfoPtr_SelectPersistentControllerInstance_Public_Static_ControllerSetSelector_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663603);
			ControllerSetSelector.NativeMethodInfoPtr_SelectSessionControllerInstance_Public_Static_ControllerSetSelector_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663604);
			ControllerSetSelector.NativeMethodInfoPtr_SelectSessionControllerInstance_Public_Static_ControllerSetSelector_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr, 100663605);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000343A0 File Offset: 0x000325A0
		[CallerCount(0)]
		public unsafe ControllerSetSelector(ControllerSetSelector.Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000343E8 File Offset: 0x000325E8
		[CallerCount(0)]
		public unsafe ControllerSetSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00034424 File Offset: 0x00032624
		[CallerCount(0)]
		public unsafe ControllerSetSelector(ControllerSetSelector source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr__ctor_Public_Void_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00034470 File Offset: 0x00032670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243412, XrefRangeEnd = 243416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerSetSelector(ControllerSetSelector.Type type, ControllerType controllerType, string guid, string hardwareIdentifier, int controllerId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSetSelector>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr__ctor_Internal_Void_Type_ControllerType_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000344F8 File Offset: 0x000326F8
		public unsafe bool hasControllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_hasControllerType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00034534 File Offset: 0x00032734
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00034570 File Offset: 0x00032770
		public unsafe ControllerSetSelector.Type type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243416, XrefRangeEnd = 243422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000345B0 File Offset: 0x000327B0
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000345EC File Offset: 0x000327EC
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0003462C File Offset: 0x0003282C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00034668 File Offset: 0x00032868
		public unsafe Guid hardwareTypeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243422, XrefRangeEnd = 243423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 243429, RefRangeEnd = 243431, XrefRangeStart = 243423, XrefRangeEnd = 243429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000346A8 File Offset: 0x000328A8
		// (set) Token: 0x060001BE RID: 446 RVA: 0x000346E0 File Offset: 0x000328E0
		public unsafe string hardwareIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00034724 File Offset: 0x00032924
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00034760 File Offset: 0x00032960
		public unsafe Guid controllerTemplateTypeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243431, XrefRangeEnd = 243432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_controllerTemplateTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 243438, RefRangeEnd = 243440, XrefRangeStart = 243432, XrefRangeEnd = 243438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_set_controllerTemplateTypeGuid_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000347A0 File Offset: 0x000329A0
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x000347DC File Offset: 0x000329DC
		public unsafe Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243440, XrefRangeEnd = 243441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 243447, RefRangeEnd = 243449, XrefRangeStart = 243441, XrefRangeEnd = 243447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0003481C File Offset: 0x00032A1C
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00034858 File Offset: 0x00032A58
		public unsafe int controllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00034898 File Offset: 0x00032A98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243460, RefRangeEnd = 243463, XrefRangeStart = 243449, XrefRangeEnd = 243460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(Controller controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_Matches_Public_Boolean_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000348E8 File Offset: 0x00032AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243463, XrefRangeEnd = 243497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00034920 File Offset: 0x00032B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243497, XrefRangeEnd = 243503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void zjGkruYCBzDzFlndFHrxYGFULBS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_zjGkruYCBzDzFlndFHrxYGFULBS_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00034954 File Offset: 0x00032B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243503, XrefRangeEnd = 243507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00034988 File Offset: 0x00032B88
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000349BC File Offset: 0x00032BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243507, XrefRangeEnd = 243510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ArcItWcEwGFnEyxJxvmxUBgQabYI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000349FC File Offset: 0x00032BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243510, XrefRangeEnd = 243513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectAll_Public_Static_ControllerSetSelector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00034A30 File Offset: 0x00032C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243513, XrefRangeEnd = 243516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectControllerType(ControllerType controllerType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectControllerType_Public_Static_ControllerSetSelector_ControllerType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00034A70 File Offset: 0x00032C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243516, XrefRangeEnd = 243520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectHardwareType(ControllerType controllerType, Guid hardwareTypeGuid, string hardwareIdentifier)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardwareTypeGuid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectHardwareType_Public_Static_ControllerSetSelector_ControllerType_Guid_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00034AD0 File Offset: 0x00032CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243520, XrefRangeEnd = 243527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectHardwareType(Controller controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectHardwareType_Public_Static_ControllerSetSelector_Controller_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00034B14 File Offset: 0x00032D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243527, XrefRangeEnd = 243531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectControllerTemplateType(ControllerType controllerType, Guid controllerTemplateTypeGuid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerTemplateTypeGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectControllerTemplateType_Public_Static_ControllerSetSelector_ControllerType_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00034B64 File Offset: 0x00032D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243531, XrefRangeEnd = 243541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectControllerTemplateType(IControllerTemplate controllerTemplate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerTemplate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectControllerTemplateType_Public_Static_ControllerSetSelector_IControllerTemplate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00034BA8 File Offset: 0x00032DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243541, XrefRangeEnd = 243545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectPersistentControllerInstance(ControllerType controllerType, Guid deviceInstanceGuid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceInstanceGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectPersistentControllerInstance_Public_Static_ControllerSetSelector_ControllerType_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00034BF8 File Offset: 0x00032DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243545, XrefRangeEnd = 243550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectPersistentControllerInstance(Controller controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectPersistentControllerInstance_Public_Static_ControllerSetSelector_Controller_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00034C3C File Offset: 0x00032E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243550, XrefRangeEnd = 243553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectSessionControllerInstance(ControllerType controllerType, int controllerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectSessionControllerInstance_Public_Static_ControllerSetSelector_ControllerType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00034C8C File Offset: 0x00032E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243553, XrefRangeEnd = 243557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerSetSelector SelectSessionControllerInstance(Controller controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector.NativeMethodInfoPtr_SelectSessionControllerInstance_Public_Static_ControllerSetSelector_Controller_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002804 File Offset: 0x00000A04
		public ControllerSetSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00034CD0 File Offset: 0x00032ED0
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000280D File Offset: 0x00000A0D
		public unsafe ControllerSetSelector.Type _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00034CF8 File Offset: 0x00032EF8
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002828 File Offset: 0x00000A28
		public unsafe ControllerType _controllerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__controllerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__controllerType)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00034D20 File Offset: 0x00032F20
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002843 File Offset: 0x00000A43
		public unsafe string _guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00034D48 File Offset: 0x00032F48
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002862 File Offset: 0x00000A62
		public unsafe string _hardwareIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__hardwareIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__hardwareIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00034D70 File Offset: 0x00032F70
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002881 File Offset: 0x00000A81
		public unsafe int _controllerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__controllerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr__controllerId)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00034D98 File Offset: 0x00032F98
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000289C File Offset: 0x00000A9C
		public unsafe Guid qJwkTVdSMTmQwSJSfIMLZHxAEBY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr_qJwkTVdSMTmQwSJSfIMLZHxAEBY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector.NativeFieldInfoPtr_qJwkTVdSMTmQwSJSfIMLZHxAEBY)) = value;
			}
		}

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr__controllerType;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr__guid;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr__hardwareIdentifier;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr__controllerId;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_qJwkTVdSMTmQwSJSfIMLZHxAEBY;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerSetSelector_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ControllerType_String_String_Int32_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_hasControllerType_Internal_get_Boolean_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_Type_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerTemplateTypeGuid_Public_get_Guid_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerTemplateTypeGuid_Public_set_Void_Guid_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_Controller_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_zjGkruYCBzDzFlndFHrxYGFULBS_Private_Void_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Public_Static_ControllerSetSelector_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_SelectControllerType_Public_Static_ControllerSetSelector_ControllerType_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_SelectHardwareType_Public_Static_ControllerSetSelector_ControllerType_Guid_String_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_SelectHardwareType_Public_Static_ControllerSetSelector_Controller_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_SelectControllerTemplateType_Public_Static_ControllerSetSelector_ControllerType_Guid_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_SelectControllerTemplateType_Public_Static_ControllerSetSelector_IControllerTemplate_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_SelectPersistentControllerInstance_Public_Static_ControllerSetSelector_ControllerType_Guid_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_SelectPersistentControllerInstance_Public_Static_ControllerSetSelector_Controller_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_SelectSessionControllerInstance_Public_Static_ControllerSetSelector_ControllerType_Int32_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_SelectSessionControllerInstance_Public_Static_ControllerSetSelector_Controller_0;

		// Token: 0x0200021E RID: 542
		[OriginalName("Rewired_Core.dll", "", "Type")]
		public enum Type
		{
			// Token: 0x04002EED RID: 12013
			All,
			// Token: 0x04002EEE RID: 12014
			ControllerType,
			// Token: 0x04002EEF RID: 12015
			HardwareType,
			// Token: 0x04002EF0 RID: 12016
			ControllerTemplateType,
			// Token: 0x04002EF1 RID: 12017
			PersistentControllerInstance,
			// Token: 0x04002EF2 RID: 12018
			SessionControllerInstance
		}
	}
}
