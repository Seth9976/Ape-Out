using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000205 RID: 517
	public class StringResultHandler : SearchResultHandler<string>
	{
		// Token: 0x06002158 RID: 8536 RVA: 0x000BADCC File Offset: 0x000B8FCC
		// Note: this type is marked as 'beforefieldinit'.
		static StringResultHandler()
		{
			Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StringResultHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr);
			StringResultHandler.NativeFieldInfoPtr__includeFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, "_includeFiles");
			StringResultHandler.NativeFieldInfoPtr__includeDirs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, "_includeDirs");
			StringResultHandler.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, 100668907);
			StringResultHandler.NativeMethodInfoPtr_IsResultIncluded_Internal_Virtual_Boolean_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, 100668908);
			StringResultHandler.NativeMethodInfoPtr_CreateObject_Internal_Virtual_String_SearchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr, 100668909);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000BAE60 File Offset: 0x000B9060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190523, XrefRangeEnd = 190524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringResultHandler(bool includeFiles, bool includeDirs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringResultHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeFiles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDirs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringResultHandler.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000BAEB8 File Offset: 0x000B90B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190524, XrefRangeEnd = 190525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsResultIncluded(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringResultHandler.NativeMethodInfoPtr_IsResultIncluded_Internal_Virtual_Boolean_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000BAF10 File Offset: 0x000B9110
		[CallerCount(0)]
		public unsafe override string CreateObject(SearchResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringResultHandler.NativeMethodInfoPtr_CreateObject_Internal_Virtual_String_SearchResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0000B21E File Offset: 0x0000941E
		public StringResultHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000BAF64 File Offset: 0x000B9164
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x0000B227 File Offset: 0x00009427
		public unsafe bool _includeFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeFiles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeFiles)) = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000BAF8C File Offset: 0x000B918C
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x0000B242 File Offset: 0x00009442
		public unsafe bool _includeDirs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeDirs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringResultHandler.NativeFieldInfoPtr__includeDirs)) = value;
			}
		}

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeFieldInfoPtr__includeFiles;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeFieldInfoPtr__includeDirs;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Boolean_0;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr_IsResultIncluded_Internal_Virtual_Boolean_SearchResult_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_CreateObject_Internal_Virtual_String_SearchResult_0;
	}
}
