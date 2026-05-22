using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000200 RID: 512
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredQuaternion
	{
		// Token: 0x06001B24 RID: 6948 RVA: 0x0007B288 File Offset: 0x00079488
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredQuaternion()
		{
			Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredQuaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr);
			ObscuredQuaternion.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "cryptoKey");
			ObscuredQuaternion.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "identity");
			ObscuredQuaternion.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "currentCryptoKey");
			ObscuredQuaternion.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "hiddenValue");
			ObscuredQuaternion.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "inited");
			ObscuredQuaternion.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "fakeValue");
			ObscuredQuaternion.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "fakeValueActive");
			ObscuredQuaternion.NativeMethodInfoPtr__ctor_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667653);
			ObscuredQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667654);
			ObscuredQuaternion.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667655);
			ObscuredQuaternion.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667656);
			ObscuredQuaternion.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667657);
			ObscuredQuaternion.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667658);
			ObscuredQuaternion.NativeMethodInfoPtr_Decrypt_Public_Static_Quaternion_RawEncryptedQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667659);
			ObscuredQuaternion.NativeMethodInfoPtr_Decrypt_Public_Static_Quaternion_RawEncryptedQuaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667660);
			ObscuredQuaternion.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667661);
			ObscuredQuaternion.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667662);
			ObscuredQuaternion.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667663);
			ObscuredQuaternion.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667664);
			ObscuredQuaternion.NativeMethodInfoPtr_GetDecrypted_Public_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667665);
			ObscuredQuaternion.NativeMethodInfoPtr_InternalDecrypt_Private_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667666);
			ObscuredQuaternion.NativeMethodInfoPtr_CompareQuaternionsWithTolerance_Private_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667667);
			ObscuredQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredQuaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667668);
			ObscuredQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_ObscuredQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667669);
			ObscuredQuaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667670);
			ObscuredQuaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667671);
			ObscuredQuaternion.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, 100667672);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0007B4D4 File Offset: 0x000796D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25833, RefRangeEnd = 25834, XrefRangeStart = 25816, XrefRangeEnd = 25833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredQuaternion(Quaternion value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr__ctor_Private_Void_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0007B508 File Offset: 0x00079708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25834, XrefRangeEnd = 25844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredQuaternion(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0007B564 File Offset: 0x00079764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25844, XrefRangeEnd = 25848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(int newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0007B598 File Offset: 0x00079798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25848, XrefRangeEnd = 25856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0007B5D8 File Offset: 0x000797D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25856, XrefRangeEnd = 25860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Quaternion_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0007B624 File Offset: 0x00079824
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 25867, RefRangeEnd = 25873, XrefRangeStart = 25860, XrefRangeEnd = 25867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Single_Single_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0007B69C File Offset: 0x0007989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25873, XrefRangeEnd = 25884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_Decrypt_Public_Static_Quaternion_RawEncryptedQuaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0007B6DC File Offset: 0x000798DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25884, XrefRangeEnd = 25891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_Decrypt_Public_Static_Quaternion_RawEncryptedQuaternion_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0007B728 File Offset: 0x00079928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25904, RefRangeEnd = 25905, XrefRangeStart = 25891, XrefRangeEnd = 25904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0007B750 File Offset: 0x00079950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25905, XrefRangeEnd = 25916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0007B778 File Offset: 0x00079978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25916, XrefRangeEnd = 25917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedQuaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0007B7A8 File Offset: 0x000799A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25917, XrefRangeEnd = 25923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(ObscuredQuaternion.RawEncryptedQuaternion encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedQuaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0007B7DC File Offset: 0x000799DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25923, XrefRangeEnd = 25924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_GetDecrypted_Public_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0007B80C File Offset: 0x00079A0C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 25931, RefRangeEnd = 25939, XrefRangeStart = 25924, XrefRangeEnd = 25931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_InternalDecrypt_Private_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0007B83C File Offset: 0x00079A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25950, RefRangeEnd = 25951, XrefRangeStart = 25939, XrefRangeEnd = 25950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_CompareQuaternionsWithTolerance_Private_Boolean_Quaternion_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0007B888 File Offset: 0x00079A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25951, XrefRangeEnd = 25952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredQuaternion(Quaternion value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredQuaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0007B8C8 File Offset: 0x00079AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Quaternion(ObscuredQuaternion value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_ObscuredQuaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0007B908 File Offset: 0x00079B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25952, XrefRangeEnd = 25953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0007B938 File Offset: 0x00079B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25953, XrefRangeEnd = 25955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0007B964 File Offset: 0x00079B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25955, XrefRangeEnd = 25957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredQuaternion.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0000A1B6 File Offset: 0x000083B6
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, ref this));
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0007B9A0 File Offset: 0x00079BA0
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0000A1C8 File Offset: 0x000083C8
		public unsafe static int cryptoKey
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredQuaternion.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredQuaternion.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0007B9BC File Offset: 0x00079BBC
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0000A1D6 File Offset: 0x000083D6
		public unsafe static Quaternion identity
		{
			get
			{
				Quaternion quaternion;
				IL2CPP.il2cpp_field_static_get_value(ObscuredQuaternion.NativeFieldInfoPtr_identity, (void*)(&quaternion));
				return quaternion;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredQuaternion.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Quaternion_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Quaternion_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Quaternion_Int32_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedQuaternion_Single_Single_Single_Single_Int32_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Quaternion_RawEncryptedQuaternion_0;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Quaternion_RawEncryptedQuaternion_Int32_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedQuaternion_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedQuaternion_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Quaternion_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Quaternion_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr_CompareQuaternionsWithTolerance_Private_Boolean_Quaternion_Quaternion_0;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredQuaternion_Quaternion_0;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_ObscuredQuaternion_0;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001C47 RID: 7239
		[FieldOffset(0)]
		public int currentCryptoKey;

		// Token: 0x04001C48 RID: 7240
		[FieldOffset(4)]
		public ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;

		// Token: 0x04001C49 RID: 7241
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001C4A RID: 7242
		[FieldOffset(24)]
		public Quaternion fakeValue;

		// Token: 0x04001C4B RID: 7243
		[FieldOffset(40)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002BD RID: 701
		[Serializable]
		[StructLayout(2)]
		public struct RawEncryptedQuaternion
		{
			// Token: 0x06002440 RID: 9280 RVA: 0x0009A9E4 File Offset: 0x00098BE4
			// Note: this type is marked as 'beforefieldinit'.
			static RawEncryptedQuaternion()
			{
				Il2CppClassPointerStore<ObscuredQuaternion.RawEncryptedQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredQuaternion>.NativeClassPtr, "RawEncryptedQuaternion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredQuaternion.RawEncryptedQuaternion>.NativeClassPtr);
				ObscuredQuaternion.RawEncryptedQuaternion.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion.RawEncryptedQuaternion>.NativeClassPtr, "x");
				ObscuredQuaternion.RawEncryptedQuaternion.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion.RawEncryptedQuaternion>.NativeClassPtr, "y");
				ObscuredQuaternion.RawEncryptedQuaternion.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion.RawEncryptedQuaternion>.NativeClassPtr, "z");
				ObscuredQuaternion.RawEncryptedQuaternion.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredQuaternion.RawEncryptedQuaternion>.NativeClassPtr, "w");
			}

			// Token: 0x06002441 RID: 9281 RVA: 0x0000D9CC File Offset: 0x0000BBCC
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredQuaternion.RawEncryptedQuaternion>.NativeClassPtr, ref this));
			}

			// Token: 0x040022B1 RID: 8881
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040022B2 RID: 8882
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x040022B3 RID: 8883
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x040022B4 RID: 8884
			private static readonly IntPtr NativeFieldInfoPtr_w;

			// Token: 0x040022B5 RID: 8885
			[FieldOffset(0)]
			public int x;

			// Token: 0x040022B6 RID: 8886
			[FieldOffset(4)]
			public int y;

			// Token: 0x040022B7 RID: 8887
			[FieldOffset(8)]
			public int z;

			// Token: 0x040022B8 RID: 8888
			[FieldOffset(12)]
			public int w;
		}
	}
}
