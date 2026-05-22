using System;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public abstract class GridBrushBase : ScriptableObject
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000290E File Offset: 0x00000B0E
		public virtual void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002911 File Offset: 0x00000B11
		public virtual void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000452C File Offset: 0x0000272C
		public virtual void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
			for (int i = position.zMin; i < position.zMax; i++)
			{
				for (int j = position.yMin; j < position.yMax; j++)
				{
					for (int k = position.xMin; k < position.xMax; k++)
					{
						this.Paint(gridLayout, brushTarget, new Vector3Int(k, j, i));
					}
				}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000045AC File Offset: 0x000027AC
		public virtual void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
			for (int i = position.zMin; i < position.zMax; i++)
			{
				for (int j = position.yMin; j < position.yMax; j++)
				{
					for (int k = position.xMin; k < position.xMax; k++)
					{
						this.Erase(gridLayout, brushTarget, new Vector3Int(k, j, i));
					}
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002914 File Offset: 0x00000B14
		public virtual void Select(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002917 File Offset: 0x00000B17
		public virtual void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000291A File Offset: 0x00000B1A
		public virtual void Rotate(GridBrushBase.RotationDirection direction, GridLayout.CellLayout layout)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000291D File Offset: 0x00000B1D
		public virtual void Flip(GridBrushBase.FlipAxis flip, GridLayout.CellLayout layout)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002920 File Offset: 0x00000B20
		public virtual void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pivot)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002923 File Offset: 0x00000B23
		public virtual void Move(GridLayout gridLayout, GameObject brushTarget, BoundsInt from, BoundsInt to)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002926 File Offset: 0x00000B26
		public virtual void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002929 File Offset: 0x00000B29
		public virtual void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000292C File Offset: 0x00000B2C
		public virtual void ChangeZPosition(int change)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000292F File Offset: 0x00000B2F
		public virtual void ResetZPosition()
		{
		}

		// Token: 0x02000051 RID: 81
		public enum Tool
		{
			// Token: 0x04000098 RID: 152
			Select,
			// Token: 0x04000099 RID: 153
			Move,
			// Token: 0x0400009A RID: 154
			Paint,
			// Token: 0x0400009B RID: 155
			Box,
			// Token: 0x0400009C RID: 156
			Pick,
			// Token: 0x0400009D RID: 157
			Erase,
			// Token: 0x0400009E RID: 158
			FloodFill
		}

		// Token: 0x02000052 RID: 82
		public enum RotationDirection
		{
			// Token: 0x040000A0 RID: 160
			Clockwise,
			// Token: 0x040000A1 RID: 161
			CounterClockwise
		}

		// Token: 0x02000053 RID: 83
		public enum FlipAxis
		{
			// Token: 0x040000A3 RID: 163
			X,
			// Token: 0x040000A4 RID: 164
			Y
		}
	}
}
