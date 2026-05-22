using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000066 RID: 102
	public class AttributePSVIInfo : Object
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x0004038C File Offset: 0x0003E58C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributePSVIInfo()
		{
			Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "AttributePSVIInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr);
			AttributePSVIInfo.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "localName");
			AttributePSVIInfo.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "namespaceUri");
			AttributePSVIInfo.NativeFieldInfoPtr_typedAttributeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "typedAttributeValue");
			AttributePSVIInfo.NativeFieldInfoPtr_attributeSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "attributeSchemaInfo");
			AttributePSVIInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, 100664959);
			AttributePSVIInfo.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, 100664960);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00040434 File Offset: 0x0003E634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396934, RefRangeEnd = 396936, XrefRangeStart = 396930, XrefRangeEnd = 396934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePSVIInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributePSVIInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00040470 File Offset: 0x0003E670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396941, RefRangeEnd = 396942, XrefRangeStart = 396936, XrefRangeEnd = 396941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributePSVIInfo.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000058F5 File Offset: 0x00003AF5
		public AttributePSVIInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000404A4 File Offset: 0x0003E6A4
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x000058FE File Offset: 0x00003AFE
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000404CC File Offset: 0x0003E6CC
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x0000591D File Offset: 0x00003B1D
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x000404F4 File Offset: 0x0003E6F4
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x0000593C File Offset: 0x00003B3C
		public unsafe Object typedAttributeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_typedAttributeValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_typedAttributeValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00040524 File Offset: 0x0003E724
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0000595B File Offset: 0x00003B5B
		public unsafe XmlSchemaInfo attributeSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_attributeSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_attributeSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr_typedAttributeValue;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_attributeSchemaInfo;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;
	}
}
