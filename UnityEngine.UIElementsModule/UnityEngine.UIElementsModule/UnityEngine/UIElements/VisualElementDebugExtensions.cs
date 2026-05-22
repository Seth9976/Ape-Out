using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005F RID: 95
	public static class VisualElementDebugExtensions
	{
		// Token: 0x0600028F RID: 655 RVA: 0x0000A0E0 File Offset: 0x000082E0
		public static string GetDisplayName(VisualElement ve, [Optional] bool withHashCode)
		{
			bool flag = ve == null;
			string text;
			if (flag)
			{
				text = String.Empty;
			}
			else
			{
				string text2 = ve.GetType().Name;
				bool flag2 = !String.IsNullOrEmpty(ve.name);
				if (flag2)
				{
					text2 = String.Concat(text2, "#", ve.name);
				}
				if (withHashCode)
				{
					text2 = String.Concat(text2, " (", ve.GetHashCode().ToString("x8"), ")");
				}
				text = text2;
			}
			return text;
		}
	}
}
