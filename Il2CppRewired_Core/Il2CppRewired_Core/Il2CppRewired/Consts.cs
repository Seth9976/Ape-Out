using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Config;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppRewired
{
	// Token: 0x0200005C RID: 92
	public static class Consts : Object
	{
		// Token: 0x06000AC2 RID: 2754 RVA: 0x000577D8 File Offset: 0x000559D8
		// Note: this type is marked as 'beforefieldinit'.
		static Consts()
		{
			Il2CppClassPointerStore<Consts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Consts");
			Consts.NativeFieldInfoPtr_systemPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "systemPlayerId");
			Consts.NativeFieldInfoPtr_menuRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "menuRoot");
			Consts.NativeFieldInfoPtr_programVersion1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "programVersion1");
			Consts.NativeFieldInfoPtr_programVersion2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "programVersion2");
			Consts.NativeFieldInfoPtr_programVersion3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "programVersion3");
			Consts.NativeFieldInfoPtr_programVersion4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "programVersion4");
			Consts.NativeFieldInfoPtr_dataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "dataVersion");
			Consts.NativeFieldInfoPtr_unityMajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityMajorVersion");
			Consts.NativeFieldInfoPtr_unityMajorVersionIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityMajorVersionIdentifier");
			Consts.NativeFieldInfoPtr_isTrial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "isTrial");
			Consts.NativeFieldInfoPtr_copyrightYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "copyrightYear");
			Consts.NativeFieldInfoPtr_defaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultNamespace");
			Consts.NativeFieldInfoPtr_defaultLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultLogLevel");
			Consts.NativeFieldInfoPtr_allowInputWhenEditorPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "allowInputWhenEditorPaused");
			Consts.NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers");
			Consts.NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers");
			Consts.NativeFieldInfoPtr_editorGUIUpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "editorGUIUpdateInterval");
			Consts.NativeFieldInfoPtr_joystickRefreshPollCheckTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickRefreshPollCheckTimeout");
			Consts.NativeFieldInfoPtr_controllerRefreshWaitTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "controllerRefreshWaitTimeout");
			Consts.NativeFieldInfoPtr_buttonsPerHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "buttonsPerHat");
			Consts.NativeFieldInfoPtr_keyboardKeyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "keyboardKeyCount");
			Consts.NativeFieldInfoPtr_keyboardModifierKeyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "keyboardModifierKeyCount");
			Consts.NativeFieldInfoPtr_unityMouseButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityMouseButtonCount");
			Consts.NativeFieldInfoPtr_unityMouseAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityMouseAxisCount");
			Consts.NativeFieldInfoPtr_unityMaxJoysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityMaxJoysticks");
			Consts.NativeFieldInfoPtr_unityJoystickButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityJoystickButtonCount");
			Consts.NativeFieldInfoPtr_unityJoystickStartingButtonKeycodeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityJoystickStartingButtonKeycodeValue");
			Consts.NativeFieldInfoPtr_unityJoystickAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityJoystickAxisCount");
			Consts.NativeFieldInfoPtr_unityJoystickLastJoystickIdWithButtonKeyCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityJoystickLastJoystickIdWithButtonKeyCodes");
			Consts.NativeFieldInfoPtr_unityJoystickPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityJoystickPrefix");
			Consts.NativeFieldInfoPtr_unityJoystickAxisSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityJoystickAxisSuffix");
			Consts.NativeFieldInfoPtr_unityJoystickButtonSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unityJoystickButtonSuffix");
			Consts.NativeFieldInfoPtr_directInputMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputMaxButtons");
			Consts.NativeFieldInfoPtr_directInputMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputMaxAxes");
			Consts.NativeFieldInfoPtr_directInputMaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputMaxHats");
			Consts.NativeFieldInfoPtr_directInputMaxSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputMaxSliders");
			Consts.NativeFieldInfoPtr_directInputMaxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputMaxAxisValue");
			Consts.NativeFieldInfoPtr_directInputMinAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputMinAxisValue");
			Consts.NativeFieldInfoPtr_directInputMaxHatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputMaxHatValue");
			Consts.NativeFieldInfoPtr_directInputHatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputHatZeroValue");
			Consts.NativeFieldInfoPtr_directInputHatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputHatSpan");
			Consts.NativeFieldInfoPtr_directInputHatSpan4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputHatSpan4Way");
			Consts.NativeFieldInfoPtr_directInput_hatValue_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInput_hatValue_up");
			Consts.NativeFieldInfoPtr_directInput_hatValue_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInput_hatValue_right");
			Consts.NativeFieldInfoPtr_directInput_hatValue_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInput_hatValue_down");
			Consts.NativeFieldInfoPtr_directInput_hatValue_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInput_hatValue_left");
			Consts.NativeFieldInfoPtr_directInputLastDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputLastDirectionValue");
			Consts.NativeFieldInfoPtr_directInputLastDirectionValue4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputLastDirectionValue4Way");
			Consts.NativeFieldInfoPtr_directInputUnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputUnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_directInputUnknownJoystickHatButtonStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputUnknownJoystickHatButtonStartIndex");
			Consts.NativeFieldInfoPtr_directInputJoystickStateByteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "directInputJoystickStateByteSize");
			Consts.NativeFieldInfoPtr_rawInputMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputMaxButtons");
			Consts.NativeFieldInfoPtr_rawInputMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputMaxAxes");
			Consts.NativeFieldInfoPtr_rawInputMaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputMaxHats");
			Consts.NativeFieldInfoPtr_rawInputMaxSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputMaxSliders");
			Consts.NativeFieldInfoPtr_rawInputMaxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputMaxAxisValue");
			Consts.NativeFieldInfoPtr_rawInputMinAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputMinAxisValue");
			Consts.NativeFieldInfoPtr_rawInputMaxHatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputMaxHatValue");
			Consts.NativeFieldInfoPtr_rawInputHatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputHatZeroValue");
			Consts.NativeFieldInfoPtr_rawInputHatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputHatSpan");
			Consts.NativeFieldInfoPtr_rawInputHatSpan4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputHatSpan4Way");
			Consts.NativeFieldInfoPtr_rawInput_hatValue_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInput_hatValue_up");
			Consts.NativeFieldInfoPtr_rawInput_hatValue_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInput_hatValue_right");
			Consts.NativeFieldInfoPtr_rawInput_hatValue_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInput_hatValue_down");
			Consts.NativeFieldInfoPtr_rawInput_hatValue_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInput_hatValue_left");
			Consts.NativeFieldInfoPtr_rawInputLastDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputLastDirectionValue");
			Consts.NativeFieldInfoPtr_rawInputLastDirectionValue4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputLastDirectionValue4Way");
			Consts.NativeFieldInfoPtr_rawInputUnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputUnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_rawInputUnknownJoystickHatButtonStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputUnknownJoystickHatButtonStartIndex");
			Consts.NativeFieldInfoPtr_rawInputUnifiedMouseButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputUnifiedMouseButtonCount");
			Consts.NativeFieldInfoPtr_rawInputUnifiedMouseAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputUnifiedMouseAxisCount");
			Consts.NativeFieldInfoPtr_rawInputUnifiedMouseAxisUnityEquivalencyMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputUnifiedMouseAxisUnityEquivalencyMultiplier");
			Consts.NativeFieldInfoPtr_rawInputUnifiedKeyboardButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rawInputUnifiedKeyboardButtonCount");
			Consts.NativeFieldInfoPtr_osxMaxSticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMaxSticks");
			Consts.NativeFieldInfoPtr_osxMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMaxButtons");
			Consts.NativeFieldInfoPtr_osxMaxAxesPerStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMaxAxesPerStick");
			Consts.NativeFieldInfoPtr_osxMaxHatsPerStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMaxHatsPerStick");
			Consts.NativeFieldInfoPtr_osxMaxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMaxAxisValue");
			Consts.NativeFieldInfoPtr_osxMinAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMinAxisValue");
			Consts.NativeFieldInfoPtr_osxMaxPressureSensitiveButtonValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMaxPressureSensitiveButtonValue");
			Consts.NativeFieldInfoPtr_osxMinPressureSensitiveButtonValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMinPressureSensitiveButtonValue");
			Consts.NativeFieldInfoPtr_osxMaxHatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxMaxHatValue");
			Consts.NativeFieldInfoPtr_osxInputHatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxInputHatZeroValue");
			Consts.NativeFieldInfoPtr_osxHatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxHatSpan");
			Consts.NativeFieldInfoPtr_osxHatSpan4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxHatSpan4Way");
			Consts.NativeFieldInfoPtr_osx_hatValue_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osx_hatValue_up");
			Consts.NativeFieldInfoPtr_osx_hatValue_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osx_hatValue_right");
			Consts.NativeFieldInfoPtr_osx_hatValue_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osx_hatValue_down");
			Consts.NativeFieldInfoPtr_osx_hatValue_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osx_hatValue_left");
			Consts.NativeFieldInfoPtr_osxLastDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxLastDirectionValue");
			Consts.NativeFieldInfoPtr_osxLastDirectionValue4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxLastDirectionValue4Way");
			Consts.NativeFieldInfoPtr_osxUnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxUnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_osxUnknownJoystickHatButtonStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxUnknownJoystickHatButtonStartIndex");
			Consts.NativeFieldInfoPtr_linuxMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxMaxButtons");
			Consts.NativeFieldInfoPtr_linuxMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxMaxAxes");
			Consts.NativeFieldInfoPtr_linuxMaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxMaxHats");
			Consts.NativeFieldInfoPtr_linuxMaxSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxMaxSliders");
			Consts.NativeFieldInfoPtr_linuxMaxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxMaxAxisValue");
			Consts.NativeFieldInfoPtr_linuxMinAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxMinAxisValue");
			Consts.NativeFieldInfoPtr_linuxMaxHatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxMaxHatValue");
			Consts.NativeFieldInfoPtr_linuxHatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxHatZeroValue");
			Consts.NativeFieldInfoPtr_linuxHatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxHatSpan");
			Consts.NativeFieldInfoPtr_linuxHatSpan4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxHatSpan4Way");
			Consts.NativeFieldInfoPtr_linux_hatValue_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linux_hatValue_up");
			Consts.NativeFieldInfoPtr_linux_hatValue_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linux_hatValue_right");
			Consts.NativeFieldInfoPtr_linux_hatValue_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linux_hatValue_down");
			Consts.NativeFieldInfoPtr_linux_hatValue_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linux_hatValue_left");
			Consts.NativeFieldInfoPtr_linuxLastDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxLastDirectionValue");
			Consts.NativeFieldInfoPtr_linuxLastDirectionValue4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxLastDirectionValue4Way");
			Consts.NativeFieldInfoPtr_linuxUnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxUnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_linuxUnknownJoystickHatButtonStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxUnknownJoystickHatButtonStartIndex");
			Consts.NativeFieldInfoPtr_linuxUnifiedMouseButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxUnifiedMouseButtonCount");
			Consts.NativeFieldInfoPtr_linuxUnifiedMouseAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxUnifiedMouseAxisCount");
			Consts.NativeFieldInfoPtr_linuxUnifiedMouseAxisUnityEquivalencyMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "linuxUnifiedMouseAxisUnityEquivalencyMultiplier");
			Consts.NativeFieldInfoPtr_sdl2MaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2MaxButtons");
			Consts.NativeFieldInfoPtr_sdl2MaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2MaxAxes");
			Consts.NativeFieldInfoPtr_sdl2MaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2MaxHats");
			Consts.NativeFieldInfoPtr_sdl2MaxSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2MaxSliders");
			Consts.NativeFieldInfoPtr_sdl2MaxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2MaxAxisValue");
			Consts.NativeFieldInfoPtr_sdl2MinAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2MinAxisValue");
			Consts.NativeFieldInfoPtr_sdl2AxisZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2AxisZeroValue");
			Consts.NativeFieldInfoPtr_sdl2MaxHatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2MaxHatValue");
			Consts.NativeFieldInfoPtr_sdl2HatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2HatZeroValue");
			Consts.NativeFieldInfoPtr_sdl2HatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2HatSpan");
			Consts.NativeFieldInfoPtr_sdl2HatSpan4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2HatSpan4Way");
			Consts.NativeFieldInfoPtr_sdl2_hatValue_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2_hatValue_up");
			Consts.NativeFieldInfoPtr_sdl2_hatValue_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2_hatValue_right");
			Consts.NativeFieldInfoPtr_sdl2_hatValue_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2_hatValue_down");
			Consts.NativeFieldInfoPtr_sdl2_hatValue_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2_hatValue_left");
			Consts.NativeFieldInfoPtr_sdl2LastDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2LastDirectionValue");
			Consts.NativeFieldInfoPtr_sdl2LastDirectionValue4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2LastDirectionValue4Way");
			Consts.NativeFieldInfoPtr_sdl2UnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2UnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_sdl2UnknownJoystickHatButtonStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2UnknownJoystickHatButtonStartIndex");
			Consts.NativeFieldInfoPtr_sdl2UnifiedMouseButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2UnifiedMouseButtonCount");
			Consts.NativeFieldInfoPtr_sdl2UnifiedMouseAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2UnifiedMouseAxisCount");
			Consts.NativeFieldInfoPtr_sdl2UnifiedMouseAxisUnityEquivalencyMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "sdl2UnifiedMouseAxisUnityEquivalencyMultiplier");
			Consts.NativeFieldInfoPtr_windowsUWPMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPMaxButtons");
			Consts.NativeFieldInfoPtr_windowsUWPMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPMaxAxes");
			Consts.NativeFieldInfoPtr_windowsUWPMaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPMaxHats");
			Consts.NativeFieldInfoPtr_windowsUWPMaxSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPMaxSliders");
			Consts.NativeFieldInfoPtr_windowsUWPMaxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPMaxAxisValue");
			Consts.NativeFieldInfoPtr_windowsUWPMinAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPMinAxisValue");
			Consts.NativeFieldInfoPtr_windowsUWPMaxHatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPMaxHatValue");
			Consts.NativeFieldInfoPtr_windowsUWPHatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPHatZeroValue");
			Consts.NativeFieldInfoPtr_windowsUWPDirectionsPerHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPDirectionsPerHat");
			Consts.NativeFieldInfoPtr_windowsUWPHatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPHatSpan");
			Consts.NativeFieldInfoPtr_windowsUWPHatSpan4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPHatSpan4Way");
			Consts.NativeFieldInfoPtr_windowsUWPLastDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPLastDirectionValue");
			Consts.NativeFieldInfoPtr_windowsUWPLastDirectionValue4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPLastDirectionValue4Way");
			Consts.NativeFieldInfoPtr_windowsUWPUnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPUnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_windowsUWPUnknownJoystickHatButtonStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPUnknownJoystickHatButtonStartIndex");
			Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPUnifiedMouseButtonCount");
			Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPUnifiedMouseAxisCount");
			Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier");
			Consts.NativeFieldInfoPtr_xInputMaxVibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "xInputMaxVibration");
			Consts.NativeFieldInfoPtr_xInputMinVibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "xInputMinVibration");
			Consts.NativeFieldInfoPtr_xInputAllowedVibrationInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "xInputAllowedVibrationInterval");
			Consts.NativeFieldInfoPtr_customPlatformMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "customPlatformMaxButtons");
			Consts.NativeFieldInfoPtr_customPlatformMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "customPlatformMaxAxes");
			Consts.NativeFieldInfoPtr_internalDriverMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverMaxButtons");
			Consts.NativeFieldInfoPtr_internalDriverMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverMaxAxes");
			Consts.NativeFieldInfoPtr_internalDriverMaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverMaxHats");
			Consts.NativeFieldInfoPtr_internalDriverMaxSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverMaxSliders");
			Consts.NativeFieldInfoPtr_internalDriverMaxAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverMaxAxisValue");
			Consts.NativeFieldInfoPtr_internalDriverMinAxisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverMinAxisValue");
			Consts.NativeFieldInfoPtr_internalDriverMaxHatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverMaxHatValue");
			Consts.NativeFieldInfoPtr_internalDriverHatZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverHatZeroValue");
			Consts.NativeFieldInfoPtr_internalDriverHatSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverHatSpan");
			Consts.NativeFieldInfoPtr_internalDriverHatSpan4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverHatSpan4Way");
			Consts.NativeFieldInfoPtr_internalDriver_hatValue_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriver_hatValue_up");
			Consts.NativeFieldInfoPtr_internalDriver_hatValue_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriver_hatValue_right");
			Consts.NativeFieldInfoPtr_internalDriver_hatValue_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriver_hatValue_down");
			Consts.NativeFieldInfoPtr_internalDriver_hatValue_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriver_hatValue_left");
			Consts.NativeFieldInfoPtr_internalDriverLastDirectionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverLastDirectionValue");
			Consts.NativeFieldInfoPtr_internalDriverLastDirectionValue4Way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverLastDirectionValue4Way");
			Consts.NativeFieldInfoPtr_internalDriverUnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverUnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_internalDriverUnknownJoystickHatButtonStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverUnknownJoystickHatButtonStartIndex");
			Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverUnifiedMouseButtonCount");
			Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverUnifiedMouseAxisCount");
			Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier");
			Consts.NativeFieldInfoPtr_webGLMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "webGLMaxButtons");
			Consts.NativeFieldInfoPtr_webGLMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "webGLMaxAxes");
			Consts.NativeFieldInfoPtr_gameCoreMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCoreMaxButtons");
			Consts.NativeFieldInfoPtr_gameCoreMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCoreMaxAxes");
			Consts.NativeFieldInfoPtr_gameCoreMaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCoreMaxHats");
			Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCoreUnknownJoystickButtonCount");
			Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCoreUnknownJoystickAxisCount");
			Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickHatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCoreUnknownJoystickHatCount");
			Consts.NativeFieldInfoPtr_appleGCControllerMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "appleGCControllerMaxButtons");
			Consts.NativeFieldInfoPtr_appleGCControllerMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "appleGCControllerMaxAxes");
			Consts.NativeFieldInfoPtr_appleGCControllerUnknownJoystickButtonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "appleGCControllerUnknownJoystickButtonCount");
			Consts.NativeFieldInfoPtr_appleGCControllerUnknownJoystickAxisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "appleGCControllerUnknownJoystickAxisCount");
			Consts.NativeFieldInfoPtr_unknownJoystickMaxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickMaxButtons");
			Consts.NativeFieldInfoPtr_unknownJoystickMaxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickMaxAxes");
			Consts.NativeFieldInfoPtr_unknownJoystickMaxHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickMaxHats");
			Consts.NativeFieldInfoPtr_unknownJoystickButtonsPerHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickButtonsPerHat");
			Consts.NativeFieldInfoPtr_unknownJoystickAxisElementIdentifierStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickAxisElementIdentifierStartIndex");
			Consts.NativeFieldInfoPtr_unknownJoystickButtonElementIdentifierStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickButtonElementIdentifierStartIndex");
			Consts.NativeFieldInfoPtr_unknownJoystickHatElementIdentifierStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickHatElementIdentifierStartIndex");
			Consts.NativeFieldInfoPtr_unknownJoystickDefaultAxisDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickDefaultAxisDeadZone");
			Consts.NativeFieldInfoPtr_defaultAbsoluteAxisPollingDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultAbsoluteAxisPollingDeadZone");
			Consts.NativeFieldInfoPtr_defaultRelativeAxisPollingDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultRelativeAxisPollingDeadZone");
			Consts.NativeFieldInfoPtr_defaultMouseXYAxisPollingDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultMouseXYAxisPollingDeadzone");
			Consts.NativeFieldInfoPtr_defaultMouseOtherAxisPollingDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultMouseOtherAxisPollingDeadzone");
			Consts.NativeFieldInfoPtr_defaultButtonDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonDeadZone");
			Consts.NativeFieldInfoPtr_hardwareButtonDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "hardwareButtonDeadZone");
			Consts.NativeFieldInfoPtr_axisDefaultSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "axisDefaultSensitivity");
			Consts.NativeFieldInfoPtr_axisDefaultSensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "axisDefaultSensitivityType");
			Consts.NativeFieldInfoPtr_defaultButtonDoublePressSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonDoublePressSpeed");
			Consts.NativeFieldInfoPtr_minDoubleButtonPressSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "minDoubleButtonPressSpeed");
			Consts.NativeFieldInfoPtr_maxDoubleButtonPressSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "maxDoubleButtonPressSpeed");
			Consts.NativeFieldInfoPtr_defaultButtonShortPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonShortPressTime");
			Consts.NativeFieldInfoPtr_minButtonShortPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "minButtonShortPressTime");
			Consts.NativeFieldInfoPtr_maxButtonShortPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "maxButtonShortPressTime");
			Consts.NativeFieldInfoPtr_defaultButtonShortPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonShortPressExpiresIn");
			Consts.NativeFieldInfoPtr_minButtonShortPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "minButtonShortPressExpiresIn");
			Consts.NativeFieldInfoPtr_maxButtonShortPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "maxButtonShortPressExpiresIn");
			Consts.NativeFieldInfoPtr_defaultButtonLongPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonLongPressTime");
			Consts.NativeFieldInfoPtr_minButtonLongPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "minButtonLongPressTime");
			Consts.NativeFieldInfoPtr_maxButtonLongPressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "maxButtonLongPressTime");
			Consts.NativeFieldInfoPtr_defaultButtonLongPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonLongPressExpiresIn");
			Consts.NativeFieldInfoPtr_minButtonLongPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "minButtonLongPressExpiresIn");
			Consts.NativeFieldInfoPtr_maxButtonLongPressExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "maxButtonLongPressExpiresIn");
			Consts.NativeFieldInfoPtr_defaultButtonRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonRepeatDelay");
			Consts.NativeFieldInfoPtr_defaultButtonRepeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultButtonRepeatRate");
			Consts.NativeFieldInfoPtr_minButtonRepeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "minButtonRepeatRate");
			Consts.NativeFieldInfoPtr_mouseAxisPollingTimerLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "mouseAxisPollingTimerLength");
			Consts.NativeFieldInfoPtr_fallbackPollingTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "fallbackPollingTimeout");
			Consts.NativeFieldInfoPtr_unknownJoystickName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "unknownJoystickName");
			Consts.NativeFieldInfoPtr_xInputControllerVibrationRenewalInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "xInputControllerVibrationRenewalInterval");
			Consts.NativeFieldInfoPtr_defaultInputThreadUpdateRateFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultInputThreadUpdateRateFPS");
			Consts.NativeFieldInfoPtr_maxInputThreadUpdateRateFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "maxInputThreadUpdateRateFPS");
			Consts.NativeFieldInfoPtr_osxXInputOutputReportRefreshRateFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxXInputOutputReportRefreshRateFPS");
			Consts.NativeFieldInfoPtr_defaultOutputRefreshRateFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultOutputRefreshRateFPS");
			Consts.NativeFieldInfoPtr_hidOutputReportRefreshRateFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "hidOutputReportRefreshRateFPS");
			Consts.NativeFieldInfoPtr_hidOutputReportThreadKillTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "hidOutputReportThreadKillTimeout");
			Consts.NativeFieldInfoPtr_joystickInputReportRingBufferCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickInputReportRingBufferCapacity");
			Consts.NativeFieldInfoPtr_joystickInputReportRingBufferCapacityDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickInputReportRingBufferCapacityDuration");
			Consts.NativeFieldInfoPtr_resourecesDLLPath_windowsStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "resourecesDLLPath_windowsStandalone");
			Consts.NativeFieldInfoPtr_resourecesDLLPath_osxStandalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "resourecesDLLPath_osxStandalone");
			Consts.NativeFieldInfoPtr_resourecesDLLPath_linux = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "resourecesDLLPath_linux");
			Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultInputBehaviorAxisSensitivity");
			Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultInputBehaviorAxisSimulation_gravity");
			Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultInputBehaviorAxisSimulation_sensitivity");
			Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_snap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultInputBehaviorAxisSmoothing_snap");
			Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_instantReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultInputBehaviorAxisSmoothing_instantReverse");
			Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "defaultInputBehaviorAxisSimulation_enabled");
			Consts.NativeFieldInfoPtr_allFlagsIntEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "allFlagsIntEnum");
			Consts.NativeFieldInfoPtr_osxPreventSystemSleepInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "osxPreventSystemSleepInterval");
			Consts.NativeFieldInfoPtr_schemaNameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaNameSpace");
			Consts.NativeFieldInfoPtr_schemaBaseLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaBaseLocation");
			Consts.NativeFieldInfoPtr_schemaVersionControllerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaVersionControllerMap");
			Consts.NativeFieldInfoPtr_schemaVersionCalibrationMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaVersionCalibrationMap");
			Consts.NativeFieldInfoPtr_schemaVersionInputBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaVersionInputBehavior");
			Consts.NativeFieldInfoPtr_schemaVersionControllerTemplateMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaVersionControllerTemplateMap");
			Consts.NativeFieldInfoPtr_schemaVersionPlayerEnabledMapsHelperData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaVersionPlayerEnabledMapsHelperData");
			Consts.NativeFieldInfoPtr_schemaVersionPlayerControllerMapLayoutManagerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "schemaVersionPlayerControllerMapLayoutManagerData");
			Consts.NativeFieldInfoPtr_controllerMapDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "controllerMapDataVersion");
			Consts.NativeFieldInfoPtr_calibrationMapDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "calibrationMapDataVersion");
			Consts.NativeFieldInfoPtr_inputBehaviorDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "inputBehaviorDataVersion");
			Consts.NativeFieldInfoPtr_controllerTemplateMapDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "controllerTemplateMapDataVersion");
			Consts.NativeFieldInfoPtr_playerMapEnablerDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "playerMapEnablerDataVersion");
			Consts.NativeFieldInfoPtr_playerControllerMapLayoutManagerDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "playerControllerMapLayoutManagerDataVersion");
			Consts.NativeFieldInfoPtr_controllerElementType_trueElements_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "controllerElementType_trueElements_minValue");
			Consts.NativeFieldInfoPtr_controllerElementType_trueElements_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "controllerElementType_trueElements_maxValue");
			Consts.NativeFieldInfoPtr_pressureSensitiveButtonDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "pressureSensitiveButtonDeadZone");
			Consts.NativeFieldInfoPtr_rewiredEditorAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rewiredEditorAssembly");
			Consts.NativeFieldInfoPtr_rewiredEditorInputEditorClassFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "rewiredEditorInputEditorClassFullName");
			Consts.NativeFieldInfoPtr_nintendoSwitchPluginEditorRuntimeAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "nintendoSwitchPluginEditorRuntimeAssembly");
			Consts.NativeFieldInfoPtr_nintendoSwitchPluginInputManagerFullClassPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "nintendoSwitchPluginInputManagerFullClassPath");
			Consts.NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_JoyConDual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "nintendoSwitchPluginHWJoystickMapGuid_JoyConDual");
			Consts.NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_Handheld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "nintendoSwitchPluginHWJoystickMapGuid_Handheld");
			Consts.NativeFieldInfoPtr_stadiaPluginEditorRuntimeAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "stadiaPluginEditorRuntimeAssembly");
			Consts.NativeFieldInfoPtr_stadiaPluginInputManagerFullClassPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "stadiaPluginInputManagerFullClassPath");
			Consts.NativeFieldInfoPtr_gameCorePluginEditorRuntimeAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCorePluginEditorRuntimeAssembly");
			Consts.NativeFieldInfoPtr_gameCorePluginInputManagerFullClassPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "gameCorePluginInputManagerFullClassPath");
			Consts.NativeFieldInfoPtr_ps5PluginEditorRuntimeAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ps5PluginEditorRuntimeAssembly");
			Consts.NativeFieldInfoPtr_ps5PluginInputManagerFullClassPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ps5PluginInputManagerFullClassPath");
			Consts.NativeFieldInfoPtr_vendorId_sony = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "vendorId_sony");
			Consts.NativeFieldInfoPtr_updateLoopTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "updateLoopTypeCount");
			Consts.NativeFieldInfoPtr_questionablePidVids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "questionablePidVids");
			Consts.NativeFieldInfoPtr_questionableVIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "questionableVIDs");
			Consts.NativeFieldInfoPtr_joystickGuid_unknownController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickGuid_unknownController");
			Consts.NativeFieldInfoPtr_joystickGuid_appleMFiController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickGuid_appleMFiController");
			Consts.NativeFieldInfoPtr_joystickGuid_standardizedGamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickGuid_standardizedGamepad");
			Consts.NativeFieldInfoPtr_joystickGuid_SonyDualShock4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickGuid_SonyDualShock4");
			Consts.NativeFieldInfoPtr_joystickGuid_SonyPS4AimController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "joystickGuid_SonyPS4AimController");
			Consts.NativeFieldInfoPtr_hardwareTypeGuid_universalKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "hardwareTypeGuid_universalKeyboard");
			Consts.NativeFieldInfoPtr_hardwareTypeGuid_universalMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "hardwareTypeGuid_universalMouse");
			Consts.NativeFieldInfoPtr_ROlfSOGtabStODOfZKBbnjVoDls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ROlfSOGtabStODOfZKBbnjVoDls");
			Consts.NativeFieldInfoPtr_WjkorWscNtnASKNQIpakJrLeBJn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "WjkorWscNtnASKNQIpakJrLeBJn");
			Consts.NativeFieldInfoPtr_mouseAxisUnityNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "mouseAxisUnityNames");
			Consts.NativeFieldInfoPtr_KCpQCyoHQPesEQLJJciQPRkSnOc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "KCpQCyoHQPesEQLJJciQPRkSnOc");
			Consts.NativeFieldInfoPtr_mouseButtonUnityNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "mouseButtonUnityNames");
			Consts.NativeFieldInfoPtr_bfEDhQnQUuAVncifZOvIfOIkLuJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "bfEDhQnQUuAVncifZOvIfOIkLuJ");
			Consts.NativeFieldInfoPtr_keyboardKeyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "keyboardKeyNames");
			Consts.NativeFieldInfoPtr_ubecLkaCHeWXfcESHEAkRDDRqdFi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ubecLkaCHeWXfcESHEAkRDDRqdFi");
			Consts.NativeFieldInfoPtr_keyboardKeyValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "keyboardKeyValues");
			Consts.NativeFieldInfoPtr__keyboardKeyValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "_keyboardKeyValues");
			Consts.NativeFieldInfoPtr_modifierKeyShortNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "modifierKeyShortNames");
			Consts.NativeFieldInfoPtr_JpAomxCzfsPGoOJSCggFhDcpfPcT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "JpAomxCzfsPGoOJSCggFhDcpfPcT");
			Consts.NativeFieldInfoPtr_pidVids_sony_dualShock4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "pidVids_sony_dualShock4");
			Consts.NativeFieldInfoPtr_DRKFsvtDZLqnQbwbIbyzPOAQwTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DRKFsvtDZLqnQbwbIbyzPOAQwTA");
			Consts.NativeFieldInfoPtr_productNames_sony_dualShock4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "productNames_sony_dualShock4");
			Consts.NativeFieldInfoPtr_AHQWiENFqxAQeDTBiNeOBdxttDx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "AHQWiENFqxAQeDTBiNeOBdxttDx");
			Consts.NativeFieldInfoPtr_tHPJnmSqpQxTYmFcRsjOGXuEFij = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "tHPJnmSqpQxTYmFcRsjOGXuEFij");
			Consts.NativeMethodInfoPtr_get_nintendoSwitchPlugin_minPluginVersion_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100665115);
			Consts.NativeMethodInfoPtr_get_stadiaPlugin_minPluginVersion_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100665116);
			Consts.NativeMethodInfoPtr_get_gameCorePlugin_minPluginVersion_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100665117);
			Consts.NativeMethodInfoPtr_get_unityUnifiedMouseElementIdentifiers_Internal_Static_get_IList_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100665119);
			Consts.NativeMethodInfoPtr_get_rawInputUnifiedMouseElementIdentifiers_Internal_Static_get_IList_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100665120);
			Consts.NativeMethodInfoPtr_get_unknownJoystickElementIdentifiers_orig_Internal_Static_get_Il2CppReferenceArray_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100665121);
			Consts.NativeMethodInfoPtr_ulNiepuYVanmiyZmfhhBMOdmdAK_Private_Static_Il2CppReferenceArray_1_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100665122);
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00059074 File Offset: 0x00057274
		public unsafe static int nintendoSwitchPlugin_minPluginVersion
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_get_nintendoSwitchPlugin_minPluginVersion_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000590A4 File Offset: 0x000572A4
		public unsafe static int stadiaPlugin_minPluginVersion
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_get_stadiaPlugin_minPluginVersion_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000590D4 File Offset: 0x000572D4
		public unsafe static int gameCorePlugin_minPluginVersion
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_get_gameCorePlugin_minPluginVersion_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00059104 File Offset: 0x00057304
		public unsafe static IList<ControllerElementIdentifier> unityUnifiedMouseElementIdentifiers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 251889, RefRangeEnd = 251891, XrefRangeStart = 251773, XrefRangeEnd = 251889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_get_unityUnifiedMouseElementIdentifiers_Internal_Static_get_IList_1_ControllerElementIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00059138 File Offset: 0x00057338
		public unsafe static IList<ControllerElementIdentifier> rawInputUnifiedMouseElementIdentifiers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 251991, RefRangeEnd = 251993, XrefRangeStart = 251891, XrefRangeEnd = 251991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_get_rawInputUnifiedMouseElementIdentifiers_Internal_Static_get_IList_1_ControllerElementIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0005916C File Offset: 0x0005736C
		public unsafe static Il2CppReferenceArray<ControllerElementIdentifier> unknownJoystickElementIdentifiers_orig
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251993, XrefRangeEnd = 251997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_get_unknownJoystickElementIdentifiers_orig_Internal_Static_get_Il2CppReferenceArray_1_ControllerElementIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000591A0 File Offset: 0x000573A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251997, XrefRangeEnd = 252153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ControllerElementIdentifier> ulNiepuYVanmiyZmfhhBMOdmdAK()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_ulNiepuYVanmiyZmfhhBMOdmdAK_Private_Static_Il2CppReferenceArray_1_ControllerElementIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr3) : null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000057D0 File Offset: 0x000039D0
		public Consts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x000591D4 File Offset: 0x000573D4
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x000057D9 File Offset: 0x000039D9
		public unsafe static int systemPlayerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_systemPlayerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_systemPlayerId, (void*)(&value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x000591F0 File Offset: 0x000573F0
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x000057E7 File Offset: 0x000039E7
		public unsafe static string menuRoot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_menuRoot, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_menuRoot, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00059210 File Offset: 0x00057410
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000057F9 File Offset: 0x000039F9
		public unsafe static int programVersion1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_programVersion1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_programVersion1, (void*)(&value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0005922C File Offset: 0x0005742C
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00005807 File Offset: 0x00003A07
		public unsafe static int programVersion2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_programVersion2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_programVersion2, (void*)(&value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00059248 File Offset: 0x00057448
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00005815 File Offset: 0x00003A15
		public unsafe static int programVersion3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_programVersion3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_programVersion3, (void*)(&value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00059264 File Offset: 0x00057464
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00005823 File Offset: 0x00003A23
		public unsafe static int programVersion4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_programVersion4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_programVersion4, (void*)(&value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00059280 File Offset: 0x00057480
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00005831 File Offset: 0x00003A31
		public unsafe static int dataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_dataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_dataVersion, (void*)(&value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0005929C File Offset: 0x0005749C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0000583F File Offset: 0x00003A3F
		public unsafe static int unityMajorVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityMajorVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityMajorVersion, (void*)(&value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000592B8 File Offset: 0x000574B8
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0000584D File Offset: 0x00003A4D
		public unsafe static string unityMajorVersionIdentifier
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityMajorVersionIdentifier, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityMajorVersionIdentifier, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000592D8 File Offset: 0x000574D8
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0000585F File Offset: 0x00003A5F
		public unsafe static bool isTrial
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_isTrial, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_isTrial, (void*)(&value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000592F4 File Offset: 0x000574F4
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0000586D File Offset: 0x00003A6D
		public unsafe static string copyrightYear
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_copyrightYear, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_copyrightYear, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00059314 File Offset: 0x00057514
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0000587F File Offset: 0x00003A7F
		public unsafe static string defaultNamespace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultNamespace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultNamespace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00059334 File Offset: 0x00057534
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00005891 File Offset: 0x00003A91
		public unsafe static LogLevelFlags defaultLogLevel
		{
			get
			{
				LogLevelFlags logLevelFlags;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultLogLevel, (void*)(&logLevelFlags));
				return logLevelFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultLogLevel, (void*)(&value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00059350 File Offset: 0x00057550
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0000589F File Offset: 0x00003A9F
		public unsafe static bool allowInputWhenEditorPaused
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_allowInputWhenEditorPaused, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_allowInputWhenEditorPaused, (void*)(&value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0005936C File Offset: 0x0005756C
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x000058AD File Offset: 0x00003AAD
		public unsafe static string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0005938C File Offset: 0x0005758C
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x000058BF File Offset: 0x00003ABF
		public unsafe static string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x000593AC File Offset: 0x000575AC
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x000058D1 File Offset: 0x00003AD1
		public unsafe static float editorGUIUpdateInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_editorGUIUpdateInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_editorGUIUpdateInterval, (void*)(&value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x000593C8 File Offset: 0x000575C8
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x000058DF File Offset: 0x00003ADF
		public unsafe static float joystickRefreshPollCheckTimeout
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickRefreshPollCheckTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickRefreshPollCheckTimeout, (void*)(&value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x000593E4 File Offset: 0x000575E4
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x000058ED File Offset: 0x00003AED
		public unsafe static float controllerRefreshWaitTimeout
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_controllerRefreshWaitTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_controllerRefreshWaitTimeout, (void*)(&value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00059400 File Offset: 0x00057600
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x000058FB File Offset: 0x00003AFB
		public unsafe static int buttonsPerHat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_buttonsPerHat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_buttonsPerHat, (void*)(&value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0005941C File Offset: 0x0005761C
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00005909 File Offset: 0x00003B09
		public unsafe static int keyboardKeyCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_keyboardKeyCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_keyboardKeyCount, (void*)(&value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00059438 File Offset: 0x00057638
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00005917 File Offset: 0x00003B17
		public unsafe static int keyboardModifierKeyCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_keyboardModifierKeyCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_keyboardModifierKeyCount, (void*)(&value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00059454 File Offset: 0x00057654
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00005925 File Offset: 0x00003B25
		public unsafe static int unityMouseButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityMouseButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityMouseButtonCount, (void*)(&value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00059470 File Offset: 0x00057670
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00005933 File Offset: 0x00003B33
		public unsafe static int unityMouseAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityMouseAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityMouseAxisCount, (void*)(&value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0005948C File Offset: 0x0005768C
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00005941 File Offset: 0x00003B41
		public unsafe static int unityMaxJoysticks
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityMaxJoysticks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityMaxJoysticks, (void*)(&value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000594A8 File Offset: 0x000576A8
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x0000594F File Offset: 0x00003B4F
		public unsafe static int unityJoystickButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityJoystickButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityJoystickButtonCount, (void*)(&value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000594C4 File Offset: 0x000576C4
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x0000595D File Offset: 0x00003B5D
		public unsafe static int unityJoystickStartingButtonKeycodeValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityJoystickStartingButtonKeycodeValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityJoystickStartingButtonKeycodeValue, (void*)(&value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x000594E0 File Offset: 0x000576E0
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x0000596B File Offset: 0x00003B6B
		public unsafe static int unityJoystickAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityJoystickAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityJoystickAxisCount, (void*)(&value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000594FC File Offset: 0x000576FC
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00005979 File Offset: 0x00003B79
		public unsafe static int unityJoystickLastJoystickIdWithButtonKeyCodes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityJoystickLastJoystickIdWithButtonKeyCodes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityJoystickLastJoystickIdWithButtonKeyCodes, (void*)(&value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00059518 File Offset: 0x00057718
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00005987 File Offset: 0x00003B87
		public unsafe static string unityJoystickPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityJoystickPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityJoystickPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00059538 File Offset: 0x00057738
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00005999 File Offset: 0x00003B99
		public unsafe static string unityJoystickAxisSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityJoystickAxisSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityJoystickAxisSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00059558 File Offset: 0x00057758
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x000059AB File Offset: 0x00003BAB
		public unsafe static string unityJoystickButtonSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unityJoystickButtonSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unityJoystickButtonSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00059578 File Offset: 0x00057778
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x000059BD File Offset: 0x00003BBD
		public unsafe static int directInputMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00059594 File Offset: 0x00057794
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x000059CB File Offset: 0x00003BCB
		public unsafe static int directInputMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000595B0 File Offset: 0x000577B0
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000059D9 File Offset: 0x00003BD9
		public unsafe static int directInputMaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputMaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputMaxHats, (void*)(&value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000595CC File Offset: 0x000577CC
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000059E7 File Offset: 0x00003BE7
		public unsafe static int directInputMaxSliders
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputMaxSliders, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputMaxSliders, (void*)(&value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000595E8 File Offset: 0x000577E8
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000059F5 File Offset: 0x00003BF5
		public unsafe static int directInputMaxAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputMaxAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputMaxAxisValue, (void*)(&value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00059604 File Offset: 0x00057804
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00005A03 File Offset: 0x00003C03
		public unsafe static int directInputMinAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputMinAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputMinAxisValue, (void*)(&value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00059620 File Offset: 0x00057820
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00005A11 File Offset: 0x00003C11
		public unsafe static int directInputMaxHatValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputMaxHatValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputMaxHatValue, (void*)(&value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0005963C File Offset: 0x0005783C
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00005A1F File Offset: 0x00003C1F
		public unsafe static int directInputHatZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputHatZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputHatZeroValue, (void*)(&value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00059658 File Offset: 0x00057858
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00005A2D File Offset: 0x00003C2D
		public unsafe static int directInputHatSpan
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputHatSpan, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputHatSpan, (void*)(&value));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00059674 File Offset: 0x00057874
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00005A3B File Offset: 0x00003C3B
		public unsafe static int directInputHatSpan4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputHatSpan4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputHatSpan4Way, (void*)(&value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00059690 File Offset: 0x00057890
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00005A49 File Offset: 0x00003C49
		public unsafe static int directInput_hatValue_up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInput_hatValue_up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInput_hatValue_up, (void*)(&value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000596AC File Offset: 0x000578AC
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00005A57 File Offset: 0x00003C57
		public unsafe static int directInput_hatValue_right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInput_hatValue_right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInput_hatValue_right, (void*)(&value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000596C8 File Offset: 0x000578C8
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00005A65 File Offset: 0x00003C65
		public unsafe static int directInput_hatValue_down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInput_hatValue_down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInput_hatValue_down, (void*)(&value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000596E4 File Offset: 0x000578E4
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00005A73 File Offset: 0x00003C73
		public unsafe static int directInput_hatValue_left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInput_hatValue_left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInput_hatValue_left, (void*)(&value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00059700 File Offset: 0x00057900
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00005A81 File Offset: 0x00003C81
		public unsafe static int directInputLastDirectionValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputLastDirectionValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputLastDirectionValue, (void*)(&value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0005971C File Offset: 0x0005791C
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00005A8F File Offset: 0x00003C8F
		public unsafe static int directInputLastDirectionValue4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputLastDirectionValue4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputLastDirectionValue4Way, (void*)(&value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00059738 File Offset: 0x00057938
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00005A9D File Offset: 0x00003C9D
		public unsafe static int directInputUnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputUnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputUnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00059754 File Offset: 0x00057954
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00005AAB File Offset: 0x00003CAB
		public unsafe static int directInputUnknownJoystickHatButtonStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputUnknownJoystickHatButtonStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputUnknownJoystickHatButtonStartIndex, (void*)(&value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00059770 File Offset: 0x00057970
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00005AB9 File Offset: 0x00003CB9
		public unsafe static int directInputJoystickStateByteSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_directInputJoystickStateByteSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_directInputJoystickStateByteSize, (void*)(&value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0005978C File Offset: 0x0005798C
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00005AC7 File Offset: 0x00003CC7
		public unsafe static int rawInputMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000597A8 File Offset: 0x000579A8
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00005AD5 File Offset: 0x00003CD5
		public unsafe static int rawInputMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000597C4 File Offset: 0x000579C4
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00005AE3 File Offset: 0x00003CE3
		public unsafe static int rawInputMaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputMaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputMaxHats, (void*)(&value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000597E0 File Offset: 0x000579E0
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00005AF1 File Offset: 0x00003CF1
		public unsafe static int rawInputMaxSliders
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputMaxSliders, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputMaxSliders, (void*)(&value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000597FC File Offset: 0x000579FC
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x00005AFF File Offset: 0x00003CFF
		public unsafe static int rawInputMaxAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputMaxAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputMaxAxisValue, (void*)(&value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00059818 File Offset: 0x00057A18
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00005B0D File Offset: 0x00003D0D
		public unsafe static int rawInputMinAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputMinAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputMinAxisValue, (void*)(&value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00059834 File Offset: 0x00057A34
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00005B1B File Offset: 0x00003D1B
		public unsafe static int rawInputMaxHatValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputMaxHatValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputMaxHatValue, (void*)(&value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00059850 File Offset: 0x00057A50
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00005B29 File Offset: 0x00003D29
		public unsafe static int rawInputHatZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputHatZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputHatZeroValue, (void*)(&value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0005986C File Offset: 0x00057A6C
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00005B37 File Offset: 0x00003D37
		public unsafe static int rawInputHatSpan
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputHatSpan, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputHatSpan, (void*)(&value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00059888 File Offset: 0x00057A88
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00005B45 File Offset: 0x00003D45
		public unsafe static int rawInputHatSpan4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputHatSpan4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputHatSpan4Way, (void*)(&value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000598A4 File Offset: 0x00057AA4
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00005B53 File Offset: 0x00003D53
		public unsafe static int rawInput_hatValue_up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_up, (void*)(&value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000598C0 File Offset: 0x00057AC0
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00005B61 File Offset: 0x00003D61
		public unsafe static int rawInput_hatValue_right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_right, (void*)(&value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000598DC File Offset: 0x00057ADC
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00005B6F File Offset: 0x00003D6F
		public unsafe static int rawInput_hatValue_down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_down, (void*)(&value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000598F8 File Offset: 0x00057AF8
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00005B7D File Offset: 0x00003D7D
		public unsafe static int rawInput_hatValue_left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInput_hatValue_left, (void*)(&value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00059914 File Offset: 0x00057B14
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00005B8B File Offset: 0x00003D8B
		public unsafe static int rawInputLastDirectionValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputLastDirectionValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputLastDirectionValue, (void*)(&value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00059930 File Offset: 0x00057B30
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00005B99 File Offset: 0x00003D99
		public unsafe static int rawInputLastDirectionValue4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputLastDirectionValue4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputLastDirectionValue4Way, (void*)(&value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0005994C File Offset: 0x00057B4C
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00005BA7 File Offset: 0x00003DA7
		public unsafe static int rawInputUnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputUnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputUnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00059968 File Offset: 0x00057B68
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x00005BB5 File Offset: 0x00003DB5
		public unsafe static int rawInputUnknownJoystickHatButtonStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputUnknownJoystickHatButtonStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputUnknownJoystickHatButtonStartIndex, (void*)(&value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00059984 File Offset: 0x00057B84
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00005BC3 File Offset: 0x00003DC3
		public unsafe static int rawInputUnifiedMouseButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputUnifiedMouseButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputUnifiedMouseButtonCount, (void*)(&value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000599A0 File Offset: 0x00057BA0
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00005BD1 File Offset: 0x00003DD1
		public unsafe static int rawInputUnifiedMouseAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputUnifiedMouseAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputUnifiedMouseAxisCount, (void*)(&value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000599BC File Offset: 0x00057BBC
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00005BDF File Offset: 0x00003DDF
		public unsafe static float rawInputUnifiedMouseAxisUnityEquivalencyMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000599D8 File Offset: 0x00057BD8
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00005BED File Offset: 0x00003DED
		public unsafe static int rawInputUnifiedKeyboardButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rawInputUnifiedKeyboardButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rawInputUnifiedKeyboardButtonCount, (void*)(&value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000599F4 File Offset: 0x00057BF4
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00005BFB File Offset: 0x00003DFB
		public unsafe static int osxMaxSticks
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMaxSticks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMaxSticks, (void*)(&value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00059A10 File Offset: 0x00057C10
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00005C09 File Offset: 0x00003E09
		public unsafe static int osxMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00059A2C File Offset: 0x00057C2C
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00005C17 File Offset: 0x00003E17
		public unsafe static int osxMaxAxesPerStick
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMaxAxesPerStick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMaxAxesPerStick, (void*)(&value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00059A48 File Offset: 0x00057C48
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00005C25 File Offset: 0x00003E25
		public unsafe static int osxMaxHatsPerStick
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMaxHatsPerStick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMaxHatsPerStick, (void*)(&value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00059A64 File Offset: 0x00057C64
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00005C33 File Offset: 0x00003E33
		public unsafe static int osxMaxAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMaxAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMaxAxisValue, (void*)(&value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00059A80 File Offset: 0x00057C80
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00005C41 File Offset: 0x00003E41
		public unsafe static int osxMinAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMinAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMinAxisValue, (void*)(&value));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00059A9C File Offset: 0x00057C9C
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00005C4F File Offset: 0x00003E4F
		public unsafe static int osxMaxPressureSensitiveButtonValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMaxPressureSensitiveButtonValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMaxPressureSensitiveButtonValue, (void*)(&value));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00059AB8 File Offset: 0x00057CB8
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00005C5D File Offset: 0x00003E5D
		public unsafe static int osxMinPressureSensitiveButtonValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMinPressureSensitiveButtonValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMinPressureSensitiveButtonValue, (void*)(&value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00059AD4 File Offset: 0x00057CD4
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00005C6B File Offset: 0x00003E6B
		public unsafe static int osxMaxHatValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxMaxHatValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxMaxHatValue, (void*)(&value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00059AF0 File Offset: 0x00057CF0
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x00005C79 File Offset: 0x00003E79
		public unsafe static int osxInputHatZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxInputHatZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxInputHatZeroValue, (void*)(&value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00059B0C File Offset: 0x00057D0C
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00005C87 File Offset: 0x00003E87
		public unsafe static int osxHatSpan
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxHatSpan, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxHatSpan, (void*)(&value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00059B28 File Offset: 0x00057D28
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00005C95 File Offset: 0x00003E95
		public unsafe static int osxHatSpan4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxHatSpan4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxHatSpan4Way, (void*)(&value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00059B44 File Offset: 0x00057D44
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00005CA3 File Offset: 0x00003EA3
		public unsafe static int osx_hatValue_up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osx_hatValue_up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osx_hatValue_up, (void*)(&value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00059B60 File Offset: 0x00057D60
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00005CB1 File Offset: 0x00003EB1
		public unsafe static int osx_hatValue_right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osx_hatValue_right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osx_hatValue_right, (void*)(&value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00059B7C File Offset: 0x00057D7C
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00005CBF File Offset: 0x00003EBF
		public unsafe static int osx_hatValue_down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osx_hatValue_down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osx_hatValue_down, (void*)(&value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00059B98 File Offset: 0x00057D98
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00005CCD File Offset: 0x00003ECD
		public unsafe static int osx_hatValue_left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osx_hatValue_left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osx_hatValue_left, (void*)(&value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00059BB4 File Offset: 0x00057DB4
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00005CDB File Offset: 0x00003EDB
		public unsafe static int osxLastDirectionValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxLastDirectionValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxLastDirectionValue, (void*)(&value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00059BD0 File Offset: 0x00057DD0
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00005CE9 File Offset: 0x00003EE9
		public unsafe static int osxLastDirectionValue4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxLastDirectionValue4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxLastDirectionValue4Way, (void*)(&value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00059BEC File Offset: 0x00057DEC
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00005CF7 File Offset: 0x00003EF7
		public unsafe static int osxUnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxUnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxUnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00059C08 File Offset: 0x00057E08
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00005D05 File Offset: 0x00003F05
		public unsafe static int osxUnknownJoystickHatButtonStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxUnknownJoystickHatButtonStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxUnknownJoystickHatButtonStartIndex, (void*)(&value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00059C24 File Offset: 0x00057E24
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00005D13 File Offset: 0x00003F13
		public unsafe static int linuxMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00059C40 File Offset: 0x00057E40
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00005D21 File Offset: 0x00003F21
		public unsafe static int linuxMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00059C5C File Offset: 0x00057E5C
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00005D2F File Offset: 0x00003F2F
		public unsafe static int linuxMaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxMaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxMaxHats, (void*)(&value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00059C78 File Offset: 0x00057E78
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00005D3D File Offset: 0x00003F3D
		public unsafe static int linuxMaxSliders
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxMaxSliders, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxMaxSliders, (void*)(&value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00059C94 File Offset: 0x00057E94
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x00005D4B File Offset: 0x00003F4B
		public unsafe static int linuxMaxAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxMaxAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxMaxAxisValue, (void*)(&value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00059CB0 File Offset: 0x00057EB0
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x00005D59 File Offset: 0x00003F59
		public unsafe static int linuxMinAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxMinAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxMinAxisValue, (void*)(&value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00059CCC File Offset: 0x00057ECC
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00005D67 File Offset: 0x00003F67
		public unsafe static int linuxMaxHatValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxMaxHatValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxMaxHatValue, (void*)(&value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00059CE8 File Offset: 0x00057EE8
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00005D75 File Offset: 0x00003F75
		public unsafe static int linuxHatZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxHatZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxHatZeroValue, (void*)(&value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00059D04 File Offset: 0x00057F04
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x00005D83 File Offset: 0x00003F83
		public unsafe static int linuxHatSpan
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxHatSpan, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxHatSpan, (void*)(&value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00059D20 File Offset: 0x00057F20
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00005D91 File Offset: 0x00003F91
		public unsafe static int linuxHatSpan4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxHatSpan4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxHatSpan4Way, (void*)(&value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00059D3C File Offset: 0x00057F3C
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x00005D9F File Offset: 0x00003F9F
		public unsafe static int linux_hatValue_up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linux_hatValue_up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linux_hatValue_up, (void*)(&value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00059D58 File Offset: 0x00057F58
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00005DAD File Offset: 0x00003FAD
		public unsafe static int linux_hatValue_right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linux_hatValue_right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linux_hatValue_right, (void*)(&value));
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00059D74 File Offset: 0x00057F74
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00005DBB File Offset: 0x00003FBB
		public unsafe static int linux_hatValue_down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linux_hatValue_down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linux_hatValue_down, (void*)(&value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00059D90 File Offset: 0x00057F90
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00005DC9 File Offset: 0x00003FC9
		public unsafe static int linux_hatValue_left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linux_hatValue_left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linux_hatValue_left, (void*)(&value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00059DAC File Offset: 0x00057FAC
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00005DD7 File Offset: 0x00003FD7
		public unsafe static int linuxLastDirectionValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxLastDirectionValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxLastDirectionValue, (void*)(&value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00059DC8 File Offset: 0x00057FC8
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00005DE5 File Offset: 0x00003FE5
		public unsafe static int linuxLastDirectionValue4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxLastDirectionValue4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxLastDirectionValue4Way, (void*)(&value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00059DE4 File Offset: 0x00057FE4
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00005DF3 File Offset: 0x00003FF3
		public unsafe static int linuxUnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxUnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxUnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00059E00 File Offset: 0x00058000
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00005E01 File Offset: 0x00004001
		public unsafe static int linuxUnknownJoystickHatButtonStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxUnknownJoystickHatButtonStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxUnknownJoystickHatButtonStartIndex, (void*)(&value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00059E1C File Offset: 0x0005801C
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00005E0F File Offset: 0x0000400F
		public unsafe static int linuxUnifiedMouseButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxUnifiedMouseButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxUnifiedMouseButtonCount, (void*)(&value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00059E38 File Offset: 0x00058038
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00005E1D File Offset: 0x0000401D
		public unsafe static int linuxUnifiedMouseAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxUnifiedMouseAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxUnifiedMouseAxisCount, (void*)(&value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00059E54 File Offset: 0x00058054
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00005E2B File Offset: 0x0000402B
		public unsafe static float linuxUnifiedMouseAxisUnityEquivalencyMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_linuxUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_linuxUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00059E70 File Offset: 0x00058070
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00005E39 File Offset: 0x00004039
		public unsafe static int sdl2MaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2MaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2MaxButtons, (void*)(&value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00059E8C File Offset: 0x0005808C
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00005E47 File Offset: 0x00004047
		public unsafe static int sdl2MaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2MaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2MaxAxes, (void*)(&value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00059EA8 File Offset: 0x000580A8
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00005E55 File Offset: 0x00004055
		public unsafe static int sdl2MaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2MaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2MaxHats, (void*)(&value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00059EC4 File Offset: 0x000580C4
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00005E63 File Offset: 0x00004063
		public unsafe static int sdl2MaxSliders
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2MaxSliders, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2MaxSliders, (void*)(&value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00059EE0 File Offset: 0x000580E0
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00005E71 File Offset: 0x00004071
		public unsafe static int sdl2MaxAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2MaxAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2MaxAxisValue, (void*)(&value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00059EFC File Offset: 0x000580FC
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00005E7F File Offset: 0x0000407F
		public unsafe static int sdl2MinAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2MinAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2MinAxisValue, (void*)(&value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00059F18 File Offset: 0x00058118
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00005E8D File Offset: 0x0000408D
		public unsafe static int sdl2AxisZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2AxisZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2AxisZeroValue, (void*)(&value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00059F34 File Offset: 0x00058134
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00005E9B File Offset: 0x0000409B
		public unsafe static int sdl2MaxHatValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2MaxHatValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2MaxHatValue, (void*)(&value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00059F50 File Offset: 0x00058150
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00005EA9 File Offset: 0x000040A9
		public unsafe static int sdl2HatZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2HatZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2HatZeroValue, (void*)(&value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00059F6C File Offset: 0x0005816C
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00005EB7 File Offset: 0x000040B7
		public unsafe static int sdl2HatSpan
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2HatSpan, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2HatSpan, (void*)(&value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00059F88 File Offset: 0x00058188
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00005EC5 File Offset: 0x000040C5
		public unsafe static int sdl2HatSpan4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2HatSpan4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2HatSpan4Way, (void*)(&value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00059FA4 File Offset: 0x000581A4
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00005ED3 File Offset: 0x000040D3
		public unsafe static int sdl2_hatValue_up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_up, (void*)(&value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00059FC0 File Offset: 0x000581C0
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00005EE1 File Offset: 0x000040E1
		public unsafe static int sdl2_hatValue_right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_right, (void*)(&value));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00059FDC File Offset: 0x000581DC
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00005EEF File Offset: 0x000040EF
		public unsafe static int sdl2_hatValue_down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_down, (void*)(&value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00059FF8 File Offset: 0x000581F8
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00005EFD File Offset: 0x000040FD
		public unsafe static int sdl2_hatValue_left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2_hatValue_left, (void*)(&value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0005A014 File Offset: 0x00058214
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00005F0B File Offset: 0x0000410B
		public unsafe static int sdl2LastDirectionValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2LastDirectionValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2LastDirectionValue, (void*)(&value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0005A030 File Offset: 0x00058230
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00005F19 File Offset: 0x00004119
		public unsafe static int sdl2LastDirectionValue4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2LastDirectionValue4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2LastDirectionValue4Way, (void*)(&value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0005A04C File Offset: 0x0005824C
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x00005F27 File Offset: 0x00004127
		public unsafe static int sdl2UnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2UnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2UnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0005A068 File Offset: 0x00058268
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x00005F35 File Offset: 0x00004135
		public unsafe static int sdl2UnknownJoystickHatButtonStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2UnknownJoystickHatButtonStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2UnknownJoystickHatButtonStartIndex, (void*)(&value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0005A084 File Offset: 0x00058284
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00005F43 File Offset: 0x00004143
		public unsafe static int sdl2UnifiedMouseButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2UnifiedMouseButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2UnifiedMouseButtonCount, (void*)(&value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0005A0A0 File Offset: 0x000582A0
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00005F51 File Offset: 0x00004151
		public unsafe static int sdl2UnifiedMouseAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2UnifiedMouseAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2UnifiedMouseAxisCount, (void*)(&value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0005A0BC File Offset: 0x000582BC
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00005F5F File Offset: 0x0000415F
		public unsafe static float sdl2UnifiedMouseAxisUnityEquivalencyMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_sdl2UnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_sdl2UnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0005A0D8 File Offset: 0x000582D8
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00005F6D File Offset: 0x0000416D
		public unsafe static int windowsUWPMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0005A0F4 File Offset: 0x000582F4
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00005F7B File Offset: 0x0000417B
		public unsafe static int windowsUWPMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0005A110 File Offset: 0x00058310
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00005F89 File Offset: 0x00004189
		public unsafe static int windowsUWPMaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPMaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPMaxHats, (void*)(&value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0005A12C File Offset: 0x0005832C
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00005F97 File Offset: 0x00004197
		public unsafe static int windowsUWPMaxSliders
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPMaxSliders, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPMaxSliders, (void*)(&value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0005A148 File Offset: 0x00058348
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00005FA5 File Offset: 0x000041A5
		public unsafe static int windowsUWPMaxAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPMaxAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPMaxAxisValue, (void*)(&value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0005A164 File Offset: 0x00058364
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00005FB3 File Offset: 0x000041B3
		public unsafe static int windowsUWPMinAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPMinAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPMinAxisValue, (void*)(&value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0005A180 File Offset: 0x00058380
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x00005FC1 File Offset: 0x000041C1
		public unsafe static int windowsUWPMaxHatValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPMaxHatValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPMaxHatValue, (void*)(&value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0005A19C File Offset: 0x0005839C
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00005FCF File Offset: 0x000041CF
		public unsafe static int windowsUWPHatZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPHatZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPHatZeroValue, (void*)(&value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0005A1B8 File Offset: 0x000583B8
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00005FDD File Offset: 0x000041DD
		public unsafe static int windowsUWPDirectionsPerHat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPDirectionsPerHat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPDirectionsPerHat, (void*)(&value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x0005A1D4 File Offset: 0x000583D4
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00005FEB File Offset: 0x000041EB
		public unsafe static int windowsUWPHatSpan
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPHatSpan, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPHatSpan, (void*)(&value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x0005A1F0 File Offset: 0x000583F0
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00005FF9 File Offset: 0x000041F9
		public unsafe static int windowsUWPHatSpan4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPHatSpan4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPHatSpan4Way, (void*)(&value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0005A20C File Offset: 0x0005840C
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00006007 File Offset: 0x00004207
		public unsafe static int windowsUWPLastDirectionValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPLastDirectionValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPLastDirectionValue, (void*)(&value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0005A228 File Offset: 0x00058428
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00006015 File Offset: 0x00004215
		public unsafe static int windowsUWPLastDirectionValue4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPLastDirectionValue4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPLastDirectionValue4Way, (void*)(&value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0005A244 File Offset: 0x00058444
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00006023 File Offset: 0x00004223
		public unsafe static int windowsUWPUnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPUnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPUnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0005A260 File Offset: 0x00058460
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00006031 File Offset: 0x00004231
		public unsafe static int windowsUWPUnknownJoystickHatButtonStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPUnknownJoystickHatButtonStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPUnknownJoystickHatButtonStartIndex, (void*)(&value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0005A27C File Offset: 0x0005847C
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x0000603F File Offset: 0x0000423F
		public unsafe static int windowsUWPUnifiedMouseButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseButtonCount, (void*)(&value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0005A298 File Offset: 0x00058498
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0000604D File Offset: 0x0000424D
		public unsafe static int windowsUWPUnifiedMouseAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisCount, (void*)(&value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0005A2B4 File Offset: 0x000584B4
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0000605B File Offset: 0x0000425B
		public unsafe static float windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0005A2D0 File Offset: 0x000584D0
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00006069 File Offset: 0x00004269
		public unsafe static int xInputMaxVibration
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_xInputMaxVibration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_xInputMaxVibration, (void*)(&value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0005A2EC File Offset: 0x000584EC
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00006077 File Offset: 0x00004277
		public unsafe static int xInputMinVibration
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_xInputMinVibration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_xInputMinVibration, (void*)(&value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0005A308 File Offset: 0x00058508
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00006085 File Offset: 0x00004285
		public unsafe static float xInputAllowedVibrationInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_xInputAllowedVibrationInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_xInputAllowedVibrationInterval, (void*)(&value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0005A324 File Offset: 0x00058524
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00006093 File Offset: 0x00004293
		public unsafe static int customPlatformMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_customPlatformMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_customPlatformMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0005A340 File Offset: 0x00058540
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x000060A1 File Offset: 0x000042A1
		public unsafe static int customPlatformMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_customPlatformMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_customPlatformMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0005A35C File Offset: 0x0005855C
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x000060AF File Offset: 0x000042AF
		public unsafe static int internalDriverMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0005A378 File Offset: 0x00058578
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x000060BD File Offset: 0x000042BD
		public unsafe static int internalDriverMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0005A394 File Offset: 0x00058594
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x000060CB File Offset: 0x000042CB
		public unsafe static int internalDriverMaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverMaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverMaxHats, (void*)(&value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0005A3B0 File Offset: 0x000585B0
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x000060D9 File Offset: 0x000042D9
		public unsafe static int internalDriverMaxSliders
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverMaxSliders, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverMaxSliders, (void*)(&value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0005A3CC File Offset: 0x000585CC
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x000060E7 File Offset: 0x000042E7
		public unsafe static int internalDriverMaxAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverMaxAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverMaxAxisValue, (void*)(&value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0005A3E8 File Offset: 0x000585E8
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x000060F5 File Offset: 0x000042F5
		public unsafe static int internalDriverMinAxisValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverMinAxisValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverMinAxisValue, (void*)(&value));
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0005A404 File Offset: 0x00058604
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00006103 File Offset: 0x00004303
		public unsafe static int internalDriverMaxHatValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverMaxHatValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverMaxHatValue, (void*)(&value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0005A420 File Offset: 0x00058620
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00006111 File Offset: 0x00004311
		public unsafe static int internalDriverHatZeroValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverHatZeroValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverHatZeroValue, (void*)(&value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0005A43C File Offset: 0x0005863C
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x0000611F File Offset: 0x0000431F
		public unsafe static int internalDriverHatSpan
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverHatSpan, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverHatSpan, (void*)(&value));
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0005A458 File Offset: 0x00058658
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x0000612D File Offset: 0x0000432D
		public unsafe static int internalDriverHatSpan4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverHatSpan4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverHatSpan4Way, (void*)(&value));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0005A474 File Offset: 0x00058674
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x0000613B File Offset: 0x0000433B
		public unsafe static int internalDriver_hatValue_up
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_up, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_up, (void*)(&value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0005A490 File Offset: 0x00058690
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00006149 File Offset: 0x00004349
		public unsafe static int internalDriver_hatValue_right
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_right, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_right, (void*)(&value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0005A4AC File Offset: 0x000586AC
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00006157 File Offset: 0x00004357
		public unsafe static int internalDriver_hatValue_down
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_down, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_down, (void*)(&value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0005A4C8 File Offset: 0x000586C8
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00006165 File Offset: 0x00004365
		public unsafe static int internalDriver_hatValue_left
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_left, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriver_hatValue_left, (void*)(&value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0005A4E4 File Offset: 0x000586E4
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00006173 File Offset: 0x00004373
		public unsafe static int internalDriverLastDirectionValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverLastDirectionValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverLastDirectionValue, (void*)(&value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0005A500 File Offset: 0x00058700
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00006181 File Offset: 0x00004381
		public unsafe static int internalDriverLastDirectionValue4Way
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverLastDirectionValue4Way, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverLastDirectionValue4Way, (void*)(&value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0005A51C File Offset: 0x0005871C
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0000618F File Offset: 0x0000438F
		public unsafe static int internalDriverUnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverUnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverUnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0005A538 File Offset: 0x00058738
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x0000619D File Offset: 0x0000439D
		public unsafe static int internalDriverUnknownJoystickHatButtonStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverUnknownJoystickHatButtonStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverUnknownJoystickHatButtonStartIndex, (void*)(&value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0005A554 File Offset: 0x00058754
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x000061AB File Offset: 0x000043AB
		public unsafe static int internalDriverUnifiedMouseButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseButtonCount, (void*)(&value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0005A570 File Offset: 0x00058770
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x000061B9 File Offset: 0x000043B9
		public unsafe static int internalDriverUnifiedMouseAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseAxisCount, (void*)(&value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0005A58C File Offset: 0x0005878C
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x000061C7 File Offset: 0x000043C7
		public unsafe static float internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0005A5A8 File Offset: 0x000587A8
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x000061D5 File Offset: 0x000043D5
		public unsafe static int webGLMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_webGLMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_webGLMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0005A5C4 File Offset: 0x000587C4
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x000061E3 File Offset: 0x000043E3
		public unsafe static int webGLMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_webGLMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_webGLMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0005A5E0 File Offset: 0x000587E0
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x000061F1 File Offset: 0x000043F1
		public unsafe static int gameCoreMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCoreMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCoreMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0005A5FC File Offset: 0x000587FC
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x000061FF File Offset: 0x000043FF
		public unsafe static int gameCoreMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCoreMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCoreMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0005A618 File Offset: 0x00058818
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x0000620D File Offset: 0x0000440D
		public unsafe static int gameCoreMaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCoreMaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCoreMaxHats, (void*)(&value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0005A634 File Offset: 0x00058834
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x0000621B File Offset: 0x0000441B
		public unsafe static int gameCoreUnknownJoystickButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickButtonCount, (void*)(&value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0005A650 File Offset: 0x00058850
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00006229 File Offset: 0x00004429
		public unsafe static int gameCoreUnknownJoystickAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickAxisCount, (void*)(&value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0005A66C File Offset: 0x0005886C
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00006237 File Offset: 0x00004437
		public unsafe static int gameCoreUnknownJoystickHatCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickHatCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCoreUnknownJoystickHatCount, (void*)(&value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0005A688 File Offset: 0x00058888
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00006245 File Offset: 0x00004445
		public unsafe static int appleGCControllerMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_appleGCControllerMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_appleGCControllerMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0005A6A4 File Offset: 0x000588A4
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00006253 File Offset: 0x00004453
		public unsafe static int appleGCControllerMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_appleGCControllerMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_appleGCControllerMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0005A6C0 File Offset: 0x000588C0
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00006261 File Offset: 0x00004461
		public unsafe static int appleGCControllerUnknownJoystickButtonCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_appleGCControllerUnknownJoystickButtonCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_appleGCControllerUnknownJoystickButtonCount, (void*)(&value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0005A6DC File Offset: 0x000588DC
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0000626F File Offset: 0x0000446F
		public unsafe static int appleGCControllerUnknownJoystickAxisCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_appleGCControllerUnknownJoystickAxisCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_appleGCControllerUnknownJoystickAxisCount, (void*)(&value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0005A6F8 File Offset: 0x000588F8
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x0000627D File Offset: 0x0000447D
		public unsafe static int unknownJoystickMaxButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickMaxButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickMaxButtons, (void*)(&value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0005A714 File Offset: 0x00058914
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x0000628B File Offset: 0x0000448B
		public unsafe static int unknownJoystickMaxAxes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickMaxAxes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickMaxAxes, (void*)(&value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0005A730 File Offset: 0x00058930
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00006299 File Offset: 0x00004499
		public unsafe static int unknownJoystickMaxHats
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickMaxHats, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickMaxHats, (void*)(&value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0005A74C File Offset: 0x0005894C
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x000062A7 File Offset: 0x000044A7
		public unsafe static int unknownJoystickButtonsPerHat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickButtonsPerHat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickButtonsPerHat, (void*)(&value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0005A768 File Offset: 0x00058968
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x000062B5 File Offset: 0x000044B5
		public unsafe static int unknownJoystickAxisElementIdentifierStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickAxisElementIdentifierStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickAxisElementIdentifierStartIndex, (void*)(&value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0005A784 File Offset: 0x00058984
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000062C3 File Offset: 0x000044C3
		public unsafe static int unknownJoystickButtonElementIdentifierStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickButtonElementIdentifierStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickButtonElementIdentifierStartIndex, (void*)(&value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0005A7A0 File Offset: 0x000589A0
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x000062D1 File Offset: 0x000044D1
		public unsafe static int unknownJoystickHatElementIdentifierStartIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickHatElementIdentifierStartIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickHatElementIdentifierStartIndex, (void*)(&value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0005A7BC File Offset: 0x000589BC
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x000062DF File Offset: 0x000044DF
		public unsafe static float unknownJoystickDefaultAxisDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickDefaultAxisDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickDefaultAxisDeadZone, (void*)(&value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0005A7D8 File Offset: 0x000589D8
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x000062ED File Offset: 0x000044ED
		public unsafe static float defaultAbsoluteAxisPollingDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultAbsoluteAxisPollingDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultAbsoluteAxisPollingDeadZone, (void*)(&value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0005A7F4 File Offset: 0x000589F4
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x000062FB File Offset: 0x000044FB
		public unsafe static float defaultRelativeAxisPollingDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultRelativeAxisPollingDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultRelativeAxisPollingDeadZone, (void*)(&value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0005A810 File Offset: 0x00058A10
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00006309 File Offset: 0x00004509
		public unsafe static float defaultMouseXYAxisPollingDeadzone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultMouseXYAxisPollingDeadzone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultMouseXYAxisPollingDeadzone, (void*)(&value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0005A82C File Offset: 0x00058A2C
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00006317 File Offset: 0x00004517
		public unsafe static float defaultMouseOtherAxisPollingDeadzone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultMouseOtherAxisPollingDeadzone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultMouseOtherAxisPollingDeadzone, (void*)(&value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0005A848 File Offset: 0x00058A48
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00006325 File Offset: 0x00004525
		public unsafe static float defaultButtonDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonDeadZone, (void*)(&value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0005A864 File Offset: 0x00058A64
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00006333 File Offset: 0x00004533
		public unsafe static float hardwareButtonDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_hardwareButtonDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_hardwareButtonDeadZone, (void*)(&value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0005A880 File Offset: 0x00058A80
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x00006341 File Offset: 0x00004541
		public unsafe static float axisDefaultSensitivity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_axisDefaultSensitivity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_axisDefaultSensitivity, (void*)(&value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0005A89C File Offset: 0x00058A9C
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0000634F File Offset: 0x0000454F
		public unsafe static AxisSensitivityType axisDefaultSensitivityType
		{
			get
			{
				AxisSensitivityType axisSensitivityType;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_axisDefaultSensitivityType, (void*)(&axisSensitivityType));
				return axisSensitivityType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_axisDefaultSensitivityType, (void*)(&value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0005A8B8 File Offset: 0x00058AB8
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x0000635D File Offset: 0x0000455D
		public unsafe static float defaultButtonDoublePressSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonDoublePressSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonDoublePressSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0005A8D4 File Offset: 0x00058AD4
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x0000636B File Offset: 0x0000456B
		public unsafe static float minDoubleButtonPressSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_minDoubleButtonPressSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_minDoubleButtonPressSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0005A8F0 File Offset: 0x00058AF0
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00006379 File Offset: 0x00004579
		public unsafe static float maxDoubleButtonPressSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_maxDoubleButtonPressSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_maxDoubleButtonPressSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0005A90C File Offset: 0x00058B0C
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00006387 File Offset: 0x00004587
		public unsafe static float defaultButtonShortPressTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonShortPressTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonShortPressTime, (void*)(&value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0005A928 File Offset: 0x00058B28
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00006395 File Offset: 0x00004595
		public unsafe static float minButtonShortPressTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_minButtonShortPressTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_minButtonShortPressTime, (void*)(&value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0005A944 File Offset: 0x00058B44
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x000063A3 File Offset: 0x000045A3
		public unsafe static float maxButtonShortPressTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_maxButtonShortPressTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_maxButtonShortPressTime, (void*)(&value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0005A960 File Offset: 0x00058B60
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000063B1 File Offset: 0x000045B1
		public unsafe static float defaultButtonShortPressExpiresIn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonShortPressExpiresIn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonShortPressExpiresIn, (void*)(&value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0005A97C File Offset: 0x00058B7C
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x000063BF File Offset: 0x000045BF
		public unsafe static float minButtonShortPressExpiresIn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_minButtonShortPressExpiresIn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_minButtonShortPressExpiresIn, (void*)(&value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0005A998 File Offset: 0x00058B98
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000063CD File Offset: 0x000045CD
		public unsafe static float maxButtonShortPressExpiresIn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_maxButtonShortPressExpiresIn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_maxButtonShortPressExpiresIn, (void*)(&value));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0005A9B4 File Offset: 0x00058BB4
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x000063DB File Offset: 0x000045DB
		public unsafe static float defaultButtonLongPressTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonLongPressTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonLongPressTime, (void*)(&value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0005A9D0 File Offset: 0x00058BD0
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x000063E9 File Offset: 0x000045E9
		public unsafe static float minButtonLongPressTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_minButtonLongPressTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_minButtonLongPressTime, (void*)(&value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0005A9EC File Offset: 0x00058BEC
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x000063F7 File Offset: 0x000045F7
		public unsafe static float maxButtonLongPressTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_maxButtonLongPressTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_maxButtonLongPressTime, (void*)(&value));
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0005AA08 File Offset: 0x00058C08
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00006405 File Offset: 0x00004605
		public unsafe static float defaultButtonLongPressExpiresIn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonLongPressExpiresIn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonLongPressExpiresIn, (void*)(&value));
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0005AA24 File Offset: 0x00058C24
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00006413 File Offset: 0x00004613
		public unsafe static float minButtonLongPressExpiresIn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_minButtonLongPressExpiresIn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_minButtonLongPressExpiresIn, (void*)(&value));
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0005AA40 File Offset: 0x00058C40
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00006421 File Offset: 0x00004621
		public unsafe static float maxButtonLongPressExpiresIn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_maxButtonLongPressExpiresIn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_maxButtonLongPressExpiresIn, (void*)(&value));
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0005AA5C File Offset: 0x00058C5C
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x0000642F File Offset: 0x0000462F
		public unsafe static float defaultButtonRepeatDelay
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonRepeatDelay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonRepeatDelay, (void*)(&value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0005AA78 File Offset: 0x00058C78
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x0000643D File Offset: 0x0000463D
		public unsafe static float defaultButtonRepeatRate
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultButtonRepeatRate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultButtonRepeatRate, (void*)(&value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0005AA94 File Offset: 0x00058C94
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x0000644B File Offset: 0x0000464B
		public unsafe static float minButtonRepeatRate
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_minButtonRepeatRate, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_minButtonRepeatRate, (void*)(&value));
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0005AAB0 File Offset: 0x00058CB0
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00006459 File Offset: 0x00004659
		public unsafe static float mouseAxisPollingTimerLength
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_mouseAxisPollingTimerLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_mouseAxisPollingTimerLength, (void*)(&value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0005AACC File Offset: 0x00058CCC
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00006467 File Offset: 0x00004667
		public unsafe static float fallbackPollingTimeout
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_fallbackPollingTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_fallbackPollingTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0005AAE8 File Offset: 0x00058CE8
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00006475 File Offset: 0x00004675
		public unsafe static string unknownJoystickName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_unknownJoystickName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_unknownJoystickName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0005AB08 File Offset: 0x00058D08
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00006487 File Offset: 0x00004687
		public unsafe static float xInputControllerVibrationRenewalInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_xInputControllerVibrationRenewalInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_xInputControllerVibrationRenewalInterval, (void*)(&value));
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0005AB24 File Offset: 0x00058D24
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00006495 File Offset: 0x00004695
		public unsafe static int defaultInputThreadUpdateRateFPS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultInputThreadUpdateRateFPS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultInputThreadUpdateRateFPS, (void*)(&value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0005AB40 File Offset: 0x00058D40
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x000064A3 File Offset: 0x000046A3
		public unsafe static int maxInputThreadUpdateRateFPS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_maxInputThreadUpdateRateFPS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_maxInputThreadUpdateRateFPS, (void*)(&value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0005AB5C File Offset: 0x00058D5C
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x000064B1 File Offset: 0x000046B1
		public unsafe static int osxXInputOutputReportRefreshRateFPS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxXInputOutputReportRefreshRateFPS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxXInputOutputReportRefreshRateFPS, (void*)(&value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0005AB78 File Offset: 0x00058D78
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x000064BF File Offset: 0x000046BF
		public unsafe static int defaultOutputRefreshRateFPS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultOutputRefreshRateFPS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultOutputRefreshRateFPS, (void*)(&value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0005AB94 File Offset: 0x00058D94
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x000064CD File Offset: 0x000046CD
		public unsafe static int hidOutputReportRefreshRateFPS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_hidOutputReportRefreshRateFPS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_hidOutputReportRefreshRateFPS, (void*)(&value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0005ABB0 File Offset: 0x00058DB0
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x000064DB File Offset: 0x000046DB
		public unsafe static int hidOutputReportThreadKillTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_hidOutputReportThreadKillTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_hidOutputReportThreadKillTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0005ABCC File Offset: 0x00058DCC
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x000064E9 File Offset: 0x000046E9
		public unsafe static int joystickInputReportRingBufferCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickInputReportRingBufferCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickInputReportRingBufferCapacity, (void*)(&value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0005ABE8 File Offset: 0x00058DE8
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x000064F7 File Offset: 0x000046F7
		public unsafe static float joystickInputReportRingBufferCapacityDuration
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickInputReportRingBufferCapacityDuration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickInputReportRingBufferCapacityDuration, (void*)(&value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0005AC04 File Offset: 0x00058E04
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00006505 File Offset: 0x00004705
		public unsafe static string resourecesDLLPath_windowsStandalone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_resourecesDLLPath_windowsStandalone, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_resourecesDLLPath_windowsStandalone, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0005AC24 File Offset: 0x00058E24
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00006517 File Offset: 0x00004717
		public unsafe static string resourecesDLLPath_osxStandalone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_resourecesDLLPath_osxStandalone, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_resourecesDLLPath_osxStandalone, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0005AC44 File Offset: 0x00058E44
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00006529 File Offset: 0x00004729
		public unsafe static string resourecesDLLPath_linux
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_resourecesDLLPath_linux, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_resourecesDLLPath_linux, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0005AC64 File Offset: 0x00058E64
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x0000653B File Offset: 0x0000473B
		public unsafe static float defaultInputBehaviorAxisSensitivity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSensitivity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSensitivity, (void*)(&value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0005AC80 File Offset: 0x00058E80
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00006549 File Offset: 0x00004749
		public unsafe static float defaultInputBehaviorAxisSimulation_gravity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_gravity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_gravity, (void*)(&value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0005AC9C File Offset: 0x00058E9C
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00006557 File Offset: 0x00004757
		public unsafe static float defaultInputBehaviorAxisSimulation_sensitivity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_sensitivity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_sensitivity, (void*)(&value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0005ACB8 File Offset: 0x00058EB8
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00006565 File Offset: 0x00004765
		public unsafe static bool defaultInputBehaviorAxisSmoothing_snap
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_snap, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_snap, (void*)(&value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0005ACD4 File Offset: 0x00058ED4
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00006573 File Offset: 0x00004773
		public unsafe static bool defaultInputBehaviorAxisSmoothing_instantReverse
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_instantReverse, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_instantReverse, (void*)(&value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0005ACF0 File Offset: 0x00058EF0
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00006581 File Offset: 0x00004781
		public unsafe static bool defaultInputBehaviorAxisSimulation_enabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_enabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_enabled, (void*)(&value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0005AD0C File Offset: 0x00058F0C
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x0000658F File Offset: 0x0000478F
		public unsafe static int allFlagsIntEnum
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_allFlagsIntEnum, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_allFlagsIntEnum, (void*)(&value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0005AD28 File Offset: 0x00058F28
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x0000659D File Offset: 0x0000479D
		public unsafe static float osxPreventSystemSleepInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_osxPreventSystemSleepInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_osxPreventSystemSleepInterval, (void*)(&value));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0005AD44 File Offset: 0x00058F44
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x000065AB File Offset: 0x000047AB
		public unsafe static string schemaNameSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaNameSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaNameSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0005AD64 File Offset: 0x00058F64
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000065BD File Offset: 0x000047BD
		public unsafe static string schemaBaseLocation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaBaseLocation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaBaseLocation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0005AD84 File Offset: 0x00058F84
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x000065CF File Offset: 0x000047CF
		public unsafe static string schemaVersionControllerMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaVersionControllerMap, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaVersionControllerMap, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0005ADA4 File Offset: 0x00058FA4
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x000065E1 File Offset: 0x000047E1
		public unsafe static string schemaVersionCalibrationMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaVersionCalibrationMap, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaVersionCalibrationMap, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0005ADC4 File Offset: 0x00058FC4
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000065F3 File Offset: 0x000047F3
		public unsafe static string schemaVersionInputBehavior
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaVersionInputBehavior, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaVersionInputBehavior, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00006605 File Offset: 0x00004805
		public unsafe static string schemaVersionControllerTemplateMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaVersionControllerTemplateMap, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaVersionControllerTemplateMap, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0005AE04 File Offset: 0x00059004
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00006617 File Offset: 0x00004817
		public unsafe static string schemaVersionPlayerEnabledMapsHelperData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaVersionPlayerEnabledMapsHelperData, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaVersionPlayerEnabledMapsHelperData, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0005AE24 File Offset: 0x00059024
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00006629 File Offset: 0x00004829
		public unsafe static string schemaVersionPlayerControllerMapLayoutManagerData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_schemaVersionPlayerControllerMapLayoutManagerData, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_schemaVersionPlayerControllerMapLayoutManagerData, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x0005AE44 File Offset: 0x00059044
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x0000663B File Offset: 0x0000483B
		public unsafe static int controllerMapDataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_controllerMapDataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_controllerMapDataVersion, (void*)(&value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0005AE60 File Offset: 0x00059060
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00006649 File Offset: 0x00004849
		public unsafe static int calibrationMapDataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_calibrationMapDataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_calibrationMapDataVersion, (void*)(&value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0005AE7C File Offset: 0x0005907C
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x00006657 File Offset: 0x00004857
		public unsafe static int inputBehaviorDataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_inputBehaviorDataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_inputBehaviorDataVersion, (void*)(&value));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0005AE98 File Offset: 0x00059098
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00006665 File Offset: 0x00004865
		public unsafe static int controllerTemplateMapDataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_controllerTemplateMapDataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_controllerTemplateMapDataVersion, (void*)(&value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0005AEB4 File Offset: 0x000590B4
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00006673 File Offset: 0x00004873
		public unsafe static int playerMapEnablerDataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_playerMapEnablerDataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_playerMapEnablerDataVersion, (void*)(&value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0005AED0 File Offset: 0x000590D0
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00006681 File Offset: 0x00004881
		public unsafe static int playerControllerMapLayoutManagerDataVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_playerControllerMapLayoutManagerDataVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_playerControllerMapLayoutManagerDataVersion, (void*)(&value));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0005AEEC File Offset: 0x000590EC
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x0000668F File Offset: 0x0000488F
		public unsafe static int controllerElementType_trueElements_minValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_controllerElementType_trueElements_minValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_controllerElementType_trueElements_minValue, (void*)(&value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0005AF08 File Offset: 0x00059108
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x0000669D File Offset: 0x0000489D
		public unsafe static int controllerElementType_trueElements_maxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_controllerElementType_trueElements_maxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_controllerElementType_trueElements_maxValue, (void*)(&value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0005AF24 File Offset: 0x00059124
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x000066AB File Offset: 0x000048AB
		public unsafe static float pressureSensitiveButtonDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_pressureSensitiveButtonDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_pressureSensitiveButtonDeadZone, (void*)(&value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0005AF40 File Offset: 0x00059140
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x000066B9 File Offset: 0x000048B9
		public unsafe static string rewiredEditorAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rewiredEditorAssembly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rewiredEditorAssembly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0005AF60 File Offset: 0x00059160
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x000066CB File Offset: 0x000048CB
		public unsafe static string rewiredEditorInputEditorClassFullName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_rewiredEditorInputEditorClassFullName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_rewiredEditorInputEditorClassFullName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0005AF80 File Offset: 0x00059180
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x000066DD File Offset: 0x000048DD
		public unsafe static string nintendoSwitchPluginEditorRuntimeAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginEditorRuntimeAssembly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginEditorRuntimeAssembly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0005AFA0 File Offset: 0x000591A0
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x000066EF File Offset: 0x000048EF
		public unsafe static string nintendoSwitchPluginInputManagerFullClassPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginInputManagerFullClassPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginInputManagerFullClassPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0005AFC0 File Offset: 0x000591C0
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00006701 File Offset: 0x00004901
		public unsafe static string nintendoSwitchPluginHWJoystickMapGuid_JoyConDual
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_JoyConDual, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_JoyConDual, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0005AFE0 File Offset: 0x000591E0
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00006713 File Offset: 0x00004913
		public unsafe static string nintendoSwitchPluginHWJoystickMapGuid_Handheld
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_Handheld, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_Handheld, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0005B000 File Offset: 0x00059200
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00006725 File Offset: 0x00004925
		public unsafe static string stadiaPluginEditorRuntimeAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_stadiaPluginEditorRuntimeAssembly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_stadiaPluginEditorRuntimeAssembly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0005B020 File Offset: 0x00059220
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00006737 File Offset: 0x00004937
		public unsafe static string stadiaPluginInputManagerFullClassPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_stadiaPluginInputManagerFullClassPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_stadiaPluginInputManagerFullClassPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0005B040 File Offset: 0x00059240
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00006749 File Offset: 0x00004949
		public unsafe static string gameCorePluginEditorRuntimeAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCorePluginEditorRuntimeAssembly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCorePluginEditorRuntimeAssembly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0005B060 File Offset: 0x00059260
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x0000675B File Offset: 0x0000495B
		public unsafe static string gameCorePluginInputManagerFullClassPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_gameCorePluginInputManagerFullClassPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_gameCorePluginInputManagerFullClassPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0005B080 File Offset: 0x00059280
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x0000676D File Offset: 0x0000496D
		public unsafe static string ps5PluginEditorRuntimeAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ps5PluginEditorRuntimeAssembly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ps5PluginEditorRuntimeAssembly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0005B0A0 File Offset: 0x000592A0
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x0000677F File Offset: 0x0000497F
		public unsafe static string ps5PluginInputManagerFullClassPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ps5PluginInputManagerFullClassPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ps5PluginInputManagerFullClassPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0005B0C0 File Offset: 0x000592C0
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00006791 File Offset: 0x00004991
		public unsafe static int vendorId_sony
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_vendorId_sony, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_vendorId_sony, (void*)(&value));
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0005B0DC File Offset: 0x000592DC
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x0000679F File Offset: 0x0000499F
		public unsafe static int updateLoopTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_updateLoopTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_updateLoopTypeCount, (void*)(&value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0005B0F8 File Offset: 0x000592F8
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x000067AD File Offset: 0x000049AD
		public unsafe static Il2CppStructArray<PidVid> questionablePidVids
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_questionablePidVids, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PidVid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_questionablePidVids, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0005B120 File Offset: 0x00059320
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x000067BF File Offset: 0x000049BF
		public unsafe static Il2CppStructArray<int> questionableVIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_questionableVIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_questionableVIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0005B148 File Offset: 0x00059348
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x000067D1 File Offset: 0x000049D1
		public unsafe static Guid joystickGuid_unknownController
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickGuid_unknownController, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickGuid_unknownController, (void*)(&value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0005B164 File Offset: 0x00059364
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x000067DF File Offset: 0x000049DF
		public unsafe static Guid joystickGuid_appleMFiController
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickGuid_appleMFiController, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickGuid_appleMFiController, (void*)(&value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0005B180 File Offset: 0x00059380
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x000067ED File Offset: 0x000049ED
		public unsafe static Guid joystickGuid_standardizedGamepad
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickGuid_standardizedGamepad, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickGuid_standardizedGamepad, (void*)(&value));
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0005B19C File Offset: 0x0005939C
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x000067FB File Offset: 0x000049FB
		public unsafe static Guid joystickGuid_SonyDualShock4
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickGuid_SonyDualShock4, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickGuid_SonyDualShock4, (void*)(&value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0005B1B8 File Offset: 0x000593B8
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00006809 File Offset: 0x00004A09
		public unsafe static Guid joystickGuid_SonyPS4AimController
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_joystickGuid_SonyPS4AimController, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_joystickGuid_SonyPS4AimController, (void*)(&value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0005B1D4 File Offset: 0x000593D4
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00006817 File Offset: 0x00004A17
		public unsafe static Guid hardwareTypeGuid_universalKeyboard
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_hardwareTypeGuid_universalKeyboard, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_hardwareTypeGuid_universalKeyboard, (void*)(&value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0005B1F0 File Offset: 0x000593F0
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00006825 File Offset: 0x00004A25
		public unsafe static Guid hardwareTypeGuid_universalMouse
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_hardwareTypeGuid_universalMouse, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_hardwareTypeGuid_universalMouse, (void*)(&value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0005B20C File Offset: 0x0005940C
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00006833 File Offset: 0x00004A33
		public unsafe static ReadOnlyCollection<ControllerElementIdentifier> ROlfSOGtabStODOfZKBbnjVoDls
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ROlfSOGtabStODOfZKBbnjVoDls, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ROlfSOGtabStODOfZKBbnjVoDls, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0005B234 File Offset: 0x00059434
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00006845 File Offset: 0x00004A45
		public unsafe static ReadOnlyCollection<ControllerElementIdentifier> WjkorWscNtnASKNQIpakJrLeBJn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_WjkorWscNtnASKNQIpakJrLeBJn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_WjkorWscNtnASKNQIpakJrLeBJn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0005B25C File Offset: 0x0005945C
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00006857 File Offset: 0x00004A57
		public unsafe static IList<string> mouseAxisUnityNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_mouseAxisUnityNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_mouseAxisUnityNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0005B284 File Offset: 0x00059484
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00006869 File Offset: 0x00004A69
		public unsafe static Il2CppStringArray KCpQCyoHQPesEQLJJciQPRkSnOc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_KCpQCyoHQPesEQLJJciQPRkSnOc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_KCpQCyoHQPesEQLJJciQPRkSnOc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0005B2AC File Offset: 0x000594AC
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x0000687B File Offset: 0x00004A7B
		public unsafe static IList<string> mouseButtonUnityNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_mouseButtonUnityNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_mouseButtonUnityNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0005B2D4 File Offset: 0x000594D4
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x0000688D File Offset: 0x00004A8D
		public unsafe static Il2CppStringArray bfEDhQnQUuAVncifZOvIfOIkLuJ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_bfEDhQnQUuAVncifZOvIfOIkLuJ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_bfEDhQnQUuAVncifZOvIfOIkLuJ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0005B2FC File Offset: 0x000594FC
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x0000689F File Offset: 0x00004A9F
		public unsafe static IList<string> keyboardKeyNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_keyboardKeyNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_keyboardKeyNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0005B324 File Offset: 0x00059524
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x000068B1 File Offset: 0x00004AB1
		public unsafe static Il2CppStringArray ubecLkaCHeWXfcESHEAkRDDRqdFi
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ubecLkaCHeWXfcESHEAkRDDRqdFi, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ubecLkaCHeWXfcESHEAkRDDRqdFi, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0005B34C File Offset: 0x0005954C
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x000068C3 File Offset: 0x00004AC3
		public unsafe static IList<int> keyboardKeyValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_keyboardKeyValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_keyboardKeyValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0005B374 File Offset: 0x00059574
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x000068D5 File Offset: 0x00004AD5
		public unsafe static Il2CppStructArray<int> _keyboardKeyValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr__keyboardKeyValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr__keyboardKeyValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0005B39C File Offset: 0x0005959C
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x000068E7 File Offset: 0x00004AE7
		public unsafe static IList<string> modifierKeyShortNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_modifierKeyShortNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_modifierKeyShortNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0005B3C4 File Offset: 0x000595C4
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x000068F9 File Offset: 0x00004AF9
		public unsafe static Il2CppStringArray JpAomxCzfsPGoOJSCggFhDcpfPcT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_JpAomxCzfsPGoOJSCggFhDcpfPcT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_JpAomxCzfsPGoOJSCggFhDcpfPcT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0005B3EC File Offset: 0x000595EC
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x0000690B File Offset: 0x00004B0B
		public unsafe static IList<PidVid> pidVids_sony_dualShock4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_pidVids_sony_dualShock4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<PidVid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_pidVids_sony_dualShock4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0005B414 File Offset: 0x00059614
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x0000691D File Offset: 0x00004B1D
		public unsafe static Il2CppStructArray<PidVid> DRKFsvtDZLqnQbwbIbyzPOAQwTA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DRKFsvtDZLqnQbwbIbyzPOAQwTA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PidVid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DRKFsvtDZLqnQbwbIbyzPOAQwTA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x0005B43C File Offset: 0x0005963C
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x0000692F File Offset: 0x00004B2F
		public unsafe static IList<string> productNames_sony_dualShock4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_productNames_sony_dualShock4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_productNames_sony_dualShock4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0005B464 File Offset: 0x00059664
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00006941 File Offset: 0x00004B41
		public unsafe static Il2CppStringArray AHQWiENFqxAQeDTBiNeOBdxttDx
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_AHQWiENFqxAQeDTBiNeOBdxttDx, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_AHQWiENFqxAQeDTBiNeOBdxttDx, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0005B48C File Offset: 0x0005968C
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00006953 File Offset: 0x00004B53
		public unsafe static Il2CppReferenceArray<ControllerElementIdentifier> tHPJnmSqpQxTYmFcRsjOGXuEFij
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_tHPJnmSqpQxTYmFcRsjOGXuEFij, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerElementIdentifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_tHPJnmSqpQxTYmFcRsjOGXuEFij, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_systemPlayerId;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_menuRoot;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_programVersion1;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_programVersion2;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_programVersion3;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_programVersion4;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_dataVersion;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_unityMajorVersion;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_unityMajorVersionIdentifier;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_isTrial;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_copyrightYear;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_defaultNamespace;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_defaultLogLevel;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_allowInputWhenEditorPaused;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_editorGUIUpdateInterval;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_joystickRefreshPollCheckTimeout;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_controllerRefreshWaitTimeout;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_buttonsPerHat;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_keyboardKeyCount;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_keyboardModifierKeyCount;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_unityMouseButtonCount;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_unityMouseAxisCount;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_unityMaxJoysticks;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_unityJoystickButtonCount;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_unityJoystickStartingButtonKeycodeValue;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_unityJoystickAxisCount;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_unityJoystickLastJoystickIdWithButtonKeyCodes;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_unityJoystickPrefix;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_unityJoystickAxisSuffix;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_unityJoystickButtonSuffix;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_directInputMaxButtons;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_directInputMaxAxes;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_directInputMaxHats;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_directInputMaxSliders;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_directInputMaxAxisValue;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_directInputMinAxisValue;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_directInputMaxHatValue;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_directInputHatZeroValue;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_directInputHatSpan;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_directInputHatSpan4Way;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_directInput_hatValue_up;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_directInput_hatValue_right;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_directInput_hatValue_down;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr_directInput_hatValue_left;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr_directInputLastDirectionValue;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_directInputLastDirectionValue4Way;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_directInputUnknownJoystickHatCount;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_directInputUnknownJoystickHatButtonStartIndex;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_directInputJoystickStateByteSize;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_rawInputMaxButtons;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_rawInputMaxAxes;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_rawInputMaxHats;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_rawInputMaxSliders;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_rawInputMaxAxisValue;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_rawInputMinAxisValue;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_rawInputMaxHatValue;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_rawInputHatZeroValue;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_rawInputHatSpan;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_rawInputHatSpan4Way;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeFieldInfoPtr_rawInput_hatValue_up;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeFieldInfoPtr_rawInput_hatValue_right;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeFieldInfoPtr_rawInput_hatValue_down;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_rawInput_hatValue_left;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr_rawInputLastDirectionValue;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_rawInputLastDirectionValue4Way;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_rawInputUnknownJoystickHatCount;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_rawInputUnknownJoystickHatButtonStartIndex;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_rawInputUnifiedMouseButtonCount;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_rawInputUnifiedMouseAxisCount;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_rawInputUnifiedMouseAxisUnityEquivalencyMultiplier;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_rawInputUnifiedKeyboardButtonCount;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_osxMaxSticks;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_osxMaxButtons;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_osxMaxAxesPerStick;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_osxMaxHatsPerStick;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_osxMaxAxisValue;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_osxMinAxisValue;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_osxMaxPressureSensitiveButtonValue;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_osxMinPressureSensitiveButtonValue;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_osxMaxHatValue;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr_osxInputHatZeroValue;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr_osxHatSpan;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_osxHatSpan4Way;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_osx_hatValue_up;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_osx_hatValue_right;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_osx_hatValue_down;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_osx_hatValue_left;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_osxLastDirectionValue;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr_osxLastDirectionValue4Way;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_osxUnknownJoystickHatCount;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_osxUnknownJoystickHatButtonStartIndex;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_linuxMaxButtons;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_linuxMaxAxes;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr_linuxMaxHats;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr_linuxMaxSliders;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_linuxMaxAxisValue;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_linuxMinAxisValue;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_linuxMaxHatValue;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_linuxHatZeroValue;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_linuxHatSpan;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_linuxHatSpan4Way;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_linux_hatValue_up;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_linux_hatValue_right;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_linux_hatValue_down;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_linux_hatValue_left;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_linuxLastDirectionValue;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_linuxLastDirectionValue4Way;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_linuxUnknownJoystickHatCount;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_linuxUnknownJoystickHatButtonStartIndex;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_linuxUnifiedMouseButtonCount;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_linuxUnifiedMouseAxisCount;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_linuxUnifiedMouseAxisUnityEquivalencyMultiplier;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_sdl2MaxButtons;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_sdl2MaxAxes;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_sdl2MaxHats;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_sdl2MaxSliders;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_sdl2MaxAxisValue;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_sdl2MinAxisValue;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_sdl2AxisZeroValue;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_sdl2MaxHatValue;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_sdl2HatZeroValue;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_sdl2HatSpan;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_sdl2HatSpan4Way;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_sdl2_hatValue_up;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_sdl2_hatValue_right;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeFieldInfoPtr_sdl2_hatValue_down;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_sdl2_hatValue_left;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeFieldInfoPtr_sdl2LastDirectionValue;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeFieldInfoPtr_sdl2LastDirectionValue4Way;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_sdl2UnknownJoystickHatCount;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr_sdl2UnknownJoystickHatButtonStartIndex;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr_sdl2UnifiedMouseButtonCount;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_sdl2UnifiedMouseAxisCount;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr_sdl2UnifiedMouseAxisUnityEquivalencyMultiplier;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPMaxButtons;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPMaxAxes;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPMaxHats;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPMaxSliders;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPMaxAxisValue;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPMinAxisValue;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPMaxHatValue;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPHatZeroValue;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPDirectionsPerHat;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPHatSpan;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPHatSpan4Way;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPLastDirectionValue;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPLastDirectionValue4Way;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPUnknownJoystickHatCount;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPUnknownJoystickHatButtonStartIndex;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPUnifiedMouseButtonCount;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisCount;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_xInputMaxVibration;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_xInputMinVibration;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_xInputAllowedVibrationInterval;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_customPlatformMaxButtons;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_customPlatformMaxAxes;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverMaxButtons;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverMaxAxes;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverMaxHats;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverMaxSliders;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverMaxAxisValue;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverMinAxisValue;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverMaxHatValue;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverHatZeroValue;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverHatSpan;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverHatSpan4Way;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_internalDriver_hatValue_up;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_internalDriver_hatValue_right;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_internalDriver_hatValue_down;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_internalDriver_hatValue_left;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverLastDirectionValue;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverLastDirectionValue4Way;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverUnknownJoystickHatCount;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverUnknownJoystickHatButtonStartIndex;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverUnifiedMouseButtonCount;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverUnifiedMouseAxisCount;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeFieldInfoPtr_internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeFieldInfoPtr_webGLMaxButtons;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeFieldInfoPtr_webGLMaxAxes;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreMaxButtons;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreMaxAxes;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreMaxHats;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreUnknownJoystickButtonCount;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreUnknownJoystickAxisCount;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_gameCoreUnknownJoystickHatCount;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr_appleGCControllerMaxButtons;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr_appleGCControllerMaxAxes;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr_appleGCControllerUnknownJoystickButtonCount;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeFieldInfoPtr_appleGCControllerUnknownJoystickAxisCount;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickMaxButtons;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickMaxAxes;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickMaxHats;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickButtonsPerHat;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickAxisElementIdentifierStartIndex;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickButtonElementIdentifierStartIndex;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickHatElementIdentifierStartIndex;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickDefaultAxisDeadZone;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr_defaultAbsoluteAxisPollingDeadZone;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr_defaultRelativeAxisPollingDeadZone;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr_defaultMouseXYAxisPollingDeadzone;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_defaultMouseOtherAxisPollingDeadzone;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonDeadZone;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_hardwareButtonDeadZone;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_axisDefaultSensitivity;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_axisDefaultSensitivityType;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonDoublePressSpeed;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeFieldInfoPtr_minDoubleButtonPressSpeed;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeFieldInfoPtr_maxDoubleButtonPressSpeed;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonShortPressTime;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeFieldInfoPtr_minButtonShortPressTime;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeFieldInfoPtr_maxButtonShortPressTime;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonShortPressExpiresIn;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeFieldInfoPtr_minButtonShortPressExpiresIn;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr_maxButtonShortPressExpiresIn;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonLongPressTime;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_minButtonLongPressTime;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_maxButtonLongPressTime;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonLongPressExpiresIn;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeFieldInfoPtr_minButtonLongPressExpiresIn;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeFieldInfoPtr_maxButtonLongPressExpiresIn;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonRepeatDelay;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonRepeatRate;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_minButtonRepeatRate;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeFieldInfoPtr_mouseAxisPollingTimerLength;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeFieldInfoPtr_fallbackPollingTimeout;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeFieldInfoPtr_unknownJoystickName;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeFieldInfoPtr_xInputControllerVibrationRenewalInterval;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputThreadUpdateRateFPS;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_maxInputThreadUpdateRateFPS;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeFieldInfoPtr_osxXInputOutputReportRefreshRateFPS;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr_defaultOutputRefreshRateFPS;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr_hidOutputReportRefreshRateFPS;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr_hidOutputReportThreadKillTimeout;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeFieldInfoPtr_joystickInputReportRingBufferCapacity;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeFieldInfoPtr_joystickInputReportRingBufferCapacityDuration;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeFieldInfoPtr_resourecesDLLPath_windowsStandalone;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeFieldInfoPtr_resourecesDLLPath_osxStandalone;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeFieldInfoPtr_resourecesDLLPath_linux;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputBehaviorAxisSensitivity;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_gravity;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_sensitivity;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_snap;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputBehaviorAxisSmoothing_instantReverse;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_defaultInputBehaviorAxisSimulation_enabled;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_allFlagsIntEnum;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_osxPreventSystemSleepInterval;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeFieldInfoPtr_schemaNameSpace;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr_schemaBaseLocation;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr_schemaVersionControllerMap;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_schemaVersionCalibrationMap;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeFieldInfoPtr_schemaVersionInputBehavior;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeFieldInfoPtr_schemaVersionControllerTemplateMap;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr_schemaVersionPlayerEnabledMapsHelperData;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeFieldInfoPtr_schemaVersionPlayerControllerMapLayoutManagerData;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr_controllerMapDataVersion;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr_calibrationMapDataVersion;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_inputBehaviorDataVersion;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_controllerTemplateMapDataVersion;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr_playerMapEnablerDataVersion;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_playerControllerMapLayoutManagerDataVersion;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_controllerElementType_trueElements_minValue;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_controllerElementType_trueElements_maxValue;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_pressureSensitiveButtonDeadZone;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_rewiredEditorAssembly;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_rewiredEditorInputEditorClassFullName;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_nintendoSwitchPluginEditorRuntimeAssembly;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr_nintendoSwitchPluginInputManagerFullClassPath;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_JoyConDual;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr_nintendoSwitchPluginHWJoystickMapGuid_Handheld;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr_stadiaPluginEditorRuntimeAssembly;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeFieldInfoPtr_stadiaPluginInputManagerFullClassPath;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeFieldInfoPtr_gameCorePluginEditorRuntimeAssembly;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeFieldInfoPtr_gameCorePluginInputManagerFullClassPath;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr_ps5PluginEditorRuntimeAssembly;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_ps5PluginInputManagerFullClassPath;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_vendorId_sony;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_updateLoopTypeCount;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_questionablePidVids;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_questionableVIDs;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_joystickGuid_unknownController;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_joystickGuid_appleMFiController;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeFieldInfoPtr_joystickGuid_standardizedGamepad;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_joystickGuid_SonyDualShock4;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_joystickGuid_SonyPS4AimController;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_hardwareTypeGuid_universalKeyboard;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_hardwareTypeGuid_universalMouse;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_ROlfSOGtabStODOfZKBbnjVoDls;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_WjkorWscNtnASKNQIpakJrLeBJn;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeFieldInfoPtr_mouseAxisUnityNames;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_KCpQCyoHQPesEQLJJciQPRkSnOc;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_mouseButtonUnityNames;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_bfEDhQnQUuAVncifZOvIfOIkLuJ;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_keyboardKeyNames;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_ubecLkaCHeWXfcESHEAkRDDRqdFi;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_keyboardKeyValues;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr__keyboardKeyValues;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr_modifierKeyShortNames;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr_JpAomxCzfsPGoOJSCggFhDcpfPcT;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr_pidVids_sony_dualShock4;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr_DRKFsvtDZLqnQbwbIbyzPOAQwTA;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr_productNames_sony_dualShock4;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_AHQWiENFqxAQeDTBiNeOBdxttDx;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeFieldInfoPtr_tHPJnmSqpQxTYmFcRsjOGXuEFij;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_get_nintendoSwitchPlugin_minPluginVersion_Internal_Static_get_Int32_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_get_stadiaPlugin_minPluginVersion_Internal_Static_get_Int32_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_get_gameCorePlugin_minPluginVersion_Internal_Static_get_Int32_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_get_unityUnifiedMouseElementIdentifiers_Internal_Static_get_IList_1_ControllerElementIdentifier_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_get_rawInputUnifiedMouseElementIdentifiers_Internal_Static_get_IList_1_ControllerElementIdentifier_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_get_unknownJoystickElementIdentifiers_orig_Internal_Static_get_Il2CppReferenceArray_1_ControllerElementIdentifier_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_ulNiepuYVanmiyZmfhhBMOdmdAK_Private_Static_Il2CppReferenceArray_1_ControllerElementIdentifier_0;
	}
}
