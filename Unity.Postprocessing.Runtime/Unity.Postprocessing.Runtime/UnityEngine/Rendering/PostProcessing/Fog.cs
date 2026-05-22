using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000023 RID: 35
	[Serializable]
	public sealed class Fog : Object
	{
		// Token: 0x0600015B RID: 347 RVA: 0x0000980C File Offset: 0x00007A0C
		// Note: this type is marked as 'beforefieldinit'.
		static Fog()
		{
			Il2CppClassPointerStore<Fog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Fog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fog>.NativeClassPtr);
			Fog.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fog>.NativeClassPtr, "enabled");
			Fog.NativeFieldInfoPtr_excludeSkybox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fog>.NativeClassPtr, "excludeSkybox");
			Fog.NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fog>.NativeClassPtr, 100663369);
			Fog.NativeMethodInfoPtr_IsEnabledAndSupported_Internal_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fog>.NativeClassPtr, 100663370);
			Fog.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fog>.NativeClassPtr, 100663371);
			Fog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fog>.NativeClassPtr, 100663372);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000098B4 File Offset: 0x00007AB4
		[CallerCount(0)]
		public unsafe DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fog.NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000098F0 File Offset: 0x00007AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 443325, RefRangeEnd = 443327, XrefRangeStart = 443313, XrefRangeEnd = 443325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fog.NativeMethodInfoPtr_IsEnabledAndSupported_Internal_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00009940 File Offset: 0x00007B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 443362, RefRangeEnd = 443363, XrefRangeStart = 443327, XrefRangeEnd = 443362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fog.NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00009984 File Offset: 0x00007B84
		[CallerCount(0)]
		public unsafe Fog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002F37 File Offset: 0x00001137
		public Fog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000099C0 File Offset: 0x00007BC0
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002F40 File Offset: 0x00001140
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fog.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fog.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000099E8 File Offset: 0x00007BE8
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002F5B File Offset: 0x0000115B
		public unsafe bool excludeSkybox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fog.NativeFieldInfoPtr_excludeSkybox);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fog.NativeFieldInfoPtr_excludeSkybox)) = value;
			}
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_excludeSkybox;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Internal_DepthTextureMode_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Internal_Boolean_PostProcessRenderContext_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Void_PostProcessRenderContext_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
