using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004D RID: 77
	public sealed class CachedCodeEntry : Object
	{
		// Token: 0x0600048F RID: 1167 RVA: 0x00022A94 File Offset: 0x00020C94
		// Note: this type is marked as 'beforefieldinit'.
		static CachedCodeEntry()
		{
			Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "CachedCodeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr);
			CachedCodeEntry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_key");
			CachedCodeEntry.NativeFieldInfoPtr__code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_code");
			CachedCodeEntry.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_caps");
			CachedCodeEntry.NativeFieldInfoPtr__capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_capnames");
			CachedCodeEntry.NativeFieldInfoPtr__capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_capslist");
			CachedCodeEntry.NativeFieldInfoPtr__capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_capsize");
			CachedCodeEntry.NativeFieldInfoPtr__factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_factory");
			CachedCodeEntry.NativeFieldInfoPtr__runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_runnerref");
			CachedCodeEntry.NativeFieldInfoPtr__replref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_replref");
			CachedCodeEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_SharedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, 100664061);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00022B8C File Offset: 0x00020D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369949, RefRangeEnd = 369950, XrefRangeStart = 369949, XrefRangeEnd = 369949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedCodeEntry(string key, Hashtable capnames, Il2CppStringArray capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, SharedReference repl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capslist);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(code);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runner);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(repl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedCodeEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_SharedReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000039B2 File Offset: 0x00001BB2
		public CachedCodeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00022C58 File Offset: 0x00020E58
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x000039BB File Offset: 0x00001BBB
		public unsafe string _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00022C80 File Offset: 0x00020E80
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x000039DA File Offset: 0x00001BDA
		public unsafe RegexCode _code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__code);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__code), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00022CB0 File Offset: 0x00020EB0
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x000039F9 File Offset: 0x00001BF9
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00022CE0 File Offset: 0x00020EE0
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00003A18 File Offset: 0x00001C18
		public unsafe Hashtable _capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00022D10 File Offset: 0x00020F10
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00003A37 File Offset: 0x00001C37
		public unsafe Il2CppStringArray _capslist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capslist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00022D40 File Offset: 0x00020F40
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00003A56 File Offset: 0x00001C56
		public unsafe int _capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capsize)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00022D68 File Offset: 0x00020F68
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00003A71 File Offset: 0x00001C71
		public unsafe RegexRunnerFactory _factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunnerFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00022D98 File Offset: 0x00020F98
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00003A90 File Offset: 0x00001C90
		public unsafe ExclusiveReference _runnerref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__runnerref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__runnerref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00022DC8 File Offset: 0x00020FC8
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00003AAF File Offset: 0x00001CAF
		public unsafe SharedReference _replref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__replref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__replref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr__code;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr__capnames;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr__capslist;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr__capsize;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr__factory;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr__runnerref;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr__replref;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_SharedReference_0;
	}
}
