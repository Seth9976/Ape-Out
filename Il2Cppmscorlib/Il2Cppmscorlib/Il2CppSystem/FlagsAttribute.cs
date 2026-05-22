using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000A7 RID: 167
	[Serializable]
	public class FlagsAttribute : Attribute
	{
		// Token: 0x06000BF6 RID: 3062 RVA: 0x000050E5 File Offset: 0x000032E5
		// Note: this type is marked as 'beforefieldinit'.
		static FlagsAttribute()
		{
			Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FlagsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr);
			FlagsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr, 100665322);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000598D4 File Offset: 0x00057AD4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlagsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlagsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlagsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0000511E File Offset: 0x0000331E
		public FlagsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
