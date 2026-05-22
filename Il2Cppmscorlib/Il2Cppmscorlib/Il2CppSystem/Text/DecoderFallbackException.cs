using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015D RID: 349
	[Serializable]
	public sealed class DecoderFallbackException : ArgumentException
	{
		// Token: 0x060017D8 RID: 6104 RVA: 0x0008FC44 File Offset: 0x0008DE44
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallbackException()
		{
			Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallbackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr);
			DecoderFallbackException.NativeFieldInfoPtr_bytesUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, "bytesUnknown");
			DecoderFallbackException.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, "index");
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100667341);
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100667342);
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100667343);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0008FCD8 File Offset: 0x0008DED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179213, XrefRangeEnd = 179216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0008FD14 File Offset: 0x0008DF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0008FD78 File Offset: 0x0008DF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179217, RefRangeEnd = 179218, XrefRangeStart = 179216, XrefRangeEnd = 179217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException(string message, Il2CppStructArray<byte> bytesUnknown, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0000841C File Offset: 0x0000661C
		public DecoderFallbackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0008FDE4 File Offset: 0x0008DFE4
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x00008425 File Offset: 0x00006625
		public unsafe Il2CppStructArray<byte> bytesUnknown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_bytesUnknown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_bytesUnknown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0008FE14 File Offset: 0x0008E014
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x00008444 File Offset: 0x00006644
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr_bytesUnknown;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0;
	}
}
