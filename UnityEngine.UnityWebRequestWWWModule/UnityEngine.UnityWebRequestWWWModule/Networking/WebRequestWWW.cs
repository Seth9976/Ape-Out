using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000004 RID: 4
	public static class WebRequestWWW
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002450 File Offset: 0x00000650
		public static AudioClip InternalCreateAudioClipUsingDH(DownloadHandler dh, string url, bool stream, bool compressed, AudioType audioType)
		{
			IntPtr intPtr = WebRequestWWW.InternalCreateAudioClipUsingDHDelegateField(IL2CPP.Il2CppObjectBaseToPtr(dh), IL2CPP.ManagedStringToIl2Cpp(url), stream, compressed, audioType);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x04000001 RID: 1
		private static readonly WebRequestWWW.InternalCreateAudioClipUsingDHDelegate InternalCreateAudioClipUsingDHDelegateField = IL2CPP.ResolveICall<WebRequestWWW.InternalCreateAudioClipUsingDHDelegate>("UnityEngine.Networking.WebRequestWWW::InternalCreateAudioClipUsingDH");

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate IntPtr InternalCreateAudioClipUsingDHDelegate(IntPtr dh, IntPtr url, bool stream, bool compressed, AudioType audioType);
	}
}
