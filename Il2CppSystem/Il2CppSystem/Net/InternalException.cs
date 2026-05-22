using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EF RID: 239
	public class InternalException : SystemException
	{
		// Token: 0x06000D26 RID: 3366 RVA: 0x00007320 File Offset: 0x00005520
		// Note: this type is marked as 'beforefieldinit'.
		static InternalException()
		{
			Il2CppClassPointerStore<InternalException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "InternalException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalException>.NativeClassPtr);
			InternalException.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalException>.NativeClassPtr, 100665197);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00042044 File Offset: 0x00040244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208113, RefRangeEnd = 208114, XrefRangeStart = 208113, XrefRangeEnd = 208114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalException.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00007359 File Offset: 0x00005559
		public InternalException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
