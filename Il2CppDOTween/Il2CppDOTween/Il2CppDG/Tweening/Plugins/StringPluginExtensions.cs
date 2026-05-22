using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppDG.Tweening.Plugins
{
	// Token: 0x0200002C RID: 44
	public static class StringPluginExtensions : Object
	{
		// Token: 0x06000325 RID: 805 RVA: 0x00016A20 File Offset: 0x00014C20
		// Note: this type is marked as 'beforefieldinit'.
		static StringPluginExtensions()
		{
			Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins", "StringPluginExtensions");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsAll");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsUppercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsUppercase");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsLowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsLowercase");
			StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsNumerals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "ScrambledCharsNumerals");
			StringPluginExtensions.NativeFieldInfoPtr__lastRndSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, "_lastRndSeed");
			StringPluginExtensions.NativeMethodInfoPtr_ScrambleChars_Internal_Static_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, 100664069);
			StringPluginExtensions.NativeMethodInfoPtr_AppendScrambledChars_Internal_Static_StringBuilder_StringBuilder_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringPluginExtensions>.NativeClassPtr, 100664070);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00016AD4 File Offset: 0x00014CD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123401, RefRangeEnd = 123403, XrefRangeStart = 123399, XrefRangeEnd = 123401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScrambleChars(this Il2CppStructArray<char> chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringPluginExtensions.NativeMethodInfoPtr_ScrambleChars_Internal_Static_Void_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00016B0C File Offset: 0x00014D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123417, RefRangeEnd = 123418, XrefRangeStart = 123403, XrefRangeEnd = 123417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, Il2CppStructArray<char> chars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringPluginExtensions.NativeMethodInfoPtr_AppendScrambledChars_Internal_Static_StringBuilder_StringBuilder_Int32_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002C79 File Offset: 0x00000E79
		public StringPluginExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00016B70 File Offset: 0x00014D70
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00002C82 File Offset: 0x00000E82
		public unsafe static Il2CppStructArray<char> ScrambledCharsAll
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsAll, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsAll, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00016B98 File Offset: 0x00014D98
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00002C94 File Offset: 0x00000E94
		public unsafe static Il2CppStructArray<char> ScrambledCharsUppercase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsUppercase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsUppercase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00016BC0 File Offset: 0x00014DC0
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public unsafe static Il2CppStructArray<char> ScrambledCharsLowercase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsLowercase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsLowercase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00016BE8 File Offset: 0x00014DE8
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00002CB8 File Offset: 0x00000EB8
		public unsafe static Il2CppStructArray<char> ScrambledCharsNumerals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsNumerals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr_ScrambledCharsNumerals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00016C10 File Offset: 0x00014E10
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00002CCA File Offset: 0x00000ECA
		public unsafe static int _lastRndSeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StringPluginExtensions.NativeFieldInfoPtr__lastRndSeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringPluginExtensions.NativeFieldInfoPtr__lastRndSeed, (void*)(&value));
			}
		}

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsAll;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsUppercase;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsLowercase;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_ScrambledCharsNumerals;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr__lastRndSeed;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_ScrambleChars_Internal_Static_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_AppendScrambledChars_Internal_Static_StringBuilder_StringBuilder_Int32_Il2CppStructArray_1_Char_0;
	}
}
