using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	public sealed class GUIGridSizer : GUILayoutEntry
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00017F74 File Offset: 0x00016174
		public static Rect GetRect(Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			Rect rect = new Rect(0f, 0f, 0f, 0f);
			EventType type = Event.current.type;
			EventType eventType = type;
			if (eventType != EventType.Layout)
			{
				if (eventType == EventType.Used)
				{
					return GUILayoutEntry.kDummyRect;
				}
				rect = GUILayoutUtility.current.topLevel.GetNext().rect;
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUIGridSizer(contents, xCount, style, options));
			}
			return rect;
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000047B2 File Offset: 0x000029B2
		public int rows
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
