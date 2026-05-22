using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Data
{
	// Token: 0x02000146 RID: 326
	[Serializable]
	public sealed class ControllerSetSelector_Editor : Object
	{
		// Token: 0x060023BA RID: 9146 RVA: 0x000B5560 File Offset: 0x000B3760
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerSetSelector_Editor()
		{
			Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ControllerSetSelector_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr);
			ControllerSetSelector_Editor.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_type");
			ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_controllerType");
			ControllerSetSelector_Editor.NativeFieldInfoPtr__hardwareTypeGuidString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_hardwareTypeGuidString");
			ControllerSetSelector_Editor.NativeFieldInfoPtr__hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_hardwareIdentifier");
			ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerTemplateTypeGuidString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_controllerTemplateTypeGuidString");
			ControllerSetSelector_Editor.NativeFieldInfoPtr__deviceInstanceGuidString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_deviceInstanceGuidString");
			ControllerSetSelector_Editor.NativeFieldInfoPtr__customControllerSourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_customControllerSourceId");
			ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, "_controllerId");
			ControllerSetSelector_Editor.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100670996);
			ControllerSetSelector_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100670997);
			ControllerSetSelector_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerSetSelector_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100670998);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100670999);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671000);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671001);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671002);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671003);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671004);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_hardwareTypeGuidString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671005);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_hardwareTypeGuidString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671006);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671007);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671008);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerTemplateTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671009);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerTemplateTypeGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671010);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerTemplateTypeGuidString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671011);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerTemplateTypeGuidString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671012);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671013);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671014);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_deviceInstanceGuidString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671015);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_deviceInstanceGuidString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671016);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671017);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671018);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671019);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_set_customControllerSourceId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671020);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_KzxgQymukAWECkGKAJysAszGYvG_Internal_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671021);
			ControllerSetSelector_Editor.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr, 100671022);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x000B584C File Offset: 0x000B3A4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289893, RefRangeEnd = 289895, XrefRangeStart = 289886, XrefRangeEnd = 289893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerSetSelector_Editor(ControllerSetSelector.Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x000B5894 File Offset: 0x000B3A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289895, XrefRangeEnd = 289902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerSetSelector_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x000B58D0 File Offset: 0x000B3AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289902, RefRangeEnd = 289903, XrefRangeStart = 289902, XrefRangeEnd = 289902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerSetSelector_Editor(ControllerSetSelector_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSetSelector_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerSetSelector_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000B591C File Offset: 0x000B3B1C
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x000B5958 File Offset: 0x000B3B58
		public unsafe ControllerSetSelector.Type type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000B5998 File Offset: 0x000B3B98
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x000B59D4 File Offset: 0x000B3BD4
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x000B5A14 File Offset: 0x000B3C14
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x000B5A50 File Offset: 0x000B3C50
		public unsafe Guid hardwareTypeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289903, XrefRangeEnd = 289907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289907, XrefRangeEnd = 289910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x000B5A90 File Offset: 0x000B3C90
		// (set) Token: 0x060023C5 RID: 9157 RVA: 0x000B5AC8 File Offset: 0x000B3CC8
		public unsafe string hardwareTypeGuidString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_hardwareTypeGuidString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_hardwareTypeGuidString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x000B5B0C File Offset: 0x000B3D0C
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x000B5B44 File Offset: 0x000B3D44
		public unsafe string hardwareIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000B5B88 File Offset: 0x000B3D88
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x000B5BC4 File Offset: 0x000B3DC4
		public unsafe Guid controllerTemplateTypeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289910, XrefRangeEnd = 289914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerTemplateTypeGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264424, RefRangeEnd = 264425, XrefRangeStart = 264424, XrefRangeEnd = 264425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerTemplateTypeGuid_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x000B5C04 File Offset: 0x000B3E04
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x000B5C3C File Offset: 0x000B3E3C
		public unsafe string controllerTemplateTypeGuidString
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerTemplateTypeGuidString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerTemplateTypeGuidString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x000B5C80 File Offset: 0x000B3E80
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x000B5CBC File Offset: 0x000B3EBC
		public unsafe Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289914, XrefRangeEnd = 289918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289918, XrefRangeEnd = 289921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x000B5CFC File Offset: 0x000B3EFC
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x000B5D34 File Offset: 0x000B3F34
		public unsafe string deviceInstanceGuidString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_deviceInstanceGuidString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_deviceInstanceGuidString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x000B5D78 File Offset: 0x000B3F78
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x000B5DB4 File Offset: 0x000B3FB4
		public unsafe int controllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x000B5DF4 File Offset: 0x000B3FF4
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x000B5E30 File Offset: 0x000B4030
		public unsafe int customControllerSourceId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_set_customControllerSourceId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000B5E70 File Offset: 0x000B4070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289938, RefRangeEnd = 289940, XrefRangeStart = 289921, XrefRangeEnd = 289938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerSetSelector KzxgQymukAWECkGKAJysAszGYvG()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_KzxgQymukAWECkGKAJysAszGYvG_Internal_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000B5EB0 File Offset: 0x000B40B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289940, XrefRangeEnd = 289944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ArcItWcEwGFnEyxJxvmxUBgQabYI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerSetSelector_Editor.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0000E5FB File Offset: 0x0000C7FB
		public ControllerSetSelector_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x000B5EF0 File Offset: 0x000B40F0
		// (set) Token: 0x060023D8 RID: 9176 RVA: 0x0000E604 File Offset: 0x0000C804
		public unsafe ControllerSetSelector.Type _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x000B5F18 File Offset: 0x000B4118
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x0000E61F File Offset: 0x0000C81F
		public unsafe ControllerType _controllerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerType)) = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x000B5F40 File Offset: 0x000B4140
		// (set) Token: 0x060023DC RID: 9180 RVA: 0x0000E63A File Offset: 0x0000C83A
		public unsafe string _hardwareTypeGuidString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__hardwareTypeGuidString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__hardwareTypeGuidString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x000B5F68 File Offset: 0x000B4168
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x0000E659 File Offset: 0x0000C859
		public unsafe string _hardwareIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__hardwareIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__hardwareIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x000B5F90 File Offset: 0x000B4190
		// (set) Token: 0x060023E0 RID: 9184 RVA: 0x0000E678 File Offset: 0x0000C878
		public unsafe string _controllerTemplateTypeGuidString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerTemplateTypeGuidString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerTemplateTypeGuidString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x000B5FB8 File Offset: 0x000B41B8
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x0000E697 File Offset: 0x0000C897
		public unsafe string _deviceInstanceGuidString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__deviceInstanceGuidString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__deviceInstanceGuidString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x000B5FE0 File Offset: 0x000B41E0
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x0000E6B6 File Offset: 0x0000C8B6
		public unsafe int _customControllerSourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__customControllerSourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__customControllerSourceId)) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x000B6008 File Offset: 0x000B4208
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x0000E6D1 File Offset: 0x0000C8D1
		public unsafe int _controllerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerSetSelector_Editor.NativeFieldInfoPtr__controllerId)) = value;
			}
		}

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeFieldInfoPtr__controllerType;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeFieldInfoPtr__hardwareTypeGuidString;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeFieldInfoPtr__hardwareIdentifier;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeFieldInfoPtr__controllerTemplateTypeGuidString;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeFieldInfoPtr__deviceInstanceGuidString;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeFieldInfoPtr__customControllerSourceId;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeFieldInfoPtr__controllerId;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerSetSelector_Editor_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_Type_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareTypeGuidString_Public_get_String_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_set_hardwareTypeGuidString_Public_set_Void_String_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerTemplateTypeGuid_Public_get_Guid_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerTemplateTypeGuid_Public_set_Void_Guid_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerTemplateTypeGuidString_Public_get_String_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerTemplateTypeGuidString_Public_set_Void_String_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuidString_Public_get_String_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_set_deviceInstanceGuidString_Public_set_Void_String_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_set_customControllerSourceId_Public_set_Void_Int32_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_KzxgQymukAWECkGKAJysAszGYvG_Internal_ControllerSetSelector_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0;
	}
}
