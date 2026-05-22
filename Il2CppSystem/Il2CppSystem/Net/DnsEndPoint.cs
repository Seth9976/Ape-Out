using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E1 RID: 225
	public class DnsEndPoint : EndPoint
	{
		// Token: 0x06000CA3 RID: 3235 RVA: 0x000406B8 File Offset: 0x0003E8B8
		// Note: this type is marked as 'beforefieldinit'.
		static DnsEndPoint()
		{
			Il2CppClassPointerStore<DnsEndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "DnsEndPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DnsEndPoint>.NativeClassPtr);
			DnsEndPoint.NativeFieldInfoPtr_m_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DnsEndPoint>.NativeClassPtr, "m_Host");
			DnsEndPoint.NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DnsEndPoint>.NativeClassPtr, "m_Port");
			DnsEndPoint.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DnsEndPoint>.NativeClassPtr, 100665149);
			DnsEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DnsEndPoint>.NativeClassPtr, 100665150);
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00040738 File Offset: 0x0003E938
		public unsafe string Host
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DnsEndPoint.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00040770 File Offset: 0x0003E970
		public unsafe int Port
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DnsEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00006F72 File Offset: 0x00005172
		public DnsEndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000407AC File Offset: 0x0003E9AC
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00006F7B File Offset: 0x0000517B
		public unsafe string m_Host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DnsEndPoint.NativeFieldInfoPtr_m_Host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DnsEndPoint.NativeFieldInfoPtr_m_Host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000407D4 File Offset: 0x0003E9D4
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00006F9A File Offset: 0x0000519A
		public unsafe int m_Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DnsEndPoint.NativeFieldInfoPtr_m_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DnsEndPoint.NativeFieldInfoPtr_m_Port)) = value;
			}
		}

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_m_Host;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_m_Port;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;
	}
}
