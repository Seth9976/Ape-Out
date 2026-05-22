using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000058 RID: 88
	[StructLayout(2)]
	public struct TMP_FontStyleStack
	{
		// Token: 0x06000B66 RID: 2918 RVA: 0x0003089C File Offset: 0x0002EA9C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontStyleStack()
		{
			Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontStyleStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr);
			TMP_FontStyleStack.NativeFieldInfoPtr_bold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "bold");
			TMP_FontStyleStack.NativeFieldInfoPtr_italic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "italic");
			TMP_FontStyleStack.NativeFieldInfoPtr_underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "underline");
			TMP_FontStyleStack.NativeFieldInfoPtr_strikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "strikethrough");
			TMP_FontStyleStack.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "highlight");
			TMP_FontStyleStack.NativeFieldInfoPtr_superscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "superscript");
			TMP_FontStyleStack.NativeFieldInfoPtr_subscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "subscript");
			TMP_FontStyleStack.NativeFieldInfoPtr_uppercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "uppercase");
			TMP_FontStyleStack.NativeFieldInfoPtr_lowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "lowercase");
			TMP_FontStyleStack.NativeFieldInfoPtr_smallcaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, "smallcaps");
			TMP_FontStyleStack.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, 100664594);
			TMP_FontStyleStack.NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, 100664595);
			TMP_FontStyleStack.NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, 100664596);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000309D0 File Offset: 0x0002EBD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463476, RefRangeEnd = 463478, XrefRangeStart = 463476, XrefRangeEnd = 463476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontStyleStack.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000309F8 File Offset: 0x0002EBF8
		[CallerCount(0)]
		public unsafe byte Add(FontStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontStyleStack.NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00030A38 File Offset: 0x0002EC38
		[CallerCount(0)]
		public unsafe byte Remove(FontStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontStyleStack.NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00007605 File Offset: 0x00005805
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_FontStyleStack>.NativeClassPtr, ref this));
		}

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_bold;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_italic;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_underline;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_strikethrough;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_superscript;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_subscript;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_uppercase;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_lowercase;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_smallcaps;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0;

		// Token: 0x0400091C RID: 2332
		[FieldOffset(0)]
		public byte bold;

		// Token: 0x0400091D RID: 2333
		[FieldOffset(1)]
		public byte italic;

		// Token: 0x0400091E RID: 2334
		[FieldOffset(2)]
		public byte underline;

		// Token: 0x0400091F RID: 2335
		[FieldOffset(3)]
		public byte strikethrough;

		// Token: 0x04000920 RID: 2336
		[FieldOffset(4)]
		public byte highlight;

		// Token: 0x04000921 RID: 2337
		[FieldOffset(5)]
		public byte superscript;

		// Token: 0x04000922 RID: 2338
		[FieldOffset(6)]
		public byte subscript;

		// Token: 0x04000923 RID: 2339
		[FieldOffset(7)]
		public byte uppercase;

		// Token: 0x04000924 RID: 2340
		[FieldOffset(8)]
		public byte lowercase;

		// Token: 0x04000925 RID: 2341
		[FieldOffset(9)]
		public byte smallcaps;
	}
}
