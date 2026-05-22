using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037A RID: 890
	public sealed class WriteObjectInfo : Object
	{
		// Token: 0x0600399E RID: 14750 RVA: 0x00115C18 File Offset: 0x00113E18
		// Note: this type is marked as 'beforefieldinit'.
		static WriteObjectInfo()
		{
			Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "WriteObjectInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr);
			WriteObjectInfo.NativeFieldInfoPtr_objectInfoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectInfoId");
			WriteObjectInfo.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "obj");
			WriteObjectInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectType");
			WriteObjectInfo.NativeFieldInfoPtr_isSi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isSi");
			WriteObjectInfo.NativeFieldInfoPtr_isNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isNamed");
			WriteObjectInfo.NativeFieldInfoPtr_isTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isTyped");
			WriteObjectInfo.NativeFieldInfoPtr_isArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isArray");
			WriteObjectInfo.NativeFieldInfoPtr_si = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "si");
			WriteObjectInfo.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "cache");
			WriteObjectInfo.NativeFieldInfoPtr_memberData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "memberData");
			WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "serializationSurrogate");
			WriteObjectInfo.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "context");
			WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "serObjectInfoInit");
			WriteObjectInfo.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectId");
			WriteObjectInfo.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "assemId");
			WriteObjectInfo.NativeFieldInfoPtr_binderTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "binderTypeName");
			WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "binderAssemblyString");
			WriteObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672046);
			WriteObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672047);
			WriteObjectInfo.NativeMethodInfoPtr_InternalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672048);
			WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672049);
			WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672050);
			WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672051);
			WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672052);
			WriteObjectInfo.NativeMethodInfoPtr_InitSiWrite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672053);
			WriteObjectInfo.NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672054);
			WriteObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672055);
			WriteObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672056);
			WriteObjectInfo.NativeMethodInfoPtr_GetTypeFullName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672057);
			WriteObjectInfo.NativeMethodInfoPtr_GetAssemblyString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672058);
			WriteObjectInfo.NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672059);
			WriteObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672060);
			WriteObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672061);
			WriteObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672062);
			WriteObjectInfo.NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100672063);
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00115F04 File Offset: 0x00114104
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteObjectInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00115F40 File Offset: 0x00114140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216814, XrefRangeEnd = 216816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00115F74 File Offset: 0x00114174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216816, RefRangeEnd = 216817, XrefRangeStart = 216816, XrefRangeEnd = 216816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InternalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00115FA8 File Offset: 0x001141A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216819, RefRangeEnd = 216821, XrefRangeStart = 216817, XrefRangeEnd = 216819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo Serialize(Object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x00116060 File Offset: 0x00114260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216838, RefRangeEnd = 216839, XrefRangeStart = 216821, XrefRangeEnd = 216838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSerialize(Object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x00116118 File Offset: 0x00114318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216841, RefRangeEnd = 216842, XrefRangeStart = 216839, XrefRangeEnd = 216841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x001161C0 File Offset: 0x001143C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216887, RefRangeEnd = 216889, XrefRangeStart = 216842, XrefRangeEnd = 216887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x00116264 File Offset: 0x00114464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216919, RefRangeEnd = 216920, XrefRangeStart = 216889, XrefRangeEnd = 216919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSiWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSiWrite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x00116298 File Offset: 0x00114498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216920, XrefRangeEnd = 216925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(binderAssemblyString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x001162F4 File Offset: 0x001144F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216925, XrefRangeEnd = 216930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x00116328 File Offset: 0x00114528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216953, RefRangeEnd = 216954, XrefRangeStart = 216930, XrefRangeEnd = 216953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMemberInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x0011635C File Offset: 0x0011455C
		[CallerCount(0)]
		public unsafe string GetTypeFullName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetTypeFullName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x00116394 File Offset: 0x00114594
		[CallerCount(0)]
		public unsafe string GetAssemblyString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetAssemblyString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x001163CC File Offset: 0x001145CC
		[CallerCount(0)]
		public unsafe void InvokeSerializationBinder(SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x00116410 File Offset: 0x00114610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216958, RefRangeEnd = 216959, XrefRangeStart = 216954, XrefRangeEnd = 216958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetMemberType(MemberInfo objMember)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objMember);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00116460 File Offset: 0x00114660
		[CallerCount(0)]
		public unsafe void GetMemberInfo(out Il2CppStringArray outMemberNames, out Il2CppReferenceArray<Type> outMemberTypes, out Il2CppReferenceArray<Object> outMemberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			outMemberNames = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr2;
			outMemberTypes = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<Type>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			outMemberData = ((intPtr8 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr8));
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x001164F8 File Offset: 0x001146F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216963, RefRangeEnd = 216966, XrefRangeStart = 216959, XrefRangeEnd = 216963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0011653C File Offset: 0x0011473C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216966, XrefRangeEnd = 216968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x00014E47 File Offset: 0x00013047
		public WriteObjectInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x00116584 File Offset: 0x00114784
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x00014E50 File Offset: 0x00013050
		public unsafe int objectInfoId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectInfoId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectInfoId)) = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x001165AC File Offset: 0x001147AC
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x00014E6B File Offset: 0x0001306B
		public unsafe Object obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x001165DC File Offset: 0x001147DC
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x00014E8A File Offset: 0x0001308A
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x0011660C File Offset: 0x0011480C
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x00014EA9 File Offset: 0x000130A9
		public unsafe bool isSi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isSi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isSi)) = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x00116634 File Offset: 0x00114834
		// (set) Token: 0x060039BB RID: 14779 RVA: 0x00014EC4 File Offset: 0x000130C4
		public unsafe bool isNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isNamed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isNamed)) = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x0011665C File Offset: 0x0011485C
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x00014EDF File Offset: 0x000130DF
		public unsafe bool isTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isTyped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isTyped)) = value;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x00116684 File Offset: 0x00114884
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x00014EFA File Offset: 0x000130FA
		public unsafe bool isArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isArray)) = value;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x001166AC File Offset: 0x001148AC
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x00014F15 File Offset: 0x00013115
		public unsafe SerializationInfo si
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_si);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_si), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x001166DC File Offset: 0x001148DC
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x00014F34 File Offset: 0x00013134
		public unsafe SerObjectInfoCache cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x0011670C File Offset: 0x0011490C
		// (set) Token: 0x060039C5 RID: 14789 RVA: 0x00014F53 File Offset: 0x00013153
		public unsafe Il2CppReferenceArray<Object> memberData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_memberData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_memberData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x0011673C File Offset: 0x0011493C
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x00014F72 File Offset: 0x00013172
		public unsafe ISerializationSurrogate serializationSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x0011676C File Offset: 0x0011496C
		// (set) Token: 0x060039C9 RID: 14793 RVA: 0x00014F91 File Offset: 0x00013191
		public StreamingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x0011679C File Offset: 0x0011499C
		// (set) Token: 0x060039CB RID: 14795 RVA: 0x00014FBF File Offset: 0x000131BF
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x001167CC File Offset: 0x001149CC
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x00014FDE File Offset: 0x000131DE
		public unsafe long objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x001167F4 File Offset: 0x001149F4
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x00014FF9 File Offset: 0x000131F9
		public unsafe long assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x0011681C File Offset: 0x00114A1C
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x00015014 File Offset: 0x00013214
		public unsafe string binderTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x00116844 File Offset: 0x00114A44
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x00015033 File Offset: 0x00013233
		public unsafe string binderAssemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoId;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeFieldInfoPtr_obj;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeFieldInfoPtr_isSi;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeFieldInfoPtr_isNamed;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeFieldInfoPtr_isTyped;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeFieldInfoPtr_isArray;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeFieldInfoPtr_si;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeFieldInfoPtr_memberData;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeFieldInfoPtr_serializationSurrogate;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeFieldInfoPtr_binderTypeName;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeFieldInfoPtr_binderAssemblyString;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeMethodInfoPtr_ObjectEnd_Internal_Void_0;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeMethodInfoPtr_InternalInit_Private_Void_0;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr_InitSiWrite_Private_Void_0;

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0;

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeMethodInfoPtr_InitNoMembers_Private_Void_0;

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeMethodInfoPtr_InitMemberInfo_Private_Void_0;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFullName_Internal_String_0;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyString_Internal_String_0;

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0;

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0;
	}
}
