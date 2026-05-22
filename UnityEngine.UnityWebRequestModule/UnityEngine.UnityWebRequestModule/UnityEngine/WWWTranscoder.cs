using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class WWWTranscoder : Object
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002D14 File Offset: 0x00000F14
		// Note: this type is marked as 'beforefieldinit'.
		static WWWTranscoder()
		{
			Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine", "WWWTranscoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr);
			WWWTranscoder.NativeFieldInfoPtr_ucHexChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "ucHexChars");
			WWWTranscoder.NativeFieldInfoPtr_lcHexChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "lcHexChars");
			WWWTranscoder.NativeFieldInfoPtr_urlEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlEscapeChar");
			WWWTranscoder.NativeFieldInfoPtr_urlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlSpace");
			WWWTranscoder.NativeFieldInfoPtr_dataSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "dataSpace");
			WWWTranscoder.NativeFieldInfoPtr_urlForbidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlForbidden");
			WWWTranscoder.NativeFieldInfoPtr_qpEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpEscapeChar");
			WWWTranscoder.NativeFieldInfoPtr_qpSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpSpace");
			WWWTranscoder.NativeFieldInfoPtr_qpForbidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpForbidden");
			WWWTranscoder.NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663308);
			WWWTranscoder.NativeMethodInfoPtr_Byte2Hex_Private_Static_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663309);
			WWWTranscoder.NativeMethodInfoPtr_DataEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663310);
			WWWTranscoder.NativeMethodInfoPtr_QPEncode_Public_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663311);
			WWWTranscoder.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663312);
			WWWTranscoder.NativeMethodInfoPtr_ByteArrayContains_Private_Static_Boolean_Il2CppStructArray_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663313);
			WWWTranscoder.NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663314);
			WWWTranscoder.NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663315);
			WWWTranscoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663316);
			WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663317);
			WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663318);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002ED4 File Offset: 0x000010D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534511, XrefRangeEnd = 534513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Hex2Byte(Il2CppStructArray<byte> b, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002F24 File Offset: 0x00001124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534516, RefRangeEnd = 534517, XrefRangeStart = 534513, XrefRangeEnd = 534516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Byte2Hex(byte b, Il2CppStructArray<byte> hexChars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Byte2Hex_Private_Static_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002F78 File Offset: 0x00001178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534522, RefRangeEnd = 534524, XrefRangeStart = 534517, XrefRangeEnd = 534522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> DataEncode(Il2CppStructArray<byte> toEncode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEncode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_DataEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002FBC File Offset: 0x000011BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534530, RefRangeEnd = 534532, XrefRangeStart = 534524, XrefRangeEnd = 534530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QPEncode(string toEncode, Encoding e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(toEncode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_QPEncode_Public_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000300C File Offset: 0x0000120C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534557, RefRangeEnd = 534559, XrefRangeStart = 534532, XrefRangeEnd = 534557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Encode(Il2CppStructArray<byte> input, byte escapeChar, Il2CppStructArray<byte> space, Il2CppStructArray<byte> forbidden, bool uppercase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escapeChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forbidden);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uppercase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003090 File Offset: 0x00001290
		[CallerCount(0)]
		public unsafe static bool ByteArrayContains(Il2CppStructArray<byte> array, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_ByteArrayContains_Private_Static_Boolean_Il2CppStructArray_1_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000030E0 File Offset: 0x000012E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534559, XrefRangeEnd = 534564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> URLDecode(Il2CppStructArray<byte> toEncode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEncode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003124 File Offset: 0x00001324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534565, RefRangeEnd = 534566, XrefRangeStart = 534564, XrefRangeEnd = 534565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ByteSubArrayEquals(Il2CppStructArray<byte> array, int index, Il2CppStructArray<byte> comperand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comperand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003188 File Offset: 0x00001388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534590, RefRangeEnd = 534592, XrefRangeStart = 534566, XrefRangeEnd = 534590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Decode(Il2CppStructArray<byte> input, byte escapeChar, Il2CppStructArray<byte> space)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escapeChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000031EC File Offset: 0x000013EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534596, RefRangeEnd = 534598, XrefRangeStart = 534592, XrefRangeEnd = 534596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SevenBitClean(string s, Encoding e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003240 File Offset: 0x00001440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534598, XrefRangeEnd = 534599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SevenBitClean(Il2CppStructArray<byte> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002165 File Offset: 0x00000365
		public WWWTranscoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003284 File Offset: 0x00001484
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000216E File Offset: 0x0000036E
		public unsafe static Il2CppStructArray<byte> ucHexChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_ucHexChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_ucHexChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000032AC File Offset: 0x000014AC
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002180 File Offset: 0x00000380
		public unsafe static Il2CppStructArray<byte> lcHexChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_lcHexChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_lcHexChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000032D4 File Offset: 0x000014D4
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002192 File Offset: 0x00000392
		public unsafe static byte urlEscapeChar
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_urlEscapeChar, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_urlEscapeChar, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000032F0 File Offset: 0x000014F0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000021A0 File Offset: 0x000003A0
		public unsafe static Il2CppStructArray<byte> urlSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_urlSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_urlSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003318 File Offset: 0x00001518
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000021B2 File Offset: 0x000003B2
		public unsafe static Il2CppStructArray<byte> dataSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_dataSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_dataSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003340 File Offset: 0x00001540
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000021C4 File Offset: 0x000003C4
		public unsafe static Il2CppStructArray<byte> urlForbidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_urlForbidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_urlForbidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003368 File Offset: 0x00001568
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000021D6 File Offset: 0x000003D6
		public unsafe static byte qpEscapeChar
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_qpEscapeChar, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_qpEscapeChar, (void*)(&value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003384 File Offset: 0x00001584
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021E4 File Offset: 0x000003E4
		public unsafe static Il2CppStructArray<byte> qpSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_qpSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_qpSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000033AC File Offset: 0x000015AC
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000021F6 File Offset: 0x000003F6
		public unsafe static Il2CppStructArray<byte> qpForbidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_qpForbidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_qpForbidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000033D4 File Offset: 0x000015D4
		public static string URLEncode(string toEncode)
		{
			return WWWTranscoder.URLEncode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000033F4 File Offset: 0x000015F4
		public static string URLEncode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace, WWWTranscoder.urlForbidden, false);
			return WWWForm.DefaultEncoding.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003438 File Offset: 0x00001638
		public static Il2CppStructArray<byte> URLEncode(Il2CppStructArray<byte> toEncode)
		{
			return WWWTranscoder.Encode(toEncode, WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace, WWWTranscoder.urlForbidden, false);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003460 File Offset: 0x00001660
		public static string DataEncode(string toEncode)
		{
			return WWWTranscoder.DataEncode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003480 File Offset: 0x00001680
		public static string DataEncode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.dataSpace, WWWTranscoder.urlForbidden, false);
			return WWWForm.DefaultEncoding.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000034C4 File Offset: 0x000016C4
		public static string QPEncode(string toEncode)
		{
			return WWWTranscoder.QPEncode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000034E4 File Offset: 0x000016E4
		public static Il2CppStructArray<byte> QPEncode(Il2CppStructArray<byte> toEncode)
		{
			return WWWTranscoder.Encode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace, WWWTranscoder.qpForbidden, true);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000350C File Offset: 0x0000170C
		public static string URLDecode(string toEncode)
		{
			return WWWTranscoder.URLDecode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000352C File Offset: 0x0000172C
		public static string URLDecode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Decode(WWWForm.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace);
			return e.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003568 File Offset: 0x00001768
		public static string DataDecode(string toDecode)
		{
			return WWWTranscoder.DataDecode(toDecode, Encoding.UTF8);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003588 File Offset: 0x00001788
		public static string DataDecode(string toDecode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Decode(WWWForm.DefaultEncoding.GetBytes(toDecode), WWWTranscoder.urlEscapeChar, WWWTranscoder.dataSpace);
			return e.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000035C4 File Offset: 0x000017C4
		public static Il2CppStructArray<byte> DataDecode(Il2CppStructArray<byte> toDecode)
		{
			return WWWTranscoder.Decode(toDecode, WWWTranscoder.urlEscapeChar, WWWTranscoder.dataSpace);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000035E8 File Offset: 0x000017E8
		public static string QPDecode(string toEncode)
		{
			return WWWTranscoder.QPDecode(toEncode, Encoding.UTF8);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003608 File Offset: 0x00001808
		public static string QPDecode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Decode(WWWForm.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
			return e.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003644 File Offset: 0x00001844
		public static Il2CppStructArray<byte> QPDecode(Il2CppStructArray<byte> toEncode)
		{
			return WWWTranscoder.Decode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003668 File Offset: 0x00001868
		public static bool SevenBitClean(string s)
		{
			return WWWTranscoder.SevenBitClean(s, Encoding.UTF8);
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_ucHexChars;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_lcHexChars;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_urlEscapeChar;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_urlSpace;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_dataSpace;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_urlForbidden;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_qpEscapeChar;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_qpSpace;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_qpForbidden;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Byte2Hex_Private_Static_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_DataEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_QPEncode_Public_Static_String_String_Encoding_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_ByteArrayContains_Private_Static_Boolean_Il2CppStructArray_1_Byte_Byte_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_String_Encoding_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;
	}
}
