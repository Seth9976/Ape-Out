using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F4 RID: 500
	public static class NativeTools : Object
	{
		// Token: 0x06003337 RID: 13111 RVA: 0x000FF850 File Offset: 0x000FDA50
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTools()
		{
			Il2CppClassPointerStore<NativeTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "NativeTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTools>.NativeClassPtr);
			NativeTools.NativeFieldInfoPtr_oOeeUkXormojRMMSyGdxEhuJWZm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, "oOeeUkXormojRMMSyGdxEhuJWZm");
			NativeTools.NativeMethodInfoPtr_OffsetIntPtr_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676210);
			NativeTools.NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_IntPtr_IntPtr_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676211);
			NativeTools.NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_IntPtr_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676212);
			NativeTools.NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676213);
			NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_IntPtr_Int32_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676214);
			NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_IntPtr_Int32_Int32_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676215);
			NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676216);
			NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676217);
			NativeTools.NativeMethodInfoPtr_ZeroFillMemory_Public_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676218);
			NativeTools.NativeMethodInfoPtr_DumpToString_Public_Static_String_IntPtr_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676219);
			NativeTools.NativeMethodInfoPtr_FreeHGlobalSafe_Public_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTools>.NativeClassPtr, 100676220);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x000FF970 File Offset: 0x000FDB70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339037, RefRangeEnd = 339040, XrefRangeStart = 339033, XrefRangeEnd = 339037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr OffsetIntPtr(IntPtr intPtr, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_OffsetIntPtr_Public_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000FF9BC File Offset: 0x000FDBBC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 339042, RefRangeEnd = 339051, XrefRangeStart = 339040, XrefRangeEnd = 339042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyMemory(IntPtr source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationStartIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesToCopy;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_IntPtr_IntPtr_Int32_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000FFA40 File Offset: 0x000FDC40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 339052, RefRangeEnd = 339056, XrefRangeStart = 339051, XrefRangeEnd = 339052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyMemory(Il2CppStructArray<byte> source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationStartIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesToCopy;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_IntPtr_Int32_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x000FFAC8 File Offset: 0x000FDCC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 339057, RefRangeEnd = 339064, XrefRangeStart = 339056, XrefRangeEnd = 339057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyMemory(IntPtr source, Il2CppStructArray<byte> destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationStartIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytesToCopy;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000FFB50 File Offset: 0x000FDD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339064, XrefRangeEnd = 339065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FillMemory(IntPtr buffer, int length, byte value, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_IntPtr_Int32_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x000FFBB8 File Offset: 0x000FDDB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339070, RefRangeEnd = 339073, XrefRangeStart = 339065, XrefRangeEnd = 339070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FillMemory(IntPtr buffer, int startIndex, int length, byte value, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_IntPtr_Int32_Int32_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x000FFC30 File Offset: 0x000FDE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339073, XrefRangeEnd = 339074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FillMemory(Il2CppStructArray<byte> buffer, int length, byte value, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x000FFC9C File Offset: 0x000FDE9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339074, RefRangeEnd = 339075, XrefRangeStart = 339074, XrefRangeEnd = 339074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FillMemory(Il2CppStructArray<byte> buffer, int startIndex, int length, byte value, bool throwOnError = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x000FFD18 File Offset: 0x000FDF18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 339091, RefRangeEnd = 339098, XrefRangeStart = 339075, XrefRangeEnd = 339091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroFillMemory(IntPtr buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_ZeroFillMemory_Public_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000FFD58 File Offset: 0x000FDF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339098, XrefRangeEnd = 339121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DumpToString(IntPtr buffer, int length, string stringFormat = "x2")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringFormat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_DumpToString_Public_Static_String_IntPtr_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x000FFDB0 File Offset: 0x000FDFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339121, XrefRangeEnd = 339126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeHGlobalSafe(ref IntPtr pointer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pointer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTools.NativeMethodInfoPtr_FreeHGlobalSafe_Public_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00011E0D File Offset: 0x0001000D
		public NativeTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x000FFDE4 File Offset: 0x000FDFE4
		// (set) Token: 0x06003345 RID: 13125 RVA: 0x00011E16 File Offset: 0x00010016
		public unsafe static Il2CppStructArray<byte> oOeeUkXormojRMMSyGdxEhuJWZm
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeTools.NativeFieldInfoPtr_oOeeUkXormojRMMSyGdxEhuJWZm, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeTools.NativeFieldInfoPtr_oOeeUkXormojRMMSyGdxEhuJWZm, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BAE RID: 11182
		private static readonly IntPtr NativeFieldInfoPtr_oOeeUkXormojRMMSyGdxEhuJWZm;

		// Token: 0x04002BAF RID: 11183
		private static readonly IntPtr NativeMethodInfoPtr_OffsetIntPtr_Public_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x04002BB0 RID: 11184
		private static readonly IntPtr NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_IntPtr_IntPtr_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04002BB1 RID: 11185
		private static readonly IntPtr NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_IntPtr_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04002BB2 RID: 11186
		private static readonly IntPtr NativeMethodInfoPtr_CopyMemory_Public_Static_Boolean_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04002BB3 RID: 11187
		private static readonly IntPtr NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_IntPtr_Int32_Byte_Boolean_0;

		// Token: 0x04002BB4 RID: 11188
		private static readonly IntPtr NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_IntPtr_Int32_Int32_Byte_Boolean_0;

		// Token: 0x04002BB5 RID: 11189
		private static readonly IntPtr NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Byte_Boolean_0;

		// Token: 0x04002BB6 RID: 11190
		private static readonly IntPtr NativeMethodInfoPtr_FillMemory_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Byte_Boolean_0;

		// Token: 0x04002BB7 RID: 11191
		private static readonly IntPtr NativeMethodInfoPtr_ZeroFillMemory_Public_Static_Void_IntPtr_Int32_0;

		// Token: 0x04002BB8 RID: 11192
		private static readonly IntPtr NativeMethodInfoPtr_DumpToString_Public_Static_String_IntPtr_Int32_String_0;

		// Token: 0x04002BB9 RID: 11193
		private static readonly IntPtr NativeMethodInfoPtr_FreeHGlobalSafe_Public_Static_Void_byref_IntPtr_0;
	}
}
