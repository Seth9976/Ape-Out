using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class AndroidInput
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00003B38 File Offset: 0x00001D38
		public static Touch GetSecondaryTouch(int index)
		{
			return AndroidInput.GetTouch_Bindings(index);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003B50 File Offset: 0x00001D50
		public static Touch GetTouch_Bindings(int index)
		{
			Touch touch;
			AndroidInput.GetTouch_Bindings_Injected(index, out touch);
			return touch;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003B68 File Offset: 0x00001D68
		public static int touchCountSecondary
		{
			get
			{
				return AndroidInput.GetTouchCount_Bindings();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000227A File Offset: 0x0000047A
		public static int GetTouchCount_Bindings()
		{
			return AndroidInput.GetTouchCount_BindingsDelegateField();
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003B80 File Offset: 0x00001D80
		public static bool secondaryTouchEnabled
		{
			get
			{
				return AndroidInput.IsInputDeviceEnabled_Bindings();
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002286 File Offset: 0x00000486
		public static bool IsInputDeviceEnabled_Bindings()
		{
			return AndroidInput.IsInputDeviceEnabled_BindingsDelegateField();
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003B98 File Offset: 0x00001D98
		public static int secondaryTouchWidth
		{
			get
			{
				return AndroidInput.GetTouchpadWidth();
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002292 File Offset: 0x00000492
		public static int GetTouchpadWidth()
		{
			return AndroidInput.GetTouchpadWidthDelegateField();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public static int secondaryTouchHeight
		{
			get
			{
				return AndroidInput.GetTouchpadHeight();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000229E File Offset: 0x0000049E
		public static int GetTouchpadHeight()
		{
			return AndroidInput.GetTouchpadHeightDelegateField();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000022AA File Offset: 0x000004AA
		public static void GetTouch_Bindings_Injected(int index, out Touch ret)
		{
			AndroidInput.GetTouch_Bindings_InjectedDelegateField(index, out ret);
		}

		// Token: 0x0400007B RID: 123
		private static readonly AndroidInput.GetTouchCount_BindingsDelegate GetTouchCount_BindingsDelegateField = IL2CPP.ResolveICall<AndroidInput.GetTouchCount_BindingsDelegate>("UnityEngine.AndroidInput::GetTouchCount_Bindings");

		// Token: 0x0400007C RID: 124
		private static readonly AndroidInput.IsInputDeviceEnabled_BindingsDelegate IsInputDeviceEnabled_BindingsDelegateField = IL2CPP.ResolveICall<AndroidInput.IsInputDeviceEnabled_BindingsDelegate>("UnityEngine.AndroidInput::IsInputDeviceEnabled_Bindings");

		// Token: 0x0400007D RID: 125
		private static readonly AndroidInput.GetTouchpadWidthDelegate GetTouchpadWidthDelegateField = IL2CPP.ResolveICall<AndroidInput.GetTouchpadWidthDelegate>("UnityEngine.AndroidInput::GetTouchpadWidth");

		// Token: 0x0400007E RID: 126
		private static readonly AndroidInput.GetTouchpadHeightDelegate GetTouchpadHeightDelegateField = IL2CPP.ResolveICall<AndroidInput.GetTouchpadHeightDelegate>("UnityEngine.AndroidInput::GetTouchpadHeight");

		// Token: 0x0400007F RID: 127
		private static readonly AndroidInput.GetTouch_Bindings_InjectedDelegate GetTouch_Bindings_InjectedDelegateField = IL2CPP.ResolveICall<AndroidInput.GetTouch_Bindings_InjectedDelegate>("UnityEngine.AndroidInput::GetTouch_Bindings_Injected");

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000E0 RID: 224
		private delegate int GetTouchCount_BindingsDelegate();

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000E2 RID: 226
		private delegate bool IsInputDeviceEnabled_BindingsDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000E4 RID: 228
		private delegate int GetTouchpadWidthDelegate();

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060000E6 RID: 230
		private delegate int GetTouchpadHeightDelegate();

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000E8 RID: 232
		private delegate void GetTouch_Bindings_InjectedDelegate(int index, [Out] IntPtr ret);
	}
}
