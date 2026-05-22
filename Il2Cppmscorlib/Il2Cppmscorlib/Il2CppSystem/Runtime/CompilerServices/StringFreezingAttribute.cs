using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000437 RID: 1079
	[Serializable]
	public sealed class StringFreezingAttribute : Attribute
	{
		// Token: 0x0600436E RID: 17262 RVA: 0x000199A0 File Offset: 0x00017BA0
		// Note: this type is marked as 'beforefieldinit'.
		static StringFreezingAttribute()
		{
			Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "StringFreezingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr);
			StringFreezingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr, 100673146);
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00138210 File Offset: 0x00136410
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringFreezingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringFreezingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFreezingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x000199D9 File Offset: 0x00017BD9
		public StringFreezingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036C5 RID: 14021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
