using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppRewired.Utils.Interfaces
{
	// Token: 0x020000F9 RID: 249
	public class IExportToJson : Il2CppObjectBase
	{
		// Token: 0x06001912 RID: 6418 RVA: 0x0000A288 File Offset: 0x00008488
		// Note: this type is marked as 'beforefieldinit'.
		static IExportToJson()
		{
			Il2CppClassPointerStore<IExportToJson>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Interfaces", "IExportToJson");
			IExportToJson.NativeMethodInfoPtr_WriteJson_Public_Abstract_Virtual_New_Void_StringBuilder_Action_2_StringBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExportToJson>.NativeClassPtr, 100669377);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0008F0E0 File Offset: 0x0008D2E0
		[CallerCount(0)]
		public unsafe virtual void WriteJson(StringBuilder stringBuilder, Action<StringBuilder, Object> appendValueDelegate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appendValueDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExportToJson.NativeMethodInfoPtr_WriteJson_Public_Abstract_Virtual_New_Void_StringBuilder_Action_2_StringBuilder_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0000A2B7 File Offset: 0x000084B7
		public IExportToJson(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Abstract_Virtual_New_Void_StringBuilder_Action_2_StringBuilder_Object_0;
	}
}
