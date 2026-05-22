using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001BE RID: 446
	public class NativeRingBuffer : Object
	{
		// Token: 0x06002EC7 RID: 11975 RVA: 0x000E9258 File Offset: 0x000E7458
		// Note: this type is marked as 'beforefieldinit'.
		static NativeRingBuffer()
		{
			Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "NativeRingBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr);
			NativeRingBuffer.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "opZcIuANSUThUUHxuFnnDUzRXqF");
			NativeRingBuffer.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "qBWhkDkyhhMvevSGcjJIDmXZcRT");
			NativeRingBuffer.NativeFieldInfoPtr_TgqfiAxVDZcoTbejzVAjLzurqSC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "TgqfiAxVDZcoTbejzVAjLzurqSC");
			NativeRingBuffer.NativeFieldInfoPtr_GfqfofCRrWIjHdxmBdZggOLYZut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "GfqfofCRrWIjHdxmBdZggOLYZut");
			NativeRingBuffer.NativeFieldInfoPtr_ILZpZNBtFwpgttAxpyEGXANhMWF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "ILZpZNBtFwpgttAxpyEGXANhMWF");
			NativeRingBuffer.NativeFieldInfoPtr_siInwyFSkrSpkeGDVbGPnjURLHm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "siInwyFSkrSpkeGDVbGPnjURLHm");
			NativeRingBuffer.NativeFieldInfoPtr_zBCkNqFzVrMTqjSmCoNZJigPMaZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "zBCkNqFzVrMTqjSmCoNZJigPMaZ");
			NativeRingBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			NativeRingBuffer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675369);
			NativeRingBuffer.NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675370);
			NativeRingBuffer.NativeMethodInfoPtr_get_BufferOverrun_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675371);
			NativeRingBuffer.NativeMethodInfoPtr_get_ReadPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675372);
			NativeRingBuffer.NativeMethodInfoPtr_get_WritePosition_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675373);
			NativeRingBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675374);
			NativeRingBuffer.NativeMethodInfoPtr_Allocate_Public_IntPtr_Int32_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675375);
			NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_byref_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675376);
			NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_byref_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675377);
			NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675378);
			NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675379);
			NativeRingBuffer.NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675380);
			NativeRingBuffer.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675381);
			NativeRingBuffer.NativeMethodInfoPtr_RandomRead_Public_Int32_IntPtr_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675382);
			NativeRingBuffer.NativeMethodInfoPtr_RandomRead_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675383);
			NativeRingBuffer.NativeMethodInfoPtr_GetPointerFromReadPosition_Public_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675384);
			NativeRingBuffer.NativeMethodInfoPtr_GetOffsetFromReadPosition_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675385);
			NativeRingBuffer.NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675386);
			NativeRingBuffer.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeRingBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675387);
			NativeRingBuffer.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675388);
			NativeRingBuffer.NativeMethodInfoPtr_eREqvAaVxTcPLqlRBwUyQFfoAEW_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675389);
			NativeRingBuffer.NativeMethodInfoPtr_KoWudvXyqhSwdlkIJJvMZjyjaYZ_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675390);
			NativeRingBuffer.NativeMethodInfoPtr_AmSdLlBrFkSkxvOOSIZJcDjywZI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675391);
			NativeRingBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675392);
			NativeRingBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675393);
			NativeRingBuffer.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr, 100675394);
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x000E9530 File Offset: 0x000E7730
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x000E956C File Offset: 0x000E776C
		public unsafe int BytesInBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x000E95A8 File Offset: 0x000E77A8
		public unsafe bool BufferOverrun
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_get_BufferOverrun_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x000E95E4 File Offset: 0x000E77E4
		public unsafe int ReadPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_get_ReadPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000E9620 File Offset: 0x000E7820
		public unsafe long WritePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_get_WritePosition_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x000E965C File Offset: 0x000E785C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334831, RefRangeEnd = 334836, XrefRangeStart = 334827, XrefRangeEnd = 334831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeRingBuffer(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRingBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x000E96A4 File Offset: 0x000E78A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334836, XrefRangeEnd = 334839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr Allocate(int bufferLength, bool zeroFill, out uint passId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroFill;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &passId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Allocate_Public_IntPtr_Int32_Boolean_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x000E970C File Offset: 0x000E790C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334839, XrefRangeEnd = 334844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Write(IntPtr buffer, int bufferLength, int numBytesToWrite, out int startOffset, out uint passId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToWrite;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &startOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &passId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_byref_Int32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000E9790 File Offset: 0x000E7990
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334848, RefRangeEnd = 334851, XrefRangeStart = 334844, XrefRangeEnd = 334848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Write(Il2CppStructArray<byte> buffer, int numBytesToWrite, out int startOffset, out uint passId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToWrite;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &startOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &passId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_byref_Int32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x000E9808 File Offset: 0x000E7A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334851, XrefRangeEnd = 334856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x000E9870 File Offset: 0x000E7A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334856, XrefRangeEnd = 334857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x000E98CC File Offset: 0x000E7ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334862, RefRangeEnd = 334864, XrefRangeStart = 334857, XrefRangeEnd = 334862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x000E9934 File Offset: 0x000E7B34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334868, RefRangeEnd = 334872, XrefRangeStart = 334864, XrefRangeEnd = 334868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x000E9990 File Offset: 0x000E7B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334872, XrefRangeEnd = 334876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RandomRead(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToRead;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_RandomRead_Public_Int32_IntPtr_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x000E9A04 File Offset: 0x000E7C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334876, XrefRangeEnd = 334879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RandomRead(Il2CppStructArray<byte> buffer, int numBytesToRead, int readStartIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytesToRead;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_RandomRead_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x000E9A70 File Offset: 0x000E7C70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334882, RefRangeEnd = 334887, XrefRangeStart = 334879, XrefRangeEnd = 334882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetPointerFromReadPosition(int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_GetPointerFromReadPosition_Public_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x000E9ABC File Offset: 0x000E7CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334887, XrefRangeEnd = 334888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOffsetFromReadPosition(int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_GetOffsetFromReadPosition_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000E9B08 File Offset: 0x000E7D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334888, XrefRangeEnd = 334889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid(int startIndex, uint passId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000E9B60 File Offset: 0x000E7D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334889, XrefRangeEnd = 334891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(NativeRingBuffer other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_CopyFrom_Public_Void_NativeRingBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x000E9BA4 File Offset: 0x000E7DA4
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000E9BD8 File Offset: 0x000E7DD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 334894, RefRangeEnd = 334901, XrefRangeStart = 334891, XrefRangeEnd = 334894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void eREqvAaVxTcPLqlRBwUyQFfoAEW(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_eREqvAaVxTcPLqlRBwUyQFfoAEW_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000E9C18 File Offset: 0x000E7E18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334901, RefRangeEnd = 334903, XrefRangeStart = 334901, XrefRangeEnd = 334901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KoWudvXyqhSwdlkIJJvMZjyjaYZ(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_KoWudvXyqhSwdlkIJJvMZjyjaYZ_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000E9C58 File Offset: 0x000E7E58
		[CallerCount(0)]
		public unsafe void AmSdLlBrFkSkxvOOSIZJcDjywZI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_AmSdLlBrFkSkxvOOSIZJcDjywZI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x000E9C8C File Offset: 0x000E7E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334903, XrefRangeEnd = 334908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000E9CC0 File Offset: 0x000E7EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334908, XrefRangeEnd = 334909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeRingBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000E9CFC File Offset: 0x000E7EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334909, XrefRangeEnd = 334910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeRingBuffer.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000111FB File Offset: 0x0000F3FB
		public NativeRingBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x000E9D3C File Offset: 0x000E7F3C
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00011204 File Offset: 0x0000F404
		public unsafe NativeBuffer opZcIuANSUThUUHxuFnnDUzRXqF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000E9D6C File Offset: 0x000E7F6C
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x00011223 File Offset: 0x0000F423
		public unsafe int qBWhkDkyhhMvevSGcjJIDmXZcRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT)) = value;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x000E9D94 File Offset: 0x000E7F94
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x0001123E File Offset: 0x0000F43E
		public unsafe long TgqfiAxVDZcoTbejzVAjLzurqSC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_TgqfiAxVDZcoTbejzVAjLzurqSC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_TgqfiAxVDZcoTbejzVAjLzurqSC)) = value;
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x000E9DBC File Offset: 0x000E7FBC
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x00011259 File Offset: 0x0000F459
		public unsafe long GfqfofCRrWIjHdxmBdZggOLYZut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_GfqfofCRrWIjHdxmBdZggOLYZut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_GfqfofCRrWIjHdxmBdZggOLYZut)) = value;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x000E9DE4 File Offset: 0x000E7FE4
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x00011274 File Offset: 0x0000F474
		public unsafe int ILZpZNBtFwpgttAxpyEGXANhMWF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_ILZpZNBtFwpgttAxpyEGXANhMWF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_ILZpZNBtFwpgttAxpyEGXANhMWF)) = value;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x000E9E0C File Offset: 0x000E800C
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x0001128F File Offset: 0x0000F48F
		public unsafe bool siInwyFSkrSpkeGDVbGPnjURLHm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_siInwyFSkrSpkeGDVbGPnjURLHm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_siInwyFSkrSpkeGDVbGPnjURLHm)) = value;
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x000E9E34 File Offset: 0x000E8034
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x000112AA File Offset: 0x0000F4AA
		public unsafe uint zBCkNqFzVrMTqjSmCoNZJigPMaZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_zBCkNqFzVrMTqjSmCoNZJigPMaZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_zBCkNqFzVrMTqjSmCoNZJigPMaZ)) = value;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x000E9E5C File Offset: 0x000E805C
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x000112C5 File Offset: 0x0000F4C5
		public unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeRingBuffer.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeFieldInfoPtr_opZcIuANSUThUUHxuFnnDUzRXqF;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeFieldInfoPtr_TgqfiAxVDZcoTbejzVAjLzurqSC;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeFieldInfoPtr_GfqfofCRrWIjHdxmBdZggOLYZut;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeFieldInfoPtr_ILZpZNBtFwpgttAxpyEGXANhMWF;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeFieldInfoPtr_siInwyFSkrSpkeGDVbGPnjURLHm;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeFieldInfoPtr_zBCkNqFzVrMTqjSmCoNZJigPMaZ;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesInBuffer_Public_get_Int32_0;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferOverrun_Public_get_Boolean_0;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadPosition_Public_get_Int32_0;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeMethodInfoPtr_get_WritePosition_Public_get_Int64_0;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_IntPtr_Int32_Boolean_byref_UInt32_0;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_byref_Int32_byref_UInt32_0;

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_byref_Int32_byref_UInt32_0;

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Int32_IntPtr_Int32_Int32_0;

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040027B5 RID: 10165
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_IntPtr_Int32_Int32_0;

		// Token: 0x040027B6 RID: 10166
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040027B7 RID: 10167
		private static readonly IntPtr NativeMethodInfoPtr_RandomRead_Public_Int32_IntPtr_Int32_Int32_Int32_0;

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeMethodInfoPtr_RandomRead_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerFromReadPosition_Public_IntPtr_Int32_0;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetFromReadPosition_Public_Int32_Int32_0;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_Int32_UInt32_0;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_NativeRingBuffer_0;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeMethodInfoPtr_eREqvAaVxTcPLqlRBwUyQFfoAEW_Private_Void_Int32_0;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeMethodInfoPtr_KoWudvXyqhSwdlkIJJvMZjyjaYZ_Private_Void_Int32_0;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeMethodInfoPtr_AmSdLlBrFkSkxvOOSIZJcDjywZI_Private_Void_0;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;
	}
}
