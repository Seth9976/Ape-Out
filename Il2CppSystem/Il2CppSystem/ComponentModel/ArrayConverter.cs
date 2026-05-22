using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006A RID: 106
	public class ArrayConverter : CollectionConverter
	{
		// Token: 0x0600078A RID: 1930 RVA: 0x00004F36 File Offset: 0x00003136
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayConverter()
		{
			Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ArrayConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr);
			ArrayConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr, 100664409);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0002D694 File Offset: 0x0002B894
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00004F6F File Offset: 0x0000316F
		public ArrayConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
