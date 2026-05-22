using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200020D RID: 525
	public class TouchButtonExample : MonoBehaviour
	{
		// Token: 0x06004040 RID: 16448 RVA: 0x000F0494 File Offset: 0x000EE694
		// Note: this type is marked as 'beforefieldinit'.
		static TouchButtonExample()
		{
			Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "TouchButtonExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr);
			TouchButtonExample.NativeFieldInfoPtr_allowMouseControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, "allowMouseControl");
			TouchButtonExample.NativeFieldInfoPtr__isPressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, "<isPressed>k__BackingField");
			TouchButtonExample.NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669565);
			TouchButtonExample.NativeMethodInfoPtr_set_isPressed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669566);
			TouchButtonExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669567);
			TouchButtonExample.NativeMethodInfoPtr_Restart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669568);
			TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669569);
			TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669570);
			TouchButtonExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669571);
			TouchButtonExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr, 100669572);
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x000F058C File Offset: 0x000EE78C
		// (set) Token: 0x06004042 RID: 16450 RVA: 0x000F05C8 File Offset: 0x000EE7C8
		public unsafe bool isPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_set_isPressed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x000F0608 File Offset: 0x000EE808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103322, XrefRangeEnd = 103324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x000F063C File Offset: 0x000EE83C
		[CallerCount(0)]
		public unsafe void Restart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_Restart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x000F0670 File Offset: 0x000EE870
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x000F06B4 File Offset: 0x000EE8B4
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x000F06F8 File Offset: 0x000EE8F8
		[CallerCount(0)]
		public unsafe static bool IsMousePointerId(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x000F0738 File Offset: 0x000EE938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103324, XrefRangeEnd = 103327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchButtonExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButtonExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00027544 File Offset: 0x00025744
		public TouchButtonExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x000F0774 File Offset: 0x000EE974
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x0002754D File Offset: 0x0002574D
		public unsafe bool allowMouseControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr_allowMouseControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr_allowMouseControl)) = value;
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x000F079C File Offset: 0x000EE99C
		// (set) Token: 0x0600404D RID: 16461 RVA: 0x00027568 File Offset: 0x00025768
		public unsafe bool _isPressed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr__isPressed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonExample.NativeFieldInfoPtr__isPressed_k__BackingField)) = value;
			}
		}

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeFieldInfoPtr_allowMouseControl;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeFieldInfoPtr__isPressed_k__BackingField;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeMethodInfoPtr_get_isPressed_Public_get_Boolean_0;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeMethodInfoPtr_set_isPressed_Private_set_Void_Boolean_0;

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Private_Void_0;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0;

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
