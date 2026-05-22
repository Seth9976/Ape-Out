using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200013E RID: 318
	[Serializable]
	public class ControllerTemplateElementIdentifier : Object
	{
		// Token: 0x060022E7 RID: 8935 RVA: 0x000B2374 File Offset: 0x000B0574
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateElementIdentifier()
		{
			Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerTemplateElementIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr);
			ControllerTemplateElementIdentifier.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, "_id");
			ControllerTemplateElementIdentifier.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, "_name");
			ControllerTemplateElementIdentifier.NativeFieldInfoPtr__positiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, "_positiveName");
			ControllerTemplateElementIdentifier.NativeFieldInfoPtr__negativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, "_negativeName");
			ControllerTemplateElementIdentifier.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, "_elementType");
			ControllerTemplateElementIdentifier.NativeFieldInfoPtr_isMappableOnPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, "isMappableOnPlatform");
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670768);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670769);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670770);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_positiveName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670771);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_set_positiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670772);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_negativeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670773);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_set_negativeName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670774);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_elementType_Public_Virtual_Final_New_get_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670775);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_useEditorElementTypeOverride_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670776);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_editorElementTypeOverride_Internal_Virtual_New_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670777);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670778);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670779);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerTemplateElementType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670780);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_ControllerTemplateElementIdentifier_ControllerTemplateElementType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670781);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Clone_Public_Virtual_New_ControllerTemplateElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670782);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_GetDisplayName_Public_String_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670783);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_ToControllerElementIdentifier_Internal_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670784);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_elementType_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670785);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_useEditorElementTypeOverride_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670786);
			ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_editorElementTypeOverride_Private_Virtual_Final_New_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr, 100670787);
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000B25AC File Offset: 0x000B07AC
		public unsafe virtual int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000B25E8 File Offset: 0x000B07E8
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x000B2620 File Offset: 0x000B0820
		public unsafe virtual string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x000B2664 File Offset: 0x000B0864
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x000B269C File Offset: 0x000B089C
		public unsafe virtual string positiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_positiveName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_set_positiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x000B26E0 File Offset: 0x000B08E0
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x000B2718 File Offset: 0x000B0918
		public unsafe virtual string negativeName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_negativeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_set_negativeName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000B275C File Offset: 0x000B095C
		public unsafe virtual ControllerTemplateElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_elementType_Public_Virtual_Final_New_get_ControllerTemplateElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x000B2798 File Offset: 0x000B0998
		public unsafe virtual bool useEditorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_useEditorElementTypeOverride_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x000B27E0 File Offset: 0x000B09E0
		public unsafe virtual ControllerElementType editorElementTypeOverride
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288203, XrefRangeEnd = 288208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplateElementIdentifier.NativeMethodInfoPtr_get_editorElementTypeOverride_Internal_Virtual_New_get_ControllerElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000B2828 File Offset: 0x000B0A28
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x000B2864 File Offset: 0x000B0A64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288208, RefRangeEnd = 288212, XrefRangeStart = 288208, XrefRangeEnd = 288208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x000B28B0 File Offset: 0x000B0AB0
		[CallerCount(0)]
		public unsafe ControllerTemplateElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, bool isMappableOnPlatform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(positiveName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(negativeName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMappableOnPlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerTemplateElementType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x000B294C File Offset: 0x000B0B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288212, XrefRangeEnd = 288213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementIdentifier>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changedElementType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMappableOnPlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_ControllerTemplateElementIdentifier_ControllerTemplateElementType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000B29B4 File Offset: 0x000B0BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288213, XrefRangeEnd = 288217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ControllerTemplateElementIdentifier Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Clone_Public_Virtual_New_ControllerTemplateElementIdentifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000B2A00 File Offset: 0x000B0C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288217, XrefRangeEnd = 288223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayName(AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisRange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_GetDisplayName_Public_String_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000B2A44 File Offset: 0x000B0C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288223, XrefRangeEnd = 288228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier ToControllerElementIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_ToControllerElementIdentifier_Internal_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x000B2A84 File Offset: 0x000B0C84
		public unsafe virtual Object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288228, XrefRangeEnd = 288231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_elementType_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x000B2AC4 File Offset: 0x000B0CC4
		public unsafe virtual bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_useEditorElementTypeOverride_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x000B2B00 File Offset: 0x000B0D00
		public unsafe virtual ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_editorElementTypeOverride_Private_Virtual_Final_New_get_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0000E117 File Offset: 0x0000C317
		public ControllerTemplateElementIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000B2B3C File Offset: 0x000B0D3C
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x0000E120 File Offset: 0x0000C320
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000B2B64 File Offset: 0x000B0D64
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x0000E13B File Offset: 0x0000C33B
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000B2B8C File Offset: 0x000B0D8C
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x0000E15A File Offset: 0x0000C35A
		public unsafe string _positiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__positiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__positiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000B2BB4 File Offset: 0x000B0DB4
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x0000E179 File Offset: 0x0000C379
		public unsafe string _negativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__negativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__negativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000B2BDC File Offset: 0x000B0DDC
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0000E198 File Offset: 0x0000C398
		public unsafe ControllerTemplateElementType _elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__elementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr__elementType)) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000B2C04 File Offset: 0x000B0E04
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0000E1B3 File Offset: 0x0000C3B3
		public unsafe bool isMappableOnPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr_isMappableOnPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier.NativeFieldInfoPtr_isMappableOnPlatform)) = value;
			}
		}

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeFieldInfoPtr__positiveName;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeFieldInfoPtr__negativeName;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeFieldInfoPtr__elementType;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeFieldInfoPtr_isMappableOnPlatform;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr_set_positiveName_Internal_set_Void_String_0;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_set_negativeName_Internal_set_Void_String_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_Virtual_Final_New_get_ControllerTemplateElementType_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_get_useEditorElementTypeOverride_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_get_editorElementTypeOverride_Internal_Virtual_New_get_ControllerElementType_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementIdentifier_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerTemplateElementType_Boolean_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ControllerTemplateElementIdentifier_ControllerTemplateElementType_Boolean_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_ControllerTemplateElementIdentifier_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_String_AxisRange_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeMethodInfoPtr_ToControllerElementIdentifier_Internal_ControllerElementIdentifier_0;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_elementType_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_useEditorElementTypeOverride_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_editorElementTypeOverride_Private_Virtual_Final_New_get_ControllerElementType_0;
	}
}
