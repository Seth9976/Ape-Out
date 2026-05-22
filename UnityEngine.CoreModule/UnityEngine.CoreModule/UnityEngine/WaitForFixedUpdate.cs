using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000ED RID: 237
	public sealed class WaitForFixedUpdate : YieldInstruction
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x0000B0EC File Offset: 0x000092EC
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForFixedUpdate()
		{
			Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForFixedUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr);
			WaitForFixedUpdate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr, 100665062);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000510A4 File Offset: 0x0004F2A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForFixedUpdate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForFixedUpdate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0000B125 File Offset: 0x00009325
		public WaitForFixedUpdate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
