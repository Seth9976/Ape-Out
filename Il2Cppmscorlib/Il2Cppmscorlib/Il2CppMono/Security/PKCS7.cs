using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x02000021 RID: 33
	public sealed class PKCS7 : Object
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00002BDF File Offset: 0x00000DDF
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS7()
		{
			Il2CppClassPointerStore<PKCS7>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security", "PKCS7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7>.NativeClassPtr);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002C04 File Offset: 0x00000E04
		public PKCS7(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000541 RID: 1345
		public class ContentInfo : Object
		{
			// Token: 0x06004F34 RID: 20276 RVA: 0x00168688 File Offset: 0x00166888
			// Note: this type is marked as 'beforefieldinit'.
			static ContentInfo()
			{
				Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "ContentInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr);
				PKCS7.ContentInfo.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "contentType");
				PKCS7.ContentInfo.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "content");
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663538);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663539);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663540);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663541);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663542);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_Content_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663543);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663544);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ContentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663545);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663546);
				PKCS7.ContentInfo.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663547);
			}

			// Token: 0x06004F35 RID: 20277 RVA: 0x001687A4 File Offset: 0x001669A4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 133069, RefRangeEnd = 133071, XrefRangeStart = 133066, XrefRangeEnd = 133069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F36 RID: 20278 RVA: 0x001687E0 File Offset: 0x001669E0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 133072, RefRangeEnd = 133077, XrefRangeStart = 133071, XrefRangeEnd = 133072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004F37 RID: 20279 RVA: 0x0016882C File Offset: 0x00166A2C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 133082, RefRangeEnd = 133087, XrefRangeStart = 133077, XrefRangeEnd = 133082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004F38 RID: 20280 RVA: 0x00168878 File Offset: 0x00166A78
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 133094, RefRangeEnd = 133097, XrefRangeStart = 133087, XrefRangeEnd = 133094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17001444 RID: 5188
			// (get) Token: 0x06004F39 RID: 20281 RVA: 0x001688C4 File Offset: 0x00166AC4
			public unsafe ASN1 ASN1
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 133107, RefRangeEnd = 133112, XrefRangeStart = 133097, XrefRangeEnd = 133107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17001445 RID: 5189
			// (get) Token: 0x06004F3A RID: 20282 RVA: 0x00168904 File Offset: 0x00166B04
			// (set) Token: 0x06004F3B RID: 20283 RVA: 0x00168944 File Offset: 0x00166B44
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

			// Token: 0x17001446 RID: 5190
			// (get) Token: 0x06004F3C RID: 20284 RVA: 0x00168988 File Offset: 0x00166B88
			// (set) Token: 0x06004F3D RID: 20285 RVA: 0x001689C0 File Offset: 0x00166BC0
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

			// Token: 0x06004F3E RID: 20286 RVA: 0x00168A04 File Offset: 0x00166C04
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 133107, RefRangeEnd = 133112, XrefRangeStart = 133107, XrefRangeEnd = 133112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004F3F RID: 20287 RVA: 0x0001DAE9 File Offset: 0x0001BCE9
			public ContentInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001442 RID: 5186
			// (get) Token: 0x06004F40 RID: 20288 RVA: 0x00168A44 File Offset: 0x00166C44
			// (set) Token: 0x06004F41 RID: 20289 RVA: 0x0001DAF2 File Offset: 0x0001BCF2
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

			// Token: 0x17001443 RID: 5187
			// (get) Token: 0x06004F42 RID: 20290 RVA: 0x00168A6C File Offset: 0x00166C6C
			// (set) Token: 0x06004F43 RID: 20291 RVA: 0x0001DB11 File Offset: 0x0001BD11
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

			// Token: 0x04004003 RID: 16387
			private static readonly IntPtr NativeFieldInfoPtr_contentType;

			// Token: 0x04004004 RID: 16388
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x04004005 RID: 16389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004006 RID: 16390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04004007 RID: 16391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04004008 RID: 16392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x04004009 RID: 16393
			private static readonly IntPtr NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0;

			// Token: 0x0400400A RID: 16394
			private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_ASN1_0;

			// Token: 0x0400400B RID: 16395
			private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0;

			// Token: 0x0400400C RID: 16396
			private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_String_0;

			// Token: 0x0400400D RID: 16397
			private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0;

			// Token: 0x0400400E RID: 16398
			private static readonly IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_0;
		}

		// Token: 0x02000542 RID: 1346
		public class EncryptedData : Object
		{
			// Token: 0x06004F44 RID: 20292 RVA: 0x00168A9C File Offset: 0x00166C9C
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedData()
			{
				Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "EncryptedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr);
				PKCS7.EncryptedData.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_version");
				PKCS7.EncryptedData.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_content");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encryptionAlgorithm");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encrypted");
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663548);
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663549);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663550);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663551);
			}

			// Token: 0x06004F45 RID: 20293 RVA: 0x00168B68 File Offset: 0x00166D68
			[CallerCount(0)]
			public unsafe EncryptedData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F46 RID: 20294 RVA: 0x00168BA4 File Offset: 0x00166DA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 133132, RefRangeEnd = 133133, XrefRangeStart = 133112, XrefRangeEnd = 133132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x1700144B RID: 5195
			// (get) Token: 0x06004F47 RID: 20295 RVA: 0x00168BF0 File Offset: 0x00166DF0
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

			// Token: 0x1700144C RID: 5196
			// (get) Token: 0x06004F48 RID: 20296 RVA: 0x00168C30 File Offset: 0x00166E30
			public unsafe Il2CppStructArray<byte> EncryptedContent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133133, XrefRangeEnd = 133136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004F49 RID: 20297 RVA: 0x0001DB30 File Offset: 0x0001BD30
			public EncryptedData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001447 RID: 5191
			// (get) Token: 0x06004F4A RID: 20298 RVA: 0x00168C70 File Offset: 0x00166E70
			// (set) Token: 0x06004F4B RID: 20299 RVA: 0x0001DB39 File Offset: 0x0001BD39
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

			// Token: 0x17001448 RID: 5192
			// (get) Token: 0x06004F4C RID: 20300 RVA: 0x00168C98 File Offset: 0x00166E98
			// (set) Token: 0x06004F4D RID: 20301 RVA: 0x0001DB54 File Offset: 0x0001BD54
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

			// Token: 0x17001449 RID: 5193
			// (get) Token: 0x06004F4E RID: 20302 RVA: 0x00168CC8 File Offset: 0x00166EC8
			// (set) Token: 0x06004F4F RID: 20303 RVA: 0x0001DB73 File Offset: 0x0001BD73
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

			// Token: 0x1700144A RID: 5194
			// (get) Token: 0x06004F50 RID: 20304 RVA: 0x00168CF8 File Offset: 0x00166EF8
			// (set) Token: 0x06004F51 RID: 20305 RVA: 0x0001DB92 File Offset: 0x0001BD92
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

			// Token: 0x0400400F RID: 16399
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004010 RID: 16400
			private static readonly IntPtr NativeFieldInfoPtr__content;

			// Token: 0x04004011 RID: 16401
			private static readonly IntPtr NativeFieldInfoPtr__encryptionAlgorithm;

			// Token: 0x04004012 RID: 16402
			private static readonly IntPtr NativeFieldInfoPtr__encrypted;

			// Token: 0x04004013 RID: 16403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004014 RID: 16404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x04004015 RID: 16405
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0;

			// Token: 0x04004016 RID: 16406
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0;
		}
	}
}
