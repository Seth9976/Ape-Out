using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000EC RID: 236
	public sealed class WaitForEndOfFrame : YieldInstruction
	{
		// Token: 0x060013FC RID: 5116 RVA: 0x0000B0AA File Offset: 0x000092AA
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForEndOfFrame()
		{
			Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForEndOfFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr);
			WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr, 100665061);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00051068 File Offset: 0x0004F268
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForEndOfFrame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0000B0E3 File Offset: 0x000092E3
		public WaitForEndOfFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
