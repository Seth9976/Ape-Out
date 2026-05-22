using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.Cache
{
	// Token: 0x02000015 RID: 21
	public sealed class XPathNodeInfoAtom : Object
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00018678 File Offset: 0x00016878
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeInfoAtom()
		{
			Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeInfoAtom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr);
			XPathNodeInfoAtom.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "localName");
			XPathNodeInfoAtom.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "namespaceUri");
			XPathNodeInfoAtom.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "prefix");
			XPathNodeInfoAtom.NativeFieldInfoPtr_pageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "pageParent");
			XPathNodeInfoAtom.NativeFieldInfoPtr_pageSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "pageSibling");
			XPathNodeInfoAtom.NativeFieldInfoPtr_doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "doc");
			XPathNodeInfoAtom.NativeFieldInfoPtr_lineNumBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "lineNumBase");
			XPathNodeInfoAtom.NativeFieldInfoPtr_linePosBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "linePosBase");
			XPathNodeInfoAtom.NativeFieldInfoPtr_pageInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "pageInfo");
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663442);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663443);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663444);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663445);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663446);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663447);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663448);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_LineNumberBase_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663449);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_LinePositionBase_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663450);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00018810 File Offset: 0x00016A10
		public unsafe XPathNodePageInfo PageInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00018850 File Offset: 0x00016A50
		public unsafe string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00018888 File Offset: 0x00016A88
		public unsafe string NamespaceUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000188C0 File Offset: 0x00016AC0
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000188F8 File Offset: 0x00016AF8
		public unsafe Il2CppReferenceArray<XPathNode> SiblingPage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00018938 File Offset: 0x00016B38
		public unsafe Il2CppReferenceArray<XPathNode> ParentPage
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00018978 File Offset: 0x00016B78
		public unsafe XPathDocument Document
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr3) : null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000189B8 File Offset: 0x00016BB8
		public unsafe int LineNumberBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_LineNumberBase_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000189F4 File Offset: 0x00016BF4
		public unsafe int LinePositionBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_LinePositionBase_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000283E File Offset: 0x00000A3E
		public XPathNodeInfoAtom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00018A30 File Offset: 0x00016C30
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002847 File Offset: 0x00000A47
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00018A58 File Offset: 0x00016C58
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002866 File Offset: 0x00000A66
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00018A80 File Offset: 0x00016C80
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002885 File Offset: 0x00000A85
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00018AA8 File Offset: 0x00016CA8
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000028A4 File Offset: 0x00000AA4
		public unsafe Il2CppReferenceArray<XPathNode> pageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00018AD8 File Offset: 0x00016CD8
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000028C3 File Offset: 0x00000AC3
		public unsafe Il2CppReferenceArray<XPathNode> pageSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageSibling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageSibling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00018B08 File Offset: 0x00016D08
		// (set) Token: 0x06000146 RID: 326 RVA: 0x000028E2 File Offset: 0x00000AE2
		public unsafe XPathDocument doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00018B38 File Offset: 0x00016D38
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002901 File Offset: 0x00000B01
		public unsafe int lineNumBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_lineNumBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_lineNumBase)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00018B60 File Offset: 0x00016D60
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000291C File Offset: 0x00000B1C
		public unsafe int linePosBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_linePosBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_linePosBase)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00018B88 File Offset: 0x00016D88
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002937 File Offset: 0x00000B37
		public unsafe XPathNodePageInfo pageInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_pageParent;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_pageSibling;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_doc;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_lineNumBase;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_linePosBase;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_pageInfo;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumberBase_Public_get_Int32_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePositionBase_Public_get_Int32_0;
	}
}
