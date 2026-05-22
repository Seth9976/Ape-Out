using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000039 RID: 57
	public class BurstDiscardAttribute : Attribute
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00003156 File Offset: 0x00001356
		// Note: this type is marked as 'beforefieldinit'.
		static BurstDiscardAttribute()
		{
			Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst", "BurstDiscardAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr);
			BurstDiscardAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr, 100663408);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000191F8 File Offset: 0x000173F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstDiscardAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstDiscardAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000318F File Offset: 0x0000138F
		public BurstDiscardAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
