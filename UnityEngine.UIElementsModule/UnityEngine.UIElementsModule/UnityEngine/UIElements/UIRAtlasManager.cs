using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010B RID: 267
	public class UIRAtlasManager
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00006305 File Offset: 0x00004505
		public static void add_atlasManagerCreated(Action<UIRAtlasManager> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00006312 File Offset: 0x00004512
		public static void remove_atlasManagerCreated(Action<UIRAtlasManager> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000631F File Offset: 0x0000451F
		public static void add_atlasManagerDisposed(Action<UIRAtlasManager> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000632C File Offset: 0x0000452C
		public static void remove_atlasManagerDisposed(Action<UIRAtlasManager> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00006339 File Offset: 0x00004539
		public int maxImageSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00006346 File Offset: 0x00004546
		public RenderTextureFormat format
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00006353 File Offset: 0x00004553
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00006360 File Offset: 0x00004560
		public RenderTexture atlas
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0000636D File Offset: 0x0000456D
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0000637A File Offset: 0x0000457A
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

		// Token: 0x06000600 RID: 1536 RVA: 0x00006387 File Offset: 0x00004587
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00006399 File Offset: 0x00004599
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000063A6 File Offset: 0x000045A6
		public static void LogDisposeError()
		{
			Debug.LogError("An attempt to use a disposed atlas manager has been detected.");
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000063B4 File Offset: 0x000045B4
		public static void MarkAllForReset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000063C1 File Offset: 0x000045C1
		public void MarkForReset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000063CE File Offset: 0x000045CE
		public bool RequiresReset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		public bool IsReleased()
		{
			return this.atlas != null && !this.atlas.IsCreated();
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000063DB File Offset: 0x000045DB
		public void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000063E8 File Offset: 0x000045E8
		public bool TryGetLocation(Texture2D image, out RectInt uvs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000063F5 File Offset: 0x000045F5
		public bool AllocateRect(int width, int height, out RectInt uvs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00006402 File Offset: 0x00004602
		public void EnqueueBlit(Texture image, RectInt srcRect, int x, int y, bool addBorder, Color tint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000C3E0 File Offset: 0x0000A5E0
		public static bool IsTextureFormatSupported(TextureFormat format)
		{
			switch (format)
			{
			case TextureFormat.Alpha8:
			case TextureFormat.ARGB4444:
			case TextureFormat.RGB24:
			case TextureFormat.RGBA32:
			case TextureFormat.ARGB32:
			case TextureFormat.RGB565:
			case TextureFormat.R16:
			case TextureFormat.DXT1:
			case TextureFormat.DXT5:
			case TextureFormat.RGBA4444:
			case TextureFormat.BGRA32:
			case TextureFormat.BC7:
			case TextureFormat.BC4:
			case TextureFormat.BC5:
			case TextureFormat.DXT1Crunched:
			case TextureFormat.DXT5Crunched:
			case TextureFormat.PVRTC_RGB2:
			case TextureFormat.PVRTC_RGBA2:
			case TextureFormat.PVRTC_RGB4:
			case TextureFormat.PVRTC_RGBA4:
			case TextureFormat.ETC_RGB4:
			case TextureFormat.EAC_R:
			case TextureFormat.EAC_R_SIGNED:
			case TextureFormat.EAC_RG:
			case TextureFormat.EAC_RG_SIGNED:
			case TextureFormat.ETC2_RGB:
			case TextureFormat.ETC2_RGBA1:
			case TextureFormat.ETC2_RGBA8:
			case TextureFormat.ASTC_4x4:
			case TextureFormat.ASTC_5x5:
			case TextureFormat.ASTC_6x6:
			case TextureFormat.ASTC_8x8:
			case TextureFormat.ASTC_10x10:
			case TextureFormat.ASTC_12x12:
			case TextureFormat.ASTC_RGBA_4x4:
			case TextureFormat.ASTC_RGBA_5x5:
			case TextureFormat.ASTC_RGBA_6x6:
			case TextureFormat.ASTC_RGBA_8x8:
			case TextureFormat.ASTC_RGBA_10x10:
			case TextureFormat.ASTC_RGBA_12x12:
			case TextureFormat.ETC_RGB4_3DS:
			case TextureFormat.ETC_RGBA8_3DS:
			case TextureFormat.RG16:
			case TextureFormat.R8:
			case TextureFormat.ETC_RGB4Crunched:
			case TextureFormat.ETC2_RGBA8Crunched:
				return true;
			case TextureFormat.RHalf:
			case TextureFormat.RGHalf:
			case TextureFormat.RGBAHalf:
			case TextureFormat.RFloat:
			case TextureFormat.RGFloat:
			case TextureFormat.RGBAFloat:
			case TextureFormat.YUY2:
			case TextureFormat.RGB9e5Float:
			case TextureFormat.BC6H:
			case TextureFormat.ASTC_HDR_4x4:
			case TextureFormat.ASTC_HDR_5x5:
			case TextureFormat.ASTC_HDR_6x6:
			case TextureFormat.ASTC_HDR_8x8:
			case TextureFormat.ASTC_HDR_10x10:
			case TextureFormat.ASTC_HDR_12x12:
			case TextureFormat.RG32:
			case TextureFormat.RGB48:
			case TextureFormat.RGBA64:
				return false;
			}
			return false;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000640F File Offset: 0x0000460F
		public bool IsTextureValid(Texture2D image)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000641C File Offset: 0x0000461C
		public void Commit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00006429 File Offset: 0x00004629
		public void UpdateAtlasTexture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00006436 File Offset: 0x00004636
		public RenderTexture CreateAtlasTexture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
