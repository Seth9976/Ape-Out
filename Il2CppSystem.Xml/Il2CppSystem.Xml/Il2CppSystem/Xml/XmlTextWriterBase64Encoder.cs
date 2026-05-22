using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001A RID: 26
	public class XmlTextWriterBase64Encoder : Base64Encoder
	{
		// Token: 0x0600016F RID: 367 RVA: 0x0001913C File Offset: 0x0001733C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextWriterBase64Encoder()
		{
			Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextWriterBase64Encoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr);
			XmlTextWriterBase64Encoder.NativeFieldInfoPtr_xmlTextEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr, "xmlTextEncoder");
			XmlTextWriterBase64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextEncoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr, 100663458);
			XmlTextWriterBase64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr, 100663459);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000191A8 File Offset: 0x000173A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextWriterBase64Encoder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlTextEncoder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextWriterBase64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextEncoder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000191F4 File Offset: 0x000173F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389611, XrefRangeEnd = 389613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextWriterBase64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002A56 File Offset: 0x00000C56
		public XmlTextWriterBase64Encoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00019260 File Offset: 0x00017460
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002A5F File Offset: 0x00000C5F
		public unsafe XmlTextEncoder xmlTextEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriterBase64Encoder.NativeFieldInfoPtr_xmlTextEncoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextEncoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextWriterBase64Encoder.NativeFieldInfoPtr_xmlTextEncoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_xmlTextEncoder;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlTextEncoder_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;
	}
}
