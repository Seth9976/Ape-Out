using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000255 RID: 597
	public class Bootstring : Object
	{
		// Token: 0x060029A2 RID: 10658 RVA: 0x000DB434 File Offset: 0x000D9634
		// Note: this type is marked as 'beforefieldinit'.
		static Bootstring()
		{
			Il2CppClassPointerStore<Bootstring>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Bootstring");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bootstring>.NativeClassPtr);
			Bootstring.NativeFieldInfoPtr_delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "delimiter");
			Bootstring.NativeFieldInfoPtr_base_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "base_num");
			Bootstring.NativeFieldInfoPtr_tmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "tmin");
			Bootstring.NativeFieldInfoPtr_tmax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "tmax");
			Bootstring.NativeFieldInfoPtr_skew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "skew");
			Bootstring.NativeFieldInfoPtr_damp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "damp");
			Bootstring.NativeFieldInfoPtr_initial_bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "initial_bias");
			Bootstring.NativeFieldInfoPtr_initial_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "initial_n");
			Bootstring.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100670046);
			Bootstring.NativeMethodInfoPtr_Encode_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100670047);
			Bootstring.NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100670048);
			Bootstring.NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100670049);
			Bootstring.NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100670050);
			Bootstring.NativeMethodInfoPtr_Decode_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100670051);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000DB57C File Offset: 0x000D977C
		[CallerCount(0)]
		public unsafe Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bootstring>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delimiter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tmin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tmax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skew;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damp;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialBias;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialN;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000DB628 File Offset: 0x000D9828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200060, RefRangeEnd = 200061, XrefRangeStart = 200016, XrefRangeEnd = 200060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Encode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Encode_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000DB680 File Offset: 0x000D9880
		[CallerCount(0)]
		public unsafe char EncodeDigit(int d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000DB6CC File Offset: 0x000D98CC
		[CallerCount(0)]
		public unsafe int DecodeDigit(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000DB718 File Offset: 0x000D9918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200061, XrefRangeEnd = 200062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Adapt(int delta, int numPoints, bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000DB780 File Offset: 0x000D9980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200078, RefRangeEnd = 200079, XrefRangeStart = 200062, XrefRangeEnd = 200078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Decode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Decode_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0000E48C File Offset: 0x0000C68C
		public Bootstring(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000DB7D8 File Offset: 0x000D99D8
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x0000E495 File Offset: 0x0000C695
		public unsafe char delimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_delimiter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_delimiter)) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000DB800 File Offset: 0x000D9A00
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		public unsafe int base_num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_base_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_base_num)) = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x000DB828 File Offset: 0x000D9A28
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x0000E4CB File Offset: 0x0000C6CB
		public unsafe int tmin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmin)) = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000DB850 File Offset: 0x000D9A50
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x0000E4E6 File Offset: 0x0000C6E6
		public unsafe int tmax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmax)) = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000DB878 File Offset: 0x000D9A78
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x0000E501 File Offset: 0x0000C701
		public unsafe int skew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_skew);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_skew)) = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000DB8A0 File Offset: 0x000D9AA0
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x0000E51C File Offset: 0x0000C71C
		public unsafe int damp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_damp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_damp)) = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x000DB8C8 File Offset: 0x000D9AC8
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x0000E537 File Offset: 0x0000C737
		public unsafe int initial_bias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_bias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_bias)) = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000DB8F0 File Offset: 0x000D9AF0
		// (set) Token: 0x060029B9 RID: 10681 RVA: 0x0000E552 File Offset: 0x0000C752
		public unsafe int initial_n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_n);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_n)) = value;
			}
		}

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeFieldInfoPtr_delimiter;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeFieldInfoPtr_base_num;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeFieldInfoPtr_tmin;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeFieldInfoPtr_tmax;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeFieldInfoPtr_skew;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeFieldInfoPtr_damp;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeFieldInfoPtr_initial_bias;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeFieldInfoPtr_initial_n;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_String_String_Int32_0;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_String_String_Int32_0;
	}
}
