using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F0 RID: 496
	public static class InputTools : global::Il2CppSystem.Object
	{
		// Token: 0x0600323F RID: 12863 RVA: 0x000FA2C8 File Offset: 0x000F84C8
		// Note: this type is marked as 'beforefieldinit'.
		static InputTools()
		{
			Il2CppClassPointerStore<InputTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "InputTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputTools>.NativeClassPtr);
			InputTools.NativeMethodInfoPtr_TransformAxis2DComponentValue_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100675999);
			InputTools.NativeMethodInfoPtr_GetCalibratedAxisValueClamped_Public_Static_Single_Single_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676000);
			InputTools.NativeMethodInfoPtr_GetCalibratedAxisValue_Public_Static_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676001);
			InputTools.NativeMethodInfoPtr_ApplyRadialDeadZone_Public_Static_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676002);
			InputTools.NativeMethodInfoPtr_ApplySensitivity_Public_Static_Single_Single_AxisSensitivityType_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676003);
			InputTools.NativeMethodInfoPtr_alhgfPesQbWJbqlopjoBcDgAZrQD_Private_Static_Boolean_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676004);
			InputTools.NativeMethodInfoPtr_ApplyRadialSensitivity_Public_Static_Void_byref_Vector2_AxisSensitivityType_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676005);
			InputTools.NativeMethodInfoPtr_FormatHardwareIdentifierString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676006);
			InputTools.NativeMethodInfoPtr_InvertAxisRange_Public_Static_AxisRange_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676007);
			InputTools.NativeMethodInfoPtr_CompareLastActiveController_Public_Static_Void_Controller_byref_Controller_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676008);
			InputTools.NativeMethodInfoPtr_IsMappableControllerElementType_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676009);
			InputTools.NativeMethodInfoPtr_IsMappableType_Public_Static_Boolean_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676010);
			InputTools.NativeMethodInfoPtr_IsMappableType_Public_Static_Boolean_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676011);
			InputTools.NativeMethodInfoPtr_HandleForced4WayHatsOnUnknownControllers_Public_Static_Boolean_Int32_byref_HatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676012);
			InputTools.NativeMethodInfoPtr_AxisToDigitalValue_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676013);
			InputTools.NativeMethodInfoPtr_AxisToDigitalValue_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTools>.NativeClassPtr, 100676014);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000FA438 File Offset: 0x000F8638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338048, RefRangeEnd = 338050, XrefRangeStart = 338046, XrefRangeEnd = 338048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float TransformAxis2DComponentValue(float value, float zero, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_TransformAxis2DComponentValue_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000FA4A0 File Offset: 0x000F86A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338051, RefRangeEnd = 338054, XrefRangeStart = 338050, XrefRangeEnd = 338051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetCalibratedAxisValueClamped(float value, float zero, float min, float max, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applySensitivity;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sensitivityCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_GetCalibratedAxisValueClamped_Public_Static_Single_Single_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000FA564 File Offset: 0x000F8764
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 338056, RefRangeEnd = 338061, XrefRangeStart = 338054, XrefRangeEnd = 338056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetCalibratedAxisValue(float value, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applySensitivity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sensitivityCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_GetCalibratedAxisValue_Public_Static_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000FA5FC File Offset: 0x000F87FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338078, RefRangeEnd = 338079, XrefRangeStart = 338061, XrefRangeEnd = 338078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ApplyRadialDeadZone(float xValue, float yValue, float deadzone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadzone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_ApplyRadialDeadZone_Public_Static_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x000FA658 File Offset: 0x000F8858
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338086, RefRangeEnd = 338089, XrefRangeStart = 338079, XrefRangeEnd = 338086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ApplySensitivity(float value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sensitivityCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_ApplySensitivity_Public_Static_Single_Single_AxisSensitivityType_Single_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x000FA6C4 File Offset: 0x000F88C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338089, XrefRangeEnd = 338093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool alhgfPesQbWJbqlopjoBcDgAZrQD(AnimationCurve A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_alhgfPesQbWJbqlopjoBcDgAZrQD_Private_Static_Boolean_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x000FA708 File Offset: 0x000F8908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338093, XrefRangeEnd = 338096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyRadialSensitivity(ref Vector2 value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivityType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sensitivityCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_ApplyRadialSensitivity_Public_Static_Void_byref_Vector2_AxisSensitivityType_Single_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x000FA768 File Offset: 0x000F8968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338104, RefRangeEnd = 338106, XrefRangeStart = 338096, XrefRangeEnd = 338104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHardwareIdentifierString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_FormatHardwareIdentifierString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000FA7A4 File Offset: 0x000F89A4
		[CallerCount(0)]
		public unsafe static AxisRange InvertAxisRange(AxisRange axisRange)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisRange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_InvertAxisRange_Public_Static_AxisRange_AxisRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000FA7E4 File Offset: 0x000F89E4
		[CallerCount(0)]
		public unsafe static void CompareLastActiveController(Controller controller, ref Controller lastController, ref double lastTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lastController);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastTime;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_CompareLastActiveController_Public_Static_Void_Controller_byref_Controller_byref_Double_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lastController = ((intPtr4 == 0) ? null : new Controller(intPtr4));
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000FA850 File Offset: 0x000F8A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338106, XrefRangeEnd = 338121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMappableControllerElementType(global::Il2CppSystem.Object type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_IsMappableControllerElementType_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x000FA894 File Offset: 0x000F8A94
		[CallerCount(0)]
		public unsafe static bool IsMappableType(ControllerElementType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_IsMappableType_Public_Static_Boolean_ControllerElementType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x000FA8D4 File Offset: 0x000F8AD4
		[CallerCount(0)]
		public unsafe static bool IsMappableType(ControllerTemplateElementType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_IsMappableType_Public_Static_Boolean_ControllerTemplateElementType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000FA914 File Offset: 0x000F8B14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338125, RefRangeEnd = 338128, XrefRangeStart = 338121, XrefRangeEnd = 338125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HandleForced4WayHatsOnUnknownControllers(int direction, ref HatType hatType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hatType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_HandleForced4WayHatsOnUnknownControllers_Public_Static_Boolean_Int32_byref_HatType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x000FA960 File Offset: 0x000F8B60
		[CallerCount(0)]
		public unsafe static float AxisToDigitalValue(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_AxisToDigitalValue_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000FA9A0 File Offset: 0x000F8BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338128, XrefRangeEnd = 338129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float AxisToDigitalValue(float value, float threshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputTools.NativeMethodInfoPtr_AxisToDigitalValue_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00011D17 File Offset: 0x0000FF17
		public InputTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeMethodInfoPtr_TransformAxis2DComponentValue_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedAxisValueClamped_Public_Static_Single_Single_Single_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedAxisValue_Public_Static_Single_Single_Single_Boolean_Boolean_AxisSensitivityType_Single_AnimationCurve_0;

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRadialDeadZone_Public_Static_Vector2_Single_Single_Single_0;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeMethodInfoPtr_ApplySensitivity_Public_Static_Single_Single_AxisSensitivityType_Single_AnimationCurve_0;

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeMethodInfoPtr_alhgfPesQbWJbqlopjoBcDgAZrQD_Private_Static_Boolean_AnimationCurve_0;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRadialSensitivity_Public_Static_Void_byref_Vector2_AxisSensitivityType_Single_AnimationCurve_0;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeMethodInfoPtr_FormatHardwareIdentifierString_Public_Static_String_String_0;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeMethodInfoPtr_InvertAxisRange_Public_Static_AxisRange_AxisRange_0;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeMethodInfoPtr_CompareLastActiveController_Public_Static_Void_Controller_byref_Controller_byref_Double_0;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeMethodInfoPtr_IsMappableControllerElementType_Public_Static_Boolean_Object_0;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeMethodInfoPtr_IsMappableType_Public_Static_Boolean_ControllerElementType_0;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeMethodInfoPtr_IsMappableType_Public_Static_Boolean_ControllerTemplateElementType_0;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeMethodInfoPtr_HandleForced4WayHatsOnUnknownControllers_Public_Static_Boolean_Int32_byref_HatType_0;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeMethodInfoPtr_AxisToDigitalValue_Public_Static_Single_Single_0;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeMethodInfoPtr_AxisToDigitalValue_Public_Static_Single_Single_Single_0;
	}
}
