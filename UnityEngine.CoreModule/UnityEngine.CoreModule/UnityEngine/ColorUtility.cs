using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000245 RID: 581
	public class ColorUtility
	{
		// Token: 0x060021AD RID: 8621 RVA: 0x00011DDD File Offset: 0x0000FFDD
		public static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
		{
			return ColorUtility.DoTryParseHtmlColorDelegateField(IL2CPP.ManagedStringToIl2Cpp(htmlString), out color);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00076D50 File Offset: 0x00074F50
		public static bool TryParseHtmlString(string htmlString, out Color color)
		{
			Color32 color2;
			bool flag = ColorUtility.DoTryParseHtmlColor(htmlString, out color2);
			color = color2;
			return flag;
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		public static string ToHtmlStringRGB(Color color)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00011DFD File Offset: 0x0000FFFD
		public static string ToHtmlStringRGBA(Color color)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001BC8 RID: 7112
		private static readonly ColorUtility.DoTryParseHtmlColorDelegate DoTryParseHtmlColorDelegateField = IL2CPP.ResolveICall<ColorUtility.DoTryParseHtmlColorDelegate>("UnityEngine.ColorUtility::DoTryParseHtmlColor");

		// Token: 0x02000B87 RID: 2951
		// (Invoke) Token: 0x0600356E RID: 13678
		private delegate bool DoTryParseHtmlColorDelegate(IntPtr htmlString, [Out] IntPtr color);
	}
}
