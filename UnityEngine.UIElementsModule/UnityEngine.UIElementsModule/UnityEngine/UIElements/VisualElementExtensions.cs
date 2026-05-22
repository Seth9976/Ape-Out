using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005E RID: 94
	public static class VisualElementExtensions
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00009F28 File Offset: 0x00008128
		public static Vector2 WorldToLocal(VisualElement ele, Vector2 p)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			return VisualElement.MultiplyMatrix44Point2(ele.worldTransformInverse, p);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00009F5C File Offset: 0x0000815C
		public static Vector2 LocalToWorld(VisualElement ele, Vector2 p)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			return VisualElement.MultiplyMatrix44Point2(ele.worldTransform, p);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00009F90 File Offset: 0x00008190
		public static Rect WorldToLocal(VisualElement ele, Rect r)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			Vector2 vector = VisualElement.MultiplyMatrix44Point2(ele.worldTransformInverse, r.position);
			r.position = vector;
			r.size = ele.worldTransformInverse.MultiplyVector(r.size);
			return r;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00009FFC File Offset: 0x000081FC
		public static Rect LocalToWorld(VisualElement ele, Rect r)
		{
			bool flag = ele == null;
			if (flag)
			{
				throw new ArgumentNullException("ele");
			}
			Matrix4x4 worldTransform = ele.worldTransform;
			r.position = VisualElement.MultiplyMatrix44Point2(worldTransform, r.position);
			r.size = worldTransform.MultiplyVector(r.size);
			return r;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A060 File Offset: 0x00008260
		public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point)
		{
			return VisualElementExtensions.WorldToLocal(dest, VisualElementExtensions.LocalToWorld(src, point));
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A080 File Offset: 0x00008280
		public static Rect ChangeCoordinatesTo(VisualElement src, VisualElement dest, Rect rect)
		{
			return VisualElementExtensions.WorldToLocal(dest, VisualElementExtensions.LocalToWorld(src, rect));
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003CFB File Offset: 0x00001EFB
		public static void StretchToParentSize(VisualElement elem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003D08 File Offset: 0x00001F08
		public static void StretchToParentWidth(VisualElement elem)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A0A0 File Offset: 0x000082A0
		public static void AddManipulator(VisualElement ele, IManipulator manipulator)
		{
			bool flag = manipulator != null;
			if (flag)
			{
				manipulator.target = ele;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000A0C0 File Offset: 0x000082C0
		public static void RemoveManipulator(VisualElement ele, IManipulator manipulator)
		{
			bool flag = manipulator != null;
			if (flag)
			{
				manipulator.target = null;
			}
		}
	}
}
