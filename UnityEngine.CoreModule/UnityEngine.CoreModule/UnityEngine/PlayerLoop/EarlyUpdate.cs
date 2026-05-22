using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000146 RID: 326
	[StructLayout(2)]
	public struct EarlyUpdate
	{
		// Token: 0x0600197C RID: 6524 RVA: 0x0000D594 File Offset: 0x0000B794
		// Note: this type is marked as 'beforefieldinit'.
		static EarlyUpdate()
		{
			Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "EarlyUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0000D5B9 File Offset: 0x0000B7B9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008C3 RID: 2243
		[StructLayout(2)]
		public struct PollPlayerConnection
		{
			// Token: 0x06003003 RID: 12291 RVA: 0x00013E16 File Offset: 0x00012016
			// Note: this type is marked as 'beforefieldinit'.
			static PollPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06003004 RID: 12292 RVA: 0x00013E36 File Offset: 0x00012036
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008C4 RID: 2244
		[StructLayout(2)]
		public struct ProfilerStartFrame
		{
			// Token: 0x06003005 RID: 12293 RVA: 0x00013E48 File Offset: 0x00012048
			// Note: this type is marked as 'beforefieldinit'.
			static ProfilerStartFrame()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProfilerStartFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProfilerStartFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProfilerStartFrame>.NativeClassPtr);
			}

			// Token: 0x06003006 RID: 12294 RVA: 0x00013E68 File Offset: 0x00012068
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProfilerStartFrame>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008C5 RID: 2245
		[StructLayout(2)]
		public struct PollHtcsPlayerConnection
		{
			// Token: 0x06003007 RID: 12295 RVA: 0x00013E7A File Offset: 0x0001207A
			// Note: this type is marked as 'beforefieldinit'.
			static PollHtcsPlayerConnection()
			{
				Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollHtcsPlayerConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr);
			}

			// Token: 0x06003008 RID: 12296 RVA: 0x00013E9A File Offset: 0x0001209A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PollHtcsPlayerConnection>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008C6 RID: 2246
		[StructLayout(2)]
		public struct GpuTimestamp
		{
			// Token: 0x06003009 RID: 12297 RVA: 0x00013EAC File Offset: 0x000120AC
			// Note: this type is marked as 'beforefieldinit'.
			static GpuTimestamp()
			{
				Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "GpuTimestamp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr);
			}

			// Token: 0x0600300A RID: 12298 RVA: 0x00013ECC File Offset: 0x000120CC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.GpuTimestamp>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008C7 RID: 2247
		[StructLayout(2)]
		public struct AnalyticsCoreStatsUpdate
		{
			// Token: 0x0600300B RID: 12299 RVA: 0x00013EDE File Offset: 0x000120DE
			// Note: this type is marked as 'beforefieldinit'.
			static AnalyticsCoreStatsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "AnalyticsCoreStatsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr);
			}

			// Token: 0x0600300C RID: 12300 RVA: 0x00013EFE File Offset: 0x000120FE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.AnalyticsCoreStatsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008C8 RID: 2248
		[StructLayout(2)]
		public struct UnityWebRequestUpdate
		{
			// Token: 0x0600300D RID: 12301 RVA: 0x00013F10 File Offset: 0x00012110
			// Note: this type is marked as 'beforefieldinit'.
			static UnityWebRequestUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UnityWebRequestUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr);
			}

			// Token: 0x0600300E RID: 12302 RVA: 0x00013F30 File Offset: 0x00012130
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UnityWebRequestUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008C9 RID: 2249
		[StructLayout(2)]
		public struct UpdateStreamingManager
		{
			// Token: 0x0600300F RID: 12303 RVA: 0x00013F42 File Offset: 0x00012142
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06003010 RID: 12304 RVA: 0x00013F62 File Offset: 0x00012162
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CA RID: 2250
		[StructLayout(2)]
		public struct ExecuteMainThreadJobs
		{
			// Token: 0x06003011 RID: 12305 RVA: 0x00013F74 File Offset: 0x00012174
			// Note: this type is marked as 'beforefieldinit'.
			static ExecuteMainThreadJobs()
			{
				Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ExecuteMainThreadJobs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr);
			}

			// Token: 0x06003012 RID: 12306 RVA: 0x00013F94 File Offset: 0x00012194
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ExecuteMainThreadJobs>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CB RID: 2251
		[StructLayout(2)]
		public struct ProcessMouseInWindow
		{
			// Token: 0x06003013 RID: 12307 RVA: 0x00013FA6 File Offset: 0x000121A6
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessMouseInWindow()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessMouseInWindow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr);
			}

			// Token: 0x06003014 RID: 12308 RVA: 0x00013FC6 File Offset: 0x000121C6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessMouseInWindow>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CC RID: 2252
		[StructLayout(2)]
		public struct ClearIntermediateRenderers
		{
			// Token: 0x06003015 RID: 12309 RVA: 0x00013FD8 File Offset: 0x000121D8
			// Note: this type is marked as 'beforefieldinit'.
			static ClearIntermediateRenderers()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearIntermediateRenderers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr);
			}

			// Token: 0x06003016 RID: 12310 RVA: 0x00013FF8 File Offset: 0x000121F8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearIntermediateRenderers>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CD RID: 2253
		[StructLayout(2)]
		public struct ClearLines
		{
			// Token: 0x06003017 RID: 12311 RVA: 0x0001400A File Offset: 0x0001220A
			// Note: this type is marked as 'beforefieldinit'.
			static ClearLines()
			{
				Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearLines");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr);
			}

			// Token: 0x06003018 RID: 12312 RVA: 0x0001402A File Offset: 0x0001222A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ClearLines>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CE RID: 2254
		[StructLayout(2)]
		public struct PresentBeforeUpdate
		{
			// Token: 0x06003019 RID: 12313 RVA: 0x0001403C File Offset: 0x0001223C
			// Note: this type is marked as 'beforefieldinit'.
			static PresentBeforeUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PresentBeforeUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr);
			}

			// Token: 0x0600301A RID: 12314 RVA: 0x0001405C File Offset: 0x0001225C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PresentBeforeUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CF RID: 2255
		[StructLayout(2)]
		public struct ResetFrameStatsAfterPresent
		{
			// Token: 0x0600301B RID: 12315 RVA: 0x0001406E File Offset: 0x0001226E
			// Note: this type is marked as 'beforefieldinit'.
			static ResetFrameStatsAfterPresent()
			{
				Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ResetFrameStatsAfterPresent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr);
			}

			// Token: 0x0600301C RID: 12316 RVA: 0x0001408E File Offset: 0x0001228E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ResetFrameStatsAfterPresent>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D0 RID: 2256
		[StructLayout(2)]
		public struct UpdateAsyncReadbackManager
		{
			// Token: 0x0600301D RID: 12317 RVA: 0x000140A0 File Offset: 0x000122A0
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateAsyncReadbackManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncReadbackManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr);
			}

			// Token: 0x0600301E RID: 12318 RVA: 0x000140C0 File Offset: 0x000122C0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateAsyncReadbackManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D1 RID: 2257
		[StructLayout(2)]
		public struct UpdateTextureStreamingManager
		{
			// Token: 0x0600301F RID: 12319 RVA: 0x000140D2 File Offset: 0x000122D2
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateTextureStreamingManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateTextureStreamingManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr);
			}

			// Token: 0x06003020 RID: 12320 RVA: 0x000140F2 File Offset: 0x000122F2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateTextureStreamingManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D2 RID: 2258
		[StructLayout(2)]
		public struct UpdatePreloading
		{
			// Token: 0x06003021 RID: 12321 RVA: 0x00014104 File Offset: 0x00012304
			// Note: this type is marked as 'beforefieldinit'.
			static UpdatePreloading()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdatePreloading");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr);
			}

			// Token: 0x06003022 RID: 12322 RVA: 0x00014124 File Offset: 0x00012324
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdatePreloading>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D3 RID: 2259
		[StructLayout(2)]
		public struct RendererNotifyInvisible
		{
			// Token: 0x06003023 RID: 12323 RVA: 0x00014136 File Offset: 0x00012336
			// Note: this type is marked as 'beforefieldinit'.
			static RendererNotifyInvisible()
			{
				Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "RendererNotifyInvisible");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr);
			}

			// Token: 0x06003024 RID: 12324 RVA: 0x00014156 File Offset: 0x00012356
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.RendererNotifyInvisible>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D4 RID: 2260
		[StructLayout(2)]
		public struct PlayerCleanupCachedData
		{
			// Token: 0x06003025 RID: 12325 RVA: 0x00014168 File Offset: 0x00012368
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerCleanupCachedData()
			{
				Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PlayerCleanupCachedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr);
			}

			// Token: 0x06003026 RID: 12326 RVA: 0x00014188 File Offset: 0x00012388
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PlayerCleanupCachedData>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D5 RID: 2261
		[StructLayout(2)]
		public struct UpdateMainGameViewRect
		{
			// Token: 0x06003027 RID: 12327 RVA: 0x0001419A File Offset: 0x0001239A
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMainGameViewRect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateMainGameViewRect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr);
			}

			// Token: 0x06003028 RID: 12328 RVA: 0x000141BA File Offset: 0x000123BA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateMainGameViewRect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D6 RID: 2262
		[StructLayout(2)]
		public struct UpdateCanvasRectTransform
		{
			// Token: 0x06003029 RID: 12329 RVA: 0x000141CC File Offset: 0x000123CC
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateCanvasRectTransform()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateCanvasRectTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr);
			}

			// Token: 0x0600302A RID: 12330 RVA: 0x000141EC File Offset: 0x000123EC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateCanvasRectTransform>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D7 RID: 2263
		[StructLayout(2)]
		public struct UpdateInputManager
		{
			// Token: 0x0600302B RID: 12331 RVA: 0x000141FE File Offset: 0x000123FE
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateInputManager()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateInputManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr);
			}

			// Token: 0x0600302C RID: 12332 RVA: 0x0001421E File Offset: 0x0001241E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateInputManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D8 RID: 2264
		[StructLayout(2)]
		public struct ProcessRemoteInput
		{
			// Token: 0x0600302D RID: 12333 RVA: 0x00014230 File Offset: 0x00012430
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessRemoteInput()
			{
				Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessRemoteInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr);
			}

			// Token: 0x0600302E RID: 12334 RVA: 0x00014250 File Offset: 0x00012450
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ProcessRemoteInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D9 RID: 2265
		[StructLayout(2)]
		public struct XRUpdate
		{
			// Token: 0x0600302F RID: 12335 RVA: 0x00014262 File Offset: 0x00012462
			// Note: this type is marked as 'beforefieldinit'.
			static XRUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "XRUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr);
			}

			// Token: 0x06003030 RID: 12336 RVA: 0x00014282 File Offset: 0x00012482
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.XRUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DA RID: 2266
		[StructLayout(2)]
		public struct ScriptRunDelayedStartupFrame
		{
			// Token: 0x06003031 RID: 12337 RVA: 0x00014294 File Offset: 0x00012494
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedStartupFrame()
			{
				Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ScriptRunDelayedStartupFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr);
			}

			// Token: 0x06003032 RID: 12338 RVA: 0x000142B4 File Offset: 0x000124B4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ScriptRunDelayedStartupFrame>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DB RID: 2267
		[StructLayout(2)]
		public struct UpdateKinect
		{
			// Token: 0x06003033 RID: 12339 RVA: 0x000142C6 File Offset: 0x000124C6
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateKinect()
			{
				Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateKinect");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr);
			}

			// Token: 0x06003034 RID: 12340 RVA: 0x000142E6 File Offset: 0x000124E6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.UpdateKinect>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DC RID: 2268
		[StructLayout(2)]
		public struct DeliverIosPlatformEvents
		{
			// Token: 0x06003035 RID: 12341 RVA: 0x000142F8 File Offset: 0x000124F8
			// Note: this type is marked as 'beforefieldinit'.
			static DeliverIosPlatformEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DeliverIosPlatformEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr);
			}

			// Token: 0x06003036 RID: 12342 RVA: 0x00014318 File Offset: 0x00012518
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DeliverIosPlatformEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DD RID: 2269
		[StructLayout(2)]
		public struct DispatchEventQueueEvents
		{
			// Token: 0x06003037 RID: 12343 RVA: 0x0001432A File Offset: 0x0001252A
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchEventQueueEvents()
			{
				Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DispatchEventQueueEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr);
			}

			// Token: 0x06003038 RID: 12344 RVA: 0x0001434A File Offset: 0x0001254A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.DispatchEventQueueEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DE RID: 2270
		[StructLayout(2)]
		public struct PhysicsResetInterpolatedTransformPosition
		{
			// Token: 0x06003039 RID: 12345 RVA: 0x0001435C File Offset: 0x0001255C
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsResetInterpolatedTransformPosition()
			{
				Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PhysicsResetInterpolatedTransformPosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr);
			}

			// Token: 0x0600303A RID: 12346 RVA: 0x0001437C File Offset: 0x0001257C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PhysicsResetInterpolatedTransformPosition>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DF RID: 2271
		[StructLayout(2)]
		public struct SpriteAtlasManagerUpdate
		{
			// Token: 0x0600303B RID: 12347 RVA: 0x0001438E File Offset: 0x0001258E
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteAtlasManagerUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "SpriteAtlasManagerUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr);
			}

			// Token: 0x0600303C RID: 12348 RVA: 0x000143AE File Offset: 0x000125AE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.SpriteAtlasManagerUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E0 RID: 2272
		[StructLayout(2)]
		public struct TangoUpdate
		{
			// Token: 0x0600303D RID: 12349 RVA: 0x000143C0 File Offset: 0x000125C0
			// Note: this type is marked as 'beforefieldinit'.
			static TangoUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "TangoUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr);
			}

			// Token: 0x0600303E RID: 12350 RVA: 0x000143E0 File Offset: 0x000125E0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.TangoUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E1 RID: 2273
		[StructLayout(2)]
		public struct ARCoreUpdate
		{
			// Token: 0x0600303F RID: 12351 RVA: 0x000143F2 File Offset: 0x000125F2
			// Note: this type is marked as 'beforefieldinit'.
			static ARCoreUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ARCoreUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr);
			}

			// Token: 0x06003040 RID: 12352 RVA: 0x00014412 File Offset: 0x00012612
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.ARCoreUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E2 RID: 2274
		[StructLayout(2)]
		public struct PerformanceAnalyticsUpdate
		{
			// Token: 0x06003041 RID: 12353 RVA: 0x00014424 File Offset: 0x00012624
			// Note: this type is marked as 'beforefieldinit'.
			static PerformanceAnalyticsUpdate()
			{
				Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PerformanceAnalyticsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003042 RID: 12354 RVA: 0x00014444 File Offset: 0x00012644
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate.PerformanceAnalyticsUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
