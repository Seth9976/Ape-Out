using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001BF RID: 447
	public class NativeMemoryBlock : Object
	{
		// Token: 0x06002EF3 RID: 12019 RVA: 0x000E9E84 File Offset: 0x000E8084
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMemoryBlock()
		{
			Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "NativeMemoryBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr);
			NativeMemoryBlock.NativeFieldInfoPtr_oeOUMtfevpJDZitngoNSLewjyQe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, "oeOUMtfevpJDZitngoNSLewjyQe");
			NativeMemoryBlock.NativeFieldInfoPtr_kBzVBAXJOdxTbUtOoMoBKLIbCv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, "kBzVBAXJOdxTbUtOoMoBKLIbCv");
			NativeMemoryBlock.NativeFieldInfoPtr_NDclxDcFKZenacxTkZpqVgpjiOCk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, "NDclxDcFKZenacxTkZpqVgpjiOCk");
			NativeMemoryBlock.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			NativeMemoryBlock.NativeMethodInfoPtr_get_size_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, 100675395);
			NativeMemoryBlock.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, 100675396);
			NativeMemoryBlock.NativeMethodInfoPtr_Allocate_Public_IntPtr_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, 100675397);
			NativeMemoryBlock.NativeMethodInfoPtr_Allocate_Public_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, 100675398);
			NativeMemoryBlock.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, 100675399);
			NativeMemoryBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, 100675400);
			NativeMemoryBlock.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr, 100675401);
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x000E9F90 File Offset: 0x000E8190
		public unsafe uint size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMemoryBlock.NativeMethodInfoPtr_get_size_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x000E9FCC File Offset: 0x000E81CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334910, XrefRangeEnd = 334918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMemoryBlock(uint size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMemoryBlock>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMemoryBlock.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x000EA014 File Offset: 0x000E8214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334918, XrefRangeEnd = 334920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Allocate(uint bytes, IntPtr ptrToData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptrToData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMemoryBlock.NativeMethodInfoPtr_Allocate_Public_IntPtr_UInt32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000EA06C File Offset: 0x000E826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334920, XrefRangeEnd = 334922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Allocate(uint bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMemoryBlock.NativeMethodInfoPtr_Allocate_Public_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000EA0B8 File Offset: 0x000E82B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334922, XrefRangeEnd = 334926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMemoryBlock.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000EA0EC File Offset: 0x000E82EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMemoryBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000EA128 File Offset: 0x000E8328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334926, XrefRangeEnd = 334930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMemoryBlock.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000112E0 File Offset: 0x0000F4E0
		public NativeMemoryBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000EA174 File Offset: 0x000E8374
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x000112E9 File Offset: 0x0000F4E9
		public unsafe int oeOUMtfevpJDZitngoNSLewjyQe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_oeOUMtfevpJDZitngoNSLewjyQe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_oeOUMtfevpJDZitngoNSLewjyQe)) = value;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x000EA19C File Offset: 0x000E839C
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x00011304 File Offset: 0x0000F504
		public unsafe uint kBzVBAXJOdxTbUtOoMoBKLIbCv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_kBzVBAXJOdxTbUtOoMoBKLIbCv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_kBzVBAXJOdxTbUtOoMoBKLIbCv)) = value;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x000EA1C4 File Offset: 0x000E83C4
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x0001131F File Offset: 0x0000F51F
		public unsafe IntPtr NDclxDcFKZenacxTkZpqVgpjiOCk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_NDclxDcFKZenacxTkZpqVgpjiOCk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_NDclxDcFKZenacxTkZpqVgpjiOCk)) = value;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x000EA1EC File Offset: 0x000E83EC
		// (set) Token: 0x06002F03 RID: 12035 RVA: 0x0001133A File Offset: 0x0000F53A
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMemoryBlock.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeFieldInfoPtr_oeOUMtfevpJDZitngoNSLewjyQe;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeFieldInfoPtr_kBzVBAXJOdxTbUtOoMoBKLIbCv;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeFieldInfoPtr_NDclxDcFKZenacxTkZpqVgpjiOCk;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_UInt32_0;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_IntPtr_UInt32_IntPtr_0;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_IntPtr_UInt32_0;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;
	}
}
