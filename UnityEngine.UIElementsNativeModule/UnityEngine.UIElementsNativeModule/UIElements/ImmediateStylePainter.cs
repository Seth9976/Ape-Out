using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001D RID: 29
	public class ImmediateStylePainter
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00002BED File Offset: 0x00000DED
		public static void DrawRect(Rect screenRect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
		{
			ImmediateStylePainter.DrawRect_Injected(ref screenRect, ref color, ref borderWidths, ref borderRadiuses);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000048CC File Offset: 0x00002ACC
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha)
		{
			ImmediateStylePainter.DrawTexture_Injected(ref screenRect, texture, ref sourceRect, ref color, ref borderWidths, ref borderRadiuses, leftBorder, topBorder, rightBorder, bottomBorder, usePremultiplyAlpha);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000048F4 File Offset: 0x00002AF4
		public static void DrawText(Rect screenRect, string text, Font font, int fontSize, FontStyle fontStyle, Color fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping)
		{
			ImmediateStylePainter.DrawText_Injected(ref screenRect, text, font, fontSize, fontStyle, ref fontColor, anchor, wordWrap, wordWrapWidth, richText, textClipping);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002BFC File Offset: 0x00000DFC
		public static void DrawRect_Injected(ref Rect screenRect, ref Color color, ref Vector4 borderWidths, ref Vector4 borderRadiuses)
		{
			ImmediateStylePainter.DrawRect_InjectedDelegateField(ref screenRect, ref color, ref borderWidths, ref borderRadiuses);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000491C File Offset: 0x00002B1C
		public static void DrawTexture_Injected(ref Rect screenRect, Texture texture, ref Rect sourceRect, ref Color color, ref Vector4 borderWidths, ref Vector4 borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha)
		{
			ImmediateStylePainter.DrawTexture_InjectedDelegateField(ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(texture), ref sourceRect, ref color, ref borderWidths, ref borderRadiuses, leftBorder, topBorder, rightBorder, bottomBorder, usePremultiplyAlpha);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000494C File Offset: 0x00002B4C
		public static void DrawText_Injected(ref Rect screenRect, string text, Font font, int fontSize, FontStyle fontStyle, ref Color fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping)
		{
			ImmediateStylePainter.DrawText_InjectedDelegateField(ref screenRect, IL2CPP.ManagedStringToIl2Cpp(text), IL2CPP.Il2CppObjectBaseToPtr(font), fontSize, fontStyle, ref fontColor, anchor, wordWrap, wordWrapWidth, richText, textClipping);
		}

		// Token: 0x040000EB RID: 235
		private static readonly ImmediateStylePainter.DrawRect_InjectedDelegate DrawRect_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawRect_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawRect_Injected");

		// Token: 0x040000EC RID: 236
		private static readonly ImmediateStylePainter.DrawTexture_InjectedDelegate DrawTexture_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawTexture_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawTexture_Injected");

		// Token: 0x040000ED RID: 237
		private static readonly ImmediateStylePainter.DrawText_InjectedDelegate DrawText_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawText_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawText_Injected");

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x0600022F RID: 559
		private delegate void DrawRect_InjectedDelegate(IntPtr screenRect, IntPtr color, IntPtr borderWidths, IntPtr borderRadiuses);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000231 RID: 561
		private delegate void DrawTexture_InjectedDelegate(IntPtr screenRect, IntPtr texture, IntPtr sourceRect, IntPtr color, IntPtr borderWidths, IntPtr borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000233 RID: 563
		private delegate void DrawText_InjectedDelegate(IntPtr screenRect, IntPtr text, IntPtr font, int fontSize, FontStyle fontStyle, IntPtr fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping);
	}
}
