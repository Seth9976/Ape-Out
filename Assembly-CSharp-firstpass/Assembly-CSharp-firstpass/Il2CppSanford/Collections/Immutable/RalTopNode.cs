using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001E0 RID: 480
	public class RalTopNode : Object
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x0006D270 File Offset: 0x0006B470
		// Note: this type is marked as 'beforefieldinit'.
		static RalTopNode()
		{
			Il2CppClassPointerStore<RalTopNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "RalTopNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr);
			RalTopNode.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr, "root");
			RalTopNode.NativeFieldInfoPtr_nextNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr, "nextNode");
			RalTopNode.NativeMethodInfoPtr__ctor_Public_Void_RalTreeNode_RalTopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr, 100666823);
			RalTopNode.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr, 100666824);
			RalTopNode.NativeMethodInfoPtr_SetValue_Public_RalTopNode_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr, 100666825);
			RalTopNode.NativeMethodInfoPtr_get_Root_Public_get_RalTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr, 100666826);
			RalTopNode.NativeMethodInfoPtr_get_NextNode_Public_get_RalTopNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr, 100666827);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0006D32C File Offset: 0x0006B52C
		[CallerCount(76)]
		[CachedScanResults(RefRangeStart = 19789, RefRangeEnd = 19865, XrefRangeStart = 19789, XrefRangeEnd = 19789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RalTopNode(RalTreeNode root, RalTopNode nextNode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RalTopNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTopNode.NativeMethodInfoPtr__ctor_Public_Void_RalTreeNode_RalTopNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0006D38C File Offset: 0x0006B58C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19868, RefRangeEnd = 19870, XrefRangeStart = 19865, XrefRangeEnd = 19868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTopNode.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0006D3D8 File Offset: 0x0006B5D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19877, RefRangeEnd = 19880, XrefRangeStart = 19870, XrefRangeEnd = 19877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RalTopNode SetValue(Object value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTopNode.NativeMethodInfoPtr_SetValue_Public_RalTopNode_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTopNode>(intPtr3) : null;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0006D438 File Offset: 0x0006B638
		public unsafe RalTreeNode Root
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTopNode.NativeMethodInfoPtr_get_Root_Public_get_RalTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0006D478 File Offset: 0x0006B678
		public unsafe RalTopNode NextNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTopNode.NativeMethodInfoPtr_get_NextNode_Public_get_RalTopNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTopNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00009B15 File Offset: 0x00007D15
		public RalTopNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0006D4B8 File Offset: 0x0006B6B8
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x00009B1E File Offset: 0x00007D1E
		public unsafe RalTreeNode root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTopNode.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTopNode.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x0006D4E8 File Offset: 0x0006B6E8
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x00009B3D File Offset: 0x00007D3D
		public unsafe RalTopNode nextNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTopNode.NativeFieldInfoPtr_nextNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTopNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTopNode.NativeFieldInfoPtr_nextNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeFieldInfoPtr_nextNode;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RalTreeNode_RalTopNode_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_RalTopNode_Object_Int32_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_get_Root_Public_get_RalTreeNode_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_get_NextNode_Public_get_RalTopNode_0;
	}
}
