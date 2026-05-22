using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000250 RID: 592
	public sealed class InternalCodePageDataItem : ValueType
	{
		// Token: 0x060028D3 RID: 10451 RVA: 0x000D8AD4 File Offset: 0x000D6CD4
		// Note: this type is marked as 'beforefieldinit'.
		static InternalCodePageDataItem()
		{
			Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalCodePageDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr);
			InternalCodePageDataItem.NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "codePage");
			InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "uiFamilyCodePage");
			InternalCodePageDataItem.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "flags");
			InternalCodePageDataItem.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "Names");
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0000DE83 File Offset: 0x0000C083
		public InternalCodePageDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0000DE8C File Offset: 0x0000C08C
		public InternalCodePageDataItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr))
		{
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060028D6 RID: 10454 RVA: 0x000D8B54 File Offset: 0x000D6D54
		// (set) Token: 0x060028D7 RID: 10455 RVA: 0x0000DE9E File Offset: 0x0000C09E
		public unsafe ushort codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_codePage)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000D8B7C File Offset: 0x000D6D7C
		// (set) Token: 0x060028D9 RID: 10457 RVA: 0x0000DEB9 File Offset: 0x0000C0B9
		public unsafe ushort uiFamilyCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage)) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x000D8BA4 File Offset: 0x000D6DA4
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		public unsafe uint flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x000D8BCC File Offset: 0x000D6DCC
		// (set) Token: 0x060028DD RID: 10461 RVA: 0x0000DEEF File Offset: 0x0000C0EF
		public unsafe string Names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_Names);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_Names), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeFieldInfoPtr_codePage;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeFieldInfoPtr_uiFamilyCodePage;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeFieldInfoPtr_Names;
	}
}
