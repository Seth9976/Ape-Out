using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppCodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000209 RID: 521
	[Serializable]
	[StructLayout(2)]
	public struct ObscuredVector3
	{
		// Token: 0x06001C3E RID: 7230 RVA: 0x000802B4 File Offset: 0x0007E4B4
		// Note: this type is marked as 'beforefieldinit'.
		static ObscuredVector3()
		{
			Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CodeStage.AntiCheat.ObscuredTypes", "ObscuredVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr);
			ObscuredVector3.NativeFieldInfoPtr_cryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "cryptoKey");
			ObscuredVector3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "zero");
			ObscuredVector3.NativeFieldInfoPtr_currentCryptoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "currentCryptoKey");
			ObscuredVector3.NativeFieldInfoPtr_hiddenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "hiddenValue");
			ObscuredVector3.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "inited");
			ObscuredVector3.NativeFieldInfoPtr_fakeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "fakeValue");
			ObscuredVector3.NativeFieldInfoPtr_fakeValueActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "fakeValueActive");
			ObscuredVector3.NativeMethodInfoPtr__ctor_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667892);
			ObscuredVector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667893);
			ObscuredVector3.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667894);
			ObscuredVector3.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667895);
			ObscuredVector3.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667896);
			ObscuredVector3.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667897);
			ObscuredVector3.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667898);
			ObscuredVector3.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667899);
			ObscuredVector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667900);
			ObscuredVector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667901);
			ObscuredVector3.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667902);
			ObscuredVector3.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667903);
			ObscuredVector3.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667904);
			ObscuredVector3.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667905);
			ObscuredVector3.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3_RawEncryptedVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667906);
			ObscuredVector3.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3_RawEncryptedVector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667907);
			ObscuredVector3.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667908);
			ObscuredVector3.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667909);
			ObscuredVector3.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667910);
			ObscuredVector3.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667911);
			ObscuredVector3.NativeMethodInfoPtr_GetDecrypted_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667912);
			ObscuredVector3.NativeMethodInfoPtr_InternalDecrypt_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667913);
			ObscuredVector3.NativeMethodInfoPtr_CompareVectorsWithTolerance_Private_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667914);
			ObscuredVector3.NativeMethodInfoPtr_InternalDecryptField_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667915);
			ObscuredVector3.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667916);
			ObscuredVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667917);
			ObscuredVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667918);
			ObscuredVector3.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_ObscuredVector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667919);
			ObscuredVector3.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_Vector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667920);
			ObscuredVector3.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_ObscuredVector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667921);
			ObscuredVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_ObscuredVector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667922);
			ObscuredVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_Vector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667923);
			ObscuredVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_ObscuredVector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667924);
			ObscuredVector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_ObscuredVector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667925);
			ObscuredVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3_ObscuredVector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667926);
			ObscuredVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3_Single_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667927);
			ObscuredVector3.NativeMethodInfoPtr_op_Division_Public_Static_ObscuredVector3_ObscuredVector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667928);
			ObscuredVector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667929);
			ObscuredVector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667930);
			ObscuredVector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667931);
			ObscuredVector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667932);
			ObscuredVector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_ObscuredVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667933);
			ObscuredVector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667934);
			ObscuredVector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667935);
			ObscuredVector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667936);
			ObscuredVector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667937);
			ObscuredVector3.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, 100667938);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0008071C File Offset: 0x0007E91C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27186, RefRangeEnd = 27197, XrefRangeStart = 27169, XrefRangeEnd = 27186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector3(Vector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr__ctor_Private_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00080750 File Offset: 0x0007E950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27197, XrefRangeEnd = 27207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector3(float x, float y, float z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x000807A0 File Offset: 0x0007E9A0
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x000807D0 File Offset: 0x0007E9D0
		public unsafe float x
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27215, RefRangeEnd = 27216, XrefRangeStart = 27207, XrefRangeEnd = 27215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_get_x_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27218, RefRangeEnd = 27219, XrefRangeStart = 27216, XrefRangeEnd = 27218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00080804 File Offset: 0x0007EA04
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x00080834 File Offset: 0x0007EA34
		public unsafe float y
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27227, RefRangeEnd = 27228, XrefRangeStart = 27219, XrefRangeEnd = 27227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_get_y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27230, RefRangeEnd = 27231, XrefRangeStart = 27228, XrefRangeEnd = 27230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00080868 File Offset: 0x0007EA68
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x00080898 File Offset: 0x0007EA98
		public unsafe float z
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27239, RefRangeEnd = 27240, XrefRangeStart = 27231, XrefRangeEnd = 27239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_get_z_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27242, RefRangeEnd = 27243, XrefRangeStart = 27240, XrefRangeEnd = 27242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058B RID: 1419
		public unsafe float this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27243, XrefRangeEnd = 27252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27252, XrefRangeEnd = 27261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0008094C File Offset: 0x0007EB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27261, XrefRangeEnd = 27265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNewCryptoKey(int newKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newKey;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00080980 File Offset: 0x0007EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27265, XrefRangeEnd = 27273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000809C0 File Offset: 0x0007EBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27273, XrefRangeEnd = 27277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00080A0C File Offset: 0x0007EC0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 27284, RefRangeEnd = 27290, XrefRangeStart = 27277, XrefRangeEnd = 27284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3.RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Single_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00080A74 File Offset: 0x0007EC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27290, XrefRangeEnd = 27301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3_RawEncryptedVector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00080AB4 File Offset: 0x0007ECB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27301, XrefRangeEnd = 27308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_Decrypt_Public_Static_Vector3_RawEncryptedVector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00080B00 File Offset: 0x0007ED00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27321, RefRangeEnd = 27322, XrefRangeStart = 27308, XrefRangeEnd = 27321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyNewCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00080B28 File Offset: 0x0007ED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27322, XrefRangeEnd = 27333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeCryptoKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00080B50 File Offset: 0x0007ED50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27333, XrefRangeEnd = 27334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredVector3.RawEncryptedVector3 GetEncrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00080B80 File Offset: 0x0007ED80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27334, XrefRangeEnd = 27340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEncrypted(ObscuredVector3.RawEncryptedVector3 encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00080BB4 File Offset: 0x0007EDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27340, XrefRangeEnd = 27341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDecrypted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_GetDecrypted_Public_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00080BE4 File Offset: 0x0007EDE4
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 27348, RefRangeEnd = 27377, XrefRangeStart = 27341, XrefRangeEnd = 27348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InternalDecrypt()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_InternalDecrypt_Private_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00080C14 File Offset: 0x0007EE14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27386, RefRangeEnd = 27387, XrefRangeStart = 27377, XrefRangeEnd = 27386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_CompareVectorsWithTolerance_Private_Boolean_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00080C60 File Offset: 0x0007EE60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27394, RefRangeEnd = 27397, XrefRangeStart = 27387, XrefRangeEnd = 27394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float InternalDecryptField(int encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_InternalDecryptField_Private_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00080CA0 File Offset: 0x0007EEA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27404, RefRangeEnd = 27407, XrefRangeStart = 27397, XrefRangeEnd = 27404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalEncryptField(float encrypted)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encrypted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00080CE0 File Offset: 0x0007EEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27407, XrefRangeEnd = 27408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ObscuredVector3(Vector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00080D20 File Offset: 0x0007EF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(ObscuredVector3 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00080D60 File Offset: 0x0007EF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27408, XrefRangeEnd = 27414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_ObscuredVector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00080DAC File Offset: 0x0007EFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27414, XrefRangeEnd = 27419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_Vector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00080DF8 File Offset: 0x0007EFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27419, XrefRangeEnd = 27424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_ObscuredVector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00080E44 File Offset: 0x0007F044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27424, XrefRangeEnd = 27430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_ObscuredVector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00080E90 File Offset: 0x0007F090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27430, XrefRangeEnd = 27435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_Vector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00080EDC File Offset: 0x0007F0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27435, XrefRangeEnd = 27440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_ObscuredVector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00080F28 File Offset: 0x0007F128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27440, XrefRangeEnd = 27445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_ObscuredVector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00080F68 File Offset: 0x0007F168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27445, XrefRangeEnd = 27450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3_ObscuredVector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00080FB4 File Offset: 0x0007F1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27450, XrefRangeEnd = 27455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3_Single_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00081000 File Offset: 0x0007F200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27455, XrefRangeEnd = 27460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Division_Public_Static_ObscuredVector3_ObscuredVector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0008104C File Offset: 0x0007F24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27460, XrefRangeEnd = 27462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00081098 File Offset: 0x0007F298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27462, XrefRangeEnd = 27463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x000810E4 File Offset: 0x0007F2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27463, XrefRangeEnd = 27464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00081130 File Offset: 0x0007F330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27464, XrefRangeEnd = 27466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0008117C File Offset: 0x0007F37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27466, XrefRangeEnd = 27467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_ObscuredVector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x000811C8 File Offset: 0x0007F3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27467, XrefRangeEnd = 27468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00081214 File Offset: 0x0007F414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27468, XrefRangeEnd = 27471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00081258 File Offset: 0x0007F458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27471, XrefRangeEnd = 27472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00081288 File Offset: 0x0007F488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27472, XrefRangeEnd = 27474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000812B4 File Offset: 0x0007F4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27474, XrefRangeEnd = 27476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObscuredVector3.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0000A38E File Offset: 0x0000858E
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x000812F0 File Offset: 0x0007F4F0
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0000A3A0 File Offset: 0x000085A0
		public unsafe static int cryptoKey
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector3.NativeFieldInfoPtr_cryptoKey, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector3.NativeFieldInfoPtr_cryptoKey, (void*)(&value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0008130C File Offset: 0x0007F50C
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0000A3AE File Offset: 0x000085AE
		public unsafe static Vector3 zero
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(ObscuredVector3.NativeFieldInfoPtr_zero, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObscuredVector3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeFieldInfoPtr_cryptoKey;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeFieldInfoPtr_currentCryptoKey;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeFieldInfoPtr_hiddenValue;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeFieldInfoPtr_fakeValue;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeFieldInfoPtr_fakeValueActive;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Vector3_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Single_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_SetNewCryptoKey_Public_Static_Void_Int32_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Vector3_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Vector3_Int32_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Static_RawEncryptedVector3_Single_Single_Single_Int32_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector3_RawEncryptedVector3_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_Vector3_RawEncryptedVector3_Int32_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_ApplyNewCryptoKey_Public_Void_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeCryptoKey_Public_Void_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_GetEncrypted_Public_RawEncryptedVector3_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_SetEncrypted_Public_Void_RawEncryptedVector3_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_GetDecrypted_Public_Vector3_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecrypt_Private_Vector3_0;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr_CompareVectorsWithTolerance_Private_Boolean_Vector3_Vector3_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_InternalDecryptField_Private_Single_Int32_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_InternalEncryptField_Private_Int32_Single_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ObscuredVector3_Vector3_0;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_ObscuredVector3_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_ObscuredVector3_ObscuredVector3_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_Vector3_ObscuredVector3_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ObscuredVector3_ObscuredVector3_Vector3_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_ObscuredVector3_ObscuredVector3_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_Vector3_ObscuredVector3_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ObscuredVector3_ObscuredVector3_Vector3_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_ObscuredVector3_ObscuredVector3_0;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3_ObscuredVector3_Single_0;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_ObscuredVector3_Single_ObscuredVector3_0;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_ObscuredVector3_ObscuredVector3_Single_0;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3_ObscuredVector3_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_ObscuredVector3_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObscuredVector3_Vector3_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3_ObscuredVector3_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_ObscuredVector3_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObscuredVector3_Vector3_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04001DA9 RID: 7593
		[FieldOffset(0)]
		public int currentCryptoKey;

		// Token: 0x04001DAA RID: 7594
		[FieldOffset(4)]
		public ObscuredVector3.RawEncryptedVector3 hiddenValue;

		// Token: 0x04001DAB RID: 7595
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool inited;

		// Token: 0x04001DAC RID: 7596
		[FieldOffset(20)]
		public Vector3 fakeValue;

		// Token: 0x04001DAD RID: 7597
		[FieldOffset(32)]
		[MarshalAs(4)]
		public bool fakeValueActive;

		// Token: 0x020002C0 RID: 704
		[Serializable]
		[StructLayout(2)]
		public struct RawEncryptedVector3
		{
			// Token: 0x06002446 RID: 9286 RVA: 0x0009AB08 File Offset: 0x00098D08
			// Note: this type is marked as 'beforefieldinit'.
			static RawEncryptedVector3()
			{
				Il2CppClassPointerStore<ObscuredVector3.RawEncryptedVector3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObscuredVector3>.NativeClassPtr, "RawEncryptedVector3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObscuredVector3.RawEncryptedVector3>.NativeClassPtr);
				ObscuredVector3.RawEncryptedVector3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3.RawEncryptedVector3>.NativeClassPtr, "x");
				ObscuredVector3.RawEncryptedVector3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3.RawEncryptedVector3>.NativeClassPtr, "y");
				ObscuredVector3.RawEncryptedVector3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObscuredVector3.RawEncryptedVector3>.NativeClassPtr, "z");
			}

			// Token: 0x06002447 RID: 9287 RVA: 0x0000DA02 File Offset: 0x0000BC02
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredVector3.RawEncryptedVector3>.NativeClassPtr, ref this));
			}

			// Token: 0x040022C1 RID: 8897
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040022C2 RID: 8898
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x040022C3 RID: 8899
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x040022C4 RID: 8900
			[FieldOffset(0)]
			public int x;

			// Token: 0x040022C5 RID: 8901
			[FieldOffset(4)]
			public int y;

			// Token: 0x040022C6 RID: 8902
			[FieldOffset(8)]
			public int z;
		}
	}
}
