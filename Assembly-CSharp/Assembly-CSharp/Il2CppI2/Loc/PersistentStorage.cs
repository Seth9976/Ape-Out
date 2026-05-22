using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000228 RID: 552
	public static class PersistentStorage : Object
	{
		// Token: 0x06004277 RID: 17015 RVA: 0x000F6DE0 File Offset: 0x000F4FE0
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentStorage()
		{
			Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "PersistentStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr);
			PersistentStorage.NativeFieldInfoPtr_mStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, "mStorage");
			PersistentStorage.NativeMethodInfoPtr_SetSetting_String_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669793);
			PersistentStorage.NativeMethodInfoPtr_GetSetting_String_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669794);
			PersistentStorage.NativeMethodInfoPtr_DeleteSetting_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669795);
			PersistentStorage.NativeMethodInfoPtr_HasSetting_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669796);
			PersistentStorage.NativeMethodInfoPtr_ForceSaveSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669797);
			PersistentStorage.NativeMethodInfoPtr_CanAccessFiles_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669798);
			PersistentStorage.NativeMethodInfoPtr_SaveFile_Public_Static_Boolean_eFileType_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669799);
			PersistentStorage.NativeMethodInfoPtr_LoadFile_Public_Static_String_eFileType_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669800);
			PersistentStorage.NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_eFileType_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669801);
			PersistentStorage.NativeMethodInfoPtr_HasFile_Public_Static_Boolean_eFileType_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentStorage>.NativeClassPtr, 100669802);
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x000F6EEC File Offset: 0x000F50EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106823, RefRangeEnd = 106826, XrefRangeStart = 106815, XrefRangeEnd = 106823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSetting_String(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_SetSetting_String_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x000F6F34 File Offset: 0x000F5134
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 106834, RefRangeEnd = 106838, XrefRangeStart = 106826, XrefRangeEnd = 106834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSetting_String(string key, string defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_GetSetting_String_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x000F6F84 File Offset: 0x000F5184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106838, XrefRangeEnd = 106846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteSetting(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_DeleteSetting_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x000F6FBC File Offset: 0x000F51BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106846, XrefRangeEnd = 106854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSetting(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_HasSetting_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x000F7000 File Offset: 0x000F5200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106854, XrefRangeEnd = 106862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceSaveSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_ForceSaveSettings_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x000F7028 File Offset: 0x000F5228
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 106870, RefRangeEnd = 106874, XrefRangeStart = 106862, XrefRangeEnd = 106870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanAccessFiles()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_CanAccessFiles_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x000F7058 File Offset: 0x000F5258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106881, RefRangeEnd = 106883, XrefRangeStart = 106874, XrefRangeEnd = 106881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_SaveFile_Public_Static_Boolean_eFileType_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x000F70C8 File Offset: 0x000F52C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 106890, RefRangeEnd = 106893, XrefRangeStart = 106883, XrefRangeEnd = 106890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_LoadFile_Public_Static_String_eFileType_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x000F7120 File Offset: 0x000F5320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106893, XrefRangeEnd = 106900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_eFileType_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x000F7180 File Offset: 0x000F5380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106900, XrefRangeEnd = 106907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentStorage.NativeMethodInfoPtr_HasFile_Public_Static_Boolean_eFileType_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x0002884D File Offset: 0x00026A4D
		public PersistentStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x000F71E0 File Offset: 0x000F53E0
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x00028856 File Offset: 0x00026A56
		public unsafe static I2CustomPersistentStorage mStorage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PersistentStorage.NativeFieldInfoPtr_mStorage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<I2CustomPersistentStorage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PersistentStorage.NativeFieldInfoPtr_mStorage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeFieldInfoPtr_mStorage;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr_SetSetting_String_Public_Static_Void_String_String_0;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_GetSetting_String_Public_Static_String_String_String_0;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSetting_Public_Static_Void_String_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr_HasSetting_Public_Static_Boolean_String_0;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_ForceSaveSettings_Public_Static_Void_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_CanAccessFiles_Public_Static_Boolean_0;

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_SaveFile_Public_Static_Boolean_eFileType_String_String_Boolean_0;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Static_String_eFileType_String_Boolean_0;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_eFileType_String_Boolean_0;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr_HasFile_Public_Static_Boolean_eFileType_String_Boolean_0;

		// Token: 0x020003B5 RID: 949
		[OriginalName("Assembly-CSharp.dll", "", "eFileType")]
		public enum eFileType
		{
			// Token: 0x04003B77 RID: 15223
			Raw,
			// Token: 0x04003B78 RID: 15224
			Persistent,
			// Token: 0x04003B79 RID: 15225
			Temporal,
			// Token: 0x04003B7A RID: 15226
			Streaming
		}
	}
}
