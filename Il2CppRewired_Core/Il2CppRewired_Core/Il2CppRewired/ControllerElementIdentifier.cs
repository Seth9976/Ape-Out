using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200013D RID: 317
	[Serializable]
	public sealed class ControllerElementIdentifier : Object
	{
		// Token: 0x060022BC RID: 8892 RVA: 0x000B18CC File Offset: 0x000AFACC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerElementIdentifier()
		{
			Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerElementIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr);
			ControllerElementIdentifier.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "_id");
			ControllerElementIdentifier.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "_name");
			ControllerElementIdentifier.NativeFieldInfoPtr__positiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "_positiveName");
			ControllerElementIdentifier.NativeFieldInfoPtr__negativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "_negativeName");
			ControllerElementIdentifier.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "_elementType");
			ControllerElementIdentifier.NativeFieldInfoPtr__compoundElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "_compoundElementType");
			ControllerElementIdentifier.NativeFieldInfoPtr_isMappableOnPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "isMappableOnPlatform");
			ControllerElementIdentifier.NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "HaBpMivpFGWfqAaGrZNSCbNTtAj");
			ControllerElementIdentifier.NativeFieldInfoPtr_TYpGUnYLzLjnQnGvIgsMudEAWGr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, "TYpGUnYLzLjnQnGvIgsMudEAWGr");
			ControllerElementIdentifier.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670745);
			ControllerElementIdentifier.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670746);
			ControllerElementIdentifier.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670747);
			ControllerElementIdentifier.NativeMethodInfoPtr_get_positiveName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670748);
			ControllerElementIdentifier.NativeMethodInfoPtr_set_positiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670749);
			ControllerElementIdentifier.NativeMethodInfoPtr_get_negativeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670750);
			ControllerElementIdentifier.NativeMethodInfoPtr_set_negativeName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670751);
			ControllerElementIdentifier.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670752);
			ControllerElementIdentifier.NativeMethodInfoPtr_get_compoundElementType_Public_get_CompoundControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670753);
			ControllerElementIdentifier.NativeMethodInfoPtr_get_isCompoundElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670754);
			ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670755);
			ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670756);
			ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerElementType_CompoundControllerElementType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670757);
			ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerElementType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670758);
			ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_ControllerElementIdentifier_Boolean_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670759);
			ControllerElementIdentifier.NativeMethodInfoPtr_Clone_Public_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670760);
			ControllerElementIdentifier.NativeMethodInfoPtr_GetDisplayName_Public_String_ControllerElementType_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670761);
			ControllerElementIdentifier.NativeMethodInfoPtr_GetDisplayName_Public_String_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670762);
			ControllerElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_elementType_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670763);
			ControllerElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_useEditorElementTypeOverride_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670764);
			ControllerElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_editorElementTypeOverride_Private_Virtual_Final_New_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670765);
			ControllerElementIdentifier.NativeMethodInfoPtr_hMMFgAWWhpFcxjYXArvaUcGeZHB_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670766);
			ControllerElementIdentifier.NativeMethodInfoPtr_get_BlankReadOnly_Internal_Static_get_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr, 100670767);
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000B1B7C File Offset: 0x000AFD7C
		public unsafe int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000B1BB8 File Offset: 0x000AFDB8
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x000B1BF0 File Offset: 0x000AFDF0
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 288113, RefRangeEnd = 288122, XrefRangeStart = 288113, XrefRangeEnd = 288113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x000B1C34 File Offset: 0x000AFE34
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x000B1C6C File Offset: 0x000AFE6C
		public unsafe string positiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_positiveName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 288122, RefRangeEnd = 288129, XrefRangeStart = 288122, XrefRangeEnd = 288122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_set_positiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x000B1CB0 File Offset: 0x000AFEB0
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x000B1CE8 File Offset: 0x000AFEE8
		public unsafe string negativeName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_negativeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 288129, RefRangeEnd = 288134, XrefRangeStart = 288129, XrefRangeEnd = 288129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_set_negativeName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x000B1D2C File Offset: 0x000AFF2C
		public unsafe ControllerElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000B1D68 File Offset: 0x000AFF68
		public unsafe CompoundControllerElementType compoundElementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_compoundElementType_Public_get_CompoundControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x000B1DA4 File Offset: 0x000AFFA4
		public unsafe bool isCompoundElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_isCompoundElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000B1DE0 File Offset: 0x000AFFE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000B1E1C File Offset: 0x000B001C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 288134, RefRangeEnd = 288141, XrefRangeStart = 288134, XrefRangeEnd = 288134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier(ControllerElementIdentifier source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Public_Void_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000B1E68 File Offset: 0x000B0068
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 288141, RefRangeEnd = 288174, XrefRangeStart = 288141, XrefRangeEnd = 288141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, CompoundControllerElementType compoundElementType, bool isMappableOnPlatform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(positiveName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(negativeName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compoundElementType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMappableOnPlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerElementType_CompoundControllerElementType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000B1F10 File Offset: 0x000B0110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288174, RefRangeEnd = 288177, XrefRangeStart = 288174, XrefRangeEnd = 288174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, bool isMappableOnPlatform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerElementType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000B1FAC File Offset: 0x000B01AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288177, XrefRangeEnd = 288178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier(ControllerElementIdentifier source, bool isMappableOnPlatform, ControllerElementType changedElementType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementIdentifier>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMappableOnPlatform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changedElementType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_ControllerElementIdentifier_Boolean_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000B2014 File Offset: 0x000B0214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288178, XrefRangeEnd = 288182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementIdentifier Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_Clone_Public_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000B2054 File Offset: 0x000B0254
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288189, RefRangeEnd = 288193, XrefRangeStart = 288182, XrefRangeEnd = 288189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actualElementType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_GetDisplayName_Public_String_ControllerElementType_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000B20A8 File Offset: 0x000B02A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288193, XrefRangeEnd = 288194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayName(AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisRange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_GetDisplayName_Public_String_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000B20EC File Offset: 0x000B02EC
		public unsafe Object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288194, XrefRangeEnd = 288197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_elementType_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x000B212C File Offset: 0x000B032C
		public unsafe bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_useEditorElementTypeOverride_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000B2168 File Offset: 0x000B0368
		public unsafe ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_editorElementTypeOverride_Private_Virtual_Final_New_get_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x000B21A4 File Offset: 0x000B03A4
		[CallerCount(0)]
		public unsafe void hMMFgAWWhpFcxjYXArvaUcGeZHB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_hMMFgAWWhpFcxjYXArvaUcGeZHB_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000B21D8 File Offset: 0x000B03D8
		public unsafe static ControllerElementIdentifier BlankReadOnly
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 288201, RefRangeEnd = 288203, XrefRangeStart = 288197, XrefRangeEnd = 288201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementIdentifier.NativeMethodInfoPtr_get_BlankReadOnly_Internal_Static_get_ControllerElementIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0000E018 File Offset: 0x0000C218
		public ControllerElementIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000B220C File Offset: 0x000B040C
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x0000E021 File Offset: 0x0000C221
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000B2234 File Offset: 0x000B0434
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x0000E03C File Offset: 0x0000C23C
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x000B225C File Offset: 0x000B045C
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x0000E05B File Offset: 0x0000C25B
		public unsafe string _positiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__positiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__positiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x000B2284 File Offset: 0x000B0484
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x0000E07A File Offset: 0x0000C27A
		public unsafe string _negativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__negativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__negativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000B22AC File Offset: 0x000B04AC
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x0000E099 File Offset: 0x0000C299
		public unsafe ControllerElementType _elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__elementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__elementType)) = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000B22D4 File Offset: 0x000B04D4
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		public unsafe CompoundControllerElementType _compoundElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__compoundElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr__compoundElementType)) = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000B22FC File Offset: 0x000B04FC
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x0000E0CF File Offset: 0x0000C2CF
		public unsafe bool isMappableOnPlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr_isMappableOnPlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr_isMappableOnPlatform)) = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000B2324 File Offset: 0x000B0524
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x0000E0EA File Offset: 0x0000C2EA
		public unsafe bool HaBpMivpFGWfqAaGrZNSCbNTtAj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementIdentifier.NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj)) = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000B234C File Offset: 0x000B054C
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x0000E105 File Offset: 0x0000C305
		public unsafe static ControllerElementIdentifier TYpGUnYLzLjnQnGvIgsMudEAWGr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControllerElementIdentifier.NativeFieldInfoPtr_TYpGUnYLzLjnQnGvIgsMudEAWGr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControllerElementIdentifier.NativeFieldInfoPtr_TYpGUnYLzLjnQnGvIgsMudEAWGr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeFieldInfoPtr__positiveName;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeFieldInfoPtr__negativeName;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeFieldInfoPtr__elementType;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeFieldInfoPtr__compoundElementType;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeFieldInfoPtr_isMappableOnPlatform;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeFieldInfoPtr_HaBpMivpFGWfqAaGrZNSCbNTtAj;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeFieldInfoPtr_TYpGUnYLzLjnQnGvIgsMudEAWGr;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_set_positiveName_Internal_set_Void_String_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_set_negativeName_Internal_set_Void_String_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_get_compoundElementType_Public_get_CompoundControllerElementType_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_get_isCompoundElement_Internal_get_Boolean_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerElementIdentifier_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerElementType_CompoundControllerElementType_Boolean_0;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_String_String_ControllerElementType_Boolean_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ControllerElementIdentifier_Boolean_ControllerElementType_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_ControllerElementIdentifier_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_String_ControllerElementType_AxisRange_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_String_AxisRange_0;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_elementType_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_useEditorElementTypeOverride_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerElementIdentifierCommon_Internal_get_editorElementTypeOverride_Private_Virtual_Final_New_get_ControllerElementType_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_hMMFgAWWhpFcxjYXArvaUcGeZHB_Private_Void_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr_get_BlankReadOnly_Internal_Static_get_ControllerElementIdentifier_0;
	}
}
