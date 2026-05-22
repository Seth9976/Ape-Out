using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x020001B2 RID: 434
	public static class GIDebugVisualisation
	{
		// Token: 0x06001F9D RID: 8093 RVA: 0x000105E3 File Offset: 0x0000E7E3
		public static void ResetRuntimeInputTextures()
		{
			GIDebugVisualisation.ResetRuntimeInputTexturesDelegateField();
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000105EF File Offset: 0x0000E7EF
		public static void PlayCycleMode()
		{
			GIDebugVisualisation.PlayCycleModeDelegateField();
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x000105FB File Offset: 0x0000E7FB
		public static void PauseCycleMode()
		{
			GIDebugVisualisation.PauseCycleModeDelegateField();
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00010607 File Offset: 0x0000E807
		public static void StopCycleMode()
		{
			GIDebugVisualisation.StopCycleModeDelegateField();
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00010613 File Offset: 0x0000E813
		public static void CycleSkipSystems(int skip)
		{
			GIDebugVisualisation.CycleSkipSystemsDelegateField(skip);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00010620 File Offset: 0x0000E820
		public static void CycleSkipInstances(int skip)
		{
			GIDebugVisualisation.CycleSkipInstancesDelegateField(skip);
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0001062D File Offset: 0x0000E82D
		public static bool cycleMode
		{
			get
			{
				return GIDebugVisualisation.get_cycleModeDelegateField();
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x00010639 File Offset: 0x0000E839
		public static bool pauseCycleMode
		{
			get
			{
				return GIDebugVisualisation.get_pauseCycleModeDelegateField();
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x00010645 File Offset: 0x0000E845
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00010651 File Offset: 0x0000E851
		public static GITextureType texType
		{
			get
			{
				return GIDebugVisualisation.get_texTypeDelegateField();
			}
			set
			{
				GIDebugVisualisation.set_texTypeDelegateField(value);
			}
		}

		// Token: 0x04001997 RID: 6551
		private static readonly GIDebugVisualisation.ResetRuntimeInputTexturesDelegate ResetRuntimeInputTexturesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.ResetRuntimeInputTexturesDelegate>("UnityEngineInternal.GIDebugVisualisation::ResetRuntimeInputTextures");

		// Token: 0x04001998 RID: 6552
		private static readonly GIDebugVisualisation.PlayCycleModeDelegate PlayCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PlayCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PlayCycleMode");

		// Token: 0x04001999 RID: 6553
		private static readonly GIDebugVisualisation.PauseCycleModeDelegate PauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PauseCycleMode");

		// Token: 0x0400199A RID: 6554
		private static readonly GIDebugVisualisation.StopCycleModeDelegate StopCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.StopCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::StopCycleMode");

		// Token: 0x0400199B RID: 6555
		private static readonly GIDebugVisualisation.CycleSkipSystemsDelegate CycleSkipSystemsDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipSystemsDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipSystems");

		// Token: 0x0400199C RID: 6556
		private static readonly GIDebugVisualisation.CycleSkipInstancesDelegate CycleSkipInstancesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipInstancesDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipInstances");

		// Token: 0x0400199D RID: 6557
		private static readonly GIDebugVisualisation.get_cycleModeDelegate get_cycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_cycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_cycleMode");

		// Token: 0x0400199E RID: 6558
		private static readonly GIDebugVisualisation.get_pauseCycleModeDelegate get_pauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_pauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_pauseCycleMode");

		// Token: 0x0400199F RID: 6559
		private static readonly GIDebugVisualisation.get_texTypeDelegate get_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_texType");

		// Token: 0x040019A0 RID: 6560
		private static readonly GIDebugVisualisation.set_texTypeDelegate set_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.set_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::set_texType");

		// Token: 0x02000A83 RID: 2691
		// (Invoke) Token: 0x06003386 RID: 13190
		private delegate void ResetRuntimeInputTexturesDelegate();

		// Token: 0x02000A84 RID: 2692
		// (Invoke) Token: 0x06003388 RID: 13192
		private delegate void PlayCycleModeDelegate();

		// Token: 0x02000A85 RID: 2693
		// (Invoke) Token: 0x0600338A RID: 13194
		private delegate void PauseCycleModeDelegate();

		// Token: 0x02000A86 RID: 2694
		// (Invoke) Token: 0x0600338C RID: 13196
		private delegate void StopCycleModeDelegate();

		// Token: 0x02000A87 RID: 2695
		// (Invoke) Token: 0x0600338E RID: 13198
		private delegate void CycleSkipSystemsDelegate(int skip);

		// Token: 0x02000A88 RID: 2696
		// (Invoke) Token: 0x06003390 RID: 13200
		private delegate void CycleSkipInstancesDelegate(int skip);

		// Token: 0x02000A89 RID: 2697
		// (Invoke) Token: 0x06003392 RID: 13202
		private delegate bool get_cycleModeDelegate();

		// Token: 0x02000A8A RID: 2698
		// (Invoke) Token: 0x06003394 RID: 13204
		private delegate bool get_pauseCycleModeDelegate();

		// Token: 0x02000A8B RID: 2699
		// (Invoke) Token: 0x06003396 RID: 13206
		private delegate GITextureType get_texTypeDelegate();

		// Token: 0x02000A8C RID: 2700
		// (Invoke) Token: 0x06003398 RID: 13208
		private delegate void set_texTypeDelegate(GITextureType value);
	}
}
