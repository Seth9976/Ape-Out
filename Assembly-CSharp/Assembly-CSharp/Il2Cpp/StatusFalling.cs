using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001AD RID: 429
	public class StatusFalling : StatusEffect
	{
		// Token: 0x060030C6 RID: 12486 RVA: 0x00021812 File Offset: 0x0001FA12
		// Note: this type is marked as 'beforefieldinit'.
		static StatusFalling()
		{
			Il2CppClassPointerStore<StatusFalling>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusFalling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusFalling>.NativeClassPtr);
			StatusFalling.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusFalling>.NativeClassPtr, 100667117);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000BA97C File Offset: 0x000B8B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84632, XrefRangeEnd = 84634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusFalling(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusFalling>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusFalling.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0002184B File Offset: 0x0001FA4B
		public StatusFalling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;
	}
}
