using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000168 RID: 360
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		// Token: 0x06001875 RID: 6261 RVA: 0x00092718 File Offset: 0x00090918
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallbackException()
		{
			Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallbackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr);
			EncoderFallbackException.NativeFieldInfoPtr_charUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "charUnknown");
			EncoderFallbackException.NativeFieldInfoPtr_charUnknownHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "charUnknownHigh");
			EncoderFallbackException.NativeFieldInfoPtr_charUnknownLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "charUnknownLow");
			EncoderFallbackException.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "index");
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667426);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667427);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667428);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667429);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000927E8 File Offset: 0x000909E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179703, XrefRangeEnd = 179706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00092824 File Offset: 0x00090A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00092888 File Offset: 0x00090A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179707, RefRangeEnd = 179708, XrefRangeStart = 179706, XrefRangeEnd = 179707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(string message, char charUnknown, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknown;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000928F0 File Offset: 0x00090AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179714, RefRangeEnd = 179715, XrefRangeStart = 179708, XrefRangeEnd = 179714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownHigh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00008722 File Offset: 0x00006922
		public EncoderFallbackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00092968 File Offset: 0x00090B68
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x0000872B File Offset: 0x0000692B
		public unsafe char charUnknown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknown)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x00092990 File Offset: 0x00090B90
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x00008746 File Offset: 0x00006946
		public unsafe char charUnknownHigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownHigh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownHigh)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x000929B8 File Offset: 0x00090BB8
		// (set) Token: 0x06001880 RID: 6272 RVA: 0x00008761 File Offset: 0x00006961
		public unsafe char charUnknownLow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownLow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownLow)) = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x000929E0 File Offset: 0x00090BE0
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x0000877C File Offset: 0x0000697C
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeFieldInfoPtr_charUnknown;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeFieldInfoPtr_charUnknownHigh;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeFieldInfoPtr_charUnknownLow;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0;
	}
}
