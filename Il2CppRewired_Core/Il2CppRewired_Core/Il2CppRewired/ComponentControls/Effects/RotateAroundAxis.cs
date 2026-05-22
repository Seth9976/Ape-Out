using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppRewired.ComponentControls.Effects
{
	// Token: 0x02000046 RID: 70
	public class RotateAroundAxis : MonoBehaviour
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x00043268 File Offset: 0x00041468
		// Note: this type is marked as 'beforefieldinit'.
		static RotateAroundAxis()
		{
			Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Effects", "RotateAroundAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr);
			RotateAroundAxis.NativeFieldInfoPtr__speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, "_speed");
			RotateAroundAxis.NativeFieldInfoPtr__slowRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, "_slowRotationSpeed");
			RotateAroundAxis.NativeFieldInfoPtr__fastRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, "_fastRotationSpeed");
			RotateAroundAxis.NativeFieldInfoPtr__rotateAroundAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, "_rotateAroundAxis");
			RotateAroundAxis.NativeFieldInfoPtr__relativeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, "_relativeTo");
			RotateAroundAxis.NativeFieldInfoPtr__reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, "_reverse");
			RotateAroundAxis.NativeMethodInfoPtr_get_speed_Public_get_Speed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664242);
			RotateAroundAxis.NativeMethodInfoPtr_set_speed_Public_set_Void_Speed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664243);
			RotateAroundAxis.NativeMethodInfoPtr_get_slowRotationSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664244);
			RotateAroundAxis.NativeMethodInfoPtr_set_slowRotationSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664245);
			RotateAroundAxis.NativeMethodInfoPtr_get_fastRotationSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664246);
			RotateAroundAxis.NativeMethodInfoPtr_set_fastRotationSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664247);
			RotateAroundAxis.NativeMethodInfoPtr_get_rotateAroundAxis_Public_get_RotationAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664248);
			RotateAroundAxis.NativeMethodInfoPtr_set_rotateAroundAxis_Public_set_Void_RotationAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664249);
			RotateAroundAxis.NativeMethodInfoPtr_get_relativeTo_Public_get_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664250);
			RotateAroundAxis.NativeMethodInfoPtr_set_relativeTo_Public_set_Void_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664251);
			RotateAroundAxis.NativeMethodInfoPtr_get_reverse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664252);
			RotateAroundAxis.NativeMethodInfoPtr_set_reverse_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664253);
			RotateAroundAxis.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664254);
			RotateAroundAxis.NativeMethodInfoPtr_GzUXipBExHMglcaORllOvpDVmPI_Private_Static_Vector3_RotationAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664255);
			RotateAroundAxis.NativeMethodInfoPtr_SetSpeed_Public_Void_Speed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664256);
			RotateAroundAxis.NativeMethodInfoPtr_SetSpeed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664257);
			RotateAroundAxis.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr, 100664258);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00043464 File Offset: 0x00041664
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x000434A0 File Offset: 0x000416A0
		public unsafe RotateAroundAxis.Speed speed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_get_speed_Public_get_Speed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_set_speed_Public_set_Void_Speed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x000434E0 File Offset: 0x000416E0
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0004351C File Offset: 0x0004171C
		public unsafe float slowRotationSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_get_slowRotationSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_set_slowRotationSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0004355C File Offset: 0x0004175C
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00043598 File Offset: 0x00041798
		public unsafe float fastRotationSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_get_fastRotationSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_set_fastRotationSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000435D8 File Offset: 0x000417D8
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00043614 File Offset: 0x00041814
		public unsafe RotateAroundAxis.RotationAxis rotateAroundAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_get_rotateAroundAxis_Public_get_RotationAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_set_rotateAroundAxis_Public_set_Void_RotationAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00043654 File Offset: 0x00041854
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00043690 File Offset: 0x00041890
		public unsafe Space relativeTo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_get_relativeTo_Public_get_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_set_relativeTo_Public_set_Void_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x000436D0 File Offset: 0x000418D0
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0004370C File Offset: 0x0004190C
		public unsafe bool reverse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_get_reverse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_set_reverse_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0004374C File Offset: 0x0004194C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246137, XrefRangeEnd = 246145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00043780 File Offset: 0x00041980
		[CallerCount(0)]
		public unsafe static Vector3 GzUXipBExHMglcaORllOvpDVmPI(RotateAroundAxis.RotationAxis A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_GzUXipBExHMglcaORllOvpDVmPI_Private_Static_Vector3_RotationAxis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000437C0 File Offset: 0x000419C0
		[CallerCount(0)]
		public unsafe void SetSpeed(RotateAroundAxis.Speed speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_SetSpeed_Public_Void_Speed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00043800 File Offset: 0x00041A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246145, XrefRangeEnd = 246160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpeed(int speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr_SetSpeed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00043840 File Offset: 0x00041A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246160, XrefRangeEnd = 246163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateAroundAxis()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateAroundAxis>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAroundAxis.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00003C86 File Offset: 0x00001E86
		public RotateAroundAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0004387C File Offset: 0x00041A7C
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00003C8F File Offset: 0x00001E8F
		public unsafe RotateAroundAxis.Speed _speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__speed)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x000438A4 File Offset: 0x00041AA4
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x00003CAA File Offset: 0x00001EAA
		public unsafe float _slowRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__slowRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__slowRotationSpeed)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000438CC File Offset: 0x00041ACC
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00003CC5 File Offset: 0x00001EC5
		public unsafe float _fastRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__fastRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__fastRotationSpeed)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000438F4 File Offset: 0x00041AF4
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00003CE0 File Offset: 0x00001EE0
		public unsafe RotateAroundAxis.RotationAxis _rotateAroundAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__rotateAroundAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__rotateAroundAxis)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0004391C File Offset: 0x00041B1C
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00003CFB File Offset: 0x00001EFB
		public unsafe Space _relativeTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__relativeTo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__relativeTo)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00043944 File Offset: 0x00041B44
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00003D16 File Offset: 0x00001F16
		public unsafe bool _reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAroundAxis.NativeFieldInfoPtr__reverse)) = value;
			}
		}

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr__speed;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr__slowRotationSpeed;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr__fastRotationSpeed;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr__rotateAroundAxis;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr__relativeTo;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr__reverse;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Public_get_Speed_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_set_speed_Public_set_Void_Speed_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_get_slowRotationSpeed_Public_get_Single_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_set_slowRotationSpeed_Public_set_Void_Single_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_get_fastRotationSpeed_Public_get_Single_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_set_fastRotationSpeed_Public_set_Void_Single_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_get_rotateAroundAxis_Public_get_RotationAxis_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_set_rotateAroundAxis_Public_set_Void_RotationAxis_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_relativeTo_Public_get_Space_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_set_relativeTo_Public_set_Void_Space_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_get_reverse_Public_get_Boolean_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_set_reverse_Public_set_Void_Boolean_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_GzUXipBExHMglcaORllOvpDVmPI_Private_Static_Vector3_RotationAxis_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Public_Void_Speed_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Public_Void_Int32_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000240 RID: 576
		[OriginalName("Rewired_Core.dll", "", "Speed")]
		public enum Speed
		{
			// Token: 0x04002FD6 RID: 12246
			Stopped,
			// Token: 0x04002FD7 RID: 12247
			Slow,
			// Token: 0x04002FD8 RID: 12248
			Fast
		}

		// Token: 0x02000241 RID: 577
		[OriginalName("Rewired_Core.dll", "", "RotationAxis")]
		public enum RotationAxis
		{
			// Token: 0x04002FDA RID: 12250
			X,
			// Token: 0x04002FDB RID: 12251
			Y,
			// Token: 0x04002FDC RID: 12252
			Z
		}
	}
}
