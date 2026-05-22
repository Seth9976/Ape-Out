using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B7 RID: 695
	public class SplashScreen
	{
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00012951 File Offset: 0x00010B51
		public static bool isFinished
		{
			get
			{
				return SplashScreen.get_isFinishedDelegateField();
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0001295D File Offset: 0x00010B5D
		public static void CancelSplashScreen()
		{
			SplashScreen.CancelSplashScreenDelegateField();
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00012969 File Offset: 0x00010B69
		public static void BeginSplashScreenFade()
		{
			SplashScreen.BeginSplashScreenFadeDelegateField();
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00012975 File Offset: 0x00010B75
		public static void Begin()
		{
			SplashScreen.BeginDelegateField();
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000785EC File Offset: 0x000767EC
		public static void Stop(SplashScreen.StopBehavior stopBehavior)
		{
			bool flag = stopBehavior == SplashScreen.StopBehavior.FadeOut;
			if (flag)
			{
				SplashScreen.BeginSplashScreenFade();
			}
			else
			{
				SplashScreen.CancelSplashScreen();
			}
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00012981 File Offset: 0x00010B81
		public static void Draw()
		{
			SplashScreen.DrawDelegateField();
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0001298D File Offset: 0x00010B8D
		public static void SetTime(float time)
		{
			SplashScreen.SetTimeDelegateField(time);
		}

		// Token: 0x04001D96 RID: 7574
		private static readonly SplashScreen.get_isFinishedDelegate get_isFinishedDelegateField = IL2CPP.ResolveICall<SplashScreen.get_isFinishedDelegate>("UnityEngine.Rendering.SplashScreen::get_isFinished");

		// Token: 0x04001D97 RID: 7575
		private static readonly SplashScreen.CancelSplashScreenDelegate CancelSplashScreenDelegateField = IL2CPP.ResolveICall<SplashScreen.CancelSplashScreenDelegate>("UnityEngine.Rendering.SplashScreen::CancelSplashScreen");

		// Token: 0x04001D98 RID: 7576
		private static readonly SplashScreen.BeginSplashScreenFadeDelegate BeginSplashScreenFadeDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginSplashScreenFadeDelegate>("UnityEngine.Rendering.SplashScreen::BeginSplashScreenFade");

		// Token: 0x04001D99 RID: 7577
		private static readonly SplashScreen.BeginDelegate BeginDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginDelegate>("UnityEngine.Rendering.SplashScreen::Begin");

		// Token: 0x04001D9A RID: 7578
		private static readonly SplashScreen.DrawDelegate DrawDelegateField = IL2CPP.ResolveICall<SplashScreen.DrawDelegate>("UnityEngine.Rendering.SplashScreen::Draw");

		// Token: 0x04001D9B RID: 7579
		private static readonly SplashScreen.SetTimeDelegate SetTimeDelegateField = IL2CPP.ResolveICall<SplashScreen.SetTimeDelegate>("UnityEngine.Rendering.SplashScreen::SetTime");

		// Token: 0x02000BF1 RID: 3057
		public enum StopBehavior
		{
			// Token: 0x0400205B RID: 8283
			StopImmediate,
			// Token: 0x0400205C RID: 8284
			FadeOut
		}

		// Token: 0x02000BF2 RID: 3058
		// (Invoke) Token: 0x0600363A RID: 13882
		private delegate bool get_isFinishedDelegate();

		// Token: 0x02000BF3 RID: 3059
		// (Invoke) Token: 0x0600363C RID: 13884
		private delegate void CancelSplashScreenDelegate();

		// Token: 0x02000BF4 RID: 3060
		// (Invoke) Token: 0x0600363E RID: 13886
		private delegate void BeginSplashScreenFadeDelegate();

		// Token: 0x02000BF5 RID: 3061
		// (Invoke) Token: 0x06003640 RID: 13888
		private delegate void BeginDelegate();

		// Token: 0x02000BF6 RID: 3062
		// (Invoke) Token: 0x06003642 RID: 13890
		private delegate void DrawDelegate();

		// Token: 0x02000BF7 RID: 3063
		// (Invoke) Token: 0x06003644 RID: 13892
		private delegate void SetTimeDelegate(float time);
	}
}
