using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public sealed class GUIElement
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x0000475A File Offset: 0x0000295A
		public static void FeatureRemoved()
		{
			throw new Exception("GUIElement has been removed from Unity.");
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00017E4C File Offset: 0x0001604C
		public bool HitTest(Vector3 screenPosition)
		{
			GUIElement.FeatureRemoved();
			return false;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00017E68 File Offset: 0x00016068
		public bool HitTest(Vector3 screenPosition, Camera camera)
		{
			GUIElement.FeatureRemoved();
			return false;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00017E84 File Offset: 0x00016084
		public Rect GetScreenRect(Camera camera)
		{
			GUIElement.FeatureRemoved();
			return new Rect(0f, 0f, 0f, 0f);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00017EB8 File Offset: 0x000160B8
		public Rect GetScreenRect()
		{
			GUIElement.FeatureRemoved();
			return new Rect(0f, 0f, 0f, 0f);
		}
	}
}
