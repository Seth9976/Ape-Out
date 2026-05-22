using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200008D RID: 141
	public class Int64Converter : BaseNumberConverter
	{
		// Token: 0x060008C2 RID: 2242 RVA: 0x000057E8 File Offset: 0x000039E8
		// Note: this type is marked as 'beforefieldinit'.
		static Int64Converter()
		{
			Il2CppClassPointerStore<Int64Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Int64Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int64Converter>.NativeClassPtr);
			Int64Converter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int64Converter>.NativeClassPtr, 100664550);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000315B8 File Offset: 0x0002F7B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int64Converter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int64Converter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64Converter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00005821 File Offset: 0x00003A21
		public Int64Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
