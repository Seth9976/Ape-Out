using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000208 RID: 520
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredVector2Int
	{
		// Token: 0x06001C1D RID: 7197 RVA: 0x0007F990 File Offset: 0x0007DB90
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredVector2Int()
		{
			Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredVector2Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr);
			ObscuredVector2Int.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "cryptoKey");
			ObscuredVector2Int.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "zero");
			ObscuredVector2Int.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "currentCryptoKey");
			ObscuredVector2Int.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "hiddenValue");
			ObscuredVector2Int.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "inited");
			ObscuredVector2Int.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "fakeValue");
			ObscuredVector2Int.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "fakeValueActive");
			ObscuredVector2Int.NativeMethodInfoPtr__ctor_Private_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667864);
			ObscuredVector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667865);
			ObscuredVector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667866);
			ObscuredVector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667867);
			ObscuredVector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667868);
			ObscuredVector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667869);
			ObscuredVector2Int.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667870);
			ObscuredVector2Int.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667871);
			ObscuredVector2Int.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667872);
			ObscuredVector2Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667873);
			ObscuredVector2Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667874);
			ObscuredVector2Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667875);
			ObscuredVector2Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2Int_RawEncryptedVector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667876);
			ObscuredVector2Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2Int_RawEncryptedVector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667877);
			ObscuredVector2Int.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667878);
			ObscuredVector2Int.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667879);
			ObscuredVector2Int.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667880);
			ObscuredVector2Int.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667881);
			ObscuredVector2Int.NativeMethodInfoPtr_GetDecrypted_Public_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667882);
			ObscuredVector2Int.NativeMethodInfoPtr_InternalDecrypt_Private_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667883);
			ObscuredVector2Int.NativeMethodInfoPtr_InternalDecryptField_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667884);
			ObscuredVector2Int.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667885);
			ObscuredVector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667886);
			ObscuredVector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2Int_ObscuredVector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667887);
			ObscuredVector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_ObscuredVector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667888);
			ObscuredVector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667889);
			ObscuredVector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, 100667890);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0007FC68 File Offset: 0x0007DE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26998, RefRangeEnd = 26999, XrefRangeStart = 26989, XrefRangeEnd = 26998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector2Int(Vector2Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr__ctor_Private_Void_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0007FC9C File Offset: 0x0007DE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26999, XrefRangeEnd = 27009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector2Int(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x0007FCDC File Offset: 0x0007DEDC
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x0007FD0C File Offset: 0x0007DF0C
		public unsafe int x
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27015, RefRangeEnd = 27016, XrefRangeStart = 27009, XrefRangeEnd = 27015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27016, XrefRangeEnd = 27018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0007FD40 File Offset: 0x0007DF40
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x0007FD70 File Offset: 0x0007DF70
		public unsafe int y
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27024, RefRangeEnd = 27025, XrefRangeStart = 27018, XrefRangeEnd = 27024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27025, XrefRangeEnd = 27027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000585 RID: 1413
		public unsafe int this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27027, XrefRangeEnd = 27035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27035, XrefRangeEnd = 27038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0007FE24 File Offset: 0x0007E024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27038, XrefRangeEnd = 27042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(int newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0007FE58 File Offset: 0x0007E058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27050, RefRangeEnd = 27051, XrefRangeStart = 27042, XrefRangeEnd = 27050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(Vector2Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0007FE98 File Offset: 0x0007E098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 27055, RefRangeEnd = 27057, XrefRangeStart = 27051, XrefRangeEnd = 27055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(Vector2Int value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Vector2Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0007FEE4 File Offset: 0x0007E0E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27066, RefRangeEnd = 27069, XrefRangeStart = 27057, XrefRangeEnd = 27066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(int x, int y, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0007FF40 File Offset: 0x0007E140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27069, XrefRangeEnd = 27090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int Decrypt(ObscuredVector2Int.RawEncryptedVector2Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2Int_RawEncryptedVector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0007FF80 File Offset: 0x0007E180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27090, XrefRangeEnd = 27099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int Decrypt(ObscuredVector2Int.RawEncryptedVector2Int value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2Int_RawEncryptedVector2Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0007FFCC File Offset: 0x0007E1CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27109, RefRangeEnd = 27110, XrefRangeStart = 27099, XrefRangeEnd = 27109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0007FFF4 File Offset: 0x0007E1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27110, XrefRangeEnd = 27117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0008001C File Offset: 0x0007E21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27117, XrefRangeEnd = 27118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector2Int.RawEncryptedVector2Int GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector2Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0008004C File Offset: 0x0007E24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27118, XrefRangeEnd = 27124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(ObscuredVector2Int.RawEncryptedVector2Int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector2Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00080080 File Offset: 0x0007E280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27124, XrefRangeEnd = 27125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_GetDecrypted_Public_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000800B0 File Offset: 0x0007E2B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 27133, RefRangeEnd = 27141, XrefRangeStart = 27125, XrefRangeEnd = 27133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_InternalDecrypt_Private_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000800E0 File Offset: 0x0007E2E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27149, RefRangeEnd = 27152, XrefRangeStart = 27141, XrefRangeEnd = 27149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalDecryptField(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_InternalDecryptField_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00080120 File Offset: 0x0007E320
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27160, RefRangeEnd = 27163, XrefRangeStart = 27152, XrefRangeEnd = 27160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalEncryptField(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00080160 File Offset: 0x0007E360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27163, XrefRangeEnd = 27164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredVector2Int(Vector2Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000801A0 File Offset: 0x0007E3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27164, XrefRangeEnd = 27165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2Int(ObscuredVector2Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2Int_ObscuredVector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000801E0 File Offset: 0x0007E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27165, XrefRangeEnd = 27166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2(ObscuredVector2Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_ObscuredVector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00080220 File Offset: 0x0007E420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27166, XrefRangeEnd = 27167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00080250 File Offset: 0x0007E450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27167, XrefRangeEnd = 27169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0000A360 File Offset: 0x00008560
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, ref this));
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0008027C File Offset: 0x0007E47C
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0000A372 File Offset: 0x00008572
		public unsafe static int cryptoKey
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector2Int.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector2Int.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00080298 File Offset: 0x0007E498
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0000A380 File Offset: 0x00008580
		public unsafe static Vector2Int zero
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector2Int.NativeFieldInfoPtr_zero, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector2Int.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Vector2Int_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Vector2Int_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Vector2Int_Int32_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2Int_Int32_Int32_Int32_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector2Int_RawEncryptedVector2Int_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector2Int_RawEncryptedVector2Int_Int32_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector2Int_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector2Int_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Vector2Int_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Vector2Int_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecryptField_Private_Int32_Int32_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Int32_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector2Int_Vector2Int_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2Int_ObscuredVector2Int_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_ObscuredVector2Int_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D6E RID: 7534
		[FieldOffset(0)]
		public int currentCryptoKey;

		// Token: 0x04001D6F RID: 7535
		[FieldOffset(4)]
		public ObscuredVector2Int.RawEncryptedVector2Int hiddenValue;

		// Token: 0x04001D70 RID: 7536
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001D71 RID: 7537
		[FieldOffset(16)]
		public Vector2Int fakeValue;

		// Token: 0x04001D72 RID: 7538
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002BF RID: 703
		[Serializable]
		[StructLayout(2)]
		public struct RawEncryptedVector2Int
		{
			// Token: 0x06002444 RID: 9284 RVA: 0x0009AAB4 File Offset: 0x00098CB4
			// Note: this type is marked as 'beforefieldinit'.
			static RawEncryptedVector2Int()
			{
				Il2CppClassPointerStore<ObscuredVector2Int.RawEncryptedVector2Int>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredVector2Int>.NativeClassPtr, "RawEncryptedVector2Int");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector2Int.RawEncryptedVector2Int>.NativeClassPtr);
				ObscuredVector2Int.RawEncryptedVector2Int.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int.RawEncryptedVector2Int>.NativeClassPtr, "x");
				ObscuredVector2Int.RawEncryptedVector2Int.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2Int.RawEncryptedVector2Int>.NativeClassPtr, "y");
			}

			// Token: 0x06002445 RID: 9285 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector2Int.RawEncryptedVector2Int>.NativeClassPtr, ref this));
			}

			// Token: 0x040022BD RID: 8893
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040022BE RID: 8894
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x040022BF RID: 8895
			[FieldOffset(0)]
			public int x;

			// Token: 0x040022C0 RID: 8896
			[FieldOffset(4)]
			public int y;
		}
	}
}
