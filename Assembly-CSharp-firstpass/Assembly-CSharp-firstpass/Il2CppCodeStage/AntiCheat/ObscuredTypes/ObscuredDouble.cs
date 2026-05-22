using System;
using System.Runtime.InteropServices;
using Il2CppCodeStage.AntiCheat.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001FA RID: 506
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredDouble
	{
		// Token: 0x06001A18 RID: 6680 RVA: 0x0007627C File Offset: 0x0007447C
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredDouble()
		{
			Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredDouble");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr);
			ObscuredDouble.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "cryptoKey");
			ObscuredDouble.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "currentCryptoKey");
			ObscuredDouble.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "hiddenValue");
			ObscuredDouble.NativeFieldInfoPtr_hiddenValueOldByte8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "hiddenValueOldByte8");
			ObscuredDouble.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "inited");
			ObscuredDouble.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "fakeValue");
			ObscuredDouble.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "fakeValueActive");
			ObscuredDouble.NativeMethodInfoPtr__ctor_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667430);
			ObscuredDouble.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667431);
			ObscuredDouble.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667432);
			ObscuredDouble.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667433);
			ObscuredDouble.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Int64_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667434);
			ObscuredDouble.NativeMethodInfoPtr_Decrypt_Public_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667435);
			ObscuredDouble.NativeMethodInfoPtr_Decrypt_Public_Static_Double_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667436);
			ObscuredDouble.NativeMethodInfoPtr_MigrateEncrypted_Public_Static_Int64_Int64_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667437);
			ObscuredDouble.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667438);
			ObscuredDouble.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667439);
			ObscuredDouble.NativeMethodInfoPtr_GetEncrypted_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667440);
			ObscuredDouble.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667441);
			ObscuredDouble.NativeMethodInfoPtr_GetDecrypted_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667442);
			ObscuredDouble.NativeMethodInfoPtr_InternalDecrypt_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667443);
			ObscuredDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredDouble_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667444);
			ObscuredDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_ObscuredDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667445);
			ObscuredDouble.NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredDouble_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667446);
			ObscuredDouble.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredDouble_ObscuredDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667447);
			ObscuredDouble.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredDouble_ObscuredDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667448);
			ObscuredDouble.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667449);
			ObscuredDouble.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667450);
			ObscuredDouble.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667451);
			ObscuredDouble.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667452);
			ObscuredDouble.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667453);
			ObscuredDouble.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667454);
			ObscuredDouble.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667455);
			ObscuredDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667456);
			ObscuredDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667457);
			ObscuredDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, 100667458);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0007657C File Offset: 0x0007477C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23319, RefRangeEnd = 23322, XrefRangeStart = 23309, XrefRangeEnd = 23319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredDouble(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr__ctor_Private_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000765B0 File Offset: 0x000747B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23322, XrefRangeEnd = 23326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(long newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x000765E4 File Offset: 0x000747E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23326, XrefRangeEnd = 23330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Encrypt(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00076624 File Offset: 0x00074824
		[CallerCount(0)]
		public unsafe static long Encrypt(double value, long key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00076670 File Offset: 0x00074870
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23335, RefRangeEnd = 23339, XrefRangeStart = 23330, XrefRangeEnd = 23335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long InternalEncrypt(double value, long key = 0L)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Int64_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000766BC File Offset: 0x000748BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23339, XrefRangeEnd = 23343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Decrypt(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_Decrypt_Public_Static_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000766FC File Offset: 0x000748FC
		[CallerCount(0)]
		public unsafe static double Decrypt(long value, long key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_Decrypt_Public_Static_Double_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00076748 File Offset: 0x00074948
		[CallerCount(0)]
		public unsafe static long MigrateEncrypted(long encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromVersion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_MigrateEncrypted_Public_Static_Int64_Int64_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000767A4 File Offset: 0x000749A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23353, RefRangeEnd = 23354, XrefRangeStart = 23343, XrefRangeEnd = 23353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000767CC File Offset: 0x000749CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23354, XrefRangeEnd = 23361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000767F4 File Offset: 0x000749F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23361, XrefRangeEnd = 23362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_GetEncrypted_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00076824 File Offset: 0x00074A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23362, XrefRangeEnd = 23368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(long encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00076858 File Offset: 0x00074A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23368, XrefRangeEnd = 23369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_GetDecrypted_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00076888 File Offset: 0x00074A88
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 23378, RefRangeEnd = 23398, XrefRangeStart = 23369, XrefRangeEnd = 23378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_InternalDecrypt_Private_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000768B8 File Offset: 0x00074AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23398, XrefRangeEnd = 23399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredDouble(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredDouble_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000768F8 File Offset: 0x00074AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23399, XrefRangeEnd = 23400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double(ObscuredDouble value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_ObscuredDouble_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00076938 File Offset: 0x00074B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23400, XrefRangeEnd = 23408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ObscuredDouble(ObscuredFloat f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredDouble_ObscuredFloat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00076978 File Offset: 0x00074B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23408, XrefRangeEnd = 23415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredDouble operator ++(ObscuredDouble input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredDouble_ObscuredDouble_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000769B8 File Offset: 0x00074BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23415, XrefRangeEnd = 23422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredDouble operator --(ObscuredDouble input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredDouble_ObscuredDouble_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x000769F8 File Offset: 0x00074BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23422, XrefRangeEnd = 23423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00076A28 File Offset: 0x00074C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23423, XrefRangeEnd = 23429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00076A54 File Offset: 0x00074C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23429, XrefRangeEnd = 23432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00076A90 File Offset: 0x00074C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23432, XrefRangeEnd = 23438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00076ACC File Offset: 0x00074CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23438, XrefRangeEnd = 23441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00076B1C File Offset: 0x00074D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23441, XrefRangeEnd = 23446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00076B60 File Offset: 0x00074D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23446, XrefRangeEnd = 23449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredDouble obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredDouble_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00076BA0 File Offset: 0x00074DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23449, XrefRangeEnd = 23452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredDouble other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredDouble_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00076BE0 File Offset: 0x00074DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23452, XrefRangeEnd = 23454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(double other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00076C20 File Offset: 0x00074E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23454, XrefRangeEnd = 23456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDouble.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0000A036 File Offset: 0x00008236
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, ref this));
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00076C64 File Offset: 0x00074E64
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0000A048 File Offset: 0x00008248
		public unsafe static long cryptoKey
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredDouble.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredDouble.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValueOldByte8;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Double_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Double_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Double_Int64_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncrypt_Private_Static_Int64_Double_Int64_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Double_Int64_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Double_Int64_Int64_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_MigrateEncrypted_Public_Static_Int64_Int64_Byte_Byte_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Int64_0;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Int64_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Double_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Double_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredDouble_Double_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Double_ObscuredDouble_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredDouble_ObscuredFloat_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredDouble_ObscuredDouble_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredDouble_ObscuredDouble_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredDouble_0;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredDouble_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Double_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001B37 RID: 6967
		[FieldOffset(0)]
		public long currentCryptoKey;

		// Token: 0x04001B38 RID: 6968
		[FieldOffset(8)]
		public long hiddenValue;

		// Token: 0x04001B39 RID: 6969
		[FieldOffset(16)]
		public ACTkByte8 hiddenValueOldByte8;

		// Token: 0x04001B3A RID: 6970
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001B3B RID: 6971
		[FieldOffset(32)]
		public double fakeValue;

		// Token: 0x04001B3C RID: 6972
		[FieldOffset(40)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002B9 RID: 697
		[StructLayout(2)]
		public struct DoubleLongBytesUnion
		{
			// Token: 0x0600243C RID: 9276 RVA: 0x0009A914 File Offset: 0x00098B14
			// Note: this type is marked as 'beforefieldinit'.
			static DoubleLongBytesUnion()
			{
				Il2CppClassPointerStore<ObscuredDouble.DoubleLongBytesUnion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredDouble>.NativeClassPtr, "DoubleLongBytesUnion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredDouble.DoubleLongBytesUnion>.NativeClassPtr);
				ObscuredDouble.DoubleLongBytesUnion.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble.DoubleLongBytesUnion>.NativeClassPtr, "d");
				ObscuredDouble.DoubleLongBytesUnion.NativeFieldInfoPtr_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble.DoubleLongBytesUnion>.NativeClassPtr, "l");
				ObscuredDouble.DoubleLongBytesUnion.NativeFieldInfoPtr_b8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDouble.DoubleLongBytesUnion>.NativeClassPtr, "b8");
			}

			// Token: 0x0600243D RID: 9277 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredDouble.DoubleLongBytesUnion>.NativeClassPtr, ref this));
			}

			// Token: 0x04002290 RID: 8848
			private static readonly IntPtr NativeFieldInfoPtr_d;

			// Token: 0x04002291 RID: 8849
			private static readonly IntPtr NativeFieldInfoPtr_l;

			// Token: 0x04002292 RID: 8850
			private static readonly IntPtr NativeFieldInfoPtr_b8;

			// Token: 0x04002293 RID: 8851
			[FieldOffset(0)]
			public double d;

			// Token: 0x04002294 RID: 8852
			[FieldOffset(0)]
			public long l;

			// Token: 0x04002295 RID: 8853
			[FieldOffset(0)]
			public ACTkByte8 b8;
		}
	}
}
