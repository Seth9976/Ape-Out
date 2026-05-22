using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020002CF RID: 719
	public class RenderSettings
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x00012B55 File Offset: 0x00010D55
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x00012B61 File Offset: 0x00010D61
		public static bool useRadianceAmbientProbe
		{
			get
			{
				return RenderSettings.get_useRadianceAmbientProbeDelegateField();
			}
			set
			{
				RenderSettings.set_useRadianceAmbientProbeDelegateField(value);
			}
		}

		// Token: 0x04001E12 RID: 7698
		private static readonly RenderSettings.get_useRadianceAmbientProbeDelegate get_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::get_useRadianceAmbientProbe");

		// Token: 0x04001E13 RID: 7699
		private static readonly RenderSettings.set_useRadianceAmbientProbeDelegate set_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::set_useRadianceAmbientProbe");

		// Token: 0x02000C0A RID: 3082
		// (Invoke) Token: 0x0600366A RID: 13930
		private delegate bool get_useRadianceAmbientProbeDelegate();

		// Token: 0x02000C0B RID: 3083
		// (Invoke) Token: 0x0600366C RID: 13932
		private delegate void set_useRadianceAmbientProbeDelegate(bool value);
	}
}
