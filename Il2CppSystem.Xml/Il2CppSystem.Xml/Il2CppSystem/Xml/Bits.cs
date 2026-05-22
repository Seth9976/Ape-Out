using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001E RID: 30
	public static class Bits : Object
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00019A40 File Offset: 0x00017C40
		// Note: this type is marked as 'beforefieldinit'.
		static Bits()
		{
			Il2CppClassPointerStore<Bits>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Bits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bits>.NativeClassPtr);
			Bits.NativeFieldInfoPtr_MASK_0101010101010101 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0101010101010101");
			Bits.NativeFieldInfoPtr_MASK_0011001100110011 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0011001100110011");
			Bits.NativeFieldInfoPtr_MASK_0000111100001111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000111100001111");
			Bits.NativeFieldInfoPtr_MASK_0000000011111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000000011111111");
			Bits.NativeFieldInfoPtr_MASK_1111111111111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_1111111111111111");
			Bits.NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663473);
			Bits.NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663474);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00019AFC File Offset: 0x00017CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389666, XrefRangeEnd = 389670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count(uint num)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bits.NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00019B3C File Offset: 0x00017D3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389678, RefRangeEnd = 389680, XrefRangeStart = 389670, XrefRangeEnd = 389678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LeastPosition(uint num)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bits.NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002B79 File Offset: 0x00000D79
		public Bits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00019B7C File Offset: 0x00017D7C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002B82 File Offset: 0x00000D82
		public unsafe static uint MASK_0101010101010101
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00019B98 File Offset: 0x00017D98
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002B90 File Offset: 0x00000D90
		public unsafe static uint MASK_0011001100110011
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00019BB4 File Offset: 0x00017DB4
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002B9E File Offset: 0x00000D9E
		public unsafe static uint MASK_0000111100001111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00019BD0 File Offset: 0x00017DD0
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002BAC File Offset: 0x00000DAC
		public unsafe static uint MASK_0000000011111111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00019BEC File Offset: 0x00017DEC
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002BBA File Offset: 0x00000DBA
		public unsafe static uint MASK_1111111111111111
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(Bits.NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bits.NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&value));
			}
		}

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0101010101010101;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0011001100110011;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0000111100001111;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_MASK_0000000011111111;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_MASK_1111111111111111;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0;
	}
}
