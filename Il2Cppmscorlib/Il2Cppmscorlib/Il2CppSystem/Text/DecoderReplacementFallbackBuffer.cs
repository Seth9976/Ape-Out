using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text
{
	// Token: 0x02000162 RID: 354
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x06001826 RID: 6182 RVA: 0x000911EC File Offset: 0x0008F3EC
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderReplacementFallbackBuffer()
		{
			Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderReplacementFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr);
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "strDefault");
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "fallbackCount");
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "fallbackIndex");
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667383);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667384);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667385);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667386);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667387);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667388);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000912D0 File Offset: 0x0008F4D0
		[CallerCount(0)]
		public unsafe DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0009131C File Offset: 0x0008F51C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00091378 File Offset: 0x0008F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179526, XrefRangeEnd = 179527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x000913B4 File Offset: 0x0008F5B4
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000913F0 File Offset: 0x0008F5F0
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00091424 File Offset: 0x0008F624
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00008599 File Offset: 0x00006799
		public DecoderReplacementFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x00091480 File Offset: 0x0008F680
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x000085A2 File Offset: 0x000067A2
		public unsafe string strDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x000914A8 File Offset: 0x0008F6A8
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x000085C1 File Offset: 0x000067C1
		public unsafe int fallbackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount)) = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x000914D0 File Offset: 0x0008F6D0
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x000085DC File Offset: 0x000067DC
		public unsafe int fallbackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex)) = value;
			}
		}

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeFieldInfoPtr_strDefault;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_fallbackCount;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_fallbackIndex;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;
	}
}
