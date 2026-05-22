using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x0200015A RID: 346
	public class NodeList : Object
	{
		// Token: 0x06002946 RID: 10566 RVA: 0x000A6714 File Offset: 0x000A4914
		// Note: this type is marked as 'beforefieldinit'.
		static NodeList()
		{
			Il2CppClassPointerStore<NodeList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NodeList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeList>.NativeClassPtr);
			NodeList.NativeFieldInfoPtr_NODE_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeList>.NativeClassPtr, "NODE_CAPACITY");
			NodeList.NativeFieldInfoPtr_nodeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeList>.NativeClassPtr, "nodeList");
			NodeList.NativeFieldInfoPtr_usedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeList>.NativeClassPtr, "usedNodes");
			NodeList.NativeFieldInfoPtr_nodePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeList>.NativeClassPtr, "nodePool");
			NodeList.NativeFieldInfoPtr_bestNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeList>.NativeClassPtr, "bestNode");
			NodeList.NativeFieldInfoPtr_minScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeList>.NativeClassPtr, "minScore");
			NodeList.NativeMethodInfoPtr_Add_Public_Node_PFCell_Node_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeList>.NativeClassPtr, 100666564);
			NodeList.NativeMethodInfoPtr_InsertNodeIntoListBinary_Private_Void_Int32_Int32_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeList>.NativeClassPtr, 100666565);
			NodeList.NativeMethodInfoPtr_GetBest_Public_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeList>.NativeClassPtr, 100666566);
			NodeList.NativeMethodInfoPtr_GetPoppy_Public_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeList>.NativeClassPtr, 100666567);
			NodeList.NativeMethodInfoPtr_GotNodes_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeList>.NativeClassPtr, 100666568);
			NodeList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeList>.NativeClassPtr, 100666569);
			NodeList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeList>.NativeClassPtr, 100666570);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000A6848 File Offset: 0x000A4A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76855, XrefRangeEnd = 76880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Node Add(PFCell cell, Node dad, float score, float cleanScore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cell;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dad);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cleanScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeList.NativeMethodInfoPtr_Add_Public_Node_PFCell_Node_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Node>(intPtr3) : null;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000A68C4 File Offset: 0x000A4AC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76889, RefRangeEnd = 76891, XrefRangeStart = 76880, XrefRangeEnd = 76889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertNodeIntoListBinary(int low, int high, Node node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref high;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeList.NativeMethodInfoPtr_InsertNodeIntoListBinary_Private_Void_Int32_Int32_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000A6924 File Offset: 0x000A4B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76891, XrefRangeEnd = 76893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Node GetBest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeList.NativeMethodInfoPtr_GetBest_Public_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Node>(intPtr3) : null;
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000A6964 File Offset: 0x000A4B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76893, XrefRangeEnd = 76900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Node GetPoppy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeList.NativeMethodInfoPtr_GetPoppy_Public_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Node>(intPtr3) : null;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000A69A4 File Offset: 0x000A4BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76900, XrefRangeEnd = 76901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GotNodes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeList.NativeMethodInfoPtr_GotNodes_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000A69E0 File Offset: 0x000A4BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76901, XrefRangeEnd = 76917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000A6A14 File Offset: 0x000A4C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76917, XrefRangeEnd = 76948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x0001CC00 File Offset: 0x0001AE00
		public NodeList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x000A6A50 File Offset: 0x000A4C50
		// (set) Token: 0x06002950 RID: 10576 RVA: 0x0001CC09 File Offset: 0x0001AE09
		public unsafe static int NODE_CAPACITY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NodeList.NativeFieldInfoPtr_NODE_CAPACITY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NodeList.NativeFieldInfoPtr_NODE_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x000A6A6C File Offset: 0x000A4C6C
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x0001CC17 File Offset: 0x0001AE17
		public unsafe List<Node> nodeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_nodeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Node>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_nodeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x000A6A9C File Offset: 0x000A4C9C
		// (set) Token: 0x06002954 RID: 10580 RVA: 0x0001CC36 File Offset: 0x0001AE36
		public unsafe Stack<Node> usedNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_usedNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Node>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_usedNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x000A6ACC File Offset: 0x000A4CCC
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x0001CC55 File Offset: 0x0001AE55
		public unsafe NodePool nodePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_nodePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NodePool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_nodePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x000A6AFC File Offset: 0x000A4CFC
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x0001CC74 File Offset: 0x0001AE74
		public unsafe int bestNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_bestNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_bestNode)) = value;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x000A6B24 File Offset: 0x000A4D24
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x0001CC8F File Offset: 0x0001AE8F
		public unsafe float minScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_minScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeList.NativeFieldInfoPtr_minScore)) = value;
			}
		}

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_NODE_CAPACITY;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_nodeList;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr_usedNodes;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr_nodePool;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr_bestNode;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_minScore;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Node_PFCell_Node_Single_Single_0;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_InsertNodeIntoListBinary_Private_Void_Int32_Int32_Node_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_GetBest_Public_Node_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr_GetPoppy_Public_Node_0;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_GotNodes_Public_Boolean_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
