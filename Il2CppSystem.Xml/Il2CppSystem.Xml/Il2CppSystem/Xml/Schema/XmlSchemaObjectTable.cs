using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C2 RID: 450
	public class XmlSchemaObjectTable : Object
	{
		// Token: 0x060023D1 RID: 9169 RVA: 0x000A5F94 File Offset: 0x000A4194
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaObjectTable()
		{
			Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaObjectTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr);
			XmlSchemaObjectTable.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "table");
			XmlSchemaObjectTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "entries");
			XmlSchemaObjectTable.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668389);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Add_Internal_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668390);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Insert_Internal_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668391);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Replace_Internal_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668392);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668393);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Remove_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668394);
			XmlSchemaObjectTable.NativeMethodInfoPtr_FindIndexByValue_Private_Int32_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668395);
			XmlSchemaObjectTable.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668396);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Contains_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668397);
			XmlSchemaObjectTable.NativeMethodInfoPtr_get_Item_Public_get_XmlSchemaObject_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668398);
			XmlSchemaObjectTable.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668399);
			XmlSchemaObjectTable.NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668400);
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000A60DC File Offset: 0x000A42DC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 427715, RefRangeEnd = 427752, XrefRangeStart = 427700, XrefRangeEnd = 427715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObjectTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000A6118 File Offset: 0x000A4318
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 427756, RefRangeEnd = 427778, XrefRangeStart = 427752, XrefRangeEnd = 427756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(XmlQualifiedName name, XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Add_Internal_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000A616C File Offset: 0x000A436C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 427783, RefRangeEnd = 427795, XrefRangeStart = 427778, XrefRangeEnd = 427783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(XmlQualifiedName name, XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Insert_Internal_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000A61C0 File Offset: 0x000A43C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 427803, RefRangeEnd = 427808, XrefRangeStart = 427795, XrefRangeEnd = 427803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Replace(XmlQualifiedName name, XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Replace_Internal_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000A6214 File Offset: 0x000A4414
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 427813, RefRangeEnd = 427857, XrefRangeStart = 427808, XrefRangeEnd = 427813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000A6248 File Offset: 0x000A4448
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 427865, RefRangeEnd = 427869, XrefRangeStart = 427857, XrefRangeEnd = 427865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Remove_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000A628C File Offset: 0x000A448C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 427872, RefRangeEnd = 427874, XrefRangeStart = 427869, XrefRangeEnd = 427872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIndexByValue(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_FindIndexByValue_Private_Int32_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x000A62DC File Offset: 0x000A44DC
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427874, XrefRangeEnd = 427875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000A6318 File Offset: 0x000A4518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 427877, RefRangeEnd = 427878, XrefRangeStart = 427875, XrefRangeEnd = 427877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Contains_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C8B RID: 3211
		public unsafe XmlSchemaObject this[XmlQualifiedName name]
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 427880, RefRangeEnd = 427964, XrefRangeStart = 427878, XrefRangeEnd = 427880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_get_Item_Public_get_XmlSchemaObject_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x000A63B8 File Offset: 0x000A45B8
		public unsafe ICollection Values
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 427968, RefRangeEnd = 428046, XrefRangeStart = 427964, XrefRangeEnd = 427968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x000A63F8 File Offset: 0x000A45F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 428050, RefRangeEnd = 428053, XrefRangeStart = 428046, XrefRangeEnd = 428050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0000F96E File Offset: 0x0000DB6E
		public XmlSchemaObjectTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x000A6438 File Offset: 0x000A4638
		// (set) Token: 0x060023E0 RID: 9184 RVA: 0x0000F977 File Offset: 0x0000DB77
		public unsafe Dictionary<XmlQualifiedName, XmlSchemaObject> table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlSchemaObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x000A6468 File Offset: 0x000A4668
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x0000F996 File Offset: 0x0000DB96
		public unsafe List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlSchemaObjectTable.XmlSchemaObjectEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_table;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Internal_Void_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Internal_Void_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr_FindIndexByValue_Private_Int32_XmlSchemaObject_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlSchemaObject_XmlQualifiedName_0;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ICollection_0;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0;

		// Token: 0x02000244 RID: 580
		[OriginalName("System.Xml.dll", "", "EnumeratorType")]
		public enum EnumeratorType
		{
			// Token: 0x040023A4 RID: 9124
			Keys,
			// Token: 0x040023A5 RID: 9125
			Values,
			// Token: 0x040023A6 RID: 9126
			DictionaryEntry
		}

		// Token: 0x02000245 RID: 581
		public sealed class XmlSchemaObjectEntry : ValueType
		{
			// Token: 0x06002D42 RID: 11586 RVA: 0x000C8EA4 File Offset: 0x000C70A4
			// Note: this type is marked as 'beforefieldinit'.
			static XmlSchemaObjectEntry()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "XmlSchemaObjectEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr);
				XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr, "qname");
				XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_xso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr, "xso");
				XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr, 100668401);
			}

			// Token: 0x06002D43 RID: 11587 RVA: 0x000C8F0C File Offset: 0x000C710C
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 5426, RefRangeEnd = 5459, XrefRangeStart = 5426, XrefRangeEnd = 5459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlSchemaObjectEntry(XmlQualifiedName name, XmlSchemaObject value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D44 RID: 11588 RVA: 0x00013990 File Offset: 0x00011B90
			public XmlSchemaObjectEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D45 RID: 11589 RVA: 0x00013999 File Offset: 0x00011B99
			public XmlSchemaObjectEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17000F64 RID: 3940
			// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000C8F70 File Offset: 0x000C7170
			// (set) Token: 0x06002D47 RID: 11591 RVA: 0x000139AB File Offset: 0x00011BAB
			public unsafe XmlQualifiedName qname
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_qname);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F65 RID: 3941
			// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000C8FA0 File Offset: 0x000C71A0
			// (set) Token: 0x06002D49 RID: 11593 RVA: 0x000139CA File Offset: 0x00011BCA
			public unsafe XmlSchemaObject xso
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_xso);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_xso), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040023A7 RID: 9127
			private static readonly IntPtr NativeFieldInfoPtr_qname;

			// Token: 0x040023A8 RID: 9128
			private static readonly IntPtr NativeFieldInfoPtr_xso;

			// Token: 0x040023A9 RID: 9129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_XmlSchemaObject_0;
		}

		// Token: 0x02000246 RID: 582
		public class ValuesCollection : Object
		{
			// Token: 0x06002D4A RID: 11594 RVA: 0x000C8FD0 File Offset: 0x000C71D0
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesCollection()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "ValuesCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr);
				XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, "entries");
				XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, "size");
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668402);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668403);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668404);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668405);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668406);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668407);
			}

			// Token: 0x06002D4B RID: 11595 RVA: 0x000C909C File Offset: 0x000C729C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesCollection(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F68 RID: 3944
			// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000C90F8 File Offset: 0x000C72F8
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000F69 RID: 3945
			// (get) Token: 0x06002D4D RID: 11597 RVA: 0x000C9134 File Offset: 0x000C7334
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427684, XrefRangeEnd = 427688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000F6A RID: 3946
			// (get) Token: 0x06002D4E RID: 11598 RVA: 0x000C9174 File Offset: 0x000C7374
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427688, XrefRangeEnd = 427692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D4F RID: 11599 RVA: 0x000C91B0 File Offset: 0x000C73B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427692, XrefRangeEnd = 427694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D50 RID: 11600 RVA: 0x000C9200 File Offset: 0x000C7400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427694, XrefRangeEnd = 427697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D51 RID: 11601 RVA: 0x000139E9 File Offset: 0x00011BE9
			public ValuesCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F66 RID: 3942
			// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000C9240 File Offset: 0x000C7440
			// (set) Token: 0x06002D53 RID: 11603 RVA: 0x000139F2 File Offset: 0x00011BF2
			public unsafe List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_entries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlSchemaObjectTable.XmlSchemaObjectEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F67 RID: 3943
			// (get) Token: 0x06002D54 RID: 11604 RVA: 0x000C9270 File Offset: 0x000C7470
			// (set) Token: 0x06002D55 RID: 11605 RVA: 0x00013A11 File Offset: 0x00011C11
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x040023AA RID: 9130
			private static readonly IntPtr NativeFieldInfoPtr_entries;

			// Token: 0x040023AB RID: 9131
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040023AC RID: 9132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_0;

			// Token: 0x040023AD RID: 9133
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040023AE RID: 9134
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040023AF RID: 9135
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040023B0 RID: 9136
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040023B1 RID: 9137
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000247 RID: 583
		public class XSOEnumerator : Object
		{
			// Token: 0x06002D56 RID: 11606 RVA: 0x000C9298 File Offset: 0x000C7498
			// Note: this type is marked as 'beforefieldinit'.
			static XSOEnumerator()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "XSOEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr);
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "entries");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_enumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "enumType");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "currentIndex");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "size");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "currentKey");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "currentValue");
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668408);
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668409);
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668410);
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668411);
			}

			// Token: 0x06002D57 RID: 11607 RVA: 0x000C938C File Offset: 0x000C758C
			[CallerCount(0)]
			public unsafe XSOEnumerator(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enumType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F71 RID: 3953
			// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000C93F4 File Offset: 0x000C75F4
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427697, XrefRangeEnd = 427698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D59 RID: 11609 RVA: 0x000C9434 File Offset: 0x000C7634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427698, XrefRangeEnd = 427699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D5A RID: 11610 RVA: 0x000C9470 File Offset: 0x000C7670
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D5B RID: 11611 RVA: 0x00013A2C File Offset: 0x00011C2C
			public XSOEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F6B RID: 3947
			// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000C94A4 File Offset: 0x000C76A4
			// (set) Token: 0x06002D5D RID: 11613 RVA: 0x00013A35 File Offset: 0x00011C35
			public unsafe List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_entries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlSchemaObjectTable.XmlSchemaObjectEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F6C RID: 3948
			// (get) Token: 0x06002D5E RID: 11614 RVA: 0x000C94D4 File Offset: 0x000C76D4
			// (set) Token: 0x06002D5F RID: 11615 RVA: 0x00013A54 File Offset: 0x00011C54
			public unsafe XmlSchemaObjectTable.EnumeratorType enumType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_enumType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_enumType)) = value;
				}
			}

			// Token: 0x17000F6D RID: 3949
			// (get) Token: 0x06002D60 RID: 11616 RVA: 0x000C94FC File Offset: 0x000C76FC
			// (set) Token: 0x06002D61 RID: 11617 RVA: 0x00013A6F File Offset: 0x00011C6F
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x17000F6E RID: 3950
			// (get) Token: 0x06002D62 RID: 11618 RVA: 0x000C9524 File Offset: 0x000C7724
			// (set) Token: 0x06002D63 RID: 11619 RVA: 0x00013A8A File Offset: 0x00011C8A
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x17000F6F RID: 3951
			// (get) Token: 0x06002D64 RID: 11620 RVA: 0x000C954C File Offset: 0x000C774C
			// (set) Token: 0x06002D65 RID: 11621 RVA: 0x00013AA5 File Offset: 0x00011CA5
			public unsafe XmlQualifiedName currentKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F70 RID: 3952
			// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000C957C File Offset: 0x000C777C
			// (set) Token: 0x06002D67 RID: 11623 RVA: 0x00013AC4 File Offset: 0x00011CC4
			public unsafe XmlSchemaObject currentValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040023B2 RID: 9138
			private static readonly IntPtr NativeFieldInfoPtr_entries;

			// Token: 0x040023B3 RID: 9139
			private static readonly IntPtr NativeFieldInfoPtr_enumType;

			// Token: 0x040023B4 RID: 9140
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x040023B5 RID: 9141
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040023B6 RID: 9142
			private static readonly IntPtr NativeFieldInfoPtr_currentKey;

			// Token: 0x040023B7 RID: 9143
			private static readonly IntPtr NativeFieldInfoPtr_currentValue;

			// Token: 0x040023B8 RID: 9144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0;

			// Token: 0x040023B9 RID: 9145
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040023BA RID: 9146
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040023BB RID: 9147
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000248 RID: 584
		public class XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator
		{
			// Token: 0x06002D68 RID: 11624 RVA: 0x000C95AC File Offset: 0x000C77AC
			// Note: this type is marked as 'beforefieldinit'.
			static XSODictionaryEnumerator()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "XSODictionaryEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668412);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668413);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668414);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668415);
			}

			// Token: 0x06002D69 RID: 11625 RVA: 0x000C9628 File Offset: 0x000C7828
			[CallerCount(0)]
			public unsafe XSODictionaryEnumerator(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enumType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F72 RID: 3954
			// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000C9690 File Offset: 0x000C7890
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427699, XrefRangeEnd = 427700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17000F73 RID: 3955
			// (get) Token: 0x06002D6B RID: 11627 RVA: 0x000C96C8 File Offset: 0x000C78C8
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000F74 RID: 3956
			// (get) Token: 0x06002D6C RID: 11628 RVA: 0x000C9708 File Offset: 0x000C7908
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D6D RID: 11629 RVA: 0x00013AE3 File Offset: 0x00011CE3
			public XSODictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040023BC RID: 9148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0;

			// Token: 0x040023BD RID: 9149
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x040023BE RID: 9150
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040023BF RID: 9151
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
