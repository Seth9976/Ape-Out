using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E7 RID: 231
	public class HttpVersion : Object
	{
		// Token: 0x06000CB5 RID: 3253 RVA: 0x00040A68 File Offset: 0x0003EC68
		// Note: this type is marked as 'beforefieldinit'.
		static HttpVersion()
		{
			Il2CppClassPointerStore<HttpVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr);
			HttpVersion.NativeFieldInfoPtr_Version10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Version10");
			HttpVersion.NativeFieldInfoPtr_Version11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Version11");
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00006FC7 File Offset: 0x000051C7
		public HttpVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00040AC0 File Offset: 0x0003ECC0
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00006FD0 File Offset: 0x000051D0
		public unsafe static Version Version10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Version10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Version10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00040AE8 File Offset: 0x0003ECE8
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00006FE2 File Offset: 0x000051E2
		public unsafe static Version Version11
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Version11, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Version11, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr_Version10;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_Version11;
	}
}
