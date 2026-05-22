using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000211 RID: 529
	public class FallbackJoystickIdentificationDemo : MonoBehaviour
	{
		// Token: 0x060040A8 RID: 16552 RVA: 0x000F1800 File Offset: 0x000EFA00
		// Note: this type is marked as 'beforefieldinit'.
		static FallbackJoystickIdentificationDemo()
		{
			Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "FallbackJoystickIdentificationDemo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr);
			FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "windowWidth");
			FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "windowHeight");
			FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_inputDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "inputDelay");
			FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_identifyRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "identifyRequired");
			FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_joysticksToIdentify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "joysticksToIdentify");
			FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_nextInputAllowedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "nextInputAllowedTime");
			FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "style");
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669606);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669607);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669608);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669609);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_SetInputDelay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669610);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669611);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669612);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669613);
			FallbackJoystickIdentificationDemo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100669614);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x000F1970 File Offset: 0x000EFB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103835, XrefRangeEnd = 103854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x000F19A4 File Offset: 0x000EFBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103854, XrefRangeEnd = 103855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoystickConnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x000F19E8 File Offset: 0x000EFBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x000F1A2C File Offset: 0x000EFC2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103875, RefRangeEnd = 103878, XrefRangeStart = 103855, XrefRangeEnd = 103875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IdentifyAllJoysticks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x000F1A60 File Offset: 0x000EFC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103880, RefRangeEnd = 103882, XrefRangeStart = 103878, XrefRangeEnd = 103880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputDelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_SetInputDelay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x000F1A94 File Offset: 0x000EFC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103882, XrefRangeEnd = 103913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x000F1AC8 File Offset: 0x000EFCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103913, XrefRangeEnd = 103949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawDialogWindow(int windowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x000F1B08 File Offset: 0x000EFD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103949, RefRangeEnd = 103950, XrefRangeStart = 103949, XrefRangeEnd = 103949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x000F1B3C File Offset: 0x000EFD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallbackJoystickIdentificationDemo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackJoystickIdentificationDemo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x0002788E File Offset: 0x00025A8E
		public FallbackJoystickIdentificationDemo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x060040B3 RID: 16563 RVA: 0x000F1B78 File Offset: 0x000EFD78
		// (set) Token: 0x060040B4 RID: 16564 RVA: 0x00027897 File Offset: 0x00025A97
		public unsafe static float windowWidth
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowWidth, (void*)(&value));
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x000F1B94 File Offset: 0x000EFD94
		// (set) Token: 0x060040B6 RID: 16566 RVA: 0x000278A5 File Offset: 0x00025AA5
		public unsafe static float windowHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_windowHeight, (void*)(&value));
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x000F1BB0 File Offset: 0x000EFDB0
		// (set) Token: 0x060040B8 RID: 16568 RVA: 0x000278B3 File Offset: 0x00025AB3
		public unsafe static float inputDelay
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_inputDelay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_inputDelay, (void*)(&value));
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x000F1BCC File Offset: 0x000EFDCC
		// (set) Token: 0x060040BA RID: 16570 RVA: 0x000278C1 File Offset: 0x00025AC1
		public unsafe bool identifyRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_identifyRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_identifyRequired)) = value;
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x060040BB RID: 16571 RVA: 0x000F1BF4 File Offset: 0x000EFDF4
		// (set) Token: 0x060040BC RID: 16572 RVA: 0x000278DC File Offset: 0x00025ADC
		public unsafe Queue<Joystick> joysticksToIdentify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_joysticksToIdentify);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Joystick>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_joysticksToIdentify), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x060040BD RID: 16573 RVA: 0x000F1C24 File Offset: 0x000EFE24
		// (set) Token: 0x060040BE RID: 16574 RVA: 0x000278FB File Offset: 0x00025AFB
		public unsafe float nextInputAllowedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_nextInputAllowedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_nextInputAllowedTime)) = value;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x000F1C4C File Offset: 0x000EFE4C
		// (set) Token: 0x060040C0 RID: 16576 RVA: 0x00027916 File Offset: 0x00025B16
		public unsafe GUIStyle style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackJoystickIdentificationDemo.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027B6 RID: 10166
		private static readonly IntPtr NativeFieldInfoPtr_windowWidth;

		// Token: 0x040027B7 RID: 10167
		private static readonly IntPtr NativeFieldInfoPtr_windowHeight;

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeFieldInfoPtr_inputDelay;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeFieldInfoPtr_identifyRequired;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeFieldInfoPtr_joysticksToIdentify;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeFieldInfoPtr_nextInputAllowedTime;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeMethodInfoPtr_SetInputDelay_Private_Void_0;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0;

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
