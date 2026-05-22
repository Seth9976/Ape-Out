using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001F8 RID: 504
	public class InputRow : MonoBehaviour
	{
		// Token: 0x06003D82 RID: 15746 RVA: 0x000E6214 File Offset: 0x000E4414
		// Note: this type is marked as 'beforefieldinit'.
		static InputRow()
		{
			Il2CppClassPointerStore<InputRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "InputRow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRow>.NativeClassPtr);
			InputRow.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, "label");
			InputRow.NativeFieldInfoPtr__buttons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, "<buttons>k__BackingField");
			InputRow.NativeFieldInfoPtr_rowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, "rowIndex");
			InputRow.NativeFieldInfoPtr_inputFieldActivatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, "inputFieldActivatedCallback");
			InputRow.NativeMethodInfoPtr_get_buttons_Public_get_Il2CppReferenceArray_1_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669054);
			InputRow.NativeMethodInfoPtr_set_buttons_Private_set_Void_Il2CppReferenceArray_1_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669055);
			InputRow.NativeMethodInfoPtr_Initialize_Public_Void_Int32_String_Action_2_Int32_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669056);
			InputRow.NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669057);
			InputRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669058);
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x000E62F8 File Offset: 0x000E44F8
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x000E6338 File Offset: 0x000E4538
		public unsafe Il2CppReferenceArray<ButtonInfo> buttons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_get_buttons_Public_get_Il2CppReferenceArray_1_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ButtonInfo>>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_set_buttons_Private_set_Void_Il2CppReferenceArray_1_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x000E637C File Offset: 0x000E457C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98844, XrefRangeEnd = 98850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int rowIndex, string label, Action<int, ButtonInfo> inputFieldActivatedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rowIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputFieldActivatedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_Initialize_Public_Void_Int32_String_Action_2_Int32_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x000E63E0 File Offset: 0x000E45E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98850, XrefRangeEnd = 98853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonActivated(ButtonInfo buttonInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttonInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x000E6424 File Offset: 0x000E4624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputRow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputRow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x000260EA File Offset: 0x000242EA
		public InputRow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x000E6460 File Offset: 0x000E4660
		// (set) Token: 0x06003D8A RID: 15754 RVA: 0x000260F3 File Offset: 0x000242F3
		public unsafe Text label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x000E6490 File Offset: 0x000E4690
		// (set) Token: 0x06003D8C RID: 15756 RVA: 0x00026112 File Offset: 0x00024312
		public unsafe Il2CppReferenceArray<ButtonInfo> _buttons_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr__buttons_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ButtonInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr__buttons_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x000E64C0 File Offset: 0x000E46C0
		// (set) Token: 0x06003D8E RID: 15758 RVA: 0x00026131 File Offset: 0x00024331
		public unsafe int rowIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_rowIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_rowIndex)) = value;
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x000E64E8 File Offset: 0x000E46E8
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x0002614C File Offset: 0x0002434C
		public unsafe Action<int, ButtonInfo> inputFieldActivatedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_inputFieldActivatedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, ButtonInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_inputFieldActivatedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeFieldInfoPtr__buttons_k__BackingField;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeFieldInfoPtr_rowIndex;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldActivatedCallback;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr_get_buttons_Public_get_Il2CppReferenceArray_1_ButtonInfo_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_set_buttons_Private_set_Void_Il2CppReferenceArray_1_ButtonInfo_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_String_Action_2_Int32_ButtonInfo_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
