using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000479 RID: 1145
	public class IComparer : Il2CppObjectBase
	{
		// Token: 0x060045C8 RID: 17864 RVA: 0x0001A851 File Offset: 0x00018A51
		// Note: this type is marked as 'beforefieldinit'.
		static IComparer()
		{
			Il2CppClassPointerStore<IComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IComparer");
			IComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComparer>.NativeClassPtr, 100673531);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00140DF4 File Offset: 0x0013EFF4
		[CallerCount(0)]
		public unsafe virtual int Compare(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x0001A880 File Offset: 0x00018A80
		public IComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038C2 RID: 14530
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_Object_Object_0;
	}
}
