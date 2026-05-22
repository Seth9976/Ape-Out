using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000202 RID: 514
	public class UIElementInfo : MonoBehaviour
	{
		// Token: 0x06003F01 RID: 16129 RVA: 0x000EBA58 File Offset: 0x000E9C58
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementInfo()
		{
			Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UIElementInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr);
			UIElementInfo.NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, "identifier");
			UIElementInfo.NativeFieldInfoPtr_intData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, "intData");
			UIElementInfo.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, "text");
			UIElementInfo.NativeFieldInfoPtr_OnSelectedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, "OnSelectedEvent");
			UIElementInfo.NativeMethodInfoPtr_add_OnSelectedEvent_Public_add_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100669317);
			UIElementInfo.NativeMethodInfoPtr_remove_OnSelectedEvent_Public_rem_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100669318);
			UIElementInfo.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100669319);
			UIElementInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100669320);
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x000EBB28 File Offset: 0x000E9D28
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 99735, RefRangeEnd = 99742, XrefRangeStart = 99732, XrefRangeEnd = 99735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSelectedEvent(Action<GameObject> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr_add_OnSelectedEvent_Public_add_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x000EBB6C File Offset: 0x000E9D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99742, XrefRangeEnd = 99745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSelectedEvent(Action<GameObject> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr_remove_OnSelectedEvent_Public_rem_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x000EBBB0 File Offset: 0x000E9DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99745, XrefRangeEnd = 99750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x000EBBF4 File Offset: 0x000E9DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIElementInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x00026CD1 File Offset: 0x00024ED1
		public UIElementInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x000EBC30 File Offset: 0x000E9E30
		// (set) Token: 0x06003F08 RID: 16136 RVA: 0x00026CDA File Offset: 0x00024EDA
		public unsafe string identifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_identifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_identifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x000EBC58 File Offset: 0x000E9E58
		// (set) Token: 0x06003F0A RID: 16138 RVA: 0x00026CF9 File Offset: 0x00024EF9
		public unsafe int intData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_intData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_intData)) = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x000EBC80 File Offset: 0x000E9E80
		// (set) Token: 0x06003F0C RID: 16140 RVA: 0x00026D14 File Offset: 0x00024F14
		public unsafe Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x000EBCB0 File Offset: 0x000E9EB0
		// (set) Token: 0x06003F0E RID: 16142 RVA: 0x00026D33 File Offset: 0x00024F33
		public unsafe Action<GameObject> OnSelectedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_OnSelectedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_OnSelectedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeFieldInfoPtr_identifier;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeFieldInfoPtr_intData;

		// Token: 0x04002694 RID: 9876
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002695 RID: 9877
		private static readonly IntPtr NativeFieldInfoPtr_OnSelectedEvent;

		// Token: 0x04002696 RID: 9878
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSelectedEvent_Public_add_Void_Action_1_GameObject_0;

		// Token: 0x04002697 RID: 9879
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSelectedEvent_Public_rem_Void_Action_1_GameObject_0;

		// Token: 0x04002698 RID: 9880
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04002699 RID: 9881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
