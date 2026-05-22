using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200016C RID: 364
	public class OnDemandRendering : Object
	{
		// Token: 0x06001A19 RID: 6681 RVA: 0x00063980 File Offset: 0x00061B80
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandRendering()
		{
			Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "OnDemandRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr);
			OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, "m_RenderFrameInterval");
			OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100665723);
			OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100665724);
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000639EC File Offset: 0x00061BEC
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x0000DA7D File Offset: 0x0000BC7D
		public unsafe static int renderFrameInterval
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502541, XrefRangeEnd = 502545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				OnDemandRendering.m_RenderFrameInterval = Math.Max(1, value);
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00063A1C File Offset: 0x00061C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502545, XrefRangeEnd = 502553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderFrameInterval(out int frameInterval)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &frameInterval;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0000DA66 File Offset: 0x0000BC66
		public OnDemandRendering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00063A50 File Offset: 0x00061C50
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x0000DA6F File Offset: 0x0000BC6F
		public unsafe static int m_RenderFrameInterval
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00063A6C File Offset: 0x00061C6C
		public static bool willCurrentFrameRender
		{
			get
			{
				return Time.frameCount % OnDemandRendering.renderFrameInterval == 0;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00063A8C File Offset: 0x00061C8C
		public static int effectiveRenderFrameRate
		{
			get
			{
				bool flag = QualitySettings.vSyncCount > 0;
				int num;
				if (flag)
				{
					num = Screen.currentResolution.refreshRate / QualitySettings.vSyncCount / OnDemandRendering.renderFrameInterval;
				}
				else
				{
					bool flag2 = Application.targetFrameRate <= 0;
					if (flag2)
					{
						num = 30 / OnDemandRendering.renderFrameInterval;
					}
					else
					{
						num = Application.targetFrameRate / OnDemandRendering.renderFrameInterval;
					}
				}
				return num;
			}
		}

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderFrameInterval;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0;
	}
}
