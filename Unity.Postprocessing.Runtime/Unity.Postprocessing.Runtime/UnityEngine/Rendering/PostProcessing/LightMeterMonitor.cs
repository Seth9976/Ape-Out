using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	public sealed class LightMeterMonitor : Monitor
	{
		// Token: 0x0600026E RID: 622 RVA: 0x0000CE04 File Offset: 0x0000B004
		// Note: this type is marked as 'beforefieldinit'.
		static LightMeterMonitor()
		{
			Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "LightMeterMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr);
			LightMeterMonitor.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr, "width");
			LightMeterMonitor.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr, "height");
			LightMeterMonitor.NativeFieldInfoPtr_showCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr, "showCurves");
			LightMeterMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr, 100663459);
			LightMeterMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr, 100663460);
			LightMeterMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr, 100663461);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445336, XrefRangeEnd = 445340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightMeterMonitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445340, XrefRangeEnd = 445428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightMeterMonitor.NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000CF40 File Offset: 0x0000B140
		[CallerCount(0)]
		public unsafe LightMeterMonitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightMeterMonitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightMeterMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000038D4 File Offset: 0x00001AD4
		public LightMeterMonitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000CF7C File Offset: 0x0000B17C
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000038DD File Offset: 0x00001ADD
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMeterMonitor.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMeterMonitor.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000038F8 File Offset: 0x00001AF8
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMeterMonitor.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMeterMonitor.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003913 File Offset: 0x00001B13
		public unsafe bool showCurves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMeterMonitor.NativeFieldInfoPtr_showCurves);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightMeterMonitor.NativeFieldInfoPtr_showCurves)) = value;
			}
		}

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_showCurves;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
