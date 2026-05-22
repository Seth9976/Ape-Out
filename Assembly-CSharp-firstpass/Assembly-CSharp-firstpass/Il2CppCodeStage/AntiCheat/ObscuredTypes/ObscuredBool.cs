using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x020001F6 RID: 502
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredBool
	{
		// Token: 0x060019A6 RID: 6566 RVA: 0x00074168 File Offset: 0x00072368
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredBool()
		{
			Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredBool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr);
			ObscuredBool.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, "cryptoKey");
			ObscuredBool.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, "currentCryptoKey");
			ObscuredBool.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, "hiddenValue");
			ObscuredBool.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, "inited");
			ObscuredBool.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, "fakeValue");
			ObscuredBool.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, "fakeValueActive");
			ObscuredBool.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667328);
			ObscuredBool.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667329);
			ObscuredBool.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667330);
			ObscuredBool.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667331);
			ObscuredBool.NativeMethodInfoPtr_Decrypt_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667332);
			ObscuredBool.NativeMethodInfoPtr_Decrypt_Public_Static_Boolean_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667333);
			ObscuredBool.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667334);
			ObscuredBool.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667335);
			ObscuredBool.NativeMethodInfoPtr_GetEncrypted_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667336);
			ObscuredBool.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667337);
			ObscuredBool.NativeMethodInfoPtr_GetDecrypted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667338);
			ObscuredBool.NativeMethodInfoPtr_InternalDecrypt_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667339);
			ObscuredBool.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredBool_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667340);
			ObscuredBool.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ObscuredBool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667341);
			ObscuredBool.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667342);
			ObscuredBool.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667343);
			ObscuredBool.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667344);
			ObscuredBool.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredBool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667345);
			ObscuredBool.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredBool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667346);
			ObscuredBool.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667347);
			ObscuredBool.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, 100667348);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000743B4 File Offset: 0x000725B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22764, RefRangeEnd = 22765, XrefRangeStart = 22757, XrefRangeEnd = 22764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredBool(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000743E8 File Offset: 0x000725E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22765, XrefRangeEnd = 22769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(byte newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0007441C File Offset: 0x0007261C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22777, RefRangeEnd = 22778, XrefRangeStart = 22769, XrefRangeEnd = 22777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Encrypt(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0007445C File Offset: 0x0007265C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22782, RefRangeEnd = 22783, XrefRangeStart = 22778, XrefRangeEnd = 22782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Encrypt(bool value, byte key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Boolean_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000744A8 File Offset: 0x000726A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22783, XrefRangeEnd = 22791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Decrypt(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_Decrypt_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x000744E8 File Offset: 0x000726E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 22795, RefRangeEnd = 22797, XrefRangeStart = 22791, XrefRangeEnd = 22795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Decrypt(int value, byte key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_Decrypt_Public_Static_Boolean_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00074534 File Offset: 0x00072734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22810, RefRangeEnd = 22811, XrefRangeStart = 22797, XrefRangeEnd = 22810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0007455C File Offset: 0x0007275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22811, XrefRangeEnd = 22818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00074584 File Offset: 0x00072784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22818, XrefRangeEnd = 22819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_GetEncrypted_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000745B4 File Offset: 0x000727B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22819, XrefRangeEnd = 22825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_SetEncrypted_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000745E8 File Offset: 0x000727E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22825, XrefRangeEnd = 22826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_GetDecrypted_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00074618 File Offset: 0x00072818
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 22830, RefRangeEnd = 22841, XrefRangeStart = 22826, XrefRangeEnd = 22830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_InternalDecrypt_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00074648 File Offset: 0x00072848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22841, XrefRangeEnd = 22842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredBool(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredBool_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00074688 File Offset: 0x00072888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22842, XrefRangeEnd = 22843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(ObscuredBool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ObscuredBool_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000746C8 File Offset: 0x000728C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22843, XrefRangeEnd = 22844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000746F8 File Offset: 0x000728F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22844, XrefRangeEnd = 22849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00074724 File Offset: 0x00072924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22849, XrefRangeEnd = 22852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00074768 File Offset: 0x00072968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22857, RefRangeEnd = 22858, XrefRangeStart = 22852, XrefRangeEnd = 22857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ObscuredBool obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredBool_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x000747A8 File Offset: 0x000729A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22858, XrefRangeEnd = 22860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ObscuredBool other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredBool_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000747E8 File Offset: 0x000729E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22860, XrefRangeEnd = 22861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(bool other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00074828 File Offset: 0x00072A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22861, XrefRangeEnd = 22863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredBool.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00009FB6 File Offset: 0x000081B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredBool>.NativeClassPtr, ref this));
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x0007486C File Offset: 0x00072A6C
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00009FC8 File Offset: 0x000081C8
		public unsafe static byte cryptoKey
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(ObscuredBool.NativeFieldInfoPtr_cryptoKey, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredBool.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Byte_0;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Boolean_0;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_Int32_Boolean_Byte_0;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Boolean_Int32_0;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Boolean_Int32_Byte_0;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_Int32_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_Int32_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Boolean_0;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Boolean_0;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredBool_Boolean_0;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ObscuredBool_0;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObscuredBool_0;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ObscuredBool_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Boolean_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001AA0 RID: 6816
		[FieldOffset(0)]
		public byte currentCryptoKey;

		// Token: 0x04001AA1 RID: 6817
		[FieldOffset(4)]
		public int hiddenValue;

		// Token: 0x04001AA2 RID: 6818
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001AA3 RID: 6819
		[FieldOffset(9)]
		[MarshalAs(4)]
		public bool fakeValue;

		// Token: 0x04001AA4 RID: 6820
		[FieldOffset(10)]
		[MarshalAs(4)]
		public bool fakeValueActive;
	}
}
