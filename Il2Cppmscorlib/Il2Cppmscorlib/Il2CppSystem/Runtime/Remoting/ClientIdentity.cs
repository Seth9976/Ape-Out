using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000393 RID: 915
	public class ClientIdentity : Identity
	{
		// Token: 0x06003C60 RID: 15456 RVA: 0x0011EEC0 File Offset: 0x0011D0C0
		// Note: this type is marked as 'beforefieldinit'.
		static ClientIdentity()
		{
			Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ClientIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr);
			ClientIdentity.NativeFieldInfoPtr__proxyReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, "_proxyReference");
			ClientIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672276);
			ClientIdentity.NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672277);
			ClientIdentity.NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672278);
			ClientIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672279);
			ClientIdentity.NativeMethodInfoPtr_get_TargetUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672280);
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x0011EF68 File Offset: 0x0011D168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219072, RefRangeEnd = 219073, XrefRangeStart = 219069, XrefRangeEnd = 219072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientIdentity(string objectUri, ObjRef objRef)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06003C62 RID: 15458 RVA: 0x0011EFC8 File Offset: 0x0011D1C8
		// (set) Token: 0x06003C63 RID: 15459 RVA: 0x0011F008 File Offset: 0x0011D208
		public unsafe MarshalByRefObject ClientProxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219073, XrefRangeEnd = 219075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219079, RefRangeEnd = 219081, XrefRangeStart = 219075, XrefRangeEnd = 219079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x0011F04C File Offset: 0x0011D24C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x0011F0A8 File Offset: 0x0011D2A8
		public unsafe string TargetUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219081, XrefRangeEnd = 219082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_get_TargetUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00016884 File Offset: 0x00014A84
		public ClientIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x0011F0E0 File Offset: 0x0011D2E0
		// (set) Token: 0x06003C68 RID: 15464 RVA: 0x0001688D File Offset: 0x00014A8D
		public unsafe WeakReference _proxyReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientIdentity.NativeFieldInfoPtr__proxyReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientIdentity.NativeFieldInfoPtr__proxyReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeFieldInfoPtr__proxyReference;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0;

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetUri_Public_get_String_0;
	}
}
