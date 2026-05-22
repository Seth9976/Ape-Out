using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003C2 RID: 962
	public class IDynamicProperty : Il2CppObjectBase
	{
		// Token: 0x06003EF1 RID: 16113 RVA: 0x0001781C File Offset: 0x00015A1C
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicProperty()
		{
			Il2CppClassPointerStore<IDynamicProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IDynamicProperty");
			IDynamicProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicProperty>.NativeClassPtr, 100672610);
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x00128890 File Offset: 0x00126A90
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0001784B File Offset: 0x00015A4B
		public IDynamicProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033F0 RID: 13296
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}
