using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B1 RID: 177
	public sealed class PublicKey : Object
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x00033B24 File Offset: 0x00031D24
		// Note: this type is marked as 'beforefieldinit'.
		static PublicKey()
		{
			Il2CppClassPointerStore<PublicKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "PublicKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublicKey>.NativeClassPtr);
			PublicKey.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_key");
			PublicKey.NativeFieldInfoPtr__keyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_keyValue");
			PublicKey.NativeFieldInfoPtr__params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_params");
			PublicKey.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_oid");
			PublicKey.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "Empty");
			PublicKey.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664632);
			PublicKey.NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664633);
			PublicKey.NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664634);
			PublicKey.NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664635);
			PublicKey.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664636);
			PublicKey.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664637);
			PublicKey.NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664638);
			PublicKey.NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664639);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00033C58 File Offset: 0x00031E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373620, RefRangeEnd = 373621, XrefRangeStart = 373576, XrefRangeEnd = 373620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PublicKey(Il2CppMono.Security.X509.X509Certificate certificate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PublicKey>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00033CA4 File Offset: 0x00031EA4
		public unsafe AsnEncodedData EncodedKeyValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr3) : null;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00033CE4 File Offset: 0x00031EE4
		public unsafe AsnEncodedData EncodedParameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr3) : null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00033D24 File Offset: 0x00031F24
		public unsafe AsymmetricAlgorithm Key
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 373630, RefRangeEnd = 373632, XrefRangeStart = 373621, XrefRangeEnd = 373630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00033D64 File Offset: 0x00031F64
		public unsafe Oid Oid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00033DA4 File Offset: 0x00031FA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 373636, RefRangeEnd = 373641, XrefRangeStart = 373632, XrefRangeEnd = 373636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUnsignedBigInteger(Il2CppStructArray<byte> integer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(integer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00033DE8 File Offset: 0x00031FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373671, RefRangeEnd = 373672, XrefRangeStart = 373641, XrefRangeEnd = 373671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DSA DecodeDSA(Il2CppStructArray<byte> rawPublicKey, Il2CppStructArray<byte> rawParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawPublicKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00033E40 File Offset: 0x00032040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373672, XrefRangeEnd = 373688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA DecodeRSA(Il2CppStructArray<byte> rawPublicKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawPublicKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00005D79 File Offset: 0x00003F79
		public PublicKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00033E84 File Offset: 0x00032084
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00005D82 File Offset: 0x00003F82
		public unsafe AsymmetricAlgorithm _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00033EB4 File Offset: 0x000320B4
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00005DA1 File Offset: 0x00003FA1
		public unsafe AsnEncodedData _keyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__keyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__keyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00033EE4 File Offset: 0x000320E4
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public unsafe AsnEncodedData _params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00033F14 File Offset: 0x00032114
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00005DDF File Offset: 0x00003FDF
		public unsafe Oid _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__oid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__oid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00033F44 File Offset: 0x00032144
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00005DFE File Offset: 0x00003FFE
		public unsafe static Il2CppStructArray<byte> Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PublicKey.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PublicKey.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr__keyValue;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr__params;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_get_Oid_Public_get_Oid_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0;
	}
}
