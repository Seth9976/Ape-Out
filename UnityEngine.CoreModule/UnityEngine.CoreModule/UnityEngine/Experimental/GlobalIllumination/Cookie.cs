using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200019E RID: 414
	[StructLayout(2)]
	public struct Cookie
	{
		// Token: 0x06001EE3 RID: 7907 RVA: 0x00071C24 File Offset: 0x0006FE24
		// Note: this type is marked as 'beforefieldinit'.
		static Cookie()
		{
			Il2CppClassPointerStore<Cookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Cookie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cookie>.NativeClassPtr);
			Cookie.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "instanceID");
			Cookie.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "scale");
			Cookie.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "sizes");
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00010155 File Offset: 0x0000E355
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cookie>.NativeClassPtr, ref this));
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00071C90 File Offset: 0x0006FE90
		public static Cookie Defaults()
		{
			Cookie cookie;
			cookie.instanceID = 0;
			cookie.scale = 1f;
			cookie.sizes = new Vector2(1f, 1f);
			return cookie;
		}

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x04001847 RID: 6215
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04001848 RID: 6216
		[FieldOffset(4)]
		public float scale;

		// Token: 0x04001849 RID: 6217
		[FieldOffset(8)]
		public Vector2 sizes;
	}
}
