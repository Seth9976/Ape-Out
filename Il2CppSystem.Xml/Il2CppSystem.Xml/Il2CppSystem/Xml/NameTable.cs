using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200008F RID: 143
	public class NameTable : XmlNameTable
	{
		// Token: 0x06000E48 RID: 3656 RVA: 0x000516F0 File Offset: 0x0004F8F0
		// Note: this type is marked as 'beforefieldinit'.
		static NameTable()
		{
			Il2CppClassPointerStore<NameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "NameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameTable>.NativeClassPtr);
			NameTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "entries");
			NameTable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "count");
			NameTable.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "mask");
			NameTable.NativeFieldInfoPtr_hashCodeRandomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "hashCodeRandomizer");
			NameTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665563);
			NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665564);
			NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665565);
			NameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665566);
			NameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665567);
			NameTable.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665568);
			NameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable>.NativeClassPtr, 100665569);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000517FC File Offset: 0x0004F9FC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 399144, RefRangeEnd = 399156, XrefRangeStart = 399141, XrefRangeEnd = 399144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00051838 File Offset: 0x0004FA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399156, XrefRangeEnd = 399160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Add(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0005188C File Offset: 0x0004FA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399160, XrefRangeEnd = 399164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Add(Il2CppStructArray<char> key, int start, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000518FC File Offset: 0x0004FAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399164, XrefRangeEnd = 399167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameTable.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00051950 File Offset: 0x0004FB50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 399173, RefRangeEnd = 399175, XrefRangeStart = 399167, XrefRangeEnd = 399173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AddEntry(string str, int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000519A8 File Offset: 0x0004FBA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399182, RefRangeEnd = 399183, XrefRangeStart = 399175, XrefRangeEnd = 399182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000519DC File Offset: 0x0004FBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399183, XrefRangeEnd = 399184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TextEquals(string str1, Il2CppStructArray<char> str2, int str2Start, int str2Length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(str2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str2Start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str2Length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00006D75 File Offset: 0x00004F75
		public NameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00051A4C File Offset: 0x0004FC4C
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00006D7E File Offset: 0x00004F7E
		public unsafe Il2CppReferenceArray<NameTable.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NameTable.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00051A7C File Offset: 0x0004FC7C
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00006D9D File Offset: 0x00004F9D
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00051AA4 File Offset: 0x0004FCA4
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00051ACC File Offset: 0x0004FCCC
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00006DD3 File Offset: 0x00004FD3
		public unsafe int hashCodeRandomizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_hashCodeRandomizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.NativeFieldInfoPtr_hashCodeRandomizer)) = value;
			}
		}

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeRandomizer;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_String_String_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_String_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Private_String_String_Int32_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_TextEquals_Private_Static_Boolean_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0200021D RID: 541
		public class Entry : Object
		{
			// Token: 0x06002BA4 RID: 11172 RVA: 0x000C468C File Offset: 0x000C288C
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameTable>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr);
				NameTable.Entry.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "str");
				NameTable.Entry.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "hashCode");
				NameTable.Entry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, "next");
				NameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr, 100665570);
			}

			// Token: 0x06002BA5 RID: 11173 RVA: 0x000C4708 File Offset: 0x000C2908
			[CallerCount(0)]
			public unsafe Entry(string str, int hashCode, NameTable.Entry next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameTable.Entry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameTable.Entry.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BA6 RID: 11174 RVA: 0x00012964 File Offset: 0x00010B64
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EE4 RID: 3812
			// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x000C4774 File Offset: 0x000C2974
			// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x0001296D File Offset: 0x00010B6D
			public unsafe string str
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_str);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EE5 RID: 3813
			// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000C479C File Offset: 0x000C299C
			// (set) Token: 0x06002BAA RID: 11178 RVA: 0x0001298C File Offset: 0x00010B8C
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x17000EE6 RID: 3814
			// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000C47C4 File Offset: 0x000C29C4
			// (set) Token: 0x06002BAC RID: 11180 RVA: 0x000129A7 File Offset: 0x00010BA7
			public unsafe NameTable.Entry next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameTable.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameTable.Entry.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021DA RID: 8666
			private static readonly IntPtr NativeFieldInfoPtr_str;

			// Token: 0x040021DB RID: 8667
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x040021DC RID: 8668
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040021DD RID: 8669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Entry_0;
		}
	}
}
