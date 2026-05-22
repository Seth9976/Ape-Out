using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x0200023A RID: 570
	public sealed class SparseTexture : Texture
	{
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x00011BE5 File Offset: 0x0000FDE5
		public int tileWidth
		{
			get
			{
				return SparseTexture.get_tileWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x00011BF7 File Offset: 0x0000FDF7
		public int tileHeight
		{
			get
			{
				return SparseTexture.get_tileHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x00011C09 File Offset: 0x0000FE09
		public bool isCreated
		{
			get
			{
				return SparseTexture.get_isCreatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00011C1B File Offset: 0x0000FE1B
		public static void Internal_Create(SparseTexture mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount)
		{
			SparseTexture.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mono), width, height, format, mipCount);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00011C32 File Offset: 0x0000FE32
		public void UpdateTile(int tileX, int tileY, int miplevel, Il2CppStructArray<Color32> data)
		{
			SparseTexture.UpdateTileDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00011C4E File Offset: 0x0000FE4E
		public void UpdateTileRaw(int tileX, int tileY, int miplevel, Il2CppStructArray<byte> data)
		{
			SparseTexture.UpdateTileRawDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00011C6A File Offset: 0x0000FE6A
		public void UnloadTile(int tileX, int tileY, int miplevel)
		{
			this.UpdateTileRaw(tileX, tileY, miplevel, null);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000760B0 File Offset: 0x000742B0
		public bool ValidateFormat(TextureFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = TextureFormat.PVRTC_RGB2 <= format && format <= TextureFormat.PVRTC_RGBA4;
				bool flag4 = flag3 && (width != height || !Mathf.IsPowerOfTwo(width));
				if (flag4)
				{
					throw new UnityException(String.Format("'{0}' demands texture to be square and have power-of-two dimensions", format.ToString()));
				}
			}
			return flag;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0007611C File Offset: 0x0007431C
		public bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format, UnityEngine.Experimental.Rendering.FormatUsage.Sparse);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsPVRTCFormat(format);
				bool flag4 = flag3 && (width != height || !Mathf.IsPowerOfTwo(width));
				if (flag4)
				{
					throw new UnityException(String.Format("'{0}' demands texture to be square and have power-of-two dimensions", format.ToString()));
				}
			}
			return flag;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00076180 File Offset: 0x00074380
		public bool ValidateSize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			bool flag = (ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockSize(format) * (ulong)((long)width / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockWidth(format))) * (ulong)((long)height / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockHeight(format))) < 65536UL;
			bool flag2;
			if (flag)
			{
				Debug.LogError("SparseTexture creation failed. The minimum size in bytes of a SparseTexture is 64KB.", this);
				flag2 = false;
			}
			else
			{
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000761D0 File Offset: 0x000743D0
		public static void ValidateIsNotCrunched(TextureFormat textureFormat)
		{
			bool flag = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsCrunchFormat(textureFormat);
			if (flag)
			{
				throw new ArgumentException("Crunched SparseTexture is not supported.");
			}
		}

		// Token: 0x04001B99 RID: 7065
		private static readonly SparseTexture.get_tileWidthDelegate get_tileWidthDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileWidthDelegate>("UnityEngine.SparseTexture::get_tileWidth");

		// Token: 0x04001B9A RID: 7066
		private static readonly SparseTexture.get_tileHeightDelegate get_tileHeightDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileHeightDelegate>("UnityEngine.SparseTexture::get_tileHeight");

		// Token: 0x04001B9B RID: 7067
		private static readonly SparseTexture.get_isCreatedDelegate get_isCreatedDelegateField = IL2CPP.ResolveICall<SparseTexture.get_isCreatedDelegate>("UnityEngine.SparseTexture::get_isCreated");

		// Token: 0x04001B9C RID: 7068
		private static readonly SparseTexture.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<SparseTexture.Internal_CreateDelegate>("UnityEngine.SparseTexture::Internal_Create");

		// Token: 0x04001B9D RID: 7069
		private static readonly SparseTexture.UpdateTileDelegate UpdateTileDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileDelegate>("UnityEngine.SparseTexture::UpdateTile");

		// Token: 0x04001B9E RID: 7070
		private static readonly SparseTexture.UpdateTileRawDelegate UpdateTileRawDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileRawDelegate>("UnityEngine.SparseTexture::UpdateTileRaw");

		// Token: 0x02000B71 RID: 2929
		// (Invoke) Token: 0x06003542 RID: 13634
		private delegate int get_tileWidthDelegate(IntPtr @this);

		// Token: 0x02000B72 RID: 2930
		// (Invoke) Token: 0x06003544 RID: 13636
		private delegate int get_tileHeightDelegate(IntPtr @this);

		// Token: 0x02000B73 RID: 2931
		// (Invoke) Token: 0x06003546 RID: 13638
		private delegate bool get_isCreatedDelegate(IntPtr @this);

		// Token: 0x02000B74 RID: 2932
		// (Invoke) Token: 0x06003548 RID: 13640
		private delegate void Internal_CreateDelegate(IntPtr mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);

		// Token: 0x02000B75 RID: 2933
		// (Invoke) Token: 0x0600354A RID: 13642
		private delegate void UpdateTileDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);

		// Token: 0x02000B76 RID: 2934
		// (Invoke) Token: 0x0600354C RID: 13644
		private delegate void UpdateTileRawDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);
	}
}
