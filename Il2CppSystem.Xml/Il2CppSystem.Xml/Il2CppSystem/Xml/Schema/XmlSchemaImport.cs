using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BC RID: 444
	public class XmlSchemaImport : XmlSchemaExternal
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x000A405C File Offset: 0x000A225C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaImport()
		{
			Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaImport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr);
			XmlSchemaImport.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, "ns");
			XmlSchemaImport.NativeFieldInfoPtr_annotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, "annotation");
			XmlSchemaImport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668318);
			XmlSchemaImport.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668319);
			XmlSchemaImport.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668320);
			XmlSchemaImport.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668321);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000A4104 File Offset: 0x000A2304
		[CallerCount(0)]
		public unsafe XmlSchemaImport()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaImport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x000A4140 File Offset: 0x000A2340
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x000A4178 File Offset: 0x000A2378
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaImport.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaImport.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x000A41BC File Offset: 0x000A23BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaImport.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0000F6AA File Offset: 0x0000D8AA
		public XmlSchemaImport(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x000A420C File Offset: 0x000A240C
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x0000F6B3 File Offset: 0x0000D8B3
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x000A4234 File Offset: 0x000A2434
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x0000F6D2 File Offset: 0x0000D8D2
		public unsafe XmlSchemaAnnotation annotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_annotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_annotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeFieldInfoPtr_annotation;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;
	}
}
