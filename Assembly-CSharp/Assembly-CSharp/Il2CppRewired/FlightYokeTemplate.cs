using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x020001E0 RID: 480
	public sealed class FlightYokeTemplate : ControllerTemplate
	{
		// Token: 0x06003686 RID: 13958 RVA: 0x000CC3A0 File Offset: 0x000CA5A0
		// Note: this type is marked as 'beforefieldinit'.
		static FlightYokeTemplate()
		{
			Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "FlightYokeTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr);
			FlightYokeTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "typeGuid");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rotateYoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rotateYoke");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_yokeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_yokeZ");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftPaddle");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightPaddle");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1Axis");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1MinDetent");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2Axis");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2MinDetent");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3Axis");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3MinDetent");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4Axis");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4MinDetent");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5Axis");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5MinDetent");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton1");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton2");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton3");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton4");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton5");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton6");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton1");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton2");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton3");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton4");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton5");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton6");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton1");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton2");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton3");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton4");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton5");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton6");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton7");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton8");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Up");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Down");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Press");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Up");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Down");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Press");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUp");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUpRight");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatRight");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDownRight");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDown");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDownLeft");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatLeft");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUpLeft");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUp");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUpRight");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatRight");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDownRight");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDown");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDownLeft");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatLeft");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUpLeft");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton1");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton2");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton3");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton4");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton5");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton6");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton7");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton8");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton9");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton10");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode1");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode2");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode3");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_yoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_yoke");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHat");
			FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHat");
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667672);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667673);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667674);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667675);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667676);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667677);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667678);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667679);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667680);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667681);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667682);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667683);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667684);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667685);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667686);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667687);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667688);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667689);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667690);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667691);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667692);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667693);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667694);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667695);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667696);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667697);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667698);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667699);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667700);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667701);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667702);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667703);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667704);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667705);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667706);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667707);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667708);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667709);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667710);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667711);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667712);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667713);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667714);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667715);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667716);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667717);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667718);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667719);
			FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667720);
			FlightYokeTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100667721);
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x000CCDD0 File Offset: 0x000CAFD0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.leftPaddle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86659, XrefRangeEnd = 86662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x000CCE10 File Offset: 0x000CB010
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.rightPaddle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86662, XrefRangeEnd = 86665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x000CCE50 File Offset: 0x000CB050
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86665, XrefRangeEnd = 86668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x000CCE90 File Offset: 0x000CB090
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86668, XrefRangeEnd = 86671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x000CCED0 File Offset: 0x000CB0D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86671, XrefRangeEnd = 86674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x000CCF10 File Offset: 0x000CB110
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86674, XrefRangeEnd = 86677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x000CCF50 File Offset: 0x000CB150
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86677, XrefRangeEnd = 86680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x000CCF90 File Offset: 0x000CB190
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86680, XrefRangeEnd = 86683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x000CCFD0 File Offset: 0x000CB1D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86683, XrefRangeEnd = 86686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x000CD010 File Offset: 0x000CB210
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86686, XrefRangeEnd = 86689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x000CD050 File Offset: 0x000CB250
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86689, XrefRangeEnd = 86692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x000CD090 File Offset: 0x000CB290
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86692, XrefRangeEnd = 86695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x000CD0D0 File Offset: 0x000CB2D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86695, XrefRangeEnd = 86698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x000CD110 File Offset: 0x000CB310
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86698, XrefRangeEnd = 86701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x000CD150 File Offset: 0x000CB350
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86701, XrefRangeEnd = 86704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x000CD190 File Offset: 0x000CB390
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86704, XrefRangeEnd = 86707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x000CD1D0 File Offset: 0x000CB3D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86707, XrefRangeEnd = 86710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06003698 RID: 13976 RVA: 0x000CD210 File Offset: 0x000CB410
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86710, XrefRangeEnd = 86713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x000CD250 File Offset: 0x000CB450
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86713, XrefRangeEnd = 86716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x0600369A RID: 13978 RVA: 0x000CD290 File Offset: 0x000CB490
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86716, XrefRangeEnd = 86719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x000CD2D0 File Offset: 0x000CB4D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86719, XrefRangeEnd = 86722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x000CD310 File Offset: 0x000CB510
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86722, XrefRangeEnd = 86725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x000CD350 File Offset: 0x000CB550
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86725, XrefRangeEnd = 86728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x000CD390 File Offset: 0x000CB590
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Down
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86728, XrefRangeEnd = 86731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x000CD3D0 File Offset: 0x000CB5D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Press
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86731, XrefRangeEnd = 86734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060036A0 RID: 13984 RVA: 0x000CD410 File Offset: 0x000CB610
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86734, XrefRangeEnd = 86737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x000CD450 File Offset: 0x000CB650
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Down
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86737, XrefRangeEnd = 86740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x000CD490 File Offset: 0x000CB690
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Press
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86740, XrefRangeEnd = 86743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x000CD4D0 File Offset: 0x000CB6D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86743, XrefRangeEnd = 86746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x000CD510 File Offset: 0x000CB710
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86746, XrefRangeEnd = 86749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x000CD550 File Offset: 0x000CB750
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86749, XrefRangeEnd = 86752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x000CD590 File Offset: 0x000CB790
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86752, XrefRangeEnd = 86755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x000CD5D0 File Offset: 0x000CB7D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86755, XrefRangeEnd = 86758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x000CD610 File Offset: 0x000CB810
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86758, XrefRangeEnd = 86761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x000CD650 File Offset: 0x000CB850
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86761, XrefRangeEnd = 86764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x000CD690 File Offset: 0x000CB890
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86764, XrefRangeEnd = 86767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x000CD6D0 File Offset: 0x000CB8D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86767, XrefRangeEnd = 86770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x000CD710 File Offset: 0x000CB910
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86770, XrefRangeEnd = 86773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x000CD750 File Offset: 0x000CB950
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.mode1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86773, XrefRangeEnd = 86776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x000CD790 File Offset: 0x000CB990
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.mode2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86776, XrefRangeEnd = 86779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x000CD7D0 File Offset: 0x000CB9D0
		public unsafe IControllerTemplateButton Rewired.IFlightYokeTemplate.mode3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86779, XrefRangeEnd = 86782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x000CD810 File Offset: 0x000CBA10
		public unsafe IControllerTemplateYoke Rewired.IFlightYokeTemplate.yoke
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86782, XrefRangeEnd = 86785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateYoke>(intPtr3) : null;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x000CD850 File Offset: 0x000CBA50
		public unsafe IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86785, XrefRangeEnd = 86788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x000CD890 File Offset: 0x000CBA90
		public unsafe IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86788, XrefRangeEnd = 86791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x000CD8D0 File Offset: 0x000CBAD0
		public unsafe IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86791, XrefRangeEnd = 86794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x000CD910 File Offset: 0x000CBB10
		public unsafe IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86794, XrefRangeEnd = 86797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x000CD950 File Offset: 0x000CBB50
		public unsafe IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86797, XrefRangeEnd = 86800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x000CD990 File Offset: 0x000CBB90
		public unsafe IControllerTemplateHat Rewired.IFlightYokeTemplate.leftGripHat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86800, XrefRangeEnd = 86803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x000CD9D0 File Offset: 0x000CBBD0
		public unsafe IControllerTemplateHat Rewired.IFlightYokeTemplate.rightGripHat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86803, XrefRangeEnd = 86811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000CDA10 File Offset: 0x000CBC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlightYokeTemplate(Object payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlightYokeTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00023AFB File Offset: 0x00021CFB
		public FlightYokeTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x060036BA RID: 14010 RVA: 0x000CDA5C File Offset: 0x000CBC5C
		// (set) Token: 0x060036BB RID: 14011 RVA: 0x00023B04 File Offset: 0x00021D04
		public unsafe static Guid typeGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&value));
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x000CDA78 File Offset: 0x000CBC78
		// (set) Token: 0x060036BD RID: 14013 RVA: 0x00023B12 File Offset: 0x00021D12
		public unsafe static int elementId_rotateYoke
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rotateYoke, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rotateYoke, (void*)(&value));
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x000CDA94 File Offset: 0x000CBC94
		// (set) Token: 0x060036BF RID: 14015 RVA: 0x00023B20 File Offset: 0x00021D20
		public unsafe static int elementId_yokeZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yokeZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yokeZ, (void*)(&value));
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x000CDAB0 File Offset: 0x000CBCB0
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x00023B2E File Offset: 0x00021D2E
		public unsafe static int elementId_leftPaddle
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftPaddle, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftPaddle, (void*)(&value));
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x000CDACC File Offset: 0x000CBCCC
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x00023B3C File Offset: 0x00021D3C
		public unsafe static int elementId_rightPaddle
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightPaddle, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightPaddle, (void*)(&value));
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x000CDAE8 File Offset: 0x000CBCE8
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x00023B4A File Offset: 0x00021D4A
		public unsafe static int elementId_lever1Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1Axis, (void*)(&value));
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x000CDB04 File Offset: 0x000CBD04
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x00023B58 File Offset: 0x00021D58
		public unsafe static int elementId_lever1MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1MinDetent, (void*)(&value));
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x000CDB20 File Offset: 0x000CBD20
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x00023B66 File Offset: 0x00021D66
		public unsafe static int elementId_lever2Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2Axis, (void*)(&value));
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x000CDB3C File Offset: 0x000CBD3C
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x00023B74 File Offset: 0x00021D74
		public unsafe static int elementId_lever2MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2MinDetent, (void*)(&value));
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x000CDB58 File Offset: 0x000CBD58
		// (set) Token: 0x060036CD RID: 14029 RVA: 0x00023B82 File Offset: 0x00021D82
		public unsafe static int elementId_lever3Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3Axis, (void*)(&value));
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x000CDB74 File Offset: 0x000CBD74
		// (set) Token: 0x060036CF RID: 14031 RVA: 0x00023B90 File Offset: 0x00021D90
		public unsafe static int elementId_lever3MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3MinDetent, (void*)(&value));
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x000CDB90 File Offset: 0x000CBD90
		// (set) Token: 0x060036D1 RID: 14033 RVA: 0x00023B9E File Offset: 0x00021D9E
		public unsafe static int elementId_lever4Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4Axis, (void*)(&value));
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x000CDBAC File Offset: 0x000CBDAC
		// (set) Token: 0x060036D3 RID: 14035 RVA: 0x00023BAC File Offset: 0x00021DAC
		public unsafe static int elementId_lever4MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4MinDetent, (void*)(&value));
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x000CDBC8 File Offset: 0x000CBDC8
		// (set) Token: 0x060036D5 RID: 14037 RVA: 0x00023BBA File Offset: 0x00021DBA
		public unsafe static int elementId_lever5Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5Axis, (void*)(&value));
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x000CDBE4 File Offset: 0x000CBDE4
		// (set) Token: 0x060036D7 RID: 14039 RVA: 0x00023BC8 File Offset: 0x00021DC8
		public unsafe static int elementId_lever5MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5MinDetent, (void*)(&value));
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x000CDC00 File Offset: 0x000CBE00
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x00023BD6 File Offset: 0x00021DD6
		public unsafe static int elementId_leftGripButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton1, (void*)(&value));
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x000CDC1C File Offset: 0x000CBE1C
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x00023BE4 File Offset: 0x00021DE4
		public unsafe static int elementId_leftGripButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton2, (void*)(&value));
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x000CDC38 File Offset: 0x000CBE38
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x00023BF2 File Offset: 0x00021DF2
		public unsafe static int elementId_leftGripButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton3, (void*)(&value));
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x000CDC54 File Offset: 0x000CBE54
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x00023C00 File Offset: 0x00021E00
		public unsafe static int elementId_leftGripButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton4, (void*)(&value));
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x000CDC70 File Offset: 0x000CBE70
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x00023C0E File Offset: 0x00021E0E
		public unsafe static int elementId_leftGripButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton5, (void*)(&value));
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x000CDC8C File Offset: 0x000CBE8C
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x00023C1C File Offset: 0x00021E1C
		public unsafe static int elementId_leftGripButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripButton6, (void*)(&value));
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x000CDCA8 File Offset: 0x000CBEA8
		// (set) Token: 0x060036E5 RID: 14053 RVA: 0x00023C2A File Offset: 0x00021E2A
		public unsafe static int elementId_rightGripButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton1, (void*)(&value));
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x060036E6 RID: 14054 RVA: 0x000CDCC4 File Offset: 0x000CBEC4
		// (set) Token: 0x060036E7 RID: 14055 RVA: 0x00023C38 File Offset: 0x00021E38
		public unsafe static int elementId_rightGripButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton2, (void*)(&value));
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x000CDCE0 File Offset: 0x000CBEE0
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x00023C46 File Offset: 0x00021E46
		public unsafe static int elementId_rightGripButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton3, (void*)(&value));
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x000CDCFC File Offset: 0x000CBEFC
		// (set) Token: 0x060036EB RID: 14059 RVA: 0x00023C54 File Offset: 0x00021E54
		public unsafe static int elementId_rightGripButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton4, (void*)(&value));
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x000CDD18 File Offset: 0x000CBF18
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x00023C62 File Offset: 0x00021E62
		public unsafe static int elementId_rightGripButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton5, (void*)(&value));
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x000CDD34 File Offset: 0x000CBF34
		// (set) Token: 0x060036EF RID: 14063 RVA: 0x00023C70 File Offset: 0x00021E70
		public unsafe static int elementId_rightGripButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripButton6, (void*)(&value));
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000CDD50 File Offset: 0x000CBF50
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x00023C7E File Offset: 0x00021E7E
		public unsafe static int elementId_centerButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton1, (void*)(&value));
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x000CDD6C File Offset: 0x000CBF6C
		// (set) Token: 0x060036F3 RID: 14067 RVA: 0x00023C8C File Offset: 0x00021E8C
		public unsafe static int elementId_centerButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton2, (void*)(&value));
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x000CDD88 File Offset: 0x000CBF88
		// (set) Token: 0x060036F5 RID: 14069 RVA: 0x00023C9A File Offset: 0x00021E9A
		public unsafe static int elementId_centerButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton3, (void*)(&value));
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x000CDDA4 File Offset: 0x000CBFA4
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x00023CA8 File Offset: 0x00021EA8
		public unsafe static int elementId_centerButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton4, (void*)(&value));
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x000CDDC0 File Offset: 0x000CBFC0
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x00023CB6 File Offset: 0x00021EB6
		public unsafe static int elementId_centerButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton5, (void*)(&value));
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x000CDDDC File Offset: 0x000CBFDC
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x00023CC4 File Offset: 0x00021EC4
		public unsafe static int elementId_centerButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton6, (void*)(&value));
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x000CDDF8 File Offset: 0x000CBFF8
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x00023CD2 File Offset: 0x00021ED2
		public unsafe static int elementId_centerButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton7, (void*)(&value));
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x000CDE14 File Offset: 0x000CC014
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x00023CE0 File Offset: 0x00021EE0
		public unsafe static int elementId_centerButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_centerButton8, (void*)(&value));
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x000CDE30 File Offset: 0x000CC030
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x00023CEE File Offset: 0x00021EEE
		public unsafe static int elementId_wheel1Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Up, (void*)(&value));
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x000CDE4C File Offset: 0x000CC04C
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x00023CFC File Offset: 0x00021EFC
		public unsafe static int elementId_wheel1Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Down, (void*)(&value));
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x000CDE68 File Offset: 0x000CC068
		// (set) Token: 0x06003705 RID: 14085 RVA: 0x00023D0A File Offset: 0x00021F0A
		public unsafe static int elementId_wheel1Press
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Press, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel1Press, (void*)(&value));
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x000CDE84 File Offset: 0x000CC084
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x00023D18 File Offset: 0x00021F18
		public unsafe static int elementId_wheel2Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Up, (void*)(&value));
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x000CDEA0 File Offset: 0x000CC0A0
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x00023D26 File Offset: 0x00021F26
		public unsafe static int elementId_wheel2Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Down, (void*)(&value));
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x000CDEBC File Offset: 0x000CC0BC
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x00023D34 File Offset: 0x00021F34
		public unsafe static int elementId_wheel2Press
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Press, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_wheel2Press, (void*)(&value));
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x000CDED8 File Offset: 0x000CC0D8
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x00023D42 File Offset: 0x00021F42
		public unsafe static int elementId_leftGripHatUp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUp, (void*)(&value));
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x000CDEF4 File Offset: 0x000CC0F4
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x00023D50 File Offset: 0x00021F50
		public unsafe static int elementId_leftGripHatUpRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*)(&value));
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x000CDF10 File Offset: 0x000CC110
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x00023D5E File Offset: 0x00021F5E
		public unsafe static int elementId_leftGripHatRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatRight, (void*)(&value));
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x000CDF2C File Offset: 0x000CC12C
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x00023D6C File Offset: 0x00021F6C
		public unsafe static int elementId_leftGripHatDownRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*)(&value));
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x000CDF48 File Offset: 0x000CC148
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x00023D7A File Offset: 0x00021F7A
		public unsafe static int elementId_leftGripHatDown
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDown, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDown, (void*)(&value));
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x000CDF64 File Offset: 0x000CC164
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x00023D88 File Offset: 0x00021F88
		public unsafe static int elementId_leftGripHatDownLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*)(&value));
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x000CDF80 File Offset: 0x000CC180
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x00023D96 File Offset: 0x00021F96
		public unsafe static int elementId_leftGripHatLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*)(&value));
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x000CDF9C File Offset: 0x000CC19C
		// (set) Token: 0x0600371B RID: 14107 RVA: 0x00023DA4 File Offset: 0x00021FA4
		public unsafe static int elementId_leftGripHatUpLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*)(&value));
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x000CDFB8 File Offset: 0x000CC1B8
		// (set) Token: 0x0600371D RID: 14109 RVA: 0x00023DB2 File Offset: 0x00021FB2
		public unsafe static int elementId_rightGripHatUp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUp, (void*)(&value));
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x000CDFD4 File Offset: 0x000CC1D4
		// (set) Token: 0x0600371F RID: 14111 RVA: 0x00023DC0 File Offset: 0x00021FC0
		public unsafe static int elementId_rightGripHatUpRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*)(&value));
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x000CDFF0 File Offset: 0x000CC1F0
		// (set) Token: 0x06003721 RID: 14113 RVA: 0x00023DCE File Offset: 0x00021FCE
		public unsafe static int elementId_rightGripHatRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatRight, (void*)(&value));
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06003722 RID: 14114 RVA: 0x000CE00C File Offset: 0x000CC20C
		// (set) Token: 0x06003723 RID: 14115 RVA: 0x00023DDC File Offset: 0x00021FDC
		public unsafe static int elementId_rightGripHatDownRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*)(&value));
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x000CE028 File Offset: 0x000CC228
		// (set) Token: 0x06003725 RID: 14117 RVA: 0x00023DEA File Offset: 0x00021FEA
		public unsafe static int elementId_rightGripHatDown
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDown, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDown, (void*)(&value));
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x000CE044 File Offset: 0x000CC244
		// (set) Token: 0x06003727 RID: 14119 RVA: 0x00023DF8 File Offset: 0x00021FF8
		public unsafe static int elementId_rightGripHatDownLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*)(&value));
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x000CE060 File Offset: 0x000CC260
		// (set) Token: 0x06003729 RID: 14121 RVA: 0x00023E06 File Offset: 0x00022006
		public unsafe static int elementId_rightGripHatLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*)(&value));
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x000CE07C File Offset: 0x000CC27C
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x00023E14 File Offset: 0x00022014
		public unsafe static int elementId_rightGripHatUpLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*)(&value));
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x000CE098 File Offset: 0x000CC298
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x00023E22 File Offset: 0x00022022
		public unsafe static int elementId_consoleButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&value));
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x000CE0B4 File Offset: 0x000CC2B4
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x00023E30 File Offset: 0x00022030
		public unsafe static int elementId_consoleButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&value));
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x000CE0D0 File Offset: 0x000CC2D0
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x00023E3E File Offset: 0x0002203E
		public unsafe static int elementId_consoleButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&value));
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x000CE0EC File Offset: 0x000CC2EC
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x00023E4C File Offset: 0x0002204C
		public unsafe static int elementId_consoleButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&value));
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x000CE108 File Offset: 0x000CC308
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x00023E5A File Offset: 0x0002205A
		public unsafe static int elementId_consoleButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&value));
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x000CE124 File Offset: 0x000CC324
		// (set) Token: 0x06003737 RID: 14135 RVA: 0x00023E68 File Offset: 0x00022068
		public unsafe static int elementId_consoleButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&value));
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x000CE140 File Offset: 0x000CC340
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x00023E76 File Offset: 0x00022076
		public unsafe static int elementId_consoleButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&value));
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x000CE15C File Offset: 0x000CC35C
		// (set) Token: 0x0600373B RID: 14139 RVA: 0x00023E84 File Offset: 0x00022084
		public unsafe static int elementId_consoleButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&value));
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x000CE178 File Offset: 0x000CC378
		// (set) Token: 0x0600373D RID: 14141 RVA: 0x00023E92 File Offset: 0x00022092
		public unsafe static int elementId_consoleButton9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&value));
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x000CE194 File Offset: 0x000CC394
		// (set) Token: 0x0600373F RID: 14143 RVA: 0x00023EA0 File Offset: 0x000220A0
		public unsafe static int elementId_consoleButton10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&value));
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06003740 RID: 14144 RVA: 0x000CE1B0 File Offset: 0x000CC3B0
		// (set) Token: 0x06003741 RID: 14145 RVA: 0x00023EAE File Offset: 0x000220AE
		public unsafe static int elementId_mode1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode1, (void*)(&value));
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x000CE1CC File Offset: 0x000CC3CC
		// (set) Token: 0x06003743 RID: 14147 RVA: 0x00023EBC File Offset: 0x000220BC
		public unsafe static int elementId_mode2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode2, (void*)(&value));
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x000CE1E8 File Offset: 0x000CC3E8
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x00023ECA File Offset: 0x000220CA
		public unsafe static int elementId_mode3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_mode3, (void*)(&value));
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x000CE204 File Offset: 0x000CC404
		// (set) Token: 0x06003747 RID: 14151 RVA: 0x00023ED8 File Offset: 0x000220D8
		public unsafe static int elementId_yoke
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yoke, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_yoke, (void*)(&value));
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x000CE220 File Offset: 0x000CC420
		// (set) Token: 0x06003749 RID: 14153 RVA: 0x00023EE6 File Offset: 0x000220E6
		public unsafe static int elementId_lever1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever1, (void*)(&value));
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x000CE23C File Offset: 0x000CC43C
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x00023EF4 File Offset: 0x000220F4
		public unsafe static int elementId_lever2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever2, (void*)(&value));
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x000CE258 File Offset: 0x000CC458
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x00023F02 File Offset: 0x00022102
		public unsafe static int elementId_lever3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever3, (void*)(&value));
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x000CE274 File Offset: 0x000CC474
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x00023F10 File Offset: 0x00022110
		public unsafe static int elementId_lever4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever4, (void*)(&value));
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x000CE290 File Offset: 0x000CC490
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x00023F1E File Offset: 0x0002211E
		public unsafe static int elementId_lever5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_lever5, (void*)(&value));
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x000CE2AC File Offset: 0x000CC4AC
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x00023F2C File Offset: 0x0002212C
		public unsafe static int elementId_leftGripHat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_leftGripHat, (void*)(&value));
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x000CE2C8 File Offset: 0x000CC4C8
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x00023F3A File Offset: 0x0002213A
		public unsafe static int elementId_rightGripHat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlightYokeTemplate.NativeFieldInfoPtr_elementId_rightGripHat, (void*)(&value));
			}
		}

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeFieldInfoPtr_typeGuid;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rotateYoke;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr_elementId_yokeZ;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftPaddle;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightPaddle;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever1Axis;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever1MinDetent;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever2Axis;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever2MinDetent;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever3Axis;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever3MinDetent;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever4Axis;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever4MinDetent;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever5Axis;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever5MinDetent;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripButton1;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripButton2;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripButton3;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripButton4;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripButton5;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripButton6;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripButton1;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripButton2;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripButton3;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripButton4;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripButton5;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripButton6;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton1;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton2;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton3;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton4;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton5;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton6;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton7;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeFieldInfoPtr_elementId_centerButton8;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheel1Up;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheel1Down;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheel1Press;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheel2Up;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheel2Down;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeFieldInfoPtr_elementId_wheel2Press;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatUp;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpRight;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatRight;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownRight;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatDown;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownLeft;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatLeft;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpLeft;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatUp;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpRight;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatRight;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownRight;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatDown;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownLeft;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatLeft;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpLeft;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton1;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton2;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton3;

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton4;

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton5;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton6;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton7;

		// Token: 0x0400209B RID: 8347
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton8;

		// Token: 0x0400209C RID: 8348
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton9;

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeFieldInfoPtr_elementId_consoleButton10;

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeFieldInfoPtr_elementId_mode1;

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeFieldInfoPtr_elementId_mode2;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeFieldInfoPtr_elementId_mode3;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeFieldInfoPtr_elementId_yoke;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever1;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever2;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever3;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever4;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeFieldInfoPtr_elementId_lever5;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftGripHat;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightGripHat;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
	}
}
