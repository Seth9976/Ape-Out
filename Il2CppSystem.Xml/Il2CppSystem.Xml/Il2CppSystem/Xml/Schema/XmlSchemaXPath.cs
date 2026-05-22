using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B8 RID: 440
	public class XmlSchemaXPath : XmlSchemaAnnotated
	{
		// Token: 0x0600233E RID: 9022 RVA: 0x000A3D14 File Offset: 0x000A1F14
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaXPath()
		{
			Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaXPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr);
			XmlSchemaXPath.NativeFieldInfoPtr_xpath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, "xpath");
			XmlSchemaXPath.NativeMethodInfoPtr_get_XPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, 100668310);
			XmlSchemaXPath.NativeMethodInfoPtr_set_XPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, 100668311);
			XmlSchemaXPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr, 100668312);
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000A3D94 File Offset: 0x000A1F94
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x000A3DCC File Offset: 0x000A1FCC
		public unsafe string XPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaXPath.NativeMethodInfoPtr_get_XPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaXPath.NativeMethodInfoPtr_set_XPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000A3E10 File Offset: 0x000A2010
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaXPath()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaXPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaXPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0000F5D6 File Offset: 0x0000D7D6
		public XmlSchemaXPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000A3E4C File Offset: 0x000A204C
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x0000F5DF File Offset: 0x0000D7DF
		public unsafe string xpath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaXPath.NativeFieldInfoPtr_xpath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaXPath.NativeFieldInfoPtr_xpath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeFieldInfoPtr_xpath;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_get_XPath_Public_get_String_0;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_set_XPath_Public_set_Void_String_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
