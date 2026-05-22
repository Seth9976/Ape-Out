using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000206 RID: 518
	public class UISliderControl : UIControl
	{
		// Token: 0x06003F2C RID: 16172 RVA: 0x000EC2A0 File Offset: 0x000EA4A0
		// Note: this type is marked as 'beforefieldinit'.
		static UISliderControl()
		{
			Il2CppClassPointerStore<UISliderControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UISliderControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr);
			UISliderControl.NativeFieldInfoPtr_iconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, "iconImage");
			UISliderControl.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, "slider");
			UISliderControl.NativeFieldInfoPtr__showIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, "_showIcon");
			UISliderControl.NativeFieldInfoPtr__showSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, "_showSlider");
			UISliderControl.NativeMethodInfoPtr_get_showIcon_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100669335);
			UISliderControl.NativeMethodInfoPtr_set_showIcon_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100669336);
			UISliderControl.NativeMethodInfoPtr_get_showSlider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100669337);
			UISliderControl.NativeMethodInfoPtr_set_showSlider_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100669338);
			UISliderControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100669339);
			UISliderControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, 100669340);
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x000EC398 File Offset: 0x000EA598
		// (set) Token: 0x06003F2E RID: 16174 RVA: 0x000EC3D4 File Offset: 0x000EA5D4
		public unsafe bool showIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_get_showIcon_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100026, XrefRangeEnd = 100042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_set_showIcon_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x000EC414 File Offset: 0x000EA614
		// (set) Token: 0x06003F30 RID: 16176 RVA: 0x000EC450 File Offset: 0x000EA650
		public unsafe bool showSlider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_get_showSlider_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100042, XrefRangeEnd = 100058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr_set_showSlider_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x000EC490 File Offset: 0x000EA690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100058, XrefRangeEnd = 100125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCancelCallback(Action cancelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cancelCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISliderControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x000EC4E0 File Offset: 0x000EA6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISliderControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00026E16 File Offset: 0x00025016
		public UISliderControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06003F34 RID: 16180 RVA: 0x000EC51C File Offset: 0x000EA71C
		// (set) Token: 0x06003F35 RID: 16181 RVA: 0x00026E1F File Offset: 0x0002501F
		public unsafe Image iconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_iconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_iconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06003F36 RID: 16182 RVA: 0x000EC54C File Offset: 0x000EA74C
		// (set) Token: 0x06003F37 RID: 16183 RVA: 0x00026E3E File Offset: 0x0002503E
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06003F38 RID: 16184 RVA: 0x000EC57C File Offset: 0x000EA77C
		// (set) Token: 0x06003F39 RID: 16185 RVA: 0x00026E5D File Offset: 0x0002505D
		public unsafe bool _showIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showIcon)) = value;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06003F3A RID: 16186 RVA: 0x000EC5A4 File Offset: 0x000EA7A4
		// (set) Token: 0x06003F3B RID: 16187 RVA: 0x00026E78 File Offset: 0x00025078
		public unsafe bool _showSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showSlider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.NativeFieldInfoPtr__showSlider)) = value;
			}
		}

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeFieldInfoPtr_iconImage;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeFieldInfoPtr__showIcon;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeFieldInfoPtr__showSlider;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeMethodInfoPtr_get_showIcon_Public_get_Boolean_0;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeMethodInfoPtr_set_showIcon_Public_set_Void_Boolean_0;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeMethodInfoPtr_get_showSlider_Public_get_Boolean_0;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeMethodInfoPtr_set_showSlider_Public_set_Void_Boolean_0;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_Void_Action_0;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000397 RID: 919
		[ObfuscatedName("Rewired.UI.ControlMapper.UISliderControl+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600582F RID: 22575 RVA: 0x0013FC74 File Offset: 0x0013DE74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISliderControl>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr);
				UISliderControl.__c__DisplayClass10_0.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, "cancelCallback");
				UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, 100669341);
				UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, 100669342);
				UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr, 100669343);
			}

			// Token: 0x06005830 RID: 22576 RVA: 0x0013FCF0 File Offset: 0x0013DEF0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISliderControl.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005831 RID: 22577 RVA: 0x0013FD2C File Offset: 0x0013DF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100024, XrefRangeEnd = 100026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetCancelCallback_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005832 RID: 22578 RVA: 0x0013FD60 File Offset: 0x0013DF60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetCancelCallback_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderControl.__c__DisplayClass10_0.NativeMethodInfoPtr__SetCancelCallback_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005833 RID: 22579 RVA: 0x00032A36 File Offset: 0x00030C36
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700203F RID: 8255
			// (get) Token: 0x06005834 RID: 22580 RVA: 0x0013FDA4 File Offset: 0x0013DFA4
			// (set) Token: 0x06005835 RID: 22581 RVA: 0x00032A3F File Offset: 0x00030C3F
			public unsafe Action cancelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.__c__DisplayClass10_0.NativeFieldInfoPtr_cancelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderControl.__c__DisplayClass10_0.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A8D RID: 14989
			private static readonly IntPtr NativeFieldInfoPtr_cancelCallback;

			// Token: 0x04003A8E RID: 14990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A8F RID: 14991
			private static readonly IntPtr NativeMethodInfoPtr__SetCancelCallback_b__0_Internal_Void_0;

			// Token: 0x04003A90 RID: 14992
			private static readonly IntPtr NativeMethodInfoPtr__SetCancelCallback_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
