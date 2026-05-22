using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200001E RID: 30
	public class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		// Token: 0x06000417 RID: 1047 RVA: 0x0001660C File Offset: 0x0001480C
		// Note: this type is marked as 'beforefieldinit'.
		static HorizontalOrVerticalLayoutGroup()
		{
			Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "HorizontalOrVerticalLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr);
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_Spacing");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ReverseArrangement");
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663953);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663954);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663955);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663956);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663957);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663958);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663959);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663960);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663961);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663962);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663963);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663964);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663965);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663966);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663967);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663968);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663969);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663970);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663971);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663972);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0001686C File Offset: 0x00014A6C
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x000168A8 File Offset: 0x00014AA8
		public unsafe float spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 523681, RefRangeEnd = 523683, XrefRangeStart = 523675, XrefRangeEnd = 523681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x000168E8 File Offset: 0x00014AE8
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00016924 File Offset: 0x00014B24
		public unsafe bool childForceExpandWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523683, XrefRangeEnd = 523685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00016964 File Offset: 0x00014B64
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000169A0 File Offset: 0x00014BA0
		public unsafe bool childForceExpandHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523685, XrefRangeEnd = 523687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000169E0 File Offset: 0x00014BE0
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00016A1C File Offset: 0x00014C1C
		public unsafe bool childControlWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523687, XrefRangeEnd = 523689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00016A5C File Offset: 0x00014C5C
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00016A98 File Offset: 0x00014C98
		public unsafe bool childControlHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523689, XrefRangeEnd = 523691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00016AD8 File Offset: 0x00014CD8
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00016B14 File Offset: 0x00014D14
		public unsafe bool childScaleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523691, XrefRangeEnd = 523693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00016B54 File Offset: 0x00014D54
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00016B90 File Offset: 0x00014D90
		public unsafe bool childScaleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523693, XrefRangeEnd = 523695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00016BD0 File Offset: 0x00014DD0
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00016C0C File Offset: 0x00014E0C
		public unsafe bool reverseArrangement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523695, XrefRangeEnd = 523697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00016C4C File Offset: 0x00014E4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 523720, RefRangeEnd = 523724, XrefRangeStart = 523697, XrefRangeEnd = 523720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00016C98 File Offset: 0x00014E98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 523805, RefRangeEnd = 523809, XrefRangeStart = 523724, XrefRangeEnd = 523805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildrenAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00016CE4 File Offset: 0x00014EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523809, XrefRangeEnd = 523819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childForceExpand;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &preferred;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flexible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00016D80 File Offset: 0x00014F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HorizontalOrVerticalLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000036B1 File Offset: 0x000018B1
		public HorizontalOrVerticalLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00016DBC File Offset: 0x00014FBC
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x000036BA File Offset: 0x000018BA
		public unsafe float m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00016DE4 File Offset: 0x00014FE4
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x000036D5 File Offset: 0x000018D5
		public unsafe bool m_ChildForceExpandWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00016E0C File Offset: 0x0001500C
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x000036F0 File Offset: 0x000018F0
		public unsafe bool m_ChildForceExpandHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00016E34 File Offset: 0x00015034
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0000370B File Offset: 0x0000190B
		public unsafe bool m_ChildControlWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00016E5C File Offset: 0x0001505C
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00003726 File Offset: 0x00001926
		public unsafe bool m_ChildControlHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00016E84 File Offset: 0x00015084
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00003741 File Offset: 0x00001941
		public unsafe bool m_ChildScaleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00016EAC File Offset: 0x000150AC
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0000375C File Offset: 0x0000195C
		public unsafe bool m_ChildScaleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00016ED4 File Offset: 0x000150D4
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00003777 File Offset: 0x00001977
		public unsafe bool m_ReverseArrangement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement)) = value;
			}
		}

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandWidth;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandHeight;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlWidth;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlHeight;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleWidth;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleHeight;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_m_ReverseArrangement;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Single_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
