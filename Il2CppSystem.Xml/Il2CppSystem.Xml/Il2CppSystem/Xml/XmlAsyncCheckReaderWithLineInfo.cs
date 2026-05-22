using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000048 RID: 72
	public class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x000230B8 File Offset: 0x000212B8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAsyncCheckReaderWithLineInfo()
		{
			Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAsyncCheckReaderWithLineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr);
			XmlAsyncCheckReaderWithLineInfo.NativeFieldInfoPtr_readerAsIXmlLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, "readerAsIXmlLineInfo");
			XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, 100663800);
			XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, 100663801);
			XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr, 100663802);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00023138 File Offset: 0x00021338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390452, RefRangeEnd = 390453, XrefRangeStart = 390447, XrefRangeEnd = 390452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAsyncCheckReaderWithLineInfo(XmlReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAsyncCheckReaderWithLineInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00023184 File Offset: 0x00021384
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390453, XrefRangeEnd = 390457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000231CC File Offset: 0x000213CC
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390457, XrefRangeEnd = 390461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAsyncCheckReaderWithLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003504 File Offset: 0x00001704
		public XmlAsyncCheckReaderWithLineInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00023214 File Offset: 0x00021414
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0000350D File Offset: 0x0000170D
		public unsafe IXmlLineInfo readerAsIXmlLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfo.NativeFieldInfoPtr_readerAsIXmlLineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAsyncCheckReaderWithLineInfo.NativeFieldInfoPtr_readerAsIXmlLineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_readerAsIXmlLineInfo;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlReader_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0;
	}
}
