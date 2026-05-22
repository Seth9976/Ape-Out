using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001F5 RID: 501
	public class ICustomSelectable : Il2CppObjectBase
	{
		// Token: 0x06003D2C RID: 15660 RVA: 0x000E4CEC File Offset: 0x000E2EEC
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomSelectable()
		{
			Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ICustomSelectable");
			ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Abstract_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669000);
			ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Abstract_Virtual_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669001);
			ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Abstract_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669002);
			ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Abstract_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669003);
			ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669004);
			ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669005);
			ICustomSelectable.NativeMethodInfoPtr_get_autoNavUp_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669006);
			ICustomSelectable.NativeMethodInfoPtr_set_autoNavUp_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669007);
			ICustomSelectable.NativeMethodInfoPtr_get_autoNavDown_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669008);
			ICustomSelectable.NativeMethodInfoPtr_set_autoNavDown_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669009);
			ICustomSelectable.NativeMethodInfoPtr_get_autoNavLeft_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669010);
			ICustomSelectable.NativeMethodInfoPtr_set_autoNavLeft_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669011);
			ICustomSelectable.NativeMethodInfoPtr_get_autoNavRight_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669012);
			ICustomSelectable.NativeMethodInfoPtr_set_autoNavRight_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669013);
			ICustomSelectable.NativeMethodInfoPtr_add_CancelEvent_Public_Abstract_Virtual_New_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669014);
			ICustomSelectable.NativeMethodInfoPtr_remove_CancelEvent_Public_Abstract_Virtual_New_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669015);
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x000E4E54 File Offset: 0x000E3054
		// (set) Token: 0x06003D2E RID: 15662 RVA: 0x000E4EA0 File Offset: 0x000E30A0
		public unsafe virtual Sprite disabledHighlightedSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Abstract_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Abstract_Virtual_New_set_Void_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x000E4EF0 File Offset: 0x000E30F0
		// (set) Token: 0x06003D30 RID: 15664 RVA: 0x000E4F38 File Offset: 0x000E3138
		public unsafe virtual Color disabledHighlightedColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Abstract_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Abstract_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x000E4F84 File Offset: 0x000E3184
		// (set) Token: 0x06003D32 RID: 15666 RVA: 0x000E4FC8 File Offset: 0x000E31C8
		public unsafe virtual string disabledHighlightedTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x000E5018 File Offset: 0x000E3218
		// (set) Token: 0x06003D34 RID: 15668 RVA: 0x000E5060 File Offset: 0x000E3260
		public unsafe virtual bool autoNavUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavUp_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavUp_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06003D35 RID: 15669 RVA: 0x000E50AC File Offset: 0x000E32AC
		// (set) Token: 0x06003D36 RID: 15670 RVA: 0x000E50F4 File Offset: 0x000E32F4
		public unsafe virtual bool autoNavDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavDown_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavDown_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x000E5140 File Offset: 0x000E3340
		// (set) Token: 0x06003D38 RID: 15672 RVA: 0x000E5188 File Offset: 0x000E3388
		public unsafe virtual bool autoNavLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavLeft_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavLeft_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x000E51D4 File Offset: 0x000E33D4
		// (set) Token: 0x06003D3A RID: 15674 RVA: 0x000E521C File Offset: 0x000E341C
		public unsafe virtual bool autoNavRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavRight_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavRight_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x000E5268 File Offset: 0x000E3468
		[CallerCount(0)]
		public unsafe virtual void add_CancelEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_add_CancelEvent_Public_Abstract_Virtual_New_add_Void_UnityAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x000E52B8 File Offset: 0x000E34B8
		[CallerCount(0)]
		public unsafe virtual void remove_CancelEvent(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomSelectable.NativeMethodInfoPtr_remove_CancelEvent_Public_Abstract_Virtual_New_rem_Void_UnityAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x00025ECA File Offset: 0x000240CA
		public ICustomSelectable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Abstract_Virtual_New_get_Sprite_0;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Abstract_Virtual_New_set_Void_Sprite_0;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Abstract_Virtual_New_get_Color_0;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Abstract_Virtual_New_set_Void_Color_0;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Abstract_Virtual_New_set_Void_String_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavUp_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavUp_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavDown_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavDown_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavLeft_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavLeft_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_get_autoNavRight_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_set_autoNavRight_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr_add_CancelEvent_Public_Abstract_Virtual_New_add_Void_UnityAction_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr_remove_CancelEvent_Public_Abstract_Virtual_New_rem_Void_UnityAction_0;
	}
}
