using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000113 RID: 275
	public sealed class LeafRangeNode : LeafNode
	{
		// Token: 0x06001644 RID: 5700 RVA: 0x00071E20 File Offset: 0x00070020
		// Note: this type is marked as 'beforefieldinit'.
		static LeafRangeNode()
		{
			Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "LeafRangeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr);
			LeafRangeNode.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "min");
			LeafRangeNode.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "max");
			LeafRangeNode.NativeFieldInfoPtr_nextIteration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, "nextIteration");
			LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666655);
			LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666656);
			LeafRangeNode.NativeMethodInfoPtr_get_Max_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666657);
			LeafRangeNode.NativeMethodInfoPtr_get_Min_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666658);
			LeafRangeNode.NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666659);
			LeafRangeNode.NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666660);
			LeafRangeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666661);
			LeafRangeNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr, 100666662);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00071F2C File Offset: 0x0007012C
		[CallerCount(0)]
		public unsafe LeafRangeNode(Decimal min, Decimal max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00071F84 File Offset: 0x00070184
		[CallerCount(0)]
		public unsafe LeafRangeNode(int pos, Decimal min, Decimal max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeafRangeNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00071FE8 File Offset: 0x000701E8
		public unsafe Decimal Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_Max_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00072024 File Offset: 0x00070224
		public unsafe Decimal Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_Min_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x00072060 File Offset: 0x00070260
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x000720A0 File Offset: 0x000702A0
		public unsafe BitSet NextIteration
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x000720E4 File Offset: 0x000702E4
		public unsafe override bool IsRangeNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00072120 File Offset: 0x00070320
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeafRangeNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00009E5F File Offset: 0x0000805F
		public LeafRangeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00072188 File Offset: 0x00070388
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00009E68 File Offset: 0x00008068
		public unsafe Decimal min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x000721B0 File Offset: 0x000703B0
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00009E83 File Offset: 0x00008083
		public unsafe Decimal max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x000721D8 File Offset: 0x000703D8
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00009E9E File Offset: 0x0000809E
		public unsafe BitSet nextIteration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_nextIteration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeafRangeNode.NativeFieldInfoPtr_nextIteration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeFieldInfoPtr_nextIteration;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decimal_Decimal_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Decimal_Decimal_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_get_Decimal_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_Decimal_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_get_NextIteration_Public_get_BitSet_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_set_NextIteration_Public_set_Void_BitSet_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_get_Boolean_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;
	}
}
