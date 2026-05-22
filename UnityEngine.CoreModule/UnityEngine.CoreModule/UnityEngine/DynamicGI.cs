using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x02000200 RID: 512
	public sealed class DynamicGI
	{
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x00010CA8 File Offset: 0x0000EEA8
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		public static float indirectScale
		{
			get
			{
				return DynamicGI.get_indirectScaleDelegateField();
			}
			set
			{
				DynamicGI.set_indirectScaleDelegateField(value);
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x00010CC1 File Offset: 0x0000EEC1
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x00010CCD File Offset: 0x0000EECD
		public static float updateThreshold
		{
			get
			{
				return DynamicGI.get_updateThresholdDelegateField();
			}
			set
			{
				DynamicGI.set_updateThresholdDelegateField(value);
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x00010CDA File Offset: 0x0000EEDA
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x00010CE6 File Offset: 0x0000EEE6
		public static int materialUpdateTimeSlice
		{
			get
			{
				return DynamicGI.get_materialUpdateTimeSliceDelegateField();
			}
			set
			{
				DynamicGI.set_materialUpdateTimeSliceDelegateField(value);
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00010CF3 File Offset: 0x0000EEF3
		public static void SetEmissive(Renderer renderer, Color color)
		{
			DynamicGI.SetEmissive_Injected(renderer, ref color);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00010CFD File Offset: 0x0000EEFD
		public static void SetEnvironmentData(Il2CppStructArray<float> input)
		{
			DynamicGI.SetEnvironmentDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(input));
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x00010D0F File Offset: 0x0000EF0F
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00010D1B File Offset: 0x0000EF1B
		public static bool synchronousMode
		{
			get
			{
				return DynamicGI.get_synchronousModeDelegateField();
			}
			set
			{
				DynamicGI.set_synchronousModeDelegateField(value);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00010D28 File Offset: 0x0000EF28
		public static bool isConverged
		{
			get
			{
				return DynamicGI.get_isConvergedDelegateField();
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00010D34 File Offset: 0x0000EF34
		public static int scheduledMaterialUpdatesCount
		{
			get
			{
				return DynamicGI.get_scheduledMaterialUpdatesCountDelegateField();
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x00010D40 File Offset: 0x0000EF40
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x00010D4C File Offset: 0x0000EF4C
		public static bool asyncMaterialUpdates
		{
			get
			{
				return DynamicGI.get_asyncMaterialUpdatesDelegateField();
			}
			set
			{
				DynamicGI.set_asyncMaterialUpdatesDelegateField(value);
			}
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00010D59 File Offset: 0x0000EF59
		public static void UpdateEnvironment()
		{
			DynamicGI.UpdateEnvironmentDelegateField();
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00010D65 File Offset: 0x0000EF65
		public static void UpdateMaterials(Renderer renderer)
		{
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00010D68 File Offset: 0x0000EF68
		public static void UpdateMaterials(Object renderer)
		{
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00010D6B File Offset: 0x0000EF6B
		public static void UpdateMaterials(Object renderer, int x, int y, int width, int height)
		{
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00010D6E File Offset: 0x0000EF6E
		public static void SetEmissive_Injected(Renderer renderer, ref Color color)
		{
			DynamicGI.SetEmissive_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref color);
		}

		// Token: 0x04001A74 RID: 6772
		private static readonly DynamicGI.get_indirectScaleDelegate get_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.get_indirectScaleDelegate>("UnityEngine.DynamicGI::get_indirectScale");

		// Token: 0x04001A75 RID: 6773
		private static readonly DynamicGI.set_indirectScaleDelegate set_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.set_indirectScaleDelegate>("UnityEngine.DynamicGI::set_indirectScale");

		// Token: 0x04001A76 RID: 6774
		private static readonly DynamicGI.get_updateThresholdDelegate get_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.get_updateThresholdDelegate>("UnityEngine.DynamicGI::get_updateThreshold");

		// Token: 0x04001A77 RID: 6775
		private static readonly DynamicGI.set_updateThresholdDelegate set_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.set_updateThresholdDelegate>("UnityEngine.DynamicGI::set_updateThreshold");

		// Token: 0x04001A78 RID: 6776
		private static readonly DynamicGI.get_materialUpdateTimeSliceDelegate get_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.get_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::get_materialUpdateTimeSlice");

		// Token: 0x04001A79 RID: 6777
		private static readonly DynamicGI.set_materialUpdateTimeSliceDelegate set_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.set_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::set_materialUpdateTimeSlice");

		// Token: 0x04001A7A RID: 6778
		private static readonly DynamicGI.SetEnvironmentDataDelegate SetEnvironmentDataDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEnvironmentDataDelegate>("UnityEngine.DynamicGI::SetEnvironmentData");

		// Token: 0x04001A7B RID: 6779
		private static readonly DynamicGI.get_synchronousModeDelegate get_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.get_synchronousModeDelegate>("UnityEngine.DynamicGI::get_synchronousMode");

		// Token: 0x04001A7C RID: 6780
		private static readonly DynamicGI.set_synchronousModeDelegate set_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.set_synchronousModeDelegate>("UnityEngine.DynamicGI::set_synchronousMode");

		// Token: 0x04001A7D RID: 6781
		private static readonly DynamicGI.get_isConvergedDelegate get_isConvergedDelegateField = IL2CPP.ResolveICall<DynamicGI.get_isConvergedDelegate>("UnityEngine.DynamicGI::get_isConverged");

		// Token: 0x04001A7E RID: 6782
		private static readonly DynamicGI.get_scheduledMaterialUpdatesCountDelegate get_scheduledMaterialUpdatesCountDelegateField = IL2CPP.ResolveICall<DynamicGI.get_scheduledMaterialUpdatesCountDelegate>("UnityEngine.DynamicGI::get_scheduledMaterialUpdatesCount");

		// Token: 0x04001A7F RID: 6783
		private static readonly DynamicGI.get_asyncMaterialUpdatesDelegate get_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.get_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::get_asyncMaterialUpdates");

		// Token: 0x04001A80 RID: 6784
		private static readonly DynamicGI.set_asyncMaterialUpdatesDelegate set_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.set_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::set_asyncMaterialUpdates");

		// Token: 0x04001A81 RID: 6785
		private static readonly DynamicGI.UpdateEnvironmentDelegate UpdateEnvironmentDelegateField = IL2CPP.ResolveICall<DynamicGI.UpdateEnvironmentDelegate>("UnityEngine.DynamicGI::UpdateEnvironment");

		// Token: 0x04001A82 RID: 6786
		private static readonly DynamicGI.SetEmissive_InjectedDelegate SetEmissive_InjectedDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEmissive_InjectedDelegate>("UnityEngine.DynamicGI::SetEmissive_Injected");

		// Token: 0x02000AD4 RID: 2772
		// (Invoke) Token: 0x0600340C RID: 13324
		private delegate float get_indirectScaleDelegate();

		// Token: 0x02000AD5 RID: 2773
		// (Invoke) Token: 0x0600340E RID: 13326
		private delegate void set_indirectScaleDelegate(float value);

		// Token: 0x02000AD6 RID: 2774
		// (Invoke) Token: 0x06003410 RID: 13328
		private delegate float get_updateThresholdDelegate();

		// Token: 0x02000AD7 RID: 2775
		// (Invoke) Token: 0x06003412 RID: 13330
		private delegate void set_updateThresholdDelegate(float value);

		// Token: 0x02000AD8 RID: 2776
		// (Invoke) Token: 0x06003414 RID: 13332
		private delegate int get_materialUpdateTimeSliceDelegate();

		// Token: 0x02000AD9 RID: 2777
		// (Invoke) Token: 0x06003416 RID: 13334
		private delegate void set_materialUpdateTimeSliceDelegate(int value);

		// Token: 0x02000ADA RID: 2778
		// (Invoke) Token: 0x06003418 RID: 13336
		private delegate void SetEnvironmentDataDelegate(IntPtr input);

		// Token: 0x02000ADB RID: 2779
		// (Invoke) Token: 0x0600341A RID: 13338
		private delegate bool get_synchronousModeDelegate();

		// Token: 0x02000ADC RID: 2780
		// (Invoke) Token: 0x0600341C RID: 13340
		private delegate void set_synchronousModeDelegate(bool value);

		// Token: 0x02000ADD RID: 2781
		// (Invoke) Token: 0x0600341E RID: 13342
		private delegate bool get_isConvergedDelegate();

		// Token: 0x02000ADE RID: 2782
		// (Invoke) Token: 0x06003420 RID: 13344
		private delegate int get_scheduledMaterialUpdatesCountDelegate();

		// Token: 0x02000ADF RID: 2783
		// (Invoke) Token: 0x06003422 RID: 13346
		private delegate bool get_asyncMaterialUpdatesDelegate();

		// Token: 0x02000AE0 RID: 2784
		// (Invoke) Token: 0x06003424 RID: 13348
		private delegate void set_asyncMaterialUpdatesDelegate(bool value);

		// Token: 0x02000AE1 RID: 2785
		// (Invoke) Token: 0x06003426 RID: 13350
		private delegate void UpdateEnvironmentDelegate();

		// Token: 0x02000AE2 RID: 2786
		// (Invoke) Token: 0x06003428 RID: 13352
		private delegate void SetEmissive_InjectedDelegate(IntPtr renderer, IntPtr color);
	}
}
