using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public sealed class AudioDistortionFilter : Behaviour
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00002BF5 File Offset: 0x00000DF5
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002C07 File Offset: 0x00000E07
		public float distortionLevel
		{
			get
			{
				return AudioDistortionFilter.get_distortionLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioDistortionFilter.set_distortionLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400015E RID: 350
		private static readonly AudioDistortionFilter.get_distortionLevelDelegate get_distortionLevelDelegateField = IL2CPP.ResolveICall<AudioDistortionFilter.get_distortionLevelDelegate>("UnityEngine.AudioDistortionFilter::get_distortionLevel");

		// Token: 0x0400015F RID: 351
		private static readonly AudioDistortionFilter.set_distortionLevelDelegate set_distortionLevelDelegateField = IL2CPP.ResolveICall<AudioDistortionFilter.set_distortionLevelDelegate>("UnityEngine.AudioDistortionFilter::set_distortionLevel");

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600030F RID: 783
		private delegate float get_distortionLevelDelegate(IntPtr @this);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000311 RID: 785
		private delegate void set_distortionLevelDelegate(IntPtr @this, float value);
	}
}
