using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200015D RID: 349
	public class TextureBlitter
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00007705 File Offset: 0x00005905
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00007712 File Offset: 0x00005912
		public bool disposed
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

		// Token: 0x06000805 RID: 2053 RVA: 0x0000771F File Offset: 0x0000591F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00007731 File Offset: 0x00005931
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0000773E File Offset: 0x0000593E
		public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0000774B File Offset: 0x0000594B
		public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00007758 File Offset: 0x00005958
		public int queueLength
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00007765 File Offset: 0x00005965
		public void Commit(RenderTexture dst)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00007772 File Offset: 0x00005972
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0000777F File Offset: 0x0000597F
		public void BeginBlit(RenderTexture dst)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0000778C File Offset: 0x0000598C
		public void EndBlit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000162 RID: 354
		public const int k_TextureSlotCount = 8;
	}
}
