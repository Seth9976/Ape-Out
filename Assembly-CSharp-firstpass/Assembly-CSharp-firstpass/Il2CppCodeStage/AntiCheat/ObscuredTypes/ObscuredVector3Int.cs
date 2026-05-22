using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200020A RID: 522
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredVector3Int
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x00081328 File Offset: 0x0007F528
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredVector3Int()
		{
			Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredVector3Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr);
			ObscuredVector3Int.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "cryptoKey");
			ObscuredVector3Int.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "zero");
			ObscuredVector3Int.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "currentCryptoKey");
			ObscuredVector3Int.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "hiddenValue");
			ObscuredVector3Int.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "inited");
			ObscuredVector3Int.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "fakeValue");
			ObscuredVector3Int.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "fakeValueActive");
			ObscuredVector3Int.NativeMethodInfoPtr__ctor_Private_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667940);
			ObscuredVector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667941);
			ObscuredVector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667942);
			ObscuredVector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667943);
			ObscuredVector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667944);
			ObscuredVector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667945);
			ObscuredVector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667946);
			ObscuredVector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667947);
			ObscuredVector3Int.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667948);
			ObscuredVector3Int.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667949);
			ObscuredVector3Int.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667950);
			ObscuredVector3Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667951);
			ObscuredVector3Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667952);
			ObscuredVector3Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667953);
			ObscuredVector3Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3Int_RawEncryptedVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667954);
			ObscuredVector3Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3Int_RawEncryptedVector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667955);
			ObscuredVector3Int.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667956);
			ObscuredVector3Int.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667957);
			ObscuredVector3Int.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667958);
			ObscuredVector3Int.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667959);
			ObscuredVector3Int.NativeMethodInfoPtr_GetDecrypted_Public_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667960);
			ObscuredVector3Int.NativeMethodInfoPtr_InternalDecrypt_Private_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667961);
			ObscuredVector3Int.NativeMethodInfoPtr_InternalDecryptField_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667962);
			ObscuredVector3Int.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667963);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667964);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667965);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667966);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_ObscuredVector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667967);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_Vector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667968);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667969);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_ObscuredVector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667970);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_Vector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667971);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667972);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667973);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667974);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667975);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667976);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667977);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_ObscuredVector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667978);
			ObscuredVector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667979);
			ObscuredVector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667980);
			ObscuredVector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667981);
			ObscuredVector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667982);
			ObscuredVector3Int.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, 100667983);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00081754 File Offset: 0x0007F954
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 27493, RefRangeEnd = 27501, XrefRangeStart = 27476, XrefRangeEnd = 27493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector3Int(Vector3Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr__ctor_Private_Void_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00081788 File Offset: 0x0007F988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27501, XrefRangeEnd = 27511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector3Int(int x, int y, int z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x000817D8 File Offset: 0x0007F9D8
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00081808 File Offset: 0x0007FA08
		public unsafe int x
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27517, RefRangeEnd = 27518, XrefRangeStart = 27511, XrefRangeEnd = 27517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27520, RefRangeEnd = 27521, XrefRangeStart = 27518, XrefRangeEnd = 27520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0008183C File Offset: 0x0007FA3C
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0008186C File Offset: 0x0007FA6C
		public unsafe int y
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27527, RefRangeEnd = 27528, XrefRangeStart = 27521, XrefRangeEnd = 27527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27530, RefRangeEnd = 27531, XrefRangeStart = 27528, XrefRangeEnd = 27530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000818A0 File Offset: 0x0007FAA0
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x000818D0 File Offset: 0x0007FAD0
		public unsafe int z
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27537, RefRangeEnd = 27538, XrefRangeStart = 27531, XrefRangeEnd = 27537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27540, RefRangeEnd = 27541, XrefRangeStart = 27538, XrefRangeEnd = 27540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000591 RID: 1425
		public unsafe int this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27541, XrefRangeEnd = 27550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27550, XrefRangeEnd = 27559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00081984 File Offset: 0x0007FB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27559, XrefRangeEnd = 27563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(int newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000819B8 File Offset: 0x0007FBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27563, XrefRangeEnd = 27571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(Vector3Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000819F8 File Offset: 0x0007FBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27571, XrefRangeEnd = 27575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(Vector3Int value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Vector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00081A44 File Offset: 0x0007FC44
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 27585, RefRangeEnd = 27592, XrefRangeStart = 27575, XrefRangeEnd = 27585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(int x, int y, int z, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00081AAC File Offset: 0x0007FCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27592, XrefRangeEnd = 27618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3Int Decrypt(ObscuredVector3Int.RawEncryptedVector3Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3Int_RawEncryptedVector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00081AEC File Offset: 0x0007FCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27618, XrefRangeEnd = 27628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3Int Decrypt(ObscuredVector3Int.RawEncryptedVector3Int value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3Int_RawEncryptedVector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00081B38 File Offset: 0x0007FD38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27641, RefRangeEnd = 27642, XrefRangeStart = 27628, XrefRangeEnd = 27641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00081B60 File Offset: 0x0007FD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27642, XrefRangeEnd = 27653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00081B88 File Offset: 0x0007FD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27653, XrefRangeEnd = 27654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector3Int.RawEncryptedVector3Int GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector3Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00081BB8 File Offset: 0x0007FDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27654, XrefRangeEnd = 27660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(ObscuredVector3Int.RawEncryptedVector3Int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00081BEC File Offset: 0x0007FDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27660, XrefRangeEnd = 27661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_GetDecrypted_Public_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00081C1C File Offset: 0x0007FE1C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 27681, RefRangeEnd = 27708, XrefRangeStart = 27661, XrefRangeEnd = 27681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_InternalDecrypt_Private_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00081C4C File Offset: 0x0007FE4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27716, RefRangeEnd = 27719, XrefRangeStart = 27708, XrefRangeEnd = 27716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalDecryptField(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_InternalDecryptField_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00081C8C File Offset: 0x0007FE8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27727, RefRangeEnd = 27730, XrefRangeStart = 27719, XrefRangeEnd = 27727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalEncryptField(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00081CCC File Offset: 0x0007FECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27730, XrefRangeEnd = 27731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredVector3Int(Vector3Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00081D0C File Offset: 0x0007FF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3Int(ObscuredVector3Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00081D4C File Offset: 0x0007FF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27731, XrefRangeEnd = 27732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(ObscuredVector3Int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00081D8C File Offset: 0x0007FF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27732, XrefRangeEnd = 27738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_ObscuredVector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00081DD8 File Offset: 0x0007FFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27738, XrefRangeEnd = 27743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_Vector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00081E24 File Offset: 0x00080024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27743, XrefRangeEnd = 27748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00081E70 File Offset: 0x00080070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27748, XrefRangeEnd = 27754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_ObscuredVector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00081EBC File Offset: 0x000800BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27754, XrefRangeEnd = 27759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_Vector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00081F08 File Offset: 0x00080108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27759, XrefRangeEnd = 27764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00081F54 File Offset: 0x00080154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27764, XrefRangeEnd = 27769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3Int operator *(ObscuredVector3Int a, int d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00081FA0 File Offset: 0x000801A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27769, XrefRangeEnd = 27771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00081FEC File Offset: 0x000801EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27771, XrefRangeEnd = 27772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00082038 File Offset: 0x00080238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27772, XrefRangeEnd = 27773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00082084 File Offset: 0x00080284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27773, XrefRangeEnd = 27775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000820D0 File Offset: 0x000802D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27775, XrefRangeEnd = 27776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_ObscuredVector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0008211C File Offset: 0x0008031C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27776, XrefRangeEnd = 27777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00082168 File Offset: 0x00080368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27777, XrefRangeEnd = 27780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x000821AC File Offset: 0x000803AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27780, XrefRangeEnd = 27781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000821DC File Offset: 0x000803DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27781, XrefRangeEnd = 27783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00082208 File Offset: 0x00080408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27783, XrefRangeEnd = 27785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3Int.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0000A3BC File Offset: 0x000085BC
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, ref this));
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00082244 File Offset: 0x00080444
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0000A3CE File Offset: 0x000085CE
		public unsafe static int cryptoKey
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector3Int.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector3Int.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00082260 File Offset: 0x00080460
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0000A3DC File Offset: 0x000085DC
		public unsafe static Vector3Int zero
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector3Int.NativeFieldInfoPtr_zero, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector3Int.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Vector3Int_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_get_z_Public_get_Int32_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Vector3Int_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Vector3Int_Int32_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3Int_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector3Int_RawEncryptedVector3Int_0;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector3Int_RawEncryptedVector3Int_Int32_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector3Int_0;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector3Int_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Vector3Int_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Vector3Int_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecryptField_Private_Int32_Int32_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Int32_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector3Int_Vector3Int_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector3Int_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_ObscuredVector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_Vector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Vector3Int_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_ObscuredVector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_Vector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Vector3Int_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3Int_ObscuredVector3Int_Int32_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3Int_Vector3Int_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_ObscuredVector3Int_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3Int_Vector3Int_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001DE1 RID: 7649
		[FieldOffset(0)]
		public int currentCryptoKey;

		// Token: 0x04001DE2 RID: 7650
		[FieldOffset(4)]
		public ObscuredVector3Int.RawEncryptedVector3Int hiddenValue;

		// Token: 0x04001DE3 RID: 7651
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001DE4 RID: 7652
		[FieldOffset(20)]
		public Vector3Int fakeValue;

		// Token: 0x04001DE5 RID: 7653
		[FieldOffset(32)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002C1 RID: 705
		[Serializable]
		[StructLayout(2)]
		public struct RawEncryptedVector3Int
		{
			// Token: 0x06002448 RID: 9288 RVA: 0x0009AB70 File Offset: 0x00098D70
			// Note: this type is marked as 'beforefieldinit'.
			static RawEncryptedVector3Int()
			{
				Il2CppClassPointerStore<ObscuredVector3Int.RawEncryptedVector3Int>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredVector3Int>.NativeClassPtr, "RawEncryptedVector3Int");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector3Int.RawEncryptedVector3Int>.NativeClassPtr);
				ObscuredVector3Int.RawEncryptedVector3Int.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int.RawEncryptedVector3Int>.NativeClassPtr, "x");
				ObscuredVector3Int.RawEncryptedVector3Int.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int.RawEncryptedVector3Int>.NativeClassPtr, "y");
				ObscuredVector3Int.RawEncryptedVector3Int.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3Int.RawEncryptedVector3Int>.NativeClassPtr, "z");
			}

			// Token: 0x06002449 RID: 9289 RVA: 0x0000DA14 File Offset: 0x0000BC14
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector3Int.RawEncryptedVector3Int>.NativeClassPtr, ref this));
			}

			// Token: 0x040022C7 RID: 8903
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040022C8 RID: 8904
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x040022C9 RID: 8905
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x040022CA RID: 8906
			[FieldOffset(0)]
			public int x;

			// Token: 0x040022CB RID: 8907
			[FieldOffset(4)]
			public int y;

			// Token: 0x040022CC RID: 8908
			[FieldOffset(8)]
			public int z;
		}
	}
}
