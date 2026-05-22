using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000206 RID: 518
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredUShort
	{
		// Token: 0x06001BDE RID: 7134 RVA: 0x0007E7A4 File Offset: 0x0007C9A4
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredUShort()
		{
			Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredUShort");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr);
			ObscuredUShort.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, "cryptoKey");
			ObscuredUShort.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, "currentCryptoKey");
			ObscuredUShort.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, "hiddenValue");
			ObscuredUShort.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, "inited");
			ObscuredUShort.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, "fakeValue");
			ObscuredUShort.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, "fakeValueActive");
			ObscuredUShort.NativeMethodInfoPtr__ctor_Private_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667809);
			ObscuredUShort.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667810);
			ObscuredUShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667811);
			ObscuredUShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667812);
			ObscuredUShort.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667813);
			ObscuredUShort.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667814);
			ObscuredUShort.NativeMethodInfoPtr_GetEncrypted_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667815);
			ObscuredUShort.NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667816);
			ObscuredUShort.NativeMethodInfoPtr_GetDecrypted_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667817);
			ObscuredUShort.NativeMethodInfoPtr_InternalDecrypt_Private_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667818);
			ObscuredUShort.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredUShort_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667819);
			ObscuredUShort.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ObscuredUShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667820);
			ObscuredUShort.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredUShort_ObscuredUShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667821);
			ObscuredUShort.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredUShort_ObscuredUShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667822);
			ObscuredUShort.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667823);
			ObscuredUShort.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667824);
			ObscuredUShort.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667825);
			ObscuredUShort.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667826);
			ObscuredUShort.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667827);
			ObscuredUShort.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667828);
			ObscuredUShort.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredUShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667829);
			ObscuredUShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredUShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667830);
			ObscuredUShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667831);
			ObscuredUShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, 100667832);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0007EA2C File Offset: 0x0007CC2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26690, RefRangeEnd = 26691, XrefRangeStart = 26683, XrefRangeEnd = 26690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredUShort(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr__ctor_Private_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0007EA60 File Offset: 0x0007CC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26691, XrefRangeEnd = 26695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(ushort newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0007EA94 File Offset: 0x0007CC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26703, RefRangeEnd = 26704, XrefRangeStart = 26695, XrefRangeEnd = 26703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort EncryptDecrypt(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0007EAD4 File Offset: 0x0007CCD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 26705, RefRangeEnd = 26711, XrefRangeStart = 26704, XrefRangeEnd = 26705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort EncryptDecrypt(ushort value, ushort key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_UInt16_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0007EB20 File Offset: 0x0007CD20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26724, RefRangeEnd = 26725, XrefRangeStart = 26711, XrefRangeEnd = 26724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0007EB48 File Offset: 0x0007CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26725, XrefRangeEnd = 26732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0007EB70 File Offset: 0x0007CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26732, XrefRangeEnd = 26733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_GetEncrypted_Public_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0007EBA0 File Offset: 0x0007CDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26733, XrefRangeEnd = 26739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(ushort encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0007EBD4 File Offset: 0x0007CDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26739, XrefRangeEnd = 26740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_GetDecrypted_Public_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0007EC04 File Offset: 0x0007CE04
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 26746, RefRangeEnd = 26762, XrefRangeStart = 26740, XrefRangeEnd = 26746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_InternalDecrypt_Private_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0007EC34 File Offset: 0x0007CE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26762, XrefRangeEnd = 26763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredUShort(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredUShort_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0007EC74 File Offset: 0x0007CE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26763, XrefRangeEnd = 26764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ushort(ObscuredUShort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ObscuredUShort_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0007ECB4 File Offset: 0x0007CEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26764, XrefRangeEnd = 26771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredUShort operator ++(ObscuredUShort input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredUShort_ObscuredUShort_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0007ECF4 File Offset: 0x0007CEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26771, XrefRangeEnd = 26778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredUShort operator --(ObscuredUShort input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredUShort_ObscuredUShort_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0007ED34 File Offset: 0x0007CF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26778, XrefRangeEnd = 26779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0007ED64 File Offset: 0x0007CF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26779, XrefRangeEnd = 26782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0007ED90 File Offset: 0x0007CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26782, XrefRangeEnd = 26785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0007EDCC File Offset: 0x0007CFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26785, XrefRangeEnd = 26788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0007EE08 File Offset: 0x0007D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26788, XrefRangeEnd = 26791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0007EE58 File Offset: 0x0007D058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26791, XrefRangeEnd = 26794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0007EE9C File Offset: 0x0007D09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26800, RefRangeEnd = 26801, XrefRangeStart = 26794, XrefRangeEnd = 26800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredUShort obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredUShort_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0007EEDC File Offset: 0x0007D0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26801, XrefRangeEnd = 26803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredUShort other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredUShort_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0007EF1C File Offset: 0x0007D11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26803, XrefRangeEnd = 26804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ushort other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0007EF5C File Offset: 0x0007D15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26804, XrefRangeEnd = 26807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0000A312 File Offset: 0x00008512
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredUShort>.NativeClassPtr, ref this));
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x0007EFA0 File Offset: 0x0007D1A0
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x0000A324 File Offset: 0x00008524
		public unsafe static ushort cryptoKey
		{
			get
			{
				ushort num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredUShort.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredUShort.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_UInt16_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt16_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_UInt16_UInt16_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_UInt16_UInt16_UInt16_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_UInt16_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt16_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_UInt16_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_UInt16_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredUShort_UInt16_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ObscuredUShort_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredUShort_ObscuredUShort_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredUShort_ObscuredUShort_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredUShort_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredUShort_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt16_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001D1E RID: 7454
		[FieldOffset(0)]
		public ushort currentCryptoKey;

		// Token: 0x04001D1F RID: 7455
		[FieldOffset(2)]
		public ushort hiddenValue;

		// Token: 0x04001D20 RID: 7456
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001D21 RID: 7457
		[FieldOffset(6)]
		public ushort fakeValue;

		// Token: 0x04001D22 RID: 7458
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
