using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Principal;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class WebRequest : MarshalByRefObject
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x00044EC8 File Offset: 0x000430C8
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequest()
		{
			Il2CppClassPointerStore<WebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest>.NativeClassPtr);
			WebRequest.NativeFieldInfoPtr_s_PrefixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_PrefixList");
			WebRequest.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_InternalSyncObject");
			WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultTimerQueue");
			WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_AuthenticationLevel");
			WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_ImpersonationLevel");
			WebRequest.NativeFieldInfoPtr_m_CachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CachePolicy");
			WebRequest.NativeFieldInfoPtr_m_CacheProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CacheProtocol");
			WebRequest.NativeFieldInfoPtr_m_CacheBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "m_CacheBinding");
			WebRequest.NativeFieldInfoPtr_webRequestCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "webRequestCreate");
			WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultWebProxy");
			WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "s_DefaultWebProxyInitialized");
			WebRequest.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665297);
			WebRequest.NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665298);
			WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665299);
			WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665300);
			WebRequest.NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665301);
			WebRequest.NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665302);
			WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665303);
			WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665304);
			WebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665305);
			WebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665306);
			WebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665307);
			WebRequest.NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665308);
			WebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665309);
			WebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665310);
			WebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665311);
			WebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665312);
			WebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665313);
			WebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665314);
			WebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665315);
			WebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665316);
			WebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665317);
			WebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665318);
			WebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665319);
			WebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665320);
			WebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665321);
			WebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665322);
			WebRequest.NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665323);
			WebRequest.NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665324);
			WebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665325);
			WebRequest.NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665326);
			WebRequest.NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665327);
			WebRequest.NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665328);
			WebRequest.NativeMethodInfoPtr_get_DefaultWebProxy_Public_Static_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665329);
			WebRequest.NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, 100665331);
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0004527C File Offset: 0x0004347C
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 377754, RefRangeEnd = 377756, XrefRangeStart = 377741, XrefRangeEnd = 377754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000452B0 File Offset: 0x000434B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 377786, RefRangeEnd = 377792, XrefRangeStart = 377756, XrefRangeEnd = 377786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(Uri requestUri, bool useUriBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useUriBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00045304 File Offset: 0x00043504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377792, XrefRangeEnd = 377806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(string requestUriString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(requestUriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00045348 File Offset: 0x00043548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377806, XrefRangeEnd = 377819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebRequest Create(Uri requestUri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0004538C File Offset: 0x0004358C
		public unsafe static ArrayList PrefixList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 377839, RefRangeEnd = 377840, XrefRangeStart = 377819, XrefRangeEnd = 377839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000453C0 File Offset: 0x000435C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 377874, RefRangeEnd = 377875, XrefRangeStart = 377840, XrefRangeEnd = 377874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayList PopulatePrefixList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000453F4 File Offset: 0x000435F4
		[CallerCount(0)]
		public unsafe WebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00045430 File Offset: 0x00043630
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00045494 File Offset: 0x00043694
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000454F0 File Offset: 0x000436F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000421 RID: 1057
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x00045554 File Offset: 0x00043754
		public unsafe virtual RequestCachePolicy CachePolicy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377875, XrefRangeEnd = 377876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000455A4 File Offset: 0x000437A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetCachePolicy(RequestCachePolicy policy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(policy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x000455E8 File Offset: 0x000437E8
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0004562C File Offset: 0x0004382C
		public unsafe virtual string Method
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377876, XrefRangeEnd = 377879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377879, XrefRangeEnd = 377882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0004567C File Offset: 0x0004387C
		public unsafe virtual Uri RequestUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377882, XrefRangeEnd = 377885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x000456C8 File Offset: 0x000438C8
		public unsafe virtual WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377885, XrefRangeEnd = 377888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00045714 File Offset: 0x00043914
		public unsafe virtual long ContentLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377888, XrefRangeEnd = 377891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0004575C File Offset: 0x0004395C
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x000457A8 File Offset: 0x000439A8
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377891, XrefRangeEnd = 377894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377894, XrefRangeEnd = 377897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x000457F8 File Offset: 0x000439F8
		public unsafe virtual bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377897, XrefRangeEnd = 377900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00045840 File Offset: 0x00043A40
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x0004588C File Offset: 0x00043A8C
		public unsafe virtual IWebProxy Proxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377900, XrefRangeEnd = 377903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377903, XrefRangeEnd = 377906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x000458DC File Offset: 0x00043ADC
		public unsafe virtual int Timeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377906, XrefRangeEnd = 377909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00045924 File Offset: 0x00043B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377909, XrefRangeEnd = 377912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebResponse GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00045970 File Offset: 0x00043B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377912, XrefRangeEnd = 377915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginGetResponse(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000459E0 File Offset: 0x00043BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377915, XrefRangeEnd = 377918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00045A3C File Offset: 0x00043C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377918, XrefRangeEnd = 377958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<WebResponse> GetResponseAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00045A88 File Offset: 0x00043C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377958, XrefRangeEnd = 377968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity SafeCaptureIdenity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr3) : null;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00045AC8 File Offset: 0x00043CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377968, XrefRangeEnd = 377971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Abort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebRequest.NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00045B04 File Offset: 0x00043D04
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00045B44 File Offset: 0x00043D44
		public unsafe RequestCacheProtocol CacheProtocol
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCacheProtocol>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00045B88 File Offset: 0x00043D88
		public unsafe static IWebProxy InternalDefaultWebProxy
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 377994, RefRangeEnd = 377998, XrefRangeStart = 377971, XrefRangeEnd = 377994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00045BBC File Offset: 0x00043DBC
		public unsafe static IWebProxy DefaultWebProxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377998, XrefRangeEnd = 378012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr_get_DefaultWebProxy_Public_Static_get_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00045BF0 File Offset: 0x00043DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378012, XrefRangeEnd = 378027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebResponse> _GetResponseAsync_b__79_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000076E4 File Offset: 0x000058E4
		public WebRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00045C30 File Offset: 0x00043E30
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x000076ED File Offset: 0x000058ED
		public unsafe static ArrayList s_PrefixList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_PrefixList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_PrefixList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00045C58 File Offset: 0x00043E58
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x000076FF File Offset: 0x000058FF
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00045C80 File Offset: 0x00043E80
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00007711 File Offset: 0x00005911
		public unsafe static TimerThread.Queue s_DefaultTimerQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultTimerQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00045CA8 File Offset: 0x00043EA8
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00007723 File Offset: 0x00005923
		public unsafe AuthenticationLevel m_AuthenticationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_AuthenticationLevel)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00045CD0 File Offset: 0x00043ED0
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0000773E File Offset: 0x0000593E
		public unsafe TokenImpersonationLevel m_ImpersonationLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_ImpersonationLevel)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00045CF8 File Offset: 0x00043EF8
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00007759 File Offset: 0x00005959
		public unsafe RequestCachePolicy m_CachePolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CachePolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00045D28 File Offset: 0x00043F28
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x00007778 File Offset: 0x00005978
		public unsafe RequestCacheProtocol m_CacheProtocol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheProtocol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheProtocol>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheProtocol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00045D58 File Offset: 0x00043F58
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00007797 File Offset: 0x00005997
		public unsafe RequestCacheBinding m_CacheBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.NativeFieldInfoPtr_m_CacheBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00045D88 File Offset: 0x00043F88
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x000077B6 File Offset: 0x000059B6
		public unsafe static WebRequest.DesignerWebRequestCreate webRequestCreate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_webRequestCreate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest.DesignerWebRequestCreate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_webRequestCreate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00045DB0 File Offset: 0x00043FB0
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x000077C8 File Offset: 0x000059C8
		public unsafe static IWebProxy s_DefaultWebProxy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00045DD8 File Offset: 0x00043FD8
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x000077DA File Offset: 0x000059DA
		public unsafe static bool s_DefaultWebProxyInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequest.NativeFieldInfoPtr_s_DefaultWebProxyInitialized, (void*)(&value));
			}
		}

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_s_PrefixList;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTimerQueue;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeFieldInfoPtr_m_AuthenticationLevel;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeFieldInfoPtr_m_ImpersonationLevel;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeFieldInfoPtr_m_CachePolicy;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheProtocol;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheBinding;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeFieldInfoPtr_webRequestCreate;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultWebProxy;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultWebProxyInitialized;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_WebRequest_Uri_Boolean_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WebRequest_String_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WebRequest_Uri_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefixList_Internal_Static_get_ArrayList_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_PopulatePrefixList_Private_Static_ArrayList_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_set_CachePolicy_Public_Virtual_New_set_Void_RequestCachePolicy_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetCachePolicy_Private_Void_RequestCachePolicy_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_Virtual_New_get_String_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestUri_Public_Virtual_New_get_Uri_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_New_get_WebHeaderCollection_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentLength_Public_Virtual_New_get_Int64_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_New_get_ICredentials_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_set_Credentials_Public_Virtual_New_set_Void_ICredentials_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_get_Proxy_Public_Virtual_New_get_IWebProxy_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_set_Proxy_Public_Virtual_New_set_Void_IWebProxy_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_New_WebResponse_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_BeginGetResponse_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_EndGetResponse_Public_Virtual_New_WebResponse_IAsyncResult_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseAsync_Public_Virtual_New_Task_1_WebResponse_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_SafeCaptureIdenity_Private_WindowsIdentity_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_New_Void_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_get_CacheProtocol_Internal_get_RequestCacheProtocol_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_set_CacheProtocol_Internal_set_Void_RequestCacheProtocol_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDefaultWebProxy_Internal_Static_get_IWebProxy_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultWebProxy_Public_Static_get_IWebProxy_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr__GetResponseAsync_b__79_0_Private_Task_1_WebResponse_0;

		// Token: 0x020001CF RID: 463
		public class DesignerWebRequestCreate : Object
		{
			// Token: 0x060019D7 RID: 6615 RVA: 0x0006EC90 File Offset: 0x0006CE90
			// Note: this type is marked as 'beforefieldinit'.
			static DesignerWebRequestCreate()
			{
				Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "DesignerWebRequestCreate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr);
				WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr, 100665332);
				WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr, 100665333);
			}

			// Token: 0x060019D8 RID: 6616 RVA: 0x0006ECE4 File Offset: 0x0006CEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377686, XrefRangeEnd = 377704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual WebRequest Create(Uri uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
				}
			}

			// Token: 0x060019D9 RID: 6617 RVA: 0x0006ED34 File Offset: 0x0006CF34
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DesignerWebRequestCreate()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest.DesignerWebRequestCreate>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.DesignerWebRequestCreate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019DA RID: 6618 RVA: 0x0000D430 File Offset: 0x0000B630
			public DesignerWebRequestCreate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001464 RID: 5220
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;

			// Token: 0x04001465 RID: 5221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001D0 RID: 464
		public class WebProxyWrapperOpaque : Object
		{
			// Token: 0x060019DB RID: 6619 RVA: 0x0006ED70 File Offset: 0x0006CF70
			// Note: this type is marked as 'beforefieldinit'.
			static WebProxyWrapperOpaque()
			{
				Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "WebProxyWrapperOpaque");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr);
				WebRequest.WebProxyWrapperOpaque.NativeFieldInfoPtr_webProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, "webProxy");
				WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, 100665334);
				WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, 100665335);
				WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapperOpaque>.NativeClassPtr, 100665336);
			}

			// Token: 0x060019DC RID: 6620 RVA: 0x0006EDEC File Offset: 0x0006CFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377704, XrefRangeEnd = 377706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Uri GetProxy(Uri destination)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x060019DD RID: 6621 RVA: 0x0006EE3C File Offset: 0x0006D03C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377706, XrefRangeEnd = 377718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool IsBypassed(Uri host)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x060019DE RID: 6622 RVA: 0x0006EE8C File Offset: 0x0006D08C
			public unsafe virtual ICredentials Credentials
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapperOpaque.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
				}
			}

			// Token: 0x060019DF RID: 6623 RVA: 0x0000D439 File Offset: 0x0000B639
			public WebProxyWrapperOpaque(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0006EECC File Offset: 0x0006D0CC
			// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000D442 File Offset: 0x0000B642
			public unsafe WebProxy webProxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.WebProxyWrapperOpaque.NativeFieldInfoPtr_webProxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebProxy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.WebProxyWrapperOpaque.NativeFieldInfoPtr_webProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001466 RID: 5222
			private static readonly IntPtr NativeFieldInfoPtr_webProxy;

			// Token: 0x04001467 RID: 5223
			private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

			// Token: 0x04001468 RID: 5224
			private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;

			// Token: 0x04001469 RID: 5225
			private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;
		}

		// Token: 0x020001D1 RID: 465
		public class WebProxyWrapper : WebRequest.WebProxyWrapperOpaque
		{
			// Token: 0x060019E2 RID: 6626 RVA: 0x0000D461 File Offset: 0x0000B661
			// Note: this type is marked as 'beforefieldinit'.
			static WebProxyWrapper()
			{
				Il2CppClassPointerStore<WebRequest.WebProxyWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "WebProxyWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.WebProxyWrapper>.NativeClassPtr);
				WebRequest.WebProxyWrapper.NativeMethodInfoPtr_get_WebProxy_Internal_get_WebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.WebProxyWrapper>.NativeClassPtr, 100665337);
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0006EEFC File Offset: 0x0006D0FC
			public unsafe WebProxy WebProxy
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.WebProxyWrapper.NativeMethodInfoPtr_get_WebProxy_Internal_get_WebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebProxy>(intPtr3) : null;
				}
			}

			// Token: 0x060019E4 RID: 6628 RVA: 0x0000D495 File Offset: 0x0000B695
			public WebProxyWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400146A RID: 5226
			private static readonly IntPtr NativeMethodInfoPtr_get_WebProxy_Internal_get_WebProxy_0;
		}

		// Token: 0x020001D2 RID: 466
		[ObfuscatedName("System.Net.WebRequest+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Object
		{
			// Token: 0x060019E5 RID: 6629 RVA: 0x0006EF3C File Offset: 0x0006D13C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebRequest>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr);
				WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, "currentUser");
				WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, 100665338);
				WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr, 100665339);
			}

			// Token: 0x060019E6 RID: 6630 RVA: 0x0006EFB8 File Offset: 0x0006D1B8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequest.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019E7 RID: 6631 RVA: 0x0006EFF4 File Offset: 0x0006D1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377718, XrefRangeEnd = 377741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<WebResponse> _GetResponseAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequest.__c__DisplayClass79_0.NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebResponse>>(intPtr3) : null;
			}

			// Token: 0x060019E8 RID: 6632 RVA: 0x0000D49E File Offset: 0x0000B69E
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0006F034 File Offset: 0x0006D234
			// (set) Token: 0x060019EA RID: 6634 RVA: 0x0000D4A7 File Offset: 0x0000B6A7
			public unsafe WindowsIdentity currentUser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr_currentUser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x060019EB RID: 6635 RVA: 0x0006F064 File Offset: 0x0006D264
			// (set) Token: 0x060019EC RID: 6636 RVA: 0x0000D4C6 File Offset: 0x0000B6C6
			public unsafe WebRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebRequest.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400146B RID: 5227
			private static readonly IntPtr NativeFieldInfoPtr_currentUser;

			// Token: 0x0400146C RID: 5228
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400146D RID: 5229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400146E RID: 5230
			private static readonly IntPtr NativeMethodInfoPtr__GetResponseAsync_b__1_Internal_Task_1_WebResponse_0;
		}
	}
}
