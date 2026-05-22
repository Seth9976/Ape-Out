using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Specialized;

namespace Il2CppSystem.Net
{
	// Token: 0x02000137 RID: 311
	public class ServicePointManager : Object
	{
		// Token: 0x060012E1 RID: 4833 RVA: 0x00057420 File Offset: 0x00055620
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointManager()
		{
			Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePointManager");
			ServicePointManager.NativeFieldInfoPtr_servicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "servicePoints");
			ServicePointManager.NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "policy");
			ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "defaultConnectionLimit");
			ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePointIdleTime");
			ServicePointManager.NativeFieldInfoPtr_maxServicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePoints");
			ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "dnsRefreshTimeout");
			ServicePointManager.NativeFieldInfoPtr__checkCRL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_checkCRL");
			ServicePointManager.NativeFieldInfoPtr__securityProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_securityProtocol");
			ServicePointManager.NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "expectContinue");
			ServicePointManager.NativeFieldInfoPtr_useNagle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "useNagle");
			ServicePointManager.NativeFieldInfoPtr_server_cert_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "server_cert_cb");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_time");
			ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_interval");
			ServicePointManager.NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665950);
			ServicePointManager.NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665951);
			ServicePointManager.NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665952);
			ServicePointManager.NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665953);
			ServicePointManager.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665954);
			ServicePointManager.NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100665955);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000575D8 File Offset: 0x000557D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383738, XrefRangeEnd = 383742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICertificatePolicy GetLegacyCertificatePolicy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr3) : null;
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0005760C File Offset: 0x0005580C
		public unsafe static bool CheckCertificateRevocationList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383742, XrefRangeEnd = 383746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x0005763C File Offset: 0x0005583C
		public unsafe static int DnsRefreshTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383746, XrefRangeEnd = 383750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x0005766C File Offset: 0x0005586C
		public unsafe static SecurityProtocolType SecurityProtocol
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383750, XrefRangeEnd = 383754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0005769C File Offset: 0x0005589C
		public unsafe static ServerCertValidationCallback ServerCertValidationCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383754, XrefRangeEnd = 383758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000576D0 File Offset: 0x000558D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383847, RefRangeEnd = 383849, XrefRangeStart = 383758, XrefRangeEnd = 383847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00009A92 File Offset: 0x00007C92
		public ServicePointManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00057728 File Offset: 0x00055928
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x00009A9B File Offset: 0x00007C9B
		public unsafe static HybridDictionary servicePoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_servicePoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HybridDictionary>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_servicePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00057750 File Offset: 0x00055950
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x00009AAD File Offset: 0x00007CAD
		public unsafe static ICertificatePolicy policy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_policy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_policy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00057778 File Offset: 0x00055978
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x00009ABF File Offset: 0x00007CBF
		public unsafe static int defaultConnectionLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00057794 File Offset: 0x00055994
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00009ACD File Offset: 0x00007CCD
		public unsafe static int maxServicePointIdleTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x000577B0 File Offset: 0x000559B0
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00009ADB File Offset: 0x00007CDB
		public unsafe static int maxServicePoints
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_maxServicePoints, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_maxServicePoints, (void*)(&value));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000577CC File Offset: 0x000559CC
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00009AE9 File Offset: 0x00007CE9
		public unsafe static int dnsRefreshTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000577E8 File Offset: 0x000559E8
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00009AF7 File Offset: 0x00007CF7
		public unsafe static bool _checkCRL
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr__checkCRL, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr__checkCRL, (void*)(&value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00057804 File Offset: 0x00055A04
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00009B05 File Offset: 0x00007D05
		public unsafe static SecurityProtocolType _securityProtocol
		{
			get
			{
				SecurityProtocolType securityProtocolType;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr__securityProtocol, (void*)(&securityProtocolType));
				return securityProtocolType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr__securityProtocol, (void*)(&value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00057820 File Offset: 0x00055A20
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x00009B13 File Offset: 0x00007D13
		public unsafe static bool expectContinue
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_expectContinue, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_expectContinue, (void*)(&value));
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0005783C File Offset: 0x00055A3C
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00009B21 File Offset: 0x00007D21
		public unsafe static bool useNagle
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_useNagle, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_useNagle, (void*)(&value));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00057858 File Offset: 0x00055A58
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00009B2F File Offset: 0x00007D2F
		public unsafe static ServerCertValidationCallback server_cert_cb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_server_cert_cb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_server_cert_cb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00057880 File Offset: 0x00055A80
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00009B41 File Offset: 0x00007D41
		public unsafe static bool tcp_keepalive
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive, (void*)(&value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0005789C File Offset: 0x00055A9C
		// (set) Token: 0x06001302 RID: 4866 RVA: 0x00009B4F File Offset: 0x00007D4F
		public unsafe static int tcp_keepalive_time
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&value));
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x000578B8 File Offset: 0x00055AB8
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x00009B5D File Offset: 0x00007D5D
		public unsafe static int tcp_keepalive_interval
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServicePointManager.NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&value));
			}
		}

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeFieldInfoPtr_servicePoints;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeFieldInfoPtr_policy;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeFieldInfoPtr_defaultConnectionLimit;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeFieldInfoPtr_maxServicePointIdleTime;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeFieldInfoPtr_maxServicePoints;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeFieldInfoPtr_dnsRefreshTimeout;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeFieldInfoPtr__checkCRL;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr__securityProtocol;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr_expectContinue;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeFieldInfoPtr_useNagle;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr_server_cert_cb;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_time;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_interval;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0;

		// Token: 0x020001EF RID: 495
		public class SPKey : Object
		{
			// Token: 0x06001AFA RID: 6906 RVA: 0x00071D8C File Offset: 0x0006FF8C
			// Note: this type is marked as 'beforefieldinit'.
			static SPKey()
			{
				Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "SPKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr);
				ServicePointManager.SPKey.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "uri");
				ServicePointManager.SPKey.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "proxy");
				ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, "use_connect");
				ServicePointManager.SPKey.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665956);
				ServicePointManager.SPKey.NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665957);
				ServicePointManager.SPKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665958);
				ServicePointManager.SPKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr, 100665959);
			}

			// Token: 0x06001AFB RID: 6907 RVA: 0x00071E44 File Offset: 0x00070044
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 207526, RefRangeEnd = 207528, XrefRangeStart = 207526, XrefRangeEnd = 207528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SPKey(Uri uri, Uri proxy, bool use_connect)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointManager.SPKey>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref use_connect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.SPKey.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00071EB0 File Offset: 0x000700B0
			public unsafe bool UsesProxy
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 383726, RefRangeEnd = 383729, XrefRangeStart = 383723, XrefRangeEnd = 383726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManager.SPKey.NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AFD RID: 6909 RVA: 0x00071EEC File Offset: 0x000700EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383729, XrefRangeEnd = 383733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePointManager.SPKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001AFE RID: 6910 RVA: 0x00071F34 File Offset: 0x00070134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383733, XrefRangeEnd = 383738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePointManager.SPKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AFF RID: 6911 RVA: 0x0000E066 File Offset: 0x0000C266
			public SPKey(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00071F8C File Offset: 0x0007018C
			// (set) Token: 0x06001B01 RID: 6913 RVA: 0x0000E06F File Offset: 0x0000C26F
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06001B02 RID: 6914 RVA: 0x00071FBC File Offset: 0x000701BC
			// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0000E08E File Offset: 0x0000C28E
			public unsafe Uri proxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_proxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x06001B04 RID: 6916 RVA: 0x00071FEC File Offset: 0x000701EC
			// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0000E0AD File Offset: 0x0000C2AD
			public unsafe bool use_connect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePointManager.SPKey.NativeFieldInfoPtr_use_connect)) = value;
				}
			}

			// Token: 0x0400150E RID: 5390
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x0400150F RID: 5391
			private static readonly IntPtr NativeFieldInfoPtr_proxy;

			// Token: 0x04001510 RID: 5392
			private static readonly IntPtr NativeFieldInfoPtr_use_connect;

			// Token: 0x04001511 RID: 5393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0;

			// Token: 0x04001512 RID: 5394
			private static readonly IntPtr NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0;

			// Token: 0x04001513 RID: 5395
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04001514 RID: 5396
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
		}
	}
}
