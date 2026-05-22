using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000DB RID: 219
	public class FlameState : GuardState
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x0007B3EC File Offset: 0x000795EC
		// Note: this type is marked as 'beforefieldinit'.
		static FlameState()
		{
			Il2CppClassPointerStore<FlameState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlameState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlameState>.NativeClassPtr);
			FlameState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameState>.NativeClassPtr, 100665368);
			FlameState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameState>.NativeClassPtr, 100665369);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0007B444 File Offset: 0x00079644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58786, XrefRangeEnd = 58791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0007B480 File Offset: 0x00079680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlameState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlameState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00012087 File Offset: 0x00010287
		public FlameState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
