using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001F7 RID: 503
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredByte
	{
		// Token: 0x060019BF RID: 6591 RVA: 0x00074888 File Offset: 0x00072A88
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredByte()
		{
			Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredByte");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr);
			ObscuredByte.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, "cryptoKey");
			ObscuredByte.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, "currentCryptoKey");
			ObscuredByte.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, "hiddenValue");
			ObscuredByte.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, "inited");
			ObscuredByte.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, "fakeValue");
			ObscuredByte.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, "fakeValueActive");
			ObscuredByte.NativeMethodInfoPtr__ctor_Private_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667350);
			ObscuredByte.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667351);
			ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667352);
			ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667353);
			ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667354);
			ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Void_Il2CppStructArray_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667355);
			ObscuredByte.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667356);
			ObscuredByte.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667357);
			ObscuredByte.NativeMethodInfoPtr_GetEncrypted_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667358);
			ObscuredByte.NativeMethodInfoPtr_SetEncrypted_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667359);
			ObscuredByte.NativeMethodInfoPtr_GetDecrypted_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667360);
			ObscuredByte.NativeMethodInfoPtr_InternalDecrypt_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667361);
			ObscuredByte.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredByte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667362);
			ObscuredByte.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_ObscuredByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667363);
			ObscuredByte.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredByte_ObscuredByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667364);
			ObscuredByte.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredByte_ObscuredByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667365);
			ObscuredByte.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667366);
			ObscuredByte.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667367);
			ObscuredByte.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667368);
			ObscuredByte.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667369);
			ObscuredByte.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667370);
			ObscuredByte.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667371);
			ObscuredByte.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667372);
			ObscuredByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667373);
			ObscuredByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667374);
			ObscuredByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, 100667375);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00074B38 File Offset: 0x00072D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22870, RefRangeEnd = 22871, XrefRangeStart = 22863, XrefRangeEnd = 22870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredByte(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr__ctor_Private_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00074B6C File Offset: 0x00072D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22871, XrefRangeEnd = 22875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(byte newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00074BA0 File Offset: 0x00072DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22883, RefRangeEnd = 22884, XrefRangeStart = 22875, XrefRangeEnd = 22883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte EncryptDecrypt(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00074BE0 File Offset: 0x00072DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22884, XrefRangeEnd = 22894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EncryptDecrypt(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Void_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00074C18 File Offset: 0x00072E18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 22895, RefRangeEnd = 22901, XrefRangeStart = 22894, XrefRangeEnd = 22895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte EncryptDecrypt(byte value, byte key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Byte_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00074C64 File Offset: 0x00072E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22901, XrefRangeEnd = 22906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EncryptDecrypt(Il2CppStructArray<byte> value, byte key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Void_Il2CppStructArray_1_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00074CA8 File Offset: 0x00072EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22919, RefRangeEnd = 22920, XrefRangeStart = 22906, XrefRangeEnd = 22919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00074CD0 File Offset: 0x00072ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22920, XrefRangeEnd = 22927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00074CF8 File Offset: 0x00072EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22927, XrefRangeEnd = 22928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_GetEncrypted_Public_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00074D28 File Offset: 0x00072F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22928, XrefRangeEnd = 22934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(byte encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_SetEncrypted_Public_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00074D5C File Offset: 0x00072F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22934, XrefRangeEnd = 22935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_GetDecrypted_Public_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00074D8C File Offset: 0x00072F8C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 22941, RefRangeEnd = 22957, XrefRangeStart = 22935, XrefRangeEnd = 22941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_InternalDecrypt_Private_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00074DBC File Offset: 0x00072FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22957, XrefRangeEnd = 22958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredByte(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredByte_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00074DFC File Offset: 0x00072FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22958, XrefRangeEnd = 22959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator byte(ObscuredByte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_ObscuredByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00074E3C File Offset: 0x0007303C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22959, XrefRangeEnd = 22966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredByte operator ++(ObscuredByte input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredByte_ObscuredByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00074E7C File Offset: 0x0007307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22966, XrefRangeEnd = 22973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredByte operator --(ObscuredByte input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredByte_ObscuredByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00074EBC File Offset: 0x000730BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22973, XrefRangeEnd = 22974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00074EEC File Offset: 0x000730EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22974, XrefRangeEnd = 22977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00074F18 File Offset: 0x00073118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22977, XrefRangeEnd = 22980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00074F54 File Offset: 0x00073154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22980, XrefRangeEnd = 22983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00074F90 File Offset: 0x00073190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22983, XrefRangeEnd = 22986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00074FE0 File Offset: 0x000731E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22986, XrefRangeEnd = 22989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00075024 File Offset: 0x00073224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22994, RefRangeEnd = 22995, XrefRangeStart = 22989, XrefRangeEnd = 22994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredByte obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00075064 File Offset: 0x00073264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22995, XrefRangeEnd = 22997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredByte other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredByte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000750A4 File Offset: 0x000732A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22997, XrefRangeEnd = 22998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(byte other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000750E4 File Offset: 0x000732E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22998, XrefRangeEnd = 23001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredByte.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00009FD6 File Offset: 0x000081D6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredByte>.NativeClassPtr, ref this));
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x00075128 File Offset: 0x00073328
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x00009FE8 File Offset: 0x000081E8
		public unsafe static byte cryptoKey
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(ObscuredByte.NativeFieldInfoPtr_cryptoKey, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredByte.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Byte_0;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Byte_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Byte_Byte_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Byte_Byte_Byte_0;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Void_Il2CppStructArray_1_Byte_Byte_0;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Byte_0;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Byte_0;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Byte_0;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Byte_0;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredByte_Byte_0;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_ObscuredByte_0;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredByte_ObscuredByte_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredByte_ObscuredByte_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredByte_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredByte_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Byte_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001AC5 RID: 6853
		[FieldOffset(0)]
		public byte currentCryptoKey;

		// Token: 0x04001AC6 RID: 6854
		[FieldOffset(1)]
		public byte hiddenValue;

		// Token: 0x04001AC7 RID: 6855
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001AC8 RID: 6856
		[FieldOffset(3)]
		public byte fakeValue;

		// Token: 0x04001AC9 RID: 6857
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
