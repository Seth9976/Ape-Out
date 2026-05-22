using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000067 RID: 103
	public sealed class TMP_LinkInfo : ValueType
	{
		// Token: 0x06000C52 RID: 3154 RVA: 0x0003417C File Offset: 0x0003237C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_LinkInfo()
		{
			Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_LinkInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr);
			TMP_LinkInfo.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "textComponent");
			TMP_LinkInfo.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "hashCode");
			TMP_LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkIdFirstCharacterIndex");
			TMP_LinkInfo.NativeFieldInfoPtr_linkIdLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkIdLength");
			TMP_LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkTextfirstCharacterIndex");
			TMP_LinkInfo.NativeFieldInfoPtr_linkTextLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkTextLength");
			TMP_LinkInfo.NativeFieldInfoPtr_linkID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, "linkID");
			TMP_LinkInfo.NativeMethodInfoPtr_SetLinkID_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, 100664706);
			TMP_LinkInfo.NativeMethodInfoPtr_GetLinkText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, 100664707);
			TMP_LinkInfo.NativeMethodInfoPtr_GetLinkID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, 100664708);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00034274 File Offset: 0x00032474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464474, XrefRangeEnd = 464477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLinkID(Il2CppStructArray<char> text, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_LinkInfo.NativeMethodInfoPtr_SetLinkID_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000342D8 File Offset: 0x000324D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464477, XrefRangeEnd = 464495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLinkText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_LinkInfo.NativeMethodInfoPtr_GetLinkText_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00034314 File Offset: 0x00032514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464495, XrefRangeEnd = 464509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLinkID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_LinkInfo.NativeMethodInfoPtr_GetLinkID_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00007AF1 File Offset: 0x00005CF1
		public TMP_LinkInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00007AFA File Offset: 0x00005CFA
		public TMP_LinkInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00034350 File Offset: 0x00032550
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00007B0C File Offset: 0x00005D0C
		public unsafe TMP_Text textComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_textComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00034380 File Offset: 0x00032580
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00007B2B File Offset: 0x00005D2B
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000343A8 File Offset: 0x000325A8
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00007B46 File Offset: 0x00005D46
		public unsafe int linkIdFirstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex)) = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x000343D0 File Offset: 0x000325D0
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x00007B61 File Offset: 0x00005D61
		public unsafe int linkIdLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkIdLength)) = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x000343F8 File Offset: 0x000325F8
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x00007B7C File Offset: 0x00005D7C
		public unsafe int linkTextfirstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex)) = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00034420 File Offset: 0x00032620
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x00007B97 File Offset: 0x00005D97
		public unsafe int linkTextLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkTextLength)) = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x00034448 File Offset: 0x00032648
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00007BB2 File Offset: 0x00005DB2
		public unsafe Il2CppStructArray<char> linkID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_LinkInfo.NativeFieldInfoPtr_linkID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_textComponent;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_linkIdFirstCharacterIndex;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_linkIdLength;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_linkTextfirstCharacterIndex;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_linkTextLength;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_linkID;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_SetLinkID_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkText_Public_String_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkID_Public_String_0;
	}
}
