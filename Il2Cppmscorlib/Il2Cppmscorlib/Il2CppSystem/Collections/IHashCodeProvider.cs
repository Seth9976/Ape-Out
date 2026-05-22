using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200047F RID: 1151
	public class IHashCodeProvider : Il2CppObjectBase
	{
		// Token: 0x060045E8 RID: 17896 RVA: 0x0001A8E5 File Offset: 0x00018AE5
		// Note: this type is marked as 'beforefieldinit'.
		static IHashCodeProvider()
		{
			Il2CppClassPointerStore<IHashCodeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IHashCodeProvider");
			IHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHashCodeProvider>.NativeClassPtr, 100673551);
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x0014165C File Offset: 0x0013F85C
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x0001A914 File Offset: 0x00018B14
		public IHashCodeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038D6 RID: 14550
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0;
	}
}
