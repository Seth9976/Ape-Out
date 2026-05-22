using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A5 RID: 421
	public class XmlSchemaFacet : XmlSchemaAnnotated
	{
		// Token: 0x060022BE RID: 8894 RVA: 0x000A258C File Offset: 0x000A078C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaFacet()
		{
			Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaFacet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr);
			XmlSchemaFacet.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, "value");
			XmlSchemaFacet.NativeFieldInfoPtr_isFixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, "isFixed");
			XmlSchemaFacet.NativeFieldInfoPtr_facetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, "facetType");
			XmlSchemaFacet.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668252);
			XmlSchemaFacet.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668253);
			XmlSchemaFacet.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668254);
			XmlSchemaFacet.NativeMethodInfoPtr_set_IsFixed_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668255);
			XmlSchemaFacet.NativeMethodInfoPtr_get_FacetType_Internal_get_FacetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668256);
			XmlSchemaFacet.NativeMethodInfoPtr_set_FacetType_Internal_set_Void_FacetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668257);
			XmlSchemaFacet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr, 100668258);
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000A2684 File Offset: 0x000A0884
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x000A26BC File Offset: 0x000A08BC
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000A2700 File Offset: 0x000A0900
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x000A2748 File Offset: 0x000A0948
		public unsafe virtual bool IsFixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaFacet.NativeMethodInfoPtr_get_IsFixed_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427556, XrefRangeEnd = 427560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaFacet.NativeMethodInfoPtr_set_IsFixed_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000A2794 File Offset: 0x000A0994
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x000A27D0 File Offset: 0x000A09D0
		public unsafe FacetType FacetType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_get_FacetType_Internal_get_FacetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr_set_FacetType_Internal_set_Void_FacetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000A2810 File Offset: 0x000A0A10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaFacet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaFacet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaFacet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0000F04C File Offset: 0x0000D24C
		public XmlSchemaFacet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000A284C File Offset: 0x000A0A4C
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x0000F055 File Offset: 0x0000D255
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000A2874 File Offset: 0x000A0A74
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x0000F074 File Offset: 0x0000D274
		public unsafe bool isFixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_isFixed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_isFixed)) = value;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x000A289C File Offset: 0x000A0A9C
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0000F08F File Offset: 0x0000D28F
		public unsafe FacetType facetType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_facetType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaFacet.NativeFieldInfoPtr_facetType)) = value;
			}
		}

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeFieldInfoPtr_isFixed;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr_facetType;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixed_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFixed_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetType_Internal_get_FacetType_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_set_FacetType_Internal_set_Void_FacetType_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
