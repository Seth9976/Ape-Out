using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	public sealed class DownloadHandlerTexture : DownloadHandler
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000207F File Offset: 0x0000027F
		public static IntPtr Create(DownloadHandlerTexture obj, bool readable)
		{
			return DownloadHandlerTexture.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), readable);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002092 File Offset: 0x00000292
		public void InternalCreateTexture(bool readable)
		{
			base.m_Ptr = DownloadHandlerTexture.Create(this, readable);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000214C File Offset: 0x0000034C
		public override Il2CppStructArray<byte> GetData()
		{
			return DownloadHandler.InternalGetByteArray(this);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002164 File Offset: 0x00000364
		public Texture2D texture
		{
			get
			{
				return this.InternalGetTexture();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020A2 File Offset: 0x000002A2
		public Texture2D InternalGetTexture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000217C File Offset: 0x0000037C
		public Texture2D InternalGetTextureNative()
		{
			IntPtr intPtr = DownloadHandlerTexture.InternalGetTextureNativeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020AF File Offset: 0x000002AF
		public void ClearNativeTexture()
		{
			DownloadHandlerTexture.ClearNativeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021A8 File Offset: 0x000003A8
		public static Texture2D GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>(www).texture;
		}

		// Token: 0x04000001 RID: 1
		private static readonly DownloadHandlerTexture.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerTexture.CreateDelegate>("UnityEngine.Networking.DownloadHandlerTexture::Create");

		// Token: 0x04000002 RID: 2
		private static readonly DownloadHandlerTexture.InternalGetTextureNativeDelegate InternalGetTextureNativeDelegateField = IL2CPP.ResolveICall<DownloadHandlerTexture.InternalGetTextureNativeDelegate>("UnityEngine.Networking.DownloadHandlerTexture::InternalGetTextureNative");

		// Token: 0x04000003 RID: 3
		private static readonly DownloadHandlerTexture.ClearNativeTextureDelegate ClearNativeTextureDelegateField = IL2CPP.ResolveICall<DownloadHandlerTexture.ClearNativeTextureDelegate>("UnityEngine.Networking.DownloadHandlerTexture::ClearNativeTexture");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000F RID: 15
		private delegate IntPtr CreateDelegate(IntPtr obj, bool readable);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000011 RID: 17
		private delegate IntPtr InternalGetTextureNativeDelegate(IntPtr @this);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000013 RID: 19
		private delegate void ClearNativeTextureDelegate(IntPtr @this);
	}
}
