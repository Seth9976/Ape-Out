using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DA RID: 986
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		// Token: 0x06003F9E RID: 16286 RVA: 0x0012AD74 File Offset: 0x00128F74
		// Note: this type is marked as 'beforefieldinit'.
		static SoapFieldAttribute()
		{
			Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr);
			SoapFieldAttribute.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, "_elementName");
			SoapFieldAttribute.NativeFieldInfoPtr__isElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, "_isElement");
			SoapFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672690);
			SoapFieldAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672691);
			SoapFieldAttribute.NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672692);
			SoapFieldAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672693);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x0012AE1C File Offset: 0x0012901C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapFieldAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06003FA0 RID: 16288 RVA: 0x0012AE58 File Offset: 0x00129058
		public unsafe string XmlElementName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0012AE90 File Offset: 0x00129090
		[CallerCount(0)]
		public unsafe bool IsInteropXmlElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x0012AECC File Offset: 0x001290CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223628, XrefRangeEnd = 223630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00017CA1 File Offset: 0x00015EA1
		public SoapFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x0012AF10 File Offset: 0x00129110
		// (set) Token: 0x06003FA5 RID: 16293 RVA: 0x00017CAA File Offset: 0x00015EAA
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06003FA6 RID: 16294 RVA: 0x0012AF38 File Offset: 0x00129138
		// (set) Token: 0x06003FA7 RID: 16295 RVA: 0x00017CC9 File Offset: 0x00015EC9
		public unsafe bool _isElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__isElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__isElement)) = value;
			}
		}

		// Token: 0x04003455 RID: 13397
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04003456 RID: 13398
		private static readonly IntPtr NativeFieldInfoPtr__isElement;

		// Token: 0x04003457 RID: 13399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003458 RID: 13400
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0;

		// Token: 0x04003459 RID: 13401
		private static readonly IntPtr NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0;

		// Token: 0x0400345A RID: 13402
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
