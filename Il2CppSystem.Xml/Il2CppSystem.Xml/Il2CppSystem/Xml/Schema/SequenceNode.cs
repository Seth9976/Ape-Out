using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010E RID: 270
	public sealed class SequenceNode : InteriorNode
	{
		// Token: 0x06001628 RID: 5672 RVA: 0x0007162C File Offset: 0x0006F82C
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceNode()
		{
			Il2CppClassPointerStore<SequenceNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SequenceNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr);
			SequenceNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100666636);
			SequenceNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100666637);
			SequenceNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100666638);
			SequenceNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100666639);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000716AC File Offset: 0x0006F8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409438, XrefRangeEnd = 409472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructPos(BitSet firstpos, BitSet lastpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00071714 File Offset: 0x0006F914
		public unsafe override bool IsNullable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409472, XrefRangeEnd = 409483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00071750 File Offset: 0x0006F950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409483, XrefRangeEnd = 409484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000717B8 File Offset: 0x0006F9B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00009E32 File Offset: 0x00008032
		public SequenceNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200022F RID: 559
		public sealed class SequenceConstructPosContext : ValueType
		{
			// Token: 0x06002C3E RID: 11326 RVA: 0x000C5FA4 File Offset: 0x000C41A4
			// Note: this type is marked as 'beforefieldinit'.
			static SequenceConstructPosContext()
			{
				Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, "SequenceConstructPosContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr);
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "this_");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "firstpos");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "lastpos");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "lastposLeft");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "firstposRight");
				SequenceNode.SequenceConstructPosContext.NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, 100666640);
			}

			// Token: 0x06002C3F RID: 11327 RVA: 0x000C6048 File Offset: 0x000C4248
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 409436, RefRangeEnd = 409438, XrefRangeStart = 409436, XrefRangeEnd = 409436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.SequenceConstructPosContext.NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C40 RID: 11328 RVA: 0x00012FA8 File Offset: 0x000111A8
			public SequenceConstructPosContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002C41 RID: 11329 RVA: 0x00012FB1 File Offset: 0x000111B1
			public SequenceConstructPosContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr))
			{
			}

			// Token: 0x17000F16 RID: 3862
			// (get) Token: 0x06002C42 RID: 11330 RVA: 0x000C60BC File Offset: 0x000C42BC
			// (set) Token: 0x06002C43 RID: 11331 RVA: 0x00012FC3 File Offset: 0x000111C3
			public unsafe SequenceNode this_
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F17 RID: 3863
			// (get) Token: 0x06002C44 RID: 11332 RVA: 0x000C60EC File Offset: 0x000C42EC
			// (set) Token: 0x06002C45 RID: 11333 RVA: 0x00012FE2 File Offset: 0x000111E2
			public unsafe BitSet firstpos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F18 RID: 3864
			// (get) Token: 0x06002C46 RID: 11334 RVA: 0x000C611C File Offset: 0x000C431C
			// (set) Token: 0x06002C47 RID: 11335 RVA: 0x00013001 File Offset: 0x00011201
			public unsafe BitSet lastpos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F19 RID: 3865
			// (get) Token: 0x06002C48 RID: 11336 RVA: 0x000C614C File Offset: 0x000C434C
			// (set) Token: 0x06002C49 RID: 11337 RVA: 0x00013020 File Offset: 0x00011220
			public unsafe BitSet lastposLeft
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F1A RID: 3866
			// (get) Token: 0x06002C4A RID: 11338 RVA: 0x000C617C File Offset: 0x000C437C
			// (set) Token: 0x06002C4B RID: 11339 RVA: 0x0001303F File Offset: 0x0001123F
			public unsafe BitSet firstposRight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002281 RID: 8833
			private static readonly IntPtr NativeFieldInfoPtr_this_;

			// Token: 0x04002282 RID: 8834
			private static readonly IntPtr NativeFieldInfoPtr_firstpos;

			// Token: 0x04002283 RID: 8835
			private static readonly IntPtr NativeFieldInfoPtr_lastpos;

			// Token: 0x04002284 RID: 8836
			private static readonly IntPtr NativeFieldInfoPtr_lastposLeft;

			// Token: 0x04002285 RID: 8837
			private static readonly IntPtr NativeFieldInfoPtr_firstposRight;

			// Token: 0x04002286 RID: 8838
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0;
		}
	}
}
