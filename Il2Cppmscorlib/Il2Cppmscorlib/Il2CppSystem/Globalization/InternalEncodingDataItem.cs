using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024F RID: 591
	public sealed class InternalEncodingDataItem : ValueType
	{
		// Token: 0x060028CC RID: 10444 RVA: 0x000D8A2C File Offset: 0x000D6C2C
		// Note: this type is marked as 'beforefieldinit'.
		static InternalEncodingDataItem()
		{
			Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalEncodingDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr);
			InternalEncodingDataItem.NativeFieldInfoPtr_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "webName");
			InternalEncodingDataItem.NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "codePage");
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0000DE2E File Offset: 0x0000C02E
		public InternalEncodingDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0000DE37 File Offset: 0x0000C037
		public InternalEncodingDataItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr))
		{
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x000D8A84 File Offset: 0x000D6C84
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x0000DE49 File Offset: 0x0000C049
		public unsafe string webName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_webName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_webName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x000D8AAC File Offset: 0x000D6CAC
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x0000DE68 File Offset: 0x0000C068
		public unsafe ushort codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_codePage)) = value;
			}
		}

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeFieldInfoPtr_webName;

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeFieldInfoPtr_codePage;
	}
}
