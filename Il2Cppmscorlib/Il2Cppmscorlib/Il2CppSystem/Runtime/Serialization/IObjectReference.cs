using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032E RID: 814
	public class IObjectReference : Il2CppObjectBase
	{
		// Token: 0x06003581 RID: 13697 RVA: 0x00012DD8 File Offset: 0x00010FD8
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectReference()
		{
			Il2CppClassPointerStore<IObjectReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "IObjectReference");
			IObjectReference.NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectReference>.NativeClassPtr, 100671646);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x00107910 File Offset: 0x00105B10
		[CallerCount(0)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectReference.NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00012E07 File Offset: 0x00011007
		public IObjectReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D51 RID: 11601
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0;
	}
}
