using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000482 RID: 1154
	public class IStructuralEquatable : Il2CppObjectBase
	{
		// Token: 0x060045FA RID: 17914 RVA: 0x00141B48 File Offset: 0x0013FD48
		// Note: this type is marked as 'beforefieldinit'.
		static IStructuralEquatable()
		{
			Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IStructuralEquatable");
			IStructuralEquatable.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr, 100673563);
			IStructuralEquatable.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr, 100673564);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00141B98 File Offset: 0x0013FD98
		[CallerCount(0)]
		public unsafe virtual bool Equals(Object other, IEqualityComparer comparer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralEquatable.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00141C04 File Offset: 0x0013FE04
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralEquatable.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x0001A95E File Offset: 0x00018B5E
		public IStructuralEquatable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0;
	}
}
