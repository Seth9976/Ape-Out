using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredLong
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x00077FF8 File Offset: 0x000761F8
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredLong()
		{
			Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredLong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr);
			ObscuredLong.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, "cryptoKey");
			ObscuredLong.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, "currentCryptoKey");
			ObscuredLong.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, "hiddenValue");
			ObscuredLong.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, "inited");
			ObscuredLong.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, "fakeValue");
			ObscuredLong.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, "fakeValueActive");
			ObscuredLong.NativeMethodInfoPtr__ctor_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667519);
			ObscuredLong.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667520);
			ObscuredLong.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667521);
			ObscuredLong.NativeMethodInfoPtr_Decrypt_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667522);
			ObscuredLong.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667523);
			ObscuredLong.NativeMethodInfoPtr_Decrypt_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667524);
			ObscuredLong.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667525);
			ObscuredLong.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667526);
			ObscuredLong.NativeMethodInfoPtr_GetEncrypted_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667527);
			ObscuredLong.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667528);
			ObscuredLong.NativeMethodInfoPtr_GetDecrypted_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667529);
			ObscuredLong.NativeMethodInfoPtr_InternalDecrypt_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667530);
			ObscuredLong.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredLong_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667531);
			ObscuredLong.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ObscuredLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667532);
			ObscuredLong.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredLong_ObscuredLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667533);
			ObscuredLong.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredLong_ObscuredLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667534);
			ObscuredLong.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667535);
			ObscuredLong.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667536);
			ObscuredLong.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667537);
			ObscuredLong.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667538);
			ObscuredLong.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667539);
			ObscuredLong.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667540);
			ObscuredLong.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667541);
			ObscuredLong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667542);
			ObscuredLong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667543);
			ObscuredLong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, 100667544);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000782A8 File Offset: 0x000764A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23889, RefRangeEnd = 23890, XrefRangeStart = 23883, XrefRangeEnd = 23889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredLong(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr__ctor_Private_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000782DC File Offset: 0x000764DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23890, XrefRangeEnd = 23894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(long newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00078310 File Offset: 0x00076510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23902, RefRangeEnd = 23903, XrefRangeStart = 23894, XrefRangeEnd = 23902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Encrypt(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00078350 File Offset: 0x00076550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23903, XrefRangeEnd = 23911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Decrypt(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_Decrypt_Public_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00078390 File Offset: 0x00076590
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23912, RefRangeEnd = 23915, XrefRangeStart = 23911, XrefRangeEnd = 23912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Encrypt(long value, long key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000783DC File Offset: 0x000765DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23916, RefRangeEnd = 23919, XrefRangeStart = 23915, XrefRangeEnd = 23916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Decrypt(long value, long key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_Decrypt_Public_Static_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00078428 File Offset: 0x00076628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23932, RefRangeEnd = 23933, XrefRangeStart = 23919, XrefRangeEnd = 23932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00078450 File Offset: 0x00076650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23933, XrefRangeEnd = 23940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00078478 File Offset: 0x00076678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23940, XrefRangeEnd = 23941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_GetEncrypted_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000784A8 File Offset: 0x000766A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23941, XrefRangeEnd = 23947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(long encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x000784DC File Offset: 0x000766DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23947, XrefRangeEnd = 23948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_GetDecrypted_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0007850C File Offset: 0x0007670C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 23954, RefRangeEnd = 23970, XrefRangeStart = 23948, XrefRangeEnd = 23954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_InternalDecrypt_Private_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0007853C File Offset: 0x0007673C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23970, XrefRangeEnd = 23971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredLong(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredLong_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0007857C File Offset: 0x0007677C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23971, XrefRangeEnd = 23972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator long(ObscuredLong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ObscuredLong_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000785BC File Offset: 0x000767BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23972, XrefRangeEnd = 23979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredLong operator ++(ObscuredLong input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredLong_ObscuredLong_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000785FC File Offset: 0x000767FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23979, XrefRangeEnd = 23986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredLong operator --(ObscuredLong input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredLong_ObscuredLong_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0007863C File Offset: 0x0007683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23986, XrefRangeEnd = 23987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0007866C File Offset: 0x0007686C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23987, XrefRangeEnd = 23990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00078698 File Offset: 0x00076898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23990, XrefRangeEnd = 23993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000786D4 File Offset: 0x000768D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23993, XrefRangeEnd = 23996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00078710 File Offset: 0x00076910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23996, XrefRangeEnd = 23999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00078760 File Offset: 0x00076960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23999, XrefRangeEnd = 24002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000787A4 File Offset: 0x000769A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24008, RefRangeEnd = 24009, XrefRangeStart = 24002, XrefRangeEnd = 24008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredLong obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredLong_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000787E4 File Offset: 0x000769E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24009, XrefRangeEnd = 24011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredLong other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredLong_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00078824 File Offset: 0x00076A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24011, XrefRangeEnd = 24012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(long other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00078864 File Offset: 0x00076A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24012, XrefRangeEnd = 24014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredLong.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000A096 File Offset: 0x00008296
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredLong>.NativeClassPtr, ref this));
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x000788A8 File Offset: 0x00076AA8
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x0000A0A8 File Offset: 0x000082A8
		public unsafe static long cryptoKey
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredLong.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredLong.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int64_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int64_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Int64_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Int64_Int64_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Int64_Int64_Int64_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Int64_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Int64_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Int64_0;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Int64_0;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredLong_Int64_0;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ObscuredLong_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredLong_ObscuredLong_0;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredLong_ObscuredLong_0;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredLong_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredLong_0;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int64_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001BAE RID: 7086
		[FieldOffset(0)]
		public long currentCryptoKey;

		// Token: 0x04001BAF RID: 7087
		[FieldOffset(8)]
		public long hiddenValue;

		// Token: 0x04001BB0 RID: 7088
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001BB1 RID: 7089
		[FieldOffset(24)]
		public long fakeValue;

		// Token: 0x04001BB2 RID: 7090
		[FieldOffset(32)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
