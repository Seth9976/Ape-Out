using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200008B RID: 139
	public class Int16Converter : BaseNumberConverter
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x00005764 File Offset: 0x00003964
		// Note: this type is marked as 'beforefieldinit'.
		static Int16Converter()
		{
			Il2CppClassPointerStore<Int16Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "Int16Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int16Converter>.NativeClassPtr);
			Int16Converter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int16Converter>.NativeClassPtr, 100664548);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00031540 File Offset: 0x0002F740
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int16Converter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Int16Converter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int16Converter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0000579D File Offset: 0x0000399D
		public Int16Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
