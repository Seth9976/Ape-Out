using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppTMPro
{
	// Token: 0x02000072 RID: 114
	public class TextContainer : UIBehaviour
	{
		// Token: 0x06000E3A RID: 3642 RVA: 0x00039CEC File Offset: 0x00037EEC
		// Note: this type is marked as 'beforefieldinit'.
		static TextContainer()
		{
			Il2CppClassPointerStore<TextContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TextContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextContainer>.NativeClassPtr);
			TextContainer.NativeFieldInfoPtr_m_hasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_hasChanged");
			TextContainer.NativeFieldInfoPtr_m_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_pivot");
			TextContainer.NativeFieldInfoPtr_m_anchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_anchorPosition");
			TextContainer.NativeFieldInfoPtr_m_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_rect");
			TextContainer.NativeFieldInfoPtr_m_isDefaultWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isDefaultWidth");
			TextContainer.NativeFieldInfoPtr_m_isDefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isDefaultHeight");
			TextContainer.NativeFieldInfoPtr_m_isAutoFitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_isAutoFitting");
			TextContainer.NativeFieldInfoPtr_m_corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_corners");
			TextContainer.NativeFieldInfoPtr_m_worldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_worldCorners");
			TextContainer.NativeFieldInfoPtr_m_margins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_margins");
			TextContainer.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_rectTransform");
			TextContainer.NativeFieldInfoPtr_k_defaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "k_defaultSize");
			TextContainer.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, "m_textMeshPro");
			TextContainer.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664876);
			TextContainer.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664877);
			TextContainer.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664878);
			TextContainer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664879);
			TextContainer.NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664880);
			TextContainer.NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664881);
			TextContainer.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664882);
			TextContainer.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664883);
			TextContainer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664884);
			TextContainer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664885);
			TextContainer.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664886);
			TextContainer.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664887);
			TextContainer.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664888);
			TextContainer.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664889);
			TextContainer.NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664890);
			TextContainer.NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664891);
			TextContainer.NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664892);
			TextContainer.NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664893);
			TextContainer.NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664894);
			TextContainer.NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664895);
			TextContainer.NativeMethodInfoPtr_get_margins_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664896);
			TextContainer.NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664897);
			TextContainer.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664898);
			TextContainer.NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664899);
			TextContainer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664900);
			TextContainer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664901);
			TextContainer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664902);
			TextContainer.NativeMethodInfoPtr_OnContainerChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664903);
			TextContainer.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664904);
			TextContainer.NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664905);
			TextContainer.NativeMethodInfoPtr_UpdateCorners_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664906);
			TextContainer.NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664907);
			TextContainer.NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664908);
			TextContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextContainer>.NativeClassPtr, 100664909);
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0003A0C8 File Offset: 0x000382C8
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x0003A104 File Offset: 0x00038304
		public unsafe bool hasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0003A144 File Offset: 0x00038344
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x0003A180 File Offset: 0x00038380
		public unsafe Vector2 pivot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 471990, RefRangeEnd = 471991, XrefRangeStart = 471981, XrefRangeEnd = 471990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0003A1C0 File Offset: 0x000383C0
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x0003A1FC File Offset: 0x000383FC
		public unsafe TextContainerAnchors anchorPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471991, XrefRangeEnd = 472002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0003A23C File Offset: 0x0003843C
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0003A278 File Offset: 0x00038478
		public unsafe Rect rect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472002, XrefRangeEnd = 472003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0003A2B8 File Offset: 0x000384B8
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0003A2F4 File Offset: 0x000384F4
		public unsafe Vector2 size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472003, XrefRangeEnd = 472004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0003A334 File Offset: 0x00038534
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0003A370 File Offset: 0x00038570
		public unsafe float width
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 472004, RefRangeEnd = 472010, XrefRangeStart = 472004, XrefRangeEnd = 472004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472010, XrefRangeEnd = 472011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0003A3B0 File Offset: 0x000385B0
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0003A3EC File Offset: 0x000385EC
		public unsafe float height
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 472011, RefRangeEnd = 472019, XrefRangeStart = 472011, XrefRangeEnd = 472011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472019, XrefRangeEnd = 472020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0003A42C File Offset: 0x0003862C
		public unsafe bool isDefaultWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0003A468 File Offset: 0x00038668
		public unsafe bool isDefaultHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0003A4A4 File Offset: 0x000386A4
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0003A4E0 File Offset: 0x000386E0
		public unsafe bool isAutoFitting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0003A520 File Offset: 0x00038720
		public unsafe Il2CppStructArray<Vector3> corners
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0003A560 File Offset: 0x00038760
		public unsafe Il2CppStructArray<Vector3> worldCorners
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003A5A0 File Offset: 0x000387A0
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0003A5DC File Offset: 0x000387DC
		public unsafe Vector4 margins
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_margins_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472020, XrefRangeEnd = 472021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0003A61C File Offset: 0x0003881C
		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472021, XrefRangeEnd = 472036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0003A65C File Offset: 0x0003885C
		public unsafe TextMeshPro textMeshPro
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472036, XrefRangeEnd = 472051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr3) : null;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0003A69C File Offset: 0x0003889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472051, XrefRangeEnd = 472066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0003A6D8 File Offset: 0x000388D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472066, XrefRangeEnd = 472067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0003A714 File Offset: 0x00038914
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003A750 File Offset: 0x00038950
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 472115, RefRangeEnd = 472125, XrefRangeStart = 472067, XrefRangeEnd = 472115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnContainerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_OnContainerChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0003A784 File Offset: 0x00038984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472125, XrefRangeEnd = 472178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextContainer.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0003A7C0 File Offset: 0x000389C0
		[CallerCount(0)]
		public unsafe void SetRect(Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0003A800 File Offset: 0x00038A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 472192, RefRangeEnd = 472193, XrefRangeStart = 472178, XrefRangeEnd = 472192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_UpdateCorners_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0003A834 File Offset: 0x00038A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472193, XrefRangeEnd = 472197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPivot(TextContainerAnchors anchor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0003A880 File Offset: 0x00038A80
		[CallerCount(0)]
		public unsafe TextContainerAnchors GetAnchorPosition(Vector2 pivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pivot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0003A8CC File Offset: 0x00038ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472197, XrefRangeEnd = 472205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00008B52 File Offset: 0x00006D52
		public TextContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0003A908 File Offset: 0x00038B08
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00008B5B File Offset: 0x00006D5B
		public unsafe bool m_hasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_hasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_hasChanged)) = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0003A930 File Offset: 0x00038B30
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00008B76 File Offset: 0x00006D76
		public unsafe Vector2 m_pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_pivot)) = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0003A958 File Offset: 0x00038B58
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00008B91 File Offset: 0x00006D91
		public unsafe TextContainerAnchors m_anchorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_anchorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_anchorPosition)) = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0003A980 File Offset: 0x00038B80
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00008BAC File Offset: 0x00006DAC
		public unsafe Rect m_rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rect)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0003A9A8 File Offset: 0x00038BA8
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00008BC7 File Offset: 0x00006DC7
		public unsafe bool m_isDefaultWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultWidth)) = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0003A9D0 File Offset: 0x00038BD0
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00008BE2 File Offset: 0x00006DE2
		public unsafe bool m_isDefaultHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isDefaultHeight)) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00008BFD File Offset: 0x00006DFD
		public unsafe bool m_isAutoFitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isAutoFitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_isAutoFitting)) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0003AA20 File Offset: 0x00038C20
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00008C18 File Offset: 0x00006E18
		public unsafe Il2CppStructArray<Vector3> m_corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0003AA50 File Offset: 0x00038C50
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00008C37 File Offset: 0x00006E37
		public unsafe Il2CppStructArray<Vector3> m_worldCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_worldCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_worldCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003AA80 File Offset: 0x00038C80
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00008C56 File Offset: 0x00006E56
		public unsafe Vector4 m_margins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_margins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_margins)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003AAA8 File Offset: 0x00038CA8
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00008C71 File Offset: 0x00006E71
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00008C90 File Offset: 0x00006E90
		public unsafe static Vector2 k_defaultSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TextContainer.NativeFieldInfoPtr_k_defaultSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextContainer.NativeFieldInfoPtr_k_defaultSize, (void*)(&value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00008C9E File Offset: 0x00006E9E
		public unsafe TextMeshPro m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextContainer.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr_m_hasChanged;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_m_pivot;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_m_anchorPosition;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr_m_rect;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultWidth;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultHeight;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_m_isAutoFitting;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_m_corners;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_m_worldCorners;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_m_margins;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_k_defaultSize;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorPosition_Public_get_TextContainerAnchors_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorPosition_Public_set_Void_TextContainerAnchors_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultWidth_Public_get_Boolean_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultHeight_Public_get_Boolean_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_get_isAutoFitting_Public_get_Boolean_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_set_isAutoFitting_Public_set_Void_Boolean_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_get_corners_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_get_worldCorners_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_get_margins_Public_get_Vector4_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_set_margins_Public_set_Void_Vector4_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_get_textMeshPro_Public_get_TextMeshPro_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_OnContainerChanged_Private_Void_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_SetRect_Private_Void_Vector2_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCorners_Private_Void_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_GetPivot_Private_Vector2_TextContainerAnchors_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_GetAnchorPosition_Private_TextContainerAnchors_Vector2_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
