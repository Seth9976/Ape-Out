using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.HID
{
	// Token: 0x02000115 RID: 277
	[StructLayout(2)]
	public struct OutputReport
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x00093B5C File Offset: 0x00091D5C
		// Note: this type is marked as 'beforefieldinit'.
		static OutputReport()
		{
			Il2CppClassPointerStore<OutputReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID", "OutputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputReport>.NativeClassPtr);
			OutputReport.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, "buffer");
			OutputReport.NativeFieldInfoPtr_bufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, "bufferLength");
			OutputReport.NativeFieldInfoPtr_reportLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, "reportLength");
			OutputReport.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, "options");
			OutputReport.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, 100669502);
			OutputReport.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, 100669503);
			OutputReport.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, 100669504);
			OutputReport.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, 100669505);
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x00093C2C File Offset: 0x00091E2C
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279073, XrefRangeEnd = 279074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputReport.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00093C5C File Offset: 0x00091E5C
		[CallerCount(0)]
		public unsafe OutputReport(IntPtr buffer, int bufferLength, int reportLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reportLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputReport.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00093CAC File Offset: 0x00091EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279074, XrefRangeEnd = 279075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputReport.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00093CD4 File Offset: 0x00091ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279075, XrefRangeEnd = 279165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutputReport.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutputReport>.NativeClassPtr, ref this));
		}

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeFieldInfoPtr_bufferLength;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr_reportLength;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016B2 RID: 5810
		[FieldOffset(0)]
		public IntPtr buffer;

		// Token: 0x040016B3 RID: 5811
		[FieldOffset(8)]
		public int bufferLength;

		// Token: 0x040016B4 RID: 5812
		[FieldOffset(12)]
		public int reportLength;

		// Token: 0x040016B5 RID: 5813
		[FieldOffset(16)]
		public OutputReportOptions options;
	}
}
