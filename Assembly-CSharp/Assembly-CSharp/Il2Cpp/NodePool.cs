using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x0200015B RID: 347
	public class NodePool : Object
	{
		// Token: 0x0600295B RID: 10587 RVA: 0x000A6B4C File Offset: 0x000A4D4C
		// Note: this type is marked as 'beforefieldinit'.
		static NodePool()
		{
			Il2CppClassPointerStore<NodePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NodePool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodePool>.NativeClassPtr);
			NodePool.NativeFieldInfoPtr_nodePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodePool>.NativeClassPtr, "nodePool");
			NodePool.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodePool>.NativeClassPtr, 100666571);
			NodePool.NativeMethodInfoPtr_TakeNode_Public_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodePool>.NativeClassPtr, 100666572);
			NodePool.NativeMethodInfoPtr_ReturnNode_Public_Void_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodePool>.NativeClassPtr, 100666573);
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000A6BCC File Offset: 0x000A4DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76948, XrefRangeEnd = 76960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodePool(int nodeCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodePool>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodePool.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000A6C14 File Offset: 0x000A4E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76960, XrefRangeEnd = 76967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Node TakeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodePool.NativeMethodInfoPtr_TakeNode_Public_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Node>(intPtr3) : null;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000A6C54 File Offset: 0x000A4E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76967, XrefRangeEnd = 76970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnNode(Node node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodePool.NativeMethodInfoPtr_ReturnNode_Public_Void_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x0001CCAA File Offset: 0x0001AEAA
		public NodePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000A6C98 File Offset: 0x000A4E98
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x0001CCB3 File Offset: 0x0001AEB3
		public unsafe Stack<Node> nodePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodePool.NativeFieldInfoPtr_nodePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Node>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodePool.NativeFieldInfoPtr_nodePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr_nodePool;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_TakeNode_Public_Node_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_ReturnNode_Public_Void_Node_0;
	}
}
