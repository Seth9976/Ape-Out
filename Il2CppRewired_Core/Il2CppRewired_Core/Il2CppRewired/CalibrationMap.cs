using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000139 RID: 313
	public sealed class CalibrationMap : global::Il2CppSystem.Object
	{
		// Token: 0x06002236 RID: 8758 RVA: 0x000AF6EC File Offset: 0x000AD8EC
		// Note: this type is marked as 'beforefieldinit'.
		static CalibrationMap()
		{
			Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "CalibrationMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr);
			CalibrationMap.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, "yPmaEVkiAXCCzJsPBnVnFFukdZK");
			CalibrationMap.NativeFieldInfoPtr_SpKhRxcbUmWgLtjDyGbxjuPAtfGR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, "SpKhRxcbUmWgLtjDyGbxjuPAtfGR");
			CalibrationMap.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			CalibrationMap.NativeMethodInfoPtr_get_Axes_Public_get_IList_1_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670676);
			CalibrationMap.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670677);
			CalibrationMap.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670678);
			CalibrationMap.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670679);
			CalibrationMap.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AxisCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670680);
			CalibrationMap.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670681);
			CalibrationMap.NativeMethodInfoPtr_GetAxis_Public_AxisCalibration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670682);
			CalibrationMap.NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670683);
			CalibrationMap.NativeMethodInfoPtr_SetAxisData_Public_Boolean_Int32_AxisCalibrationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670684);
			CalibrationMap.NativeMethodInfoPtr_GetAxisData_Public_AxisCalibrationData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670685);
			CalibrationMap.NativeMethodInfoPtr_CopyFrom_Internal_Void_CalibrationMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670686);
			CalibrationMap.NativeMethodInfoPtr_ToXmlString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670687);
			CalibrationMap.NativeMethodInfoPtr_ToJsonString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670688);
			CalibrationMap.NativeMethodInfoPtr_ImportXmlString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670689);
			CalibrationMap.NativeMethodInfoPtr_ImportJsonString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670690);
			CalibrationMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670691);
			CalibrationMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670692);
			CalibrationMap.NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Vector2_Int32_Int32_Single_Single_DeadZone2DType_AxisSensitivity2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr, 100670693);
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x000AF8C0 File Offset: 0x000ADAC0
		public unsafe IList<AxisCalibration> Axes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_get_Axes_Public_get_IList_1_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<AxisCalibration>>(intPtr3) : null;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x000AF900 File Offset: 0x000ADB00
		public unsafe int axisCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x000AF93C File Offset: 0x000ADB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287449, XrefRangeEnd = 287453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalibrationMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x000AF978 File Offset: 0x000ADB78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287485, RefRangeEnd = 287486, XrefRangeStart = 287453, XrefRangeEnd = 287485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalibrationMap(Il2CppReferenceArray<AxisCalibrationData> hardwareAxisCalibrationData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hardwareAxisCalibrationData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_AxisCalibrationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x000AF9C4 File Offset: 0x000ADBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287486, XrefRangeEnd = 287494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalibrationMap(Il2CppReferenceArray<AxisCalibration> axisCalibrations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalibrationMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisCalibrations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AxisCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000AFA10 File Offset: 0x000ADC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287494, XrefRangeEnd = 287502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x000AFA44 File Offset: 0x000ADC44
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 287506, RefRangeEnd = 287520, XrefRangeStart = 287502, XrefRangeEnd = 287506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibration GetAxis(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_GetAxis_Public_AxisCalibration_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000AFA90 File Offset: 0x000ADC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287520, XrefRangeEnd = 287529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCalibratedValue(int axisIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x000AFAE8 File Offset: 0x000ADCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287529, XrefRangeEnd = 287537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetAxisData(int index, AxisCalibrationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_SetAxisData_Public_Boolean_Int32_AxisCalibrationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x000AFB48 File Offset: 0x000ADD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287537, XrefRangeEnd = 287545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibrationData GetAxisData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_GetAxisData_Public_AxisCalibrationData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AxisCalibrationData(intPtr);
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x000AFB8C File Offset: 0x000ADD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287545, XrefRangeEnd = 287559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyHardwareDeadzone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_CopyFrom_Internal_Void_CalibrationMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x000AFBDC File Offset: 0x000ADDDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287567, RefRangeEnd = 287569, XrefRangeStart = 287559, XrefRangeEnd = 287567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXmlString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_ToXmlString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x000AFC14 File Offset: 0x000ADE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287569, XrefRangeEnd = 287576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJsonString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_ToJsonString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x000AFC4C File Offset: 0x000ADE4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287586, RefRangeEnd = 287587, XrefRangeStart = 287576, XrefRangeEnd = 287586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_ImportXmlString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x000AFC9C File Offset: 0x000ADE9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287597, RefRangeEnd = 287598, XrefRangeStart = 287587, XrefRangeEnd = 287597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportJsonString(string jsonString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_ImportJsonString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000AFCEC File Offset: 0x000ADEEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287688, RefRangeEnd = 287690, XrefRangeStart = 287598, XrefRangeEnd = 287688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject TUpbRFbZCQXGnqKfXoSpZTimZpRE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x000AFD2C File Offset: 0x000ADF2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287705, RefRangeEnd = 287707, XrefRangeStart = 287690, XrefRangeEnd = 287705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x000AFD70 File Offset: 0x000ADF70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287710, RefRangeEnd = 287714, XrefRangeStart = 287707, XrefRangeEnd = 287710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xAxisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAxisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueRawX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueRawY;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZoneType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalibrationMap.NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Vector2_Int32_Int32_Single_Single_DeadZone2DType_AxisSensitivity2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0000DCD6 File Offset: 0x0000BED6
		public CalibrationMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x000AFE00 File Offset: 0x000AE000
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x0000DCDF File Offset: 0x0000BEDF
		public unsafe Il2CppReferenceArray<AxisCalibration> yPmaEVkiAXCCzJsPBnVnFFukdZK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMap.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AxisCalibration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMap.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x000AFE30 File Offset: 0x000AE030
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x0000DCFE File Offset: 0x0000BEFE
		public unsafe IList<AxisCalibration> SpKhRxcbUmWgLtjDyGbxjuPAtfGR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMap.NativeFieldInfoPtr_SpKhRxcbUmWgLtjDyGbxjuPAtfGR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<AxisCalibration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMap.NativeFieldInfoPtr_SpKhRxcbUmWgLtjDyGbxjuPAtfGR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x000AFE60 File Offset: 0x000AE060
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x0000DD1D File Offset: 0x0000BF1D
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMap.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalibrationMap.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeFieldInfoPtr_SpKhRxcbUmWgLtjDyGbxjuPAtfGR;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr_get_Axes_Public_get_IList_1_AxisCalibration_0;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_get_Int32_0;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_AxisCalibrationData_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AxisCalibration_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_AxisCalibration_Int32_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedValue_Public_Single_Int32_Single_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisData_Public_Boolean_Int32_AxisCalibrationData_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisData_Public_AxisCalibrationData_Int32_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Internal_Void_CalibrationMap_Boolean_0;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_String_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_ImportXmlString_Public_Boolean_String_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_ImportJsonString_Public_Boolean_String_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Void_SerializedObject_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibrated2DValue_Internal_Vector2_Int32_Int32_Single_Single_DeadZone2DType_AxisSensitivity2DType_0;
	}
}
