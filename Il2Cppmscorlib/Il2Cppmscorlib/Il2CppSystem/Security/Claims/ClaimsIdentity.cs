using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Security.Claims
{
	// Token: 0x020002D4 RID: 724
	[Serializable]
	public class ClaimsIdentity : Object
	{
		// Token: 0x060030F8 RID: 12536 RVA: 0x000F6C94 File Offset: 0x000F4E94
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimsIdentity()
		{
			Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Claims", "ClaimsIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr);
			ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_userSerializationData");
			ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_instanceClaims");
			ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_externalClaims");
			ClaimsIdentity.NativeFieldInfoPtr_m_nameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_nameType");
			ClaimsIdentity.NativeFieldInfoPtr_m_roleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_roleType");
			ClaimsIdentity.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_version");
			ClaimsIdentity.NativeFieldInfoPtr_m_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_actor");
			ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_authenticationType");
			ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_bootstrapContext");
			ClaimsIdentity.NativeFieldInfoPtr_m_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_label");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedNameType");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedRoleType");
			ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "m_serializedClaims");
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671063);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671064);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671065);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671066);
			ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671067);
			ClaimsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671068);
			ClaimsIdentity.NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671069);
			ClaimsIdentity.NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671070);
			ClaimsIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671071);
			ClaimsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671072);
			ClaimsIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671073);
			ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671074);
			ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671075);
			ClaimsIdentity.NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671076);
			ClaimsIdentity.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671077);
			ClaimsIdentity.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671078);
			ClaimsIdentity.NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671079);
			ClaimsIdentity.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671080);
			ClaimsIdentity.NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671081);
			ClaimsIdentity.NativeMethodInfoPtr_SerializeClaims_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671082);
			ClaimsIdentity.NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671083);
			ClaimsIdentity.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, 100671084);
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x000F6F80 File Offset: 0x000F5180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208817, XrefRangeEnd = 208818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000F6FBC File Offset: 0x000F51BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208818, XrefRangeEnd = 208819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IEnumerable<Claim> claims)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000F7008 File Offset: 0x000F5208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208819, XrefRangeEnd = 208820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(claims);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authenticationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(roleType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000F70A0 File Offset: 0x000F52A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 208883, RefRangeEnd = 208889, XrefRangeStart = 208820, XrefRangeEnd = 208883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(claims);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authenticationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(roleType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAuthType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000F7144 File Offset: 0x000F5344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208889, XrefRangeEnd = 208907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x000F71A8 File Offset: 0x000F53A8
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x000F71EC File Offset: 0x000F53EC
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x000F722C File Offset: 0x000F542C
		public unsafe ClaimsIdentity Actor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208908, RefRangeEnd = 208909, XrefRangeStart = 208907, XrefRangeEnd = 208908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x000F7270 File Offset: 0x000F5470
		public unsafe virtual IEnumerable<Claim> Claims
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208909, XrefRangeEnd = 208914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Claim>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x000F72BC File Offset: 0x000F54BC
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000F7300 File Offset: 0x000F5500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208914, XrefRangeEnd = 208922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ClaimsIdentity Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x000F734C File Offset: 0x000F554C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208943, RefRangeEnd = 208945, XrefRangeStart = 208922, XrefRangeEnd = 208943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeAddClaims(IEnumerable<Claim> claims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x000F7390 File Offset: 0x000F5590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208945, XrefRangeEnd = 208951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SafeAddClaim(Claim claim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x000F73D4 File Offset: 0x000F55D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208951, XrefRangeEnd = 208968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Claim FindFirst(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
			}
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x000F7430 File Offset: 0x000F5630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208968, XrefRangeEnd = 208972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializingMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x000F7478 File Offset: 0x000F5678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208972, XrefRangeEnd = 208981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializedMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x000F74C0 File Offset: 0x000F56C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208981, XrefRangeEnd = 208995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializingMethod(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x000F7508 File Offset: 0x000F5708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208995, XrefRangeEnd = 209079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClaimsIdentity.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x000F756C File Offset: 0x000F576C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209112, RefRangeEnd = 209113, XrefRangeStart = 209079, XrefRangeEnd = 209112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeClaims(string serializedClaims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serializedClaims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000F75B0 File Offset: 0x000F57B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209130, RefRangeEnd = 209132, XrefRangeStart = 209113, XrefRangeEnd = 209130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SerializeClaims()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_SerializeClaims_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x000F75E8 File Offset: 0x000F57E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209132, XrefRangeEnd = 209133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCircular(ClaimsIdentity subject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x000F7638 File Offset: 0x000F5838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209152, RefRangeEnd = 209153, XrefRangeStart = 209133, XrefRangeEnd = 209152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity.NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x000110EC File Offset: 0x0000F2EC
		public ClaimsIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x000F76A0 File Offset: 0x000F58A0
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x000110F5 File Offset: 0x0000F2F5
		public unsafe Il2CppStructArray<byte> m_userSerializationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_userSerializationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x000F76D0 File Offset: 0x000F58D0
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x00011114 File Offset: 0x0000F314
		public unsafe List<Claim> m_instanceClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Claim>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_instanceClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x000F7700 File Offset: 0x000F5900
		// (set) Token: 0x06003115 RID: 12565 RVA: 0x00011133 File Offset: 0x0000F333
		public unsafe Collection<IEnumerable<Claim>> m_externalClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collection<IEnumerable<Claim>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_externalClaims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x000F7730 File Offset: 0x000F5930
		// (set) Token: 0x06003117 RID: 12567 RVA: 0x00011152 File Offset: 0x0000F352
		public unsafe string m_nameType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_nameType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_nameType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x000F7758 File Offset: 0x000F5958
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x00011171 File Offset: 0x0000F371
		public unsafe string m_roleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_roleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_roleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x000F7780 File Offset: 0x000F5980
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x00011190 File Offset: 0x0000F390
		public unsafe string m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x000F77A8 File Offset: 0x000F59A8
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x000111AF File Offset: 0x0000F3AF
		public unsafe ClaimsIdentity m_actor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_actor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_actor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x000F77D8 File Offset: 0x000F59D8
		// (set) Token: 0x0600311F RID: 12575 RVA: 0x000111CE File Offset: 0x0000F3CE
		public unsafe string m_authenticationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_authenticationType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x000F7800 File Offset: 0x000F5A00
		// (set) Token: 0x06003121 RID: 12577 RVA: 0x000111ED File Offset: 0x0000F3ED
		public unsafe Object m_bootstrapContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_bootstrapContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x000F7830 File Offset: 0x000F5A30
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x0001120C File Offset: 0x0000F40C
		public unsafe string m_label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x000F7858 File Offset: 0x000F5A58
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x0001122B File Offset: 0x0000F42B
		public unsafe string m_serializedNameType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedNameType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x000F7880 File Offset: 0x000F5A80
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x0001124A File Offset: 0x0000F44A
		public unsafe string m_serializedRoleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedRoleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x000F78A8 File Offset: 0x000F5AA8
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x00011269 File Offset: 0x0000F469
		public unsafe string m_serializedClaims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity.NativeFieldInfoPtr_m_serializedClaims), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeFieldInfoPtr_m_userSerializationData;

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeFieldInfoPtr_m_instanceClaims;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeFieldInfoPtr_m_externalClaims;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeFieldInfoPtr_m_nameType;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeFieldInfoPtr_m_roleType;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeFieldInfoPtr_m_actor;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeFieldInfoPtr_m_authenticationType;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeFieldInfoPtr_m_bootstrapContext;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeFieldInfoPtr_m_label;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedNameType;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedRoleType;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedClaims;

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Claim_0;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IIdentity_IEnumerable_1_Claim_String_String_String_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IIdentity_IEnumerable_1_Claim_String_String_String_Boolean_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_New_get_String_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr_get_Actor_Public_get_ClaimsIdentity_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeMethodInfoPtr_set_Actor_Public_set_Void_ClaimsIdentity_0;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeMethodInfoPtr_get_Claims_Public_Virtual_New_get_IEnumerable_1_Claim_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_ClaimsIdentity_0;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeMethodInfoPtr_SafeAddClaims_Private_Void_IEnumerable_1_Claim_0;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeMethodInfoPtr_SafeAddClaim_Private_Void_Claim_0;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeMethodInfoPtr_FindFirst_Public_Virtual_New_Claim_String_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializingMethod_Private_Void_StreamingContext_0;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializedMethod_Private_Void_StreamingContext_0;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializingMethod_Private_Void_StreamingContext_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeClaims_Private_Void_String_0;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeMethodInfoPtr_SerializeClaims_Private_String_0;

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeMethodInfoPtr_IsCircular_Private_Boolean_ClaimsIdentity_0;

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Private_Void_SerializationInfo_StreamingContext_Boolean_0;

		// Token: 0x02000626 RID: 1574
		[ObfuscatedName("System.Security.Claims.ClaimsIdentity+<get_Claims>d__51")]
		public sealed class _get_Claims_d__51 : Object
		{
			// Token: 0x06005576 RID: 21878 RVA: 0x0017ECC0 File Offset: 0x0017CEC0
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Claims_d__51()
			{
				Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClaimsIdentity>.NativeClassPtr, "<get_Claims>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr);
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>1__state");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>2__current");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>l__initialThreadId");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>4__this");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<i>5__1");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__j_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<j>5__2");
				ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, "<>7__wrap1");
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671085);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671086);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671087);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671088);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671089);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671090);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671091);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671092);
				ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr, 100671093);
			}

			// Token: 0x06005577 RID: 21879 RVA: 0x0017EE2C File Offset: 0x0017D02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Claims_d__51(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimsIdentity._get_Claims_d__51>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005578 RID: 21880 RVA: 0x0017EE74 File Offset: 0x0017D074
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208774, RefRangeEnd = 208775, XrefRangeStart = 208771, XrefRangeEnd = 208774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005579 RID: 21881 RVA: 0x0017EEA8 File Offset: 0x0017D0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208775, XrefRangeEnd = 208806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600557A RID: 21882 RVA: 0x0017EEE4 File Offset: 0x0017D0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208806, XrefRangeEnd = 208809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015F7 RID: 5623
			// (get) Token: 0x0600557B RID: 21883 RVA: 0x0017EF18 File Offset: 0x0017D118
			public unsafe Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr3) : null;
				}
			}

			// Token: 0x0600557C RID: 21884 RVA: 0x0017EF58 File Offset: 0x0017D158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208809, XrefRangeEnd = 208814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015F8 RID: 5624
			// (get) Token: 0x0600557D RID: 21885 RVA: 0x0017EF8C File Offset: 0x0017D18C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600557E RID: 21886 RVA: 0x0017EFCC File Offset: 0x0017D1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208814, XrefRangeEnd = 208817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Claim> System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Claim>>(intPtr3) : null;
			}

			// Token: 0x0600557F RID: 21887 RVA: 0x0017F00C File Offset: 0x0017D20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimsIdentity._get_Claims_d__51.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005580 RID: 21888 RVA: 0x0002061F File Offset: 0x0001E81F
			public _get_Claims_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015F0 RID: 5616
			// (get) Token: 0x06005581 RID: 21889 RVA: 0x0017F04C File Offset: 0x0017D24C
			// (set) Token: 0x06005582 RID: 21890 RVA: 0x00020628 File Offset: 0x0001E828
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170015F1 RID: 5617
			// (get) Token: 0x06005583 RID: 21891 RVA: 0x0017F074 File Offset: 0x0017D274
			// (set) Token: 0x06005584 RID: 21892 RVA: 0x00020643 File Offset: 0x0001E843
			public unsafe Claim __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Claim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F2 RID: 5618
			// (get) Token: 0x06005585 RID: 21893 RVA: 0x0017F0A4 File Offset: 0x0017D2A4
			// (set) Token: 0x06005586 RID: 21894 RVA: 0x00020662 File Offset: 0x0001E862
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170015F3 RID: 5619
			// (get) Token: 0x06005587 RID: 21895 RVA: 0x0017F0CC File Offset: 0x0017D2CC
			// (set) Token: 0x06005588 RID: 21896 RVA: 0x0002067D File Offset: 0x0001E87D
			public unsafe ClaimsIdentity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015F4 RID: 5620
			// (get) Token: 0x06005589 RID: 21897 RVA: 0x0017F0FC File Offset: 0x0017D2FC
			// (set) Token: 0x0600558A RID: 21898 RVA: 0x0002069C File Offset: 0x0001E89C
			public unsafe int _i_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__i_5__1)) = value;
				}
			}

			// Token: 0x170015F5 RID: 5621
			// (get) Token: 0x0600558B RID: 21899 RVA: 0x0017F124 File Offset: 0x0017D324
			// (set) Token: 0x0600558C RID: 21900 RVA: 0x000206B7 File Offset: 0x0001E8B7
			public unsafe int _j_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__j_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr__j_5__2)) = value;
				}
			}

			// Token: 0x170015F6 RID: 5622
			// (get) Token: 0x0600558D RID: 21901 RVA: 0x0017F14C File Offset: 0x0017D34C
			// (set) Token: 0x0600558E RID: 21902 RVA: 0x000206D2 File Offset: 0x0001E8D2
			public unsafe IEnumerator<Claim> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Claim>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClaimsIdentity._get_Claims_d__51.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004501 RID: 17665
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004502 RID: 17666
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004503 RID: 17667
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004504 RID: 17668
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004505 RID: 17669
			private static readonly IntPtr NativeFieldInfoPtr__i_5__1;

			// Token: 0x04004506 RID: 17670
			private static readonly IntPtr NativeFieldInfoPtr__j_5__2;

			// Token: 0x04004507 RID: 17671
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04004508 RID: 17672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004509 RID: 17673
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400450A RID: 17674
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400450B RID: 17675
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400450C RID: 17676
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Security_Claims_Claim__get_Current_Private_Virtual_Final_New_get_Claim_0;

			// Token: 0x0400450D RID: 17677
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400450E RID: 17678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400450F RID: 17679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Security_Claims_Claim__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Claim_0;

			// Token: 0x04004510 RID: 17680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
