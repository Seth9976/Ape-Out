using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x020001DD RID: 477
	public sealed class GamepadTemplate : ControllerTemplate
	{
		// Token: 0x060033DE RID: 13278 RVA: 0x000C5DC4 File Offset: 0x000C3FC4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadTemplate()
		{
			Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "GamepadTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr);
			GamepadTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "typeGuid");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickX");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickY");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickX");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickY");
			GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow1");
			GamepadTemplate.NativeFieldInfoPtr_elementId_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_a");
			GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow2");
			GamepadTemplate.NativeFieldInfoPtr_elementId_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_b");
			GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow3");
			GamepadTemplate.NativeFieldInfoPtr_elementId_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_c");
			GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow1");
			GamepadTemplate.NativeFieldInfoPtr_elementId_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_x");
			GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow2");
			GamepadTemplate.NativeFieldInfoPtr_elementId_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_y");
			GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow3");
			GamepadTemplate.NativeFieldInfoPtr_elementId_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_z");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftShoulder1");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftBumper");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftShoulder2");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftTrigger");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightShoulder1");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightBumper");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightShoulder2");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightTrigger");
			GamepadTemplate.NativeFieldInfoPtr_elementId_center1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center1");
			GamepadTemplate.NativeFieldInfoPtr_elementId_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_back");
			GamepadTemplate.NativeFieldInfoPtr_elementId_center2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center2");
			GamepadTemplate.NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_start");
			GamepadTemplate.NativeFieldInfoPtr_elementId_center3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center3");
			GamepadTemplate.NativeFieldInfoPtr_elementId_guide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_guide");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickButton");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickButton");
			GamepadTemplate.NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadUp");
			GamepadTemplate.NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadRight");
			GamepadTemplate.NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadDown");
			GamepadTemplate.NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadLeft");
			GamepadTemplate.NativeFieldInfoPtr_elementId_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStick");
			GamepadTemplate.NativeFieldInfoPtr_elementId_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStick");
			GamepadTemplate.NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPad");
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667507);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667508);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667509);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667510);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667511);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667512);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667513);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667514);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667515);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667516);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667517);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667518);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667519);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667520);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667521);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667522);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667523);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667524);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667525);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667526);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667527);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667528);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667529);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667530);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667531);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667532);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667533);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667534);
			GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667535);
			GamepadTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100667536);
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x000C636C File Offset: 0x000C456C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86163, XrefRangeEnd = 86166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x060033E0 RID: 13280 RVA: 0x000C63AC File Offset: 0x000C45AC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.a
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86166, XrefRangeEnd = 86169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x000C63EC File Offset: 0x000C45EC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86169, XrefRangeEnd = 86172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x060033E2 RID: 13282 RVA: 0x000C642C File Offset: 0x000C462C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.b
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86172, XrefRangeEnd = 86175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000C646C File Offset: 0x000C466C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86175, XrefRangeEnd = 86178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x000C64AC File Offset: 0x000C46AC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.c
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86178, XrefRangeEnd = 86181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x000C64EC File Offset: 0x000C46EC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86181, XrefRangeEnd = 86184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x060033E6 RID: 13286 RVA: 0x000C652C File Offset: 0x000C472C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.x
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86184, XrefRangeEnd = 86187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x000C656C File Offset: 0x000C476C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86187, XrefRangeEnd = 86190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x000C65AC File Offset: 0x000C47AC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.y
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86190, XrefRangeEnd = 86193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x000C65EC File Offset: 0x000C47EC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86193, XrefRangeEnd = 86196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x000C662C File Offset: 0x000C482C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.z
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86196, XrefRangeEnd = 86199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x000C666C File Offset: 0x000C486C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.leftShoulder1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86199, XrefRangeEnd = 86202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x000C66AC File Offset: 0x000C48AC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.leftBumper
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86202, XrefRangeEnd = 86205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x000C66EC File Offset: 0x000C48EC
		public unsafe IControllerTemplateAxis Rewired.IGamepadTemplate.leftShoulder2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86205, XrefRangeEnd = 86208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x000C672C File Offset: 0x000C492C
		public unsafe IControllerTemplateAxis Rewired.IGamepadTemplate.leftTrigger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86208, XrefRangeEnd = 86211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x000C676C File Offset: 0x000C496C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.rightShoulder1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86211, XrefRangeEnd = 86214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x000C67AC File Offset: 0x000C49AC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.rightBumper
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86214, XrefRangeEnd = 86217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x000C67EC File Offset: 0x000C49EC
		public unsafe IControllerTemplateAxis Rewired.IGamepadTemplate.rightShoulder2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86217, XrefRangeEnd = 86220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x060033F2 RID: 13298 RVA: 0x000C682C File Offset: 0x000C4A2C
		public unsafe IControllerTemplateAxis Rewired.IGamepadTemplate.rightTrigger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86220, XrefRangeEnd = 86223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x000C686C File Offset: 0x000C4A6C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.center1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86223, XrefRangeEnd = 86226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060033F4 RID: 13300 RVA: 0x000C68AC File Offset: 0x000C4AAC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.back
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86226, XrefRangeEnd = 86229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x000C68EC File Offset: 0x000C4AEC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.center2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86229, XrefRangeEnd = 86232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x000C692C File Offset: 0x000C4B2C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.start
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86232, XrefRangeEnd = 86235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x000C696C File Offset: 0x000C4B6C
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.center3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86235, XrefRangeEnd = 86238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x000C69AC File Offset: 0x000C4BAC
		public unsafe IControllerTemplateButton Rewired.IGamepadTemplate.guide
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86238, XrefRangeEnd = 86241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x000C69EC File Offset: 0x000C4BEC
		public unsafe IControllerTemplateThumbStick Rewired.IGamepadTemplate.leftStick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86241, XrefRangeEnd = 86244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr3) : null;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060033FA RID: 13306 RVA: 0x000C6A2C File Offset: 0x000C4C2C
		public unsafe IControllerTemplateThumbStick Rewired.IGamepadTemplate.rightStick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86244, XrefRangeEnd = 86247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr3) : null;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x000C6A6C File Offset: 0x000C4C6C
		public unsafe IControllerTemplateDPad Rewired.IGamepadTemplate.dPad
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86247, XrefRangeEnd = 86255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateDPad>(intPtr3) : null;
			}
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x000C6AAC File Offset: 0x000C4CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86255, XrefRangeEnd = 86264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadTemplate(Object payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00022CE0 File Offset: 0x00020EE0
		public GamepadTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x000C6AF8 File Offset: 0x000C4CF8
		// (set) Token: 0x060033FF RID: 13311 RVA: 0x00022CE9 File Offset: 0x00020EE9
		public unsafe static Guid typeGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&value));
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x000C6B14 File Offset: 0x000C4D14
		// (set) Token: 0x06003401 RID: 13313 RVA: 0x00022CF7 File Offset: 0x00020EF7
		public unsafe static int elementId_leftStickX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickX, (void*)(&value));
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06003402 RID: 13314 RVA: 0x000C6B30 File Offset: 0x000C4D30
		// (set) Token: 0x06003403 RID: 13315 RVA: 0x00022D05 File Offset: 0x00020F05
		public unsafe static int elementId_leftStickY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickY, (void*)(&value));
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x000C6B4C File Offset: 0x000C4D4C
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x00022D13 File Offset: 0x00020F13
		public unsafe static int elementId_rightStickX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickX, (void*)(&value));
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x000C6B68 File Offset: 0x000C4D68
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x00022D21 File Offset: 0x00020F21
		public unsafe static int elementId_rightStickY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickY, (void*)(&value));
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x000C6B84 File Offset: 0x000C4D84
		// (set) Token: 0x06003409 RID: 13321 RVA: 0x00022D2F File Offset: 0x00020F2F
		public unsafe static int elementId_actionBottomRow1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow1, (void*)(&value));
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x000C6BA0 File Offset: 0x000C4DA0
		// (set) Token: 0x0600340B RID: 13323 RVA: 0x00022D3D File Offset: 0x00020F3D
		public unsafe static int elementId_a
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_a, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_a, (void*)(&value));
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600340C RID: 13324 RVA: 0x000C6BBC File Offset: 0x000C4DBC
		// (set) Token: 0x0600340D RID: 13325 RVA: 0x00022D4B File Offset: 0x00020F4B
		public unsafe static int elementId_actionBottomRow2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow2, (void*)(&value));
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x000C6BD8 File Offset: 0x000C4DD8
		// (set) Token: 0x0600340F RID: 13327 RVA: 0x00022D59 File Offset: 0x00020F59
		public unsafe static int elementId_b
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_b, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_b, (void*)(&value));
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x000C6BF4 File Offset: 0x000C4DF4
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x00022D67 File Offset: 0x00020F67
		public unsafe static int elementId_actionBottomRow3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionBottomRow3, (void*)(&value));
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x000C6C10 File Offset: 0x000C4E10
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x00022D75 File Offset: 0x00020F75
		public unsafe static int elementId_c
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_c, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_c, (void*)(&value));
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x000C6C2C File Offset: 0x000C4E2C
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x00022D83 File Offset: 0x00020F83
		public unsafe static int elementId_actionTopRow1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow1, (void*)(&value));
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x000C6C48 File Offset: 0x000C4E48
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x00022D91 File Offset: 0x00020F91
		public unsafe static int elementId_x
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_x, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_x, (void*)(&value));
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x000C6C64 File Offset: 0x000C4E64
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x00022D9F File Offset: 0x00020F9F
		public unsafe static int elementId_actionTopRow2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow2, (void*)(&value));
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x0600341A RID: 13338 RVA: 0x000C6C80 File Offset: 0x000C4E80
		// (set) Token: 0x0600341B RID: 13339 RVA: 0x00022DAD File Offset: 0x00020FAD
		public unsafe static int elementId_y
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_y, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_y, (void*)(&value));
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x0600341C RID: 13340 RVA: 0x000C6C9C File Offset: 0x000C4E9C
		// (set) Token: 0x0600341D RID: 13341 RVA: 0x00022DBB File Offset: 0x00020FBB
		public unsafe static int elementId_actionTopRow3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_actionTopRow3, (void*)(&value));
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x0600341E RID: 13342 RVA: 0x000C6CB8 File Offset: 0x000C4EB8
		// (set) Token: 0x0600341F RID: 13343 RVA: 0x00022DC9 File Offset: 0x00020FC9
		public unsafe static int elementId_z
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_z, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_z, (void*)(&value));
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06003420 RID: 13344 RVA: 0x000C6CD4 File Offset: 0x000C4ED4
		// (set) Token: 0x06003421 RID: 13345 RVA: 0x00022DD7 File Offset: 0x00020FD7
		public unsafe static int elementId_leftShoulder1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder1, (void*)(&value));
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06003422 RID: 13346 RVA: 0x000C6CF0 File Offset: 0x000C4EF0
		// (set) Token: 0x06003423 RID: 13347 RVA: 0x00022DE5 File Offset: 0x00020FE5
		public unsafe static int elementId_leftBumper
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftBumper, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftBumper, (void*)(&value));
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x000C6D0C File Offset: 0x000C4F0C
		// (set) Token: 0x06003425 RID: 13349 RVA: 0x00022DF3 File Offset: 0x00020FF3
		public unsafe static int elementId_leftShoulder2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftShoulder2, (void*)(&value));
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06003426 RID: 13350 RVA: 0x000C6D28 File Offset: 0x000C4F28
		// (set) Token: 0x06003427 RID: 13351 RVA: 0x00022E01 File Offset: 0x00021001
		public unsafe static int elementId_leftTrigger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftTrigger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftTrigger, (void*)(&value));
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06003428 RID: 13352 RVA: 0x000C6D44 File Offset: 0x000C4F44
		// (set) Token: 0x06003429 RID: 13353 RVA: 0x00022E0F File Offset: 0x0002100F
		public unsafe static int elementId_rightShoulder1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder1, (void*)(&value));
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x000C6D60 File Offset: 0x000C4F60
		// (set) Token: 0x0600342B RID: 13355 RVA: 0x00022E1D File Offset: 0x0002101D
		public unsafe static int elementId_rightBumper
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightBumper, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightBumper, (void*)(&value));
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x000C6D7C File Offset: 0x000C4F7C
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x00022E2B File Offset: 0x0002102B
		public unsafe static int elementId_rightShoulder2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightShoulder2, (void*)(&value));
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x000C6D98 File Offset: 0x000C4F98
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x00022E39 File Offset: 0x00021039
		public unsafe static int elementId_rightTrigger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightTrigger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightTrigger, (void*)(&value));
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x000C6DB4 File Offset: 0x000C4FB4
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x00022E47 File Offset: 0x00021047
		public unsafe static int elementId_center1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center1, (void*)(&value));
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x000C6DD0 File Offset: 0x000C4FD0
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x00022E55 File Offset: 0x00021055
		public unsafe static int elementId_back
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_back, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_back, (void*)(&value));
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x000C6DEC File Offset: 0x000C4FEC
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x00022E63 File Offset: 0x00021063
		public unsafe static int elementId_center2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center2, (void*)(&value));
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x000C6E08 File Offset: 0x000C5008
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x00022E71 File Offset: 0x00021071
		public unsafe static int elementId_start
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_start, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_start, (void*)(&value));
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x000C6E24 File Offset: 0x000C5024
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x00022E7F File Offset: 0x0002107F
		public unsafe static int elementId_center3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_center3, (void*)(&value));
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x000C6E40 File Offset: 0x000C5040
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x00022E8D File Offset: 0x0002108D
		public unsafe static int elementId_guide
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_guide, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_guide, (void*)(&value));
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x000C6E5C File Offset: 0x000C505C
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x00022E9B File Offset: 0x0002109B
		public unsafe static int elementId_leftStickButton
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickButton, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStickButton, (void*)(&value));
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x000C6E78 File Offset: 0x000C5078
		// (set) Token: 0x0600343F RID: 13375 RVA: 0x00022EA9 File Offset: 0x000210A9
		public unsafe static int elementId_rightStickButton
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickButton, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStickButton, (void*)(&value));
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06003440 RID: 13376 RVA: 0x000C6E94 File Offset: 0x000C5094
		// (set) Token: 0x06003441 RID: 13377 RVA: 0x00022EB7 File Offset: 0x000210B7
		public unsafe static int elementId_dPadUp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*)(&value));
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x000C6EB0 File Offset: 0x000C50B0
		// (set) Token: 0x06003443 RID: 13379 RVA: 0x00022EC5 File Offset: 0x000210C5
		public unsafe static int elementId_dPadRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*)(&value));
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x000C6ECC File Offset: 0x000C50CC
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x00022ED3 File Offset: 0x000210D3
		public unsafe static int elementId_dPadDown
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*)(&value));
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x000C6EE8 File Offset: 0x000C50E8
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x00022EE1 File Offset: 0x000210E1
		public unsafe static int elementId_dPadLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*)(&value));
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x000C6F04 File Offset: 0x000C5104
		// (set) Token: 0x06003449 RID: 13385 RVA: 0x00022EEF File Offset: 0x000210EF
		public unsafe static int elementId_leftStick
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_leftStick, (void*)(&value));
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x000C6F20 File Offset: 0x000C5120
		// (set) Token: 0x0600344B RID: 13387 RVA: 0x00022EFD File Offset: 0x000210FD
		public unsafe static int elementId_rightStick
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_rightStick, (void*)(&value));
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x000C6F3C File Offset: 0x000C513C
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x00022F0B File Offset: 0x0002110B
		public unsafe static int elementId_dPad
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPad, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTemplate.NativeFieldInfoPtr_elementId_dPad, (void*)(&value));
			}
		}

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeFieldInfoPtr_typeGuid;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftStickX;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftStickY;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightStickX;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightStickY;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeFieldInfoPtr_elementId_actionBottomRow1;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeFieldInfoPtr_elementId_a;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeFieldInfoPtr_elementId_actionBottomRow2;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeFieldInfoPtr_elementId_b;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeFieldInfoPtr_elementId_actionBottomRow3;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeFieldInfoPtr_elementId_c;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeFieldInfoPtr_elementId_actionTopRow1;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeFieldInfoPtr_elementId_x;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeFieldInfoPtr_elementId_actionTopRow2;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeFieldInfoPtr_elementId_y;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeFieldInfoPtr_elementId_actionTopRow3;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeFieldInfoPtr_elementId_z;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftShoulder1;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftBumper;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftShoulder2;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftTrigger;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightShoulder1;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightBumper;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightShoulder2;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightTrigger;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeFieldInfoPtr_elementId_center1;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeFieldInfoPtr_elementId_back;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeFieldInfoPtr_elementId_center2;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeFieldInfoPtr_elementId_start;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeFieldInfoPtr_elementId_center3;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeFieldInfoPtr_elementId_guide;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftStickButton;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightStickButton;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadUp;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadRight;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadDown;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadLeft;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftStick;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightStick;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPad;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
	}
}
