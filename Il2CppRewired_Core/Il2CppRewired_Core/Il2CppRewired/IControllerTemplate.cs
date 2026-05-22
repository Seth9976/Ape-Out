using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired
{
	// Token: 0x02000071 RID: 113
	public class IControllerTemplate : Il2CppObjectBase
	{
		// Token: 0x06000FD0 RID: 4048 RVA: 0x00067E40 File Offset: 0x00066040
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplate()
		{
			Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplate");
			IControllerTemplate.NativeMethodInfoPtr_get_controller_Public_Abstract_Virtual_New_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665811);
			IControllerTemplate.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665812);
			IControllerTemplate.NativeMethodInfoPtr_get_typeGuid_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665813);
			IControllerTemplate.NativeMethodInfoPtr_get_elements_Public_Abstract_Virtual_New_get_IList_1_IControllerTemplateElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665814);
			IControllerTemplate.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665815);
			IControllerTemplate.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665816);
			IControllerTemplate.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665817);
			IControllerTemplate.NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_IList_1_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr, 100665818);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00067F08 File Offset: 0x00066108
		public unsafe virtual Controller controller
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.NativeMethodInfoPtr_get_controller_Public_Abstract_Virtual_New_get_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00067F54 File Offset: 0x00066154
		public unsafe virtual string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00067F98 File Offset: 0x00066198
		public unsafe virtual Guid typeGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.NativeMethodInfoPtr_get_typeGuid_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00067FE0 File Offset: 0x000661E0
		public unsafe virtual IList<IControllerTemplateElement> elements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.NativeMethodInfoPtr_get_elements_Public_Abstract_Virtual_New_get_IList_1_IControllerTemplateElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IControllerTemplateElement>>(intPtr3) : null;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0006802C File Offset: 0x0006622C
		public unsafe virtual int elementCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00068074 File Offset: 0x00066274
		[CallerCount(0)]
		public unsafe virtual IControllerTemplateElement GetElement(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000680CC File Offset: 0x000662CC
		[CallerCount(0)]
		public unsafe virtual T GetElement<T>(int id) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.MethodInfoStoreGeneric_GetElement_Public_Abstract_Virtual_New_T_Int32_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00068120 File Offset: 0x00066320
		[CallerCount(0)]
		public unsafe virtual int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(target));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplate.NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_IList_1_ControllerTemplateElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00007349 File Offset: 0x00005549
		public IControllerTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_Abstract_Virtual_New_get_Controller_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_get_typeGuid_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_get_elements_Public_Abstract_Virtual_New_get_IList_1_IControllerTemplateElement_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_T_Int32_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_IList_1_ControllerTemplateElementTarget_0;

		// Token: 0x0200028B RID: 651
		private sealed class MethodInfoStoreGeneric_GetElement_Public_Abstract_Virtual_New_T_Int32_0<T>
		{
			// Token: 0x040031B2 RID: 12722
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IControllerTemplate.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_T_Int32_0, Il2CppClassPointerStore<IControllerTemplate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
