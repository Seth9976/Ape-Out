using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x02000120 RID: 288
	public class AuthenticationManager : Object
	{
		// Token: 0x0600102C RID: 4140 RVA: 0x0004D48C File Offset: 0x0004B68C
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticationManager()
		{
			Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AuthenticationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr);
			AuthenticationManager.NativeFieldInfoPtr_modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "modules");
			AuthenticationManager.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "locker");
			AuthenticationManager.NativeFieldInfoPtr_credential_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "credential_policy");
			AuthenticationManager.NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665604);
			AuthenticationManager.NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665605);
			AuthenticationManager.NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665606);
			AuthenticationManager.NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100665607);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004D548 File Offset: 0x0004B748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380115, RefRangeEnd = 380117, XrefRangeStart = 380082, XrefRangeEnd = 380115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureModules()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0004D570 File Offset: 0x0004B770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380117, XrefRangeEnd = 380139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0004D5D8 File Offset: 0x0004B7D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 380172, RefRangeEnd = 380175, XrefRangeStart = 380139, XrefRangeEnd = 380172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0004D640 File Offset: 0x0004B840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380209, RefRangeEnd = 380210, XrefRangeStart = 380175, XrefRangeEnd = 380209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00008670 File Offset: 0x00006870
		public AuthenticationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0004D698 File Offset: 0x0004B898
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00008679 File Offset: 0x00006879
		public unsafe static ArrayList modules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_modules, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_modules, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0004D6C0 File Offset: 0x0004B8C0
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x0000868B File Offset: 0x0000688B
		public unsafe static Object locker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_locker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_locker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x0000869D File Offset: 0x0000689D
		public unsafe static ICredentialPolicy credential_policy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_credential_policy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentialPolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_credential_policy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeFieldInfoPtr_modules;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_credential_policy;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0;
	}
}
