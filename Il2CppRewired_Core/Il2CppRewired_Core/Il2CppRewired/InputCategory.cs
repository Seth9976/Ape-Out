using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000159 RID: 345
	[Serializable]
	public class InputCategory : Object
	{
		// Token: 0x060026EB RID: 9963 RVA: 0x000C5614 File Offset: 0x000C3814
		// Note: this type is marked as 'beforefieldinit'.
		static InputCategory()
		{
			Il2CppClassPointerStore<InputCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputCategory>.NativeClassPtr);
			InputCategory.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, "_name");
			InputCategory.NativeFieldInfoPtr__descriptiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, "_descriptiveName");
			InputCategory.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, "_tag");
			InputCategory.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, "_id");
			InputCategory.NativeFieldInfoPtr__userAssignable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, "_userAssignable");
			InputCategory.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671664);
			InputCategory.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671665);
			InputCategory.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671666);
			InputCategory.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671667);
			InputCategory.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671668);
			InputCategory.NativeMethodInfoPtr_set_tag_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671669);
			InputCategory.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671670);
			InputCategory.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671671);
			InputCategory.NativeMethodInfoPtr_get_userAssignable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671672);
			InputCategory.NativeMethodInfoPtr_set_userAssignable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671673);
			InputCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671674);
			InputCategory.NativeMethodInfoPtr__ctor_Public_Void_InputCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCategory>.NativeClassPtr, 100671675);
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000C5798 File Offset: 0x000C3998
		// (set) Token: 0x060026ED RID: 9965 RVA: 0x000C57D0 File Offset: 0x000C39D0
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x000C5814 File Offset: 0x000C3A14
		// (set) Token: 0x060026EF RID: 9967 RVA: 0x000C584C File Offset: 0x000C3A4C
		public unsafe string descriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000C5890 File Offset: 0x000C3A90
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x000C58C8 File Offset: 0x000C3AC8
		public unsafe string tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_set_tag_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x000C590C File Offset: 0x000C3B0C
		// (set) Token: 0x060026F3 RID: 9971 RVA: 0x000C5948 File Offset: 0x000C3B48
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x000C5988 File Offset: 0x000C3B88
		// (set) Token: 0x060026F5 RID: 9973 RVA: 0x000C59C4 File Offset: 0x000C3BC4
		public unsafe bool userAssignable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_get_userAssignable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr_set_userAssignable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000C5A04 File Offset: 0x000C3C04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputCategory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000C5A40 File Offset: 0x000C3C40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295078, RefRangeEnd = 295081, XrefRangeStart = 295078, XrefRangeEnd = 295078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputCategory(InputCategory source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputCategory>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputCategory.NativeMethodInfoPtr__ctor_Public_Void_InputCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public InputCategory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000C5A8C File Offset: 0x000C3C8C
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x0000F3D1 File Offset: 0x0000D5D1
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000C5AB4 File Offset: 0x000C3CB4
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		public unsafe string _descriptiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__descriptiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__descriptiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000C5ADC File Offset: 0x000C3CDC
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x0000F40F File Offset: 0x0000D60F
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000C5B04 File Offset: 0x000C3D04
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x0000F42E File Offset: 0x0000D62E
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000C5B2C File Offset: 0x000C3D2C
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x0000F449 File Offset: 0x0000D649
		public unsafe bool _userAssignable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__userAssignable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputCategory.NativeFieldInfoPtr__userAssignable)) = value;
			}
		}

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeFieldInfoPtr__descriptiveName;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeFieldInfoPtr__userAssignable;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Internal_set_Void_String_0;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_get_userAssignable_Public_get_Boolean_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_set_userAssignable_Internal_set_Void_Boolean_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputCategory_0;
	}
}
