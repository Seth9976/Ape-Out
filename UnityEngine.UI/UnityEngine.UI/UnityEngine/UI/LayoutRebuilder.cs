using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x02000026 RID: 38
	public class LayoutRebuilder : Object
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x00018E08 File Offset: 0x00017008
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutRebuilder()
		{
			Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutRebuilder");
			LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "m_ToRebuild");
			LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "m_CachedHashFromTransform");
			LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "s_Rebuilders");
			LayoutRebuilder.NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664053);
			LayoutRebuilder.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664054);
			LayoutRebuilder.NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664056);
			LayoutRebuilder.NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664057);
			LayoutRebuilder.NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664058);
			LayoutRebuilder.NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664059);
			LayoutRebuilder.NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664060);
			LayoutRebuilder.NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664061);
			LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664062);
			LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664063);
			LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664064);
			LayoutRebuilder.NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664065);
			LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664066);
			LayoutRebuilder.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664067);
			LayoutRebuilder.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664068);
			LayoutRebuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664069);
			LayoutRebuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664070);
			LayoutRebuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664071);
			LayoutRebuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664072);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00018FE8 File Offset: 0x000171E8
		[CallerCount(0)]
		public unsafe void Initialize(RectTransform controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001902C File Offset: 0x0001722C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00019060 File Offset: 0x00017260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524236, XrefRangeEnd = 524240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReapplyDrivenProperties(RectTransform driven)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00019098 File Offset: 0x00017298
		public unsafe virtual Transform transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000190D8 File Offset: 0x000172D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524240, XrefRangeEnd = 524252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00019114 File Offset: 0x00017314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524271, RefRangeEnd = 524273, XrefRangeStart = 524252, XrefRangeEnd = 524271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StripDisabledBehavioursFromList(List<Component> components)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001914C File Offset: 0x0001734C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524286, RefRangeEnd = 524288, XrefRangeStart = 524273, XrefRangeEnd = 524286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00019184 File Offset: 0x00017384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524335, RefRangeEnd = 524336, XrefRangeStart = 524288, XrefRangeEnd = 524335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000191C4 File Offset: 0x000173C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 524415, RefRangeEnd = 524418, XrefRangeStart = 524336, XrefRangeEnd = 524415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00019218 File Offset: 0x00017418
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 524475, RefRangeEnd = 524478, XrefRangeStart = 524418, XrefRangeEnd = 524475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001926C File Offset: 0x0001746C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 524594, RefRangeEnd = 524611, XrefRangeStart = 524478, XrefRangeEnd = 524594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkLayoutForRebuild(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000192A4 File Offset: 0x000174A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524664, RefRangeEnd = 524665, XrefRangeStart = 524611, XrefRangeEnd = 524664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutRoot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000192F8 File Offset: 0x000174F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524699, RefRangeEnd = 524700, XrefRangeStart = 524665, XrefRangeEnd = 524699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkLayoutRootForRebuild(RectTransform controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00019330 File Offset: 0x00017530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524700, XrefRangeEnd = 524708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00019364 File Offset: 0x00017564
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00019398 File Offset: 0x00017598
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000193E0 File Offset: 0x000175E0
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00019438 File Offset: 0x00017638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524708, XrefRangeEnd = 524712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001947C File Offset: 0x0001767C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutRebuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000039F2 File Offset: 0x00001BF2
		public LayoutRebuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000194B8 File Offset: 0x000176B8
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x000039FB File Offset: 0x00001BFB
		public unsafe RectTransform m_ToRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x000194E8 File Offset: 0x000176E8
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00003A1A File Offset: 0x00001C1A
		public unsafe int m_CachedHashFromTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00019510 File Offset: 0x00017710
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00003A35 File Offset: 0x00001C35
		public unsafe static ObjectPool<LayoutRebuilder> s_Rebuilders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LayoutRebuilder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_m_ToRebuild;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedHashFromTransform;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_s_Rebuilders;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("UnityEngine.UI.LayoutRebuilder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000BE1 RID: 3041 RVA: 0x00033EF4 File Offset: 0x000320F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr);
				LayoutRebuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__10_0");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_0");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_1");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_2");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_3");
				LayoutRebuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664074);
				LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_Void_LayoutRebuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664075);
				LayoutRebuilder.__c.NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664076);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664077);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664078);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664079);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664080);
			}

			// Token: 0x06000BE2 RID: 3042 RVA: 0x00034024 File Offset: 0x00032224
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BE3 RID: 3043 RVA: 0x00034060 File Offset: 0x00032260
			[CallerCount(0)]
			public unsafe void __cctor_b__5_0(LayoutRebuilder x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_Void_LayoutRebuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BE4 RID: 3044 RVA: 0x000340A4 File Offset: 0x000322A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524196, XrefRangeEnd = 524200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StripDisabledBehavioursFromList_b__10_0(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000BE5 RID: 3045 RVA: 0x000340F4 File Offset: 0x000322F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524200, XrefRangeEnd = 524208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_0(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BE6 RID: 3046 RVA: 0x00034138 File Offset: 0x00032338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524208, XrefRangeEnd = 524216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_1(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BE7 RID: 3047 RVA: 0x0003417C File Offset: 0x0003237C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524216, XrefRangeEnd = 524224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_2(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BE8 RID: 3048 RVA: 0x000341C0 File Offset: 0x000323C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524224, XrefRangeEnd = 524236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_3(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x0000668D File Offset: 0x0000488D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00034204 File Offset: 0x00032404
			// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00006696 File Offset: 0x00004896
			public unsafe static LayoutRebuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutRebuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003422C File Offset: 0x0003242C
			// (set) Token: 0x06000BED RID: 3053 RVA: 0x000066A8 File Offset: 0x000048A8
			public unsafe static Predicate<Component> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00034254 File Offset: 0x00032454
			// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000066BA File Offset: 0x000048BA
			public unsafe static UnityAction<Component> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0003427C File Offset: 0x0003247C
			// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x000066CC File Offset: 0x000048CC
			public unsafe static UnityAction<Component> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000342A4 File Offset: 0x000324A4
			// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000066DE File Offset: 0x000048DE
			public unsafe static UnityAction<Component> __9__12_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x000342CC File Offset: 0x000324CC
			// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000066F0 File Offset: 0x000048F0
			public unsafe static UnityAction<Component> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400093B RID: 2363
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400093C RID: 2364
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400093D RID: 2365
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400093E RID: 2366
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x0400093F RID: 2367
			private static readonly IntPtr NativeFieldInfoPtr___9__12_2;

			// Token: 0x04000940 RID: 2368
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x04000941 RID: 2369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000942 RID: 2370
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_Void_LayoutRebuilder_0;

			// Token: 0x04000943 RID: 2371
			private static readonly IntPtr NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0;

			// Token: 0x04000944 RID: 2372
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0;

			// Token: 0x04000945 RID: 2373
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0;

			// Token: 0x04000946 RID: 2374
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0;

			// Token: 0x04000947 RID: 2375
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0;
		}
	}
}
