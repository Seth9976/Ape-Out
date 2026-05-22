using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000137 RID: 311
	public class ByteMatcher : Object
	{
		// Token: 0x060016B0 RID: 5808 RVA: 0x0008ACD8 File Offset: 0x00088ED8
		// Note: this type is marked as 'beforefieldinit'.
		static ByteMatcher()
		{
			Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ByteMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr);
			ByteMatcher.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, "map");
			ByteMatcher.NativeFieldInfoPtr_starts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, "starts");
			ByteMatcher.NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667180);
			ByteMatcher.NativeMethodInfoPtr_Sort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667181);
			ByteMatcher.NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667182);
			ByteMatcher.NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667183);
			ByteMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667184);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0008AD94 File Offset: 0x00088F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178405, RefRangeEnd = 178408, XrefRangeStart = 178396, XrefRangeEnd = 178405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMapping(TermInfoStrings key, Il2CppStructArray<byte> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0008ADE4 File Offset: 0x00088FE4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_Sort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0008AE18 File Offset: 0x00089018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178408, XrefRangeEnd = 178411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0008AE64 File Offset: 0x00089064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178433, RefRangeEnd = 178434, XrefRangeStart = 178411, XrefRangeEnd = 178433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoStrings Match(Il2CppStructArray<char> buffer, int offset, int length, out int used)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &used;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0008AEDC File Offset: 0x000890DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178434, XrefRangeEnd = 178441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00007D26 File Offset: 0x00005F26
		public ByteMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0008AF18 File Offset: 0x00089118
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00007D2F File Offset: 0x00005F2F
		public unsafe Hashtable map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0008AF48 File Offset: 0x00089148
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x00007D4E File Offset: 0x00005F4E
		public unsafe Hashtable starts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_starts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_starts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeFieldInfoPtr_starts;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
