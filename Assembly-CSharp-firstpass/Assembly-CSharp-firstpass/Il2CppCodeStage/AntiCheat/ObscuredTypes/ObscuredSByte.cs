using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000201 RID: 513
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredSByte
	{
		// Token: 0x06001B3E RID: 6974 RVA: 0x0007B9D8 File Offset: 0x00079BD8
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredSByte()
		{
			Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredSByte");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr);
			ObscuredSByte.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, "cryptoKey");
			ObscuredSByte.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, "currentCryptoKey");
			ObscuredSByte.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, "hiddenValue");
			ObscuredSByte.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, "inited");
			ObscuredSByte.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, "fakeValue");
			ObscuredSByte.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, "fakeValueActive");
			ObscuredSByte.NativeMethodInfoPtr__ctor_Private_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667674);
			ObscuredSByte.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667675);
			ObscuredSByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667676);
			ObscuredSByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667677);
			ObscuredSByte.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667678);
			ObscuredSByte.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667679);
			ObscuredSByte.NativeMethodInfoPtr_GetEncrypted_Public_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667680);
			ObscuredSByte.NativeMethodInfoPtr_SetEncrypted_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667681);
			ObscuredSByte.NativeMethodInfoPtr_GetDecrypted_Public_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667682);
			ObscuredSByte.NativeMethodInfoPtr_InternalDecrypt_Private_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667683);
			ObscuredSByte.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredSByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667684);
			ObscuredSByte.NativeMethodInfoPtr_op_Implicit_Public_Static_SByte_ObscuredSByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667685);
			ObscuredSByte.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredSByte_ObscuredSByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667686);
			ObscuredSByte.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredSByte_ObscuredSByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667687);
			ObscuredSByte.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667688);
			ObscuredSByte.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667689);
			ObscuredSByte.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667690);
			ObscuredSByte.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667691);
			ObscuredSByte.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667692);
			ObscuredSByte.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667693);
			ObscuredSByte.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredSByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667694);
			ObscuredSByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredSByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667695);
			ObscuredSByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667696);
			ObscuredSByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, 100667697);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0007BC60 File Offset: 0x00079E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25964, RefRangeEnd = 25965, XrefRangeStart = 25957, XrefRangeEnd = 25964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredSByte(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr__ctor_Private_Void_SByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0007BC94 File Offset: 0x00079E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25965, XrefRangeEnd = 25969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(sbyte newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0007BCC8 File Offset: 0x00079EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25977, RefRangeEnd = 25978, XrefRangeStart = 25969, XrefRangeEnd = 25977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte EncryptDecrypt(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0007BD08 File Offset: 0x00079F08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 25979, RefRangeEnd = 25985, XrefRangeStart = 25978, XrefRangeEnd = 25979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_SByte_SByte_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0007BD54 File Offset: 0x00079F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25998, RefRangeEnd = 25999, XrefRangeStart = 25985, XrefRangeEnd = 25998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0007BD7C File Offset: 0x00079F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25999, XrefRangeEnd = 26006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0007BDA4 File Offset: 0x00079FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26006, XrefRangeEnd = 26007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_GetEncrypted_Public_SByte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0007BDD4 File Offset: 0x00079FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26007, XrefRangeEnd = 26013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(sbyte encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_SetEncrypted_Public_Void_SByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0007BE08 File Offset: 0x0007A008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26013, XrefRangeEnd = 26014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_GetDecrypted_Public_SByte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0007BE38 File Offset: 0x0007A038
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 26020, RefRangeEnd = 26036, XrefRangeStart = 26014, XrefRangeEnd = 26020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_InternalDecrypt_Private_SByte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0007BE68 File Offset: 0x0007A068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26036, XrefRangeEnd = 26037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredSByte(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredSByte_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0007BEA8 File Offset: 0x0007A0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26037, XrefRangeEnd = 26038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator sbyte(ObscuredSByte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_op_Implicit_Public_Static_SByte_ObscuredSByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0007BEE8 File Offset: 0x0007A0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26038, XrefRangeEnd = 26045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredSByte operator ++(ObscuredSByte input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredSByte_ObscuredSByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0007BF28 File Offset: 0x0007A128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26045, XrefRangeEnd = 26052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredSByte operator --(ObscuredSByte input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredSByte_ObscuredSByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0007BF68 File Offset: 0x0007A168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26052, XrefRangeEnd = 26053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0007BF98 File Offset: 0x0007A198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26053, XrefRangeEnd = 26056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0007BFC4 File Offset: 0x0007A1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26056, XrefRangeEnd = 26060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0007C000 File Offset: 0x0007A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26060, XrefRangeEnd = 26063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0007C03C File Offset: 0x0007A23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26063, XrefRangeEnd = 26067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0007C08C File Offset: 0x0007A28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26067, XrefRangeEnd = 26070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0007C0D0 File Offset: 0x0007A2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26075, RefRangeEnd = 26076, XrefRangeStart = 26070, XrefRangeEnd = 26075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredSByte obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredSByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0007C110 File Offset: 0x0007A310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26076, XrefRangeEnd = 26078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredSByte other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredSByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0007C150 File Offset: 0x0007A350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26078, XrefRangeEnd = 26079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(sbyte other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0007C190 File Offset: 0x0007A390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26079, XrefRangeEnd = 26082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredSByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredSByte>.NativeClassPtr, ref this));
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0007C1D4 File Offset: 0x0007A3D4
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0000A1F6 File Offset: 0x000083F6
		public unsafe static sbyte cryptoKey
		{
			get
			{
				sbyte b;
				IL2CPP.il2cpp_field_static_get_value(ObscuredSByte.NativeFieldInfoPtr_cryptoKey, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredSByte.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SByte_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_SByte_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_SByte_SByte_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_SByte_SByte_SByte_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_SByte_0;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_SByte_0;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_SByte_0;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_SByte_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredSByte_SByte_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SByte_ObscuredSByte_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredSByte_ObscuredSByte_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredSByte_ObscuredSByte_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredSByte_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredSByte_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SByte_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001C6A RID: 7274
		[FieldOffset(0)]
		public sbyte currentCryptoKey;

		// Token: 0x04001C6B RID: 7275
		[FieldOffset(1)]
		public sbyte hiddenValue;

		// Token: 0x04001C6C RID: 7276
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001C6D RID: 7277
		[FieldOffset(3)]
		public sbyte fakeValue;

		// Token: 0x04001C6E RID: 7278
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
