using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200018D RID: 397
	public class XmlSchemaAppInfo : XmlSchemaObject
	{
		// Token: 0x060020BD RID: 8381 RVA: 0x0009A6F0 File Offset: 0x000988F0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAppInfo()
		{
			Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAppInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr);
			XmlSchemaAppInfo.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, "source");
			XmlSchemaAppInfo.NativeFieldInfoPtr_markup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, "markup");
			XmlSchemaAppInfo.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, 100667975);
			XmlSchemaAppInfo.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, 100667976);
			XmlSchemaAppInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr, 100667977);
		}

		// Token: 0x17000B56 RID: 2902
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0009A784 File Offset: 0x00098984
		public unsafe string Source
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAppInfo.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x0009A7C8 File Offset: 0x000989C8
		public unsafe Il2CppReferenceArray<XmlNode> Markup
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAppInfo.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0009A80C File Offset: 0x00098A0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAppInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAppInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAppInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0000E3F6 File Offset: 0x0000C5F6
		public XmlSchemaAppInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0009A848 File Offset: 0x00098A48
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x0000E3FF File Offset: 0x0000C5FF
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0009A870 File Offset: 0x00098A70
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x0000E41E File Offset: 0x0000C61E
		public unsafe Il2CppReferenceArray<XmlNode> markup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_markup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAppInfo.NativeFieldInfoPtr_markup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeFieldInfoPtr_markup;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_set_Void_String_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
