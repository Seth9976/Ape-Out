using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D3 RID: 211
	public class XmlMapping : Object
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x0006226C File Offset: 0x0006046C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlMapping()
		{
			Il2CppClassPointerStore<XmlMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr);
			XmlMapping.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "map");
			XmlMapping.NativeFieldInfoPtr_relatedMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "relatedMaps");
			XmlMapping.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "format");
			XmlMapping.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "_elementName");
			XmlMapping.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "_namespace");
			XmlMapping.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, "key");
			XmlMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666153);
			XmlMapping.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666154);
			XmlMapping.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666155);
			XmlMapping.NativeMethodInfoPtr_SetKey_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666156);
			XmlMapping.NativeMethodInfoPtr_get_ObjectMap_Internal_get_ObjectMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666157);
			XmlMapping.NativeMethodInfoPtr_set_ObjectMap_Internal_set_Void_ObjectMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666158);
			XmlMapping.NativeMethodInfoPtr_get_RelatedMaps_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666159);
			XmlMapping.NativeMethodInfoPtr_set_RelatedMaps_Internal_set_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666160);
			XmlMapping.NativeMethodInfoPtr_get_Format_Internal_get_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666161);
			XmlMapping.NativeMethodInfoPtr_set_Format_Internal_set_Void_SerializationFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr, 100666162);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000623DC File Offset: 0x000605DC
		[CallerCount(0)]
		public unsafe XmlMapping(string elementName, string ns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlMapping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0006243C File Offset: 0x0006063C
		public unsafe string ElementName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00062474 File Offset: 0x00060674
		public unsafe string Namespace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000624AC File Offset: 0x000606AC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_SetKey_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000624F0 File Offset: 0x000606F0
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00062530 File Offset: 0x00060730
		public unsafe ObjectMap ObjectMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_ObjectMap_Internal_get_ObjectMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_set_ObjectMap_Internal_set_Void_ObjectMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00062574 File Offset: 0x00060774
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x000625B4 File Offset: 0x000607B4
		public unsafe ArrayList RelatedMaps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_RelatedMaps_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_set_RelatedMaps_Internal_set_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000625F8 File Offset: 0x000607F8
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00062634 File Offset: 0x00060834
		public unsafe SerializationFormat Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_get_Format_Internal_get_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMapping.NativeMethodInfoPtr_set_Format_Internal_set_Void_SerializationFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00008213 File Offset: 0x00006413
		public XmlMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00062674 File Offset: 0x00060874
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x0000821C File Offset: 0x0000641C
		public unsafe ObjectMap map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000626A4 File Offset: 0x000608A4
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x0000823B File Offset: 0x0000643B
		public unsafe ArrayList relatedMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_relatedMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_relatedMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000626D4 File Offset: 0x000608D4
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x0000825A File Offset: 0x0000645A
		public unsafe SerializationFormat format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_format);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_format)) = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000626FC File Offset: 0x000608FC
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x00008275 File Offset: 0x00006475
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00062724 File Offset: 0x00060924
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x00008294 File Offset: 0x00006494
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0006274C File Offset: 0x0006094C
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x000082B3 File Offset: 0x000064B3
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMapping.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_relatedMaps;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_SetKey_Public_Void_String_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectMap_Internal_get_ObjectMap_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectMap_Internal_set_Void_ObjectMap_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_get_RelatedMaps_Internal_get_ArrayList_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_set_RelatedMaps_Internal_set_Void_ArrayList_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Internal_get_SerializationFormat_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Internal_set_Void_SerializationFormat_0;
	}
}
