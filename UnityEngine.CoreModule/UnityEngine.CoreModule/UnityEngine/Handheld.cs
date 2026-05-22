using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200023E RID: 574
	public class Handheld
	{
		// Token: 0x06002181 RID: 8577 RVA: 0x0007627C File Offset: 0x0007447C
		public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return Handheld.PlayFullScreenMovie_Bindings(path, bgColor, controlMode, scalingMode);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00076298 File Offset: 0x00074498
		public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode)
		{
			FullScreenMovieScalingMode fullScreenMovieScalingMode = FullScreenMovieScalingMode.AspectFit;
			return Handheld.PlayFullScreenMovie_Bindings(path, bgColor, controlMode, fullScreenMovieScalingMode);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000762B8 File Offset: 0x000744B8
		public static bool PlayFullScreenMovie(string path, Color bgColor)
		{
			FullScreenMovieScalingMode fullScreenMovieScalingMode = FullScreenMovieScalingMode.AspectFit;
			FullScreenMovieControlMode fullScreenMovieControlMode = FullScreenMovieControlMode.Full;
			return Handheld.PlayFullScreenMovie_Bindings(path, bgColor, fullScreenMovieControlMode, fullScreenMovieScalingMode);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000762D8 File Offset: 0x000744D8
		public static bool PlayFullScreenMovie(string path)
		{
			FullScreenMovieScalingMode fullScreenMovieScalingMode = FullScreenMovieScalingMode.AspectFit;
			FullScreenMovieControlMode fullScreenMovieControlMode = FullScreenMovieControlMode.Full;
			Color black = Color.black;
			return Handheld.PlayFullScreenMovie_Bindings(path, black, fullScreenMovieControlMode, fullScreenMovieScalingMode);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00011C78 File Offset: 0x0000FE78
		public static bool PlayFullScreenMovie_Bindings(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return Handheld.PlayFullScreenMovie_Bindings_Injected(path, ref bgColor, controlMode, scalingMode);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00011C84 File Offset: 0x0000FE84
		public static void Vibrate()
		{
			Handheld.VibrateDelegateField();
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x00076300 File Offset: 0x00074500
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00011C90 File Offset: 0x0000FE90
		public static bool use32BitDisplayBuffer
		{
			get
			{
				return Handheld.GetUse32BitDisplayBuffer_Bindings();
			}
			set
			{
			}
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00011C93 File Offset: 0x0000FE93
		public static bool GetUse32BitDisplayBuffer_Bindings()
		{
			return Handheld.GetUse32BitDisplayBuffer_BindingsDelegateField();
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00011C9F File Offset: 0x0000FE9F
		public static void SetActivityIndicatorStyleImpl_Bindings(int style)
		{
			Handheld.SetActivityIndicatorStyleImpl_BindingsDelegateField(style);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00011CAC File Offset: 0x0000FEAC
		public static void SetActivityIndicatorStyle(AndroidActivityIndicatorStyle style)
		{
			Handheld.SetActivityIndicatorStyleImpl_Bindings((int)style);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00011CB6 File Offset: 0x0000FEB6
		public static int GetActivityIndicatorStyle()
		{
			return Handheld.GetActivityIndicatorStyleDelegateField();
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00011CC2 File Offset: 0x0000FEC2
		public static void StartActivityIndicator()
		{
			Handheld.StartActivityIndicatorDelegateField();
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00011CCE File Offset: 0x0000FECE
		public static void StopActivityIndicator()
		{
			Handheld.StopActivityIndicatorDelegateField();
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00011CDA File Offset: 0x0000FEDA
		public static void ClearShaderCache()
		{
			Handheld.ClearShaderCacheDelegateField();
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00011CE6 File Offset: 0x0000FEE6
		public static bool PlayFullScreenMovie_Bindings_Injected(string path, ref Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return Handheld.PlayFullScreenMovie_Bindings_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(path), ref bgColor, controlMode, scalingMode);
		}

		// Token: 0x04001BAF RID: 7087
		private static readonly Handheld.VibrateDelegate VibrateDelegateField = IL2CPP.ResolveICall<Handheld.VibrateDelegate>("UnityEngine.Handheld::Vibrate");

		// Token: 0x04001BB0 RID: 7088
		private static readonly Handheld.GetUse32BitDisplayBuffer_BindingsDelegate GetUse32BitDisplayBuffer_BindingsDelegateField = IL2CPP.ResolveICall<Handheld.GetUse32BitDisplayBuffer_BindingsDelegate>("UnityEngine.Handheld::GetUse32BitDisplayBuffer_Bindings");

		// Token: 0x04001BB1 RID: 7089
		private static readonly Handheld.SetActivityIndicatorStyleImpl_BindingsDelegate SetActivityIndicatorStyleImpl_BindingsDelegateField = IL2CPP.ResolveICall<Handheld.SetActivityIndicatorStyleImpl_BindingsDelegate>("UnityEngine.Handheld::SetActivityIndicatorStyleImpl_Bindings");

		// Token: 0x04001BB2 RID: 7090
		private static readonly Handheld.GetActivityIndicatorStyleDelegate GetActivityIndicatorStyleDelegateField = IL2CPP.ResolveICall<Handheld.GetActivityIndicatorStyleDelegate>("UnityEngine.Handheld::GetActivityIndicatorStyle");

		// Token: 0x04001BB3 RID: 7091
		private static readonly Handheld.StartActivityIndicatorDelegate StartActivityIndicatorDelegateField = IL2CPP.ResolveICall<Handheld.StartActivityIndicatorDelegate>("UnityEngine.Handheld::StartActivityIndicator");

		// Token: 0x04001BB4 RID: 7092
		private static readonly Handheld.StopActivityIndicatorDelegate StopActivityIndicatorDelegateField = IL2CPP.ResolveICall<Handheld.StopActivityIndicatorDelegate>("UnityEngine.Handheld::StopActivityIndicator");

		// Token: 0x04001BB5 RID: 7093
		private static readonly Handheld.ClearShaderCacheDelegate ClearShaderCacheDelegateField = IL2CPP.ResolveICall<Handheld.ClearShaderCacheDelegate>("UnityEngine.Handheld::ClearShaderCache");

		// Token: 0x04001BB6 RID: 7094
		private static readonly Handheld.PlayFullScreenMovie_Bindings_InjectedDelegate PlayFullScreenMovie_Bindings_InjectedDelegateField = IL2CPP.ResolveICall<Handheld.PlayFullScreenMovie_Bindings_InjectedDelegate>("UnityEngine.Handheld::PlayFullScreenMovie_Bindings_Injected");

		// Token: 0x02000B77 RID: 2935
		// (Invoke) Token: 0x0600354E RID: 13646
		private delegate void VibrateDelegate();

		// Token: 0x02000B78 RID: 2936
		// (Invoke) Token: 0x06003550 RID: 13648
		private delegate bool GetUse32BitDisplayBuffer_BindingsDelegate();

		// Token: 0x02000B79 RID: 2937
		// (Invoke) Token: 0x06003552 RID: 13650
		private delegate void SetActivityIndicatorStyleImpl_BindingsDelegate(int style);

		// Token: 0x02000B7A RID: 2938
		// (Invoke) Token: 0x06003554 RID: 13652
		private delegate int GetActivityIndicatorStyleDelegate();

		// Token: 0x02000B7B RID: 2939
		// (Invoke) Token: 0x06003556 RID: 13654
		private delegate void StartActivityIndicatorDelegate();

		// Token: 0x02000B7C RID: 2940
		// (Invoke) Token: 0x06003558 RID: 13656
		private delegate void StopActivityIndicatorDelegate();

		// Token: 0x02000B7D RID: 2941
		// (Invoke) Token: 0x0600355A RID: 13658
		private delegate void ClearShaderCacheDelegate();

		// Token: 0x02000B7E RID: 2942
		// (Invoke) Token: 0x0600355C RID: 13660
		private delegate bool PlayFullScreenMovie_Bindings_InjectedDelegate(IntPtr path, IntPtr bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode);
	}
}
