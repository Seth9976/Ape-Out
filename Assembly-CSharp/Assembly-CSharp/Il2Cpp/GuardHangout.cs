using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000F7 RID: 247
	public class GuardHangout : GuardMode
	{
		// Token: 0x06001D5C RID: 7516 RVA: 0x00086B78 File Offset: 0x00084D78
		// Note: this type is marked as 'beforefieldinit'.
		static GuardHangout()
		{
			Il2CppClassPointerStore<GuardHangout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardHangout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardHangout>.NativeClassPtr);
			GuardHangout.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardHangout>.NativeClassPtr, 100665665);
			GuardHangout.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardHangout>.NativeClassPtr, 100665666);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00086BD0 File Offset: 0x00084DD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64492, RefRangeEnd = 64495, XrefRangeStart = 64492, XrefRangeEnd = 64492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardHangout(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardHangout>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardHangout.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00086C1C File Offset: 0x00084E1C
		[CallerCount(0)]
		public unsafe override bool ShouldAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardHangout.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00014A84 File Offset: 0x00012C84
		public GuardHangout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0;
	}
}
