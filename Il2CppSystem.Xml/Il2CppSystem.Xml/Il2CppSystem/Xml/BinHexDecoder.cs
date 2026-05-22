using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001B RID: 27
	public class BinHexDecoder : IncrementalReadDecoder
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00019290 File Offset: 0x00017490
		// Note: this type is marked as 'beforefieldinit'.
		static BinHexDecoder()
		{
			Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinHexDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr);
			BinHexDecoder.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "buffer");
			BinHexDecoder.NativeFieldInfoPtr_curIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "curIndex");
			BinHexDecoder.NativeFieldInfoPtr_endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "endIndex");
			BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "hasHalfByteCached");
			BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "cachedHalfByte");
			BinHexDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663460);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663461);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663462);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663463);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00019374 File Offset: 0x00017574
		public unsafe override bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinHexDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000193BC File Offset: 0x000175BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389613, XrefRangeEnd = 389614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Decode(Il2CppStructArray<char> chars, int startPos, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinHexDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00019430 File Offset: 0x00017630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389621, RefRangeEnd = 389624, XrefRangeStart = 389614, XrefRangeEnd = 389621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Decode(Il2CppStructArray<char> chars, bool allowOddChars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOddChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexDecoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00019484 File Offset: 0x00017684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389629, RefRangeEnd = 389631, XrefRangeStart = 389624, XrefRangeEnd = 389629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pCharsEndPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytesEndPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasHalfByteCached;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cachedHalfByte;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsDecoded;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesDecoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexDecoder.NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002A7E File Offset: 0x00000C7E
		public BinHexDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00019518 File Offset: 0x00017718
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002A87 File Offset: 0x00000C87
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00019548 File Offset: 0x00017748
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002AA6 File Offset: 0x00000CA6
		public unsafe int curIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_curIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_curIndex)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00019570 File Offset: 0x00017770
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002AC1 File Offset: 0x00000CC1
		public unsafe int endIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_endIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_endIndex)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00019598 File Offset: 0x00017798
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002ADC File Offset: 0x00000CDC
		public unsafe bool hasHalfByteCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000195C0 File Offset: 0x000177C0
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public unsafe byte cachedHalfByte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte)) = value;
			}
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_curIndex;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_endIndex;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_hasHalfByteCached;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_cachedHalfByte;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0;
	}
}
