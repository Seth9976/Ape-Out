using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x02000139 RID: 313
	public sealed class MovedFromAttributeData : ValueType
	{
		// Token: 0x060018BD RID: 6333 RVA: 0x0005FF24 File Offset: 0x0005E124
		// Note: this type is marked as 'beforefieldinit'.
		static MovedFromAttributeData()
		{
			Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttributeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr);
			MovedFromAttributeData.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "className");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpace");
			MovedFromAttributeData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assembly");
			MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "classHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpaceHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assemblyHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "autoUdpateAPI");
			MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, 100665590);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0005FFF4 File Offset: 0x0005E1F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 501634, RefRangeEnd = 501636, XrefRangeStart = 501634, XrefRangeEnd = 501634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoUpdateAPI;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0000D041 File Offset: 0x0000B241
		public MovedFromAttributeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0000D04A File Offset: 0x0000B24A
		public MovedFromAttributeData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr))
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x00060070 File Offset: 0x0005E270
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x0000D05C File Offset: 0x0000B25C
		public unsafe string className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00060098 File Offset: 0x0005E298
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0000D07B File Offset: 0x0000B27B
		public unsafe string nameSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x000600C0 File Offset: 0x0005E2C0
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0000D09A File Offset: 0x0000B29A
		public unsafe string assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x000600E8 File Offset: 0x0005E2E8
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0000D0B9 File Offset: 0x0000B2B9
		public unsafe bool classHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00060110 File Offset: 0x0005E310
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
		public unsafe bool nameSpaceHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00060138 File Offset: 0x0005E338
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x0000D0EF File Offset: 0x0000B2EF
		public unsafe bool assemblyHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged)) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00060160 File Offset: 0x0005E360
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0000D10A File Offset: 0x0000B30A
		public unsafe bool autoUdpateAPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI)) = value;
			}
		}

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr_className;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr_nameSpace;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_classHasChanged;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_nameSpaceHasChanged;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_assemblyHasChanged;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_autoUdpateAPI;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0;
	}
}
