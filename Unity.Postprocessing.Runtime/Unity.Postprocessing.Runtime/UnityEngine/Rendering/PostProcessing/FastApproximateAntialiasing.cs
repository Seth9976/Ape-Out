using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000022 RID: 34
	[Serializable]
	public sealed class FastApproximateAntialiasing : Object
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00009714 File Offset: 0x00007914
		// Note: this type is marked as 'beforefieldinit'.
		static FastApproximateAntialiasing()
		{
			Il2CppClassPointerStore<FastApproximateAntialiasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "FastApproximateAntialiasing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastApproximateAntialiasing>.NativeClassPtr);
			FastApproximateAntialiasing.NativeFieldInfoPtr_fastMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastApproximateAntialiasing>.NativeClassPtr, "fastMode");
			FastApproximateAntialiasing.NativeFieldInfoPtr_keepAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastApproximateAntialiasing>.NativeClassPtr, "keepAlpha");
			FastApproximateAntialiasing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastApproximateAntialiasing>.NativeClassPtr, 100663368);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00009780 File Offset: 0x00007980
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastApproximateAntialiasing()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastApproximateAntialiasing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastApproximateAntialiasing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002EF8 File Offset: 0x000010F8
		public FastApproximateAntialiasing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000097BC File Offset: 0x000079BC
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002F01 File Offset: 0x00001101
		public unsafe bool fastMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastApproximateAntialiasing.NativeFieldInfoPtr_fastMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastApproximateAntialiasing.NativeFieldInfoPtr_fastMode)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000097E4 File Offset: 0x000079E4
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002F1C File Offset: 0x0000111C
		public unsafe bool keepAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastApproximateAntialiasing.NativeFieldInfoPtr_keepAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastApproximateAntialiasing.NativeFieldInfoPtr_keepAlpha)) = value;
			}
		}

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_fastMode;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_keepAlpha;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
