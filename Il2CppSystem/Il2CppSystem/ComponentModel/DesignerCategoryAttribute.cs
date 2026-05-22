using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200007C RID: 124
	public sealed class DesignerCategoryAttribute : Attribute
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00030094 File Offset: 0x0002E294
		// Note: this type is marked as 'beforefieldinit'.
		static DesignerCategoryAttribute()
		{
			Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DesignerCategoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr);
			DesignerCategoryAttribute.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "category");
			DesignerCategoryAttribute.NativeFieldInfoPtr_Component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Component");
			DesignerCategoryAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Default");
			DesignerCategoryAttribute.NativeFieldInfoPtr_Form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Form");
			DesignerCategoryAttribute.NativeFieldInfoPtr_Generic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, "Generic");
			DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100664507);
			DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100664508);
			DesignerCategoryAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100664509);
			DesignerCategoryAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr, 100664510);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00030178 File Offset: 0x0002E378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372826, XrefRangeEnd = 372828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignerCategoryAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000301B4 File Offset: 0x0002E3B4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignerCategoryAttribute(string category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerCategoryAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00030200 File Offset: 0x0002E400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372828, XrefRangeEnd = 372830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00030250 File Offset: 0x0002E450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerCategoryAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00005484 File Offset: 0x00003684
		public DesignerCategoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x0003028C File Offset: 0x0002E48C
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x0000548D File Offset: 0x0000368D
		public unsafe string category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerCategoryAttribute.NativeFieldInfoPtr_category);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerCategoryAttribute.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x000302B4 File Offset: 0x0002E4B4
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x000054AC File Offset: 0x000036AC
		public unsafe static DesignerCategoryAttribute Component
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Component, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Component, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x000302DC File Offset: 0x0002E4DC
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x000054BE File Offset: 0x000036BE
		public unsafe static DesignerCategoryAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00030304 File Offset: 0x0002E504
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x000054D0 File Offset: 0x000036D0
		public unsafe static DesignerCategoryAttribute Form
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Form, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Form, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0003032C File Offset: 0x0002E52C
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x000054E2 File Offset: 0x000036E2
		public unsafe static DesignerCategoryAttribute Generic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Generic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerCategoryAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerCategoryAttribute.NativeFieldInfoPtr_Generic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_Component;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_Form;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_Generic;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
