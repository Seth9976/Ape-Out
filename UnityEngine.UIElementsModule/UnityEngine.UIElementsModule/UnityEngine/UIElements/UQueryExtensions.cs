using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000057 RID: 87
	public static class UQueryExtensions
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00003235 File Offset: 0x00001435
		public static T Q<T>(VisualElement e, [Optional] string name, Il2CppStringArray classes) where T : VisualElement
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00003242 File Offset: 0x00001442
		public static T Q<T>(VisualElement e, [Optional] string name, params string[] classes) where T : VisualElement
		{
			return UQueryExtensions.Q(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00003251 File Offset: 0x00001451
		public static VisualElement Q(VisualElement e, [Optional] string name, Il2CppStringArray classes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000325E File Offset: 0x0000145E
		public static VisualElement Q(VisualElement e, [Optional] string name, params string[] classes)
		{
			return UQueryExtensions.Q(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000326D File Offset: 0x0000146D
		public static T Q<T>(VisualElement e, [Optional] string name, [Optional] string className) where T : VisualElement
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000959C File Offset: 0x0000779C
		public static T MandatoryQ<T>(VisualElement e, string name, [Optional] string className) where T : VisualElement
		{
			T t = UQueryExtensions.Q<T>(e, name, className);
			bool flag = t == null;
			if (flag)
			{
				throw new UQueryExtensions.MissingVisualElementException(String.Concat("Element not found: ", name));
			}
			return t;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000327A File Offset: 0x0000147A
		public static VisualElement Q(VisualElement e, [Optional] string name, [Optional] string className)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000095D8 File Offset: 0x000077D8
		public static VisualElement MandatoryQ(VisualElement e, string name, [Optional] string className)
		{
			VisualElement visualElement = UQueryExtensions.Q<VisualElement>(e, name, className);
			bool flag = visualElement == null;
			if (flag)
			{
				throw new UQueryExtensions.MissingVisualElementException(String.Concat("Element not found: ", name));
			}
			return visualElement;
		}

		// Token: 0x020001B2 RID: 434
		public class MissingVisualElementException : Exception
		{
		}
	}
}
