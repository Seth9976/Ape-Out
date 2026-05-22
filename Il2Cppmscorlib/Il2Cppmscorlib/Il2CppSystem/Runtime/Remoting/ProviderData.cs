using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000399 RID: 921
	public class ProviderData : Object
	{
		// Token: 0x06003CFF RID: 15615 RVA: 0x001211F0 File Offset: 0x0011F3F0
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderData()
		{
			Il2CppClassPointerStore<ProviderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ProviderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderData>.NativeClassPtr);
			ProviderData.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Ref");
			ProviderData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Type");
			ProviderData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Id");
			ProviderData.NativeFieldInfoPtr_CustomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "CustomProperties");
			ProviderData.NativeFieldInfoPtr_CustomData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "CustomData");
			ProviderData.NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, 100672349);
			ProviderData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, 100672350);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x001212AC File Offset: 0x0011F4AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220301, RefRangeEnd = 220305, XrefRangeStart = 220254, XrefRangeEnd = 220301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ProviderData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderData.NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x001212F0 File Offset: 0x0011F4F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220309, RefRangeEnd = 220313, XrefRangeStart = 220305, XrefRangeEnd = 220309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00016C7B File Offset: 0x00014E7B
		public ProviderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x0012132C File Offset: 0x0011F52C
		// (set) Token: 0x06003D04 RID: 15620 RVA: 0x00016C84 File Offset: 0x00014E84
		public unsafe string Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Ref);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Ref), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x00121354 File Offset: 0x0011F554
		// (set) Token: 0x06003D06 RID: 15622 RVA: 0x00016CA3 File Offset: 0x00014EA3
		public unsafe string Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x0012137C File Offset: 0x0011F57C
		// (set) Token: 0x06003D08 RID: 15624 RVA: 0x00016CC2 File Offset: 0x00014EC2
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x001213A4 File Offset: 0x0011F5A4
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x00016CE1 File Offset: 0x00014EE1
		public unsafe Hashtable CustomProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x001213D4 File Offset: 0x0011F5D4
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x00016D00 File Offset: 0x00014F00
		public unsafe IList CustomData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x0400329F RID: 12959
		private static readonly IntPtr NativeFieldInfoPtr_CustomProperties;

		// Token: 0x040032A0 RID: 12960
		private static readonly IntPtr NativeFieldInfoPtr_CustomData;

		// Token: 0x040032A1 RID: 12961
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0;

		// Token: 0x040032A2 RID: 12962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
