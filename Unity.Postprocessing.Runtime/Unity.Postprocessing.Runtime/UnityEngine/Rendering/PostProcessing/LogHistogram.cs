using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200005D RID: 93
	public sealed class LogHistogram : Object
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00015E8C File Offset: 0x0001408C
		// Note: this type is marked as 'beforefieldinit'.
		static LogHistogram()
		{
			Il2CppClassPointerStore<LogHistogram>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "LogHistogram");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr);
			LogHistogram.NativeFieldInfoPtr_rangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "rangeMin");
			LogHistogram.NativeFieldInfoPtr_rangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "rangeMax");
			LogHistogram.NativeFieldInfoPtr_k_Bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "k_Bins");
			LogHistogram.NativeFieldInfoPtr__data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, "<data>k__BackingField");
			LogHistogram.NativeMethodInfoPtr_get_data_Public_get_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100663779);
			LogHistogram.NativeMethodInfoPtr_set_data_Private_set_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100663780);
			LogHistogram.NativeMethodInfoPtr_Generate_Public_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100663781);
			LogHistogram.NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Public_Vector4_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100663782);
			LogHistogram.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100663783);
			LogHistogram.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr, 100663784);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00015F84 File Offset: 0x00014184
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00015FC4 File Offset: 0x000141C4
		public unsafe ComputeBuffer data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHistogram.NativeMethodInfoPtr_get_data_Public_get_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHistogram.NativeMethodInfoPtr_set_data_Private_set_Void_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00016008 File Offset: 0x00014208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 448504, RefRangeEnd = 448505, XrefRangeStart = 448452, XrefRangeEnd = 448504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHistogram.NativeMethodInfoPtr_Generate_Public_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001604C File Offset: 0x0001424C
		[CallerCount(0)]
		public unsafe Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHistogram.NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Public_Vector4_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001609C File Offset: 0x0001429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448505, XrefRangeEnd = 448506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHistogram.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000160D0 File Offset: 0x000142D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogHistogram()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogHistogram>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogHistogram.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004A84 File Offset: 0x00002C84
		public LogHistogram(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001610C File Offset: 0x0001430C
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00004A8D File Offset: 0x00002C8D
		public unsafe static int rangeMin
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LogHistogram.NativeFieldInfoPtr_rangeMin, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogHistogram.NativeFieldInfoPtr_rangeMin, (void*)(&value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00016128 File Offset: 0x00014328
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00004A9B File Offset: 0x00002C9B
		public unsafe static int rangeMax
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LogHistogram.NativeFieldInfoPtr_rangeMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogHistogram.NativeFieldInfoPtr_rangeMax, (void*)(&value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00016144 File Offset: 0x00014344
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00004AA9 File Offset: 0x00002CA9
		public unsafe static int k_Bins
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LogHistogram.NativeFieldInfoPtr_k_Bins, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogHistogram.NativeFieldInfoPtr_k_Bins, (void*)(&value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00016160 File Offset: 0x00014360
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00004AB7 File Offset: 0x00002CB7
		public unsafe ComputeBuffer _data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogHistogram.NativeFieldInfoPtr__data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogHistogram.NativeFieldInfoPtr__data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeFieldInfoPtr_rangeMin;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr_rangeMax;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_k_Bins;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr__data_k__BackingField;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_ComputeBuffer_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_set_data_Private_set_Void_ComputeBuffer_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_PostProcessRenderContext_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Public_Vector4_PostProcessRenderContext_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
