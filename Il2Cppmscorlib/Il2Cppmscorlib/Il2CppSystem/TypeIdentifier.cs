using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x02000140 RID: 320
	public class TypeIdentifier : Il2CppObjectBase
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x00007EF5 File Offset: 0x000060F5
		// Note: this type is marked as 'beforefieldinit'.
		static TypeIdentifier()
		{
			Il2CppClassPointerStore<TypeIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeIdentifier");
			TypeIdentifier.NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifier>.NativeClassPtr, 100667205);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0008BA88 File Offset: 0x00089C88
		public unsafe virtual string InternalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeIdentifier.NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00007F24 File Offset: 0x00006124
		public TypeIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0;
	}
}
