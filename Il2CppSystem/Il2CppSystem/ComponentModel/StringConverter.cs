using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000095 RID: 149
	public class StringConverter : TypeConverter
	{
		// Token: 0x060008F9 RID: 2297 RVA: 0x000059B9 File Offset: 0x00003BB9
		// Note: this type is marked as 'beforefieldinit'.
		static StringConverter()
		{
			Il2CppClassPointerStore<StringConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "StringConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringConverter>.NativeClassPtr);
			StringConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConverter>.NativeClassPtr, 100664569);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00031F78 File Offset: 0x00030178
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000059F2 File Offset: 0x00003BF2
		public StringConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
