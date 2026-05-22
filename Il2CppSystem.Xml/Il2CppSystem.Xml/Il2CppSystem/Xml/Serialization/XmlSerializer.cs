using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E0 RID: 224
	public class XmlSerializer : Object
	{
		// Token: 0x06001322 RID: 4898 RVA: 0x000667A8 File Offset: 0x000649A8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializer()
		{
			Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializer");
			XmlSerializer.NativeFieldInfoPtr_generationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "generationThreshold");
			XmlSerializer.NativeFieldInfoPtr_backgroundGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "backgroundGeneration");
			XmlSerializer.NativeFieldInfoPtr_deleteTempFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "deleteTempFiles");
			XmlSerializer.NativeFieldInfoPtr_generatorFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "generatorFallback");
			XmlSerializer.NativeFieldInfoPtr_customSerializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "customSerializer");
			XmlSerializer.NativeFieldInfoPtr_typeMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "typeMapping");
			XmlSerializer.NativeFieldInfoPtr_serializerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "serializerData");
			XmlSerializer.NativeFieldInfoPtr_serializerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "serializerTypes");
			XmlSerializer.NativeFieldInfoPtr_DefaultEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "DefaultEncoding");
			XmlSerializer.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666294);
			XmlSerializer.NativeMethodInfoPtr__ctor_Public_Void_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666295);
			XmlSerializer.NativeMethodInfoPtr_CreateWriter_Protected_Virtual_New_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666296);
			XmlSerializer.NativeMethodInfoPtr_Serialize_Protected_Virtual_New_Void_Object_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666297);
			XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666298);
			XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_XmlSerializerNamespaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666299);
			XmlSerializer.NativeMethodInfoPtr_CreateWriter_Private_XmlSerializationWriter_XmlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, 100666300);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00066910 File Offset: 0x00064B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407285, XrefRangeEnd = 407286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializer(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0006695C File Offset: 0x00064B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407296, RefRangeEnd = 407298, XrefRangeStart = 407286, XrefRangeEnd = 407296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializer(Type type, XmlAttributeOverrides overrides, Il2CppReferenceArray<Type> extraTypes, XmlRootAttribute root, string defaultNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrides);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr__ctor_Public_Void_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000669F4 File Offset: 0x00064BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407298, XrefRangeEnd = 407303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSerializationWriter CreateWriter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_CreateWriter_Protected_Virtual_New_XmlSerializationWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00066A40 File Offset: 0x00064C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407303, XrefRangeEnd = 407307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Serialize(Object o, XmlSerializationWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializer.NativeMethodInfoPtr_Serialize_Protected_Virtual_New_Void_Object_XmlSerializationWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00066AA0 File Offset: 0x00064CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407307, XrefRangeEnd = 407312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(TextWriter textWriter, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00066AF4 File Offset: 0x00064CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 407336, RefRangeEnd = 407338, XrefRangeStart = 407312, XrefRangeEnd = 407336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(XmlWriter xmlWriter, Object o, XmlSerializerNamespaces namespaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaces);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_XmlSerializerNamespaces_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00066B5C File Offset: 0x00064D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407355, RefRangeEnd = 407356, XrefRangeStart = 407338, XrefRangeEnd = 407355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationWriter CreateWriter(XmlMapping typeMapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeMapping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.NativeMethodInfoPtr_CreateWriter_Private_XmlSerializationWriter_XmlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0000876B File Offset: 0x0000696B
		public XmlSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00066BAC File Offset: 0x00064DAC
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x00008774 File Offset: 0x00006974
		public unsafe static int generationThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_generationThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_generationThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00066BC8 File Offset: 0x00064DC8
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x00008782 File Offset: 0x00006982
		public unsafe static bool backgroundGeneration
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_backgroundGeneration, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_backgroundGeneration, (void*)(&value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00066BE4 File Offset: 0x00064DE4
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00008790 File Offset: 0x00006990
		public unsafe static bool deleteTempFiles
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_deleteTempFiles, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_deleteTempFiles, (void*)(&value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00066C00 File Offset: 0x00064E00
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x0000879E File Offset: 0x0000699E
		public unsafe static bool generatorFallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_generatorFallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_generatorFallback, (void*)(&value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00066C1C File Offset: 0x00064E1C
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x000087AC File Offset: 0x000069AC
		public unsafe bool customSerializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_customSerializer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_customSerializer)) = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x00066C44 File Offset: 0x00064E44
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x000087C7 File Offset: 0x000069C7
		public unsafe XmlMapping typeMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_typeMapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_typeMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00066C74 File Offset: 0x00064E74
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x000087E6 File Offset: 0x000069E6
		public unsafe XmlSerializer.SerializerData serializerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_serializerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializer.SerializerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.NativeFieldInfoPtr_serializerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00066CA4 File Offset: 0x00064EA4
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00008805 File Offset: 0x00006A05
		public unsafe static Hashtable serializerTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_serializerTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_serializerTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00066CCC File Offset: 0x00064ECC
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00008817 File Offset: 0x00006A17
		public unsafe static Encoding DefaultEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializer.NativeFieldInfoPtr_DefaultEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializer.NativeFieldInfoPtr_DefaultEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeFieldInfoPtr_generationThreshold;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeFieldInfoPtr_backgroundGeneration;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeFieldInfoPtr_deleteTempFiles;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeFieldInfoPtr_generatorFallback;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeFieldInfoPtr_customSerializer;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeFieldInfoPtr_typeMapping;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeFieldInfoPtr_serializerData;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeFieldInfoPtr_serializerTypes;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeFieldInfoPtr_DefaultEncoding;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Protected_Virtual_New_XmlSerializationWriter_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Protected_Virtual_New_Void_Object_XmlSerializationWriter_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_XmlWriter_Object_XmlSerializerNamespaces_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Private_XmlSerializationWriter_XmlMapping_0;

		// Token: 0x0200022B RID: 555
		public class SerializerData : Object
		{
			// Token: 0x06002C1E RID: 11294 RVA: 0x000C59C0 File Offset: 0x000C3BC0
			// Note: this type is marked as 'beforefieldinit'.
			static SerializerData()
			{
				Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSerializer>.NativeClassPtr, "SerializerData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr);
				XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, "WriterType");
				XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, "WriterMethod");
				XmlSerializer.SerializerData.NativeFieldInfoPtr_Implementation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, "Implementation");
				XmlSerializer.SerializerData.NativeMethodInfoPtr_CreateWriter_Public_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializer.SerializerData>.NativeClassPtr, 100666301);
			}

			// Token: 0x06002C1F RID: 11295 RVA: 0x000C5A3C File Offset: 0x000C3C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407281, XrefRangeEnd = 407285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlSerializationWriter CreateWriter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializer.SerializerData.NativeMethodInfoPtr_CreateWriter_Public_XmlSerializationWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
			}

			// Token: 0x06002C20 RID: 11296 RVA: 0x00012E9D File Offset: 0x0001109D
			public SerializerData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F09 RID: 3849
			// (get) Token: 0x06002C21 RID: 11297 RVA: 0x000C5A7C File Offset: 0x000C3C7C
			// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00012EA6 File Offset: 0x000110A6
			public unsafe Type WriterType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F0A RID: 3850
			// (get) Token: 0x06002C23 RID: 11299 RVA: 0x000C5AAC File Offset: 0x000C3CAC
			// (set) Token: 0x06002C24 RID: 11300 RVA: 0x00012EC5 File Offset: 0x000110C5
			public unsafe MethodInfo WriterMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_WriterMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F0B RID: 3851
			// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000C5ADC File Offset: 0x000C3CDC
			// (set) Token: 0x06002C26 RID: 11302 RVA: 0x00012EE4 File Offset: 0x000110E4
			public unsafe XmlSerializerImplementation Implementation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_Implementation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSerializerImplementation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializer.SerializerData.NativeFieldInfoPtr_Implementation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400226B RID: 8811
			private static readonly IntPtr NativeFieldInfoPtr_WriterType;

			// Token: 0x0400226C RID: 8812
			private static readonly IntPtr NativeFieldInfoPtr_WriterMethod;

			// Token: 0x0400226D RID: 8813
			private static readonly IntPtr NativeFieldInfoPtr_Implementation;

			// Token: 0x0400226E RID: 8814
			private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Public_XmlSerializationWriter_0;
		}
	}
}
