using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200007D RID: 125
	public class XmlNamedNodeMap : Object
	{
		// Token: 0x06000D4F RID: 3407 RVA: 0x0004CD5C File Offset: 0x0004AF5C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamedNodeMap()
		{
			Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNamedNodeMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr);
			XmlNamedNodeMap.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "parent");
			XmlNamedNodeMap.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "nodes");
			XmlNamedNodeMap.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665385);
			XmlNamedNodeMap.NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665386);
			XmlNamedNodeMap.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665387);
			XmlNamedNodeMap.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665388);
			XmlNamedNodeMap.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665389);
			XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665390);
			XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665391);
			XmlNamedNodeMap.NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665392);
			XmlNamedNodeMap.NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665393);
			XmlNamedNodeMap.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665394);
			XmlNamedNodeMap.NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665395);
			XmlNamedNodeMap.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100665396);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0004CEA4 File Offset: 0x0004B0A4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamedNodeMap(XmlNode parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398809, XrefRangeEnd = 398813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode GetNamedItem(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0004CF4C File Offset: 0x0004B14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398813, XrefRangeEnd = 398814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode SetNamedItem(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0004CFA8 File Offset: 0x0004B1A8
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0004CFF0 File Offset: 0x0004B1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398814, XrefRangeEnd = 398815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0004D03C File Offset: 0x0004B23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398815, XrefRangeEnd = 398818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeOffset(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0004D08C File Offset: 0x0004B28C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 398821, RefRangeEnd = 398825, XrefRangeStart = 398818, XrefRangeEnd = 398821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeOffset(string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0004D0EC File Offset: 0x0004B2EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 398829, RefRangeEnd = 398831, XrefRangeStart = 398825, XrefRangeEnd = 398829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AddNode(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0004D148 File Offset: 0x0004B348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398831, XrefRangeEnd = 398833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0004D1B8 File Offset: 0x0004B3B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 398837, RefRangeEnd = 398841, XrefRangeStart = 398833, XrefRangeEnd = 398837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode RemoveNodeAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0004D210 File Offset: 0x0004B410
		[CallerCount(0)]
		public unsafe XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0004D270 File Offset: 0x0004B470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 398845, RefRangeEnd = 398846, XrefRangeStart = 398841, XrefRangeEnd = 398845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00006A21 File Offset: 0x00004C21
		public XmlNamedNodeMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0004D2DC File Offset: 0x0004B4DC
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00006A2A File Offset: 0x00004C2A
		public unsafe XmlNode parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0004D30C File Offset: 0x0004B50C
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00006A49 File Offset: 0x00004C49
		public XmlNamedNodeMap.SmallXmlNodeList nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_nodes);
				return new XmlNamedNodeMap.SmallXmlNodeList(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_nodes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0;

		// Token: 0x0200021C RID: 540
		public sealed class SmallXmlNodeList : ValueType
		{
			// Token: 0x06002B99 RID: 11161 RVA: 0x000C43E4 File Offset: 0x000C25E4
			// Note: this type is marked as 'beforefieldinit'.
			static SmallXmlNodeList()
			{
				Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "SmallXmlNodeList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr);
				XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, "field");
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665397);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665398);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Add_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665399);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665400);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665401);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100665402);
			}

			// Token: 0x17000EE2 RID: 3810
			// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000C449C File Offset: 0x000C269C
			public unsafe int Count
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 398731, RefRangeEnd = 398736, XrefRangeStart = 398729, XrefRangeEnd = 398731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EE3 RID: 3811
			public unsafe Object this[int index]
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 398738, RefRangeEnd = 398749, XrefRangeStart = 398736, XrefRangeEnd = 398738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x06002B9C RID: 11164 RVA: 0x000C4534 File Offset: 0x000C2734
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 398759, RefRangeEnd = 398763, XrefRangeStart = 398749, XrefRangeEnd = 398759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Add_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B9D RID: 11165 RVA: 0x000C457C File Offset: 0x000C277C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 398778, RefRangeEnd = 398779, XrefRangeStart = 398763, XrefRangeEnd = 398778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B9E RID: 11166 RVA: 0x000C45C0 File Offset: 0x000C27C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 398801, RefRangeEnd = 398802, XrefRangeStart = 398779, XrefRangeEnd = 398801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Insert(int index, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B9F RID: 11167 RVA: 0x000C4618 File Offset: 0x000C2818
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 398808, RefRangeEnd = 398809, XrefRangeStart = 398802, XrefRangeEnd = 398808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002BA0 RID: 11168 RVA: 0x0001292A File Offset: 0x00010B2A
			public SmallXmlNodeList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002BA1 RID: 11169 RVA: 0x00012933 File Offset: 0x00010B33
			public SmallXmlNodeList()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr))
			{
			}

			// Token: 0x17000EE1 RID: 3809
			// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000C465C File Offset: 0x000C285C
			// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x00012945 File Offset: 0x00010B45
			public unsafe Object field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021D3 RID: 8659
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x040021D4 RID: 8660
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x040021D5 RID: 8661
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

			// Token: 0x040021D6 RID: 8662
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_0;

			// Token: 0x040021D7 RID: 8663
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

			// Token: 0x040021D8 RID: 8664
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0;

			// Token: 0x040021D9 RID: 8665
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

			// Token: 0x0200026E RID: 622
			public class SingleObjectEnumerator : Object
			{
				// Token: 0x06002E0E RID: 11790 RVA: 0x000CADD0 File Offset: 0x000C8FD0
				// Note: this type is marked as 'beforefieldinit'.
				static SingleObjectEnumerator()
				{
					Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, "SingleObjectEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, "loneValue");
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, "position");
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665403);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665404);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665405);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100665406);
				}

				// Token: 0x06002E0F RID: 11791 RVA: 0x000CAE74 File Offset: 0x000C9074
				[CallerCount(0)]
				public unsafe SingleObjectEnumerator(Object value)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x17000F96 RID: 3990
				// (get) Token: 0x06002E10 RID: 11792 RVA: 0x000CAEC0 File Offset: 0x000C90C0
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06002E11 RID: 11793 RVA: 0x000CAF00 File Offset: 0x000C9100
				[CallerCount(0)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002E12 RID: 11794 RVA: 0x000CAF3C File Offset: 0x000C913C
				[CallerCount(0)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002E13 RID: 11795 RVA: 0x0001420E File Offset: 0x0001240E
				public SingleObjectEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000F94 RID: 3988
				// (get) Token: 0x06002E14 RID: 11796 RVA: 0x000CAF70 File Offset: 0x000C9170
				// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00014217 File Offset: 0x00012417
				public unsafe Object loneValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000F95 RID: 3989
				// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000CAFA0 File Offset: 0x000C91A0
				// (set) Token: 0x06002E17 RID: 11799 RVA: 0x00014236 File Offset: 0x00012436
				public unsafe int position
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position)) = value;
					}
				}

				// Token: 0x04002458 RID: 9304
				private static readonly IntPtr NativeFieldInfoPtr_loneValue;

				// Token: 0x04002459 RID: 9305
				private static readonly IntPtr NativeFieldInfoPtr_position;

				// Token: 0x0400245A RID: 9306
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

				// Token: 0x0400245B RID: 9307
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x0400245C RID: 9308
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x0400245D RID: 9309
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}
	}
}
