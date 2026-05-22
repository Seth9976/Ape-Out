using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200010F RID: 271
	public class CookieParser : Object
	{
		// Token: 0x06000F1C RID: 3868 RVA: 0x0004928C File Offset: 0x0004748C
		// Note: this type is marked as 'beforefieldinit'.
		static CookieParser()
		{
			Il2CppClassPointerStore<CookieParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieParser>.NativeClassPtr);
			CookieParser.NativeFieldInfoPtr_m_tokenizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, "m_tokenizer");
			CookieParser.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100665464);
			CookieParser.NativeMethodInfoPtr_Get_Internal_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100665465);
			CookieParser.NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100665466);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0004930C File Offset: 0x0004750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378622, XrefRangeEnd = 378625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieParser(string cookieString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cookieString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00049358 File Offset: 0x00047558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378688, RefRangeEnd = 378689, XrefRangeStart = 378625, XrefRangeEnd = 378688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cookie Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr_Get_Internal_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cookie>(intPtr3) : null;
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00049398 File Offset: 0x00047598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 378692, RefRangeEnd = 378693, XrefRangeStart = 378689, XrefRangeEnd = 378692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CheckQuoted(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00007F33 File Offset: 0x00006133
		public CookieParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000493D4 File Offset: 0x000475D4
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00007F3C File Offset: 0x0000613C
		public unsafe CookieTokenizer m_tokenizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieParser.NativeFieldInfoPtr_m_tokenizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieTokenizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieParser.NativeFieldInfoPtr_m_tokenizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenizer;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Cookie_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0;
	}
}
