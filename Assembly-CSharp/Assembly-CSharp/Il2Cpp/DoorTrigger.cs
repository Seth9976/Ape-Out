using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000B9 RID: 185
	public class DoorTrigger : MonoBehaviour
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x0007337C File Offset: 0x0007157C
		// Note: this type is marked as 'beforefieldinit'.
		static DoorTrigger()
		{
			Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DoorTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr);
			DoorTrigger.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr, "door");
			DoorTrigger.NativeFieldInfoPtr_mom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr, "mom");
			DoorTrigger.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr, 100665167);
			DoorTrigger.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr, 100665168);
			DoorTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr, 100665169);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00073410 File Offset: 0x00071610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55538, XrefRangeEnd = 55589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorTrigger.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00073444 File Offset: 0x00071644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55589, XrefRangeEnd = 55603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorTrigger.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00073488 File Offset: 0x00071688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0001023E File Offset: 0x0000E43E
		public DoorTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x000734C4 File Offset: 0x000716C4
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x00010247 File Offset: 0x0000E447
		public unsafe Door door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorTrigger.NativeFieldInfoPtr_door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Door>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorTrigger.NativeFieldInfoPtr_door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x000734F4 File Offset: 0x000716F4
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x00010266 File Offset: 0x0000E466
		public unsafe MediumDoor mom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorTrigger.NativeFieldInfoPtr_mom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MediumDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorTrigger.NativeFieldInfoPtr_mom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeFieldInfoPtr_door;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeFieldInfoPtr_mom;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
