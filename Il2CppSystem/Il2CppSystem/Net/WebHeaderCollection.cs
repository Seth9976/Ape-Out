using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FD RID: 253
	[DefaultMember("Item")]
	[Serializable]
	public class WebHeaderCollection : NameValueCollection
	{
		// Token: 0x06000DA4 RID: 3492 RVA: 0x00043E58 File Offset: 0x00042058
		// Note: this type is marked as 'beforefieldinit'.
		static WebHeaderCollection()
		{
			Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebHeaderCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr);
			WebHeaderCollection.NativeFieldInfoPtr_HInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "HInfo");
			WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_CommonHeaders");
			WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_NumCommonHeaders");
			WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "s_CommonHeaderNames");
			WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "s_CommonHeaderHints");
			WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_InnerCollection");
			WebHeaderCollection.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_Type");
			WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "HttpTrimCharacters");
			WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "RfcCharMap");
			WebHeaderCollection.NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665260);
			WebHeaderCollection.NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665261);
			WebHeaderCollection.NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665262);
			WebHeaderCollection.NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665263);
			WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665264);
			WebHeaderCollection.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665265);
			WebHeaderCollection.NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665266);
			WebHeaderCollection.NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665267);
			WebHeaderCollection.NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665268);
			WebHeaderCollection.NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665269);
			WebHeaderCollection.NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665270);
			WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665271);
			WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665272);
			WebHeaderCollection.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665273);
			WebHeaderCollection.NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665274);
			WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665275);
			WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665276);
			WebHeaderCollection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665277);
			WebHeaderCollection.NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665278);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665279);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665280);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665281);
			WebHeaderCollection.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665282);
			WebHeaderCollection.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665283);
			WebHeaderCollection.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665284);
			WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665285);
			WebHeaderCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665286);
			WebHeaderCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665287);
			WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665288);
			WebHeaderCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665289);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00044194 File Offset: 0x00042394
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 377060, RefRangeEnd = 377082, XrefRangeStart = 377053, XrefRangeEnd = 377060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NormalizeCommonHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x000441C8 File Offset: 0x000423C8
		public unsafe NameValueCollection InnerCollection
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 377090, RefRangeEnd = 377104, XrefRangeStart = 377082, XrefRangeEnd = 377090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00044208 File Offset: 0x00042408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 377111, RefRangeEnd = 377112, XrefRangeStart = 377104, XrefRangeEnd = 377111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowMultiValues(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x0004424C File Offset: 0x0004244C
		public unsafe bool AllowHttpRequestHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00044288 File Offset: 0x00042488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 377132, RefRangeEnd = 377133, XrefRangeStart = 377112, XrefRangeEnd = 377132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(HttpRequestHeader header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref header;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000442C8 File Offset: 0x000424C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 377137, RefRangeEnd = 377138, XrefRangeStart = 377133, XrefRangeEnd = 377137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInternal(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0004431C File Offset: 0x0004251C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 377142, RefRangeEnd = 377147, XrefRangeStart = 377138, XrefRangeEnd = 377142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInternal(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00044370 File Offset: 0x00042570
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 377149, RefRangeEnd = 377154, XrefRangeStart = 377147, XrefRangeEnd = 377149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInternal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000443B4 File Offset: 0x000425B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 377173, RefRangeEnd = 377182, XrefRangeStart = 377154, XrefRangeEnd = 377173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CheckBadChars(string name, bool isHeaderValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHeaderValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00044400 File Offset: 0x00042600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377182, XrefRangeEnd = 377184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsNonAsciiChars(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00044444 File Offset: 0x00042644
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 377194, RefRangeEnd = 377198, XrefRangeStart = 377184, XrefRangeEnd = 377194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOnRestrictedHeader(string headerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(headerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00044488 File Offset: 0x00042688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377198, XrefRangeEnd = 377223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Add(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000444E8 File Offset: 0x000426E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 377268, RefRangeEnd = 377269, XrefRangeStart = 377223, XrefRangeEnd = 377268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0004452C File Offset: 0x0004272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377269, XrefRangeEnd = 377303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Set(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0004458C File Offset: 0x0004278C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 377336, RefRangeEnd = 377339, XrefRangeStart = 377303, XrefRangeEnd = 377336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInternal(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000445E0 File Offset: 0x000427E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377339, XrefRangeEnd = 377349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00044630 File Offset: 0x00042830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377349, XrefRangeEnd = 377364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetValues(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0004468C File Offset: 0x0004288C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377364, XrefRangeEnd = 377368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x000446D0 File Offset: 0x000428D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 377395, RefRangeEnd = 377396, XrefRangeStart = 377368, XrefRangeEnd = 377395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref winInetCompat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forTrace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00044728 File Offset: 0x00042928
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 377402, RefRangeEnd = 377406, XrefRangeStart = 377396, XrefRangeEnd = 377402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00044764 File Offset: 0x00042964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 377419, RefRangeEnd = 377420, XrefRangeStart = 377406, XrefRangeEnd = 377419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection(WebHeaderCollectionType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x000447AC File Offset: 0x000429AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377420, XrefRangeEnd = 377446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00044810 File Offset: 0x00042A10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00044860 File Offset: 0x00042A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377446, XrefRangeEnd = 377488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000448C4 File Offset: 0x00042AC4
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00044920 File Offset: 0x00042B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377488, XrefRangeEnd = 377511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00044974 File Offset: 0x00042B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377511, XrefRangeEnd = 377517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x000449C0 File Offset: 0x00042BC0
		public unsafe override int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00044A08 File Offset: 0x00042C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377517, XrefRangeEnd = 377520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00044A58 File Offset: 0x00042C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377520, XrefRangeEnd = 377648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000075E0 File Offset: 0x000057E0
		public WebHeaderCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00044AA8 File Offset: 0x00042CA8
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x000075E9 File Offset: 0x000057E9
		public unsafe static HeaderInfoTable HInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_HInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderInfoTable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_HInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00044AD0 File Offset: 0x00042CD0
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x000075FB File Offset: 0x000057FB
		public unsafe Il2CppStringArray m_CommonHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00044B00 File Offset: 0x00042D00
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0000761A File Offset: 0x0000581A
		public unsafe int m_NumCommonHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00044B28 File Offset: 0x00042D28
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00007635 File Offset: 0x00005835
		public unsafe static Il2CppStringArray s_CommonHeaderNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00044B50 File Offset: 0x00042D50
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00007647 File Offset: 0x00005847
		public unsafe static Il2CppStructArray<sbyte> s_CommonHeaderHints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00044B78 File Offset: 0x00042D78
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00007659 File Offset: 0x00005859
		public unsafe NameValueCollection m_InnerCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00044BA8 File Offset: 0x00042DA8
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00007678 File Offset: 0x00005878
		public unsafe WebHeaderCollectionType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00044BD0 File Offset: 0x00042DD0
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00007693 File Offset: 0x00005893
		public unsafe static Il2CppStructArray<char> HttpTrimCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00044BF8 File Offset: 0x00042DF8
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x000076A5 File Offset: 0x000058A5
		public unsafe static Il2CppStructArray<WebHeaderCollection.RfcChar> RfcCharMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WebHeaderCollection.RfcChar>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr_HInfo;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr_m_CommonHeaders;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeFieldInfoPtr_m_NumCommonHeaders;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeFieldInfoPtr_s_CommonHeaderNames;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeFieldInfoPtr_s_CommonHeaderHints;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr_m_InnerCollection;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr_HttpTrimCharacters;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeFieldInfoPtr_RfcCharMap;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_String_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0;

		// Token: 0x020001CE RID: 462
		[OriginalName("System.dll", "", "RfcChar")]
		public enum RfcChar : byte
		{
			// Token: 0x0400145C RID: 5212
			High,
			// Token: 0x0400145D RID: 5213
			Reg,
			// Token: 0x0400145E RID: 5214
			Ctl,
			// Token: 0x0400145F RID: 5215
			CR,
			// Token: 0x04001460 RID: 5216
			LF,
			// Token: 0x04001461 RID: 5217
			WS,
			// Token: 0x04001462 RID: 5218
			Colon,
			// Token: 0x04001463 RID: 5219
			Delim
		}
	}
}
