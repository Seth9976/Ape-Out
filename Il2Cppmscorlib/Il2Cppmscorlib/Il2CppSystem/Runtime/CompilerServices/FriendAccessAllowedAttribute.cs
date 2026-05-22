using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000432 RID: 1074
	public sealed class FriendAccessAllowedAttribute : Attribute
	{
		// Token: 0x0600435E RID: 17246 RVA: 0x00019884 File Offset: 0x00017A84
		// Note: this type is marked as 'beforefieldinit'.
		static FriendAccessAllowedAttribute()
		{
			Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "FriendAccessAllowedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr);
			FriendAccessAllowedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr, 100673142);
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00138090 File Offset: 0x00136290
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendAccessAllowedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendAccessAllowedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x000198BD File Offset: 0x00017ABD
		public FriendAccessAllowedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036C0 RID: 14016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
