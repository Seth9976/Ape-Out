using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D9 RID: 217
	public class XmlReflectionMember : Object
	{
		// Token: 0x0600128B RID: 4747 RVA: 0x00063818 File Offset: 0x00061A18
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReflectionMember()
		{
			Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlReflectionMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr);
			XmlReflectionMember.NativeFieldInfoPtr_isReturnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "isReturnValue");
			XmlReflectionMember.NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "memberName");
			XmlReflectionMember.NativeFieldInfoPtr_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "memberType");
			XmlReflectionMember.NativeFieldInfoPtr_xmlAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "xmlAttributes");
			XmlReflectionMember.NativeFieldInfoPtr_declaringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, "declaringType");
			XmlReflectionMember.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666195);
			XmlReflectionMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666196);
			XmlReflectionMember.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666197);
			XmlReflectionMember.NativeMethodInfoPtr_get_MemberType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666198);
			XmlReflectionMember.NativeMethodInfoPtr_get_XmlAttributes_Public_get_XmlAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666199);
			XmlReflectionMember.NativeMethodInfoPtr_get_DeclaringType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666200);
			XmlReflectionMember.NativeMethodInfoPtr_set_DeclaringType_Internal_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr, 100666201);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00063938 File Offset: 0x00061B38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 406160, RefRangeEnd = 406162, XrefRangeStart = 406160, XrefRangeEnd = 406160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReflectionMember(string name, Type type, XmlAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReflectionMember>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x000639A8 File Offset: 0x00061BA8
		public unsafe bool IsReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x000639E4 File Offset: 0x00061BE4
		public unsafe string MemberName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00063A1C File Offset: 0x00061C1C
		public unsafe Type MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_MemberType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00063A5C File Offset: 0x00061C5C
		public unsafe XmlAttributes XmlAttributes
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 406166, RefRangeEnd = 406171, XrefRangeStart = 406162, XrefRangeEnd = 406166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_XmlAttributes_Public_get_XmlAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00063A9C File Offset: 0x00061C9C
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x00063ADC File Offset: 0x00061CDC
		public unsafe Type DeclaringType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_get_DeclaringType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReflectionMember.NativeMethodInfoPtr_set_DeclaringType_Internal_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00008478 File Offset: 0x00006678
		public XmlReflectionMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00063B20 File Offset: 0x00061D20
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x00008481 File Offset: 0x00006681
		public unsafe bool isReturnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_isReturnValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_isReturnValue)) = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00063B48 File Offset: 0x00061D48
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0000849C File Offset: 0x0000669C
		public unsafe string memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00063B70 File Offset: 0x00061D70
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x000084BB File Offset: 0x000066BB
		public unsafe Type memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_memberType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00063BA0 File Offset: 0x00061DA0
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x000084DA File Offset: 0x000066DA
		public unsafe XmlAttributes xmlAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_xmlAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_xmlAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00063BD0 File Offset: 0x00061DD0
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x000084F9 File Offset: 0x000066F9
		public unsafe Type declaringType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_declaringType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReflectionMember.NativeFieldInfoPtr_declaringType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeFieldInfoPtr_isReturnValue;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr_memberName;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr_memberType;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr_xmlAttributes;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeFieldInfoPtr_declaringType;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Type_XmlAttributes_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReturnValue_Public_get_Boolean_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_get_Type_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlAttributes_Public_get_XmlAttributes_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Internal_get_Type_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaringType_Internal_set_Void_Type_0;
	}
}
