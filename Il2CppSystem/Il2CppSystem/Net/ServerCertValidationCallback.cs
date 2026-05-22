using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011F RID: 287
	public class ServerCertValidationCallback : Object
	{
		// Token: 0x06001023 RID: 4131 RVA: 0x0004D288 File Offset: 0x0004B488
		// Note: this type is marked as 'beforefieldinit'.
		static ServerCertValidationCallback()
		{
			Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServerCertValidationCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr);
			ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "m_ValidationCallback");
			ServerCertValidationCallback.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "m_Context");
			ServerCertValidationCallback.NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100665600);
			ServerCertValidationCallback.NativeMethodInfoPtr_Callback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100665601);
			ServerCertValidationCallback.NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100665602);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004D31C File Offset: 0x0004B51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380060, XrefRangeEnd = 380064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validationCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0004D368 File Offset: 0x0004B568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380064, XrefRangeEnd = 380067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Callback(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr_Callback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0004D3AC File Offset: 0x0004B5AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380080, RefRangeEnd = 380082, XrefRangeStart = 380067, XrefRangeEnd = 380080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00008629 File Offset: 0x00006829
		public ServerCertValidationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0004D42C File Offset: 0x0004B62C
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00008632 File Offset: 0x00006832
		public unsafe RemoteCertificateValidationCallback m_ValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0004D45C File Offset: 0x0004B65C
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00008651 File Offset: 0x00006851
		public unsafe ExecutionContext m_Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidationCallback;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeFieldInfoPtr_m_Context;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_Callback_Internal_Void_Object_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;

		// Token: 0x020001E0 RID: 480
		public class CallbackContext : Object
		{
			// Token: 0x06001A4B RID: 6731 RVA: 0x000700FC File Offset: 0x0006E2FC
			// Note: this type is marked as 'beforefieldinit'.
			static CallbackContext()
			{
				Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "CallbackContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr);
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "request");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "certificate");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "chain");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "sslPolicyErrors");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "result");
				ServerCertValidationCallback.CallbackContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, 100665603);
			}

			// Token: 0x06001A4C RID: 6732 RVA: 0x000701A0 File Offset: 0x0006E3A0
			[CallerCount(0)]
			public unsafe CallbackContext(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.CallbackContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A4D RID: 6733 RVA: 0x0000D801 File Offset: 0x0000BA01
			public CallbackContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x06001A4E RID: 6734 RVA: 0x00070220 File Offset: 0x0006E420
			// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000D80A File Offset: 0x0000BA0A
			public unsafe Object request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00070250 File Offset: 0x0006E450
			// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0000D829 File Offset: 0x0000BA29
			public unsafe X509Certificate certificate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00070280 File Offset: 0x0006E480
			// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0000D848 File Offset: 0x0000BA48
			public unsafe X509Chain chain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000702B0 File Offset: 0x0006E4B0
			// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0000D867 File Offset: 0x0000BA67
			public unsafe SslPolicyErrors sslPolicyErrors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors)) = value;
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06001A56 RID: 6742 RVA: 0x000702D8 File Offset: 0x0006E4D8
			// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0000D882 File Offset: 0x0000BA82
			public unsafe bool result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x040014A3 RID: 5283
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040014A4 RID: 5284
			private static readonly IntPtr NativeFieldInfoPtr_certificate;

			// Token: 0x040014A5 RID: 5285
			private static readonly IntPtr NativeFieldInfoPtr_chain;

			// Token: 0x040014A6 RID: 5286
			private static readonly IntPtr NativeFieldInfoPtr_sslPolicyErrors;

			// Token: 0x040014A7 RID: 5287
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x040014A8 RID: 5288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
		}
	}
}
