using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000203 RID: 515
	[Serializable]
	public sealed class ObscuredString : Object
	{
		// Token: 0x06001B76 RID: 7030 RVA: 0x0007CA08 File Offset: 0x0007AC08
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredString()
		{
			Il2CppClassPointerStore<ObscuredString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr);
			ObscuredString.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, "cryptoKey");
			ObscuredString.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, "currentCryptoKey");
			ObscuredString.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, "hiddenValue");
			ObscuredString.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, "inited");
			ObscuredString.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, "fakeValue");
			ObscuredString.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, "fakeValueActive");
			ObscuredString.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667724);
			ObscuredString.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667725);
			ObscuredString.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667726);
			ObscuredString.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667727);
			ObscuredString.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667728);
			ObscuredString.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667729);
			ObscuredString.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667730);
			ObscuredString.NativeMethodInfoPtr_GetEncrypted_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667731);
			ObscuredString.NativeMethodInfoPtr_SetEncrypted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667732);
			ObscuredString.NativeMethodInfoPtr_GetDecrypted_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667733);
			ObscuredString.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667734);
			ObscuredString.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Il2CppStructArray_1_Byte_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667735);
			ObscuredString.NativeMethodInfoPtr_InternalDecrypt_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667736);
			ObscuredString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667737);
			ObscuredString.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667738);
			ObscuredString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ObscuredString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667739);
			ObscuredString.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredString_ObscuredString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667740);
			ObscuredString.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredString_ObscuredString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667741);
			ObscuredString.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667742);
			ObscuredString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667743);
			ObscuredString.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667744);
			ObscuredString.NativeMethodInfoPtr_Equals_Public_Boolean_ObscuredString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667745);
			ObscuredString.NativeMethodInfoPtr_Equals_Public_Boolean_ObscuredString_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667746);
			ObscuredString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667747);
			ObscuredString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667748);
			ObscuredString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667749);
			ObscuredString.NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667750);
			ObscuredString.NativeMethodInfoPtr_GetString_Private_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667751);
			ObscuredString.NativeMethodInfoPtr_ArraysEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr, 100667752);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0007CCF4 File Offset: 0x0007AEF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0007CD30 File Offset: 0x0007AF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26208, XrefRangeEnd = 26214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredString(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObscuredString>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0007CD7C File Offset: 0x0007AF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26214, XrefRangeEnd = 26218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(string newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0007CDB4 File Offset: 0x0007AFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26218, XrefRangeEnd = 26224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptDecrypt(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0007CDF0 File Offset: 0x0007AFF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 26237, RefRangeEnd = 26242, XrefRangeStart = 26224, XrefRangeEnd = 26237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncryptDecrypt(string value, string key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0007CE40 File Offset: 0x0007B040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26251, RefRangeEnd = 26252, XrefRangeStart = 26242, XrefRangeEnd = 26251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0007CE74 File Offset: 0x0007B074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26252, XrefRangeEnd = 26261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0007CEA8 File Offset: 0x0007B0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26261, XrefRangeEnd = 26271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEncrypted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_GetEncrypted_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0007CEE0 File Offset: 0x0007B0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26271, XrefRangeEnd = 26284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(string encrypted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(encrypted);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_SetEncrypted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0007CF24 File Offset: 0x0007B124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26284, XrefRangeEnd = 26285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDecrypted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_GetDecrypted_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0007CF5C File Offset: 0x0007B15C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 26290, RefRangeEnd = 26292, XrefRangeStart = 26285, XrefRangeEnd = 26290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> InternalEncrypt(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0007CFA0 File Offset: 0x0007B1A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26301, RefRangeEnd = 26304, XrefRangeStart = 26292, XrefRangeEnd = 26301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> InternalEncrypt(string value, string key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_InternalEncrypt_Private_Static_Il2CppStructArray_1_Byte_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0007CFF8 File Offset: 0x0007B1F8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 26332, RefRangeEnd = 26348, XrefRangeStart = 26304, XrefRangeEnd = 26332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalDecrypt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_InternalDecrypt_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0007D030 File Offset: 0x0007B230
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0007D06C File Offset: 0x0007B26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26348, XrefRangeEnd = 26349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator ObscuredString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredString_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObscuredString>(intPtr3) : null;
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26349, XrefRangeEnd = 26353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(ObscuredString value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ObscuredString_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0007D0EC File Offset: 0x0007B2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26356, RefRangeEnd = 26357, XrefRangeStart = 26353, XrefRangeEnd = 26356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ObscuredString a, ObscuredString b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredString_ObscuredString_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0007D140 File Offset: 0x0007B340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26357, XrefRangeEnd = 26361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ObscuredString a, ObscuredString b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredString_ObscuredString_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0007D194 File Offset: 0x0007B394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26361, XrefRangeEnd = 26363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0007D1D0 File Offset: 0x0007B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0007D208 File Offset: 0x0007B408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26363, XrefRangeEnd = 26366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0007D258 File Offset: 0x0007B458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26374, RefRangeEnd = 26375, XrefRangeStart = 26366, XrefRangeEnd = 26374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredString value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_Equals_Public_Boolean_ObscuredString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0007D2A8 File Offset: 0x0007B4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26375, XrefRangeEnd = 26382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_Equals_Public_Boolean_ObscuredString_StringComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0007D304 File Offset: 0x0007B504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26382, XrefRangeEnd = 26386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredString other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0007D354 File Offset: 0x0007B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26386, XrefRangeEnd = 26389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(string other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0007D3A4 File Offset: 0x0007B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26389, XrefRangeEnd = 26392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0007D3F4 File Offset: 0x0007B5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26392, XrefRangeEnd = 26397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0007D438 File Offset: 0x0007B638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26397, XrefRangeEnd = 26403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_GetString_Private_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0007D474 File Offset: 0x0007B674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26403, XrefRangeEnd = 26404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArraysEquals(Il2CppStructArray<byte> a1, Il2CppStructArray<byte> a2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredString.NativeMethodInfoPtr_ArraysEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0000A224 File Offset: 0x00008424
		public ObscuredString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0007D4C8 File Offset: 0x0007B6C8
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0000A22D File Offset: 0x0000842D
		public unsafe static string cryptoKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObscuredString.NativeFieldInfoPtr_cryptoKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredString.NativeFieldInfoPtr_cryptoKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0007D4E8 File Offset: 0x0007B6E8
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000A23F File Offset: 0x0000843F
		public unsafe string currentCryptoKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_currentCryptoKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_currentCryptoKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0007D510 File Offset: 0x0007B710
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0000A25E File Offset: 0x0000845E
		public unsafe Il2CppStructArray<byte> hiddenValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_hiddenValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_hiddenValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0007D540 File Offset: 0x0007B740
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000A27D File Offset: 0x0000847D
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0007D568 File Offset: 0x0007B768
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000A298 File Offset: 0x00008498
		public unsafe string fakeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_fakeValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_fakeValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0007D590 File Offset: 0x0007B790
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000A2B7 File Offset: 0x000084B7
		public unsafe bool fakeValueActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_fakeValueActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObscuredString.NativeFieldInfoPtr_fakeValueActive)) = value;
			}
		}

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_String_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_String_String_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_String_String_String_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_String_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_String_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_String_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncrypt_Private_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncrypt_Private_Static_Il2CppStructArray_1_Byte_String_String_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_String_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredString_String_0;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_ObscuredString_0;

		// Token: 0x04001CA8 RID: 7336
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredString_ObscuredString_0;

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredString_ObscuredString_0;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ObscuredString_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ObscuredString_StringComparison_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredString_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001CB3 RID: 7347
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeMethodInfoPtr_ArraysEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;
	}
}
