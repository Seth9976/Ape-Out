using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200038A RID: 906
	public sealed class PrimitiveArray : Object
	{
		// Token: 0x06003BFC RID: 15356 RVA: 0x0011DADC File Offset: 0x0011BCDC
		// Note: this type is marked as 'beforefieldinit'.
		static PrimitiveArray()
		{
			Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "PrimitiveArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr);
			PrimitiveArray.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "code");
			PrimitiveArray.NativeFieldInfoPtr_booleanA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "booleanA");
			PrimitiveArray.NativeFieldInfoPtr_charA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "charA");
			PrimitiveArray.NativeFieldInfoPtr_doubleA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "doubleA");
			PrimitiveArray.NativeFieldInfoPtr_int16A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int16A");
			PrimitiveArray.NativeFieldInfoPtr_int32A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int32A");
			PrimitiveArray.NativeFieldInfoPtr_int64A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int64A");
			PrimitiveArray.NativeFieldInfoPtr_sbyteA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "sbyteA");
			PrimitiveArray.NativeFieldInfoPtr_singleA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "singleA");
			PrimitiveArray.NativeFieldInfoPtr_uint16A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint16A");
			PrimitiveArray.NativeFieldInfoPtr_uint32A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint32A");
			PrimitiveArray.NativeFieldInfoPtr_uint64A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint64A");
			PrimitiveArray.NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100672242);
			PrimitiveArray.NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100672243);
			PrimitiveArray.NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100672244);
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x0011DC38 File Offset: 0x0011BE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219014, XrefRangeEnd = 219015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimitiveArray(InternalPrimitiveTypeE code, Array array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0011DC94 File Offset: 0x0011BE94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219029, RefRangeEnd = 219030, XrefRangeStart = 219015, XrefRangeEnd = 219029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(InternalPrimitiveTypeE code, Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x0011DCE4 File Offset: 0x0011BEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219038, RefRangeEnd = 219039, XrefRangeStart = 219030, XrefRangeEnd = 219038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(string value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x000164F5 File Offset: 0x000146F5
		public PrimitiveArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x0011DD34 File Offset: 0x0011BF34
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x000164FE File Offset: 0x000146FE
		public unsafe InternalPrimitiveTypeE code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_code)) = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x0011DD5C File Offset: 0x0011BF5C
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x00016519 File Offset: 0x00014719
		public unsafe Il2CppStructArray<bool> booleanA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_booleanA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_booleanA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x0011DD8C File Offset: 0x0011BF8C
		// (set) Token: 0x06003C06 RID: 15366 RVA: 0x00016538 File Offset: 0x00014738
		public unsafe Il2CppStructArray<char> charA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_charA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_charA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0011DDBC File Offset: 0x0011BFBC
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x00016557 File Offset: 0x00014757
		public unsafe Il2CppStructArray<double> doubleA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_doubleA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_doubleA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x0011DDEC File Offset: 0x0011BFEC
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x00016576 File Offset: 0x00014776
		public unsafe Il2CppStructArray<short> int16A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int16A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int16A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x0011DE1C File Offset: 0x0011C01C
		// (set) Token: 0x06003C0C RID: 15372 RVA: 0x00016595 File Offset: 0x00014795
		public unsafe Il2CppStructArray<int> int32A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int32A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int32A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x0011DE4C File Offset: 0x0011C04C
		// (set) Token: 0x06003C0E RID: 15374 RVA: 0x000165B4 File Offset: 0x000147B4
		public unsafe Il2CppStructArray<long> int64A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int64A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int64A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x0011DE7C File Offset: 0x0011C07C
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x000165D3 File Offset: 0x000147D3
		public unsafe Il2CppStructArray<sbyte> sbyteA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_sbyteA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_sbyteA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x0011DEAC File Offset: 0x0011C0AC
		// (set) Token: 0x06003C12 RID: 15378 RVA: 0x000165F2 File Offset: 0x000147F2
		public unsafe Il2CppStructArray<float> singleA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_singleA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_singleA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x0011DEDC File Offset: 0x0011C0DC
		// (set) Token: 0x06003C14 RID: 15380 RVA: 0x00016611 File Offset: 0x00014811
		public unsafe Il2CppStructArray<ushort> uint16A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint16A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint16A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x0011DF0C File Offset: 0x0011C10C
		// (set) Token: 0x06003C16 RID: 15382 RVA: 0x00016630 File Offset: 0x00014830
		public unsafe Il2CppStructArray<uint> uint32A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint32A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint32A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x0011DF3C File Offset: 0x0011C13C
		// (set) Token: 0x06003C18 RID: 15384 RVA: 0x0001664F File Offset: 0x0001484F
		public unsafe Il2CppStructArray<ulong> uint64A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint64A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint64A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeFieldInfoPtr_code;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeFieldInfoPtr_booleanA;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeFieldInfoPtr_charA;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeFieldInfoPtr_doubleA;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeFieldInfoPtr_int16A;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeFieldInfoPtr_int32A;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeFieldInfoPtr_int64A;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeFieldInfoPtr_sbyteA;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeFieldInfoPtr_singleA;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeFieldInfoPtr_uint16A;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeFieldInfoPtr_uint32A;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeFieldInfoPtr_uint64A;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0;
	}
}
