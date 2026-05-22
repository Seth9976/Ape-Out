using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E3 RID: 227
	public class XmlTypeAttribute : Attribute
	{
		// Token: 0x06001349 RID: 4937 RVA: 0x00066EE0 File Offset: 0x000650E0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeAttribute()
		{
			Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr);
			XmlTypeAttribute.NativeFieldInfoPtr_includeInSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, "includeInSchema");
			XmlTypeAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, "ns");
			XmlTypeAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, "typeName");
			XmlTypeAttribute.NativeMethodInfoPtr_get_IncludeInSchema_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, 100666306);
			XmlTypeAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, 100666307);
			XmlTypeAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, 100666308);
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00066F88 File Offset: 0x00065188
		public unsafe bool IncludeInSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeAttribute.NativeMethodInfoPtr_get_IncludeInSchema_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00066FC4 File Offset: 0x000651C4
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00066FFC File Offset: 0x000651FC
		public unsafe string TypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 407365, RefRangeEnd = 407366, XrefRangeStart = 407363, XrefRangeEnd = 407365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000088B2 File Offset: 0x00006AB2
		public XmlTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x00067034 File Offset: 0x00065234
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x000088BB File Offset: 0x00006ABB
		public unsafe bool includeInSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_includeInSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_includeInSchema)) = value;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0006705C File Offset: 0x0006525C
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x000088D6 File Offset: 0x00006AD6
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00067084 File Offset: 0x00065284
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x000088F5 File Offset: 0x00006AF5
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeFieldInfoPtr_includeInSchema;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeInSchema_Public_get_Boolean_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;
	}
}
