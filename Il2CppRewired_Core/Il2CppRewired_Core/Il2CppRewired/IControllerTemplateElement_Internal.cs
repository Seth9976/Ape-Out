using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x02000074 RID: 116
	public class IControllerTemplateElement_Internal : Il2CppObjectBase
	{
		// Token: 0x06001007 RID: 4103 RVA: 0x00068D80 File Offset: 0x00066F80
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateElement_Internal()
		{
			Il2CppClassPointerStore<IControllerTemplateElement_Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "IControllerTemplateElement_Internal");
			IControllerTemplateElement_Internal.NativeMethodInfoPtr_get_parent_Public_Abstract_Virtual_New_get_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement_Internal>.NativeClassPtr, 100665962);
			IControllerTemplateElement_Internal.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement_Internal>.NativeClassPtr, 100665963);
			IControllerTemplateElement_Internal.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement_Internal>.NativeClassPtr, 100665964);
			IControllerTemplateElement_Internal.NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElement_Internal>.NativeClassPtr, 100665965);
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00068DF8 File Offset: 0x00066FF8
		public unsafe virtual IControllerTemplate parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement_Internal.NativeMethodInfoPtr_get_parent_Public_Abstract_Virtual_New_get_IControllerTemplate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x00068E44 File Offset: 0x00067044
		public unsafe virtual int elementCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement_Internal.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00068E8C File Offset: 0x0006708C
		[CallerCount(0)]
		public unsafe virtual IControllerTemplateElement GetElement(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement_Internal.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00068EE4 File Offset: 0x000670E4
		[CallerCount(0)]
		public unsafe virtual int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(find));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElement_Internal.NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			list = ((intPtr4 == 0) ? null : new IList<ControllerTemplateElementTarget>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00007454 File Offset: 0x00005654
		public IControllerTemplateElement_Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_Abstract_Virtual_New_get_IControllerTemplate_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0;
	}
}
