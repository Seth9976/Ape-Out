using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000DB RID: 219
	public sealed class ParamArrayAttribute : Attribute
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x00005B1D File Offset: 0x00003D1D
		// Note: this type is marked as 'beforefieldinit'.
		static ParamArrayAttribute()
		{
			Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParamArrayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr);
			ParamArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr, 100665785);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00066528 File Offset: 0x00064728
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamArrayAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00005B56 File Offset: 0x00003D56
		public ParamArrayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
