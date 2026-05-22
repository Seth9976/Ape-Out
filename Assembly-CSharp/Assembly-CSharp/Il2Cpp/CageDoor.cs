using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200009D RID: 157
	public class CageDoor : Glass
	{
		// Token: 0x06001293 RID: 4755 RVA: 0x000696D4 File Offset: 0x000678D4
		// Note: this type is marked as 'beforefieldinit'.
		static CageDoor()
		{
			Il2CppClassPointerStore<CageDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CageDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CageDoor>.NativeClassPtr);
			CageDoor.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, "health");
			CageDoor.NativeFieldInfoPtr_animals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, "animals");
			CageDoor.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, "open");
			CageDoor.NativeFieldInfoPtr_linkedDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, "linkedDoor");
			CageDoor.NativeFieldInfoPtr_hardCodedAnimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, "hardCodedAnimals");
			CageDoor.NativeFieldInfoPtr_checkedHC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, "checkedHC");
			CageDoor.NativeFieldInfoPtr_mapTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, "mapTile");
			CageDoor.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, 100664879);
			CageDoor.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, 100664880);
			CageDoor.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, 100664881);
			CageDoor.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, 100664882);
			CageDoor.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, 100664883);
			CageDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CageDoor>.NativeClassPtr, 100664884);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00069808 File Offset: 0x00067A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50193, XrefRangeEnd = 50196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CageDoor.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00069844 File Offset: 0x00067A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50196, XrefRangeEnd = 50219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CageDoor.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00069880 File Offset: 0x00067A80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 50226, RefRangeEnd = 50228, XrefRangeStart = 50219, XrefRangeEnd = 50226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CageDoor.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000698B4 File Offset: 0x00067AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50228, XrefRangeEnd = 50231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CageDoor.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000698F0 File Offset: 0x00067AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50231, XrefRangeEnd = 50275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CageDoor.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0006993C File Offset: 0x00067B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50275, XrefRangeEnd = 50276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CageDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CageDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CageDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0000D950 File Offset: 0x0000BB50
		public CageDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00069978 File Offset: 0x00067B78
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x0000D959 File Offset: 0x0000BB59
		public unsafe float health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_health)) = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000699A0 File Offset: 0x00067BA0
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x0000D974 File Offset: 0x0000BB74
		public unsafe List<GameObject> animals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_animals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_animals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000699D0 File Offset: 0x00067BD0
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x0000D993 File Offset: 0x0000BB93
		public unsafe bool open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_open)) = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000699F8 File Offset: 0x00067BF8
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x0000D9AE File Offset: 0x0000BBAE
		public unsafe Il2CppReferenceArray<CageDoor> linkedDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_linkedDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CageDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_linkedDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00069A28 File Offset: 0x00067C28
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0000D9CD File Offset: 0x0000BBCD
		public unsafe bool hardCodedAnimals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_hardCodedAnimals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_hardCodedAnimals)) = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00069A50 File Offset: 0x00067C50
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		public unsafe bool checkedHC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_checkedHC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_checkedHC)) = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00069A78 File Offset: 0x00067C78
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x0000DA03 File Offset: 0x0000BC03
		public unsafe MapTile mapTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_mapTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CageDoor.NativeFieldInfoPtr_mapTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_health;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_animals;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_open;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_linkedDoor;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_hardCodedAnimals;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_checkedHC;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeFieldInfoPtr_mapTile;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
