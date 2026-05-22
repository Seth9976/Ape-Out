using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Xsl.Runtime
{
	// Token: 0x020001EF RID: 495
	public sealed class StringConcat : ValueType
	{
		// Token: 0x060029BB RID: 10683 RVA: 0x000BEC98 File Offset: 0x000BCE98
		// Note: this type is marked as 'beforefieldinit'.
		static StringConcat()
		{
			Il2CppClassPointerStore<StringConcat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Xsl.Runtime", "StringConcat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringConcat>.NativeClassPtr);
			StringConcat.NativeFieldInfoPtr_s1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s1");
			StringConcat.NativeFieldInfoPtr_s2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s2");
			StringConcat.NativeFieldInfoPtr_s3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s3");
			StringConcat.NativeFieldInfoPtr_s4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s4");
			StringConcat.NativeFieldInfoPtr_delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "delimiter");
			StringConcat.NativeFieldInfoPtr_strList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "strList");
			StringConcat.NativeFieldInfoPtr_idxStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "idxStr");
			StringConcat.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100669257);
			StringConcat.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100669258);
			StringConcat.NativeMethodInfoPtr_GetResult_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100669259);
			StringConcat.NativeMethodInfoPtr_ConcatNoDelimiter_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100669260);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000BEDA4 File Offset: 0x000BCFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439360, RefRangeEnd = 439361, XrefRangeStart = 439360, XrefRangeEnd = 439360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x000BEDDC File Offset: 0x000BCFDC
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000BEE20 File Offset: 0x000BD020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439367, RefRangeEnd = 439369, XrefRangeStart = 439361, XrefRangeEnd = 439367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_GetResult_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000BEE5C File Offset: 0x000BD05C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439387, RefRangeEnd = 439388, XrefRangeStart = 439369, XrefRangeEnd = 439387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcatNoDelimiter(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_ConcatNoDelimiter_Internal_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x0001196D File Offset: 0x0000FB6D
		public StringConcat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00011976 File Offset: 0x0000FB76
		public StringConcat()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringConcat>.NativeClassPtr))
		{
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x000BEEA4 File Offset: 0x000BD0A4
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x00011988 File Offset: 0x0000FB88
		public unsafe string s1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s1);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s1), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000BEECC File Offset: 0x000BD0CC
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x000119A7 File Offset: 0x0000FBA7
		public unsafe string s2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000BEEF4 File Offset: 0x000BD0F4
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x000119C6 File Offset: 0x0000FBC6
		public unsafe string s3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s3);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s3), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000BEF1C File Offset: 0x000BD11C
		// (set) Token: 0x060029C9 RID: 10697 RVA: 0x000119E5 File Offset: 0x0000FBE5
		public unsafe string s4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s4);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s4), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x000BEF44 File Offset: 0x000BD144
		// (set) Token: 0x060029CB RID: 10699 RVA: 0x00011A04 File Offset: 0x0000FC04
		public unsafe string delimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_delimiter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_delimiter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x000BEF6C File Offset: 0x000BD16C
		// (set) Token: 0x060029CD RID: 10701 RVA: 0x00011A23 File Offset: 0x0000FC23
		public unsafe List<string> strList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_strList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_strList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x000BEF9C File Offset: 0x000BD19C
		// (set) Token: 0x060029CF RID: 10703 RVA: 0x00011A42 File Offset: 0x0000FC42
		public unsafe int idxStr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_idxStr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_idxStr)) = value;
			}
		}

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeFieldInfoPtr_s1;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeFieldInfoPtr_s2;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeFieldInfoPtr_s3;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr_s4;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeFieldInfoPtr_delimiter;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeFieldInfoPtr_strList;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeFieldInfoPtr_idxStr;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_String_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_ConcatNoDelimiter_Internal_Void_String_0;
	}
}
