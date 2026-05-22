using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x02000006 RID: 6
	public sealed class PKCS7 : Object
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002106 File Offset: 0x00000306
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS7()
		{
			Il2CppClassPointerStore<PKCS7>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "PKCS7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7>.NativeClassPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000212B File Offset: 0x0000032B
		public PKCS7(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000038 RID: 56
		public class ContentInfo : Object
		{
			// Token: 0x06000307 RID: 775 RVA: 0x0000E95C File Offset: 0x0000CB5C
			// Note: this type is marked as 'beforefieldinit'.
			static ContentInfo()
			{
				Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "ContentInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr);
				PKCS7.ContentInfo.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "contentType");
				PKCS7.ContentInfo.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "content");
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663329);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663330);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663331);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663332);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663333);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_Content_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663334);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663335);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ContentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663336);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663337);
				PKCS7.ContentInfo.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663338);
			}

			// Token: 0x06000308 RID: 776 RVA: 0x0000EA78 File Offset: 0x0000CC78
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 127037, RefRangeEnd = 127039, XrefRangeStart = 127034, XrefRangeEnd = 127037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0000EAB4 File Offset: 0x0000CCB4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 127040, RefRangeEnd = 127045, XrefRangeStart = 127039, XrefRangeEnd = 127040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(string oid)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600030A RID: 778 RVA: 0x0000EB00 File Offset: 0x0000CD00
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 127050, RefRangeEnd = 127055, XrefRangeStart = 127045, XrefRangeEnd = 127050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600030B RID: 779 RVA: 0x0000EB4C File Offset: 0x0000CD4C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 127062, RefRangeEnd = 127065, XrefRangeStart = 127055, XrefRangeEnd = 127062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x0600030C RID: 780 RVA: 0x0000EB98 File Offset: 0x0000CD98
			public unsafe ASN1 ASN1
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 127075, RefRangeEnd = 127080, XrefRangeStart = 127065, XrefRangeEnd = 127075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x0600030D RID: 781 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
			// (set) Token: 0x0600030E RID: 782 RVA: 0x0000EC18 File Offset: 0x0000CE18
			public unsafe ASN1 Content
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_Content_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x0600030F RID: 783 RVA: 0x0000EC5C File Offset: 0x0000CE5C
			// (set) Token: 0x06000310 RID: 784 RVA: 0x0000EC94 File Offset: 0x0000CE94
			public unsafe string ContentType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_ContentType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000311 RID: 785 RVA: 0x0000ECD8 File Offset: 0x0000CED8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 127075, RefRangeEnd = 127080, XrefRangeStart = 127075, XrefRangeEnd = 127080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ASN1 GetASN1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}

			// Token: 0x06000312 RID: 786 RVA: 0x0000344B File Offset: 0x0000164B
			public ContentInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000313 RID: 787 RVA: 0x0000ED18 File Offset: 0x0000CF18
			// (set) Token: 0x06000314 RID: 788 RVA: 0x00003454 File Offset: 0x00001654
			public unsafe string contentType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_contentType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_contentType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000315 RID: 789 RVA: 0x0000ED40 File Offset: 0x0000CF40
			// (set) Token: 0x06000316 RID: 790 RVA: 0x00003473 File Offset: 0x00001673
			public unsafe ASN1 content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_content);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeFieldInfoPtr_contentType;

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0;

			// Token: 0x0400034F RID: 847
			private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_ASN1_0;

			// Token: 0x04000350 RID: 848
			private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0;

			// Token: 0x04000351 RID: 849
			private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_String_0;

			// Token: 0x04000352 RID: 850
			private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0;

			// Token: 0x04000353 RID: 851
			private static readonly IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_0;
		}

		// Token: 0x02000039 RID: 57
		public class EncryptedData : Object
		{
			// Token: 0x06000317 RID: 791 RVA: 0x0000ED70 File Offset: 0x0000CF70
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedData()
			{
				Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "EncryptedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr);
				PKCS7.EncryptedData.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_version");
				PKCS7.EncryptedData.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_content");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encryptionAlgorithm");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encrypted");
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663339);
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663340);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663341);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663342);
			}

			// Token: 0x06000318 RID: 792 RVA: 0x0000EE3C File Offset: 0x0000D03C
			[CallerCount(0)]
			public unsafe EncryptedData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x0000EE78 File Offset: 0x0000D078
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 127100, RefRangeEnd = 127101, XrefRangeStart = 127080, XrefRangeEnd = 127100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedData(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600031A RID: 794 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
			public unsafe PKCS7.ContentInfo EncryptionAlgorithm
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr3) : null;
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600031B RID: 795 RVA: 0x0000EF04 File Offset: 0x0000D104
			public unsafe Il2CppStructArray<byte> EncryptedContent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127101, XrefRangeEnd = 127104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x0600031C RID: 796 RVA: 0x00003492 File Offset: 0x00001692
			public EncryptedData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x0600031D RID: 797 RVA: 0x0000EF44 File Offset: 0x0000D144
			// (set) Token: 0x0600031E RID: 798 RVA: 0x0000349B File Offset: 0x0000169B
			public unsafe byte _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x0600031F RID: 799 RVA: 0x0000EF6C File Offset: 0x0000D16C
			// (set) Token: 0x06000320 RID: 800 RVA: 0x000034B6 File Offset: 0x000016B6
			public unsafe PKCS7.ContentInfo _content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__content);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__content), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000321 RID: 801 RVA: 0x0000EF9C File Offset: 0x0000D19C
			// (set) Token: 0x06000322 RID: 802 RVA: 0x000034D5 File Offset: 0x000016D5
			public unsafe PKCS7.ContentInfo _encryptionAlgorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000323 RID: 803 RVA: 0x0000EFCC File Offset: 0x0000D1CC
			// (set) Token: 0x06000324 RID: 804 RVA: 0x000034F4 File Offset: 0x000016F4
			public unsafe Il2CppStructArray<byte> _encrypted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000354 RID: 852
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04000355 RID: 853
			private static readonly IntPtr NativeFieldInfoPtr__content;

			// Token: 0x04000356 RID: 854
			private static readonly IntPtr NativeFieldInfoPtr__encryptionAlgorithm;

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr__encrypted;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0;

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0;
		}
	}
}
