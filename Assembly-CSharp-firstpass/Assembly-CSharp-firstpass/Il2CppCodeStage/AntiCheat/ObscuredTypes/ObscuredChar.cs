using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001F8 RID: 504
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredChar
	{
		// Token: 0x060019DD RID: 6621 RVA: 0x00075144 File Offset: 0x00073344
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredChar()
		{
			Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredChar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr);
			ObscuredChar.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, "cryptoKey");
			ObscuredChar.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, "currentCryptoKey");
			ObscuredChar.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, "hiddenValue");
			ObscuredChar.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, "inited");
			ObscuredChar.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, "fakeValue");
			ObscuredChar.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, "fakeValueActive");
			ObscuredChar.NativeMethodInfoPtr__ctor_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667377);
			ObscuredChar.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667378);
			ObscuredChar.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667379);
			ObscuredChar.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667380);
			ObscuredChar.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667381);
			ObscuredChar.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667382);
			ObscuredChar.NativeMethodInfoPtr_GetEncrypted_Public_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667383);
			ObscuredChar.NativeMethodInfoPtr_SetEncrypted_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667384);
			ObscuredChar.NativeMethodInfoPtr_GetDecrypted_Public_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667385);
			ObscuredChar.NativeMethodInfoPtr_InternalDecrypt_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667386);
			ObscuredChar.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredChar_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667387);
			ObscuredChar.NativeMethodInfoPtr_op_Implicit_Public_Static_Char_ObscuredChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667388);
			ObscuredChar.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredChar_ObscuredChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667389);
			ObscuredChar.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredChar_ObscuredChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667390);
			ObscuredChar.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667391);
			ObscuredChar.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667392);
			ObscuredChar.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667393);
			ObscuredChar.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667394);
			ObscuredChar.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667395);
			ObscuredChar.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667396);
			ObscuredChar.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667397);
			ObscuredChar.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, 100667398);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x000753A4 File Offset: 0x000735A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23008, RefRangeEnd = 23009, XrefRangeStart = 23001, XrefRangeEnd = 23008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredChar(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr__ctor_Private_Void_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000753D8 File Offset: 0x000735D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23009, XrefRangeEnd = 23013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(char newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0007540C File Offset: 0x0007360C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23021, RefRangeEnd = 23022, XrefRangeStart = 23013, XrefRangeEnd = 23021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char EncryptDecrypt(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0007544C File Offset: 0x0007364C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 23023, RefRangeEnd = 23029, XrefRangeStart = 23022, XrefRangeEnd = 23023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char EncryptDecrypt(char value, char key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00075498 File Offset: 0x00073698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23042, RefRangeEnd = 23043, XrefRangeStart = 23029, XrefRangeEnd = 23042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x000754C0 File Offset: 0x000736C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23043, XrefRangeEnd = 23050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x000754E8 File Offset: 0x000736E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23050, XrefRangeEnd = 23051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_GetEncrypted_Public_Char_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00075518 File Offset: 0x00073718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23051, XrefRangeEnd = 23057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(char encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_SetEncrypted_Public_Void_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0007554C File Offset: 0x0007374C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23057, XrefRangeEnd = 23058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_GetDecrypted_Public_Char_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0007557C File Offset: 0x0007377C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 23064, RefRangeEnd = 23078, XrefRangeStart = 23058, XrefRangeEnd = 23064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_InternalDecrypt_Private_Char_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000755AC File Offset: 0x000737AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23078, XrefRangeEnd = 23079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredChar(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredChar_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x000755EC File Offset: 0x000737EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23079, XrefRangeEnd = 23080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator char(ObscuredChar value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_op_Implicit_Public_Static_Char_ObscuredChar_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0007562C File Offset: 0x0007382C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23080, XrefRangeEnd = 23087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredChar operator ++(ObscuredChar input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredChar_ObscuredChar_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0007566C File Offset: 0x0007386C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23087, XrefRangeEnd = 23094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredChar operator --(ObscuredChar input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredChar_ObscuredChar_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000756AC File Offset: 0x000738AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23094, XrefRangeEnd = 23095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x000756DC File Offset: 0x000738DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23095, XrefRangeEnd = 23100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00075708 File Offset: 0x00073908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23100, XrefRangeEnd = 23105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00075744 File Offset: 0x00073944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23105, XrefRangeEnd = 23108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00075788 File Offset: 0x00073988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23114, RefRangeEnd = 23115, XrefRangeStart = 23108, XrefRangeEnd = 23114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredChar obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredChar_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000757C8 File Offset: 0x000739C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23115, XrefRangeEnd = 23117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredChar other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredChar_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00075808 File Offset: 0x00073A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23117, XrefRangeEnd = 23118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(char other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00075848 File Offset: 0x00073A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23118, XrefRangeEnd = 23121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredChar.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00009FF6 File Offset: 0x000081F6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredChar>.NativeClassPtr, ref this));
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0007588C File Offset: 0x00073A8C
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0000A008 File Offset: 0x00008208
		public unsafe static char cryptoKey
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(ObscuredChar.NativeFieldInfoPtr_cryptoKey, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredChar.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Char_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Char_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Char_Char_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_EncryptDecrypt_Public_Static_Char_Char_Char_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Char_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Char_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Char_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Char_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredChar_Char_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Char_ObscuredChar_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_ObscuredChar_ObscuredChar_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_ObscuredChar_ObscuredChar_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_IFormatProvider_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredChar_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredChar_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001AE6 RID: 6886
		[FieldOffset(0)]
		public char currentCryptoKey;

		// Token: 0x04001AE7 RID: 6887
		[FieldOffset(2)]
		public char hiddenValue;

		// Token: 0x04001AE8 RID: 6888
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001AE9 RID: 6889
		[FieldOffset(6)]
		public char fakeValue;

		// Token: 0x04001AEA RID: 6890
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
