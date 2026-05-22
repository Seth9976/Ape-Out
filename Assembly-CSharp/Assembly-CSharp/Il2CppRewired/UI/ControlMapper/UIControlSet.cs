using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000201 RID: 513
	public class UIControlSet : MonoBehaviour
	{
		// Token: 0x06003EF6 RID: 16118 RVA: 0x000EB790 File Offset: 0x000E9990
		// Note: this type is marked as 'beforefieldinit'.
		static UIControlSet()
		{
			Il2CppClassPointerStore<UIControlSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UIControlSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr);
			UIControlSet.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, "title");
			UIControlSet.NativeFieldInfoPtr__controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, "_controls");
			UIControlSet.NativeMethodInfoPtr_get_controls_Private_get_Dictionary_2_Int32_UIControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100669309);
			UIControlSet.NativeMethodInfoPtr_SetTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100669310);
			UIControlSet.NativeMethodInfoPtr_GetControl_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100669311);
			UIControlSet.NativeMethodInfoPtr_CreateSlider_Public_UISliderControl_GameObject_Sprite_Single_Single_Action_2_Int32_Single_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100669312);
			UIControlSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, 100669313);
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x000EB84C File Offset: 0x000E9A4C
		public unsafe Dictionary<int, UIControl> controls
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99629, RefRangeEnd = 99631, XrefRangeStart = 99624, XrefRangeEnd = 99629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr_get_controls_Private_get_Dictionary_2_Int32_UIControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, UIControl>>(intPtr3) : null;
			}
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x000EB88C File Offset: 0x000E9A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99643, RefRangeEnd = 99644, XrefRangeStart = 99631, XrefRangeEnd = 99643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTitle(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr_SetTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x000EB8D0 File Offset: 0x000E9AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99653, RefRangeEnd = 99655, XrefRangeStart = 99644, XrefRangeEnd = 99653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetControl<T>(int uniqueId) where T : UIControl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uniqueId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.MethodInfoStoreGeneric_GetControl_Public_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x000EB918 File Offset: 0x000E9B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99731, RefRangeEnd = 99732, XrefRangeStart = 99655, XrefRangeEnd = 99731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<int, float> valueChangedCallback, Action<int> cancelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueChangedCallback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancelCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr_CreateSlider_Public_UISliderControl_GameObject_Sprite_Single_Single_Action_2_Int32_Single_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISliderControl>(intPtr3) : null;
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x000EB9BC File Offset: 0x000E9BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIControlSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x00026C8A File Offset: 0x00024E8A
		public UIControlSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x000EB9F8 File Offset: 0x000E9BF8
		// (set) Token: 0x06003EFE RID: 16126 RVA: 0x00026C93 File Offset: 0x00024E93
		public unsafe Text title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x000EBA28 File Offset: 0x000E9C28
		// (set) Token: 0x06003F00 RID: 16128 RVA: 0x00026CB2 File Offset: 0x00024EB2
		public unsafe Dictionary<int, UIControl> _controls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr__controls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, UIControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.NativeFieldInfoPtr__controls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeFieldInfoPtr__controls;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeMethodInfoPtr_get_controls_Private_get_Dictionary_2_Int32_UIControl_0;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeMethodInfoPtr_SetTitle_Public_Void_String_0;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeMethodInfoPtr_GetControl_Public_T_Int32_0;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeMethodInfoPtr_CreateSlider_Public_UISliderControl_GameObject_Sprite_Single_Single_Action_2_Int32_Single_Action_1_Int32_0;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000394 RID: 916
		[ObfuscatedName("Rewired.UI.ControlMapper.UIControlSet+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600581D RID: 22557 RVA: 0x0013F92C File Offset: 0x0013DB2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIControlSet>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr);
				UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_valueChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, "valueChangedCallback");
				UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, "control");
				UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, "cancelCallback");
				UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, 100669314);
				UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, 100669315);
				UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr, 100669316);
			}

			// Token: 0x0600581E RID: 22558 RVA: 0x0013F9D0 File Offset: 0x0013DBD0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControlSet.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600581F RID: 22559 RVA: 0x0013FA0C File Offset: 0x0013DC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99616, XrefRangeEnd = 99620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateSlider_b__0(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005820 RID: 22560 RVA: 0x0013FA4C File Offset: 0x0013DC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99620, XrefRangeEnd = 99624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateSlider_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControlSet.__c__DisplayClass6_0.NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005821 RID: 22561 RVA: 0x000329AC File Offset: 0x00030BAC
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700203B RID: 8251
			// (get) Token: 0x06005822 RID: 22562 RVA: 0x0013FA80 File Offset: 0x0013DC80
			// (set) Token: 0x06005823 RID: 22563 RVA: 0x000329B5 File Offset: 0x00030BB5
			public unsafe Action<int, float> valueChangedCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_valueChangedCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_valueChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700203C RID: 8252
			// (get) Token: 0x06005824 RID: 22564 RVA: 0x0013FAB0 File Offset: 0x0013DCB0
			// (set) Token: 0x06005825 RID: 22565 RVA: 0x000329D4 File Offset: 0x00030BD4
			public unsafe UISliderControl control
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_control);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISliderControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_control), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700203D RID: 8253
			// (get) Token: 0x06005826 RID: 22566 RVA: 0x0013FAE0 File Offset: 0x0013DCE0
			// (set) Token: 0x06005827 RID: 22567 RVA: 0x000329F3 File Offset: 0x00030BF3
			public unsafe Action<int> cancelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_cancelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControlSet.__c__DisplayClass6_0.NativeFieldInfoPtr_cancelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A83 RID: 14979
			private static readonly IntPtr NativeFieldInfoPtr_valueChangedCallback;

			// Token: 0x04003A84 RID: 14980
			private static readonly IntPtr NativeFieldInfoPtr_control;

			// Token: 0x04003A85 RID: 14981
			private static readonly IntPtr NativeFieldInfoPtr_cancelCallback;

			// Token: 0x04003A86 RID: 14982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A87 RID: 14983
			private static readonly IntPtr NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Single_0;

			// Token: 0x04003A88 RID: 14984
			private static readonly IntPtr NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_0;
		}

		// Token: 0x02000395 RID: 917
		private sealed class MethodInfoStoreGeneric_GetControl_Public_T_Int32_0<T>
		{
			// Token: 0x04003A89 RID: 14985
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UIControlSet.NativeMethodInfoPtr_GetControl_Public_T_Int32_0, Il2CppClassPointerStore<UIControlSet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
