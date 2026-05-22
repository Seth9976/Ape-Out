using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C8 RID: 200
	public sealed class X509SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x000384C8 File Offset: 0x000366C8
		// Note: this type is marked as 'beforefieldinit'.
		static X509SubjectKeyIdentifierExtension()
		{
			Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509SubjectKeyIdentifierExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr);
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "oid");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "friendlyName");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_subjectKeyIdentifier");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_ski");
			X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, "_status");
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664796);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664797);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664798);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664799);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664800);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664801);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664802);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664803);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664804);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664805);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664806);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664807);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664808);
			X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr, 100664809);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00038674 File Offset: 0x00036874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374725, XrefRangeEnd = 374733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000386B0 File Offset: 0x000368B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374733, XrefRangeEnd = 374742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedSubjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0003870C File Offset: 0x0003690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374742, XrefRangeEnd = 374771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(Il2CppStructArray<byte> subjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00038768 File Offset: 0x00036968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374771, XrefRangeEnd = 374796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subjectKeyIdentifier);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000387C4 File Offset: 0x000369C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374796, XrefRangeEnd = 374797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00038820 File Offset: 0x00036A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374883, RefRangeEnd = 374884, XrefRangeStart = 374797, XrefRangeEnd = 374883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509SubjectKeyIdentifierExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref algorithm;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00038888 File Offset: 0x00036A88
		public unsafe string SubjectKeyIdentifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374884, XrefRangeEnd = 374886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000388C0 File Offset: 0x00036AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374886, XrefRangeEnd = 374901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00038904 File Offset: 0x00036B04
		[CallerCount(0)]
		public unsafe static byte FromHexChar(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00038944 File Offset: 0x00036B44
		[CallerCount(0)]
		public unsafe static byte FromHexChars(char c1, char c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00038990 File Offset: 0x00036B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374910, RefRangeEnd = 374911, XrefRangeStart = 374901, XrefRangeEnd = 374910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromHex(string hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000389D4 File Offset: 0x00036BD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 374920, RefRangeEnd = 374923, XrefRangeStart = 374911, XrefRangeEnd = 374920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00038A24 File Offset: 0x00036C24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 374926, RefRangeEnd = 374929, XrefRangeStart = 374923, XrefRangeEnd = 374926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00038A64 File Offset: 0x00036C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374929, XrefRangeEnd = 374939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509SubjectKeyIdentifierExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00006633 File Offset: 0x00004833
		public X509SubjectKeyIdentifierExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00038AA8 File Offset: 0x00036CA8
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0000663C File Offset: 0x0000483C
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00038AC8 File Offset: 0x00036CC8
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x0000664E File Offset: 0x0000484E
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00038AE8 File Offset: 0x00036CE8
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00006660 File Offset: 0x00004860
		public unsafe Il2CppStructArray<byte> _subjectKeyIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__subjectKeyIdentifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00038B18 File Offset: 0x00036D18
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0000667F File Offset: 0x0000487F
		public unsafe string _ski
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__ski), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00038B40 File Offset: 0x00036D40
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x0000669E File Offset: 0x0000489E
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509SubjectKeyIdentifierExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr__subjectKeyIdentifier;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr__ski;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublicKey_Boolean_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublicKey_X509SubjectKeyIdentifierHashAlgorithm_Boolean_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectKeyIdentifier_Public_get_String_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_FromHexChar_Internal_Static_Byte_Char_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_FromHexChars_Internal_Static_Byte_Char_Char_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Internal_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
