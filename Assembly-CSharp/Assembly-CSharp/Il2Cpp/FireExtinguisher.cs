using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000D4 RID: 212
	public class FireExtinguisher : Throwable
	{
		// Token: 0x060018D7 RID: 6359 RVA: 0x0007A138 File Offset: 0x00078338
		// Note: this type is marked as 'beforefieldinit'.
		static FireExtinguisher()
		{
			Il2CppClassPointerStore<FireExtinguisher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FireExtinguisher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireExtinguisher>.NativeClassPtr);
			FireExtinguisher.NativeMethodInfoPtr_Break_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireExtinguisher>.NativeClassPtr, 100665338);
			FireExtinguisher.NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireExtinguisher>.NativeClassPtr, 100665339);
			FireExtinguisher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireExtinguisher>.NativeClassPtr, 100665340);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0007A1A4 File Offset: 0x000783A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58254, XrefRangeEnd = 58289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FireExtinguisher.NativeMethodInfoPtr_Break_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0007A1E0 File Offset: 0x000783E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58289, XrefRangeEnd = 58327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FireExtinguisher.NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0007A21C File Offset: 0x0007841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FireExtinguisher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireExtinguisher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireExtinguisher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00011C8F File Offset: 0x0000FE8F
		public FireExtinguisher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_SetLayer_Public_Virtual_Void_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
