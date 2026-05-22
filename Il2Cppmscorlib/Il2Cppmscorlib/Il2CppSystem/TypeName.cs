using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x0200013F RID: 319
	public class TypeName : Il2CppObjectBase
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x00007EBD File Offset: 0x000060BD
		// Note: this type is marked as 'beforefieldinit'.
		static TypeName()
		{
			Il2CppClassPointerStore<TypeName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeName");
			TypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeName>.NativeClassPtr, 100667204);
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0008BA44 File Offset: 0x00089C44
		public unsafe virtual string DisplayName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00007EEC File Offset: 0x000060EC
		public TypeName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0;
	}
}
