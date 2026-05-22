using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000056 RID: 86
	public sealed class RegexPrefix : Object
	{
		// Token: 0x06000573 RID: 1395 RVA: 0x00025B10 File Offset: 0x00023D10
		// Note: this type is marked as 'beforefieldinit'.
		static RegexPrefix()
		{
			Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexPrefix");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr);
			RegexPrefix.NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "_prefix");
			RegexPrefix.NativeFieldInfoPtr__caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "_caseInsensitive");
			RegexPrefix.NativeFieldInfoPtr__empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "_empty");
			RegexPrefix.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664148);
			RegexPrefix.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664149);
			RegexPrefix.NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664150);
			RegexPrefix.NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664151);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00025BCC File Offset: 0x00023DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161220, RefRangeEnd = 161221, XrefRangeStart = 161220, XrefRangeEnd = 161221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexPrefix(string prefix, bool ci)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ci;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00025C28 File Offset: 0x00023E28
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00025C60 File Offset: 0x00023E60
		public unsafe bool CaseInsensitive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00025C9C File Offset: 0x00023E9C
		public unsafe static RegexPrefix Empty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370558, XrefRangeEnd = 370562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr3) : null;
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000040B5 File Offset: 0x000022B5
		public RegexPrefix(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00025CD0 File Offset: 0x00023ED0
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x000040BE File Offset: 0x000022BE
		public unsafe string _prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00025CF8 File Offset: 0x00023EF8
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x000040DD File Offset: 0x000022DD
		public unsafe bool _caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__caseInsensitive)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00025D20 File Offset: 0x00023F20
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x000040F8 File Offset: 0x000022F8
		public unsafe static RegexPrefix _empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexPrefix.NativeFieldInfoPtr__empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexPrefix.NativeFieldInfoPtr__empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr__prefix;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitive;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr__empty;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Internal_get_String_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0;
	}
}
