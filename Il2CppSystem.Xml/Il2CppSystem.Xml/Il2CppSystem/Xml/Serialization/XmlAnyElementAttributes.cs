using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C5 RID: 197
	[DefaultMember("Item")]
	public class XmlAnyElementAttributes : CollectionBase
	{
		// Token: 0x06001186 RID: 4486 RVA: 0x0005FF28 File Offset: 0x0005E128
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyElementAttributes()
		{
			Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAnyElementAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr);
			XmlAnyElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666085);
			XmlAnyElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666086);
			XmlAnyElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666087);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0005FF94 File Offset: 0x0005E194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404725, XrefRangeEnd = 404729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlAnyElementAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0005FFE4 File Offset: 0x0005E1E4
		public unsafe int Order
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404729, XrefRangeEnd = 404744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00060020 File Offset: 0x0005E220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyElementAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00007C68 File Offset: 0x00005E68
		public XmlAnyElementAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Int32_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
