using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x02000136 RID: 310
	public class ServicePoint : Object
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x00056780 File Offset: 0x00054980
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePoint()
		{
			Il2CppClassPointerStore<ServicePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr);
			ServicePoint.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "uri");
			ServicePoint.NativeFieldInfoPtr_lastDnsResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "lastDnsResolve");
			ServicePoint.NativeFieldInfoPtr_protocolVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "protocolVersion");
			ServicePoint.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "host");
			ServicePoint.NativeFieldInfoPtr_usesProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "usesProxy");
			ServicePoint.NativeFieldInfoPtr_sendContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "sendContinue");
			ServicePoint.NativeFieldInfoPtr_useConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "useConnect");
			ServicePoint.NativeFieldInfoPtr_hostE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "hostE");
			ServicePoint.NativeFieldInfoPtr_useNagle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "useNagle");
			ServicePoint.NativeFieldInfoPtr_endPointCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "endPointCallback");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive_time");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive_interval");
			ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "<Scheduler>k__BackingField");
			ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "m_ServerCertificateOrBytes");
			ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "m_ClientCertificateOrBytes");
			ServicePoint.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665925);
			ServicePoint.NativeMethodInfoPtr_get_Scheduler_Internal_get_ServicePointScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665926);
			ServicePoint.NativeMethodInfoPtr_get_Address_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665927);
			ServicePoint.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665928);
			ServicePoint.NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665929);
			ServicePoint.NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665930);
			ServicePoint.NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665931);
			ServicePoint.NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665932);
			ServicePoint.NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665933);
			ServicePoint.NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665934);
			ServicePoint.NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665935);
			ServicePoint.NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665936);
			ServicePoint.NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665937);
			ServicePoint.NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665938);
			ServicePoint.NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665939);
			ServicePoint.NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665940);
			ServicePoint.NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665941);
			ServicePoint.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665942);
			ServicePoint.NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665943);
			ServicePoint.NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665944);
			ServicePoint.NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665945);
			ServicePoint.NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665946);
			ServicePoint.NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665947);
			ServicePoint.NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665948);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00056AD0 File Offset: 0x00054CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383613, XrefRangeEnd = 383620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint(Uri uri, int connectionLimit, int maxIdleTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionLimit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIdleTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00056B38 File Offset: 0x00054D38
		public unsafe ServicePointScheduler Scheduler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_Scheduler_Internal_get_ServicePointScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00056B78 File Offset: 0x00054D78
		public unsafe Uri Address
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_Address_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00056BB8 File Offset: 0x00054DB8
		public unsafe int ConnectionLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00056BF4 File Offset: 0x00054DF4
		public unsafe virtual Version ProtocolVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePoint.NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x00056C40 File Offset: 0x00054E40
		public unsafe bool Expect100Continue
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00056C80 File Offset: 0x00054E80
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x00056CBC File Offset: 0x00054EBC
		public unsafe bool UseNagleAlgorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00056CFC File Offset: 0x00054EFC
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x00056D38 File Offset: 0x00054F38
		public unsafe bool SendContinue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 383622, RefRangeEnd = 383623, XrefRangeStart = 383620, XrefRangeEnd = 383622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00056D78 File Offset: 0x00054F78
		[CallerCount(0)]
		public unsafe void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveInterval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00056DD4 File Offset: 0x00054FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383623, XrefRangeEnd = 383633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeepAliveSetup(Socket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00056E18 File Offset: 0x00055018
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 383637, RefRangeEnd = 383640, XrefRangeStart = 383633, XrefRangeEnd = 383637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutBytes(Il2CppStructArray<byte> bytes, uint v, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00056E6C File Offset: 0x0005506C
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x00056EA8 File Offset: 0x000550A8
		public unsafe bool UsesProxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00056EE8 File Offset: 0x000550E8
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x00056F24 File Offset: 0x00055124
		public unsafe bool UseConnect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00056F64 File Offset: 0x00055164
		public unsafe bool HasTimedOut
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383640, XrefRangeEnd = 383650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x00056FA0 File Offset: 0x000551A0
		public unsafe IPHostEntry HostEntry
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 383709, RefRangeEnd = 383712, XrefRangeStart = 383650, XrefRangeEnd = 383709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00056FE0 File Offset: 0x000551E0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVersion(Version version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00057024 File Offset: 0x00055224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383716, RefRangeEnd = 383717, XrefRangeStart = 383712, XrefRangeEnd = 383716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequest(WebOperation operation, string groupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00057078 File Offset: 0x00055278
		[CallerCount(0)]
		public unsafe void UpdateServerCertificate(X509Certificate certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000570BC File Offset: 0x000552BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383717, RefRangeEnd = 383718, XrefRangeStart = 383717, XrefRangeEnd = 383717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClientCertificate(X509Certificate certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00057100 File Offset: 0x00055300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383722, RefRangeEnd = 383723, XrefRangeStart = 383718, XrefRangeEnd = 383722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sock);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remote);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000098B9 File Offset: 0x00007AB9
		public ServicePoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00057160 File Offset: 0x00055360
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x000098C2 File Offset: 0x00007AC2
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00057190 File Offset: 0x00055390
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x000098E1 File Offset: 0x00007AE1
		public unsafe DateTime lastDnsResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_lastDnsResolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_lastDnsResolve)) = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x000571B8 File Offset: 0x000553B8
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x000098FC File Offset: 0x00007AFC
		public unsafe Version protocolVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_protocolVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_protocolVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x000571E8 File Offset: 0x000553E8
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0000991B File Offset: 0x00007B1B
		public unsafe IPHostEntry host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_host);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_host), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00057218 File Offset: 0x00055418
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0000993A File Offset: 0x00007B3A
		public unsafe bool usesProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_usesProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_usesProxy)) = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00057240 File Offset: 0x00055440
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x00009955 File Offset: 0x00007B55
		public unsafe bool sendContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_sendContinue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_sendContinue)) = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00057268 File Offset: 0x00055468
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x00009970 File Offset: 0x00007B70
		public unsafe bool useConnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useConnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useConnect)) = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00057290 File Offset: 0x00055490
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x0000998B File Offset: 0x00007B8B
		public unsafe Object hostE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_hostE);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_hostE), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000572C0 File Offset: 0x000554C0
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x000099AA File Offset: 0x00007BAA
		public unsafe bool useNagle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useNagle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useNagle)) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x000572E8 File Offset: 0x000554E8
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x000099C5 File Offset: 0x00007BC5
		public unsafe BindIPEndPoint endPointCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_endPointCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindIPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_endPointCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00057318 File Offset: 0x00055518
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x000099E4 File Offset: 0x00007BE4
		public unsafe bool tcp_keepalive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive)) = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00057340 File Offset: 0x00055540
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x000099FF File Offset: 0x00007BFF
		public unsafe int tcp_keepalive_time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time)) = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00057368 File Offset: 0x00055568
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x00009A1A File Offset: 0x00007C1A
		public unsafe int tcp_keepalive_interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval)) = value;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00057390 File Offset: 0x00055590
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00009A35 File Offset: 0x00007C35
		public unsafe ServicePointScheduler _Scheduler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x000573C0 File Offset: 0x000555C0
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00009A54 File Offset: 0x00007C54
		public unsafe Object m_ServerCertificateOrBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x000573F0 File Offset: 0x000555F0
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00009A73 File Offset: 0x00007C73
		public unsafe Object m_ClientCertificateOrBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_lastDnsResolve;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeFieldInfoPtr_protocolVersion;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeFieldInfoPtr_host;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeFieldInfoPtr_usesProxy;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_sendContinue;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeFieldInfoPtr_useConnect;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_hostE;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_useNagle;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_endPointCallback;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_time;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_interval;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeFieldInfoPtr__Scheduler_k__BackingField;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerCertificateOrBytes;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeFieldInfoPtr_m_ClientCertificateOrBytes;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_Int32_Int32_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheduler_Internal_get_ServicePointScheduler_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Uri_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0;
	}
}
