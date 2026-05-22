using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020D RID: 525
	[Serializable]
	public class Stream : MarshalByRefObject
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x000BCCDC File Offset: 0x000BAEDC
		// Note: this type is marked as 'beforefieldinit'.
		static Stream()
		{
			Il2CppClassPointerStore<Stream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Stream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream>.NativeClassPtr);
			Stream.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "Null");
			Stream.NativeFieldInfoPtr__activeReadWriteTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "_activeReadWriteTask");
			Stream.NativeFieldInfoPtr__asyncActiveSemaphore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "_asyncActiveSemaphore");
			Stream.NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668968);
			Stream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668969);
			Stream.NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668970);
			Stream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668971);
			Stream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668972);
			Stream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668973);
			Stream.NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668974);
			Stream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668975);
			Stream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668976);
			Stream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668977);
			Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668978);
			Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668979);
			Stream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_New_Task_Stream_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668980);
			Stream.NativeMethodInfoPtr_CopyToAsyncInternal_Private_Task_Stream_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668981);
			Stream.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668982);
			Stream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668983);
			Stream.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668984);
			Stream.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668985);
			Stream.NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668986);
			Stream.NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668987);
			Stream.NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668988);
			Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668989);
			Stream.NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668990);
			Stream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668991);
			Stream.NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668992);
			Stream.NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668993);
			Stream.NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668994);
			Stream.NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668995);
			Stream.NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668996);
			Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668997);
			Stream.NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668998);
			Stream.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668999);
			Stream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669000);
			Stream.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669001);
			Stream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669002);
			Stream.NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669003);
			Stream.NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669004);
			Stream.NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669005);
			Stream.NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669006);
			Stream.NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669007);
			Stream.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100669008);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x000BD07C File Offset: 0x000BB27C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 190912, RefRangeEnd = 190916, XrefRangeStart = 190897, XrefRangeEnd = 190912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000BD0BC File Offset: 0x000BB2BC
		public unsafe virtual bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x000BD104 File Offset: 0x000BB304
		public unsafe virtual bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000BD14C File Offset: 0x000BB34C
		public unsafe virtual bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x000BD194 File Offset: 0x000BB394
		public unsafe virtual long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x000BD1DC File Offset: 0x000BB3DC
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x000BD224 File Offset: 0x000BB424
		public unsafe virtual long Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x000BD270 File Offset: 0x000BB470
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x000BD2B8 File Offset: 0x000BB4B8
		public unsafe virtual int ReadTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190916, XrefRangeEnd = 190923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190923, XrefRangeEnd = 190930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x000BD304 File Offset: 0x000BB504
		public unsafe virtual int WriteTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190930, XrefRangeEnd = 190937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000BD34C File Offset: 0x000BB54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190937, XrefRangeEnd = 190940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsync(Stream destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000BD39C File Offset: 0x000BB59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190940, XrefRangeEnd = 190943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsync(Stream destination, int bufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000BD3FC File Offset: 0x000BB5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190943, XrefRangeEnd = 190987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_New_Task_Stream_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000BD47C File Offset: 0x000BB67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190996, RefRangeEnd = 190997, XrefRangeStart = 190987, XrefRangeEnd = 190996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_CopyToAsyncInternal_Private_Task_Stream_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000BD4F4 File Offset: 0x000BB6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190997, XrefRangeEnd = 191001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000BD530 File Offset: 0x000BB730
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000BD564 File Offset: 0x000BB764
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000BD5B0 File Offset: 0x000BB7B0
		[CallerCount(0)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000BD5EC File Offset: 0x000BB7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191001, XrefRangeEnd = 191002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000BD68C File Offset: 0x000BB88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191028, RefRangeEnd = 191029, XrefRangeStart = 191002, XrefRangeEnd = 191028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReadInternal(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state, bool serializeAsynchronously)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serializeAsynchronously;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000BD72C File Offset: 0x000BB92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191029, XrefRangeEnd = 191040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000BD784 File Offset: 0x000BB984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191047, RefRangeEnd = 191048, XrefRangeStart = 191040, XrefRangeEnd = 191047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000BD814 File Offset: 0x000BBA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191076, RefRangeEnd = 191077, XrefRangeStart = 191048, XrefRangeEnd = 191076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> BeginEndReadAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000BD880 File Offset: 0x000BBA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191077, XrefRangeEnd = 191078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000BD920 File Offset: 0x000BBB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191104, RefRangeEnd = 191105, XrefRangeStart = 191078, XrefRangeEnd = 191104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginWriteInternal(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state, bool serializeAsynchronously)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serializeAsynchronously;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000BD9C0 File Offset: 0x000BBBC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191130, RefRangeEnd = 191132, XrefRangeStart = 191105, XrefRangeEnd = 191130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncWaiter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readWriteTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000BDA14 File Offset: 0x000BBC14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191138, RefRangeEnd = 191141, XrefRangeStart = 191132, XrefRangeEnd = 191138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readWriteTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000BDA58 File Offset: 0x000BBC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191156, RefRangeEnd = 191157, XrefRangeStart = 191141, XrefRangeEnd = 191156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000BDAA8 File Offset: 0x000BBCA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191160, RefRangeEnd = 191162, XrefRangeStart = 191157, XrefRangeEnd = 191160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000BDB14 File Offset: 0x000BBD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191168, RefRangeEnd = 191169, XrefRangeStart = 191162, XrefRangeEnd = 191168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000BDBA4 File Offset: 0x000BBDA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191197, RefRangeEnd = 191198, XrefRangeStart = 191169, XrefRangeEnd = 191197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task BeginEndWriteAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000BDC10 File Offset: 0x000BBE10
		[CallerCount(0)]
		public unsafe virtual long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x000BDC74 File Offset: 0x000BBE74
		[CallerCount(0)]
		public unsafe virtual int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000BDCFC File Offset: 0x000BBEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191198, XrefRangeEnd = 191201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000BDD44 File Offset: 0x000BBF44
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x000BDDB0 File Offset: 0x000BBFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191201, XrefRangeEnd = 191204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000BDDFC File Offset: 0x000BBFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191212, RefRangeEnd = 191213, XrefRangeStart = 191204, XrefRangeEnd = 191212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BlockingBeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000BDE90 File Offset: 0x000BC090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BlockingEndRead(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000BDED4 File Offset: 0x000BC0D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191221, RefRangeEnd = 191222, XrefRangeStart = 191213, XrefRangeEnd = 191221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BlockingBeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000BDF68 File Offset: 0x000BC168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190841, RefRangeEnd = 190842, XrefRangeStart = 190841, XrefRangeEnd = 190842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockingEndWrite(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x000BDFA0 File Offset: 0x000BC1A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0000B4FB File Offset: 0x000096FB
		public Stream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x000BDFDC File Offset: 0x000BC1DC
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x0000B504 File Offset: 0x00009704
		public unsafe static Stream Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Stream.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stream.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x000BE004 File Offset: 0x000BC204
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x0000B516 File Offset: 0x00009716
		public unsafe Stream.ReadWriteTask _activeReadWriteTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__activeReadWriteTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.ReadWriteTask>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__activeReadWriteTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x000BE034 File Offset: 0x000BC234
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x0000B535 File Offset: 0x00009735
		public unsafe SemaphoreSlim _asyncActiveSemaphore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__asyncActiveSemaphore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__asyncActiveSemaphore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeFieldInfoPtr__activeReadWriteTask;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeFieldInfoPtr__asyncActiveSemaphore;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_Int32_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Virtual_New_Task_Stream_Int32_CancellationToken_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsyncInternal_Private_Task_Stream_Int32_CancellationToken_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020005D1 RID: 1489
		public sealed class ReadWriteParameters : ValueType
		{
			// Token: 0x060052E2 RID: 21218 RVA: 0x00176044 File Offset: 0x00174244
			// Note: this type is marked as 'beforefieldinit'.
			static ReadWriteParameters()
			{
				Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "ReadWriteParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr);
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Buffer");
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Offset");
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Count");
			}

			// Token: 0x060052E3 RID: 21219 RVA: 0x0001F30C File Offset: 0x0001D50C
			public ReadWriteParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060052E4 RID: 21220 RVA: 0x0001F315 File Offset: 0x0001D515
			public ReadWriteParameters()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr))
			{
			}

			// Token: 0x17001542 RID: 5442
			// (get) Token: 0x060052E5 RID: 21221 RVA: 0x001760AC File Offset: 0x001742AC
			// (set) Token: 0x060052E6 RID: 21222 RVA: 0x0001F327 File Offset: 0x0001D527
			public unsafe Il2CppStructArray<byte> Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001543 RID: 5443
			// (get) Token: 0x060052E7 RID: 21223 RVA: 0x001760DC File Offset: 0x001742DC
			// (set) Token: 0x060052E8 RID: 21224 RVA: 0x0001F346 File Offset: 0x0001D546
			public unsafe int Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x17001544 RID: 5444
			// (get) Token: 0x060052E9 RID: 21225 RVA: 0x00176104 File Offset: 0x00174304
			// (set) Token: 0x060052EA RID: 21226 RVA: 0x0001F361 File Offset: 0x0001D561
			public unsafe int Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Count)) = value;
				}
			}

			// Token: 0x0400432D RID: 17197
			private static readonly IntPtr NativeFieldInfoPtr_Buffer;

			// Token: 0x0400432E RID: 17198
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x0400432F RID: 17199
			private static readonly IntPtr NativeFieldInfoPtr_Count;
		}

		// Token: 0x020005D2 RID: 1490
		public sealed class ReadWriteTask : Task<int>
		{
			// Token: 0x060052EB RID: 21227 RVA: 0x0017612C File Offset: 0x0017432C
			// Note: this type is marked as 'beforefieldinit'.
			static ReadWriteTask()
			{
				Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "ReadWriteTask");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr);
				Stream.ReadWriteTask.NativeFieldInfoPtr__isRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_isRead");
				Stream.ReadWriteTask.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_stream");
				Stream.ReadWriteTask.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_buffer");
				Stream.ReadWriteTask.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_offset");
				Stream.ReadWriteTask.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_count");
				Stream.ReadWriteTask.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_callback");
				Stream.ReadWriteTask.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_context");
				Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "s_invokeAsyncCallback");
				Stream.ReadWriteTask.NativeMethodInfoPtr_ClearBeginState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100669010);
				Stream.ReadWriteTask.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100669011);
				Stream.ReadWriteTask.NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100669012);
				Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100669013);
			}

			// Token: 0x060052EC RID: 21228 RVA: 0x00176248 File Offset: 0x00174448
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190729, RefRangeEnd = 190731, XrefRangeStart = 190729, XrefRangeEnd = 190729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearBeginState()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_ClearBeginState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052ED RID: 21229 RVA: 0x0017627C File Offset: 0x0017447C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190747, RefRangeEnd = 190749, XrefRangeStart = 190731, XrefRangeEnd = 190747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadWriteTask(bool isRead, Func<Object, int> function, Object state, Stream stream, Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isRead;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052EE RID: 21230 RVA: 0x0017633C File Offset: 0x0017453C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190749, XrefRangeEnd = 190754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InvokeAsyncCallback(Object completedTask)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052EF RID: 21231 RVA: 0x00176374 File Offset: 0x00174574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190754, XrefRangeEnd = 190774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Threading_Tasks_ITaskCompletionAction_Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052F0 RID: 21232 RVA: 0x0001F37C File Offset: 0x0001D57C
			public ReadWriteTask(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001545 RID: 5445
			// (get) Token: 0x060052F1 RID: 21233 RVA: 0x001763B8 File Offset: 0x001745B8
			// (set) Token: 0x060052F2 RID: 21234 RVA: 0x0001F385 File Offset: 0x0001D585
			public unsafe bool _isRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__isRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__isRead)) = value;
				}
			}

			// Token: 0x17001546 RID: 5446
			// (get) Token: 0x060052F3 RID: 21235 RVA: 0x001763E0 File Offset: 0x001745E0
			// (set) Token: 0x060052F4 RID: 21236 RVA: 0x0001F3A0 File Offset: 0x0001D5A0
			public unsafe Stream _stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001547 RID: 5447
			// (get) Token: 0x060052F5 RID: 21237 RVA: 0x00176410 File Offset: 0x00174610
			// (set) Token: 0x060052F6 RID: 21238 RVA: 0x0001F3BF File Offset: 0x0001D5BF
			public unsafe Il2CppStructArray<byte> _buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001548 RID: 5448
			// (get) Token: 0x060052F7 RID: 21239 RVA: 0x00176440 File Offset: 0x00174640
			// (set) Token: 0x060052F8 RID: 21240 RVA: 0x0001F3DE File Offset: 0x0001D5DE
			public unsafe int _offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__offset)) = value;
				}
			}

			// Token: 0x17001549 RID: 5449
			// (get) Token: 0x060052F9 RID: 21241 RVA: 0x00176468 File Offset: 0x00174668
			// (set) Token: 0x060052FA RID: 21242 RVA: 0x0001F3F9 File Offset: 0x0001D5F9
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x1700154A RID: 5450
			// (get) Token: 0x060052FB RID: 21243 RVA: 0x00176490 File Offset: 0x00174690
			// (set) Token: 0x060052FC RID: 21244 RVA: 0x0001F414 File Offset: 0x0001D614
			public unsafe AsyncCallback _callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700154B RID: 5451
			// (get) Token: 0x060052FD RID: 21245 RVA: 0x001764C0 File Offset: 0x001746C0
			// (set) Token: 0x060052FE RID: 21246 RVA: 0x0001F433 File Offset: 0x0001D633
			public unsafe ExecutionContext _context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700154C RID: 5452
			// (get) Token: 0x060052FF RID: 21247 RVA: 0x001764F0 File Offset: 0x001746F0
			// (set) Token: 0x06005300 RID: 21248 RVA: 0x0001F452 File Offset: 0x0001D652
			public unsafe static ContextCallback s_invokeAsyncCallback
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004330 RID: 17200
			private static readonly IntPtr NativeFieldInfoPtr__isRead;

			// Token: 0x04004331 RID: 17201
			private static readonly IntPtr NativeFieldInfoPtr__stream;

			// Token: 0x04004332 RID: 17202
			private static readonly IntPtr NativeFieldInfoPtr__buffer;

			// Token: 0x04004333 RID: 17203
			private static readonly IntPtr NativeFieldInfoPtr__offset;

			// Token: 0x04004334 RID: 17204
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x04004335 RID: 17205
			private static readonly IntPtr NativeFieldInfoPtr__callback;

			// Token: 0x04004336 RID: 17206
			private static readonly IntPtr NativeFieldInfoPtr__context;

			// Token: 0x04004337 RID: 17207
			private static readonly IntPtr NativeFieldInfoPtr_s_invokeAsyncCallback;

			// Token: 0x04004338 RID: 17208
			private static readonly IntPtr NativeMethodInfoPtr_ClearBeginState_Internal_Void_0;

			// Token: 0x04004339 RID: 17209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0;

			// Token: 0x0400433A RID: 17210
			private static readonly IntPtr NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0;

			// Token: 0x0400433B RID: 17211
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0;
		}

		// Token: 0x020005D3 RID: 1491
		[Serializable]
		public sealed class NullStream : Stream
		{
			// Token: 0x06005301 RID: 21249 RVA: 0x00176518 File Offset: 0x00174718
			// Note: this type is marked as 'beforefieldinit'.
			static NullStream()
			{
				Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "NullStream");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr);
				Stream.NullStream.NativeFieldInfoPtr_s_nullReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, "s_nullReadTask");
				Stream.NullStream.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669014);
				Stream.NullStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669015);
				Stream.NullStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669016);
				Stream.NullStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669017);
				Stream.NullStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669018);
				Stream.NullStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669019);
				Stream.NullStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669020);
				Stream.NullStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669021);
				Stream.NullStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669022);
				Stream.NullStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669023);
				Stream.NullStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669024);
				Stream.NullStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669025);
				Stream.NullStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669026);
				Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669027);
				Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669028);
				Stream.NullStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669029);
				Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669030);
				Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669031);
				Stream.NullStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669032);
				Stream.NullStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100669033);
			}

			// Token: 0x06005302 RID: 21250 RVA: 0x001766E8 File Offset: 0x001748E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190774, XrefRangeEnd = 190777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullStream()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700154E RID: 5454
			// (get) Token: 0x06005303 RID: 21251 RVA: 0x00176724 File Offset: 0x00174924
			public unsafe override bool CanRead
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700154F RID: 5455
			// (get) Token: 0x06005304 RID: 21252 RVA: 0x00176760 File Offset: 0x00174960
			public unsafe override bool CanWrite
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001550 RID: 5456
			// (get) Token: 0x06005305 RID: 21253 RVA: 0x0017679C File Offset: 0x0017499C
			public unsafe override bool CanSeek
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001551 RID: 5457
			// (get) Token: 0x06005306 RID: 21254 RVA: 0x001767D8 File Offset: 0x001749D8
			public unsafe override long Length
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001552 RID: 5458
			// (get) Token: 0x06005307 RID: 21255 RVA: 0x00176814 File Offset: 0x00174A14
			// (set) Token: 0x06005308 RID: 21256 RVA: 0x00176850 File Offset: 0x00174A50
			public unsafe override long Position
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005309 RID: 21257 RVA: 0x00176890 File Offset: 0x00174A90
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600530A RID: 21258 RVA: 0x001768D0 File Offset: 0x00174AD0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600530B RID: 21259 RVA: 0x00176904 File Offset: 0x00174B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190777, XrefRangeEnd = 190779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600530C RID: 21260 RVA: 0x00176998 File Offset: 0x00174B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190779, XrefRangeEnd = 190784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int EndRead(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600530D RID: 21261 RVA: 0x001769E8 File Offset: 0x00174BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190784, XrefRangeEnd = 190786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600530E RID: 21262 RVA: 0x00176A7C File Offset: 0x00174C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190786, XrefRangeEnd = 190791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void EndWrite(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600530F RID: 21263 RVA: 0x00176AC0 File Offset: 0x00174CC0
			[CallerCount(0)]
			public unsafe override int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06005310 RID: 21264 RVA: 0x00176B3C File Offset: 0x00174D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190791, XrefRangeEnd = 190805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
			}

			// Token: 0x06005311 RID: 21265 RVA: 0x00176BC0 File Offset: 0x00174DC0
			[CallerCount(0)]
			public unsafe override int ReadByte()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005312 RID: 21266 RVA: 0x00176BFC File Offset: 0x00174DFC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005313 RID: 21267 RVA: 0x00176C5C File Offset: 0x00174E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190805, XrefRangeEnd = 190812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06005314 RID: 21268 RVA: 0x00176CE0 File Offset: 0x00174EE0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteByte(byte value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005315 RID: 21269 RVA: 0x00176D20 File Offset: 0x00174F20
			[CallerCount(0)]
			public unsafe override long Seek(long offset, SeekOrigin origin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005316 RID: 21270 RVA: 0x0001F464 File Offset: 0x0001D664
			public NullStream(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700154D RID: 5453
			// (get) Token: 0x06005317 RID: 21271 RVA: 0x00176D78 File Offset: 0x00174F78
			// (set) Token: 0x06005318 RID: 21272 RVA: 0x0001F46D File Offset: 0x0001D66D
			public unsafe static Task<int> s_nullReadTask
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.NullStream.NativeFieldInfoPtr_s_nullReadTask, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.NullStream.NativeFieldInfoPtr_s_nullReadTask, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400433C RID: 17212
			private static readonly IntPtr NativeFieldInfoPtr_s_nullReadTask;

			// Token: 0x0400433D RID: 17213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x0400433E RID: 17214
			private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

			// Token: 0x0400433F RID: 17215
			private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

			// Token: 0x04004340 RID: 17216
			private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

			// Token: 0x04004341 RID: 17217
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

			// Token: 0x04004342 RID: 17218
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

			// Token: 0x04004343 RID: 17219
			private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

			// Token: 0x04004344 RID: 17220
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004345 RID: 17221
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x04004346 RID: 17222
			private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04004347 RID: 17223
			private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

			// Token: 0x04004348 RID: 17224
			private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04004349 RID: 17225
			private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

			// Token: 0x0400434A RID: 17226
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x0400434B RID: 17227
			private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

			// Token: 0x0400434C RID: 17228
			private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

			// Token: 0x0400434D RID: 17229
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x0400434E RID: 17230
			private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

			// Token: 0x0400434F RID: 17231
			private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

			// Token: 0x04004350 RID: 17232
			private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;
		}

		// Token: 0x020005D4 RID: 1492
		public sealed class SynchronousAsyncResult : Object
		{
			// Token: 0x06005319 RID: 21273 RVA: 0x00176DA0 File Offset: 0x00174FA0
			// Note: this type is marked as 'beforefieldinit'.
			static SynchronousAsyncResult()
			{
				Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "SynchronousAsyncResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr);
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_stateObject");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_isWrite");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_waitHandle");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_exceptionInfo");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_endXxxCalled");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_bytesRead");
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669034);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669035);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669036);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669037);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669038);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669039);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669040);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_ThrowIfError_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669041);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669042);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100669043);
			}

			// Token: 0x0600531A RID: 21274 RVA: 0x00176F0C File Offset: 0x0017510C
			[CallerCount(0)]
			public unsafe SynchronousAsyncResult(int bytesRead, Object asyncStateObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bytesRead;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600531B RID: 21275 RVA: 0x00176F68 File Offset: 0x00175168
			[CallerCount(0)]
			public unsafe SynchronousAsyncResult(Object asyncStateObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600531C RID: 21276 RVA: 0x00176FB4 File Offset: 0x001751B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190820, RefRangeEnd = 190822, XrefRangeStart = 190816, XrefRangeEnd = 190820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronousAsyncResult(Exception ex, Object asyncStateObject, bool isWrite)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWrite;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001559 RID: 5465
			// (get) Token: 0x0600531D RID: 21277 RVA: 0x00177020 File Offset: 0x00175220
			public unsafe bool IsCompleted
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700155A RID: 5466
			// (get) Token: 0x0600531E RID: 21278 RVA: 0x0017705C File Offset: 0x0017525C
			public unsafe WaitHandle AsyncWaitHandle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190822, XrefRangeEnd = 190837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
				}
			}

			// Token: 0x1700155B RID: 5467
			// (get) Token: 0x0600531F RID: 21279 RVA: 0x0017709C File Offset: 0x0017529C
			public unsafe Object AsyncState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700155C RID: 5468
			// (get) Token: 0x06005320 RID: 21280 RVA: 0x001770DC File Offset: 0x001752DC
			public unsafe bool CompletedSynchronously
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005321 RID: 21281 RVA: 0x00177118 File Offset: 0x00175318
			[CallerCount(0)]
			public unsafe void ThrowIfError()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_ThrowIfError_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005322 RID: 21282 RVA: 0x0017714C File Offset: 0x0017534C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190837, XrefRangeEnd = 190839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EndRead(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005323 RID: 21283 RVA: 0x00177190 File Offset: 0x00175390
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190841, RefRangeEnd = 190842, XrefRangeStart = 190839, XrefRangeEnd = 190841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EndWrite(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005324 RID: 21284 RVA: 0x0001F47F File Offset: 0x0001D67F
			public SynchronousAsyncResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001553 RID: 5459
			// (get) Token: 0x06005325 RID: 21285 RVA: 0x001771C8 File Offset: 0x001753C8
			// (set) Token: 0x06005326 RID: 21286 RVA: 0x0001F488 File Offset: 0x0001D688
			public unsafe Object _stateObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001554 RID: 5460
			// (get) Token: 0x06005327 RID: 21287 RVA: 0x001771F8 File Offset: 0x001753F8
			// (set) Token: 0x06005328 RID: 21288 RVA: 0x0001F4A7 File Offset: 0x0001D6A7
			public unsafe bool _isWrite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite)) = value;
				}
			}

			// Token: 0x17001555 RID: 5461
			// (get) Token: 0x06005329 RID: 21289 RVA: 0x00177220 File Offset: 0x00175420
			// (set) Token: 0x0600532A RID: 21290 RVA: 0x0001F4C2 File Offset: 0x0001D6C2
			public unsafe ManualResetEvent _waitHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001556 RID: 5462
			// (get) Token: 0x0600532B RID: 21291 RVA: 0x00177250 File Offset: 0x00175450
			// (set) Token: 0x0600532C RID: 21292 RVA: 0x0001F4E1 File Offset: 0x0001D6E1
			public unsafe ExceptionDispatchInfo _exceptionInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001557 RID: 5463
			// (get) Token: 0x0600532D RID: 21293 RVA: 0x00177280 File Offset: 0x00175480
			// (set) Token: 0x0600532E RID: 21294 RVA: 0x0001F500 File Offset: 0x0001D700
			public unsafe bool _endXxxCalled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled)) = value;
				}
			}

			// Token: 0x17001558 RID: 5464
			// (get) Token: 0x0600532F RID: 21295 RVA: 0x001772A8 File Offset: 0x001754A8
			// (set) Token: 0x06005330 RID: 21296 RVA: 0x0001F51B File Offset: 0x0001D71B
			public unsafe int _bytesRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead)) = value;
				}
			}

			// Token: 0x04004351 RID: 17233
			private static readonly IntPtr NativeFieldInfoPtr__stateObject;

			// Token: 0x04004352 RID: 17234
			private static readonly IntPtr NativeFieldInfoPtr__isWrite;

			// Token: 0x04004353 RID: 17235
			private static readonly IntPtr NativeFieldInfoPtr__waitHandle;

			// Token: 0x04004354 RID: 17236
			private static readonly IntPtr NativeFieldInfoPtr__exceptionInfo;

			// Token: 0x04004355 RID: 17237
			private static readonly IntPtr NativeFieldInfoPtr__endXxxCalled;

			// Token: 0x04004356 RID: 17238
			private static readonly IntPtr NativeFieldInfoPtr__bytesRead;

			// Token: 0x04004357 RID: 17239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

			// Token: 0x04004358 RID: 17240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_0;

			// Token: 0x04004359 RID: 17241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0;

			// Token: 0x0400435A RID: 17242
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400435B RID: 17243
			private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

			// Token: 0x0400435C RID: 17244
			private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400435D RID: 17245
			private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400435E RID: 17246
			private static readonly IntPtr NativeMethodInfoPtr_ThrowIfError_Internal_Void_0;

			// Token: 0x0400435F RID: 17247
			private static readonly IntPtr NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0;

			// Token: 0x04004360 RID: 17248
			private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0;

			// Token: 0x020006CD RID: 1741
			[ObfuscatedName("System.IO.Stream+SynchronousAsyncResult+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060059BE RID: 22974 RVA: 0x0018C8D8 File Offset: 0x0018AAD8
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr);
					Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, "<>9");
					Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, "<>9__12_0");
					Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, 100669045);
					Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, 100669046);
				}

				// Token: 0x060059BF RID: 22975 RVA: 0x0018C954 File Offset: 0x0018AB54
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060059C0 RID: 22976 RVA: 0x0018C990 File Offset: 0x0018AB90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190812, XrefRangeEnd = 190816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ManualResetEvent _get_AsyncWaitHandle_b__12_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr3) : null;
				}

				// Token: 0x060059C1 RID: 22977 RVA: 0x00022AF8 File Offset: 0x00020CF8
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700171D RID: 5917
				// (get) Token: 0x060059C2 RID: 22978 RVA: 0x0018C9D0 File Offset: 0x0018ABD0
				// (set) Token: 0x060059C3 RID: 22979 RVA: 0x00022B01 File Offset: 0x00020D01
				public unsafe static Stream.SynchronousAsyncResult.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.SynchronousAsyncResult.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700171E RID: 5918
				// (get) Token: 0x060059C4 RID: 22980 RVA: 0x0018C9F8 File Offset: 0x0018ABF8
				// (set) Token: 0x060059C5 RID: 22981 RVA: 0x00022B13 File Offset: 0x00020D13
				public unsafe static Func<ManualResetEvent> __9__12_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ManualResetEvent>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040047AB RID: 18347
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040047AC RID: 18348
				private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

				// Token: 0x040047AD RID: 18349
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040047AE RID: 18350
				private static readonly IntPtr NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0;
			}
		}

		// Token: 0x020005D5 RID: 1493
		[ObfuscatedName("System.IO.Stream+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005331 RID: 21297 RVA: 0x001772D0 File Offset: 0x001754D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Stream.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr);
				Stream.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9");
				Stream.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__4_0");
				Stream.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__39_0");
				Stream.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__43_0");
				Stream.__c.NativeFieldInfoPtr___9__43_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__43_1");
				Stream.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__46_0");
				Stream.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__47_0");
				Stream.__c.NativeFieldInfoPtr___9__53_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__53_0");
				Stream.__c.NativeFieldInfoPtr___9__53_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__53_1");
				Stream.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669048);
				Stream.__c.NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669049);
				Stream.__c.NativeMethodInfoPtr__BeginReadInternal_b__39_0_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669050);
				Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669051);
				Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_1_Internal_Int32_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669052);
				Stream.__c.NativeMethodInfoPtr__BeginWriteInternal_b__46_0_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669053);
				Stream.__c.NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__47_0_Internal_Void_Task_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669054);
				Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669055);
				Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_1_Internal_VoidTaskResult_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100669056);
			}

			// Token: 0x06005332 RID: 21298 RVA: 0x00177464 File Offset: 0x00175664
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005333 RID: 21299 RVA: 0x001774A0 File Offset: 0x001756A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190842, XrefRangeEnd = 190846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SemaphoreSlim _EnsureAsyncActiveSemaphoreInitialized_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
			}

			// Token: 0x06005334 RID: 21300 RVA: 0x001774E0 File Offset: 0x001756E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190846, XrefRangeEnd = 190853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginReadInternal_b__39_0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginReadInternal_b__39_0_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005335 RID: 21301 RVA: 0x00177530 File Offset: 0x00175730
			[CallerCount(0)]
			public unsafe IAsyncResult _BeginEndReadAsync_b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005336 RID: 21302 RVA: 0x001775BC File Offset: 0x001757BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190853, XrefRangeEnd = 190854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginEndReadAsync_b__43_1(Stream stream, IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_1_Internal_Int32_Stream_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005337 RID: 21303 RVA: 0x0017761C File Offset: 0x0017581C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190854, XrefRangeEnd = 190861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginWriteInternal_b__46_0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginWriteInternal_b__46_0_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005338 RID: 21304 RVA: 0x0017766C File Offset: 0x0017586C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190861, XrefRangeEnd = 190868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunReadWriteTaskWhenReady_b__47_0(Task t, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__47_0_Internal_Void_Task_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005339 RID: 21305 RVA: 0x001776C0 File Offset: 0x001758C0
			[CallerCount(0)]
			public unsafe IAsyncResult _BeginEndWriteAsync_b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600533A RID: 21306 RVA: 0x0017774C File Offset: 0x0017594C
			[CallerCount(0)]
			public unsafe VoidTaskResult _BeginEndWriteAsync_b__53_1(Stream stream, IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_1_Internal_VoidTaskResult_Stream_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600533B RID: 21307 RVA: 0x0001F536 File Offset: 0x0001D736
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700155D RID: 5469
			// (get) Token: 0x0600533C RID: 21308 RVA: 0x001777AC File Offset: 0x001759AC
			// (set) Token: 0x0600533D RID: 21309 RVA: 0x0001F53F File Offset: 0x0001D73F
			public unsafe static Stream.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155E RID: 5470
			// (get) Token: 0x0600533E RID: 21310 RVA: 0x001777D4 File Offset: 0x001759D4
			// (set) Token: 0x0600533F RID: 21311 RVA: 0x0001F551 File Offset: 0x0001D751
			public unsafe static Func<SemaphoreSlim> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SemaphoreSlim>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155F RID: 5471
			// (get) Token: 0x06005340 RID: 21312 RVA: 0x001777FC File Offset: 0x001759FC
			// (set) Token: 0x06005341 RID: 21313 RVA: 0x0001F563 File Offset: 0x0001D763
			public unsafe static Func<Object, int> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001560 RID: 5472
			// (get) Token: 0x06005342 RID: 21314 RVA: 0x00177824 File Offset: 0x00175A24
			// (set) Token: 0x06005343 RID: 21315 RVA: 0x0001F575 File Offset: 0x0001D775
			public unsafe static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001561 RID: 5473
			// (get) Token: 0x06005344 RID: 21316 RVA: 0x0017784C File Offset: 0x00175A4C
			// (set) Token: 0x06005345 RID: 21317 RVA: 0x0001F587 File Offset: 0x0001D787
			public unsafe static Func<Stream, IAsyncResult, int> __9__43_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__43_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, IAsyncResult, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__43_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001562 RID: 5474
			// (get) Token: 0x06005346 RID: 21318 RVA: 0x00177874 File Offset: 0x00175A74
			// (set) Token: 0x06005347 RID: 21319 RVA: 0x0001F599 File Offset: 0x0001D799
			public unsafe static Func<Object, int> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001563 RID: 5475
			// (get) Token: 0x06005348 RID: 21320 RVA: 0x0017789C File Offset: 0x00175A9C
			// (set) Token: 0x06005349 RID: 21321 RVA: 0x0001F5AB File Offset: 0x0001D7AB
			public unsafe static Action<Task, Object> __9__47_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Task, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001564 RID: 5476
			// (get) Token: 0x0600534A RID: 21322 RVA: 0x001778C4 File Offset: 0x00175AC4
			// (set) Token: 0x0600534B RID: 21323 RVA: 0x0001F5BD File Offset: 0x0001D7BD
			public unsafe static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult> __9__53_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__53_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__53_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001565 RID: 5477
			// (get) Token: 0x0600534C RID: 21324 RVA: 0x001778EC File Offset: 0x00175AEC
			// (set) Token: 0x0600534D RID: 21325 RVA: 0x0001F5CF File Offset: 0x0001D7CF
			public unsafe static Func<Stream, IAsyncResult, VoidTaskResult> __9__53_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__53_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, IAsyncResult, VoidTaskResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__53_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004361 RID: 17249
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004362 RID: 17250
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04004363 RID: 17251
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x04004364 RID: 17252
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04004365 RID: 17253
			private static readonly IntPtr NativeFieldInfoPtr___9__43_1;

			// Token: 0x04004366 RID: 17254
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x04004367 RID: 17255
			private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

			// Token: 0x04004368 RID: 17256
			private static readonly IntPtr NativeFieldInfoPtr___9__53_0;

			// Token: 0x04004369 RID: 17257
			private static readonly IntPtr NativeFieldInfoPtr___9__53_1;

			// Token: 0x0400436A RID: 17258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400436B RID: 17259
			private static readonly IntPtr NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0;

			// Token: 0x0400436C RID: 17260
			private static readonly IntPtr NativeMethodInfoPtr__BeginReadInternal_b__39_0_Internal_Int32_Object_0;

			// Token: 0x0400436D RID: 17261
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndReadAsync_b__43_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0;

			// Token: 0x0400436E RID: 17262
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndReadAsync_b__43_1_Internal_Int32_Stream_IAsyncResult_0;

			// Token: 0x0400436F RID: 17263
			private static readonly IntPtr NativeMethodInfoPtr__BeginWriteInternal_b__46_0_Internal_Int32_Object_0;

			// Token: 0x04004370 RID: 17264
			private static readonly IntPtr NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__47_0_Internal_Void_Task_Object_0;

			// Token: 0x04004371 RID: 17265
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndWriteAsync_b__53_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0;

			// Token: 0x04004372 RID: 17266
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndWriteAsync_b__53_1_Internal_VoidTaskResult_Stream_IAsyncResult_0;
		}

		// Token: 0x020005D6 RID: 1494
		[ObfuscatedName("System.IO.Stream+<CopyToAsyncInternal>d__27")]
		public sealed class _CopyToAsyncInternal_d__27 : ValueType
		{
			// Token: 0x0600534E RID: 21326 RVA: 0x00177914 File Offset: 0x00175B14
			// Note: this type is marked as 'beforefieldinit'.
			static _CopyToAsyncInternal_d__27()
			{
				Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "<CopyToAsyncInternal>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr);
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "<>1__state");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "<>t__builder");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "bufferSize");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "destination");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "<buffer>5__1");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr__bytesRead_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "<bytesRead>5__2");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "cancellationToken");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "<>4__this");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "<>u__1");
				Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, "<>u__2");
				Stream._CopyToAsyncInternal_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, 100669057);
				Stream._CopyToAsyncInternal_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr, 100669058);
			}

			// Token: 0x0600534F RID: 21327 RVA: 0x00177A30 File Offset: 0x00175C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190868, XrefRangeEnd = 190896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream._CopyToAsyncInternal_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005350 RID: 21328 RVA: 0x00177A68 File Offset: 0x00175C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190896, XrefRangeEnd = 190897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream._CopyToAsyncInternal_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005351 RID: 21329 RVA: 0x0001F5E1 File Offset: 0x0001D7E1
			public _CopyToAsyncInternal_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005352 RID: 21330 RVA: 0x0001F5EA File Offset: 0x0001D7EA
			public _CopyToAsyncInternal_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x17001566 RID: 5478
			// (get) Token: 0x06005353 RID: 21331 RVA: 0x00177AB0 File Offset: 0x00175CB0
			// (set) Token: 0x06005354 RID: 21332 RVA: 0x0001F5FC File Offset: 0x0001D7FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001567 RID: 5479
			// (get) Token: 0x06005355 RID: 21333 RVA: 0x00177AD8 File Offset: 0x00175CD8
			// (set) Token: 0x06005356 RID: 21334 RVA: 0x0001F617 File Offset: 0x0001D817
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001568 RID: 5480
			// (get) Token: 0x06005357 RID: 21335 RVA: 0x00177B08 File Offset: 0x00175D08
			// (set) Token: 0x06005358 RID: 21336 RVA: 0x0001F645 File Offset: 0x0001D845
			public unsafe int bufferSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_bufferSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_bufferSize)) = value;
				}
			}

			// Token: 0x17001569 RID: 5481
			// (get) Token: 0x06005359 RID: 21337 RVA: 0x00177B30 File Offset: 0x00175D30
			// (set) Token: 0x0600535A RID: 21338 RVA: 0x0001F660 File Offset: 0x0001D860
			public unsafe Stream destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700156A RID: 5482
			// (get) Token: 0x0600535B RID: 21339 RVA: 0x00177B60 File Offset: 0x00175D60
			// (set) Token: 0x0600535C RID: 21340 RVA: 0x0001F67F File Offset: 0x0001D87F
			public unsafe Il2CppStructArray<byte> _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr__buffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr__buffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700156B RID: 5483
			// (get) Token: 0x0600535D RID: 21341 RVA: 0x00177B90 File Offset: 0x00175D90
			// (set) Token: 0x0600535E RID: 21342 RVA: 0x0001F69E File Offset: 0x0001D89E
			public unsafe int _bytesRead_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr__bytesRead_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr__bytesRead_5__2)) = value;
				}
			}

			// Token: 0x1700156C RID: 5484
			// (get) Token: 0x0600535F RID: 21343 RVA: 0x00177BB8 File Offset: 0x00175DB8
			// (set) Token: 0x06005360 RID: 21344 RVA: 0x0001F6B9 File Offset: 0x0001D8B9
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700156D RID: 5485
			// (get) Token: 0x06005361 RID: 21345 RVA: 0x00177BE8 File Offset: 0x00175DE8
			// (set) Token: 0x06005362 RID: 21346 RVA: 0x0001F6E7 File Offset: 0x0001D8E7
			public unsafe Stream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700156E RID: 5486
			// (get) Token: 0x06005363 RID: 21347 RVA: 0x00177C18 File Offset: 0x00175E18
			// (set) Token: 0x06005364 RID: 21348 RVA: 0x0001F706 File Offset: 0x0001D906
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700156F RID: 5487
			// (get) Token: 0x06005365 RID: 21349 RVA: 0x00177C48 File Offset: 0x00175E48
			// (set) Token: 0x06005366 RID: 21350 RVA: 0x0001F734 File Offset: 0x0001D934
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__27.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004373 RID: 17267
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004374 RID: 17268
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004375 RID: 17269
			private static readonly IntPtr NativeFieldInfoPtr_bufferSize;

			// Token: 0x04004376 RID: 17270
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04004377 RID: 17271
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x04004378 RID: 17272
			private static readonly IntPtr NativeFieldInfoPtr__bytesRead_5__2;

			// Token: 0x04004379 RID: 17273
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400437A RID: 17274
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400437B RID: 17275
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400437C RID: 17276
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400437D RID: 17277
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400437E RID: 17278
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
