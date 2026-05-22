using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B5 RID: 949
	public class Context : Object
	{
		// Token: 0x06003E76 RID: 15990 RVA: 0x00126C44 File Offset: 0x00124E44
		// Note: this type is marked as 'beforefieldinit'.
		static Context()
		{
			Il2CppClassPointerStore<Context>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "Context");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context>.NativeClassPtr);
			Context.NativeFieldInfoPtr_domain_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "domain_id");
			Context.NativeFieldInfoPtr_context_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_id");
			Context.NativeFieldInfoPtr_static_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "static_data");
			Context.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "data");
			Context.NativeFieldInfoPtr_local_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "local_slots");
			Context.NativeFieldInfoPtr_default_server_context_sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "default_server_context_sink");
			Context.NativeFieldInfoPtr_server_context_sink_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "server_context_sink_chain");
			Context.NativeFieldInfoPtr_client_context_sink_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "client_context_sink_chain");
			Context.NativeFieldInfoPtr_context_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_properties");
			Context.NativeFieldInfoPtr_global_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "global_count");
			Context.NativeFieldInfoPtr__localDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "_localDataStore");
			Context.NativeFieldInfoPtr__localDataStoreMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "_localDataStoreMgr");
			Context.NativeFieldInfoPtr_global_dynamic_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "global_dynamic_properties");
			Context.NativeFieldInfoPtr_context_dynamic_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_dynamic_properties");
			Context.NativeFieldInfoPtr_callback_object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "callback_object");
			Context.NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672543);
			Context.NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672544);
			Context.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672545);
			Context.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672546);
			Context.NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672547);
			Context.NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672548);
			Context.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672549);
			Context.NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672550);
			Context.NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672551);
			Context.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672552);
			Context.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672553);
			Context.NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672554);
			Context.NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672555);
			Context.NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672556);
			Context.NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672557);
			Context.NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672558);
			Context.NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672559);
			Context.NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672560);
			Context.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672561);
			Context.NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672562);
			Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672563);
			Context.NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672564);
			Context.NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672565);
			Context.NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672566);
			Context.NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672567);
			Context.NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672568);
			Context.NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672569);
			Context.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672570);
			Context.NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672571);
			Context.NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672572);
			Context.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672573);
			Context.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672574);
			Context.NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672575);
			Context.NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672576);
			Context.NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100672577);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x0012705C File Offset: 0x0012525C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131113, RefRangeEnd = 131119, XrefRangeStart = 131113, XrefRangeEnd = 131119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterContext(Context ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00127094 File Offset: 0x00125294
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131113, RefRangeEnd = 131119, XrefRangeStart = 131113, XrefRangeEnd = 131119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseContext(Context ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x001270CC File Offset: 0x001252CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222138, RefRangeEnd = 222139, XrefRangeStart = 222127, XrefRangeEnd = 222138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00127108 File Offset: 0x00125308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222139, XrefRangeEnd = 222143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06003E7B RID: 15995 RVA: 0x00127144 File Offset: 0x00125344
		public unsafe static Context DefaultContext
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 173638, RefRangeEnd = 173641, XrefRangeStart = 173638, XrefRangeEnd = 173641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x00127178 File Offset: 0x00125378
		public unsafe virtual int ContextID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003E7D RID: 15997 RVA: 0x001271C0 File Offset: 0x001253C0
		public unsafe virtual Il2CppReferenceArray<IContextProperty> ContextProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222143, XrefRangeEnd = 222149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IContextProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x0012720C File Offset: 0x0012540C
		public unsafe bool IsDefaultContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06003E7F RID: 15999 RVA: 0x00127248 File Offset: 0x00125448
		public unsafe bool NeedsContextSink
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222149, XrefRangeEnd = 222155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00127284 File Offset: 0x00125484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222155, XrefRangeEnd = 222189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x001272EC File Offset: 0x001254EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222189, XrefRangeEnd = 222223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x00127354 File Offset: 0x00125554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222223, XrefRangeEnd = 222238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr3) : null;
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x001273AC File Offset: 0x001255AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 222248, RefRangeEnd = 222258, XrefRangeStart = 222238, XrefRangeEnd = 222248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x0012740C File Offset: 0x0012560C
		public unsafe static bool HasGlobalDynamicSinks
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222262, RefRangeEnd = 222264, XrefRangeStart = 222258, XrefRangeEnd = 222262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x0012743C File Offset: 0x0012563C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 222265, RefRangeEnd = 222271, XrefRangeStart = 222264, XrefRangeEnd = 222265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06003E86 RID: 16006 RVA: 0x001274A8 File Offset: 0x001256A8
		public unsafe bool HasDynamicSinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x001274E4 File Offset: 0x001256E4
		public unsafe bool HasExitSinks
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222275, RefRangeEnd = 222276, XrefRangeStart = 222271, XrefRangeEnd = 222275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x00127520 File Offset: 0x00125720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222276, XrefRangeEnd = 222287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IContextProperty GetProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContextProperty>(intPtr3) : null;
			}
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x0012757C File Offset: 0x0012577C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222287, XrefRangeEnd = 222313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProperty(IContextProperty prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x001275CC File Offset: 0x001257CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222313, XrefRangeEnd = 222325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Freeze()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x00127608 File Offset: 0x00125808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222325, XrefRangeEnd = 222334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x0012764C File Offset: 0x0012584C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222356, RefRangeEnd = 222358, XrefRangeStart = 222334, XrefRangeEnd = 222356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink GetServerContextSinkChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x0012768C File Offset: 0x0012588C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 222375, RefRangeEnd = 222379, XrefRangeStart = 222358, XrefRangeEnd = 222375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink GetClientContextSinkChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x001276CC File Offset: 0x001258CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 222397, RefRangeEnd = 222402, XrefRangeStart = 222379, XrefRangeEnd = 222397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceInternalExecute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x0012772C File Offset: 0x0012592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222402, XrefRangeEnd = 222419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x0012777C File Offset: 0x0012597C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222419, XrefRangeEnd = 222420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context SwitchToContext(Context newContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x001277C0 File Offset: 0x001259C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222429, RefRangeEnd = 222430, XrefRangeStart = 222420, XrefRangeEnd = 222429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context CreateNewContext(IConstructionCallMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00127804 File Offset: 0x00125A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222430, XrefRangeEnd = 222435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(CrossContextDelegate deleg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deleg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x00127848 File Offset: 0x00125A48
		public unsafe LocalDataStore MyLocalStore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222446, RefRangeEnd = 222448, XrefRangeStart = 222435, XrefRangeEnd = 222446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStore>(intPtr3) : null;
			}
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00127888 File Offset: 0x00125A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222448, XrefRangeEnd = 222454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot AllocateDataSlot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x001278BC File Offset: 0x00125ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222454, XrefRangeEnd = 222460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00127900 File Offset: 0x00125B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222460, XrefRangeEnd = 222466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00127938 File Offset: 0x00125B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222466, XrefRangeEnd = 222472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x0012797C File Offset: 0x00125B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222472, XrefRangeEnd = 222474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetData(LocalDataStoreSlot slot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x001279C0 File Offset: 0x00125BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222474, XrefRangeEnd = 222484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetData(LocalDataStoreSlot slot, Object data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x000174FA File Offset: 0x000156FA
		public Context(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x00127A08 File Offset: 0x00125C08
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x00017503 File Offset: 0x00015703
		public unsafe int domain_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_domain_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_domain_id)) = value;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x00127A30 File Offset: 0x00125C30
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x0001751E File Offset: 0x0001571E
		public unsafe int context_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_id)) = value;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x00127A58 File Offset: 0x00125C58
		// (set) Token: 0x06003EA0 RID: 16032 RVA: 0x00017539 File Offset: 0x00015739
		public unsafe UIntPtr static_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_static_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_static_data)) = value;
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x00127A80 File Offset: 0x00125C80
		// (set) Token: 0x06003EA2 RID: 16034 RVA: 0x00017554 File Offset: 0x00015754
		public unsafe UIntPtr data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x00127AA8 File Offset: 0x00125CA8
		// (set) Token: 0x06003EA4 RID: 16036 RVA: 0x0001756F File Offset: 0x0001576F
		public unsafe static Il2CppReferenceArray<Object> local_slots
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_local_slots, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_local_slots, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x00127AD0 File Offset: 0x00125CD0
		// (set) Token: 0x06003EA6 RID: 16038 RVA: 0x00017581 File Offset: 0x00015781
		public unsafe static IMessageSink default_server_context_sink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_default_server_context_sink, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_default_server_context_sink, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x00127AF8 File Offset: 0x00125CF8
		// (set) Token: 0x06003EA8 RID: 16040 RVA: 0x00017593 File Offset: 0x00015793
		public unsafe IMessageSink server_context_sink_chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_server_context_sink_chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_server_context_sink_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x00127B28 File Offset: 0x00125D28
		// (set) Token: 0x06003EAA RID: 16042 RVA: 0x000175B2 File Offset: 0x000157B2
		public unsafe IMessageSink client_context_sink_chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_client_context_sink_chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_client_context_sink_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06003EAB RID: 16043 RVA: 0x00127B58 File Offset: 0x00125D58
		// (set) Token: 0x06003EAC RID: 16044 RVA: 0x000175D1 File Offset: 0x000157D1
		public unsafe List<IContextProperty> context_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IContextProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06003EAD RID: 16045 RVA: 0x00127B88 File Offset: 0x00125D88
		// (set) Token: 0x06003EAE RID: 16046 RVA: 0x000175F0 File Offset: 0x000157F0
		public unsafe static int global_count
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_global_count, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_global_count, (void*)(&value));
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x00127BA4 File Offset: 0x00125DA4
		// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x000175FE File Offset: 0x000157FE
		public unsafe LocalDataStoreHolder _localDataStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr__localDataStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr__localDataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003EB1 RID: 16049 RVA: 0x00127BD4 File Offset: 0x00125DD4
		// (set) Token: 0x06003EB2 RID: 16050 RVA: 0x0001761D File Offset: 0x0001581D
		public unsafe static LocalDataStoreMgr _localDataStoreMgr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr__localDataStoreMgr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr__localDataStoreMgr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x00127BFC File Offset: 0x00125DFC
		// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x0001762F File Offset: 0x0001582F
		public unsafe static DynamicPropertyCollection global_dynamic_properties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_global_dynamic_properties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_global_dynamic_properties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x00127C24 File Offset: 0x00125E24
		// (set) Token: 0x06003EB6 RID: 16054 RVA: 0x00017641 File Offset: 0x00015841
		public unsafe DynamicPropertyCollection context_dynamic_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_dynamic_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_dynamic_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06003EB7 RID: 16055 RVA: 0x00127C54 File Offset: 0x00125E54
		// (set) Token: 0x06003EB8 RID: 16056 RVA: 0x00017660 File Offset: 0x00015860
		public unsafe ContextCallbackObject callback_object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_callback_object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallbackObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_callback_object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeFieldInfoPtr_domain_id;

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeFieldInfoPtr_context_id;

		// Token: 0x040033A4 RID: 13220
		private static readonly IntPtr NativeFieldInfoPtr_static_data;

		// Token: 0x040033A5 RID: 13221
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040033A6 RID: 13222
		private static readonly IntPtr NativeFieldInfoPtr_local_slots;

		// Token: 0x040033A7 RID: 13223
		private static readonly IntPtr NativeFieldInfoPtr_default_server_context_sink;

		// Token: 0x040033A8 RID: 13224
		private static readonly IntPtr NativeFieldInfoPtr_server_context_sink_chain;

		// Token: 0x040033A9 RID: 13225
		private static readonly IntPtr NativeFieldInfoPtr_client_context_sink_chain;

		// Token: 0x040033AA RID: 13226
		private static readonly IntPtr NativeFieldInfoPtr_context_properties;

		// Token: 0x040033AB RID: 13227
		private static readonly IntPtr NativeFieldInfoPtr_global_count;

		// Token: 0x040033AC RID: 13228
		private static readonly IntPtr NativeFieldInfoPtr__localDataStore;

		// Token: 0x040033AD RID: 13229
		private static readonly IntPtr NativeFieldInfoPtr__localDataStoreMgr;

		// Token: 0x040033AE RID: 13230
		private static readonly IntPtr NativeFieldInfoPtr_global_dynamic_properties;

		// Token: 0x040033AF RID: 13231
		private static readonly IntPtr NativeFieldInfoPtr_context_dynamic_properties;

		// Token: 0x040033B0 RID: 13232
		private static readonly IntPtr NativeFieldInfoPtr_callback_object;

		// Token: 0x040033B1 RID: 13233
		private static readonly IntPtr NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0;

		// Token: 0x040033B2 RID: 13234
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0;

		// Token: 0x040033B3 RID: 13235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0;

		// Token: 0x040033B6 RID: 13238
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0;

		// Token: 0x040033B7 RID: 13239
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0;

		// Token: 0x040033B8 RID: 13240
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0;

		// Token: 0x040033B9 RID: 13241
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0;

		// Token: 0x040033BA RID: 13242
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0;

		// Token: 0x040033BB RID: 13243
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0;

		// Token: 0x040033BC RID: 13244
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0;

		// Token: 0x040033BD RID: 13245
		private static readonly IntPtr NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x040033BE RID: 13246
		private static readonly IntPtr NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0;

		// Token: 0x040033BF RID: 13247
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x040033C0 RID: 13248
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0;

		// Token: 0x040033C1 RID: 13249
		private static readonly IntPtr NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0;

		// Token: 0x040033C2 RID: 13250
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0;

		// Token: 0x040033C3 RID: 13251
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0;

		// Token: 0x040033C4 RID: 13252
		private static readonly IntPtr NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0;

		// Token: 0x040033C5 RID: 13253
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040033C6 RID: 13254
		private static readonly IntPtr NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0;

		// Token: 0x040033C7 RID: 13255
		private static readonly IntPtr NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0;

		// Token: 0x040033C8 RID: 13256
		private static readonly IntPtr NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0;

		// Token: 0x040033C9 RID: 13257
		private static readonly IntPtr NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0;

		// Token: 0x040033CA RID: 13258
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0;

		// Token: 0x040033CB RID: 13259
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0;

		// Token: 0x040033CC RID: 13260
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0;

		// Token: 0x040033CD RID: 13261
		private static readonly IntPtr NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0;

		// Token: 0x040033CE RID: 13262
		private static readonly IntPtr NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0;

		// Token: 0x040033CF RID: 13263
		private static readonly IntPtr NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0;

		// Token: 0x040033D0 RID: 13264
		private static readonly IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0;

		// Token: 0x040033D1 RID: 13265
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0;

		// Token: 0x040033D2 RID: 13266
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0;

		// Token: 0x040033D3 RID: 13267
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0;
	}
}
