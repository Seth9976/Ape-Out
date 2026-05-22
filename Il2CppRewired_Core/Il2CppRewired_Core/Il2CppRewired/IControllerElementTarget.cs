using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x02000092 RID: 146
	public class IControllerElementTarget : Il2CppObjectBase
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x0006DD2C File Offset: 0x0006BF2C
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerElementTarget()
		{
			Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerElementTarget");
			IControllerElementTarget.NativeMethodInfoPtr_get_elementIdentifierId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr, 100666134);
			IControllerElementTarget.NativeMethodInfoPtr_get_axisRange_Public_Abstract_Virtual_New_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr, 100666135);
			IControllerElementTarget.NativeMethodInfoPtr_get_hasTarget_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr, 100666136);
			IControllerElementTarget.NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr, 100666137);
			IControllerElementTarget.NativeMethodInfoPtr_get_descriptiveName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr, 100666138);
			IControllerElementTarget.NativeMethodInfoPtr_get_controller_Public_Abstract_Virtual_New_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr, 100666139);
			IControllerElementTarget.NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerElementTarget>.NativeClassPtr, 100666140);
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0006DDE0 File Offset: 0x0006BFE0
		public unsafe virtual int elementIdentifierId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementTarget.NativeMethodInfoPtr_get_elementIdentifierId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0006DE28 File Offset: 0x0006C028
		public unsafe virtual AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementTarget.NativeMethodInfoPtr_get_axisRange_Public_Abstract_Virtual_New_get_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0006DE70 File Offset: 0x0006C070
		public unsafe virtual bool hasTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementTarget.NativeMethodInfoPtr_get_hasTarget_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0006DEB8 File Offset: 0x0006C0B8
		public unsafe virtual ControllerElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementTarget.NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_ControllerElementType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0006DF00 File Offset: 0x0006C100
		public unsafe virtual string descriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementTarget.NativeMethodInfoPtr_get_descriptiveName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0006DF44 File Offset: 0x0006C144
		public unsafe virtual Controller controller
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementTarget.NativeMethodInfoPtr_get_controller_Public_Abstract_Virtual_New_get_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0006DF90 File Offset: 0x0006C190
		public unsafe virtual Controller.Element element
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerElementTarget.NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_Element_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr3) : null;
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00007B34 File Offset: 0x00005D34
		public IControllerElementTarget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifierId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_Abstract_Virtual_New_get_AxisRange_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_get_hasTarget_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_Abstract_Virtual_New_get_ControllerElementType_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_Abstract_Virtual_New_get_Controller_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_get_element_Public_Abstract_Virtual_New_get_Element_0;
	}
}
