using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037B RID: 891
	public sealed class ReadObjectInfo : Object
	{
		// Token: 0x060039D4 RID: 14804 RVA: 0x0011686C File Offset: 0x00114A6C
		// Note: this type is marked as 'beforefieldinit'.
		static ReadObjectInfo()
		{
			Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ReadObjectInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr);
			ReadObjectInfo.NativeFieldInfoPtr_objectInfoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectInfoId");
			ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "readObjectInfoCounter");
			ReadObjectInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectType");
			ReadObjectInfo.NativeFieldInfoPtr_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectManager");
			ReadObjectInfo.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "count");
			ReadObjectInfo.NativeFieldInfoPtr_isSi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isSi");
			ReadObjectInfo.NativeFieldInfoPtr_isNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isNamed");
			ReadObjectInfo.NativeFieldInfoPtr_isTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isTyped");
			ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "bSimpleAssembly");
			ReadObjectInfo.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "cache");
			ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "wireMemberNames");
			ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "wireMemberTypes");
			ReadObjectInfo.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "lastPosition");
			ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "serializationSurrogate");
			ReadObjectInfo.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "context");
			ReadObjectInfo.NativeFieldInfoPtr_memberTypesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "memberTypesList");
			ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "serObjectInfoInit");
			ReadObjectInfo.NativeFieldInfoPtr_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "formatterConverter");
			ReadObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672064);
			ReadObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672065);
			ReadObjectInfo.NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672066);
			ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672067);
			ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672068);
			ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672069);
			ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672070);
			ReadObjectInfo.NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672071);
			ReadObjectInfo.NativeMethodInfoPtr_InitSiRead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672072);
			ReadObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672073);
			ReadObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672074);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672075);
			ReadObjectInfo.NativeMethodInfoPtr_GetType_Internal_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672076);
			ReadObjectInfo.NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672077);
			ReadObjectInfo.NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672078);
			ReadObjectInfo.NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672079);
			ReadObjectInfo.NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672080);
			ReadObjectInfo.NativeMethodInfoPtr_Position_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672081);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672082);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672083);
			ReadObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100672084);
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00116BA8 File Offset: 0x00114DA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00116BE4 File Offset: 0x00114DE4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00116C18 File Offset: 0x00114E18
		[CallerCount(0)]
		public unsafe void PrepareForReuse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00116C4C File Offset: 0x00114E4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216973, RefRangeEnd = 216976, XrefRangeStart = 216968, XrefRangeEnd = 216973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00116D00 File Offset: 0x00114F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216977, RefRangeEnd = 216978, XrefRangeStart = 216976, XrefRangeEnd = 216977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00116DB4 File Offset: 0x00114FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216978, XrefRangeEnd = 216983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo Create(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00116E90 File Offset: 0x00115090
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216984, RefRangeEnd = 216987, XrefRangeStart = 216983, XrefRangeEnd = 216984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00116F6C File Offset: 0x0011516C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216997, RefRangeEnd = 216999, XrefRangeStart = 216987, XrefRangeEnd = 216997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00116FD8 File Offset: 0x001151D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216999, XrefRangeEnd = 217007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSiRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitSiRead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x0011700C File Offset: 0x0011520C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217007, XrefRangeEnd = 217011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00117040 File Offset: 0x00115240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217030, RefRangeEnd = 217031, XrefRangeStart = 217011, XrefRangeEnd = 217030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMemberInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00117074 File Offset: 0x00115274
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217032, RefRangeEnd = 217036, XrefRangeStart = 217031, XrefRangeEnd = 217032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfo GetMemberInfo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x001170C4 File Offset: 0x001152C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217036, XrefRangeEnd = 217040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetType_Internal_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00117114 File Offset: 0x00115314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217043, RefRangeEnd = 217044, XrefRangeStart = 217040, XrefRangeEnd = 217043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value, ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x001171BC File Offset: 0x001153BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217052, RefRangeEnd = 217056, XrefRangeStart = 217044, XrefRangeEnd = 217052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDataStore(ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x0011723C File Offset: 0x0011543C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217056, XrefRangeEnd = 217057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordFixup(long objectId, string name, long idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x0011729C File Offset: 0x0011549C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217057, XrefRangeEnd = 217061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateObjectMembers(Object obj, Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x001172F0 File Offset: 0x001154F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 217062, RefRangeEnd = 217067, XrefRangeStart = 217061, XrefRangeEnd = 217062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Position(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Position_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00117340 File Offset: 0x00115540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217091, RefRangeEnd = 217093, XrefRangeStart = 217067, XrefRangeEnd = 217091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetMemberTypes(Il2CppStringArray inMemberNames, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inMemberNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x001173A4 File Offset: 0x001155A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217097, RefRangeEnd = 217099, XrefRangeStart = 217093, XrefRangeEnd = 217097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetMemberType(MemberInfo objMember)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objMember);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x001173F4 File Offset: 0x001155F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217099, XrefRangeEnd = 217103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00015052 File Offset: 0x00013252
		public ReadObjectInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x060039EB RID: 14827 RVA: 0x00117438 File Offset: 0x00115638
		// (set) Token: 0x060039EC RID: 14828 RVA: 0x0001505B File Offset: 0x0001325B
		public unsafe int objectInfoId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectInfoId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectInfoId)) = value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x00117460 File Offset: 0x00115660
		// (set) Token: 0x060039EE RID: 14830 RVA: 0x00015076 File Offset: 0x00013276
		public unsafe static int readObjectInfoCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter, (void*)(&value));
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x0011747C File Offset: 0x0011567C
		// (set) Token: 0x060039F0 RID: 14832 RVA: 0x00015084 File Offset: 0x00013284
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x001174AC File Offset: 0x001156AC
		// (set) Token: 0x060039F2 RID: 14834 RVA: 0x000150A3 File Offset: 0x000132A3
		public unsafe ObjectManager objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x001174DC File Offset: 0x001156DC
		// (set) Token: 0x060039F4 RID: 14836 RVA: 0x000150C2 File Offset: 0x000132C2
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x00117504 File Offset: 0x00115704
		// (set) Token: 0x060039F6 RID: 14838 RVA: 0x000150DD File Offset: 0x000132DD
		public unsafe bool isSi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isSi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isSi)) = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x0011752C File Offset: 0x0011572C
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x000150F8 File Offset: 0x000132F8
		public unsafe bool isNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isNamed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isNamed)) = value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x00117554 File Offset: 0x00115754
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x00015113 File Offset: 0x00013313
		public unsafe bool isTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isTyped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isTyped)) = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x0011757C File Offset: 0x0011577C
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x0001512E File Offset: 0x0001332E
		public unsafe bool bSimpleAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly)) = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x001175A4 File Offset: 0x001157A4
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x00015149 File Offset: 0x00013349
		public unsafe SerObjectInfoCache cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x001175D4 File Offset: 0x001157D4
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x00015168 File Offset: 0x00013368
		public unsafe Il2CppStringArray wireMemberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x00117604 File Offset: 0x00115804
		// (set) Token: 0x06003A02 RID: 14850 RVA: 0x00015187 File Offset: 0x00013387
		public unsafe Il2CppReferenceArray<Type> wireMemberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x00117634 File Offset: 0x00115834
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x000151A6 File Offset: 0x000133A6
		public unsafe int lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x0011765C File Offset: 0x0011585C
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x000151C1 File Offset: 0x000133C1
		public unsafe ISerializationSurrogate serializationSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x0011768C File Offset: 0x0011588C
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x000151E0 File Offset: 0x000133E0
		public StreamingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x001176BC File Offset: 0x001158BC
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x0001520E File Offset: 0x0001340E
		public unsafe List<Type> memberTypesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_memberTypesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_memberTypesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x001176EC File Offset: 0x001158EC
		// (set) Token: 0x06003A0C RID: 14860 RVA: 0x0001522D File Offset: 0x0001342D
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x0011771C File Offset: 0x0011591C
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x0001524C File Offset: 0x0001344C
		public unsafe IFormatterConverter formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoId;

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeFieldInfoPtr_readObjectInfoCounter;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeFieldInfoPtr_objectManager;

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeFieldInfoPtr_isSi;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeFieldInfoPtr_isNamed;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeFieldInfoPtr_isTyped;

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeFieldInfoPtr_bSimpleAssembly;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeFieldInfoPtr_wireMemberNames;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeFieldInfoPtr_wireMemberTypes;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeFieldInfoPtr_serializationSurrogate;

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeFieldInfoPtr_memberTypesList;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeFieldInfoPtr_formatterConverter;

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeMethodInfoPtr_ObjectEnd_Internal_Void_0;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x040030B2 RID: 12466
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x040030B3 RID: 12467
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeMethodInfoPtr_InitSiRead_Private_Void_0;

		// Token: 0x040030B6 RID: 12470
		private static readonly IntPtr NativeMethodInfoPtr_InitNoMembers_Private_Void_0;

		// Token: 0x040030B7 RID: 12471
		private static readonly IntPtr NativeMethodInfoPtr_InitMemberInfo_Private_Void_0;

		// Token: 0x040030B8 RID: 12472
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0;

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Type_String_0;

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0;

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeMethodInfoPtr_Position_Private_Int32_String_0;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0;
	}
}
