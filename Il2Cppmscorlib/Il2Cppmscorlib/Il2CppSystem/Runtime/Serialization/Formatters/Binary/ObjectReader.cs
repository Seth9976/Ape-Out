using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037F RID: 895
	public sealed class ObjectReader : Object
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x00117D6C File Offset: 0x00115F6C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectReader()
		{
			Il2CppClassPointerStore<ObjectReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr);
			ObjectReader.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_stream");
			ObjectReader.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_surrogates");
			ObjectReader.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_context");
			ObjectReader.NativeFieldInfoPtr_m_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_objectManager");
			ObjectReader.NativeFieldInfoPtr_formatterEnums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "formatterEnums");
			ObjectReader.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_binder");
			ObjectReader.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "topId");
			ObjectReader.NativeFieldInfoPtr_bSimpleAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bSimpleAssembly");
			ObjectReader.NativeFieldInfoPtr_handlerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "handlerObject");
			ObjectReader.NativeFieldInfoPtr_m_topObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_topObject");
			ObjectReader.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "headers");
			ObjectReader.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "handler");
			ObjectReader.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "serObjectInfoInit");
			ObjectReader.NativeFieldInfoPtr_m_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_formatterConverter");
			ObjectReader.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "stack");
			ObjectReader.NativeFieldInfoPtr_valueFixupStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "valueFixupStack");
			ObjectReader.NativeFieldInfoPtr_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "crossAppDomainArray");
			ObjectReader.NativeFieldInfoPtr_bFullDeserialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bFullDeserialization");
			ObjectReader.NativeFieldInfoPtr_bOldFormatDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bOldFormatDetected");
			ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "valTypeObjectIdTable");
			ObjectReader.NativeFieldInfoPtr_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "typeCache");
			ObjectReader.NativeFieldInfoPtr_previousAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousAssemblyString");
			ObjectReader.NativeFieldInfoPtr_previousName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousName");
			ObjectReader.NativeFieldInfoPtr_previousType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousType");
			ObjectReader.NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672092);
			ObjectReader.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672093);
			ObjectReader.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672094);
			ObjectReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672095);
			ObjectReader.NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672096);
			ObjectReader.NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672097);
			ObjectReader.NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672098);
			ObjectReader.NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672099);
			ObjectReader.NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672100);
			ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672101);
			ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672102);
			ObjectReader.NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672103);
			ObjectReader.NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672104);
			ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672105);
			ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672106);
			ObjectReader.NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672107);
			ObjectReader.NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672108);
			ObjectReader.NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672109);
			ObjectReader.NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672110);
			ObjectReader.NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672111);
			ObjectReader.NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672112);
			ObjectReader.NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672113);
			ObjectReader.NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672114);
			ObjectReader.NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672115);
			ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672116);
			ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672117);
			ObjectReader.NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672118);
			ObjectReader.NativeMethodInfoPtr_Bind_Internal_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672119);
			ObjectReader.NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672120);
			ObjectReader.NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672121);
			ObjectReader.NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672122);
			ObjectReader.NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672123);
			ObjectReader.NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100672124);
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x00118210 File Offset: 0x00116410
		public unsafe SerStack ValueFixupStack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217132, RefRangeEnd = 217133, XrefRangeStart = 217126, XrefRangeEnd = 217132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr3) : null;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06003A36 RID: 14902 RVA: 0x00118250 File Offset: 0x00116450
		// (set) Token: 0x06003A37 RID: 14903 RVA: 0x00118290 File Offset: 0x00116490
		public unsafe Object TopObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 217133, RefRangeEnd = 217139, XrefRangeStart = 217133, XrefRangeEnd = 217133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x001182D4 File Offset: 0x001164D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217142, RefRangeEnd = 217143, XrefRangeStart = 217139, XrefRangeEnd = 217142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectReader(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterEnums);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x00118370 File Offset: 0x00116570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217167, RefRangeEnd = 217168, XrefRangeStart = 217143, XrefRangeEnd = 217167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x001183E0 File Offset: 0x001165E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217171, RefRangeEnd = 217173, XrefRangeStart = 217168, XrefRangeEnd = 217171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSurrogate(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00118430 File Offset: 0x00116630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217174, RefRangeEnd = 217176, XrefRangeStart = 217173, XrefRangeEnd = 217174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSerializable(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00118474 File Offset: 0x00116674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217189, RefRangeEnd = 217191, XrefRangeStart = 217176, XrefRangeEnd = 217189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitFullDeserialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x001184A8 File Offset: 0x001166A8
		[CallerCount(0)]
		public unsafe Object CrossAppDomainArray(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x001184F4 File Offset: 0x001166F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217191, XrefRangeEnd = 217192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateReadObjectInfo(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00118544 File Offset: 0x00116744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217192, XrefRangeEnd = 217197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateReadObjectInfo(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x001185B8 File Offset: 0x001167B8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 217201, RefRangeEnd = 217213, XrefRangeStart = 217197, XrefRangeEnd = 217201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x001185FC File Offset: 0x001167FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217213, XrefRangeEnd = 217267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseError(ParseRecord processing, ParseRecord onStack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processing);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onStack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x00118650 File Offset: 0x00116850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217267, XrefRangeEnd = 217269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSerializedStreamHeader(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x00118694 File Offset: 0x00116894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217269, XrefRangeEnd = 217270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSerializedStreamHeaderEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x001186D8 File Offset: 0x001168D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217293, RefRangeEnd = 217295, XrefRangeStart = 217270, XrefRangeEnd = 217293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseObject(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x0011871C File Offset: 0x0011691C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217305, RefRangeEnd = 217308, XrefRangeStart = 217295, XrefRangeEnd = 217305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseObjectEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x00118760 File Offset: 0x00116960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217308, XrefRangeEnd = 217328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArray(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x001187A4 File Offset: 0x001169A4
		[CallerCount(0)]
		public unsafe void NextRectangleMap(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x001187E8 File Offset: 0x001169E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217407, RefRangeEnd = 217408, XrefRangeStart = 217328, XrefRangeEnd = 217407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArrayMember(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x0011882C File Offset: 0x00116A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217408, XrefRangeEnd = 217409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArrayMemberEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x00118870 File Offset: 0x00116A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217439, RefRangeEnd = 217440, XrefRangeStart = 217409, XrefRangeEnd = 217439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMember(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x001188B4 File Offset: 0x00116AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217440, XrefRangeEnd = 217442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMemberEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x001188F8 File Offset: 0x00116AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217442, XrefRangeEnd = 217443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseString(ParseRecord pr, ParseRecord parentPr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentPr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x0011894C File Offset: 0x00116B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217443, XrefRangeEnd = 217446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, ParseRecord pr, ParseRecord objectPr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectPr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x001189B4 File Offset: 0x00116BB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217449, RefRangeEnd = 217453, XrefRangeStart = 217446, XrefRangeEnd = 217449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectPr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsString;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00118A28 File Offset: 0x00116C28
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 217455, RefRangeEnd = 217465, XrefRangeStart = 217453, XrefRangeEnd = 217455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetId(long objectId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00118A74 File Offset: 0x00116C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217465, XrefRangeEnd = 217466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type Bind(string assemblyString, string typeString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Bind_Internal_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00118AD8 File Offset: 0x00116CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217487, RefRangeEnd = 217489, XrefRangeStart = 217466, XrefRangeEnd = 217487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type FastBindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00118B3C File Offset: 0x00116D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217493, RefRangeEnd = 217494, XrefRangeStart = 217489, XrefRangeEnd = 217493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00118B80 File Offset: 0x00116D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217520, RefRangeEnd = 217522, XrefRangeStart = 217494, XrefRangeEnd = 217520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			type = ((intPtr4 == 0) ? null : new Type(intPtr4));
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00118BF0 File Offset: 0x00116DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217538, RefRangeEnd = 217540, XrefRangeStart = 217522, XrefRangeEnd = 217538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(BinaryAssemblyInfo assemblyInfo, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00118C54 File Offset: 0x00116E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217550, RefRangeEnd = 217552, XrefRangeStart = 217540, XrefRangeEnd = 217550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destAssembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolvedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x000153EE File Offset: 0x000135EE
		public ObjectReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x00118CB0 File Offset: 0x00116EB0
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x000153F7 File Offset: 0x000135F7
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x00118CE0 File Offset: 0x00116EE0
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x00015416 File Offset: 0x00013616
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x00118D10 File Offset: 0x00116F10
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x00015435 File Offset: 0x00013635
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x00118D40 File Offset: 0x00116F40
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x00015463 File Offset: 0x00013663
		public unsafe ObjectManager m_objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003A5F RID: 14943 RVA: 0x00118D70 File Offset: 0x00116F70
		// (set) Token: 0x06003A60 RID: 14944 RVA: 0x00015482 File Offset: 0x00013682
		public unsafe InternalFE formatterEnums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_formatterEnums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalFE>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_formatterEnums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x00118DA0 File Offset: 0x00116FA0
		// (set) Token: 0x06003A62 RID: 14946 RVA: 0x000154A1 File Offset: 0x000136A1
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x00118DD0 File Offset: 0x00116FD0
		// (set) Token: 0x06003A64 RID: 14948 RVA: 0x000154C0 File Offset: 0x000136C0
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x00118DF8 File Offset: 0x00116FF8
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x000154DB File Offset: 0x000136DB
		public unsafe bool bSimpleAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bSimpleAssembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bSimpleAssembly)) = value;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003A67 RID: 14951 RVA: 0x00118E20 File Offset: 0x00117020
		// (set) Token: 0x06003A68 RID: 14952 RVA: 0x000154F6 File Offset: 0x000136F6
		public unsafe Object handlerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handlerObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handlerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x00118E50 File Offset: 0x00117050
		// (set) Token: 0x06003A6A RID: 14954 RVA: 0x00015515 File Offset: 0x00013715
		public unsafe Object m_topObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_topObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_topObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x00118E80 File Offset: 0x00117080
		// (set) Token: 0x06003A6C RID: 14956 RVA: 0x00015534 File Offset: 0x00013734
		public unsafe Il2CppReferenceArray<Header> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x00118EB0 File Offset: 0x001170B0
		// (set) Token: 0x06003A6E RID: 14958 RVA: 0x00015553 File Offset: 0x00013753
		public unsafe HeaderHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x00118EE0 File Offset: 0x001170E0
		// (set) Token: 0x06003A70 RID: 14960 RVA: 0x00015572 File Offset: 0x00013772
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x00118F10 File Offset: 0x00117110
		// (set) Token: 0x06003A72 RID: 14962 RVA: 0x00015591 File Offset: 0x00013791
		public unsafe IFormatterConverter m_formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x00118F40 File Offset: 0x00117140
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x000155B0 File Offset: 0x000137B0
		public unsafe SerStack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x00118F70 File Offset: 0x00117170
		// (set) Token: 0x06003A76 RID: 14966 RVA: 0x000155CF File Offset: 0x000137CF
		public unsafe SerStack valueFixupStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valueFixupStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valueFixupStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x00118FA0 File Offset: 0x001171A0
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x000155EE File Offset: 0x000137EE
		public unsafe Il2CppReferenceArray<Object> crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x00118FD0 File Offset: 0x001171D0
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x0001560D File Offset: 0x0001380D
		public unsafe bool bFullDeserialization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bFullDeserialization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bFullDeserialization)) = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x00118FF8 File Offset: 0x001171F8
		// (set) Token: 0x06003A7C RID: 14972 RVA: 0x00015628 File Offset: 0x00013828
		public unsafe bool bOldFormatDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bOldFormatDetected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bOldFormatDetected)) = value;
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x00119020 File Offset: 0x00117220
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x00015643 File Offset: 0x00013843
		public unsafe IntSizedArray valTypeObjectIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntSizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x00119050 File Offset: 0x00117250
		// (set) Token: 0x06003A80 RID: 14976 RVA: 0x00015662 File Offset: 0x00013862
		public unsafe NameCache typeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_typeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_typeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x00119080 File Offset: 0x00117280
		// (set) Token: 0x06003A82 RID: 14978 RVA: 0x00015681 File Offset: 0x00013881
		public unsafe string previousAssemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousAssemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousAssemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x001190A8 File Offset: 0x001172A8
		// (set) Token: 0x06003A84 RID: 14980 RVA: 0x000156A0 File Offset: 0x000138A0
		public unsafe string previousName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x001190D0 File Offset: 0x001172D0
		// (set) Token: 0x06003A86 RID: 14982 RVA: 0x000156BF File Offset: 0x000138BF
		public unsafe Type previousType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeFieldInfoPtr_m_objectManager;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeFieldInfoPtr_formatterEnums;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeFieldInfoPtr_bSimpleAssembly;

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeFieldInfoPtr_handlerObject;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeFieldInfoPtr_m_topObject;

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeFieldInfoPtr_m_formatterConverter;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeFieldInfoPtr_valueFixupStack;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArray;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeFieldInfoPtr_bFullDeserialization;

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeFieldInfoPtr_bOldFormatDetected;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeFieldInfoPtr_valTypeObjectIdTable;

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeFieldInfoPtr_typeCache;

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeFieldInfoPtr_previousAssemblyString;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeFieldInfoPtr_previousName;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeFieldInfoPtr_previousType;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0;

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0;

		// Token: 0x040030F0 RID: 12528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0;

		// Token: 0x040030F1 RID: 12529
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0;

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0;

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0;

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0;

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0;

		// Token: 0x040030FA RID: 12538
		private static readonly IntPtr NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0;

		// Token: 0x040030FB RID: 12539
		private static readonly IntPtr NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0;

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0;

		// Token: 0x040030FE RID: 12542
		private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0;

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0;

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0;

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Type_String_String_0;

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0;

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0;

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0;

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0;

		// Token: 0x0200062B RID: 1579
		public class TypeNAssembly : Object
		{
			// Token: 0x060055DE RID: 21982 RVA: 0x0017FC84 File Offset: 0x0017DE84
			// Note: this type is marked as 'beforefieldinit'.
			static TypeNAssembly()
			{
				Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "TypeNAssembly");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr);
				ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, "type");
				ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, "assemblyName");
				ObjectReader.TypeNAssembly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, 100672125);
			}

			// Token: 0x060055DF RID: 21983 RVA: 0x0017FCEC File Offset: 0x0017DEEC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeNAssembly()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TypeNAssembly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055E0 RID: 21984 RVA: 0x00020B04 File Offset: 0x0001ED04
			public TypeNAssembly(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001617 RID: 5655
			// (get) Token: 0x060055E1 RID: 21985 RVA: 0x0017FD28 File Offset: 0x0017DF28
			// (set) Token: 0x060055E2 RID: 21986 RVA: 0x00020B0D File Offset: 0x0001ED0D
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001618 RID: 5656
			// (get) Token: 0x060055E3 RID: 21987 RVA: 0x0017FD58 File Offset: 0x0017DF58
			// (set) Token: 0x060055E4 RID: 21988 RVA: 0x00020B2C File Offset: 0x0001ED2C
			public unsafe string assemblyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004538 RID: 17720
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04004539 RID: 17721
			private static readonly IntPtr NativeFieldInfoPtr_assemblyName;

			// Token: 0x0400453A RID: 17722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200062C RID: 1580
		public sealed class TopLevelAssemblyTypeResolver : Object
		{
			// Token: 0x060055E5 RID: 21989 RVA: 0x0017FD80 File Offset: 0x0017DF80
			// Note: this type is marked as 'beforefieldinit'.
			static TopLevelAssemblyTypeResolver()
			{
				Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "TopLevelAssemblyTypeResolver");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr);
				ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, "m_topLevelAssembly");
				ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, 100672126);
				ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, 100672127);
			}

			// Token: 0x060055E6 RID: 21990 RVA: 0x0017FDE8 File Offset: 0x0017DFE8
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TopLevelAssemblyTypeResolver(Assembly topLevelAssembly)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(topLevelAssembly);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055E7 RID: 21991 RVA: 0x0017FE34 File Offset: 0x0017E034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217125, XrefRangeEnd = 217126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(simpleTypeName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}

			// Token: 0x060055E8 RID: 21992 RVA: 0x00020B4B File Offset: 0x0001ED4B
			public TopLevelAssemblyTypeResolver(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001619 RID: 5657
			// (get) Token: 0x060055E9 RID: 21993 RVA: 0x0017FEA4 File Offset: 0x0017E0A4
			// (set) Token: 0x060055EA RID: 21994 RVA: 0x00020B54 File Offset: 0x0001ED54
			public unsafe Assembly m_topLevelAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400453B RID: 17723
			private static readonly IntPtr NativeFieldInfoPtr_m_topLevelAssembly;

			// Token: 0x0400453C RID: 17724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;

			// Token: 0x0400453D RID: 17725
			private static readonly IntPtr NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0;
		}
	}
}
