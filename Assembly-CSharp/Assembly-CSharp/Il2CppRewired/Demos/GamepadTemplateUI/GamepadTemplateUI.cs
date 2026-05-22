using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Demos.GamepadTemplateUI
{
	// Token: 0x0200021F RID: 543
	public class GamepadTemplateUI : MonoBehaviour
	{
		// Token: 0x060041F0 RID: 16880 RVA: 0x000F54C4 File Offset: 0x000F36C4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadTemplateUI()
		{
			Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.GamepadTemplateUI", "GamepadTemplateUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr);
			GamepadTemplateUI.NativeFieldInfoPtr_stickRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "stickRadius");
			GamepadTemplateUI.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "playerId");
			GamepadTemplateUI.NativeFieldInfoPtr_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "leftStick");
			GamepadTemplateUI.NativeFieldInfoPtr_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "rightStick");
			GamepadTemplateUI.NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "leftStickX");
			GamepadTemplateUI.NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "leftStickY");
			GamepadTemplateUI.NativeFieldInfoPtr_leftStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "leftStickButton");
			GamepadTemplateUI.NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "rightStickX");
			GamepadTemplateUI.NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "rightStickY");
			GamepadTemplateUI.NativeFieldInfoPtr_rightStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "rightStickButton");
			GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "actionBottomRow1");
			GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "actionBottomRow2");
			GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "actionBottomRow3");
			GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "actionTopRow1");
			GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "actionTopRow2");
			GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "actionTopRow3");
			GamepadTemplateUI.NativeFieldInfoPtr_leftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "leftShoulder");
			GamepadTemplateUI.NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "leftTrigger");
			GamepadTemplateUI.NativeFieldInfoPtr_rightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "rightShoulder");
			GamepadTemplateUI.NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "rightTrigger");
			GamepadTemplateUI.NativeFieldInfoPtr_center1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "center1");
			GamepadTemplateUI.NativeFieldInfoPtr_center2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "center2");
			GamepadTemplateUI.NativeFieldInfoPtr_center3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "center3");
			GamepadTemplateUI.NativeFieldInfoPtr_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "dPadUp");
			GamepadTemplateUI.NativeFieldInfoPtr_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "dPadRight");
			GamepadTemplateUI.NativeFieldInfoPtr_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "dPadDown");
			GamepadTemplateUI.NativeFieldInfoPtr_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "dPadLeft");
			GamepadTemplateUI.NativeFieldInfoPtr__uiElementsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "_uiElementsArray");
			GamepadTemplateUI.NativeFieldInfoPtr__uiElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "_uiElements");
			GamepadTemplateUI.NativeFieldInfoPtr__tempTargetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "_tempTargetList");
			GamepadTemplateUI.NativeFieldInfoPtr__sticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "_sticks");
			GamepadTemplateUI.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669743);
			GamepadTemplateUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669744);
			GamepadTemplateUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669745);
			GamepadTemplateUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669746);
			GamepadTemplateUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669747);
			GamepadTemplateUI.NativeMethodInfoPtr_DrawActiveElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669748);
			GamepadTemplateUI.NativeMethodInfoPtr_ActivateElements_Private_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669749);
			GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669750);
			GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_Player_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669751);
			GamepadTemplateUI.NativeMethodInfoPtr_DrawLabel_Private_Void_ControllerUIElement_InputAction_ControllerMap_IControllerTemplate_IControllerTemplateElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669752);
			GamepadTemplateUI.NativeMethodInfoPtr_GetStick_Private_Stick_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669753);
			GamepadTemplateUI.NativeMethodInfoPtr_OnControllerConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669754);
			GamepadTemplateUI.NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669755);
			GamepadTemplateUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, 100669756);
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x000F5878 File Offset: 0x000F3A78
		public unsafe Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106070, XrefRangeEnd = 106076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x000F58B8 File Offset: 0x000F3AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106076, XrefRangeEnd = 106259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x000F58EC File Offset: 0x000F3AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106259, XrefRangeEnd = 106264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x000F5920 File Offset: 0x000F3B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106264, XrefRangeEnd = 106283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x000F5954 File Offset: 0x000F3B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106283, XrefRangeEnd = 106288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x000F5988 File Offset: 0x000F3B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106329, RefRangeEnd = 106330, XrefRangeStart = 106288, XrefRangeEnd = 106329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawActiveElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_DrawActiveElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x000F59BC File Offset: 0x000F3BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106382, RefRangeEnd = 106383, XrefRangeStart = 106330, XrefRangeEnd = 106382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateElements(Player player, int actionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_ActivateElements_Private_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x000F5A0C File Offset: 0x000F3C0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106405, RefRangeEnd = 106408, XrefRangeStart = 106383, XrefRangeEnd = 106405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x000F5A40 File Offset: 0x000F3C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106430, RefRangeEnd = 106431, XrefRangeStart = 106408, XrefRangeEnd = 106430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLabels(Player player, InputAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_DrawLabels_Private_Void_Player_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x000F5A94 File Offset: 0x000F3C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106453, RefRangeEnd = 106454, XrefRangeStart = 106431, XrefRangeEnd = 106453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(template);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_DrawLabel_Private_Void_ControllerUIElement_InputAction_ControllerMap_IControllerTemplate_IControllerTemplateElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x000F5B20 File Offset: 0x000F3D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106470, RefRangeEnd = 106471, XrefRangeStart = 106454, XrefRangeEnd = 106470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadTemplateUI.Stick GetStick(int elementId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_GetStick_Private_Stick_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadTemplateUI.Stick>(intPtr3) : null;
			}
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x000F5B6C File Offset: 0x000F3D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106471, XrefRangeEnd = 106472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_OnControllerConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x000F5BB0 File Offset: 0x000F3DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x000F5BF4 File Offset: 0x000F3DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106472, XrefRangeEnd = 106488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadTemplateUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x00028352 File Offset: 0x00026552
		public GamepadTemplateUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x000F5C30 File Offset: 0x000F3E30
		// (set) Token: 0x06004201 RID: 16897 RVA: 0x0002835B File Offset: 0x0002655B
		public unsafe static float stickRadius
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplateUI.NativeFieldInfoPtr_stickRadius, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplateUI.NativeFieldInfoPtr_stickRadius, (void*)(&value));
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x000F5C4C File Offset: 0x000F3E4C
		// (set) Token: 0x06004203 RID: 16899 RVA: 0x00028369 File Offset: 0x00026569
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06004204 RID: 16900 RVA: 0x000F5C74 File Offset: 0x000F3E74
		// (set) Token: 0x06004205 RID: 16901 RVA: 0x00028384 File Offset: 0x00026584
		public unsafe RectTransform leftStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x000F5CA4 File Offset: 0x000F3EA4
		// (set) Token: 0x06004207 RID: 16903 RVA: 0x000283A3 File Offset: 0x000265A3
		public unsafe RectTransform rightStick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06004208 RID: 16904 RVA: 0x000F5CD4 File Offset: 0x000F3ED4
		// (set) Token: 0x06004209 RID: 16905 RVA: 0x000283C2 File Offset: 0x000265C2
		public unsafe ControllerUIElement leftStickX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStickX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStickX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x000F5D04 File Offset: 0x000F3F04
		// (set) Token: 0x0600420B RID: 16907 RVA: 0x000283E1 File Offset: 0x000265E1
		public unsafe ControllerUIElement leftStickY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStickY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStickY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x000F5D34 File Offset: 0x000F3F34
		// (set) Token: 0x0600420D RID: 16909 RVA: 0x00028400 File Offset: 0x00026600
		public unsafe ControllerUIElement leftStickButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStickButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftStickButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x000F5D64 File Offset: 0x000F3F64
		// (set) Token: 0x0600420F RID: 16911 RVA: 0x0002841F File Offset: 0x0002661F
		public unsafe ControllerUIElement rightStickX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStickX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStickX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x000F5D94 File Offset: 0x000F3F94
		// (set) Token: 0x06004211 RID: 16913 RVA: 0x0002843E File Offset: 0x0002663E
		public unsafe ControllerUIElement rightStickY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStickY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStickY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x000F5DC4 File Offset: 0x000F3FC4
		// (set) Token: 0x06004213 RID: 16915 RVA: 0x0002845D File Offset: 0x0002665D
		public unsafe ControllerUIElement rightStickButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStickButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightStickButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x000F5DF4 File Offset: 0x000F3FF4
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x0002847C File Offset: 0x0002667C
		public unsafe ControllerUIElement actionBottomRow1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x000F5E24 File Offset: 0x000F4024
		// (set) Token: 0x06004217 RID: 16919 RVA: 0x0002849B File Offset: 0x0002669B
		public unsafe ControllerUIElement actionBottomRow2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x000F5E54 File Offset: 0x000F4054
		// (set) Token: 0x06004219 RID: 16921 RVA: 0x000284BA File Offset: 0x000266BA
		public unsafe ControllerUIElement actionBottomRow3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionBottomRow3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x000F5E84 File Offset: 0x000F4084
		// (set) Token: 0x0600421B RID: 16923 RVA: 0x000284D9 File Offset: 0x000266D9
		public unsafe ControllerUIElement actionTopRow1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600421C RID: 16924 RVA: 0x000F5EB4 File Offset: 0x000F40B4
		// (set) Token: 0x0600421D RID: 16925 RVA: 0x000284F8 File Offset: 0x000266F8
		public unsafe ControllerUIElement actionTopRow2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x000F5EE4 File Offset: 0x000F40E4
		// (set) Token: 0x0600421F RID: 16927 RVA: 0x00028517 File Offset: 0x00026717
		public unsafe ControllerUIElement actionTopRow3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_actionTopRow3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x000F5F14 File Offset: 0x000F4114
		// (set) Token: 0x06004221 RID: 16929 RVA: 0x00028536 File Offset: 0x00026736
		public unsafe ControllerUIElement leftShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x000F5F44 File Offset: 0x000F4144
		// (set) Token: 0x06004223 RID: 16931 RVA: 0x00028555 File Offset: 0x00026755
		public unsafe ControllerUIElement leftTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_leftTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x000F5F74 File Offset: 0x000F4174
		// (set) Token: 0x06004225 RID: 16933 RVA: 0x00028574 File Offset: 0x00026774
		public unsafe ControllerUIElement rightShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x000F5FA4 File Offset: 0x000F41A4
		// (set) Token: 0x06004227 RID: 16935 RVA: 0x00028593 File Offset: 0x00026793
		public unsafe ControllerUIElement rightTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_rightTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x000F5FD4 File Offset: 0x000F41D4
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x000285B2 File Offset: 0x000267B2
		public unsafe ControllerUIElement center1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_center1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_center1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x000F6004 File Offset: 0x000F4204
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x000285D1 File Offset: 0x000267D1
		public unsafe ControllerUIElement center2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_center2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_center2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x000F6034 File Offset: 0x000F4234
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x000285F0 File Offset: 0x000267F0
		public unsafe ControllerUIElement center3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_center3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_center3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x000F6064 File Offset: 0x000F4264
		// (set) Token: 0x0600422F RID: 16943 RVA: 0x0002860F File Offset: 0x0002680F
		public unsafe ControllerUIElement dPadUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x000F6094 File Offset: 0x000F4294
		// (set) Token: 0x06004231 RID: 16945 RVA: 0x0002862E File Offset: 0x0002682E
		public unsafe ControllerUIElement dPadRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x000F60C4 File Offset: 0x000F42C4
		// (set) Token: 0x06004233 RID: 16947 RVA: 0x0002864D File Offset: 0x0002684D
		public unsafe ControllerUIElement dPadDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x000F60F4 File Offset: 0x000F42F4
		// (set) Token: 0x06004235 RID: 16949 RVA: 0x0002866C File Offset: 0x0002686C
		public unsafe ControllerUIElement dPadLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr_dPadLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x000F6124 File Offset: 0x000F4324
		// (set) Token: 0x06004237 RID: 16951 RVA: 0x0002868B File Offset: 0x0002688B
		public unsafe Il2CppReferenceArray<GamepadTemplateUI.UIElement> _uiElementsArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__uiElementsArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GamepadTemplateUI.UIElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__uiElementsArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x000F6154 File Offset: 0x000F4354
		// (set) Token: 0x06004239 RID: 16953 RVA: 0x000286AA File Offset: 0x000268AA
		public unsafe Dictionary<int, ControllerUIElement> _uiElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__uiElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ControllerUIElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__uiElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x000F6184 File Offset: 0x000F4384
		// (set) Token: 0x0600423B RID: 16955 RVA: 0x000286C9 File Offset: 0x000268C9
		public unsafe IList<ControllerTemplateElementTarget> _tempTargetList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__tempTargetList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ControllerTemplateElementTarget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__tempTargetList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x000F61B4 File Offset: 0x000F43B4
		// (set) Token: 0x0600423D RID: 16957 RVA: 0x000286E8 File Offset: 0x000268E8
		public unsafe Il2CppReferenceArray<GamepadTemplateUI.Stick> _sticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__sticks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GamepadTemplateUI.Stick>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.NativeFieldInfoPtr__sticks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeFieldInfoPtr_stickRadius;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeFieldInfoPtr_leftStick;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeFieldInfoPtr_rightStick;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeFieldInfoPtr_leftStickX;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeFieldInfoPtr_leftStickY;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeFieldInfoPtr_leftStickButton;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeFieldInfoPtr_rightStickX;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeFieldInfoPtr_rightStickY;

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeFieldInfoPtr_rightStickButton;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeFieldInfoPtr_actionBottomRow1;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeFieldInfoPtr_actionBottomRow2;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeFieldInfoPtr_actionBottomRow3;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeFieldInfoPtr_actionTopRow1;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeFieldInfoPtr_actionTopRow2;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeFieldInfoPtr_actionTopRow3;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeFieldInfoPtr_leftShoulder;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeFieldInfoPtr_leftTrigger;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeFieldInfoPtr_rightShoulder;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeFieldInfoPtr_rightTrigger;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeFieldInfoPtr_center1;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeFieldInfoPtr_center2;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeFieldInfoPtr_center3;

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeFieldInfoPtr_dPadUp;

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeFieldInfoPtr_dPadRight;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeFieldInfoPtr_dPadDown;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeFieldInfoPtr_dPadLeft;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeFieldInfoPtr__uiElementsArray;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeFieldInfoPtr__uiElements;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeFieldInfoPtr__tempTargetList;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeFieldInfoPtr__sticks;

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeMethodInfoPtr_DrawActiveElements_Private_Void_0;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeMethodInfoPtr_ActivateElements_Private_Void_Player_Int32_0;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeMethodInfoPtr_DrawLabels_Private_Void_0;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeMethodInfoPtr_DrawLabels_Private_Void_Player_InputAction_0;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeMethodInfoPtr_DrawLabel_Private_Void_ControllerUIElement_InputAction_ControllerMap_IControllerTemplate_IControllerTemplateElement_0;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_GetStick_Private_Stick_Int32_0;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerConnected_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003B3 RID: 947
		public class Stick : global::Il2CppSystem.Object
		{
			// Token: 0x06005978 RID: 22904 RVA: 0x00143BF0 File Offset: 0x00141DF0
			// Note: this type is marked as 'beforefieldinit'.
			static Stick()
			{
				Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "Stick");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr);
				GamepadTemplateUI.Stick.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, "_transform");
				GamepadTemplateUI.Stick.NativeFieldInfoPtr__origPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, "_origPosition");
				GamepadTemplateUI.Stick.NativeFieldInfoPtr__xAxisElementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, "_xAxisElementId");
				GamepadTemplateUI.Stick.NativeFieldInfoPtr__yAxisElementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, "_yAxisElementId");
				GamepadTemplateUI.Stick.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, 100669757);
				GamepadTemplateUI.Stick.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, 100669758);
				GamepadTemplateUI.Stick.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, 100669759);
				GamepadTemplateUI.Stick.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, 100669760);
				GamepadTemplateUI.Stick.NativeMethodInfoPtr_ContainsElement_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, 100669761);
				GamepadTemplateUI.Stick.NativeMethodInfoPtr_SetAxisPosition_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr, 100669762);
			}

			// Token: 0x170020B7 RID: 8375
			// (get) Token: 0x06005979 RID: 22905 RVA: 0x00143CE4 File Offset: 0x00141EE4
			// (set) Token: 0x0600597A RID: 22906 RVA: 0x00143D20 File Offset: 0x00141F20
			public unsafe Vector2 position
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105950, XrefRangeEnd = 105963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.Stick.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105963, XrefRangeEnd = 105977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.Stick.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600597B RID: 22907 RVA: 0x00143D60 File Offset: 0x00141F60
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 105990, RefRangeEnd = 105992, XrefRangeStart = 105977, XrefRangeEnd = 105990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadTemplateUI.Stick>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAxisElementId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAxisElementId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.Stick.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600597C RID: 22908 RVA: 0x00143DC8 File Offset: 0x00141FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105992, XrefRangeEnd = 106006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.Stick.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600597D RID: 22909 RVA: 0x00143DFC File Offset: 0x00141FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106006, XrefRangeEnd = 106018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ContainsElement(int elementId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref elementId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.Stick.NativeMethodInfoPtr_ContainsElement_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600597E RID: 22910 RVA: 0x00143E48 File Offset: 0x00142048
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106067, RefRangeEnd = 106068, XrefRangeStart = 106018, XrefRangeEnd = 106067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetAxisPosition(int elementId, float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref elementId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.Stick.NativeMethodInfoPtr_SetAxisPosition_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600597F RID: 22911 RVA: 0x000333FC File Offset: 0x000315FC
			public Stick(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020B3 RID: 8371
			// (get) Token: 0x06005980 RID: 22912 RVA: 0x00143E94 File Offset: 0x00142094
			// (set) Token: 0x06005981 RID: 22913 RVA: 0x00033405 File Offset: 0x00031605
			public unsafe RectTransform _transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020B4 RID: 8372
			// (get) Token: 0x06005982 RID: 22914 RVA: 0x00143EC4 File Offset: 0x001420C4
			// (set) Token: 0x06005983 RID: 22915 RVA: 0x00033424 File Offset: 0x00031624
			public unsafe Vector2 _origPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__origPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__origPosition)) = value;
				}
			}

			// Token: 0x170020B5 RID: 8373
			// (get) Token: 0x06005984 RID: 22916 RVA: 0x00143EEC File Offset: 0x001420EC
			// (set) Token: 0x06005985 RID: 22917 RVA: 0x0003343F File Offset: 0x0003163F
			public unsafe int _xAxisElementId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__xAxisElementId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__xAxisElementId)) = value;
				}
			}

			// Token: 0x170020B6 RID: 8374
			// (get) Token: 0x06005986 RID: 22918 RVA: 0x00143F14 File Offset: 0x00142114
			// (set) Token: 0x06005987 RID: 22919 RVA: 0x0003345A File Offset: 0x0003165A
			public unsafe int _yAxisElementId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__yAxisElementId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.Stick.NativeFieldInfoPtr__yAxisElementId)) = value;
				}
			}

			// Token: 0x04003B69 RID: 15209
			private static readonly IntPtr NativeFieldInfoPtr__transform;

			// Token: 0x04003B6A RID: 15210
			private static readonly IntPtr NativeFieldInfoPtr__origPosition;

			// Token: 0x04003B6B RID: 15211
			private static readonly IntPtr NativeFieldInfoPtr__xAxisElementId;

			// Token: 0x04003B6C RID: 15212
			private static readonly IntPtr NativeFieldInfoPtr__yAxisElementId;

			// Token: 0x04003B6D RID: 15213
			private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

			// Token: 0x04003B6E RID: 15214
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

			// Token: 0x04003B6F RID: 15215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Int32_Int32_0;

			// Token: 0x04003B70 RID: 15216
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x04003B71 RID: 15217
			private static readonly IntPtr NativeMethodInfoPtr_ContainsElement_Public_Boolean_Int32_0;

			// Token: 0x04003B72 RID: 15218
			private static readonly IntPtr NativeMethodInfoPtr_SetAxisPosition_Public_Void_Int32_Single_0;
		}

		// Token: 0x020003B4 RID: 948
		public class UIElement : global::Il2CppSystem.Object
		{
			// Token: 0x06005988 RID: 22920 RVA: 0x00143F3C File Offset: 0x0014213C
			// Note: this type is marked as 'beforefieldinit'.
			static UIElement()
			{
				Il2CppClassPointerStore<GamepadTemplateUI.UIElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamepadTemplateUI>.NativeClassPtr, "UIElement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTemplateUI.UIElement>.NativeClassPtr);
				GamepadTemplateUI.UIElement.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI.UIElement>.NativeClassPtr, "id");
				GamepadTemplateUI.UIElement.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplateUI.UIElement>.NativeClassPtr, "element");
				GamepadTemplateUI.UIElement.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplateUI.UIElement>.NativeClassPtr, 100669763);
			}

			// Token: 0x06005989 RID: 22921 RVA: 0x00143FA4 File Offset: 0x001421A4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIElement(int id, ControllerUIElement element)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadTemplateUI.UIElement>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplateUI.UIElement.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600598A RID: 22922 RVA: 0x00033475 File Offset: 0x00031675
			public UIElement(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020B8 RID: 8376
			// (get) Token: 0x0600598B RID: 22923 RVA: 0x00144000 File Offset: 0x00142200
			// (set) Token: 0x0600598C RID: 22924 RVA: 0x0003347E File Offset: 0x0003167E
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.UIElement.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.UIElement.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x170020B9 RID: 8377
			// (get) Token: 0x0600598D RID: 22925 RVA: 0x00144028 File Offset: 0x00142228
			// (set) Token: 0x0600598E RID: 22926 RVA: 0x00033499 File Offset: 0x00031699
			public unsafe ControllerUIElement element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.UIElement.NativeFieldInfoPtr_element);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerUIElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadTemplateUI.UIElement.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B73 RID: 15219
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003B74 RID: 15220
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x04003B75 RID: 15221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ControllerUIElement_0;
		}
	}
}
