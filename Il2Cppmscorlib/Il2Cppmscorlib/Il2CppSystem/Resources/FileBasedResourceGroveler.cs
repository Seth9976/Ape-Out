using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200017D RID: 381
	public class FileBasedResourceGroveler : Object
	{
		// Token: 0x06001AA9 RID: 6825 RVA: 0x0009DAF4 File Offset: 0x0009BCF4
		// Note: this type is marked as 'beforefieldinit'.
		static FileBasedResourceGroveler()
		{
			Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "FileBasedResourceGroveler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr);
			FileBasedResourceGroveler.NativeFieldInfoPtr__mediator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, "_mediator");
			FileBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667870);
			FileBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667871);
			FileBasedResourceGroveler.NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667872);
			FileBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr, 100667873);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0009DB88 File Offset: 0x0009BD88
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileBasedResourceGroveler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mediator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0009DBD4 File Offset: 0x0009BDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184832, XrefRangeEnd = 184839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localResourceSets);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0009DC64 File Offset: 0x0009BE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184839, XrefRangeEnd = 184844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FindResourceFile(CultureInfo culture, string fileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0009DCC0 File Offset: 0x0009BEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184860, RefRangeEnd = 184861, XrefRangeStart = 184844, XrefRangeEnd = 184860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceSet CreateResourceSet(string file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileBasedResourceGroveler.NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00008F36 File Offset: 0x00007136
		public FileBasedResourceGroveler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x0009DD10 File Offset: 0x0009BF10
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00008F3F File Offset: 0x0000713F
		public unsafe ResourceManager.ResourceManagerMediator _mediator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileBasedResourceGroveler.NativeFieldInfoPtr__mediator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager.ResourceManagerMediator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileBasedResourceGroveler.NativeFieldInfoPtr__mediator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr__mediator;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManagerMediator_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_GrovelForResourceSet_Public_Virtual_Final_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeMethodInfoPtr_FindResourceFile_Private_String_CultureInfo_String_0;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeMethodInfoPtr_CreateResourceSet_Private_ResourceSet_String_0;
	}
}
