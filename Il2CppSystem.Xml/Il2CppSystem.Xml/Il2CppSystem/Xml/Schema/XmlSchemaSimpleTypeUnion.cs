using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CE RID: 462
	public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
	{
		// Token: 0x060024C1 RID: 9409 RVA: 0x000A9900 File Offset: 0x000A7B00
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeUnion()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeUnion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr);
			XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, "baseTypes");
			XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, "memberTypes");
			XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseMemberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, "baseMemberTypes");
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseTypes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100668529);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_MemberTypes_Public_get_Il2CppReferenceArray_1_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100668530);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_set_MemberTypes_Public_set_Void_Il2CppReferenceArray_1_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100668531);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseMemberTypes_Public_get_Il2CppReferenceArray_1_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100668532);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_SetBaseMemberTypes_Internal_Void_Il2CppReferenceArray_1_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100668533);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100668534);
			XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr, 100668535);
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000A99F8 File Offset: 0x000A7BF8
		public unsafe XmlSchemaObjectCollection BaseTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseTypes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000A9A38 File Offset: 0x000A7C38
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x000A9A78 File Offset: 0x000A7C78
		public unsafe Il2CppReferenceArray<XmlQualifiedName> MemberTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_MemberTypes_Public_get_Il2CppReferenceArray_1_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 17925, RefRangeEnd = 17937, XrefRangeStart = 17925, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_set_MemberTypes_Public_set_Void_Il2CppReferenceArray_1_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x000A9ABC File Offset: 0x000A7CBC
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> BaseMemberTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_get_BaseMemberTypes_Public_get_Il2CppReferenceArray_1_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr3) : null;
			}
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x000A9AFC File Offset: 0x000A7CFC
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBaseMemberTypes(Il2CppReferenceArray<XmlSchemaSimpleType> baseMemberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMemberTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_SetBaseMemberTypes_Internal_Void_Il2CppReferenceArray_1_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000A9B40 File Offset: 0x000A7D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429271, XrefRangeEnd = 429285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000A9B8C File Offset: 0x000A7D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429285, XrefRangeEnd = 429289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeUnion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeUnion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeUnion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0000FFA3 File Offset: 0x0000E1A3
		public XmlSchemaSimpleTypeUnion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000A9BC8 File Offset: 0x000A7DC8
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x0000FFAC File Offset: 0x0000E1AC
		public unsafe XmlSchemaObjectCollection baseTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000A9BF8 File Offset: 0x000A7DF8
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x0000FFCB File Offset: 0x0000E1CB
		public unsafe Il2CppReferenceArray<XmlQualifiedName> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x000A9C28 File Offset: 0x000A7E28
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0000FFEA File Offset: 0x0000E1EA
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> baseMemberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseMemberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeUnion.NativeFieldInfoPtr_baseMemberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeFieldInfoPtr_baseTypes;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeFieldInfoPtr_baseMemberTypes;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseTypes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberTypes_Public_get_Il2CppReferenceArray_1_XmlQualifiedName_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberTypes_Public_set_Void_Il2CppReferenceArray_1_XmlQualifiedName_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMemberTypes_Public_get_Il2CppReferenceArray_1_XmlSchemaSimpleType_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseMemberTypes_Internal_Void_Il2CppReferenceArray_1_XmlSchemaSimpleType_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
