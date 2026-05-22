using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003AC RID: 940
	public class RealProxy : Object
	{
		// Token: 0x06003DF1 RID: 15857 RVA: 0x00124EF8 File Offset: 0x001230F8
		// Note: this type is marked as 'beforefieldinit'.
		static RealProxy()
		{
			Il2CppClassPointerStore<RealProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "RealProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealProxy>.NativeClassPtr);
			RealProxy.NativeFieldInfoPtr_class_to_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "class_to_proxy");
			RealProxy.NativeFieldInfoPtr__targetContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetContext");
			RealProxy.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_server");
			RealProxy.NativeFieldInfoPtr__targetDomainId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetDomainId");
			RealProxy.NativeFieldInfoPtr__targetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetUri");
			RealProxy.NativeFieldInfoPtr__objectIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_objectIdentity");
			RealProxy.NativeFieldInfoPtr__objTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_objTP");
			RealProxy.NativeFieldInfoPtr__stubData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_stubData");
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672478);
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672479);
			RealProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672480);
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672481);
			RealProxy.NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672482);
			RealProxy.NativeMethodInfoPtr_GetProxiedType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672483);
			RealProxy.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672484);
			RealProxy.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672485);
			RealProxy.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672486);
			RealProxy.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672487);
			RealProxy.NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672488);
			RealProxy.NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672489);
			RealProxy.NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672490);
			RealProxy.NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672491);
			RealProxy.NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672492);
			RealProxy.NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672493);
			RealProxy.NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672494);
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x0012511C File Offset: 0x0012331C
		[CallerCount(0)]
		public unsafe RealProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00125158 File Offset: 0x00123358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221594, XrefRangeEnd = 221596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x001251A4 File Offset: 0x001233A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221596, XrefRangeEnd = 221598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy, ClientIdentity identity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00125204 File Offset: 0x00123404
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 221600, RefRangeEnd = 221605, XrefRangeStart = 221598, XrefRangeEnd = 221600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy, IntPtr stub, Object stubData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stub;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stubData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00125270 File Offset: 0x00123470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221605, XrefRangeEnd = 221606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type InternalGetProxyType(Object transparentProxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transparentProxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x001252B4 File Offset: 0x001234B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 221609, RefRangeEnd = 221613, XrefRangeStart = 221606, XrefRangeEnd = 221609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetProxiedType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_GetProxiedType_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x001252F4 File Offset: 0x001234F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221613, XrefRangeEnd = 221618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x00125358 File Offset: 0x00123558
		// (set) Token: 0x06003DFA RID: 15866 RVA: 0x00125398 File Offset: 0x00123598
		public unsafe Identity ObjectIdentity
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x001253DC File Offset: 0x001235DC
		[CallerCount(0)]
		public unsafe virtual IMessage Invoke(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00125438 File Offset: 0x00123638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221794, RefRangeEnd = 221796, XrefRangeStart = 221618, XrefRangeEnd = 221794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Il2CppReferenceArray<Object> out_args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			exc = ((intPtr5 == 0) ? null : new Exception(intPtr5));
			IntPtr intPtr6 = intPtr2;
			out_args = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<Object>(intPtr7) : null;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x001254D4 File Offset: 0x001236D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221796, XrefRangeEnd = 221797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object InternalGetTransparentProxy(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x00125530 File Offset: 0x00123730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221797, XrefRangeEnd = 221808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetTransparentProxy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0012557C File Offset: 0x0012377C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachServer(MarshalByRefObject s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x001255C0 File Offset: 0x001237C0
		[CallerCount(0)]
		public unsafe void SetTargetDomain(int domainId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00125600 File Offset: 0x00123800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221808, XrefRangeEnd = 221815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetAppDomainTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x00125640 File Offset: 0x00123840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221829, RefRangeEnd = 221830, XrefRangeStart = 221815, XrefRangeEnd = 221829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mrm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x00017187 File Offset: 0x00015387
		public RealProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x00125698 File Offset: 0x00123898
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x00017190 File Offset: 0x00015390
		public unsafe Type class_to_proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr_class_to_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr_class_to_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x001256C8 File Offset: 0x001238C8
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x000171AF File Offset: 0x000153AF
		public unsafe Context _targetContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x001256F8 File Offset: 0x001238F8
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x000171CE File Offset: 0x000153CE
		public unsafe MarshalByRefObject _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x00125728 File Offset: 0x00123928
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x000171ED File Offset: 0x000153ED
		public unsafe int _targetDomainId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetDomainId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetDomainId)) = value;
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x00125750 File Offset: 0x00123950
		// (set) Token: 0x06003E0D RID: 15885 RVA: 0x00017208 File Offset: 0x00015408
		public unsafe string _targetUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06003E0E RID: 15886 RVA: 0x00125778 File Offset: 0x00123978
		// (set) Token: 0x06003E0F RID: 15887 RVA: 0x00017227 File Offset: 0x00015427
		public unsafe Identity _objectIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objectIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objectIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x001257A8 File Offset: 0x001239A8
		// (set) Token: 0x06003E11 RID: 15889 RVA: 0x00017246 File Offset: 0x00015446
		public unsafe Object _objTP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objTP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objTP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x001257D8 File Offset: 0x001239D8
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x00017265 File Offset: 0x00015465
		public unsafe Object _stubData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__stubData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__stubData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003344 RID: 13124
		private static readonly IntPtr NativeFieldInfoPtr_class_to_proxy;

		// Token: 0x04003345 RID: 13125
		private static readonly IntPtr NativeFieldInfoPtr__targetContext;

		// Token: 0x04003346 RID: 13126
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04003347 RID: 13127
		private static readonly IntPtr NativeFieldInfoPtr__targetDomainId;

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeFieldInfoPtr__targetUri;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeFieldInfoPtr__objectIdentity;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeFieldInfoPtr__objTP;

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeFieldInfoPtr__stubData;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_0;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiedType_Public_Type_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0;

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0;

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0;
	}
}
