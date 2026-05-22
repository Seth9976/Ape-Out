using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001F7 RID: 503
	public class InputFieldInfo : UIElementInfo
	{
		// Token: 0x06003D6B RID: 15723 RVA: 0x000E5D34 File Offset: 0x000E3F34
		// Note: this type is marked as 'beforefieldinit'.
		static InputFieldInfo()
		{
			Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "InputFieldInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr);
			InputFieldInfo.NativeFieldInfoPtr__actionId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<actionId>k__BackingField");
			InputFieldInfo.NativeFieldInfoPtr__axisRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<axisRange>k__BackingField");
			InputFieldInfo.NativeFieldInfoPtr__actionElementMapId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<actionElementMapId>k__BackingField");
			InputFieldInfo.NativeFieldInfoPtr__controllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<controllerType>k__BackingField");
			InputFieldInfo.NativeFieldInfoPtr__controllerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<controllerId>k__BackingField");
			InputFieldInfo.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669043);
			InputFieldInfo.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669044);
			InputFieldInfo.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669045);
			InputFieldInfo.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669046);
			InputFieldInfo.NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669047);
			InputFieldInfo.NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669048);
			InputFieldInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669049);
			InputFieldInfo.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669050);
			InputFieldInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669051);
			InputFieldInfo.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669052);
			InputFieldInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100669053);
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x000E5EA4 File Offset: 0x000E40A4
		// (set) Token: 0x06003D6D RID: 15725 RVA: 0x000E5EE0 File Offset: 0x000E40E0
		public unsafe int actionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x000E5F20 File Offset: 0x000E4120
		// (set) Token: 0x06003D6F RID: 15727 RVA: 0x000E5F5C File Offset: 0x000E415C
		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x000E5F9C File Offset: 0x000E419C
		// (set) Token: 0x06003D71 RID: 15729 RVA: 0x000E5FD8 File Offset: 0x000E41D8
		public unsafe int actionElementMapId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x000E6018 File Offset: 0x000E4218
		// (set) Token: 0x06003D73 RID: 15731 RVA: 0x000E6054 File Offset: 0x000E4254
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06003D74 RID: 15732 RVA: 0x000E6094 File Offset: 0x000E4294
		// (set) Token: 0x06003D75 RID: 15733 RVA: 0x000E60D0 File Offset: 0x000E42D0
		public unsafe int controllerId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93966, RefRangeEnd = 93969, XrefRangeStart = 93966, XrefRangeEnd = 93969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x000E6110 File Offset: 0x000E4310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputFieldInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0002605A File Offset: 0x0002425A
		public InputFieldInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06003D78 RID: 15736 RVA: 0x000E614C File Offset: 0x000E434C
		// (set) Token: 0x06003D79 RID: 15737 RVA: 0x00026063 File Offset: 0x00024263
		public unsafe int _actionId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionId_k__BackingField)) = value;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06003D7A RID: 15738 RVA: 0x000E6174 File Offset: 0x000E4374
		// (set) Token: 0x06003D7B RID: 15739 RVA: 0x0002607E File Offset: 0x0002427E
		public unsafe AxisRange _axisRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__axisRange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__axisRange_k__BackingField)) = value;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06003D7C RID: 15740 RVA: 0x000E619C File Offset: 0x000E439C
		// (set) Token: 0x06003D7D RID: 15741 RVA: 0x00026099 File Offset: 0x00024299
		public unsafe int _actionElementMapId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionElementMapId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__actionElementMapId_k__BackingField)) = value;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06003D7E RID: 15742 RVA: 0x000E61C4 File Offset: 0x000E43C4
		// (set) Token: 0x06003D7F RID: 15743 RVA: 0x000260B4 File Offset: 0x000242B4
		public unsafe ControllerType _controllerType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerType_k__BackingField)) = value;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x000E61EC File Offset: 0x000E43EC
		// (set) Token: 0x06003D81 RID: 15745 RVA: 0x000260CF File Offset: 0x000242CF
		public unsafe int _controllerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldInfo.NativeFieldInfoPtr__controllerId_k__BackingField)) = value;
			}
		}

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeFieldInfoPtr__actionId_k__BackingField;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeFieldInfoPtr__axisRange_k__BackingField;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeFieldInfoPtr__actionElementMapId_k__BackingField;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeFieldInfoPtr__controllerType_k__BackingField;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeFieldInfoPtr__controllerId_k__BackingField;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
