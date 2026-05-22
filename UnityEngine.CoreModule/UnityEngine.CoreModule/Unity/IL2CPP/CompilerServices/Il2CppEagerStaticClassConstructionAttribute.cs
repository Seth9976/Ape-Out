using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x02000016 RID: 22
	public class Il2CppEagerStaticClassConstructionAttribute : Attribute
	{
		// Token: 0x06000093 RID: 147 RVA: 0x000025D7 File Offset: 0x000007D7
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppEagerStaticClassConstructionAttribute()
		{
			Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IL2CPP.CompilerServices", "Il2CppEagerStaticClassConstructionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr);
			Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00016BDC File Offset: 0x00014DDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppEagerStaticClassConstructionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002610 File Offset: 0x00000810
		public Il2CppEagerStaticClassConstructionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
