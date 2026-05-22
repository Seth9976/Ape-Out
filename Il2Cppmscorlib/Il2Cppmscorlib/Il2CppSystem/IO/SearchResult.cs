using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32;

namespace Il2CppSystem.IO
{
	// Token: 0x02000206 RID: 518
	public sealed class SearchResult : Object
	{
		// Token: 0x06002161 RID: 8545 RVA: 0x000BAFB4 File Offset: 0x000B91B4
		// Note: this type is marked as 'beforefieldinit'.
		static SearchResult()
		{
			Il2CppClassPointerStore<SearchResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "SearchResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchResult>.NativeClassPtr);
			SearchResult.NativeFieldInfoPtr_fullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, "fullPath");
			SearchResult.NativeFieldInfoPtr_userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, "userPath");
			SearchResult.NativeFieldInfoPtr_findData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, "findData");
			SearchResult.NativeMethodInfoPtr__ctor_Internal_Void_String_String_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, 100668910);
			SearchResult.NativeMethodInfoPtr_get_UserPath_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, 100668911);
			SearchResult.NativeMethodInfoPtr_get_FindData_Internal_get_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchResult>.NativeClassPtr, 100668912);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x000BB05C File Offset: 0x000B925C
		[CallerCount(0)]
		public unsafe SearchResult(string fullPath, string userPath, Win32Native.WIN32_FIND_DATA findData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(findData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResult.NativeMethodInfoPtr__ctor_Internal_Void_String_String_WIN32_FIND_DATA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000BB0CC File Offset: 0x000B92CC
		public unsafe string UserPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResult.NativeMethodInfoPtr_get_UserPath_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x000BB104 File Offset: 0x000B9304
		public unsafe Win32Native.WIN32_FIND_DATA FindData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchResult.NativeMethodInfoPtr_get_FindData_Internal_get_WIN32_FIND_DATA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Win32Native.WIN32_FIND_DATA>(intPtr3) : null;
			}
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0000B25D File Offset: 0x0000945D
		public SearchResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x000BB144 File Offset: 0x000B9344
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x0000B266 File Offset: 0x00009466
		public unsafe string fullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_fullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_fullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x000BB16C File Offset: 0x000B936C
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x0000B285 File Offset: 0x00009485
		public unsafe string userPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_userPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_userPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000BB194 File Offset: 0x000B9394
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x0000B2A4 File Offset: 0x000094A4
		public unsafe Win32Native.WIN32_FIND_DATA findData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_findData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Win32Native.WIN32_FIND_DATA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SearchResult.NativeFieldInfoPtr_findData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeFieldInfoPtr_fullPath;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeFieldInfoPtr_userPath;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeFieldInfoPtr_findData;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_WIN32_FIND_DATA_0;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr_get_UserPath_Internal_get_String_0;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeMethodInfoPtr_get_FindData_Internal_get_WIN32_FIND_DATA_0;
	}
}
