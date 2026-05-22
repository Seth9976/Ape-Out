using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x0200026B RID: 619
	public class IResourceManager_Bundles : Il2CppObjectBase
	{
		// Token: 0x06004679 RID: 18041 RVA: 0x00029E51 File Offset: 0x00028051
		// Note: this type is marked as 'beforefieldinit'.
		static IResourceManager_Bundles()
		{
			Il2CppClassPointerStore<IResourceManager_Bundles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "IResourceManager_Bundles");
			IResourceManager_Bundles.NativeMethodInfoPtr_LoadFromBundle_Public_Abstract_Virtual_New_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceManager_Bundles>.NativeClassPtr, 100670430);
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x00106F40 File Offset: 0x00105140
		[CallerCount(0)]
		public unsafe virtual global::UnityEngine.Object LoadFromBundle(string path, Type assetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceManager_Bundles.NativeMethodInfoPtr_LoadFromBundle_Public_Abstract_Virtual_New_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00029E80 File Offset: 0x00028080
		public IResourceManager_Bundles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromBundle_Public_Abstract_Virtual_New_Object_String_Type_0;
	}
}
