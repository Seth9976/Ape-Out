using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public class GUIDebugger
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x000046BC File Offset: 0x000028BC
		public static void LogLayoutEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style)
		{
			GUIDebugger.LogLayoutEntry_Injected(ref rect, left, right, top, bottom, style);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000046CC File Offset: 0x000028CC
		public static void LogLayoutGroupEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style, bool isVertical)
		{
			GUIDebugger.LogLayoutGroupEntry_Injected(ref rect, left, right, top, bottom, style, isVertical);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000046DE File Offset: 0x000028DE
		public static void LogLayoutEndGroup()
		{
			GUIDebugger.LogLayoutEndGroupDelegateField();
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000046EA File Offset: 0x000028EA
		public static void LogBeginProperty(string targetTypeAssemblyQualifiedName, string path, Rect position)
		{
			GUIDebugger.LogBeginProperty_Injected(targetTypeAssemblyQualifiedName, path, ref position);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000046F5 File Offset: 0x000028F5
		public static void LogEndProperty()
		{
			GUIDebugger.LogEndPropertyDelegateField();
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00004701 File Offset: 0x00002901
		public static bool active
		{
			get
			{
				return GUIDebugger.get_activeDelegateField();
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000470D File Offset: 0x0000290D
		public static void LogLayoutEntry_Injected(ref Rect rect, int left, int right, int top, int bottom, GUIStyle style)
		{
			GUIDebugger.LogLayoutEntry_InjectedDelegateField(ref rect, left, right, top, bottom, IL2CPP.Il2CppObjectBaseToPtr(style));
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00004726 File Offset: 0x00002926
		public static void LogLayoutGroupEntry_Injected(ref Rect rect, int left, int right, int top, int bottom, GUIStyle style, bool isVertical)
		{
			GUIDebugger.LogLayoutGroupEntry_InjectedDelegateField(ref rect, left, right, top, bottom, IL2CPP.Il2CppObjectBaseToPtr(style), isVertical);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00004741 File Offset: 0x00002941
		public static void LogBeginProperty_Injected(string targetTypeAssemblyQualifiedName, string path, ref Rect position)
		{
			GUIDebugger.LogBeginProperty_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(targetTypeAssemblyQualifiedName), IL2CPP.ManagedStringToIl2Cpp(path), ref position);
		}

		// Token: 0x040003B0 RID: 944
		private static readonly GUIDebugger.LogLayoutEndGroupDelegate LogLayoutEndGroupDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutEndGroupDelegate>("UnityEngine.GUIDebugger::LogLayoutEndGroup");

		// Token: 0x040003B1 RID: 945
		private static readonly GUIDebugger.LogEndPropertyDelegate LogEndPropertyDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogEndPropertyDelegate>("UnityEngine.GUIDebugger::LogEndProperty");

		// Token: 0x040003B2 RID: 946
		private static readonly GUIDebugger.get_activeDelegate get_activeDelegateField = IL2CPP.ResolveICall<GUIDebugger.get_activeDelegate>("UnityEngine.GUIDebugger::get_active");

		// Token: 0x040003B3 RID: 947
		private static readonly GUIDebugger.LogLayoutEntry_InjectedDelegate LogLayoutEntry_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutEntry_Injected");

		// Token: 0x040003B4 RID: 948
		private static readonly GUIDebugger.LogLayoutGroupEntry_InjectedDelegate LogLayoutGroupEntry_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutGroupEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutGroupEntry_Injected");

		// Token: 0x040003B5 RID: 949
		private static readonly GUIDebugger.LogBeginProperty_InjectedDelegate LogBeginProperty_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogBeginProperty_InjectedDelegate>("UnityEngine.GUIDebugger::LogBeginProperty_Injected");

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600071C RID: 1820
		private delegate void LogLayoutEndGroupDelegate();

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x0600071E RID: 1822
		private delegate void LogEndPropertyDelegate();

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000720 RID: 1824
		private delegate bool get_activeDelegate();

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000722 RID: 1826
		private delegate void LogLayoutEntry_InjectedDelegate(IntPtr rect, int left, int right, int top, int bottom, IntPtr style);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000724 RID: 1828
		private delegate void LogLayoutGroupEntry_InjectedDelegate(IntPtr rect, int left, int right, int top, int bottom, IntPtr style, bool isVertical);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x06000726 RID: 1830
		private delegate void LogBeginProperty_InjectedDelegate(IntPtr targetTypeAssemblyQualifiedName, IntPtr path, IntPtr position);
	}
}
