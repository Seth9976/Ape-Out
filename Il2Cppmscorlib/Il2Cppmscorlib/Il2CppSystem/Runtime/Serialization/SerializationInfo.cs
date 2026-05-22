using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000349 RID: 841
	public sealed class SerializationInfo : Object
	{
		// Token: 0x060036D1 RID: 14033 RVA: 0x0010C8DC File Offset: 0x0010AADC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationInfo()
		{
			Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr);
			SerializationInfo.NativeFieldInfoPtr_defaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "defaultSize");
			SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "s_mscorlibAssemblySimpleName");
			SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "s_mscorlibFileName");
			SerializationInfo.NativeFieldInfoPtr_m_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_members");
			SerializationInfo.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_data");
			SerializationInfo.NativeFieldInfoPtr_m_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_types");
			SerializationInfo.NativeFieldInfoPtr_m_nameToIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_nameToIndex");
			SerializationInfo.NativeFieldInfoPtr_m_currMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_currMember");
			SerializationInfo.NativeFieldInfoPtr_m_converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_converter");
			SerializationInfo.NativeFieldInfoPtr_m_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_fullTypeName");
			SerializationInfo.NativeFieldInfoPtr_m_assemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_assemName");
			SerializationInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "objectType");
			SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "isFullTypeNameSetExplicit");
			SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "isAssemblyNameSetExplicit");
			SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "requireSameTokenInPartialTrust");
			SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671807);
			SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671808);
			SerializationInfo.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671809);
			SerializationInfo.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671810);
			SerializationInfo.NativeMethodInfoPtr_SetType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671811);
			SerializationInfo.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671812);
			SerializationInfo.NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671813);
			SerializationInfo.NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671814);
			SerializationInfo.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671815);
			SerializationInfo.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671816);
			SerializationInfo.NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671817);
			SerializationInfo.NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671818);
			SerializationInfo.NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671819);
			SerializationInfo.NativeMethodInfoPtr_ExpandArrays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671820);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671821);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671822);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671823);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671824);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671825);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671826);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671827);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671828);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671829);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671830);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671831);
			SerializationInfo.NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671832);
			SerializationInfo.NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671833);
			SerializationInfo.NativeMethodInfoPtr_FindElement_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671834);
			SerializationInfo.NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671835);
			SerializationInfo.NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671836);
			SerializationInfo.NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671837);
			SerializationInfo.NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671838);
			SerializationInfo.NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671839);
			SerializationInfo.NativeMethodInfoPtr_GetInt32_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671840);
			SerializationInfo.NativeMethodInfoPtr_GetInt64_Public_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671841);
			SerializationInfo.NativeMethodInfoPtr_GetSingle_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671842);
			SerializationInfo.NativeMethodInfoPtr_GetString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671843);
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0010CD1C File Offset: 0x0010AF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214714, XrefRangeEnd = 214715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfo(Type type, IFormatterConverter converter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x0010CD7C File Offset: 0x0010AF7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 214735, RefRangeEnd = 214740, XrefRangeStart = 214715, XrefRangeEnd = 214735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requireSameTokenInPartialTrust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x0010CDE8 File Offset: 0x0010AFE8
		public unsafe string FullTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x0010CE20 File Offset: 0x0010B020
		public unsafe string AssemblyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x0010CE58 File Offset: 0x0010B058
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 214744, RefRangeEnd = 214755, XrefRangeStart = 214740, XrefRangeEnd = 214744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_SetType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x0010CE9C File Offset: 0x0010B09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214755, XrefRangeEnd = 214756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(Il2CppStructArray<byte> a, Il2CppStructArray<byte> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x0010CEF0 File Offset: 0x0010B0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214756, XrefRangeEnd = 214757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalAssemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newAssemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x0010CF38 File Offset: 0x0010B138
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 214779, RefRangeEnd = 214784, XrefRangeStart = 214757, XrefRangeEnd = 214779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalAssemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newAssemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x0010CF8C File Offset: 0x0010B18C
		public unsafe int MemberCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x0010CFC8 File Offset: 0x0010B1C8
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x0010D008 File Offset: 0x0010B208
		public unsafe bool IsFullTypeNameSetExplicit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x0010D044 File Offset: 0x0010B244
		public unsafe bool IsAssemblyNameSetExplicit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0010D080 File Offset: 0x0010B280
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 214787, RefRangeEnd = 214806, XrefRangeStart = 214784, XrefRangeEnd = 214787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfoEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfoEnumerator>(intPtr3) : null;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0010D0C0 File Offset: 0x0010B2C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214824, RefRangeEnd = 214825, XrefRangeStart = 214806, XrefRangeEnd = 214824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandArrays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_ExpandArrays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0010D0F4 File Offset: 0x0010B2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214825, XrefRangeEnd = 214838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x0010D15C File Offset: 0x0010B35C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 214842, RefRangeEnd = 214861, XrefRangeStart = 214838, XrefRangeEnd = 214842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0010D1B0 File Offset: 0x0010B3B0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 214871, RefRangeEnd = 214895, XrefRangeStart = 214861, XrefRangeEnd = 214871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x0010D200 File Offset: 0x0010B400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214905, RefRangeEnd = 214907, XrefRangeStart = 214895, XrefRangeEnd = 214905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x0010D250 File Offset: 0x0010B450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214917, RefRangeEnd = 214920, XrefRangeStart = 214907, XrefRangeEnd = 214917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x0010D2A0 File Offset: 0x0010B4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214920, XrefRangeEnd = 214930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x0010D2F0 File Offset: 0x0010B4F0
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 214940, RefRangeEnd = 214987, XrefRangeStart = 214930, XrefRangeEnd = 214940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x0010D340 File Offset: 0x0010B540
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 214997, RefRangeEnd = 215005, XrefRangeStart = 214987, XrefRangeEnd = 214997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x0010D390 File Offset: 0x0010B590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215015, RefRangeEnd = 215017, XrefRangeStart = 215005, XrefRangeEnd = 215015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x0010D3E0 File Offset: 0x0010B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215017, XrefRangeEnd = 215027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x0010D430 File Offset: 0x0010B630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 215037, RefRangeEnd = 215041, XrefRangeStart = 215027, XrefRangeEnd = 215037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x0010D480 File Offset: 0x0010B680
		[CallerCount(221)]
		[CachedScanResults(RefRangeStart = 215052, RefRangeEnd = 215273, XrefRangeStart = 215041, XrefRangeEnd = 215052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValueInternal(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x0010D4E8 File Offset: 0x0010B6E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215280, RefRangeEnd = 215281, XrefRangeStart = 215273, XrefRangeEnd = 215280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValue(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x0010D550 File Offset: 0x0010B750
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215287, XrefRangeStart = 215281, XrefRangeEnd = 215283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_FindElement_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x0010D5A0 File Offset: 0x0010B7A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 215288, RefRangeEnd = 215294, XrefRangeStart = 215287, XrefRangeEnd = 215288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetElement(string name, out Type foundType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x0010D614 File Offset: 0x0010B814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215294, XrefRangeEnd = 215295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetElementNoThrow(string name, out Type foundType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x0010D688 File Offset: 0x0010B888
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 215302, RefRangeEnd = 215428, XrefRangeStart = 215295, XrefRangeEnd = 215302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x0010D6EC File Offset: 0x0010B8EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 215431, RefRangeEnd = 215438, XrefRangeStart = 215428, XrefRangeEnd = 215431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueNoThrow(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0010D750 File Offset: 0x0010B950
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 215449, RefRangeEnd = 215463, XrefRangeStart = 215438, XrefRangeEnd = 215449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBoolean(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x0010D7A0 File Offset: 0x0010B9A0
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 215474, RefRangeEnd = 215504, XrefRangeStart = 215463, XrefRangeEnd = 215474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt32(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetInt32_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x0010D7F0 File Offset: 0x0010B9F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 215515, RefRangeEnd = 215522, XrefRangeStart = 215504, XrefRangeEnd = 215515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetInt64(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetInt64_Public_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x0010D840 File Offset: 0x0010BA40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215533, RefRangeEnd = 215534, XrefRangeStart = 215522, XrefRangeEnd = 215533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSingle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetSingle_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x0010D890 File Offset: 0x0010BA90
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 215545, RefRangeEnd = 215597, XrefRangeStart = 215534, XrefRangeEnd = 215545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00013782 File Offset: 0x00011982
		public SerializationInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x0010D8D8 File Offset: 0x0010BAD8
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x0001378B File Offset: 0x0001198B
		public unsafe static int defaultSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_defaultSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_defaultSize, (void*)(&value));
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x0010D8F4 File Offset: 0x0010BAF4
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x00013799 File Offset: 0x00011999
		public unsafe static string s_mscorlibAssemblySimpleName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x0010D914 File Offset: 0x0010BB14
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x000137AB File Offset: 0x000119AB
		public unsafe static string s_mscorlibFileName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x0010D934 File Offset: 0x0010BB34
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x000137BD File Offset: 0x000119BD
		public unsafe Il2CppStringArray m_members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x0010D964 File Offset: 0x0010BB64
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x000137DC File Offset: 0x000119DC
		public unsafe Il2CppReferenceArray<Object> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x0010D994 File Offset: 0x0010BB94
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x000137FB File Offset: 0x000119FB
		public unsafe Il2CppReferenceArray<Type> m_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x0010D9C4 File Offset: 0x0010BBC4
		// (set) Token: 0x06003705 RID: 14085 RVA: 0x0001381A File Offset: 0x00011A1A
		public unsafe Dictionary<string, int> m_nameToIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_nameToIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_nameToIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x0010D9F4 File Offset: 0x0010BBF4
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x00013839 File Offset: 0x00011A39
		public unsafe int m_currMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_currMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_currMember)) = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x0010DA1C File Offset: 0x0010BC1C
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x00013854 File Offset: 0x00011A54
		public unsafe IFormatterConverter m_converter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_converter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_converter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x0010DA4C File Offset: 0x0010BC4C
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x00013873 File Offset: 0x00011A73
		public unsafe string m_fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x0010DA74 File Offset: 0x0010BC74
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x00013892 File Offset: 0x00011A92
		public unsafe string m_assemName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_assemName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_assemName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x0010DA9C File Offset: 0x0010BC9C
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x000138B1 File Offset: 0x00011AB1
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x0010DACC File Offset: 0x0010BCCC
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x000138D0 File Offset: 0x00011AD0
		public unsafe bool isFullTypeNameSetExplicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit)) = value;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x0010DAF4 File Offset: 0x0010BCF4
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x000138EB File Offset: 0x00011AEB
		public unsafe bool isAssemblyNameSetExplicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit)) = value;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x0010DB1C File Offset: 0x0010BD1C
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x00013906 File Offset: 0x00011B06
		public unsafe bool requireSameTokenInPartialTrust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust)) = value;
			}
		}

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeFieldInfoPtr_defaultSize;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeFieldInfoPtr_s_mscorlibAssemblySimpleName;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeFieldInfoPtr_s_mscorlibFileName;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeFieldInfoPtr_m_members;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeFieldInfoPtr_m_types;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeFieldInfoPtr_m_nameToIndex;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeFieldInfoPtr_m_currMember;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeFieldInfoPtr_m_converter;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeFieldInfoPtr_m_fullTypeName;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeFieldInfoPtr_m_assemName;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeFieldInfoPtr_isFullTypeNameSetExplicit;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeFieldInfoPtr_isAssemblyNameSetExplicit;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeFieldInfoPtr_requireSameTokenInPartialTrust;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Public_Void_Type_0;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_ExpandArrays_Private_Void_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0;

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Char_0;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0;

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0;

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Private_Int32_String_0;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0;

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Public_Int32_String_0;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeMethodInfoPtr_GetInt64_Public_Int64_String_0;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeMethodInfoPtr_GetSingle_Public_Single_String_0;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_0;
	}
}
