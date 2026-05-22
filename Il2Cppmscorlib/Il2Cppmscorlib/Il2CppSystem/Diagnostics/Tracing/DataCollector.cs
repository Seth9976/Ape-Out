using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C5 RID: 1221
	public sealed class DataCollector : ValueType
	{
		// Token: 0x06004932 RID: 18738 RVA: 0x00153108 File Offset: 0x00151308
		// Note: this type is marked as 'beforefieldinit'.
		static DataCollector()
		{
			Il2CppClassPointerStore<DataCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "DataCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataCollector>.NativeClassPtr);
			DataCollector.NativeFieldInfoPtr_ThreadInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "ThreadInstance");
			DataCollector.NativeFieldInfoPtr_scratchEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "scratchEnd");
			DataCollector.NativeFieldInfoPtr_datasEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "datasEnd");
			DataCollector.NativeFieldInfoPtr_pinsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "pinsEnd");
			DataCollector.NativeFieldInfoPtr_datasStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "datasStart");
			DataCollector.NativeFieldInfoPtr_scratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "scratch");
			DataCollector.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "datas");
			DataCollector.NativeFieldInfoPtr_pins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "pins");
			DataCollector.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "buffer");
			DataCollector.NativeFieldInfoPtr_bufferPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "bufferPos");
			DataCollector.NativeFieldInfoPtr_bufferNesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "bufferNesting");
			DataCollector.NativeFieldInfoPtr_writingScalars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, "writingScalars");
			DataCollector.NativeMethodInfoPtr_Enable_Internal_Void_ptr_Byte_Int32_ptr_EventData_Int32_ptr_GCHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674249);
			DataCollector.NativeMethodInfoPtr_Disable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674250);
			DataCollector.NativeMethodInfoPtr_Finish_Internal_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674251);
			DataCollector.NativeMethodInfoPtr_AddScalar_Internal_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674252);
			DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674253);
			DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674254);
			DataCollector.NativeMethodInfoPtr_AddArray_Internal_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674255);
			DataCollector.NativeMethodInfoPtr_BeginBufferedArray_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674256);
			DataCollector.NativeMethodInfoPtr_EndBufferedArray_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674257);
			DataCollector.NativeMethodInfoPtr_BeginBuffered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674258);
			DataCollector.NativeMethodInfoPtr_EndBuffered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674259);
			DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674260);
			DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674261);
			DataCollector.NativeMethodInfoPtr_GrowBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674262);
			DataCollector.NativeMethodInfoPtr_PinArray_Private_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674263);
			DataCollector.NativeMethodInfoPtr_ScalarsBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674264);
			DataCollector.NativeMethodInfoPtr_ScalarsEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, 100674265);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x0015337C File Offset: 0x0015157C
		[CallerCount(0)]
		public unsafe void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = scratch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scratchSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = datas;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pins;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_Enable_Internal_Void_ptr_Byte_Int32_ptr_EventData_Int32_ptr_GCHandle_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x00153404 File Offset: 0x00151604
		[CallerCount(0)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_Disable_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x0015343C File Offset: 0x0015163C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233520, XrefRangeEnd = 233521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource.EventData* Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_Finish_Internal_ptr_EventData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00153474 File Offset: 0x00151674
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 233525, RefRangeEnd = 233547, XrefRangeStart = 233521, XrefRangeEnd = 233525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScalar(void* value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddScalar_Internal_Void_ptr_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x001534C4 File Offset: 0x001516C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233556, RefRangeEnd = 233558, XrefRangeStart = 233547, XrefRangeEnd = 233556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(string value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x0015351C File Offset: 0x0015171C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233558, XrefRangeEnd = 233559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinary(Array value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddBinary_Internal_Void_Array_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00153574 File Offset: 0x00151774
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 233565, RefRangeEnd = 233596, XrefRangeStart = 233559, XrefRangeEnd = 233565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArray(Array value, int length, int itemSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_AddArray_Internal_Void_Array_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x001535D8 File Offset: 0x001517D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233596, XrefRangeEnd = 233597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BeginBufferedArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_BeginBufferedArray_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x0015361C File Offset: 0x0015181C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233604, RefRangeEnd = 233605, XrefRangeStart = 233597, XrefRangeEnd = 233604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EndBufferedArray_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00153670 File Offset: 0x00151870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233605, XrefRangeEnd = 233606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBuffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_BeginBuffered_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x001536A8 File Offset: 0x001518A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233608, RefRangeEnd = 233610, XrefRangeStart = 233606, XrefRangeEnd = 233608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndBuffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EndBuffered_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001536E0 File Offset: 0x001518E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 233612, RefRangeEnd = 233618, XrefRangeStart = 233610, XrefRangeEnd = 233612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00153718 File Offset: 0x00151918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233618, XrefRangeEnd = 233620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureBuffer(int additionalSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref additionalSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_EnsureBuffer_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x0015375C File Offset: 0x0015195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233620, XrefRangeEnd = 233622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowBuffer(int required)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref required;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_GrowBuffer_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x001537A0 File Offset: 0x001519A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233629, RefRangeEnd = 233630, XrefRangeStart = 233622, XrefRangeEnd = 233629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PinArray(Object value, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_PinArray_Private_Void_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x001537F8 File Offset: 0x001519F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233633, RefRangeEnd = 233634, XrefRangeStart = 233630, XrefRangeEnd = 233633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScalarsBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_ScalarsBegin_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x00153830 File Offset: 0x00151A30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 233635, RefRangeEnd = 233640, XrefRangeStart = 233634, XrefRangeEnd = 233635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScalarsEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCollector.NativeMethodInfoPtr_ScalarsEnd_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x0001B5C6 File Offset: 0x000197C6
		public DataCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x0001B5CF File Offset: 0x000197CF
		public DataCollector()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataCollector>.NativeClassPtr))
		{
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x00153868 File Offset: 0x00151A68
		// (set) Token: 0x06004947 RID: 18759 RVA: 0x0001B5E1 File Offset: 0x000197E1
		public unsafe static DataCollector ThreadInstance
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(DataCollector.NativeFieldInfoPtr_ThreadInstance, intPtr);
				return new DataCollector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataCollector>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataCollector.NativeFieldInfoPtr_ThreadInstance, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06004948 RID: 18760 RVA: 0x001538A4 File Offset: 0x00151AA4
		// (set) Token: 0x06004949 RID: 18761 RVA: 0x0001B5F8 File Offset: 0x000197F8
		public unsafe byte* scratchEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratchEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratchEnd)) = value;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x001538C8 File Offset: 0x00151AC8
		// (set) Token: 0x0600494B RID: 18763 RVA: 0x0001B613 File Offset: 0x00019813
		public unsafe EventSource.EventData* datasEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasEnd)) = value;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x001538EC File Offset: 0x00151AEC
		// (set) Token: 0x0600494D RID: 18765 RVA: 0x0001B62E File Offset: 0x0001982E
		public unsafe GCHandle* pinsEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pinsEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pinsEnd)) = value;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x00153910 File Offset: 0x00151B10
		// (set) Token: 0x0600494F RID: 18767 RVA: 0x0001B649 File Offset: 0x00019849
		public unsafe EventSource.EventData* datasStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datasStart)) = value;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06004950 RID: 18768 RVA: 0x00153934 File Offset: 0x00151B34
		// (set) Token: 0x06004951 RID: 18769 RVA: 0x0001B664 File Offset: 0x00019864
		public unsafe byte* scratch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_scratch)) = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06004952 RID: 18770 RVA: 0x00153958 File Offset: 0x00151B58
		// (set) Token: 0x06004953 RID: 18771 RVA: 0x0001B67F File Offset: 0x0001987F
		public unsafe EventSource.EventData* datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datas);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_datas)) = value;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x0015397C File Offset: 0x00151B7C
		// (set) Token: 0x06004955 RID: 18773 RVA: 0x0001B69A File Offset: 0x0001989A
		public unsafe GCHandle* pins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_pins)) = value;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06004956 RID: 18774 RVA: 0x001539A0 File Offset: 0x00151BA0
		// (set) Token: 0x06004957 RID: 18775 RVA: 0x0001B6B5 File Offset: 0x000198B5
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x001539D0 File Offset: 0x00151BD0
		// (set) Token: 0x06004959 RID: 18777 RVA: 0x0001B6D4 File Offset: 0x000198D4
		public unsafe int bufferPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferPos)) = value;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x001539F8 File Offset: 0x00151BF8
		// (set) Token: 0x0600495B RID: 18779 RVA: 0x0001B6EF File Offset: 0x000198EF
		public unsafe int bufferNesting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferNesting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_bufferNesting)) = value;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x00153A20 File Offset: 0x00151C20
		// (set) Token: 0x0600495D RID: 18781 RVA: 0x0001B70A File Offset: 0x0001990A
		public unsafe bool writingScalars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_writingScalars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCollector.NativeFieldInfoPtr_writingScalars)) = value;
			}
		}

		// Token: 0x04003B46 RID: 15174
		private static readonly IntPtr NativeFieldInfoPtr_ThreadInstance;

		// Token: 0x04003B47 RID: 15175
		private static readonly IntPtr NativeFieldInfoPtr_scratchEnd;

		// Token: 0x04003B48 RID: 15176
		private static readonly IntPtr NativeFieldInfoPtr_datasEnd;

		// Token: 0x04003B49 RID: 15177
		private static readonly IntPtr NativeFieldInfoPtr_pinsEnd;

		// Token: 0x04003B4A RID: 15178
		private static readonly IntPtr NativeFieldInfoPtr_datasStart;

		// Token: 0x04003B4B RID: 15179
		private static readonly IntPtr NativeFieldInfoPtr_scratch;

		// Token: 0x04003B4C RID: 15180
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x04003B4D RID: 15181
		private static readonly IntPtr NativeFieldInfoPtr_pins;

		// Token: 0x04003B4E RID: 15182
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04003B4F RID: 15183
		private static readonly IntPtr NativeFieldInfoPtr_bufferPos;

		// Token: 0x04003B50 RID: 15184
		private static readonly IntPtr NativeFieldInfoPtr_bufferNesting;

		// Token: 0x04003B51 RID: 15185
		private static readonly IntPtr NativeFieldInfoPtr_writingScalars;

		// Token: 0x04003B52 RID: 15186
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Internal_Void_ptr_Byte_Int32_ptr_EventData_Int32_ptr_GCHandle_Int32_0;

		// Token: 0x04003B53 RID: 15187
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Internal_Void_0;

		// Token: 0x04003B54 RID: 15188
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_ptr_EventData_0;

		// Token: 0x04003B55 RID: 15189
		private static readonly IntPtr NativeMethodInfoPtr_AddScalar_Internal_Void_ptr_Void_Int32_0;

		// Token: 0x04003B56 RID: 15190
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Internal_Void_String_Int32_0;

		// Token: 0x04003B57 RID: 15191
		private static readonly IntPtr NativeMethodInfoPtr_AddBinary_Internal_Void_Array_Int32_0;

		// Token: 0x04003B58 RID: 15192
		private static readonly IntPtr NativeMethodInfoPtr_AddArray_Internal_Void_Array_Int32_Int32_0;

		// Token: 0x04003B59 RID: 15193
		private static readonly IntPtr NativeMethodInfoPtr_BeginBufferedArray_Internal_Int32_0;

		// Token: 0x04003B5A RID: 15194
		private static readonly IntPtr NativeMethodInfoPtr_EndBufferedArray_Internal_Void_Int32_Int32_0;

		// Token: 0x04003B5B RID: 15195
		private static readonly IntPtr NativeMethodInfoPtr_BeginBuffered_Internal_Void_0;

		// Token: 0x04003B5C RID: 15196
		private static readonly IntPtr NativeMethodInfoPtr_EndBuffered_Internal_Void_0;

		// Token: 0x04003B5D RID: 15197
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBuffer_Private_Void_0;

		// Token: 0x04003B5E RID: 15198
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBuffer_Private_Void_Int32_0;

		// Token: 0x04003B5F RID: 15199
		private static readonly IntPtr NativeMethodInfoPtr_GrowBuffer_Private_Void_Int32_0;

		// Token: 0x04003B60 RID: 15200
		private static readonly IntPtr NativeMethodInfoPtr_PinArray_Private_Void_Object_Int32_0;

		// Token: 0x04003B61 RID: 15201
		private static readonly IntPtr NativeMethodInfoPtr_ScalarsBegin_Private_Void_0;

		// Token: 0x04003B62 RID: 15202
		private static readonly IntPtr NativeMethodInfoPtr_ScalarsEnd_Private_Void_0;
	}
}
