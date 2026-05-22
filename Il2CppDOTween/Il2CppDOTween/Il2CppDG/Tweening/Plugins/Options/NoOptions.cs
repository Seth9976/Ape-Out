using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppDG.Tweening.Plugins.Options
{
	// Token: 0x02000035 RID: 53
	[StructLayout(2)]
	public struct NoOptions
	{
		// Token: 0x06000382 RID: 898 RVA: 0x00002FA4 File Offset: 0x000011A4
		// Note: this type is marked as 'beforefieldinit'.
		static NoOptions()
		{
			Il2CppClassPointerStore<NoOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "NoOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoOptions>.NativeClassPtr);
			NoOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoOptions>.NativeClassPtr, 100664094);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00017C80 File Offset: 0x00015E80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002FDD File Offset: 0x000011DD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NoOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
