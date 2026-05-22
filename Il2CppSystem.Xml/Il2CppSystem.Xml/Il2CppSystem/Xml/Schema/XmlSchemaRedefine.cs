using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C4 RID: 452
	public class XmlSchemaRedefine : XmlSchemaExternal
	{
		// Token: 0x060023F9 RID: 9209 RVA: 0x000A69A0 File Offset: 0x000A4BA0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaRedefine()
		{
			Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaRedefine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr);
			XmlSchemaRedefine.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "items");
			XmlSchemaRedefine.NativeFieldInfoPtr_attributeGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "attributeGroups");
			XmlSchemaRedefine.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "types");
			XmlSchemaRedefine.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, "groups");
			XmlSchemaRedefine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668431);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668432);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668433);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668434);
			XmlSchemaRedefine.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668435);
			XmlSchemaRedefine.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr, 100668436);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x000A6A98 File Offset: 0x000A4C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428258, RefRangeEnd = 428259, XrefRangeStart = 428244, XrefRangeEnd = 428258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaRedefine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaRedefine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000A6AD4 File Offset: 0x000A4CD4
		public unsafe XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x000A6B14 File Offset: 0x000A4D14
		public unsafe XmlSchemaObjectTable AttributeGroups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x000A6B54 File Offset: 0x000A4D54
		public unsafe XmlSchemaObjectTable SchemaTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x000A6B94 File Offset: 0x000A4D94
		public unsafe XmlSchemaObjectTable Groups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaRedefine.NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428259, XrefRangeEnd = 428263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaRedefine.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0000FA21 File Offset: 0x0000DC21
		public XmlSchemaRedefine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000A6C24 File Offset: 0x000A4E24
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0000FA2A File Offset: 0x0000DC2A
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000A6C54 File Offset: 0x000A4E54
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0000FA49 File Offset: 0x0000DC49
		public unsafe XmlSchemaObjectTable attributeGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_attributeGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_attributeGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000A6C84 File Offset: 0x000A4E84
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0000FA68 File Offset: 0x0000DC68
		public unsafe XmlSchemaObjectTable types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000A6CB4 File Offset: 0x000A4EB4
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0000FA87 File Offset: 0x0000DC87
		public unsafe XmlSchemaObjectTable groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaRedefine.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeFieldInfoPtr_attributeGroups;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeFieldInfoPtr_types;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeGroups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypes_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;
	}
}
