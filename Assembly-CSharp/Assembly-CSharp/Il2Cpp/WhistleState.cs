using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001D5 RID: 469
	public class WhistleState : CivState
	{
		// Token: 0x060032BE RID: 12990 RVA: 0x000BFA5C File Offset: 0x000BDC5C
		// Note: this type is marked as 'beforefieldinit'.
		static WhistleState()
		{
			Il2CppClassPointerStore<WhistleState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WhistleState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhistleState>.NativeClassPtr);
			WhistleState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhistleState>.NativeClassPtr, 100667243);
			WhistleState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhistleState>.NativeClassPtr, 100667244);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000BFAB4 File Offset: 0x000BDCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85992, XrefRangeEnd = 85997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WhistleState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000BFAF0 File Offset: 0x000BDCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhistleState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhistleState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhistleState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x00022BD4 File Offset: 0x00020DD4
		public WhistleState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
