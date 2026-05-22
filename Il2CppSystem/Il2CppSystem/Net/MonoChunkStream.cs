using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x02000134 RID: 308
	public class MonoChunkStream : Object
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x00055BA0 File Offset: 0x00053DA0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoChunkStream()
		{
			Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "MonoChunkStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr);
			MonoChunkStream.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "headers");
			MonoChunkStream.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "chunkSize");
			MonoChunkStream.NativeFieldInfoPtr_chunkRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "chunkRead");
			MonoChunkStream.NativeFieldInfoPtr_totalWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "totalWritten");
			MonoChunkStream.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "state");
			MonoChunkStream.NativeFieldInfoPtr_saved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "saved");
			MonoChunkStream.NativeFieldInfoPtr_sawCR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "sawCR");
			MonoChunkStream.NativeFieldInfoPtr_gotit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "gotit");
			MonoChunkStream.NativeFieldInfoPtr_trailerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "trailerState");
			MonoChunkStream.NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "chunks");
			MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665902);
			MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665903);
			MonoChunkStream.NativeMethodInfoPtr_ResetBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665904);
			MonoChunkStream.NativeMethodInfoPtr_WriteAndReadBack_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665905);
			MonoChunkStream.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665906);
			MonoChunkStream.NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665907);
			MonoChunkStream.NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665908);
			MonoChunkStream.NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665909);
			MonoChunkStream.NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665910);
			MonoChunkStream.NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665911);
			MonoChunkStream.NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665912);
			MonoChunkStream.NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665913);
			MonoChunkStream.NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665914);
			MonoChunkStream.NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665915);
			MonoChunkStream.NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665916);
			MonoChunkStream.NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665917);
			MonoChunkStream.NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665918);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00055DEC File Offset: 0x00053FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383501, XrefRangeEnd = 383503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream(Il2CppStructArray<byte> buffer, int offset, int size, WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00055E68 File Offset: 0x00054068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383514, RefRangeEnd = 383516, XrefRangeStart = 383503, XrefRangeEnd = 383514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream(WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00055EB4 File Offset: 0x000540B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383516, XrefRangeEnd = 383517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ResetBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00055EE8 File Offset: 0x000540E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383517, XrefRangeEnd = 383519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAndReadBack(Il2CppStructArray<byte> buffer, int offset, int size, ref int read)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &read;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_WriteAndReadBack_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00055F58 File Offset: 0x00054158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383519, XrefRangeEnd = 383520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00055FC4 File Offset: 0x000541C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 383541, RefRangeEnd = 383545, XrefRangeStart = 383520, XrefRangeEnd = 383541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadFromChunks(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00056030 File Offset: 0x00054230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383545, XrefRangeEnd = 383546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00056090 File Offset: 0x00054290
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 383562, RefRangeEnd = 383569, XrefRangeStart = 383546, XrefRangeEnd = 383562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWrite(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000560F0 File Offset: 0x000542F0
		public unsafe bool WantMore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x0005612C File Offset: 0x0005432C
		public unsafe bool DataAvailable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383569, XrefRangeEnd = 383571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00056168 File Offset: 0x00054368
		public unsafe int ChunkLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000561A4 File Offset: 0x000543A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383571, XrefRangeEnd = 383578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State ReadBody(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00056210 File Offset: 0x00054410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383588, RefRangeEnd = 383589, XrefRangeStart = 383578, XrefRangeEnd = 383588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State GetChunkSize(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0005627C File Offset: 0x0005447C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383589, XrefRangeEnd = 383591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveChunkExtension(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000562B8 File Offset: 0x000544B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383591, XrefRangeEnd = 383594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State ReadCRLF(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00056324 File Offset: 0x00054524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383599, RefRangeEnd = 383600, XrefRangeStart = 383594, XrefRangeEnd = 383599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State ReadTrailer(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00056390 File Offset: 0x00054590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383600, XrefRangeEnd = 383605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowProtocolViolation(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0000976E File Offset: 0x0000796E
		public MonoChunkStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000563C8 File Offset: 0x000545C8
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x00009777 File Offset: 0x00007977
		public unsafe WebHeaderCollection headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000563F8 File Offset: 0x000545F8
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x00009796 File Offset: 0x00007996
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00056420 File Offset: 0x00054620
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x000097B1 File Offset: 0x000079B1
		public unsafe int chunkRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkRead)) = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00056448 File Offset: 0x00054648
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000097CC File Offset: 0x000079CC
		public unsafe int totalWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_totalWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_totalWritten)) = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00056470 File Offset: 0x00054670
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x000097E7 File Offset: 0x000079E7
		public unsafe MonoChunkStream.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00056498 File Offset: 0x00054698
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x00009802 File Offset: 0x00007A02
		public unsafe StringBuilder saved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_saved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_saved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000564C8 File Offset: 0x000546C8
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x00009821 File Offset: 0x00007A21
		public unsafe bool sawCR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_sawCR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_sawCR)) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000564F0 File Offset: 0x000546F0
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0000983C File Offset: 0x00007A3C
		public unsafe bool gotit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_gotit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_gotit)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00056518 File Offset: 0x00054718
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x00009857 File Offset: 0x00007A57
		public unsafe int trailerState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_trailerState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_trailerState)) = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x00056540 File Offset: 0x00054740
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x00009872 File Offset: 0x00007A72
		public unsafe ArrayList chunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeFieldInfoPtr_chunkRead;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeFieldInfoPtr_totalWritten;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeFieldInfoPtr_saved;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeFieldInfoPtr_sawCR;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeFieldInfoPtr_gotit;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr_trailerState;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_chunks;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_WebHeaderCollection_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_ResetBuffer_Public_Void_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_WriteAndReadBack_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0;

		// Token: 0x020001ED RID: 493
		[OriginalName("System.dll", "", "State")]
		public enum State
		{
			// Token: 0x04001505 RID: 5381
			None,
			// Token: 0x04001506 RID: 5382
			PartialSize,
			// Token: 0x04001507 RID: 5383
			Body,
			// Token: 0x04001508 RID: 5384
			BodyFinished,
			// Token: 0x04001509 RID: 5385
			Trailer
		}

		// Token: 0x020001EE RID: 494
		public class Chunk : Object
		{
			// Token: 0x06001AF2 RID: 6898 RVA: 0x00071C00 File Offset: 0x0006FE00
			// Note: this type is marked as 'beforefieldinit'.
			static Chunk()
			{
				Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "Chunk");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr);
				MonoChunkStream.Chunk.NativeFieldInfoPtr_Bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, "Bytes");
				MonoChunkStream.Chunk.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, "Offset");
				MonoChunkStream.Chunk.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, 100665919);
				MonoChunkStream.Chunk.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, 100665920);
			}

			// Token: 0x06001AF3 RID: 6899 RVA: 0x00071C7C File Offset: 0x0006FE7C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Chunk(Il2CppStructArray<byte> chunk)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.Chunk.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AF4 RID: 6900 RVA: 0x00071CC8 File Offset: 0x0006FEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383500, XrefRangeEnd = 383501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Read(Il2CppStructArray<byte> buffer, int offset, int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.Chunk.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001AF5 RID: 6901 RVA: 0x0000E023 File Offset: 0x0000C223
			public Chunk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x00071D34 File Offset: 0x0006FF34
			// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0000E02C File Offset: 0x0000C22C
			public unsafe Il2CppStructArray<byte> Bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x00071D64 File Offset: 0x0006FF64
			// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x0000E04B File Offset: 0x0000C24B
			public unsafe int Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x0400150A RID: 5386
			private static readonly IntPtr NativeFieldInfoPtr_Bytes;

			// Token: 0x0400150B RID: 5387
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x0400150C RID: 5388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400150D RID: 5389
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;
		}
	}
}
