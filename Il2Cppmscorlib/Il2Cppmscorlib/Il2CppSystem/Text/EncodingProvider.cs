using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000170 RID: 368
	public class EncodingProvider : Object
	{
		// Token: 0x06001959 RID: 6489 RVA: 0x00096878 File Offset: 0x00094A78
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingProvider()
		{
			Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr);
			EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_InternalSyncObject");
			EncodingProvider.NativeFieldInfoPtr_s_providers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_providers");
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667596);
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667597);
			EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667598);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667599);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667600);
			EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100667601);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00096948 File Offset: 0x00094B48
		[CallerCount(0)]
		public unsafe virtual Encoding GetEncoding(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000969A4 File Offset: 0x00094BA4
		[CallerCount(0)]
		public unsafe virtual Encoding GetEncoding(int codepage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x000969FC File Offset: 0x00094BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180862, XrefRangeEnd = 180866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoderFallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoderFallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncodingProvider.NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00096A78 File Offset: 0x00094C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180866, XrefRangeEnd = 180874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00096AB8 File Offset: 0x00094CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180874, XrefRangeEnd = 180882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(string encodingName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(encodingName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00096AFC File Offset: 0x00094CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180882, XrefRangeEnd = 180890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dec);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingProvider.NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00008B49 File Offset: 0x00006D49
		public EncodingProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x00096B60 File Offset: 0x00094D60
		// (set) Token: 0x06001962 RID: 6498 RVA: 0x00008B52 File Offset: 0x00006D52
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingProvider.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x00096B88 File Offset: 0x00094D88
		// (set) Token: 0x06001964 RID: 6500 RVA: 0x00008B64 File Offset: 0x00006D64
		public unsafe static Il2CppReferenceArray<EncodingProvider> s_providers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingProvider.NativeFieldInfoPtr_s_providers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EncodingProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingProvider.NativeFieldInfoPtr_s_providers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeFieldInfoPtr_s_providers;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0;
	}
}
