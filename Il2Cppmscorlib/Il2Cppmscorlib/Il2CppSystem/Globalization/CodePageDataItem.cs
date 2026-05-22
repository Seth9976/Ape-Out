using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024D RID: 589
	[Serializable]
	public class CodePageDataItem : Object
	{
		// Token: 0x060028A8 RID: 10408 RVA: 0x000D83D4 File Offset: 0x000D65D4
		// Note: this type is marked as 'beforefieldinit'.
		static CodePageDataItem()
		{
			Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CodePageDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr);
			CodePageDataItem.NativeFieldInfoPtr_m_dataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_dataIndex");
			CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_uiFamilyCodePage");
			CodePageDataItem.NativeFieldInfoPtr_m_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_webName");
			CodePageDataItem.NativeFieldInfoPtr_m_headerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_headerName");
			CodePageDataItem.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_flags");
			CodePageDataItem.NativeFieldInfoPtr_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "sep");
			CodePageDataItem.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669959);
			CodePageDataItem.NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669960);
			CodePageDataItem.NativeMethodInfoPtr_get_WebName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669961);
			CodePageDataItem.NativeMethodInfoPtr_get_HeaderName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100669962);
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000D84CC File Offset: 0x000D66CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198577, RefRangeEnd = 198578, XrefRangeStart = 198572, XrefRangeEnd = 198577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CodePageDataItem(int dataIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000D8514 File Offset: 0x000D6714
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 198579, RefRangeEnd = 198583, XrefRangeStart = 198578, XrefRangeEnd = 198579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateString(string pStrings, uint index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pStrings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000D8560 File Offset: 0x000D6760
		public unsafe string WebName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198583, XrefRangeEnd = 198591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_get_WebName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x000D8598 File Offset: 0x000D6798
		public unsafe string HeaderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198591, XrefRangeEnd = 198599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodePageDataItem.NativeMethodInfoPtr_get_HeaderName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0000DD25 File Offset: 0x0000BF25
		public CodePageDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x000D85D0 File Offset: 0x000D67D0
		// (set) Token: 0x060028AF RID: 10415 RVA: 0x0000DD2E File Offset: 0x0000BF2E
		public unsafe int m_dataIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_dataIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_dataIndex)) = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000D85F8 File Offset: 0x000D67F8
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x0000DD49 File Offset: 0x0000BF49
		public unsafe int m_uiFamilyCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_uiFamilyCodePage)) = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x000D8620 File Offset: 0x000D6820
		// (set) Token: 0x060028B3 RID: 10419 RVA: 0x0000DD64 File Offset: 0x0000BF64
		public unsafe string m_webName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_webName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_webName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x000D8648 File Offset: 0x000D6848
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x0000DD83 File Offset: 0x0000BF83
		public unsafe string m_headerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_headerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_headerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000D8670 File Offset: 0x000D6870
		// (set) Token: 0x060028B7 RID: 10423 RVA: 0x0000DDA2 File Offset: 0x0000BFA2
		public unsafe uint m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodePageDataItem.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000D8698 File Offset: 0x000D6898
		// (set) Token: 0x060028B9 RID: 10425 RVA: 0x0000DDBD File Offset: 0x0000BFBD
		public unsafe static Il2CppStructArray<char> sep
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CodePageDataItem.NativeFieldInfoPtr_sep, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodePageDataItem.NativeFieldInfoPtr_sep, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeFieldInfoPtr_m_dataIndex;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeFieldInfoPtr_m_uiFamilyCodePage;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeFieldInfoPtr_m_webName;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeFieldInfoPtr_m_headerName;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeFieldInfoPtr_sep;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_get_WebName_Public_get_String_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_get_HeaderName_Public_get_String_0;
	}
}
