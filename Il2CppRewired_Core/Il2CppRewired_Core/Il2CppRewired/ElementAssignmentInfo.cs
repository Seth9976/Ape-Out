using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000013 RID: 19
	public sealed class ElementAssignmentInfo : global::Il2CppSystem.Object
	{
		// Token: 0x0600015F RID: 351 RVA: 0x00032F28 File Offset: 0x00031128
		// Note: this type is marked as 'beforefieldinit'.
		static ElementAssignmentInfo()
		{
			Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ElementAssignmentInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr);
			ElementAssignmentInfo.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "wQXdFKgaEVDIjgjfyWReFTcBhsTt");
			ElementAssignmentInfo.NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "BSxDqfHZlHRrRHngfWyKkIxRqxNi");
			ElementAssignmentInfo.NativeFieldInfoPtr_jrSDVAeRbXhRPTyAnHuBlnBlMHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "jrSDVAeRbXhRPTyAnHuBlnBlMHA");
			ElementAssignmentInfo.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "LmpWzzgHGngqvdvpwzTKPbztfdh");
			ElementAssignmentInfo.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "fQhXdDzxMfJmFQuoJwqnjqjKizF");
			ElementAssignmentInfo.NativeFieldInfoPtr_OAseHIgxHysjZKwIzDoeQWojzVmH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "OAseHIgxHysjZKwIzDoeQWojzVmH");
			ElementAssignmentInfo.NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "jguJLhLQrutwBBlfOhjkXhNEEqm");
			ElementAssignmentInfo.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "HSNQHCcXgyznRFxfZdJonabrHRG");
			ElementAssignmentInfo.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "wclwqICFwBjaBPhKCYlbyjGpUgp");
			ElementAssignmentInfo.NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, "EvuDNwoPLdXPTXxOXwNeRHfLnDI");
			ElementAssignmentInfo.NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663535);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_action_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663536);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_controller_Public_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663537);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663538);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663539);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663540);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663541);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_elementMap_Public_get_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663542);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663543);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663544);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663545);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663546);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663547);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663548);
			ElementAssignmentInfo.NativeMethodInfoPtr_get_elementDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663549);
			ElementAssignmentInfo.NativeMethodInfoPtr__ctor_Internal_Void_ControllerMap_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr, 100663550);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00033160 File Offset: 0x00031360
		public unsafe Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243343, XrefRangeEnd = 243356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000331A0 File Offset: 0x000313A0
		public unsafe InputAction action
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243356, XrefRangeEnd = 243364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_action_Public_get_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000331E0 File Offset: 0x000313E0
		public unsafe Controller controller
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 243374, RefRangeEnd = 243377, XrefRangeStart = 243364, XrefRangeEnd = 243374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_controller_Public_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00033220 File Offset: 0x00031420
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243377, XrefRangeEnd = 243382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0003325C File Offset: 0x0003145C
		public unsafe int controllerId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243382, XrefRangeEnd = 243387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00033298 File Offset: 0x00031498
		public unsafe ControllerMap controllerMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000332D8 File Offset: 0x000314D8
		public unsafe ControllerElementIdentifier elementIdentifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243387, XrefRangeEnd = 243390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00033318 File Offset: 0x00031518
		public unsafe ActionElementMap elementMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_elementMap_Public_get_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00033358 File Offset: 0x00031558
		public unsafe ControllerElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00033394 File Offset: 0x00031594
		public unsafe Pole axisContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000333D0 File Offset: 0x000315D0
		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0003340C File Offset: 0x0003160C
		public unsafe bool invert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00033448 File Offset: 0x00031648
		public unsafe KeyCode keyCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00033484 File Offset: 0x00031684
		public unsafe ModifierKeyFlags modifierKeyFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000334C0 File Offset: 0x000316C0
		public unsafe string elementDisplayName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 243398, RefRangeEnd = 243400, XrefRangeStart = 243390, XrefRangeEnd = 243398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr_get_elementDisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000334F8 File Offset: 0x000316F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243400, XrefRangeEnd = 243403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementAssignmentInfo(ControllerMap controllerMap, ElementAssignment assignment)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementAssignmentInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementAssignmentInfo.NativeMethodInfoPtr__ctor_Internal_Void_ControllerMap_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002593 File Offset: 0x00000793
		public ElementAssignmentInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00033554 File Offset: 0x00031754
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000259C File Offset: 0x0000079C
		public unsafe ControllerMap wQXdFKgaEVDIjgjfyWReFTcBhsTt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00033584 File Offset: 0x00031784
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000025BB File Offset: 0x000007BB
		public unsafe ControllerElementType BSxDqfHZlHRrRHngfWyKkIxRqxNi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000335AC File Offset: 0x000317AC
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000025D6 File Offset: 0x000007D6
		public unsafe int jrSDVAeRbXhRPTyAnHuBlnBlMHA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_jrSDVAeRbXhRPTyAnHuBlnBlMHA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_jrSDVAeRbXhRPTyAnHuBlnBlMHA)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000335D4 File Offset: 0x000317D4
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000025F1 File Offset: 0x000007F1
		public unsafe int LmpWzzgHGngqvdvpwzTKPbztfdh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000335FC File Offset: 0x000317FC
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000260C File Offset: 0x0000080C
		public unsafe AxisRange fQhXdDzxMfJmFQuoJwqnjqjKizF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00033624 File Offset: 0x00031824
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002627 File Offset: 0x00000827
		public unsafe KeyCode OAseHIgxHysjZKwIzDoeQWojzVmH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_OAseHIgxHysjZKwIzDoeQWojzVmH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_OAseHIgxHysjZKwIzDoeQWojzVmH)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0003364C File Offset: 0x0003184C
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002642 File Offset: 0x00000842
		public unsafe ModifierKeyFlags jguJLhLQrutwBBlfOhjkXhNEEqm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00033674 File Offset: 0x00031874
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000265D File Offset: 0x0000085D
		public unsafe int HSNQHCcXgyznRFxfZdJonabrHRG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0003369C File Offset: 0x0003189C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002678 File Offset: 0x00000878
		public unsafe Pole wclwqICFwBjaBPhKCYlbyjGpUgp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000336C4 File Offset: 0x000318C4
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002693 File Offset: 0x00000893
		public unsafe bool EvuDNwoPLdXPTXxOXwNeRHfLnDI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementAssignmentInfo.NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI)) = value;
			}
		}

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_jrSDVAeRbXhRPTyAnHuBlnBlMHA;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_OAseHIgxHysjZKwIzDoeQWojzVmH;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_jguJLhLQrutwBBlfOhjkXhNEEqm;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_action_Public_get_InputAction_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_get_Controller_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_elementMap_Public_get_ActionElementMap_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_get_invert_Public_get_Boolean_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_get_elementDisplayName_Public_get_String_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ControllerMap_ElementAssignment_0;
	}
}
