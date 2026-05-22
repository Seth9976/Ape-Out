using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003AA RID: 938
	public class ProxyAttribute : Attribute
	{
		// Token: 0x06003DDE RID: 15838 RVA: 0x00124A48 File Offset: 0x00122C48
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyAttribute()
		{
			Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "ProxyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr);
			ProxyAttribute.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100672469);
			ProxyAttribute.NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100672470);
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x00124AA0 File Offset: 0x00122CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221504, XrefRangeEnd = 221514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MarshalByRefObject CreateInstance(Type serverType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProxyAttribute.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
			}
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00124AFC File Offset: 0x00122CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221514, XrefRangeEnd = 221519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, Object serverObject, Context serverContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProxyAttribute.NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr3) : null;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00017120 File Offset: 0x00015320
		public ProxyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003338 RID: 13112
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0;

		// Token: 0x04003339 RID: 13113
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0;
	}
}
