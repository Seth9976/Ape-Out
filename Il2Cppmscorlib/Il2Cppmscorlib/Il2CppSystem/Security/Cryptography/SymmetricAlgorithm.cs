using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000310 RID: 784
	public class SymmetricAlgorithm : Object
	{
		// Token: 0x060033CC RID: 13260 RVA: 0x0010100C File Offset: 0x000FF20C
		// Note: this type is marked as 'beforefieldinit'.
		static SymmetricAlgorithm()
		{
			Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SymmetricAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr);
			SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "BlockSizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "FeedbackSizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_IVValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "IVValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "KeyValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "LegalBlockSizesValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "LegalKeySizesValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "KeySizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "ModeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "PaddingValue");
			SymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671409);
			SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671410);
			SymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671411);
			SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671412);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671413);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671414);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671415);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671416);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671417);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671418);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671419);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671420);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671421);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671422);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671423);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671424);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671425);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671426);
			SymmetricAlgorithm.NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671427);
			SymmetricAlgorithm.NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671428);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671429);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671430);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671431);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671432);
			SymmetricAlgorithm.NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671433);
			SymmetricAlgorithm.NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671434);
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x001012F8 File Offset: 0x000FF4F8
		[CallerCount(0)]
		public unsafe SymmetricAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00101334 File Offset: 0x000FF534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211876, XrefRangeEnd = 211880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00101368 File Offset: 0x000FF568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211880, XrefRangeEnd = 211883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x0010139C File Offset: 0x000FF59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211883, XrefRangeEnd = 211887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x001013E8 File Offset: 0x000FF5E8
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x00101430 File Offset: 0x000FF630
		public unsafe virtual int BlockSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211887, XrefRangeEnd = 211891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x0010147C File Offset: 0x000FF67C
		public unsafe virtual int FeedbackSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x001014C4 File Offset: 0x000FF6C4
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x00101510 File Offset: 0x000FF710
		public unsafe virtual Il2CppStructArray<byte> IV
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211891, XrefRangeEnd = 211894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211894, XrefRangeEnd = 211913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x00101560 File Offset: 0x000FF760
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x001015AC File Offset: 0x000FF7AC
		public unsafe virtual Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211913, XrefRangeEnd = 211916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211916, XrefRangeEnd = 211922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x001015FC File Offset: 0x000FF7FC
		public unsafe virtual Il2CppReferenceArray<KeySizes> LegalKeySizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211922, XrefRangeEnd = 211925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x00101648 File Offset: 0x000FF848
		// (set) Token: 0x060033DA RID: 13274 RVA: 0x00101690 File Offset: 0x000FF890
		public unsafe virtual int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 211926, RefRangeEnd = 211928, XrefRangeStart = 211925, XrefRangeEnd = 211926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x001016DC File Offset: 0x000FF8DC
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x00101724 File Offset: 0x000FF924
		public unsafe virtual CipherMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x00101770 File Offset: 0x000FF970
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x001017B8 File Offset: 0x000FF9B8
		public unsafe virtual PaddingMode Padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00101804 File Offset: 0x000FFA04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 211930, RefRangeEnd = 211937, XrefRangeStart = 211928, XrefRangeEnd = 211930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidKeySize(int bitLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00101850 File Offset: 0x000FFA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211937, XrefRangeEnd = 211940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SymmetricAlgorithm Create(string algName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00101894 File Offset: 0x000FFA94
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateEncryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x001018E0 File Offset: 0x000FFAE0
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateEncryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00101950 File Offset: 0x000FFB50
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateDecryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x0010199C File Offset: 0x000FFB9C
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateDecryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00101A0C File Offset: 0x000FFC0C
		[CallerCount(0)]
		public unsafe virtual void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00101A48 File Offset: 0x000FFC48
		[CallerCount(0)]
		public unsafe virtual void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00012481 File Offset: 0x00010681
		public SymmetricAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x00101A84 File Offset: 0x000FFC84
		// (set) Token: 0x060033E9 RID: 13289 RVA: 0x0001248A File Offset: 0x0001068A
		public unsafe int BlockSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue)) = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x00101AAC File Offset: 0x000FFCAC
		// (set) Token: 0x060033EB RID: 13291 RVA: 0x000124A5 File Offset: 0x000106A5
		public unsafe int FeedbackSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue)) = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x00101AD4 File Offset: 0x000FFCD4
		// (set) Token: 0x060033ED RID: 13293 RVA: 0x000124C0 File Offset: 0x000106C0
		public unsafe Il2CppStructArray<byte> IVValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_IVValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_IVValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x00101B04 File Offset: 0x000FFD04
		// (set) Token: 0x060033EF RID: 13295 RVA: 0x000124DF File Offset: 0x000106DF
		public unsafe Il2CppStructArray<byte> KeyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x00101B34 File Offset: 0x000FFD34
		// (set) Token: 0x060033F1 RID: 13297 RVA: 0x000124FE File Offset: 0x000106FE
		public unsafe Il2CppReferenceArray<KeySizes> LegalBlockSizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060033F2 RID: 13298 RVA: 0x00101B64 File Offset: 0x000FFD64
		// (set) Token: 0x060033F3 RID: 13299 RVA: 0x0001251D File Offset: 0x0001071D
		public unsafe Il2CppReferenceArray<KeySizes> LegalKeySizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060033F4 RID: 13300 RVA: 0x00101B94 File Offset: 0x000FFD94
		// (set) Token: 0x060033F5 RID: 13301 RVA: 0x0001253C File Offset: 0x0001073C
		public unsafe int KeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue)) = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x00101BBC File Offset: 0x000FFDBC
		// (set) Token: 0x060033F7 RID: 13303 RVA: 0x00012557 File Offset: 0x00010757
		public unsafe CipherMode ModeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x00101BE4 File Offset: 0x000FFDE4
		// (set) Token: 0x060033F9 RID: 13305 RVA: 0x00012572 File Offset: 0x00010772
		public unsafe PaddingMode PaddingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue)) = value;
			}
		}

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeFieldInfoPtr_BlockSizeValue;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackSizeValue;

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeFieldInfoPtr_IVValue;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeFieldInfoPtr_KeyValue;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeFieldInfoPtr_LegalBlockSizesValue;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeFieldInfoPtr_LegalKeySizesValue;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeFieldInfoPtr_KeySizeValue;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeFieldInfoPtr_ModeValue;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeFieldInfoPtr_PaddingValue;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C23 RID: 11299
		private static readonly IntPtr NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0;

		// Token: 0x04002C24 RID: 11300
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002C25 RID: 11301
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04002C26 RID: 11302
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0;

		// Token: 0x04002C27 RID: 11303
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0;

		// Token: 0x04002C28 RID: 11304
		private static readonly IntPtr NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0;

		// Token: 0x04002C29 RID: 11305
		private static readonly IntPtr NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0;

		// Token: 0x04002C2A RID: 11306
		private static readonly IntPtr NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0;

		// Token: 0x04002C2B RID: 11307
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0;

		// Token: 0x04002C2C RID: 11308
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0;

		// Token: 0x04002C2D RID: 11309
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C2E RID: 11310
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0;

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0;
	}
}
