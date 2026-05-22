using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001B0 RID: 432
	public class StatusOnFire : StatusEffect
	{
		// Token: 0x060030D0 RID: 12496 RVA: 0x000BAB08 File Offset: 0x000B8D08
		// Note: this type is marked as 'beforefieldinit'.
		static StatusOnFire()
		{
			Il2CppClassPointerStore<StatusOnFire>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusOnFire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusOnFire>.NativeClassPtr);
			StatusOnFire.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusOnFire>.NativeClassPtr, "timer");
			StatusOnFire.NativeFieldInfoPtr_fireTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusOnFire>.NativeClassPtr, "fireTrans");
			StatusOnFire.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusOnFire>.NativeClassPtr, 100667121);
			StatusOnFire.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusOnFire>.NativeClassPtr, 100667122);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000BAB88 File Offset: 0x000B8D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84675, RefRangeEnd = 84676, XrefRangeStart = 84657, XrefRangeEnd = 84675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusOnFire(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusOnFire>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatusOnFire.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000BABD4 File Offset: 0x000B8DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84676, XrefRangeEnd = 84713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatusOnFire.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0002189F File Offset: 0x0001FA9F
		public StatusOnFire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x000BAC10 File Offset: 0x000B8E10
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x000218A8 File Offset: 0x0001FAA8
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusOnFire.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusOnFire.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x000BAC38 File Offset: 0x000B8E38
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x000218C3 File Offset: 0x0001FAC3
		public unsafe Transform fireTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusOnFire.NativeFieldInfoPtr_fireTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatusOnFire.NativeFieldInfoPtr_fireTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeFieldInfoPtr_fireTrans;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
