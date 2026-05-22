using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000A8 RID: 168
	public class IHardwareControllerMap : Il2CppObjectBase
	{
		// Token: 0x06001480 RID: 5248 RVA: 0x00079BF0 File Offset: 0x00077DF0
		// Note: this type is marked as 'beforefieldinit'.
		static IHardwareControllerMap()
		{
			Il2CppClassPointerStore<IHardwareControllerMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "IHardwareControllerMap");
			IHardwareControllerMap.NativeMethodInfoPtr_GetElementIdentifierNames_Public_Abstract_Virtual_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerMap>.NativeClassPtr, 100666754);
			IHardwareControllerMap.NativeMethodInfoPtr_GetElementIdentifierIds_Public_Abstract_Virtual_New_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerMap>.NativeClassPtr, 100666755);
			IHardwareControllerMap.NativeMethodInfoPtr_ContainsElementIdentifier_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerMap>.NativeClassPtr, 100666756);
			IHardwareControllerMap.NativeMethodInfoPtr_GetMappableElementIdentifierInfo_Public_Abstract_Virtual_New_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHardwareControllerMap>.NativeClassPtr, 100666757);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00079C68 File Offset: 0x00077E68
		[CallerCount(0)]
		public unsafe virtual Il2CppStringArray GetElementIdentifierNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerMap.NativeMethodInfoPtr_GetElementIdentifierNames_Public_Abstract_Virtual_New_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00079CB4 File Offset: 0x00077EB4
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<int> GetElementIdentifierIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerMap.NativeMethodInfoPtr_GetElementIdentifierIds_Public_Abstract_Virtual_New_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00079D00 File Offset: 0x00077F00
		[CallerCount(0)]
		public unsafe virtual bool ContainsElementIdentifier(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerMap.NativeMethodInfoPtr_ContainsElementIdentifier_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00079D54 File Offset: 0x00077F54
		[CallerCount(0)]
		public unsafe virtual int GetMappableElementIdentifierInfo(out Il2CppStringArray names, out Il2CppStructArray<int> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHardwareControllerMap.NativeMethodInfoPtr_GetMappableElementIdentifierInfo_Public_Abstract_Virtual_New_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			names = ((intPtr5 == 0) ? null : new Il2CppStringArray(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ids = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00008E54 File Offset: 0x00007054
		public IHardwareControllerMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierNames_Public_Abstract_Virtual_New_Il2CppStringArray_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_GetElementIdentifierIds_Public_Abstract_Virtual_New_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_ContainsElementIdentifier_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_GetMappableElementIdentifierInfo_Public_Abstract_Virtual_New_Int32_byref_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_0;
	}
}
