using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000106 RID: 262
	public class CLRConfig : Object
	{
		// Token: 0x06001394 RID: 5012 RVA: 0x00006A74 File Offset: 0x00004C74
		// Note: this type is marked as 'beforefieldinit'.
		static CLRConfig()
		{
			Il2CppClassPointerStore<CLRConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CLRConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLRConfig>.NativeClassPtr);
			CLRConfig.NativeMethodInfoPtr_CheckThrowUnobservedTaskExceptions_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLRConfig>.NativeClassPtr, 100666743);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0007EF34 File Offset: 0x0007D134
		[CallerCount(0)]
		public unsafe static bool CheckThrowUnobservedTaskExceptions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CLRConfig.NativeMethodInfoPtr_CheckThrowUnobservedTaskExceptions_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00006AAD File Offset: 0x00004CAD
		public CLRConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_CheckThrowUnobservedTaskExceptions_Internal_Static_Boolean_0;
	}
}
