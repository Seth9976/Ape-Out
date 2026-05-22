using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000BE RID: 190
	public class DynoState : GuardState
	{
		// Token: 0x0600169A RID: 5786 RVA: 0x00074144 File Offset: 0x00072344
		// Note: this type is marked as 'beforefieldinit'.
		static DynoState()
		{
			Il2CppClassPointerStore<DynoState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DynoState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynoState>.NativeClassPtr);
			DynoState.NativeFieldInfoPtr_spark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoState>.NativeClassPtr, "spark");
			DynoState.NativeFieldInfoPtr_sparkCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoState>.NativeClassPtr, "sparkCounter");
			DynoState.NativeFieldInfoPtr_lastThrownTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoState>.NativeClassPtr, "lastThrownTimer");
			DynoState.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoState>.NativeClassPtr, "sprite");
			DynoState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoState>.NativeClassPtr, 100665193);
			DynoState.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoState>.NativeClassPtr, 100665194);
			DynoState.NativeMethodInfoPtr_ThrowDynamite_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoState>.NativeClassPtr, 100665195);
			DynoState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoState>.NativeClassPtr, 100665196);
			DynoState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoState>.NativeClassPtr, 100665197);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00074228 File Offset: 0x00072428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55965, XrefRangeEnd = 55972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoState.NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00074264 File Offset: 0x00072464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55972, XrefRangeEnd = 56018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoState.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000742A0 File Offset: 0x000724A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56071, RefRangeEnd = 56073, XrefRangeStart = 56018, XrefRangeEnd = 56071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowDynamite(Vector3 pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynoState.NativeMethodInfoPtr_ThrowDynamite_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000742E0 File Offset: 0x000724E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56073, XrefRangeEnd = 56087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBlown(Vector2 blowPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blowPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoState.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0007432C File Offset: 0x0007252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynoState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynoState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynoState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00010452 File Offset: 0x0000E652
		public DynoState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00074368 File Offset: 0x00072568
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x0001045B File Offset: 0x0000E65B
		public unsafe GameObject spark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_spark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_spark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00074398 File Offset: 0x00072598
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x0001047A File Offset: 0x0000E67A
		public unsafe int sparkCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_sparkCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_sparkCounter)) = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x000743C0 File Offset: 0x000725C0
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x00010495 File Offset: 0x0000E695
		public unsafe int lastThrownTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_lastThrownTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_lastThrownTimer)) = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x000743E8 File Offset: 0x000725E8
		// (set) Token: 0x060016A8 RID: 5800 RVA: 0x000104B0 File Offset: 0x0000E6B0
		public unsafe SpriteRenderer sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoState.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeFieldInfoPtr_spark;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeFieldInfoPtr_sparkCounter;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeFieldInfoPtr_lastThrownTimer;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_InitModes_Public_Virtual_Void_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_ThrowDynamite_Public_Void_Vector3_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
