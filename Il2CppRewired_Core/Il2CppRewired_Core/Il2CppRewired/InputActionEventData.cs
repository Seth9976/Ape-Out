using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x0200000E RID: 14
	public sealed class InputActionEventData : ValueType
	{
		// Token: 0x06000060 RID: 96 RVA: 0x0002D798 File Offset: 0x0002B998
		// Note: this type is marked as 'beforefieldinit'.
		static InputActionEventData()
		{
			Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputActionEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr);
			InputActionEventData.NativeFieldInfoPtr_dWjYIQDdfWSXnQAwfFvdBLWhTKl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, "dWjYIQDdfWSXnQAwfFvdBLWhTKl");
			InputActionEventData.NativeFieldInfoPtr_hiQAqacnKCyEiZlvPcqDYbadgok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, "hiQAqacnKCyEiZlvPcqDYbadgok");
			InputActionEventData.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, "playerId");
			InputActionEventData.NativeFieldInfoPtr_actionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, "actionId");
			InputActionEventData.NativeFieldInfoPtr_updateLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, "updateLoop");
			InputActionEventData.NativeMethodInfoPtr_get_eventType_Public_get_InputActionEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663324);
			InputActionEventData.NativeMethodInfoPtr_set_eventType_Internal_set_Void_InputActionEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663325);
			InputActionEventData.NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663326);
			InputActionEventData.NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663327);
			InputActionEventData.NativeMethodInfoPtr_get_actionDescriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663328);
			InputActionEventData.NativeMethodInfoPtr_GetAxis_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663329);
			InputActionEventData.NativeMethodInfoPtr_GetAxisPrev_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663330);
			InputActionEventData.NativeMethodInfoPtr_GetAxisDelta_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663331);
			InputActionEventData.NativeMethodInfoPtr_GetAxisTimeActive_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663332);
			InputActionEventData.NativeMethodInfoPtr_GetAxisTimeInactive_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663333);
			InputActionEventData.NativeMethodInfoPtr_GetAxisRaw_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663334);
			InputActionEventData.NativeMethodInfoPtr_GetAxisRawDelta_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663335);
			InputActionEventData.NativeMethodInfoPtr_GetAxisRawPrev_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663336);
			InputActionEventData.NativeMethodInfoPtr_GetAxisRawTimeActive_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663337);
			InputActionEventData.NativeMethodInfoPtr_GetAxisRawTimeInactive_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663338);
			InputActionEventData.NativeMethodInfoPtr_GetAxisCoordinateMode_Public_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663339);
			InputActionEventData.NativeMethodInfoPtr_GetAxisCoordinateModePrev_Public_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663340);
			InputActionEventData.NativeMethodInfoPtr_GetAxisRawCoordinateMode_Public_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663341);
			InputActionEventData.NativeMethodInfoPtr_GetAxisRawCoordinateModePrev_Public_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663342);
			InputActionEventData.NativeMethodInfoPtr_GetButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663343);
			InputActionEventData.NativeMethodInfoPtr_GetButtonPrev_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663344);
			InputActionEventData.NativeMethodInfoPtr_GetButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663345);
			InputActionEventData.NativeMethodInfoPtr_GetButtonUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663346);
			InputActionEventData.NativeMethodInfoPtr_GetButtonSinglePressHold_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663347);
			InputActionEventData.NativeMethodInfoPtr_GetButtonSinglePressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663348);
			InputActionEventData.NativeMethodInfoPtr_GetButtonSinglePressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663349);
			InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663350);
			InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663351);
			InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663352);
			InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663353);
			InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663354);
			InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressUp_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663355);
			InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPress_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663356);
			InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPress_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663357);
			InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPressDown_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663358);
			InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPressUp_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663359);
			InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPressUp_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663360);
			InputActionEventData.NativeMethodInfoPtr_GetButtonShortPress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663361);
			InputActionEventData.NativeMethodInfoPtr_GetButtonShortPressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663362);
			InputActionEventData.NativeMethodInfoPtr_GetButtonShortPressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663363);
			InputActionEventData.NativeMethodInfoPtr_GetButtonLongPress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663364);
			InputActionEventData.NativeMethodInfoPtr_GetButtonLongPressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663365);
			InputActionEventData.NativeMethodInfoPtr_GetButtonLongPressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663366);
			InputActionEventData.NativeMethodInfoPtr_GetButtonRepeating_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663367);
			InputActionEventData.NativeMethodInfoPtr_GetButtonTimePressed_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663368);
			InputActionEventData.NativeMethodInfoPtr_GetButtonTimeUnpressed_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663369);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663370);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonPrev_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663371);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663372);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663373);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonSinglePressHold_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663374);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonSinglePressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663375);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonSinglePressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663376);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663377);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressDown_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663378);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressHold_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663379);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressHold_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663380);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663381);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressUp_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663382);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPress_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663383);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPress_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663384);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPressDown_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663385);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPressUp_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663386);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPressUp_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663387);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonShortPress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663388);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonShortPressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663389);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonShortPressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663390);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonLongPress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663391);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonLongPressDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663392);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonLongPressUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663393);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonRepeating_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663394);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimePressed_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663395);
			InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimeUnpressed_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663396);
			InputActionEventData.NativeMethodInfoPtr_GetCurrentInputSources_Public_IList_1_InputActionSourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663397);
			InputActionEventData.NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663398);
			InputActionEventData.NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663399);
			InputActionEventData.NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663400);
			InputActionEventData.NativeMethodInfoPtr__ctor_Internal_Void_GPleNSRyMITftFHQfeXocMLFaCN_Int32_Int32_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr, 100663401);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0002DE44 File Offset: 0x0002C044
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0002DE88 File Offset: 0x0002C088
		public unsafe InputActionEventType eventType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_get_eventType_Public_get_InputActionEventType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_set_eventType_Internal_set_Void_InputActionEventType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0002DECC File Offset: 0x0002C0CC
		public unsafe Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242943, XrefRangeEnd = 242951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0002DF10 File Offset: 0x0002C110
		public unsafe string actionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242951, XrefRangeEnd = 242959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0002DF4C File Offset: 0x0002C14C
		public unsafe string actionDescriptiveName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242959, XrefRangeEnd = 242967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_get_actionDescriptiveName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0002DF88 File Offset: 0x0002C188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242967, XrefRangeEnd = 242969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxis_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0002DFCC File Offset: 0x0002C1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242969, XrefRangeEnd = 242971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisPrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisPrev_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0002E010 File Offset: 0x0002C210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242971, XrefRangeEnd = 242973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisDelta_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0002E054 File Offset: 0x0002C254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242973, XrefRangeEnd = 242975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisTimeActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisTimeActive_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0002E098 File Offset: 0x0002C298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242975, XrefRangeEnd = 242977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisTimeInactive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisTimeInactive_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0002E0DC File Offset: 0x0002C2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242977, XrefRangeEnd = 242979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisRaw_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0002E120 File Offset: 0x0002C320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242979, XrefRangeEnd = 242981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisRawDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisRawDelta_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0002E164 File Offset: 0x0002C364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242981, XrefRangeEnd = 242983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisRawPrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisRawPrev_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242983, XrefRangeEnd = 242985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawTimeActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisRawTimeActive_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0002E1EC File Offset: 0x0002C3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242985, XrefRangeEnd = 242987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetAxisRawTimeInactive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisRawTimeInactive_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0002E230 File Offset: 0x0002C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242987, XrefRangeEnd = 242989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCoordinateMode GetAxisCoordinateMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisCoordinateMode_Public_AxisCoordinateMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0002E274 File Offset: 0x0002C474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242989, XrefRangeEnd = 242991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCoordinateMode GetAxisCoordinateModePrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisCoordinateModePrev_Public_AxisCoordinateMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0002E2B8 File Offset: 0x0002C4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242991, XrefRangeEnd = 242993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCoordinateMode GetAxisRawCoordinateMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisRawCoordinateMode_Public_AxisCoordinateMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0002E2FC File Offset: 0x0002C4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242993, XrefRangeEnd = 242995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCoordinateMode GetAxisRawCoordinateModePrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetAxisRawCoordinateModePrev_Public_AxisCoordinateMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0002E340 File Offset: 0x0002C540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242995, XrefRangeEnd = 242997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButton_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0002E384 File Offset: 0x0002C584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242997, XrefRangeEnd = 242999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonPrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonPrev_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242999, XrefRangeEnd = 243001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0002E40C File Offset: 0x0002C60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243001, XrefRangeEnd = 243003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0002E450 File Offset: 0x0002C650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243003, XrefRangeEnd = 243005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonSinglePressHold()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonSinglePressHold_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0002E494 File Offset: 0x0002C694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243005, XrefRangeEnd = 243007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonSinglePressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonSinglePressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0002E4D8 File Offset: 0x0002C6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243007, XrefRangeEnd = 243009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonSinglePressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonSinglePressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0002E51C File Offset: 0x0002C71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243009, XrefRangeEnd = 243011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDoublePressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0002E560 File Offset: 0x0002C760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243011, XrefRangeEnd = 243013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDoublePressDown(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0002E5B0 File Offset: 0x0002C7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243013, XrefRangeEnd = 243015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDoublePressHold()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243015, XrefRangeEnd = 243017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDoublePressHold(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0002E644 File Offset: 0x0002C844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243017, XrefRangeEnd = 243019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDoublePressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0002E688 File Offset: 0x0002C888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243019, XrefRangeEnd = 243021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonDoublePressUp(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonDoublePressUp_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0002E6D8 File Offset: 0x0002C8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243021, XrefRangeEnd = 243023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonTimedPress(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPress_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0002E728 File Offset: 0x0002C928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243023, XrefRangeEnd = 243025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonTimedPress(float time, float expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPress_Public_Boolean_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0002E784 File Offset: 0x0002C984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243025, XrefRangeEnd = 243027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonTimedPressDown(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPressDown_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0002E7D4 File Offset: 0x0002C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243027, XrefRangeEnd = 243029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonTimedPressUp(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPressUp_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0002E824 File Offset: 0x0002CA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243029, XrefRangeEnd = 243031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonTimedPressUp(float time, float expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonTimedPressUp_Public_Boolean_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0002E880 File Offset: 0x0002CA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243031, XrefRangeEnd = 243033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonShortPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonShortPress_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0002E8C4 File Offset: 0x0002CAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243033, XrefRangeEnd = 243035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonShortPressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonShortPressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0002E908 File Offset: 0x0002CB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243035, XrefRangeEnd = 243037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonShortPressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonShortPressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0002E94C File Offset: 0x0002CB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243037, XrefRangeEnd = 243039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonLongPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonLongPress_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0002E990 File Offset: 0x0002CB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243039, XrefRangeEnd = 243041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonLongPressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonLongPressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0002E9D4 File Offset: 0x0002CBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243041, XrefRangeEnd = 243043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonLongPressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonLongPressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0002EA18 File Offset: 0x0002CC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243043, XrefRangeEnd = 243045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetButtonRepeating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonRepeating_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243045, XrefRangeEnd = 243047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetButtonTimePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonTimePressed_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243047, XrefRangeEnd = 243049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetButtonTimeUnpressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetButtonTimeUnpressed_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0002EAE4 File Offset: 0x0002CCE4
		[CallerCount(0)]
		public unsafe bool GetNegativeButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButton_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0002EB28 File Offset: 0x0002CD28
		[CallerCount(0)]
		public unsafe bool GetNegativeButtonPrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonPrev_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0002EB6C File Offset: 0x0002CD6C
		[CallerCount(0)]
		public unsafe bool GetNegativeButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0002EBB0 File Offset: 0x0002CDB0
		[CallerCount(0)]
		public unsafe bool GetNegativeButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0002EBF4 File Offset: 0x0002CDF4
		[CallerCount(0)]
		public unsafe bool GetNegativeButtonSinglePressHold()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonSinglePressHold_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0002EC38 File Offset: 0x0002CE38
		[CallerCount(0)]
		public unsafe bool GetNegativeButtonSinglePressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonSinglePressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0002EC7C File Offset: 0x0002CE7C
		[CallerCount(0)]
		public unsafe bool GetNegativeButtonSinglePressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonSinglePressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243049, XrefRangeEnd = 243051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonDoublePressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0002ED04 File Offset: 0x0002CF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243051, XrefRangeEnd = 243053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonDoublePressDown(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressDown_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0002ED54 File Offset: 0x0002CF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243053, XrefRangeEnd = 243055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonDoublePressHold()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressHold_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0002ED98 File Offset: 0x0002CF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243055, XrefRangeEnd = 243057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonDoublePressHold(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressHold_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243057, XrefRangeEnd = 243059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonDoublePressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0002EE2C File Offset: 0x0002D02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243059, XrefRangeEnd = 243061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonDoublePressUp(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonDoublePressUp_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0002EE7C File Offset: 0x0002D07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243061, XrefRangeEnd = 243063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonTimedPress(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPress_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0002EECC File Offset: 0x0002D0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243063, XrefRangeEnd = 243065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonTimedPress(float time, float expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPress_Public_Boolean_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0002EF28 File Offset: 0x0002D128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243065, XrefRangeEnd = 243067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonTimedPressDown(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPressDown_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0002EF78 File Offset: 0x0002D178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243067, XrefRangeEnd = 243069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonTimedPressUp(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPressUp_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243069, XrefRangeEnd = 243071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonTimedPressUp(float time, float expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimedPressUp_Public_Boolean_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0002F024 File Offset: 0x0002D224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243071, XrefRangeEnd = 243073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonShortPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonShortPress_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0002F068 File Offset: 0x0002D268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243073, XrefRangeEnd = 243075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonShortPressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonShortPressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0002F0AC File Offset: 0x0002D2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243075, XrefRangeEnd = 243077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonShortPressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonShortPressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0002F0F0 File Offset: 0x0002D2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243077, XrefRangeEnd = 243079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonLongPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonLongPress_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0002F134 File Offset: 0x0002D334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243079, XrefRangeEnd = 243081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonLongPressDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonLongPressDown_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0002F178 File Offset: 0x0002D378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243081, XrefRangeEnd = 243083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNegativeButtonLongPressUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonLongPressUp_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		[CallerCount(0)]
		public unsafe bool GetNegativeButtonRepeating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonRepeating_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0002F200 File Offset: 0x0002D400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243083, XrefRangeEnd = 243084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetNegativeButtonTimePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimePressed_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0002F244 File Offset: 0x0002D444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243084, XrefRangeEnd = 243087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetNegativeButtonTimeUnpressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetNegativeButtonTimeUnpressed_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0002F288 File Offset: 0x0002D488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243087, XrefRangeEnd = 243093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<InputActionSourceData> GetCurrentInputSources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_GetCurrentInputSources_Public_IList_1_InputActionSourceData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<InputActionSourceData>>(intPtr3) : null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0002F2CC File Offset: 0x0002D4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243093, XrefRangeEnd = 243099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentInputSource(ControllerType controllerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_ControllerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0002F31C File Offset: 0x0002D51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243099, XrefRangeEnd = 243105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentInputSource(ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_ControllerType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0002F378 File Offset: 0x0002D578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243105, XrefRangeEnd = 243111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentInputSource(Controller controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0002F3CC File Offset: 0x0002D5CC
		[CallerCount(0)]
		public unsafe InputActionEventData(GPleNSRyMITftFHQfeXocMLFaCN vc, int playerId, int actionId, UpdateLoopType updateLoop)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLoop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionEventData.NativeMethodInfoPtr__ctor_Internal_Void_GPleNSRyMITftFHQfeXocMLFaCN_Int32_Int32_UpdateLoopType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000236B File Offset: 0x0000056B
		public InputActionEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002374 File Offset: 0x00000574
		public InputActionEventData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputActionEventData>.NativeClassPtr))
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0002F448 File Offset: 0x0002D648
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002386 File Offset: 0x00000586
		public unsafe GPleNSRyMITftFHQfeXocMLFaCN dWjYIQDdfWSXnQAwfFvdBLWhTKl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_dWjYIQDdfWSXnQAwfFvdBLWhTKl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPleNSRyMITftFHQfeXocMLFaCN>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_dWjYIQDdfWSXnQAwfFvdBLWhTKl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0002F478 File Offset: 0x0002D678
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000023A5 File Offset: 0x000005A5
		public unsafe InputActionEventType hiQAqacnKCyEiZlvPcqDYbadgok
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_hiQAqacnKCyEiZlvPcqDYbadgok);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_hiQAqacnKCyEiZlvPcqDYbadgok)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0002F4A0 File Offset: 0x0002D6A0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000023C0 File Offset: 0x000005C0
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0002F4C8 File Offset: 0x0002D6C8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000023DB File Offset: 0x000005DB
		public unsafe int actionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_actionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_actionId)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0002F4F0 File Offset: 0x0002D6F0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000023F6 File Offset: 0x000005F6
		public unsafe UpdateLoopType updateLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_updateLoop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionEventData.NativeFieldInfoPtr_updateLoop)) = value;
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_dWjYIQDdfWSXnQAwfFvdBLWhTKl;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_hiQAqacnKCyEiZlvPcqDYbadgok;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_actionId;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_updateLoop;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_eventType_Public_get_InputActionEventType_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_set_eventType_Internal_set_Void_InputActionEventType_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_actionDescriptiveName_Public_get_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Single_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisPrev_Public_Single_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisDelta_Public_Single_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisTimeActive_Public_Double_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisTimeInactive_Public_Double_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Single_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawDelta_Public_Single_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawPrev_Public_Single_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawTimeActive_Public_Double_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawTimeInactive_Public_Double_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisCoordinateMode_Public_AxisCoordinateMode_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisCoordinateModePrev_Public_AxisCoordinateMode_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawCoordinateMode_Public_AxisCoordinateMode_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawCoordinateModePrev_Public_AxisCoordinateMode_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Boolean_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonPrev_Public_Boolean_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Boolean_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonSinglePressHold_Public_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonSinglePressDown_Public_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonSinglePressUp_Public_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressDown_Public_Boolean_Single_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Boolean_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressHold_Public_Boolean_Single_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressUp_Public_Boolean_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDoublePressUp_Public_Boolean_Single_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimedPress_Public_Boolean_Single_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimedPress_Public_Boolean_Single_Single_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimedPressDown_Public_Boolean_Single_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimedPressUp_Public_Boolean_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimedPressUp_Public_Boolean_Single_Single_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonShortPress_Public_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonShortPressDown_Public_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonShortPressUp_Public_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonLongPress_Public_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonLongPressDown_Public_Boolean_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonLongPressUp_Public_Boolean_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonRepeating_Public_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimePressed_Public_Double_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonTimeUnpressed_Public_Double_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButton_Public_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonPrev_Public_Boolean_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDown_Public_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonUp_Public_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonSinglePressHold_Public_Boolean_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonSinglePressDown_Public_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonSinglePressUp_Public_Boolean_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDoublePressDown_Public_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDoublePressDown_Public_Boolean_Single_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDoublePressHold_Public_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDoublePressHold_Public_Boolean_Single_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDoublePressUp_Public_Boolean_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonDoublePressUp_Public_Boolean_Single_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonTimedPress_Public_Boolean_Single_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonTimedPress_Public_Boolean_Single_Single_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonTimedPressDown_Public_Boolean_Single_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonTimedPressUp_Public_Boolean_Single_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonTimedPressUp_Public_Boolean_Single_Single_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonShortPress_Public_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonShortPressDown_Public_Boolean_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonShortPressUp_Public_Boolean_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonLongPress_Public_Boolean_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonLongPressDown_Public_Boolean_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonLongPressUp_Public_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonRepeating_Public_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonTimePressed_Public_Double_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeButtonTimeUnpressed_Public_Double_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentInputSources_Public_IList_1_InputActionSourceData_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_ControllerType_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_ControllerType_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentInputSource_Public_Boolean_Controller_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GPleNSRyMITftFHQfeXocMLFaCN_Int32_Int32_UpdateLoopType_0;
	}
}
