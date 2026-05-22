using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000090 RID: 144
	public static class Ref : Object
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x00006DEE File Offset: 0x00004FEE
		// Note: this type is marked as 'beforefieldinit'.
		static Ref()
		{
			Il2CppClassPointerStore<Ref>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ref>.NativeClassPtr);
			Ref.NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ref>.NativeClassPtr, 100665571);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00051AF4 File Offset: 0x0004FCF4
		[CallerCount(0)]
		public unsafe static bool Equal(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ref.NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00006E27 File Offset: 0x00005027
		public Ref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0;
	}
}
