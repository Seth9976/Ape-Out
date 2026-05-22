using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200017A RID: 378
	public sealed class SortingGroup : Behaviour
	{
		// Token: 0x06001D0D RID: 7437 RVA: 0x0006ABA4 File Offset: 0x00068DA4
		// Note: this type is marked as 'beforefieldinit'.
		static SortingGroup()
		{
			Il2CppClassPointerStore<SortingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr);
			SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100665886);
			SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100665887);
			SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100665888);
			SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100665889);
			SortingGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100665890);
			SortingGroup.UpdateAllSortingGroupsDelegateField = IL2CPP.ResolveICall<SortingGroup.UpdateAllSortingGroupsDelegate>("UnityEngine.Rendering.SortingGroup::UpdateAllSortingGroups");
			SortingGroup.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingLayerNameDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingLayerName");
			SortingGroup.set_sortingLayerNameDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerNameDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerName");
			SortingGroup.set_sortingLayerIDDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerIDDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerID");
			SortingGroup.set_sortingOrderDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingOrderDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingOrder");
			SortingGroup.get_sortingGroupIDDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupIDDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupID");
			SortingGroup.get_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupOrderDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupOrder");
			SortingGroup.get_indexDelegateField = IL2CPP.ResolveICall<SortingGroup.get_indexDelegate>("UnityEngine.Rendering.SortingGroup::get_index");
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0006ACB0 File Offset: 0x00068EB0
		public unsafe static int invalidSortingGroupID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 503337, RefRangeEnd = 503341, XrefRangeStart = 503333, XrefRangeEnd = 503337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0006ACE0 File Offset: 0x00068EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503345, RefRangeEnd = 503346, XrefRangeStart = 503341, XrefRangeEnd = 503345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SortingGroup GetSortingGroupByIndex(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortingGroup>(intPtr3) : null;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0006AD20 File Offset: 0x00068F20
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0000F948 File Offset: 0x0000DB48
		public unsafe int sortingLayerID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 503350, RefRangeEnd = 503351, XrefRangeStart = 503346, XrefRangeEnd = 503350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				SortingGroup.set_sortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0006AD5C File Offset: 0x00068F5C
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0000F95B File Offset: 0x0000DB5B
		public unsafe int sortingOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 503355, RefRangeEnd = 503356, XrefRangeStart = 503351, XrefRangeEnd = 503355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				SortingGroup.set_sortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0006AD98 File Offset: 0x00068F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0000F91B File Offset: 0x0000DB1B
		public SortingGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0000F924 File Offset: 0x0000DB24
		public static void UpdateAllSortingGroups()
		{
			SortingGroup.UpdateAllSortingGroupsDelegateField();
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0006ADD4 File Offset: 0x00068FD4
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0000F930 File Offset: 0x0000DB30
		public string sortingLayerName
		{
			get
			{
				IntPtr intPtr = SortingGroup.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				SortingGroup.set_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0000F96E File Offset: 0x0000DB6E
		public int sortingGroupID
		{
			get
			{
				return SortingGroup.get_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x0000F980 File Offset: 0x0000DB80
		public int sortingGroupOrder
		{
			get
			{
				return SortingGroup.get_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0000F992 File Offset: 0x0000DB92
		public int index
		{
			get
			{
				return SortingGroup.get_indexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001652 RID: 5714
		private static readonly SortingGroup.UpdateAllSortingGroupsDelegate UpdateAllSortingGroupsDelegateField;

		// Token: 0x04001653 RID: 5715
		private static readonly SortingGroup.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x04001654 RID: 5716
		private static readonly SortingGroup.set_sortingLayerNameDelegate set_sortingLayerNameDelegateField;

		// Token: 0x04001655 RID: 5717
		private static readonly SortingGroup.set_sortingLayerIDDelegate set_sortingLayerIDDelegateField;

		// Token: 0x04001656 RID: 5718
		private static readonly SortingGroup.set_sortingOrderDelegate set_sortingOrderDelegateField;

		// Token: 0x04001657 RID: 5719
		private static readonly SortingGroup.get_sortingGroupIDDelegate get_sortingGroupIDDelegateField;

		// Token: 0x04001658 RID: 5720
		private static readonly SortingGroup.get_sortingGroupOrderDelegate get_sortingGroupOrderDelegateField;

		// Token: 0x04001659 RID: 5721
		private static readonly SortingGroup.get_indexDelegate get_indexDelegateField;

		// Token: 0x020009EB RID: 2539
		// (Invoke) Token: 0x0600326E RID: 12910
		private delegate void UpdateAllSortingGroupsDelegate();

		// Token: 0x020009EC RID: 2540
		// (Invoke) Token: 0x06003270 RID: 12912
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x020009ED RID: 2541
		// (Invoke) Token: 0x06003272 RID: 12914
		private delegate void set_sortingLayerNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020009EE RID: 2542
		// (Invoke) Token: 0x06003274 RID: 12916
		private delegate void set_sortingLayerIDDelegate(IntPtr @this, int value);

		// Token: 0x020009EF RID: 2543
		// (Invoke) Token: 0x06003276 RID: 12918
		private delegate void set_sortingOrderDelegate(IntPtr @this, int value);

		// Token: 0x020009F0 RID: 2544
		// (Invoke) Token: 0x06003278 RID: 12920
		private delegate int get_sortingGroupIDDelegate(IntPtr @this);

		// Token: 0x020009F1 RID: 2545
		// (Invoke) Token: 0x0600327A RID: 12922
		private delegate int get_sortingGroupOrderDelegate(IntPtr @this);

		// Token: 0x020009F2 RID: 2546
		// (Invoke) Token: 0x0600327C RID: 12924
		private delegate int get_indexDelegate(IntPtr @this);
	}
}
