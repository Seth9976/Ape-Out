using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000202 RID: 514
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredShort
	{
		// Token: 0x06001B5A RID: 7002 RVA: 0x0007C1F0 File Offset: 0x0007A3F0
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredShort()
		{
			Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredShort");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr);
			ObscuredShort.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, "cryptoKey");
			ObscuredShort.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, "currentCryptoKey");
			ObscuredShort.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, "hiddenValue");
			ObscuredShort.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, "inited");
			ObscuredShort.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, "fakeValue");
			ObscuredShort.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, "fakeValueActive");
			ObscuredShort.NativeMethodInfoPtr__ctor_Private_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667699);
			ObscuredShort.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667700);
			ObscuredShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667701);
			ObscuredShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667702);
			ObscuredShort.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667703);
			ObscuredShort.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667704);
			ObscuredShort.NativeMethodInfoPtr_GetEncrypted_Public_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667705);
			ObscuredShort.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667706);
			ObscuredShort.NativeMethodInfoPtr_GetDecrypted_Public_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667707);
			ObscuredShort.NativeMethodInfoPtr_InternalDecrypt_Private_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667708);
			ObscuredShort.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredShort_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667709);
			ObscuredShort.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_ObscuredShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667710);
			ObscuredShort.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredShort_ObscuredShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667711);
			ObscuredShort.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredShort_ObscuredShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667712);
			ObscuredShort.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667713);
			ObscuredShort.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667714);
			ObscuredShort.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667715);
			ObscuredShort.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667716);
			ObscuredShort.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667717);
			ObscuredShort.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667718);
			ObscuredShort.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667719);
			ObscuredShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredShort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667720);
			ObscuredShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667721);
			ObscuredShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, 100667722);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0007C478 File Offset: 0x0007A678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26089, RefRangeEnd = 26090, XrefRangeStart = 26082, XrefRangeEnd = 26089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredShort(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr__ctor_Private_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0007C4AC File Offset: 0x0007A6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26090, XrefRangeEnd = 26094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(short newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0007C4E0 File Offset: 0x0007A6E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26102, RefRangeEnd = 26105, XrefRangeStart = 26094, XrefRangeEnd = 26102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short EncryptDecrypt(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0007C520 File Offset: 0x0007A720
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 26106, RefRangeEnd = 26110, XrefRangeStart = 26105, XrefRangeEnd = 26106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short EncryptDecrypt(short value, short key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Int16_Int16_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0007C56C File Offset: 0x0007A76C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26123, RefRangeEnd = 26124, XrefRangeStart = 26110, XrefRangeEnd = 26123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0007C594 File Offset: 0x0007A794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26124, XrefRangeEnd = 26131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0007C5BC File Offset: 0x0007A7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26131, XrefRangeEnd = 26132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_GetEncrypted_Public_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0007C5EC File Offset: 0x0007A7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26132, XrefRangeEnd = 26138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(short encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0007C620 File Offset: 0x0007A820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26138, XrefRangeEnd = 26139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_GetDecrypted_Public_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0007C650 File Offset: 0x0007A850
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 26145, RefRangeEnd = 26161, XrefRangeStart = 26139, XrefRangeEnd = 26145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_InternalDecrypt_Private_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0007C680 File Offset: 0x0007A880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26161, XrefRangeEnd = 26162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredShort(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredShort_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0007C6C0 File Offset: 0x0007A8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26162, XrefRangeEnd = 26163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator short(ObscuredShort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_ObscuredShort_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0007C700 File Offset: 0x0007A900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26163, XrefRangeEnd = 26170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredShort operator ++(ObscuredShort input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredShort_ObscuredShort_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0007C740 File Offset: 0x0007A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26170, XrefRangeEnd = 26177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredShort operator --(ObscuredShort input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredShort_ObscuredShort_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0007C780 File Offset: 0x0007A980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26177, XrefRangeEnd = 26178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0007C7B0 File Offset: 0x0007A9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26178, XrefRangeEnd = 26181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0007C7DC File Offset: 0x0007A9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26181, XrefRangeEnd = 26185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0007C818 File Offset: 0x0007AA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26185, XrefRangeEnd = 26188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0007C854 File Offset: 0x0007AA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26188, XrefRangeEnd = 26192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0007C8A4 File Offset: 0x0007AAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26192, XrefRangeEnd = 26195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0007C8E8 File Offset: 0x0007AAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26201, RefRangeEnd = 26202, XrefRangeStart = 26195, XrefRangeEnd = 26201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredShort obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredShort_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0007C928 File Offset: 0x0007AB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26202, XrefRangeEnd = 26204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredShort other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredShort_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0007C968 File Offset: 0x0007AB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26204, XrefRangeEnd = 26205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(short other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0007C9A8 File Offset: 0x0007ABA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26205, XrefRangeEnd = 26208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredShort.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0000A204 File Offset: 0x00008404
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredShort>.NativeClassPtr, ref this));
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x0007C9EC File Offset: 0x0007ABEC
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0000A216 File Offset: 0x00008416
		public unsafe static short cryptoKey
		{
			get
			{
				short num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredShort.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredShort.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int16_0;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int16_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Int16_Int16_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Int16_Int16_Int16_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Int16_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Int16_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Int16_0;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Int16_0;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredShort_Int16_0;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_ObscuredShort_0;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredShort_ObscuredShort_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredShort_ObscuredShort_0;

		// Token: 0x04001C83 RID: 7299
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredShort_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredShort_0;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int16_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001C8D RID: 7309
		[FieldOffset(0)]
		public short currentCryptoKey;

		// Token: 0x04001C8E RID: 7310
		[FieldOffset(2)]
		public short hiddenValue;

		// Token: 0x04001C8F RID: 7311
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001C90 RID: 7312
		[FieldOffset(6)]
		public short fakeValue;

		// Token: 0x04001C91 RID: 7313
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
