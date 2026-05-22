using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A2 RID: 930
	public class SoapServices : Object
	{
		// Token: 0x06003D87 RID: 15751 RVA: 0x001236E0 File Offset: 0x001218E0
		// Note: this type is marked as 'beforefieldinit'.
		static SoapServices()
		{
			Il2CppClassPointerStore<SoapServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "SoapServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapServices>.NativeClassPtr);
			SoapServices.NativeFieldInfoPtr__xmlTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_xmlTypes");
			SoapServices.NativeFieldInfoPtr__xmlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_xmlElements");
			SoapServices.NativeFieldInfoPtr__soapActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_soapActions");
			SoapServices.NativeFieldInfoPtr__soapActionsMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_soapActionsMethods");
			SoapServices.NativeFieldInfoPtr__typeInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "_typeInfos");
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672427);
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672428);
			SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672429);
			SoapServices.NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672430);
			SoapServices.NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672431);
			SoapServices.NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672432);
			SoapServices.NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672433);
			SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672434);
			SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672435);
			SoapServices.NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672436);
			SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672437);
			SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672438);
			SoapServices.NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672439);
			SoapServices.NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672440);
			SoapServices.NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, 100672441);
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06003D88 RID: 15752 RVA: 0x001238A0 File Offset: 0x00121AA0
		public unsafe static string XmlNsForClrTypeWithAssembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221123, XrefRangeEnd = 221125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x001238CC File Offset: 0x00121ACC
		public unsafe static string XmlNsForClrTypeWithNs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221125, XrefRangeEnd = 221127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x001238F8 File Offset: 0x00121AF8
		public unsafe static string XmlNsForClrTypeWithNsAndAssembly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221127, XrefRangeEnd = 221129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00123924 File Offset: 0x00121B24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 221151, RefRangeEnd = 221157, XrefRangeStart = 221129, XrefRangeEnd = 221151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeNamespace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00123974 File Offset: 0x00121B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221157, XrefRangeEnd = 221160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameKey(string name, string namspace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namspace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x001239C4 File Offset: 0x00121BC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221167, RefRangeEnd = 221169, XrefRangeStart = 221160, XrefRangeEnd = 221167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAssemblyName(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00123A00 File Offset: 0x00121C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221175, RefRangeEnd = 221176, XrefRangeStart = 221169, XrefRangeEnd = 221175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			xmlElement = IL2CPP.Il2CppStringToManaged(intPtr);
			xmlNamespace = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00123A78 File Offset: 0x00121C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221176, XrefRangeEnd = 221182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetXmlNamespaceForMethodCall(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00123AB4 File Offset: 0x00121CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221182, XrefRangeEnd = 221188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetXmlNamespaceForMethodResponse(MethodBase mb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x00123AF0 File Offset: 0x00121CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221194, RefRangeEnd = 221195, XrefRangeStart = 221188, XrefRangeEnd = 221194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			xmlType = IL2CPP.Il2CppStringToManaged(intPtr);
			xmlTypeNamespace = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x00123B68 File Offset: 0x00121D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221195, XrefRangeEnd = 221200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreLoad(Assembly assembly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00123BA0 File Offset: 0x00121DA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221249, RefRangeEnd = 221252, XrefRangeStart = 221200, XrefRangeEnd = 221249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PreLoad(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00123BD8 File Offset: 0x00121DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221265, RefRangeEnd = 221266, XrefRangeStart = 221252, XrefRangeEnd = 221265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00123C34 File Offset: 0x00121E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221279, RefRangeEnd = 221281, XrefRangeStart = 221266, XrefRangeEnd = 221279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlTypeNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00123C90 File Offset: 0x00121E90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221302, RefRangeEnd = 221304, XrefRangeStart = 221281, XrefRangeEnd = 221302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeNs(string ns)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00016F24 File Offset: 0x00015124
		public SoapServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x00123CCC File Offset: 0x00121ECC
		// (set) Token: 0x06003D99 RID: 15769 RVA: 0x00016F2D File Offset: 0x0001512D
		public unsafe static Hashtable _xmlTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__xmlTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__xmlTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06003D9A RID: 15770 RVA: 0x00123CF4 File Offset: 0x00121EF4
		// (set) Token: 0x06003D9B RID: 15771 RVA: 0x00016F3F File Offset: 0x0001513F
		public unsafe static Hashtable _xmlElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__xmlElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__xmlElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06003D9C RID: 15772 RVA: 0x00123D1C File Offset: 0x00121F1C
		// (set) Token: 0x06003D9D RID: 15773 RVA: 0x00016F51 File Offset: 0x00015151
		public unsafe static Hashtable _soapActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__soapActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__soapActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x00123D44 File Offset: 0x00121F44
		// (set) Token: 0x06003D9F RID: 15775 RVA: 0x00016F63 File Offset: 0x00015163
		public unsafe static Hashtable _soapActionsMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__soapActionsMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__soapActionsMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x00123D6C File Offset: 0x00121F6C
		// (set) Token: 0x06003DA1 RID: 15777 RVA: 0x00016F75 File Offset: 0x00015175
		public unsafe static Hashtable _typeInfos
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SoapServices.NativeFieldInfoPtr__typeInfos, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SoapServices.NativeFieldInfoPtr__typeInfos, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032FD RID: 13053
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypes;

		// Token: 0x040032FE RID: 13054
		private static readonly IntPtr NativeFieldInfoPtr__xmlElements;

		// Token: 0x040032FF RID: 13055
		private static readonly IntPtr NativeFieldInfoPtr__soapActions;

		// Token: 0x04003300 RID: 13056
		private static readonly IntPtr NativeFieldInfoPtr__soapActionsMethods;

		// Token: 0x04003301 RID: 13057
		private static readonly IntPtr NativeFieldInfoPtr__typeInfos;

		// Token: 0x04003302 RID: 13058
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithAssembly_Public_Static_get_String_0;

		// Token: 0x04003303 RID: 13059
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithNs_Public_Static_get_String_0;

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNsForClrTypeWithNsAndAssembly_Public_Static_get_String_0;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeMethodInfoPtr_CodeXmlNamespaceForClrTypeNamespace_Public_Static_String_String_String_0;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeMethodInfoPtr_GetNameKey_Private_Static_String_String_String_0;

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyName_Private_Static_String_MethodBase_0;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlElementForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0;

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceForMethodCall_Public_Static_String_MethodBase_0;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceForMethodResponse_Public_Static_String_MethodBase_0;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlTypeForInteropType_Public_Static_Boolean_Type_byref_String_byref_String_0;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeMethodInfoPtr_PreLoad_Public_Static_Void_Assembly_0;

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr_PreLoad_Public_Static_Void_Type_0;

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInteropXmlElement_Public_Static_Void_String_String_Type_0;

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInteropXmlType_Public_Static_Void_String_String_Type_0;

		// Token: 0x04003310 RID: 13072
		private static readonly IntPtr NativeMethodInfoPtr_EncodeNs_Private_Static_String_String_0;

		// Token: 0x0200062E RID: 1582
		public class TypeInfo : Object
		{
			// Token: 0x060055F2 RID: 22002 RVA: 0x0017FFD8 File Offset: 0x0017E1D8
			// Note: this type is marked as 'beforefieldinit'.
			static TypeInfo()
			{
				Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoapServices>.NativeClassPtr, "TypeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr);
				SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, "Attributes");
				SoapServices.TypeInfo.NativeFieldInfoPtr_Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, "Elements");
				SoapServices.TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr, 100672443);
			}

			// Token: 0x060055F3 RID: 22003 RVA: 0x00180040 File Offset: 0x0017E240
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapServices.TypeInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapServices.TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055F4 RID: 22004 RVA: 0x00020BBA File Offset: 0x0001EDBA
			public TypeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161C RID: 5660
			// (get) Token: 0x060055F5 RID: 22005 RVA: 0x0018007C File Offset: 0x0017E27C
			// (set) Token: 0x060055F6 RID: 22006 RVA: 0x00020BC3 File Offset: 0x0001EDC3
			public unsafe Hashtable Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700161D RID: 5661
			// (get) Token: 0x060055F7 RID: 22007 RVA: 0x001800AC File Offset: 0x0017E2AC
			// (set) Token: 0x060055F8 RID: 22008 RVA: 0x00020BE2 File Offset: 0x0001EDE2
			public unsafe Hashtable Elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapServices.TypeInfo.NativeFieldInfoPtr_Elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004541 RID: 17729
			private static readonly IntPtr NativeFieldInfoPtr_Attributes;

			// Token: 0x04004542 RID: 17730
			private static readonly IntPtr NativeFieldInfoPtr_Elements;

			// Token: 0x04004543 RID: 17731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
