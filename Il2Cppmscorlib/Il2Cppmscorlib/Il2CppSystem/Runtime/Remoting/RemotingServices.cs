using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Remoting.Proxies;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039C RID: 924
	public static class RemotingServices : Object
	{
		// Token: 0x06003D16 RID: 15638 RVA: 0x0012160C File Offset: 0x0011F80C
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingServices()
		{
			Il2CppClassPointerStore<RemotingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingServices");
			RemotingServices.NativeFieldInfoPtr_uri_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "uri_hash");
			RemotingServices.NativeFieldInfoPtr__serializationFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "_serializationFormatter");
			RemotingServices.NativeFieldInfoPtr__deserializationFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "_deserializationFormatter");
			RemotingServices.NativeFieldInfoPtr_app_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "app_id");
			RemotingServices.NativeFieldInfoPtr_app_id_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "app_id_lock");
			RemotingServices.NativeFieldInfoPtr_next_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "next_id");
			RemotingServices.NativeFieldInfoPtr_FieldSetterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "FieldSetterMethod");
			RemotingServices.NativeFieldInfoPtr_FieldGetterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "FieldGetterMethod");
			RemotingServices.NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672357);
			RemotingServices.NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672358);
			RemotingServices.NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672359);
			RemotingServices.NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672360);
			RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672361);
			RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672362);
			RemotingServices.NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672363);
			RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672364);
			RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672365);
			RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672366);
			RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672367);
			RemotingServices.NativeMethodInfoPtr_NewUri_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672368);
			RemotingServices.NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672369);
			RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672370);
			RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672371);
			RemotingServices.NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672372);
			RemotingServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672373);
			RemotingServices.NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672374);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672375);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672376);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672377);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672378);
			RemotingServices.NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672379);
			RemotingServices.NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672380);
			RemotingServices.NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672381);
			RemotingServices.NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672382);
			RemotingServices.NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672383);
			RemotingServices.NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672384);
			RemotingServices.NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672385);
			RemotingServices.NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672386);
			RemotingServices.NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672387);
			RemotingServices.NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672388);
			RemotingServices.NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672389);
			RemotingServices.NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672390);
			RemotingServices.NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672391);
			RemotingServices.NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672392);
			RemotingServices.NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672393);
			RemotingServices.NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672394);
			RemotingServices.NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672395);
			RemotingServices.NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672396);
			RemotingServices.NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672397);
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x00121A08 File Offset: 0x0011FC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220338, XrefRangeEnd = 220339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InternalExecute(MethodBase method, Object obj, Il2CppReferenceArray<Object> parameters, out Il2CppReferenceArray<Object> out_args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			out_args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x00121A94 File Offset: 0x0011FC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220339, XrefRangeEnd = 220340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetVirtualMethod(Type type, MethodBase method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x00121AEC File Offset: 0x0011FCEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220345, RefRangeEnd = 220351, XrefRangeStart = 220340, XrefRangeEnd = 220345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTransparentProxy(Object proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x00121B30 File Offset: 0x0011FD30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220376, RefRangeEnd = 220378, XrefRangeStart = 220351, XrefRangeEnd = 220376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMethodReturnMessage>(intPtr3) : null;
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x00121B88 File Offset: 0x0011FD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220378, XrefRangeEnd = 220386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Connect(Type classToProxy, string url)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x00121BE0 File Offset: 0x0011FDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220386, XrefRangeEnd = 220394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Connect(Type classToProxy, string url, Object data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x00121C48 File Offset: 0x0011FE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220394, XrefRangeEnd = 220400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetServerTypeForUri(string URI)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(URI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x00121C8C File Offset: 0x0011FE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220404, RefRangeEnd = 220405, XrefRangeStart = 220400, XrefRangeEnd = 220404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unmarshal(ObjRef objectRef)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectRef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x00121CD0 File Offset: 0x0011FED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220457, RefRangeEnd = 220458, XrefRangeStart = 220405, XrefRangeEnd = 220457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRefine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00121D24 File Offset: 0x0011FF24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220462, RefRangeEnd = 220463, XrefRangeStart = 220458, XrefRangeEnd = 220462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjRef Marshal(MarshalByRefObject Obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x00121D68 File Offset: 0x0011FF68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220472, RefRangeEnd = 220474, XrefRangeStart = 220463, XrefRangeEnd = 220472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ObjURI);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(RequestedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x00121DD0 File Offset: 0x0011FFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220474, XrefRangeEnd = 220533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NewUri()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_NewUri_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x00121DFC File Offset: 0x0011FFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220538, RefRangeEnd = 220539, XrefRangeStart = 220533, XrefRangeEnd = 220538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RealProxy GetRealProxy(Object proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x00121E40 File Offset: 0x00120040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220574, RefRangeEnd = 220576, XrefRangeStart = 220539, XrefRangeEnd = 220574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00121E84 File Offset: 0x00120084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220585, RefRangeEnd = 220587, XrefRangeStart = 220576, XrefRangeEnd = 220585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodBaseFromName(Type type, string methodName, Il2CppReferenceArray<Type> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x00121EEC File Offset: 0x001200EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220587, XrefRangeEnd = 220592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase FindInterfaceMethod(Type type, string methodName, Il2CppReferenceArray<Type> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x00121F54 File Offset: 0x00120154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220605, RefRangeEnd = 220606, XrefRangeStart = 220592, XrefRangeEnd = 220605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00121FB4 File Offset: 0x001201B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220606, XrefRangeEnd = 220613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOneWay(MethodBase method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x00121FF8 File Offset: 0x001201F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220613, XrefRangeEnd = 220625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(ActivatedClientTypeEntry entry, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x00122050 File Offset: 0x00120250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220644, RefRangeEnd = 220645, XrefRangeStart = 220625, XrefRangeEnd = 220644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(Type objectType, string url, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x001220B8 File Offset: 0x001202B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220645, XrefRangeEnd = 220657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x001220FC File Offset: 0x001202FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220657, XrefRangeEnd = 220668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxyForContextBound(Type type, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00122154 File Offset: 0x00120354
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220702, RefRangeEnd = 220708, XrefRangeStart = 220668, XrefRangeEnd = 220702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Identity GetIdentityForUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00122198 File Offset: 0x00120398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220708, XrefRangeEnd = 220720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAppNameFromUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x001221D4 File Offset: 0x001203D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220770, RefRangeEnd = 220772, XrefRangeStart = 220720, XrefRangeEnd = 220770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out Object clientProxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			clientProxy = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ClientIdentity>(intPtr5) : null;
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00122250 File Offset: 0x00120450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220772, XrefRangeEnd = 220777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink GetClientChannelSinkChain(string url, Object channelData, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x001222C4 File Offset: 0x001204C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220777, XrefRangeEnd = 220789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientActivatedIdentity>(intPtr3) : null;
			}
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00122308 File Offset: 0x00120508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220789, XrefRangeEnd = 220801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(realObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientActivatedIdentity>(intPtr3) : null;
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00122370 File Offset: 0x00120570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220818, RefRangeEnd = 220819, XrefRangeStart = 220801, XrefRangeEnd = 220818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr3) : null;
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x001223D4 File Offset: 0x001205D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220832, RefRangeEnd = 220833, XrefRangeStart = 220819, XrefRangeEnd = 220832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterServerIdentity(ServerIdentity identity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0012240C File Offset: 0x0012060C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220839, RefRangeEnd = 220841, XrefRangeStart = 220833, XrefRangeEnd = 220839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objref);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00122464 File Offset: 0x00120664
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220845, RefRangeEnd = 220850, XrefRangeStart = 220841, XrefRangeEnd = 220845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetRemoteObject(ObjRef objRef, Type proxyType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x001224BC File Offset: 0x001206BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220850, XrefRangeEnd = 220869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> SerializeCallData(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x00122500 File Offset: 0x00120700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220869, XrefRangeEnd = 220901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeCallData(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x00122544 File Offset: 0x00120744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220901, XrefRangeEnd = 220910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> SerializeExceptionData(Exception ex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00122588 File Offset: 0x00120788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220910, XrefRangeEnd = 220914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInternalChannels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x001225B0 File Offset: 0x001207B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220931, RefRangeEnd = 220934, XrefRangeStart = 220914, XrefRangeEnd = 220931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeIdentity(Identity ident)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ident);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x001225E8 File Offset: 0x001207E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 220959, RefRangeEnd = 220970, XrefRangeStart = 220934, XrefRangeEnd = 220959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Identity GetMessageTargetIdentity(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x0012262C File Offset: 0x0012082C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220978, RefRangeEnd = 220981, XrefRangeStart = 220970, XrefRangeEnd = 220978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMessageTargetIdentity(IMessage msg, Identity ident)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ident);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00122674 File Offset: 0x00120874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220988, RefRangeEnd = 220989, XrefRangeStart = 220981, XrefRangeEnd = 220988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateOutArgObject(ParameterInfo pi, Object local, Object remote)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(local);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remote);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x001226DC File Offset: 0x001208DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220992, RefRangeEnd = 220996, XrefRangeStart = 220989, XrefRangeEnd = 220992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNormalizedUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00016D6A File Offset: 0x00014F6A
		public RemotingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x00122718 File Offset: 0x00120918
		// (set) Token: 0x06003D42 RID: 15682 RVA: 0x00016D73 File Offset: 0x00014F73
		public unsafe static Hashtable uri_hash
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_uri_hash, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_uri_hash, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00122740 File Offset: 0x00120940
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x00016D85 File Offset: 0x00014F85
		public unsafe static BinaryFormatter _serializationFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr__serializationFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr__serializationFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x00122768 File Offset: 0x00120968
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x00016D97 File Offset: 0x00014F97
		public unsafe static BinaryFormatter _deserializationFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr__deserializationFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr__deserializationFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x00122790 File Offset: 0x00120990
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x00016DA9 File Offset: 0x00014FA9
		public unsafe static string app_id
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_app_id, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_app_id, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x001227B0 File Offset: 0x001209B0
		// (set) Token: 0x06003D4A RID: 15690 RVA: 0x00016DBB File Offset: 0x00014FBB
		public unsafe static Object app_id_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_app_id_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_app_id_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x001227D8 File Offset: 0x001209D8
		// (set) Token: 0x06003D4C RID: 15692 RVA: 0x00016DCD File Offset: 0x00014FCD
		public unsafe static int next_id
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_next_id, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_next_id, (void*)(&value));
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x001227F4 File Offset: 0x001209F4
		// (set) Token: 0x06003D4E RID: 15694 RVA: 0x00016DDB File Offset: 0x00014FDB
		public unsafe static MethodInfo FieldSetterMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_FieldSetterMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_FieldSetterMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x0012281C File Offset: 0x00120A1C
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x00016DED File Offset: 0x00014FED
		public unsafe static MethodInfo FieldGetterMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_FieldGetterMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_FieldGetterMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeFieldInfoPtr_uri_hash;

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeFieldInfoPtr__serializationFormatter;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeFieldInfoPtr__deserializationFormatter;

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeFieldInfoPtr_app_id;

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeFieldInfoPtr_app_id_lock;

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeFieldInfoPtr_next_id;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeFieldInfoPtr_FieldSetterMethod;

		// Token: 0x040032AF RID: 12975
		private static readonly IntPtr NativeFieldInfoPtr_FieldGetterMethod;

		// Token: 0x040032B0 RID: 12976
		private static readonly IntPtr NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040032B1 RID: 12977
		private static readonly IntPtr NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0;

		// Token: 0x040032B2 RID: 12978
		private static readonly IntPtr NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0;

		// Token: 0x040032B3 RID: 12979
		private static readonly IntPtr NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0;

		// Token: 0x040032B4 RID: 12980
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0;

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0;

		// Token: 0x040032B6 RID: 12982
		private static readonly IntPtr NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0;

		// Token: 0x040032B7 RID: 12983
		private static readonly IntPtr NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0;

		// Token: 0x040032B8 RID: 12984
		private static readonly IntPtr NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0;

		// Token: 0x040032B9 RID: 12985
		private static readonly IntPtr NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0;

		// Token: 0x040032BA RID: 12986
		private static readonly IntPtr NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0;

		// Token: 0x040032BB RID: 12987
		private static readonly IntPtr NativeMethodInfoPtr_NewUri_Private_Static_String_0;

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0;

		// Token: 0x040032C2 RID: 12994
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040032C3 RID: 12995
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040032C4 RID: 12996
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0;

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0;

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0;

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0;

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0;

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0;

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0;

		// Token: 0x0200062D RID: 1581
		[Serializable]
		public class CACD : Object
		{
			// Token: 0x060055EB RID: 21995 RVA: 0x0017FED4 File Offset: 0x0017E0D4
			// Note: this type is marked as 'beforefieldinit'.
			static CACD()
			{
				Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "CACD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr);
				RemotingServices.CACD.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, "d");
				RemotingServices.CACD.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, "c");
				RemotingServices.CACD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, 100672398);
			}

			// Token: 0x060055EC RID: 21996 RVA: 0x0017FF3C File Offset: 0x0017E13C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CACD()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.CACD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055ED RID: 21997 RVA: 0x00020B73 File Offset: 0x0001ED73
			public CACD(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161A RID: 5658
			// (get) Token: 0x060055EE RID: 21998 RVA: 0x0017FF78 File Offset: 0x0017E178
			// (set) Token: 0x060055EF RID: 21999 RVA: 0x00020B7C File Offset: 0x0001ED7C
			public unsafe Object d
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_d);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700161B RID: 5659
			// (get) Token: 0x060055F0 RID: 22000 RVA: 0x0017FFA8 File Offset: 0x0017E1A8
			// (set) Token: 0x060055F1 RID: 22001 RVA: 0x00020B9B File Offset: 0x0001ED9B
			public unsafe Object c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_c);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400453E RID: 17726
			private static readonly IntPtr NativeFieldInfoPtr_d;

			// Token: 0x0400453F RID: 17727
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x04004540 RID: 17728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
