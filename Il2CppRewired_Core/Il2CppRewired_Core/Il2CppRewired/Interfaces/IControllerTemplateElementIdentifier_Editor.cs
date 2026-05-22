using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppRewired.Interfaces
{
	// Token: 0x020000EE RID: 238
	public class IControllerTemplateElementIdentifier_Editor : Il2CppObjectBase
	{
		// Token: 0x06001879 RID: 6265 RVA: 0x0008B444 File Offset: 0x00089644
		// Note: this type is marked as 'beforefieldinit'.
		static IControllerTemplateElementIdentifier_Editor()
		{
			Il2CppClassPointerStore<IControllerTemplateElementIdentifier_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Interfaces", "IControllerTemplateElementIdentifier_Editor");
			IControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_scriptingName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100669246);
			IControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_alternateScriptingName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100669247);
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x0008B494 File Offset: 0x00089694
		public unsafe virtual string scriptingName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_scriptingName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x0008B4D8 File Offset: 0x000896D8
		public unsafe virtual string alternateScriptingName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_alternateScriptingName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0000A225 File Offset: 0x00008425
		public IControllerTemplateElementIdentifier_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeMethodInfoPtr_get_scriptingName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeMethodInfoPtr_get_alternateScriptingName_Public_Abstract_Virtual_New_get_String_0;
	}
}
