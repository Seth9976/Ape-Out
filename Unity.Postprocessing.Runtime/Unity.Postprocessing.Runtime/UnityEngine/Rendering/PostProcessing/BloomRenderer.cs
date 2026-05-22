using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000014 RID: 20
	public sealed class BloomRenderer : PostProcessEffectRenderer<Bloom>
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00007948 File Offset: 0x00005B48
		// Note: this type is marked as 'beforefieldinit'.
		static BloomRenderer()
		{
			Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "BloomRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr);
			BloomRenderer.NativeFieldInfoPtr_m_Pyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr, "m_Pyramid");
			BloomRenderer.NativeFieldInfoPtr_k_MaxPyramidSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr, "k_MaxPyramidSize");
			BloomRenderer.NativeMethodInfoPtr_Init_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr, 100663331);
			BloomRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr, 100663332);
			BloomRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr, 100663333);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000079DC File Offset: 0x00005BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441930, XrefRangeEnd = 441947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomRenderer.NativeMethodInfoPtr_Init_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007A10 File Offset: 0x00005C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441947, XrefRangeEnd = 442076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00007A54 File Offset: 0x00005C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442076, XrefRangeEnd = 442077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloomRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000026B3 File Offset: 0x000008B3
		public BloomRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00007A90 File Offset: 0x00005C90
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000026BC File Offset: 0x000008BC
		public unsafe Il2CppStructArray<BloomRenderer.Level> m_Pyramid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomRenderer.NativeFieldInfoPtr_m_Pyramid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BloomRenderer.Level>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomRenderer.NativeFieldInfoPtr_m_Pyramid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00007AC0 File Offset: 0x00005CC0
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000026DB File Offset: 0x000008DB
		public unsafe static int k_MaxPyramidSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BloomRenderer.NativeFieldInfoPtr_k_MaxPyramidSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BloomRenderer.NativeFieldInfoPtr_k_MaxPyramidSize, (void*)(&value));
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_m_Pyramid;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxPyramidSize;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000069 RID: 105
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x0400046A RID: 1130
			Prefilter13,
			// Token: 0x0400046B RID: 1131
			Prefilter4,
			// Token: 0x0400046C RID: 1132
			Downsample13,
			// Token: 0x0400046D RID: 1133
			Downsample4,
			// Token: 0x0400046E RID: 1134
			UpsampleTent,
			// Token: 0x0400046F RID: 1135
			UpsampleBox,
			// Token: 0x04000470 RID: 1136
			DebugOverlayThreshold,
			// Token: 0x04000471 RID: 1137
			DebugOverlayTent,
			// Token: 0x04000472 RID: 1138
			DebugOverlayBox
		}

		// Token: 0x0200006A RID: 106
		[StructLayout(2)]
		public struct Level
		{
			// Token: 0x060006CA RID: 1738 RVA: 0x0001A784 File Offset: 0x00018984
			// Note: this type is marked as 'beforefieldinit'.
			static Level()
			{
				Il2CppClassPointerStore<BloomRenderer.Level>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomRenderer>.NativeClassPtr, "Level");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomRenderer.Level>.NativeClassPtr);
				BloomRenderer.Level.NativeFieldInfoPtr_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomRenderer.Level>.NativeClassPtr, "down");
				BloomRenderer.Level.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomRenderer.Level>.NativeClassPtr, "up");
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x0000562C File Offset: 0x0000382C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomRenderer.Level>.NativeClassPtr, ref this));
			}

			// Token: 0x04000473 RID: 1139
			private static readonly IntPtr NativeFieldInfoPtr_down;

			// Token: 0x04000474 RID: 1140
			private static readonly IntPtr NativeFieldInfoPtr_up;

			// Token: 0x04000475 RID: 1141
			[FieldOffset(0)]
			public int down;

			// Token: 0x04000476 RID: 1142
			[FieldOffset(4)]
			public int up;
		}
	}
}
