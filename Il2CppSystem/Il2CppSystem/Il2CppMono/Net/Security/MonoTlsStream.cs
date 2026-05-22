using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000027 RID: 39
	public class MonoTlsStream : Object
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00018E88 File Offset: 0x00017088
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsStream()
		{
			Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoTlsStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr);
			MonoTlsStream.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "provider");
			MonoTlsStream.NativeFieldInfoPtr_networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "networkStream");
			MonoTlsStream.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "request");
			MonoTlsStream.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "settings");
			MonoTlsStream.NativeFieldInfoPtr_sslStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "sslStream");
			MonoTlsStream.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "status");
			MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "<CertificateValidationFailed>k__BackingField");
			MonoTlsStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663735);
			MonoTlsStream.NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663736);
			MonoTlsStream.NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663737);
			MonoTlsStream.NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663738);
			MonoTlsStream.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663739);
			MonoTlsStream.NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, 100663740);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00018FBC File Offset: 0x000171BC
		public unsafe HttpWebRequest Request
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00018FFC File Offset: 0x000171FC
		public unsafe WebExceptionStatus ExceptionStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00019038 File Offset: 0x00017238
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00019074 File Offset: 0x00017274
		public unsafe bool CertificateValidationFailed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000190B4 File Offset: 0x000172B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366721, RefRangeEnd = 366722, XrefRangeStart = 366713, XrefRangeEnd = 366721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsStream(HttpWebRequest request, NetworkStream networkStream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00019114 File Offset: 0x00017314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366732, RefRangeEnd = 366733, XrefRangeStart = 366722, XrefRangeEnd = 366732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tunnel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream.NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002CAB File Offset: 0x00000EAB
		public MonoTlsStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0001917C File Offset: 0x0001737C
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public unsafe MonoTlsProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000191AC File Offset: 0x000173AC
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002CD3 File Offset: 0x00000ED3
		public unsafe NetworkStream networkStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_networkStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000191DC File Offset: 0x000173DC
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002CF2 File Offset: 0x00000EF2
		public unsafe HttpWebRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0001920C File Offset: 0x0001740C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002D11 File Offset: 0x00000F11
		public unsafe MonoTlsSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0001923C File Offset: 0x0001743C
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002D30 File Offset: 0x00000F30
		public unsafe IMonoSslStream sslStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMonoSslStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_sslStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0001926C File Offset: 0x0001746C
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002D4F File Offset: 0x00000F4F
		public unsafe WebExceptionStatus status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00019294 File Offset: 0x00017494
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002D6A File Offset: 0x00000F6A
		public unsafe bool _CertificateValidationFailed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream.NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField)) = value;
			}
		}

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_networkStream;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_sslStream;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr__CertificateValidationFailed_k__BackingField;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Internal_get_HttpWebRequest_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionStatus_Internal_get_WebExceptionStatus_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateValidationFailed_Internal_get_Boolean_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateValidationFailed_Internal_set_Void_Boolean_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_NetworkStream_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_CreateStream_Internal_Task_1_Stream_WebConnectionTunnel_CancellationToken_0;

		// Token: 0x020001AC RID: 428
		[ObfuscatedName("Mono.Net.Security.MonoTlsStream+<CreateStream>d__17")]
		public sealed class _CreateStream_d__17 : ValueType
		{
			// Token: 0x060018B1 RID: 6321 RVA: 0x0006B188 File Offset: 0x00069388
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateStream_d__17()
			{
				Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoTlsStream>.NativeClassPtr, "<CreateStream>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr);
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>1__state");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>t__builder");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>4__this");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr__socket_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<socket>5__1");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_tunnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "tunnel");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "cancellationToken");
				MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, "<>u__1");
				MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, 100663741);
				MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr, 100663742);
			}

			// Token: 0x060018B2 RID: 6322 RVA: 0x0006B268 File Offset: 0x00069468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366639, XrefRangeEnd = 366698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018B3 RID: 6323 RVA: 0x0006B2A0 File Offset: 0x000694A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366698, XrefRangeEnd = 366713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsStream._CreateStream_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018B4 RID: 6324 RVA: 0x0000CAF2 File Offset: 0x0000ACF2
			public _CreateStream_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018B5 RID: 6325 RVA: 0x0000CAFB File Offset: 0x0000ACFB
			public _CreateStream_d__17()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsStream._CreateStream_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0006B2E8 File Offset: 0x000694E8
			// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0000CB0D File Offset: 0x0000AD0D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x060018B8 RID: 6328 RVA: 0x0006B310 File Offset: 0x00069510
			// (set) Token: 0x060018B9 RID: 6329 RVA: 0x0000CB28 File Offset: 0x0000AD28
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x060018BA RID: 6330 RVA: 0x0006B340 File Offset: 0x00069540
			// (set) Token: 0x060018BB RID: 6331 RVA: 0x0000CB56 File Offset: 0x0000AD56
			public unsafe MonoTlsStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x060018BC RID: 6332 RVA: 0x0006B370 File Offset: 0x00069570
			// (set) Token: 0x060018BD RID: 6333 RVA: 0x0000CB75 File Offset: 0x0000AD75
			public unsafe Socket _socket_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr__socket_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr__socket_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x060018BE RID: 6334 RVA: 0x0006B3A0 File Offset: 0x000695A0
			// (set) Token: 0x060018BF RID: 6335 RVA: 0x0000CB94 File Offset: 0x0000AD94
			public unsafe WebConnectionTunnel tunnel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_tunnel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_tunnel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F1 RID: 2033
			// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0006B3D0 File Offset: 0x000695D0
			// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0000CBB3 File Offset: 0x0000ADB3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007F2 RID: 2034
			// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0006B400 File Offset: 0x00069600
			// (set) Token: 0x060018C3 RID: 6339 RVA: 0x0000CBE1 File Offset: 0x0000ADE1
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTlsStream._CreateStream_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001360 RID: 4960
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001361 RID: 4961
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001362 RID: 4962
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001363 RID: 4963
			private static readonly IntPtr NativeFieldInfoPtr__socket_5__1;

			// Token: 0x04001364 RID: 4964
			private static readonly IntPtr NativeFieldInfoPtr_tunnel;

			// Token: 0x04001365 RID: 4965
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001366 RID: 4966
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001367 RID: 4967
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001368 RID: 4968
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
