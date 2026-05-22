using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x020001E2 RID: 482
	public sealed class SixDofControllerTemplate : ControllerTemplate
	{
		// Token: 0x06003764 RID: 14180 RVA: 0x000CE530 File Offset: 0x000CC730
		// Note: this type is marked as 'beforefieldinit'.
		static SixDofControllerTemplate()
		{
			Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "SixDofControllerTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr);
			SixDofControllerTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "typeGuid");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_positionX");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_positionY");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_positionZ");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_rotationX");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_rotationY");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_rotationZ");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle1Axis");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle1MinDetent");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle2Axis");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle2MinDetent");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis1");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis2");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis3");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis4");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button1");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button2");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button3");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button4");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button5");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button6");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button7");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button8");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button9");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button10");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button11");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button12");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button13");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button14");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button15");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button16");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button17");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button18");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button19");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button20");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button21");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button22");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button23");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button24");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button25");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button26");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button27");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button28");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button29");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button30");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button31");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button32");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Up");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1UpRight");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Right");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1DownRight");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Down");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1DownLeft");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Left");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1UpLeft");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Up");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2UpRight");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Right");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2DownRight");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Down");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2DownLeft");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Left");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2UpLeft");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle1");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle2");
			SixDofControllerTemplate.NativeFieldInfoPtr_elementId_stick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_stick");
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667728);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667729);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667730);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667731);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667732);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667733);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667734);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667735);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667736);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667737);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667738);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667739);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667740);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667741);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667742);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667743);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667744);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667745);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667746);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667747);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667748);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667749);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667750);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667751);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667752);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667753);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667754);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667755);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667756);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667757);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667758);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667759);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667760);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667761);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667762);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667763);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667764);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667765);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667766);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667767);
			SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667768);
			SixDofControllerTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100667769);
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x000CEDF8 File Offset: 0x000CCFF8
		public unsafe IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86825, XrefRangeEnd = 86828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06003766 RID: 14182 RVA: 0x000CEE38 File Offset: 0x000CD038
		public unsafe IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86828, XrefRangeEnd = 86831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06003767 RID: 14183 RVA: 0x000CEE78 File Offset: 0x000CD078
		public unsafe IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86831, XrefRangeEnd = 86834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06003768 RID: 14184 RVA: 0x000CEEB8 File Offset: 0x000CD0B8
		public unsafe IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86834, XrefRangeEnd = 86837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x000CEEF8 File Offset: 0x000CD0F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86837, XrefRangeEnd = 86840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x0600376A RID: 14186 RVA: 0x000CEF38 File Offset: 0x000CD138
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86840, XrefRangeEnd = 86843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x000CEF78 File Offset: 0x000CD178
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86843, XrefRangeEnd = 86846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x000CEFB8 File Offset: 0x000CD1B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86846, XrefRangeEnd = 86849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x000CEFF8 File Offset: 0x000CD1F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86849, XrefRangeEnd = 86852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x0600376E RID: 14190 RVA: 0x000CF038 File Offset: 0x000CD238
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86852, XrefRangeEnd = 86855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x000CF078 File Offset: 0x000CD278
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86855, XrefRangeEnd = 86858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x000CF0B8 File Offset: 0x000CD2B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86858, XrefRangeEnd = 86861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06003771 RID: 14193 RVA: 0x000CF0F8 File Offset: 0x000CD2F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86861, XrefRangeEnd = 86864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x000CF138 File Offset: 0x000CD338
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86864, XrefRangeEnd = 86867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06003773 RID: 14195 RVA: 0x000CF178 File Offset: 0x000CD378
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button11
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86867, XrefRangeEnd = 86870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06003774 RID: 14196 RVA: 0x000CF1B8 File Offset: 0x000CD3B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button12
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86870, XrefRangeEnd = 86873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06003775 RID: 14197 RVA: 0x000CF1F8 File Offset: 0x000CD3F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button13
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86873, XrefRangeEnd = 86876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x000CF238 File Offset: 0x000CD438
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button14
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86876, XrefRangeEnd = 86879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x000CF278 File Offset: 0x000CD478
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button15
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86879, XrefRangeEnd = 86882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x000CF2B8 File Offset: 0x000CD4B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button16
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86882, XrefRangeEnd = 86885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x000CF2F8 File Offset: 0x000CD4F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button17
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86885, XrefRangeEnd = 86888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x000CF338 File Offset: 0x000CD538
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button18
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86888, XrefRangeEnd = 86891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x000CF378 File Offset: 0x000CD578
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button19
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86891, XrefRangeEnd = 86894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x000CF3B8 File Offset: 0x000CD5B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button20
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86894, XrefRangeEnd = 86897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x000CF3F8 File Offset: 0x000CD5F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button21
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86897, XrefRangeEnd = 86900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x000CF438 File Offset: 0x000CD638
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button22
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86900, XrefRangeEnd = 86903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x000CF478 File Offset: 0x000CD678
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button23
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86903, XrefRangeEnd = 86906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x000CF4B8 File Offset: 0x000CD6B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button24
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86906, XrefRangeEnd = 86909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x000CF4F8 File Offset: 0x000CD6F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button25
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86909, XrefRangeEnd = 86912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06003782 RID: 14210 RVA: 0x000CF538 File Offset: 0x000CD738
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button26
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86912, XrefRangeEnd = 86915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x000CF578 File Offset: 0x000CD778
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button27
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86915, XrefRangeEnd = 86918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x000CF5B8 File Offset: 0x000CD7B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button28
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86918, XrefRangeEnd = 86921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x000CF5F8 File Offset: 0x000CD7F8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button29
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86921, XrefRangeEnd = 86924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x000CF638 File Offset: 0x000CD838
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button30
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86924, XrefRangeEnd = 86927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x000CF678 File Offset: 0x000CD878
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button31
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86927, XrefRangeEnd = 86930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x000CF6B8 File Offset: 0x000CD8B8
		public unsafe IControllerTemplateButton Rewired.ISixDofControllerTemplate.button32
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86930, XrefRangeEnd = 86933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x000CF6F8 File Offset: 0x000CD8F8
		public unsafe IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86933, XrefRangeEnd = 86936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x000CF738 File Offset: 0x000CD938
		public unsafe IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86936, XrefRangeEnd = 86939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x000CF778 File Offset: 0x000CD978
		public unsafe IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86939, XrefRangeEnd = 86942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x000CF7B8 File Offset: 0x000CD9B8
		public unsafe IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86942, XrefRangeEnd = 86945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x0600378D RID: 14221 RVA: 0x000CF7F8 File Offset: 0x000CD9F8
		public unsafe IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.stick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86945, XrefRangeEnd = 86953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateStick6D>(intPtr3) : null;
			}
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x000CF838 File Offset: 0x000CDA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SixDofControllerTemplate(Object payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SixDofControllerTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00023F89 File Offset: 0x00022189
		public SixDofControllerTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x000CF884 File Offset: 0x000CDA84
		// (set) Token: 0x06003791 RID: 14225 RVA: 0x00023F92 File Offset: 0x00022192
		public unsafe static Guid typeGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&value));
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x000CF8A0 File Offset: 0x000CDAA0
		// (set) Token: 0x06003793 RID: 14227 RVA: 0x00023FA0 File Offset: 0x000221A0
		public unsafe static int elementId_positionX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionX, (void*)(&value));
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x000CF8BC File Offset: 0x000CDABC
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x00023FAE File Offset: 0x000221AE
		public unsafe static int elementId_positionY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionY, (void*)(&value));
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x000CF8D8 File Offset: 0x000CDAD8
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x00023FBC File Offset: 0x000221BC
		public unsafe static int elementId_positionZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_positionZ, (void*)(&value));
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x000CF8F4 File Offset: 0x000CDAF4
		// (set) Token: 0x06003799 RID: 14233 RVA: 0x00023FCA File Offset: 0x000221CA
		public unsafe static int elementId_rotationX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationX, (void*)(&value));
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x000CF910 File Offset: 0x000CDB10
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x00023FD8 File Offset: 0x000221D8
		public unsafe static int elementId_rotationY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationY, (void*)(&value));
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x000CF92C File Offset: 0x000CDB2C
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x00023FE6 File Offset: 0x000221E6
		public unsafe static int elementId_rotationZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_rotationZ, (void*)(&value));
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x000CF948 File Offset: 0x000CDB48
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x00023FF4 File Offset: 0x000221F4
		public unsafe static int elementId_throttle1Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*)(&value));
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x000CF964 File Offset: 0x000CDB64
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x00024002 File Offset: 0x00022202
		public unsafe static int elementId_throttle1MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*)(&value));
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x000CF980 File Offset: 0x000CDB80
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x00024010 File Offset: 0x00022210
		public unsafe static int elementId_throttle2Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*)(&value));
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x000CF99C File Offset: 0x000CDB9C
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x0002401E File Offset: 0x0002221E
		public unsafe static int elementId_throttle2MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*)(&value));
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x000CF9B8 File Offset: 0x000CDBB8
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x0002402C File Offset: 0x0002222C
		public unsafe static int elementId_extraAxis1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis1, (void*)(&value));
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x000CF9D4 File Offset: 0x000CDBD4
		// (set) Token: 0x060037A9 RID: 14249 RVA: 0x0002403A File Offset: 0x0002223A
		public unsafe static int elementId_extraAxis2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis2, (void*)(&value));
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x000CF9F0 File Offset: 0x000CDBF0
		// (set) Token: 0x060037AB RID: 14251 RVA: 0x00024048 File Offset: 0x00022248
		public unsafe static int elementId_extraAxis3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis3, (void*)(&value));
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x060037AC RID: 14252 RVA: 0x000CFA0C File Offset: 0x000CDC0C
		// (set) Token: 0x060037AD RID: 14253 RVA: 0x00024056 File Offset: 0x00022256
		public unsafe static int elementId_extraAxis4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_extraAxis4, (void*)(&value));
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x000CFA28 File Offset: 0x000CDC28
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x00024064 File Offset: 0x00022264
		public unsafe static int elementId_button1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button1, (void*)(&value));
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x000CFA44 File Offset: 0x000CDC44
		// (set) Token: 0x060037B1 RID: 14257 RVA: 0x00024072 File Offset: 0x00022272
		public unsafe static int elementId_button2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button2, (void*)(&value));
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x000CFA60 File Offset: 0x000CDC60
		// (set) Token: 0x060037B3 RID: 14259 RVA: 0x00024080 File Offset: 0x00022280
		public unsafe static int elementId_button3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button3, (void*)(&value));
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x000CFA7C File Offset: 0x000CDC7C
		// (set) Token: 0x060037B5 RID: 14261 RVA: 0x0002408E File Offset: 0x0002228E
		public unsafe static int elementId_button4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button4, (void*)(&value));
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x000CFA98 File Offset: 0x000CDC98
		// (set) Token: 0x060037B7 RID: 14263 RVA: 0x0002409C File Offset: 0x0002229C
		public unsafe static int elementId_button5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button5, (void*)(&value));
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x000CFAB4 File Offset: 0x000CDCB4
		// (set) Token: 0x060037B9 RID: 14265 RVA: 0x000240AA File Offset: 0x000222AA
		public unsafe static int elementId_button6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button6, (void*)(&value));
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x000CFAD0 File Offset: 0x000CDCD0
		// (set) Token: 0x060037BB RID: 14267 RVA: 0x000240B8 File Offset: 0x000222B8
		public unsafe static int elementId_button7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button7, (void*)(&value));
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x000CFAEC File Offset: 0x000CDCEC
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x000240C6 File Offset: 0x000222C6
		public unsafe static int elementId_button8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button8, (void*)(&value));
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x000CFB08 File Offset: 0x000CDD08
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x000240D4 File Offset: 0x000222D4
		public unsafe static int elementId_button9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button9, (void*)(&value));
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x000CFB24 File Offset: 0x000CDD24
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x000240E2 File Offset: 0x000222E2
		public unsafe static int elementId_button10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button10, (void*)(&value));
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x000CFB40 File Offset: 0x000CDD40
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x000240F0 File Offset: 0x000222F0
		public unsafe static int elementId_button11
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button11, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button11, (void*)(&value));
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x000CFB5C File Offset: 0x000CDD5C
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x000240FE File Offset: 0x000222FE
		public unsafe static int elementId_button12
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button12, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button12, (void*)(&value));
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x000CFB78 File Offset: 0x000CDD78
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x0002410C File Offset: 0x0002230C
		public unsafe static int elementId_button13
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button13, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button13, (void*)(&value));
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x000CFB94 File Offset: 0x000CDD94
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x0002411A File Offset: 0x0002231A
		public unsafe static int elementId_button14
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button14, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button14, (void*)(&value));
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x000CFBB0 File Offset: 0x000CDDB0
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x00024128 File Offset: 0x00022328
		public unsafe static int elementId_button15
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button15, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button15, (void*)(&value));
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060037CC RID: 14284 RVA: 0x000CFBCC File Offset: 0x000CDDCC
		// (set) Token: 0x060037CD RID: 14285 RVA: 0x00024136 File Offset: 0x00022336
		public unsafe static int elementId_button16
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button16, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button16, (void*)(&value));
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060037CE RID: 14286 RVA: 0x000CFBE8 File Offset: 0x000CDDE8
		// (set) Token: 0x060037CF RID: 14287 RVA: 0x00024144 File Offset: 0x00022344
		public unsafe static int elementId_button17
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button17, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button17, (void*)(&value));
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x000CFC04 File Offset: 0x000CDE04
		// (set) Token: 0x060037D1 RID: 14289 RVA: 0x00024152 File Offset: 0x00022352
		public unsafe static int elementId_button18
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button18, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button18, (void*)(&value));
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x060037D2 RID: 14290 RVA: 0x000CFC20 File Offset: 0x000CDE20
		// (set) Token: 0x060037D3 RID: 14291 RVA: 0x00024160 File Offset: 0x00022360
		public unsafe static int elementId_button19
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button19, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button19, (void*)(&value));
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x000CFC3C File Offset: 0x000CDE3C
		// (set) Token: 0x060037D5 RID: 14293 RVA: 0x0002416E File Offset: 0x0002236E
		public unsafe static int elementId_button20
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button20, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button20, (void*)(&value));
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x060037D6 RID: 14294 RVA: 0x000CFC58 File Offset: 0x000CDE58
		// (set) Token: 0x060037D7 RID: 14295 RVA: 0x0002417C File Offset: 0x0002237C
		public unsafe static int elementId_button21
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button21, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button21, (void*)(&value));
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x060037D8 RID: 14296 RVA: 0x000CFC74 File Offset: 0x000CDE74
		// (set) Token: 0x060037D9 RID: 14297 RVA: 0x0002418A File Offset: 0x0002238A
		public unsafe static int elementId_button22
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button22, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button22, (void*)(&value));
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x000CFC90 File Offset: 0x000CDE90
		// (set) Token: 0x060037DB RID: 14299 RVA: 0x00024198 File Offset: 0x00022398
		public unsafe static int elementId_button23
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button23, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button23, (void*)(&value));
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x000CFCAC File Offset: 0x000CDEAC
		// (set) Token: 0x060037DD RID: 14301 RVA: 0x000241A6 File Offset: 0x000223A6
		public unsafe static int elementId_button24
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button24, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button24, (void*)(&value));
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x000CFCC8 File Offset: 0x000CDEC8
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x000241B4 File Offset: 0x000223B4
		public unsafe static int elementId_button25
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button25, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button25, (void*)(&value));
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x000CFCE4 File Offset: 0x000CDEE4
		// (set) Token: 0x060037E1 RID: 14305 RVA: 0x000241C2 File Offset: 0x000223C2
		public unsafe static int elementId_button26
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button26, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button26, (void*)(&value));
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x000CFD00 File Offset: 0x000CDF00
		// (set) Token: 0x060037E3 RID: 14307 RVA: 0x000241D0 File Offset: 0x000223D0
		public unsafe static int elementId_button27
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button27, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button27, (void*)(&value));
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x000CFD1C File Offset: 0x000CDF1C
		// (set) Token: 0x060037E5 RID: 14309 RVA: 0x000241DE File Offset: 0x000223DE
		public unsafe static int elementId_button28
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button28, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button28, (void*)(&value));
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x000CFD38 File Offset: 0x000CDF38
		// (set) Token: 0x060037E7 RID: 14311 RVA: 0x000241EC File Offset: 0x000223EC
		public unsafe static int elementId_button29
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button29, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button29, (void*)(&value));
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x000CFD54 File Offset: 0x000CDF54
		// (set) Token: 0x060037E9 RID: 14313 RVA: 0x000241FA File Offset: 0x000223FA
		public unsafe static int elementId_button30
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button30, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button30, (void*)(&value));
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x000CFD70 File Offset: 0x000CDF70
		// (set) Token: 0x060037EB RID: 14315 RVA: 0x00024208 File Offset: 0x00022408
		public unsafe static int elementId_button31
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button31, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button31, (void*)(&value));
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x000CFD8C File Offset: 0x000CDF8C
		// (set) Token: 0x060037ED RID: 14317 RVA: 0x00024216 File Offset: 0x00022416
		public unsafe static int elementId_button32
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button32, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_button32, (void*)(&value));
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x060037EE RID: 14318 RVA: 0x000CFDA8 File Offset: 0x000CDFA8
		// (set) Token: 0x060037EF RID: 14319 RVA: 0x00024224 File Offset: 0x00022424
		public unsafe static int elementId_hat1Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Up, (void*)(&value));
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x000CFDC4 File Offset: 0x000CDFC4
		// (set) Token: 0x060037F1 RID: 14321 RVA: 0x00024232 File Offset: 0x00022432
		public unsafe static int elementId_hat1UpRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpRight, (void*)(&value));
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
		// (set) Token: 0x060037F3 RID: 14323 RVA: 0x00024240 File Offset: 0x00022440
		public unsafe static int elementId_hat1Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Right, (void*)(&value));
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x000CFDFC File Offset: 0x000CDFFC
		// (set) Token: 0x060037F5 RID: 14325 RVA: 0x0002424E File Offset: 0x0002244E
		public unsafe static int elementId_hat1DownRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownRight, (void*)(&value));
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x060037F6 RID: 14326 RVA: 0x000CFE18 File Offset: 0x000CE018
		// (set) Token: 0x060037F7 RID: 14327 RVA: 0x0002425C File Offset: 0x0002245C
		public unsafe static int elementId_hat1Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Down, (void*)(&value));
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x060037F8 RID: 14328 RVA: 0x000CFE34 File Offset: 0x000CE034
		// (set) Token: 0x060037F9 RID: 14329 RVA: 0x0002426A File Offset: 0x0002246A
		public unsafe static int elementId_hat1DownLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1DownLeft, (void*)(&value));
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x060037FA RID: 14330 RVA: 0x000CFE50 File Offset: 0x000CE050
		// (set) Token: 0x060037FB RID: 14331 RVA: 0x00024278 File Offset: 0x00022478
		public unsafe static int elementId_hat1Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1Left, (void*)(&value));
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x000CFE6C File Offset: 0x000CE06C
		// (set) Token: 0x060037FD RID: 14333 RVA: 0x00024286 File Offset: 0x00022486
		public unsafe static int elementId_hat1UpLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1UpLeft, (void*)(&value));
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x000CFE88 File Offset: 0x000CE088
		// (set) Token: 0x060037FF RID: 14335 RVA: 0x00024294 File Offset: 0x00022494
		public unsafe static int elementId_hat2Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Up, (void*)(&value));
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x000CFEA4 File Offset: 0x000CE0A4
		// (set) Token: 0x06003801 RID: 14337 RVA: 0x000242A2 File Offset: 0x000224A2
		public unsafe static int elementId_hat2UpRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpRight, (void*)(&value));
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x000CFEC0 File Offset: 0x000CE0C0
		// (set) Token: 0x06003803 RID: 14339 RVA: 0x000242B0 File Offset: 0x000224B0
		public unsafe static int elementId_hat2Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Right, (void*)(&value));
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x000CFEDC File Offset: 0x000CE0DC
		// (set) Token: 0x06003805 RID: 14341 RVA: 0x000242BE File Offset: 0x000224BE
		public unsafe static int elementId_hat2DownRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownRight, (void*)(&value));
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x000CFEF8 File Offset: 0x000CE0F8
		// (set) Token: 0x06003807 RID: 14343 RVA: 0x000242CC File Offset: 0x000224CC
		public unsafe static int elementId_hat2Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Down, (void*)(&value));
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x000CFF14 File Offset: 0x000CE114
		// (set) Token: 0x06003809 RID: 14345 RVA: 0x000242DA File Offset: 0x000224DA
		public unsafe static int elementId_hat2DownLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2DownLeft, (void*)(&value));
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x000CFF30 File Offset: 0x000CE130
		// (set) Token: 0x0600380B RID: 14347 RVA: 0x000242E8 File Offset: 0x000224E8
		public unsafe static int elementId_hat2Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2Left, (void*)(&value));
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x000CFF4C File Offset: 0x000CE14C
		// (set) Token: 0x0600380D RID: 14349 RVA: 0x000242F6 File Offset: 0x000224F6
		public unsafe static int elementId_hat2UpLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2UpLeft, (void*)(&value));
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x000CFF68 File Offset: 0x000CE168
		// (set) Token: 0x0600380F RID: 14351 RVA: 0x00024304 File Offset: 0x00022504
		public unsafe static int elementId_hat1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat1, (void*)(&value));
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x000CFF84 File Offset: 0x000CE184
		// (set) Token: 0x06003811 RID: 14353 RVA: 0x00024312 File Offset: 0x00022512
		public unsafe static int elementId_hat2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_hat2, (void*)(&value));
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06003812 RID: 14354 RVA: 0x000CFFA0 File Offset: 0x000CE1A0
		// (set) Token: 0x06003813 RID: 14355 RVA: 0x00024320 File Offset: 0x00022520
		public unsafe static int elementId_throttle1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*)(&value));
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x000CFFBC File Offset: 0x000CE1BC
		// (set) Token: 0x06003815 RID: 14357 RVA: 0x0002432E File Offset: 0x0002252E
		public unsafe static int elementId_throttle2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*)(&value));
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x000CFFD8 File Offset: 0x000CE1D8
		// (set) Token: 0x06003817 RID: 14359 RVA: 0x0002433C File Offset: 0x0002253C
		public unsafe static int elementId_stick
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_stick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SixDofControllerTemplate.NativeFieldInfoPtr_elementId_stick, (void*)(&value));
			}
		}

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_typeGuid;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_elementId_positionX;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr_elementId_positionY;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeFieldInfoPtr_elementId_positionZ;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rotationX;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rotationY;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rotationZ;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle1Axis;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle1MinDetent;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle2Axis;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle2MinDetent;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_elementId_extraAxis1;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr_elementId_extraAxis2;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_elementId_extraAxis3;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeFieldInfoPtr_elementId_extraAxis4;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button1;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button2;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button3;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button4;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button5;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button6;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button7;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button8;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button9;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button10;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button11;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button12;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button13;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button14;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button15;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button16;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button17;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button18;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button19;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button20;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button21;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button22;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button23;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button24;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button25;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button26;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button27;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button28;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button29;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button30;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button31;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeFieldInfoPtr_elementId_button32;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1Up;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1UpRight;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1Right;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1DownRight;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1Down;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1DownLeft;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1Left;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1UpLeft;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2Up;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2UpRight;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2Right;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2DownRight;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2Down;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2DownLeft;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2Left;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2UpLeft;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat1;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeFieldInfoPtr_elementId_hat2;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle1;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle2;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stick;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
	}
}
