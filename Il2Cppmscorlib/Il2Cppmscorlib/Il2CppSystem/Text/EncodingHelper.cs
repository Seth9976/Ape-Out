using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Text
{
	// Token: 0x0200017A RID: 378
	public static class EncodingHelper : Object
	{
		// Token: 0x06001A8B RID: 6795 RVA: 0x0009D380 File Offset: 0x0009B580
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingHelper()
		{
			Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr);
			EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "utf8EncodingWithoutMarkers");
			EncodingHelper.NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "lockobj");
			EncodingHelper.NativeFieldInfoPtr_i18nAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nAssembly");
			EncodingHelper.NativeFieldInfoPtr_i18nDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nDisabled");
			EncodingHelper.NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667853);
			EncodingHelper.NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667854);
			EncodingHelper.NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667855);
			EncodingHelper.NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667856);
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0009D450 File Offset: 0x0009B650
		public unsafe static Encoding UTF8Unmarked
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 184713, RefRangeEnd = 184716, XrefRangeStart = 184690, XrefRangeEnd = 184713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0009D484 File Offset: 0x0009B684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184716, XrefRangeEnd = 184717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalCodePage(ref int code_page)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &code_page;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0009D4BC File Offset: 0x0009B6BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184735, RefRangeEnd = 184737, XrefRangeStart = 184717, XrefRangeEnd = 184735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetDefaultEncoding()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0009D4F0 File Offset: 0x0009B6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184737, XrefRangeEnd = 184797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeI18N(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00008EC0 File Offset: 0x000070C0
		public static Object InvokeI18N(string name, params Object[] args)
		{
			return EncodingHelper.InvokeI18N(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00008ECE File Offset: 0x000070CE
		public EncodingHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0009D554 File Offset: 0x0009B754
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x00008ED7 File Offset: 0x000070D7
		public unsafe static Encoding utf8EncodingWithoutMarkers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0009D57C File Offset: 0x0009B77C
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x00008EE9 File Offset: 0x000070E9
		public unsafe static Object lockobj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_lockobj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0009D5A4 File Offset: 0x0009B7A4
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x00008EFB File Offset: 0x000070FB
		public unsafe static Assembly i18nAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_i18nAssembly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_i18nAssembly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0009D5CC File Offset: 0x0009B7CC
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x00008F0D File Offset: 0x0000710D
		public unsafe static bool i18nDisabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_i18nDisabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_i18nDisabled, (void*)(&value));
			}
		}

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeFieldInfoPtr_utf8EncodingWithoutMarkers;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeFieldInfoPtr_lockobj;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeFieldInfoPtr_i18nAssembly;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeFieldInfoPtr_i18nDisabled;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0;
	}
}
