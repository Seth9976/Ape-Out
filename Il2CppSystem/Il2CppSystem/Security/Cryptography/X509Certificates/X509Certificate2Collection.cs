using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B5 RID: 181
	[DefaultMember("Item")]
	public class X509Certificate2Collection : X509CertificateCollection
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x00005F11 File Offset: 0x00004111
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2Collection()
		{
			Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2Collection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr);
			X509Certificate2Collection.NativeFieldInfoPtr_newline_split = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, "newline_split");
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00005F4A File Offset: 0x0000414A
		public X509Certificate2Collection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00034B28 File Offset: 0x00032D28
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00005F53 File Offset: 0x00004153
		public unsafe static Il2CppStringArray newline_split
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2Collection.NativeFieldInfoPtr_newline_split, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2Collection.NativeFieldInfoPtr_newline_split, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_newline_split;
	}
}
