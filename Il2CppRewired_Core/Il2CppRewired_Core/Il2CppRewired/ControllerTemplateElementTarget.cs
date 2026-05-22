using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000090 RID: 144
	public sealed class ControllerTemplateElementTarget : ValueType
	{
		// Token: 0x0600112C RID: 4396 RVA: 0x0006D398 File Offset: 0x0006B598
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateElementTarget()
		{
			Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerTemplateElementTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr);
			ControllerTemplateElementTarget.NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, "RZsbLJsZVOaCOYYYBgZokVmdZgx");
			ControllerTemplateElementTarget.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, "fQhXdDzxMfJmFQuoJwqnjqjKizF");
			ControllerTemplateElementTarget.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplateElement_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666111);
			ControllerTemplateElementTarget.NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666112);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666113);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666114);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_get_elementType_Public_get_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666115);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666116);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_get_element_Public_get_IControllerTemplateElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666117);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_set_element_Public_set_Void_IControllerTemplateElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666118);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_get_template_Public_get_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666119);
			ControllerTemplateElementTarget.NativeMethodInfoPtr_get_hasTarget_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr, 100666120);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0006D4B8 File Offset: 0x0006B6B8
		[CallerCount(0)]
		public unsafe ControllerTemplateElementTarget(IControllerTemplateElement element, AxisRange axisRange)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplateElement_AxisRange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0006D518 File Offset: 0x0006B718
		[CallerCount(0)]
		public unsafe ControllerTemplateElementTarget(ControllerTemplateElementTarget other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementTarget_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0006D570 File Offset: 0x0006B770
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x0006D5B4 File Offset: 0x0006B7B4
		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0006D5F8 File Offset: 0x0006B7F8
		public unsafe ControllerTemplateElementType elementType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260086, XrefRangeEnd = 260089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_get_elementType_Public_get_ControllerTemplateElementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0006D63C File Offset: 0x0006B83C
		public unsafe string descriptiveName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260089, XrefRangeEnd = 260109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0006D678 File Offset: 0x0006B878
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0006D6BC File Offset: 0x0006B8BC
		public unsafe IControllerTemplateElement element
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_get_element_Public_get_IControllerTemplateElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_set_element_Public_set_Void_IControllerTemplateElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0006D704 File Offset: 0x0006B904
		public unsafe IControllerTemplate template
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260109, XrefRangeEnd = 260116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_get_template_Public_get_IControllerTemplate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0006D748 File Offset: 0x0006B948
		public unsafe bool hasTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementTarget.NativeMethodInfoPtr_get_hasTarget_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00007A8A File Offset: 0x00005C8A
		public ControllerTemplateElementTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00007A93 File Offset: 0x00005C93
		public ControllerTemplateElementTarget()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementTarget>.NativeClassPtr))
		{
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0006D78C File Offset: 0x0006B98C
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x00007AA5 File Offset: 0x00005CA5
		public unsafe IControllerTemplateElement RZsbLJsZVOaCOYYYBgZokVmdZgx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementTarget.NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementTarget.NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0006D7BC File Offset: 0x0006B9BC
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public unsafe AxisRange fQhXdDzxMfJmFQuoJwqnjqjKizF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementTarget.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementTarget.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF)) = value;
			}
		}

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplateElement_AxisRange_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementTarget_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_ControllerTemplateElementType_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_get_element_Public_get_IControllerTemplateElement_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_set_element_Public_set_Void_IControllerTemplateElement_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_get_template_Public_get_IControllerTemplate_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_get_hasTarget_Public_get_Boolean_0;
	}
}
