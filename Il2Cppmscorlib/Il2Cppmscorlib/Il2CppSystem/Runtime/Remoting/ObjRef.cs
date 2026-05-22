using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000395 RID: 917
	[Serializable]
	public class ObjRef : Object
	{
		// Token: 0x06003C6E RID: 15470 RVA: 0x0011F1D4 File Offset: 0x0011D3D4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjRef()
		{
			Il2CppClassPointerStore<ObjRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ObjRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjRef>.NativeClassPtr);
			ObjRef.NativeFieldInfoPtr_channel_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "channel_info");
			ObjRef.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "uri");
			ObjRef.NativeFieldInfoPtr_typeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "typeInfo");
			ObjRef.NativeFieldInfoPtr_envoyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "envoyInfo");
			ObjRef.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "flags");
			ObjRef.NativeFieldInfoPtr__serverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "_serverType");
			ObjRef.NativeFieldInfoPtr_MarshalledObjectRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "MarshalledObjectRef");
			ObjRef.NativeFieldInfoPtr_WellKnowObjectRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "WellKnowObjectRef");
			ObjRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672283);
			ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672284);
			ObjRef.NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672285);
			ObjRef.NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672286);
			ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672287);
			ObjRef.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672288);
			ObjRef.NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672289);
			ObjRef.NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672290);
			ObjRef.NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672291);
			ObjRef.NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672292);
			ObjRef.NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672293);
			ObjRef.NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672294);
			ObjRef.NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672295);
			ObjRef.NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672296);
			ObjRef.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672297);
			ObjRef.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672298);
			ObjRef.NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672299);
			ObjRef.NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672300);
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x0011F40C File Offset: 0x0011D60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219137, XrefRangeEnd = 219138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x0011F448 File Offset: 0x0011D648
		[CallerCount(0)]
		public unsafe ObjRef(string uri, IChannelInfo cinfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cinfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x0011F4A8 File Offset: 0x0011D6A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219155, RefRangeEnd = 219156, XrefRangeStart = 219138, XrefRangeEnd = 219155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef DeserializeInTheCurrentDomain(int domainId, Il2CppStructArray<byte> tInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0011F508 File Offset: 0x0011D708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219156, XrefRangeEnd = 219164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> SerializeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x0011F548 File Offset: 0x0011D748
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219176, RefRangeEnd = 219180, XrefRangeStart = 219164, XrefRangeEnd = 219176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef(Type type, string url, Object remoteChannelData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x0011F5B8 File Offset: 0x0011D7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219180, XrefRangeEnd = 219245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x0011F61C File Offset: 0x0011D81C
		public unsafe bool IsReferenceToWellKnow
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219249, RefRangeEnd = 219250, XrefRangeStart = 219245, XrefRangeEnd = 219249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06003C76 RID: 15478 RVA: 0x0011F658 File Offset: 0x0011D858
		public unsafe virtual IChannelInfo ChannelInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IChannelInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x0011F6A4 File Offset: 0x0011D8A4
		// (set) Token: 0x06003C78 RID: 15480 RVA: 0x0011F6F0 File Offset: 0x0011D8F0
		public unsafe virtual IEnvoyInfo EnvoyInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnvoyInfo>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x0011F740 File Offset: 0x0011D940
		// (set) Token: 0x06003C7A RID: 15482 RVA: 0x0011F78C File Offset: 0x0011D98C
		public unsafe virtual IRemotingTypeInfo TypeInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRemotingTypeInfo>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x0011F7DC File Offset: 0x0011D9DC
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x0011F820 File Offset: 0x0011DA20
		public unsafe virtual string URI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x0011F870 File Offset: 0x0011DA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219250, XrefRangeEnd = 219348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x0011F8D4 File Offset: 0x0011DAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219348, XrefRangeEnd = 219353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x0011F934 File Offset: 0x0011DB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219360, RefRangeEnd = 219362, XrefRangeStart = 219353, XrefRangeEnd = 219360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChannelInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x0011F968 File Offset: 0x0011DB68
		public unsafe Type ServerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219362, XrefRangeEnd = 219374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x000168C7 File Offset: 0x00014AC7
		public ObjRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x0011F9A8 File Offset: 0x0011DBA8
		// (set) Token: 0x06003C83 RID: 15491 RVA: 0x000168D0 File Offset: 0x00014AD0
		public unsafe IChannelInfo channel_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_channel_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IChannelInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_channel_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06003C84 RID: 15492 RVA: 0x0011F9D8 File Offset: 0x0011DBD8
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x000168EF File Offset: 0x00014AEF
		public unsafe string uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x0011FA00 File Offset: 0x0011DC00
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x0001690E File Offset: 0x00014B0E
		public unsafe IRemotingTypeInfo typeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_typeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRemotingTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_typeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06003C88 RID: 15496 RVA: 0x0011FA30 File Offset: 0x0011DC30
		// (set) Token: 0x06003C89 RID: 15497 RVA: 0x0001692D File Offset: 0x00014B2D
		public unsafe IEnvoyInfo envoyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_envoyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnvoyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_envoyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06003C8A RID: 15498 RVA: 0x0011FA60 File Offset: 0x0011DC60
		// (set) Token: 0x06003C8B RID: 15499 RVA: 0x0001694C File Offset: 0x00014B4C
		public unsafe int flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06003C8C RID: 15500 RVA: 0x0011FA88 File Offset: 0x0011DC88
		// (set) Token: 0x06003C8D RID: 15501 RVA: 0x00016967 File Offset: 0x00014B67
		public unsafe Type _serverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr__serverType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr__serverType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06003C8E RID: 15502 RVA: 0x0011FAB8 File Offset: 0x0011DCB8
		// (set) Token: 0x06003C8F RID: 15503 RVA: 0x00016986 File Offset: 0x00014B86
		public unsafe static int MarshalledObjectRef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjRef.NativeFieldInfoPtr_MarshalledObjectRef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjRef.NativeFieldInfoPtr_MarshalledObjectRef, (void*)(&value));
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06003C90 RID: 15504 RVA: 0x0011FAD4 File Offset: 0x0011DCD4
		// (set) Token: 0x06003C91 RID: 15505 RVA: 0x00016994 File Offset: 0x00014B94
		public unsafe static int WellKnowObjectRef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjRef.NativeFieldInfoPtr_WellKnowObjectRef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjRef.NativeFieldInfoPtr_WellKnowObjectRef, (void*)(&value));
			}
		}

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeFieldInfoPtr_channel_info;

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeFieldInfoPtr_typeInfo;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeFieldInfoPtr_envoyInfo;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeFieldInfoPtr__serverType;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeFieldInfoPtr_MarshalledObjectRef;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeFieldInfoPtr_WellKnowObjectRef;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0;

		// Token: 0x04003242 RID: 12866
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003243 RID: 12867
		private static readonly IntPtr NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003244 RID: 12868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0;

		// Token: 0x04003245 RID: 12869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003246 RID: 12870
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0;

		// Token: 0x04003247 RID: 12871
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0;

		// Token: 0x04003248 RID: 12872
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0;

		// Token: 0x04003249 RID: 12873
		private static readonly IntPtr NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0;

		// Token: 0x0400324A RID: 12874
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0;

		// Token: 0x0400324B RID: 12875
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0;

		// Token: 0x0400324C RID: 12876
		private static readonly IntPtr NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0;

		// Token: 0x0400324D RID: 12877
		private static readonly IntPtr NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400324E RID: 12878
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0;
	}
}
