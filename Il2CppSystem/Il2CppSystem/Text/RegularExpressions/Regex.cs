using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004B RID: 75
	[Serializable]
	public class Regex : Object
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x000212A4 File Offset: 0x0001F4A4
		// Note: this type is marked as 'beforefieldinit'.
		static Regex()
		{
			Il2CppClassPointerStore<Regex>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Regex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Regex>.NativeClassPtr);
			Regex.NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "pattern");
			Regex.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "factory");
			Regex.NativeFieldInfoPtr_roptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "roptions");
			Regex.NativeFieldInfoPtr_MaximumMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "MaximumMatchTimeout");
			Regex.NativeFieldInfoPtr_InfiniteMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "InfiniteMatchTimeout");
			Regex.NativeFieldInfoPtr_internalMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "internalMatchTimeout");
			Regex.NativeFieldInfoPtr_FallbackDefaultMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "FallbackDefaultMatchTimeout");
			Regex.NativeFieldInfoPtr_DefaultMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "DefaultMatchTimeout");
			Regex.NativeFieldInfoPtr_caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "caps");
			Regex.NativeFieldInfoPtr_capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capnames");
			Regex.NativeFieldInfoPtr_capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capslist");
			Regex.NativeFieldInfoPtr_capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capsize");
			Regex.NativeFieldInfoPtr_runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "runnerref");
			Regex.NativeFieldInfoPtr_replref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "replref");
			Regex.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "code");
			Regex.NativeFieldInfoPtr_refsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "refsInitialized");
			Regex.NativeFieldInfoPtr_livecode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "livecode");
			Regex.NativeFieldInfoPtr_cacheSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "cacheSize");
			Regex.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664014);
			Regex.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664015);
			Regex.NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664016);
			Regex.NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664017);
			Regex.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664018);
			Regex.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664019);
			Regex.NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664020);
			Regex.NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664021);
			Regex.NativeMethodInfoPtr_Escape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664022);
			Regex.NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664023);
			Regex.NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664024);
			Regex.NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664025);
			Regex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664026);
			Regex.NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664027);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664028);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664029);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664030);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664031);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664032);
			Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664033);
			Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664034);
			Regex.NativeMethodInfoPtr_Match_Public_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664035);
			Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664036);
			Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664037);
			Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664038);
			Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664039);
			Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664040);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664041);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664042);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664043);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664044);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664045);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664046);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664047);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664048);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664049);
			Regex.NativeMethodInfoPtr_InitializeReferences_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664050);
			Regex.NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664051);
			Regex.NativeMethodInfoPtr_LookupCachedAndUpdate_Private_Static_CachedCodeEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664052);
			Regex.NativeMethodInfoPtr_CacheCode_Private_CachedCodeEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664053);
			Regex.NativeMethodInfoPtr_UseOptionR_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664054);
			Regex.NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664055);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00021784 File Offset: 0x0001F984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369396, XrefRangeEnd = 369400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000217C0 File Offset: 0x0001F9C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369405, RefRangeEnd = 369407, XrefRangeStart = 369400, XrefRangeEnd = 369405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0002180C File Offset: 0x0001FA0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 369412, RefRangeEnd = 369417, XrefRangeStart = 369407, XrefRangeEnd = 369412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern, RegexOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00021868 File Offset: 0x0001FA68
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 369461, RefRangeEnd = 369471, XrefRangeStart = 369417, XrefRangeEnd = 369461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000218E0 File Offset: 0x0001FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369471, XrefRangeEnd = 369486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00021944 File Offset: 0x0001FB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369486, XrefRangeEnd = 369563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo si, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000219A0 File Offset: 0x0001FBA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369579, RefRangeEnd = 369583, XrefRangeStart = 369563, XrefRangeEnd = 369579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref matchTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000219D4 File Offset: 0x0001FBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369583, XrefRangeEnd = 369605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan InitDefaultMatchTimeout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00021A04 File Offset: 0x0001FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369605, XrefRangeEnd = 369615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Escape(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Escape_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00021A40 File Offset: 0x0001FC40
		public unsafe RegexOptions Options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00021A7C File Offset: 0x0001FC7C
		public unsafe TimeSpan MatchTimeout
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00021AB8 File Offset: 0x0001FCB8
		public unsafe bool RightToLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00021AF4 File Offset: 0x0001FCF4
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Regex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00021B38 File Offset: 0x0001FD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369615, XrefRangeEnd = 369621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GroupNameFromNumber(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00021B7C File Offset: 0x0001FD7C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 369626, RefRangeEnd = 369634, XrefRangeStart = 369621, XrefRangeEnd = 369626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369639, RefRangeEnd = 369643, XrefRangeStart = 369634, XrefRangeEnd = 369639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern, RegexOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00021C34 File Offset: 0x0001FE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369649, RefRangeEnd = 369651, XrefRangeStart = 369643, XrefRangeEnd = 369649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00021CA4 File Offset: 0x0001FEA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369653, RefRangeEnd = 369654, XrefRangeStart = 369651, XrefRangeEnd = 369653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369654, XrefRangeEnd = 369655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00021D50 File Offset: 0x0001FF50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 369665, RefRangeEnd = 369672, XrefRangeStart = 369655, XrefRangeEnd = 369665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Match Match(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00021DA8 File Offset: 0x0001FFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369672, XrefRangeEnd = 369678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00021E1C File Offset: 0x0002001C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369678, XrefRangeEnd = 369680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Match(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00021E6C File Offset: 0x0002006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369680, XrefRangeEnd = 369681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Match(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00021ECC File Offset: 0x000200CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369694, RefRangeEnd = 369696, XrefRangeStart = 369681, XrefRangeEnd = 369694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MatchCollection Matches(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00021F24 File Offset: 0x00020124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369696, XrefRangeEnd = 369705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00021F98 File Offset: 0x00020198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369705, XrefRangeEnd = 369710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchCollection Matches(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00021FE8 File Offset: 0x000201E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369710, XrefRangeEnd = 369714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchCollection Matches(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00022048 File Offset: 0x00020248
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 369719, RefRangeEnd = 369749, XrefRangeStart = 369714, XrefRangeEnd = 369719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, string replacement)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000220A8 File Offset: 0x000202A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369754, RefRangeEnd = 369756, XrefRangeStart = 369749, XrefRangeEnd = 369754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, string replacement, RegexOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00022118 File Offset: 0x00020318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369769, RefRangeEnd = 369771, XrefRangeStart = 369756, XrefRangeEnd = 369769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00022194 File Offset: 0x00020394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369771, XrefRangeEnd = 369773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, string replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000221F0 File Offset: 0x000203F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369795, RefRangeEnd = 369797, XrefRangeStart = 369773, XrefRangeEnd = 369795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, string replacement, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00022268 File Offset: 0x00020468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369807, RefRangeEnd = 369809, XrefRangeStart = 369797, XrefRangeEnd = 369807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, MatchEvaluator evaluator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000222C8 File Offset: 0x000204C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369809, XrefRangeEnd = 369822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00022344 File Offset: 0x00020544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369822, XrefRangeEnd = 369824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, MatchEvaluator evaluator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000223A0 File Offset: 0x000205A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369824, XrefRangeEnd = 369831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, MatchEvaluator evaluator, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00022418 File Offset: 0x00020618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369831, XrefRangeEnd = 369841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_InitializeReferences_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0002244C File Offset: 0x0002064C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 369864, RefRangeEnd = 369882, XrefRangeStart = 369841, XrefRangeEnd = 369864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevlen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginning;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000224E4 File Offset: 0x000206E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369906, RefRangeEnd = 369907, XrefRangeStart = 369882, XrefRangeEnd = 369906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CachedCodeEntry LookupCachedAndUpdate(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_LookupCachedAndUpdate_Private_Static_CachedCodeEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00022528 File Offset: 0x00020728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369907, XrefRangeEnd = 369949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedCodeEntry CacheCode(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_CacheCode_Private_CachedCodeEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00022578 File Offset: 0x00020778
		[CallerCount(0)]
		public unsafe bool UseOptionR()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_UseOptionR_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000225B4 File Offset: 0x000207B4
		[CallerCount(0)]
		public unsafe bool UseOptionInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000037BD File Offset: 0x000019BD
		public Regex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000225F0 File Offset: 0x000207F0
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x000037C6 File Offset: 0x000019C6
		public unsafe string pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00022618 File Offset: 0x00020818
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x000037E5 File Offset: 0x000019E5
		public unsafe RegexRunnerFactory factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunnerFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00022648 File Offset: 0x00020848
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00003804 File Offset: 0x00001A04
		public unsafe RegexOptions roptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_roptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_roptions)) = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00022670 File Offset: 0x00020870
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000381F File Offset: 0x00001A1F
		public unsafe static TimeSpan MaximumMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_MaximumMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_MaximumMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0002268C File Offset: 0x0002088C
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0000382D File Offset: 0x00001A2D
		public unsafe static TimeSpan InfiniteMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000226A8 File Offset: 0x000208A8
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0000383B File Offset: 0x00001A3B
		public unsafe TimeSpan internalMatchTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_internalMatchTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_internalMatchTimeout)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000226D0 File Offset: 0x000208D0
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003856 File Offset: 0x00001A56
		public unsafe static TimeSpan FallbackDefaultMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_FallbackDefaultMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_FallbackDefaultMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x000226EC File Offset: 0x000208EC
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003864 File Offset: 0x00001A64
		public unsafe static TimeSpan DefaultMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00022708 File Offset: 0x00020908
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003872 File Offset: 0x00001A72
		public unsafe Hashtable caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00022738 File Offset: 0x00020938
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00003891 File Offset: 0x00001A91
		public unsafe Hashtable capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00022768 File Offset: 0x00020968
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x000038B0 File Offset: 0x00001AB0
		public unsafe Il2CppStringArray capslist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capslist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00022798 File Offset: 0x00020998
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x000038CF File Offset: 0x00001ACF
		public unsafe int capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capsize)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000227C0 File Offset: 0x000209C0
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000038EA File Offset: 0x00001AEA
		public unsafe ExclusiveReference runnerref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_runnerref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_runnerref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000227F0 File Offset: 0x000209F0
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003909 File Offset: 0x00001B09
		public unsafe SharedReference replref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_replref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_replref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00022820 File Offset: 0x00020A20
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003928 File Offset: 0x00001B28
		public unsafe RegexCode code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_code);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_code), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00022850 File Offset: 0x00020A50
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00003947 File Offset: 0x00001B47
		public unsafe bool refsInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_refsInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_refsInitialized)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00022878 File Offset: 0x00020A78
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003962 File Offset: 0x00001B62
		public unsafe static LinkedList<CachedCodeEntry> livecode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_livecode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<CachedCodeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_livecode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000228A0 File Offset: 0x00020AA0
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003974 File Offset: 0x00001B74
		public unsafe static int cacheSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_cacheSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_cacheSize, (void*)(&value));
			}
		}

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeFieldInfoPtr_pattern;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeFieldInfoPtr_factory;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr_roptions;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_MaximumMatchTimeout;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_InfiniteMatchTimeout;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr_internalMatchTimeout;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr_FallbackDefaultMatchTimeout;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMatchTimeout;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr_caps;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeFieldInfoPtr_capnames;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_capslist;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr_capsize;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_runnerref;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_replref;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_code;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr_refsInitialized;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_livecode;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr_cacheSize;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_Escape_Public_Static_String_String_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Match_String_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Match_String_Int32_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_InitializeReferences_Protected_Void_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_LookupCachedAndUpdate_Private_Static_CachedCodeEntry_String_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_CacheCode_Private_CachedCodeEntry_String_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionR_Protected_Boolean_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0;
	}
}
