using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000315 RID: 789
	public class DESTransform : SymmetricTransform
	{
		// Token: 0x0600342B RID: 13355 RVA: 0x001029B4 File Offset: 0x00100BB4
		// Note: this type is marked as 'beforefieldinit'.
		static DESTransform()
		{
			Il2CppClassPointerStore<DESTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DESTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DESTransform>.NativeClassPtr);
			DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "KEY_BIT_SIZE");
			DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "KEY_BYTE_SIZE");
			DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "BLOCK_BIT_SIZE");
			DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "BLOCK_BYTE_SIZE");
			DESTransform.NativeFieldInfoPtr_keySchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "keySchedule");
			DESTransform.NativeFieldInfoPtr_byteBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "byteBuff");
			DESTransform.NativeFieldInfoPtr_dwordBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "dwordBuff");
			DESTransform.NativeFieldInfoPtr_spBoxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "spBoxes");
			DESTransform.NativeFieldInfoPtr_PC1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "PC1");
			DESTransform.NativeFieldInfoPtr_leftRotTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "leftRotTotal");
			DESTransform.NativeFieldInfoPtr_PC2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "PC2");
			DESTransform.NativeFieldInfoPtr_ipTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "ipTab");
			DESTransform.NativeFieldInfoPtr_fpTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, "fpTab");
			DESTransform.NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671470);
			DESTransform.NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671471);
			DESTransform.NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671472);
			DESTransform.NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671473);
			DESTransform.NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671474);
			DESTransform.NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671475);
			DESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671476);
			DESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DESTransform>.NativeClassPtr, 100671477);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00102B88 File Offset: 0x00100D88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 212450, RefRangeEnd = 212455, XrefRangeStart = 212399, XrefRangeEnd = 212450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DESTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symmAlgo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00102C08 File Offset: 0x00100E08
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 212459, RefRangeEnd = 212491, XrefRangeStart = 212455, XrefRangeEnd = 212459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint CipherFunct(uint r, int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00102C60 File Offset: 0x00100E60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212507, RefRangeEnd = 212511, XrefRangeStart = 212491, XrefRangeEnd = 212507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Permutation(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output, Il2CppStructArray<uint> permTab, bool preSwap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(permTab);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preSwap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00102CC8 File Offset: 0x00100EC8
		[CallerCount(0)]
		public unsafe static void BSwap(Il2CppStructArray<byte> byteBuff)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteBuff);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00102D00 File Offset: 0x00100F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212536, RefRangeEnd = 212537, XrefRangeStart = 212511, XrefRangeEnd = 212536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKey(Il2CppStructArray<byte> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00102D44 File Offset: 0x00100F44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 212579, RefRangeEnd = 212585, XrefRangeStart = 212537, XrefRangeEnd = 212579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00102D98 File Offset: 0x00100F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212585, XrefRangeEnd = 212593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00102DF8 File Offset: 0x00100FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212593, XrefRangeEnd = 212605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStrongKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x000125F5 File Offset: 0x000107F5
		public DESTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06003435 RID: 13365 RVA: 0x00102E2C File Offset: 0x0010102C
		// (set) Token: 0x06003436 RID: 13366 RVA: 0x000125FE File Offset: 0x000107FE
		public unsafe static int KEY_BIT_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_KEY_BIT_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x00102E48 File Offset: 0x00101048
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x0001260C File Offset: 0x0001080C
		public unsafe static int KEY_BYTE_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_KEY_BYTE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x00102E64 File Offset: 0x00101064
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x0001261A File Offset: 0x0001081A
		public unsafe static int BLOCK_BIT_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_BLOCK_BIT_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x00102E80 File Offset: 0x00101080
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x00012628 File Offset: 0x00010828
		public unsafe static int BLOCK_BYTE_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_BLOCK_BYTE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x00102E9C File Offset: 0x0010109C
		// (set) Token: 0x0600343E RID: 13374 RVA: 0x00012636 File Offset: 0x00010836
		public unsafe Il2CppStructArray<byte> keySchedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_keySchedule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_keySchedule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x00102ECC File Offset: 0x001010CC
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x00012655 File Offset: 0x00010855
		public unsafe Il2CppStructArray<byte> byteBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_byteBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_byteBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x00102EFC File Offset: 0x001010FC
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x00012674 File Offset: 0x00010874
		public unsafe Il2CppStructArray<uint> dwordBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_dwordBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DESTransform.NativeFieldInfoPtr_dwordBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00102F2C File Offset: 0x0010112C
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x00012693 File Offset: 0x00010893
		public unsafe static Il2CppStructArray<uint> spBoxes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_spBoxes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_spBoxes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x00102F54 File Offset: 0x00101154
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x000126A5 File Offset: 0x000108A5
		public unsafe static Il2CppStructArray<byte> PC1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_PC1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_PC1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x00102F7C File Offset: 0x0010117C
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x000126B7 File Offset: 0x000108B7
		public unsafe static Il2CppStructArray<byte> leftRotTotal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_leftRotTotal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_leftRotTotal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x00102FA4 File Offset: 0x001011A4
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x000126C9 File Offset: 0x000108C9
		public unsafe static Il2CppStructArray<byte> PC2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_PC2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_PC2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x00102FCC File Offset: 0x001011CC
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x000126DB File Offset: 0x000108DB
		public unsafe static Il2CppStructArray<uint> ipTab
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_ipTab, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_ipTab, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x00102FF4 File Offset: 0x001011F4
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x000126ED File Offset: 0x000108ED
		public unsafe static Il2CppStructArray<uint> fpTab
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DESTransform.NativeFieldInfoPtr_fpTab, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DESTransform.NativeFieldInfoPtr_fpTab, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeFieldInfoPtr_KEY_BIT_SIZE;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeFieldInfoPtr_KEY_BYTE_SIZE;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeFieldInfoPtr_BLOCK_BIT_SIZE;

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeFieldInfoPtr_BLOCK_BYTE_SIZE;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeFieldInfoPtr_keySchedule;

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeFieldInfoPtr_byteBuff;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeFieldInfoPtr_dwordBuff;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeFieldInfoPtr_spBoxes;

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeFieldInfoPtr_PC1;

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeFieldInfoPtr_leftRotTotal;

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeFieldInfoPtr_PC2;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeFieldInfoPtr_ipTab;

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeFieldInfoPtr_fpTab;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeMethodInfoPtr_CipherFunct_Private_UInt32_UInt32_Int32_0;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeMethodInfoPtr_Permutation_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Boolean_0;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeMethodInfoPtr_BSwap_Private_Static_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0;
	}
}
