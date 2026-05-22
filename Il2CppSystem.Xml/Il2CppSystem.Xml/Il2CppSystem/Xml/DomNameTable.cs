using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000068 RID: 104
	public class DomNameTable : Object
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x0004296C File Offset: 0x00040B6C
		// Note: this type is marked as 'beforefieldinit'.
		static DomNameTable()
		{
			Il2CppClassPointerStore<DomNameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "DomNameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr);
			DomNameTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "entries");
			DomNameTable.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "count");
			DomNameTable.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "mask");
			DomNameTable.NativeFieldInfoPtr_ownerDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "ownerDocument");
			DomNameTable.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, "nameTable");
			DomNameTable.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665034);
			DomNameTable.NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665035);
			DomNameTable.NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665036);
			DomNameTable.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr, 100665037);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00042A50 File Offset: 0x00040C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397263, XrefRangeEnd = 397266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DomNameTable(XmlDocument document)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DomNameTable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(document);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00042A9C File Offset: 0x00040C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397266, XrefRangeEnd = 397272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00042B24 File Offset: 0x00040D24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 397290, RefRangeEnd = 397297, XrefRangeStart = 397272, XrefRangeEnd = 397290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00042BAC File Offset: 0x00040DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397304, RefRangeEnd = 397305, XrefRangeStart = 397297, XrefRangeEnd = 397304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomNameTable.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00005E1E File Offset: 0x0000401E
		public DomNameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00042BE0 File Offset: 0x00040DE0
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00005E27 File Offset: 0x00004027
		public unsafe Il2CppReferenceArray<XmlName> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00042C10 File Offset: 0x00040E10
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00005E46 File Offset: 0x00004046
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00042C38 File Offset: 0x00040E38
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00005E61 File Offset: 0x00004061
		public unsafe int mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_mask)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00042C60 File Offset: 0x00040E60
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00005E7C File Offset: 0x0000407C
		public unsafe XmlDocument ownerDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_ownerDocument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_ownerDocument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00042C90 File Offset: 0x00040E90
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00005E9B File Offset: 0x0000409B
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DomNameTable.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr_ownerDocument;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlDocument_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;
	}
}
