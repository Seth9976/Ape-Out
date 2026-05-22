using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200016B RID: 363
	public sealed class Win32_IP_ADDR_STRING : ValueType
	{
		// Token: 0x060016CB RID: 5835 RVA: 0x00066434 File Offset: 0x00064634
		// Note: this type is marked as 'beforefieldinit'.
		static Win32_IP_ADDR_STRING()
		{
			Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_IP_ADDR_STRING");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr);
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Next");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpAddress");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpMask");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Context");
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0000B56D File Offset: 0x0000976D
		public Win32_IP_ADDR_STRING(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0000B576 File Offset: 0x00009776
		public Win32_IP_ADDR_STRING()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr))
		{
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x000664B4 File Offset: 0x000646B4
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x0000B588 File Offset: 0x00009788
		public unsafe IntPtr Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next)) = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x000664DC File Offset: 0x000646DC
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x0000B5A3 File Offset: 0x000097A3
		public unsafe string IpAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00066504 File Offset: 0x00064704
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0000B5C2 File Offset: 0x000097C2
		public unsafe string IpMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0006652C File Offset: 0x0006472C
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0000B5E1 File Offset: 0x000097E1
		public unsafe uint Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context)) = value;
			}
		}

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeFieldInfoPtr_IpAddress;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr_IpMask;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeFieldInfoPtr_Context;
	}
}
