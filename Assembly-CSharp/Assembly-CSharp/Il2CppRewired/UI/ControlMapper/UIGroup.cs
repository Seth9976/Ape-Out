using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000203 RID: 515
	public class UIGroup : MonoBehaviour
	{
		// Token: 0x06003F0F RID: 16143 RVA: 0x000EBCE0 File Offset: 0x000E9EE0
		// Note: this type is marked as 'beforefieldinit'.
		static UIGroup()
		{
			Il2CppClassPointerStore<UIGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UIGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIGroup>.NativeClassPtr);
			UIGroup.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGroup>.NativeClassPtr, "_label");
			UIGroup.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGroup>.NativeClassPtr, "_content");
			UIGroup.NativeMethodInfoPtr_get_labelText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGroup>.NativeClassPtr, 100669321);
			UIGroup.NativeMethodInfoPtr_set_labelText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGroup>.NativeClassPtr, 100669322);
			UIGroup.NativeMethodInfoPtr_get_content_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGroup>.NativeClassPtr, 100669323);
			UIGroup.NativeMethodInfoPtr_SetLabelActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGroup>.NativeClassPtr, 100669324);
			UIGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGroup>.NativeClassPtr, 100669325);
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x000EBD9C File Offset: 0x000E9F9C
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x000EBDD4 File Offset: 0x000E9FD4
		public unsafe string labelText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99750, XrefRangeEnd = 99764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIGroup.NativeMethodInfoPtr_get_labelText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 99776, RefRangeEnd = 99781, XrefRangeStart = 99764, XrefRangeEnd = 99776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIGroup.NativeMethodInfoPtr_set_labelText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x000EBE18 File Offset: 0x000EA018
		public unsafe Transform content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIGroup.NativeMethodInfoPtr_get_content_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x000EBE58 File Offset: 0x000EA058
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 99797, RefRangeEnd = 99802, XrefRangeStart = 99781, XrefRangeEnd = 99797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabelActive(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIGroup.NativeMethodInfoPtr_SetLabelActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x000EBE98 File Offset: 0x000EA098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x00026D52 File Offset: 0x00024F52
		public UIGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x000EBED4 File Offset: 0x000EA0D4
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x00026D5B File Offset: 0x00024F5B
		public unsafe Text _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIGroup.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIGroup.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x000EBF04 File Offset: 0x000EA104
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x00026D7A File Offset: 0x00024F7A
		public unsafe Transform _content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIGroup.NativeFieldInfoPtr__content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIGroup.NativeFieldInfoPtr__content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400269A RID: 9882
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x0400269B RID: 9883
		private static readonly IntPtr NativeFieldInfoPtr__content;

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeMethodInfoPtr_get_labelText_Public_get_String_0;

		// Token: 0x0400269D RID: 9885
		private static readonly IntPtr NativeMethodInfoPtr_set_labelText_Public_set_Void_String_0;

		// Token: 0x0400269E RID: 9886
		private static readonly IntPtr NativeMethodInfoPtr_get_content_Public_get_Transform_0;

		// Token: 0x0400269F RID: 9887
		private static readonly IntPtr NativeMethodInfoPtr_SetLabelActive_Public_Void_Boolean_0;

		// Token: 0x040026A0 RID: 9888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
