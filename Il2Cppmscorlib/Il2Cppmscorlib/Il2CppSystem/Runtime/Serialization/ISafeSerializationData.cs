using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033D RID: 829
	public class ISafeSerializationData : Il2CppObjectBase
	{
		// Token: 0x0600366C RID: 13932 RVA: 0x00013471 File Offset: 0x00011671
		// Note: this type is marked as 'beforefieldinit'.
		static ISafeSerializationData()
		{
			Il2CppClassPointerStore<ISafeSerializationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISafeSerializationData");
			ISafeSerializationData.NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISafeSerializationData>.NativeClassPtr, 100671758);
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x0010B198 File Offset: 0x00109398
		[CallerCount(0)]
		public unsafe virtual void CompleteDeserialization(Object deserialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deserialized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISafeSerializationData.NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x000134A0 File Offset: 0x000116A0
		public ISafeSerializationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
