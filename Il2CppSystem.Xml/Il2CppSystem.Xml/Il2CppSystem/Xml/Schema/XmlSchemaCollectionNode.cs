using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000193 RID: 403
	public sealed class XmlSchemaCollectionNode : Object
	{
		// Token: 0x06002150 RID: 8528 RVA: 0x0009C950 File Offset: 0x0009AB50
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaCollectionNode()
		{
			Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCollectionNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr);
			XmlSchemaCollectionNode.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, "namespaceUri");
			XmlSchemaCollectionNode.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, "schemaInfo");
			XmlSchemaCollectionNode.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, "schema");
			XmlSchemaCollectionNode.NativeMethodInfoPtr_set_NamespaceURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668048);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_get_SchemaInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668049);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_set_SchemaInfo_Internal_set_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668050);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_get_Schema_Internal_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668051);
			XmlSchemaCollectionNode.NativeMethodInfoPtr_set_Schema_Internal_set_Void_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668052);
			XmlSchemaCollectionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr, 100668053);
		}

		// Token: 0x17000B99 RID: 2969
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x0009CA34 File Offset: 0x0009AC34
		public unsafe string NamespaceURI
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_set_NamespaceURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x0009CA78 File Offset: 0x0009AC78
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x0009CAB8 File Offset: 0x0009ACB8
		public unsafe SchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_get_SchemaInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_set_SchemaInfo_Internal_set_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x0009CAFC File Offset: 0x0009ACFC
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x0009CB3C File Offset: 0x0009AD3C
		public unsafe XmlSchema Schema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_get_Schema_Internal_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr_set_Schema_Internal_set_Void_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0009CB80 File Offset: 0x0009AD80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaCollectionNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCollectionNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollectionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0000E7D9 File Offset: 0x0000C9D9
		public XmlSchemaCollectionNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x0009CBBC File Offset: 0x0009ADBC
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x0000E7E2 File Offset: 0x0000C9E2
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x0009CBE4 File Offset: 0x0009ADE4
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x0000E801 File Offset: 0x0000CA01
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0009CC14 File Offset: 0x0009AE14
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x0000E820 File Offset: 0x0000CA20
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollectionNode.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_set_NamespaceURI_Internal_set_Void_String_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Internal_get_SchemaInfo_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaInfo_Internal_set_Void_SchemaInfo_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_get_Schema_Internal_get_XmlSchema_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_set_Schema_Internal_set_Void_XmlSchema_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
