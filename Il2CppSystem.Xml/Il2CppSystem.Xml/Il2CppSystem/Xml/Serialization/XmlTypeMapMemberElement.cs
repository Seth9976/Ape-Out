using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E8 RID: 232
	public class XmlTypeMapMemberElement : XmlTypeMapMember
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x000689F0 File Offset: 0x00066BF0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberElement()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr);
			XmlTypeMapMemberElement.NativeFieldInfoPtr__elementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_elementInfo");
			XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_choiceMember");
			XmlTypeMapMemberElement.NativeFieldInfoPtr__isTextCollector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_isTextCollector");
			XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceTypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, "_choiceTypeData");
			XmlTypeMapMemberElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666365);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ElementInfo_Public_get_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666366);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ElementInfo_Public_set_Void_XmlTypeMapElementInfoList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666367);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ChoiceMember_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666368);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666369);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceTypeData_Public_set_Void_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666370);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666371);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_get_IsXmlTextCollector_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666372);
			XmlTypeMapMemberElement.NativeMethodInfoPtr_set_IsXmlTextCollector_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr, 100666373);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00068B24 File Offset: 0x00066D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407509, XrefRangeEnd = 407510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00068B60 File Offset: 0x00066D60
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00068BA0 File Offset: 0x00066DA0
		public unsafe XmlTypeMapElementInfoList ElementInfo
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 407517, RefRangeEnd = 407523, XrefRangeStart = 407510, XrefRangeEnd = 407517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ElementInfo_Public_get_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ElementInfo_Public_set_Void_XmlTypeMapElementInfoList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x00068BE4 File Offset: 0x00066DE4
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00068C1C File Offset: 0x00066E1C
		public unsafe string ChoiceMember
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_get_ChoiceMember_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x00068C60 File Offset: 0x00066E60
		public unsafe TypeData ChoiceTypeData
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_ChoiceTypeData_Public_set_Void_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00068CA4 File Offset: 0x00066EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 407553, RefRangeEnd = 407554, XrefRangeStart = 407523, XrefRangeEnd = 407553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo FindElement(Object ob, Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfo>(intPtr3) : null;
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00068D08 File Offset: 0x00066F08
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00068D44 File Offset: 0x00066F44
		public unsafe bool IsXmlTextCollector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_get_IsXmlTextCollector_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberElement.NativeMethodInfoPtr_set_IsXmlTextCollector_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00008C50 File Offset: 0x00006E50
		public XmlTypeMapMemberElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00068D84 File Offset: 0x00066F84
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00008C59 File Offset: 0x00006E59
		public unsafe XmlTypeMapElementInfoList _elementInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__elementInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapElementInfoList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__elementInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00068DB4 File Offset: 0x00066FB4
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00008C78 File Offset: 0x00006E78
		public unsafe string _choiceMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceMember);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceMember), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00068DDC File Offset: 0x00066FDC
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x00008C97 File Offset: 0x00006E97
		public unsafe bool _isTextCollector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__isTextCollector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__isTextCollector)) = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00068E04 File Offset: 0x00067004
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x00008CB2 File Offset: 0x00006EB2
		public unsafe TypeData _choiceTypeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceTypeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberElement.NativeFieldInfoPtr__choiceTypeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr__elementInfo;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeFieldInfoPtr__choiceMember;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr__isTextCollector;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr__choiceTypeData;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementInfo_Public_get_XmlTypeMapElementInfoList_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementInfo_Public_set_Void_XmlTypeMapElementInfoList_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoiceMember_Public_get_String_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceMember_Public_set_Void_String_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceTypeData_Public_set_Void_TypeData_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Public_XmlTypeMapElementInfo_Object_Object_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlTextCollector_Public_get_Boolean_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_set_IsXmlTextCollector_Public_set_Void_Boolean_0;
	}
}
