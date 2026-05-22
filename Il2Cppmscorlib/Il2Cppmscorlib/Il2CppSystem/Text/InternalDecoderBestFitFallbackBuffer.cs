using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015A RID: 346
	public sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x060017B6 RID: 6070 RVA: 0x0008F440 File Offset: 0x0008D640
		// Note: this type is marked as 'beforefieldinit'.
		static InternalDecoderBestFitFallbackBuffer()
		{
			Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalDecoderBestFitFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr);
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "cBestFit");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "iCount");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "iSize");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "oFallback");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "s_InternalSyncObject");
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667323);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667324);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667325);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667326);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667327);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667328);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667329);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667330);
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x0008F574 File Offset: 0x0008D774
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179137, XrefRangeEnd = 179144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0008F5A8 File Offset: 0x0008D7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179154, RefRangeEnd = 179155, XrefRangeStart = 179144, XrefRangeEnd = 179154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0008F5F4 File Offset: 0x0008D7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179155, XrefRangeEnd = 179156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(Il2CppStructArray<byte> bytesUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0008F650 File Offset: 0x0008D850
		[CallerCount(0)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x0008F68C File Offset: 0x0008D88C
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0008F6C8 File Offset: 0x0008D8C8
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0008F6FC File Offset: 0x0008D8FC
		[CallerCount(0)]
		public unsafe override int InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0008F758 File Offset: 0x0008D958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179157, RefRangeEnd = 179158, XrefRangeStart = 179156, XrefRangeEnd = 179157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char TryBestFit(Il2CppStructArray<byte> bytesCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0000837F File Offset: 0x0000657F
		public InternalDecoderBestFitFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0008F7A8 File Offset: 0x0008D9A8
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00008388 File Offset: 0x00006588
		public unsafe char cBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit)) = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0008F7D0 File Offset: 0x0008D9D0
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x000083A3 File Offset: 0x000065A3
		public unsafe int iCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount)) = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0008F7F8 File Offset: 0x0008D9F8
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x000083BE File Offset: 0x000065BE
		public unsafe int iSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize)) = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0008F820 File Offset: 0x0008DA20
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x000083D9 File Offset: 0x000065D9
		public unsafe InternalDecoderBestFitFallback oFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalDecoderBestFitFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0008F850 File Offset: 0x0008DA50
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x000083F8 File Offset: 0x000065F8
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeFieldInfoPtr_cBestFit;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeFieldInfoPtr_iCount;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeFieldInfoPtr_iSize;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeFieldInfoPtr_oFallback;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0;
	}
}
