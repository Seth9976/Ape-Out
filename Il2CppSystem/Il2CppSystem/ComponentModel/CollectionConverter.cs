using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000073 RID: 115
	public class CollectionConverter : TypeConverter
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x00005248 File Offset: 0x00003448
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionConverter()
		{
			Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CollectionConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr);
			CollectionConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr, 100664465);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0002EF6C File Offset: 0x0002D16C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00005281 File Offset: 0x00003481
		public CollectionConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
