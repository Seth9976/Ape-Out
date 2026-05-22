using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000204 RID: 516
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredUInt
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x0007D5B8 File Offset: 0x0007B7B8
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredUInt()
		{
			Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredUInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr);
			ObscuredUInt.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, "cryptoKey");
			ObscuredUInt.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, "currentCryptoKey");
			ObscuredUInt.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, "hiddenValue");
			ObscuredUInt.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, "inited");
			ObscuredUInt.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, "fakeValue");
			ObscuredUInt.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, "fakeValueActive");
			ObscuredUInt.NativeMethodInfoPtr__ctor_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667754);
			ObscuredUInt.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667755);
			ObscuredUInt.NativeMethodInfoPtr_Encrypt_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667756);
			ObscuredUInt.NativeMethodInfoPtr_Decrypt_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667757);
			ObscuredUInt.NativeMethodInfoPtr_Encrypt_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667758);
			ObscuredUInt.NativeMethodInfoPtr_Decrypt_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667759);
			ObscuredUInt.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667760);
			ObscuredUInt.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667761);
			ObscuredUInt.NativeMethodInfoPtr_GetEncrypted_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667762);
			ObscuredUInt.NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667763);
			ObscuredUInt.NativeMethodInfoPtr_GetDecrypted_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667764);
			ObscuredUInt.NativeMethodInfoPtr_InternalDecrypt_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667765);
			ObscuredUInt.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredUInt_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667766);
			ObscuredUInt.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ObscuredUInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667767);
			ObscuredUInt.NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredInt_ObscuredUInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667768);
			ObscuredUInt.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredUInt_ObscuredUInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667769);
			ObscuredUInt.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredUInt_ObscuredUInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667770);
			ObscuredUInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667771);
			ObscuredUInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667772);
			ObscuredUInt.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667773);
			ObscuredUInt.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667774);
			ObscuredUInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667775);
			ObscuredUInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667776);
			ObscuredUInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredUInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667777);
			ObscuredUInt.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredUInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667778);
			ObscuredUInt.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667779);
			ObscuredUInt.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, 100667780);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0007D87C File Offset: 0x0007BA7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26410, RefRangeEnd = 26411, XrefRangeStart = 26404, XrefRangeEnd = 26410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredUInt(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr__ctor_Private_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0007D8B0 File Offset: 0x0007BAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26411, XrefRangeEnd = 26415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(uint newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0007D8E4 File Offset: 0x0007BAE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 26423, RefRangeEnd = 26425, XrefRangeStart = 26415, XrefRangeEnd = 26423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Encrypt(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_Encrypt_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0007D924 File Offset: 0x0007BB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26425, XrefRangeEnd = 26433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Decrypt(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_Decrypt_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0007D964 File Offset: 0x0007BB64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26434, RefRangeEnd = 26437, XrefRangeStart = 26433, XrefRangeEnd = 26434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Encrypt(uint value, uint key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_Encrypt_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0007D9B0 File Offset: 0x0007BBB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 26438, RefRangeEnd = 26443, XrefRangeStart = 26437, XrefRangeEnd = 26438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Decrypt(uint value, uint key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_Decrypt_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0007D9FC File Offset: 0x0007BBFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26456, RefRangeEnd = 26457, XrefRangeStart = 26443, XrefRangeEnd = 26456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0007DA24 File Offset: 0x0007BC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26457, XrefRangeEnd = 26464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0007DA4C File Offset: 0x0007BC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26464, XrefRangeEnd = 26465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_GetEncrypted_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0007DA7C File Offset: 0x0007BC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26465, XrefRangeEnd = 26471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(uint encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0007DAB0 File Offset: 0x0007BCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26471, XrefRangeEnd = 26472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_GetDecrypted_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0007DAE0 File Offset: 0x0007BCE0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 26478, RefRangeEnd = 26495, XrefRangeStart = 26472, XrefRangeEnd = 26478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_InternalDecrypt_Private_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0007DB10 File Offset: 0x0007BD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26495, XrefRangeEnd = 26496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredUInt(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredUInt_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0007DB50 File Offset: 0x0007BD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26496, XrefRangeEnd = 26497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(ObscuredUInt value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ObscuredUInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0007DB90 File Offset: 0x0007BD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26497, XrefRangeEnd = 26508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ObscuredInt(ObscuredUInt value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredInt_ObscuredUInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0007DBD0 File Offset: 0x0007BDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26508, XrefRangeEnd = 26515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredUInt operator ++(ObscuredUInt input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredUInt_ObscuredUInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0007DC10 File Offset: 0x0007BE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26515, XrefRangeEnd = 26522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredUInt operator --(ObscuredUInt input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredUInt_ObscuredUInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0007DC50 File Offset: 0x0007BE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0007DC80 File Offset: 0x0007BE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26522, XrefRangeEnd = 26525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0007DCAC File Offset: 0x0007BEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26525, XrefRangeEnd = 26528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0007DCE8 File Offset: 0x0007BEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26528, XrefRangeEnd = 26531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0007DD24 File Offset: 0x0007BF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26531, XrefRangeEnd = 26534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0007DD74 File Offset: 0x0007BF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26534, XrefRangeEnd = 26541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0007DDB8 File Offset: 0x0007BFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26541, XrefRangeEnd = 26547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredUInt obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredUInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0007DDF8 File Offset: 0x0007BFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26547, XrefRangeEnd = 26549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredUInt other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredUInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0007DE38 File Offset: 0x0007C038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26549, XrefRangeEnd = 26550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(uint other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0007DE78 File Offset: 0x0007C078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26550, XrefRangeEnd = 26552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredUInt.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0000A2D2 File Offset: 0x000084D2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredUInt>.NativeClassPtr, ref this));
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x0007DEBC File Offset: 0x0007C0BC
		// (set) Token: 0x06001BBF RID: 7103 RVA: 0x0000A2E4 File Offset: 0x000084E4
		public unsafe static uint cryptoKey
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredUInt.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredUInt.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_UInt32_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_UInt32_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_UInt32_UInt32_0;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_UInt32_UInt32_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_UInt32_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_UInt32_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_UInt32_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_UInt32_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredUInt_UInt32_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ObscuredUInt_0;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ObscuredInt_ObscuredUInt_0;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredUInt_ObscuredUInt_0;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredUInt_ObscuredUInt_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredUInt_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredUInt_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UInt32_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001CD6 RID: 7382
		[FieldOffset(0)]
		public uint currentCryptoKey;

		// Token: 0x04001CD7 RID: 7383
		[FieldOffset(4)]
		public uint hiddenValue;

		// Token: 0x04001CD8 RID: 7384
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001CD9 RID: 7385
		[FieldOffset(12)]
		public uint fakeValue;

		// Token: 0x04001CDA RID: 7386
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
