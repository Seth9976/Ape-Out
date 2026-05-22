using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000157 RID: 343
	[Serializable]
	public sealed class InputAction : Object
	{
		// Token: 0x06002654 RID: 9812 RVA: 0x000C3410 File Offset: 0x000C1610
		// Note: this type is marked as 'beforefieldinit'.
		static InputAction()
		{
			Il2CppClassPointerStore<InputAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputAction>.NativeClassPtr);
			InputAction.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_id");
			InputAction.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_name");
			InputAction.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_type");
			InputAction.NativeFieldInfoPtr__descriptiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_descriptiveName");
			InputAction.NativeFieldInfoPtr__positiveDescriptiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_positiveDescriptiveName");
			InputAction.NativeFieldInfoPtr__negativeDescriptiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_negativeDescriptiveName");
			InputAction.NativeFieldInfoPtr__behaviorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_behaviorId");
			InputAction.NativeFieldInfoPtr__userAssignable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_userAssignable");
			InputAction.NativeFieldInfoPtr__categoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "_categoryId");
			InputAction.NativeFieldInfoPtr_kmczbDXjjCpDSAbiTizuCvHZHxn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "kmczbDXjjCpDSAbiTizuCvHZHxn");
			InputAction.NativeFieldInfoPtr_uWbCYomoHMJmbvloCLuuIvBMnKE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAction>.NativeClassPtr, "uWbCYomoHMJmbvloCLuuIvBMnKE");
			InputAction.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671585);
			InputAction.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671586);
			InputAction.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671587);
			InputAction.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671588);
			InputAction.NativeMethodInfoPtr_get_type_Public_get_InputActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671589);
			InputAction.NativeMethodInfoPtr_set_type_Internal_set_Void_InputActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671590);
			InputAction.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671591);
			InputAction.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671592);
			InputAction.NativeMethodInfoPtr_get_positiveDescriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671593);
			InputAction.NativeMethodInfoPtr_set_positiveDescriptiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671594);
			InputAction.NativeMethodInfoPtr_get_negativeDescriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671595);
			InputAction.NativeMethodInfoPtr_set_negativeDescriptiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671596);
			InputAction.NativeMethodInfoPtr_get_behaviorId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671597);
			InputAction.NativeMethodInfoPtr_set_behaviorId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671598);
			InputAction.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671599);
			InputAction.NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671600);
			InputAction.NativeMethodInfoPtr_get_userAssignable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671601);
			InputAction.NativeMethodInfoPtr_set_userAssignable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671602);
			InputAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671603);
			InputAction.NativeMethodInfoPtr__ctor_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671604);
			InputAction.NativeMethodInfoPtr_Clone_Public_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAction>.NativeClassPtr, 100671605);
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x000C36C0 File Offset: 0x000C18C0
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x000C36FC File Offset: 0x000C18FC
		public unsafe int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x000C373C File Offset: 0x000C193C
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x000C3774 File Offset: 0x000C1974
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x000C37B8 File Offset: 0x000C19B8
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x000C37F4 File Offset: 0x000C19F4
		public unsafe InputActionType type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_type_Public_get_InputActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_type_Internal_set_Void_InputActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x000C3834 File Offset: 0x000C1A34
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x000C386C File Offset: 0x000C1A6C
		public unsafe string descriptiveName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000C38B0 File Offset: 0x000C1AB0
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x000C38E8 File Offset: 0x000C1AE8
		public unsafe string positiveDescriptiveName
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 294747, RefRangeEnd = 294755, XrefRangeStart = 294741, XrefRangeEnd = 294747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_positiveDescriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294755, XrefRangeEnd = 294757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_positiveDescriptiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000C392C File Offset: 0x000C1B2C
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x000C3964 File Offset: 0x000C1B64
		public unsafe string negativeDescriptiveName
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 294763, RefRangeEnd = 294771, XrefRangeStart = 294757, XrefRangeEnd = 294763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_negativeDescriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294771, XrefRangeEnd = 294773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_negativeDescriptiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x000C39A8 File Offset: 0x000C1BA8
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x000C39E4 File Offset: 0x000C1BE4
		public unsafe int behaviorId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_behaviorId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_behaviorId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x000C3A24 File Offset: 0x000C1C24
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x000C3A60 File Offset: 0x000C1C60
		public unsafe int categoryId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x000C3AA0 File Offset: 0x000C1CA0
		// (set) Token: 0x06002666 RID: 9830 RVA: 0x000C3ADC File Offset: 0x000C1CDC
		public unsafe bool userAssignable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_get_userAssignable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_set_userAssignable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000C3B1C File Offset: 0x000C1D1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000C3B58 File Offset: 0x000C1D58
		[CallerCount(0)]
		public unsafe InputAction(InputAction source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr__ctor_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000C3BA4 File Offset: 0x000C1DA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294776, RefRangeEnd = 294779, XrefRangeStart = 294773, XrefRangeEnd = 294776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAction Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAction.NativeMethodInfoPtr_Clone_Public_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x0000F004 File Offset: 0x0000D204
		public InputAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x000C3BE4 File Offset: 0x000C1DE4
		// (set) Token: 0x0600266C RID: 9836 RVA: 0x0000F00D File Offset: 0x0000D20D
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x000C3C0C File Offset: 0x000C1E0C
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x0000F028 File Offset: 0x0000D228
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x000C3C34 File Offset: 0x000C1E34
		// (set) Token: 0x06002670 RID: 9840 RVA: 0x0000F047 File Offset: 0x0000D247
		public unsafe InputActionType _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x000C3C5C File Offset: 0x000C1E5C
		// (set) Token: 0x06002672 RID: 9842 RVA: 0x0000F062 File Offset: 0x0000D262
		public unsafe string _descriptiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__descriptiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__descriptiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x000C3C84 File Offset: 0x000C1E84
		// (set) Token: 0x06002674 RID: 9844 RVA: 0x0000F081 File Offset: 0x0000D281
		public unsafe string _positiveDescriptiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__positiveDescriptiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__positiveDescriptiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x000C3CAC File Offset: 0x000C1EAC
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		public unsafe string _negativeDescriptiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__negativeDescriptiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__negativeDescriptiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x000C3CD4 File Offset: 0x000C1ED4
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x0000F0BF File Offset: 0x0000D2BF
		public unsafe int _behaviorId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__behaviorId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__behaviorId)) = value;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000C3CFC File Offset: 0x000C1EFC
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x0000F0DA File Offset: 0x0000D2DA
		public unsafe bool _userAssignable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__userAssignable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__userAssignable)) = value;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x000C3D24 File Offset: 0x000C1F24
		// (set) Token: 0x0600267C RID: 9852 RVA: 0x0000F0F5 File Offset: 0x0000D2F5
		public unsafe int _categoryId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__categoryId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr__categoryId)) = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x000C3D4C File Offset: 0x000C1F4C
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x0000F110 File Offset: 0x0000D310
		public unsafe string kmczbDXjjCpDSAbiTizuCvHZHxn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_kmczbDXjjCpDSAbiTizuCvHZHxn);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_kmczbDXjjCpDSAbiTizuCvHZHxn), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x000C3D74 File Offset: 0x000C1F74
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x0000F12F File Offset: 0x0000D32F
		public unsafe string uWbCYomoHMJmbvloCLuuIvBMnKE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_uWbCYomoHMJmbvloCLuuIvBMnKE);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputAction.NativeFieldInfoPtr_uWbCYomoHMJmbvloCLuuIvBMnKE), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeFieldInfoPtr__descriptiveName;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeFieldInfoPtr__positiveDescriptiveName;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeFieldInfoPtr__negativeDescriptiveName;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeFieldInfoPtr__behaviorId;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeFieldInfoPtr__userAssignable;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeFieldInfoPtr__categoryId;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeFieldInfoPtr_kmczbDXjjCpDSAbiTizuCvHZHxn;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeFieldInfoPtr_uWbCYomoHMJmbvloCLuuIvBMnKE;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_InputActionType_0;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Internal_set_Void_InputActionType_0;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveDescriptiveName_Public_get_String_0;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeMethodInfoPtr_set_positiveDescriptiveName_Internal_set_Void_String_0;

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeDescriptiveName_Public_get_String_0;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeMethodInfoPtr_set_negativeDescriptiveName_Internal_set_Void_String_0;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeMethodInfoPtr_get_behaviorId_Public_get_Int32_0;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeMethodInfoPtr_set_behaviorId_Internal_set_Void_Int32_0;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeMethodInfoPtr_get_userAssignable_Public_get_Boolean_0;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeMethodInfoPtr_set_userAssignable_Internal_set_Void_Boolean_0;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputAction_0;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_InputAction_0;
	}
}
