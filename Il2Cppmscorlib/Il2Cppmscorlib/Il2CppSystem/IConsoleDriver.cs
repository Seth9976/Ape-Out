using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x0200011E RID: 286
	public class IConsoleDriver : Il2CppObjectBase
	{
		// Token: 0x060014A7 RID: 5287 RVA: 0x0000719A File Offset: 0x0000539A
		// Note: this type is marked as 'beforefieldinit'.
		static IConsoleDriver()
		{
			Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IConsoleDriver");
			IConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr, 100666885);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00082CE8 File Offset: 0x00080EE8
		[CallerCount(0)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x000071C9 File Offset: 0x000053C9
		public IConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0;
	}
}
