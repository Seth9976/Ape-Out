using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DB RID: 987
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		// Token: 0x06003FA8 RID: 16296 RVA: 0x0012AF60 File Offset: 0x00129160
		// Note: this type is marked as 'beforefieldinit'.
		static SoapMethodAttribute()
		{
			Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr);
			SoapMethodAttribute.NativeFieldInfoPtr__responseElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_responseElement");
			SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_responseNamespace");
			SoapMethodAttribute.NativeFieldInfoPtr__returnElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_returnElement");
			SoapMethodAttribute.NativeFieldInfoPtr__soapAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_soapAction");
			SoapMethodAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_useAttribute");
			SoapMethodAttribute.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_namespace");
			SoapMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672694);
			SoapMethodAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672695);
			SoapMethodAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672696);
			SoapMethodAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672697);
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0012B058 File Offset: 0x00129258
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06003FAA RID: 16298 RVA: 0x0012B094 File Offset: 0x00129294
		public unsafe override bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x0012B0D0 File Offset: 0x001292D0
		public unsafe override string XmlNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x0012B108 File Offset: 0x00129308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223630, XrefRangeEnd = 223687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x00017CE4 File Offset: 0x00015EE4
		public SoapMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06003FAE RID: 16302 RVA: 0x0012B14C File Offset: 0x0012934C
		// (set) Token: 0x06003FAF RID: 16303 RVA: 0x00017CED File Offset: 0x00015EED
		public unsafe string _responseElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseElement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseElement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x0012B174 File Offset: 0x00129374
		// (set) Token: 0x06003FB1 RID: 16305 RVA: 0x00017D0C File Offset: 0x00015F0C
		public unsafe string _responseNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x0012B19C File Offset: 0x0012939C
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x00017D2B File Offset: 0x00015F2B
		public unsafe string _returnElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__returnElement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__returnElement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06003FB4 RID: 16308 RVA: 0x0012B1C4 File Offset: 0x001293C4
		// (set) Token: 0x06003FB5 RID: 16309 RVA: 0x00017D4A File Offset: 0x00015F4A
		public unsafe string _soapAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__soapAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__soapAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06003FB6 RID: 16310 RVA: 0x0012B1EC File Offset: 0x001293EC
		// (set) Token: 0x06003FB7 RID: 16311 RVA: 0x00017D69 File Offset: 0x00015F69
		public new unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06003FB8 RID: 16312 RVA: 0x0012B214 File Offset: 0x00129414
		// (set) Token: 0x06003FB9 RID: 16313 RVA: 0x00017D84 File Offset: 0x00015F84
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400345B RID: 13403
		private static readonly IntPtr NativeFieldInfoPtr__responseElement;

		// Token: 0x0400345C RID: 13404
		private static readonly IntPtr NativeFieldInfoPtr__responseNamespace;

		// Token: 0x0400345D RID: 13405
		private static readonly IntPtr NativeFieldInfoPtr__returnElement;

		// Token: 0x0400345E RID: 13406
		private static readonly IntPtr NativeFieldInfoPtr__soapAction;

		// Token: 0x0400345F RID: 13407
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x04003460 RID: 13408
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x04003461 RID: 13409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003462 RID: 13410
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0;

		// Token: 0x04003463 RID: 13411
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0;

		// Token: 0x04003464 RID: 13412
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
