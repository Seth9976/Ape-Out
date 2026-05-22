using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Services
{
	// Token: 0x020003A8 RID: 936
	public class ITrackingHandler : Il2CppObjectBase
	{
		// Token: 0x06003DD2 RID: 15826 RVA: 0x00124764 File Offset: 0x00122964
		// Note: this type is marked as 'beforefieldinit'.
		static ITrackingHandler()
		{
			Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Services", "ITrackingHandler");
			ITrackingHandler.NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100672462);
			ITrackingHandler.NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100672463);
			ITrackingHandler.NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100672464);
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x001247C8 File Offset: 0x001229C8
		[CallerCount(0)]
		public unsafe virtual void DisconnectedObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00124818 File Offset: 0x00122A18
		[CallerCount(0)]
		public unsafe virtual void MarshaledObject(Object obj, ObjRef or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00124878 File Offset: 0x00122A78
		[CallerCount(0)]
		public unsafe virtual void UnmarshaledObject(Object obj, ObjRef or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x000170FC File Offset: 0x000152FC
		public ITrackingHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003331 RID: 13105
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04003332 RID: 13106
		private static readonly IntPtr NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0;

		// Token: 0x04003333 RID: 13107
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0;
	}
}
