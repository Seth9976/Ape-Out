using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Claims;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x020002D1 RID: 721
	[Serializable]
	public class WindowsIdentity : ClaimsIdentity
	{
		// Token: 0x060030B1 RID: 12465 RVA: 0x000F5CCC File Offset: 0x000F3ECC
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsIdentity()
		{
			Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "WindowsIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr);
			WindowsIdentity.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_token");
			WindowsIdentity.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_type");
			WindowsIdentity.NativeFieldInfoPtr__account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_account");
			WindowsIdentity.NativeFieldInfoPtr__authenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_authenticated");
			WindowsIdentity.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_name");
			WindowsIdentity.NativeFieldInfoPtr__info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_info");
			WindowsIdentity.NativeFieldInfoPtr_invalidWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "invalidWindows");
			WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671032);
			WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671033);
			WindowsIdentity.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671034);
			WindowsIdentity.NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671035);
			WindowsIdentity.NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671036);
			WindowsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671037);
			WindowsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671038);
			WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671039);
			WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671040);
			WindowsIdentity.NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671041);
			WindowsIdentity.NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671042);
			WindowsIdentity.NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100671043);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000F5E78 File Offset: 0x000F4078
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208461, RefRangeEnd = 208464, XrefRangeStart = 208451, XrefRangeEnd = 208461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userToken;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acctType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAuthenticated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000F5EF0 File Offset: 0x000F40F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208464, XrefRangeEnd = 208465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x000F5F54 File Offset: 0x000F4154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208465, XrefRangeEnd = 208466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x000F5F88 File Offset: 0x000F4188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208466, XrefRangeEnd = 208472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WindowsIdentity GetCurrent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr3) : null;
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x000F5FBC File Offset: 0x000F41BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208472, XrefRangeEnd = 208477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WindowsImpersonationContext Impersonate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WindowsIdentity.NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsImpersonationContext>(intPtr3) : null;
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x000F6008 File Offset: 0x000F4208
		public unsafe override string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x000F6040 File Offset: 0x000F4240
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208477, XrefRangeEnd = 208480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WindowsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x000F6084 File Offset: 0x000F4284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208480, XrefRangeEnd = 208515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000F60C8 File Offset: 0x000F42C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208515, XrefRangeEnd = 208665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000F6124 File Offset: 0x000F4324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208665, XrefRangeEnd = 208674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToken(IntPtr token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x000F6164 File Offset: 0x000F4364
		[CallerCount(0)]
		public unsafe static IntPtr GetCurrentToken()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x000F6194 File Offset: 0x000F4394
		[CallerCount(0)]
		public unsafe static string GetTokenName(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		public WindowsIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x000F61CC File Offset: 0x000F43CC
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x00010ED1 File Offset: 0x0000F0D1
		public unsafe IntPtr _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x000F61F4 File Offset: 0x000F43F4
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x00010EEC File Offset: 0x0000F0EC
		public unsafe string _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000F621C File Offset: 0x000F441C
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x00010F0B File Offset: 0x0000F10B
		public unsafe WindowsAccountType _account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__account);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__account)) = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000F6244 File Offset: 0x000F4444
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x00010F26 File Offset: 0x0000F126
		public unsafe bool _authenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__authenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__authenticated)) = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000F626C File Offset: 0x000F446C
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x00010F41 File Offset: 0x0000F141
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x000F6294 File Offset: 0x000F4494
		// (set) Token: 0x060030CA RID: 12490 RVA: 0x00010F60 File Offset: 0x0000F160
		public unsafe SerializationInfo _info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x000F62C4 File Offset: 0x000F44C4
		// (set) Token: 0x060030CC RID: 12492 RVA: 0x00010F7F File Offset: 0x0000F17F
		public unsafe static IntPtr invalidWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WindowsIdentity.NativeFieldInfoPtr_invalidWindows, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowsIdentity.NativeFieldInfoPtr_invalidWindows, (void*)(&value));
			}
		}

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeFieldInfoPtr__account;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeFieldInfoPtr__authenticated;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeFieldInfoPtr__info;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeFieldInfoPtr_invalidWindows;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0;
	}
}
