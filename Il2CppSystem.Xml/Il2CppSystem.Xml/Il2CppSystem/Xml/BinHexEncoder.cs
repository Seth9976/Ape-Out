using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001C RID: 28
	public static class BinHexEncoder : Object
	{
		// Token: 0x06000185 RID: 389 RVA: 0x000195E8 File Offset: 0x000177E8
		// Note: this type is marked as 'beforefieldinit'.
		static BinHexEncoder()
		{
			Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinHexEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663464);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663465);
			BinHexEncoder.NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexEncoder>.NativeClassPtr, 100663466);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00019654 File Offset: 0x00017854
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389636, RefRangeEnd = 389639, XrefRangeStart = 389631, XrefRangeEnd = 389636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Encode(Il2CppStructArray<byte> buffer, int index, int count, XmlWriter writer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_XmlWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000196B8 File Offset: 0x000178B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389639, XrefRangeEnd = 389644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Encode(Il2CppStructArray<byte> inArray, int offsetIn, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00019710 File Offset: 0x00017910
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 389648, RefRangeEnd = 389651, XrefRangeStart = 389644, XrefRangeEnd = 389648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Encode(Il2CppStructArray<byte> inArray, int offsetIn, int count, Il2CppStructArray<char> outArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexEncoder.NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002B12 File Offset: 0x00000D12
		public BinHexEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_XmlWriter_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_0;
	}
}
