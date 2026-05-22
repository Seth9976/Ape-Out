using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppRewired.Components
{
	// Token: 0x02000057 RID: 87
	[Serializable]
	public sealed class PlayerMouse : PlayerController
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x000567CC File Offset: 0x000549CC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMouse()
		{
			Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Components", "PlayerMouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr);
			PlayerMouse.NativeFieldInfoPtr__defaultToCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "_defaultToCenter");
			PlayerMouse.NativeFieldInfoPtr__pointerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "_pointerSpeed");
			PlayerMouse.NativeFieldInfoPtr__useHardwarePointerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "_useHardwarePointerPosition");
			PlayerMouse.NativeFieldInfoPtr__clampToMovementArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "_clampToMovementArea");
			PlayerMouse.NativeFieldInfoPtr__movementArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "_movementArea");
			PlayerMouse.NativeFieldInfoPtr__movementAreaUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "_movementAreaUnit");
			PlayerMouse.NativeFieldInfoPtr__onScreenPositionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "_onScreenPositionChanged");
			PlayerMouse.NativeMethodInfoPtr_get_source_Private_get_PlayerMouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665070);
			PlayerMouse.NativeMethodInfoPtr_get_defaultToCenter_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665071);
			PlayerMouse.NativeMethodInfoPtr_set_defaultToCenter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665072);
			PlayerMouse.NativeMethodInfoPtr_get_clampToMovementArea_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665073);
			PlayerMouse.NativeMethodInfoPtr_set_clampToMovementArea_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665074);
			PlayerMouse.NativeMethodInfoPtr_get_movementArea_Public_Virtual_Final_New_get_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665075);
			PlayerMouse.NativeMethodInfoPtr_set_movementArea_Public_Virtual_Final_New_set_Void_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665076);
			PlayerMouse.NativeMethodInfoPtr_get_movementAreaUnit_Public_Virtual_Final_New_get_MovementAreaUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665077);
			PlayerMouse.NativeMethodInfoPtr_set_movementAreaUnit_Public_Virtual_Final_New_set_Void_MovementAreaUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665078);
			PlayerMouse.NativeMethodInfoPtr_get_screenPosition_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665079);
			PlayerMouse.NativeMethodInfoPtr_set_screenPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665080);
			PlayerMouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665081);
			PlayerMouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665082);
			PlayerMouse.NativeMethodInfoPtr_get_xAxis_Public_Virtual_Final_New_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665083);
			PlayerMouse.NativeMethodInfoPtr_get_yAxis_Public_Virtual_Final_New_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665084);
			PlayerMouse.NativeMethodInfoPtr_get_wheel_Public_Virtual_Final_New_get_MouseWheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665085);
			PlayerMouse.NativeMethodInfoPtr_get_leftButton_Public_Virtual_Final_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665086);
			PlayerMouse.NativeMethodInfoPtr_get_rightButton_Public_Virtual_Final_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665087);
			PlayerMouse.NativeMethodInfoPtr_get_middleButton_Public_Virtual_Final_New_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665088);
			PlayerMouse.NativeMethodInfoPtr_get_pointerSpeed_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665089);
			PlayerMouse.NativeMethodInfoPtr_set_pointerSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665090);
			PlayerMouse.NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665091);
			PlayerMouse.NativeMethodInfoPtr_set_useHardwarePointerPosition_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665092);
			PlayerMouse.NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665093);
			PlayerMouse.NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665094);
			PlayerMouse.NativeMethodInfoPtr_OnValidated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665095);
			PlayerMouse.NativeMethodInfoPtr_OnReset_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665096);
			PlayerMouse.NativeMethodInfoPtr_CreateSource_Protected_Virtual_PlayerController_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665097);
			PlayerMouse.NativeMethodInfoPtr_Deinitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665098);
			PlayerMouse.NativeMethodInfoPtr_Subscribe_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665099);
			PlayerMouse.NativeMethodInfoPtr_Unsubscribe_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665100);
			PlayerMouse.NativeMethodInfoPtr_HpMGqAommMgbVcbRvjhzRHgsqRNd_Internal_Virtual_List_1_ElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665101);
			PlayerMouse.NativeMethodInfoPtr_SrnbWjqleOJDkExdjOYPdiQxVFZ_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665102);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665103);
			PlayerMouse.NativeMethodInfoPtr_NrvxhgnjcDmjeIdQqgpndmCbjwif_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665104);
			PlayerMouse.NativeMethodInfoPtr_mphxJIfWAzWREMypyzmjIRAgXnl_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665105);
			PlayerMouse.NativeMethodInfoPtr_OQVCCOBKjGgchxHuRHIxRFtYhxhN_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665106);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665107);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665108);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665109);
			PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665110);
			PlayerMouse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665111);
			PlayerMouse.NativeMethodInfoPtr_Rewired_IPlayerController_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665112);
			PlayerMouse.NativeMethodInfoPtr_Rewired_IPlayerController_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, 100665113);
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00056BF8 File Offset: 0x00054DF8
		public new unsafe PlayerMouse source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251287, XrefRangeEnd = 251290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_source_Private_get_PlayerMouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMouse>(intPtr3) : null;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00056C38 File Offset: 0x00054E38
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00056C74 File Offset: 0x00054E74
		public unsafe bool defaultToCenter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251290, XrefRangeEnd = 251295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_defaultToCenter_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251295, XrefRangeEnd = 251305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_defaultToCenter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00056CB4 File Offset: 0x00054EB4
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00056CF0 File Offset: 0x00054EF0
		public unsafe bool clampToMovementArea
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251305, XrefRangeEnd = 251309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_clampToMovementArea_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251309, XrefRangeEnd = 251318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_clampToMovementArea_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00056D30 File Offset: 0x00054F30
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00056D6C File Offset: 0x00054F6C
		public unsafe ScreenRect movementArea
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251318, XrefRangeEnd = 251323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_movementArea_Public_Virtual_Final_New_get_ScreenRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 251345, RefRangeEnd = 251346, XrefRangeStart = 251323, XrefRangeEnd = 251345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_movementArea_Public_Virtual_Final_New_set_Void_ScreenRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00056DAC File Offset: 0x00054FAC
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00056DE8 File Offset: 0x00054FE8
		public unsafe PlayerMouse.MovementAreaUnit movementAreaUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251346, XrefRangeEnd = 251351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_movementAreaUnit_Public_Virtual_Final_New_get_MovementAreaUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251351, XrefRangeEnd = 251361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_movementAreaUnit_Public_Virtual_Final_New_set_Void_MovementAreaUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00056E28 File Offset: 0x00055028
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00056E64 File Offset: 0x00055064
		public unsafe Vector2 screenPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251361, XrefRangeEnd = 251368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_screenPosition_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251368, XrefRangeEnd = 251375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_screenPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00056EA4 File Offset: 0x000550A4
		public unsafe Vector2 screenPositionPrev
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251375, XrefRangeEnd = 251384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00056EE0 File Offset: 0x000550E0
		public unsafe Vector2 screenPositionDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251384, XrefRangeEnd = 251393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00056F1C File Offset: 0x0005511C
		public unsafe PlayerController.MouseAxis xAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251393, XrefRangeEnd = 251398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_xAxis_Public_Virtual_Final_New_get_MouseAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00056F5C File Offset: 0x0005515C
		public unsafe PlayerController.MouseAxis yAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251398, XrefRangeEnd = 251403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_yAxis_Public_Virtual_Final_New_get_MouseAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00056F9C File Offset: 0x0005519C
		public unsafe PlayerController.MouseWheel wheel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251403, XrefRangeEnd = 251408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_wheel_Public_Virtual_Final_New_get_MouseWheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseWheel>(intPtr3) : null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00056FDC File Offset: 0x000551DC
		public unsafe PlayerController.Button leftButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251408, XrefRangeEnd = 251413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_leftButton_Public_Virtual_Final_New_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0005701C File Offset: 0x0005521C
		public unsafe PlayerController.Button rightButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251413, XrefRangeEnd = 251418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_rightButton_Public_Virtual_Final_New_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0005705C File Offset: 0x0005525C
		public unsafe PlayerController.Button middleButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251418, XrefRangeEnd = 251423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_middleButton_Public_Virtual_Final_New_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Button>(intPtr3) : null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0005709C File Offset: 0x0005529C
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x000570D8 File Offset: 0x000552D8
		public unsafe float pointerSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251423, XrefRangeEnd = 251428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_pointerSpeed_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251428, XrefRangeEnd = 251437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_pointerSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00057118 File Offset: 0x00055318
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00057154 File Offset: 0x00055354
		public unsafe bool useHardwarePointerPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251437, XrefRangeEnd = 251445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251445, XrefRangeEnd = 251454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_set_useHardwarePointerPosition_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00057194 File Offset: 0x00055394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251454, XrefRangeEnd = 251459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ScreenPositionChangedEvent(Action<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000571D8 File Offset: 0x000553D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251459, XrefRangeEnd = 251464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ScreenPositionChangedEvent(Action<Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0005721C File Offset: 0x0005541C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251464, XrefRangeEnd = 251518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_OnValidated_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00057250 File Offset: 0x00055450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251518, XrefRangeEnd = 251524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_OnReset_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00057284 File Offset: 0x00055484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251524, XrefRangeEnd = 251572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlayerController CreateSource(global::Il2CppSystem.Object args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_CreateSource_Protected_Virtual_PlayerController_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000572D4 File Offset: 0x000554D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251572, XrefRangeEnd = 251573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Deinitialize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00057308 File Offset: 0x00055508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251573, XrefRangeEnd = 251587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Subscribe_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0005733C File Offset: 0x0005553C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251587, XrefRangeEnd = 251601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unsubscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Unsubscribe_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00057370 File Offset: 0x00055570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251601, XrefRangeEnd = 251692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<PlayerController.ElementInfo> HpMGqAommMgbVcbRvjhzRHgsqRNd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_HpMGqAommMgbVcbRvjhzRHgsqRNd_Internal_Virtual_List_1_ElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerController.ElementInfo>>(intPtr3) : null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000573B0 File Offset: 0x000555B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251692, XrefRangeEnd = 251705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SrnbWjqleOJDkExdjOYPdiQxVFZ(Vector2 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_SrnbWjqleOJDkExdjOYPdiQxVFZ_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000573F0 File Offset: 0x000555F0
		public unsafe bool Rewired.UI.IMouseInputSource.enabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251705, XrefRangeEnd = 251712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0005742C File Offset: 0x0005562C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251712, XrefRangeEnd = 251719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NrvxhgnjcDmjeIdQqgpndmCbjwif(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_NrvxhgnjcDmjeIdQqgpndmCbjwif_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00057478 File Offset: 0x00055678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251719, XrefRangeEnd = 251726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool mphxJIfWAzWREMypyzmjIRAgXnl(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_mphxJIfWAzWREMypyzmjIRAgXnl_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000574C4 File Offset: 0x000556C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251726, XrefRangeEnd = 251733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OQVCCOBKjGgchxHuRHIxRFtYhxhN(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_OQVCCOBKjGgchxHuRHIxRFtYhxhN_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00057510 File Offset: 0x00055710
		public unsafe Vector2 Rewired.UI.IMouseInputSource.screenPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251733, XrefRangeEnd = 251742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0005754C File Offset: 0x0005574C
		public unsafe Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251742, XrefRangeEnd = 251751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00057588 File Offset: 0x00055788
		public unsafe Vector2 Rewired.UI.IMouseInputSource.wheelDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251751, XrefRangeEnd = 251760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x000575C4 File Offset: 0x000557C4
		public unsafe bool Rewired.UI.IMouseInputSource.locked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251760, XrefRangeEnd = 251767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00057600 File Offset: 0x00055800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251767, XrefRangeEnd = 251773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMouse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0005763C File Offset: 0x0005583C
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00057678 File Offset: 0x00055878
		public new unsafe bool Rewired.IPlayerController.enabled
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 251250, RefRangeEnd = 251258, XrefRangeStart = 251250, XrefRangeEnd = 251258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_IPlayerController_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 251262, RefRangeEnd = 251285, XrefRangeStart = 251262, XrefRangeEnd = 251285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.NativeMethodInfoPtr_Rewired_IPlayerController_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00005706 File Offset: 0x00003906
		public PlayerMouse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000576B8 File Offset: 0x000558B8
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0000570F File Offset: 0x0000390F
		public unsafe bool _defaultToCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__defaultToCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__defaultToCenter)) = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000576E0 File Offset: 0x000558E0
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x0000572A File Offset: 0x0000392A
		public unsafe float _pointerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__pointerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__pointerSpeed)) = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00057708 File Offset: 0x00055908
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00005745 File Offset: 0x00003945
		public unsafe bool _useHardwarePointerPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__useHardwarePointerPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__useHardwarePointerPosition)) = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00057730 File Offset: 0x00055930
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00005760 File Offset: 0x00003960
		public unsafe bool _clampToMovementArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__clampToMovementArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__clampToMovementArea)) = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00057758 File Offset: 0x00055958
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0000577B File Offset: 0x0000397B
		public unsafe Rect _movementArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__movementArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__movementArea)) = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00057780 File Offset: 0x00055980
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00005796 File Offset: 0x00003996
		public unsafe PlayerMouse.MovementAreaUnit _movementAreaUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__movementAreaUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__movementAreaUnit)) = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000577A8 File Offset: 0x000559A8
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x000057B1 File Offset: 0x000039B1
		public unsafe PlayerMouse.ScreenPositionChangedHandler _onScreenPositionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__onScreenPositionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMouse.ScreenPositionChangedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMouse.NativeFieldInfoPtr__onScreenPositionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeFieldInfoPtr__defaultToCenter;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr__pointerSpeed;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr__useHardwarePointerPosition;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr__clampToMovementArea;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr__movementArea;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeFieldInfoPtr__movementAreaUnit;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeFieldInfoPtr__onScreenPositionChanged;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Private_get_PlayerMouse_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultToCenter_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultToCenter_Public_set_Void_Boolean_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_clampToMovementArea_Public_get_Boolean_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_set_clampToMovementArea_Public_set_Void_Boolean_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_get_movementArea_Public_Virtual_Final_New_get_ScreenRect_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_set_movementArea_Public_Virtual_Final_New_set_Void_ScreenRect_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_get_movementAreaUnit_Public_Virtual_Final_New_get_MovementAreaUnit_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_set_movementAreaUnit_Public_Virtual_Final_New_set_Void_MovementAreaUnit_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPosition_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_set_screenPosition_Public_set_Void_Vector2_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionPrev_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionDelta_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_Virtual_Final_New_get_MouseAxis_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_Virtual_Final_New_get_MouseAxis_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_get_wheel_Public_Virtual_Final_New_get_MouseWheel_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_leftButton_Public_Virtual_Final_New_get_Button_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_get_rightButton_Public_Virtual_Final_New_get_Button_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_get_middleButton_Public_Virtual_Final_New_get_Button_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerSpeed_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerSpeed_Public_set_Void_Single_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_useHardwarePointerPosition_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_set_useHardwarePointerPosition_Public_set_Void_Boolean_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_add_ScreenPositionChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Vector2_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_remove_ScreenPositionChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Vector2_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_OnValidated_Protected_Virtual_Void_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_OnReset_Protected_Virtual_Void_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_CreateSource_Protected_Virtual_PlayerController_Object_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Protected_Virtual_Void_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Protected_Virtual_Void_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Protected_Virtual_Void_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_HpMGqAommMgbVcbRvjhzRHgsqRNd_Internal_Virtual_List_1_ElementInfo_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_SrnbWjqleOJDkExdjOYPdiQxVFZ_Private_Void_Vector2_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_NrvxhgnjcDmjeIdQqgpndmCbjwif_Private_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_mphxJIfWAzWREMypyzmjIRAgXnl_Private_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_OQVCCOBKjGgchxHuRHIxRFtYhxhN_Private_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IPlayerController_get_enabled_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IPlayerController_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x02000275 RID: 629
		[Serializable]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2>
		{
			// Token: 0x060039A9 RID: 14761 RVA: 0x00014604 File Offset: 0x00012804
			// Note: this type is marked as 'beforefieldinit'.
			static ScreenPositionChangedHandler()
			{
				Il2CppClassPointerStore<PlayerMouse.ScreenPositionChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMouse>.NativeClassPtr, "ScreenPositionChangedHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMouse.ScreenPositionChangedHandler>.NativeClassPtr);
				PlayerMouse.ScreenPositionChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouse.ScreenPositionChangedHandler>.NativeClassPtr, 100665114);
			}

			// Token: 0x060039AA RID: 14762 RVA: 0x00118000 File Offset: 0x00116200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251285, XrefRangeEnd = 251287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScreenPositionChangedHandler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMouse.ScreenPositionChangedHandler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMouse.ScreenPositionChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039AB RID: 14763 RVA: 0x00014638 File Offset: 0x00012838
			public ScreenPositionChangedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003096 RID: 12438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
