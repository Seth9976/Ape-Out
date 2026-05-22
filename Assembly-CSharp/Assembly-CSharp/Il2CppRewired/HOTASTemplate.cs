using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x020001DF RID: 479
	public sealed class HOTASTemplate : ControllerTemplate
	{
		// Token: 0x060034D9 RID: 13529 RVA: 0x000C8680 File Offset: 0x000C6880
		// Note: this type is marked as 'beforefieldinit'.
		static HOTASTemplate()
		{
			Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "HOTASTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr);
			HOTASTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "typeGuid");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickX");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickY");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickRotate");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1X");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1Y");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1Press");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2X");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2Y");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2Press");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickTrigger");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickTriggerStage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickTriggerStage2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickPinkyButton");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickPinkyTrigger");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton4");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton5");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton6");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton7");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton8");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton9");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton10");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton4");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton5");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton6");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton7");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton8");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton9");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton10");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton11");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton12");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1UpRight");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1DownRight");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1DownLeft");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Up_right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Down_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Down_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Up_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Down_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Down_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Up_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Down_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Down_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_mode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_mode1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_mode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_mode2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_mode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_mode3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle1Axis");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle2Axis");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle1MinDetent");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle2MinDetent");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton4");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton5");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton6");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton7");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton8");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton9");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton10");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton4");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton5");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton6");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton7");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton8");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton9");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton10");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton11");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton12");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton13");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton14");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton15");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider4");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial4");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStickX");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStickY");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStickPress");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel1Forward");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel1Back");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel1Press");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel2Forward");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel2Back");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel2Press");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel3Forward");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel3Back");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel3Press");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Up_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Down_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Down_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Up_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Down_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Down_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Up_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Down_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Down_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Up");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Up_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Down_Right");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Down");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Down_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Up_Left");
			HOTASTemplate.NativeFieldInfoPtr_elementId_leftPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_leftPedal");
			HOTASTemplate.NativeFieldInfoPtr_elementId_rightPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_rightPedal");
			HOTASTemplate.NativeFieldInfoPtr_elementId_slidePedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_slidePedals");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stick");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStick");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3");
			HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4");
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667582);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667583);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667584);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667585);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667586);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667587);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667588);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667589);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667590);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667591);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667592);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667593);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667594);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667595);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667596);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667597);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667598);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667599);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667600);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667601);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667602);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667603);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667604);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667605);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667606);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667607);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667608);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667609);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667610);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667611);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667612);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667613);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667614);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667615);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667616);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667617);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667618);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667619);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667620);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667621);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667622);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667623);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667624);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667625);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667626);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667627);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667628);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667629);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667630);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667631);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667632);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667633);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667634);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667635);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667636);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667637);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667638);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667639);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667640);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667641);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667642);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667643);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667644);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667645);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667646);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667647);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667648);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667649);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667650);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667651);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667652);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667653);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667654);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667655);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667656);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667657);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667658);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667659);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667660);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667661);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667662);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667663);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667664);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667665);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667666);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667667);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667668);
			HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667669);
			HOTASTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100667670);
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x000C9AD8 File Offset: 0x000C7CD8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickTrigger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86395, XrefRangeEnd = 86398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x000C9B18 File Offset: 0x000C7D18
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickTriggerStage2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86398, XrefRangeEnd = 86401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x000C9B58 File Offset: 0x000C7D58
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyButton
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86401, XrefRangeEnd = 86404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x000C9B98 File Offset: 0x000C7D98
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyTrigger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86404, XrefRangeEnd = 86407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x000C9BD8 File Offset: 0x000C7DD8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86407, XrefRangeEnd = 86410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060034DF RID: 13535 RVA: 0x000C9C18 File Offset: 0x000C7E18
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86410, XrefRangeEnd = 86413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x060034E0 RID: 13536 RVA: 0x000C9C58 File Offset: 0x000C7E58
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86413, XrefRangeEnd = 86416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x060034E1 RID: 13537 RVA: 0x000C9C98 File Offset: 0x000C7E98
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86416, XrefRangeEnd = 86419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x000C9CD8 File Offset: 0x000C7ED8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86419, XrefRangeEnd = 86422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060034E3 RID: 13539 RVA: 0x000C9D18 File Offset: 0x000C7F18
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86422, XrefRangeEnd = 86425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x000C9D58 File Offset: 0x000C7F58
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86425, XrefRangeEnd = 86428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060034E5 RID: 13541 RVA: 0x000C9D98 File Offset: 0x000C7F98
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86428, XrefRangeEnd = 86431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x000C9DD8 File Offset: 0x000C7FD8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86431, XrefRangeEnd = 86434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060034E7 RID: 13543 RVA: 0x000C9E18 File Offset: 0x000C8018
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickButton10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86434, XrefRangeEnd = 86437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x000C9E58 File Offset: 0x000C8058
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86437, XrefRangeEnd = 86440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x000C9E98 File Offset: 0x000C8098
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86440, XrefRangeEnd = 86443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x000C9ED8 File Offset: 0x000C80D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86443, XrefRangeEnd = 86446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x000C9F18 File Offset: 0x000C8118
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86446, XrefRangeEnd = 86449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x000C9F58 File Offset: 0x000C8158
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86449, XrefRangeEnd = 86452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060034ED RID: 13549 RVA: 0x000C9F98 File Offset: 0x000C8198
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86452, XrefRangeEnd = 86455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x000C9FD8 File Offset: 0x000C81D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86455, XrefRangeEnd = 86458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x000CA018 File Offset: 0x000C8218
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86458, XrefRangeEnd = 86461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x000CA058 File Offset: 0x000C8258
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86461, XrefRangeEnd = 86464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060034F1 RID: 13553 RVA: 0x000CA098 File Offset: 0x000C8298
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86464, XrefRangeEnd = 86467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x000CA0D8 File Offset: 0x000C82D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton11
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86467, XrefRangeEnd = 86470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060034F3 RID: 13555 RVA: 0x000CA118 File Offset: 0x000C8318
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton12
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86470, XrefRangeEnd = 86473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x000CA158 File Offset: 0x000C8358
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.mode1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86473, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060034F5 RID: 13557 RVA: 0x000CA198 File Offset: 0x000C8398
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.mode2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86476, XrefRangeEnd = 86479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x000CA1D8 File Offset: 0x000C83D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.mode3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86479, XrefRangeEnd = 86482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x000CA218 File Offset: 0x000C8418
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86482, XrefRangeEnd = 86485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x000CA258 File Offset: 0x000C8458
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86485, XrefRangeEnd = 86488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x000CA298 File Offset: 0x000C8498
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86488, XrefRangeEnd = 86491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x000CA2D8 File Offset: 0x000C84D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86491, XrefRangeEnd = 86494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x000CA318 File Offset: 0x000C8518
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86494, XrefRangeEnd = 86497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x000CA358 File Offset: 0x000C8558
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86497, XrefRangeEnd = 86500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x060034FD RID: 13565 RVA: 0x000CA398 File Offset: 0x000C8598
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86500, XrefRangeEnd = 86503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x000CA3D8 File Offset: 0x000C85D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86503, XrefRangeEnd = 86506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x060034FF RID: 13567 RVA: 0x000CA418 File Offset: 0x000C8618
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86506, XrefRangeEnd = 86509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x000CA458 File Offset: 0x000C8658
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86509, XrefRangeEnd = 86512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x000CA498 File Offset: 0x000C8698
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86512, XrefRangeEnd = 86515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x000CA4D8 File Offset: 0x000C86D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86515, XrefRangeEnd = 86518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06003503 RID: 13571 RVA: 0x000CA518 File Offset: 0x000C8718
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86518, XrefRangeEnd = 86521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x000CA558 File Offset: 0x000C8758
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86521, XrefRangeEnd = 86524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x000CA598 File Offset: 0x000C8798
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton5
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86524, XrefRangeEnd = 86527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x000CA5D8 File Offset: 0x000C87D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton6
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86527, XrefRangeEnd = 86530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x000CA618 File Offset: 0x000C8818
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton7
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86530, XrefRangeEnd = 86533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x000CA658 File Offset: 0x000C8858
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton8
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86533, XrefRangeEnd = 86536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x000CA698 File Offset: 0x000C8898
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton9
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86536, XrefRangeEnd = 86539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x000CA6D8 File Offset: 0x000C88D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton10
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86539, XrefRangeEnd = 86542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x000CA718 File Offset: 0x000C8918
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton11
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86542, XrefRangeEnd = 86545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000CA758 File Offset: 0x000C8958
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton12
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86545, XrefRangeEnd = 86548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x000CA798 File Offset: 0x000C8998
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton13
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86548, XrefRangeEnd = 86551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000CA7D8 File Offset: 0x000C89D8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton14
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86551, XrefRangeEnd = 86554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x000CA818 File Offset: 0x000C8A18
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton15
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86554, XrefRangeEnd = 86557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000CA858 File Offset: 0x000C8A58
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86557, XrefRangeEnd = 86560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x000CA898 File Offset: 0x000C8A98
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86560, XrefRangeEnd = 86563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x000CA8D8 File Offset: 0x000C8AD8
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86563, XrefRangeEnd = 86566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x000CA918 File Offset: 0x000C8B18
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86566, XrefRangeEnd = 86569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x000CA958 File Offset: 0x000C8B58
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86569, XrefRangeEnd = 86572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x000CA998 File Offset: 0x000C8B98
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86572, XrefRangeEnd = 86575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x000CA9D8 File Offset: 0x000C8BD8
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86575, XrefRangeEnd = 86578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x000CAA18 File Offset: 0x000C8C18
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86578, XrefRangeEnd = 86581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x000CAA58 File Offset: 0x000C8C58
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Forward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86581, XrefRangeEnd = 86584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x000CAA98 File Offset: 0x000C8C98
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Back
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86584, XrefRangeEnd = 86587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x000CAAD8 File Offset: 0x000C8CD8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Press
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86587, XrefRangeEnd = 86590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x000CAB18 File Offset: 0x000C8D18
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Forward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86590, XrefRangeEnd = 86593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x000CAB58 File Offset: 0x000C8D58
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Back
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86593, XrefRangeEnd = 86596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x000CAB98 File Offset: 0x000C8D98
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Press
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86596, XrefRangeEnd = 86599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x000CABD8 File Offset: 0x000C8DD8
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Forward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86599, XrefRangeEnd = 86602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x000CAC18 File Offset: 0x000C8E18
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Back
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86602, XrefRangeEnd = 86605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x000CAC58 File Offset: 0x000C8E58
		public unsafe IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Press
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86605, XrefRangeEnd = 86608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06003521 RID: 13601 RVA: 0x000CAC98 File Offset: 0x000C8E98
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.leftPedal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86608, XrefRangeEnd = 86611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x000CACD8 File Offset: 0x000C8ED8
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.rightPedal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86611, XrefRangeEnd = 86614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x000CAD18 File Offset: 0x000C8F18
		public unsafe IControllerTemplateAxis Rewired.IHOTASTemplate.slidePedals
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86614, XrefRangeEnd = 86617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x000CAD58 File Offset: 0x000C8F58
		public unsafe IControllerTemplateStick Rewired.IHOTASTemplate.stick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86617, XrefRangeEnd = 86620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateStick>(intPtr3) : null;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x000CAD98 File Offset: 0x000C8F98
		public unsafe IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86620, XrefRangeEnd = 86623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr3) : null;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x000CADD8 File Offset: 0x000C8FD8
		public unsafe IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86623, XrefRangeEnd = 86626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr3) : null;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x000CAE18 File Offset: 0x000C9018
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.stickHat1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86626, XrefRangeEnd = 86629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x000CAE58 File Offset: 0x000C9058
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.stickHat2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86629, XrefRangeEnd = 86632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x000CAE98 File Offset: 0x000C9098
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.stickHat3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86632, XrefRangeEnd = 86635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x000CAED8 File Offset: 0x000C90D8
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.stickHat4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86635, XrefRangeEnd = 86638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x000CAF18 File Offset: 0x000C9118
		public unsafe IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86638, XrefRangeEnd = 86641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x000CAF58 File Offset: 0x000C9158
		public unsafe IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86641, XrefRangeEnd = 86644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr3) : null;
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x000CAF98 File Offset: 0x000C9198
		public unsafe IControllerTemplateThumbStick Rewired.IHOTASTemplate.throttleMiniStick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86644, XrefRangeEnd = 86647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr3) : null;
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x000CAFD8 File Offset: 0x000C91D8
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86647, XrefRangeEnd = 86650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x000CB018 File Offset: 0x000C9218
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86650, XrefRangeEnd = 86653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x000CB058 File Offset: 0x000C9258
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat3
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86653, XrefRangeEnd = 86656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x000CB098 File Offset: 0x000C9298
		public unsafe IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat4
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86656, XrefRangeEnd = 86659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr3) : null;
			}
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x000CB0D8 File Offset: 0x000C92D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HOTASTemplate(Object payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HOTASTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x000231B4 File Offset: 0x000213B4
		public HOTASTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x000CB124 File Offset: 0x000C9324
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x000231BD File Offset: 0x000213BD
		public unsafe static Guid typeGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_typeGuid, (void*)(&value));
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x000CB140 File Offset: 0x000C9340
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x000231CB File Offset: 0x000213CB
		public unsafe static int elementId_stickX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickX, (void*)(&value));
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x000CB15C File Offset: 0x000C935C
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x000231D9 File Offset: 0x000213D9
		public unsafe static int elementId_stickY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickY, (void*)(&value));
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x000CB178 File Offset: 0x000C9378
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x000231E7 File Offset: 0x000213E7
		public unsafe static int elementId_stickRotate
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickRotate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickRotate, (void*)(&value));
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x0600353C RID: 13628 RVA: 0x000CB194 File Offset: 0x000C9394
		// (set) Token: 0x0600353D RID: 13629 RVA: 0x000231F5 File Offset: 0x000213F5
		public unsafe static int elementId_stickMiniStick1X
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1X, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1X, (void*)(&value));
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x000CB1B0 File Offset: 0x000C93B0
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x00023203 File Offset: 0x00021403
		public unsafe static int elementId_stickMiniStick1Y
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Y, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Y, (void*)(&value));
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x000CB1CC File Offset: 0x000C93CC
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x00023211 File Offset: 0x00021411
		public unsafe static int elementId_stickMiniStick1Press
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Press, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1Press, (void*)(&value));
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x000CB1E8 File Offset: 0x000C93E8
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x0002321F File Offset: 0x0002141F
		public unsafe static int elementId_stickMiniStick2X
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2X, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2X, (void*)(&value));
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x000CB204 File Offset: 0x000C9404
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x0002322D File Offset: 0x0002142D
		public unsafe static int elementId_stickMiniStick2Y
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Y, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Y, (void*)(&value));
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x000CB220 File Offset: 0x000C9420
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x0002323B File Offset: 0x0002143B
		public unsafe static int elementId_stickMiniStick2Press
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Press, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2Press, (void*)(&value));
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x000CB23C File Offset: 0x000C943C
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x00023249 File Offset: 0x00021449
		public unsafe static int elementId_stickTrigger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTrigger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTrigger, (void*)(&value));
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x000CB258 File Offset: 0x000C9458
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x00023257 File Offset: 0x00021457
		public unsafe static int elementId_stickTriggerStage2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTriggerStage2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickTriggerStage2, (void*)(&value));
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x000CB274 File Offset: 0x000C9474
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x00023265 File Offset: 0x00021465
		public unsafe static int elementId_stickPinkyButton
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyButton, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyButton, (void*)(&value));
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x000CB290 File Offset: 0x000C9490
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x00023273 File Offset: 0x00021473
		public unsafe static int elementId_stickPinkyTrigger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyTrigger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickPinkyTrigger, (void*)(&value));
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x000CB2AC File Offset: 0x000C94AC
		// (set) Token: 0x06003551 RID: 13649 RVA: 0x00023281 File Offset: 0x00021481
		public unsafe static int elementId_stickButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton1, (void*)(&value));
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x000CB2C8 File Offset: 0x000C94C8
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x0002328F File Offset: 0x0002148F
		public unsafe static int elementId_stickButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton2, (void*)(&value));
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x000CB2E4 File Offset: 0x000C94E4
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x0002329D File Offset: 0x0002149D
		public unsafe static int elementId_stickButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton3, (void*)(&value));
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x000CB300 File Offset: 0x000C9500
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x000232AB File Offset: 0x000214AB
		public unsafe static int elementId_stickButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton4, (void*)(&value));
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x000CB31C File Offset: 0x000C951C
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x000232B9 File Offset: 0x000214B9
		public unsafe static int elementId_stickButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton5, (void*)(&value));
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x000CB338 File Offset: 0x000C9538
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x000232C7 File Offset: 0x000214C7
		public unsafe static int elementId_stickButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton6, (void*)(&value));
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x000CB354 File Offset: 0x000C9554
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x000232D5 File Offset: 0x000214D5
		public unsafe static int elementId_stickButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton7, (void*)(&value));
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x000CB370 File Offset: 0x000C9570
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x000232E3 File Offset: 0x000214E3
		public unsafe static int elementId_stickButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton8, (void*)(&value));
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x000CB38C File Offset: 0x000C958C
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x000232F1 File Offset: 0x000214F1
		public unsafe static int elementId_stickButton9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton9, (void*)(&value));
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x000CB3A8 File Offset: 0x000C95A8
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x000232FF File Offset: 0x000214FF
		public unsafe static int elementId_stickButton10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickButton10, (void*)(&value));
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x000CB3C4 File Offset: 0x000C95C4
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x0002330D File Offset: 0x0002150D
		public unsafe static int elementId_stickBaseButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton1, (void*)(&value));
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x000CB3E0 File Offset: 0x000C95E0
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x0002331B File Offset: 0x0002151B
		public unsafe static int elementId_stickBaseButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton2, (void*)(&value));
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x000CB3FC File Offset: 0x000C95FC
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x00023329 File Offset: 0x00021529
		public unsafe static int elementId_stickBaseButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton3, (void*)(&value));
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x000CB418 File Offset: 0x000C9618
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00023337 File Offset: 0x00021537
		public unsafe static int elementId_stickBaseButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton4, (void*)(&value));
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x000CB434 File Offset: 0x000C9634
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x00023345 File Offset: 0x00021545
		public unsafe static int elementId_stickBaseButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton5, (void*)(&value));
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x000CB450 File Offset: 0x000C9650
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x00023353 File Offset: 0x00021553
		public unsafe static int elementId_stickBaseButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton6, (void*)(&value));
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x000CB46C File Offset: 0x000C966C
		// (set) Token: 0x06003571 RID: 13681 RVA: 0x00023361 File Offset: 0x00021561
		public unsafe static int elementId_stickBaseButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton7, (void*)(&value));
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06003572 RID: 13682 RVA: 0x000CB488 File Offset: 0x000C9688
		// (set) Token: 0x06003573 RID: 13683 RVA: 0x0002336F File Offset: 0x0002156F
		public unsafe static int elementId_stickBaseButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton8, (void*)(&value));
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06003574 RID: 13684 RVA: 0x000CB4A4 File Offset: 0x000C96A4
		// (set) Token: 0x06003575 RID: 13685 RVA: 0x0002337D File Offset: 0x0002157D
		public unsafe static int elementId_stickBaseButton9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton9, (void*)(&value));
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x000CB4C0 File Offset: 0x000C96C0
		// (set) Token: 0x06003577 RID: 13687 RVA: 0x0002338B File Offset: 0x0002158B
		public unsafe static int elementId_stickBaseButton10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton10, (void*)(&value));
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x000CB4DC File Offset: 0x000C96DC
		// (set) Token: 0x06003579 RID: 13689 RVA: 0x00023399 File Offset: 0x00021599
		public unsafe static int elementId_stickBaseButton11
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton11, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton11, (void*)(&value));
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x000CB4F8 File Offset: 0x000C96F8
		// (set) Token: 0x0600357B RID: 13691 RVA: 0x000233A7 File Offset: 0x000215A7
		public unsafe static int elementId_stickBaseButton12
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton12, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickBaseButton12, (void*)(&value));
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x000CB514 File Offset: 0x000C9714
		// (set) Token: 0x0600357D RID: 13693 RVA: 0x000233B5 File Offset: 0x000215B5
		public unsafe static int elementId_stickHat1Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up, (void*)(&value));
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x000CB530 File Offset: 0x000C9730
		// (set) Token: 0x0600357F RID: 13695 RVA: 0x000233C3 File Offset: 0x000215C3
		public unsafe static int elementId_stickHat1UpRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1UpRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1UpRight, (void*)(&value));
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06003580 RID: 13696 RVA: 0x000CB54C File Offset: 0x000C974C
		// (set) Token: 0x06003581 RID: 13697 RVA: 0x000233D1 File Offset: 0x000215D1
		public unsafe static int elementId_stickHat1Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Right, (void*)(&value));
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x000CB568 File Offset: 0x000C9768
		// (set) Token: 0x06003583 RID: 13699 RVA: 0x000233DF File Offset: 0x000215DF
		public unsafe static int elementId_stickHat1DownRight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownRight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownRight, (void*)(&value));
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x000CB584 File Offset: 0x000C9784
		// (set) Token: 0x06003585 RID: 13701 RVA: 0x000233ED File Offset: 0x000215ED
		public unsafe static int elementId_stickHat1Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Down, (void*)(&value));
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x000CB5A0 File Offset: 0x000C97A0
		// (set) Token: 0x06003587 RID: 13703 RVA: 0x000233FB File Offset: 0x000215FB
		public unsafe static int elementId_stickHat1DownLeft
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownLeft, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1DownLeft, (void*)(&value));
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x000CB5BC File Offset: 0x000C97BC
		// (set) Token: 0x06003589 RID: 13705 RVA: 0x00023409 File Offset: 0x00021609
		public unsafe static int elementId_stickHat1Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Left, (void*)(&value));
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600358A RID: 13706 RVA: 0x000CB5D8 File Offset: 0x000C97D8
		// (set) Token: 0x0600358B RID: 13707 RVA: 0x00023417 File Offset: 0x00021617
		public unsafe static int elementId_stickHat1Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1Up_Left, (void*)(&value));
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600358C RID: 13708 RVA: 0x000CB5F4 File Offset: 0x000C97F4
		// (set) Token: 0x0600358D RID: 13709 RVA: 0x00023425 File Offset: 0x00021625
		public unsafe static int elementId_stickHat2Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up, (void*)(&value));
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600358E RID: 13710 RVA: 0x000CB610 File Offset: 0x000C9810
		// (set) Token: 0x0600358F RID: 13711 RVA: 0x00023433 File Offset: 0x00021633
		public unsafe static int elementId_stickHat2Up_right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_right, (void*)(&value));
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06003590 RID: 13712 RVA: 0x000CB62C File Offset: 0x000C982C
		// (set) Token: 0x06003591 RID: 13713 RVA: 0x00023441 File Offset: 0x00021641
		public unsafe static int elementId_stickHat2Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Right, (void*)(&value));
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x000CB648 File Offset: 0x000C9848
		// (set) Token: 0x06003593 RID: 13715 RVA: 0x0002344F File Offset: 0x0002164F
		public unsafe static int elementId_stickHat2Down_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Right, (void*)(&value));
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x000CB664 File Offset: 0x000C9864
		// (set) Token: 0x06003595 RID: 13717 RVA: 0x0002345D File Offset: 0x0002165D
		public unsafe static int elementId_stickHat2Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down, (void*)(&value));
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x000CB680 File Offset: 0x000C9880
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x0002346B File Offset: 0x0002166B
		public unsafe static int elementId_stickHat2Down_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Down_Left, (void*)(&value));
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x000CB69C File Offset: 0x000C989C
		// (set) Token: 0x06003599 RID: 13721 RVA: 0x00023479 File Offset: 0x00021679
		public unsafe static int elementId_stickHat2Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Left, (void*)(&value));
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x000CB6B8 File Offset: 0x000C98B8
		// (set) Token: 0x0600359B RID: 13723 RVA: 0x00023487 File Offset: 0x00021687
		public unsafe static int elementId_stickHat2Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2Up_Left, (void*)(&value));
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x000CB6D4 File Offset: 0x000C98D4
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x00023495 File Offset: 0x00021695
		public unsafe static int elementId_stickHat3Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up, (void*)(&value));
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x000CB6F0 File Offset: 0x000C98F0
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x000234A3 File Offset: 0x000216A3
		public unsafe static int elementId_stickHat3Up_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Right, (void*)(&value));
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x000CB70C File Offset: 0x000C990C
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x000234B1 File Offset: 0x000216B1
		public unsafe static int elementId_stickHat3Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Right, (void*)(&value));
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x000CB728 File Offset: 0x000C9928
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x000234BF File Offset: 0x000216BF
		public unsafe static int elementId_stickHat3Down_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Right, (void*)(&value));
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x000CB744 File Offset: 0x000C9944
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x000234CD File Offset: 0x000216CD
		public unsafe static int elementId_stickHat3Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down, (void*)(&value));
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x000CB760 File Offset: 0x000C9960
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x000234DB File Offset: 0x000216DB
		public unsafe static int elementId_stickHat3Down_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Down_Left, (void*)(&value));
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x000CB77C File Offset: 0x000C997C
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x000234E9 File Offset: 0x000216E9
		public unsafe static int elementId_stickHat3Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Left, (void*)(&value));
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x000CB798 File Offset: 0x000C9998
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x000234F7 File Offset: 0x000216F7
		public unsafe static int elementId_stickHat3Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3Up_Left, (void*)(&value));
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x000CB7B4 File Offset: 0x000C99B4
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x00023505 File Offset: 0x00021705
		public unsafe static int elementId_stickHat4Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up, (void*)(&value));
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x000CB7D0 File Offset: 0x000C99D0
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x00023513 File Offset: 0x00021713
		public unsafe static int elementId_stickHat4Up_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Right, (void*)(&value));
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x000CB7EC File Offset: 0x000C99EC
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x00023521 File Offset: 0x00021721
		public unsafe static int elementId_stickHat4Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Right, (void*)(&value));
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x000CB808 File Offset: 0x000C9A08
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x0002352F File Offset: 0x0002172F
		public unsafe static int elementId_stickHat4Down_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Right, (void*)(&value));
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000CB824 File Offset: 0x000C9A24
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x0002353D File Offset: 0x0002173D
		public unsafe static int elementId_stickHat4Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down, (void*)(&value));
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x000CB840 File Offset: 0x000C9A40
		// (set) Token: 0x060035B7 RID: 13751 RVA: 0x0002354B File Offset: 0x0002174B
		public unsafe static int elementId_stickHat4Down_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Down_Left, (void*)(&value));
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x000CB85C File Offset: 0x000C9A5C
		// (set) Token: 0x060035B9 RID: 13753 RVA: 0x00023559 File Offset: 0x00021759
		public unsafe static int elementId_stickHat4Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Left, (void*)(&value));
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x000CB878 File Offset: 0x000C9A78
		// (set) Token: 0x060035BB RID: 13755 RVA: 0x00023567 File Offset: 0x00021767
		public unsafe static int elementId_stickHat4Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4Up_Left, (void*)(&value));
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x000CB894 File Offset: 0x000C9A94
		// (set) Token: 0x060035BD RID: 13757 RVA: 0x00023575 File Offset: 0x00021775
		public unsafe static int elementId_mode1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode1, (void*)(&value));
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x000CB8B0 File Offset: 0x000C9AB0
		// (set) Token: 0x060035BF RID: 13759 RVA: 0x00023583 File Offset: 0x00021783
		public unsafe static int elementId_mode2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode2, (void*)(&value));
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x000CB8CC File Offset: 0x000C9ACC
		// (set) Token: 0x060035C1 RID: 13761 RVA: 0x00023591 File Offset: 0x00021791
		public unsafe static int elementId_mode3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_mode3, (void*)(&value));
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x000CB8E8 File Offset: 0x000C9AE8
		// (set) Token: 0x060035C3 RID: 13763 RVA: 0x0002359F File Offset: 0x0002179F
		public unsafe static int elementId_throttle1Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1Axis, (void*)(&value));
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000CB904 File Offset: 0x000C9B04
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x000235AD File Offset: 0x000217AD
		public unsafe static int elementId_throttle2Axis
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2Axis, (void*)(&value));
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000CB920 File Offset: 0x000C9B20
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x000235BB File Offset: 0x000217BB
		public unsafe static int elementId_throttle1MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*)(&value));
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x000CB93C File Offset: 0x000C9B3C
		// (set) Token: 0x060035C9 RID: 13769 RVA: 0x000235C9 File Offset: 0x000217C9
		public unsafe static int elementId_throttle2MinDetent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*)(&value));
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x000CB958 File Offset: 0x000C9B58
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x000235D7 File Offset: 0x000217D7
		public unsafe static int elementId_throttleButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton1, (void*)(&value));
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x000CB974 File Offset: 0x000C9B74
		// (set) Token: 0x060035CD RID: 13773 RVA: 0x000235E5 File Offset: 0x000217E5
		public unsafe static int elementId_throttleButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton2, (void*)(&value));
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x000CB990 File Offset: 0x000C9B90
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x000235F3 File Offset: 0x000217F3
		public unsafe static int elementId_throttleButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton3, (void*)(&value));
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x000CB9AC File Offset: 0x000C9BAC
		// (set) Token: 0x060035D1 RID: 13777 RVA: 0x00023601 File Offset: 0x00021801
		public unsafe static int elementId_throttleButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton4, (void*)(&value));
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x000CB9C8 File Offset: 0x000C9BC8
		// (set) Token: 0x060035D3 RID: 13779 RVA: 0x0002360F File Offset: 0x0002180F
		public unsafe static int elementId_throttleButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton5, (void*)(&value));
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x000CB9E4 File Offset: 0x000C9BE4
		// (set) Token: 0x060035D5 RID: 13781 RVA: 0x0002361D File Offset: 0x0002181D
		public unsafe static int elementId_throttleButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton6, (void*)(&value));
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000CBA00 File Offset: 0x000C9C00
		// (set) Token: 0x060035D7 RID: 13783 RVA: 0x0002362B File Offset: 0x0002182B
		public unsafe static int elementId_throttleButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton7, (void*)(&value));
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060035D8 RID: 13784 RVA: 0x000CBA1C File Offset: 0x000C9C1C
		// (set) Token: 0x060035D9 RID: 13785 RVA: 0x00023639 File Offset: 0x00021839
		public unsafe static int elementId_throttleButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton8, (void*)(&value));
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x000CBA38 File Offset: 0x000C9C38
		// (set) Token: 0x060035DB RID: 13787 RVA: 0x00023647 File Offset: 0x00021847
		public unsafe static int elementId_throttleButton9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton9, (void*)(&value));
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x000CBA54 File Offset: 0x000C9C54
		// (set) Token: 0x060035DD RID: 13789 RVA: 0x00023655 File Offset: 0x00021855
		public unsafe static int elementId_throttleButton10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleButton10, (void*)(&value));
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x000CBA70 File Offset: 0x000C9C70
		// (set) Token: 0x060035DF RID: 13791 RVA: 0x00023663 File Offset: 0x00021863
		public unsafe static int elementId_throttleBaseButton1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton1, (void*)(&value));
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x000CBA8C File Offset: 0x000C9C8C
		// (set) Token: 0x060035E1 RID: 13793 RVA: 0x00023671 File Offset: 0x00021871
		public unsafe static int elementId_throttleBaseButton2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton2, (void*)(&value));
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060035E2 RID: 13794 RVA: 0x000CBAA8 File Offset: 0x000C9CA8
		// (set) Token: 0x060035E3 RID: 13795 RVA: 0x0002367F File Offset: 0x0002187F
		public unsafe static int elementId_throttleBaseButton3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton3, (void*)(&value));
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x000CBAC4 File Offset: 0x000C9CC4
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x0002368D File Offset: 0x0002188D
		public unsafe static int elementId_throttleBaseButton4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton4, (void*)(&value));
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x000CBAE0 File Offset: 0x000C9CE0
		// (set) Token: 0x060035E7 RID: 13799 RVA: 0x0002369B File Offset: 0x0002189B
		public unsafe static int elementId_throttleBaseButton5
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton5, (void*)(&value));
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060035E8 RID: 13800 RVA: 0x000CBAFC File Offset: 0x000C9CFC
		// (set) Token: 0x060035E9 RID: 13801 RVA: 0x000236A9 File Offset: 0x000218A9
		public unsafe static int elementId_throttleBaseButton6
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton6, (void*)(&value));
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x000CBB18 File Offset: 0x000C9D18
		// (set) Token: 0x060035EB RID: 13803 RVA: 0x000236B7 File Offset: 0x000218B7
		public unsafe static int elementId_throttleBaseButton7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton7, (void*)(&value));
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060035EC RID: 13804 RVA: 0x000CBB34 File Offset: 0x000C9D34
		// (set) Token: 0x060035ED RID: 13805 RVA: 0x000236C5 File Offset: 0x000218C5
		public unsafe static int elementId_throttleBaseButton8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton8, (void*)(&value));
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x000CBB50 File Offset: 0x000C9D50
		// (set) Token: 0x060035EF RID: 13807 RVA: 0x000236D3 File Offset: 0x000218D3
		public unsafe static int elementId_throttleBaseButton9
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton9, (void*)(&value));
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x000CBB6C File Offset: 0x000C9D6C
		// (set) Token: 0x060035F1 RID: 13809 RVA: 0x000236E1 File Offset: 0x000218E1
		public unsafe static int elementId_throttleBaseButton10
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton10, (void*)(&value));
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x000CBB88 File Offset: 0x000C9D88
		// (set) Token: 0x060035F3 RID: 13811 RVA: 0x000236EF File Offset: 0x000218EF
		public unsafe static int elementId_throttleBaseButton11
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton11, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton11, (void*)(&value));
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x000CBBA4 File Offset: 0x000C9DA4
		// (set) Token: 0x060035F5 RID: 13813 RVA: 0x000236FD File Offset: 0x000218FD
		public unsafe static int elementId_throttleBaseButton12
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton12, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton12, (void*)(&value));
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x060035F6 RID: 13814 RVA: 0x000CBBC0 File Offset: 0x000C9DC0
		// (set) Token: 0x060035F7 RID: 13815 RVA: 0x0002370B File Offset: 0x0002190B
		public unsafe static int elementId_throttleBaseButton13
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton13, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton13, (void*)(&value));
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x000CBBDC File Offset: 0x000C9DDC
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x00023719 File Offset: 0x00021919
		public unsafe static int elementId_throttleBaseButton14
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton14, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton14, (void*)(&value));
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x000CBBF8 File Offset: 0x000C9DF8
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x00023727 File Offset: 0x00021927
		public unsafe static int elementId_throttleBaseButton15
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton15, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleBaseButton15, (void*)(&value));
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x000CBC14 File Offset: 0x000C9E14
		// (set) Token: 0x060035FD RID: 13821 RVA: 0x00023735 File Offset: 0x00021935
		public unsafe static int elementId_throttleSlider1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider1, (void*)(&value));
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x060035FE RID: 13822 RVA: 0x000CBC30 File Offset: 0x000C9E30
		// (set) Token: 0x060035FF RID: 13823 RVA: 0x00023743 File Offset: 0x00021943
		public unsafe static int elementId_throttleSlider2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider2, (void*)(&value));
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x000CBC4C File Offset: 0x000C9E4C
		// (set) Token: 0x06003601 RID: 13825 RVA: 0x00023751 File Offset: 0x00021951
		public unsafe static int elementId_throttleSlider3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider3, (void*)(&value));
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x000CBC68 File Offset: 0x000C9E68
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x0002375F File Offset: 0x0002195F
		public unsafe static int elementId_throttleSlider4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleSlider4, (void*)(&value));
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x000CBC84 File Offset: 0x000C9E84
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x0002376D File Offset: 0x0002196D
		public unsafe static int elementId_throttleDial1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial1, (void*)(&value));
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x000CBCA0 File Offset: 0x000C9EA0
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x0002377B File Offset: 0x0002197B
		public unsafe static int elementId_throttleDial2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial2, (void*)(&value));
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x000CBCBC File Offset: 0x000C9EBC
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x00023789 File Offset: 0x00021989
		public unsafe static int elementId_throttleDial3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial3, (void*)(&value));
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x000CBCD8 File Offset: 0x000C9ED8
		// (set) Token: 0x0600360B RID: 13835 RVA: 0x00023797 File Offset: 0x00021997
		public unsafe static int elementId_throttleDial4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleDial4, (void*)(&value));
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x000CBCF4 File Offset: 0x000C9EF4
		// (set) Token: 0x0600360D RID: 13837 RVA: 0x000237A5 File Offset: 0x000219A5
		public unsafe static int elementId_throttleMiniStickX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickX, (void*)(&value));
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x0600360E RID: 13838 RVA: 0x000CBD10 File Offset: 0x000C9F10
		// (set) Token: 0x0600360F RID: 13839 RVA: 0x000237B3 File Offset: 0x000219B3
		public unsafe static int elementId_throttleMiniStickY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickY, (void*)(&value));
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06003610 RID: 13840 RVA: 0x000CBD2C File Offset: 0x000C9F2C
		// (set) Token: 0x06003611 RID: 13841 RVA: 0x000237C1 File Offset: 0x000219C1
		public unsafe static int elementId_throttleMiniStickPress
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickPress, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStickPress, (void*)(&value));
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x000CBD48 File Offset: 0x000C9F48
		// (set) Token: 0x06003613 RID: 13843 RVA: 0x000237CF File Offset: 0x000219CF
		public unsafe static int elementId_throttleWheel1Forward
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Forward, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Forward, (void*)(&value));
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x000CBD64 File Offset: 0x000C9F64
		// (set) Token: 0x06003615 RID: 13845 RVA: 0x000237DD File Offset: 0x000219DD
		public unsafe static int elementId_throttleWheel1Back
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Back, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Back, (void*)(&value));
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06003616 RID: 13846 RVA: 0x000CBD80 File Offset: 0x000C9F80
		// (set) Token: 0x06003617 RID: 13847 RVA: 0x000237EB File Offset: 0x000219EB
		public unsafe static int elementId_throttleWheel1Press
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Press, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel1Press, (void*)(&value));
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x000CBD9C File Offset: 0x000C9F9C
		// (set) Token: 0x06003619 RID: 13849 RVA: 0x000237F9 File Offset: 0x000219F9
		public unsafe static int elementId_throttleWheel2Forward
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Forward, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Forward, (void*)(&value));
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x000CBDB8 File Offset: 0x000C9FB8
		// (set) Token: 0x0600361B RID: 13851 RVA: 0x00023807 File Offset: 0x00021A07
		public unsafe static int elementId_throttleWheel2Back
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Back, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Back, (void*)(&value));
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x000CBDD4 File Offset: 0x000C9FD4
		// (set) Token: 0x0600361D RID: 13853 RVA: 0x00023815 File Offset: 0x00021A15
		public unsafe static int elementId_throttleWheel2Press
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Press, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel2Press, (void*)(&value));
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x000CBDF0 File Offset: 0x000C9FF0
		// (set) Token: 0x0600361F RID: 13855 RVA: 0x00023823 File Offset: 0x00021A23
		public unsafe static int elementId_throttleWheel3Forward
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Forward, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Forward, (void*)(&value));
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x000CBE0C File Offset: 0x000CA00C
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x00023831 File Offset: 0x00021A31
		public unsafe static int elementId_throttleWheel3Back
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Back, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Back, (void*)(&value));
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x000CBE28 File Offset: 0x000CA028
		// (set) Token: 0x06003623 RID: 13859 RVA: 0x0002383F File Offset: 0x00021A3F
		public unsafe static int elementId_throttleWheel3Press
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Press, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleWheel3Press, (void*)(&value));
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x000CBE44 File Offset: 0x000CA044
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x0002384D File Offset: 0x00021A4D
		public unsafe static int elementId_throttleHat1Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up, (void*)(&value));
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x000CBE60 File Offset: 0x000CA060
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x0002385B File Offset: 0x00021A5B
		public unsafe static int elementId_throttleHat1Up_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Right, (void*)(&value));
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x000CBE7C File Offset: 0x000CA07C
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x00023869 File Offset: 0x00021A69
		public unsafe static int elementId_throttleHat1Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Right, (void*)(&value));
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x000CBE98 File Offset: 0x000CA098
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x00023877 File Offset: 0x00021A77
		public unsafe static int elementId_throttleHat1Down_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Right, (void*)(&value));
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x000CBEB4 File Offset: 0x000CA0B4
		// (set) Token: 0x0600362D RID: 13869 RVA: 0x00023885 File Offset: 0x00021A85
		public unsafe static int elementId_throttleHat1Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down, (void*)(&value));
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x0600362E RID: 13870 RVA: 0x000CBED0 File Offset: 0x000CA0D0
		// (set) Token: 0x0600362F RID: 13871 RVA: 0x00023893 File Offset: 0x00021A93
		public unsafe static int elementId_throttleHat1Down_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Down_Left, (void*)(&value));
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06003630 RID: 13872 RVA: 0x000CBEEC File Offset: 0x000CA0EC
		// (set) Token: 0x06003631 RID: 13873 RVA: 0x000238A1 File Offset: 0x00021AA1
		public unsafe static int elementId_throttleHat1Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Left, (void*)(&value));
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x000CBF08 File Offset: 0x000CA108
		// (set) Token: 0x06003633 RID: 13875 RVA: 0x000238AF File Offset: 0x00021AAF
		public unsafe static int elementId_throttleHat1Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1Up_Left, (void*)(&value));
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06003634 RID: 13876 RVA: 0x000CBF24 File Offset: 0x000CA124
		// (set) Token: 0x06003635 RID: 13877 RVA: 0x000238BD File Offset: 0x00021ABD
		public unsafe static int elementId_throttleHat2Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up, (void*)(&value));
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x000CBF40 File Offset: 0x000CA140
		// (set) Token: 0x06003637 RID: 13879 RVA: 0x000238CB File Offset: 0x00021ACB
		public unsafe static int elementId_throttleHat2Up_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Right, (void*)(&value));
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x000CBF5C File Offset: 0x000CA15C
		// (set) Token: 0x06003639 RID: 13881 RVA: 0x000238D9 File Offset: 0x00021AD9
		public unsafe static int elementId_throttleHat2Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Right, (void*)(&value));
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x0600363A RID: 13882 RVA: 0x000CBF78 File Offset: 0x000CA178
		// (set) Token: 0x0600363B RID: 13883 RVA: 0x000238E7 File Offset: 0x00021AE7
		public unsafe static int elementId_throttleHat2Down_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Right, (void*)(&value));
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x0600363C RID: 13884 RVA: 0x000CBF94 File Offset: 0x000CA194
		// (set) Token: 0x0600363D RID: 13885 RVA: 0x000238F5 File Offset: 0x00021AF5
		public unsafe static int elementId_throttleHat2Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down, (void*)(&value));
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x000CBFB0 File Offset: 0x000CA1B0
		// (set) Token: 0x0600363F RID: 13887 RVA: 0x00023903 File Offset: 0x00021B03
		public unsafe static int elementId_throttleHat2Down_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Down_Left, (void*)(&value));
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x000CBFCC File Offset: 0x000CA1CC
		// (set) Token: 0x06003641 RID: 13889 RVA: 0x00023911 File Offset: 0x00021B11
		public unsafe static int elementId_throttleHat2Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Left, (void*)(&value));
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06003642 RID: 13890 RVA: 0x000CBFE8 File Offset: 0x000CA1E8
		// (set) Token: 0x06003643 RID: 13891 RVA: 0x0002391F File Offset: 0x00021B1F
		public unsafe static int elementId_throttleHat2Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2Up_Left, (void*)(&value));
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06003644 RID: 13892 RVA: 0x000CC004 File Offset: 0x000CA204
		// (set) Token: 0x06003645 RID: 13893 RVA: 0x0002392D File Offset: 0x00021B2D
		public unsafe static int elementId_throttleHat3Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up, (void*)(&value));
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06003646 RID: 13894 RVA: 0x000CC020 File Offset: 0x000CA220
		// (set) Token: 0x06003647 RID: 13895 RVA: 0x0002393B File Offset: 0x00021B3B
		public unsafe static int elementId_throttleHat3Up_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Right, (void*)(&value));
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06003648 RID: 13896 RVA: 0x000CC03C File Offset: 0x000CA23C
		// (set) Token: 0x06003649 RID: 13897 RVA: 0x00023949 File Offset: 0x00021B49
		public unsafe static int elementId_throttleHat3Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Right, (void*)(&value));
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x000CC058 File Offset: 0x000CA258
		// (set) Token: 0x0600364B RID: 13899 RVA: 0x00023957 File Offset: 0x00021B57
		public unsafe static int elementId_throttleHat3Down_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Right, (void*)(&value));
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x000CC074 File Offset: 0x000CA274
		// (set) Token: 0x0600364D RID: 13901 RVA: 0x00023965 File Offset: 0x00021B65
		public unsafe static int elementId_throttleHat3Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down, (void*)(&value));
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x000CC090 File Offset: 0x000CA290
		// (set) Token: 0x0600364F RID: 13903 RVA: 0x00023973 File Offset: 0x00021B73
		public unsafe static int elementId_throttleHat3Down_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Down_Left, (void*)(&value));
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06003650 RID: 13904 RVA: 0x000CC0AC File Offset: 0x000CA2AC
		// (set) Token: 0x06003651 RID: 13905 RVA: 0x00023981 File Offset: 0x00021B81
		public unsafe static int elementId_throttleHat3Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Left, (void*)(&value));
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06003652 RID: 13906 RVA: 0x000CC0C8 File Offset: 0x000CA2C8
		// (set) Token: 0x06003653 RID: 13907 RVA: 0x0002398F File Offset: 0x00021B8F
		public unsafe static int elementId_throttleHat3Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3Up_Left, (void*)(&value));
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x000CC0E4 File Offset: 0x000CA2E4
		// (set) Token: 0x06003655 RID: 13909 RVA: 0x0002399D File Offset: 0x00021B9D
		public unsafe static int elementId_throttleHat4Up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up, (void*)(&value));
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06003656 RID: 13910 RVA: 0x000CC100 File Offset: 0x000CA300
		// (set) Token: 0x06003657 RID: 13911 RVA: 0x000239AB File Offset: 0x00021BAB
		public unsafe static int elementId_throttleHat4Up_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Right, (void*)(&value));
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x000CC11C File Offset: 0x000CA31C
		// (set) Token: 0x06003659 RID: 13913 RVA: 0x000239B9 File Offset: 0x00021BB9
		public unsafe static int elementId_throttleHat4Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Right, (void*)(&value));
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x000CC138 File Offset: 0x000CA338
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x000239C7 File Offset: 0x00021BC7
		public unsafe static int elementId_throttleHat4Down_Right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Right, (void*)(&value));
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x000CC154 File Offset: 0x000CA354
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x000239D5 File Offset: 0x00021BD5
		public unsafe static int elementId_throttleHat4Down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down, (void*)(&value));
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x000CC170 File Offset: 0x000CA370
		// (set) Token: 0x0600365F RID: 13919 RVA: 0x000239E3 File Offset: 0x00021BE3
		public unsafe static int elementId_throttleHat4Down_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Down_Left, (void*)(&value));
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x000CC18C File Offset: 0x000CA38C
		// (set) Token: 0x06003661 RID: 13921 RVA: 0x000239F1 File Offset: 0x00021BF1
		public unsafe static int elementId_throttleHat4Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Left, (void*)(&value));
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x000CC1A8 File Offset: 0x000CA3A8
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x000239FF File Offset: 0x00021BFF
		public unsafe static int elementId_throttleHat4Up_Left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4Up_Left, (void*)(&value));
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x000CC1C4 File Offset: 0x000CA3C4
		// (set) Token: 0x06003665 RID: 13925 RVA: 0x00023A0D File Offset: 0x00021C0D
		public unsafe static int elementId_leftPedal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*)(&value));
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x000CC1E0 File Offset: 0x000CA3E0
		// (set) Token: 0x06003667 RID: 13927 RVA: 0x00023A1B File Offset: 0x00021C1B
		public unsafe static int elementId_rightPedal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*)(&value));
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x000CC1FC File Offset: 0x000CA3FC
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x00023A29 File Offset: 0x00021C29
		public unsafe static int elementId_slidePedals
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_slidePedals, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_slidePedals, (void*)(&value));
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x000CC218 File Offset: 0x000CA418
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x00023A37 File Offset: 0x00021C37
		public unsafe static int elementId_stick
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stick, (void*)(&value));
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x000CC234 File Offset: 0x000CA434
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x00023A45 File Offset: 0x00021C45
		public unsafe static int elementId_stickMiniStick1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick1, (void*)(&value));
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x000CC250 File Offset: 0x000CA450
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x00023A53 File Offset: 0x00021C53
		public unsafe static int elementId_stickMiniStick2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickMiniStick2, (void*)(&value));
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x000CC26C File Offset: 0x000CA46C
		// (set) Token: 0x06003671 RID: 13937 RVA: 0x00023A61 File Offset: 0x00021C61
		public unsafe static int elementId_stickHat1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat1, (void*)(&value));
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x000CC288 File Offset: 0x000CA488
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x00023A6F File Offset: 0x00021C6F
		public unsafe static int elementId_stickHat2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat2, (void*)(&value));
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06003674 RID: 13940 RVA: 0x000CC2A4 File Offset: 0x000CA4A4
		// (set) Token: 0x06003675 RID: 13941 RVA: 0x00023A7D File Offset: 0x00021C7D
		public unsafe static int elementId_stickHat3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat3, (void*)(&value));
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x000CC2C0 File Offset: 0x000CA4C0
		// (set) Token: 0x06003677 RID: 13943 RVA: 0x00023A8B File Offset: 0x00021C8B
		public unsafe static int elementId_stickHat4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_stickHat4, (void*)(&value));
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x000CC2DC File Offset: 0x000CA4DC
		// (set) Token: 0x06003679 RID: 13945 RVA: 0x00023A99 File Offset: 0x00021C99
		public unsafe static int elementId_throttle1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle1, (void*)(&value));
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x000CC2F8 File Offset: 0x000CA4F8
		// (set) Token: 0x0600367B RID: 13947 RVA: 0x00023AA7 File Offset: 0x00021CA7
		public unsafe static int elementId_throttle2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttle2, (void*)(&value));
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x0600367C RID: 13948 RVA: 0x000CC314 File Offset: 0x000CA514
		// (set) Token: 0x0600367D RID: 13949 RVA: 0x00023AB5 File Offset: 0x00021CB5
		public unsafe static int elementId_throttleMiniStick
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleMiniStick, (void*)(&value));
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x000CC330 File Offset: 0x000CA530
		// (set) Token: 0x0600367F RID: 13951 RVA: 0x00023AC3 File Offset: 0x00021CC3
		public unsafe static int elementId_throttleHat1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat1, (void*)(&value));
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x000CC34C File Offset: 0x000CA54C
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x00023AD1 File Offset: 0x00021CD1
		public unsafe static int elementId_throttleHat2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat2, (void*)(&value));
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x000CC368 File Offset: 0x000CA568
		// (set) Token: 0x06003683 RID: 13955 RVA: 0x00023ADF File Offset: 0x00021CDF
		public unsafe static int elementId_throttleHat3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat3, (void*)(&value));
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x000CC384 File Offset: 0x000CA584
		// (set) Token: 0x06003685 RID: 13957 RVA: 0x00023AED File Offset: 0x00021CED
		public unsafe static int elementId_throttleHat4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HOTASTemplate.NativeFieldInfoPtr_elementId_throttleHat4, (void*)(&value));
			}
		}

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeFieldInfoPtr_typeGuid;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickX;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickY;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickRotate;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1X;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1Y;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1Press;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2X;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2Y;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2Press;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickTrigger;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickTriggerStage2;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickPinkyButton;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickPinkyTrigger;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton1;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton2;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton3;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton4;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton5;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton6;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton7;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton8;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton9;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickButton10;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton1;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton2;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton3;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton4;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton5;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton6;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton7;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton8;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton9;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton10;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton11;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickBaseButton12;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1Up;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1UpRight;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1Right;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1DownRight;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1Down;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1DownLeft;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1Left;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1Up_Left;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Up;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Up_right;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Right;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Down_Right;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Down;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Down_Left;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Left;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2Up_Left;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Up;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Up_Right;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Right;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Down_Right;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Down;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Down_Left;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Left;

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3Up_Left;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Up;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Up_Right;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Right;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Down_Right;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Down;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Down_Left;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Left;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4Up_Left;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeFieldInfoPtr_elementId_mode1;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeFieldInfoPtr_elementId_mode2;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr_elementId_mode3;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle1Axis;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle2Axis;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle1MinDetent;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle2MinDetent;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton1;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton2;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton3;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton4;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton5;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton6;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton7;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton8;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton9;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleButton10;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton1;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton2;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton3;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton4;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton5;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton6;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton7;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton8;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton9;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton10;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton11;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton12;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton13;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton14;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton15;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleSlider1;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleSlider2;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleSlider3;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleSlider4;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleDial1;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleDial2;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleDial3;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleDial4;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickX;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickY;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickPress;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Forward;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Back;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Press;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Forward;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Back;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Press;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Forward;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Back;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Press;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up_Right;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Right;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down_Right;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down_Left;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Left;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up_Left;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up_Right;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Right;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down_Right;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down_Left;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Left;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up_Left;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up_Right;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Right;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down_Right;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down_Left;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Left;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up_Left;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up_Right;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Right;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down_Right;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down_Left;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Left;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up_Left;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeFieldInfoPtr_elementId_leftPedal;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeFieldInfoPtr_elementId_rightPedal;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeFieldInfoPtr_elementId_slidePedals;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stick;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat1;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat2;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat3;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeFieldInfoPtr_elementId_stickHat4;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle1;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttle2;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleMiniStick;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat1;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat2;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat3;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeFieldInfoPtr_elementId_throttleHat4;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
	}
}
