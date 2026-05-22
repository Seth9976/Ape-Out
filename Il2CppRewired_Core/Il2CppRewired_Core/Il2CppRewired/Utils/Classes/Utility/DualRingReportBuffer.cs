using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000203 RID: 515
	public class DualRingReportBuffer : Object
	{
		// Token: 0x060035B6 RID: 13750 RVA: 0x0010AC98 File Offset: 0x00108E98
		// Note: this type is marked as 'beforefieldinit'.
		static DualRingReportBuffer()
		{
			Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "DualRingReportBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr);
			DualRingReportBuffer.NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "egdaswlnwfBLbytFwfNxUJCCacD");
			DualRingReportBuffer.NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "ozWGOIdxGvOEvBCyGTQVWUxZCQX");
			DualRingReportBuffer.NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "vYTCDXeuacgLWsLtZIEItfkwuMw");
			DualRingReportBuffer.NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "nsDqYlXKcLrxNWpKqIyaQUbthPO");
			DualRingReportBuffer.NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "GCixjfLPfAkhvgaZXxHrdikZPup");
			DualRingReportBuffer.NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "SzUNrWlJembrKyFLPqKRZWNbHmC");
			DualRingReportBuffer.NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "VyGtRqfftgoFlVJGXCXfIMAVxDU");
			DualRingReportBuffer.NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "kYVCfsvTFAbojbYLxcakfMlAdHzC");
			DualRingReportBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			DualRingReportBuffer.NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676636);
			DualRingReportBuffer.NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676637);
			DualRingReportBuffer.NativeMethodInfoPtr_get_EntriesInBuffer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676638);
			DualRingReportBuffer.NativeMethodInfoPtr_get_ReadBuffer_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676639);
			DualRingReportBuffer.NativeMethodInfoPtr_get_LastNumBytesRead_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676640);
			DualRingReportBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676641);
			DualRingReportBuffer.NativeMethodInfoPtr_StartRead_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676642);
			DualRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676643);
			DualRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676644);
			DualRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676645);
			DualRingReportBuffer.NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676646);
			DualRingReportBuffer.NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676647);
			DualRingReportBuffer.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676648);
			DualRingReportBuffer.NativeMethodInfoPtr_bUdcLDcywCXWtSqrfjvqtTKBXnW_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676649);
			DualRingReportBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676650);
			DualRingReportBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676651);
			DualRingReportBuffer.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr, 100676652);
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x0010AED0 File Offset: 0x001090D0
		public unsafe int BufferLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x0010AF0C File Offset: 0x0010910C
		public unsafe int BytesInBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x0010AF48 File Offset: 0x00109148
		public unsafe int EntriesInBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_get_EntriesInBuffer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x0010AF84 File Offset: 0x00109184
		public unsafe Il2CppStructArray<byte> ReadBuffer
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_get_ReadBuffer_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x0010AFC4 File Offset: 0x001091C4
		public unsafe int LastNumBytesRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_get_LastNumBytesRead_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0010B000 File Offset: 0x00109200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346325, XrefRangeEnd = 346337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualRingReportBuffer(int entryByteLength, int entryCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualRingReportBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref entryByteLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0010B058 File Offset: 0x00109258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346337, XrefRangeEnd = 346338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int StartRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_StartRead_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x0010B094 File Offset: 0x00109294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346338, XrefRangeEnd = 346343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x0010B0D0 File Offset: 0x001092D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346343, XrefRangeEnd = 346348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read(Il2CppStructArray<byte> buffer, int numBytesToRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x0010B12C File Offset: 0x0010932C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346348, XrefRangeEnd = 346354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read(IntPtr buffer, int bufferLength, int numBytesToRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0010B194 File Offset: 0x00109394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346354, XrefRangeEnd = 346359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Write(Il2CppStructArray<byte> buffer, int numBytesToWrite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x0010B1F0 File Offset: 0x001093F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346359, XrefRangeEnd = 346369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Write(IntPtr buffer, int bufferLength, int numBytesToWrite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0010B258 File Offset: 0x00109458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346369, XrefRangeEnd = 346376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x0010B28C File Offset: 0x0010948C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346390, RefRangeEnd = 346391, XrefRangeStart = 346376, XrefRangeEnd = 346390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void bUdcLDcywCXWtSqrfjvqtTKBXnW()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_bUdcLDcywCXWtSqrfjvqtTKBXnW_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x0010B2C0 File Offset: 0x001094C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346391, XrefRangeEnd = 346395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0010B2F4 File Offset: 0x001094F4
		[CallerCount(0)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualRingReportBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0010B330 File Offset: 0x00109530
		[CallerCount(0)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualRingReportBuffer.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x000127E7 File Offset: 0x000109E7
		public DualRingReportBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x0010B370 File Offset: 0x00109570
		// (set) Token: 0x060035CA RID: 13770 RVA: 0x000127F0 File Offset: 0x000109F0
		public unsafe int egdaswlnwfBLbytFwfNxUJCCacD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD)) = value;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x0010B398 File Offset: 0x00109598
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x0001280B File Offset: 0x00010A0B
		public unsafe int ozWGOIdxGvOEvBCyGTQVWUxZCQX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX)) = value;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x0010B3C0 File Offset: 0x001095C0
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x00012826 File Offset: 0x00010A26
		public unsafe int vYTCDXeuacgLWsLtZIEItfkwuMw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw)) = value;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x0010B3E8 File Offset: 0x001095E8
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x00012841 File Offset: 0x00010A41
		public unsafe NativeRingBuffer nsDqYlXKcLrxNWpKqIyaQUbthPO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeRingBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x0010B418 File Offset: 0x00109618
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x00012860 File Offset: 0x00010A60
		public unsafe NativeRingBuffer GCixjfLPfAkhvgaZXxHrdikZPup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeRingBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x0010B448 File Offset: 0x00109648
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x0001287F File Offset: 0x00010A7F
		public unsafe Il2CppStructArray<byte> SzUNrWlJembrKyFLPqKRZWNbHmC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x0010B478 File Offset: 0x00109678
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x0001289E File Offset: 0x00010A9E
		public unsafe Il2CppStructArray<byte> VyGtRqfftgoFlVJGXCXfIMAVxDU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x0010B4A8 File Offset: 0x001096A8
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x000128BD File Offset: 0x00010ABD
		public unsafe int kYVCfsvTFAbojbYLxcakfMlAdHzC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC)) = value;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x0010B4D0 File Offset: 0x001096D0
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x000128D8 File Offset: 0x00010AD8
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualRingReportBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0;

		// Token: 0x04002DB5 RID: 11701
		private static readonly IntPtr NativeMethodInfoPtr_get_EntriesInBuffer_Public_get_Int32_0;

		// Token: 0x04002DB6 RID: 11702
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadBuffer_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002DB7 RID: 11703
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNumBytesRead_Public_get_Int32_0;

		// Token: 0x04002DB8 RID: 11704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04002DB9 RID: 11705
		private static readonly IntPtr NativeMethodInfoPtr_StartRead_Public_Int32_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_0;

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_Int32_0;

		// Token: 0x04002DBD RID: 11709
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002DBE RID: 11710
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_0;

		// Token: 0x04002DBF RID: 11711
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002DC0 RID: 11712
		private static readonly IntPtr NativeMethodInfoPtr_bUdcLDcywCXWtSqrfjvqtTKBXnW_Private_Void_0;

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
