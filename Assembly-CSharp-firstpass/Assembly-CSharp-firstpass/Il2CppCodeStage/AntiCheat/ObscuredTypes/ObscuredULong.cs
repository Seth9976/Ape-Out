using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000205 RID: 517
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredULong
	{
		// Token: 0x06001BC0 RID: 7104 RVA: 0x0007DED8 File Offset: 0x0007C0D8
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredULong()
		{
			Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredULong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr);
			ObscuredULong.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, "cryptoKey");
			ObscuredULong.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, "currentCryptoKey");
			ObscuredULong.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, "hiddenValue");
			ObscuredULong.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, "inited");
			ObscuredULong.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, "fakeValue");
			ObscuredULong.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, "fakeValueActive");
			ObscuredULong.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667782);
			ObscuredULong.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667783);
			ObscuredULong.NativeMethodInfoPtr_Encrypt_Public_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667784);
			ObscuredULong.NativeMethodInfoPtr_Decrypt_Public_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667785);
			ObscuredULong.NativeMethodInfoPtr_Encrypt_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667786);
			ObscuredULong.NativeMethodInfoPtr_Decrypt_Public_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667787);
			ObscuredULong.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667788);
			ObscuredULong.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667789);
			ObscuredULong.NativeMethodInfoPtr_GetEncrypted_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667790);
			ObscuredULong.NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667791);
			ObscuredULong.NativeMethodInfoPtr_GetDecrypted_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667792);
			ObscuredULong.NativeMethodInfoPtr_InternalDecrypt_Private_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667793);
			ObscuredULong.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredULong_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667794);
			ObscuredULong.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ObscuredULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667795);
			ObscuredULong.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredULong_ObscuredULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667796);
			ObscuredULong.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredULong_ObscuredULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667797);
			ObscuredULong.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667798);
			ObscuredULong.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667799);
			ObscuredULong.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667800);
			ObscuredULong.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667801);
			ObscuredULong.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667802);
			ObscuredULong.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667803);
			ObscuredULong.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667804);
			ObscuredULong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredULong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667805);
			ObscuredULong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667806);
			ObscuredULong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, 100667807);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0007E188 File Offset: 0x0007C388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26558, RefRangeEnd = 26559, XrefRangeStart = 26552, XrefRangeEnd = 26558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredULong(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0007E1BC File Offset: 0x0007C3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26559, XrefRangeEnd = 26563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(ulong newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0007E1F0 File Offset: 0x0007C3F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26571, RefRangeEnd = 26572, XrefRangeStart = 26563, XrefRangeEnd = 26571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Encrypt(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_Encrypt_Public_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0007E230 File Offset: 0x0007C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26572, XrefRangeEnd = 26580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Decrypt(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_Decrypt_Public_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0007E270 File Offset: 0x0007C470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26581, RefRangeEnd = 26584, XrefRangeStart = 26580, XrefRangeEnd = 26581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Encrypt(ulong value, ulong key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_Encrypt_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0007E2BC File Offset: 0x0007C4BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26585, RefRangeEnd = 26588, XrefRangeStart = 26584, XrefRangeEnd = 26585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Decrypt(ulong value, ulong key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_Decrypt_Public_Static_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0007E308 File Offset: 0x0007C508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26601, RefRangeEnd = 26602, XrefRangeStart = 26588, XrefRangeEnd = 26601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0007E330 File Offset: 0x0007C530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26602, XrefRangeEnd = 26609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0007E358 File Offset: 0x0007C558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26609, XrefRangeEnd = 26610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_GetEncrypted_Public_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0007E388 File Offset: 0x0007C588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26610, XrefRangeEnd = 26616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(ulong encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0007E3BC File Offset: 0x0007C5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26616, XrefRangeEnd = 26617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_GetDecrypted_Public_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0007E3EC File Offset: 0x0007C5EC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 26623, RefRangeEnd = 26639, XrefRangeStart = 26617, XrefRangeEnd = 26623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_InternalDecrypt_Private_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0007E41C File Offset: 0x0007C61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26639, XrefRangeEnd = 26640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredULong(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredULong_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0007E45C File Offset: 0x0007C65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26640, XrefRangeEnd = 26641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(ObscuredULong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ObscuredULong_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0007E49C File Offset: 0x0007C69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26641, XrefRangeEnd = 26648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredULong operator ++(ObscuredULong input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredULong_ObscuredULong_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0007E4DC File Offset: 0x0007C6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26648, XrefRangeEnd = 26655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredULong operator --(ObscuredULong input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredULong_ObscuredULong_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0007E51C File Offset: 0x0007C71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26655, XrefRangeEnd = 26656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0007E54C File Offset: 0x0007C74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26656, XrefRangeEnd = 26659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0007E578 File Offset: 0x0007C778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26659, XrefRangeEnd = 26662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0007E5B4 File Offset: 0x0007C7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26662, XrefRangeEnd = 26665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0007E5F0 File Offset: 0x0007C7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26665, XrefRangeEnd = 26668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0007E640 File Offset: 0x0007C840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26668, XrefRangeEnd = 26671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0007E684 File Offset: 0x0007C884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26677, RefRangeEnd = 26678, XrefRangeStart = 26671, XrefRangeEnd = 26677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredULong obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredULong_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0007E6C4 File Offset: 0x0007C8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26678, XrefRangeEnd = 26680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredULong other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredULong_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0007E704 File Offset: 0x0007C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26680, XrefRangeEnd = 26681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ulong other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0007E744 File Offset: 0x0007C944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26681, XrefRangeEnd = 26683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredULong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0000A2F2 File Offset: 0x000084F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredULong>.NativeClassPtr, ref this));
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x0007E788 File Offset: 0x0007C988
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x0000A304 File Offset: 0x00008504
		public unsafe static ulong cryptoKey
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredULong.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredULong.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_UInt64_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt64_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_UInt64_UInt64_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_UInt64_UInt64_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_UInt64_UInt64_UInt64_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_UInt64_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt64_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_UInt64_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_UInt64_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredULong_UInt64_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ObscuredULong_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredULong_ObscuredULong_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredULong_ObscuredULong_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredULong_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredULong_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt64_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001CFB RID: 7419
		[FieldOffset(0)]
		public ulong currentCryptoKey;

		// Token: 0x04001CFC RID: 7420
		[FieldOffset(8)]
		public ulong hiddenValue;

		// Token: 0x04001CFD RID: 7421
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001CFE RID: 7422
		[FieldOffset(24)]
		public ulong fakeValue;

		// Token: 0x04001CFF RID: 7423
		[FieldOffset(32)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
