using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000008 RID: 8
	public static class UIElementsRuntimeUtilityNative : Object
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00004100 File Offset: 0x00002300
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsRuntimeUtilityNative()
		{
			Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.UIElements", "UIElementsRuntimeUtilityNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr);
			UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, "RepaintOverlayPanelsCallback");
			UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, "UpdateRuntimePanelsCallback");
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100663309);
			UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtilityNative>.NativeClassPtr, 100663310);
			UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegateField = IL2CPP.ResolveICall<UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegate>("UnityEngine.UIElements.UIElementsRuntimeUtilityNative::RegisterPlayerloopCallback");
			UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegateField = IL2CPP.ResolveICall<UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegate>("UnityEngine.UIElements.UIElementsRuntimeUtilityNative::UnregisterPlayerloopCallback");
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000041A0 File Offset: 0x000023A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533445, XrefRangeEnd = 533448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOverlayPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000041C8 File Offset: 0x000023C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533448, XrefRangeEnd = 533451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRuntimePanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtilityNative.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000028AF File Offset: 0x00000AAF
		public UIElementsRuntimeUtilityNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000041F0 File Offset: 0x000023F0
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000028B8 File Offset: 0x00000AB8
		public unsafe static Action RepaintOverlayPanelsCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_RepaintOverlayPanelsCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004218 File Offset: 0x00002418
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000028CA File Offset: 0x00000ACA
		public unsafe static Action UpdateRuntimePanelsCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtilityNative.NativeFieldInfoPtr_UpdateRuntimePanelsCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000028DC File Offset: 0x00000ADC
		public static void RegisterPlayerloopCallback()
		{
			UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegateField();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000028E8 File Offset: 0x00000AE8
		public static void UnregisterPlayerloopCallback()
		{
			UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegateField();
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_RepaintOverlayPanelsCallback;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_UpdateRuntimePanelsCallback;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOverlayPanels_Public_Static_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly UIElementsRuntimeUtilityNative.RegisterPlayerloopCallbackDelegate RegisterPlayerloopCallbackDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly UIElementsRuntimeUtilityNative.UnregisterPlayerloopCallbackDelegate UnregisterPlayerloopCallbackDelegateField;

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060001F7 RID: 503
		private delegate void RegisterPlayerloopCallbackDelegate();

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060001F9 RID: 505
		private delegate void UnregisterPlayerloopCallbackDelegate();
	}
}
