using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000392 RID: 914
	public class Identity : Object
	{
		// Token: 0x06003C42 RID: 15426 RVA: 0x0011E7B8 File Offset: 0x0011C9B8
		// Note: this type is marked as 'beforefieldinit'.
		static Identity()
		{
			Il2CppClassPointerStore<Identity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "Identity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Identity>.NativeClassPtr);
			Identity.NativeFieldInfoPtr__objectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_objectUri");
			Identity.NativeFieldInfoPtr__channelSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_channelSink");
			Identity.NativeFieldInfoPtr__envoySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_envoySink");
			Identity.NativeFieldInfoPtr__clientDynamicProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_clientDynamicProperties");
			Identity.NativeFieldInfoPtr__serverDynamicProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_serverDynamicProperties");
			Identity.NativeFieldInfoPtr__objRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_objRef");
			Identity.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_disposed");
			Identity.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672262);
			Identity.NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672263);
			Identity.NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672264);
			Identity.NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672265);
			Identity.NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672266);
			Identity.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672267);
			Identity.NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672268);
			Identity.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672269);
			Identity.NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672270);
			Identity.NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672271);
			Identity.NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672272);
			Identity.NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672273);
			Identity.NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672274);
			Identity.NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100672275);
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x0011E98C File Offset: 0x0011CB8C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Identity(string objectUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Identity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x0011E9D8 File Offset: 0x0011CBD8
		[CallerCount(0)]
		public unsafe virtual ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Identity.NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x0011EA34 File Offset: 0x0011CC34
		// (set) Token: 0x06003C46 RID: 15430 RVA: 0x0011EA74 File Offset: 0x0011CC74
		public unsafe IMessageSink ChannelSink
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x0011EAB8 File Offset: 0x0011CCB8
		public unsafe IMessageSink EnvoySink
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x0011EAF8 File Offset: 0x0011CCF8
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x0011EB30 File Offset: 0x0011CD30
		public unsafe string ObjectUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x0011EB74 File Offset: 0x0011CD74
		public unsafe bool IsConnected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x0011EBB0 File Offset: 0x0011CDB0
		// (set) Token: 0x06003C4C RID: 15436 RVA: 0x0011EBEC File Offset: 0x0011CDEC
		public unsafe bool Disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x0011EC2C File Offset: 0x0011CE2C
		public unsafe DynamicPropertyCollection ClientDynamicProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219063, XrefRangeEnd = 219067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x0011EC6C File Offset: 0x0011CE6C
		public unsafe bool HasServerDynamicSinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0011ECA8 File Offset: 0x0011CEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219067, XrefRangeEnd = 219068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x0011ED14 File Offset: 0x0011CF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219068, XrefRangeEnd = 219069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x000167A6 File Offset: 0x000149A6
		public Identity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x0011ED80 File Offset: 0x0011CF80
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x000167AF File Offset: 0x000149AF
		public unsafe string _objectUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objectUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objectUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x0011EDA8 File Offset: 0x0011CFA8
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x000167CE File Offset: 0x000149CE
		public unsafe IMessageSink _channelSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__channelSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__channelSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x0011EDD8 File Offset: 0x0011CFD8
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x000167ED File Offset: 0x000149ED
		public unsafe IMessageSink _envoySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__envoySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__envoySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x0011EE08 File Offset: 0x0011D008
		// (set) Token: 0x06003C59 RID: 15449 RVA: 0x0001680C File Offset: 0x00014A0C
		public unsafe DynamicPropertyCollection _clientDynamicProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__clientDynamicProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__clientDynamicProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x0011EE38 File Offset: 0x0011D038
		// (set) Token: 0x06003C5B RID: 15451 RVA: 0x0001682B File Offset: 0x00014A2B
		public unsafe DynamicPropertyCollection _serverDynamicProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__serverDynamicProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__serverDynamicProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x0011EE68 File Offset: 0x0011D068
		// (set) Token: 0x06003C5D RID: 15453 RVA: 0x0001684A File Offset: 0x00014A4A
		public unsafe ObjRef _objRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x0011EE98 File Offset: 0x0011D098
		// (set) Token: 0x06003C5F RID: 15455 RVA: 0x00016869 File Offset: 0x00014A69
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeFieldInfoPtr__objectUri;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeFieldInfoPtr__channelSink;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeFieldInfoPtr__envoySink;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeFieldInfoPtr__clientDynamicProperties;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeFieldInfoPtr__serverDynamicProperties;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeFieldInfoPtr__objRef;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0;

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0;

		// Token: 0x0400322C RID: 12844
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0;

		// Token: 0x0400322D RID: 12845
		private static readonly IntPtr NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0;

		// Token: 0x0400322E RID: 12846
		private static readonly IntPtr NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x0400322F RID: 12847
		private static readonly IntPtr NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0;
	}
}
