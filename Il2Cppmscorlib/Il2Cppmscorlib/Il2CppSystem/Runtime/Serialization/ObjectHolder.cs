using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000335 RID: 821
	public sealed class ObjectHolder : Object
	{
		// Token: 0x060035D7 RID: 13783 RVA: 0x00108FE0 File Offset: 0x001071E0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolder()
		{
			Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr);
			ObjectHolder.NativeFieldInfoPtr_m_object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_object");
			ObjectHolder.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_id");
			ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingElementsRemaining");
			ObjectHolder.NativeFieldInfoPtr_m_missingDecendents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingDecendents");
			ObjectHolder.NativeFieldInfoPtr_m_serInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_serInfo");
			ObjectHolder.NativeFieldInfoPtr_m_surrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_surrogate");
			ObjectHolder.NativeFieldInfoPtr_m_missingElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingElements");
			ObjectHolder.NativeFieldInfoPtr_m_dependentObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_dependentObjects");
			ObjectHolder.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_next");
			ObjectHolder.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_flags");
			ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_markForFixupWhenAvailable");
			ObjectHolder.NativeFieldInfoPtr_m_valueFixup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_valueFixup");
			ObjectHolder.NativeFieldInfoPtr_m_typeLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_typeLoad");
			ObjectHolder.NativeFieldInfoPtr_m_reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_reachable");
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671689);
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671690);
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671691);
			ObjectHolder.NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671692);
			ObjectHolder.NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671693);
			ObjectHolder.NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671694);
			ObjectHolder.NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671695);
			ObjectHolder.NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671696);
			ObjectHolder.NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671697);
			ObjectHolder.NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671698);
			ObjectHolder.NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671699);
			ObjectHolder.NativeMethodInfoPtr_SetFlags_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671700);
			ObjectHolder.NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671701);
			ObjectHolder.NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671702);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671703);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671704);
			ObjectHolder.NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671705);
			ObjectHolder.NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671706);
			ObjectHolder.NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671707);
			ObjectHolder.NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671708);
			ObjectHolder.NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671709);
			ObjectHolder.NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671710);
			ObjectHolder.NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671711);
			ObjectHolder.NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671712);
			ObjectHolder.NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671713);
			ObjectHolder.NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671714);
			ObjectHolder.NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671715);
			ObjectHolder.NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671716);
			ObjectHolder.NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671717);
			ObjectHolder.NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671718);
			ObjectHolder.NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671719);
			ObjectHolder.NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671720);
			ObjectHolder.NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671721);
			ObjectHolder.NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671722);
			ObjectHolder.NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671723);
			ObjectHolder.NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671724);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671725);
			ObjectHolder.NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671726);
			ObjectHolder.NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671727);
			ObjectHolder.NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671728);
			ObjectHolder.NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671729);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0010945C File Offset: 0x0010765C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214122, XrefRangeEnd = 214123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(long objID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x001094A4 File Offset: 0x001076A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214123, XrefRangeEnd = 214140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(Object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Il2CppStructArray<int> arrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00109558 File Offset: 0x00107758
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214145, RefRangeEnd = 214148, XrefRangeStart = 214140, XrefRangeEnd = 214145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Il2CppStructArray<int> arrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0010960C File Offset: 0x0010780C
		[CallerCount(0)]
		public unsafe void IncrementDescendentFixups(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0010964C File Offset: 0x0010784C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214148, XrefRangeEnd = 214150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementFixupsRemaining(ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00109690 File Offset: 0x00107890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214150, RefRangeEnd = 214152, XrefRangeStart = 214150, XrefRangeEnd = 214150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDependency(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x001096D0 File Offset: 0x001078D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214160, RefRangeEnd = 214161, XrefRangeStart = 214152, XrefRangeEnd = 214160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFixup(FixupHolder fixup, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00109724 File Offset: 0x00107924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214161, XrefRangeEnd = 214163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00109774 File Offset: 0x00107974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214170, RefRangeEnd = 214171, XrefRangeStart = 214163, XrefRangeEnd = 214170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDependency(long dependentObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dependentObject;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x001097B4 File Offset: 0x001079B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214180, RefRangeEnd = 214181, XrefRangeStart = 214171, XrefRangeEnd = 214180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData(Object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, Il2CppStructArray<int> arrayIndex, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00109864 File Offset: 0x00107A64
		[CallerCount(0)]
		public unsafe void MarkForCompletionWhenAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x00109898 File Offset: 0x00107A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214188, RefRangeEnd = 214190, XrefRangeStart = 214181, XrefRangeEnd = 214188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_SetFlags_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x001098CC File Offset: 0x00107ACC
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x00109908 File Offset: 0x00107B08
		public unsafe bool IsIncompleteObjectReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x00109948 File Offset: 0x00107B48
		public unsafe bool RequiresDelayedFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x00109984 File Offset: 0x00107B84
		public unsafe bool RequiresValueTypeFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060035E8 RID: 13800 RVA: 0x001099C0 File Offset: 0x00107BC0
		// (set) Token: 0x060035E9 RID: 13801 RVA: 0x001099FC File Offset: 0x00107BFC
		public unsafe bool ValueTypeFixupPerformed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x00109A3C File Offset: 0x00107C3C
		public unsafe bool HasISerializable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x00109A78 File Offset: 0x00107C78
		public unsafe bool HasSurrogate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060035EC RID: 13804 RVA: 0x00109AB4 File Offset: 0x00107CB4
		public unsafe bool CanSurrogatedObjectValueChange
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 214192, RefRangeEnd = 214194, XrefRangeStart = 214190, XrefRangeEnd = 214192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x00109AF0 File Offset: 0x00107CF0
		public unsafe bool CanObjectValueChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x00109B2C File Offset: 0x00107D2C
		public unsafe int DirectlyDependentObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x00109B68 File Offset: 0x00107D68
		public unsafe int TotalDependentObjects
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 181300, RefRangeEnd = 181301, XrefRangeStart = 181300, XrefRangeEnd = 181301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x00109BA4 File Offset: 0x00107DA4
		// (set) Token: 0x060035F1 RID: 13809 RVA: 0x00109BE0 File Offset: 0x00107DE0
		public unsafe bool Reachable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x00109C20 File Offset: 0x00107E20
		public unsafe bool TypeLoadExceptionReachable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x00109C5C File Offset: 0x00107E5C
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x00109C9C File Offset: 0x00107E9C
		public unsafe TypeLoadExceptionHolder TypeLoadException
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeLoadExceptionHolder>(intPtr3) : null;
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x00109CE0 File Offset: 0x00107EE0
		public unsafe Object ObjectValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00109D20 File Offset: 0x00107F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214236, RefRangeEnd = 214239, XrefRangeStart = 214233, XrefRangeEnd = 214236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectValue(Object obj, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x00109D74 File Offset: 0x00107F74
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x00109DB4 File Offset: 0x00107FB4
		public unsafe SerializationInfo SerializationInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x00109DF8 File Offset: 0x00107FF8
		public unsafe ISerializationSurrogate Surrogate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr3) : null;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x00109E38 File Offset: 0x00108038
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x00109E78 File Offset: 0x00108078
		public unsafe LongList DependentObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LongList>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x00109EBC File Offset: 0x001080BC
		// (set) Token: 0x060035FD RID: 13821 RVA: 0x00109EF8 File Offset: 0x001080F8
		public unsafe bool RequiresSerInfoFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x00109F38 File Offset: 0x00108138
		public unsafe ValueTypeFixupInfo ValueFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueTypeFixupInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x00109F78 File Offset: 0x00108178
		public unsafe bool CompletelyFixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x00109FB4 File Offset: 0x001081B4
		public unsafe long ContainerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x0001307A File Offset: 0x0001127A
		public ObjectHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x00109FF0 File Offset: 0x001081F0
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x00013083 File Offset: 0x00011283
		public unsafe Object m_object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x0010A020 File Offset: 0x00108220
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x000130A2 File Offset: 0x000112A2
		public unsafe long m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x0010A048 File Offset: 0x00108248
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x000130BD File Offset: 0x000112BD
		public unsafe int m_missingElementsRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining)) = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x0010A070 File Offset: 0x00108270
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x000130D8 File Offset: 0x000112D8
		public unsafe int m_missingDecendents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingDecendents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingDecendents)) = value;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x0010A098 File Offset: 0x00108298
		// (set) Token: 0x0600360B RID: 13835 RVA: 0x000130F3 File Offset: 0x000112F3
		public unsafe SerializationInfo m_serInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_serInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_serInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x0010A0C8 File Offset: 0x001082C8
		// (set) Token: 0x0600360D RID: 13837 RVA: 0x00013112 File Offset: 0x00011312
		public unsafe ISerializationSurrogate m_surrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_surrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_surrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x0600360E RID: 13838 RVA: 0x0010A0F8 File Offset: 0x001082F8
		// (set) Token: 0x0600360F RID: 13839 RVA: 0x00013131 File Offset: 0x00011331
		public unsafe FixupHolderList m_missingElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FixupHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06003610 RID: 13840 RVA: 0x0010A128 File Offset: 0x00108328
		// (set) Token: 0x06003611 RID: 13841 RVA: 0x00013150 File Offset: 0x00011350
		public unsafe LongList m_dependentObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_dependentObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LongList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_dependentObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x0010A158 File Offset: 0x00108358
		// (set) Token: 0x06003613 RID: 13843 RVA: 0x0001316F File Offset: 0x0001136F
		public unsafe ObjectHolder m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x0010A188 File Offset: 0x00108388
		// (set) Token: 0x06003615 RID: 13845 RVA: 0x0001318E File Offset: 0x0001138E
		public unsafe int m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06003616 RID: 13846 RVA: 0x0010A1B0 File Offset: 0x001083B0
		// (set) Token: 0x06003617 RID: 13847 RVA: 0x000131A9 File Offset: 0x000113A9
		public unsafe bool m_markForFixupWhenAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable)) = value;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x0010A1D8 File Offset: 0x001083D8
		// (set) Token: 0x06003619 RID: 13849 RVA: 0x000131C4 File Offset: 0x000113C4
		public unsafe ValueTypeFixupInfo m_valueFixup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_valueFixup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTypeFixupInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_valueFixup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x0010A208 File Offset: 0x00108408
		// (set) Token: 0x0600361B RID: 13851 RVA: 0x000131E3 File Offset: 0x000113E3
		public unsafe TypeLoadExceptionHolder m_typeLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_typeLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLoadExceptionHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_typeLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x0010A238 File Offset: 0x00108438
		// (set) Token: 0x0600361D RID: 13853 RVA: 0x00013202 File Offset: 0x00011402
		public unsafe bool m_reachable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_reachable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_reachable)) = value;
			}
		}

		// Token: 0x04002D8A RID: 11658
		private static readonly IntPtr NativeFieldInfoPtr_m_object;

		// Token: 0x04002D8B RID: 11659
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeFieldInfoPtr_m_missingElementsRemaining;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeFieldInfoPtr_m_missingDecendents;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeFieldInfoPtr_m_serInfo;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogate;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeFieldInfoPtr_m_missingElements;

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeFieldInfoPtr_m_dependentObjects;

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeFieldInfoPtr_m_markForFixupWhenAvailable;

		// Token: 0x04002D95 RID: 11669
		private static readonly IntPtr NativeFieldInfoPtr_m_valueFixup;

		// Token: 0x04002D96 RID: 11670
		private static readonly IntPtr NativeFieldInfoPtr_m_typeLoad;

		// Token: 0x04002D97 RID: 11671
		private static readonly IntPtr NativeFieldInfoPtr_m_reachable;

		// Token: 0x04002D98 RID: 11672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_0;

		// Token: 0x04002D99 RID: 11673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002D9A RID: 11674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0;

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeMethodInfoPtr_SetFlags_Internal_Void_0;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0;

		// Token: 0x04002DB5 RID: 11701
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0;

		// Token: 0x04002DB6 RID: 11702
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0;

		// Token: 0x04002DB7 RID: 11703
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0;

		// Token: 0x04002DB8 RID: 11704
		private static readonly IntPtr NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0;

		// Token: 0x04002DB9 RID: 11705
		private static readonly IntPtr NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0;

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0;

		// Token: 0x04002DBD RID: 11709
		private static readonly IntPtr NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0;

		// Token: 0x04002DBE RID: 11710
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0;

		// Token: 0x04002DBF RID: 11711
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0;

		// Token: 0x04002DC0 RID: 11712
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0;
	}
}
