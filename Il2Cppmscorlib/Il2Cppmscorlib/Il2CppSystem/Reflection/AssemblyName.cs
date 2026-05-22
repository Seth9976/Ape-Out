using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Configuration.Assemblies;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C3 RID: 451
	[Serializable]
	public sealed class AssemblyName : Object
	{
		// Token: 0x06001D0D RID: 7437 RVA: 0x000A74FC File Offset: 0x000A56FC
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyName()
		{
			Il2CppClassPointerStore<AssemblyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr);
			AssemblyName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "name");
			AssemblyName.NativeFieldInfoPtr_codebase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "codebase");
			AssemblyName.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "major");
			AssemblyName.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "minor");
			AssemblyName.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "build");
			AssemblyName.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "revision");
			AssemblyName.NativeFieldInfoPtr_cultureinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "cultureinfo");
			AssemblyName.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "flags");
			AssemblyName.NativeFieldInfoPtr_hashalg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "hashalg");
			AssemblyName.NativeFieldInfoPtr_keypair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "keypair");
			AssemblyName.NativeFieldInfoPtr_publicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "publicKey");
			AssemblyName.NativeFieldInfoPtr_keyToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "keyToken");
			AssemblyName.NativeFieldInfoPtr_versioncompat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "versioncompat");
			AssemblyName.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "version");
			AssemblyName.NativeFieldInfoPtr_processor_architecture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "processor_architecture");
			AssemblyName.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, "contentType");
			AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668211);
			AssemblyName.NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668212);
			AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668213);
			AssemblyName.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668214);
			AssemblyName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668215);
			AssemblyName.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668216);
			AssemblyName.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668217);
			AssemblyName.NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668218);
			AssemblyName.NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668219);
			AssemblyName.NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668220);
			AssemblyName.NativeMethodInfoPtr_get_FullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668221);
			AssemblyName.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668222);
			AssemblyName.NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668223);
			AssemblyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668224);
			AssemblyName.NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668225);
			AssemblyName.NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668226);
			AssemblyName.NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668227);
			AssemblyName.NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668228);
			AssemblyName.NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668229);
			AssemblyName.NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668230);
			AssemblyName.NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668231);
			AssemblyName.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668232);
			AssemblyName.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668233);
			AssemblyName.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668234);
			AssemblyName.NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668235);
			AssemblyName.NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668236);
			AssemblyName.NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr, 100668237);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000A7888 File Offset: 0x000A5A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186864, RefRangeEnd = 186865, XrefRangeStart = 186864, XrefRangeEnd = 186864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x000A78C4 File Offset: 0x000A5AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186865, XrefRangeEnd = 186866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &aname;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &is_version_definited;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &is_token_defined;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000A792C File Offset: 0x000A5B2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 186874, RefRangeEnd = 186881, XrefRangeStart = 186866, XrefRangeEnd = 186874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName(string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000A7978 File Offset: 0x000A5B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186881, XrefRangeEnd = 186956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyName(SerializationInfo si, StreamingContext sc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x000A79DC File Offset: 0x000A5BDC
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x000A7A14 File Offset: 0x000A5C14
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x000A7A58 File Offset: 0x000A5C58
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x000A7A98 File Offset: 0x000A5C98
		public unsafe CultureInfo CultureInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x000A7ADC File Offset: 0x000A5CDC
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x000A7B18 File Offset: 0x000A5D18
		public unsafe AssemblyNameFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x000A7B58 File Offset: 0x000A5D58
		public unsafe string FullName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 187022, RefRangeEnd = 187025, XrefRangeStart = 186956, XrefRangeEnd = 187022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_FullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x000A7B90 File Offset: 0x000A5D90
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x000A7BD0 File Offset: 0x000A5DD0
		public unsafe Version Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 187033, RefRangeEnd = 187035, XrefRangeStart = 187025, XrefRangeEnd = 187033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x000A7C14 File Offset: 0x000A5E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187035, XrefRangeEnd = 187037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x000A7C4C File Offset: 0x000A5E4C
		[CallerCount(0)]
		public unsafe Il2CppStructArray<byte> GetPublicKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x000A7C8C File Offset: 0x000A5E8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 187041, RefRangeEnd = 187046, XrefRangeStart = 187037, XrefRangeEnd = 187041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetPublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x000A7CCC File Offset: 0x000A5ECC
		public unsafe bool IsPublicKeyValid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 187049, RefRangeEnd = 187052, XrefRangeStart = 187046, XrefRangeEnd = 187049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000A7D08 File Offset: 0x000A5F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187052, XrefRangeEnd = 187058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> InternalGetPublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000A7D48 File Offset: 0x000A5F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187058, XrefRangeEnd = 187060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_public_token(byte* token, byte* pubkey, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pubkey;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000A7D94 File Offset: 0x000A5F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187066, RefRangeEnd = 187069, XrefRangeStart = 187060, XrefRangeEnd = 187066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ComputePublicKeyToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000A7DD4 File Offset: 0x000A5FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187069, RefRangeEnd = 187070, XrefRangeStart = 187069, XrefRangeEnd = 187069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPublicKey(Il2CppStructArray<byte> publicKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(publicKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000A7E18 File Offset: 0x000A6018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187070, XrefRangeEnd = 187444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000A7E74 File Offset: 0x000A6074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187444, XrefRangeEnd = 187447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000A7EB4 File Offset: 0x000A60B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187447, XrefRangeEnd = 187448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000A7EF8 File Offset: 0x000A60F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187448, XrefRangeEnd = 187452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assembly_ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x000A7F2C File Offset: 0x000A612C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187488, RefRangeEnd = 187490, XrefRangeStart = 187452, XrefRangeEnd = 187488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = native;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeBase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addVersion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addPublickey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultToken;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemblyRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x000A7FB4 File Offset: 0x000A61B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187499, RefRangeEnd = 187500, XrefRangeStart = 187490, XrefRangeEnd = 187499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssemblyName Create(Assembly assembly, bool fillCodebase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillCodebase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyName.NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00009D56 File Offset: 0x00007F56
		public AssemblyName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x000A8008 File Offset: 0x000A6208
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00009D5F File Offset: 0x00007F5F
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000A8030 File Offset: 0x000A6230
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00009D7E File Offset: 0x00007F7E
		public unsafe string codebase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_codebase);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_codebase), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000A8058 File Offset: 0x000A6258
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00009D9D File Offset: 0x00007F9D
		public unsafe int major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_major)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x000A8080 File Offset: 0x000A6280
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x00009DB8 File Offset: 0x00007FB8
		public unsafe int minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_minor)) = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x000A80A8 File Offset: 0x000A62A8
		// (set) Token: 0x06001D33 RID: 7475 RVA: 0x00009DD3 File Offset: 0x00007FD3
		public unsafe int build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_build)) = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x000A80D0 File Offset: 0x000A62D0
		// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00009DEE File Offset: 0x00007FEE
		public unsafe int revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_revision)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x000A80F8 File Offset: 0x000A62F8
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00009E09 File Offset: 0x00008009
		public unsafe CultureInfo cultureinfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_cultureinfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_cultureinfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x000A8128 File Offset: 0x000A6328
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00009E28 File Offset: 0x00008028
		public unsafe AssemblyNameFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x000A8150 File Offset: 0x000A6350
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00009E43 File Offset: 0x00008043
		public unsafe AssemblyHashAlgorithm hashalg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_hashalg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_hashalg)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x000A8178 File Offset: 0x000A6378
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00009E5E File Offset: 0x0000805E
		public unsafe StrongNameKeyPair keypair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keypair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StrongNameKeyPair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keypair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x000A81A8 File Offset: 0x000A63A8
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00009E7D File Offset: 0x0000807D
		public unsafe Il2CppStructArray<byte> publicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_publicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_publicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x000A81D8 File Offset: 0x000A63D8
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00009E9C File Offset: 0x0000809C
		public unsafe Il2CppStructArray<byte> keyToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keyToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_keyToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x000A8208 File Offset: 0x000A6408
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00009EBB File Offset: 0x000080BB
		public unsafe AssemblyVersionCompatibility versioncompat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_versioncompat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_versioncompat)) = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x000A8230 File Offset: 0x000A6430
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00009ED6 File Offset: 0x000080D6
		public unsafe Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x000A8260 File Offset: 0x000A6460
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x00009EF5 File Offset: 0x000080F5
		public unsafe ProcessorArchitecture processor_architecture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_processor_architecture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_processor_architecture)) = value;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000A8288 File Offset: 0x000A6488
		// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00009F10 File Offset: 0x00008110
		public unsafe AssemblyContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyName.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeFieldInfoPtr_codebase;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeFieldInfoPtr_revision;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeFieldInfoPtr_cultureinfo;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeFieldInfoPtr_hashalg;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeFieldInfoPtr_keypair;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeFieldInfoPtr_publicKey;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeFieldInfoPtr_keyToken;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeFieldInfoPtr_versioncompat;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeFieldInfoPtr_processor_architecture;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_ParseAssemblyName_Private_Static_Boolean_IntPtr_byref_MonoAssemblyName_byref_Boolean_byref_Boolean_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureInfo_Public_get_CultureInfo_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_set_CultureInfo_Public_set_Void_CultureInfo_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_AssemblyNameFlags_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_AssemblyNameFlags_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_get_String_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_Version_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKey_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicKeyToken_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublicKeyValid_Private_get_Boolean_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPublicKeyToken_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_get_public_token_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_ComputePublicKeyToken_Private_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_SetPublicKey_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeName_Private_Static_ptr_MonoAssemblyName_IntPtr_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_FillName_Internal_Void_ptr_MonoAssemblyName_String_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_AssemblyName_Assembly_Boolean_0;
	}
}
