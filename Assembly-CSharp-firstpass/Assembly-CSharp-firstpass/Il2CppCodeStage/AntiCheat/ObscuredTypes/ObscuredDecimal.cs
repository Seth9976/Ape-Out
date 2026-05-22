using System;
using System.Runtime.InteropServices;
using Il2CppCodeStage.AntiCheat.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001F9 RID: 505
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredDecimal
	{
		// Token: 0x060019F7 RID: 6647 RVA: 0x000758A8 File Offset: 0x00073AA8
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredDecimal()
		{
			Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredDecimal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr);
			ObscuredDecimal.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, "cryptoKey");
			ObscuredDecimal.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, "currentCryptoKey");
			ObscuredDecimal.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, "hiddenValue");
			ObscuredDecimal.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, "inited");
			ObscuredDecimal.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, "fakeValue");
			ObscuredDecimal.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, "fakeValueActive");
			ObscuredDecimal.NativeMethodInfoPtr__ctor_Private_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667400);
			ObscuredDecimal.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667401);
			ObscuredDecimal.NativeMethodInfoPtr_Encrypt_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667402);
			ObscuredDecimal.NativeMethodInfoPtr_Encrypt_Public_Static_Decimal_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667403);
			ObscuredDecimal.NativeMethodInfoPtr_InternalEncrypt_Private_Static_ACTkByte16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667404);
			ObscuredDecimal.NativeMethodInfoPtr_InternalEncrypt_Private_Static_ACTkByte16_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667405);
			ObscuredDecimal.NativeMethodInfoPtr_Decrypt_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667406);
			ObscuredDecimal.NativeMethodInfoPtr_Decrypt_Public_Static_Decimal_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667407);
			ObscuredDecimal.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667408);
			ObscuredDecimal.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667409);
			ObscuredDecimal.NativeMethodInfoPtr_GetEncrypted_Public_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667410);
			ObscuredDecimal.NativeMethodInfoPtr_SetEncrypted_Public_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667411);
			ObscuredDecimal.NativeMethodInfoPtr_GetDecrypted_Public_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667412);
			ObscuredDecimal.NativeMethodInfoPtr_InternalDecrypt_Private_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667413);
			ObscuredDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredDecimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667414);
			ObscuredDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_ObscuredDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667415);
			ObscuredDecimal.NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredDecimal_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667416);
			ObscuredDecimal.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredDecimal_ObscuredDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667417);
			ObscuredDecimal.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredDecimal_ObscuredDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667418);
			ObscuredDecimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667419);
			ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667420);
			ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667421);
			ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667422);
			ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667423);
			ObscuredDecimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667424);
			ObscuredDecimal.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667425);
			ObscuredDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667426);
			ObscuredDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667427);
			ObscuredDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, 100667428);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00075B94 File Offset: 0x00073D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23139, RefRangeEnd = 23141, XrefRangeStart = 23121, XrefRangeEnd = 23139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredDecimal(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr__ctor_Private_Void_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00075BC8 File Offset: 0x00073DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23141, XrefRangeEnd = 23145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(long newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00075BFC File Offset: 0x00073DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23145, XrefRangeEnd = 23149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Encrypt(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_Encrypt_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00075C3C File Offset: 0x00073E3C
		[CallerCount(0)]
		public unsafe static Decimal Encrypt(Decimal value, long key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_Encrypt_Public_Static_Decimal_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00075C88 File Offset: 0x00073E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23149, XrefRangeEnd = 23157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ACTkByte16 InternalEncrypt(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_InternalEncrypt_Private_Static_ACTkByte16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00075CC8 File Offset: 0x00073EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23157, XrefRangeEnd = 23161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ACTkByte16 InternalEncrypt(Decimal value, long key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_InternalEncrypt_Private_Static_ACTkByte16_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00075D14 File Offset: 0x00073F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23161, XrefRangeEnd = 23165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Decrypt(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_Decrypt_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00075D54 File Offset: 0x00073F54
		[CallerCount(0)]
		public unsafe static Decimal Decrypt(Decimal value, long key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_Decrypt_Public_Static_Decimal_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00075DA0 File Offset: 0x00073FA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23178, RefRangeEnd = 23179, XrefRangeStart = 23165, XrefRangeEnd = 23178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00075DC8 File Offset: 0x00073FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23179, XrefRangeEnd = 23186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00075DF0 File Offset: 0x00073FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23186, XrefRangeEnd = 23187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_GetEncrypted_Public_Decimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00075E20 File Offset: 0x00074020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23187, XrefRangeEnd = 23193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(Decimal encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_SetEncrypted_Public_Void_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00075E54 File Offset: 0x00074054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23193, XrefRangeEnd = 23194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_GetDecrypted_Public_Decimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00075E84 File Offset: 0x00074084
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 23205, RefRangeEnd = 23223, XrefRangeStart = 23194, XrefRangeEnd = 23205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_InternalDecrypt_Private_Decimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00075EB4 File Offset: 0x000740B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23223, XrefRangeEnd = 23224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredDecimal(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredDecimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00075EF4 File Offset: 0x000740F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(ObscuredDecimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_ObscuredDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00075F34 File Offset: 0x00074134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23224, XrefRangeEnd = 23236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredDecimal_ObscuredFloat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00075F74 File Offset: 0x00074174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23236, XrefRangeEnd = 23255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredDecimal_ObscuredDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00075FB4 File Offset: 0x000741B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23255, XrefRangeEnd = 23274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredDecimal_ObscuredDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00075FF4 File Offset: 0x000741F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23274, XrefRangeEnd = 23276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00076024 File Offset: 0x00074224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23276, XrefRangeEnd = 23279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00076050 File Offset: 0x00074250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23279, XrefRangeEnd = 23282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0007608C File Offset: 0x0007428C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23282, XrefRangeEnd = 23285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000760C8 File Offset: 0x000742C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23285, XrefRangeEnd = 23288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00076118 File Offset: 0x00074318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23288, XrefRangeEnd = 23291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0007615C File Offset: 0x0007435C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23297, RefRangeEnd = 23298, XrefRangeStart = 23291, XrefRangeEnd = 23297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredDecimal obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredDecimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0007619C File Offset: 0x0007439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23298, XrefRangeEnd = 23303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredDecimal other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredDecimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000761DC File Offset: 0x000743DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23303, XrefRangeEnd = 23307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Decimal other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0007621C File Offset: 0x0007441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23307, XrefRangeEnd = 23309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0000A016 File Offset: 0x00008216
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, ref this));
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00076260 File Offset: 0x00074460
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0000A028 File Offset: 0x00008228
		public unsafe static long cryptoKey
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredDecimal.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredDecimal.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Decimal_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Decimal_Decimal_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Decimal_Decimal_Int64_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncrypt_Private_Static_ACTkByte16_Decimal_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncrypt_Private_Static_ACTkByte16_Decimal_Int64_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Decimal_Decimal_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Decimal_Decimal_Int64_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Decimal_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Decimal_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Decimal_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Decimal_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredDecimal_Decimal_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_ObscuredDecimal_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredDecimal_ObscuredFloat_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredDecimal_ObscuredDecimal_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredDecimal_ObscuredDecimal_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredDecimal_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredDecimal_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001B0E RID: 6926
		[FieldOffset(0)]
		public long currentCryptoKey;

		// Token: 0x04001B0F RID: 6927
		[FieldOffset(8)]
		public ACTkByte16 hiddenValue;

		// Token: 0x04001B10 RID: 6928
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001B11 RID: 6929
		[FieldOffset(28)]
		public Decimal fakeValue;

		// Token: 0x04001B12 RID: 6930
		[FieldOffset(44)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002B8 RID: 696
		[StructLayout(2)]
		public struct DecimalLongBytesUnion
		{
			// Token: 0x0600243A RID: 9274 RVA: 0x0009A898 File Offset: 0x00098A98
			// Note: this type is marked as 'beforefieldinit'.
			static DecimalLongBytesUnion()
			{
				Il2CppClassPointerStore<ObscuredDecimal.DecimalLongBytesUnion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredDecimal>.NativeClassPtr, "DecimalLongBytesUnion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredDecimal.DecimalLongBytesUnion>.NativeClassPtr);
				ObscuredDecimal.DecimalLongBytesUnion.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal.DecimalLongBytesUnion>.NativeClassPtr, "d");
				ObscuredDecimal.DecimalLongBytesUnion.NativeFieldInfoPtr_l1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal.DecimalLongBytesUnion>.NativeClassPtr, "l1");
				ObscuredDecimal.DecimalLongBytesUnion.NativeFieldInfoPtr_l2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal.DecimalLongBytesUnion>.NativeClassPtr, "l2");
				ObscuredDecimal.DecimalLongBytesUnion.NativeFieldInfoPtr_b16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredDecimal.DecimalLongBytesUnion>.NativeClassPtr, "b16");
			}

			// Token: 0x0600243B RID: 9275 RVA: 0x0000D996 File Offset: 0x0000BB96
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredDecimal.DecimalLongBytesUnion>.NativeClassPtr, ref this));
			}

			// Token: 0x04002288 RID: 8840
			private static readonly IntPtr NativeFieldInfoPtr_d;

			// Token: 0x04002289 RID: 8841
			private static readonly IntPtr NativeFieldInfoPtr_l1;

			// Token: 0x0400228A RID: 8842
			private static readonly IntPtr NativeFieldInfoPtr_l2;

			// Token: 0x0400228B RID: 8843
			private static readonly IntPtr NativeFieldInfoPtr_b16;

			// Token: 0x0400228C RID: 8844
			[FieldOffset(0)]
			public Decimal d;

			// Token: 0x0400228D RID: 8845
			[FieldOffset(0)]
			public long l1;

			// Token: 0x0400228E RID: 8846
			[FieldOffset(8)]
			public long l2;

			// Token: 0x0400228F RID: 8847
			[FieldOffset(0)]
			public ACTkByte16 b16;
		}
	}
}
