using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000046 RID: 70
	public class KeyHandler : Object
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x00033B20 File Offset: 0x00031D20
		// Note: this type is marked as 'beforefieldinit'.
		static KeyHandler()
		{
			Il2CppClassPointerStore<KeyHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "KeyHandler");
			KeyHandler.NativeFieldInfoPtr_key_to_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "key_to_handler");
			KeyHandler.NativeFieldInfoPtr_dir_to_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "dir_to_handler");
			KeyHandler.NativeFieldInfoPtr_Dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "Dir");
			KeyHandler.NativeFieldInfoPtr_ActualDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "ActualDir");
			KeyHandler.NativeFieldInfoPtr_IsVolatile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "IsVolatile");
			KeyHandler.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "values");
			KeyHandler.NativeFieldInfoPtr_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "file");
			KeyHandler.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "dirty");
			KeyHandler.NativeFieldInfoPtr_user_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "user_store");
			KeyHandler.NativeFieldInfoPtr_machine_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, "machine_store");
			KeyHandler.NativeMethodInfoPtr__ctor_Private_Void_RegistryKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663935);
			KeyHandler.NativeMethodInfoPtr__ctor_Private_Void_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663936);
			KeyHandler.NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663937);
			KeyHandler.NativeMethodInfoPtr_LoadKey_Private_Void_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663938);
			KeyHandler.NativeMethodInfoPtr_Ensure_Public_RegistryKey_RegistryKey_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663939);
			KeyHandler.NativeMethodInfoPtr_Probe_Public_RegistryKey_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663940);
			KeyHandler.NativeMethodInfoPtr_CombineName_Private_Static_String_RegistryKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663941);
			KeyHandler.NativeMethodInfoPtr_GetSystemBootTime_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663942);
			KeyHandler.NativeMethodInfoPtr_GetRegisteredBootTime_Private_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663943);
			KeyHandler.NativeMethodInfoPtr_SaveRegisteredBootTime_Private_Static_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663944);
			KeyHandler.NativeMethodInfoPtr_CleanVolatileKeys_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663945);
			KeyHandler.NativeMethodInfoPtr_VolatileKeyExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663946);
			KeyHandler.NativeMethodInfoPtr_GetVolatileDir_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663947);
			KeyHandler.NativeMethodInfoPtr_Lookup_Public_Static_KeyHandler_RegistryKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663948);
			KeyHandler.NativeMethodInfoPtr_GetRootFromDir_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663949);
			KeyHandler.NativeMethodInfoPtr_Drop_Public_Static_Void_RegistryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663950);
			KeyHandler.NativeMethodInfoPtr_GetValue_Public_Object_String_RegistryValueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663951);
			KeyHandler.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663952);
			KeyHandler.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663953);
			KeyHandler.NativeMethodInfoPtr_ValueExists_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663954);
			KeyHandler.NativeMethodInfoPtr_get_IsMarkedForDeletion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663955);
			KeyHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663956);
			KeyHandler.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663957);
			KeyHandler.NativeMethodInfoPtr_get_UserStore_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663958);
			KeyHandler.NativeMethodInfoPtr_get_MachineStore_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr, 100663959);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00033E04 File Offset: 0x00032004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137523, XrefRangeEnd = 137524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyHandler(RegistryKey rkey, string basedir)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(basedir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr__ctor_Private_Void_RegistryKey_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00033E64 File Offset: 0x00032064
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137548, RefRangeEnd = 137553, XrefRangeStart = 137524, XrefRangeEnd = 137548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyHandler(RegistryKey rkey, string basedir, bool is_volatile)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(basedir);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_volatile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr__ctor_Private_Void_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00033ED0 File Offset: 0x000320D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137601, RefRangeEnd = 137602, XrefRangeStart = 137553, XrefRangeEnd = 137601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00033F04 File Offset: 0x00032104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137675, RefRangeEnd = 137676, XrefRangeStart = 137602, XrefRangeEnd = 137675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadKey(SecurityElement se)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_LoadKey_Private_Void_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00033F48 File Offset: 0x00032148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137710, RefRangeEnd = 137711, XrefRangeStart = 137676, XrefRangeEnd = 137710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extra);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_volatile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_Ensure_Public_RegistryKey_RegistryKey_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00033FC8 File Offset: 0x000321C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137760, RefRangeEnd = 137761, XrefRangeStart = 137711, XrefRangeEnd = 137760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey Probe(RegistryKey rkey, string extra, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extra);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_Probe_Public_RegistryKey_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00034038 File Offset: 0x00032238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137761, XrefRangeEnd = 137767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CombineName(RegistryKey rkey, string extra)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extra);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_CombineName_Private_Static_String_RegistryKey_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00034088 File Offset: 0x00032288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137794, RefRangeEnd = 137795, XrefRangeStart = 137767, XrefRangeEnd = 137794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetSystemBootTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_GetSystemBootTime_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000340B8 File Offset: 0x000322B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137814, RefRangeEnd = 137815, XrefRangeStart = 137795, XrefRangeEnd = 137814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetRegisteredBootTime(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_GetRegisteredBootTime_Private_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000340FC File Offset: 0x000322FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137827, RefRangeEnd = 137828, XrefRangeStart = 137815, XrefRangeEnd = 137827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveRegisteredBootTime(string path, long btime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref btime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_SaveRegisteredBootTime_Private_Static_Void_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00034140 File Offset: 0x00032340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137828, XrefRangeEnd = 137864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanVolatileKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_CleanVolatileKeys_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00034168 File Offset: 0x00032368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137886, RefRangeEnd = 137888, XrefRangeStart = 137864, XrefRangeEnd = 137886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool VolatileKeyExists(string dir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_VolatileKeyExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000341AC File Offset: 0x000323AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137916, RefRangeEnd = 137920, XrefRangeStart = 137888, XrefRangeEnd = 137916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetVolatileDir(string dir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_GetVolatileDir_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000341E8 File Offset: 0x000323E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137967, RefRangeEnd = 137972, XrefRangeStart = 137920, XrefRangeEnd = 137967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createNonExisting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_Lookup_Public_Static_KeyHandler_RegistryKey_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyHandler>(intPtr3) : null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0003423C File Offset: 0x0003243C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137972, XrefRangeEnd = 137994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRootFromDir(string dir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_GetRootFromDir_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00034278 File Offset: 0x00032478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138030, RefRangeEnd = 138031, XrefRangeStart = 137994, XrefRangeEnd = 138030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Drop(RegistryKey rkey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_Drop_Public_Static_Void_RegistryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000342B0 File Offset: 0x000324B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138043, RefRangeEnd = 138044, XrefRangeStart = 138031, XrefRangeEnd = 138043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name, RegistryValueOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_GetValue_Public_Object_String_RegistryValueOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00034310 File Offset: 0x00032510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138090, RefRangeEnd = 138091, XrefRangeStart = 138044, XrefRangeEnd = 138090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetSubKeyNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00034350 File Offset: 0x00032550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138101, RefRangeEnd = 138103, XrefRangeStart = 138091, XrefRangeEnd = 138101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00034384 File Offset: 0x00032584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138108, RefRangeEnd = 138109, XrefRangeStart = 138103, XrefRangeEnd = 138108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValueExists(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_ValueExists_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000343D4 File Offset: 0x000325D4
		public unsafe bool IsMarkedForDeletion
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 138113, RefRangeEnd = 138115, XrefRangeStart = 138109, XrefRangeEnd = 138113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_get_IsMarkedForDeletion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00034410 File Offset: 0x00032610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138115, XrefRangeEnd = 138117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0003444C File Offset: 0x0003264C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138244, RefRangeEnd = 138245, XrefRangeStart = 138117, XrefRangeEnd = 138244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00034480 File Offset: 0x00032680
		public unsafe static string UserStore
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 138262, RefRangeEnd = 138268, XrefRangeStart = 138245, XrefRangeEnd = 138262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_get_UserStore_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x000344AC File Offset: 0x000326AC
		public unsafe static string MachineStore
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 138300, RefRangeEnd = 138306, XrefRangeStart = 138268, XrefRangeEnd = 138300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHandler.NativeMethodInfoPtr_get_MachineStore_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00003C63 File Offset: 0x00001E63
		public KeyHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x000344D8 File Offset: 0x000326D8
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00003C6C File Offset: 0x00001E6C
		public unsafe static Hashtable key_to_handler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyHandler.NativeFieldInfoPtr_key_to_handler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyHandler.NativeFieldInfoPtr_key_to_handler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00034500 File Offset: 0x00032700
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00003C7E File Offset: 0x00001E7E
		public unsafe static Hashtable dir_to_handler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyHandler.NativeFieldInfoPtr_dir_to_handler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyHandler.NativeFieldInfoPtr_dir_to_handler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00034528 File Offset: 0x00032728
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00003C90 File Offset: 0x00001E90
		public unsafe string Dir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_Dir);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_Dir), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00034550 File Offset: 0x00032750
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00003CAF File Offset: 0x00001EAF
		public unsafe string ActualDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_ActualDir);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_ActualDir), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00034578 File Offset: 0x00032778
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00003CCE File Offset: 0x00001ECE
		public unsafe bool IsVolatile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_IsVolatile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_IsVolatile)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000345A0 File Offset: 0x000327A0
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public unsafe Hashtable values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000345D0 File Offset: 0x000327D0
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00003D08 File Offset: 0x00001F08
		public unsafe string file
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_file);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_file), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000345F8 File Offset: 0x000327F8
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00003D27 File Offset: 0x00001F27
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyHandler.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00034620 File Offset: 0x00032820
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00003D42 File Offset: 0x00001F42
		public unsafe static string user_store
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyHandler.NativeFieldInfoPtr_user_store, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyHandler.NativeFieldInfoPtr_user_store, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00034640 File Offset: 0x00032840
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003D54 File Offset: 0x00001F54
		public unsafe static string machine_store
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyHandler.NativeFieldInfoPtr_machine_store, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyHandler.NativeFieldInfoPtr_machine_store, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_key_to_handler;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_dir_to_handler;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_Dir;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_ActualDir;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_IsVolatile;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_file;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_user_store;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_machine_store;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_RegistryKey_String_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_RegistryKey_String_Boolean_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_LoadKey_Private_Void_SecurityElement_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_Ensure_Public_RegistryKey_RegistryKey_String_Boolean_Boolean_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_Probe_Public_RegistryKey_RegistryKey_String_Boolean_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_CombineName_Private_Static_String_RegistryKey_String_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemBootTime_Private_Static_Int64_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredBootTime_Private_Static_Int64_String_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_SaveRegisteredBootTime_Private_Static_Void_String_Int64_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_CleanVolatileKeys_Private_Static_Void_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_VolatileKeyExists_Public_Static_Boolean_String_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_GetVolatileDir_Public_Static_String_String_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_Lookup_Public_Static_KeyHandler_RegistryKey_Boolean_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_GetRootFromDir_Private_Static_String_String_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_Drop_Public_Static_Void_RegistryKey_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_RegistryValueOptions_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_ValueExists_Public_Boolean_String_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMarkedForDeletion_Public_get_Boolean_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_get_UserStore_Private_Static_get_String_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_get_MachineStore_Private_Static_get_String_0;
	}
}
