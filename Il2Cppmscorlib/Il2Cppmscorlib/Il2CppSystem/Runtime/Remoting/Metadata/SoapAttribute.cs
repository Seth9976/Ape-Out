using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003D9 RID: 985
	public class SoapAttribute : Attribute
	{
		// Token: 0x06003F92 RID: 16274 RVA: 0x0012AB20 File Offset: 0x00128D20
		// Note: this type is marked as 'beforefieldinit'.
		static SoapAttribute()
		{
			Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr);
			SoapAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "_useAttribute");
			SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "ProtXmlNamespace");
			SoapAttribute.NativeFieldInfoPtr_ReflectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "ReflectInfo");
			SoapAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672686);
			SoapAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672687);
			SoapAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672688);
			SoapAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672689);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0012ABDC File Offset: 0x00128DDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06003F94 RID: 16276 RVA: 0x0012AC18 File Offset: 0x00128E18
		public unsafe virtual bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06003F95 RID: 16277 RVA: 0x0012AC60 File Offset: 0x00128E60
		public unsafe virtual string XmlNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x0012ACA4 File Offset: 0x00128EA4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00017C3F File Offset: 0x00015E3F
		public SoapAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x0012ACF4 File Offset: 0x00128EF4
		// (set) Token: 0x06003F99 RID: 16281 RVA: 0x00017C48 File Offset: 0x00015E48
		public unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06003F9A RID: 16282 RVA: 0x0012AD1C File Offset: 0x00128F1C
		// (set) Token: 0x06003F9B RID: 16283 RVA: 0x00017C63 File Offset: 0x00015E63
		public unsafe string ProtXmlNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06003F9C RID: 16284 RVA: 0x0012AD44 File Offset: 0x00128F44
		// (set) Token: 0x06003F9D RID: 16285 RVA: 0x00017C82 File Offset: 0x00015E82
		public unsafe Object ReflectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ReflectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ReflectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400344E RID: 13390
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x0400344F RID: 13391
		private static readonly IntPtr NativeFieldInfoPtr_ProtXmlNamespace;

		// Token: 0x04003450 RID: 13392
		private static readonly IntPtr NativeFieldInfoPtr_ReflectInfo;

		// Token: 0x04003451 RID: 13393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003452 RID: 13394
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003453 RID: 13395
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0;

		// Token: 0x04003454 RID: 13396
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0;
	}
}
