using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200003B RID: 59
	public class Monitor : Object
	{
		// Token: 0x06000279 RID: 633 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		// Note: this type is marked as 'beforefieldinit'.
		static Monitor()
		{
			Il2CppClassPointerStore<Monitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Monitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Monitor>.NativeClassPtr);
			Monitor.NativeFieldInfoPtr__output_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Monitor>.NativeClassPtr, "<output>k__BackingField");
			Monitor.NativeFieldInfoPtr_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Monitor>.NativeClassPtr, "requested");
			Monitor.NativeMethodInfoPtr_get_output_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663462);
			Monitor.NativeMethodInfoPtr_set_output_Protected_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663463);
			Monitor.NativeMethodInfoPtr_IsRequestedAndSupported_Public_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663464);
			Monitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Abstract_Virtual_New_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663465);
			Monitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663466);
			Monitor.NativeMethodInfoPtr_CheckOutput_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663467);
			Monitor.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663468);
			Monitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663469);
			Monitor.NativeMethodInfoPtr_Render_Internal_Abstract_Virtual_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663470);
			Monitor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Monitor>.NativeClassPtr, 100663471);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000D114 File Offset: 0x0000B314
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0000D154 File Offset: 0x0000B354
		public unsafe RenderTexture output
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_get_output_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_set_output_Protected_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000D198 File Offset: 0x0000B398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 445434, RefRangeEnd = 445437, XrefRangeStart = 445428, XrefRangeEnd = 445434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRequestedAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_IsRequestedAndSupported_Public_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[CallerCount(0)]
		public unsafe virtual bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Monitor.NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Abstract_Virtual_New_Boolean_PostProcessRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000D240 File Offset: 0x0000B440
		[CallerCount(0)]
		public unsafe virtual bool NeedsHalfRes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Monitor.NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000D288 File Offset: 0x0000B488
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 445468, RefRangeEnd = 445472, XrefRangeStart = 445437, XrefRangeEnd = 445468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckOutput(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr_CheckOutput_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Monitor.NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000D310 File Offset: 0x0000B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445472, XrefRangeEnd = 445476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Monitor.NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000D34C File Offset: 0x0000B54C
		[CallerCount(0)]
		public unsafe virtual void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Monitor.NativeMethodInfoPtr_Render_Internal_Abstract_Virtual_New_Void_PostProcessRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000D39C File Offset: 0x0000B59C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Monitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Monitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Monitor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000392E File Offset: 0x00001B2E
		public Monitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003937 File Offset: 0x00001B37
		public unsafe RenderTexture _output_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Monitor.NativeFieldInfoPtr__output_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Monitor.NativeFieldInfoPtr__output_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000D408 File Offset: 0x0000B608
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00003956 File Offset: 0x00001B56
		public unsafe bool requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Monitor.NativeFieldInfoPtr_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Monitor.NativeFieldInfoPtr_requested)) = value;
			}
		}

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr__output_k__BackingField;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_requested;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_output_Public_get_RenderTexture_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_set_output_Protected_set_Void_RenderTexture_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_IsRequestedAndSupported_Public_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_ShaderResourcesAvailable_Internal_Abstract_Virtual_New_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_NeedsHalfRes_Internal_Virtual_New_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_CheckOutput_Protected_Void_Int32_Int32_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_New_Void_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Virtual_New_Void_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Abstract_Virtual_New_Void_PostProcessRenderContext_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
