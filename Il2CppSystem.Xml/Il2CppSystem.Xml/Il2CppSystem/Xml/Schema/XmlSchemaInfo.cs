using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001BE RID: 446
	public class XmlSchemaInfo : Object
	{
		// Token: 0x06002362 RID: 9058 RVA: 0x000A438C File Offset: 0x000A258C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaInfo()
		{
			Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr);
			XmlSchemaInfo.NativeFieldInfoPtr_isDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "isDefault");
			XmlSchemaInfo.NativeFieldInfoPtr_isNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "isNil");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaElement");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaAttribute");
			XmlSchemaInfo.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "schemaType");
			XmlSchemaInfo.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "memberType");
			XmlSchemaInfo.NativeFieldInfoPtr_validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "validity");
			XmlSchemaInfo.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, "contentType");
			XmlSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668324);
			XmlSchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668325);
			XmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668326);
			XmlSchemaInfo.NativeMethodInfoPtr_set_Validity_Public_set_Void_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668327);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668328);
			XmlSchemaInfo.NativeMethodInfoPtr_set_IsDefault_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668329);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668330);
			XmlSchemaInfo.NativeMethodInfoPtr_set_IsNil_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668331);
			XmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668332);
			XmlSchemaInfo.NativeMethodInfoPtr_set_MemberType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668333);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668334);
			XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668335);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668336);
			XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaElement_Public_set_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668337);
			XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668338);
			XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaAttribute_Public_set_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668339);
			XmlSchemaInfo.NativeMethodInfoPtr_get_XmlType_Internal_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668340);
			XmlSchemaInfo.NativeMethodInfoPtr_get_HasDefaultValue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668341);
			XmlSchemaInfo.NativeMethodInfoPtr_get_IsUnionType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668342);
			XmlSchemaInfo.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr, 100668343);
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x000A45EC File Offset: 0x000A27EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427628, XrefRangeEnd = 427629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x000A4628 File Offset: 0x000A2828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427629, XrefRangeEnd = 427630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInfo(XmlSchemaValidity validity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref validity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x000A4670 File Offset: 0x000A2870
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x000A46AC File Offset: 0x000A28AC
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_Validity_Public_set_Void_XmlSchemaValidity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000A46EC File Offset: 0x000A28EC
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x000A4728 File Offset: 0x000A2928
		public unsafe virtual bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_IsDefault_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000A4768 File Offset: 0x000A2968
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x000A47A4 File Offset: 0x000A29A4
		public unsafe virtual bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_IsNil_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000A47E4 File Offset: 0x000A29E4
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x000A4824 File Offset: 0x000A2A24
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_MemberType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000A4868 File Offset: 0x000A2A68
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x000A48A8 File Offset: 0x000A2AA8
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 427630, RefRangeEnd = 427634, XrefRangeStart = 427630, XrefRangeEnd = 427630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000A48EC File Offset: 0x000A2AEC
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x000A492C File Offset: 0x000A2B2C
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 427634, RefRangeEnd = 427636, XrefRangeStart = 427634, XrefRangeEnd = 427634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaElement_Public_set_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000A4970 File Offset: 0x000A2B70
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x000A49B0 File Offset: 0x000A2BB0
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 427636, RefRangeEnd = 427638, XrefRangeStart = 427636, XrefRangeEnd = 427636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_set_SchemaAttribute_Public_set_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000A49F4 File Offset: 0x000A2BF4
		public unsafe XmlSchemaType XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_XmlType_Internal_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000A4A34 File Offset: 0x000A2C34
		public unsafe bool HasDefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_HasDefaultValue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000A4A70 File Offset: 0x000A2C70
		public unsafe bool IsUnionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_get_IsUnionType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000A4AAC File Offset: 0x000A2CAC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 427638, RefRangeEnd = 427644, XrefRangeStart = 427638, XrefRangeEnd = 427638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInfo.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0000F719 File Offset: 0x0000D919
		public XmlSchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x000A4AE0 File Offset: 0x000A2CE0
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x0000F722 File Offset: 0x0000D922
		public unsafe bool isDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isDefault)) = value;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x000A4B08 File Offset: 0x000A2D08
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x0000F73D File Offset: 0x0000D93D
		public unsafe bool isNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isNil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_isNil)) = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x000A4B30 File Offset: 0x000A2D30
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x0000F758 File Offset: 0x0000D958
		public unsafe XmlSchemaElement schemaElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000A4B60 File Offset: 0x000A2D60
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x0000F777 File Offset: 0x0000D977
		public unsafe XmlSchemaAttribute schemaAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000A4B90 File Offset: 0x000A2D90
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0000F796 File Offset: 0x0000D996
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000A4BC0 File Offset: 0x000A2DC0
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x0000F7B5 File Offset: 0x0000D9B5
		public unsafe XmlSchemaSimpleType memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000A4BF0 File Offset: 0x000A2DF0
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
		public unsafe XmlSchemaValidity validity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_validity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_validity)) = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000A4C18 File Offset: 0x000A2E18
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x0000F7EF File Offset: 0x0000D9EF
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInfo.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeFieldInfoPtr_isDefault;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeFieldInfoPtr_isNil;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeFieldInfoPtr_schemaElement;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeFieldInfoPtr_schemaAttribute;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeFieldInfoPtr_validity;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaValidity_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Virtual_Final_New_get_XmlSchemaValidity_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_set_Validity_Public_set_Void_XmlSchemaValidity_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDefault_Public_set_Void_Boolean_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNil_Public_set_Void_Boolean_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_Final_New_get_XmlSchemaSimpleType_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Virtual_Final_New_get_XmlSchemaType_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_Final_New_get_XmlSchemaElement_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaElement_Public_set_Void_XmlSchemaElement_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_Final_New_get_XmlSchemaAttribute_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaAttribute_Public_set_Void_XmlSchemaAttribute_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Internal_get_XmlSchemaType_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultValue_Internal_get_Boolean_0;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnionType_Internal_get_Boolean_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
	}
}
