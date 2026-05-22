using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000023 RID: 35
	public class PKCS12 : Object
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x0002A234 File Offset: 0x00028434
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS12()
		{
			Il2CppClassPointerStore<PKCS12>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "PKCS12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS12>.NativeClassPtr);
			PKCS12.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_password");
			PKCS12.NativeFieldInfoPtr__keyBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_keyBags");
			PKCS12.NativeFieldInfoPtr__secretBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_secretBags");
			PKCS12.NativeFieldInfoPtr__certs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_certs");
			PKCS12.NativeFieldInfoPtr__keyBagsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_keyBagsChanged");
			PKCS12.NativeFieldInfoPtr__secretBagsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_secretBagsChanged");
			PKCS12.NativeFieldInfoPtr__certsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_certsChanged");
			PKCS12.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_iterations");
			PKCS12.NativeFieldInfoPtr__safeBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_safeBags");
			PKCS12.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_rng");
			PKCS12.NativeFieldInfoPtr_password_max_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "password_max_length");
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663555);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663556);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663557);
			PKCS12.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663558);
			PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663559);
			PKCS12.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663560);
			PKCS12.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663561);
			PKCS12.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663562);
			PKCS12.NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663563);
			PKCS12.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663564);
			PKCS12.NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663565);
			PKCS12.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663566);
			PKCS12.NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663567);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663568);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663569);
			PKCS12.NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663570);
			PKCS12.NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663571);
			PKCS12.NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663572);
			PKCS12.NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663573);
			PKCS12.NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663574);
			PKCS12.NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663575);
			PKCS12.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663576);
			PKCS12.NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663577);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663578);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663579);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663580);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663581);
			PKCS12.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663582);
			PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663583);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0002A584 File Offset: 0x00028784
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 133232, RefRangeEnd = 133236, XrefRangeStart = 133218, XrefRangeEnd = 133232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0002A5C0 File Offset: 0x000287C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133236, XrefRangeEnd = 133239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0002A60C File Offset: 0x0002880C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133239, XrefRangeEnd = 133242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12(Il2CppStructArray<byte> data, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0002A66C File Offset: 0x0002886C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 133316, RefRangeEnd = 133320, XrefRangeStart = 133242, XrefRangeEnd = 133316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decode(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0002A6B0 File Offset: 0x000288B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008A RID: 138
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0002A6EC File Offset: 0x000288EC
		public unsafe string Password
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 133326, RefRangeEnd = 133330, XrefRangeStart = 133320, XrefRangeEnd = 133326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0002A730 File Offset: 0x00028930
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0002A76C File Offset: 0x0002896C
		public unsafe int IterationCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0002A7AC File Offset: 0x000289AC
		public unsafe ArrayList Keys
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 133388, RefRangeEnd = 133390, XrefRangeStart = 133330, XrefRangeEnd = 133388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0002A7EC File Offset: 0x000289EC
		public unsafe X509CertificateCollection Certificates
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 133422, RefRangeEnd = 133427, XrefRangeStart = 133390, XrefRangeEnd = 133422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0002A82C File Offset: 0x00028A2C
		public unsafe RandomNumberGenerator RNG
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 127407, RefRangeEnd = 127411, XrefRangeStart = 127407, XrefRangeEnd = 127411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0002A86C File Offset: 0x00028A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Compare(Il2CppStructArray<byte> expected, Il2CppStructArray<byte> actual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0002A8CC File Offset: 0x00028ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133555, RefRangeEnd = 133557, XrefRangeStart = 133427, XrefRangeEnd = 133555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymmetricAlgorithm>(intPtr3) : null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0002A93C File Offset: 0x00028B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 133564, RefRangeEnd = 133567, XrefRangeStart = 133557, XrefRangeEnd = 133564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Decrypt(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount, Il2CppStructArray<byte> encryptedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encryptedData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133577, RefRangeEnd = 133578, XrefRangeStart = 133567, XrefRangeEnd = 133577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Decrypt(PKCS7.EncryptedData ed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0002AA10 File Offset: 0x00028C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133585, RefRangeEnd = 133586, XrefRangeStart = 133578, XrefRangeEnd = 133585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encrypt(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0002AA94 File Offset: 0x00028C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133600, RefRangeEnd = 133601, XrefRangeStart = 133586, XrefRangeEnd = 133600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSAParameters GetExistingParameters(out bool found)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &found;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0002AAD8 File Offset: 0x00028CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133618, RefRangeEnd = 133620, XrefRangeStart = 133601, XrefRangeEnd = 133618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pki);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0002AB1C File Offset: 0x00028D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133750, RefRangeEnd = 133752, XrefRangeStart = 133620, XrefRangeEnd = 133750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSafeBag(ASN1 safeBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeBag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0002AB60 File Offset: 0x00028D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133878, RefRangeEnd = 133879, XrefRangeStart = 133752, XrefRangeEnd = 133878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0002ABC4 File Offset: 0x00028DC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 133901, RefRangeEnd = 133904, XrefRangeStart = 133879, XrefRangeEnd = 133901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> MAC(Il2CppStructArray<byte> password, Il2CppStructArray<byte> salt, int iterations, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterations;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0002AC48 File Offset: 0x00028E48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134238, RefRangeEnd = 134240, XrefRangeStart = 133904, XrefRangeEnd = 134238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0002AC88 File Offset: 0x00028E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134293, RefRangeEnd = 134295, XrefRangeStart = 134240, XrefRangeEnd = 134293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeBags);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr3) : null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0002ACEC File Offset: 0x00028EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134295, XrefRangeEnd = 134296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0002AD30 File Offset: 0x00028F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134320, RefRangeEnd = 134322, XrefRangeStart = 134296, XrefRangeEnd = 134320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0002AD84 File Offset: 0x00028F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134322, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCertificate(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0002ADC8 File Offset: 0x00028FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134367, RefRangeEnd = 134369, XrefRangeStart = 134323, XrefRangeEnd = 134367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0002AE1C File Offset: 0x0002901C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134369, XrefRangeEnd = 134379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0002AE5C File Offset: 0x0002905C
		public unsafe static int MaximumPasswordLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134379, XrefRangeEnd = 134383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002C54 File Offset: 0x00000E54
		public PKCS12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0002AE8C File Offset: 0x0002908C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002C5D File Offset: 0x00000E5D
		public unsafe Il2CppStructArray<byte> _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0002AEBC File Offset: 0x000290BC
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002C7C File Offset: 0x00000E7C
		public unsafe ArrayList _keyBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0002AEEC File Offset: 0x000290EC
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002C9B File Offset: 0x00000E9B
		public unsafe ArrayList _secretBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0002AF1C File Offset: 0x0002911C
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002CBA File Offset: 0x00000EBA
		public unsafe X509CertificateCollection _certs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0002AF4C File Offset: 0x0002914C
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002CD9 File Offset: 0x00000ED9
		public unsafe bool _keyBagsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBagsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBagsChanged)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0002AF74 File Offset: 0x00029174
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public unsafe bool _secretBagsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBagsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBagsChanged)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0002AF9C File Offset: 0x0002919C
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002D0F File Offset: 0x00000F0F
		public unsafe bool _certsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certsChanged)) = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0002AFC4 File Offset: 0x000291C4
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002D2A File Offset: 0x00000F2A
		public unsafe int _iterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__iterations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__iterations)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0002AFEC File Offset: 0x000291EC
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002D45 File Offset: 0x00000F45
		public unsafe ArrayList _safeBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__safeBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__safeBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0002B01C File Offset: 0x0002921C
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002D64 File Offset: 0x00000F64
		public unsafe RandomNumberGenerator _rng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__rng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__rng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0002B04C File Offset: 0x0002924C
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002D83 File Offset: 0x00000F83
		public unsafe static int password_max_length
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PKCS12.NativeFieldInfoPtr_password_max_length, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS12.NativeFieldInfoPtr_password_max_length, (void*)(&value));
			}
		}

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr__keyBags;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr__secretBags;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr__certs;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr__keyBagsChanged;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr__secretBagsChanged;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr__certsChanged;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr__iterations;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr__safeBags;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_password_max_length;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0;

		// Token: 0x02000543 RID: 1347
		public class DeriveBytes : Object
		{
			// Token: 0x06004F52 RID: 20306 RVA: 0x00168D28 File Offset: 0x00166F28
			// Note: this type is marked as 'beforefieldinit'.
			static DeriveBytes()
			{
				Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "DeriveBytes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr);
				PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "keyDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "ivDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "macDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_hashName");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_iterations");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_password");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_salt");
				PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663585);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663586);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663587);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663588);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663589);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663590);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663591);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663592);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663593);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663594);
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x00168EA8 File Offset: 0x001670A8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeriveBytes()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001454 RID: 5204
			// (set) Token: 0x06004F54 RID: 20308 RVA: 0x00168EE4 File Offset: 0x001670E4
			public unsafe string HashName
			{
				[CallerCount(79)]
				[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001455 RID: 5205
			// (set) Token: 0x06004F55 RID: 20309 RVA: 0x00168F28 File Offset: 0x00167128
			public unsafe int IterationCount
			{
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001456 RID: 5206
			// (set) Token: 0x06004F56 RID: 20310 RVA: 0x00168F68 File Offset: 0x00167168
			public unsafe Il2CppStructArray<byte> Password
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 133140, RefRangeEnd = 133142, XrefRangeStart = 133136, XrefRangeEnd = 133140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001457 RID: 5207
			// (set) Token: 0x06004F57 RID: 20311 RVA: 0x00168FAC File Offset: 0x001671AC
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 133143, RefRangeEnd = 133145, XrefRangeStart = 133142, XrefRangeEnd = 133143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004F58 RID: 20312 RVA: 0x00168FF0 File Offset: 0x001671F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 127113, RefRangeEnd = 127115, XrefRangeStart = 127113, XrefRangeEnd = 127115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Adjust(Il2CppStructArray<byte> a, int aOff, Il2CppStructArray<byte> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aOff;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F59 RID: 20313 RVA: 0x00169054 File Offset: 0x00167254
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 133177, RefRangeEnd = 133183, XrefRangeStart = 133145, XrefRangeEnd = 133177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> Derive(Il2CppStructArray<byte> diversifier, int n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(diversifier);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x06004F5A RID: 20314 RVA: 0x001690B4 File Offset: 0x001672B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133183, XrefRangeEnd = 133188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveKey(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004F5B RID: 20315 RVA: 0x00169100 File Offset: 0x00167300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133188, XrefRangeEnd = 133193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveIV(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004F5C RID: 20316 RVA: 0x0016914C File Offset: 0x0016734C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133193, XrefRangeEnd = 133218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveMAC(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004F5D RID: 20317 RVA: 0x0001DBB1 File Offset: 0x0001BDB1
			public DeriveBytes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700144D RID: 5197
			// (get) Token: 0x06004F5E RID: 20318 RVA: 0x00169198 File Offset: 0x00167398
			// (set) Token: 0x06004F5F RID: 20319 RVA: 0x0001DBBA File Offset: 0x0001BDBA
			public unsafe static Il2CppStructArray<byte> keyDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144E RID: 5198
			// (get) Token: 0x06004F60 RID: 20320 RVA: 0x001691C0 File Offset: 0x001673C0
			// (set) Token: 0x06004F61 RID: 20321 RVA: 0x0001DBCC File Offset: 0x0001BDCC
			public unsafe static Il2CppStructArray<byte> ivDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144F RID: 5199
			// (get) Token: 0x06004F62 RID: 20322 RVA: 0x001691E8 File Offset: 0x001673E8
			// (set) Token: 0x06004F63 RID: 20323 RVA: 0x0001DBDE File Offset: 0x0001BDDE
			public unsafe static Il2CppStructArray<byte> macDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001450 RID: 5200
			// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00169210 File Offset: 0x00167410
			// (set) Token: 0x06004F65 RID: 20325 RVA: 0x0001DBF0 File Offset: 0x0001BDF0
			public unsafe string _hashName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001451 RID: 5201
			// (get) Token: 0x06004F66 RID: 20326 RVA: 0x00169238 File Offset: 0x00167438
			// (set) Token: 0x06004F67 RID: 20327 RVA: 0x0001DC0F File Offset: 0x0001BE0F
			public unsafe int _iterations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations)) = value;
				}
			}

			// Token: 0x17001452 RID: 5202
			// (get) Token: 0x06004F68 RID: 20328 RVA: 0x00169260 File Offset: 0x00167460
			// (set) Token: 0x06004F69 RID: 20329 RVA: 0x0001DC2A File Offset: 0x0001BE2A
			public unsafe Il2CppStructArray<byte> _password
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__password);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__password), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001453 RID: 5203
			// (get) Token: 0x06004F6A RID: 20330 RVA: 0x00169290 File Offset: 0x00167490
			// (set) Token: 0x06004F6B RID: 20331 RVA: 0x0001DC49 File Offset: 0x0001BE49
			public unsafe Il2CppStructArray<byte> _salt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__salt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__salt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004017 RID: 16407
			private static readonly IntPtr NativeFieldInfoPtr_keyDiversifier;

			// Token: 0x04004018 RID: 16408
			private static readonly IntPtr NativeFieldInfoPtr_ivDiversifier;

			// Token: 0x04004019 RID: 16409
			private static readonly IntPtr NativeFieldInfoPtr_macDiversifier;

			// Token: 0x0400401A RID: 16410
			private static readonly IntPtr NativeFieldInfoPtr__hashName;

			// Token: 0x0400401B RID: 16411
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x0400401C RID: 16412
			private static readonly IntPtr NativeFieldInfoPtr__password;

			// Token: 0x0400401D RID: 16413
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x0400401E RID: 16414
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400401F RID: 16415
			private static readonly IntPtr NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0;

			// Token: 0x04004020 RID: 16416
			private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

			// Token: 0x04004021 RID: 16417
			private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004022 RID: 16418
			private static readonly IntPtr NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004023 RID: 16419
			private static readonly IntPtr NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004024 RID: 16420
			private static readonly IntPtr NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04004025 RID: 16421
			private static readonly IntPtr NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04004026 RID: 16422
			private static readonly IntPtr NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04004027 RID: 16423
			private static readonly IntPtr NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0;
		}
	}
}
