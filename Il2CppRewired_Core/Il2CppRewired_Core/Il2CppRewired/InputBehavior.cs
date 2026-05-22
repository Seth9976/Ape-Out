using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000158 RID: 344
	[Serializable]
	public sealed class InputBehavior : Object
	{
		// Token: 0x06002681 RID: 9857 RVA: 0x000C3D9C File Offset: 0x000C1F9C
		// Note: this type is marked as 'beforefieldinit'.
		static InputBehavior()
		{
			Il2CppClassPointerStore<InputBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputBehavior");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr);
			InputBehavior.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_id");
			InputBehavior.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_name");
			InputBehavior.NativeFieldInfoPtr__joystickAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_joystickAxisSensitivity");
			InputBehavior.NativeFieldInfoPtr__digitalAxisSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_digitalAxisSimulation");
			InputBehavior.NativeFieldInfoPtr__digitalAxisSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_digitalAxisSnap");
			InputBehavior.NativeFieldInfoPtr__digitalAxisInstantReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_digitalAxisInstantReverse");
			InputBehavior.NativeFieldInfoPtr__digitalAxisGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_digitalAxisGravity");
			InputBehavior.NativeFieldInfoPtr__digitalAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_digitalAxisSensitivity");
			InputBehavior.NativeFieldInfoPtr__mouseXYAxisMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_mouseXYAxisMode");
			InputBehavior.NativeFieldInfoPtr__mouseOtherAxisMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_mouseOtherAxisMode");
			InputBehavior.NativeFieldInfoPtr__mouseXYAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_mouseXYAxisSensitivity");
			InputBehavior.NativeFieldInfoPtr__mouseXYAxisDeltaCalc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_mouseXYAxisDeltaCalc");
			InputBehavior.NativeFieldInfoPtr__mouseOtherAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_mouseOtherAxisSensitivity");
			InputBehavior.NativeFieldInfoPtr__customControllerAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_customControllerAxisSensitivity");
			InputBehavior.NativeFieldInfoPtr__buttonDoublePressSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonDoublePressSpeed");
			InputBehavior.NativeFieldInfoPtr__buttonShortPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonShortPressTime");
			InputBehavior.NativeFieldInfoPtr__buttonShortPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonShortPressExpiresIn");
			InputBehavior.NativeFieldInfoPtr__buttonLongPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonLongPressTime");
			InputBehavior.NativeFieldInfoPtr__buttonLongPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonLongPressExpiresIn");
			InputBehavior.NativeFieldInfoPtr__buttonDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonDeadZone");
			InputBehavior.NativeFieldInfoPtr__buttonDownBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonDownBuffer");
			InputBehavior.NativeFieldInfoPtr__buttonRepeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonRepeatRate");
			InputBehavior.NativeFieldInfoPtr__buttonRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, "_buttonRepeatDelay");
			InputBehavior.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671606);
			InputBehavior.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671607);
			InputBehavior.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671608);
			InputBehavior.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671609);
			InputBehavior.NativeMethodInfoPtr_get_joystickAxisSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671610);
			InputBehavior.NativeMethodInfoPtr_set_joystickAxisSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671611);
			InputBehavior.NativeMethodInfoPtr_get_digitalAxisSimulation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671612);
			InputBehavior.NativeMethodInfoPtr_set_digitalAxisSimulation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671613);
			InputBehavior.NativeMethodInfoPtr_get_digitalAxisSnap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671614);
			InputBehavior.NativeMethodInfoPtr_set_digitalAxisSnap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671615);
			InputBehavior.NativeMethodInfoPtr_get_digitalAxisInstantReverse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671616);
			InputBehavior.NativeMethodInfoPtr_set_digitalAxisInstantReverse_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671617);
			InputBehavior.NativeMethodInfoPtr_get_digitalAxisGravity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671618);
			InputBehavior.NativeMethodInfoPtr_set_digitalAxisGravity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671619);
			InputBehavior.NativeMethodInfoPtr_get_digitalAxisSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671620);
			InputBehavior.NativeMethodInfoPtr_set_digitalAxisSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671621);
			InputBehavior.NativeMethodInfoPtr_get_mouseXYAxisMode_Public_get_MouseXYAxisMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671622);
			InputBehavior.NativeMethodInfoPtr_set_mouseXYAxisMode_Public_set_Void_MouseXYAxisMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671623);
			InputBehavior.NativeMethodInfoPtr_get_mouseOtherAxisMode_Public_get_MouseOtherAxisMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671624);
			InputBehavior.NativeMethodInfoPtr_set_mouseOtherAxisMode_Public_set_Void_MouseOtherAxisMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671625);
			InputBehavior.NativeMethodInfoPtr_get_mouseXYAxisSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671626);
			InputBehavior.NativeMethodInfoPtr_set_mouseXYAxisSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671627);
			InputBehavior.NativeMethodInfoPtr_get_mouseXYAxisDeltaCalc_Public_get_MouseXYAxisDeltaCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671628);
			InputBehavior.NativeMethodInfoPtr_set_mouseXYAxisDeltaCalc_Public_set_Void_MouseXYAxisDeltaCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671629);
			InputBehavior.NativeMethodInfoPtr_get_mouseOtherAxisSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671630);
			InputBehavior.NativeMethodInfoPtr_set_mouseOtherAxisSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671631);
			InputBehavior.NativeMethodInfoPtr_get_customControllerAxisSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671632);
			InputBehavior.NativeMethodInfoPtr_set_customControllerAxisSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671633);
			InputBehavior.NativeMethodInfoPtr_get_buttonDoublePressSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671634);
			InputBehavior.NativeMethodInfoPtr_set_buttonDoublePressSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671635);
			InputBehavior.NativeMethodInfoPtr_get_buttonShortPressTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671636);
			InputBehavior.NativeMethodInfoPtr_set_buttonShortPressTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671637);
			InputBehavior.NativeMethodInfoPtr_get_buttonShortPressExpiresIn_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671638);
			InputBehavior.NativeMethodInfoPtr_set_buttonShortPressExpiresIn_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671639);
			InputBehavior.NativeMethodInfoPtr_get_buttonLongPressTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671640);
			InputBehavior.NativeMethodInfoPtr_set_buttonLongPressTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671641);
			InputBehavior.NativeMethodInfoPtr_get_buttonLongPressExpiresIn_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671642);
			InputBehavior.NativeMethodInfoPtr_set_buttonLongPressExpiresIn_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671643);
			InputBehavior.NativeMethodInfoPtr_get_buttonDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671644);
			InputBehavior.NativeMethodInfoPtr_set_buttonDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671645);
			InputBehavior.NativeMethodInfoPtr_get_buttonDownBuffer_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671646);
			InputBehavior.NativeMethodInfoPtr_set_buttonDownBuffer_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671647);
			InputBehavior.NativeMethodInfoPtr_get_buttonRepeatRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671648);
			InputBehavior.NativeMethodInfoPtr_set_buttonRepeatRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671649);
			InputBehavior.NativeMethodInfoPtr_get_buttonRepeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671650);
			InputBehavior.NativeMethodInfoPtr_set_buttonRepeatDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671651);
			InputBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671652);
			InputBehavior.NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671653);
			InputBehavior.NativeMethodInfoPtr_ToXmlString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671654);
			InputBehavior.NativeMethodInfoPtr_ImportXmlString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671655);
			InputBehavior.NativeMethodInfoPtr_ToJsonString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671656);
			InputBehavior.NativeMethodInfoPtr_ImportJsonString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671657);
			InputBehavior.NativeMethodInfoPtr_ImportData_Public_Boolean_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671658);
			InputBehavior.NativeMethodInfoPtr_Clone_Public_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671659);
			InputBehavior.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671660);
			InputBehavior.NativeMethodInfoPtr_uWHAOsFrZajqcgGzgegyWlrrWvhV_Internal_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671661);
			InputBehavior.NativeMethodInfoPtr_HslZXwzLZbxwelftxpsnxMKSYYg_Internal_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671662);
			InputBehavior.NativeMethodInfoPtr_iBQZzrzZCpRiLDOWLBsealmteFb_Private_Static_Void_InputBehavior_InputBehavior_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr, 100671663);
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x000C4420 File Offset: 0x000C2620
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x000C445C File Offset: 0x000C265C
		public unsafe int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x000C449C File Offset: 0x000C269C
		// (set) Token: 0x06002685 RID: 9861 RVA: 0x000C44D4 File Offset: 0x000C26D4
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x000C4518 File Offset: 0x000C2718
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x000C4554 File Offset: 0x000C2754
		public unsafe float joystickAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_joystickAxisSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_joystickAxisSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x000C4594 File Offset: 0x000C2794
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x000C45D0 File Offset: 0x000C27D0
		public unsafe bool digitalAxisSimulation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_digitalAxisSimulation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_digitalAxisSimulation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x000C4610 File Offset: 0x000C2810
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x000C464C File Offset: 0x000C284C
		public unsafe bool digitalAxisSnap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_digitalAxisSnap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_digitalAxisSnap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x000C468C File Offset: 0x000C288C
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x000C46C8 File Offset: 0x000C28C8
		public unsafe bool digitalAxisInstantReverse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_digitalAxisInstantReverse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_digitalAxisInstantReverse_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x000C4708 File Offset: 0x000C2908
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x000C4744 File Offset: 0x000C2944
		public unsafe float digitalAxisGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_digitalAxisGravity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_digitalAxisGravity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x000C4784 File Offset: 0x000C2984
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x000C47C0 File Offset: 0x000C29C0
		public unsafe float digitalAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_digitalAxisSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_digitalAxisSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x000C4800 File Offset: 0x000C2A00
		// (set) Token: 0x06002693 RID: 9875 RVA: 0x000C483C File Offset: 0x000C2A3C
		public unsafe MouseXYAxisMode mouseXYAxisMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_mouseXYAxisMode_Public_get_MouseXYAxisMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_mouseXYAxisMode_Public_set_Void_MouseXYAxisMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x000C487C File Offset: 0x000C2A7C
		// (set) Token: 0x06002695 RID: 9877 RVA: 0x000C48B8 File Offset: 0x000C2AB8
		public unsafe MouseOtherAxisMode mouseOtherAxisMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_mouseOtherAxisMode_Public_get_MouseOtherAxisMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_mouseOtherAxisMode_Public_set_Void_MouseOtherAxisMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x000C48F8 File Offset: 0x000C2AF8
		// (set) Token: 0x06002697 RID: 9879 RVA: 0x000C4934 File Offset: 0x000C2B34
		public unsafe float mouseXYAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_mouseXYAxisSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_mouseXYAxisSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x000C4974 File Offset: 0x000C2B74
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x000C49B0 File Offset: 0x000C2BB0
		public unsafe MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_mouseXYAxisDeltaCalc_Public_get_MouseXYAxisDeltaCalc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_mouseXYAxisDeltaCalc_Public_set_Void_MouseXYAxisDeltaCalc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x000C49F0 File Offset: 0x000C2BF0
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x000C4A2C File Offset: 0x000C2C2C
		public unsafe float mouseOtherAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_mouseOtherAxisSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_mouseOtherAxisSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x000C4A6C File Offset: 0x000C2C6C
		// (set) Token: 0x0600269D RID: 9885 RVA: 0x000C4AA8 File Offset: 0x000C2CA8
		public unsafe float customControllerAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_customControllerAxisSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_customControllerAxisSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x000C4AE8 File Offset: 0x000C2CE8
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x000C4B24 File Offset: 0x000C2D24
		public unsafe float buttonDoublePressSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonDoublePressSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonDoublePressSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x000C4B64 File Offset: 0x000C2D64
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x000C4BA0 File Offset: 0x000C2DA0
		public unsafe float buttonShortPressTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 91998, RefRangeEnd = 91999, XrefRangeStart = 91998, XrefRangeEnd = 91999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonShortPressTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonShortPressTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x000C4BE0 File Offset: 0x000C2DE0
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x000C4C1C File Offset: 0x000C2E1C
		public unsafe float buttonShortPressExpiresIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonShortPressExpiresIn_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonShortPressExpiresIn_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000C4C5C File Offset: 0x000C2E5C
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x000C4C98 File Offset: 0x000C2E98
		public unsafe float buttonLongPressTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonLongPressTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonLongPressTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000C4CD8 File Offset: 0x000C2ED8
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x000C4D14 File Offset: 0x000C2F14
		public unsafe float buttonLongPressExpiresIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonLongPressExpiresIn_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonLongPressExpiresIn_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000C4D54 File Offset: 0x000C2F54
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x000C4D90 File Offset: 0x000C2F90
		public unsafe float buttonDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x000C4DD0 File Offset: 0x000C2FD0
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x000C4E0C File Offset: 0x000C300C
		public unsafe float buttonDownBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonDownBuffer_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonDownBuffer_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x000C4E4C File Offset: 0x000C304C
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x000C4E88 File Offset: 0x000C3088
		public unsafe float buttonRepeatRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonRepeatRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonRepeatRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x000C4EC8 File Offset: 0x000C30C8
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x000C4F04 File Offset: 0x000C3104
		public unsafe float buttonRepeatDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_get_buttonRepeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_set_buttonRepeatDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000C4F44 File Offset: 0x000C3144
		[CallerCount(0)]
		public unsafe InputBehavior()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000C4F80 File Offset: 0x000C3180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294779, XrefRangeEnd = 294780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBehavior(InputBehavior source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehavior>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000C4FCC File Offset: 0x000C31CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294783, RefRangeEnd = 294788, XrefRangeStart = 294780, XrefRangeEnd = 294783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXmlString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_ToXmlString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000C5004 File Offset: 0x000C3204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294798, RefRangeEnd = 294799, XrefRangeStart = 294788, XrefRangeEnd = 294798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_ImportXmlString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000C5054 File Offset: 0x000C3254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294799, XrefRangeEnd = 294802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJsonString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_ToJsonString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000C508C File Offset: 0x000C328C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294802, XrefRangeEnd = 294812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportJsonString(string jsonString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_ImportJsonString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000C50DC File Offset: 0x000C32DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294812, XrefRangeEnd = 294813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportData(InputBehavior inputBehavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBehavior);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_ImportData_Public_Boolean_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x000C512C File Offset: 0x000C332C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294817, RefRangeEnd = 294818, XrefRangeStart = 294813, XrefRangeEnd = 294817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBehavior Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_Clone_Public_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr3) : null;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000C516C File Offset: 0x000C336C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294830, RefRangeEnd = 294833, XrefRangeStart = 294818, XrefRangeEnd = 294830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000C51A0 File Offset: 0x000C33A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294995, RefRangeEnd = 294997, XrefRangeStart = 294833, XrefRangeEnd = 294995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject uWHAOsFrZajqcgGzgegyWlrrWvhV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_uWHAOsFrZajqcgGzgegyWlrrWvhV_Internal_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000C51E0 File Offset: 0x000C33E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295066, RefRangeEnd = 295068, XrefRangeStart = 294997, XrefRangeEnd = 295066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HslZXwzLZbxwelftxpsnxMKSYYg(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_HslZXwzLZbxwelftxpsnxMKSYYg_Internal_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000C5224 File Offset: 0x000C3424
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 295069, RefRangeEnd = 295078, XrefRangeStart = 295068, XrefRangeEnd = 295069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void iBQZzrzZCpRiLDOWLBsealmteFb(InputBehavior A_0, InputBehavior A_1, bool A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputBehavior.NativeMethodInfoPtr_iBQZzrzZCpRiLDOWLBsealmteFb_Private_Static_Void_InputBehavior_InputBehavior_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0000F14E File Offset: 0x0000D34E
		public InputBehavior(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000C527C File Offset: 0x000C347C
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x0000F157 File Offset: 0x0000D357
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000C52A4 File Offset: 0x000C34A4
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x0000F172 File Offset: 0x0000D372
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000C52CC File Offset: 0x000C34CC
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x0000F191 File Offset: 0x0000D391
		public unsafe float _joystickAxisSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__joystickAxisSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__joystickAxisSensitivity)) = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000C52F4 File Offset: 0x000C34F4
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public unsafe bool _digitalAxisSimulation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisSimulation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisSimulation)) = value;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000C531C File Offset: 0x000C351C
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x0000F1C7 File Offset: 0x0000D3C7
		public unsafe bool _digitalAxisSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisSnap)) = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000C5344 File Offset: 0x000C3544
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x0000F1E2 File Offset: 0x0000D3E2
		public unsafe bool _digitalAxisInstantReverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisInstantReverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisInstantReverse)) = value;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000C536C File Offset: 0x000C356C
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x0000F1FD File Offset: 0x0000D3FD
		public unsafe float _digitalAxisGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisGravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisGravity)) = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x000C5394 File Offset: 0x000C3594
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x0000F218 File Offset: 0x0000D418
		public unsafe float _digitalAxisSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__digitalAxisSensitivity)) = value;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x000C53BC File Offset: 0x000C35BC
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x0000F233 File Offset: 0x0000D433
		public unsafe MouseXYAxisMode _mouseXYAxisMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseXYAxisMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseXYAxisMode)) = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000C53E4 File Offset: 0x000C35E4
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x0000F24E File Offset: 0x0000D44E
		public unsafe MouseOtherAxisMode _mouseOtherAxisMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseOtherAxisMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseOtherAxisMode)) = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x000C540C File Offset: 0x000C360C
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x0000F269 File Offset: 0x0000D469
		public unsafe float _mouseXYAxisSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseXYAxisSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseXYAxisSensitivity)) = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000C5434 File Offset: 0x000C3634
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0000F284 File Offset: 0x0000D484
		public unsafe MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseXYAxisDeltaCalc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseXYAxisDeltaCalc)) = value;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000C545C File Offset: 0x000C365C
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0000F29F File Offset: 0x0000D49F
		public unsafe float _mouseOtherAxisSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseOtherAxisSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__mouseOtherAxisSensitivity)) = value;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000C5484 File Offset: 0x000C3684
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0000F2BA File Offset: 0x0000D4BA
		public unsafe float _customControllerAxisSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__customControllerAxisSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__customControllerAxisSensitivity)) = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000C54AC File Offset: 0x000C36AC
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x0000F2D5 File Offset: 0x0000D4D5
		public unsafe float _buttonDoublePressSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonDoublePressSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonDoublePressSpeed)) = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000C54D4 File Offset: 0x000C36D4
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
		public unsafe float _buttonShortPressTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonShortPressTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonShortPressTime)) = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000C54FC File Offset: 0x000C36FC
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0000F30B File Offset: 0x0000D50B
		public unsafe float _buttonShortPressExpiresIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonShortPressExpiresIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonShortPressExpiresIn)) = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000C5524 File Offset: 0x000C3724
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0000F326 File Offset: 0x0000D526
		public unsafe float _buttonLongPressTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonLongPressTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonLongPressTime)) = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000C554C File Offset: 0x000C374C
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x0000F341 File Offset: 0x0000D541
		public unsafe float _buttonLongPressExpiresIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonLongPressExpiresIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonLongPressExpiresIn)) = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000C5574 File Offset: 0x000C3774
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x0000F35C File Offset: 0x0000D55C
		public unsafe float _buttonDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonDeadZone)) = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000C559C File Offset: 0x000C379C
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x0000F377 File Offset: 0x0000D577
		public unsafe float _buttonDownBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonDownBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonDownBuffer)) = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000C55C4 File Offset: 0x000C37C4
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x0000F392 File Offset: 0x0000D592
		public unsafe float _buttonRepeatRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonRepeatRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonRepeatRate)) = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x000C55EC File Offset: 0x000C37EC
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x0000F3AD File Offset: 0x0000D5AD
		public unsafe float _buttonRepeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonRepeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputBehavior.NativeFieldInfoPtr__buttonRepeatDelay)) = value;
			}
		}

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeFieldInfoPtr__joystickAxisSensitivity;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr__digitalAxisSimulation;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr__digitalAxisSnap;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeFieldInfoPtr__digitalAxisInstantReverse;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeFieldInfoPtr__digitalAxisGravity;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeFieldInfoPtr__digitalAxisSensitivity;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeFieldInfoPtr__mouseXYAxisMode;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr__mouseOtherAxisMode;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr__mouseXYAxisSensitivity;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr__mouseXYAxisDeltaCalc;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeFieldInfoPtr__mouseOtherAxisSensitivity;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr__customControllerAxisSensitivity;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr__buttonDoublePressSpeed;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr__buttonShortPressTime;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr__buttonShortPressExpiresIn;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeFieldInfoPtr__buttonLongPressTime;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeFieldInfoPtr__buttonLongPressExpiresIn;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeFieldInfoPtr__buttonDeadZone;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeFieldInfoPtr__buttonDownBuffer;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeFieldInfoPtr__buttonRepeatRate;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeFieldInfoPtr__buttonRepeatDelay;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr_get_joystickAxisSensitivity_Public_get_Single_0;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeMethodInfoPtr_set_joystickAxisSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalAxisSimulation_Public_get_Boolean_0;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalAxisSimulation_Public_set_Void_Boolean_0;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalAxisSnap_Public_get_Boolean_0;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalAxisSnap_Public_set_Void_Boolean_0;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalAxisInstantReverse_Public_get_Boolean_0;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalAxisInstantReverse_Public_set_Void_Boolean_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalAxisGravity_Public_get_Single_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalAxisGravity_Public_set_Void_Single_0;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeMethodInfoPtr_get_digitalAxisSensitivity_Public_get_Single_0;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr_set_digitalAxisSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseXYAxisMode_Public_get_MouseXYAxisMode_0;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseXYAxisMode_Public_set_Void_MouseXYAxisMode_0;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseOtherAxisMode_Public_get_MouseOtherAxisMode_0;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseOtherAxisMode_Public_set_Void_MouseOtherAxisMode_0;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseXYAxisSensitivity_Public_get_Single_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseXYAxisSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseXYAxisDeltaCalc_Public_get_MouseXYAxisDeltaCalc_0;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseXYAxisDeltaCalc_Public_set_Void_MouseXYAxisDeltaCalc_0;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseOtherAxisSensitivity_Public_get_Single_0;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseOtherAxisSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr_get_customControllerAxisSensitivity_Public_get_Single_0;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeMethodInfoPtr_set_customControllerAxisSensitivity_Public_set_Void_Single_0;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonDoublePressSpeed_Public_get_Single_0;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonDoublePressSpeed_Public_set_Void_Single_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonShortPressTime_Public_get_Single_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonShortPressTime_Public_set_Void_Single_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonShortPressExpiresIn_Public_get_Single_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonShortPressExpiresIn_Public_set_Void_Single_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonLongPressTime_Public_get_Single_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonLongPressTime_Public_set_Void_Single_0;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonLongPressExpiresIn_Public_get_Single_0;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonLongPressExpiresIn_Public_set_Void_Single_0;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonDeadZone_Public_get_Single_0;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonDeadZone_Public_set_Void_Single_0;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonDownBuffer_Public_get_Single_0;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonDownBuffer_Public_set_Void_Single_0;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonRepeatRate_Public_get_Single_0;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonRepeatRate_Public_set_Void_Single_0;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonRepeatDelay_Public_get_Single_0;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeMethodInfoPtr_set_buttonRepeatDelay_Public_set_Void_Single_0;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_0;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_String_0;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr_ImportXmlString_Public_Boolean_String_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_ImportJsonString_Public_Boolean_String_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_ImportData_Public_Boolean_InputBehavior_0;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_InputBehavior_0;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_uWHAOsFrZajqcgGzgegyWlrrWvhV_Internal_SerializedObject_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_HslZXwzLZbxwelftxpsnxMKSYYg_Internal_Void_SerializedObject_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_iBQZzrzZCpRiLDOWLBsealmteFb_Private_Static_Void_InputBehavior_InputBehavior_Boolean_0;
	}
}
