using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000173 RID: 371
	public static class StringBuilderCache : Object
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x00098CE4 File Offset: 0x00096EE4
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilderCache()
		{
			Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "StringBuilderCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr);
			StringBuilderCache.NativeFieldInfoPtr_CachedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, "CachedInstance");
			StringBuilderCache.NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100667672);
			StringBuilderCache.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100667673);
			StringBuilderCache.NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100667674);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00098D64 File Offset: 0x00096F64
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 183039, RefRangeEnd = 183058, XrefRangeStart = 183031, XrefRangeEnd = 183039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder Acquire(int capacity = 16)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00098DA4 File Offset: 0x00096FA4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 183061, RefRangeEnd = 183079, XrefRangeStart = 183058, XrefRangeEnd = 183061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00098DDC File Offset: 0x00096FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183079, XrefRangeEnd = 183080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringAndRelease(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00008CAC File Offset: 0x00006EAC
		public StringBuilderCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00098E18 File Offset: 0x00097018
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00008CB5 File Offset: 0x00006EB5
		public unsafe static StringBuilder CachedInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilderCache.NativeFieldInfoPtr_CachedInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilderCache.NativeFieldInfoPtr_CachedInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeFieldInfoPtr_CachedInstance;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0;
	}
}
