using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000506 RID: 1286
	public class TraceLoggingDataCollector : Object
	{
		// Token: 0x06004B11 RID: 19217 RVA: 0x0015B19C File Offset: 0x0015939C
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggingDataCollector()
		{
			Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TraceLoggingDataCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr);
			TraceLoggingDataCollector.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, "Instance");
			TraceLoggingDataCollector.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674514);
			TraceLoggingDataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674515);
			TraceLoggingDataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674516);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674517);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674518);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674519);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674520);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674521);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674522);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674523);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674524);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674525);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674526);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674527);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674528);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674529);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674530);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674531);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674532);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674533);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674534);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674535);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674536);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674537);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674538);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674539);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674540);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674541);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674542);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674543);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674544);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674545);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674546);
			TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr, 100674547);
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x0015B488 File Offset: 0x00159688
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceLoggingDataCollector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceLoggingDataCollector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x0015B4C4 File Offset: 0x001596C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237439, RefRangeEnd = 237441, XrefRangeStart = 237435, XrefRangeEnd = 237439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BeginBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_BeginBufferedArray_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x0015B500 File Offset: 0x00159700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237445, RefRangeEnd = 237446, XrefRangeStart = 237441, XrefRangeEnd = 237445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndBufferedArray(int bookmark, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bookmark;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_EndBufferedArray_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x0015B54C File Offset: 0x0015974C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237446, XrefRangeEnd = 237450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x0015B58C File Offset: 0x0015978C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 237454, RefRangeEnd = 237477, XrefRangeStart = 237450, XrefRangeEnd = 237454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x0015B5CC File Offset: 0x001597CC
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 237481, RefRangeEnd = 237672, XrefRangeStart = 237477, XrefRangeEnd = 237481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x0015B60C File Offset: 0x0015980C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 237676, RefRangeEnd = 237699, XrefRangeStart = 237672, XrefRangeEnd = 237676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x0015B64C File Offset: 0x0015984C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 237703, RefRangeEnd = 237726, XrefRangeStart = 237699, XrefRangeEnd = 237703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x0015B68C File Offset: 0x0015988C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 237730, RefRangeEnd = 237753, XrefRangeStart = 237726, XrefRangeEnd = 237730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x0015B6CC File Offset: 0x001598CC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 237757, RefRangeEnd = 237780, XrefRangeStart = 237753, XrefRangeEnd = 237757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x0015B70C File Offset: 0x0015990C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 237784, RefRangeEnd = 237811, XrefRangeStart = 237780, XrefRangeEnd = 237784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x0015B74C File Offset: 0x0015994C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 237815, RefRangeEnd = 237838, XrefRangeStart = 237811, XrefRangeEnd = 237815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x0015B78C File Offset: 0x0015998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237838, XrefRangeEnd = 237842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(IntPtr value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x0015B7CC File Offset: 0x001599CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237842, XrefRangeEnd = 237849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(UIntPtr value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_UIntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x0015B80C File Offset: 0x00159A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237849, XrefRangeEnd = 237853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x0015B84C File Offset: 0x00159A4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237857, RefRangeEnd = 237859, XrefRangeStart = 237853, XrefRangeEnd = 237857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0015B88C File Offset: 0x00159A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237859, XrefRangeEnd = 237863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0015B8CC File Offset: 0x00159ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237863, XrefRangeEnd = 237867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(Guid value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddScalar_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x0015B90C File Offset: 0x00159B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237867, XrefRangeEnd = 237874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x0015B950 File Offset: 0x00159B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237874, XrefRangeEnd = 237881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddBinary_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x0015B994 File Offset: 0x00159B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237881, XrefRangeEnd = 237888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x0015B9D8 File Offset: 0x00159BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237888, XrefRangeEnd = 237895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<sbyte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0015BA1C File Offset: 0x00159C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237895, XrefRangeEnd = 237902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<short> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0015BA60 File Offset: 0x00159C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237902, XrefRangeEnd = 237909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<ushort> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x0015BAA4 File Offset: 0x00159CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237909, XrefRangeEnd = 237916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x0015BAE8 File Offset: 0x00159CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237916, XrefRangeEnd = 237923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<uint> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0015BB2C File Offset: 0x00159D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237923, XrefRangeEnd = 237930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<long> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0015BB70 File Offset: 0x00159D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237930, XrefRangeEnd = 237937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<ulong> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x0015BBB4 File Offset: 0x00159DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237937, XrefRangeEnd = 237944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<IntPtr> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x0015BBF8 File Offset: 0x00159DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237944, XrefRangeEnd = 237954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<UIntPtr> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UIntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x0015BC3C File Offset: 0x00159E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237954, XrefRangeEnd = 237961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x0015BC80 File Offset: 0x00159E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237961, XrefRangeEnd = 237968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<double> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x0015BCC4 File Offset: 0x00159EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237968, XrefRangeEnd = 237975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x0015BD08 File Offset: 0x00159F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237975, XrefRangeEnd = 237982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Il2CppStructArray<Guid> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceLoggingDataCollector.NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x0001BE10 File Offset: 0x0001A010
		public TraceLoggingDataCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x0015BD4C File Offset: 0x00159F4C
		// (set) Token: 0x06004B36 RID: 19254 RVA: 0x0001BE19 File Offset: 0x0001A019
		public unsafe static TraceLoggingDataCollector Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceLoggingDataCollector.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceLoggingDataCollector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceLoggingDataCollector.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C87 RID: 15495
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04003C88 RID: 15496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003C89 RID: 15497
		private static readonly IntPtr NativeMethodInfoPtr_BeginBufferedArray_Public_Int32_0;

		// Token: 0x04003C8A RID: 15498
		private static readonly IntPtr NativeMethodInfoPtr_EndBufferedArray_Public_Void_Int32_Int32_0;

		// Token: 0x04003C8B RID: 15499
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Boolean_0;

		// Token: 0x04003C8C RID: 15500
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_SByte_0;

		// Token: 0x04003C8D RID: 15501
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Byte_0;

		// Token: 0x04003C8E RID: 15502
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int16_0;

		// Token: 0x04003C8F RID: 15503
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UInt16_0;

		// Token: 0x04003C90 RID: 15504
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int32_0;

		// Token: 0x04003C91 RID: 15505
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UInt32_0;

		// Token: 0x04003C92 RID: 15506
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Int64_0;

		// Token: 0x04003C93 RID: 15507
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UInt64_0;

		// Token: 0x04003C94 RID: 15508
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_IntPtr_0;

		// Token: 0x04003C95 RID: 15509
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_UIntPtr_0;

		// Token: 0x04003C96 RID: 15510
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Single_0;

		// Token: 0x04003C97 RID: 15511
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Double_0;

		// Token: 0x04003C98 RID: 15512
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Char_0;

		// Token: 0x04003C99 RID: 15513
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Public_Void_Guid_0;

		// Token: 0x04003C9A RID: 15514
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Public_Void_String_0;

		// Token: 0x04003C9B RID: 15515
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003C9C RID: 15516
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Boolean_0;

		// Token: 0x04003C9D RID: 15517
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_SByte_0;

		// Token: 0x04003C9E RID: 15518
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int16_0;

		// Token: 0x04003C9F RID: 15519
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04003CA0 RID: 15520
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003CA1 RID: 15521
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04003CA2 RID: 15522
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Int64_0;

		// Token: 0x04003CA3 RID: 15523
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UInt64_0;

		// Token: 0x04003CA4 RID: 15524
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_IntPtr_0;

		// Token: 0x04003CA5 RID: 15525
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_UIntPtr_0;

		// Token: 0x04003CA6 RID: 15526
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x04003CA7 RID: 15527
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Double_0;

		// Token: 0x04003CA8 RID: 15528
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04003CA9 RID: 15529
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Public_Void_Il2CppStructArray_1_Guid_0;
	}
}
