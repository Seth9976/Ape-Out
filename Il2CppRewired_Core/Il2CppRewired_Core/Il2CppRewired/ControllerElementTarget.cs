using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000091 RID: 145
	public sealed class ControllerElementTarget : ValueType
	{
		// Token: 0x0600113D RID: 4413 RVA: 0x0006D7E4 File Offset: 0x0006B9E4
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerElementTarget()
		{
			Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerElementTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr);
			ControllerElementTarget.NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, "RZsbLJsZVOaCOYYYBgZokVmdZgx");
			ControllerElementTarget.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, "fQhXdDzxMfJmFQuoJwqnjqjKizF");
			ControllerElementTarget.NativeMethodInfoPtr__ctor_Public_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666121);
			ControllerElementTarget.NativeMethodInfoPtr__ctor_Public_Void_ControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666122);
			ControllerElementTarget.NativeMethodInfoPtr__ctor_Public_Void_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666123);
			ControllerElementTarget.NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666124);
			ControllerElementTarget.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666125);
			ControllerElementTarget.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666126);
			ControllerElementTarget.NativeMethodInfoPtr_get_hasTarget_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666127);
			ControllerElementTarget.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666128);
			ControllerElementTarget.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666129);
			ControllerElementTarget.NativeMethodInfoPtr_get_controller_Public_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666130);
			ControllerElementTarget.NativeMethodInfoPtr_get_element_Public_get_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666131);
			ControllerElementTarget.NativeMethodInfoPtr_set_element_Public_set_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666132);
			ControllerElementTarget.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllerElementTarget_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr, 100666133);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0006D940 File Offset: 0x0006BB40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260125, RefRangeEnd = 260128, XrefRangeStart = 260116, XrefRangeEnd = 260125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementTarget(ActionElementMap actionElementMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr__ctor_Public_Void_ActionElementMap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0006D990 File Offset: 0x0006BB90
		[CallerCount(0)]
		public unsafe ControllerElementTarget(ControllerElementTarget other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr__ctor_Public_Void_ControllerElementTarget_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0006D9E8 File Offset: 0x0006BBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260128, XrefRangeEnd = 260132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerElementTarget(IControllerElementTarget other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr__ctor_Public_Void_IControllerElementTarget_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0006DA38 File Offset: 0x0006BC38
		public unsafe int elementIdentifierId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0006DA7C File Offset: 0x0006BC7C
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x0006DAC0 File Offset: 0x0006BCC0
		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0006DB04 File Offset: 0x0006BD04
		public unsafe bool hasTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_get_hasTarget_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0006DB48 File Offset: 0x0006BD48
		public unsafe ControllerElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0006DB8C File Offset: 0x0006BD8C
		public unsafe string descriptiveName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260132, XrefRangeEnd = 260136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0006DBC8 File Offset: 0x0006BDC8
		public unsafe Controller controller
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_get_controller_Public_get_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0006DC0C File Offset: 0x0006BE0C
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x0006DC50 File Offset: 0x0006BE50
		public unsafe Controller.Element element
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_get_element_Public_get_Element_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_set_element_Public_set_Void_Element_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0006DC98 File Offset: 0x0006BE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260136, XrefRangeEnd = 260137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ControllerElementTarget(ActionElementMap actionElementMap)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerElementTarget.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllerElementTarget_ActionElementMap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ControllerElementTarget(intPtr);
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00007ADF File Offset: 0x00005CDF
		public ControllerElementTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00007AE8 File Offset: 0x00005CE8
		public ControllerElementTarget()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementTarget>.NativeClassPtr))
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0006DCD4 File Offset: 0x0006BED4
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x00007AFA File Offset: 0x00005CFA
		public unsafe Controller.Element RZsbLJsZVOaCOYYYBgZokVmdZgx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementTarget.NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementTarget.NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0006DD04 File Offset: 0x0006BF04
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00007B19 File Offset: 0x00005D19
		public unsafe AxisRange fQhXdDzxMfJmFQuoJwqnjqjKizF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementTarget.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerElementTarget.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF)) = value;
			}
		}

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeFieldInfoPtr_RZsbLJsZVOaCOYYYBgZokVmdZgx;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ActionElementMap_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerElementTarget_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IControllerElementTarget_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_get_hasTarget_Public_get_Boolean_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_get_Controller_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_get_element_Public_get_Element_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_set_element_Public_set_Void_Element_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ControllerElementTarget_ActionElementMap_0;
	}
}
