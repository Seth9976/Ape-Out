using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000380 RID: 896
	public sealed class ObjectWriter : Object
	{
		// Token: 0x06003A87 RID: 14983 RVA: 0x00119100 File Offset: 0x00117300
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectWriter()
		{
			Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr);
			ObjectWriter.NativeFieldInfoPtr_m_objectQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_objectQueue");
			ObjectWriter.NativeFieldInfoPtr_m_idGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_idGenerator");
			ObjectWriter.NativeFieldInfoPtr_m_currentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_currentId");
			ObjectWriter.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_surrogates");
			ObjectWriter.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_context");
			ObjectWriter.NativeFieldInfoPtr_serWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "serWriter");
			ObjectWriter.NativeFieldInfoPtr_m_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_objectManager");
			ObjectWriter.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "topId");
			ObjectWriter.NativeFieldInfoPtr_topName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "topName");
			ObjectWriter.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "headers");
			ObjectWriter.NativeFieldInfoPtr_formatterEnums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "formatterEnums");
			ObjectWriter.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_binder");
			ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "serObjectInfoInit");
			ObjectWriter.NativeFieldInfoPtr_m_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_formatterConverter");
			ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "crossAppDomainArray");
			ObjectWriter.NativeFieldInfoPtr_previousObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousObj");
			ObjectWriter.NativeFieldInfoPtr_previousId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousId");
			ObjectWriter.NativeFieldInfoPtr_previousType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousType");
			ObjectWriter.NativeFieldInfoPtr_previousCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousCode");
			ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "assemblyToIdTable");
			ObjectWriter.NativeFieldInfoPtr_niPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "niPool");
			ObjectWriter.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672128);
			ObjectWriter.NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672129);
			ObjectWriter.NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672130);
			ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672131);
			ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672132);
			ObjectWriter.NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672133);
			ObjectWriter.NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672134);
			ObjectWriter.NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672135);
			ObjectWriter.NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672136);
			ObjectWriter.NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672137);
			ObjectWriter.NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672138);
			ObjectWriter.NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672139);
			ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672140);
			ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672141);
			ObjectWriter.NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672142);
			ObjectWriter.NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672143);
			ObjectWriter.NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672144);
			ObjectWriter.NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672145);
			ObjectWriter.NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672146);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672147);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672148);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672149);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672150);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672151);
			ObjectWriter.NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672152);
			ObjectWriter.NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672153);
			ObjectWriter.NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672154);
			ObjectWriter.NativeMethodInfoPtr_GetType_Private_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672155);
			ObjectWriter.NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672156);
			ObjectWriter.NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672157);
			ObjectWriter.NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100672158);
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x00119540 File Offset: 0x00117740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217568, RefRangeEnd = 217569, XrefRangeStart = 217552, XrefRangeEnd = 217568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterEnums);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x001195C8 File Offset: 0x001177C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217603, RefRangeEnd = 217604, XrefRangeStart = 217569, XrefRangeEnd = 217603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Object graph, Il2CppReferenceArray<Header> inHeaders, __BinaryWriter serWriter, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inHeaders);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serWriter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x0011963C File Offset: 0x0011783C
		public unsafe SerializationObjectManager ObjectManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationObjectManager>(intPtr3) : null;
			}
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x0011967C File Offset: 0x0011787C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217652, RefRangeEnd = 217653, XrefRangeStart = 217604, XrefRangeEnd = 217652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x001196E4 File Offset: 0x001178E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217653, XrefRangeEnd = 217678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, Il2CppReferenceArray<Object> memberData, Il2CppReferenceArray<WriteObjectInfo> memberObjectInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00119798 File Offset: 0x00117998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217678, XrefRangeEnd = 217686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, Object memberData, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0011984C File Offset: 0x00117A4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217720, RefRangeEnd = 217723, XrefRangeStart = 217686, XrefRangeEnd = 217720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, Object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x001198EC File Offset: 0x00117AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217754, RefRangeEnd = 217755, XrefRangeStart = 217723, XrefRangeEnd = 217754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00119954 File Offset: 0x00117B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217757, RefRangeEnd = 217758, XrefRangeStart = 217755, XrefRangeEnd = 217757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x001199BC File Offset: 0x00117BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217758, XrefRangeEnd = 217766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRectangle(WriteObjectInfo objectInfo, int rank, Il2CppStructArray<int> maxA, Array array, NameInfo arrayElemNameTypeInfo, Il2CppStructArray<int> lowerBoundA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maxA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemNameTypeInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x00119A58 File Offset: 0x00117C58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217769, RefRangeEnd = 217771, XrefRangeStart = 217766, XrefRangeEnd = 217769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetNext(out long objID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &objID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00119AA4 File Offset: 0x00117CA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 217773, RefRangeEnd = 217779, XrefRangeStart = 217771, XrefRangeEnd = 217773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long InternalGetId(Object obj, bool assignUniqueIdToValueType, Type type, out bool isNew)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isNew;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00119B20 File Offset: 0x00117D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217779, XrefRangeEnd = 217780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Schedule(Object obj, bool assignUniqueIdToValueType, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x00119B90 File Offset: 0x00117D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217780, XrefRangeEnd = 217781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Schedule(Object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x00119C10 File Offset: 0x00117E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217789, RefRangeEnd = 217790, XrefRangeStart = 217781, XrefRangeEnd = 217789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x00119C84 File Offset: 0x00117E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217790, XrefRangeEnd = 217792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectRef(NameInfo nameInfo, long objectId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x00119CD4 File Offset: 0x00117ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217792, XrefRangeEnd = 217795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, Object stringObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x00119D3C File Offset: 0x00117F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217795, XrefRangeEnd = 217800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00119DC0 File Offset: 0x00117FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217804, RefRangeEnd = 217805, XrefRangeStart = 217800, XrefRangeEnd = 217804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializedStreamHeader(long topId, long headerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00119E0C File Offset: 0x0011800C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217805, XrefRangeEnd = 217810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00119E90 File Offset: 0x00118090
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217812, RefRangeEnd = 217816, XrefRangeStart = 217810, XrefRangeEnd = 217812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x00119EE0 File Offset: 0x001180E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 217820, RefRangeEnd = 217826, XrefRangeStart = 217816, XrefRangeEnd = 217820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x00119F30 File Offset: 0x00118130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217826, XrefRangeEnd = 217832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x00119F94 File Offset: 0x00118194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217832, XrefRangeEnd = 217836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TypeToNameInfo(Type type, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00119FE8 File Offset: 0x001181E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217837, RefRangeEnd = 217839, XrefRangeStart = 217836, XrefRangeEnd = 217837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo MemberToNameInfo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x0011A038 File Offset: 0x00118238
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 217843, RefRangeEnd = 217851, XrefRangeStart = 217839, XrefRangeEnd = 217843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalPrimitiveTypeE ToCode(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x0011A088 File Offset: 0x00118288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217870, RefRangeEnd = 217873, XrefRangeStart = 217851, XrefRangeEnd = 217870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetAssemblyId(WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x0011A0D8 File Offset: 0x001182D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217873, XrefRangeEnd = 217875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetType_Private_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x0011A128 File Offset: 0x00118328
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 217879, RefRangeEnd = 217885, XrefRangeStart = 217875, XrefRangeEnd = 217879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo GetNameInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x0011A168 File Offset: 0x00118368
		[CallerCount(0)]
		public unsafe bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref test;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref want;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x0011A1C0 File Offset: 0x001183C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217885, XrefRangeEnd = 217887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutNameInfo(NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x000156DE File Offset: 0x000138DE
		public ObjectWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x0011A204 File Offset: 0x00118404
		// (set) Token: 0x06003AA9 RID: 15017 RVA: 0x000156E7 File Offset: 0x000138E7
		public unsafe Queue m_objectQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x0011A234 File Offset: 0x00118434
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x00015706 File Offset: 0x00013906
		public unsafe ObjectIDGenerator m_idGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_idGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectIDGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_idGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x0011A264 File Offset: 0x00118464
		// (set) Token: 0x06003AAD RID: 15021 RVA: 0x00015725 File Offset: 0x00013925
		public unsafe int m_currentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_currentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_currentId)) = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003AAE RID: 15022 RVA: 0x0011A28C File Offset: 0x0011848C
		// (set) Token: 0x06003AAF RID: 15023 RVA: 0x00015740 File Offset: 0x00013940
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x0011A2BC File Offset: 0x001184BC
		// (set) Token: 0x06003AB1 RID: 15025 RVA: 0x0001575F File Offset: 0x0001395F
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x0011A2EC File Offset: 0x001184EC
		// (set) Token: 0x06003AB3 RID: 15027 RVA: 0x0001578D File Offset: 0x0001398D
		public unsafe __BinaryWriter serWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<__BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x0011A31C File Offset: 0x0011851C
		// (set) Token: 0x06003AB5 RID: 15029 RVA: 0x000157AC File Offset: 0x000139AC
		public unsafe SerializationObjectManager m_objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x0011A34C File Offset: 0x0011854C
		// (set) Token: 0x06003AB7 RID: 15031 RVA: 0x000157CB File Offset: 0x000139CB
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x0011A374 File Offset: 0x00118574
		// (set) Token: 0x06003AB9 RID: 15033 RVA: 0x000157E6 File Offset: 0x000139E6
		public unsafe string topName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x0011A39C File Offset: 0x0011859C
		// (set) Token: 0x06003ABB RID: 15035 RVA: 0x00015805 File Offset: 0x00013A05
		public unsafe Il2CppReferenceArray<Header> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003ABC RID: 15036 RVA: 0x0011A3CC File Offset: 0x001185CC
		// (set) Token: 0x06003ABD RID: 15037 RVA: 0x00015824 File Offset: 0x00013A24
		public unsafe InternalFE formatterEnums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_formatterEnums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalFE>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_formatterEnums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x0011A3FC File Offset: 0x001185FC
		// (set) Token: 0x06003ABF RID: 15039 RVA: 0x00015843 File Offset: 0x00013A43
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x0011A42C File Offset: 0x0011862C
		// (set) Token: 0x06003AC1 RID: 15041 RVA: 0x00015862 File Offset: 0x00013A62
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x0011A45C File Offset: 0x0011865C
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x00015881 File Offset: 0x00013A81
		public unsafe IFormatterConverter m_formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x0011A48C File Offset: 0x0011868C
		// (set) Token: 0x06003AC5 RID: 15045 RVA: 0x000158A0 File Offset: 0x00013AA0
		public unsafe Il2CppReferenceArray<Object> crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x0011A4BC File Offset: 0x001186BC
		// (set) Token: 0x06003AC7 RID: 15047 RVA: 0x000158BF File Offset: 0x00013ABF
		public unsafe Object previousObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x0011A4EC File Offset: 0x001186EC
		// (set) Token: 0x06003AC9 RID: 15049 RVA: 0x000158DE File Offset: 0x00013ADE
		public unsafe long previousId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousId)) = value;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x0011A514 File Offset: 0x00118714
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x000158F9 File Offset: 0x00013AF9
		public unsafe Type previousType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x0011A544 File Offset: 0x00118744
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x00015918 File Offset: 0x00013B18
		public unsafe InternalPrimitiveTypeE previousCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousCode)) = value;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x0011A56C File Offset: 0x0011876C
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x00015933 File Offset: 0x00013B33
		public unsafe Hashtable assemblyToIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x0011A59C File Offset: 0x0011879C
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x00015952 File Offset: 0x00013B52
		public unsafe SerStack niPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_niPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_niPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeFieldInfoPtr_m_objectQueue;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeFieldInfoPtr_m_idGenerator;

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeFieldInfoPtr_m_currentId;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeFieldInfoPtr_serWriter;

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeFieldInfoPtr_m_objectManager;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeFieldInfoPtr_topName;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeFieldInfoPtr_formatterEnums;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeFieldInfoPtr_m_formatterConverter;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArray;

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeFieldInfoPtr_previousObj;

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeFieldInfoPtr_previousId;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeFieldInfoPtr_previousType;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeFieldInfoPtr_previousCode;

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeFieldInfoPtr_assemblyToIdTable;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeFieldInfoPtr_niPool;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0;

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0;

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0;

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0;

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0;

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Private_Type_Object_0;

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0;
	}
}
