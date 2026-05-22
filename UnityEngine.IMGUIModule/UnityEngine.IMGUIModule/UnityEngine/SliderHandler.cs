using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001D RID: 29
	public sealed class SliderHandler : ValueType
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x00014AA0 File Offset: 0x00012CA0
		// Note: this type is marked as 'beforefieldinit'.
		static SliderHandler()
		{
			Il2CppClassPointerStore<SliderHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "SliderHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr);
			SliderHandler.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "position");
			SliderHandler.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "currentValue");
			SliderHandler.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "size");
			SliderHandler.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "start");
			SliderHandler.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "end");
			SliderHandler.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "slider");
			SliderHandler.NativeFieldInfoPtr_thumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "thumb");
			SliderHandler.NativeFieldInfoPtr_thumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "thumbExtent");
			SliderHandler.NativeFieldInfoPtr_horiz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "horiz");
			SliderHandler.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "id");
			SliderHandler.NativeMethodInfoPtr__ctor_Public_Void_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663757);
			SliderHandler.NativeMethodInfoPtr_Handle_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663758);
			SliderHandler.NativeMethodInfoPtr_OnMouseDown_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663759);
			SliderHandler.NativeMethodInfoPtr_OnMouseDrag_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663760);
			SliderHandler.NativeMethodInfoPtr_OnMouseUp_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663761);
			SliderHandler.NativeMethodInfoPtr_OnRepaint_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663762);
			SliderHandler.NativeMethodInfoPtr_CurrentEventType_Private_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663763);
			SliderHandler.NativeMethodInfoPtr_CurrentScrollTroughSide_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663764);
			SliderHandler.NativeMethodInfoPtr_IsEmptySlider_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663765);
			SliderHandler.NativeMethodInfoPtr_SupportsPageMovements_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663766);
			SliderHandler.NativeMethodInfoPtr_PageMovementValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663767);
			SliderHandler.NativeMethodInfoPtr_PageUpMovementBound_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663768);
			SliderHandler.NativeMethodInfoPtr_CurrentEvent_Private_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663769);
			SliderHandler.NativeMethodInfoPtr_ValueForCurrentMousePosition_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663770);
			SliderHandler.NativeMethodInfoPtr_Clamp_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663771);
			SliderHandler.NativeMethodInfoPtr_ThumbSelectionRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663772);
			SliderHandler.NativeMethodInfoPtr_StartDraggingWithValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663773);
			SliderHandler.NativeMethodInfoPtr_SliderState_Private_SliderState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663774);
			SliderHandler.NativeMethodInfoPtr_ThumbExtRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663775);
			SliderHandler.NativeMethodInfoPtr_ThumbRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663776);
			SliderHandler.NativeMethodInfoPtr_VerticalThumbRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663777);
			SliderHandler.NativeMethodInfoPtr_HorizontalThumbRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663778);
			SliderHandler.NativeMethodInfoPtr_ClampedCurrentValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663779);
			SliderHandler.NativeMethodInfoPtr_MousePosition_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663780);
			SliderHandler.NativeMethodInfoPtr_ValuesPerPixel_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663781);
			SliderHandler.NativeMethodInfoPtr_ThumbSize_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663782);
			SliderHandler.NativeMethodInfoPtr_MaxValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663783);
			SliderHandler.NativeMethodInfoPtr_MinValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663784);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00014DC8 File Offset: 0x00012FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510312, RefRangeEnd = 510313, XrefRangeStart = 510312, XrefRangeEnd = 510312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slider);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thumb);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horiz;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thumbExtent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr__ctor_Public_Void_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00014EA4 File Offset: 0x000130A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510313, XrefRangeEnd = 510316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Handle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_Handle_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00014EE8 File Offset: 0x000130E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510370, RefRangeEnd = 510371, XrefRangeStart = 510316, XrefRangeEnd = 510370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnMouseDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnMouseDown_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00014F2C File Offset: 0x0001312C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510386, RefRangeEnd = 510388, XrefRangeStart = 510371, XrefRangeEnd = 510386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnMouseDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnMouseDrag_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00014F70 File Offset: 0x00013170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510398, RefRangeEnd = 510399, XrefRangeStart = 510388, XrefRangeEnd = 510398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnMouseUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnMouseUp_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00014FB4 File Offset: 0x000131B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510461, RefRangeEnd = 510463, XrefRangeStart = 510399, XrefRangeEnd = 510461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnRepaint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnRepaint_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00014FF8 File Offset: 0x000131F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510470, RefRangeEnd = 510471, XrefRangeStart = 510463, XrefRangeEnd = 510470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventType CurrentEventType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_CurrentEventType_Private_EventType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001503C File Offset: 0x0001323C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510481, RefRangeEnd = 510483, XrefRangeStart = 510471, XrefRangeEnd = 510481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CurrentScrollTroughSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_CurrentScrollTroughSide_Private_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00015080 File Offset: 0x00013280
		[CallerCount(0)]
		public unsafe bool IsEmptySlider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_IsEmptySlider_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000150C4 File Offset: 0x000132C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510484, RefRangeEnd = 510486, XrefRangeStart = 510483, XrefRangeEnd = 510484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SupportsPageMovements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_SupportsPageMovements_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00015108 File Offset: 0x00013308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510493, RefRangeEnd = 510494, XrefRangeStart = 510486, XrefRangeEnd = 510493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float PageMovementValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_PageMovementValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001514C File Offset: 0x0001334C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510494, XrefRangeEnd = 510495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float PageUpMovementBound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_PageUpMovementBound_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00015190 File Offset: 0x00013390
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 505096, RefRangeEnd = 505104, XrefRangeStart = 505096, XrefRangeEnd = 505104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event CurrentEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_CurrentEvent_Private_Event_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000151D4 File Offset: 0x000133D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510500, RefRangeEnd = 510501, XrefRangeStart = 510495, XrefRangeEnd = 510500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ValueForCurrentMousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ValueForCurrentMousePosition_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00015218 File Offset: 0x00013418
		[CallerCount(0)]
		public unsafe float Clamp(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_Clamp_Private_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00015268 File Offset: 0x00013468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510501, XrefRangeEnd = 510502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ThumbSelectionRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbSelectionRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000152AC File Offset: 0x000134AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510504, RefRangeEnd = 510505, XrefRangeStart = 510502, XrefRangeEnd = 510504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDraggingWithValue(float dragStartValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragStartValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_StartDraggingWithValue_Private_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000152F0 File Offset: 0x000134F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 510520, RefRangeEnd = 510524, XrefRangeStart = 510505, XrefRangeEnd = 510520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderState SliderState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_SliderState_Private_SliderState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SliderState>(intPtr3) : null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00015334 File Offset: 0x00013534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510531, RefRangeEnd = 510532, XrefRangeStart = 510524, XrefRangeEnd = 510531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ThumbExtRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbExtRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00015378 File Offset: 0x00013578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510532, XrefRangeEnd = 510533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ThumbRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000153BC File Offset: 0x000135BC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 510549, RefRangeEnd = 510557, XrefRangeStart = 510533, XrefRangeEnd = 510549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect VerticalThumbRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_VerticalThumbRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00015400 File Offset: 0x00013600
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 510573, RefRangeEnd = 510582, XrefRangeStart = 510557, XrefRangeEnd = 510573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect HorizontalThumbRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_HorizontalThumbRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00015444 File Offset: 0x00013644
		[CallerCount(0)]
		public unsafe float ClampedCurrentValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ClampedCurrentValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00015488 File Offset: 0x00013688
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 510585, RefRangeEnd = 510590, XrefRangeStart = 510582, XrefRangeEnd = 510585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_MousePosition_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000154CC File Offset: 0x000136CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 510594, RefRangeEnd = 510598, XrefRangeStart = 510590, XrefRangeEnd = 510594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ValuesPerPixel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ValuesPerPixel_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00015510 File Offset: 0x00013710
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 510603, RefRangeEnd = 510606, XrefRangeStart = 510598, XrefRangeEnd = 510603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ThumbSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbSize_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00015554 File Offset: 0x00013754
		[CallerCount(0)]
		public unsafe float MaxValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_MaxValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00015598 File Offset: 0x00013798
		[CallerCount(0)]
		public unsafe float MinValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_MinValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000426A File Offset: 0x0000246A
		public SliderHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00004273 File Offset: 0x00002473
		public SliderHandler()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr))
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000155DC File Offset: 0x000137DC
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00004285 File Offset: 0x00002485
		public unsafe Rect position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00015604 File Offset: 0x00013804
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000042A0 File Offset: 0x000024A0
		public unsafe float currentValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_currentValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_currentValue)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0001562C File Offset: 0x0001382C
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x000042BB File Offset: 0x000024BB
		public unsafe float size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00015654 File Offset: 0x00013854
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x000042D6 File Offset: 0x000024D6
		public unsafe float start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001567C File Offset: 0x0001387C
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x000042F1 File Offset: 0x000024F1
		public unsafe float end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_end)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x000156A4 File Offset: 0x000138A4
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0000430C File Offset: 0x0000250C
		public unsafe GUIStyle slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x000156D4 File Offset: 0x000138D4
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0000432B File Offset: 0x0000252B
		public unsafe GUIStyle thumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00015704 File Offset: 0x00013904
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0000434A File Offset: 0x0000254A
		public unsafe GUIStyle thumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00015734 File Offset: 0x00013934
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00004369 File Offset: 0x00002569
		public unsafe bool horiz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_horiz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_horiz)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0001575C File Offset: 0x0001395C
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00004384 File Offset: 0x00002584
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_currentValue;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_thumb;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_thumbExtent;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_horiz;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Single_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDown_Private_Single_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDrag_Private_Single_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseUp_Private_Single_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_OnRepaint_Private_Single_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_CurrentEventType_Private_EventType_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_CurrentScrollTroughSide_Private_Int32_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_IsEmptySlider_Private_Boolean_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_SupportsPageMovements_Private_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_PageMovementValue_Private_Single_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_PageUpMovementBound_Private_Single_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_CurrentEvent_Private_Event_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_ValueForCurrentMousePosition_Private_Single_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Private_Single_Single_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_ThumbSelectionRect_Private_Rect_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_StartDraggingWithValue_Private_Void_Single_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_SliderState_Private_SliderState_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_ThumbExtRect_Private_Rect_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_ThumbRect_Private_Rect_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_VerticalThumbRect_Private_Rect_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_HorizontalThumbRect_Private_Rect_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_ClampedCurrentValue_Private_Single_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_MousePosition_Private_Single_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_ValuesPerPixel_Private_Single_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_ThumbSize_Private_Single_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_MaxValue_Private_Single_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_MinValue_Private_Single_0;
	}
}
