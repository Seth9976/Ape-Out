using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000C6 RID: 198
	public sealed class X509KeyUsageExtension : X509Extension
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x00037F44 File Offset: 0x00036144
		// Note: this type is marked as 'beforefieldinit'.
		static X509KeyUsageExtension()
		{
			Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr);
			X509KeyUsageExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "oid");
			X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "friendlyName");
			X509KeyUsageExtension.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "all");
			X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_keyUsages");
			X509KeyUsageExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_status");
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664786);
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664787);
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664788);
			X509KeyUsageExtension.NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664789);
			X509KeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664790);
			X509KeyUsageExtension.NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664791);
			X509KeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664792);
			X509KeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664793);
			X509KeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664794);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003808C File Offset: 0x0003628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374616, XrefRangeEnd = 374624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000380C8 File Offset: 0x000362C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374624, XrefRangeEnd = 374633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedKeyUsage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00038124 File Offset: 0x00036324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374633, XrefRangeEnd = 374643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyUsages;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0003817C File Offset: 0x0003637C
		public unsafe X509KeyUsageFlags KeyUsages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x000381B8 File Offset: 0x000363B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374643, XrefRangeEnd = 374658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000381FC File Offset: 0x000363FC
		[CallerCount(0)]
		public unsafe X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00038248 File Offset: 0x00036448
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 374666, RefRangeEnd = 374669, XrefRangeStart = 374658, XrefRangeEnd = 374666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00038298 File Offset: 0x00036498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374697, RefRangeEnd = 374698, XrefRangeStart = 374669, XrefRangeEnd = 374697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000382D8 File Offset: 0x000364D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374698, XrefRangeEnd = 374720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000657B File Offset: 0x0000477B
		public X509KeyUsageExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0003831C File Offset: 0x0003651C
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00006584 File Offset: 0x00004784
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0003833C File Offset: 0x0003653C
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00006596 File Offset: 0x00004796
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0003835C File Offset: 0x0003655C
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x000065A8 File Offset: 0x000047A8
		public unsafe static X509KeyUsageFlags all
		{
			get
			{
				X509KeyUsageFlags x509KeyUsageFlags;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_all, (void*)(&x509KeyUsageFlags));
				return x509KeyUsageFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_all, (void*)(&value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00038378 File Offset: 0x00036578
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x000065B6 File Offset: 0x000047B6
		public unsafe X509KeyUsageFlags _keyUsages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x000383A0 File Offset: 0x000365A0
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x000065D1 File Offset: 0x000047D1
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr__keyUsages;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
