using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E9 RID: 745
	public class HMAC : KeyedHashAlgorithm
	{
		// Token: 0x060031F3 RID: 12787 RVA: 0x000FA6B4 File Offset: 0x000F88B4
		// Note: this type is marked as 'beforefieldinit'.
		static HMAC()
		{
			Il2CppClassPointerStore<HMAC>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HMAC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HMAC>.NativeClassPtr);
			HMAC.NativeFieldInfoPtr_blockSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "blockSizeValue");
			HMAC.NativeFieldInfoPtr_m_hashName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hashName");
			HMAC.NativeFieldInfoPtr_m_hash1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hash1");
			HMAC.NativeFieldInfoPtr_m_hash2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hash2");
			HMAC.NativeFieldInfoPtr_m_inner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_inner");
			HMAC.NativeFieldInfoPtr_m_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_outer");
			HMAC.NativeFieldInfoPtr_m_hashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HMAC>.NativeClassPtr, "m_hashing");
			HMAC.NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671192);
			HMAC.NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671193);
			HMAC.NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671194);
			HMAC.NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671195);
			HMAC.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671196);
			HMAC.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671197);
			HMAC.NativeMethodInfoPtr_Create_Public_Static_HMAC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671198);
			HMAC.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671199);
			HMAC.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671200);
			HMAC.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671201);
			HMAC.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671202);
			HMAC.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HMAC>.NativeClassPtr, 100671203);
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x000FA860 File Offset: 0x000F8A60
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x000FA89C File Offset: 0x000F8A9C
		public unsafe int BlockSizeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x000FA8DC File Offset: 0x000F8ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210029, RefRangeEnd = 210030, XrefRangeStart = 210023, XrefRangeEnd = 210029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIOPadBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x000FA910 File Offset: 0x000F8B10
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 210039, RefRangeEnd = 210050, XrefRangeStart = 210030, XrefRangeEnd = 210039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeKey(Il2CppStructArray<byte> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x000FA954 File Offset: 0x000F8B54
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x000FA9A0 File Offset: 0x000F8BA0
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210050, XrefRangeEnd = 210053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210053, XrefRangeEnd = 210061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x000FA9F0 File Offset: 0x000F8BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210061, XrefRangeEnd = 210065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HMAC Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr_Create_Public_Static_HMAC_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HMAC>(intPtr3) : null;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x000FAA24 File Offset: 0x000F8C24
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x000FAA60 File Offset: 0x000F8C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210065, XrefRangeEnd = 210067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ib, int cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ib;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x000FAACC File Offset: 0x000F8CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210067, XrefRangeEnd = 210077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x000FAB18 File Offset: 0x000F8D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210077, XrefRangeEnd = 210085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HMAC.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x000FAB64 File Offset: 0x000F8D64
		[CallerCount(0)]
		public unsafe HMAC()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HMAC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HMAC.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x000117F4 File Offset: 0x0000F9F4
		public HMAC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x000FABA0 File Offset: 0x000F8DA0
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x000117FD File Offset: 0x0000F9FD
		public unsafe int blockSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_blockSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_blockSizeValue)) = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x000FABC8 File Offset: 0x000F8DC8
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x00011818 File Offset: 0x0000FA18
		public unsafe string m_hashName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x000FABF0 File Offset: 0x000F8DF0
		// (set) Token: 0x06003206 RID: 12806 RVA: 0x00011837 File Offset: 0x0000FA37
		public unsafe HashAlgorithm m_hash1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x000FAC20 File Offset: 0x000F8E20
		// (set) Token: 0x06003208 RID: 12808 RVA: 0x00011856 File Offset: 0x0000FA56
		public unsafe HashAlgorithm m_hash2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hash2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x000FAC50 File Offset: 0x000F8E50
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x00011875 File Offset: 0x0000FA75
		public unsafe Il2CppStructArray<byte> m_inner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_inner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_inner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600320B RID: 12811 RVA: 0x000FAC80 File Offset: 0x000F8E80
		// (set) Token: 0x0600320C RID: 12812 RVA: 0x00011894 File Offset: 0x0000FA94
		public unsafe Il2CppStructArray<byte> m_outer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_outer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_outer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x000FACB0 File Offset: 0x000F8EB0
		// (set) Token: 0x0600320E RID: 12814 RVA: 0x000118B3 File Offset: 0x0000FAB3
		public unsafe bool m_hashing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HMAC.NativeFieldInfoPtr_m_hashing)) = value;
			}
		}

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeFieldInfoPtr_blockSizeValue;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeFieldInfoPtr_m_hashName;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeFieldInfoPtr_m_hash1;

		// Token: 0x04002AE0 RID: 10976
		private static readonly IntPtr NativeFieldInfoPtr_m_hash2;

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeFieldInfoPtr_m_inner;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeFieldInfoPtr_m_outer;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeFieldInfoPtr_m_hashing;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSizeValue_Protected_get_Int32_0;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockSizeValue_Protected_set_Void_Int32_0;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIOPadBuffers_Private_Void_0;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeMethodInfoPtr_InitializeKey_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_HMAC_0;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
