using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000208 RID: 520
	[Serializable]
	public class FileSystemInfo : MarshalByRefObject
	{
		// Token: 0x06002170 RID: 8560 RVA: 0x000BB2A4 File Offset: 0x000B94A4
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemInfo()
		{
			Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr);
			FileSystemInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_data");
			FileSystemInfo.NativeFieldInfoPtr__dataInitialised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_dataInitialised");
			FileSystemInfo.NativeFieldInfoPtr_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "FullPath");
			FileSystemInfo.NativeFieldInfoPtr_OriginalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "OriginalPath");
			FileSystemInfo.NativeFieldInfoPtr__displayPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_displayPath");
			FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668915);
			FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668916);
			FileSystemInfo.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668917);
			FileSystemInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668918);
			FileSystemInfo.NativeMethodInfoPtr_get_Exists_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668919);
			FileSystemInfo.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668920);
			FileSystemInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668921);
			FileSystemInfo.NativeMethodInfoPtr_get_DisplayPath_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668922);
			FileSystemInfo.NativeMethodInfoPtr_set_DisplayPath_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100668923);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x000BB3EC File Offset: 0x000B95EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190532, RefRangeEnd = 190535, XrefRangeStart = 190530, XrefRangeEnd = 190532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000BB428 File Offset: 0x000B9628
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190551, RefRangeEnd = 190553, XrefRangeStart = 190535, XrefRangeEnd = 190551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000BB48C File Offset: 0x000B968C
		public unsafe virtual string FullName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x000BB4D0 File Offset: 0x000B96D0
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000BB514 File Offset: 0x000B9714
		public unsafe virtual bool Exists
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_Exists_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x000BB55C File Offset: 0x000B975C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190562, RefRangeEnd = 190564, XrefRangeStart = 190553, XrefRangeEnd = 190562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000BB590 File Offset: 0x000B9790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190564, XrefRangeEnd = 190578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x000BB5F4 File Offset: 0x000B97F4
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x000BB62C File Offset: 0x000B982C
		public unsafe string DisplayPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_get_DisplayPath_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_set_DisplayPath_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0000B2CC File Offset: 0x000094CC
		public FileSystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000BB670 File Offset: 0x000B9870
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x0000B2D5 File Offset: 0x000094D5
		public unsafe MonoIOStat _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__data)) = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x000BB698 File Offset: 0x000B9898
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x0000B2F0 File Offset: 0x000094F0
		public unsafe int _dataInitialised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__dataInitialised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__dataInitialised)) = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x000BB6C0 File Offset: 0x000B98C0
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x0000B30B File Offset: 0x0000950B
		public unsafe string FullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_FullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_FullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x000BB6E8 File Offset: 0x000B98E8
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x0000B32A File Offset: 0x0000952A
		public unsafe string OriginalPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_OriginalPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_OriginalPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x000BB710 File Offset: 0x000B9910
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x0000B349 File Offset: 0x00009549
		public unsafe string _displayPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__displayPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__displayPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeFieldInfoPtr__dataInitialised;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeFieldInfoPtr_FullPath;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeFieldInfoPtr_OriginalPath;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeFieldInfoPtr__displayPath;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeMethodInfoPtr_get_Exists_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayPath_Internal_get_String_0;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayPath_Internal_set_Void_String_0;
	}
}
