using System;
using Il2CppInterop.Runtime;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x0200020B RID: 523
	public class HDROutputSettings
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x000111F1 File Offset: 0x0000F3F1
		public static HDROutputSettings main
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000111FE File Offset: 0x0000F3FE
		public bool active
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0001120B File Offset: 0x0000F40B
		public bool available
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x00011218 File Offset: 0x0000F418
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x00011225 File Offset: 0x0000F425
		public bool automaticHDRTonemapping
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x00011232 File Offset: 0x0000F432
		public ColorGamut displayColorGamut
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0001123F File Offset: 0x0000F43F
		public RenderTextureFormat format
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0001124C File Offset: 0x0000F44C
		public UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x00011259 File Offset: 0x0000F459
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x00011266 File Offset: 0x0000F466
		public float paperWhiteNits
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

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x00011273 File Offset: 0x0000F473
		public int maxFullFrameToneMapLuminance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00011280 File Offset: 0x0000F480
		public int maxToneMapLuminance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0001128D File Offset: 0x0000F48D
		public int minToneMapLuminance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0001129A File Offset: 0x0000F49A
		public bool HDRModeChangeRequested
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000112A7 File Offset: 0x0000F4A7
		public void RequestHDRModeChange(bool enabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00075444 File Offset: 0x00073644
		public static void SetPaperWhiteInNits(float paperWhite)
		{
			int num = 0;
			bool available = HDROutputSettings.GetAvailable(num);
			if (available)
			{
				HDROutputSettings.SetPaperWhiteNits(num, paperWhite);
			}
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000112B4 File Offset: 0x0000F4B4
		public static bool GetActive(int displayIndex)
		{
			return HDROutputSettings.GetActiveDelegateField(displayIndex);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000112C1 File Offset: 0x0000F4C1
		public static bool GetAvailable(int displayIndex)
		{
			return HDROutputSettings.GetAvailableDelegateField(displayIndex);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000112CE File Offset: 0x0000F4CE
		public static bool GetAutomaticHDRTonemapping(int displayIndex)
		{
			return HDROutputSettings.GetAutomaticHDRTonemappingDelegateField(displayIndex);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000112DB File Offset: 0x0000F4DB
		public static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted)
		{
			HDROutputSettings.SetAutomaticHDRTonemappingDelegateField(displayIndex, scripted);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000112E9 File Offset: 0x0000F4E9
		public static ColorGamut GetDisplayColorGamut(int displayIndex)
		{
			return HDROutputSettings.GetDisplayColorGamutDelegateField(displayIndex);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x000112F6 File Offset: 0x0000F4F6
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(int displayIndex)
		{
			return HDROutputSettings.GetGraphicsFormatDelegateField(displayIndex);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00011303 File Offset: 0x0000F503
		public static float GetPaperWhiteNits(int displayIndex)
		{
			return HDROutputSettings.GetPaperWhiteNitsDelegateField(displayIndex);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00011310 File Offset: 0x0000F510
		public static void SetPaperWhiteNits(int displayIndex, float paperWhite)
		{
			HDROutputSettings.SetPaperWhiteNitsDelegateField(displayIndex, paperWhite);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0001131E File Offset: 0x0000F51E
		public static int GetMaxFullFrameToneMapLuminance(int displayIndex)
		{
			return HDROutputSettings.GetMaxFullFrameToneMapLuminanceDelegateField(displayIndex);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0001132B File Offset: 0x0000F52B
		public static int GetMaxToneMapLuminance(int displayIndex)
		{
			return HDROutputSettings.GetMaxToneMapLuminanceDelegateField(displayIndex);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00011338 File Offset: 0x0000F538
		public static int GetMinToneMapLuminance(int displayIndex)
		{
			return HDROutputSettings.GetMinToneMapLuminanceDelegateField(displayIndex);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00011345 File Offset: 0x0000F545
		public static bool GetHDRModeChangeRequested(int displayIndex)
		{
			return HDROutputSettings.GetHDRModeChangeRequestedDelegateField(displayIndex);
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00011352 File Offset: 0x0000F552
		public static void RequestHDRModeChangeInternal(int displayIndex, bool enabled)
		{
			HDROutputSettings.RequestHDRModeChangeInternalDelegateField(displayIndex, enabled);
		}

		// Token: 0x04001AB3 RID: 6835
		private static readonly HDROutputSettings.GetActiveDelegate GetActiveDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetActiveDelegate>("UnityEngine.HDROutputSettings::GetActive");

		// Token: 0x04001AB4 RID: 6836
		private static readonly HDROutputSettings.GetAvailableDelegate GetAvailableDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetAvailableDelegate>("UnityEngine.HDROutputSettings::GetAvailable");

		// Token: 0x04001AB5 RID: 6837
		private static readonly HDROutputSettings.GetAutomaticHDRTonemappingDelegate GetAutomaticHDRTonemappingDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetAutomaticHDRTonemappingDelegate>("UnityEngine.HDROutputSettings::GetAutomaticHDRTonemapping");

		// Token: 0x04001AB6 RID: 6838
		private static readonly HDROutputSettings.SetAutomaticHDRTonemappingDelegate SetAutomaticHDRTonemappingDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetAutomaticHDRTonemappingDelegate>("UnityEngine.HDROutputSettings::SetAutomaticHDRTonemapping");

		// Token: 0x04001AB7 RID: 6839
		private static readonly HDROutputSettings.GetDisplayColorGamutDelegate GetDisplayColorGamutDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetDisplayColorGamutDelegate>("UnityEngine.HDROutputSettings::GetDisplayColorGamut");

		// Token: 0x04001AB8 RID: 6840
		private static readonly HDROutputSettings.GetGraphicsFormatDelegate GetGraphicsFormatDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetGraphicsFormatDelegate>("UnityEngine.HDROutputSettings::GetGraphicsFormat");

		// Token: 0x04001AB9 RID: 6841
		private static readonly HDROutputSettings.GetPaperWhiteNitsDelegate GetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::GetPaperWhiteNits");

		// Token: 0x04001ABA RID: 6842
		private static readonly HDROutputSettings.SetPaperWhiteNitsDelegate SetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::SetPaperWhiteNits");

		// Token: 0x04001ABB RID: 6843
		private static readonly HDROutputSettings.GetMaxFullFrameToneMapLuminanceDelegate GetMaxFullFrameToneMapLuminanceDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetMaxFullFrameToneMapLuminanceDelegate>("UnityEngine.HDROutputSettings::GetMaxFullFrameToneMapLuminance");

		// Token: 0x04001ABC RID: 6844
		private static readonly HDROutputSettings.GetMaxToneMapLuminanceDelegate GetMaxToneMapLuminanceDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetMaxToneMapLuminanceDelegate>("UnityEngine.HDROutputSettings::GetMaxToneMapLuminance");

		// Token: 0x04001ABD RID: 6845
		private static readonly HDROutputSettings.GetMinToneMapLuminanceDelegate GetMinToneMapLuminanceDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetMinToneMapLuminanceDelegate>("UnityEngine.HDROutputSettings::GetMinToneMapLuminance");

		// Token: 0x04001ABE RID: 6846
		private static readonly HDROutputSettings.GetHDRModeChangeRequestedDelegate GetHDRModeChangeRequestedDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetHDRModeChangeRequestedDelegate>("UnityEngine.HDROutputSettings::GetHDRModeChangeRequested");

		// Token: 0x04001ABF RID: 6847
		private static readonly HDROutputSettings.RequestHDRModeChangeInternalDelegate RequestHDRModeChangeInternalDelegateField = IL2CPP.ResolveICall<HDROutputSettings.RequestHDRModeChangeInternalDelegate>("UnityEngine.HDROutputSettings::RequestHDRModeChangeInternal");

		// Token: 0x02000B06 RID: 2822
		// (Invoke) Token: 0x0600346E RID: 13422
		private delegate bool GetActiveDelegate(int displayIndex);

		// Token: 0x02000B07 RID: 2823
		// (Invoke) Token: 0x06003470 RID: 13424
		private delegate bool GetAvailableDelegate(int displayIndex);

		// Token: 0x02000B08 RID: 2824
		// (Invoke) Token: 0x06003472 RID: 13426
		private delegate bool GetAutomaticHDRTonemappingDelegate(int displayIndex);

		// Token: 0x02000B09 RID: 2825
		// (Invoke) Token: 0x06003474 RID: 13428
		private delegate void SetAutomaticHDRTonemappingDelegate(int displayIndex, bool scripted);

		// Token: 0x02000B0A RID: 2826
		// (Invoke) Token: 0x06003476 RID: 13430
		private delegate ColorGamut GetDisplayColorGamutDelegate(int displayIndex);

		// Token: 0x02000B0B RID: 2827
		// (Invoke) Token: 0x06003478 RID: 13432
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormatDelegate(int displayIndex);

		// Token: 0x02000B0C RID: 2828
		// (Invoke) Token: 0x0600347A RID: 13434
		private delegate float GetPaperWhiteNitsDelegate(int displayIndex);

		// Token: 0x02000B0D RID: 2829
		// (Invoke) Token: 0x0600347C RID: 13436
		private delegate void SetPaperWhiteNitsDelegate(int displayIndex, float paperWhite);

		// Token: 0x02000B0E RID: 2830
		// (Invoke) Token: 0x0600347E RID: 13438
		private delegate int GetMaxFullFrameToneMapLuminanceDelegate(int displayIndex);

		// Token: 0x02000B0F RID: 2831
		// (Invoke) Token: 0x06003480 RID: 13440
		private delegate int GetMaxToneMapLuminanceDelegate(int displayIndex);

		// Token: 0x02000B10 RID: 2832
		// (Invoke) Token: 0x06003482 RID: 13442
		private delegate int GetMinToneMapLuminanceDelegate(int displayIndex);

		// Token: 0x02000B11 RID: 2833
		// (Invoke) Token: 0x06003484 RID: 13444
		private delegate bool GetHDRModeChangeRequestedDelegate(int displayIndex);

		// Token: 0x02000B12 RID: 2834
		// (Invoke) Token: 0x06003486 RID: 13446
		private delegate void RequestHDRModeChangeInternalDelegate(int displayIndex, bool enabled);
	}
}
