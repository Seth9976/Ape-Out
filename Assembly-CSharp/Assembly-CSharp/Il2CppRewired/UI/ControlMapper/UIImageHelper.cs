using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000204 RID: 516
	public class UIImageHelper : MonoBehaviour
	{
		// Token: 0x06003F1A RID: 16154 RVA: 0x000EBF34 File Offset: 0x000EA134
		// Note: this type is marked as 'beforefieldinit'.
		static UIImageHelper()
		{
			Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UIImageHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr);
			UIImageHelper.NativeFieldInfoPtr_enabledState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, "enabledState");
			UIImageHelper.NativeFieldInfoPtr_disabledState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, "disabledState");
			UIImageHelper.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, "currentState");
			UIImageHelper.NativeMethodInfoPtr_SetEnabledState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100669326);
			UIImageHelper.NativeMethodInfoPtr_SetEnabledStateColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100669327);
			UIImageHelper.NativeMethodInfoPtr_SetDisabledStateColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100669328);
			UIImageHelper.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100669329);
			UIImageHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, 100669330);
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x000EC004 File Offset: 0x000EA204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99817, XrefRangeEnd = 99838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabledState(bool newState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_SetEnabledState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x000EC044 File Offset: 0x000EA244
		[CallerCount(0)]
		public unsafe void SetEnabledStateColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_SetEnabledStateColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x000EC084 File Offset: 0x000EA284
		[CallerCount(0)]
		public unsafe void SetDisabledStateColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_SetDisabledStateColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x000EC0C4 File Offset: 0x000EA2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99838, XrefRangeEnd = 99857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x000EC0F8 File Offset: 0x000EA2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIImageHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x00026D99 File Offset: 0x00024F99
		public UIImageHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x000EC134 File Offset: 0x000EA334
		// (set) Token: 0x06003F22 RID: 16162 RVA: 0x00026DA2 File Offset: 0x00024FA2
		public unsafe UIImageHelper.State enabledState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_enabledState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIImageHelper.State>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_enabledState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x000EC164 File Offset: 0x000EA364
		// (set) Token: 0x06003F24 RID: 16164 RVA: 0x00026DC1 File Offset: 0x00024FC1
		public unsafe UIImageHelper.State disabledState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_disabledState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIImageHelper.State>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_disabledState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x000EC194 File Offset: 0x000EA394
		// (set) Token: 0x06003F26 RID: 16166 RVA: 0x00026DE0 File Offset: 0x00024FE0
		public unsafe bool currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x040026A1 RID: 9889
		private static readonly IntPtr NativeFieldInfoPtr_enabledState;

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeFieldInfoPtr_disabledState;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabledState_Public_Void_Boolean_0;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabledStateColor_Public_Void_Color_0;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeMethodInfoPtr_SetDisabledStateColor_Public_Void_Color_0;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000396 RID: 918
		[Serializable]
		public class State : global::Il2CppSystem.Object
		{
			// Token: 0x06005829 RID: 22569 RVA: 0x0013FB64 File Offset: 0x0013DD64
			// Note: this type is marked as 'beforefieldinit'.
			static State()
			{
				Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIImageHelper>.NativeClassPtr, "State");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr);
				UIImageHelper.State.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr, "color");
				UIImageHelper.State.NativeMethodInfoPtr_Set_Public_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr, 100669331);
				UIImageHelper.State.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr, 100669332);
			}

			// Token: 0x0600582A RID: 22570 RVA: 0x0013FBCC File Offset: 0x0013DDCC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 99814, RefRangeEnd = 99817, XrefRangeStart = 99802, XrefRangeEnd = 99814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(Image image)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageHelper.State.NativeMethodInfoPtr_Set_Public_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600582B RID: 22571 RVA: 0x0013FC10 File Offset: 0x0013DE10
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe State()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIImageHelper.State>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageHelper.State.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600582C RID: 22572 RVA: 0x00032A12 File Offset: 0x00030C12
			public State(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700203E RID: 8254
			// (get) Token: 0x0600582D RID: 22573 RVA: 0x0013FC4C File Offset: 0x0013DE4C
			// (set) Token: 0x0600582E RID: 22574 RVA: 0x00032A1B File Offset: 0x00030C1B
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.State.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageHelper.State.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04003A8A RID: 14986
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04003A8B RID: 14987
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Image_0;

			// Token: 0x04003A8C RID: 14988
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
