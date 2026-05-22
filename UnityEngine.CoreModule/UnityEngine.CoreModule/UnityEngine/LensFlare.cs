using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000215 RID: 533
	public sealed class LensFlare : Behaviour
	{
		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x00011657 File Offset: 0x0000F857
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x00011669 File Offset: 0x0000F869
		public float brightness
		{
			get
			{
				return LensFlare.get_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x0001167C File Offset: 0x0000F87C
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x0001168E File Offset: 0x0000F88E
		public float fadeSpeed
		{
			get
			{
				return LensFlare.get_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x00075A00 File Offset: 0x00073C00
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x000116A1 File Offset: 0x0000F8A1
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x00075A18 File Offset: 0x00073C18
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x000116AB File Offset: 0x0000F8AB
		public Flare flare
		{
			get
			{
				IntPtr intPtr = LensFlare.get_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr2) : null;
			}
			set
			{
				LensFlare.set_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x000116C3 File Offset: 0x0000F8C3
		public void get_color_Injected(out Color ret)
		{
			LensFlare.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000116D6 File Offset: 0x0000F8D6
		public void set_color_Injected(ref Color value)
		{
			LensFlare.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04001ADA RID: 6874
		private static readonly LensFlare.get_brightnessDelegate get_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.get_brightnessDelegate>("UnityEngine.LensFlare::get_brightness");

		// Token: 0x04001ADB RID: 6875
		private static readonly LensFlare.set_brightnessDelegate set_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.set_brightnessDelegate>("UnityEngine.LensFlare::set_brightness");

		// Token: 0x04001ADC RID: 6876
		private static readonly LensFlare.get_fadeSpeedDelegate get_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.get_fadeSpeedDelegate>("UnityEngine.LensFlare::get_fadeSpeed");

		// Token: 0x04001ADD RID: 6877
		private static readonly LensFlare.set_fadeSpeedDelegate set_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.set_fadeSpeedDelegate>("UnityEngine.LensFlare::set_fadeSpeed");

		// Token: 0x04001ADE RID: 6878
		private static readonly LensFlare.get_flareDelegate get_flareDelegateField = IL2CPP.ResolveICall<LensFlare.get_flareDelegate>("UnityEngine.LensFlare::get_flare");

		// Token: 0x04001ADF RID: 6879
		private static readonly LensFlare.set_flareDelegate set_flareDelegateField = IL2CPP.ResolveICall<LensFlare.set_flareDelegate>("UnityEngine.LensFlare::set_flare");

		// Token: 0x04001AE0 RID: 6880
		private static readonly LensFlare.get_color_InjectedDelegate get_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_color_InjectedDelegate>("UnityEngine.LensFlare::get_color_Injected");

		// Token: 0x04001AE1 RID: 6881
		private static readonly LensFlare.set_color_InjectedDelegate set_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_color_InjectedDelegate>("UnityEngine.LensFlare::set_color_Injected");

		// Token: 0x02000B2A RID: 2858
		// (Invoke) Token: 0x060034B4 RID: 13492
		private delegate float get_brightnessDelegate(IntPtr @this);

		// Token: 0x02000B2B RID: 2859
		// (Invoke) Token: 0x060034B6 RID: 13494
		private delegate void set_brightnessDelegate(IntPtr @this, float value);

		// Token: 0x02000B2C RID: 2860
		// (Invoke) Token: 0x060034B8 RID: 13496
		private delegate float get_fadeSpeedDelegate(IntPtr @this);

		// Token: 0x02000B2D RID: 2861
		// (Invoke) Token: 0x060034BA RID: 13498
		private delegate void set_fadeSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000B2E RID: 2862
		// (Invoke) Token: 0x060034BC RID: 13500
		private delegate IntPtr get_flareDelegate(IntPtr @this);

		// Token: 0x02000B2F RID: 2863
		// (Invoke) Token: 0x060034BE RID: 13502
		private delegate void set_flareDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B30 RID: 2864
		// (Invoke) Token: 0x060034C0 RID: 13504
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B31 RID: 2865
		// (Invoke) Token: 0x060034C2 RID: 13506
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
