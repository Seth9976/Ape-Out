using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x02000076 RID: 118
	public class IControllerTemplateButton : Il2CppObjectBase
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x00069220 File Offset: 0x00067420
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateButton()
		{
			Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateButton");
			IControllerTemplateButton.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665973);
			IControllerTemplateButton.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665974);
			IControllerTemplateButton.NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665975);
			IControllerTemplateButton.NativeMethodInfoPtr_get_pressurePrev_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665976);
			IControllerTemplateButton.NativeMethodInfoPtr_get_justPressed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665977);
			IControllerTemplateButton.NativeMethodInfoPtr_get_justReleased_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665978);
			IControllerTemplateButton.NativeMethodInfoPtr_get_justChangedState_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665979);
			IControllerTemplateButton.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateButtonSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665980);
			IControllerTemplateButton.NativeMethodInfoPtr_get_AsAxis_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateButton>.NativeClassPtr, 100665981);
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x000692FC File Offset: 0x000674FC
		public unsafe virtual bool value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00069344 File Offset: 0x00067544
		public unsafe virtual bool valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x0006938C File Offset: 0x0006758C
		public unsafe virtual float pressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x000693D4 File Offset: 0x000675D4
		public unsafe virtual float pressurePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_pressurePrev_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0006941C File Offset: 0x0006761C
		public unsafe virtual bool justPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_justPressed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00069464 File Offset: 0x00067664
		public unsafe virtual bool justReleased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_justReleased_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x000694AC File Offset: 0x000676AC
		public unsafe virtual bool justChangedState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_justChangedState_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x000694F4 File Offset: 0x000676F4
		public unsafe virtual IControllerTemplateButtonSource source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateButtonSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButtonSource>(intPtr3) : null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00069540 File Offset: 0x00067740
		public unsafe virtual IControllerTemplateAxis AsAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateButton.NativeMethodInfoPtr_get_AsAxis_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00007466 File Offset: 0x00005666
		public IControllerTemplateButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_get_pressurePrev_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_get_justPressed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_get_justReleased_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_get_justChangedState_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateButtonSource_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_get_AsAxis_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
	}
}
