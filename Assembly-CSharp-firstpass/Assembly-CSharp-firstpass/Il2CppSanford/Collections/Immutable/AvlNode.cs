using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001DA RID: 474
	public class AvlNode : Object
	{
		// Token: 0x060017DE RID: 6110 RVA: 0x0006B4A8 File Offset: 0x000696A8
		// Note: this type is marked as 'beforefieldinit'.
		static AvlNode()
		{
			Il2CppClassPointerStore<AvlNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "AvlNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvlNode>.NativeClassPtr);
			AvlNode.NativeFieldInfoPtr_NullNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, "NullNode");
			AvlNode.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, "data");
			AvlNode.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, "count");
			AvlNode.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, "height");
			AvlNode.NativeFieldInfoPtr_leftChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, "leftChild");
			AvlNode.NativeFieldInfoPtr_rightChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, "rightChild");
			AvlNode.NativeMethodInfoPtr__ctor_Public_Void_Object_IAvlNode_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666756);
			AvlNode.NativeMethodInfoPtr_DoLLRotation_Private_IAvlNode_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666757);
			AvlNode.NativeMethodInfoPtr_DoLRRotation_Private_IAvlNode_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666758);
			AvlNode.NativeMethodInfoPtr_DoRRRotation_Private_IAvlNode_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666759);
			AvlNode.NativeMethodInfoPtr_DoRLRotation_Private_IAvlNode_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666760);
			AvlNode.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666761);
			AvlNode.NativeMethodInfoPtr_RemoveReplacement_Private_IAvlNode_IAvlNode_byref_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666762);
			AvlNode.NativeMethodInfoPtr_Balance_Public_Virtual_Final_New_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666763);
			AvlNode.NativeMethodInfoPtr_IsBalanced_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666764);
			AvlNode.NativeMethodInfoPtr_get_BalanceFactor_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666765);
			AvlNode.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666766);
			AvlNode.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666767);
			AvlNode.NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666768);
			AvlNode.NativeMethodInfoPtr_get_LeftChild_Public_Virtual_Final_New_get_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666769);
			AvlNode.NativeMethodInfoPtr_get_RightChild_Public_Virtual_Final_New_get_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvlNode>.NativeClassPtr, 100666770);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0006B67C File Offset: 0x0006987C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 19245, RefRangeEnd = 19263, XrefRangeStart = 19233, XrefRangeEnd = 19245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvlNode(Object data, IAvlNode leftChild, IAvlNode rightChild)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvlNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leftChild);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr__ctor_Public_Void_Object_IAvlNode_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0006B6EC File Offset: 0x000698EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19287, RefRangeEnd = 19291, XrefRangeStart = 19263, XrefRangeEnd = 19287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode DoLLRotation(IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_DoLLRotation_Private_IAvlNode_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0006B73C File Offset: 0x0006993C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19291, XrefRangeEnd = 19305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode DoLRRotation(IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_DoLRRotation_Private_IAvlNode_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0006B78C File Offset: 0x0006998C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19329, RefRangeEnd = 19334, XrefRangeStart = 19305, XrefRangeEnd = 19329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode DoRRRotation(IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_DoRRRotation_Private_IAvlNode_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0006B7DC File Offset: 0x000699DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19334, XrefRangeEnd = 19348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode DoRLRotation(IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_DoRLRotation_Private_IAvlNode_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0006B82C File Offset: 0x00069A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19348, XrefRangeEnd = 19375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAvlNode Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0006B86C File Offset: 0x00069A6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19397, RefRangeEnd = 19399, XrefRangeStart = 19375, XrefRangeEnd = 19397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode RemoveReplacement(IAvlNode node, ref IAvlNode replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_RemoveReplacement_Private_IAvlNode_IAvlNode_byref_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			replacement = ((intPtr4 == 0) ? null : new IAvlNode(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr5) : null;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0006B8E8 File Offset: 0x00069AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19399, XrefRangeEnd = 19436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAvlNode Balance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_Balance_Public_Virtual_Final_New_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0006B928 File Offset: 0x00069B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19436, XrefRangeEnd = 19437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsBalanced()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_IsBalanced_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0006B964 File Offset: 0x00069B64
		public unsafe virtual int BalanceFactor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19442, RefRangeEnd = 19445, XrefRangeStart = 19437, XrefRangeEnd = 19442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_get_BalanceFactor_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0006B9A0 File Offset: 0x00069BA0
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0006B9DC File Offset: 0x00069BDC
		public unsafe virtual Object Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0006BA1C File Offset: 0x00069C1C
		public unsafe virtual int Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0006BA58 File Offset: 0x00069C58
		public unsafe virtual IAvlNode LeftChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_get_LeftChild_Public_Virtual_Final_New_get_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x0006BA98 File Offset: 0x00069C98
		public unsafe virtual IAvlNode RightChild
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvlNode.NativeMethodInfoPtr_get_RightChild_Public_Virtual_Final_New_get_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000098E6 File Offset: 0x00007AE6
		public AvlNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x000098EF File Offset: 0x00007AEF
		public unsafe static NullAvlNode NullNode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AvlNode.NativeFieldInfoPtr_NullNode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NullAvlNode>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvlNode.NativeFieldInfoPtr_NullNode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0006BB00 File Offset: 0x00069D00
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x00009901 File Offset: 0x00007B01
		public unsafe Object data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x0006BB30 File Offset: 0x00069D30
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x00009920 File Offset: 0x00007B20
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0006BB58 File Offset: 0x00069D58
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0000993B File Offset: 0x00007B3B
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0006BB80 File Offset: 0x00069D80
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x00009956 File Offset: 0x00007B56
		public unsafe IAvlNode leftChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_leftChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_leftChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0006BBB0 File Offset: 0x00069DB0
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x00009975 File Offset: 0x00007B75
		public unsafe IAvlNode rightChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_rightChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvlNode.NativeFieldInfoPtr_rightChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeFieldInfoPtr_NullNode;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeFieldInfoPtr_leftChild;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeFieldInfoPtr_rightChild;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IAvlNode_IAvlNode_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_DoLLRotation_Private_IAvlNode_IAvlNode_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_DoLRRotation_Private_IAvlNode_IAvlNode_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_DoRRRotation_Private_IAvlNode_IAvlNode_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_DoRLRotation_Private_IAvlNode_IAvlNode_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_IAvlNode_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_RemoveReplacement_Private_IAvlNode_IAvlNode_byref_IAvlNode_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_Balance_Public_Virtual_Final_New_IAvlNode_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr_IsBalanced_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr_get_BalanceFactor_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftChild_Public_Virtual_Final_New_get_IAvlNode_0;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeMethodInfoPtr_get_RightChild_Public_Virtual_Final_New_get_IAvlNode_0;
	}
}
