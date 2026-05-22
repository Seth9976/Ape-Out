using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppI2.Loc
{
	// Token: 0x0200025F RID: 607
	public class ILocalizationParamsManager : Il2CppObjectBase
	{
		// Token: 0x06004620 RID: 17952 RVA: 0x00029C45 File Offset: 0x00027E45
		// Note: this type is marked as 'beforefieldinit'.
		static ILocalizationParamsManager()
		{
			Il2CppClassPointerStore<ILocalizationParamsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ILocalizationParamsManager");
			ILocalizationParamsManager.NativeMethodInfoPtr_GetParameterValue_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizationParamsManager>.NativeClassPtr, 100670391);
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00105CF0 File Offset: 0x00103EF0
		[CallerCount(0)]
		public unsafe virtual string GetParameterValue(string Param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizationParamsManager.NativeMethodInfoPtr_GetParameterValue_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x00029C74 File Offset: 0x00027E74
		public ILocalizationParamsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeMethodInfoPtr_GetParameterValue_Public_Abstract_Virtual_New_String_String_0;
	}
}
