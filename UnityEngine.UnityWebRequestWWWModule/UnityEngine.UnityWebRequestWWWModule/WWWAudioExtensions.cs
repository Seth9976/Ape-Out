using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public static class WWWAudioExtensions
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002394 File Offset: 0x00000594
		public static AudioClip GetAudioClip(WWW www)
		{
			return www.GetAudioClip();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000023AC File Offset: 0x000005AC
		public static AudioClip GetAudioClip(WWW www, bool threeD)
		{
			return www.GetAudioClip(threeD);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000023C8 File Offset: 0x000005C8
		public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream)
		{
			return www.GetAudioClip(threeD, stream);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000023E4 File Offset: 0x000005E4
		public static AudioClip GetAudioClip(WWW www, bool threeD, bool stream, AudioType audioType)
		{
			return www.GetAudioClip(threeD, stream, audioType);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002400 File Offset: 0x00000600
		public static AudioClip GetAudioClipCompressed(WWW www)
		{
			return www.GetAudioClipCompressed();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002418 File Offset: 0x00000618
		public static AudioClip GetAudioClipCompressed(WWW www, bool threeD)
		{
			return www.GetAudioClipCompressed(threeD);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002434 File Offset: 0x00000634
		public static AudioClip GetAudioClipCompressed(WWW www, bool threeD, AudioType audioType)
		{
			return www.GetAudioClipCompressed(threeD, audioType);
		}
	}
}
