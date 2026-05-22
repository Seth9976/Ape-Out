using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000081 RID: 129
	public class DoubleConverter : BaseNumberConverter
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x000055D7 File Offset: 0x000037D7
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleConverter()
		{
			Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DoubleConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr);
			DoubleConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr, 100664524);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000309C4 File Offset: 0x0002EBC4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00005610 File Offset: 0x00003810
		public DoubleConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
