using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000057 RID: 87
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x00025D48 File Offset: 0x00023F48
		// Note: this type is marked as 'beforefieldinit'.
		static Group()
		{
			Il2CppClassPointerStore<Group>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Group");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Group>.NativeClassPtr);
			Group.NativeFieldInfoPtr__emptygroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_emptygroup");
			Group.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_caps");
			Group.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_capcount");
			Group.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_name");
			Group.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664153);
			Group.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664154);
			Group.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664156);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00025E04 File Offset: 0x00024004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 370563, RefRangeEnd = 370565, XrefRangeStart = 370562, XrefRangeEnd = 370563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group(string text, Il2CppStructArray<int> caps, int capcount, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Group>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00025E84 File Offset: 0x00024084
		public unsafe bool Success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00025EC0 File Offset: 0x000240C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370565, XrefRangeEnd = 370568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Group>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000410A File Offset: 0x0000230A
		public Group(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00025EFC File Offset: 0x000240FC
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00004113 File Offset: 0x00002313
		public unsafe static Group _emptygroup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Group.NativeFieldInfoPtr__emptygroup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Group>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Group.NativeFieldInfoPtr__emptygroup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00025F24 File Offset: 0x00024124
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00004125 File Offset: 0x00002325
		public unsafe Il2CppStructArray<int> _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00025F54 File Offset: 0x00024154
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00004144 File Offset: 0x00002344
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00025F7C File Offset: 0x0002417C
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0000415F File Offset: 0x0000235F
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr__emptygroup;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
