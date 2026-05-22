using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001D0 RID: 464
	public class Waiter : MonoBehaviour
	{
		// Token: 0x06003288 RID: 12936 RVA: 0x000BF174 File Offset: 0x000BD374
		// Note: this type is marked as 'beforefieldinit'.
		static Waiter()
		{
			Il2CppClassPointerStore<Waiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Waiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Waiter>.NativeClassPtr);
			Waiter.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waiter>.NativeClassPtr, "on");
			Waiter.NativeFieldInfoPtr_prevOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waiter>.NativeClassPtr, "prevOn");
			Waiter.NativeFieldInfoPtr_guards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waiter>.NativeClassPtr, "guards");
			Waiter.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waiter>.NativeClassPtr, 100667229);
			Waiter.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waiter>.NativeClassPtr, 100667230);
			Waiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waiter>.NativeClassPtr, 100667231);
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000BF21C File Offset: 0x000BD41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85861, XrefRangeEnd = 85867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waiter.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000BF250 File Offset: 0x000BD450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85867, XrefRangeEnd = 85890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waiter.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000BF294 File Offset: 0x000BD494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Waiter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Waiter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00022A0A File Offset: 0x00020C0A
		public Waiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x000BF2D0 File Offset: 0x000BD4D0
		// (set) Token: 0x0600328E RID: 12942 RVA: 0x00022A13 File Offset: 0x00020C13
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waiter.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waiter.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x000BF2F8 File Offset: 0x000BD4F8
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x00022A2E File Offset: 0x00020C2E
		public unsafe bool prevOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waiter.NativeFieldInfoPtr_prevOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waiter.NativeFieldInfoPtr_prevOn)) = value;
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x000BF320 File Offset: 0x000BD520
		// (set) Token: 0x06003292 RID: 12946 RVA: 0x00022A49 File Offset: 0x00020C49
		public unsafe List<GuardState> guards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waiter.NativeFieldInfoPtr_guards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuardState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waiter.NativeFieldInfoPtr_guards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeFieldInfoPtr_prevOn;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeFieldInfoPtr_guards;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
