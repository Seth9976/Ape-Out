using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000019 RID: 25
	public class XmlRawWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00018FE8 File Offset: 0x000171E8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlRawWriterBase64Encoder()
		{
			Il2CppClassPointerStore<XmlRawWriterBase64Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlRawWriterBase64Encoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlRawWriterBase64Encoder>.NativeClassPtr);
			XmlRawWriterBase64Encoder.NativeFieldInfoPtr_rawWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRawWriterBase64Encoder>.NativeClassPtr, "rawWriter");
			XmlRawWriterBase64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_XmlRawWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRawWriterBase64Encoder>.NativeClassPtr, 100663456);
			XmlRawWriterBase64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRawWriterBase64Encoder>.NativeClassPtr, 100663457);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00019054 File Offset: 0x00017254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389609, XrefRangeEnd = 389610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlRawWriterBase64Encoder(XmlRawWriter rawWriter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlRawWriterBase64Encoder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRawWriterBase64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_XmlRawWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000190A0 File Offset: 0x000172A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389610, XrefRangeEnd = 389611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteChars(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlRawWriterBase64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002A2E File Offset: 0x00000C2E
		public XmlRawWriterBase64Encoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0001910C File Offset: 0x0001730C
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002A37 File Offset: 0x00000C37
		public unsafe XmlRawWriter rawWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRawWriterBase64Encoder.NativeFieldInfoPtr_rawWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlRawWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRawWriterBase64Encoder.NativeFieldInfoPtr_rawWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_rawWriter;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlRawWriter_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;
	}
}
