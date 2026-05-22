using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x02000075 RID: 117
	public class IControllerTemplateAxis : Il2CppObjectBase
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x00068F6C File Offset: 0x0006716C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateAxis()
		{
			Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateAxis");
			IControllerTemplateAxis.NativeMethodInfoPtr_get_positiveDescriptiveName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr, 100665966);
			IControllerTemplateAxis.NativeMethodInfoPtr_get_negativeDescriptiveName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr, 100665967);
			IControllerTemplateAxis.NativeMethodInfoPtr_GetDescriptiveName_Public_Abstract_Virtual_New_String_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr, 100665968);
			IControllerTemplateAxis.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr, 100665969);
			IControllerTemplateAxis.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr, 100665970);
			IControllerTemplateAxis.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateAxisSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr, 100665971);
			IControllerTemplateAxis.NativeMethodInfoPtr_get_AsButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateAxis>.NativeClassPtr, 100665972);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00069020 File Offset: 0x00067220
		public unsafe virtual string positiveDescriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis.NativeMethodInfoPtr_get_positiveDescriptiveName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00069064 File Offset: 0x00067264
		public unsafe virtual string negativeDescriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis.NativeMethodInfoPtr_get_negativeDescriptiveName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000690A8 File Offset: 0x000672A8
		[CallerCount(0)]
		public unsafe virtual string GetDescriptiveName(AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisRange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis.NativeMethodInfoPtr_GetDescriptiveName_Public_Abstract_Virtual_New_String_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000690F8 File Offset: 0x000672F8
		public unsafe virtual float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis.NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00069140 File Offset: 0x00067340
		public unsafe virtual float valuePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis.NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x00069188 File Offset: 0x00067388
		public unsafe virtual IControllerTemplateAxisSource source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateAxisSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxisSource>(intPtr3) : null;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x000691D4 File Offset: 0x000673D4
		public unsafe virtual IControllerTemplateButton AsButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateAxis.NativeMethodInfoPtr_get_AsButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0000745D File Offset: 0x0000565D
		public IControllerTemplateAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveDescriptiveName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeDescriptiveName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptiveName_Public_Abstract_Virtual_New_String_AxisRange_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateAxisSource_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_get_AsButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;
	}
}
