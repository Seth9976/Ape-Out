using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000481 RID: 1153
	public class IStructuralComparable : Il2CppObjectBase
	{
		// Token: 0x060045F7 RID: 17911 RVA: 0x0001A926 File Offset: 0x00018B26
		// Note: this type is marked as 'beforefieldinit'.
		static IStructuralComparable()
		{
			Il2CppClassPointerStore<IStructuralComparable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IStructuralComparable");
			IStructuralComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralComparable>.NativeClassPtr, 100673562);
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00141ADC File Offset: 0x0013FCDC
		[CallerCount(0)]
		public unsafe virtual int CompareTo(Object other, IComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_IComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x0001A955 File Offset: 0x00018B55
		public IStructuralComparable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_IComparer_0;
	}
}
