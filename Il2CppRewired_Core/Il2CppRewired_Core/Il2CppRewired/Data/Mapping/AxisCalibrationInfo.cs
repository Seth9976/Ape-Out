using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000BB RID: 187
	[Serializable]
	public class AxisCalibrationInfo : global::Il2CppSystem.Object
	{
		// Token: 0x06001573 RID: 5491 RVA: 0x0007D550 File Offset: 0x0007B750
		// Note: this type is marked as 'beforefieldinit'.
		static AxisCalibrationInfo()
		{
			Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "AxisCalibrationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr);
			AxisCalibrationInfo.NativeFieldInfoPtr__applyRangeCalibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_applyRangeCalibration");
			AxisCalibrationInfo.NativeFieldInfoPtr__invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_invert");
			AxisCalibrationInfo.NativeFieldInfoPtr__deadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_deadZone");
			AxisCalibrationInfo.NativeFieldInfoPtr__zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_zero");
			AxisCalibrationInfo.NativeFieldInfoPtr__min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_min");
			AxisCalibrationInfo.NativeFieldInfoPtr__max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_max");
			AxisCalibrationInfo.NativeFieldInfoPtr__sensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_sensitivityType");
			AxisCalibrationInfo.NativeFieldInfoPtr__sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_sensitivity");
			AxisCalibrationInfo.NativeFieldInfoPtr__sensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, "_sensitivityCurve");
			AxisCalibrationInfo.NativeMethodInfoPtr_get_applyRangeCalibration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668375);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_applyRangeCalibration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668376);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668377);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668378);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_deadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668379);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_deadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668380);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_zero_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668381);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_zero_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668382);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_min_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668383);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_min_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668384);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_max_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668385);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_max_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668386);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668387);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668388);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668389);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_sensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668390);
			AxisCalibrationInfo.NativeMethodInfoPtr_get_sensitivityCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668391);
			AxisCalibrationInfo.NativeMethodInfoPtr_set_sensitivityCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668392);
			AxisCalibrationInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668393);
			AxisCalibrationInfo.NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668394);
			AxisCalibrationInfo.NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668395);
			AxisCalibrationInfo.NativeMethodInfoPtr_wIQfkqpzvgOEMhoPXBABYqftOnI_Internal_Static_AxisCalibrationData_AxisCalibrationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668396);
			AxisCalibrationInfo.NativeMethodInfoPtr_kyrjWgLvlSiwJsSgbDXkLpcHYOC_Internal_Static_AxisCalibrationInfo_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr, 100668397);
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0007D800 File Offset: 0x0007BA00
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x0007D83C File Offset: 0x0007BA3C
		public unsafe bool applyRangeCalibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_applyRangeCalibration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_applyRangeCalibration_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x0007D87C File Offset: 0x0007BA7C
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x0007D8B8 File Offset: 0x0007BAB8
		public unsafe bool invert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0007D8F8 File Offset: 0x0007BAF8
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0007D934 File Offset: 0x0007BB34
		public unsafe float deadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_deadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_deadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0007D974 File Offset: 0x0007BB74
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x0007D9B0 File Offset: 0x0007BBB0
		public unsafe float zero
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_zero_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_zero_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x0007D9F0 File Offset: 0x0007BBF0
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0007DA2C File Offset: 0x0007BC2C
		public unsafe float min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_min_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_min_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0007DA6C File Offset: 0x0007BC6C
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0007DAA8 File Offset: 0x0007BCA8
		public unsafe float max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_max_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_max_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0007DAE8 File Offset: 0x0007BCE8
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x0007DB24 File Offset: 0x0007BD24
		public unsafe AxisSensitivityType sensitivityType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0007DB64 File Offset: 0x0007BD64
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0007DBA0 File Offset: 0x0007BDA0
		public unsafe float sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_sensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0007DBE0 File Offset: 0x0007BDE0
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0007DC20 File Offset: 0x0007BE20
		public unsafe AnimationCurve sensitivityCurve
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_get_sensitivityCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_set_sensitivityCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0007DC64 File Offset: 0x0007BE64
		[CallerCount(0)]
		public unsafe AxisCalibrationInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0007DCA0 File Offset: 0x0007BEA0
		[CallerCount(0)]
		public unsafe AxisCalibrationInfo(float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibrationInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deadZone;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyRangeCalibration;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sensitivityCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0007DD60 File Offset: 0x0007BF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271482, RefRangeEnd = 271483, XrefRangeStart = 271475, XrefRangeEnd = 271482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual global::Il2CppSystem.Object DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271483, XrefRangeEnd = 271490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AxisCalibrationData wIQfkqpzvgOEMhoPXBABYqftOnI(AxisCalibrationInfo A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_wIQfkqpzvgOEMhoPXBABYqftOnI_Internal_Static_AxisCalibrationData_AxisCalibrationInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AxisCalibrationData(intPtr);
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0007DDDC File Offset: 0x0007BFDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 271493, RefRangeEnd = 271498, XrefRangeStart = 271490, XrefRangeEnd = 271493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AxisCalibrationInfo kyrjWgLvlSiwJsSgbDXkLpcHYOC(AxisCalibrationData A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxisCalibrationInfo.NativeMethodInfoPtr_kyrjWgLvlSiwJsSgbDXkLpcHYOC_Internal_Static_AxisCalibrationInfo_AxisCalibrationData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibrationInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00009652 File Offset: 0x00007852
		public AxisCalibrationInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x0007DE28 File Offset: 0x0007C028
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000965B File Offset: 0x0000785B
		public unsafe bool _applyRangeCalibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__applyRangeCalibration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__applyRangeCalibration)) = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0007DE50 File Offset: 0x0007C050
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00009676 File Offset: 0x00007876
		public unsafe bool _invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__invert)) = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x0007DE78 File Offset: 0x0007C078
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00009691 File Offset: 0x00007891
		public unsafe float _deadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__deadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__deadZone)) = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x0007DEA0 File Offset: 0x0007C0A0
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x000096AC File Offset: 0x000078AC
		public unsafe float _zero
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__zero);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__zero)) = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0007DEC8 File Offset: 0x0007C0C8
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x000096C7 File Offset: 0x000078C7
		public unsafe float _min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__min)) = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x0007DEF0 File Offset: 0x0007C0F0
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x000096E2 File Offset: 0x000078E2
		public unsafe float _max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__max)) = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0007DF18 File Offset: 0x0007C118
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x000096FD File Offset: 0x000078FD
		public unsafe AxisSensitivityType _sensitivityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__sensitivityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__sensitivityType)) = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0007DF40 File Offset: 0x0007C140
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x00009718 File Offset: 0x00007918
		public unsafe float _sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__sensitivity)) = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x0007DF68 File Offset: 0x0007C168
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x00009733 File Offset: 0x00007933
		public unsafe AnimationCurve _sensitivityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__sensitivityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxisCalibrationInfo.NativeFieldInfoPtr__sensitivityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeFieldInfoPtr__applyRangeCalibration;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr__invert;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr__deadZone;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr__zero;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeFieldInfoPtr__min;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr__max;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeFieldInfoPtr__sensitivityType;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeFieldInfoPtr__sensitivity;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeFieldInfoPtr__sensitivityCurve;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_get_applyRangeCalibration_Public_get_Boolean_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_set_applyRangeCalibration_Public_set_Void_Boolean_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_get_invert_Public_get_Boolean_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_set_invert_Public_set_Void_Boolean_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_get_deadZone_Public_get_Single_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_set_deadZone_Public_set_Void_Single_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_get_Single_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_set_zero_Public_set_Void_Single_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_get_min_Public_get_Single_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Single_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_get_max_Public_get_Single_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Single_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_get_sensitivityType_Public_get_AxisSensitivityType_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_set_sensitivityType_Public_set_Void_AxisSensitivityType_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_get_sensitivity_Public_get_Single_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_set_sensitivity_Public_set_Void_Single_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_get_sensitivityCurve_Public_get_AnimationCurve_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_set_sensitivityCurve_Public_set_Void_AnimationCurve_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_wIQfkqpzvgOEMhoPXBABYqftOnI_Internal_Static_AxisCalibrationData_AxisCalibrationInfo_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_kyrjWgLvlSiwJsSgbDXkLpcHYOC_Internal_Static_AxisCalibrationInfo_AxisCalibrationData_0;
	}
}
