using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x02000154 RID: 340
	[Serializable]
	public sealed class ControllerMap_Editor : Object
	{
		// Token: 0x060025C5 RID: 9669 RVA: 0x000C1464 File Offset: 0x000BF664
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMap_Editor()
		{
			Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "ControllerMap_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr);
			ControllerMap_Editor.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "id");
			ControllerMap_Editor.NativeFieldInfoPtr_categoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "categoryId");
			ControllerMap_Editor.NativeFieldInfoPtr_layoutId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "layoutId");
			ControllerMap_Editor.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "name");
			ControllerMap_Editor.NativeFieldInfoPtr_hardwareGuidString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "hardwareGuidString");
			ControllerMap_Editor.NativeFieldInfoPtr_customControllerUid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "customControllerUid");
			ControllerMap_Editor.NativeFieldInfoPtr_actionElementMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "actionElementMaps");
			ControllerMap_Editor.NativeMethodInfoPtr_get_ActionElementMaps_Public_get_IEnumerable_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671534);
			ControllerMap_Editor.NativeMethodInfoPtr_get_hardwareGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671535);
			ControllerMap_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671536);
			ControllerMap_Editor.NativeMethodInfoPtr_Clone_Public_ControllerMap_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671537);
			ControllerMap_Editor.NativeMethodInfoPtr_GetActionElementMap_Public_ActionElementMap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671538);
			ControllerMap_Editor.NativeMethodInfoPtr_kjfXfcjKefEcpTANjtkrwdobXxE_Internal_JoystickMap_Func_2_Int32_Boolean_HardwareControllerMapIdentifier_HardwareJoystickMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671539);
			ControllerMap_Editor.NativeMethodInfoPtr_nRZWvuziHzPIUERJGNaBGmtvFRJ_Internal_KeyboardMap_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671540);
			ControllerMap_Editor.NativeMethodInfoPtr_uiDSLuukDvPmNwTIYGoWFttqFtB_Internal_MouseMap_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671541);
			ControllerMap_Editor.NativeMethodInfoPtr_QiERDyXxBpNAEXItTLrqWjjnEdS_Internal_CustomControllerMap_Func_2_Int32_Boolean_CustomController_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671542);
			ControllerMap_Editor.NativeMethodInfoPtr_ppxXrzMcJzHhtHppAOnMJAjsYpi_Internal_ControllerTemplateMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671543);
			ControllerMap_Editor.NativeMethodInfoPtr_aPtWnJGBwOopLdHpuFhrUartqkH_Private_Void_Func_2_Int32_Boolean_ControllerMap_HardwareControllerMapIdentifier_HardwareJoystickMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671544);
			ControllerMap_Editor.NativeMethodInfoPtr_xfYaTcCnacxLSvEVrmQpUQtPNJgc_Private_Void_Func_2_Int32_Boolean_InputSource_CustomControllerMap_CustomController_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671545);
			ControllerMap_Editor.NativeMethodInfoPtr_CreateElementsFromHardwareMap_Public_Void_IHardwareControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671546);
			ControllerMap_Editor.NativeMethodInfoPtr_CreateElementsFromHardwareMap_Public_Void_CustomController_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671547);
			ControllerMap_Editor.NativeMethodInfoPtr_AddActionElementMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671548);
			ControllerMap_Editor.NativeMethodInfoPtr_InsertActionElementMap_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671549);
			ControllerMap_Editor.NativeMethodInfoPtr_DeleteActionElementMap_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671550);
			ControllerMap_Editor.NativeMethodInfoPtr_ReorderActionElementMap_Public_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671551);
			ControllerMap_Editor.NativeMethodInfoPtr_DuplicateActionElementMap_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671552);
			ControllerMap_Editor.NativeMethodInfoPtr_JfUyPpCBzuFPbhoZsrZwSTjttwi_Private_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, 100671553);
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x000C16B0 File Offset: 0x000BF8B0
		public unsafe IEnumerable<ActionElementMap> ActionElementMaps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294210, XrefRangeEnd = 294215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_get_ActionElementMaps_Public_get_IEnumerable_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActionElementMap>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000C16F0 File Offset: 0x000BF8F0
		public unsafe Guid hardwareGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294215, XrefRangeEnd = 294219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_get_hardwareGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000C172C File Offset: 0x000BF92C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 294225, RefRangeEnd = 294232, XrefRangeStart = 294219, XrefRangeEnd = 294225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMap_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000C1768 File Offset: 0x000BF968
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294255, RefRangeEnd = 294260, XrefRangeStart = 294232, XrefRangeEnd = 294255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMap_Editor Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_Clone_Public_ControllerMap_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap_Editor>(intPtr3) : null;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000C17A8 File Offset: 0x000BF9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294260, XrefRangeEnd = 294262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap GetActionElementMap(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_GetActionElementMap_Public_ActionElementMap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000C17F4 File Offset: 0x000BF9F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294267, RefRangeEnd = 294268, XrefRangeStart = 294262, XrefRangeEnd = 294267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoystickMap kjfXfcjKefEcpTANjtkrwdobXxE(Func<int, bool> A_1, HardwareControllerMapIdentifier A_2, HardwareJoystickMap A_3, bool A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_kjfXfcjKefEcpTANjtkrwdobXxE_Internal_JoystickMap_Func_2_Int32_Boolean_HardwareControllerMapIdentifier_HardwareJoystickMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JoystickMap>(intPtr3) : null;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000C1874 File Offset: 0x000BFA74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294276, RefRangeEnd = 294278, XrefRangeStart = 294268, XrefRangeEnd = 294276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardMap nRZWvuziHzPIUERJGNaBGmtvFRJ(Func<int, bool> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_nRZWvuziHzPIUERJGNaBGmtvFRJ_Internal_KeyboardMap_Func_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyboardMap>(intPtr3) : null;
			}
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x000C18C4 File Offset: 0x000BFAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294283, RefRangeEnd = 294285, XrefRangeStart = 294278, XrefRangeEnd = 294283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMap uiDSLuukDvPmNwTIYGoWFttqFtB(Func<int, bool> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_uiDSLuukDvPmNwTIYGoWFttqFtB_Internal_MouseMap_Func_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseMap>(intPtr3) : null;
			}
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x000C1914 File Offset: 0x000BFB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294285, XrefRangeEnd = 294290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerMap QiERDyXxBpNAEXItTLrqWjjnEdS(Func<int, bool> A_1, CustomController_Editor A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_QiERDyXxBpNAEXItTLrqWjjnEdS_Internal_CustomControllerMap_Func_2_Int32_Boolean_CustomController_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerMap>(intPtr3) : null;
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x000C1978 File Offset: 0x000BFB78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294320, RefRangeEnd = 294323, XrefRangeStart = 294290, XrefRangeEnd = 294320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateMap ppxXrzMcJzHhtHppAOnMJAjsYpi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_ppxXrzMcJzHhtHppAOnMJAjsYpi_Internal_ControllerTemplateMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateMap>(intPtr3) : null;
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x000C19B8 File Offset: 0x000BFBB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294356, RefRangeEnd = 294359, XrefRangeStart = 294323, XrefRangeEnd = 294356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void aPtWnJGBwOopLdHpuFhrUartqkH(Func<int, bool> A_1, ControllerMap A_2, HardwareControllerMapIdentifier A_3, HardwareJoystickMap A_4, bool A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_aPtWnJGBwOopLdHpuFhrUartqkH_Private_Void_Func_2_Int32_Boolean_ControllerMap_HardwareControllerMapIdentifier_HardwareJoystickMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x000C1A3C File Offset: 0x000BFC3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294378, RefRangeEnd = 294380, XrefRangeStart = 294359, XrefRangeEnd = 294378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void xfYaTcCnacxLSvEVrmQpUQtPNJgc(Func<int, bool> A_1, InputSource A_2, CustomControllerMap A_3, CustomController_Editor A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_xfYaTcCnacxLSvEVrmQpUQtPNJgc_Private_Void_Func_2_Int32_Boolean_InputSource_CustomControllerMap_CustomController_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x000C1AB4 File Offset: 0x000BFCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294380, XrefRangeEnd = 294437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateElementsFromHardwareMap(IHardwareControllerMap hardwareJoystickMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hardwareJoystickMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_CreateElementsFromHardwareMap_Public_Void_IHardwareControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x000C1AF8 File Offset: 0x000BFCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294437, XrefRangeEnd = 294486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateElementsFromHardwareMap(CustomController_Editor customController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_CreateElementsFromHardwareMap_Public_Void_CustomController_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000C1B3C File Offset: 0x000BFD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294486, XrefRangeEnd = 294494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionElementMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_AddActionElementMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000C1B70 File Offset: 0x000BFD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294494, XrefRangeEnd = 294506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertActionElementMap(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_InsertActionElementMap_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x000C1BB0 File Offset: 0x000BFDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294506, XrefRangeEnd = 294516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteActionElementMap(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_DeleteActionElementMap_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x000C1BF0 File Offset: 0x000BFDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294516, XrefRangeEnd = 294519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReorderActionElementMap(int index, bool offsetDown, bool offsetNow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDown;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetNow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_ReorderActionElementMap_Public_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x000C1C58 File Offset: 0x000BFE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294519, XrefRangeEnd = 294529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DuplicateActionElementMap(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_DuplicateActionElementMap_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000C1C98 File Offset: 0x000BFE98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294533, RefRangeEnd = 294534, XrefRangeStart = 294529, XrefRangeEnd = 294533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap JfUyPpCBzuFPbhoZsrZwSTjttwi()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.NativeMethodInfoPtr_JfUyPpCBzuFPbhoZsrZwSTjttwi_Private_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		public ControllerMap_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x000C1CD8 File Offset: 0x000BFED8
		// (set) Token: 0x060025DC RID: 9692 RVA: 0x0000EA85 File Offset: 0x0000CC85
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x000C1D00 File Offset: 0x000BFF00
		// (set) Token: 0x060025DE RID: 9694 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public unsafe int categoryId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_categoryId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_categoryId)) = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000C1D28 File Offset: 0x000BFF28
		// (set) Token: 0x060025E0 RID: 9696 RVA: 0x0000EABB File Offset: 0x0000CCBB
		public unsafe int layoutId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_layoutId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_layoutId)) = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000C1D50 File Offset: 0x000BFF50
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x0000EAD6 File Offset: 0x0000CCD6
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000C1D78 File Offset: 0x000BFF78
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x0000EAF5 File Offset: 0x0000CCF5
		public unsafe string hardwareGuidString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_hardwareGuidString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_hardwareGuidString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x000C1DA0 File Offset: 0x000BFFA0
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x0000EB14 File Offset: 0x0000CD14
		public unsafe int customControllerUid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_customControllerUid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_customControllerUid)) = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000C1DC8 File Offset: 0x000BFFC8
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x0000EB2F File Offset: 0x0000CD2F
		public unsafe List<ActionElementMap> actionElementMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_actionElementMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ActionElementMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.NativeFieldInfoPtr_actionElementMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeFieldInfoPtr_categoryId;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeFieldInfoPtr_layoutId;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeFieldInfoPtr_hardwareGuidString;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeFieldInfoPtr_customControllerUid;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeFieldInfoPtr_actionElementMaps;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionElementMaps_Public_get_IEnumerable_1_ActionElementMap_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareGuid_Public_get_Guid_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_ControllerMap_Editor_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_GetActionElementMap_Public_ActionElementMap_Int32_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_kjfXfcjKefEcpTANjtkrwdobXxE_Internal_JoystickMap_Func_2_Int32_Boolean_HardwareControllerMapIdentifier_HardwareJoystickMap_Boolean_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_nRZWvuziHzPIUERJGNaBGmtvFRJ_Internal_KeyboardMap_Func_2_Int32_Boolean_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_uiDSLuukDvPmNwTIYGoWFttqFtB_Internal_MouseMap_Func_2_Int32_Boolean_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_QiERDyXxBpNAEXItTLrqWjjnEdS_Internal_CustomControllerMap_Func_2_Int32_Boolean_CustomController_Editor_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_ppxXrzMcJzHhtHppAOnMJAjsYpi_Internal_ControllerTemplateMap_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr_aPtWnJGBwOopLdHpuFhrUartqkH_Private_Void_Func_2_Int32_Boolean_ControllerMap_HardwareControllerMapIdentifier_HardwareJoystickMap_Boolean_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr_xfYaTcCnacxLSvEVrmQpUQtPNJgc_Private_Void_Func_2_Int32_Boolean_InputSource_CustomControllerMap_CustomController_Editor_0;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_CreateElementsFromHardwareMap_Public_Void_IHardwareControllerMap_0;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr_CreateElementsFromHardwareMap_Public_Void_CustomController_Editor_0;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeMethodInfoPtr_AddActionElementMap_Public_Void_0;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeMethodInfoPtr_InsertActionElementMap_Public_Void_Int32_0;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeMethodInfoPtr_DeleteActionElementMap_Public_Void_Int32_0;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeMethodInfoPtr_ReorderActionElementMap_Public_Boolean_Int32_Boolean_Boolean_0;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateActionElementMap_Public_Void_Int32_0;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeMethodInfoPtr_JfUyPpCBzuFPbhoZsrZwSTjttwi_Private_ActionElementMap_0;

		// Token: 0x0200037B RID: 891
		public sealed class WXmbjUddkLnPyAFCsoSEZnmSoSf : Object
		{
			// Token: 0x060049CF RID: 18895 RVA: 0x00152578 File Offset: 0x00150778
			// Note: this type is marked as 'beforefieldinit'.
			static WXmbjUddkLnPyAFCsoSEZnmSoSf()
			{
				Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMap_Editor>.NativeClassPtr, "WXmbjUddkLnPyAFCsoSEZnmSoSf");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, "NuVnrlTavvGYEgMZhwgjSLwilSSG");
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, "NsLEWIBMBVGSwXePCZaULRETkiZ");
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, "wNSJsQuOfbQPTCkuxzljZjIjmsi");
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, "HbFBVXVdulMdGSmvVCgeOcAyoyn");
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, "kUBcJcFfgoKKiApkBmiZbFhcTlkZ");
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671554);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671555);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671556);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ActionElementMap__get_Current_Private_Virtual_Final_New_get_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671557);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671558);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671559);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671560);
				ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr, 100671561);
			}

			// Token: 0x060049D0 RID: 18896 RVA: 0x001526A8 File Offset: 0x001508A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294199, XrefRangeEnd = 294202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ActionElementMap> System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ActionElementMap>>(intPtr3) : null;
			}

			// Token: 0x060049D1 RID: 18897 RVA: 0x001526E8 File Offset: 0x001508E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060049D2 RID: 18898 RVA: 0x00152728 File Offset: 0x00150928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294202, XrefRangeEnd = 294205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001728 RID: 5928
			// (get) Token: 0x060049D3 RID: 18899 RVA: 0x00152764 File Offset: 0x00150964
			public unsafe ActionElementMap HnmefHEcpMxYCxZVnKBQTKoYjyM
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ActionElementMap__get_Current_Private_Virtual_Final_New_get_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
				}
			}

			// Token: 0x060049D4 RID: 18900 RVA: 0x001527A4 File Offset: 0x001509A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294205, XrefRangeEnd = 294210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049D5 RID: 18901 RVA: 0x001527D8 File Offset: 0x001509D8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001729 RID: 5929
			// (get) Token: 0x060049D6 RID: 18902 RVA: 0x0015280C File Offset: 0x00150A0C
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060049D7 RID: 18903 RVA: 0x0015284C File Offset: 0x00150A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WXmbjUddkLnPyAFCsoSEZnmSoSf(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060049D8 RID: 18904 RVA: 0x0001B20E File Offset: 0x0001940E
			public WXmbjUddkLnPyAFCsoSEZnmSoSf(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001723 RID: 5923
			// (get) Token: 0x060049D9 RID: 18905 RVA: 0x00152894 File Offset: 0x00150A94
			// (set) Token: 0x060049DA RID: 18906 RVA: 0x0001B217 File Offset: 0x00019417
			public unsafe ActionElementMap NuVnrlTavvGYEgMZhwgjSLwilSSG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001724 RID: 5924
			// (get) Token: 0x060049DB RID: 18907 RVA: 0x001528C4 File Offset: 0x00150AC4
			// (set) Token: 0x060049DC RID: 18908 RVA: 0x0001B236 File Offset: 0x00019436
			public unsafe int NsLEWIBMBVGSwXePCZaULRETkiZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ)) = value;
				}
			}

			// Token: 0x17001725 RID: 5925
			// (get) Token: 0x060049DD RID: 18909 RVA: 0x001528EC File Offset: 0x00150AEC
			// (set) Token: 0x060049DE RID: 18910 RVA: 0x0001B251 File Offset: 0x00019451
			public unsafe int wNSJsQuOfbQPTCkuxzljZjIjmsi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi)) = value;
				}
			}

			// Token: 0x17001726 RID: 5926
			// (get) Token: 0x060049DF RID: 18911 RVA: 0x00152914 File Offset: 0x00150B14
			// (set) Token: 0x060049E0 RID: 18912 RVA: 0x0001B26C File Offset: 0x0001946C
			public unsafe ControllerMap_Editor HbFBVXVdulMdGSmvVCgeOcAyoyn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap_Editor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001727 RID: 5927
			// (get) Token: 0x060049E1 RID: 18913 RVA: 0x00152944 File Offset: 0x00150B44
			// (set) Token: 0x060049E2 RID: 18914 RVA: 0x0001B28B File Offset: 0x0001948B
			public unsafe int kUBcJcFfgoKKiApkBmiZbFhcTlkZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMap_Editor.WXmbjUddkLnPyAFCsoSEZnmSoSf.NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ)) = value;
				}
			}

			// Token: 0x04003BC1 RID: 15297
			private static readonly IntPtr NativeFieldInfoPtr_NuVnrlTavvGYEgMZhwgjSLwilSSG;

			// Token: 0x04003BC2 RID: 15298
			private static readonly IntPtr NativeFieldInfoPtr_NsLEWIBMBVGSwXePCZaULRETkiZ;

			// Token: 0x04003BC3 RID: 15299
			private static readonly IntPtr NativeFieldInfoPtr_wNSJsQuOfbQPTCkuxzljZjIjmsi;

			// Token: 0x04003BC4 RID: 15300
			private static readonly IntPtr NativeFieldInfoPtr_HbFBVXVdulMdGSmvVCgeOcAyoyn;

			// Token: 0x04003BC5 RID: 15301
			private static readonly IntPtr NativeFieldInfoPtr_kUBcJcFfgoKKiApkBmiZbFhcTlkZ;

			// Token: 0x04003BC6 RID: 15302
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ActionElementMap__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ActionElementMap_0;

			// Token: 0x04003BC7 RID: 15303
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003BC8 RID: 15304
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003BC9 RID: 15305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ActionElementMap__get_Current_Private_Virtual_Final_New_get_ActionElementMap_0;

			// Token: 0x04003BCA RID: 15306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BCB RID: 15307
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BCC RID: 15308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003BCD RID: 15309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
