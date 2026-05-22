using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000207 RID: 519
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredVector2
	{
		// Token: 0x06001BFA RID: 7162 RVA: 0x0007EFBC File Offset: 0x0007D1BC
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredVector2()
		{
			Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredVector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr);
			ObscuredVector2.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "cryptoKey");
			ObscuredVector2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "zero");
			ObscuredVector2.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "currentCryptoKey");
			ObscuredVector2.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "hiddenValue");
			ObscuredVector2.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "inited");
			ObscuredVector2.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "fakeValue");
			ObscuredVector2.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "fakeValueActive");
			ObscuredVector2.NativeMethodInfoPtr__ctor_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667834);
			ObscuredVector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667835);
			ObscuredVector2.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667836);
			ObscuredVector2.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667837);
			ObscuredVector2.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667838);
			ObscuredVector2.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667839);
			ObscuredVector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667840);
			ObscuredVector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667841);
			ObscuredVector2.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667842);
			ObscuredVector2.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667843);
			ObscuredVector2.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667844);
			ObscuredVector2.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667845);
			ObscuredVector2.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2_RawEncryptedVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667846);
			ObscuredVector2.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2_RawEncryptedVector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667847);
			ObscuredVector2.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667848);
			ObscuredVector2.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667849);
			ObscuredVector2.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667850);
			ObscuredVector2.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667851);
			ObscuredVector2.NativeMethodInfoPtr_GetDecrypted_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667852);
			ObscuredVector2.NativeMethodInfoPtr_InternalDecrypt_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667853);
			ObscuredVector2.NativeMethodInfoPtr_CompareVectorsWithTolerance_Private_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667854);
			ObscuredVector2.NativeMethodInfoPtr_InternalDecryptField_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667855);
			ObscuredVector2.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667856);
			ObscuredVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667857);
			ObscuredVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_ObscuredVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667858);
			ObscuredVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667859);
			ObscuredVector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667860);
			ObscuredVector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667861);
			ObscuredVector2.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, 100667862);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0007F2BC File Offset: 0x0007D4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26817, RefRangeEnd = 26818, XrefRangeStart = 26807, XrefRangeEnd = 26817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector2(Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr__ctor_Private_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0007F2F0 File Offset: 0x0007D4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26818, XrefRangeEnd = 26828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector2(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0007F330 File Offset: 0x0007D530
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0007F360 File Offset: 0x0007D560
		public unsafe float x
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26836, RefRangeEnd = 26837, XrefRangeStart = 26828, XrefRangeEnd = 26836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_get_x_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26837, XrefRangeEnd = 26839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x0007F394 File Offset: 0x0007D594
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x0007F3C4 File Offset: 0x0007D5C4
		public unsafe float y
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26847, RefRangeEnd = 26848, XrefRangeStart = 26839, XrefRangeEnd = 26847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_get_y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26848, XrefRangeEnd = 26850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000580 RID: 1408
		public unsafe float this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26850, XrefRangeEnd = 26858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26858, XrefRangeEnd = 26861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0007F478 File Offset: 0x0007D678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26861, XrefRangeEnd = 26865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(int newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0007F4AC File Offset: 0x0007D6AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26873, RefRangeEnd = 26874, XrefRangeStart = 26865, XrefRangeEnd = 26873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0007F4EC File Offset: 0x0007D6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26878, RefRangeEnd = 26879, XrefRangeStart = 26874, XrefRangeEnd = 26878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0007F538 File Offset: 0x0007D738
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 26886, RefRangeEnd = 26890, XrefRangeStart = 26879, XrefRangeEnd = 26886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector2.RawEncryptedVector2 Encrypt(float x, float y, int key)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0007F594 File Offset: 0x0007D794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26890, XrefRangeEnd = 26901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2_RawEncryptedVector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0007F5D4 File Offset: 0x0007D7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26901, XrefRangeEnd = 26908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_Decrypt_Public_Static_Vector2_RawEncryptedVector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0007F620 File Offset: 0x0007D820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26918, RefRangeEnd = 26919, XrefRangeStart = 26908, XrefRangeEnd = 26918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0007F648 File Offset: 0x0007D848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26919, XrefRangeEnd = 26930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0007F670 File Offset: 0x0007D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26930, XrefRangeEnd = 26931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector2.RawEncryptedVector2 GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0007F6A0 File Offset: 0x0007D8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26931, XrefRangeEnd = 26937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(ObscuredVector2.RawEncryptedVector2 encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0007F6D4 File Offset: 0x0007D8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26937, XrefRangeEnd = 26938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_GetDecrypted_Public_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0007F704 File Offset: 0x0007D904
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 26945, RefRangeEnd = 26954, XrefRangeStart = 26938, XrefRangeEnd = 26945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_InternalDecrypt_Private_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0007F734 File Offset: 0x0007D934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26960, RefRangeEnd = 26961, XrefRangeStart = 26954, XrefRangeEnd = 26960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_CompareVectorsWithTolerance_Private_Boolean_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0007F780 File Offset: 0x0007D980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26968, RefRangeEnd = 26971, XrefRangeStart = 26961, XrefRangeEnd = 26968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float InternalDecryptField(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_InternalDecryptField_Private_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0007F7C0 File Offset: 0x0007D9C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 26978, RefRangeEnd = 26981, XrefRangeStart = 26971, XrefRangeEnd = 26978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalEncryptField(float encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0007F800 File Offset: 0x0007DA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26981, XrefRangeEnd = 26982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredVector2(Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0007F840 File Offset: 0x0007DA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26982, XrefRangeEnd = 26983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2(ObscuredVector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_ObscuredVector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0007F880 File Offset: 0x0007DA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26983, XrefRangeEnd = 26984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(ObscuredVector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0007F8C0 File Offset: 0x0007DAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26984, XrefRangeEnd = 26985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0007F8F0 File Offset: 0x0007DAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26985, XrefRangeEnd = 26987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0007F91C File Offset: 0x0007DB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26987, XrefRangeEnd = 26989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector2.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0000A332 File Offset: 0x00008532
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, ref this));
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0007F958 File Offset: 0x0007DB58
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0000A344 File Offset: 0x00008544
		public unsafe static int cryptoKey
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector2.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector2.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0007F974 File Offset: 0x0007DB74
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x0000A352 File Offset: 0x00008552
		public unsafe static Vector2 zero
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector2.NativeFieldInfoPtr_zero, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Vector2_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Vector2_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Vector2_Int32_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector2_Single_Single_Int32_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector2_RawEncryptedVector2_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector2_RawEncryptedVector2_Int32_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector2_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector2_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Vector2_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Vector2_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_CompareVectorsWithTolerance_Private_Boolean_Vector2_Vector2_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecryptField_Private_Single_Int32_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Single_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector2_Vector2_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_ObscuredVector2_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector2_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001D47 RID: 7495
		[FieldOffset(0)]
		public int currentCryptoKey;

		// Token: 0x04001D48 RID: 7496
		[FieldOffset(4)]
		public ObscuredVector2.RawEncryptedVector2 hiddenValue;

		// Token: 0x04001D49 RID: 7497
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001D4A RID: 7498
		[FieldOffset(16)]
		public Vector2 fakeValue;

		// Token: 0x04001D4B RID: 7499
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002BE RID: 702
		[Serializable]
		[StructLayout(2)]
		public struct RawEncryptedVector2
		{
			// Token: 0x06002442 RID: 9282 RVA: 0x0009AA60 File Offset: 0x00098C60
			// Note: this type is marked as 'beforefieldinit'.
			static RawEncryptedVector2()
			{
				Il2CppClassPointerStore<ObscuredVector2.RawEncryptedVector2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredVector2>.NativeClassPtr, "RawEncryptedVector2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector2.RawEncryptedVector2>.NativeClassPtr);
				ObscuredVector2.RawEncryptedVector2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2.RawEncryptedVector2>.NativeClassPtr, "x");
				ObscuredVector2.RawEncryptedVector2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector2.RawEncryptedVector2>.NativeClassPtr, "y");
			}

			// Token: 0x06002443 RID: 9283 RVA: 0x0000D9DE File Offset: 0x0000BBDE
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector2.RawEncryptedVector2>.NativeClassPtr, ref this));
			}

			// Token: 0x040022B9 RID: 8889
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040022BA RID: 8890
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x040022BB RID: 8891
			[FieldOffset(0)]
			public int x;

			// Token: 0x040022BC RID: 8892
			[FieldOffset(4)]
			public int y;
		}
	}
}
