using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000096 RID: 150
	public class TimeSpanConverter : TypeConverter
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x000059FB File Offset: 0x00003BFB
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanConverter()
		{
			Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TimeSpanConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr);
			TimeSpanConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr, 100664570);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00031FB4 File Offset: 0x000301B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpanConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00005A34 File Offset: 0x00003C34
		public TimeSpanConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
