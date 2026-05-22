using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Lifetime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039D RID: 925
	public class ServerIdentity : Identity
	{
		// Token: 0x06003D51 RID: 15697 RVA: 0x00122844 File Offset: 0x00120A44
		// Note: this type is marked as 'beforefieldinit'.
		static ServerIdentity()
		{
			Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ServerIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr);
			ServerIdentity.NativeFieldInfoPtr__objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_objectType");
			ServerIdentity.NativeFieldInfoPtr__serverObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_serverObject");
			ServerIdentity.NativeFieldInfoPtr__serverSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_serverSink");
			ServerIdentity.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_context");
			ServerIdentity.NativeFieldInfoPtr__lease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_lease");
			ServerIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672399);
			ServerIdentity.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672400);
			ServerIdentity.NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672401);
			ServerIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672402);
			ServerIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672403);
			ServerIdentity.NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672404);
			ServerIdentity.NativeMethodInfoPtr_get_Lease_Public_get_Lease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672405);
			ServerIdentity.NativeMethodInfoPtr_get_Context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672406);
			ServerIdentity.NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672407);
			ServerIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672408);
			ServerIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672409);
			ServerIdentity.NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672410);
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x001229C8 File Offset: 0x00120BC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220996, RefRangeEnd = 221002, XrefRangeStart = 220996, XrefRangeEnd = 220996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerIdentity(string objectUri, Context context, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x00122A38 File Offset: 0x00120C38
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00122A78 File Offset: 0x00120C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221002, XrefRangeEnd = 221016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTrackingLifetime(ILease lease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00122ABC File Offset: 0x00120CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221017, RefRangeEnd = 221018, XrefRangeStart = 221016, XrefRangeEnd = 221017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnLifetimeExpired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00122AF8 File Offset: 0x00120CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221018, XrefRangeEnd = 221034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00122B54 File Offset: 0x00120D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221041, RefRangeEnd = 221043, XrefRangeStart = 221034, XrefRangeEnd = 221041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachServerObject(MarshalByRefObject serverObject, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x00122BA8 File Offset: 0x00120DA8
		public unsafe Lease Lease
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_Lease_Public_get_Lease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lease>(intPtr3) : null;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06003D59 RID: 15705 RVA: 0x00122BE8 File Offset: 0x00120DE8
		// (set) Token: 0x06003D5A RID: 15706 RVA: 0x00122C28 File Offset: 0x00120E28
		public unsafe Context Context
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_Context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00122C6C File Offset: 0x00120E6C
		[CallerCount(0)]
		public unsafe virtual IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x00122CC8 File Offset: 0x00120EC8
		[CallerCount(0)]
		public unsafe virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00122D38 File Offset: 0x00120F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221017, RefRangeEnd = 221018, XrefRangeStart = 221017, XrefRangeEnd = 221018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeServerObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00016DFF File Offset: 0x00014FFF
		public ServerIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00122D6C File Offset: 0x00120F6C
		// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00016E08 File Offset: 0x00015008
		public unsafe Type _objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x00122D9C File Offset: 0x00120F9C
		// (set) Token: 0x06003D62 RID: 15714 RVA: 0x00016E27 File Offset: 0x00015027
		public unsafe MarshalByRefObject _serverObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00122DCC File Offset: 0x00120FCC
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00016E46 File Offset: 0x00015046
		public unsafe IMessageSink _serverSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00122DFC File Offset: 0x00120FFC
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x00016E65 File Offset: 0x00015065
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x00122E2C File Offset: 0x0012102C
		// (set) Token: 0x06003D68 RID: 15720 RVA: 0x00016E84 File Offset: 0x00015084
		public unsafe Lease _lease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__lease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lease>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__lease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeFieldInfoPtr__objectType;

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeFieldInfoPtr__serverObject;

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeFieldInfoPtr__serverSink;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeFieldInfoPtr__lease;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0;

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr_get_Lease_Public_get_Lease_0;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_Context_0;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040032E9 RID: 13033
		private static readonly IntPtr NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0;
	}
}
