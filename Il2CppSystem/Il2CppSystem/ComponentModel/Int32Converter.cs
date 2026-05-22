using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200008C RID: 140
	public class Int32Converter : BaseNumberConverter
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x000057A6 File Offset: 0x000039A6
		// Note: this type is marked as 'beforefieldinit'.
		static Int32Converter()
		{
			Il2CppClassPointerStore<Int32Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Int32Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int32Converter>.NativeClassPtr);
			Int32Converter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int32Converter>.NativeClassPtr, 100664549);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0003157C File Offset: 0x0002F77C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int32Converter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int32Converter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int32Converter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000057DF File Offset: 0x000039DF
		public Int32Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
