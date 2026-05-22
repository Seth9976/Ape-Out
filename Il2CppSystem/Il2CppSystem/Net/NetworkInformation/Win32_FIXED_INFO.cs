using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200016A RID: 362
	public sealed class Win32_FIXED_INFO : ValueType
	{
		// Token: 0x060016B6 RID: 5814 RVA: 0x000661E0 File Offset: 0x000643E0
		// Note: this type is marked as 'beforefieldinit'.
		static Win32_FIXED_INFO()
		{
			Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_FIXED_INFO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr);
			Win32_FIXED_INFO.NativeFieldInfoPtr_HostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "HostName");
			Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DomainName");
			Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "CurrentDnsServer");
			Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DnsServerList");
			Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "NodeType");
			Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "ScopeId");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableRouting");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableProxy");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableDns");
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0000B440 File Offset: 0x00009640
		public Win32_FIXED_INFO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0000B449 File Offset: 0x00009649
		public Win32_FIXED_INFO()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr))
		{
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x000662C4 File Offset: 0x000644C4
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x0000B45B File Offset: 0x0000965B
		public unsafe string HostName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_HostName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_HostName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000662EC File Offset: 0x000644EC
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x0000B47A File Offset: 0x0000967A
		public unsafe string DomainName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00066314 File Offset: 0x00064514
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x0000B499 File Offset: 0x00009699
		public unsafe IntPtr CurrentDnsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer)) = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x0006633C File Offset: 0x0006453C
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x0000B4B4 File Offset: 0x000096B4
		public Win32_IP_ADDR_STRING DnsServerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList);
				return new Win32_IP_ADDR_STRING(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x0006636C File Offset: 0x0006456C
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x0000B4E2 File Offset: 0x000096E2
		public unsafe NetBiosNodeType NodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType)) = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00066394 File Offset: 0x00064594
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x0000B4FD File Offset: 0x000096FD
		public unsafe string ScopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x000663BC File Offset: 0x000645BC
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x0000B51C File Offset: 0x0000971C
		public unsafe uint EnableRouting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting)) = value;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x000663E4 File Offset: 0x000645E4
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x0000B537 File Offset: 0x00009737
		public unsafe uint EnableProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy)) = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x0006640C File Offset: 0x0006460C
		// (set) Token: 0x060016CA RID: 5834 RVA: 0x0000B552 File Offset: 0x00009752
		public unsafe uint EnableDns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns)) = value;
			}
		}

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeFieldInfoPtr_HostName;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeFieldInfoPtr_DomainName;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeFieldInfoPtr_CurrentDnsServer;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeFieldInfoPtr_DnsServerList;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeFieldInfoPtr_NodeType;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeFieldInfoPtr_ScopeId;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeFieldInfoPtr_EnableRouting;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeFieldInfoPtr_EnableProxy;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeFieldInfoPtr_EnableDns;
	}
}
