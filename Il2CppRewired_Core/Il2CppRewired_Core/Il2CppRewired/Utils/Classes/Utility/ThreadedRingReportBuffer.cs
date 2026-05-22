using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x02000202 RID: 514
	public class ThreadedRingReportBuffer : Object
	{
		// Token: 0x06003580 RID: 13696 RVA: 0x0010A1D0 File Offset: 0x001083D0
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadedRingReportBuffer()
		{
			Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "ThreadedRingReportBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr);
			ThreadedRingReportBuffer.NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "egdaswlnwfBLbytFwfNxUJCCacD");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "ozWGOIdxGvOEvBCyGTQVWUxZCQX");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "vYTCDXeuacgLWsLtZIEItfkwuMw");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "frqvHyUIdUlffWfOfdnujaYrTlN");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "LnDCUpcsFDXdGdmceKbnXMRSGkiO");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "keWkAwdpjRoiHThOXqjduoyMvCn");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "EbNjedtgmmFwfTnOvvmSghwMnPZ");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "nsDqYlXKcLrxNWpKqIyaQUbthPO");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "GCixjfLPfAkhvgaZXxHrdikZPup");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_SktNTbSGmVhwugxqVOsPwKBQOVM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "SktNTbSGmVhwugxqVOsPwKBQOVM");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "SzUNrWlJembrKyFLPqKRZWNbHmC");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "VyGtRqfftgoFlVJGXCXfIMAVxDU");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "oEZtbKVDQiwNaTKoOIOXEoeGHWQ");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "cyyBkkdxKBBsyXCzMlRPgcvSIBjT");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "kYVCfsvTFAbojbYLxcakfMlAdHzC");
			ThreadedRingReportBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			ThreadedRingReportBuffer.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676616);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676617);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676618);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_get_EntriesInBuffer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676619);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_get_ReadBuffer_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676620);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_get_LastNumBytesRead_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676621);
			ThreadedRingReportBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Boolean_Action_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676622);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676623);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676624);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676625);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_StartRead_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676626);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_StartThread_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676627);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_StopThread_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676628);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676629);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676630);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_bUdcLDcywCXWtSqrfjvqtTKBXnW_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676631);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676632);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676633);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676634);
			ThreadedRingReportBuffer.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr, 100676635);
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0010A4D0 File Offset: 0x001086D0
		public unsafe bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x0010A50C File Offset: 0x0010870C
		public unsafe int BufferLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x0010A548 File Offset: 0x00108748
		public unsafe int BytesInBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x0010A584 File Offset: 0x00108784
		public unsafe int EntriesInBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_get_EntriesInBuffer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x0010A5C0 File Offset: 0x001087C0
		public unsafe Il2CppStructArray<byte> ReadBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_get_ReadBuffer_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x0010A600 File Offset: 0x00108800
		public unsafe int LastNumBytesRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_get_LastNumBytesRead_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x0010A63C File Offset: 0x0010883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346250, XrefRangeEnd = 346263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadedRingReportBuffer(int entryByteLength, int entryCapacity, int threadRefreshRateFPS, int threadAutoKillTimeoutMS, bool threadBlockOnStartAndStop, Action<Il2CppStructArray<byte>> threadRetrieveDataDelegate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadedRingReportBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref entryByteLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryCapacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadRefreshRateFPS;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadAutoKillTimeoutMS;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadBlockOnStartAndStop;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(threadRetrieveDataDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Boolean_Action_1_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x0010A6D0 File Offset: 0x001088D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346263, XrefRangeEnd = 346268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0010A70C File Offset: 0x0010890C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346268, XrefRangeEnd = 346273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x0010A75C File Offset: 0x0010895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346273, XrefRangeEnd = 346279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read(IntPtr buffer, int bufferLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x0010A7B4 File Offset: 0x001089B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346279, XrefRangeEnd = 346280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int StartRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_StartRead_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x0010A7F0 File Offset: 0x001089F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346280, XrefRangeEnd = 346282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartThread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_StartThread_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x0010A824 File Offset: 0x00108A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346282, XrefRangeEnd = 346289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopThread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_StopThread_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x0010A858 File Offset: 0x00108A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346289, XrefRangeEnd = 346290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool addlbLsYdhqtKsbAsBkBewwooiH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x0010A894 File Offset: 0x00108A94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346293, RefRangeEnd = 346295, XrefRangeStart = 346290, XrefRangeEnd = 346293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ghRwtMydhLgIeEFZWwEssneMZlc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x0010A8D0 File Offset: 0x00108AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346309, RefRangeEnd = 346310, XrefRangeStart = 346295, XrefRangeEnd = 346309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void bUdcLDcywCXWtSqrfjvqtTKBXnW()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_bUdcLDcywCXWtSqrfjvqtTKBXnW_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x0010A904 File Offset: 0x00108B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346310, XrefRangeEnd = 346318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void khVkVIhFAUMrhObnIwpBwEBgHnb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x0010A938 File Offset: 0x00108B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346318, XrefRangeEnd = 346323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x0010A96C File Offset: 0x00108B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346323, XrefRangeEnd = 346324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThreadedRingReportBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x0010A9A8 File Offset: 0x00108BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346324, XrefRangeEnd = 346325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadedRingReportBuffer.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00012616 File Offset: 0x00010816
		public ThreadedRingReportBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x0010A9E8 File Offset: 0x00108BE8
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x0001261F File Offset: 0x0001081F
		public unsafe int egdaswlnwfBLbytFwfNxUJCCacD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD)) = value;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x0010AA10 File Offset: 0x00108C10
		// (set) Token: 0x06003599 RID: 13721 RVA: 0x0001263A File Offset: 0x0001083A
		public unsafe int ozWGOIdxGvOEvBCyGTQVWUxZCQX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX)) = value;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x0010AA38 File Offset: 0x00108C38
		// (set) Token: 0x0600359B RID: 13723 RVA: 0x00012655 File Offset: 0x00010855
		public unsafe int vYTCDXeuacgLWsLtZIEItfkwuMw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw)) = value;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x0010AA60 File Offset: 0x00108C60
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x00012670 File Offset: 0x00010870
		public unsafe int frqvHyUIdUlffWfOfdnujaYrTlN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN)) = value;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x0010AA88 File Offset: 0x00108C88
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x0001268B File Offset: 0x0001088B
		public unsafe int LnDCUpcsFDXdGdmceKbnXMRSGkiO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO)) = value;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x0010AAB0 File Offset: 0x00108CB0
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x000126A6 File Offset: 0x000108A6
		public unsafe bool keWkAwdpjRoiHThOXqjduoyMvCn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn)) = value;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x0010AAD8 File Offset: 0x00108CD8
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x000126C1 File Offset: 0x000108C1
		public unsafe ThreadHelper EbNjedtgmmFwfTnOvvmSghwMnPZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x0010AB08 File Offset: 0x00108D08
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x000126E0 File Offset: 0x000108E0
		public unsafe NativeRingBuffer nsDqYlXKcLrxNWpKqIyaQUbthPO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeRingBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x0010AB38 File Offset: 0x00108D38
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x000126FF File Offset: 0x000108FF
		public unsafe NativeRingBuffer GCixjfLPfAkhvgaZXxHrdikZPup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeRingBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x0010AB68 File Offset: 0x00108D68
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x0001271E File Offset: 0x0001091E
		public unsafe Action<Il2CppStructArray<byte>> SktNTbSGmVhwugxqVOsPwKBQOVM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_SktNTbSGmVhwugxqVOsPwKBQOVM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStructArray<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_SktNTbSGmVhwugxqVOsPwKBQOVM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x0010AB98 File Offset: 0x00108D98
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x0001273D File Offset: 0x0001093D
		public unsafe Il2CppStructArray<byte> SzUNrWlJembrKyFLPqKRZWNbHmC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x0010ABC8 File Offset: 0x00108DC8
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x0001275C File Offset: 0x0001095C
		public unsafe Il2CppStructArray<byte> VyGtRqfftgoFlVJGXCXfIMAVxDU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x0010ABF8 File Offset: 0x00108DF8
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x0001277B File Offset: 0x0001097B
		public unsafe bool oEZtbKVDQiwNaTKoOIOXEoeGHWQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ)) = value;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x0010AC20 File Offset: 0x00108E20
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x00012796 File Offset: 0x00010996
		public unsafe bool cyyBkkdxKBBsyXCzMlRPgcvSIBjT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT)) = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x0010AC48 File Offset: 0x00108E48
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x000127B1 File Offset: 0x000109B1
		public unsafe int kYVCfsvTFAbojbYLxcakfMlAdHzC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC)) = value;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x0010AC70 File Offset: 0x00108E70
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x000127CC File Offset: 0x000109CC
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadedRingReportBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002D86 RID: 11654
		private static readonly IntPtr NativeFieldInfoPtr_egdaswlnwfBLbytFwfNxUJCCacD;

		// Token: 0x04002D87 RID: 11655
		private static readonly IntPtr NativeFieldInfoPtr_ozWGOIdxGvOEvBCyGTQVWUxZCQX;

		// Token: 0x04002D88 RID: 11656
		private static readonly IntPtr NativeFieldInfoPtr_vYTCDXeuacgLWsLtZIEItfkwuMw;

		// Token: 0x04002D89 RID: 11657
		private static readonly IntPtr NativeFieldInfoPtr_frqvHyUIdUlffWfOfdnujaYrTlN;

		// Token: 0x04002D8A RID: 11658
		private static readonly IntPtr NativeFieldInfoPtr_LnDCUpcsFDXdGdmceKbnXMRSGkiO;

		// Token: 0x04002D8B RID: 11659
		private static readonly IntPtr NativeFieldInfoPtr_keWkAwdpjRoiHThOXqjduoyMvCn;

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeFieldInfoPtr_EbNjedtgmmFwfTnOvvmSghwMnPZ;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeFieldInfoPtr_nsDqYlXKcLrxNWpKqIyaQUbthPO;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeFieldInfoPtr_GCixjfLPfAkhvgaZXxHrdikZPup;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeFieldInfoPtr_SktNTbSGmVhwugxqVOsPwKBQOVM;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeFieldInfoPtr_SzUNrWlJembrKyFLPqKRZWNbHmC;

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeFieldInfoPtr_VyGtRqfftgoFlVJGXCXfIMAVxDU;

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeFieldInfoPtr_oEZtbKVDQiwNaTKoOIOXEoeGHWQ;

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeFieldInfoPtr_cyyBkkdxKBBsyXCzMlRPgcvSIBjT;

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeFieldInfoPtr_kYVCfsvTFAbojbYLxcakfMlAdHzC;

		// Token: 0x04002D95 RID: 11669
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002D96 RID: 11670
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

		// Token: 0x04002D97 RID: 11671
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferLength_Public_get_Int32_0;

		// Token: 0x04002D98 RID: 11672
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0;

		// Token: 0x04002D99 RID: 11673
		private static readonly IntPtr NativeMethodInfoPtr_get_EntriesInBuffer_Public_get_Int32_0;

		// Token: 0x04002D9A RID: 11674
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadBuffer_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNumBytesRead_Public_get_Int32_0;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Boolean_Action_1_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_0;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_0;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeMethodInfoPtr_StartRead_Public_Int32_0;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeMethodInfoPtr_StartThread_Public_Void_0;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeMethodInfoPtr_StopThread_Public_Void_0;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeMethodInfoPtr_addlbLsYdhqtKsbAsBkBewwooiH_Private_Boolean_0;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeMethodInfoPtr_ghRwtMydhLgIeEFZWwEssneMZlc_Private_Boolean_0;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeMethodInfoPtr_bUdcLDcywCXWtSqrfjvqtTKBXnW_Private_Void_0;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeMethodInfoPtr_khVkVIhFAUMrhObnIwpBwEBgHnb_Private_Void_0;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
