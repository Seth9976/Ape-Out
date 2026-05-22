using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000094 RID: 148
	public class SingleConverter : BaseNumberConverter
	{
		// Token: 0x060008F6 RID: 2294 RVA: 0x00005977 File Offset: 0x00003B77
		// Note: this type is marked as 'beforefieldinit'.
		static SingleConverter()
		{
			Il2CppClassPointerStore<SingleConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "SingleConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleConverter>.NativeClassPtr);
			SingleConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleConverter>.NativeClassPtr, 100664568);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00031F3C File Offset: 0x0003013C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000059B0 File Offset: 0x00003BB0
		public SingleConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
