using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000066 RID: 102
	public class AlarmDoor : Door
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
		// Note: this type is marked as 'beforefieldinit'.
		static AlarmDoor()
		{
			Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AlarmDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr);
			AlarmDoor.NativeFieldInfoPtr_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, "closed");
			AlarmDoor.NativeFieldInfoPtr_alarmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, "alarmed");
			AlarmDoor.NativeFieldInfoPtr_alarmTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, "alarmTimer");
			AlarmDoor.NativeFieldInfoPtr_ptLst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, "ptLst");
			AlarmDoor.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, 100664485);
			AlarmDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, 100664486);
			AlarmDoor.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, 100664487);
			AlarmDoor.NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, 100664488);
			AlarmDoor.NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, 100664489);
			AlarmDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr, 100664490);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0005CCAC File Offset: 0x0005AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44143, XrefRangeEnd = 44157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlarmDoor.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44157, XrefRangeEnd = 44180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MyFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlarmDoor.NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0005CD24 File Offset: 0x0005AF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44180, XrefRangeEnd = 44184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlarmDoor.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0005CD60 File Offset: 0x0005AF60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetTriggerSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlarmDoor.NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0005CD9C File Offset: 0x0005AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44184, XrefRangeEnd = 44192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTrigStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AlarmDoor.NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_Void_Collider2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0005CDEC File Offset: 0x0005AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlarmDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlarmDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlarmDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0000A5EF File Offset: 0x000087EF
		public AlarmDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0005CE28 File Offset: 0x0005B028
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public unsafe bool closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_closed)) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0005CE50 File Offset: 0x0005B050
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x0000A613 File Offset: 0x00008813
		public unsafe bool alarmed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_alarmed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_alarmed)) = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0005CE78 File Offset: 0x0005B078
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x0000A62E File Offset: 0x0000882E
		public unsafe int alarmTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_alarmTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_alarmTimer)) = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0005CEA0 File Offset: 0x0005B0A0
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x0000A649 File Offset: 0x00008849
		public unsafe List<Vector3> ptLst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_ptLst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlarmDoor.NativeFieldInfoPtr_ptLst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeFieldInfoPtr_closed;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeFieldInfoPtr_alarmed;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeFieldInfoPtr_alarmTimer;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeFieldInfoPtr_ptLst;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_MyFixedUpdate_Public_Virtual_Void_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggerSize_Public_Virtual_Void_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_OnTrigStay2D_Public_Virtual_Void_Collider2D_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
