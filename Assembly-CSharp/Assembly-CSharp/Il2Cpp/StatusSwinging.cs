using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001B4 RID: 436
	public class StatusSwinging : StatusEffect
	{
		// Token: 0x060030E7 RID: 12519 RVA: 0x0002196C File Offset: 0x0001FB6C
		// Note: this type is marked as 'beforefieldinit'.
		static StatusSwinging()
		{
			Il2CppClassPointerStore<StatusSwinging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusSwinging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusSwinging>.NativeClassPtr);
			StatusSwinging.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusSwinging>.NativeClassPtr, 100667128);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000BAF10 File Offset: 0x000B9110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84743, RefRangeEnd = 84745, XrefRangeStart = 84741, XrefRangeEnd = 84743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusSwinging(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusSwinging>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusSwinging.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x000219A5 File Offset: 0x0001FBA5
		public StatusSwinging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;
	}
}
