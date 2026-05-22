using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200013B RID: 315
	public class WebConnection : Object
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x00058504 File Offset: 0x00056704
		// Note: this type is marked as 'beforefieldinit'.
		static WebConnection()
		{
			Il2CppClassPointerStore<WebConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection>.NativeClassPtr);
			WebConnection.NativeFieldInfoPtr_ntlm_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "ntlm_credentials");
			WebConnection.NativeFieldInfoPtr_ntlm_authenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "ntlm_authenticated");
			WebConnection.NativeFieldInfoPtr_unsafe_sharing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "unsafe_sharing");
			WebConnection.NativeFieldInfoPtr_networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "networkStream");
			WebConnection.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "socket");
			WebConnection.NativeFieldInfoPtr_monoTlsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "monoTlsStream");
			WebConnection.NativeFieldInfoPtr_tunnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "tunnel");
			WebConnection.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "disposed");
			WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<ServicePoint>k__BackingField");
			WebConnection.NativeFieldInfoPtr_idleSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "idleSince");
			WebConnection.NativeFieldInfoPtr_currentOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "currentOperation");
			WebConnection.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666009);
			WebConnection.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666010);
			WebConnection.NativeMethodInfoPtr_CanReuse_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666011);
			WebConnection.NativeMethodInfoPtr_CheckReusable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666012);
			WebConnection.NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666013);
			WebConnection.NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666014);
			WebConnection.NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666015);
			WebConnection.NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666016);
			WebConnection.NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666017);
			WebConnection.NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666018);
			WebConnection.NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666019);
			WebConnection.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666020);
			WebConnection.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666021);
			WebConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666022);
			WebConnection.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666023);
			WebConnection.NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666024);
			WebConnection.NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666025);
			WebConnection.NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666026);
			WebConnection.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666027);
			WebConnection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666028);
			WebConnection.NativeMethodInfoPtr_ResetNtlm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666029);
			WebConnection.NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666030);
			WebConnection.NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666031);
			WebConnection.NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666032);
			WebConnection.NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666033);
			WebConnection.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666034);
			WebConnection.NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100666035);
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0005882C File Offset: 0x00056A2C
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0005886C File Offset: 0x00056A6C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebConnection(ServicePoint sPoint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000588B8 File Offset: 0x00056AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384526, XrefRangeEnd = 384532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReuse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CanReuse_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000588F4 File Offset: 0x00056AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384532, XrefRangeEnd = 384539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckReusable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CheckReusable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00058930 File Offset: 0x00056B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384548, RefRangeEnd = 384549, XrefRangeStart = 384539, XrefRangeEnd = 384548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Connect(WebOperation operation, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00058998 File Offset: 0x00056B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384559, RefRangeEnd = 384560, XrefRangeStart = 384549, XrefRangeEnd = 384559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reused;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00058A10 File Offset: 0x00056C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384570, RefRangeEnd = 384571, XrefRangeStart = 384560, XrefRangeEnd = 384570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebRequestStream>>(intPtr3) : null;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00058A78 File Offset: 0x00056C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384571, XrefRangeEnd = 384592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebException GetException(WebExceptionStatus status, Exception error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00058ACC File Offset: 0x00056CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 384602, RefRangeEnd = 384605, XrefRangeStart = 384592, XrefRangeEnd = 384602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadLine(Il2CppStructArray<byte> buffer, ref int start, int max, ref string output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(output);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			output = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00058B4C File Offset: 0x00056D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384627, RefRangeEnd = 384628, XrefRangeStart = 384605, XrefRangeEnd = 384627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReuseConnection(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00058B9C File Offset: 0x00056D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 384642, RefRangeEnd = 384644, XrefRangeStart = 384628, XrefRangeEnd = 384642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrepareSharingNtlm(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00058BEC File Offset: 0x00056DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384647, RefRangeEnd = 384648, XrefRangeStart = 384644, XrefRangeEnd = 384647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00058C20 File Offset: 0x00056E20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 384653, RefRangeEnd = 384658, XrefRangeStart = 384648, XrefRangeEnd = 384653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool reset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00058C60 File Offset: 0x00056E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384665, RefRangeEnd = 384666, XrefRangeStart = 384658, XrefRangeEnd = 384665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00058C94 File Offset: 0x00056E94
		public unsafe bool Closed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00058CD0 File Offset: 0x00056ED0
		public unsafe DateTime IdleSince
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00058D0C File Offset: 0x00056F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384684, RefRangeEnd = 384685, XrefRangeStart = 384666, XrefRangeEnd = 384684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartOperation(WebOperation operation, bool reused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00058D68 File Offset: 0x00056F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384694, RefRangeEnd = 384695, XrefRangeStart = 384685, XrefRangeEnd = 384694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Continue(WebOperation next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00058DB8 File Offset: 0x00056FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384695, XrefRangeEnd = 384696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00058DF8 File Offset: 0x00056FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00058E2C File Offset: 0x0005702C
		[CallerCount(0)]
		public unsafe void ResetNtlm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_ResetNtlm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00058E60 File Offset: 0x00057060
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00058E9C File Offset: 0x0005709C
		public unsafe bool NtlmAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00058EDC File Offset: 0x000570DC
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00058F1C File Offset: 0x0005711C
		public unsafe NetworkCredential NtlmCredential
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00058F60 File Offset: 0x00057160
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00058F9C File Offset: 0x0005719C
		public unsafe bool UnsafeAuthenticatedConnectionSharing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00009D06 File Offset: 0x00007F06
		public WebConnection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00058FDC File Offset: 0x000571DC
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x00009D0F File Offset: 0x00007F0F
		public unsafe NetworkCredential ntlm_credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0005900C File Offset: 0x0005720C
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x00009D2E File Offset: 0x00007F2E
		public unsafe bool ntlm_authenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_authenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_authenticated)) = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00059034 File Offset: 0x00057234
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x00009D49 File Offset: 0x00007F49
		public unsafe bool unsafe_sharing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_unsafe_sharing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_unsafe_sharing)) = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0005905C File Offset: 0x0005725C
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00009D64 File Offset: 0x00007F64
		public unsafe Stream networkStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_networkStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x0005908C File Offset: 0x0005728C
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x00009D83 File Offset: 0x00007F83
		public unsafe Socket socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x000590BC File Offset: 0x000572BC
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x00009DA2 File Offset: 0x00007FA2
		public unsafe MonoTlsStream monoTlsStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_monoTlsStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_monoTlsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x000590EC File Offset: 0x000572EC
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x00009DC1 File Offset: 0x00007FC1
		public unsafe WebConnectionTunnel tunnel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_tunnel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_tunnel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0005911C File Offset: 0x0005731C
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x00009DE0 File Offset: 0x00007FE0
		public unsafe int disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00059144 File Offset: 0x00057344
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00009DFB File Offset: 0x00007FFB
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00059174 File Offset: 0x00057374
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00009E1A File Offset: 0x0000801A
		public unsafe DateTime idleSince
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_idleSince);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_idleSince)) = value;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0005919C File Offset: 0x0005739C
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00009E35 File Offset: 0x00008035
		public unsafe WebOperation currentOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_currentOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_currentOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeFieldInfoPtr_ntlm_credentials;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_ntlm_authenticated;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_unsafe_sharing;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_networkStream;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_monoTlsStream;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_tunnel;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_idleSince;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_currentOperation;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_CanReuse_Private_Boolean_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_CheckReusable_Private_Boolean_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_CloseSocket_Private_Void_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_ResetNtlm_Private_Void_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0;

		// Token: 0x020001F6 RID: 502
		[ObfuscatedName("System.Net.WebConnection+<Connect>d__16")]
		public sealed class _Connect_d__16 : ValueType
		{
			// Token: 0x06001B50 RID: 6992 RVA: 0x00072D24 File Offset: 0x00070F24
			// Note: this type is marked as 'beforefieldinit'.
			static _Connect_d__16()
			{
				Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<Connect>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr);
				WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>1__state");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>t__builder");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>4__this");
				WebConnection._Connect_d__16.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "operation");
				WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "cancellationToken");
				WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<connectException>5__1");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>7__wrap1");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>7__wrap2");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>u__1");
				WebConnection._Connect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, 100666036);
				WebConnection._Connect_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, 100666037);
			}

			// Token: 0x06001B51 RID: 6993 RVA: 0x00072E2C File Offset: 0x0007102C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384385, XrefRangeEnd = 384401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._Connect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B52 RID: 6994 RVA: 0x00072E64 File Offset: 0x00071064
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._Connect_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B53 RID: 6995 RVA: 0x0000E3BB File Offset: 0x0000C5BB
			public _Connect_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B54 RID: 6996 RVA: 0x0000E3C4 File Offset: 0x0000C5C4
			public _Connect_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00072EAC File Offset: 0x000710AC
			// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0000E3D6 File Offset: 0x0000C5D6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00072ED4 File Offset: 0x000710D4
			// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0000E3F1 File Offset: 0x0000C5F1
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00072F04 File Offset: 0x00071104
			// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000E41F File Offset: 0x0000C61F
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00072F34 File Offset: 0x00071134
			// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0000E43E File Offset: 0x0000C63E
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00072F64 File Offset: 0x00071164
			// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0000E45D File Offset: 0x0000C65D
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00072F94 File Offset: 0x00071194
			// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0000E48B File Offset: 0x0000C68B
			public unsafe Exception _connectException_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00072FC4 File Offset: 0x000711C4
			// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0000E4AA File Offset: 0x0000C6AA
			public unsafe Il2CppReferenceArray<IPAddress> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00072FF4 File Offset: 0x000711F4
			// (set) Token: 0x06001B64 RID: 7012 RVA: 0x0000E4C9 File Offset: 0x0000C6C9
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0007301C File Offset: 0x0007121C
			// (set) Token: 0x06001B66 RID: 7014 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001543 RID: 5443
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001544 RID: 5444
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001545 RID: 5445
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001546 RID: 5446
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04001547 RID: 5447
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001548 RID: 5448
			private static readonly IntPtr NativeFieldInfoPtr__connectException_5__1;

			// Token: 0x04001549 RID: 5449
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400154A RID: 5450
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400154B RID: 5451
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400154C RID: 5452
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400154D RID: 5453
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001F7 RID: 503
		[ObfuscatedName("System.Net.WebConnection+<CreateStream>d__18")]
		public sealed class _CreateStream_d__18 : ValueType
		{
			// Token: 0x06001B67 RID: 7015 RVA: 0x0007304C File Offset: 0x0007124C
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateStream_d__18()
			{
				Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<CreateStream>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr);
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>1__state");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>t__builder");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>4__this");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "operation");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "reused");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "cancellationToken");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<stream>5__1");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>u__1");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>u__2");
				WebConnection._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, 100666038);
				WebConnection._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, 100666039);
			}

			// Token: 0x06001B68 RID: 7016 RVA: 0x00073154 File Offset: 0x00071354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384401, XrefRangeEnd = 384465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B69 RID: 7017 RVA: 0x0007318C File Offset: 0x0007138C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384465, XrefRangeEnd = 384480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B6A RID: 7018 RVA: 0x0000E512 File Offset: 0x0000C712
			public _CreateStream_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B6B RID: 7019 RVA: 0x0000E51B File Offset: 0x0000C71B
			public _CreateStream_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x06001B6C RID: 7020 RVA: 0x000731D4 File Offset: 0x000713D4
			// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0000E52D File Offset: 0x0000C72D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x06001B6E RID: 7022 RVA: 0x000731FC File Offset: 0x000713FC
			// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0000E548 File Offset: 0x0000C748
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x06001B70 RID: 7024 RVA: 0x0007322C File Offset: 0x0007142C
			// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0000E576 File Offset: 0x0000C776
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0007325C File Offset: 0x0007145C
			// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0000E595 File Offset: 0x0000C795
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x06001B74 RID: 7028 RVA: 0x0007328C File Offset: 0x0007148C
			// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
			public unsafe bool reused
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused)) = value;
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000732B4 File Offset: 0x000714B4
			// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0000E5CF File Offset: 0x0000C7CF
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000732E4 File Offset: 0x000714E4
			// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000E5FD File Offset: 0x0000C7FD
			public unsafe NetworkStream _stream_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00073314 File Offset: 0x00071514
			// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000E61C File Offset: 0x0000C81C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00073344 File Offset: 0x00071544
			// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000E64A File Offset: 0x0000C84A
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400154E RID: 5454
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400154F RID: 5455
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001550 RID: 5456
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001551 RID: 5457
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04001552 RID: 5458
			private static readonly IntPtr NativeFieldInfoPtr_reused;

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__1;

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001556 RID: 5462
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001F8 RID: 504
		[ObfuscatedName("System.Net.WebConnection+<InitConnection>d__19")]
		public sealed class _InitConnection_d__19 : ValueType
		{
			// Token: 0x06001B7E RID: 7038 RVA: 0x00073374 File Offset: 0x00071574
			// Note: this type is marked as 'beforefieldinit'.
			static _InitConnection_d__19()
			{
				Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<InitConnection>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr);
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>1__state");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>t__builder");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "operation");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "cancellationToken");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>4__this");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<reused>5__1");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>u__1");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>u__2");
				WebConnection._InitConnection_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, 100666040);
				WebConnection._InitConnection_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, 100666041);
			}

			// Token: 0x06001B7F RID: 7039 RVA: 0x00073468 File Offset: 0x00071668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384480, XrefRangeEnd = 384511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._InitConnection_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B80 RID: 7040 RVA: 0x000734A0 File Offset: 0x000716A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384511, XrefRangeEnd = 384526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._InitConnection_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B81 RID: 7041 RVA: 0x0000E678 File Offset: 0x0000C878
			public _InitConnection_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B82 RID: 7042 RVA: 0x0000E681 File Offset: 0x0000C881
			public _InitConnection_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x06001B83 RID: 7043 RVA: 0x000734E8 File Offset: 0x000716E8
			// (set) Token: 0x06001B84 RID: 7044 RVA: 0x0000E693 File Offset: 0x0000C893
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06001B85 RID: 7045 RVA: 0x00073510 File Offset: 0x00071710
			// (set) Token: 0x06001B86 RID: 7046 RVA: 0x0000E6AE File Offset: 0x0000C8AE
			public AsyncTaskMethodBuilder<WebRequestStream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<WebRequestStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebRequestStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebRequestStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00073540 File Offset: 0x00071740
			// (set) Token: 0x06001B88 RID: 7048 RVA: 0x0000E6DC File Offset: 0x0000C8DC
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00073570 File Offset: 0x00071770
			// (set) Token: 0x06001B8A RID: 7050 RVA: 0x0000E6FB File Offset: 0x0000C8FB
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x06001B8B RID: 7051 RVA: 0x000735A0 File Offset: 0x000717A0
			// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0000E729 File Offset: 0x0000C929
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x06001B8D RID: 7053 RVA: 0x000735D0 File Offset: 0x000717D0
			// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000E748 File Offset: 0x0000C948
			public unsafe bool _reused_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__1)) = value;
				}
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x06001B8F RID: 7055 RVA: 0x000735F8 File Offset: 0x000717F8
			// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000E763 File Offset: 0x0000C963
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00073628 File Offset: 0x00071828
			// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0000E791 File Offset: 0x0000C991
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400155C RID: 5468
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400155D RID: 5469
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400155E RID: 5470
			private static readonly IntPtr NativeFieldInfoPtr__reused_5__1;

			// Token: 0x0400155F RID: 5471
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001560 RID: 5472
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001561 RID: 5473
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001562 RID: 5474
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
