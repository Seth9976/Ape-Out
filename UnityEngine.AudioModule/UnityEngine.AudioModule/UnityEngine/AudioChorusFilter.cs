using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public sealed class AudioChorusFilter : Behaviour
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002CAE File Offset: 0x00000EAE
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public float dryMix
		{
			get
			{
				return AudioChorusFilter.get_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_dryMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00002CD3 File Offset: 0x00000ED3
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public float wetMix1
		{
			get
			{
				return AudioChorusFilter.get_wetMix1DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_wetMix1DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00002CF8 File Offset: 0x00000EF8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002D0A File Offset: 0x00000F0A
		public float wetMix2
		{
			get
			{
				return AudioChorusFilter.get_wetMix2DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_wetMix2DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002D1D File Offset: 0x00000F1D
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002D2F File Offset: 0x00000F2F
		public float wetMix3
		{
			get
			{
				return AudioChorusFilter.get_wetMix3DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_wetMix3DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00002D42 File Offset: 0x00000F42
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002D54 File Offset: 0x00000F54
		public float delay
		{
			get
			{
				return AudioChorusFilter.get_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_delayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00002D67 File Offset: 0x00000F67
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002D79 File Offset: 0x00000F79
		public float rate
		{
			get
			{
				return AudioChorusFilter.get_rateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_rateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002D8C File Offset: 0x00000F8C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002D9E File Offset: 0x00000F9E
		public float depth
		{
			get
			{
				return AudioChorusFilter.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioChorusFilter.set_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00007910 File Offset: 0x00005B10
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002DB1 File Offset: 0x00000FB1
		public float feedback
		{
			get
			{
				Debug.LogWarning("Warning! Feedback is deprecated. This property does nothing.");
				return 0f;
			}
			set
			{
				Debug.LogWarning("Warning! Feedback is deprecated. This property does nothing.");
			}
		}

		// Token: 0x04000168 RID: 360
		private static readonly AudioChorusFilter.get_dryMixDelegate get_dryMixDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_dryMixDelegate>("UnityEngine.AudioChorusFilter::get_dryMix");

		// Token: 0x04000169 RID: 361
		private static readonly AudioChorusFilter.set_dryMixDelegate set_dryMixDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_dryMixDelegate>("UnityEngine.AudioChorusFilter::set_dryMix");

		// Token: 0x0400016A RID: 362
		private static readonly AudioChorusFilter.get_wetMix1Delegate get_wetMix1DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_wetMix1Delegate>("UnityEngine.AudioChorusFilter::get_wetMix1");

		// Token: 0x0400016B RID: 363
		private static readonly AudioChorusFilter.set_wetMix1Delegate set_wetMix1DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_wetMix1Delegate>("UnityEngine.AudioChorusFilter::set_wetMix1");

		// Token: 0x0400016C RID: 364
		private static readonly AudioChorusFilter.get_wetMix2Delegate get_wetMix2DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_wetMix2Delegate>("UnityEngine.AudioChorusFilter::get_wetMix2");

		// Token: 0x0400016D RID: 365
		private static readonly AudioChorusFilter.set_wetMix2Delegate set_wetMix2DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_wetMix2Delegate>("UnityEngine.AudioChorusFilter::set_wetMix2");

		// Token: 0x0400016E RID: 366
		private static readonly AudioChorusFilter.get_wetMix3Delegate get_wetMix3DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_wetMix3Delegate>("UnityEngine.AudioChorusFilter::get_wetMix3");

		// Token: 0x0400016F RID: 367
		private static readonly AudioChorusFilter.set_wetMix3Delegate set_wetMix3DelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_wetMix3Delegate>("UnityEngine.AudioChorusFilter::set_wetMix3");

		// Token: 0x04000170 RID: 368
		private static readonly AudioChorusFilter.get_delayDelegate get_delayDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_delayDelegate>("UnityEngine.AudioChorusFilter::get_delay");

		// Token: 0x04000171 RID: 369
		private static readonly AudioChorusFilter.set_delayDelegate set_delayDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_delayDelegate>("UnityEngine.AudioChorusFilter::set_delay");

		// Token: 0x04000172 RID: 370
		private static readonly AudioChorusFilter.get_rateDelegate get_rateDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_rateDelegate>("UnityEngine.AudioChorusFilter::get_rate");

		// Token: 0x04000173 RID: 371
		private static readonly AudioChorusFilter.set_rateDelegate set_rateDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_rateDelegate>("UnityEngine.AudioChorusFilter::set_rate");

		// Token: 0x04000174 RID: 372
		private static readonly AudioChorusFilter.get_depthDelegate get_depthDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.get_depthDelegate>("UnityEngine.AudioChorusFilter::get_depth");

		// Token: 0x04000175 RID: 373
		private static readonly AudioChorusFilter.set_depthDelegate set_depthDelegateField = IL2CPP.ResolveICall<AudioChorusFilter.set_depthDelegate>("UnityEngine.AudioChorusFilter::set_depth");

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000323 RID: 803
		private delegate float get_dryMixDelegate(IntPtr @this);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000325 RID: 805
		private delegate void set_dryMixDelegate(IntPtr @this, float value);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000327 RID: 807
		private delegate float get_wetMix1Delegate(IntPtr @this);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000329 RID: 809
		private delegate void set_wetMix1Delegate(IntPtr @this, float value);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x0600032B RID: 811
		private delegate float get_wetMix2Delegate(IntPtr @this);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x0600032D RID: 813
		private delegate void set_wetMix2Delegate(IntPtr @this, float value);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x0600032F RID: 815
		private delegate float get_wetMix3Delegate(IntPtr @this);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000331 RID: 817
		private delegate void set_wetMix3Delegate(IntPtr @this, float value);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000333 RID: 819
		private delegate float get_delayDelegate(IntPtr @this);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000335 RID: 821
		private delegate void set_delayDelegate(IntPtr @this, float value);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x06000337 RID: 823
		private delegate float get_rateDelegate(IntPtr @this);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000339 RID: 825
		private delegate void set_rateDelegate(IntPtr @this, float value);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x0600033B RID: 827
		private delegate float get_depthDelegate(IntPtr @this);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x0600033D RID: 829
		private delegate void set_depthDelegate(IntPtr @this, float value);
	}
}
