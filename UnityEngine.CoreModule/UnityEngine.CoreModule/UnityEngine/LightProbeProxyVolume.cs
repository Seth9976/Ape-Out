using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200008D RID: 141
	public sealed class LightProbeProxyVolume : Behaviour
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbeProxyVolume()
		{
			Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbeProxyVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr);
			LightProbeProxyVolume.get_isFeatureSupportedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_isFeatureSupportedDelegate>("UnityEngine.LightProbeProxyVolume::get_isFeatureSupported");
			LightProbeProxyVolume.get_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::get_probeDensity");
			LightProbeProxyVolume.set_probeDensityDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probeDensityDelegate>("UnityEngine.LightProbeProxyVolume::set_probeDensity");
			LightProbeProxyVolume.get_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionX");
			LightProbeProxyVolume.set_gridResolutionXDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionXDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionX");
			LightProbeProxyVolume.get_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionY");
			LightProbeProxyVolume.set_gridResolutionYDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionYDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionY");
			LightProbeProxyVolume.get_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionZ");
			LightProbeProxyVolume.set_gridResolutionZDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_gridResolutionZDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionZ");
			LightProbeProxyVolume.get_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::get_boundingBoxMode");
			LightProbeProxyVolume.set_boundingBoxModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_boundingBoxModeDelegate>("UnityEngine.LightProbeProxyVolume::set_boundingBoxMode");
			LightProbeProxyVolume.get_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_resolutionMode");
			LightProbeProxyVolume.set_resolutionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_resolutionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_resolutionMode");
			LightProbeProxyVolume.get_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::get_probePositionMode");
			LightProbeProxyVolume.set_probePositionModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_probePositionModeDelegate>("UnityEngine.LightProbeProxyVolume::set_probePositionMode");
			LightProbeProxyVolume.get_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::get_refreshMode");
			LightProbeProxyVolume.set_refreshModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_refreshModeDelegate>("UnityEngine.LightProbeProxyVolume::set_refreshMode");
			LightProbeProxyVolume.get_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::get_qualityMode");
			LightProbeProxyVolume.set_qualityModeDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_qualityModeDelegate>("UnityEngine.LightProbeProxyVolume::set_qualityMode");
			LightProbeProxyVolume.get_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::get_dataFormat");
			LightProbeProxyVolume.set_dataFormatDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_dataFormatDelegate>("UnityEngine.LightProbeProxyVolume::set_dataFormat");
			LightProbeProxyVolume.SetDirtyFlagDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.SetDirtyFlagDelegate>("UnityEngine.LightProbeProxyVolume::SetDirtyFlag");
			LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundsGlobal_Injected");
			LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_sizeCustom_Injected");
			LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_sizeCustom_Injected");
			LightProbeProxyVolume.get_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.get_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_originCustom_Injected");
			LightProbeProxyVolume.set_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<LightProbeProxyVolume.set_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_originCustom_Injected");
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00007F9B File Offset: 0x0000619B
		public LightProbeProxyVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00007FA4 File Offset: 0x000061A4
		public static bool isFeatureSupported
		{
			get
			{
				return LightProbeProxyVolume.get_isFeatureSupportedDelegateField();
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0002F568 File Offset: 0x0002D768
		public Bounds boundsGlobal
		{
			get
			{
				Bounds bounds;
				this.get_boundsGlobal_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0002F580 File Offset: 0x0002D780
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00007FB0 File Offset: 0x000061B0
		public Vector3 sizeCustom
		{
			get
			{
				Vector3 vector;
				this.get_sizeCustom_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_sizeCustom_Injected(ref value);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0002F598 File Offset: 0x0002D798
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00007FBA File Offset: 0x000061BA
		public Vector3 originCustom
		{
			get
			{
				Vector3 vector;
				this.get_originCustom_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_originCustom_Injected(ref value);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00007FC4 File Offset: 0x000061C4
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00007FD6 File Offset: 0x000061D6
		public float probeDensity
		{
			get
			{
				return LightProbeProxyVolume.get_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probeDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00007FE9 File Offset: 0x000061E9
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00007FFB File Offset: 0x000061FB
		public int gridResolutionX
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0000800E File Offset: 0x0000620E
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00008020 File Offset: 0x00006220
		public int gridResolutionY
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00008033 File Offset: 0x00006233
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00008045 File Offset: 0x00006245
		public int gridResolutionZ
		{
			get
			{
				return LightProbeProxyVolume.get_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_gridResolutionZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00008058 File Offset: 0x00006258
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0000806A File Offset: 0x0000626A
		public LightProbeProxyVolume.BoundingBoxMode boundingBoxMode
		{
			get
			{
				return LightProbeProxyVolume.get_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_boundingBoxModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0000807D File Offset: 0x0000627D
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x0000808F File Offset: 0x0000628F
		public LightProbeProxyVolume.ResolutionMode resolutionMode
		{
			get
			{
				return LightProbeProxyVolume.get_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_resolutionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x000080A2 File Offset: 0x000062A2
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x000080B4 File Offset: 0x000062B4
		public LightProbeProxyVolume.ProbePositionMode probePositionMode
		{
			get
			{
				return LightProbeProxyVolume.get_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_probePositionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000080C7 File Offset: 0x000062C7
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000080D9 File Offset: 0x000062D9
		public LightProbeProxyVolume.RefreshMode refreshMode
		{
			get
			{
				return LightProbeProxyVolume.get_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000080EC File Offset: 0x000062EC
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x000080FE File Offset: 0x000062FE
		public LightProbeProxyVolume.QualityMode qualityMode
		{
			get
			{
				return LightProbeProxyVolume.get_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_qualityModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00008111 File Offset: 0x00006311
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00008123 File Offset: 0x00006323
		public LightProbeProxyVolume.DataFormat dataFormat
		{
			get
			{
				return LightProbeProxyVolume.get_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightProbeProxyVolume.set_dataFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00008136 File Offset: 0x00006336
		public void Update()
		{
			this.SetDirtyFlag(true);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00008141 File Offset: 0x00006341
		public void SetDirtyFlag(bool flag)
		{
			LightProbeProxyVolume.SetDirtyFlagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), flag);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00008154 File Offset: 0x00006354
		public void get_boundsGlobal_Injected(out Bounds ret)
		{
			LightProbeProxyVolume.get_boundsGlobal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00008167 File Offset: 0x00006367
		public void get_sizeCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0000817A File Offset: 0x0000637A
		public void set_sizeCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_sizeCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000818D File Offset: 0x0000638D
		public void get_originCustom_Injected(out Vector3 ret)
		{
			LightProbeProxyVolume.get_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000081A0 File Offset: 0x000063A0
		public void set_originCustom_Injected(ref Vector3 value)
		{
			LightProbeProxyVolume.set_originCustom_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000835 RID: 2101
		private static readonly LightProbeProxyVolume.get_isFeatureSupportedDelegate get_isFeatureSupportedDelegateField;

		// Token: 0x04000836 RID: 2102
		private static readonly LightProbeProxyVolume.get_probeDensityDelegate get_probeDensityDelegateField;

		// Token: 0x04000837 RID: 2103
		private static readonly LightProbeProxyVolume.set_probeDensityDelegate set_probeDensityDelegateField;

		// Token: 0x04000838 RID: 2104
		private static readonly LightProbeProxyVolume.get_gridResolutionXDelegate get_gridResolutionXDelegateField;

		// Token: 0x04000839 RID: 2105
		private static readonly LightProbeProxyVolume.set_gridResolutionXDelegate set_gridResolutionXDelegateField;

		// Token: 0x0400083A RID: 2106
		private static readonly LightProbeProxyVolume.get_gridResolutionYDelegate get_gridResolutionYDelegateField;

		// Token: 0x0400083B RID: 2107
		private static readonly LightProbeProxyVolume.set_gridResolutionYDelegate set_gridResolutionYDelegateField;

		// Token: 0x0400083C RID: 2108
		private static readonly LightProbeProxyVolume.get_gridResolutionZDelegate get_gridResolutionZDelegateField;

		// Token: 0x0400083D RID: 2109
		private static readonly LightProbeProxyVolume.set_gridResolutionZDelegate set_gridResolutionZDelegateField;

		// Token: 0x0400083E RID: 2110
		private static readonly LightProbeProxyVolume.get_boundingBoxModeDelegate get_boundingBoxModeDelegateField;

		// Token: 0x0400083F RID: 2111
		private static readonly LightProbeProxyVolume.set_boundingBoxModeDelegate set_boundingBoxModeDelegateField;

		// Token: 0x04000840 RID: 2112
		private static readonly LightProbeProxyVolume.get_resolutionModeDelegate get_resolutionModeDelegateField;

		// Token: 0x04000841 RID: 2113
		private static readonly LightProbeProxyVolume.set_resolutionModeDelegate set_resolutionModeDelegateField;

		// Token: 0x04000842 RID: 2114
		private static readonly LightProbeProxyVolume.get_probePositionModeDelegate get_probePositionModeDelegateField;

		// Token: 0x04000843 RID: 2115
		private static readonly LightProbeProxyVolume.set_probePositionModeDelegate set_probePositionModeDelegateField;

		// Token: 0x04000844 RID: 2116
		private static readonly LightProbeProxyVolume.get_refreshModeDelegate get_refreshModeDelegateField;

		// Token: 0x04000845 RID: 2117
		private static readonly LightProbeProxyVolume.set_refreshModeDelegate set_refreshModeDelegateField;

		// Token: 0x04000846 RID: 2118
		private static readonly LightProbeProxyVolume.get_qualityModeDelegate get_qualityModeDelegateField;

		// Token: 0x04000847 RID: 2119
		private static readonly LightProbeProxyVolume.set_qualityModeDelegate set_qualityModeDelegateField;

		// Token: 0x04000848 RID: 2120
		private static readonly LightProbeProxyVolume.get_dataFormatDelegate get_dataFormatDelegateField;

		// Token: 0x04000849 RID: 2121
		private static readonly LightProbeProxyVolume.set_dataFormatDelegate set_dataFormatDelegateField;

		// Token: 0x0400084A RID: 2122
		private static readonly LightProbeProxyVolume.SetDirtyFlagDelegate SetDirtyFlagDelegateField;

		// Token: 0x0400084B RID: 2123
		private static readonly LightProbeProxyVolume.get_boundsGlobal_InjectedDelegate get_boundsGlobal_InjectedDelegateField;

		// Token: 0x0400084C RID: 2124
		private static readonly LightProbeProxyVolume.get_sizeCustom_InjectedDelegate get_sizeCustom_InjectedDelegateField;

		// Token: 0x0400084D RID: 2125
		private static readonly LightProbeProxyVolume.set_sizeCustom_InjectedDelegate set_sizeCustom_InjectedDelegateField;

		// Token: 0x0400084E RID: 2126
		private static readonly LightProbeProxyVolume.get_originCustom_InjectedDelegate get_originCustom_InjectedDelegateField;

		// Token: 0x0400084F RID: 2127
		private static readonly LightProbeProxyVolume.set_originCustom_InjectedDelegate set_originCustom_InjectedDelegateField;

		// Token: 0x02000636 RID: 1590
		public enum ResolutionMode
		{
			// Token: 0x04001ED2 RID: 7890
			Automatic,
			// Token: 0x04001ED3 RID: 7891
			Custom
		}

		// Token: 0x02000637 RID: 1591
		public enum BoundingBoxMode
		{
			// Token: 0x04001ED5 RID: 7893
			AutomaticLocal,
			// Token: 0x04001ED6 RID: 7894
			AutomaticWorld,
			// Token: 0x04001ED7 RID: 7895
			Custom
		}

		// Token: 0x02000638 RID: 1592
		public enum ProbePositionMode
		{
			// Token: 0x04001ED9 RID: 7897
			CellCorner,
			// Token: 0x04001EDA RID: 7898
			CellCenter
		}

		// Token: 0x02000639 RID: 1593
		public enum RefreshMode
		{
			// Token: 0x04001EDC RID: 7900
			Automatic,
			// Token: 0x04001EDD RID: 7901
			EveryFrame,
			// Token: 0x04001EDE RID: 7902
			ViaScripting
		}

		// Token: 0x0200063A RID: 1594
		public enum QualityMode
		{
			// Token: 0x04001EE0 RID: 7904
			Low,
			// Token: 0x04001EE1 RID: 7905
			Normal
		}

		// Token: 0x0200063B RID: 1595
		public enum DataFormat
		{
			// Token: 0x04001EE3 RID: 7907
			HalfFloat,
			// Token: 0x04001EE4 RID: 7908
			Float
		}

		// Token: 0x0200063C RID: 1596
		// (Invoke) Token: 0x06002AA2 RID: 10914
		private delegate bool get_isFeatureSupportedDelegate();

		// Token: 0x0200063D RID: 1597
		// (Invoke) Token: 0x06002AA4 RID: 10916
		private delegate float get_probeDensityDelegate(IntPtr @this);

		// Token: 0x0200063E RID: 1598
		// (Invoke) Token: 0x06002AA6 RID: 10918
		private delegate void set_probeDensityDelegate(IntPtr @this, float value);

		// Token: 0x0200063F RID: 1599
		// (Invoke) Token: 0x06002AA8 RID: 10920
		private delegate int get_gridResolutionXDelegate(IntPtr @this);

		// Token: 0x02000640 RID: 1600
		// (Invoke) Token: 0x06002AAA RID: 10922
		private delegate void set_gridResolutionXDelegate(IntPtr @this, int value);

		// Token: 0x02000641 RID: 1601
		// (Invoke) Token: 0x06002AAC RID: 10924
		private delegate int get_gridResolutionYDelegate(IntPtr @this);

		// Token: 0x02000642 RID: 1602
		// (Invoke) Token: 0x06002AAE RID: 10926
		private delegate void set_gridResolutionYDelegate(IntPtr @this, int value);

		// Token: 0x02000643 RID: 1603
		// (Invoke) Token: 0x06002AB0 RID: 10928
		private delegate int get_gridResolutionZDelegate(IntPtr @this);

		// Token: 0x02000644 RID: 1604
		// (Invoke) Token: 0x06002AB2 RID: 10930
		private delegate void set_gridResolutionZDelegate(IntPtr @this, int value);

		// Token: 0x02000645 RID: 1605
		// (Invoke) Token: 0x06002AB4 RID: 10932
		private delegate LightProbeProxyVolume.BoundingBoxMode get_boundingBoxModeDelegate(IntPtr @this);

		// Token: 0x02000646 RID: 1606
		// (Invoke) Token: 0x06002AB6 RID: 10934
		private delegate void set_boundingBoxModeDelegate(IntPtr @this, LightProbeProxyVolume.BoundingBoxMode value);

		// Token: 0x02000647 RID: 1607
		// (Invoke) Token: 0x06002AB8 RID: 10936
		private delegate LightProbeProxyVolume.ResolutionMode get_resolutionModeDelegate(IntPtr @this);

		// Token: 0x02000648 RID: 1608
		// (Invoke) Token: 0x06002ABA RID: 10938
		private delegate void set_resolutionModeDelegate(IntPtr @this, LightProbeProxyVolume.ResolutionMode value);

		// Token: 0x02000649 RID: 1609
		// (Invoke) Token: 0x06002ABC RID: 10940
		private delegate LightProbeProxyVolume.ProbePositionMode get_probePositionModeDelegate(IntPtr @this);

		// Token: 0x0200064A RID: 1610
		// (Invoke) Token: 0x06002ABE RID: 10942
		private delegate void set_probePositionModeDelegate(IntPtr @this, LightProbeProxyVolume.ProbePositionMode value);

		// Token: 0x0200064B RID: 1611
		// (Invoke) Token: 0x06002AC0 RID: 10944
		private delegate LightProbeProxyVolume.RefreshMode get_refreshModeDelegate(IntPtr @this);

		// Token: 0x0200064C RID: 1612
		// (Invoke) Token: 0x06002AC2 RID: 10946
		private delegate void set_refreshModeDelegate(IntPtr @this, LightProbeProxyVolume.RefreshMode value);

		// Token: 0x0200064D RID: 1613
		// (Invoke) Token: 0x06002AC4 RID: 10948
		private delegate LightProbeProxyVolume.QualityMode get_qualityModeDelegate(IntPtr @this);

		// Token: 0x0200064E RID: 1614
		// (Invoke) Token: 0x06002AC6 RID: 10950
		private delegate void set_qualityModeDelegate(IntPtr @this, LightProbeProxyVolume.QualityMode value);

		// Token: 0x0200064F RID: 1615
		// (Invoke) Token: 0x06002AC8 RID: 10952
		private delegate LightProbeProxyVolume.DataFormat get_dataFormatDelegate(IntPtr @this);

		// Token: 0x02000650 RID: 1616
		// (Invoke) Token: 0x06002ACA RID: 10954
		private delegate void set_dataFormatDelegate(IntPtr @this, LightProbeProxyVolume.DataFormat value);

		// Token: 0x02000651 RID: 1617
		// (Invoke) Token: 0x06002ACC RID: 10956
		private delegate void SetDirtyFlagDelegate(IntPtr @this, bool flag);

		// Token: 0x02000652 RID: 1618
		// (Invoke) Token: 0x06002ACE RID: 10958
		private delegate void get_boundsGlobal_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000653 RID: 1619
		// (Invoke) Token: 0x06002AD0 RID: 10960
		private delegate void get_sizeCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000654 RID: 1620
		// (Invoke) Token: 0x06002AD2 RID: 10962
		private delegate void set_sizeCustom_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000655 RID: 1621
		// (Invoke) Token: 0x06002AD4 RID: 10964
		private delegate void get_originCustom_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000656 RID: 1622
		// (Invoke) Token: 0x06002AD6 RID: 10966
		private delegate void set_originCustom_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
