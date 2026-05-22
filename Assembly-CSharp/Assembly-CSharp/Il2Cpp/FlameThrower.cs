using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000DC RID: 220
	public class FlameThrower : GuardGun
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x0007B4BC File Offset: 0x000796BC
		// Note: this type is marked as 'beforefieldinit'.
		static FlameThrower()
		{
			Il2CppClassPointerStore<FlameThrower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlameThrower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr);
			FlameThrower.NativeFieldInfoPtr_ammo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, "ammo");
			FlameThrower.NativeFieldInfoPtr_shooting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, "shooting");
			FlameThrower.NativeFieldInfoPtr_flameThrowerLoopThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, "flameThrowerLoopThrough");
			FlameThrower.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, 100665370);
			FlameThrower.NativeMethodInfoPtr_TurnOffFlameThrower_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, 100665371);
			FlameThrower.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, 100665372);
			FlameThrower.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, 100665373);
			FlameThrower.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, 100665374);
			FlameThrower.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, 100665375);
			FlameThrower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr, 100665376);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0007B5B4 File Offset: 0x000797B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58791, XrefRangeEnd = 58792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameThrower.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0007B5F0 File Offset: 0x000797F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58792, XrefRangeEnd = 58793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOffFlameThrower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameThrower.NativeMethodInfoPtr_TurnOffFlameThrower_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0007B624 File Offset: 0x00079824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58793, XrefRangeEnd = 58797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameThrower.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0007B660 File Offset: 0x00079860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58797, XrefRangeEnd = 58798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameThrower.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0007B69C File Offset: 0x0007989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58798, XrefRangeEnd = 58800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameThrower.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0007B6D8 File Offset: 0x000798D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58800, XrefRangeEnd = 58849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlameThrower.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0007B714 File Offset: 0x00079914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58849, XrefRangeEnd = 58850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlameThrower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlameThrower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlameThrower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00012090 File Offset: 0x00010290
		public FlameThrower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x0007B750 File Offset: 0x00079950
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x00012099 File Offset: 0x00010299
		public unsafe int ammo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameThrower.NativeFieldInfoPtr_ammo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameThrower.NativeFieldInfoPtr_ammo)) = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x0007B778 File Offset: 0x00079978
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x000120B4 File Offset: 0x000102B4
		public unsafe bool shooting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameThrower.NativeFieldInfoPtr_shooting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameThrower.NativeFieldInfoPtr_shooting)) = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0007B7A0 File Offset: 0x000799A0
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x000120CF File Offset: 0x000102CF
		public unsafe SECTRLoopThrough flameThrowerLoopThrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameThrower.NativeFieldInfoPtr_flameThrowerLoopThrough);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTRLoopThrough>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlameThrower.NativeFieldInfoPtr_flameThrowerLoopThrough), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr_ammo;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr_shooting;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeFieldInfoPtr_flameThrowerLoopThrough;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_TurnOffFlameThrower_Public_Void_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
