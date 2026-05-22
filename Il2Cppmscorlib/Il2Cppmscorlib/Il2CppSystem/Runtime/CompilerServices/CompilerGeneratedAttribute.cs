using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042B RID: 1067
	[Serializable]
	public sealed class CompilerGeneratedAttribute : Attribute
	{
		// Token: 0x06004336 RID: 17206 RVA: 0x00019729 File Offset: 0x00017929
		// Note: this type is marked as 'beforefieldinit'.
		static CompilerGeneratedAttribute()
		{
			Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CompilerGeneratedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr);
			CompilerGeneratedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr, 100673128);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x0013796C File Offset: 0x00135B6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilerGeneratedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilerGeneratedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerGeneratedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00019762 File Offset: 0x00017962
		public CompilerGeneratedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036AC RID: 13996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
