using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000256 RID: 598
	public class Punycode : Bootstring
	{
		// Token: 0x060029BA RID: 10682 RVA: 0x0000E56D File Offset: 0x0000C76D
		// Note: this type is marked as 'beforefieldinit'.
		static Punycode()
		{
			Il2CppClassPointerStore<Punycode>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Punycode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Punycode>.NativeClassPtr);
			Punycode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Punycode>.NativeClassPtr, 100670052);
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000DB918 File Offset: 0x000D9B18
		[CallerCount(0)]
		public unsafe Punycode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Punycode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Punycode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0000E5A6 File Offset: 0x0000C7A6
		public Punycode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
