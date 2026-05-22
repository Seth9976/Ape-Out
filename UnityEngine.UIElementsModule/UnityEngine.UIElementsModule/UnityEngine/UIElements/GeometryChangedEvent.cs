using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D5 RID: 213
	public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x0000590E File Offset: 0x00003B0E
		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000591B File Offset: 0x00003B1B
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00005928 File Offset: 0x00003B28
		public void LocalInit()
		{
			this.oldRect = Rect.zero;
			this.newRect = Rect.zero;
			this.layoutPass = 0;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0000594B File Offset: 0x00003B4B
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00005958 File Offset: 0x00003B58
		public Rect oldRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00005965 File Offset: 0x00003B65
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00005972 File Offset: 0x00003B72
		public Rect newRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000597F File Offset: 0x00003B7F
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0000598C File Offset: 0x00003B8C
		public int layoutPass
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
