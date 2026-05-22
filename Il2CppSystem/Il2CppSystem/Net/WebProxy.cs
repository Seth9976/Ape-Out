using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011B RID: 283
	[Serializable]
	public class WebProxy : Object
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		// Note: this type is marked as 'beforefieldinit'.
		static WebProxy()
		{
			Il2CppClassPointerStore<WebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebProxy>.NativeClassPtr);
			WebProxy.NativeFieldInfoPtr__UseRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_UseRegistry");
			WebProxy.NativeFieldInfoPtr__BypassOnLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_BypassOnLocal");
			WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "m_EnableAutoproxy");
			WebProxy.NativeFieldInfoPtr__ProxyAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_ProxyAddress");
			WebProxy.NativeFieldInfoPtr__BypassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_BypassList");
			WebProxy.NativeFieldInfoPtr__Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_Credentials");
			WebProxy.NativeFieldInfoPtr__RegExBypassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_RegExBypassList");
			WebProxy.NativeFieldInfoPtr__ProxyHostAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_ProxyHostAddresses");
			WebProxy.NativeFieldInfoPtr_m_ScriptEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "m_ScriptEngine");
			WebProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665570);
			WebProxy.NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665571);
			WebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665572);
			WebProxy.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665573);
			WebProxy.NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665574);
			WebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665575);
			WebProxy.NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665576);
			WebProxy.NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665577);
			WebProxy.NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665578);
			WebProxy.NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665579);
			WebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665580);
			WebProxy.NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665581);
			WebProxy.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665582);
			WebProxy.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665583);
			WebProxy.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665584);
			WebProxy.NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665585);
			WebProxy.NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665586);
			WebProxy.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665587);
			WebProxy.NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665588);
			WebProxy.NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665589);
			WebProxy.NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665590);
			WebProxy.NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665591);
			WebProxy.NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665592);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0004C880 File Offset: 0x0004AA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379801, XrefRangeEnd = 379802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0004C8BC File Offset: 0x0004AABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379802, XrefRangeEnd = 379807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(Uri Address, bool BypassOnLocal, Il2CppStringArray BypassList, ICredentials Credentials)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref BypassOnLocal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(BypassList);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0004C93C File Offset: 0x0004AB3C
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0004C97C File Offset: 0x0004AB7C
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0004C9B8 File Offset: 0x0004ABB8
		public unsafe bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379807, XrefRangeEnd = 379809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379809, XrefRangeEnd = 379811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0004C9F8 File Offset: 0x0004ABF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379823, RefRangeEnd = 379824, XrefRangeStart = 379811, XrefRangeEnd = 379823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Uri GetProxy(Uri destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0004CA48 File Offset: 0x0004AC48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 379835, RefRangeEnd = 379837, XrefRangeStart = 379824, XrefRangeEnd = 379835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRegExList(bool canThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canThrow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0004CA88 File Offset: 0x0004AC88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379863, RefRangeEnd = 379864, XrefRangeStart = 379837, XrefRangeEnd = 379863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchInBypassList(Uri input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0004CAD8 File Offset: 0x0004ACD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 379879, RefRangeEnd = 379880, XrefRangeStart = 379864, XrefRangeEnd = 379879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocal(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0004CB28 File Offset: 0x0004AD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379880, XrefRangeEnd = 379886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalInProxyHash(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0004CB78 File Offset: 0x0004AD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379886, XrefRangeEnd = 379897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsBypassed(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 379908, RefRangeEnd = 379911, XrefRangeStart = 379897, XrefRangeEnd = 379908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBypassedManual(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0004CC18 File Offset: 0x0004AE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379911, XrefRangeEnd = 379944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0004CC7C File Offset: 0x0004AE7C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0004CCD8 File Offset: 0x0004AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379944, XrefRangeEnd = 379978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebProxy.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0004CD3C File Offset: 0x0004AF3C
		public unsafe AutoWebProxyScriptEngine ScriptEngine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoWebProxyScriptEngine>(intPtr3) : null;
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004CD7C File Offset: 0x0004AF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379978, XrefRangeEnd = 379982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy CreateDefaultProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		[CallerCount(0)]
		public unsafe WebProxy(bool enableAutoproxy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableAutoproxy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0004CDF8 File Offset: 0x0004AFF8
		[CallerCount(0)]
		public unsafe void UnsafeUpdateFromRegistry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0004CE2C File Offset: 0x0004B02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379982, XrefRangeEnd = 379984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetProxyAuto(Uri destination, out Uri proxyUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyUri = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004CE9C File Offset: 0x0004B09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379984, XrefRangeEnd = 379985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBypassedAuto(Uri destination, out bool isBypassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isBypassed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0004CEF8 File Offset: 0x0004B0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379985, XrefRangeEnd = 380000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxies);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFirstOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0004CF48 File Offset: 0x0004B148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380000, XrefRangeEnd = 380007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ProxyUri(string proxyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(proxyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0000848E File Offset: 0x0000668E
		public WebProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x0004CF8C File Offset: 0x0004B18C
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x00008497 File Offset: 0x00006697
		public unsafe bool _UseRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__UseRegistry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__UseRegistry)) = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0004CFB4 File Offset: 0x0004B1B4
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x000084B2 File Offset: 0x000066B2
		public unsafe bool _BypassOnLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassOnLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassOnLocal)) = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x0004CFDC File Offset: 0x0004B1DC
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x000084CD File Offset: 0x000066CD
		public unsafe bool m_EnableAutoproxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy)) = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x0004D004 File Offset: 0x0004B204
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x000084E8 File Offset: 0x000066E8
		public unsafe Uri _ProxyAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyAddress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyAddress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x0004D034 File Offset: 0x0004B234
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00008507 File Offset: 0x00006707
		public unsafe ArrayList _BypassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x0004D064 File Offset: 0x0004B264
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x00008526 File Offset: 0x00006726
		public unsafe ICredentials _Credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__Credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__Credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x0004D094 File Offset: 0x0004B294
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x00008545 File Offset: 0x00006745
		public unsafe Il2CppReferenceArray<Regex> _RegExBypassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__RegExBypassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Regex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__RegExBypassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x0004D0C4 File Offset: 0x0004B2C4
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x00008564 File Offset: 0x00006764
		public unsafe Hashtable _ProxyHostAddresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyHostAddresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyHostAddresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0004D0F4 File Offset: 0x0004B2F4
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x00008583 File Offset: 0x00006783
		public unsafe AutoWebProxyScriptEngine m_ScriptEngine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_ScriptEngine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoWebProxyScriptEngine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_ScriptEngine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr__UseRegistry;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr__BypassOnLocal;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableAutoproxy;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeFieldInfoPtr__ProxyAddress;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeFieldInfoPtr__BypassList;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr__Credentials;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeFieldInfoPtr__RegExBypassList;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr__ProxyHostAddresses;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr_m_ScriptEngine;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0;
	}
}
