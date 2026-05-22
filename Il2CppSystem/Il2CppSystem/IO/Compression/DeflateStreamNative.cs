using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO.Compression
{
	// Token: 0x020000CC RID: 204
	public class DeflateStreamNative : Object
	{
		// Token: 0x06000B21 RID: 2849 RVA: 0x0003A094 File Offset: 0x00038294
		// Note: this type is marked as 'beforefieldinit'.
		static DeflateStreamNative()
		{
			Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO.Compression", "DeflateStreamNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr);
			DeflateStreamNative.NativeFieldInfoPtr_feeder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "feeder");
			DeflateStreamNative.NativeFieldInfoPtr_base_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "base_stream");
			DeflateStreamNative.NativeFieldInfoPtr_z_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "z_stream");
			DeflateStreamNative.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "data");
			DeflateStreamNative.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "disposed");
			DeflateStreamNative.NativeFieldInfoPtr_io_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "io_buffer");
			DeflateStreamNative.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664861);
			DeflateStreamNative.NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664862);
			DeflateStreamNative.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664863);
			DeflateStreamNative.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664864);
			DeflateStreamNative.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664865);
			DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664866);
			DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664867);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664868);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664869);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664870);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664871);
			DeflateStreamNative.NativeMethodInfoPtr_CheckResult_Private_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664872);
			DeflateStreamNative.NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664873);
			DeflateStreamNative.NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664874);
			DeflateStreamNative.NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664875);
			DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664876);
			DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664877);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0003A290 File Offset: 0x00038490
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateStreamNative()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0003A2CC File Offset: 0x000384CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375156, RefRangeEnd = 375157, XrefRangeStart = 375137, XrefRangeEnd = 375156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(compressedStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative>(intPtr3) : null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0003A32C File Offset: 0x0003852C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375157, XrefRangeEnd = 375160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStreamNative.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0003A368 File Offset: 0x00038568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375166, RefRangeEnd = 375167, XrefRangeStart = 375160, XrefRangeEnd = 375166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0003A3A8 File Offset: 0x000385A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375167, XrefRangeEnd = 375177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0003A3DC File Offset: 0x000385DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375177, XrefRangeEnd = 375183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadZStream(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0003A434 File Offset: 0x00038634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375183, XrefRangeEnd = 375191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteZStream(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0003A480 File Offset: 0x00038680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375191, XrefRangeEnd = 375205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0003A4DC File Offset: 0x000386DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375205, XrefRangeEnd = 375215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UnmanagedRead(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0003A534 File Offset: 0x00038734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375215, XrefRangeEnd = 375231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0003A590 File Offset: 0x00038790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375231, XrefRangeEnd = 375243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UnmanagedWrite(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0003A5E8 File Offset: 0x000387E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 375244, RefRangeEnd = 375252, XrefRangeStart = 375243, XrefRangeEnd = 375244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckResult(int result, string where)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(where);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CheckResult_Private_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0003A62C File Offset: 0x0003882C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375252, XrefRangeEnd = 375259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref compress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(feeder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.SafeDeflateStreamHandle>(intPtr3) : null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0003A69C File Offset: 0x0003889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375259, XrefRangeEnd = 375260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CloseZStream(IntPtr stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0003A6DC File Offset: 0x000388DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375260, XrefRangeEnd = 375265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0003A720 File Offset: 0x00038920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375265, XrefRangeEnd = 375268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0003A780 File Offset: 0x00038980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375268, XrefRangeEnd = 375271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00006779 File Offset: 0x00004979
		public DeflateStreamNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0003A7E0 File Offset: 0x000389E0
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00006782 File Offset: 0x00004982
		public unsafe DeflateStreamNative.UnmanagedReadOrWrite feeder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_feeder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.UnmanagedReadOrWrite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_feeder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0003A810 File Offset: 0x00038A10
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x000067A1 File Offset: 0x000049A1
		public unsafe Stream base_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_base_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_base_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0003A840 File Offset: 0x00038A40
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000067C0 File Offset: 0x000049C0
		public unsafe DeflateStreamNative.SafeDeflateStreamHandle z_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_z_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.SafeDeflateStreamHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_z_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0003A870 File Offset: 0x00038A70
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x000067DF File Offset: 0x000049DF
		public unsafe GCHandle data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0003A898 File Offset: 0x00038A98
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x000067FA File Offset: 0x000049FA
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0003A8C0 File Offset: 0x00038AC0
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00006815 File Offset: 0x00004A15
		public unsafe Il2CppStructArray<byte> io_buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_io_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_io_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr_feeder;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_base_stream;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_z_stream;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_io_buffer;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_CheckResult_Private_Static_Void_Int32_String_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0;

		// Token: 0x020001C1 RID: 449
		public sealed class UnmanagedReadOrWrite : MulticastDelegate
		{
			// Token: 0x0600193C RID: 6460 RVA: 0x0006CA34 File Offset: 0x0006AC34
			// Note: this type is marked as 'beforefieldinit'.
			static UnmanagedReadOrWrite()
			{
				Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "UnmanagedReadOrWrite");
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100664878);
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100664879);
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100664880);
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100664881);
			}

			// Token: 0x0600193D RID: 6461 RVA: 0x0006CAA8 File Offset: 0x0006ACA8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnmanagedReadOrWrite(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600193E RID: 6462 RVA: 0x0006CB04 File Offset: 0x0006AD04
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr buffer, int length, IntPtr data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref buffer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600193F RID: 6463 RVA: 0x0006CB6C File Offset: 0x0006AD6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375124, XrefRangeEnd = 375133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref buffer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001940 RID: 6464 RVA: 0x0006CBFC File Offset: 0x0006ADFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001941 RID: 6465 RVA: 0x0000D037 File Offset: 0x0000B237
			public UnmanagedReadOrWrite(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001942 RID: 6466 RVA: 0x0000D040 File Offset: 0x0000B240
			public static implicit operator DeflateStreamNative.UnmanagedReadOrWrite(Func<IntPtr, int, IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DeflateStreamNative.UnmanagedReadOrWrite>(A_0);
			}

			// Token: 0x06001943 RID: 6467 RVA: 0x0000D048 File Offset: 0x0000B248
			public static DeflateStreamNative.UnmanagedReadOrWrite operator +(DeflateStreamNative.UnmanagedReadOrWrite A_0, DeflateStreamNative.UnmanagedReadOrWrite A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DeflateStreamNative.UnmanagedReadOrWrite>();
			}

			// Token: 0x06001944 RID: 6468 RVA: 0x0000D056 File Offset: 0x0000B256
			public static DeflateStreamNative.UnmanagedReadOrWrite operator -(DeflateStreamNative.UnmanagedReadOrWrite A_0, DeflateStreamNative.UnmanagedReadOrWrite A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DeflateStreamNative.UnmanagedReadOrWrite>();
				}
				return delegate2;
			}

			// Token: 0x040013FD RID: 5117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040013FE RID: 5118
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0;

			// Token: 0x040013FF RID: 5119
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001400 RID: 5120
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x020001C2 RID: 450
		public sealed class SafeDeflateStreamHandle : SafeHandle
		{
			// Token: 0x06001945 RID: 6469 RVA: 0x0006CC4C File Offset: 0x0006AE4C
			// Note: this type is marked as 'beforefieldinit'.
			static SafeDeflateStreamHandle()
			{
				Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "SafeDeflateStreamHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100664882);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100664883);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100664884);
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x06001946 RID: 6470 RVA: 0x0006CCB4 File Offset: 0x0006AEB4
			public unsafe override bool IsInvalid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375133, XrefRangeEnd = 375134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001947 RID: 6471 RVA: 0x0006CCF0 File Offset: 0x0006AEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375134, XrefRangeEnd = 375136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SafeDeflateStreamHandle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001948 RID: 6472 RVA: 0x0006CD2C File Offset: 0x0006AF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375136, XrefRangeEnd = 375137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001949 RID: 6473 RVA: 0x0000D067 File Offset: 0x0000B267
			public SafeDeflateStreamHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001401 RID: 5121
			private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;

			// Token: 0x04001402 RID: 5122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04001403 RID: 5123
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
