using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x020001DE RID: 478
	public sealed class RacingWheelTemplate : ControllerTemplate
	{
		// Token: 0x0600344E RID: 13390 RVA: 0x000C6F58 File Offset: 0x000C5158
		// Note: this type is marked as 'beforefieldinit'.
		static RacingWheelTemplate()
		{
			Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "RacingWheelTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr);
			RacingWheelTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "typeGuid");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheel");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_accelerator");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_brake");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_clutch");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shiftDown");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shiftUp");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton1");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton2");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton3");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton4");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton5");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton6");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton7");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton8");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton9");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton10");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton1");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton2");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton3");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton4");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton5");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton6");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton7");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton8");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton9");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton10");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter1");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter2");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter3");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter4");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter5");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter6");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter7");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter8");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter9");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter10");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_reverseGear");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_select");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_start");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_systemButton");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_horn");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadUp");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadRight");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadDown");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadLeft");
			RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPad");
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667538);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667539);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667540);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667541);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667542);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667543);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667544);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667545);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667546);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667547);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667548);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667549);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667550);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667551);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667552);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667553);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667554);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667555);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667556);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667557);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667558);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667559);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667560);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667561);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667562);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667563);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667564);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667565);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667566);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667567);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667568);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667569);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667570);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667571);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667572);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667573);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667574);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667575);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667576);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667577);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667578);
			RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667579);
			RacingWheelTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100667580);
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x000C7690 File Offset: 0x000C5890
		public unsafe IControllerTemplateAxis Rewired.IRacingWheelTemplate.wheel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86264, XrefRangeEnd = 86267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x000C76D0 File Offset: 0x000C58D0
		public unsafe IControllerTemplateAxis Rewired.IRacingWheelTemplate.accelerator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86267, XrefRangeEnd = 86270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x000C7710 File Offset: 0x000C5910
		public unsafe IControllerTemplateAxis Rewired.IRacingWheelTemplate.brake
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86270, XrefRangeEnd = 86273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x000C7750 File Offset: 0x000C5950
		public unsafe IControllerTemplateAxis Rewired.IRacingWheelTemplate.clutch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86273, XrefRangeEnd = 86276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x000C7790 File Offset: 0x000C5990
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftDown
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86276, XrefRangeEnd = 86279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x000C77D0 File Offset: 0x000C59D0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftUp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86279, XrefRangeEnd = 86282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x000C7810 File Offset: 0x000C5A10
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86282, XrefRangeEnd = 86285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x000C7850 File Offset: 0x000C5A50
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86285, XrefRangeEnd = 86288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x000C7890 File Offset: 0x000C5A90
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86288, XrefRangeEnd = 86291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06003458 RID: 13400 RVA: 0x000C78D0 File Offset: 0x000C5AD0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86291, XrefRangeEnd = 86294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x000C7910 File Offset: 0x000C5B10
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86294, XrefRangeEnd = 86297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x000C7950 File Offset: 0x000C5B50
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86297, XrefRangeEnd = 86300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x000C7990 File Offset: 0x000C5B90
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86300, XrefRangeEnd = 86303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x000C79D0 File Offset: 0x000C5BD0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86303, XrefRangeEnd = 86306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x000C7A10 File Offset: 0x000C5C10
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86306, XrefRangeEnd = 86309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x000C7A50 File Offset: 0x000C5C50
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86309, XrefRangeEnd = 86312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x000C7A90 File Offset: 0x000C5C90
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86312, XrefRangeEnd = 86315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x000C7AD0 File Offset: 0x000C5CD0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86315, XrefRangeEnd = 86318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x000C7B10 File Offset: 0x000C5D10
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86318, XrefRangeEnd = 86321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x000C7B50 File Offset: 0x000C5D50
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86321, XrefRangeEnd = 86324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x000C7B90 File Offset: 0x000C5D90
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86324, XrefRangeEnd = 86327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x000C7BD0 File Offset: 0x000C5DD0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86327, XrefRangeEnd = 86330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x000C7C10 File Offset: 0x000C5E10
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86330, XrefRangeEnd = 86333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06003466 RID: 13414 RVA: 0x000C7C50 File Offset: 0x000C5E50
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86333, XrefRangeEnd = 86336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x000C7C90 File Offset: 0x000C5E90
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86336, XrefRangeEnd = 86339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x000C7CD0 File Offset: 0x000C5ED0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86339, XrefRangeEnd = 86342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x000C7D10 File Offset: 0x000C5F10
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86342, XrefRangeEnd = 86345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x000C7D50 File Offset: 0x000C5F50
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86345, XrefRangeEnd = 86348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x000C7D90 File Offset: 0x000C5F90
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86348, XrefRangeEnd = 86351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x000C7DD0 File Offset: 0x000C5FD0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86351, XrefRangeEnd = 86354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x000C7E10 File Offset: 0x000C6010
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86354, XrefRangeEnd = 86357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x000C7E50 File Offset: 0x000C6050
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86357, XrefRangeEnd = 86360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x000C7E90 File Offset: 0x000C6090
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86360, XrefRangeEnd = 86363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x000C7ED0 File Offset: 0x000C60D0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86363, XrefRangeEnd = 86366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x000C7F10 File Offset: 0x000C6110
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86366, XrefRangeEnd = 86369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x000C7F50 File Offset: 0x000C6150
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86369, XrefRangeEnd = 86372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x000C7F90 File Offset: 0x000C6190
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.reverseGear
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86372, XrefRangeEnd = 86375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x000C7FD0 File Offset: 0x000C61D0
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.select
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86375, XrefRangeEnd = 86378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x000C8010 File Offset: 0x000C6210
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.start
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86378, XrefRangeEnd = 86381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x000C8050 File Offset: 0x000C6250
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.systemButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86381, XrefRangeEnd = 86384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x000C8090 File Offset: 0x000C6290
		public unsafe IControllerTemplateButton Rewired.IRacingWheelTemplate.horn
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86384, XrefRangeEnd = 86387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x000C80D0 File Offset: 0x000C62D0
		public unsafe IControllerTemplateDPad Rewired.IRacingWheelTemplate.dPad
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86387, XrefRangeEnd = 86395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateDPad>(intPtr3) : null;
			}
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x000C8110 File Offset: 0x000C6310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RacingWheelTemplate(Object payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RacingWheelTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00022F19 File Offset: 0x00021119
		public RacingWheelTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x0600347B RID: 13435 RVA: 0x000C815C File Offset: 0x000C635C
		// (set) Token: 0x0600347C RID: 13436 RVA: 0x00022F22 File Offset: 0x00021122
		public unsafe static Guid typeGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&value));
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x000C8178 File Offset: 0x000C6378
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x00022F30 File Offset: 0x00021130
		public unsafe static int elementId_wheel
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheel, (void*)(&value));
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x000C8194 File Offset: 0x000C6394
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x00022F3E File Offset: 0x0002113E
		public unsafe static int elementId_accelerator
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_accelerator, (void*)(&value));
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06003481 RID: 13441 RVA: 0x000C81B0 File Offset: 0x000C63B0
		// (set) Token: 0x06003482 RID: 13442 RVA: 0x00022F4C File Offset: 0x0002114C
		public unsafe static int elementId_brake
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_brake, (void*)(&value));
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06003483 RID: 13443 RVA: 0x000C81CC File Offset: 0x000C63CC
		// (set) Token: 0x06003484 RID: 13444 RVA: 0x00022F5A File Offset: 0x0002115A
		public unsafe static int elementId_clutch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_clutch, (void*)(&value));
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x000C81E8 File Offset: 0x000C63E8
		// (set) Token: 0x06003486 RID: 13446 RVA: 0x00022F68 File Offset: 0x00021168
		public unsafe static int elementId_shiftDown
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftDown, (void*)(&value));
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06003487 RID: 13447 RVA: 0x000C8204 File Offset: 0x000C6404
		// (set) Token: 0x06003488 RID: 13448 RVA: 0x00022F76 File Offset: 0x00021176
		public unsafe static int elementId_shiftUp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shiftUp, (void*)(&value));
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06003489 RID: 13449 RVA: 0x000C8220 File Offset: 0x000C6420
		// (set) Token: 0x0600348A RID: 13450 RVA: 0x00022F84 File Offset: 0x00021184
		public unsafe static int elementId_wheelButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton1, (void*)(&value));
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x000C823C File Offset: 0x000C643C
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x00022F92 File Offset: 0x00021192
		public unsafe static int elementId_wheelButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton2, (void*)(&value));
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x000C8258 File Offset: 0x000C6458
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x00022FA0 File Offset: 0x000211A0
		public unsafe static int elementId_wheelButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton3, (void*)(&value));
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x000C8274 File Offset: 0x000C6474
		// (set) Token: 0x06003490 RID: 13456 RVA: 0x00022FAE File Offset: 0x000211AE
		public unsafe static int elementId_wheelButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton4, (void*)(&value));
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x000C8290 File Offset: 0x000C6490
		// (set) Token: 0x06003492 RID: 13458 RVA: 0x00022FBC File Offset: 0x000211BC
		public unsafe static int elementId_wheelButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton5, (void*)(&value));
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x000C82AC File Offset: 0x000C64AC
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x00022FCA File Offset: 0x000211CA
		public unsafe static int elementId_wheelButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton6, (void*)(&value));
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x000C82C8 File Offset: 0x000C64C8
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x00022FD8 File Offset: 0x000211D8
		public unsafe static int elementId_wheelButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton7, (void*)(&value));
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x000C82E4 File Offset: 0x000C64E4
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x00022FE6 File Offset: 0x000211E6
		public unsafe static int elementId_wheelButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton8, (void*)(&value));
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x000C8300 File Offset: 0x000C6500
		// (set) Token: 0x0600349A RID: 13466 RVA: 0x00022FF4 File Offset: 0x000211F4
		public unsafe static int elementId_wheelButton9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton9, (void*)(&value));
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x0600349B RID: 13467 RVA: 0x000C831C File Offset: 0x000C651C
		// (set) Token: 0x0600349C RID: 13468 RVA: 0x00023002 File Offset: 0x00021202
		public unsafe static int elementId_wheelButton10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_wheelButton10, (void*)(&value));
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x000C8338 File Offset: 0x000C6538
		// (set) Token: 0x0600349E RID: 13470 RVA: 0x00023010 File Offset: 0x00021210
		public unsafe static int elementId_consoleButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&value));
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x000C8354 File Offset: 0x000C6554
		// (set) Token: 0x060034A0 RID: 13472 RVA: 0x0002301E File Offset: 0x0002121E
		public unsafe static int elementId_consoleButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&value));
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x000C8370 File Offset: 0x000C6570
		// (set) Token: 0x060034A2 RID: 13474 RVA: 0x0002302C File Offset: 0x0002122C
		public unsafe static int elementId_consoleButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&value));
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x000C838C File Offset: 0x000C658C
		// (set) Token: 0x060034A4 RID: 13476 RVA: 0x0002303A File Offset: 0x0002123A
		public unsafe static int elementId_consoleButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&value));
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x000C83A8 File Offset: 0x000C65A8
		// (set) Token: 0x060034A6 RID: 13478 RVA: 0x00023048 File Offset: 0x00021248
		public unsafe static int elementId_consoleButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&value));
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x060034A7 RID: 13479 RVA: 0x000C83C4 File Offset: 0x000C65C4
		// (set) Token: 0x060034A8 RID: 13480 RVA: 0x00023056 File Offset: 0x00021256
		public unsafe static int elementId_consoleButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&value));
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x000C83E0 File Offset: 0x000C65E0
		// (set) Token: 0x060034AA RID: 13482 RVA: 0x00023064 File Offset: 0x00021264
		public unsafe static int elementId_consoleButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&value));
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x060034AB RID: 13483 RVA: 0x000C83FC File Offset: 0x000C65FC
		// (set) Token: 0x060034AC RID: 13484 RVA: 0x00023072 File Offset: 0x00021272
		public unsafe static int elementId_consoleButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&value));
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x060034AD RID: 13485 RVA: 0x000C8418 File Offset: 0x000C6618
		// (set) Token: 0x060034AE RID: 13486 RVA: 0x00023080 File Offset: 0x00021280
		public unsafe static int elementId_consoleButton9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&value));
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x060034AF RID: 13487 RVA: 0x000C8434 File Offset: 0x000C6634
		// (set) Token: 0x060034B0 RID: 13488 RVA: 0x0002308E File Offset: 0x0002128E
		public unsafe static int elementId_consoleButton10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&value));
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x000C8450 File Offset: 0x000C6650
		// (set) Token: 0x060034B2 RID: 13490 RVA: 0x0002309C File Offset: 0x0002129C
		public unsafe static int elementId_shifter1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter1, (void*)(&value));
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x000C846C File Offset: 0x000C666C
		// (set) Token: 0x060034B4 RID: 13492 RVA: 0x000230AA File Offset: 0x000212AA
		public unsafe static int elementId_shifter2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter2, (void*)(&value));
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x000C8488 File Offset: 0x000C6688
		// (set) Token: 0x060034B6 RID: 13494 RVA: 0x000230B8 File Offset: 0x000212B8
		public unsafe static int elementId_shifter3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter3, (void*)(&value));
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x000C84A4 File Offset: 0x000C66A4
		// (set) Token: 0x060034B8 RID: 13496 RVA: 0x000230C6 File Offset: 0x000212C6
		public unsafe static int elementId_shifter4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter4, (void*)(&value));
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x000C84C0 File Offset: 0x000C66C0
		// (set) Token: 0x060034BA RID: 13498 RVA: 0x000230D4 File Offset: 0x000212D4
		public unsafe static int elementId_shifter5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter5, (void*)(&value));
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x000C84DC File Offset: 0x000C66DC
		// (set) Token: 0x060034BC RID: 13500 RVA: 0x000230E2 File Offset: 0x000212E2
		public unsafe static int elementId_shifter6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter6, (void*)(&value));
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x000C84F8 File Offset: 0x000C66F8
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x000230F0 File Offset: 0x000212F0
		public unsafe static int elementId_shifter7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter7, (void*)(&value));
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x000C8514 File Offset: 0x000C6714
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x000230FE File Offset: 0x000212FE
		public unsafe static int elementId_shifter8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter8, (void*)(&value));
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x000C8530 File Offset: 0x000C6730
		// (set) Token: 0x060034C2 RID: 13506 RVA: 0x0002310C File Offset: 0x0002130C
		public unsafe static int elementId_shifter9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter9, (void*)(&value));
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x000C854C File Offset: 0x000C674C
		// (set) Token: 0x060034C4 RID: 13508 RVA: 0x0002311A File Offset: 0x0002131A
		public unsafe static int elementId_shifter10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_shifter10, (void*)(&value));
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x000C8568 File Offset: 0x000C6768
		// (set) Token: 0x060034C6 RID: 13510 RVA: 0x00023128 File Offset: 0x00021328
		public unsafe static int elementId_reverseGear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_reverseGear, (void*)(&value));
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x060034C7 RID: 13511 RVA: 0x000C8584 File Offset: 0x000C6784
		// (set) Token: 0x060034C8 RID: 13512 RVA: 0x00023136 File Offset: 0x00021336
		public unsafe static int elementId_select
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_select, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_select, (void*)(&value));
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x000C85A0 File Offset: 0x000C67A0
		// (set) Token: 0x060034CA RID: 13514 RVA: 0x00023144 File Offset: 0x00021344
		public unsafe static int elementId_start
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_start, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_start, (void*)(&value));
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x000C85BC File Offset: 0x000C67BC
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x00023152 File Offset: 0x00021352
		public unsafe static int elementId_systemButton
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_systemButton, (void*)(&value));
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x000C85D8 File Offset: 0x000C67D8
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x00023160 File Offset: 0x00021360
		public unsafe static int elementId_horn
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_horn, (void*)(&value));
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x000C85F4 File Offset: 0x000C67F4
		// (set) Token: 0x060034D0 RID: 13520 RVA: 0x0002316E File Offset: 0x0002136E
		public unsafe static int elementId_dPadUp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadUp, (void*)(&value));
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x000C8610 File Offset: 0x000C6810
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x0002317C File Offset: 0x0002137C
		public unsafe static int elementId_dPadRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadRight, (void*)(&value));
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x000C862C File Offset: 0x000C682C
		// (set) Token: 0x060034D4 RID: 13524 RVA: 0x0002318A File Offset: 0x0002138A
		public unsafe static int elementId_dPadDown
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadDown, (void*)(&value));
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x000C8648 File Offset: 0x000C6848
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x00023198 File Offset: 0x00021398
		public unsafe static int elementId_dPadLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPadLeft, (void*)(&value));
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x000C8664 File Offset: 0x000C6864
		// (set) Token: 0x060034D8 RID: 13528 RVA: 0x000231A6 File Offset: 0x000213A6
		public unsafe static int elementId_dPad
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RacingWheelTemplate.NativeFieldInfoPtr_elementId_dPad, (void*)(&value));
			}
		}

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_typeGuid;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheel;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeFieldInfoPtr_elementId_accelerator;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeFieldInfoPtr_elementId_brake;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeFieldInfoPtr_elementId_clutch;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shiftDown;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shiftUp;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton1;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton2;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton3;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton4;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton5;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton6;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton7;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton8;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton9;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheelButton10;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton1;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton2;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton3;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton4;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton5;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton6;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton7;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton8;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton9;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton10;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter1;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter2;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter3;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter4;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter5;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter6;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter7;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter8;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter9;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeFieldInfoPtr_elementId_shifter10;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeFieldInfoPtr_elementId_reverseGear;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeFieldInfoPtr_elementId_select;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeFieldInfoPtr_elementId_start;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeFieldInfoPtr_elementId_systemButton;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeFieldInfoPtr_elementId_horn;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadUp;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadRight;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadDown;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPadLeft;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeFieldInfoPtr_elementId_dPad;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
	}
}
