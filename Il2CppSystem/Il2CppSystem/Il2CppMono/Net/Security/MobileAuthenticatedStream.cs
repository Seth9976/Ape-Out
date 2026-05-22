using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000024 RID: 36
	public class MobileAuthenticatedStream : AuthenticatedStream
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00016790 File Offset: 0x00014990
		// Note: this type is marked as 'beforefieldinit'.
		static MobileAuthenticatedStream()
		{
			Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MobileAuthenticatedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr);
			MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "xobileTlsContext");
			MobileAuthenticatedStream.NativeFieldInfoPtr_lastException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "lastException");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncHandshakeRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncReadRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "asyncWriteRequest");
			MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "readBuffer");
			MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "writeBuffer");
			MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "ioLock");
			MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "closeRequested");
			MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "shutdown");
			MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "uniqueNameInteger");
			MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<SslStream>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<Settings>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<Provider>k__BackingField");
			MobileAuthenticatedStream.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "nextId");
			MobileAuthenticatedStream.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "ID");
			MobileAuthenticatedStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663651);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663652);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Provider_Public_Virtual_Final_New_get_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663653);
			MobileAuthenticatedStream.NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663654);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663655);
			MobileAuthenticatedStream.NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663656);
			MobileAuthenticatedStream.NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663657);
			MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Virtual_Final_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663658);
			MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663659);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_AuthenticatedStream_Public_Virtual_Final_New_get_AuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663660);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663661);
			MobileAuthenticatedStream.NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663662);
			MobileAuthenticatedStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663663);
			MobileAuthenticatedStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663664);
			MobileAuthenticatedStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663665);
			MobileAuthenticatedStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663666);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663667);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663668);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663669);
			MobileAuthenticatedStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663670);
			MobileAuthenticatedStream.NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663671);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663672);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663673);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663674);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663675);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663676);
			MobileAuthenticatedStream.NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663677);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663678);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663679);
			MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663680);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663681);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663682);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663683);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663684);
			MobileAuthenticatedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663685);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663686);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663687);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663688);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663689);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663690);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663691);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663692);
			MobileAuthenticatedStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663693);
			MobileAuthenticatedStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663694);
			MobileAuthenticatedStream.NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, 100663696);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00016C84 File Offset: 0x00014E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366203, RefRangeEnd = 366205, XrefRangeStart = 366188, XrefRangeEnd = 366203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00016D18 File Offset: 0x00014F18
		public unsafe MonoTlsSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00016D58 File Offset: 0x00014F58
		public unsafe virtual MonoTlsProvider Provider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_Provider_Public_Virtual_Final_New_get_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00016D98 File Offset: 0x00014F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366205, RefRangeEnd = 366206, XrefRangeStart = 366205, XrefRangeEnd = 366205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref authSuccessCheck;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shutdownCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00016DE4 File Offset: 0x00014FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366215, RefRangeEnd = 366216, XrefRangeStart = 366206, XrefRangeEnd = 366215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetSSPIException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00016E28 File Offset: 0x00015028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366224, RefRangeEnd = 366226, XrefRangeStart = 366216, XrefRangeEnd = 366224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetIOException(Exception e, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00016E80 File Offset: 0x00015080
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 366230, RefRangeEnd = 366233, XrefRangeStart = 366226, XrefRangeEnd = 366230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo SetException(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00016ED0 File Offset: 0x000150D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366233, XrefRangeEnd = 366236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClient_Public_Virtual_Final_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00016F40 File Offset: 0x00015140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366236, XrefRangeEnd = 366237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledSslProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkCertificateRevocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00016FC0 File Offset: 0x000151C0
		public unsafe virtual AuthenticatedStream AuthenticatedStream
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_AuthenticatedStream_Public_Virtual_Final_New_get_AuthenticatedStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00017000 File Offset: 0x00015200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366246, RefRangeEnd = 366248, XrefRangeStart = 366237, XrefRangeEnd = 366246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref runSynchronously;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledProtocols;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientCertRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000170B0 File Offset: 0x000152B0
		[CallerCount(0)]
		public unsafe virtual MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serverMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askForClientCert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr3) : null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001715C File Offset: 0x0001535C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366248, XrefRangeEnd = 366257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000171FC File Offset: 0x000153FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366257, XrefRangeEnd = 366259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00017254 File Offset: 0x00015454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366259, XrefRangeEnd = 366268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback asyncCallback, Object asyncState)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000172F4 File Offset: 0x000154F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366268, XrefRangeEnd = 366269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00017344 File Offset: 0x00015544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366269, XrefRangeEnd = 366279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000173B8 File Offset: 0x000155B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366279, XrefRangeEnd = 366289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00017424 File Offset: 0x00015624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366289, XrefRangeEnd = 366294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000174B4 File Offset: 0x000156B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366294, XrefRangeEnd = 366299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00017544 File Offset: 0x00015744
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 366309, RefRangeEnd = 366315, XrefRangeStart = 366299, XrefRangeEnd = 366309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000175BC File Offset: 0x000157BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366331, RefRangeEnd = 366332, XrefRangeStart = 366315, XrefRangeEnd = 366331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalRead(Il2CppStructArray<byte> buffer, int offset, int size, out bool outWantMore)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outWantMore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00017634 File Offset: 0x00015834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366332, XrefRangeEnd = 366335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, bool>(intPtr);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000176BC File Offset: 0x000158BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366344, RefRangeEnd = 366345, XrefRangeStart = 366335, XrefRangeEnd = 366344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWrite(Il2CppStructArray<byte> buffer, int offset, int size)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00017728 File Offset: 0x00015928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366348, RefRangeEnd = 366349, XrefRangeStart = 366345, XrefRangeEnd = 366348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000177B8 File Offset: 0x000159B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366359, RefRangeEnd = 366360, XrefRangeStart = 366349, XrefRangeEnd = 366359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sync;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001782C File Offset: 0x00015A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366369, RefRangeEnd = 366370, XrefRangeStart = 366360, XrefRangeEnd = 366369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InnerWrite(bool sync, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sync;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00017890 File Offset: 0x00015A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366374, RefRangeEnd = 366375, XrefRangeStart = 366370, XrefRangeEnd = 366374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000178DC File Offset: 0x00015ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366378, RefRangeEnd = 366379, XrefRangeStart = 366375, XrefRangeEnd = 366378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, bool>(intPtr);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00017924 File Offset: 0x00015B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366382, RefRangeEnd = 366383, XrefRangeStart = 366379, XrefRangeEnd = 366382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, bool>(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001796C File Offset: 0x00015B6C
		public unsafe override bool IsAuthenticated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366383, XrefRangeEnd = 366387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000179B4 File Offset: 0x00015BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366387, XrefRangeEnd = 366409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00017A00 File Offset: 0x00015C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366409, XrefRangeEnd = 366410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00017A3C File Offset: 0x00015C3C
		public unsafe virtual X509Certificate InternalLocalCertificate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366410, XrefRangeEnd = 366415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00017A7C File Offset: 0x00015C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366415, XrefRangeEnd = 366420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00017AE0 File Offset: 0x00015CE0
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00017B28 File Offset: 0x00015D28
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00017B70 File Offset: 0x00015D70
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00017BB8 File Offset: 0x00015DB8
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00017C00 File Offset: 0x00015E00
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00017C48 File Offset: 0x00015E48
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366420, XrefRangeEnd = 366425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00017C94 File Offset: 0x00015E94
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00017CDC File Offset: 0x00015EDC
		public unsafe override int ReadTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366425, XrefRangeEnd = 366426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366426, XrefRangeEnd = 366427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00017D28 File Offset: 0x00015F28
		public unsafe override int WriteTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366427, XrefRangeEnd = 366430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MobileAuthenticatedStream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00017D70 File Offset: 0x00015F70
		[CallerCount(0)]
		public unsafe void _InnerWrite_b__67_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002935 File Offset: 0x00000B35
		public MobileAuthenticatedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00017DA4 File Offset: 0x00015FA4
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000293E File Offset: 0x00000B3E
		public unsafe MobileTlsContext xobileTlsContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_xobileTlsContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00017DD4 File Offset: 0x00015FD4
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000295D File Offset: 0x00000B5D
		public unsafe ExceptionDispatchInfo lastException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_lastException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_lastException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00017E04 File Offset: 0x00016004
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000297C File Offset: 0x00000B7C
		public unsafe AsyncProtocolRequest asyncHandshakeRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncHandshakeRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00017E34 File Offset: 0x00016034
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0000299B File Offset: 0x00000B9B
		public unsafe AsyncProtocolRequest asyncReadRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncReadRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00017E64 File Offset: 0x00016064
		// (set) Token: 0x060001CC RID: 460 RVA: 0x000029BA File Offset: 0x00000BBA
		public unsafe AsyncProtocolRequest asyncWriteRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_asyncWriteRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00017E94 File Offset: 0x00016094
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000029D9 File Offset: 0x00000BD9
		public unsafe BufferOffsetSize2 readBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_readBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00017EC4 File Offset: 0x000160C4
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe BufferOffsetSize2 writeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_writeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00017EF4 File Offset: 0x000160F4
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002A17 File Offset: 0x00000C17
		public unsafe Object ioLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ioLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00017F24 File Offset: 0x00016124
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002A36 File Offset: 0x00000C36
		public unsafe int closeRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_closeRequested)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00017F4C File Offset: 0x0001614C
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002A51 File Offset: 0x00000C51
		public unsafe bool shutdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_shutdown)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00017F74 File Offset: 0x00016174
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002A6C File Offset: 0x00000C6C
		public unsafe static int uniqueNameInteger
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MobileAuthenticatedStream.NativeFieldInfoPtr_uniqueNameInteger, (void*)(&value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00017F90 File Offset: 0x00016190
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002A7A File Offset: 0x00000C7A
		public unsafe SslStream _SslStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SslStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__SslStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00017FC0 File Offset: 0x000161C0
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002A99 File Offset: 0x00000C99
		public unsafe MonoTlsSettings _Settings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Settings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00017FF0 File Offset: 0x000161F0
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public unsafe MonoTlsProvider _Provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr__Provider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00018020 File Offset: 0x00016220
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public unsafe static int nextId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MobileAuthenticatedStream.NativeFieldInfoPtr_nextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MobileAuthenticatedStream.NativeFieldInfoPtr_nextId, (void*)(&value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001803C File Offset: 0x0001623C
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public unsafe int ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.NativeFieldInfoPtr_ID)) = value;
			}
		}

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_xobileTlsContext;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_lastException;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_asyncHandshakeRequest;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_asyncReadRequest;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_asyncWriteRequest;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_writeBuffer;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_ioLock;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_closeRequested;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_shutdown;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_uniqueNameInteger;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr__SslStream_k__BackingField;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr__Settings_k__BackingField;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_nextId;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_MonoTlsSettings_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Public_Virtual_Final_New_get_MonoTlsProvider_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_CheckThrow_Internal_Void_Boolean_Boolean_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_GetSSPIException_Internal_Static_Exception_Exception_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_GetIOException_Internal_Static_Exception_Exception_String_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Internal_ExceptionDispatchInfo_Exception_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClient_Public_Virtual_Final_New_Void_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_AuthenticateAsClientAsync_Public_Virtual_Final_New_Task_String_X509CertificateCollection_SslProtocols_Boolean_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticatedStream_Public_Virtual_Final_New_get_AuthenticatedStream_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAuthentication_Private_Task_Boolean_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_CreateContext_Protected_Abstract_Virtual_New_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Private_Task_1_Int32_OperationType_AsyncProtocolRequest_CancellationToken_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_InternalRead_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Boolean_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_InternalRead_Private_ValueTuple_2_Int32_Boolean_AsyncProtocolRequest_BufferOffsetSize_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Internal_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Private_Boolean_AsyncProtocolRequest_BufferOffsetSize2_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_InnerRead_Internal_Task_1_Int32_Boolean_Int32_CancellationToken_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_InnerWrite_Internal_Task_Boolean_CancellationToken_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandshake_Internal_AsyncOperationStatus_AsyncOperationStatus_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRead_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_ProcessWrite_Internal_ValueTuple_2_Int32_Boolean_BufferOffsetSize_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Virtual_get_Boolean_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalLocalCertificate_Public_Virtual_Final_New_get_X509Certificate_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_get_Int32_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr__InnerWrite_b__67_0_Private_Void_0;

		// Token: 0x020001A6 RID: 422
		[OriginalName("System.dll", "", "OperationType")]
		public enum OperationType
		{
			// Token: 0x04001332 RID: 4914
			Read,
			// Token: 0x04001333 RID: 4915
			Write,
			// Token: 0x04001334 RID: 4916
			Shutdown
		}

		// Token: 0x020001A7 RID: 423
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<ProcessAuthentication>d__47")]
		public sealed class _ProcessAuthentication_d__47 : ValueType
		{
			// Token: 0x06001857 RID: 6231 RVA: 0x0006A518 File Offset: 0x00068718
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessAuthentication_d__47()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<ProcessAuthentication>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr);
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "serverMode");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverCertificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "serverCertificate");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_targetHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "targetHost");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_runSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "runSynchronously");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_enabledProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "enabledProtocols");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertificates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "clientCertificates");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "clientCertRequired");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, 100663697);
				MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr, 100663698);
			}

			// Token: 0x06001858 RID: 6232 RVA: 0x0006A648 File Offset: 0x00068848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366021, XrefRangeEnd = 366068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001859 RID: 6233 RVA: 0x0006A680 File Offset: 0x00068880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600185A RID: 6234 RVA: 0x0000C60D File Offset: 0x0000A80D
			public _ProcessAuthentication_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600185B RID: 6235 RVA: 0x0000C616 File Offset: 0x0000A816
			public _ProcessAuthentication_d__47()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._ProcessAuthentication_d__47>.NativeClassPtr))
			{
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x0600185C RID: 6236 RVA: 0x0006A6C8 File Offset: 0x000688C8
			// (set) Token: 0x0600185D RID: 6237 RVA: 0x0000C628 File Offset: 0x0000A828
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x0600185E RID: 6238 RVA: 0x0006A6F0 File Offset: 0x000688F0
			// (set) Token: 0x0600185F RID: 6239 RVA: 0x0000C643 File Offset: 0x0000A843
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x06001860 RID: 6240 RVA: 0x0006A720 File Offset: 0x00068920
			// (set) Token: 0x06001861 RID: 6241 RVA: 0x0000C671 File Offset: 0x0000A871
			public unsafe bool serverMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverMode)) = value;
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x06001862 RID: 6242 RVA: 0x0006A748 File Offset: 0x00068948
			// (set) Token: 0x06001863 RID: 6243 RVA: 0x0000C68C File Offset: 0x0000A88C
			public unsafe X509Certificate serverCertificate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverCertificate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_serverCertificate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x06001864 RID: 6244 RVA: 0x0006A778 File Offset: 0x00068978
			// (set) Token: 0x06001865 RID: 6245 RVA: 0x0000C6AB File Offset: 0x0000A8AB
			public unsafe string targetHost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_targetHost);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_targetHost), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x06001866 RID: 6246 RVA: 0x0006A7A0 File Offset: 0x000689A0
			// (set) Token: 0x06001867 RID: 6247 RVA: 0x0000C6CA File Offset: 0x0000A8CA
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x06001868 RID: 6248 RVA: 0x0006A7D0 File Offset: 0x000689D0
			// (set) Token: 0x06001869 RID: 6249 RVA: 0x0000C6E9 File Offset: 0x0000A8E9
			public unsafe bool runSynchronously
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_runSynchronously);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_runSynchronously)) = value;
				}
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x0600186A RID: 6250 RVA: 0x0006A7F8 File Offset: 0x000689F8
			// (set) Token: 0x0600186B RID: 6251 RVA: 0x0000C704 File Offset: 0x0000A904
			public unsafe SslProtocols enabledProtocols
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_enabledProtocols);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_enabledProtocols)) = value;
				}
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x0600186C RID: 6252 RVA: 0x0006A820 File Offset: 0x00068A20
			// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000C71F File Offset: 0x0000A91F
			public unsafe X509CertificateCollection clientCertificates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertificates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertificates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x0600186E RID: 6254 RVA: 0x0006A850 File Offset: 0x00068A50
			// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000C73E File Offset: 0x0000A93E
			public unsafe bool clientCertRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr_clientCertRequired)) = value;
				}
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06001870 RID: 6256 RVA: 0x0006A878 File Offset: 0x00068A78
			// (set) Token: 0x06001871 RID: 6257 RVA: 0x0000C759 File Offset: 0x0000A959
			public ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._ProcessAuthentication_d__47.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001335 RID: 4917
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001336 RID: 4918
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001337 RID: 4919
			private static readonly IntPtr NativeFieldInfoPtr_serverMode;

			// Token: 0x04001338 RID: 4920
			private static readonly IntPtr NativeFieldInfoPtr_serverCertificate;

			// Token: 0x04001339 RID: 4921
			private static readonly IntPtr NativeFieldInfoPtr_targetHost;

			// Token: 0x0400133A RID: 4922
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400133B RID: 4923
			private static readonly IntPtr NativeFieldInfoPtr_runSynchronously;

			// Token: 0x0400133C RID: 4924
			private static readonly IntPtr NativeFieldInfoPtr_enabledProtocols;

			// Token: 0x0400133D RID: 4925
			private static readonly IntPtr NativeFieldInfoPtr_clientCertificates;

			// Token: 0x0400133E RID: 4926
			private static readonly IntPtr NativeFieldInfoPtr_clientCertRequired;

			// Token: 0x0400133F RID: 4927
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001340 RID: 4928
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001341 RID: 4929
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001A8 RID: 424
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<StartOperation>d__58")]
		public sealed class _StartOperation_d__58 : ValueType
		{
			// Token: 0x06001872 RID: 6258 RVA: 0x0006A8A8 File Offset: 0x00068AA8
			// Note: this type is marked as 'beforefieldinit'.
			static _StartOperation_d__58()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<StartOperation>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr);
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "type");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_asyncRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "asyncRequest");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, 100663699);
				MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr, 100663700);
			}

			// Token: 0x06001873 RID: 6259 RVA: 0x0006A988 File Offset: 0x00068B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366068, XrefRangeEnd = 366099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x0006A9C0 File Offset: 0x00068BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366099, XrefRangeEnd = 366114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._StartOperation_d__58.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001875 RID: 6261 RVA: 0x0000C787 File Offset: 0x0000A987
			public _StartOperation_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001876 RID: 6262 RVA: 0x0000C790 File Offset: 0x0000A990
			public _StartOperation_d__58()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._StartOperation_d__58>.NativeClassPtr))
			{
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x06001877 RID: 6263 RVA: 0x0006AA08 File Offset: 0x00068C08
			// (set) Token: 0x06001878 RID: 6264 RVA: 0x0000C7A2 File Offset: 0x0000A9A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x06001879 RID: 6265 RVA: 0x0006AA30 File Offset: 0x00068C30
			// (set) Token: 0x0600187A RID: 6266 RVA: 0x0000C7BD File Offset: 0x0000A9BD
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x0600187B RID: 6267 RVA: 0x0006AA60 File Offset: 0x00068C60
			// (set) Token: 0x0600187C RID: 6268 RVA: 0x0000C7EB File Offset: 0x0000A9EB
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x0600187D RID: 6269 RVA: 0x0006AA90 File Offset: 0x00068C90
			// (set) Token: 0x0600187E RID: 6270 RVA: 0x0000C80A File Offset: 0x0000AA0A
			public unsafe MobileAuthenticatedStream.OperationType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x0600187F RID: 6271 RVA: 0x0006AAB8 File Offset: 0x00068CB8
			// (set) Token: 0x06001880 RID: 6272 RVA: 0x0000C825 File Offset: 0x0000AA25
			public unsafe AsyncProtocolRequest asyncRequest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_asyncRequest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_asyncRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06001881 RID: 6273 RVA: 0x0006AAE8 File Offset: 0x00068CE8
			// (set) Token: 0x06001882 RID: 6274 RVA: 0x0000C844 File Offset: 0x0000AA44
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x06001883 RID: 6275 RVA: 0x0006AB18 File Offset: 0x00068D18
			// (set) Token: 0x06001884 RID: 6276 RVA: 0x0000C872 File Offset: 0x0000AA72
			public ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._StartOperation_d__58.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001342 RID: 4930
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001343 RID: 4931
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001344 RID: 4932
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001345 RID: 4933
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001346 RID: 4934
			private static readonly IntPtr NativeFieldInfoPtr_asyncRequest;

			// Token: 0x04001347 RID: 4935
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001348 RID: 4936
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001349 RID: 4937
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400134A RID: 4938
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001A9 RID: 425
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Object
		{
			// Token: 0x06001885 RID: 6277 RVA: 0x0006AB48 File Offset: 0x00068D48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr);
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, "len");
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, 100663701);
				MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr, 100663702);
			}

			// Token: 0x06001886 RID: 6278 RVA: 0x0006ABC4 File Offset: 0x00068DC4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001887 RID: 6279 RVA: 0x0006AC00 File Offset: 0x00068E00
			[CallerCount(0)]
			public unsafe int _InnerRead_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001888 RID: 6280 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x06001889 RID: 6281 RVA: 0x0006AC3C File Offset: 0x00068E3C
			// (set) Token: 0x0600188A RID: 6282 RVA: 0x0000C8A9 File Offset: 0x0000AAA9
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x0600188B RID: 6283 RVA: 0x0006AC6C File Offset: 0x00068E6C
			// (set) Token: 0x0600188C RID: 6284 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
			public unsafe int len
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream.__c__DisplayClass66_0.NativeFieldInfoPtr_len)) = value;
				}
			}

			// Token: 0x0400134B RID: 4939
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400134C RID: 4940
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x0400134D RID: 4941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400134E RID: 4942
			private static readonly IntPtr NativeMethodInfoPtr__InnerRead_b__0_Internal_Int32_0;
		}

		// Token: 0x020001AA RID: 426
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<InnerRead>d__66")]
		public sealed class _InnerRead_d__66 : ValueType
		{
			// Token: 0x0600188D RID: 6285 RVA: 0x0006AC94 File Offset: 0x00068E94
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerRead_d__66()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<InnerRead>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr);
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "requestedSize");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "sync");
				MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, 100663703);
				MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr, 100663704);
			}

			// Token: 0x0600188E RID: 6286 RVA: 0x0006AD74 File Offset: 0x00068F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366114, XrefRangeEnd = 366150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600188F RID: 6287 RVA: 0x0006ADAC File Offset: 0x00068FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366150, XrefRangeEnd = 366165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerRead_d__66.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001890 RID: 6288 RVA: 0x0000C8E3 File Offset: 0x0000AAE3
			public _InnerRead_d__66(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001891 RID: 6289 RVA: 0x0000C8EC File Offset: 0x0000AAEC
			public _InnerRead_d__66()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerRead_d__66>.NativeClassPtr))
			{
			}

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x06001892 RID: 6290 RVA: 0x0006ADF4 File Offset: 0x00068FF4
			// (set) Token: 0x06001893 RID: 6291 RVA: 0x0000C8FE File Offset: 0x0000AAFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x06001894 RID: 6292 RVA: 0x0006AE1C File Offset: 0x0006901C
			// (set) Token: 0x06001895 RID: 6293 RVA: 0x0000C919 File Offset: 0x0000AB19
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x06001896 RID: 6294 RVA: 0x0006AE4C File Offset: 0x0006904C
			// (set) Token: 0x06001897 RID: 6295 RVA: 0x0000C947 File Offset: 0x0000AB47
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x06001898 RID: 6296 RVA: 0x0006AE7C File Offset: 0x0006907C
			// (set) Token: 0x06001899 RID: 6297 RVA: 0x0000C966 File Offset: 0x0000AB66
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x0600189A RID: 6298 RVA: 0x0006AEAC File Offset: 0x000690AC
			// (set) Token: 0x0600189B RID: 6299 RVA: 0x0000C994 File Offset: 0x0000AB94
			public unsafe int requestedSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_requestedSize)) = value;
				}
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x0600189C RID: 6300 RVA: 0x0006AED4 File Offset: 0x000690D4
			// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000C9AF File Offset: 0x0000ABAF
			public unsafe bool sync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr_sync)) = value;
				}
			}

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x0600189E RID: 6302 RVA: 0x0006AEFC File Offset: 0x000690FC
			// (set) Token: 0x0600189F RID: 6303 RVA: 0x0000C9CA File Offset: 0x0000ABCA
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerRead_d__66.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400134F RID: 4943
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001350 RID: 4944
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001351 RID: 4945
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001352 RID: 4946
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001353 RID: 4947
			private static readonly IntPtr NativeFieldInfoPtr_requestedSize;

			// Token: 0x04001354 RID: 4948
			private static readonly IntPtr NativeFieldInfoPtr_sync;

			// Token: 0x04001355 RID: 4949
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001356 RID: 4950
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001357 RID: 4951
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001AB RID: 427
		[ObfuscatedName("Mono.Net.Security.MobileAuthenticatedStream+<InnerWrite>d__67")]
		public sealed class _InnerWrite_d__67 : ValueType
		{
			// Token: 0x060018A0 RID: 6304 RVA: 0x0006AF2C File Offset: 0x0006912C
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerWrite_d__67()
			{
				Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MobileAuthenticatedStream>.NativeClassPtr, "<InnerWrite>d__67");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr);
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>1__state");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>t__builder");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "cancellationToken");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>4__this");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "sync");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, "<>u__1");
				MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, 100663705);
				MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr, 100663706);
			}

			// Token: 0x060018A1 RID: 6305 RVA: 0x0006AFF8 File Offset: 0x000691F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366165, XrefRangeEnd = 366188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018A2 RID: 6306 RVA: 0x0006B030 File Offset: 0x00069230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileAuthenticatedStream._InnerWrite_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018A3 RID: 6307 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
			public _InnerWrite_d__67(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018A4 RID: 6308 RVA: 0x0000CA01 File Offset: 0x0000AC01
			public _InnerWrite_d__67()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileAuthenticatedStream._InnerWrite_d__67>.NativeClassPtr))
			{
			}

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0006B078 File Offset: 0x00069278
			// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000CA13 File Offset: 0x0000AC13
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007E7 RID: 2023
			// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0006B0A0 File Offset: 0x000692A0
			// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000CA2E File Offset: 0x0000AC2E
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E8 RID: 2024
			// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0006B0D0 File Offset: 0x000692D0
			// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000CA5C File Offset: 0x0000AC5C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E9 RID: 2025
			// (get) Token: 0x060018AB RID: 6315 RVA: 0x0006B100 File Offset: 0x00069300
			// (set) Token: 0x060018AC RID: 6316 RVA: 0x0000CA8A File Offset: 0x0000AC8A
			public unsafe MobileAuthenticatedStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EA RID: 2026
			// (get) Token: 0x060018AD RID: 6317 RVA: 0x0006B130 File Offset: 0x00069330
			// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000CAA9 File Offset: 0x0000ACA9
			public unsafe bool sync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr_sync)) = value;
				}
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x060018AF RID: 6319 RVA: 0x0006B158 File Offset: 0x00069358
			// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MobileAuthenticatedStream._InnerWrite_d__67.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001358 RID: 4952
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001359 RID: 4953
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400135A RID: 4954
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400135B RID: 4955
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400135C RID: 4956
			private static readonly IntPtr NativeFieldInfoPtr_sync;

			// Token: 0x0400135D RID: 4957
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400135E RID: 4958
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400135F RID: 4959
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
