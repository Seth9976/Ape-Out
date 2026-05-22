using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000023 RID: 35
	public class ChainValidationHelper : Object
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00015FD8 File Offset: 0x000141D8
		// Note: this type is marked as 'beforefieldinit'.
		static ChainValidationHelper()
		{
			Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "ChainValidationHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr);
			ChainValidationHelper.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "sender");
			ChainValidationHelper.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "settings");
			ChainValidationHelper.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "provider");
			ChainValidationHelper.NativeFieldInfoPtr_certValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "certValidationCallback");
			ChainValidationHelper.NativeFieldInfoPtr_certSelectionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "certSelectionCallback");
			ChainValidationHelper.NativeFieldInfoPtr_callbackWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "callbackWrapper");
			ChainValidationHelper.NativeFieldInfoPtr_tlsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "tlsStream");
			ChainValidationHelper.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, "request");
			ChainValidationHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ICertificateValidator_MonoTlsProvider_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663642);
			ChainValidationHelper.NativeMethodInfoPtr_Create_Internal_Static_ChainValidationHelper_MonoTlsProvider_byref_MonoTlsSettings_MonoTlsStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663643);
			ChainValidationHelper.NativeMethodInfoPtr__ctor_Private_Void_MonoTlsProvider_MonoTlsSettings_Boolean_MonoTlsStream_ServerCertValidationCallbackWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663644);
			ChainValidationHelper.NativeMethodInfoPtr_DefaultSelectionCallback_Private_Static_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663645);
			ChainValidationHelper.NativeMethodInfoPtr_get_Settings_Public_Virtual_Final_New_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663646);
			ChainValidationHelper.NativeMethodInfoPtr_SelectClientCertificate_Public_Virtual_Final_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663647);
			ChainValidationHelper.NativeMethodInfoPtr_ValidateCertificate_Public_Virtual_Final_New_ValidationResult_String_Boolean_X509Certificate_X509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663648);
			ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_X509Chain_X509CertificateCollection_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663649);
			ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_byref_X509Chain_X509CertificateCollection_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr, 100663650);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001615C File Offset: 0x0001435C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365896, XrefRangeEnd = 365903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ICertificateValidator_MonoTlsProvider_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICertificateValidator>(intPtr3) : null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000161B4 File Offset: 0x000143B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365903, XrefRangeEnd = 365907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_Create_Internal_Static_ChainValidationHelper_MonoTlsProvider_byref_MonoTlsSettings_MonoTlsStream_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			settings = ((intPtr4 == 0) ? null : new MonoTlsSettings(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ChainValidationHelper>(intPtr5) : null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00016234 File Offset: 0x00014434
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 365966, RefRangeEnd = 365971, XrefRangeStart = 365907, XrefRangeEnd = 365966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChainValidationHelper(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChainValidationHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cloneSettings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackWrapper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr__ctor_Private_Void_MonoTlsProvider_MonoTlsSettings_Boolean_MonoTlsStream_ServerCertValidationCallbackWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000162C8 File Offset: 0x000144C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365971, XrefRangeEnd = 365972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_DefaultSelectionCallback_Private_Static_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00016344 File Offset: 0x00014544
		public unsafe virtual MonoTlsSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_get_Settings_Public_Virtual_Final_New_get_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00016384 File Offset: 0x00014584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365972, XrefRangeEnd = 365973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers, out X509Certificate clientCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_SelectClientCertificate_Public_Virtual_Final_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			clientCertificate = ((intPtr4 == 0) ? null : new X509Certificate(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001642C File Offset: 0x0001462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365973, XrefRangeEnd = 365975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_ValidateCertificate_Public_Virtual_Final_New_ValidationResult_String_Boolean_X509Certificate_X509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationResult>(intPtr3) : null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000164B0 File Offset: 0x000146B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365981, RefRangeEnd = 365982, XrefRangeStart = 365975, XrefRangeEnd = 365981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_X509Chain_X509CertificateCollection_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationResult>(intPtr3) : null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00016554 File Offset: 0x00014754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366020, RefRangeEnd = 366021, XrefRangeStart = 365982, XrefRangeEnd = 366020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaf);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errors;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChainValidationHelper.NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_byref_X509Chain_X509CertificateCollection_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chain = ((intPtr4 == 0) ? null : new X509Chain(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ValidationResult>(intPtr5) : null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002834 File Offset: 0x00000A34
		public ChainValidationHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00016610 File Offset: 0x00014810
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000283D File Offset: 0x00000A3D
		public unsafe Object sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_sender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00016640 File Offset: 0x00014840
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0000285C File Offset: 0x00000A5C
		public unsafe MonoTlsSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00016670 File Offset: 0x00014870
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0000287B File Offset: 0x00000A7B
		public unsafe MonoTlsProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000166A0 File Offset: 0x000148A0
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000289A File Offset: 0x00000A9A
		public unsafe ServerCertValidationCallback certValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000166D0 File Offset: 0x000148D0
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000028B9 File Offset: 0x00000AB9
		public unsafe LocalCertSelectionCallback certSelectionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certSelectionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalCertSelectionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_certSelectionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00016700 File Offset: 0x00014900
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000028D8 File Offset: 0x00000AD8
		public unsafe ServerCertValidationCallbackWrapper callbackWrapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_callbackWrapper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerCertValidationCallbackWrapper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_callbackWrapper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00016730 File Offset: 0x00014930
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000028F7 File Offset: 0x00000AF7
		public unsafe MonoTlsStream tlsStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_tlsStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_tlsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00016760 File Offset: 0x00014960
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002916 File Offset: 0x00000B16
		public unsafe HttpWebRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainValidationHelper.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_certValidationCallback;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_certSelectionCallback;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_callbackWrapper;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_tlsStream;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalValidator_Internal_Static_ICertificateValidator_MonoTlsProvider_MonoTlsSettings_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ChainValidationHelper_MonoTlsProvider_byref_MonoTlsSettings_MonoTlsStream_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_MonoTlsProvider_MonoTlsSettings_Boolean_MonoTlsStream_ServerCertValidationCallbackWrapper_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_DefaultSelectionCallback_Private_Static_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_Final_New_get_MonoTlsSettings_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_SelectClientCertificate_Public_Virtual_Final_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Public_Virtual_Final_New_ValidationResult_String_Boolean_X509Certificate_X509Chain_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_X509Chain_X509CertificateCollection_SslPolicyErrors_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChain_Private_ValidationResult_String_Boolean_X509Certificate_byref_X509Chain_X509CertificateCollection_SslPolicyErrors_0;
	}
}
