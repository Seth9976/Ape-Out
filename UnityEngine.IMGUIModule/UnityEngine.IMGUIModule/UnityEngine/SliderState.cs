using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public class SliderState : Object
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x0001496C File Offset: 0x00012B6C
		// Note: this type is marked as 'beforefieldinit'.
		static SliderState()
		{
			Il2CppClassPointerStore<SliderState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "SliderState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderState>.NativeClassPtr);
			SliderState.NativeFieldInfoPtr_dragStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderState>.NativeClassPtr, "dragStartPos");
			SliderState.NativeFieldInfoPtr_dragStartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderState>.NativeClassPtr, "dragStartValue");
			SliderState.NativeFieldInfoPtr_isDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderState>.NativeClassPtr, "isDragging");
			SliderState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderState>.NativeClassPtr, 100663756);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000149EC File Offset: 0x00012BEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00004210 File Offset: 0x00002410
		public SliderState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00014A28 File Offset: 0x00012C28
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00004219 File Offset: 0x00002419
		public unsafe float dragStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartPos)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00014A50 File Offset: 0x00012C50
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00004234 File Offset: 0x00002434
		public unsafe float dragStartValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_dragStartValue)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00014A78 File Offset: 0x00012C78
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x0000424F File Offset: 0x0000244F
		public unsafe bool isDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_isDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderState.NativeFieldInfoPtr_isDragging)) = value;
			}
		}

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_dragStartPos;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_dragStartValue;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_isDragging;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
