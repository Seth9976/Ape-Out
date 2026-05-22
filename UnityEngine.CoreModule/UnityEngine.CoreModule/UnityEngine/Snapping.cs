using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	// Token: 0x02000260 RID: 608
	public static class Snapping
	{
		// Token: 0x060021EE RID: 8686 RVA: 0x00077454 File Offset: 0x00075654
		public static bool IsCardinalDirection(Vector3 direction)
		{
			return (Mathf.Abs(direction.x) > 0f && Mathf.Approximately(direction.y, 0f) && Mathf.Approximately(direction.z, 0f)) || (Mathf.Abs(direction.y) > 0f && Mathf.Approximately(direction.x, 0f) && Mathf.Approximately(direction.z, 0f)) || (Mathf.Abs(direction.z) > 0f && Mathf.Approximately(direction.x, 0f) && Mathf.Approximately(direction.y, 0f));
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0007750C File Offset: 0x0007570C
		public static float Snap(float val, float snap)
		{
			bool flag = snap == 0f;
			float num;
			if (flag)
			{
				num = val;
			}
			else
			{
				num = snap * Mathf.Round(val / snap);
			}
			return num;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00077538 File Offset: 0x00075738
		public static Vector2 Snap(Vector2 val, Vector2 snap)
		{
			return new Vector3((Mathf.Abs(snap.x) < Mathf.Epsilon) ? val.x : (snap.x * Mathf.Round(val.x / snap.x)), (Mathf.Abs(snap.y) < Mathf.Epsilon) ? val.y : (snap.y * Mathf.Round(val.y / snap.y)));
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000775BC File Offset: 0x000757BC
		public static Vector3 Snap(Vector3 val, Vector3 snap, [Optional] SnapAxis axis)
		{
			return new Vector3(((axis & SnapAxis.X) == SnapAxis.X) ? Snapping.Snap(val.x, snap.x) : val.x, ((axis & SnapAxis.Y) == SnapAxis.Y) ? Snapping.Snap(val.y, snap.y) : val.y, ((axis & SnapAxis.Z) == SnapAxis.Z) ? Snapping.Snap(val.z, snap.z) : val.z);
		}
	}
}
