using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.XmlConfiguration
{
	// Token: 0x020001EE RID: 494
	public sealed class XmlReaderSection : Object
	{
		// Token: 0x060029B6 RID: 10678 RVA: 0x000BEB98 File Offset: 0x000BCD98
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReaderSection()
		{
			Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XmlConfiguration", "XmlReaderSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr);
			XmlReaderSection.NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100669254);
			XmlReaderSection.NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100669255);
			XmlReaderSection.NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100669256);
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x000BEC04 File Offset: 0x000BCE04
		public unsafe static bool ProhibitDefaultUrlResolver
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000BEC34 File Offset: 0x000BCE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439357, XrefRangeEnd = 439360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlResolver CreateDefaultResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000BEC68 File Offset: 0x000BCE68
		public unsafe static bool CollapseWhiteSpaceIntoEmptyString
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00011964 File Offset: 0x0000FB64
		public XmlReaderSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0;
	}
}
