using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F0 RID: 240
	public class XmlSerializableMapping : XmlTypeMapping
	{
		// Token: 0x0600141A RID: 5146 RVA: 0x00069B4C File Offset: 0x00067D4C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializableMapping()
		{
			Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializableMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr);
			XmlSerializableMapping.NativeFieldInfoPtr__schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, "_schema");
			XmlSerializableMapping.NativeFieldInfoPtr__schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, "_schemaType");
			XmlSerializableMapping.NativeFieldInfoPtr__schemaTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, "_schemaTypeName");
			XmlSerializableMapping.NativeMethodInfoPtr__ctor_Internal_Void_XmlRootAttribute_String_String_TypeData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr, 100666403);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00069BCC File Offset: 0x00067DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407685, RefRangeEnd = 407686, XrefRangeStart = 407612, XrefRangeEnd = 407685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializableMapping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlTypeNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializableMapping.NativeMethodInfoPtr__ctor_Internal_Void_XmlRootAttribute_String_String_TypeData_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00008EFC File Offset: 0x000070FC
		public XmlSerializableMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00069C74 File Offset: 0x00067E74
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x00008F05 File Offset: 0x00007105
		public unsafe XmlSchema _schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00069CA4 File Offset: 0x00067EA4
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x00008F24 File Offset: 0x00007124
		public unsafe XmlSchemaComplexType _schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00069CD4 File Offset: 0x00067ED4
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x00008F43 File Offset: 0x00007143
		public unsafe XmlQualifiedName _schemaTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializableMapping.NativeFieldInfoPtr__schemaTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeFieldInfoPtr__schema;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeFieldInfoPtr__schemaType;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeFieldInfoPtr__schemaTypeName;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlRootAttribute_String_String_TypeData_String_String_0;
	}
}
