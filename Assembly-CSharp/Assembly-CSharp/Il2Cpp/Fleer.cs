using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000DF RID: 223
	public class Fleer : MonoBehaviour
	{
		// Token: 0x0600198E RID: 6542 RVA: 0x0007C030 File Offset: 0x0007A230
		// Note: this type is marked as 'beforefieldinit'.
		static Fleer()
		{
			Il2CppClassPointerStore<Fleer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Fleer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fleer>.NativeClassPtr);
			Fleer.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fleer>.NativeClassPtr, "on");
			Fleer.NativeFieldInfoPtr_prevOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fleer>.NativeClassPtr, "prevOn");
			Fleer.NativeFieldInfoPtr_guards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fleer>.NativeClassPtr, "guards");
			Fleer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fleer>.NativeClassPtr, 100665385);
			Fleer.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fleer>.NativeClassPtr, 100665386);
			Fleer.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fleer>.NativeClassPtr, 100665387);
			Fleer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fleer>.NativeClassPtr, 100665388);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0007C0EC File Offset: 0x0007A2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59172, XrefRangeEnd = 59178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fleer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0007C120 File Offset: 0x0007A320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59178, XrefRangeEnd = 59179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fleer.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0007C164 File Offset: 0x0007A364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59215, RefRangeEnd = 59216, XrefRangeStart = 59179, XrefRangeEnd = 59215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fleer.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fleer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fleer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fleer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00012384 File Offset: 0x00010584
		public Fleer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x0007C1E4 File Offset: 0x0007A3E4
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x0001238D File Offset: 0x0001058D
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fleer.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fleer.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0007C20C File Offset: 0x0007A40C
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x000123A8 File Offset: 0x000105A8
		public unsafe bool prevOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fleer.NativeFieldInfoPtr_prevOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fleer.NativeFieldInfoPtr_prevOn)) = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x0007C234 File Offset: 0x0007A434
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x000123C3 File Offset: 0x000105C3
		public unsafe List<GameObject> guards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fleer.NativeFieldInfoPtr_guards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fleer.NativeFieldInfoPtr_guards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_prevOn;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_guards;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
