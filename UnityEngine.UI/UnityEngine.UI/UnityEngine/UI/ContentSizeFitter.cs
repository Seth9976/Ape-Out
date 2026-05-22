using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001B RID: 27
	public class ContentSizeFitter : UIBehaviour
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x000157B8 File Offset: 0x000139B8
		// Note: this type is marked as 'beforefieldinit'.
		static ContentSizeFitter()
		{
			Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ContentSizeFitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr);
			ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_HorizontalFit");
			ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_VerticalFit");
			ContentSizeFitter.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_Rect");
			ContentSizeFitter.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_Tracker");
			ContentSizeFitter.NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663917);
			ContentSizeFitter.NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663918);
			ContentSizeFitter.NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663919);
			ContentSizeFitter.NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663920);
			ContentSizeFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663921);
			ContentSizeFitter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663922);
			ContentSizeFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663923);
			ContentSizeFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663924);
			ContentSizeFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663925);
			ContentSizeFitter.NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663926);
			ContentSizeFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663927);
			ContentSizeFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663928);
			ContentSizeFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663929);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0001593C File Offset: 0x00013B3C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00015978 File Offset: 0x00013B78
		public unsafe ContentSizeFitter.FitMode horizontalFit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523532, XrefRangeEnd = 523536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000159B8 File Offset: 0x00013BB8
		// (set) Token: 0x060003DD RID: 989 RVA: 0x000159F4 File Offset: 0x00013BF4
		public unsafe ContentSizeFitter.FitMode verticalFit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523536, XrefRangeEnd = 523540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00015A34 File Offset: 0x00013C34
		public unsafe RectTransform rectTransform
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 523555, RefRangeEnd = 523563, XrefRangeStart = 523540, XrefRangeEnd = 523555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00015A74 File Offset: 0x00013C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentSizeFitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00015AB0 File Offset: 0x00013CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523563, XrefRangeEnd = 523564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00015AEC File Offset: 0x00013CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523564, XrefRangeEnd = 523569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00015B28 File Offset: 0x00013D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00015B64 File Offset: 0x00013D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523569, XrefRangeEnd = 523574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSelfFittingAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00015BA4 File Offset: 0x00013DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523574, XrefRangeEnd = 523578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00015BE0 File Offset: 0x00013DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523578, XrefRangeEnd = 523582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00015C1C File Offset: 0x00013E1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 523587, RefRangeEnd = 523591, XrefRangeStart = 523582, XrefRangeEnd = 523587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003584 File Offset: 0x00001784
		public ContentSizeFitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00015C50 File Offset: 0x00013E50
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0000358D File Offset: 0x0000178D
		public unsafe ContentSizeFitter.FitMode m_HorizontalFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00015C78 File Offset: 0x00013E78
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x000035A8 File Offset: 0x000017A8
		public unsafe ContentSizeFitter.FitMode m_VerticalFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00015CA0 File Offset: 0x00013EA0
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x000035C3 File Offset: 0x000017C3
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00015CD0 File Offset: 0x00013ED0
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x000035E2 File Offset: 0x000017E2
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalFit;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalFit;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x02000097 RID: 151
		[OriginalName("UnityEngine.UI.dll", "", "FitMode")]
		public enum FitMode
		{
			// Token: 0x04000922 RID: 2338
			Unconstrained,
			// Token: 0x04000923 RID: 2339
			MinSize,
			// Token: 0x04000924 RID: 2340
			PreferredSize
		}
	}
}
