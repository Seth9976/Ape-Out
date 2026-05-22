using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Timeline
{
	// Token: 0x0200001E RID: 30
	public class IntervalTree<T> : Object
	{
		// Token: 0x0600033C RID: 828 RVA: 0x00011374 File Offset: 0x0000F574
		// Note: this type is marked as 'beforefieldinit'.
		static IntervalTree()
		{
			Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IntervalTree`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr);
			IntervalTree<T>.NativeFieldInfoPtr_kMinNodeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, "kMinNodeSize");
			IntervalTree<T>.NativeFieldInfoPtr_kInvalidNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, "kInvalidNode");
			IntervalTree<T>.NativeFieldInfoPtr_kCenterUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, "kCenterUnknown");
			IntervalTree<T>.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, "m_Entries");
			IntervalTree<T>.NativeFieldInfoPtr_m_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, "m_Nodes");
			IntervalTree<T>.NativeFieldInfoPtr__dirty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, "<dirty>k__BackingField");
			IntervalTree<T>.NativeMethodInfoPtr_get_dirty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663864);
			IntervalTree<T>.NativeMethodInfoPtr_set_dirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663865);
			IntervalTree<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663866);
			IntervalTree<T>.NativeMethodInfoPtr_IntersectsWith_Public_Void_Int64_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663867);
			IntervalTree<T>.NativeMethodInfoPtr_IntersectsWithRange_Public_Void_Int64_Int64_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663868);
			IntervalTree<T>.NativeMethodInfoPtr_UpdateIntervals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663869);
			IntervalTree<T>.NativeMethodInfoPtr_Query_Private_Void_IntervalTreeNode_Int64_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663870);
			IntervalTree<T>.NativeMethodInfoPtr_QueryRange_Private_Void_IntervalTreeNode_Int64_Int64_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663871);
			IntervalTree<T>.NativeMethodInfoPtr_Rebuild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663872);
			IntervalTree<T>.NativeMethodInfoPtr_Rebuild_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663873);
			IntervalTree<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663874);
			IntervalTree<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, 100663875);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00011548 File Offset: 0x0000F748
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00011584 File Offset: 0x0000F784
		public unsafe bool dirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_get_dirty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_set_dirty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000115C4 File Offset: 0x0000F7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477638, XrefRangeEnd = 477643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00011654 File Offset: 0x0000F854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477643, XrefRangeEnd = 477645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntersectsWith(long value, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_IntersectsWith_Public_Void_Int64_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000116A4 File Offset: 0x0000F8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477645, XrefRangeEnd = 477647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntersectsWithRange(long start, long end, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_IntersectsWithRange_Public_Void_Int64_Int64_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00011704 File Offset: 0x0000F904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477647, XrefRangeEnd = 477655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIntervals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_UpdateIntervals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00011738 File Offset: 0x0000F938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477655, XrefRangeEnd = 477656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intervalTreeNode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_Query_Private_Void_IntervalTreeNode_Int64_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00011798 File Offset: 0x0000F998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477656, XrefRangeEnd = 477657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intervalTreeNode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_QueryRange_Private_Void_IntervalTreeNode_Int64_Int64_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00011808 File Offset: 0x0000FA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477657, XrefRangeEnd = 477673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rebuild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_Rebuild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001183C File Offset: 0x0000FA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477673, XrefRangeEnd = 477684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Rebuild(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_Rebuild_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00011894 File Offset: 0x0000FA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477684, XrefRangeEnd = 477686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477698, RefRangeEnd = 477699, XrefRangeStart = 477686, XrefRangeEnd = 477698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntervalTree()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalTree<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00003045 File Offset: 0x00001245
		public IntervalTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00011904 File Offset: 0x0000FB04
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000304E File Offset: 0x0000124E
		public unsafe static int kMinNodeSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IntervalTree<T>.NativeFieldInfoPtr_kMinNodeSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntervalTree<T>.NativeFieldInfoPtr_kMinNodeSize, (void*)(&value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00011920 File Offset: 0x0000FB20
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000305C File Offset: 0x0000125C
		public unsafe static int kInvalidNode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IntervalTree<T>.NativeFieldInfoPtr_kInvalidNode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntervalTree<T>.NativeFieldInfoPtr_kInvalidNode, (void*)(&value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0001193C File Offset: 0x0000FB3C
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000306A File Offset: 0x0000126A
		public unsafe static long kCenterUnknown
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(IntervalTree<T>.NativeFieldInfoPtr_kCenterUnknown, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntervalTree<T>.NativeFieldInfoPtr_kCenterUnknown, (void*)(&value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00011958 File Offset: 0x0000FB58
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00003078 File Offset: 0x00001278
		public unsafe List<IntervalTree<T>.Entry> m_Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.NativeFieldInfoPtr_m_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntervalTree<T>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.NativeFieldInfoPtr_m_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00011988 File Offset: 0x0000FB88
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00003097 File Offset: 0x00001297
		public unsafe List<IntervalTreeNode> m_Nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.NativeFieldInfoPtr_m_Nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntervalTreeNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.NativeFieldInfoPtr_m_Nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000119B8 File Offset: 0x0000FBB8
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000030B6 File Offset: 0x000012B6
		public unsafe bool _dirty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.NativeFieldInfoPtr__dirty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.NativeFieldInfoPtr__dirty_k__BackingField)) = value;
			}
		}

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_kMinNodeSize;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_kInvalidNode;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_kCenterUnknown;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_m_Entries;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_m_Nodes;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr__dirty_k__BackingField;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_dirty_Public_get_Boolean_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_set_dirty_Internal_set_Void_Boolean_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_IntersectsWith_Public_Void_Int64_List_1_T_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_IntersectsWithRange_Public_Void_Int64_Int64_List_1_T_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIntervals_Public_Void_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_Query_Private_Void_IntervalTreeNode_Int64_List_1_T_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_QueryRange_Private_Void_IntervalTreeNode_Int64_Int64_List_1_T_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Private_Void_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Private_Int32_Int32_Int32_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000071 RID: 113
		public sealed class Entry : ValueType
		{
			// Token: 0x060005EE RID: 1518 RVA: 0x0001B330 File Offset: 0x00019530
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<IntervalTree<T>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntervalTree<T>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalTree<T>.Entry>.NativeClassPtr);
				IntervalTree<T>.Entry.NativeFieldInfoPtr_intervalStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>.Entry>.NativeClassPtr, "intervalStart");
				IntervalTree<T>.Entry.NativeFieldInfoPtr_intervalEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>.Entry>.NativeClassPtr, "intervalEnd");
				IntervalTree<T>.Entry.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTree<T>.Entry>.NativeClassPtr, "item");
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x0000417E File Offset: 0x0000237E
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x00004187 File Offset: 0x00002387
			public Entry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalTree<T>.Entry>.NativeClassPtr))
			{
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001B3D4 File Offset: 0x000195D4
			// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00004199 File Offset: 0x00002399
			public unsafe long intervalStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.Entry.NativeFieldInfoPtr_intervalStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.Entry.NativeFieldInfoPtr_intervalStart)) = value;
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001B3FC File Offset: 0x000195FC
			// (set) Token: 0x060005F4 RID: 1524 RVA: 0x000041B4 File Offset: 0x000023B4
			public unsafe long intervalEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.Entry.NativeFieldInfoPtr_intervalEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.Entry.NativeFieldInfoPtr_intervalEnd)) = value;
				}
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001B424 File Offset: 0x00019624
			// (set) Token: 0x060005F6 RID: 1526 RVA: 0x0001B44C File Offset: 0x0001964C
			public unsafe T item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.Entry.NativeFieldInfoPtr_item);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalTree<T>.Entry.NativeFieldInfoPtr_item);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400049A RID: 1178
			private static readonly IntPtr NativeFieldInfoPtr_intervalStart;

			// Token: 0x0400049B RID: 1179
			private static readonly IntPtr NativeFieldInfoPtr_intervalEnd;

			// Token: 0x0400049C RID: 1180
			private static readonly IntPtr NativeFieldInfoPtr_item;
		}
	}
}
