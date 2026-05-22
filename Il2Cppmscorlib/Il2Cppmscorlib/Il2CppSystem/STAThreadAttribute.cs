using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000EF RID: 239
	public sealed class STAThreadAttribute : Attribute
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x0000616E File Offset: 0x0000436E
		// Note: this type is marked as 'beforefieldinit'.
		static STAThreadAttribute()
		{
			Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "STAThreadAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr);
			STAThreadAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr, 100666236);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x000727D8 File Offset: 0x000709D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe STAThreadAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(STAThreadAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000061A7 File Offset: 0x000043A7
		public STAThreadAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
