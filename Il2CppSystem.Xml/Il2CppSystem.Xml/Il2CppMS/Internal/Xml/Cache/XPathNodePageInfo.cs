using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMS.Internal.Xml.Cache
{
	// Token: 0x02000014 RID: 20
	public sealed class XPathNodePageInfo : Object
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00018498 File Offset: 0x00016698
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodePageInfo()
		{
			Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodePageInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr);
			XPathNodePageInfo.NativeFieldInfoPtr_pageNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "pageNum");
			XPathNodePageInfo.NativeFieldInfoPtr_nodeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "nodeCount");
			XPathNodePageInfo.NativeFieldInfoPtr_pageNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "pageNext");
			XPathNodePageInfo.NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100663439);
			XPathNodePageInfo.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100663440);
			XPathNodePageInfo.NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100663441);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00018540 File Offset: 0x00016740
		public unsafe int PageNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0001857C File Offset: 0x0001677C
		public unsafe int NodeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000185B8 File Offset: 0x000167B8
		public unsafe Il2CppReferenceArray<XPathNode> NextPage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000027E0 File Offset: 0x000009E0
		public XPathNodePageInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000185F8 File Offset: 0x000167F8
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000027E9 File Offset: 0x000009E9
		public unsafe int pageNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNum)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00018620 File Offset: 0x00016820
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002804 File Offset: 0x00000A04
		public unsafe int nodeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_nodeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_nodeCount)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00018648 File Offset: 0x00016848
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000281F File Offset: 0x00000A1F
		public unsafe Il2CppReferenceArray<XPathNode> pageNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_pageNum;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_nodeCount;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_pageNext;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;
	}
}
