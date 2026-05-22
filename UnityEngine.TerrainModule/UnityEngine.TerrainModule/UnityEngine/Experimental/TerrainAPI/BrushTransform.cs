using System;

namespace UnityEngine.Experimental.TerrainAPI
{
	// Token: 0x02000013 RID: 19
	public struct BrushTransform
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00003048 File Offset: 0x00001248
		public Vector2 brushOrigin
		{
			get
			{
				return this.<brushOrigin>k__BackingField;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00003050 File Offset: 0x00001250
		public Vector2 brushU
		{
			get
			{
				return this.<brushU>k__BackingField;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00003058 File Offset: 0x00001258
		public Vector2 brushV
		{
			get
			{
				return this.<brushV>k__BackingField;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00003060 File Offset: 0x00001260
		public Vector2 targetOrigin
		{
			get
			{
				return this.<targetOrigin>k__BackingField;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003068 File Offset: 0x00001268
		public Vector2 targetX
		{
			get
			{
				return this.<targetX>k__BackingField;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00003070 File Offset: 0x00001270
		public Vector2 targetY
		{
			get
			{
				return this.<targetY>k__BackingField;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005BF0 File Offset: 0x00003DF0
		public Rect GetBrushXYBounds()
		{
			Vector2 vector = this.brushOrigin + this.brushU;
			Vector2 vector2 = this.brushOrigin + this.brushV;
			Vector2 vector3 = this.brushOrigin + this.brushU + this.brushV;
			float num = Mathf.Min(Mathf.Min(this.brushOrigin.x, vector.x), Mathf.Min(vector2.x, vector3.x));
			float num2 = Mathf.Max(Mathf.Max(this.brushOrigin.x, vector.x), Mathf.Max(vector2.x, vector3.x));
			float num3 = Mathf.Min(Mathf.Min(this.brushOrigin.y, vector.y), Mathf.Min(vector2.y, vector3.y));
			float num4 = Mathf.Max(Mathf.Max(this.brushOrigin.y, vector.y), Mathf.Max(vector2.y, vector3.y));
			return Rect.MinMaxRect(num, num3, num2, num4);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005D08 File Offset: 0x00003F08
		public static BrushTransform FromRect(Rect brushRect)
		{
			Vector2 min = brushRect.min;
			Vector2 vector = new Vector2(brushRect.width, 0f);
			Vector2 vector2 = new Vector2(0f, brushRect.height);
			return new BrushTransform(min, vector, vector2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005D50 File Offset: 0x00003F50
		public Vector2 ToBrushUV(Vector2 targetXY)
		{
			return targetXY.x * this.targetX + targetXY.y * this.targetY + this.targetOrigin;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005D94 File Offset: 0x00003F94
		public Vector2 FromBrushUV(Vector2 brushUV)
		{
			return brushUV.x * this.brushU + brushUV.y * this.brushV + this.brushOrigin;
		}

		// Token: 0x040000F0 RID: 240
		public readonly Vector2 <brushOrigin>k__BackingField;

		// Token: 0x040000F1 RID: 241
		public readonly Vector2 <brushU>k__BackingField;

		// Token: 0x040000F2 RID: 242
		public readonly Vector2 <brushV>k__BackingField;

		// Token: 0x040000F3 RID: 243
		public readonly Vector2 <targetOrigin>k__BackingField;

		// Token: 0x040000F4 RID: 244
		public readonly Vector2 <targetX>k__BackingField;

		// Token: 0x040000F5 RID: 245
		public readonly Vector2 <targetY>k__BackingField;
	}
}
