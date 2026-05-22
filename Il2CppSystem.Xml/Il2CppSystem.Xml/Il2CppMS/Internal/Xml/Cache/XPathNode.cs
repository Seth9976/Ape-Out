using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace Il2CppMS.Internal.Xml.Cache
{
	// Token: 0x02000011 RID: 17
	public sealed class XPathNode : ValueType
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00017760 File Offset: 0x00015960
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNode()
		{
			Il2CppClassPointerStore<XPathNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNode>.NativeClassPtr);
			XPathNode.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "info");
			XPathNode.NativeFieldInfoPtr_idxSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "idxSibling");
			XPathNode.NativeFieldInfoPtr_idxParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "idxParent");
			XPathNode.NativeFieldInfoPtr_idxSimilar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "idxSimilar");
			XPathNode.NativeFieldInfoPtr_posOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "posOffset");
			XPathNode.NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "props");
			XPathNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "value");
			XPathNode.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663412);
			XPathNode.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663413);
			XPathNode.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663414);
			XPathNode.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663415);
			XPathNode.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663416);
			XPathNode.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663417);
			XPathNode.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663418);
			XPathNode.NativeMethodInfoPtr_get_CollapsedLinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663419);
			XPathNode.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663420);
			XPathNode.NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663421);
			XPathNode.NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663422);
			XPathNode.NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663423);
			XPathNode.NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663424);
			XPathNode.NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663425);
			XPathNode.NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663426);
			XPathNode.NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663427);
			XPathNode.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663428);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00017970 File Offset: 0x00015B70
		public unsafe XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000179B4 File Offset: 0x00015BB4
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000179F0 File Offset: 0x00015BF0
		public unsafe string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00017A2C File Offset: 0x00015C2C
		public unsafe string NamespaceUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00017A68 File Offset: 0x00015C68
		public unsafe XPathDocument Document
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr3) : null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00017AAC File Offset: 0x00015CAC
		public unsafe int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00017AF0 File Offset: 0x00015CF0
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00017B34 File Offset: 0x00015D34
		public unsafe int CollapsedLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_CollapsedLinePosition_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00017B78 File Offset: 0x00015D78
		public unsafe XPathNodePageInfo PageInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00017BBC File Offset: 0x00015DBC
		[CallerCount(0)]
		public unsafe int GetParent(out Il2CppReferenceArray<XPathNode> pageNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00017C20 File Offset: 0x00015E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389569, RefRangeEnd = 389570, XrefRangeStart = 389569, XrefRangeEnd = 389569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSibling(out Il2CppReferenceArray<XPathNode> pageNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00017C84 File Offset: 0x00015E84
		public unsafe bool IsXmlNamespaceNode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 389572, RefRangeEnd = 389574, XrefRangeStart = 389570, XrefRangeEnd = 389572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00017CC8 File Offset: 0x00015EC8
		public unsafe bool HasSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00017D0C File Offset: 0x00015F0C
		public unsafe bool HasCollapsedText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00017D50 File Offset: 0x00015F50
		public unsafe bool IsText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389574, XrefRangeEnd = 389577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00017D94 File Offset: 0x00015F94
		public unsafe bool HasNamespaceDecls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00017DD8 File Offset: 0x00015FD8
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000026A2 File Offset: 0x000008A2
		public XPathNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000026AB File Offset: 0x000008AB
		public XPathNode()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNode>.NativeClassPtr))
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00017E14 File Offset: 0x00016014
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000026BD File Offset: 0x000008BD
		public unsafe XPathNodeInfoAtom info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNodeInfoAtom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00017E44 File Offset: 0x00016044
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000026DC File Offset: 0x000008DC
		public unsafe ushort idxSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSibling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSibling)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00017E6C File Offset: 0x0001606C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000026F7 File Offset: 0x000008F7
		public unsafe ushort idxParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxParent)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00017E94 File Offset: 0x00016094
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002712 File Offset: 0x00000912
		public unsafe ushort idxSimilar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSimilar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSimilar)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00017EBC File Offset: 0x000160BC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000272D File Offset: 0x0000092D
		public unsafe ushort posOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_posOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_posOffset)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00017EE4 File Offset: 0x000160E4
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002748 File Offset: 0x00000948
		public unsafe uint props
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_props);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_props)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00017F0C File Offset: 0x0001610C
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002763 File Offset: 0x00000963
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_idxSibling;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_idxParent;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_idxSimilar;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_posOffset;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_props;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_CollapsedLinePosition_Public_get_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
