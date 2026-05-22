using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200008C RID: 140
	public class ReaderPositionInfo : PositionInfo
	{
		// Token: 0x06000E38 RID: 3640 RVA: 0x00051300 File Offset: 0x0004F500
		// Note: this type is marked as 'beforefieldinit'.
		static ReaderPositionInfo()
		{
			Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ReaderPositionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr);
			ReaderPositionInfo.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, "lineInfo");
			ReaderPositionInfo.NativeMethodInfoPtr__ctor_Public_Void_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, 100665555);
			ReaderPositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, 100665556);
			ReaderPositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, 100665557);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00051380 File Offset: 0x0004F580
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderPositionInfo(IXmlLineInfo lineInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderPositionInfo.NativeMethodInfoPtr__ctor_Public_Void_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000513CC File Offset: 0x0004F5CC
		public unsafe override int LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399133, XrefRangeEnd = 399137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReaderPositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00051414 File Offset: 0x0004F614
		public unsafe override int LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399137, XrefRangeEnd = 399141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReaderPositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00006D32 File Offset: 0x00004F32
		public ReaderPositionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0005145C File Offset: 0x0004F65C
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00006D3B File Offset: 0x00004F3B
		public unsafe IXmlLineInfo lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderPositionInfo.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderPositionInfo.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IXmlLineInfo_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_get_Int32_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_get_Int32_0;
	}
}
