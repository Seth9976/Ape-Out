using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x0200001D RID: 29
	public class SortKeyBuffer : Object
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00028934 File Offset: 0x00026B34
		// Note: this type is marked as 'beforefieldinit'.
		static SortKeyBuffer()
		{
			Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "SortKeyBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr);
			SortKeyBuffer.NativeFieldInfoPtr_l1b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l1b");
			SortKeyBuffer.NativeFieldInfoPtr_l2b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l2b");
			SortKeyBuffer.NativeFieldInfoPtr_l3b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l3b");
			SortKeyBuffer.NativeFieldInfoPtr_l4sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4sb");
			SortKeyBuffer.NativeFieldInfoPtr_l4tb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4tb");
			SortKeyBuffer.NativeFieldInfoPtr_l4kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4kb");
			SortKeyBuffer.NativeFieldInfoPtr_l4wb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4wb");
			SortKeyBuffer.NativeFieldInfoPtr_l5b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l5b");
			SortKeyBuffer.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "source");
			SortKeyBuffer.NativeFieldInfoPtr_l1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l1");
			SortKeyBuffer.NativeFieldInfoPtr_l2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l2");
			SortKeyBuffer.NativeFieldInfoPtr_l3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l3");
			SortKeyBuffer.NativeFieldInfoPtr_l4s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4s");
			SortKeyBuffer.NativeFieldInfoPtr_l4t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4t");
			SortKeyBuffer.NativeFieldInfoPtr_l4k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4k");
			SortKeyBuffer.NativeFieldInfoPtr_l4w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l4w");
			SortKeyBuffer.NativeFieldInfoPtr_l5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "l5");
			SortKeyBuffer.NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "lcid");
			SortKeyBuffer.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "options");
			SortKeyBuffer.NativeFieldInfoPtr_processLevel2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "processLevel2");
			SortKeyBuffer.NativeFieldInfoPtr_frenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "frenchSort");
			SortKeyBuffer.NativeFieldInfoPtr_frenchSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, "frenchSorted");
			SortKeyBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663496);
			SortKeyBuffer.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663497);
			SortKeyBuffer.NativeMethodInfoPtr_Initialize_Internal_Void_CompareOptions_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663498);
			SortKeyBuffer.NativeMethodInfoPtr_AppendCJKExtension_Internal_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663499);
			SortKeyBuffer.NativeMethodInfoPtr_AppendKana_Internal_Void_Byte_Byte_Byte_Byte_Boolean_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663500);
			SortKeyBuffer.NativeMethodInfoPtr_AppendNormal_Internal_Void_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663501);
			SortKeyBuffer.NativeMethodInfoPtr_AppendLevel5_Private_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663502);
			SortKeyBuffer.NativeMethodInfoPtr_AppendBufferPrimitive_Private_Void_Byte_byref_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663503);
			SortKeyBuffer.NativeMethodInfoPtr_GetResultAndReset_Public_SortKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663504);
			SortKeyBuffer.NativeMethodInfoPtr_GetOptimizedLength_Private_Int32_Il2CppStructArray_1_Byte_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663505);
			SortKeyBuffer.NativeMethodInfoPtr_GetResult_Public_SortKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr, 100663506);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00028BF8 File Offset: 0x00026DF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKeyBuffer(int lcid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortKeyBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00028C40 File Offset: 0x00026E40
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00028C74 File Offset: 0x00026E74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132415, RefRangeEnd = 132417, XrefRangeStart = 132398, XrefRangeEnd = 132415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CompareOptions options, int lcid, string s, bool frenchSort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lcid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frenchSort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_Initialize_Internal_Void_CompareOptions_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00028CE0 File Offset: 0x00026EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132417, XrefRangeEnd = 132423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendCJKExtension(byte lv1msb, byte lv1lsb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lv1msb;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1lsb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendCJKExtension_Internal_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00028D2C File Offset: 0x00026F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132423, XrefRangeEnd = 132429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSmallKana;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref markType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKatakana;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHalfWidth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendKana_Internal_Void_Byte_Byte_Byte_Byte_Boolean_Byte_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00028DCC File Offset: 0x00026FCC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 132443, RefRangeEnd = 132448, XrefRangeStart = 132429, XrefRangeEnd = 132443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendNormal(byte category, byte lv1, byte lv2, byte lv3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendNormal_Internal_Void_Byte_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00028E34 File Offset: 0x00027034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132448, XrefRangeEnd = 132452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendLevel5(byte category, byte lv1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lv1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendLevel5_Private_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00028E80 File Offset: 0x00027080
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 132458, RefRangeEnd = 132479, XrefRangeStart = 132452, XrefRangeEnd = 132458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendBufferPrimitive(byte value, ref Il2CppStructArray<byte> buf, ref int bidx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bidx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_AppendBufferPrimitive_Private_Void_Byte_byref_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buf = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00028EF4 File Offset: 0x000270F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132479, XrefRangeEnd = 132480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetResultAndReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_GetResultAndReset_Public_SortKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00028F34 File Offset: 0x00027134
		[CallerCount(0)]
		public unsafe int GetOptimizedLength(Il2CppStructArray<byte> data, int len, byte defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_GetOptimizedLength_Private_Int32_Il2CppStructArray_1_Byte_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00028FA0 File Offset: 0x000271A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132499, RefRangeEnd = 132502, XrefRangeStart = 132480, XrefRangeEnd = 132499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortKeyBuffer.NativeMethodInfoPtr_GetResult_Public_SortKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000028EC File Offset: 0x00000AEC
		public SortKeyBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00028FE0 File Offset: 0x000271E0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000028F5 File Offset: 0x00000AF5
		public unsafe Il2CppStructArray<byte> l1b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00029010 File Offset: 0x00027210
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002914 File Offset: 0x00000B14
		public unsafe Il2CppStructArray<byte> l2b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00029040 File Offset: 0x00027240
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002933 File Offset: 0x00000B33
		public unsafe Il2CppStructArray<byte> l3b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00029070 File Offset: 0x00027270
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002952 File Offset: 0x00000B52
		public unsafe Il2CppStructArray<byte> l4sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000290A0 File Offset: 0x000272A0
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002971 File Offset: 0x00000B71
		public unsafe Il2CppStructArray<byte> l4tb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4tb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4tb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000290D0 File Offset: 0x000272D0
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002990 File Offset: 0x00000B90
		public unsafe Il2CppStructArray<byte> l4kb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4kb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4kb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00029100 File Offset: 0x00027300
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000029AF File Offset: 0x00000BAF
		public unsafe Il2CppStructArray<byte> l4wb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4wb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4wb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00029130 File Offset: 0x00027330
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000029CE File Offset: 0x00000BCE
		public unsafe Il2CppStructArray<byte> l5b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00029160 File Offset: 0x00027360
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000029ED File Offset: 0x00000BED
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00029188 File Offset: 0x00027388
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002A0C File Offset: 0x00000C0C
		public unsafe int l1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l1)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600019A RID: 410 RVA: 0x000291B0 File Offset: 0x000273B0
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002A27 File Offset: 0x00000C27
		public unsafe int l2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l2)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000291D8 File Offset: 0x000273D8
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002A42 File Offset: 0x00000C42
		public unsafe int l3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l3)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00029200 File Offset: 0x00027400
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002A5D File Offset: 0x00000C5D
		public unsafe int l4s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4s);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4s)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00029228 File Offset: 0x00027428
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002A78 File Offset: 0x00000C78
		public unsafe int l4t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4t);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4t)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00029250 File Offset: 0x00027450
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002A93 File Offset: 0x00000C93
		public unsafe int l4k
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4k);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4k)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00029278 File Offset: 0x00027478
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002AAE File Offset: 0x00000CAE
		public unsafe int l4w
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4w);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l4w)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000292A0 File Offset: 0x000274A0
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002AC9 File Offset: 0x00000CC9
		public unsafe int l5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_l5)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000292C8 File Offset: 0x000274C8
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002AE4 File Offset: 0x00000CE4
		public unsafe int lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_lcid)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000292F0 File Offset: 0x000274F0
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002AFF File Offset: 0x00000CFF
		public unsafe CompareOptions options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_options)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00029318 File Offset: 0x00027518
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002B1A File Offset: 0x00000D1A
		public unsafe bool processLevel2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_processLevel2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_processLevel2)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00029340 File Offset: 0x00027540
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002B35 File Offset: 0x00000D35
		public unsafe bool frenchSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSort)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00029368 File Offset: 0x00027568
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002B50 File Offset: 0x00000D50
		public unsafe bool frenchSorted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSorted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortKeyBuffer.NativeFieldInfoPtr_frenchSorted)) = value;
			}
		}

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_l1b;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_l2b;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_l3b;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_l4sb;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_l4tb;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_l4kb;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_l4wb;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_l5b;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_l1;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_l2;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_l3;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_l4s;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_l4t;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_l4k;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_l4w;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_l5;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_lcid;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_processLevel2;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_frenchSort;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_frenchSorted;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_CompareOptions_Int32_String_Boolean_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_AppendCJKExtension_Internal_Void_Byte_Byte_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_AppendKana_Internal_Void_Byte_Byte_Byte_Byte_Boolean_Byte_Boolean_Boolean_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_AppendNormal_Internal_Void_Byte_Byte_Byte_Byte_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_AppendLevel5_Private_Void_Byte_Byte_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_AppendBufferPrimitive_Private_Void_Byte_byref_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_GetResultAndReset_Public_SortKey_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_GetOptimizedLength_Private_Int32_Il2CppStructArray_1_Byte_Int32_Byte_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_SortKey_0;
	}
}
