using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x02000104 RID: 260
	public class HeaderInfoTable : Object
	{
		// Token: 0x06000E47 RID: 3655 RVA: 0x000467BC File Offset: 0x000449BC
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderInfoTable()
		{
			Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderInfoTable");
			HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "HeaderHashTable");
			HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "UnknownHeaderInfo");
			HeaderInfoTable.NativeFieldInfoPtr_SingleParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "SingleParser");
			HeaderInfoTable.NativeFieldInfoPtr_MultiParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "MultiParser");
			HeaderInfoTable.NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665357);
			HeaderInfoTable.NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665358);
			HeaderInfoTable.NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665360);
			HeaderInfoTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665361);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00046884 File Offset: 0x00044A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378050, XrefRangeEnd = 378055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseSingleValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000468C8 File Offset: 0x00044AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378055, XrefRangeEnd = 378076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseMultiValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x1700043B RID: 1083
		public unsafe HeaderInfo this[string name]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 378082, RefRangeEnd = 378086, XrefRangeStart = 378076, XrefRangeEnd = 378082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0004695C File Offset: 0x00044B5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderInfoTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00007917 File Offset: 0x00005B17
		public HeaderInfoTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00046998 File Offset: 0x00044B98
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00007920 File Offset: 0x00005B20
		public unsafe static Hashtable HeaderHashTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x000469C0 File Offset: 0x00044BC0
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00007932 File Offset: 0x00005B32
		public unsafe static HeaderInfo UnknownHeaderInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x000469E8 File Offset: 0x00044BE8
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00007944 File Offset: 0x00005B44
		public unsafe static HeaderParser SingleParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_SingleParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_SingleParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00046A10 File Offset: 0x00044C10
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00007956 File Offset: 0x00005B56
		public unsafe static HeaderParser MultiParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_MultiParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_MultiParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_HeaderHashTable;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_UnknownHeaderInfo;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_SingleParser;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_MultiParser;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
