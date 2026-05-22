using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200016E RID: 366
	public class RequestCache : Object
	{
		// Token: 0x060016ED RID: 5869 RVA: 0x0000B687 File Offset: 0x00009887
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCache()
		{
			Il2CppClassPointerStore<RequestCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCache>.NativeClassPtr);
			RequestCache.NativeFieldInfoPtr_LineSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCache>.NativeClassPtr, "LineSplits");
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0000B6C0 File Offset: 0x000098C0
		public RequestCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00066994 File Offset: 0x00064B94
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0000B6C9 File Offset: 0x000098C9
		public unsafe static Il2CppStructArray<char> LineSplits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCache.NativeFieldInfoPtr_LineSplits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCache.NativeFieldInfoPtr_LineSplits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeFieldInfoPtr_LineSplits;
	}
}
