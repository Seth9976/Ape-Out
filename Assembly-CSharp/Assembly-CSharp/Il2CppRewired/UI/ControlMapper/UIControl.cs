using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x02000200 RID: 512
	public class UIControl : MonoBehaviour
	{
		// Token: 0x06003EE5 RID: 16101 RVA: 0x000EB440 File Offset: 0x000E9640
		// Note: this type is marked as 'beforefieldinit'.
		static UIControl()
		{
			Il2CppClassPointerStore<UIControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UIControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControl>.NativeClassPtr);
			UIControl.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, "title");
			UIControl.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, "_id");
			UIControl.NativeFieldInfoPtr__showTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, "_showTitle");
			UIControl.NativeFieldInfoPtr__uidCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, "_uidCounter");
			UIControl.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100669302);
			UIControl.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100669303);
			UIControl.NativeMethodInfoPtr_get_showTitle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100669304);
			UIControl.NativeMethodInfoPtr_set_showTitle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100669305);
			UIControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100669306);
			UIControl.NativeMethodInfoPtr_GetNextUid_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100669307);
			UIControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100669308);
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x000EB54C File Offset: 0x000E974C
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x000EB588 File Offset: 0x000E9788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99592, XrefRangeEnd = 99595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x000EB5BC File Offset: 0x000E97BC
		// (set) Token: 0x06003EE9 RID: 16105 RVA: 0x000EB5F8 File Offset: 0x000E97F8
		public unsafe bool showTitle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_get_showTitle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99611, RefRangeEnd = 99613, XrefRangeStart = 99595, XrefRangeEnd = 99611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_set_showTitle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x000EB638 File Offset: 0x000E9838
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCancelCallback(Action cancelCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cancelCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x000EB688 File Offset: 0x000E9888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99613, XrefRangeEnd = 99616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextUid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_GetNextUid_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x000EB6B8 File Offset: 0x000E98B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00026C1E File Offset: 0x00024E1E
		public UIControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06003EEE RID: 16110 RVA: 0x000EB6F4 File Offset: 0x000E98F4
		// (set) Token: 0x06003EEF RID: 16111 RVA: 0x00026C27 File Offset: 0x00024E27
		public unsafe Text title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x000EB724 File Offset: 0x000E9924
		// (set) Token: 0x06003EF1 RID: 16113 RVA: 0x00026C46 File Offset: 0x00024E46
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x000EB74C File Offset: 0x000E994C
		// (set) Token: 0x06003EF3 RID: 16115 RVA: 0x00026C61 File Offset: 0x00024E61
		public unsafe bool _showTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__showTitle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__showTitle)) = value;
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06003EF4 RID: 16116 RVA: 0x000EB774 File Offset: 0x000E9974
		// (set) Token: 0x06003EF5 RID: 16117 RVA: 0x00026C7C File Offset: 0x00024E7C
		public unsafe static int _uidCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIControl.NativeFieldInfoPtr__uidCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIControl.NativeFieldInfoPtr__uidCounter, (void*)(&value));
			}
		}

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeFieldInfoPtr__showTitle;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeFieldInfoPtr__uidCounter;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04002685 RID: 9861
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeMethodInfoPtr_get_showTitle_Public_get_Boolean_0;

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeMethodInfoPtr_set_showTitle_Public_set_Void_Boolean_0;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_New_Void_Action_0;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeMethodInfoPtr_GetNextUid_Private_Static_Int32_0;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
