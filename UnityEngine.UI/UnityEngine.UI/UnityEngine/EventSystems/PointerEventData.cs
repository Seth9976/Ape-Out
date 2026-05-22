using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004F RID: 79
	public class PointerEventData : BaseEventData
	{
		// Token: 0x060008D6 RID: 2262 RVA: 0x00029560 File Offset: 0x00027760
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventData()
		{
			Il2CppClassPointerStore<PointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PointerEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr);
			PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerEnter>k__BackingField");
			PointerEventData.NativeFieldInfoPtr_m_PointerPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "m_PointerPress");
			PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<lastPress>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<rawPointerPress>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerDrag>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerClick>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerCurrentRaycast>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerPressRaycast>k__BackingField");
			PointerEventData.NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "hovered");
			PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<eligibleForClick>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerId>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<position>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__delta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<delta>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pressPosition>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<worldPosition>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<worldNormal>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<clickTime>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<clickCount>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<scrollDelta>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<useDragThreshold>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<dragging>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<button>k__BackingField");
			PointerEventData.NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664723);
			PointerEventData.NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664724);
			PointerEventData.NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664725);
			PointerEventData.NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664726);
			PointerEventData.NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664727);
			PointerEventData.NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664728);
			PointerEventData.NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664729);
			PointerEventData.NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664730);
			PointerEventData.NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664731);
			PointerEventData.NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664732);
			PointerEventData.NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664733);
			PointerEventData.NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664734);
			PointerEventData.NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664735);
			PointerEventData.NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664736);
			PointerEventData.NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664737);
			PointerEventData.NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664738);
			PointerEventData.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664739);
			PointerEventData.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664740);
			PointerEventData.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664741);
			PointerEventData.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664742);
			PointerEventData.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664743);
			PointerEventData.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664744);
			PointerEventData.NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664745);
			PointerEventData.NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664746);
			PointerEventData.NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664747);
			PointerEventData.NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664748);
			PointerEventData.NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664749);
			PointerEventData.NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664750);
			PointerEventData.NativeMethodInfoPtr_get_clickTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664751);
			PointerEventData.NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664752);
			PointerEventData.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664753);
			PointerEventData.NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664754);
			PointerEventData.NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664755);
			PointerEventData.NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664756);
			PointerEventData.NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664757);
			PointerEventData.NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664758);
			PointerEventData.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664759);
			PointerEventData.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664760);
			PointerEventData.NativeMethodInfoPtr_get_button_Public_get_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664761);
			PointerEventData.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664762);
			PointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664763);
			PointerEventData.NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664764);
			PointerEventData.NativeMethodInfoPtr_IsScrolling_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664765);
			PointerEventData.NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664766);
			PointerEventData.NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664767);
			PointerEventData.NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664768);
			PointerEventData.NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664769);
			PointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664770);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00029B08 File Offset: 0x00027D08
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00029B48 File Offset: 0x00027D48
		public unsafe GameObject pointerEnter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00029B8C File Offset: 0x00027D8C
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00029BCC File Offset: 0x00027DCC
		public unsafe GameObject lastPress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00029C10 File Offset: 0x00027E10
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00029C50 File Offset: 0x00027E50
		public unsafe GameObject rawPointerPress
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00029C94 File Offset: 0x00027E94
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00029CD4 File Offset: 0x00027ED4
		public unsafe GameObject pointerDrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00029D18 File Offset: 0x00027F18
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00029D58 File Offset: 0x00027F58
		public unsafe GameObject pointerClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00029D9C File Offset: 0x00027F9C
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00029DD4 File Offset: 0x00027FD4
		public unsafe RaycastResult pointerCurrentRaycast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00029E1C File Offset: 0x0002801C
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00029E54 File Offset: 0x00028054
		public unsafe RaycastResult pointerPressRaycast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00029E9C File Offset: 0x0002809C
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00029ED8 File Offset: 0x000280D8
		public unsafe bool eligibleForClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00029F18 File Offset: 0x00028118
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00029F54 File Offset: 0x00028154
		public unsafe int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00029F94 File Offset: 0x00028194
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00029FD0 File Offset: 0x000281D0
		public unsafe Vector2 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0002A010 File Offset: 0x00028210
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x0002A04C File Offset: 0x0002824C
		public unsafe Vector2 delta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0002A08C File Offset: 0x0002828C
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0002A0C8 File Offset: 0x000282C8
		public unsafe Vector2 pressPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0002A108 File Offset: 0x00028308
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x0002A144 File Offset: 0x00028344
		public unsafe Vector3 worldPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0002A184 File Offset: 0x00028384
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x0002A1C0 File Offset: 0x000283C0
		public unsafe Vector3 worldNormal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0002A200 File Offset: 0x00028400
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x0002A23C File Offset: 0x0002843C
		public unsafe float clickTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_clickTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002A27C File Offset: 0x0002847C
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x0002A2B8 File Offset: 0x000284B8
		public unsafe int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0002A2F8 File Offset: 0x000284F8
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x0002A334 File Offset: 0x00028534
		public unsafe Vector2 scrollDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002A374 File Offset: 0x00028574
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x0002A3B0 File Offset: 0x000285B0
		public unsafe bool useDragThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0002A3F0 File Offset: 0x000285F0
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0002A42C File Offset: 0x0002862C
		public unsafe bool dragging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0002A46C File Offset: 0x0002866C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x0002A4A8 File Offset: 0x000286A8
		public unsafe PointerEventData.InputButton button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_button_Public_get_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002A4E8 File Offset: 0x000286E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 530361, RefRangeEnd = 530366, XrefRangeStart = 530347, XrefRangeEnd = 530361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0002A534 File Offset: 0x00028734
		[CallerCount(0)]
		public unsafe bool IsPointerMoving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0002A570 File Offset: 0x00028770
		[CallerCount(0)]
		public unsafe bool IsScrolling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_IsScrolling_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0002A5AC File Offset: 0x000287AC
		public unsafe Camera enterEventCamera
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 530378, RefRangeEnd = 530382, XrefRangeStart = 530366, XrefRangeEnd = 530378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0002A5EC File Offset: 0x000287EC
		public unsafe Camera pressEventCamera
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 530394, RefRangeEnd = 530406, XrefRangeStart = 530382, XrefRangeEnd = 530394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0002A62C File Offset: 0x0002882C
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x0002A66C File Offset: 0x0002886C
		public unsafe GameObject pointerPress
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 530422, RefRangeEnd = 530436, XrefRangeStart = 530406, XrefRangeEnd = 530422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0002A6B0 File Offset: 0x000288B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 530523, RefRangeEnd = 530524, XrefRangeStart = 530436, XrefRangeEnd = 530523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000050D2 File Offset: 0x000032D2
		public PointerEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0002A6F4 File Offset: 0x000288F4
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x000050DB File Offset: 0x000032DB
		public unsafe GameObject _pointerEnter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0002A724 File Offset: 0x00028924
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x000050FA File Offset: 0x000032FA
		public unsafe GameObject m_PointerPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_m_PointerPress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_m_PointerPress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0002A754 File Offset: 0x00028954
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00005119 File Offset: 0x00003319
		public unsafe GameObject _lastPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0002A784 File Offset: 0x00028984
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00005138 File Offset: 0x00003338
		public unsafe GameObject _rawPointerPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0002A7B4 File Offset: 0x000289B4
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x00005157 File Offset: 0x00003357
		public unsafe GameObject _pointerDrag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0002A7E4 File Offset: 0x000289E4
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00005176 File Offset: 0x00003376
		public unsafe GameObject _pointerClick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0002A814 File Offset: 0x00028A14
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00005195 File Offset: 0x00003395
		public RaycastResult _pointerCurrentRaycast_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField);
				return new RaycastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0002A844 File Offset: 0x00028A44
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x000051C3 File Offset: 0x000033C3
		public RaycastResult _pointerPressRaycast_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField);
				return new RaycastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0002A874 File Offset: 0x00028A74
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000051F1 File Offset: 0x000033F1
		public unsafe List<GameObject> hovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_hovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_hovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00005210 File Offset: 0x00003410
		public unsafe bool _eligibleForClick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0002A8CC File Offset: 0x00028ACC
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0000522B File Offset: 0x0000342B
		public unsafe int _pointerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00005246 File Offset: 0x00003446
		public unsafe Vector2 _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0002A91C File Offset: 0x00028B1C
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00005261 File Offset: 0x00003461
		public unsafe Vector2 _delta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__delta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__delta_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002A944 File Offset: 0x00028B44
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0000527C File Offset: 0x0000347C
		public unsafe Vector2 _pressPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002A96C File Offset: 0x00028B6C
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00005297 File Offset: 0x00003497
		public unsafe Vector3 _worldPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0002A994 File Offset: 0x00028B94
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x000052B2 File Offset: 0x000034B2
		public unsafe Vector3 _worldNormal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0002A9BC File Offset: 0x00028BBC
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x000052CD File Offset: 0x000034CD
		public unsafe float _clickTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0002A9E4 File Offset: 0x00028BE4
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x000052E8 File Offset: 0x000034E8
		public unsafe int _clickCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0002AA0C File Offset: 0x00028C0C
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00005303 File Offset: 0x00003503
		public unsafe Vector2 _scrollDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0002AA34 File Offset: 0x00028C34
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0000531E File Offset: 0x0000351E
		public unsafe bool _useDragThreshold_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002AA5C File Offset: 0x00028C5C
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00005339 File Offset: 0x00003539
		public unsafe bool _dragging_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002AA84 File Offset: 0x00028C84
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00005354 File Offset: 0x00003554
		public unsafe PointerEventData.InputButton _button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__button_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__button_k__BackingField)) = value;
			}
		}

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr__pointerEnter_k__BackingField;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerPress;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr__lastPress_k__BackingField;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr__rawPointerPress_k__BackingField;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr__pointerDrag_k__BackingField;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr__pointerClick_k__BackingField;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr__pointerPressRaycast_k__BackingField;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_hovered;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr__eligibleForClick_k__BackingField;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr__delta_k__BackingField;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr__pressPosition_k__BackingField;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr__worldPosition_k__BackingField;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr__worldNormal_k__BackingField;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr__clickTime_k__BackingField;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr__scrollDelta_k__BackingField;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr__useDragThreshold_k__BackingField;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr__dragging_k__BackingField;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector2_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_get_clickTime_Public_get_Single_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_InputButton_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_IsScrolling_Public_Boolean_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020000BD RID: 189
		[OriginalName("UnityEngine.UI.dll", "", "InputButton")]
		public enum InputButton
		{
			// Token: 0x040009D2 RID: 2514
			Left,
			// Token: 0x040009D3 RID: 2515
			Right,
			// Token: 0x040009D4 RID: 2516
			Middle
		}

		// Token: 0x020000BE RID: 190
		[OriginalName("UnityEngine.UI.dll", "", "FramePressState")]
		public enum FramePressState
		{
			// Token: 0x040009D6 RID: 2518
			Pressed,
			// Token: 0x040009D7 RID: 2519
			Released,
			// Token: 0x040009D8 RID: 2520
			PressedAndReleased,
			// Token: 0x040009D9 RID: 2521
			NotChanged
		}
	}
}
