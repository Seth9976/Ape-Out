using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DC RID: 476
	public class RuntimeModule : Module
	{
		// Token: 0x06001EF6 RID: 7926 RVA: 0x0000A760 File Offset: 0x00008960
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeModule()
		{
			Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr);
			RuntimeModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100668494);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000AF670 File Offset: 0x000AD870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188472, XrefRangeEnd = 188475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0000A799 File Offset: 0x00008999
		public RuntimeModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
