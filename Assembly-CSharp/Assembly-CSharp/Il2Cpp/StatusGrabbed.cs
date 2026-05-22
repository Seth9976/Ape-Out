using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001AF RID: 431
	public class StatusGrabbed : StatusEffect
	{
		// Token: 0x060030CD RID: 12493 RVA: 0x0002185D File Offset: 0x0001FA5D
		// Note: this type is marked as 'beforefieldinit'.
		static StatusGrabbed()
		{
			Il2CppClassPointerStore<StatusGrabbed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusGrabbed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusGrabbed>.NativeClassPtr);
			StatusGrabbed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusGrabbed>.NativeClassPtr, 100667120);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000BAABC File Offset: 0x000B8CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84655, RefRangeEnd = 84657, XrefRangeStart = 84653, XrefRangeEnd = 84655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusGrabbed(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusGrabbed>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusGrabbed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00021896 File Offset: 0x0001FA96
		public StatusGrabbed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;
	}
}
