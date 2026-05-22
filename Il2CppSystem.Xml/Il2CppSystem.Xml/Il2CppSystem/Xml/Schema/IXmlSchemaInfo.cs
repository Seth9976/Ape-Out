using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200016B RID: 363
	public class IXmlSchemaInfo : Il2CppObjectBase
	{
		// Token: 0x06001ABF RID: 6847 RVA: 0x00083F2C File Offset: 0x0008212C
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlSchemaInfo()
		{
			Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "IXmlSchemaInfo");
			IXmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667256);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667257);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667258);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667259);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667260);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667261);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100667262);
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x00083FE0 File Offset: 0x000821E0
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x00084028 File Offset: 0x00082228
		public unsafe virtual bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00084070 File Offset: 0x00082270
		public unsafe virtual bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x000840B8 File Offset: 0x000822B8
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x00084104 File Offset: 0x00082304
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00084150 File Offset: 0x00082350
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0008419C File Offset: 0x0008239C
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0000B52E File Offset: 0x0000972E
		public IXmlSchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0;
	}
}
