using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000391 RID: 913
	public class IRemotingTypeInfo : Il2CppObjectBase
	{
		// Token: 0x06003C3E RID: 15422 RVA: 0x0011E6B8 File Offset: 0x0011C8B8
		// Note: this type is marked as 'beforefieldinit'.
		static IRemotingTypeInfo()
		{
			Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IRemotingTypeInfo");
			IRemotingTypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr, 100672260);
			IRemotingTypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr, 100672261);
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x0011E708 File Offset: 0x0011C908
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRemotingTypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x0011E74C File Offset: 0x0011C94C
		[CallerCount(0)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRemotingTypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x0001679D File Offset: 0x0001499D
		public IRemotingTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0;
	}
}
