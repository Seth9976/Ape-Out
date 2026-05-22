using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMS.Internal.Xml.Cache
{
	// Token: 0x02000013 RID: 19
	public class XPathNodeHelper : Object
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00018160 File Offset: 0x00016360
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeHelper()
		{
			Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr);
			XPathNodeHelper.NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663433);
			XPathNodeHelper.NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663434);
			XPathNodeHelper.NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663435);
			XPathNodeHelper.NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663436);
			XPathNodeHelper.NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663437);
			XPathNodeHelper.NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663438);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00018208 File Offset: 0x00016408
		[CallerCount(0)]
		public unsafe static int GetLocalNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001827C File Offset: 0x0001647C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389577, RefRangeEnd = 389578, XrefRangeStart = 389577, XrefRangeEnd = 389577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInScopeNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000182F0 File Offset: 0x000164F0
		[CallerCount(0)]
		public unsafe static bool GetParent(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxNode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00018358 File Offset: 0x00016558
		[CallerCount(0)]
		public unsafe static int GetLocation(Il2CppReferenceArray<XPathNode> pageNode, int idxNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxNode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000183A8 File Offset: 0x000165A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389584, RefRangeEnd = 389586, XrefRangeStart = 389578, XrefRangeEnd = 389584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTextFollowing(ref Il2CppReferenceArray<XPathNode> pageCurrent, ref int idxCurrent, Il2CppReferenceArray<XPathNode> pageEnd, int idxEnd)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageCurrent);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxCurrent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pageEnd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxEnd;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageCurrent = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00018430 File Offset: 0x00016630
		[CallerCount(0)]
		public unsafe static bool GetNonDescendant(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxNode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000027D7 File Offset: 0x000009D7
		public XPathNodeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;
	}
}
