using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Il2CppSystem.Threading;

namespace Il2CppMono.Net
{
	// Token: 0x02000018 RID: 24
	public static class CFNetwork : Object
	{
		// Token: 0x06000103 RID: 259 RVA: 0x000143A0 File Offset: 0x000125A0
		// Note: this type is marked as 'beforefieldinit'.
		static CFNetwork()
		{
			Il2CppClassPointerStore<CFNetwork>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFNetwork");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr);
			CFNetwork.NativeFieldInfoPtr_lock_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "lock_obj");
			CFNetwork.NativeFieldInfoPtr_get_proxy_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "get_proxy_queue");
			CFNetwork.NativeFieldInfoPtr_proxy_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "proxy_event");
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptSequential_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663564);
			CFNetwork.NativeMethodInfoPtr_CFNetworkExecuteProxyAutoConfigurationURL_Private_Static_IntPtr_IntPtr_IntPtr_CFProxyAutoConfigurationResultCallback_byref_CFStreamClientContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663565);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptThread_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663566);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScript_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663567);
			CFNetwork.NativeMethodInfoPtr_CopyProxiesForAutoConfigurationScript_Private_Static_CFArray_IntPtr_CFUrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663568);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_CFUrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663569);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663570);
			CFNetwork.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663571);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForURL_Private_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663572);
			CFNetwork.NativeMethodInfoPtr_CopyProxiesForURL_Private_Static_CFArray_CFUrl_CFDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663573);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForURL_Public_Static_Il2CppReferenceArray_1_CFProxy_CFUrl_CFProxySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663574);
			CFNetwork.NativeMethodInfoPtr_GetProxiesForUri_Public_Static_Il2CppReferenceArray_1_CFProxy_Uri_CFProxySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663575);
			CFNetwork.NativeMethodInfoPtr_CFNetworkCopySystemProxySettings_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663576);
			CFNetwork.NativeMethodInfoPtr_GetSystemProxySettings_Public_Static_CFProxySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663577);
			CFNetwork.NativeMethodInfoPtr_GetDefaultProxy_Public_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, 100663578);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00014538 File Offset: 0x00012738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365368, RefRangeEnd = 365369, XrefRangeStart = 365366, XrefRangeEnd = 365368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetURL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptSequential_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00014594 File Offset: 0x00012794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365369, XrefRangeEnd = 365371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigURL;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetURL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clientContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkExecuteProxyAutoConfigurationURL_Private_Static_IntPtr_IntPtr_IntPtr_CFProxyAutoConfigurationResultCallback_byref_CFStreamClientContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00014600 File Offset: 0x00012800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365371, XrefRangeEnd = 365435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CFNetworkCopyProxiesForAutoConfigurationScriptThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptThread_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00014628 File Offset: 0x00012828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365490, RefRangeEnd = 365492, XrefRangeStart = 365435, XrefRangeEnd = 365490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetURL;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScript_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00014684 File Offset: 0x00012884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365492, XrefRangeEnd = 365500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CopyProxiesForAutoConfigurationScript_Private_Static_CFArray_IntPtr_CFUrl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFArray>(intPtr3) : null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000146D8 File Offset: 0x000128D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365532, RefRangeEnd = 365534, XrefRangeStart = 365500, XrefRangeEnd = 365532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_CFUrl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001472C File Offset: 0x0001292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365534, XrefRangeEnd = 365545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigurationScript;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00014780 File Offset: 0x00012980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365576, RefRangeEnd = 365577, XrefRangeStart = 365545, XrefRangeEnd = 365576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxyAutoConfigURL;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000147D4 File Offset: 0x000129D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365577, XrefRangeEnd = 365579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref url;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proxySettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopyProxiesForURL_Private_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00014820 File Offset: 0x00012A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365579, XrefRangeEnd = 365589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxySettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CopyProxiesForURL_Private_Static_CFArray_CFUrl_CFDictionary_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFArray>(intPtr3) : null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00014878 File Offset: 0x00012A78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365626, RefRangeEnd = 365628, XrefRangeStart = 365589, XrefRangeEnd = 365626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForURL(CFUrl url, CFProxySettings proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxySettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForURL_Public_Static_Il2CppReferenceArray_1_CFProxy_CFUrl_CFProxySettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000148D0 File Offset: 0x00012AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365628, XrefRangeEnd = 365638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CFProxy> GetProxiesForUri(Uri uri, CFProxySettings proxySettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxySettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetProxiesForUri_Public_Static_Il2CppReferenceArray_1_CFProxy_Uri_CFProxySettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr3) : null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00014928 File Offset: 0x00012B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365638, XrefRangeEnd = 365640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFNetworkCopySystemProxySettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_CFNetworkCopySystemProxySettings_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00014958 File Offset: 0x00012B58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365652, RefRangeEnd = 365654, XrefRangeStart = 365640, XrefRangeEnd = 365652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFProxySettings GetSystemProxySettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetSystemProxySettings_Public_Static_CFProxySettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFProxySettings>(intPtr3) : null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001498C File Offset: 0x00012B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365654, XrefRangeEnd = 365662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetDefaultProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.NativeMethodInfoPtr_GetDefaultProxy_Public_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000259E File Offset: 0x0000079E
		public CFNetwork(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000149C0 File Offset: 0x00012BC0
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000025A7 File Offset: 0x000007A7
		public unsafe static Object lock_obj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFNetwork.NativeFieldInfoPtr_lock_obj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFNetwork.NativeFieldInfoPtr_lock_obj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000149E8 File Offset: 0x00012BE8
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000025B9 File Offset: 0x000007B9
		public unsafe static Queue<CFNetwork.GetProxyData> get_proxy_queue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFNetwork.NativeFieldInfoPtr_get_proxy_queue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<CFNetwork.GetProxyData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFNetwork.NativeFieldInfoPtr_get_proxy_queue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00014A10 File Offset: 0x00012C10
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000025CB File Offset: 0x000007CB
		public unsafe static AutoResetEvent proxy_event
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFNetwork.NativeFieldInfoPtr_proxy_event, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFNetwork.NativeFieldInfoPtr_proxy_event, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_lock_obj;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_get_proxy_queue;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_proxy_event;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptSequential_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkExecuteProxyAutoConfigurationURL_Private_Static_IntPtr_IntPtr_IntPtr_CFProxyAutoConfigurationResultCallback_byref_CFStreamClientContext_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScriptThread_Private_Static_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForAutoConfigurationScript_Private_Static_IntPtr_IntPtr_IntPtr_byref_IntPtr_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_CopyProxiesForAutoConfigurationScript_Private_Static_CFArray_IntPtr_CFUrl_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_CFUrl_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForAutoConfigurationScript_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Public_Static_Il2CppReferenceArray_1_CFProxy_IntPtr_Uri_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopyProxiesForURL_Private_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_CopyProxiesForURL_Private_Static_CFArray_CFUrl_CFDictionary_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForURL_Public_Static_Il2CppReferenceArray_1_CFProxy_CFUrl_CFProxySettings_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiesForUri_Public_Static_Il2CppReferenceArray_1_CFProxy_Uri_CFProxySettings_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_CFNetworkCopySystemProxySettings_Private_Static_IntPtr_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemProxySettings_Public_Static_CFProxySettings_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProxy_Public_Static_IWebProxy_0;

		// Token: 0x0200019F RID: 415
		public class GetProxyData : Object
		{
			// Token: 0x060017F3 RID: 6131 RVA: 0x000693D4 File Offset: 0x000675D4
			// Note: this type is marked as 'beforefieldinit'.
			static GetProxyData()
			{
				Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "GetProxyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr);
				CFNetwork.GetProxyData.NativeFieldInfoPtr_script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "script");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_targetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "targetUri");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "error");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "result");
				CFNetwork.GetProxyData.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, "evt");
				CFNetwork.GetProxyData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, 100663580);
				CFNetwork.GetProxyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr, 100663581);
			}

			// Token: 0x060017F4 RID: 6132 RVA: 0x0006948C File Offset: 0x0006768C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365166, XrefRangeEnd = 365167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.GetProxyData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017F5 RID: 6133 RVA: 0x000694C0 File Offset: 0x000676C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365167, XrefRangeEnd = 365171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetProxyData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.GetProxyData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.GetProxyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017F6 RID: 6134 RVA: 0x0000C175 File Offset: 0x0000A375
			public GetProxyData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000694FC File Offset: 0x000676FC
			// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000C17E File Offset: 0x0000A37E
			public unsafe IntPtr script
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_script);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_script)) = value;
				}
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00069524 File Offset: 0x00067724
			// (set) Token: 0x060017FA RID: 6138 RVA: 0x0000C199 File Offset: 0x0000A399
			public unsafe IntPtr targetUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_targetUri);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_targetUri)) = value;
				}
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x060017FB RID: 6139 RVA: 0x0006954C File Offset: 0x0006774C
			// (set) Token: 0x060017FC RID: 6140 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
			public unsafe IntPtr error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_error);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_error)) = value;
				}
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x060017FD RID: 6141 RVA: 0x00069574 File Offset: 0x00067774
			// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000C1CF File Offset: 0x0000A3CF
			public unsafe IntPtr result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x060017FF RID: 6143 RVA: 0x0006959C File Offset: 0x0006779C
			// (set) Token: 0x06001800 RID: 6144 RVA: 0x0000C1EA File Offset: 0x0000A3EA
			public unsafe ManualResetEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.GetProxyData.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012FE RID: 4862
			private static readonly IntPtr NativeFieldInfoPtr_script;

			// Token: 0x040012FF RID: 4863
			private static readonly IntPtr NativeFieldInfoPtr_targetUri;

			// Token: 0x04001300 RID: 4864
			private static readonly IntPtr NativeFieldInfoPtr_error;

			// Token: 0x04001301 RID: 4865
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04001302 RID: 4866
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04001303 RID: 4867
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04001304 RID: 4868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A0 RID: 416
		public sealed class CFProxyAutoConfigurationResultCallback : MulticastDelegate
		{
			// Token: 0x06001801 RID: 6145 RVA: 0x000695CC File Offset: 0x000677CC
			// Note: this type is marked as 'beforefieldinit'.
			static CFProxyAutoConfigurationResultCallback()
			{
				Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "CFProxyAutoConfigurationResultCallback");
				CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr, 100663582);
				CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr, 100663583);
				CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr, 100663584);
				CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr, 100663585);
			}

			// Token: 0x06001802 RID: 6146 RVA: 0x00069640 File Offset: 0x00067840
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CFProxyAutoConfigurationResultCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.CFProxyAutoConfigurationResultCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001803 RID: 6147 RVA: 0x0006969C File Offset: 0x0006789C
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr client, IntPtr proxyList, IntPtr error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref client;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proxyList;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001804 RID: 6148 RVA: 0x000696F8 File Offset: 0x000678F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365171, XrefRangeEnd = 365179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref client;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proxyList;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001805 RID: 6149 RVA: 0x00069788 File Offset: 0x00067988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFProxyAutoConfigurationResultCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001806 RID: 6150 RVA: 0x0000C209 File Offset: 0x0000A409
			public CFProxyAutoConfigurationResultCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001807 RID: 6151 RVA: 0x0000C212 File Offset: 0x0000A412
			public static implicit operator CFNetwork.CFProxyAutoConfigurationResultCallback(Action<IntPtr, IntPtr, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<CFNetwork.CFProxyAutoConfigurationResultCallback>(A_0);
			}

			// Token: 0x06001808 RID: 6152 RVA: 0x0000C21A File Offset: 0x0000A41A
			public static CFNetwork.CFProxyAutoConfigurationResultCallback operator +(CFNetwork.CFProxyAutoConfigurationResultCallback A_0, CFNetwork.CFProxyAutoConfigurationResultCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CFNetwork.CFProxyAutoConfigurationResultCallback>();
			}

			// Token: 0x06001809 RID: 6153 RVA: 0x0000C228 File Offset: 0x0000A428
			public static CFNetwork.CFProxyAutoConfigurationResultCallback operator -(CFNetwork.CFProxyAutoConfigurationResultCallback A_0, CFNetwork.CFProxyAutoConfigurationResultCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CFNetwork.CFProxyAutoConfigurationResultCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001305 RID: 4869
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001306 RID: 4870
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0;

			// Token: 0x04001307 RID: 4871
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001308 RID: 4872
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020001A1 RID: 417
		public class CFWebProxy : Object
		{
			// Token: 0x0600180A RID: 6154 RVA: 0x000697CC File Offset: 0x000679CC
			// Note: this type is marked as 'beforefieldinit'.
			static CFWebProxy()
			{
				Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "CFWebProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr);
				CFNetwork.CFWebProxy.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, "credentials");
				CFNetwork.CFWebProxy.NativeFieldInfoPtr_userSpecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, "userSpecified");
				CFNetwork.CFWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663586);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663587);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUri_Private_Static_Uri_CFProxy_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663588);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUriFromScript_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663589);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663590);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_SelectProxy_Private_Static_Uri_Il2CppReferenceArray_1_CFProxy_Uri_byref_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663591);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663592);
				CFNetwork.CFWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr, 100663593);
			}

			// Token: 0x0600180B RID: 6155 RVA: 0x000698C0 File Offset: 0x00067AC0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CFWebProxy()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.CFWebProxy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x0600180C RID: 6156 RVA: 0x000698FC File Offset: 0x00067AFC
			public unsafe virtual ICredentials Credentials
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
				}
			}

			// Token: 0x0600180D RID: 6157 RVA: 0x0006993C File Offset: 0x00067B3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 365250, RefRangeEnd = 365251, XrefRangeStart = 365179, XrefRangeEnd = 365250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUri_Private_Static_Uri_CFProxy_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x0600180E RID: 6158 RVA: 0x000699A4 File Offset: 0x00067BA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 365279, RefRangeEnd = 365280, XrefRangeStart = 365251, XrefRangeEnd = 365279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref script;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxyUriFromScript_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x0600180F RID: 6159 RVA: 0x00069A1C File Offset: 0x00067C1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 365285, RefRangeEnd = 365286, XrefRangeStart = 365280, XrefRangeEnd = 365285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref proxyAutoConfigURL;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x06001810 RID: 6160 RVA: 0x00069A94 File Offset: 0x00067C94
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 365289, RefRangeEnd = 365291, XrefRangeStart = 365286, XrefRangeEnd = 365289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Uri SelectProxy(Il2CppReferenceArray<CFProxy> proxies, Uri targetUri, out NetworkCredential credentials)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxies);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_SelectProxy_Private_Static_Uri_Il2CppReferenceArray_1_CFProxy_Uri_byref_NetworkCredential_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				credentials = ((intPtr4 == 0) ? null : new NetworkCredential(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
			}

			// Token: 0x06001811 RID: 6161 RVA: 0x00069B10 File Offset: 0x00067D10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 365324, RefRangeEnd = 365325, XrefRangeStart = 365291, XrefRangeEnd = 365324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Uri GetProxy(Uri targetUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x06001812 RID: 6162 RVA: 0x00069B60 File Offset: 0x00067D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365325, XrefRangeEnd = 365331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool IsBypassed(Uri targetUri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.CFWebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x0000C239 File Offset: 0x0000A439
			public CFWebProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06001814 RID: 6164 RVA: 0x00069BB0 File Offset: 0x00067DB0
			// (set) Token: 0x06001815 RID: 6165 RVA: 0x0000C242 File Offset: 0x0000A442
			public unsafe ICredentials credentials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_credentials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06001816 RID: 6166 RVA: 0x00069BE0 File Offset: 0x00067DE0
			// (set) Token: 0x06001817 RID: 6167 RVA: 0x0000C261 File Offset: 0x0000A461
			public unsafe bool userSpecified
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_userSpecified);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.CFWebProxy.NativeFieldInfoPtr_userSpecified)) = value;
				}
			}

			// Token: 0x04001309 RID: 4873
			private static readonly IntPtr NativeFieldInfoPtr_credentials;

			// Token: 0x0400130A RID: 4874
			private static readonly IntPtr NativeFieldInfoPtr_userSpecified;

			// Token: 0x0400130B RID: 4875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400130C RID: 4876
			private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;

			// Token: 0x0400130D RID: 4877
			private static readonly IntPtr NativeMethodInfoPtr_GetProxyUri_Private_Static_Uri_CFProxy_byref_NetworkCredential_0;

			// Token: 0x0400130E RID: 4878
			private static readonly IntPtr NativeMethodInfoPtr_GetProxyUriFromScript_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0;

			// Token: 0x0400130F RID: 4879
			private static readonly IntPtr NativeMethodInfoPtr_ExecuteProxyAutoConfigurationURL_Private_Static_Uri_IntPtr_Uri_byref_NetworkCredential_0;

			// Token: 0x04001310 RID: 4880
			private static readonly IntPtr NativeMethodInfoPtr_SelectProxy_Private_Static_Uri_Il2CppReferenceArray_1_CFProxy_Uri_byref_NetworkCredential_0;

			// Token: 0x04001311 RID: 4881
			private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

			// Token: 0x04001312 RID: 4882
			private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;
		}

		// Token: 0x020001A2 RID: 418
		[ObfuscatedName("Mono.Net.CFNetwork+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06001818 RID: 6168 RVA: 0x00069C08 File Offset: 0x00067E08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CFNetwork>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr);
				CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_proxies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, "proxies");
				CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_runLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, "runLoop");
				CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, 100663594);
				CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ExecuteProxyAutoConfigurationURL_b__0_Internal_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr, 100663595);
			}

			// Token: 0x06001819 RID: 6169 RVA: 0x00069C84 File Offset: 0x00067E84
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFNetwork.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600181A RID: 6170 RVA: 0x00069CC0 File Offset: 0x00067EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365331, XrefRangeEnd = 365366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteProxyAutoConfigurationURL_b__0(IntPtr client, IntPtr proxyList, IntPtr error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref client;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proxyList;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNetwork.__c__DisplayClass13_0.NativeMethodInfoPtr__ExecuteProxyAutoConfigurationURL_b__0_Internal_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600181B RID: 6171 RVA: 0x0000C27C File Offset: 0x0000A47C
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x0600181C RID: 6172 RVA: 0x00069D1C File Offset: 0x00067F1C
			// (set) Token: 0x0600181D RID: 6173 RVA: 0x0000C285 File Offset: 0x0000A485
			public unsafe Il2CppReferenceArray<CFProxy> proxies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_proxies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CFProxy>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_proxies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x0600181E RID: 6174 RVA: 0x00069D4C File Offset: 0x00067F4C
			// (set) Token: 0x0600181F RID: 6175 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
			public unsafe CFRunLoop runLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_runLoop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CFRunLoop>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CFNetwork.__c__DisplayClass13_0.NativeFieldInfoPtr_runLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001313 RID: 4883
			private static readonly IntPtr NativeFieldInfoPtr_proxies;

			// Token: 0x04001314 RID: 4884
			private static readonly IntPtr NativeFieldInfoPtr_runLoop;

			// Token: 0x04001315 RID: 4885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001316 RID: 4886
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteProxyAutoConfigurationURL_b__0_Internal_Void_IntPtr_IntPtr_IntPtr_0;
		}
	}
}
