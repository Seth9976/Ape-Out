using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010D RID: 269
	public class InteriorNode : SyntaxTreeNode
	{
		// Token: 0x0600161B RID: 5659 RVA: 0x000712C8 File Offset: 0x0006F4C8
		// Note: this type is marked as 'beforefieldinit'.
		static InteriorNode()
		{
			Il2CppClassPointerStore<InteriorNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "InteriorNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr);
			InteriorNode.NativeFieldInfoPtr_leftChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, "leftChild");
			InteriorNode.NativeFieldInfoPtr_rightChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, "rightChild");
			InteriorNode.NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100666629);
			InteriorNode.NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100666630);
			InteriorNode.NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100666631);
			InteriorNode.NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100666632);
			InteriorNode.NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100666633);
			InteriorNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100666634);
			InteriorNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100666635);
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x000713AC File Offset: 0x0006F5AC
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x000713EC File Offset: 0x0006F5EC
		public unsafe SyntaxTreeNode LeftChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x00071430 File Offset: 0x0006F630
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x00071470 File Offset: 0x0006F670
		public unsafe SyntaxTreeNode RightChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000714B4 File Offset: 0x0006F6B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409434, RefRangeEnd = 409436, XrefRangeStart = 409415, XrefRangeEnd = 409434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0007151C File Offset: 0x0006F71C
		[CallerCount(0)]
		public unsafe override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteriorNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00071590 File Offset: 0x0006F790
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteriorNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00009DEB File Offset: 0x00007FEB
		public InteriorNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x000715CC File Offset: 0x0006F7CC
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x00009DF4 File Offset: 0x00007FF4
		public unsafe SyntaxTreeNode leftChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_leftChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_leftChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x000715FC File Offset: 0x0006F7FC
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x00009E13 File Offset: 0x00008013
		public unsafe SyntaxTreeNode rightChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_rightChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_rightChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeFieldInfoPtr_leftChild;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeFieldInfoPtr_rightChild;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
