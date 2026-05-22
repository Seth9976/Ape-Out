using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x020000C2 RID: 194
	public sealed class StoreAuthURLResponse_t : ValueType
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x0002D1FC File Offset: 0x0002B3FC
		// Note: this type is marked as 'beforefieldinit'.
		static StoreAuthURLResponse_t()
		{
			Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "StoreAuthURLResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr);
			StoreAuthURLResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, "k_iCallback");
			StoreAuthURLResponse_t.NativeFieldInfoPtr_m_szURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, "m_szURL");
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000052B6 File Offset: 0x000034B6
		public StoreAuthURLResponse_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000052BF File Offset: 0x000034BF
		public StoreAuthURLResponse_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x0002D254 File Offset: 0x0002B454
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x000052D1 File Offset: 0x000034D1
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StoreAuthURLResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoreAuthURLResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0002D270 File Offset: 0x0002B470
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x000052DF File Offset: 0x000034DF
		public unsafe string m_szURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreAuthURLResponse_t.NativeFieldInfoPtr_m_szURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreAuthURLResponse_t.NativeFieldInfoPtr_m_szURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeFieldInfoPtr_m_szURL;
	}
}
