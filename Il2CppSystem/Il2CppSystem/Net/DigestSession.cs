using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppSystem.Net
{
	// Token: 0x02000126 RID: 294
	public class DigestSession : Object
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x0004E078 File Offset: 0x0004C278
		// Note: this type is marked as 'beforefieldinit'.
		static DigestSession()
		{
			Il2CppClassPointerStore<DigestSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "DigestSession");
			DigestSession.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "rng");
			DigestSession.NativeFieldInfoPtr_lastUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "lastUse");
			DigestSession.NativeFieldInfoPtr__nc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "_nc");
			DigestSession.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "hash");
			DigestSession.NativeFieldInfoPtr_parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "parser");
			DigestSession.NativeFieldInfoPtr__cnonce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "_cnonce");
			DigestSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665631);
			DigestSession.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665632);
			DigestSession.NativeMethodInfoPtr_get_Realm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665633);
			DigestSession.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665634);
			DigestSession.NativeMethodInfoPtr_get_Opaque_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665635);
			DigestSession.NativeMethodInfoPtr_get_QOP_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665636);
			DigestSession.NativeMethodInfoPtr_get_CNonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665637);
			DigestSession.NativeMethodInfoPtr_Parse_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665638);
			DigestSession.NativeMethodInfoPtr_HashToHexString_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665639);
			DigestSession.NativeMethodInfoPtr_HA1_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665640);
			DigestSession.NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665641);
			DigestSession.NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665642);
			DigestSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665643);
			DigestSession.NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100665644);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0004E230 File Offset: 0x0004C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380341, XrefRangeEnd = 380345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigestSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigestSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x0004E26C File Offset: 0x0004C46C
		public unsafe string Algorithm
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 380345, RefRangeEnd = 380347, XrefRangeStart = 380345, XrefRangeEnd = 380345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0004E2A4 File Offset: 0x0004C4A4
		public unsafe string Realm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 380347, RefRangeEnd = 380348, XrefRangeStart = 380347, XrefRangeEnd = 380347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Realm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		public unsafe string Nonce
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 380348, RefRangeEnd = 380350, XrefRangeStart = 380348, XrefRangeEnd = 380348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0004E314 File Offset: 0x0004C514
		public unsafe string Opaque
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 380350, RefRangeEnd = 380352, XrefRangeStart = 380350, XrefRangeEnd = 380350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Opaque_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x0004E34C File Offset: 0x0004C54C
		public unsafe string QOP
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 380352, RefRangeEnd = 380355, XrefRangeStart = 380352, XrefRangeEnd = 380352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_QOP_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x0004E384 File Offset: 0x0004C584
		public unsafe string CNonce
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 380371, RefRangeEnd = 380375, XrefRangeStart = 380355, XrefRangeEnd = 380371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_CNonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0004E3BC File Offset: 0x0004C5BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380395, RefRangeEnd = 380397, XrefRangeStart = 380375, XrefRangeEnd = 380395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse(string challenge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Parse_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0004E40C File Offset: 0x0004C60C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 380412, RefRangeEnd = 380417, XrefRangeStart = 380397, XrefRangeEnd = 380412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HashToHexString(string toBeHashed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(toBeHashed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HashToHexString_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0004E454 File Offset: 0x0004C654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380435, RefRangeEnd = 380436, XrefRangeStart = 380417, XrefRangeEnd = 380435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HA1(string username, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HA1_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0004E4B0 File Offset: 0x0004C6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380436, XrefRangeEnd = 380445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HA2(HttpWebRequest webRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0004E4F8 File Offset: 0x0004C6F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380475, RefRangeEnd = 380476, XrefRangeStart = 380445, XrefRangeEnd = 380475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Response(string username, string password, HttpWebRequest webRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0004E564 File Offset: 0x0004C764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380547, RefRangeEnd = 380548, XrefRangeStart = 380476, XrefRangeEnd = 380547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0004E5C8 File Offset: 0x0004C7C8
		public unsafe DateTime LastUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000087A5 File Offset: 0x000069A5
		public DigestSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0004E604 File Offset: 0x0004C804
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x000087AE File Offset: 0x000069AE
		public unsafe static RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DigestSession.NativeFieldInfoPtr_rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigestSession.NativeFieldInfoPtr_rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0004E62C File Offset: 0x0004C82C
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x000087C0 File Offset: 0x000069C0
		public unsafe DateTime lastUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_lastUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_lastUse)) = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0004E654 File Offset: 0x0004C854
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x000087DB File Offset: 0x000069DB
		public unsafe int _nc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__nc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__nc)) = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0004E67C File Offset: 0x0004C87C
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x000087F6 File Offset: 0x000069F6
		public unsafe HashAlgorithm hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_hash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_hash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x0004E6AC File Offset: 0x0004C8AC
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x00008815 File Offset: 0x00006A15
		public unsafe DigestHeaderParser parser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_parser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DigestHeaderParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_parser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x0004E6DC File Offset: 0x0004C8DC
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x00008834 File Offset: 0x00006A34
		public unsafe string _cnonce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__cnonce);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__cnonce), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr_lastUse;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr__nc;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeFieldInfoPtr_hash;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_parser;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr__cnonce;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_get_Realm_Public_get_String_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_get_Opaque_Public_get_String_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_get_QOP_Public_get_String_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_get_CNonce_Public_get_String_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_String_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_HashToHexString_Private_String_String_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_HA1_Private_String_String_String_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0;
	}
}
