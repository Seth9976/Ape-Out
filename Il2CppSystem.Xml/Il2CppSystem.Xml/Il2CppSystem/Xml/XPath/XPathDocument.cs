using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMS.Internal.Xml.Cache;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x020000B2 RID: 178
	public class XPathDocument : Object
	{
		// Token: 0x060010A8 RID: 4264 RVA: 0x0005C844 File Offset: 0x0005AA44
		// Note: this type is marked as 'beforefieldinit'.
		static XPathDocument()
		{
			Il2CppClassPointerStore<XPathDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr);
			XPathDocument.NativeFieldInfoPtr_pageXmlNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "pageXmlNmsp");
			XPathDocument.NativeFieldInfoPtr_idxXmlNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "idxXmlNmsp");
			XPathDocument.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "nameTable");
			XPathDocument.NativeFieldInfoPtr_mapNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "mapNmsp");
			XPathDocument.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100665966);
			XPathDocument.NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100665967);
			XPathDocument.NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100665968);
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0005C900 File Offset: 0x0005AB00
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0005C940 File Offset: 0x0005AB40
		[CallerCount(0)]
		public unsafe int GetXmlNamespaceNode(out Il2CppReferenceArray<XPathNode> pageXmlNmsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageXmlNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0005C9A0 File Offset: 0x0005ABA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403262, RefRangeEnd = 403263, XrefRangeStart = 403257, XrefRangeEnd = 403262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageElem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxElem;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00007792 File Offset: 0x00005992
		public XPathDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x0005CA20 File Offset: 0x0005AC20
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x0000779B File Offset: 0x0000599B
		public unsafe Il2CppReferenceArray<XPathNode> pageXmlNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_pageXmlNmsp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_pageXmlNmsp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0005CA50 File Offset: 0x0005AC50
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x000077BA File Offset: 0x000059BA
		public unsafe int idxXmlNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_idxXmlNmsp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_idxXmlNmsp)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0005CA78 File Offset: 0x0005AC78
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x000077D5 File Offset: 0x000059D5
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0005CAA8 File Offset: 0x0005ACA8
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x000077F4 File Offset: 0x000059F4
		public unsafe Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_mapNmsp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XPathNodeRef, XPathNodeRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_mapNmsp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_pageXmlNmsp;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_idxXmlNmsp;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr_mapNmsp;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;
	}
}
