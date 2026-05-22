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
	// Token: 0x0200002F RID: 47
	public sealed class PKCS8 : Object
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00003069 File Offset: 0x00001269
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS8()
		{
			Il2CppClassPointerStore<PKCS8>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "PKCS8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8>.NativeClassPtr);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000308E File Offset: 0x0000128E
		public PKCS8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200003C RID: 60
		public class PrivateKeyInfo : Object
		{
			// Token: 0x06000349 RID: 841 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
			// Note: this type is marked as 'beforefieldinit'.
			static PrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "PrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr);
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_version");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_key");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_list");
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663607);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663608);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663609);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663610);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663611);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663612);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663613);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663614);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663615);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663616);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663617);
			}

			// Token: 0x0600034A RID: 842 RVA: 0x0000F94C File Offset: 0x0000DB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129909, XrefRangeEnd = 129913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600034B RID: 843 RVA: 0x0000F988 File Offset: 0x0000DB88
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 129918, RefRangeEnd = 129922, XrefRangeStart = 129913, XrefRangeEnd = 129918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x0600034C RID: 844 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
			public unsafe Il2CppStructArray<byte> PrivateKey
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 129925, RefRangeEnd = 129928, XrefRangeStart = 129922, XrefRangeEnd = 129925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600034D RID: 845 RVA: 0x0000FA14 File Offset: 0x0000DC14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129943, RefRangeEnd = 129944, XrefRangeStart = 129928, XrefRangeEnd = 129943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600034E RID: 846 RVA: 0x0000FA58 File Offset: 0x0000DC58
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129948, RefRangeEnd = 129950, XrefRangeStart = 129944, XrefRangeEnd = 129948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600034F RID: 847 RVA: 0x0000FA9C File Offset: 0x0000DC9C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 129954, RefRangeEnd = 129961, XrefRangeStart = 129950, XrefRangeEnd = 129954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000350 RID: 848 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 130004, RefRangeEnd = 130007, XrefRangeStart = 129961, XrefRangeEnd = 130004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000351 RID: 849 RVA: 0x0000FB34 File Offset: 0x0000DD34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130033, RefRangeEnd = 130034, XrefRangeStart = 130007, XrefRangeEnd = 130033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(RSA rsa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000352 RID: 850 RVA: 0x0000FB78 File Offset: 0x0000DD78
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 130044, RefRangeEnd = 130047, XrefRangeStart = 130034, XrefRangeEnd = 130044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000353 RID: 851 RVA: 0x0000FBD4 File Offset: 0x0000DDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130047, XrefRangeEnd = 130049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(DSA dsa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dsa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000354 RID: 852 RVA: 0x0000FC18 File Offset: 0x0000DE18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130066, RefRangeEnd = 130067, XrefRangeStart = 130049, XrefRangeEnd = 130066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(AsymmetricAlgorithm aa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000355 RID: 853 RVA: 0x000035F2 File Offset: 0x000017F2
			public PrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000356 RID: 854 RVA: 0x0000FC5C File Offset: 0x0000DE5C
			// (set) Token: 0x06000357 RID: 855 RVA: 0x000035FB File Offset: 0x000017FB
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

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000358 RID: 856 RVA: 0x0000FC84 File Offset: 0x0000DE84
			// (set) Token: 0x06000359 RID: 857 RVA: 0x00003616 File Offset: 0x00001816
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

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x0600035A RID: 858 RVA: 0x0000FCAC File Offset: 0x0000DEAC
			// (set) Token: 0x0600035B RID: 859 RVA: 0x00003635 File Offset: 0x00001835
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

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0000FCDC File Offset: 0x0000DEDC
			// (set) Token: 0x0600035D RID: 861 RVA: 0x00003654 File Offset: 0x00001854
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

			// Token: 0x04000374 RID: 884
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04000375 RID: 885
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x04000376 RID: 886
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04000377 RID: 887
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04000378 RID: 888
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000379 RID: 889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400037A RID: 890
			private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400037B RID: 891
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400037C RID: 892
			private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400037D RID: 893
			private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x0400037E RID: 894
			private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400037F RID: 895
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0;

			// Token: 0x04000380 RID: 896
			private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0;

			// Token: 0x04000381 RID: 897
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0;

			// Token: 0x04000382 RID: 898
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0;
		}

		// Token: 0x0200003D RID: 61
		public class EncryptedPrivateKeyInfo : Object
		{
			// Token: 0x0600035E RID: 862 RVA: 0x0000FD0C File Offset: 0x0000DF0C
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedPrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "EncryptedPrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr);
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_salt");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_iterations");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_data");
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663618);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663619);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663620);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663621);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663622);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663623);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663624);
			}

			// Token: 0x0600035F RID: 863 RVA: 0x0000FE14 File Offset: 0x0000E014
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

			// Token: 0x06000360 RID: 864 RVA: 0x0000FE50 File Offset: 0x0000E050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130067, XrefRangeEnd = 130068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000361 RID: 865 RVA: 0x0000FE9C File Offset: 0x0000E09C
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

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000362 RID: 866 RVA: 0x0000FED4 File Offset: 0x0000E0D4
			public unsafe Il2CppStructArray<byte> EncryptedData
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 130069, RefRangeEnd = 130071, XrefRangeStart = 130068, XrefRangeEnd = 130069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000363 RID: 867 RVA: 0x0000FF14 File Offset: 0x0000E114
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 130077, RefRangeEnd = 130079, XrefRangeStart = 130071, XrefRangeEnd = 130077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0000FF54 File Offset: 0x0000E154
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

			// Token: 0x06000365 RID: 869 RVA: 0x0000FF90 File Offset: 0x0000E190
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 130094, RefRangeEnd = 130097, XrefRangeStart = 130079, XrefRangeEnd = 130094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000366 RID: 870 RVA: 0x00003673 File Offset: 0x00001873
			public EncryptedPrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000367 RID: 871 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
			// (set) Token: 0x06000368 RID: 872 RVA: 0x0000367C File Offset: 0x0000187C
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

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000369 RID: 873 RVA: 0x0000FFFC File Offset: 0x0000E1FC
			// (set) Token: 0x0600036A RID: 874 RVA: 0x0000369B File Offset: 0x0000189B
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

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600036B RID: 875 RVA: 0x0001002C File Offset: 0x0000E22C
			// (set) Token: 0x0600036C RID: 876 RVA: 0x000036BA File Offset: 0x000018BA
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

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600036D RID: 877 RVA: 0x00010054 File Offset: 0x0000E254
			// (set) Token: 0x0600036E RID: 878 RVA: 0x000036D5 File Offset: 0x000018D5
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

			// Token: 0x04000383 RID: 899
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x04000384 RID: 900
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x04000385 RID: 901
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x04000386 RID: 902
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x04000387 RID: 903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000388 RID: 904
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000389 RID: 905
			private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

			// Token: 0x0400038A RID: 906
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400038B RID: 907
			private static readonly IntPtr NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400038C RID: 908
			private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

			// Token: 0x0400038D RID: 909
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;
		}
	}
}
