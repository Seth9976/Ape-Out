using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032F RID: 815
	public class ISerializable : Il2CppObjectBase
	{
		// Token: 0x06003584 RID: 13700 RVA: 0x00012E10 File Offset: 0x00011010
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializable()
		{
			Il2CppClassPointerStore<ISerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISerializable");
			ISerializable.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializable>.NativeClassPtr, 100671647);
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x00107970 File Offset: 0x00105B70
		[CallerCount(0)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializable.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00012E3F File Offset: 0x0001103F
		public ISerializable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D52 RID: 11602
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0;
	}
}
