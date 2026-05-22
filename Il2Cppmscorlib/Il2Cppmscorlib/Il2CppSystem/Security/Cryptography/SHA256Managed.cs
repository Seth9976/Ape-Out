using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000304 RID: 772
	public class SHA256Managed : SHA256
	{
		// Token: 0x0600334D RID: 13133 RVA: 0x000FF3EC File Offset: 0x000FD5EC
		// Note: this type is marked as 'beforefieldinit'.
		static SHA256Managed()
		{
			Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA256Managed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr);
			SHA256Managed.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_buffer");
			SHA256Managed.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_count");
			SHA256Managed.NativeFieldInfoPtr__stateSHA256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_stateSHA256");
			SHA256Managed.NativeFieldInfoPtr__W = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_W");
			SHA256Managed.NativeFieldInfoPtr__K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, "_K");
			SHA256Managed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671343);
			SHA256Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671344);
			SHA256Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671345);
			SHA256Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671346);
			SHA256Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671347);
			SHA256Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671348);
			SHA256Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671349);
			SHA256Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671350);
			SHA256Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671351);
			SHA256Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671352);
			SHA256Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671353);
			SHA256Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671354);
			SHA256Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671355);
			SHA256Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671356);
			SHA256Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671357);
			SHA256Managed.NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr, 100671358);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000FF5C0 File Offset: 0x000FD7C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 211440, RefRangeEnd = 211446, XrefRangeStart = 211431, XrefRangeEnd = 211440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA256Managed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA256Managed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000FF5FC File Offset: 0x000FD7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211446, XrefRangeEnd = 211450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x000FF638 File Offset: 0x000FD838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211450, XrefRangeEnd = 211451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x000FF6A4 File Offset: 0x000FD8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211451, XrefRangeEnd = 211452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SHA256Managed.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x000FF6F0 File Offset: 0x000FD8F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211452, RefRangeEnd = 211454, XrefRangeStart = 211452, XrefRangeEnd = 211452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_InitializeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000FF724 File Offset: 0x000FD924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211479, RefRangeEnd = 211481, XrefRangeStart = 211454, XrefRangeEnd = 211479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HashData(Il2CppStructArray<byte> partIn, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partIn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000FF784 File Offset: 0x000FD984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211487, RefRangeEnd = 211488, XrefRangeStart = 211481, XrefRangeEnd = 211487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> _EndHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000FF7C4 File Offset: 0x000FD9C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211525, RefRangeEnd = 211527, XrefRangeStart = 211488, XrefRangeEnd = 211525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = expandedBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000FF810 File Offset: 0x000FDA10
		[CallerCount(0)]
		public unsafe static uint RotateRight(uint x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000FF85C File Offset: 0x000FDA5C
		[CallerCount(0)]
		public unsafe static uint Ch(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000FF8B8 File Offset: 0x000FDAB8
		[CallerCount(0)]
		public unsafe static uint Maj(uint x, uint y, uint z)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000FF914 File Offset: 0x000FDB14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211530, RefRangeEnd = 211532, XrefRangeStart = 211527, XrefRangeEnd = 211530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint sigma_0(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000FF954 File Offset: 0x000FDB54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211535, RefRangeEnd = 211537, XrefRangeStart = 211532, XrefRangeEnd = 211535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint sigma_1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000FF994 File Offset: 0x000FDB94
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 211540, RefRangeEnd = 211548, XrefRangeStart = 211537, XrefRangeEnd = 211540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Sigma_0(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000FF9D4 File Offset: 0x000FDBD4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 211551, RefRangeEnd = 211559, XrefRangeStart = 211548, XrefRangeEnd = 211551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Sigma_1(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000FFA14 File Offset: 0x000FDC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211559, XrefRangeEnd = 211564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SHA256Expand(uint* x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256Managed.NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000120BF File Offset: 0x000102BF
		public SHA256Managed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x000FFA48 File Offset: 0x000FDC48
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x000120C8 File Offset: 0x000102C8
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x000FFA78 File Offset: 0x000FDC78
		// (set) Token: 0x06003362 RID: 13154 RVA: 0x000120E7 File Offset: 0x000102E7
		public unsafe long _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x000FFAA0 File Offset: 0x000FDCA0
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x00012102 File Offset: 0x00010302
		public unsafe Il2CppStructArray<uint> _stateSHA256
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__stateSHA256);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__stateSHA256), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x000FFAD0 File Offset: 0x000FDCD0
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x00012121 File Offset: 0x00010321
		public unsafe Il2CppStructArray<uint> _W
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__W);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA256Managed.NativeFieldInfoPtr__W), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x000FFB00 File Offset: 0x000FDD00
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x00012140 File Offset: 0x00010340
		public unsafe static Il2CppStructArray<uint> _K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SHA256Managed.NativeFieldInfoPtr__K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SHA256Managed.NativeFieldInfoPtr__K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeFieldInfoPtr__stateSHA256;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeFieldInfoPtr__W;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeFieldInfoPtr__K;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeMethodInfoPtr_InitializeState_Private_Void_0;

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeMethodInfoPtr__HashData_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeMethodInfoPtr__EndHash_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeMethodInfoPtr_SHATransform_Private_Static_Void_ptr_UInt32_ptr_UInt32_ptr_Byte_0;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeMethodInfoPtr_Ch_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeMethodInfoPtr_Maj_Private_Static_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeMethodInfoPtr_sigma_0_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeMethodInfoPtr_sigma_1_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_0_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeMethodInfoPtr_Sigma_1_Private_Static_UInt32_UInt32_0;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeMethodInfoPtr_SHA256Expand_Private_Static_Void_ptr_UInt32_0;
	}
}
