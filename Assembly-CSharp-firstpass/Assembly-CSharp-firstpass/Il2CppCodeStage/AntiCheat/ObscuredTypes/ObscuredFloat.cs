using System;
using System.Runtime.InteropServices;
using Il2CppCodeStage.AntiCheat.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001FB RID: 507
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredFloat
	{
		// Token: 0x06001A39 RID: 6713 RVA: 0x00076C80 File Offset: 0x00074E80
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredFloat()
		{
			Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredFloat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr);
			ObscuredFloat.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "cryptoKey");
			ObscuredFloat.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "currentCryptoKey");
			ObscuredFloat.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "hiddenValue");
			ObscuredFloat.NativeFieldInfoPtr_hiddenValueOldByte4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "hiddenValueOldByte4");
			ObscuredFloat.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "inited");
			ObscuredFloat.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "fakeValue");
			ObscuredFloat.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "fakeValueActive");
			ObscuredFloat.NativeMethodInfoPtr__ctor_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667460);
			ObscuredFloat.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667461);
			ObscuredFloat.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667462);
			ObscuredFloat.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667463);
			ObscuredFloat.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667464);
			ObscuredFloat.NativeMethodInfoPtr_Decrypt_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667465);
			ObscuredFloat.NativeMethodInfoPtr_Decrypt_Public_Static_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667466);
			ObscuredFloat.NativeMethodInfoPtr_MigrateEncrypted_Public_Static_Int32_Int32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667467);
			ObscuredFloat.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667468);
			ObscuredFloat.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667469);
			ObscuredFloat.NativeMethodInfoPtr_GetEncrypted_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667470);
			ObscuredFloat.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667471);
			ObscuredFloat.NativeMethodInfoPtr_GetDecrypted_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667472);
			ObscuredFloat.NativeMethodInfoPtr_InternalDecrypt_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667473);
			ObscuredFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667474);
			ObscuredFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667475);
			ObscuredFloat.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredFloat_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667476);
			ObscuredFloat.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredFloat_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667477);
			ObscuredFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667478);
			ObscuredFloat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667479);
			ObscuredFloat.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667480);
			ObscuredFloat.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667481);
			ObscuredFloat.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667482);
			ObscuredFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667483);
			ObscuredFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667484);
			ObscuredFloat.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667485);
			ObscuredFloat.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667486);
			ObscuredFloat.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, 100667487);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00076F6C File Offset: 0x0007516C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 23466, RefRangeEnd = 23481, XrefRangeStart = 23456, XrefRangeEnd = 23466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredFloat(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr__ctor_Private_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00076FA0 File Offset: 0x000751A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23481, XrefRangeEnd = 23485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(int newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00076FD4 File Offset: 0x000751D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23485, XrefRangeEnd = 23489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Encrypt(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00077014 File Offset: 0x00075214
		[CallerCount(0)]
		public unsafe static int Encrypt(float value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00077060 File Offset: 0x00075260
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23494, RefRangeEnd = 23498, XrefRangeStart = 23489, XrefRangeEnd = 23494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalEncrypt(float value, int key = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Int32_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000770AC File Offset: 0x000752AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23498, XrefRangeEnd = 23502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Decrypt(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_Decrypt_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000770EC File Offset: 0x000752EC
		[CallerCount(0)]
		public unsafe static float Decrypt(int value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_Decrypt_Public_Static_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00077138 File Offset: 0x00075338
		[CallerCount(0)]
		public unsafe static int MigrateEncrypted(int encrypted, byte fromVersion = 0, byte toVersion = 2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_MigrateEncrypted_Public_Static_Int32_Int32_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00077194 File Offset: 0x00075394
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23512, RefRangeEnd = 23516, XrefRangeStart = 23502, XrefRangeEnd = 23512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x000771BC File Offset: 0x000753BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23516, XrefRangeEnd = 23523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x000771E4 File Offset: 0x000753E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23523, XrefRangeEnd = 23524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_GetEncrypted_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00077214 File Offset: 0x00075414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23524, XrefRangeEnd = 23530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00077248 File Offset: 0x00075448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23530, XrefRangeEnd = 23531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_GetDecrypted_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00077278 File Offset: 0x00075478
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 23540, RefRangeEnd = 23568, XrefRangeStart = 23531, XrefRangeEnd = 23540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_InternalDecrypt_Private_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000772A8 File Offset: 0x000754A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23568, XrefRangeEnd = 23569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredFloat(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredFloat_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x000772E8 File Offset: 0x000754E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23569, XrefRangeEnd = 23570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float(ObscuredFloat value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ObscuredFloat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00077328 File Offset: 0x00075528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23570, XrefRangeEnd = 23577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredFloat operator ++(ObscuredFloat input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredFloat_ObscuredFloat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00077368 File Offset: 0x00075568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23577, XrefRangeEnd = 23584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredFloat operator --(ObscuredFloat input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredFloat_ObscuredFloat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000773A8 File Offset: 0x000755A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23584, XrefRangeEnd = 23585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000773D8 File Offset: 0x000755D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23585, XrefRangeEnd = 23591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00077404 File Offset: 0x00075604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23591, XrefRangeEnd = 23594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00077440 File Offset: 0x00075640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23594, XrefRangeEnd = 23600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0007747C File Offset: 0x0007567C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23600, XrefRangeEnd = 23603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000774CC File Offset: 0x000756CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23603, XrefRangeEnd = 23607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00077510 File Offset: 0x00075710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23607, XrefRangeEnd = 23609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredFloat obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredFloat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00077550 File Offset: 0x00075750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23609, XrefRangeEnd = 23611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredFloat other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredFloat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00077590 File Offset: 0x00075790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23611, XrefRangeEnd = 23612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(float other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000775D0 File Offset: 0x000757D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23612, XrefRangeEnd = 23614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredFloat.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0000A056 File Offset: 0x00008256
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, ref this));
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00077614 File Offset: 0x00075814
		// (set) Token: 0x06001A58 RID: 6744 RVA: 0x0000A068 File Offset: 0x00008268
		public unsafe static int cryptoKey
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredFloat.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredFloat.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValueOldByte4;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Single_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Single_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Single_Int32_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncrypt_Private_Static_Int32_Single_Int32_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Single_Int32_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Single_Int32_Int32_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_MigrateEncrypted_Public_Static_Int32_Int32_Byte_Byte_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Int32_0;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Int32_0;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Single_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Single_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredFloat_Single_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ObscuredFloat_0;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredFloat_ObscuredFloat_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredFloat_ObscuredFloat_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredFloat_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredFloat_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Single_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001B60 RID: 7008
		[FieldOffset(0)]
		public int currentCryptoKey;

		// Token: 0x04001B61 RID: 7009
		[FieldOffset(4)]
		public int hiddenValue;

		// Token: 0x04001B62 RID: 7010
		[FieldOffset(8)]
		public ACTkByte4 hiddenValueOldByte4;

		// Token: 0x04001B63 RID: 7011
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001B64 RID: 7012
		[FieldOffset(16)]
		public float fakeValue;

		// Token: 0x04001B65 RID: 7013
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002BA RID: 698
		[StructLayout(2)]
		public struct FloatIntBytesUnion
		{
			// Token: 0x0600243E RID: 9278 RVA: 0x0009A97C File Offset: 0x00098B7C
			// Note: this type is marked as 'beforefieldinit'.
			static FloatIntBytesUnion()
			{
				Il2CppClassPointerStore<ObscuredFloat.FloatIntBytesUnion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, "FloatIntBytesUnion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredFloat.FloatIntBytesUnion>.NativeClassPtr);
				ObscuredFloat.FloatIntBytesUnion.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat.FloatIntBytesUnion>.NativeClassPtr, "f");
				ObscuredFloat.FloatIntBytesUnion.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat.FloatIntBytesUnion>.NativeClassPtr, "i");
				ObscuredFloat.FloatIntBytesUnion.NativeFieldInfoPtr_b4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredFloat.FloatIntBytesUnion>.NativeClassPtr, "b4");
			}

			// Token: 0x0600243F RID: 9279 RVA: 0x0000D9BA File Offset: 0x0000BBBA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredFloat.FloatIntBytesUnion>.NativeClassPtr, ref this));
			}

			// Token: 0x04002296 RID: 8854
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04002297 RID: 8855
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04002298 RID: 8856
			private static readonly IntPtr NativeFieldInfoPtr_b4;

			// Token: 0x04002299 RID: 8857
			[FieldOffset(0)]
			public float f;

			// Token: 0x0400229A RID: 8858
			[FieldOffset(0)]
			public int i;

			// Token: 0x0400229B RID: 8859
			[FieldOffset(0)]
			public ACTkByte4 b4;
		}
	}
}
