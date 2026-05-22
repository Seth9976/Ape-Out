using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000180 RID: 384
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06001ED0 RID: 7888 RVA: 0x000930CC File Offset: 0x000912CC
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationEventArgs()
		{
			Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr);
			ValidationEventArgs.NativeFieldInfoPtr_ex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, "ex");
			ValidationEventArgs.NativeFieldInfoPtr_severity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, "severity");
			ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100667705);
			ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100667706);
			ValidationEventArgs.NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100667707);
			ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100667708);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00093174 File Offset: 0x00091374
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 424628, RefRangeEnd = 424632, XrefRangeStart = 424625, XrefRangeEnd = 424628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventArgs(XmlSchemaException ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000931C0 File Offset: 0x000913C0
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 424635, RefRangeEnd = 424702, XrefRangeStart = 424632, XrefRangeEnd = 424635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0009321C File Offset: 0x0009141C
		public unsafe XmlSeverityType Severity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x00093258 File Offset: 0x00091458
		public unsafe XmlSchemaException Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaException>(intPtr3) : null;
			}
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0000D6D5 File Offset: 0x0000B8D5
		public ValidationEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00093298 File Offset: 0x00091498
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x0000D6DE File Offset: 0x0000B8DE
		public unsafe XmlSchemaException ex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_ex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_ex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x000932C8 File Offset: 0x000914C8
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x0000D6FD File Offset: 0x0000B8FD
		public unsafe XmlSeverityType severity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_severity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_severity)) = value;
			}
		}

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_ex;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeFieldInfoPtr_severity;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0;
	}
}
