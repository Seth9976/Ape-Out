using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000035 RID: 53
	public abstract class BaseRuntimePanel : Panel
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002C89 File Offset: 0x00000E89
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002C96 File Offset: 0x00000E96
		public override Shader standardWorldSpaceShader
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002CA3 File Offset: 0x00000EA3
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public bool drawToCameras
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

		// Token: 0x06000112 RID: 274 RVA: 0x00002CBD File Offset: 0x00000EBD
		public override void Repaint(Event e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002CCA File Offset: 0x00000ECA
		public Vector2 ScreenToPanel(Vector2 screen)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001A3 RID: 419
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
