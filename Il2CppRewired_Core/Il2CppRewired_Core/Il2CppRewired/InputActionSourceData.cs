using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000014 RID: 20
	public sealed class InputActionSourceData : ValueType
	{
		// Token: 0x06000185 RID: 389 RVA: 0x000336EC File Offset: 0x000318EC
		// Note: this type is marked as 'beforefieldinit'.
		static InputActionSourceData()
		{
			Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "InputActionSourceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr);
			InputActionSourceData.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, "egOPTGwnsPnUJWHsXfaRAFkRlvOu");
			InputActionSourceData.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, "wQXdFKgaEVDIjgjfyWReFTcBhsTt");
			InputActionSourceData.NativeFieldInfoPtr_fBAmZTIdHUNeSOkbHExSiupwypIx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, "fBAmZTIdHUNeSOkbHExSiupwypIx");
			InputActionSourceData.NativeMethodInfoPtr_get_controller_Public_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, 100663551);
			InputActionSourceData.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, 100663552);
			InputActionSourceData.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, 100663553);
			InputActionSourceData.NativeMethodInfoPtr_get_actionElementMap_Public_get_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, 100663554);
			InputActionSourceData.NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, 100663555);
			InputActionSourceData.NativeMethodInfoPtr__ctor_Internal_Void_Controller_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, 100663556);
			InputActionSourceData.NativeMethodInfoPtr__ctor_Internal_Void_OPQOGNATZEGnQFmFYfKQxgiidNcD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr, 100663557);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000337E4 File Offset: 0x000319E4
		public unsafe Controller controller
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSourceData.NativeMethodInfoPtr_get_controller_Public_get_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00033828 File Offset: 0x00031A28
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243403, XrefRangeEnd = 243405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSourceData.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0003386C File Offset: 0x00031A6C
		public unsafe ControllerMap controllerMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSourceData.NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000338B0 File Offset: 0x00031AB0
		public unsafe ActionElementMap actionElementMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSourceData.NativeMethodInfoPtr_get_actionElementMap_Public_get_ActionElementMap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000338F4 File Offset: 0x00031AF4
		public unsafe string elementIdentifierName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243405, XrefRangeEnd = 243407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSourceData.NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00033930 File Offset: 0x00031B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243407, RefRangeEnd = 243409, XrefRangeStart = 243407, XrefRangeEnd = 243407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputActionSourceData(Controller controller, ControllerMap controllerMap, ActionElementMap actionElementMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerMap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSourceData.NativeMethodInfoPtr__ctor_Internal_Void_Controller_ControllerMap_ActionElementMap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000339A4 File Offset: 0x00031BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243409, RefRangeEnd = 243410, XrefRangeStart = 243409, XrefRangeEnd = 243409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputActionSourceData(OPQOGNATZEGnQFmFYfKQxgiidNcD working)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(working);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSourceData.NativeMethodInfoPtr__ctor_Internal_Void_OPQOGNATZEGnQFmFYfKQxgiidNcD_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000026AE File Offset: 0x000008AE
		public InputActionSourceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000026B7 File Offset: 0x000008B7
		public InputActionSourceData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputActionSourceData>.NativeClassPtr))
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000339F4 File Offset: 0x00031BF4
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000026C9 File Offset: 0x000008C9
		public unsafe Controller egOPTGwnsPnUJWHsXfaRAFkRlvOu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionSourceData.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionSourceData.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00033A24 File Offset: 0x00031C24
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000026E8 File Offset: 0x000008E8
		public unsafe ControllerMap wQXdFKgaEVDIjgjfyWReFTcBhsTt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionSourceData.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionSourceData.NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00033A54 File Offset: 0x00031C54
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002707 File Offset: 0x00000907
		public unsafe ActionElementMap fBAmZTIdHUNeSOkbHExSiupwypIx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionSourceData.NativeFieldInfoPtr_fBAmZTIdHUNeSOkbHExSiupwypIx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputActionSourceData.NativeFieldInfoPtr_fBAmZTIdHUNeSOkbHExSiupwypIx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_wQXdFKgaEVDIjgjfyWReFTcBhsTt;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_fBAmZTIdHUNeSOkbHExSiupwypIx;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_get_Controller_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerMap_Public_get_ControllerMap_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_get_actionElementMap_Public_get_ActionElementMap_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_ControllerMap_ActionElementMap_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_OPQOGNATZEGnQFmFYfKQxgiidNcD_0;
	}
}
