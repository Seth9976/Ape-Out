using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B7 RID: 439
	public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated
	{
		// Token: 0x06002326 RID: 8998 RVA: 0x000A3790 File Offset: 0x000A1990
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaIdentityConstraint()
		{
			Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaIdentityConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr);
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "name");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "selector");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "fields");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_qualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "qualifiedName");
			XmlSchemaIdentityConstraint.NativeFieldInfoPtr_compiledConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, "compiledConstraint");
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668298);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668299);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_XmlSchemaXPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668300);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Selector_Public_set_Void_XmlSchemaXPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668301);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668302);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668303);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668304);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_CompiledConstraint_Internal_get_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668305);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_CompiledConstraint_Internal_set_Void_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668306);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668307);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668308);
			XmlSchemaIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr, 100668309);
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000A3914 File Offset: 0x000A1B14
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x000A394C File Offset: 0x000A1B4C
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000A3990 File Offset: 0x000A1B90
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x000A39D0 File Offset: 0x000A1BD0
		public unsafe XmlSchemaXPath Selector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_XmlSchemaXPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaXPath>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_Selector_Public_set_Void_XmlSchemaXPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000A3A14 File Offset: 0x000A1C14
		public unsafe XmlSchemaObjectCollection Fields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000A3A54 File Offset: 0x000A1C54
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x000A3A94 File Offset: 0x000A1C94
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQualifiedName(XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000A3AD8 File Offset: 0x000A1CD8
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x000A3B18 File Offset: 0x000A1D18
		public unsafe CompiledIdentityConstraint CompiledConstraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_CompiledConstraint_Internal_get_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 89481, RefRangeEnd = 89490, XrefRangeStart = 89481, XrefRangeEnd = 89490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_CompiledConstraint_Internal_set_Void_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000A3B5C File Offset: 0x000A1D5C
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x000A3BA0 File Offset: 0x000A1DA0
		public unsafe override string NameAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaIdentityConstraint.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaIdentityConstraint.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x000A3BF0 File Offset: 0x000A1DF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 427612, RefRangeEnd = 427616, XrefRangeStart = 427604, XrefRangeEnd = 427612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaIdentityConstraint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaIdentityConstraint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0000F532 File Offset: 0x0000D732
		public XmlSchemaIdentityConstraint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000A3C2C File Offset: 0x000A1E2C
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0000F53B File Offset: 0x0000D73B
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000A3C54 File Offset: 0x000A1E54
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x0000F55A File Offset: 0x0000D75A
		public unsafe XmlSchemaXPath selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaXPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000A3C84 File Offset: 0x000A1E84
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x0000F579 File Offset: 0x0000D779
		public unsafe XmlSchemaObjectCollection fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000A3CB4 File Offset: 0x000A1EB4
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0000F598 File Offset: 0x0000D798
		public unsafe XmlQualifiedName qualifiedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_qualifiedName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_qualifiedName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000A3CE4 File Offset: 0x000A1EE4
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
		public unsafe CompiledIdentityConstraint compiledConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_compiledConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaIdentityConstraint.NativeFieldInfoPtr_compiledConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeFieldInfoPtr_selector;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedName;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeFieldInfoPtr_compiledConstraint;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_get_Selector_Public_get_XmlSchemaXPath_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_set_Selector_Public_set_Void_XmlSchemaXPath_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_get_CompiledConstraint_Internal_get_CompiledIdentityConstraint_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_set_CompiledConstraint_Internal_set_Void_CompiledIdentityConstraint_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
