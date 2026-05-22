using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001B2 RID: 434
	public class StatusPushed : StatusEffect
	{
		// Token: 0x060030DC RID: 12508 RVA: 0x000218EB File Offset: 0x0001FAEB
		// Note: this type is marked as 'beforefieldinit'.
		static StatusPushed()
		{
			Il2CppClassPointerStore<StatusPushed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusPushed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusPushed>.NativeClassPtr);
			StatusPushed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusPushed>.NativeClassPtr, 100667125);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000BAD5C File Offset: 0x000B8F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84732, XrefRangeEnd = 84734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusPushed(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusPushed>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusPushed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x00021924 File Offset: 0x0001FB24
		public StatusPushed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;
	}
}
