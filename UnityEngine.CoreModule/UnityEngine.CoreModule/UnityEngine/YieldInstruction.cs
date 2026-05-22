using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F1 RID: 241
	public class YieldInstruction : Object
	{
		// Token: 0x06001418 RID: 5144 RVA: 0x0000B1B9 File Offset: 0x000093B9
		// Note: this type is marked as 'beforefieldinit'.
		static YieldInstruction()
		{
			Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "YieldInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr);
			YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr, 100665071);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00051520 File Offset: 0x0004F720
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YieldInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0000B1F2 File Offset: 0x000093F2
		public YieldInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
