using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000334 RID: 820
	public class ObjectManager : Object
	{
		// Token: 0x060035A8 RID: 13736 RVA: 0x00108130 File Offset: 0x00106330
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectManager()
		{
			Il2CppClassPointerStore<ObjectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr);
			ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_onDeserializationHandler");
			ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_onDeserializedHandler");
			ObjectManager.NativeFieldInfoPtr_m_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_objects");
			ObjectManager.NativeFieldInfoPtr_m_topObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_topObject");
			ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_specialFixupObjects");
			ObjectManager.NativeFieldInfoPtr_m_fixupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_fixupCount");
			ObjectManager.NativeFieldInfoPtr_m_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_selector");
			ObjectManager.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_context");
			ObjectManager.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671660);
			ObjectManager.NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671661);
			ObjectManager.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671662);
			ObjectManager.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671663);
			ObjectManager.NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671664);
			ObjectManager.NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671665);
			ObjectManager.NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671666);
			ObjectManager.NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671667);
			ObjectManager.NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671668);
			ObjectManager.NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671669);
			ObjectManager.NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671670);
			ObjectManager.NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671671);
			ObjectManager.NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671672);
			ObjectManager.NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671673);
			ObjectManager.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671674);
			ObjectManager.NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671675);
			ObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671676);
			ObjectManager.NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671677);
			ObjectManager.NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671678);
			ObjectManager.NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671679);
			ObjectManager.NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671680);
			ObjectManager.NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671681);
			ObjectManager.NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671682);
			ObjectManager.NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671683);
			ObjectManager.NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671684);
			ObjectManager.NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671685);
			ObjectManager.NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671686);
			ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671687);
			ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671688);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00108444 File Offset: 0x00106644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213711, RefRangeEnd = 213713, XrefRangeStart = 213708, XrefRangeEnd = 213711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkSecurity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCrossAppDomain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x001084C4 File Offset: 0x001066C4
		[CallerCount(0)]
		public unsafe bool CanCallGetType(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x00108558 File Offset: 0x00106758
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x00108514 File Offset: 0x00106714
		public unsafe Object TopObject
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x00108598 File Offset: 0x00106798
		public unsafe ObjectHolderList SpecialFixupObjects
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 213719, RefRangeEnd = 213722, XrefRangeStart = 213713, XrefRangeEnd = 213719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr3) : null;
			}
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x001085D8 File Offset: 0x001067D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213722, RefRangeEnd = 213725, XrefRangeStart = 213722, XrefRangeEnd = 213722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder FindObjectHolder(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00108624 File Offset: 0x00106824
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 213730, RefRangeEnd = 213739, XrefRangeStart = 213725, XrefRangeEnd = 213730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder FindOrCreateObjectHolder(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00108670 File Offset: 0x00106870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213762, RefRangeEnd = 213764, XrefRangeStart = 213739, XrefRangeEnd = 213762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddObjectHolder(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x001086B4 File Offset: 0x001068B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213769, RefRangeEnd = 213771, XrefRangeStart = 213764, XrefRangeEnd = 213769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out Object member, bool bThrowIfMissing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bThrowIfMissing;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			holder = ((intPtr5 == 0) ? null : new ObjectHolder(intPtr5));
			IntPtr intPtr6 = intPtr2;
			member = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00108758 File Offset: 0x00106958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213807, RefRangeEnd = 213808, XrefRangeStart = 213771, XrefRangeEnd = 213807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupSpecialObject(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x0010879C File Offset: 0x0010699C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213826, RefRangeEnd = 213827, XrefRangeStart = 213808, XrefRangeEnd = 213826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveObjectReference(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x001087EC File Offset: 0x001069EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213865, RefRangeEnd = 213867, XrefRangeStart = 213827, XrefRangeEnd = 213865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberToFix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(holder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00108860 File Offset: 0x00106A60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213910, RefRangeEnd = 213915, XrefRangeStart = 213867, XrefRangeEnd = 213910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bObjectFullyComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x001088B0 File Offset: 0x00106AB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213923, RefRangeEnd = 213926, XrefRangeStart = 213915, XrefRangeEnd = 213923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x001088F4 File Offset: 0x00106AF4
		[CallerCount(0)]
		public unsafe virtual Object GetObject(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0010894C File Offset: 0x00106B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213926, XrefRangeEnd = 213935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x001089D0 File Offset: 0x00106BD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213975, RefRangeEnd = 213978, XrefRangeStart = 213935, XrefRangeEnd = 213975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, Il2CppStructArray<int> arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00108A68 File Offset: 0x00106C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213990, RefRangeEnd = 213991, XrefRangeStart = 213978, XrefRangeEnd = 213990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteISerializableObject(Object obj, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00108AD4 File Offset: 0x00106CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213995, RefRangeEnd = 213996, XrefRangeStart = 213991, XrefRangeEnd = 213995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeConstructorInfo GetConstructor(RuntimeType t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00108B18 File Offset: 0x00106D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213996, XrefRangeEnd = 214011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DoFixups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00108B54 File Offset: 0x00106D54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214015, RefRangeEnd = 214018, XrefRangeStart = 214011, XrefRangeEnd = 214015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectToBeFixed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00108BB4 File Offset: 0x00106DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214018, XrefRangeEnd = 214061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00108C20 File Offset: 0x00106E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214061, XrefRangeEnd = 214080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00108C8C File Offset: 0x00106E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214080, XrefRangeEnd = 214099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordArrayElementFixup(long arrayToBeFixed, Il2CppStructArray<int> indices, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arrayToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00108CF8 File Offset: 0x00106EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214099, XrefRangeEnd = 214101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RaiseDeserializationEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00108D34 File Offset: 0x00106F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214101, XrefRangeEnd = 214104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddOnDeserialization(DeserializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00108D84 File Offset: 0x00106F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214104, XrefRangeEnd = 214110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddOnDeserialized(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00108DD4 File Offset: 0x00106FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214110, XrefRangeEnd = 214116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RaiseOnDeserializedEvent(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00108E24 File Offset: 0x00107024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214116, XrefRangeEnd = 214122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseOnDeserializingEvent(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00012F6E File Offset: 0x0001116E
		public ObjectManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x00108E68 File Offset: 0x00107068
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x00012F77 File Offset: 0x00011177
		public unsafe DeserializationEventHandler m_onDeserializationHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeserializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x00108E98 File Offset: 0x00107098
		// (set) Token: 0x060035CA RID: 13770 RVA: 0x00012F96 File Offset: 0x00011196
		public unsafe SerializationEventHandler m_onDeserializedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x00108EC8 File Offset: 0x001070C8
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x00012FB5 File Offset: 0x000111B5
		public unsafe Il2CppReferenceArray<ObjectHolder> m_objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x00108EF8 File Offset: 0x001070F8
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x00012FD4 File Offset: 0x000111D4
		public unsafe Object m_topObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_topObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_topObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x00108F28 File Offset: 0x00107128
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x00012FF3 File Offset: 0x000111F3
		public unsafe ObjectHolderList m_specialFixupObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x00108F58 File Offset: 0x00107158
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x00013012 File Offset: 0x00011212
		public unsafe long m_fixupCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_fixupCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_fixupCount)) = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x00108F80 File Offset: 0x00107180
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x0001302D File Offset: 0x0001122D
		public unsafe ISurrogateSelector m_selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x00108FB0 File Offset: 0x001071B0
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x0001304C File Offset: 0x0001124C
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeFieldInfoPtr_m_onDeserializationHandler;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeFieldInfoPtr_m_onDeserializedHandler;

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeFieldInfoPtr_m_objects;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeFieldInfoPtr_m_topObject;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeFieldInfoPtr_m_specialFixupObjects;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupCount;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeFieldInfoPtr_m_selector;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0;

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0;

		// Token: 0x04002D71 RID: 11633
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0;

		// Token: 0x04002D72 RID: 11634
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0;

		// Token: 0x04002D73 RID: 11635
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0;

		// Token: 0x04002D74 RID: 11636
		private static readonly IntPtr NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0;

		// Token: 0x04002D75 RID: 11637
		private static readonly IntPtr NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0;

		// Token: 0x04002D76 RID: 11638
		private static readonly IntPtr NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0;

		// Token: 0x04002D77 RID: 11639
		private static readonly IntPtr NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0;

		// Token: 0x04002D78 RID: 11640
		private static readonly IntPtr NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0;

		// Token: 0x04002D79 RID: 11641
		private static readonly IntPtr NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0;

		// Token: 0x04002D7A RID: 11642
		private static readonly IntPtr NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0;

		// Token: 0x04002D7B RID: 11643
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0;

		// Token: 0x04002D7C RID: 11644
		private static readonly IntPtr NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0;

		// Token: 0x04002D7D RID: 11645
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002D7E RID: 11646
		private static readonly IntPtr NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002D7F RID: 11647
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0;

		// Token: 0x04002D80 RID: 11648
		private static readonly IntPtr NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0;

		// Token: 0x04002D81 RID: 11649
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0;

		// Token: 0x04002D82 RID: 11650
		private static readonly IntPtr NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0;

		// Token: 0x04002D83 RID: 11651
		private static readonly IntPtr NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0;

		// Token: 0x04002D84 RID: 11652
		private static readonly IntPtr NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0;

		// Token: 0x04002D85 RID: 11653
		private static readonly IntPtr NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0;

		// Token: 0x04002D86 RID: 11654
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0;

		// Token: 0x04002D87 RID: 11655
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0;

		// Token: 0x04002D88 RID: 11656
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0;

		// Token: 0x04002D89 RID: 11657
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0;
	}
}
