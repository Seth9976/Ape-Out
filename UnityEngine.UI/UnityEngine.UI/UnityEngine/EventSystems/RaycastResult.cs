using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006D RID: 109
	public sealed class RaycastResult : ValueType
	{
		// Token: 0x06000ABB RID: 2747 RVA: 0x000305A8 File Offset: 0x0002E7A8
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastResult()
		{
			Il2CppClassPointerStore<RaycastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "RaycastResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr);
			RaycastResult.NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "m_GameObject");
			RaycastResult.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "module");
			RaycastResult.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "distance");
			RaycastResult.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "index");
			RaycastResult.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "depth");
			RaycastResult.NativeFieldInfoPtr_sortingGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingGroupID");
			RaycastResult.NativeFieldInfoPtr_sortingGroupOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingGroupOrder");
			RaycastResult.NativeFieldInfoPtr_sortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingLayer");
			RaycastResult.NativeFieldInfoPtr_sortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingOrder");
			RaycastResult.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "worldPosition");
			RaycastResult.NativeFieldInfoPtr_worldNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "worldNormal");
			RaycastResult.NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "screenPosition");
			RaycastResult.NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "displayIndex");
			RaycastResult.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665012);
			RaycastResult.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665013);
			RaycastResult.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665014);
			RaycastResult.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665015);
			RaycastResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100665016);
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00030740 File Offset: 0x0002E940
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00030784 File Offset: 0x0002E984
		public unsafe GameObject gameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000307CC File Offset: 0x0002E9CC
		public unsafe bool isValid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 532917, RefRangeEnd = 532918, XrefRangeStart = 532893, XrefRangeEnd = 532917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00030810 File Offset: 0x0002EA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532918, XrefRangeEnd = 532924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00030848 File Offset: 0x0002EA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 533031, RefRangeEnd = 533033, XrefRangeStart = 532924, XrefRangeEnd = 533031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00005D65 File Offset: 0x00003F65
		public RaycastResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00005D6E File Offset: 0x00003F6E
		public RaycastResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr))
		{
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00030884 File Offset: 0x0002EA84
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00005D80 File Offset: 0x00003F80
		public unsafe GameObject m_GameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_m_GameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_m_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000308B4 File Offset: 0x0002EAB4
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00005D9F File Offset: 0x00003F9F
		public unsafe BaseRaycaster module
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_module);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x000308E4 File Offset: 0x0002EAE4
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00005DBE File Offset: 0x00003FBE
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0003090C File Offset: 0x0002EB0C
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00005DD9 File Offset: 0x00003FD9
		public unsafe float index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00030934 File Offset: 0x0002EB34
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00005DF4 File Offset: 0x00003FF4
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0003095C File Offset: 0x0002EB5C
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00005E0F File Offset: 0x0000400F
		public unsafe int sortingGroupID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupID)) = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00030984 File Offset: 0x0002EB84
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00005E2A File Offset: 0x0000402A
		public unsafe int sortingGroupOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingGroupOrder)) = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000309AC File Offset: 0x0002EBAC
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00005E45 File Offset: 0x00004045
		public unsafe int sortingLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingLayer)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000309D4 File Offset: 0x0002EBD4
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00005E60 File Offset: 0x00004060
		public unsafe int sortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingOrder)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000309FC File Offset: 0x0002EBFC
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00005E7B File Offset: 0x0000407B
		public unsafe Vector3 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00030A24 File Offset: 0x0002EC24
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00005E96 File Offset: 0x00004096
		public unsafe Vector3 worldNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldNormal)) = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00030A4C File Offset: 0x0002EC4C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00005EB1 File Offset: 0x000040B1
		public unsafe Vector2 screenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_screenPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_screenPosition)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00030A74 File Offset: 0x0002EC74
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00005ECC File Offset: 0x000040CC
		public unsafe int displayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_displayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_displayIndex)) = value;
			}
		}

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr_m_GameObject;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeFieldInfoPtr_module;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeFieldInfoPtr_sortingGroupID;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr_sortingGroupOrder;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_sortingLayer;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_sortingOrder;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_worldNormal;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_screenPosition;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_displayIndex;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
