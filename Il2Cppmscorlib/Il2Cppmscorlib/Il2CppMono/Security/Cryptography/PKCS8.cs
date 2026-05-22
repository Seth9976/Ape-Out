using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000031 RID: 49
	public sealed class PKCS8 : Object
	{
		// Token: 0x06000330 RID: 816 RVA: 0x00003514 File Offset: 0x00001714
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS8()
		{
			Il2CppClassPointerStore<PKCS8>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "PKCS8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8>.NativeClassPtr);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003539 File Offset: 0x00001739
		public PKCS8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000545 RID: 1349
		public class PrivateKeyInfo : Object
		{
			// Token: 0x06004F76 RID: 20342 RVA: 0x00169520 File Offset: 0x00167720
			// Note: this type is marked as 'beforefieldinit'.
			static PrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "PrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr);
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_version");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_key");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_list");
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663714);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663715);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663716);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663717);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663718);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663719);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663720);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663721);
			}

			// Token: 0x06004F77 RID: 20343 RVA: 0x0016963C File Offset: 0x0016783C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135428, XrefRangeEnd = 135432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F78 RID: 20344 RVA: 0x00169678 File Offset: 0x00167878
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 135437, RefRangeEnd = 135441, XrefRangeStart = 135432, XrefRangeEnd = 135437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700145F RID: 5215
			// (get) Token: 0x06004F79 RID: 20345 RVA: 0x001696C4 File Offset: 0x001678C4
			public unsafe Il2CppStructArray<byte> PrivateKey
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 135444, RefRangeEnd = 135447, XrefRangeStart = 135441, XrefRangeEnd = 135444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004F7A RID: 20346 RVA: 0x00169704 File Offset: 0x00167904
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 135462, RefRangeEnd = 135463, XrefRangeStart = 135447, XrefRangeEnd = 135462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Decode(Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F7B RID: 20347 RVA: 0x00169748 File Offset: 0x00167948
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 135467, RefRangeEnd = 135469, XrefRangeStart = 135463, XrefRangeEnd = 135467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> RemoveLeadingZero(Il2CppStructArray<byte> bigInt)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bigInt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004F7C RID: 20348 RVA: 0x0016978C File Offset: 0x0016798C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 135473, RefRangeEnd = 135480, XrefRangeStart = 135469, XrefRangeEnd = 135473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Normalize(Il2CppStructArray<byte> bigInt, int length)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bigInt);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x06004F7D RID: 20349 RVA: 0x001697E0 File Offset: 0x001679E0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 135523, RefRangeEnd = 135526, XrefRangeStart = 135480, XrefRangeEnd = 135523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static RSA DecodeRSA(Il2CppStructArray<byte> keypair)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keypair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
				}
			}

			// Token: 0x06004F7E RID: 20350 RVA: 0x00169824 File Offset: 0x00167A24
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 135536, RefRangeEnd = 135539, XrefRangeStart = 135526, XrefRangeEnd = 135536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DSA DecodeDSA(Il2CppStructArray<byte> privateKey, DSAParameters dsaParameters)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(privateKey);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dsaParameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
			}

			// Token: 0x06004F7F RID: 20351 RVA: 0x0001DC90 File Offset: 0x0001BE90
			public PrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700145B RID: 5211
			// (get) Token: 0x06004F80 RID: 20352 RVA: 0x00169880 File Offset: 0x00167A80
			// (set) Token: 0x06004F81 RID: 20353 RVA: 0x0001DC99 File Offset: 0x0001BE99
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x1700145C RID: 5212
			// (get) Token: 0x06004F82 RID: 20354 RVA: 0x001698A8 File Offset: 0x00167AA8
			// (set) Token: 0x06004F83 RID: 20355 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
			public unsafe string _algorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700145D RID: 5213
			// (get) Token: 0x06004F84 RID: 20356 RVA: 0x001698D0 File Offset: 0x00167AD0
			// (set) Token: 0x06004F85 RID: 20357 RVA: 0x0001DCD3 File Offset: 0x0001BED3
			public unsafe Il2CppStructArray<byte> _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700145E RID: 5214
			// (get) Token: 0x06004F86 RID: 20358 RVA: 0x00169900 File Offset: 0x00167B00
			// (set) Token: 0x06004F87 RID: 20359 RVA: 0x0001DCF2 File Offset: 0x0001BEF2
			public unsafe ArrayList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400402F RID: 16431
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004030 RID: 16432
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x04004031 RID: 16433
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04004032 RID: 16434
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04004033 RID: 16435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004034 RID: 16436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004035 RID: 16437
			private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004036 RID: 16438
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004037 RID: 16439
			private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004038 RID: 16440
			private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04004039 RID: 16441
			private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400403A RID: 16442
			private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0;
		}

		// Token: 0x02000546 RID: 1350
		public class EncryptedPrivateKeyInfo : Object
		{
			// Token: 0x06004F88 RID: 20360 RVA: 0x00169930 File Offset: 0x00167B30
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedPrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "EncryptedPrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr);
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_salt");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_iterations");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_data");
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663722);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663723);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663724);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663725);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663726);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663727);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663728);
			}

			// Token: 0x06004F89 RID: 20361 RVA: 0x00169A38 File Offset: 0x00167C38
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedPrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F8A RID: 20362 RVA: 0x00169A74 File Offset: 0x00167C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135539, XrefRangeEnd = 135540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedPrivateKeyInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001464 RID: 5220
			// (get) Token: 0x06004F8B RID: 20363 RVA: 0x00169AC0 File Offset: 0x00167CC0
			public unsafe string Algorithm
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001465 RID: 5221
			// (get) Token: 0x06004F8C RID: 20364 RVA: 0x00169AF8 File Offset: 0x00167CF8
			public unsafe Il2CppStructArray<byte> EncryptedData
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 135541, RefRangeEnd = 135543, XrefRangeStart = 135540, XrefRangeEnd = 135541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x17001466 RID: 5222
			// (get) Token: 0x06004F8D RID: 20365 RVA: 0x00169B38 File Offset: 0x00167D38
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 135549, RefRangeEnd = 135551, XrefRangeStart = 135543, XrefRangeEnd = 135549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x17001467 RID: 5223
			// (get) Token: 0x06004F8E RID: 20366 RVA: 0x00169B78 File Offset: 0x00167D78
			public unsafe int IterationCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F8F RID: 20367 RVA: 0x00169BB4 File Offset: 0x00167DB4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 135566, RefRangeEnd = 135569, XrefRangeStart = 135551, XrefRangeEnd = 135566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Decode(Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F90 RID: 20368 RVA: 0x0001DD11 File Offset: 0x0001BF11
			public EncryptedPrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001460 RID: 5216
			// (get) Token: 0x06004F91 RID: 20369 RVA: 0x00169BF8 File Offset: 0x00167DF8
			// (set) Token: 0x06004F92 RID: 20370 RVA: 0x0001DD1A File Offset: 0x0001BF1A
			public unsafe string _algorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001461 RID: 5217
			// (get) Token: 0x06004F93 RID: 20371 RVA: 0x00169C20 File Offset: 0x00167E20
			// (set) Token: 0x06004F94 RID: 20372 RVA: 0x0001DD39 File Offset: 0x0001BF39
			public unsafe Il2CppStructArray<byte> _salt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001462 RID: 5218
			// (get) Token: 0x06004F95 RID: 20373 RVA: 0x00169C50 File Offset: 0x00167E50
			// (set) Token: 0x06004F96 RID: 20374 RVA: 0x0001DD58 File Offset: 0x0001BF58
			public unsafe int _iterations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations)) = value;
				}
			}

			// Token: 0x17001463 RID: 5219
			// (get) Token: 0x06004F97 RID: 20375 RVA: 0x00169C78 File Offset: 0x00167E78
			// (set) Token: 0x06004F98 RID: 20376 RVA: 0x0001DD73 File Offset: 0x0001BF73
			public unsafe Il2CppStructArray<byte> _data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400403B RID: 16443
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x0400403C RID: 16444
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x0400403D RID: 16445
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x0400403E RID: 16446
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x0400403F RID: 16447
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004040 RID: 16448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004041 RID: 16449
			private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

			// Token: 0x04004042 RID: 16450
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004043 RID: 16451
			private static readonly IntPtr NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004044 RID: 16452
			private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

			// Token: 0x04004045 RID: 16453
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;
		}
	}
}
