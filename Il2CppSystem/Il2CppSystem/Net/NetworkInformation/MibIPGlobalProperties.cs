using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000167 RID: 359
	public class MibIPGlobalProperties : UnixIPGlobalProperties
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x00065D84 File Offset: 0x00063F84
		// Note: this type is marked as 'beforefieldinit'.
		static MibIPGlobalProperties()
		{
			Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "MibIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr);
			MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "StatisticsFile");
			MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFileIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "StatisticsFileIPv6");
			MibIPGlobalProperties.NativeFieldInfoPtr_TcpFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "TcpFile");
			MibIPGlobalProperties.NativeFieldInfoPtr_Tcp6File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "Tcp6File");
			MibIPGlobalProperties.NativeFieldInfoPtr_UdpFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "UdpFile");
			MibIPGlobalProperties.NativeFieldInfoPtr_Udp6File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "Udp6File");
			MibIPGlobalProperties.NativeFieldInfoPtr_wsChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "wsChars");
			MibIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, 100666508);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00065E54 File Offset: 0x00064054
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 388597, RefRangeEnd = 388600, XrefRangeStart = 388576, XrefRangeEnd = 388597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MibIPGlobalProperties(string procDir)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(procDir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MibIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0000B334 File Offset: 0x00009534
		public MibIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x00065EA0 File Offset: 0x000640A0
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x0000B33D File Offset: 0x0000953D
		public unsafe string StatisticsFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00065EC8 File Offset: 0x000640C8
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x0000B35C File Offset: 0x0000955C
		public unsafe string StatisticsFileIPv6
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFileIPv6);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFileIPv6), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00065EF0 File Offset: 0x000640F0
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x0000B37B File Offset: 0x0000957B
		public unsafe string TcpFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_TcpFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_TcpFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00065F18 File Offset: 0x00064118
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x0000B39A File Offset: 0x0000959A
		public unsafe string Tcp6File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Tcp6File);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Tcp6File), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00065F40 File Offset: 0x00064140
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000B3B9 File Offset: 0x000095B9
		public unsafe string UdpFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_UdpFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_UdpFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x00065F68 File Offset: 0x00064168
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x0000B3D8 File Offset: 0x000095D8
		public unsafe string Udp6File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Udp6File);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Udp6File), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00065F90 File Offset: 0x00064190
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x0000B3F7 File Offset: 0x000095F7
		public unsafe static Il2CppStructArray<char> wsChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MibIPGlobalProperties.NativeFieldInfoPtr_wsChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MibIPGlobalProperties.NativeFieldInfoPtr_wsChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeFieldInfoPtr_StatisticsFile;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeFieldInfoPtr_StatisticsFileIPv6;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeFieldInfoPtr_TcpFile;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeFieldInfoPtr_Tcp6File;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeFieldInfoPtr_UdpFile;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeFieldInfoPtr_Udp6File;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeFieldInfoPtr_wsChars;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
