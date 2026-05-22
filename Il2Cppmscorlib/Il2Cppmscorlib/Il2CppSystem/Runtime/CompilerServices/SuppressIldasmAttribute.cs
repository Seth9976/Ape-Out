using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000434 RID: 1076
	public sealed class SuppressIldasmAttribute : Attribute
	{
		// Token: 0x06004363 RID: 17251 RVA: 0x000198F4 File Offset: 0x00017AF4
		// Note: this type is marked as 'beforefieldinit'.
		static SuppressIldasmAttribute()
		{
			Il2CppClassPointerStore<SuppressIldasmAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "SuppressIldasmAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuppressIldasmAttribute>.NativeClassPtr);
			SuppressIldasmAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuppressIldasmAttribute>.NativeClassPtr, 100673143);
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x001380CC File Offset: 0x001362CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SuppressIldasmAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuppressIldasmAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuppressIldasmAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x0001992D File Offset: 0x00017B2D
		public SuppressIldasmAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036C1 RID: 14017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
