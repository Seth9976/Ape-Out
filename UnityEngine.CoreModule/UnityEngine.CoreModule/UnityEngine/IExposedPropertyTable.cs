using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000051 RID: 81
	public class IExposedPropertyTable : Il2CppObjectBase
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x000046CE File Offset: 0x000028CE
		// Note: this type is marked as 'beforefieldinit'.
		static IExposedPropertyTable()
		{
			Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "IExposedPropertyTable");
			IExposedPropertyTable.NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr, 100663623);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		[CallerCount(0)]
		public unsafe virtual Object GetReferenceValue(PropertyName id, out bool idValid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idValid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExposedPropertyTable.NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000046FD File Offset: 0x000028FD
		public IExposedPropertyTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0;
	}
}
