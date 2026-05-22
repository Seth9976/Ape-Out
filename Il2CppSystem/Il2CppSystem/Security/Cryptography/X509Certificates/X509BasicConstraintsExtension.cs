using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B3 RID: 179
	public sealed class X509BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x00033F6C File Offset: 0x0003216C
		// Note: this type is marked as 'beforefieldinit'.
		static X509BasicConstraintsExtension()
		{
			Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509BasicConstraintsExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr);
			X509BasicConstraintsExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "oid");
			X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "friendlyName");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_certificateAuthority");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_hasPathLengthConstraint");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_pathLengthConstraint");
			X509BasicConstraintsExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, "_status");
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664641);
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664642);
			X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664643);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664644);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664645);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664646);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664647);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664648);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664649);
			X509BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr, 100664650);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000340DC File Offset: 0x000322DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373688, XrefRangeEnd = 373696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00034118 File Offset: 0x00032318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373696, XrefRangeEnd = 373705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedBasicConstraints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00034174 File Offset: 0x00032374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373705, XrefRangeEnd = 373721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509BasicConstraintsExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref certificateAuthority;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasPathLengthConstraint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathLengthConstraint;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000341E8 File Offset: 0x000323E8
		public unsafe bool CertificateAuthority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00034224 File Offset: 0x00032424
		public unsafe bool HasPathLengthConstraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00034260 File Offset: 0x00032460
		public unsafe int PathLengthConstraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0003429C File Offset: 0x0003249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373721, XrefRangeEnd = 373736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000342E0 File Offset: 0x000324E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373737, RefRangeEnd = 373740, XrefRangeStart = 373736, XrefRangeEnd = 373737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00034330 File Offset: 0x00032530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373759, RefRangeEnd = 373760, XrefRangeStart = 373740, XrefRangeEnd = 373759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00034370 File Offset: 0x00032570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373760, XrefRangeEnd = 373798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509BasicConstraintsExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00005E3E File Offset: 0x0000403E
		public X509BasicConstraintsExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x000343B4 File Offset: 0x000325B4
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00005E47 File Offset: 0x00004047
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x000343D4 File Offset: 0x000325D4
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00005E59 File Offset: 0x00004059
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509BasicConstraintsExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x000343F4 File Offset: 0x000325F4
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00005E6B File Offset: 0x0000406B
		public unsafe bool _certificateAuthority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__certificateAuthority)) = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0003441C File Offset: 0x0003261C
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00005E86 File Offset: 0x00004086
		public unsafe bool _hasPathLengthConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__hasPathLengthConstraint)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00034444 File Offset: 0x00032644
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00005EA1 File Offset: 0x000040A1
		public unsafe int _pathLengthConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__pathLengthConstraint)) = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0003446C File Offset: 0x0003266C
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00005EBC File Offset: 0x000040BC
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509BasicConstraintsExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr__certificateAuthority;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr__hasPathLengthConstraint;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr__pathLengthConstraint;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Boolean_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateAuthority_Public_get_Boolean_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPathLengthConstraint_Public_get_Boolean_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_get_PathLengthConstraint_Public_get_Int32_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
