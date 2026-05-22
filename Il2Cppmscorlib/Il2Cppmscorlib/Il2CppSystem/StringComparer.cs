using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000EB RID: 235
	[Serializable]
	public class StringComparer : Object
	{
		// Token: 0x060010C3 RID: 4291 RVA: 0x00071AA0 File Offset: 0x0006FCA0
		// Note: this type is marked as 'beforefieldinit'.
		static StringComparer()
		{
			Il2CppClassPointerStore<StringComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "StringComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringComparer>.NativeClassPtr);
			StringComparer.NativeFieldInfoPtr__invariantCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_invariantCulture");
			StringComparer.NativeFieldInfoPtr__invariantCultureIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_invariantCultureIgnoreCase");
			StringComparer.NativeFieldInfoPtr__ordinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_ordinal");
			StringComparer.NativeFieldInfoPtr__ordinalIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_ordinalIgnoreCase");
			StringComparer.NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666208);
			StringComparer.NativeMethodInfoPtr_get_CurrentCultureIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666209);
			StringComparer.NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666210);
			StringComparer.NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666211);
			StringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666212);
			StringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666213);
			StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666214);
			StringComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666215);
			StringComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666216);
			StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666217);
			StringComparer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666218);
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00071BFC File Offset: 0x0006FDFC
		public unsafe static StringComparer InvariantCultureIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167715, XrefRangeEnd = 167719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00071C30 File Offset: 0x0006FE30
		public unsafe static StringComparer CurrentCultureIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167719, XrefRangeEnd = 167728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_CurrentCultureIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x00071C64 File Offset: 0x0006FE64
		public unsafe static StringComparer Ordinal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167728, XrefRangeEnd = 167732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00071C98 File Offset: 0x0006FE98
		public unsafe static StringComparer OrdinalIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167732, XrefRangeEnd = 167736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00071CCC File Offset: 0x0006FECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167736, XrefRangeEnd = 167743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00071D2C File Offset: 0x0006FF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167743, XrefRangeEnd = 167745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00071D8C File Offset: 0x0006FF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167745, XrefRangeEnd = 167787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00071DDC File Offset: 0x0006FFDC
		[CallerCount(0)]
		public unsafe virtual int Compare(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00071E48 File Offset: 0x00070048
		[CallerCount(0)]
		public unsafe virtual bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00071EB4 File Offset: 0x000700B4
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00071F0C File Offset: 0x0007010C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00006092 File Offset: 0x00004292
		public StringComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00071F48 File Offset: 0x00070148
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x0000609B File Offset: 0x0000429B
		public unsafe static StringComparer _invariantCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__invariantCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__invariantCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00071F70 File Offset: 0x00070170
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x000060AD File Offset: 0x000042AD
		public unsafe static StringComparer _invariantCultureIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__invariantCultureIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__invariantCultureIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00071F98 File Offset: 0x00070198
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x000060BF File Offset: 0x000042BF
		public unsafe static StringComparer _ordinal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__ordinal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__ordinal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x00071FC0 File Offset: 0x000701C0
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x000060D1 File Offset: 0x000042D1
		public unsafe static StringComparer _ordinalIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__ordinalIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__ordinalIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr__invariantCulture;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr__invariantCultureIgnoreCase;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr__ordinal;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeFieldInfoPtr__ordinalIgnoreCase;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCultureIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
