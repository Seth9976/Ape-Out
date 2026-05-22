using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000B9 RID: 185
	public class IComparable : Il2CppObjectBase
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x000056DC File Offset: 0x000038DC
		// Note: this type is marked as 'beforefieldinit'.
		static IComparable()
		{
			Il2CppClassPointerStore<IComparable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IComparable");
			IComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComparable>.NativeClassPtr, 100665514);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
		[CallerCount(0)]
		public unsafe virtual int CompareTo(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0000570B File Offset: 0x0000390B
		public IComparable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0;
	}
}
