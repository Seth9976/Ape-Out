using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000160 RID: 352
	public class FacetsChecker : Object
	{
		// Token: 0x06001A5C RID: 6748 RVA: 0x00081B2C File Offset: 0x0007FD2C
		// Note: this type is marked as 'beforefieldinit'.
		static FacetsChecker()
		{
			Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "FacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr);
			FacetsChecker.NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667161);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667162);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667163);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667164);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667165);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667166);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667167);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667168);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667169);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667170);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667171);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667172);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667173);
			FacetsChecker.NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667174);
			FacetsChecker.NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667175);
			FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667176);
			FacetsChecker.NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667177);
			FacetsChecker.NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667178);
			FacetsChecker.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667179);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00081CD8 File Offset: 0x0007FED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412842, XrefRangeEnd = 412845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(parseString);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			parseString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr4) : null;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00081D54 File Offset: 0x0007FF54
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00081DC4 File Offset: 0x0007FFC4
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00081E30 File Offset: 0x00080030
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00081E9C File Offset: 0x0008009C
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00081F08 File Offset: 0x00080108
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00081F74 File Offset: 0x00080174
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00081FE0 File Offset: 0x000801E0
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0008204C File Offset: 0x0008024C
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x000820B8 File Offset: 0x000802B8
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00082128 File Offset: 0x00080328
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(Il2CppStructArray<byte> value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00082198 File Offset: 0x00080398
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00082204 File Offset: 0x00080404
		[CallerCount(0)]
		public unsafe virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00082274 File Offset: 0x00080474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412847, RefRangeEnd = 412848, XrefRangeStart = 412845, XrefRangeEnd = 412847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(s);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			s = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000822D8 File Offset: 0x000804D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412862, RefRangeEnd = 412863, XrefRangeStart = 412848, XrefRangeEnd = 412862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CheckPatternFacets(RestrictionFacets restriction, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(restriction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0008233C File Offset: 0x0008053C
		[CallerCount(0)]
		public unsafe virtual bool MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x000823B8 File Offset: 0x000805B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412863, XrefRangeEnd = 412921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facets);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00082438 File Offset: 0x00080638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412921, XrefRangeEnd = 412933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Power(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00082484 File Offset: 0x00080684
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0000B438 File Offset: 0x00009638
		public FacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000232 RID: 562
		public sealed class FacetsCompiler : ValueType
		{
			// Token: 0x06002C5E RID: 11358 RVA: 0x000C65C4 File Offset: 0x000C47C4
			// Note: this type is marked as 'beforefieldinit'.
			static FacetsCompiler()
			{
				Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, "FacetsCompiler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr);
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "datatype");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_derivedRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "derivedRestriction");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "baseFlags");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFixedFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "baseFixedFlags");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_validRestrictionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "validRestrictionFlags");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_nonNegativeInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "nonNegativeInt");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "builtInType");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "builtInEnum");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_firstPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "firstPattern");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_regStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "regStr");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_pattern_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "pattern_facet");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_c_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "c_map");
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667180);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667181);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667182);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667183);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667184);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667185);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667186);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667187);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667188);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667189);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667190);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667191);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667192);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667193);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667194);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667195);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667196);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667197);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667198);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667199);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667200);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667201);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667202);
			}

			// Token: 0x06002C5F RID: 11359 RVA: 0x000C68AC File Offset: 0x000C4AAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412531, RefRangeEnd = 412532, XrefRangeStart = 412523, XrefRangeEnd = 412531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FacetsCompiler(DatatypeImplementation baseDatatype, RestrictionFacets restriction)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDatatype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(restriction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C60 RID: 11360 RVA: 0x000C6910 File Offset: 0x000C4B10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412552, RefRangeEnd = 412553, XrefRangeStart = 412532, XrefRangeEnd = 412552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileLengthFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C61 RID: 11361 RVA: 0x000C6958 File Offset: 0x000C4B58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412573, RefRangeEnd = 412574, XrefRangeStart = 412553, XrefRangeEnd = 412573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMinLengthFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C62 RID: 11362 RVA: 0x000C69A0 File Offset: 0x000C4BA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412594, RefRangeEnd = 412595, XrefRangeStart = 412574, XrefRangeEnd = 412594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMaxLengthFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C63 RID: 11363 RVA: 0x000C69E8 File Offset: 0x000C4BE8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412614, RefRangeEnd = 412615, XrefRangeStart = 412595, XrefRangeEnd = 412614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompilePatternFacet(XmlSchemaPatternFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C64 RID: 11364 RVA: 0x000C6A30 File Offset: 0x000C4C30
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412625, RefRangeEnd = 412626, XrefRangeStart = 412615, XrefRangeEnd = 412625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C65 RID: 11365 RVA: 0x000C6A9C File Offset: 0x000C4C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412626, XrefRangeEnd = 412647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileWhitespaceFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C66 RID: 11366 RVA: 0x000C6AE4 File Offset: 0x000C4CE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412657, RefRangeEnd = 412658, XrefRangeStart = 412647, XrefRangeEnd = 412657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMaxInclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C67 RID: 11367 RVA: 0x000C6B2C File Offset: 0x000C4D2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412668, RefRangeEnd = 412669, XrefRangeStart = 412658, XrefRangeEnd = 412668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMaxExclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C68 RID: 11368 RVA: 0x000C6B74 File Offset: 0x000C4D74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412679, RefRangeEnd = 412680, XrefRangeStart = 412669, XrefRangeEnd = 412679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMinInclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C69 RID: 11369 RVA: 0x000C6BBC File Offset: 0x000C4DBC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412690, RefRangeEnd = 412691, XrefRangeStart = 412680, XrefRangeEnd = 412690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMinExclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C6A RID: 11370 RVA: 0x000C6C04 File Offset: 0x000C4E04
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412715, RefRangeEnd = 412716, XrefRangeStart = 412691, XrefRangeEnd = 412715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileTotalDigitsFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C6B RID: 11371 RVA: 0x000C6C4C File Offset: 0x000C4E4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412731, RefRangeEnd = 412732, XrefRangeStart = 412716, XrefRangeEnd = 412731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileFractionDigitsFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C6C RID: 11372 RVA: 0x000C6C94 File Offset: 0x000C4E94
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412754, RefRangeEnd = 412755, XrefRangeStart = 412732, XrefRangeEnd = 412754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FinishFacetCompile()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C6D RID: 11373 RVA: 0x000C6CCC File Offset: 0x000C4ECC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 412758, RefRangeEnd = 412762, XrefRangeStart = 412755, XrefRangeEnd = 412758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckValue(Object value, XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C6E RID: 11374 RVA: 0x000C6D28 File Offset: 0x000C4F28
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412763, RefRangeEnd = 412764, XrefRangeStart = 412762, XrefRangeEnd = 412763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileFacetCombinations()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C6F RID: 11375 RVA: 0x000C6D60 File Offset: 0x000C4F60
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412771, RefRangeEnd = 412772, XrefRangeStart = 412764, XrefRangeEnd = 412771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyFacetsFromBaseType()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C70 RID: 11376 RVA: 0x000C6D98 File Offset: 0x000C4F98
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 412772, RefRangeEnd = 412782, XrefRangeStart = 412772, XrefRangeEnd = 412772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facet);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06002C71 RID: 11377 RVA: 0x000C6E38 File Offset: 0x000C5038
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412819, RefRangeEnd = 412820, XrefRangeStart = 412782, XrefRangeEnd = 412819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Preprocess(string pattern)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002C72 RID: 11378 RVA: 0x000C6E74 File Offset: 0x000C5074
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 412820, RefRangeEnd = 412832, XrefRangeStart = 412820, XrefRangeEnd = 412820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C73 RID: 11379 RVA: 0x000C6EDC File Offset: 0x000C50DC
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 412832, RefRangeEnd = 412842, XrefRangeStart = 412832, XrefRangeEnd = 412832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C74 RID: 11380 RVA: 0x000C6F44 File Offset: 0x000C5144
			[CallerCount(0)]
			public unsafe void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C75 RID: 11381 RVA: 0x000C6F9C File Offset: 0x000C519C
			[CallerCount(0)]
			public unsafe void SetFlag(RestrictionFlags flag)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref flag;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C76 RID: 11382 RVA: 0x000130C9 File Offset: 0x000112C9
			public FacetsCompiler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002C77 RID: 11383 RVA: 0x000130D2 File Offset: 0x000112D2
			public FacetsCompiler()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr))
			{
			}

			// Token: 0x17000F20 RID: 3872
			// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000C6FE0 File Offset: 0x000C51E0
			// (set) Token: 0x06002C79 RID: 11385 RVA: 0x000130E4 File Offset: 0x000112E4
			public unsafe DatatypeImplementation datatype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_datatype);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F21 RID: 3873
			// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000C7010 File Offset: 0x000C5210
			// (set) Token: 0x06002C7B RID: 11387 RVA: 0x00013103 File Offset: 0x00011303
			public unsafe RestrictionFacets derivedRestriction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_derivedRestriction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_derivedRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F22 RID: 3874
			// (get) Token: 0x06002C7C RID: 11388 RVA: 0x000C7040 File Offset: 0x000C5240
			// (set) Token: 0x06002C7D RID: 11389 RVA: 0x00013122 File Offset: 0x00011322
			public unsafe RestrictionFlags baseFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFlags)) = value;
				}
			}

			// Token: 0x17000F23 RID: 3875
			// (get) Token: 0x06002C7E RID: 11390 RVA: 0x000C7068 File Offset: 0x000C5268
			// (set) Token: 0x06002C7F RID: 11391 RVA: 0x0001313D File Offset: 0x0001133D
			public unsafe RestrictionFlags baseFixedFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFixedFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFixedFlags)) = value;
				}
			}

			// Token: 0x17000F24 RID: 3876
			// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000C7090 File Offset: 0x000C5290
			// (set) Token: 0x06002C81 RID: 11393 RVA: 0x00013158 File Offset: 0x00011358
			public unsafe RestrictionFlags validRestrictionFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_validRestrictionFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_validRestrictionFlags)) = value;
				}
			}

			// Token: 0x17000F25 RID: 3877
			// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000C70B8 File Offset: 0x000C52B8
			// (set) Token: 0x06002C83 RID: 11395 RVA: 0x00013173 File Offset: 0x00011373
			public unsafe XmlSchemaDatatype nonNegativeInt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_nonNegativeInt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_nonNegativeInt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F26 RID: 3878
			// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000C70E8 File Offset: 0x000C52E8
			// (set) Token: 0x06002C85 RID: 11397 RVA: 0x00013192 File Offset: 0x00011392
			public unsafe XmlSchemaDatatype builtInType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F27 RID: 3879
			// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000C7118 File Offset: 0x000C5318
			// (set) Token: 0x06002C87 RID: 11399 RVA: 0x000131B1 File Offset: 0x000113B1
			public unsafe XmlTypeCode builtInEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInEnum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInEnum)) = value;
				}
			}

			// Token: 0x17000F28 RID: 3880
			// (get) Token: 0x06002C88 RID: 11400 RVA: 0x000C7140 File Offset: 0x000C5340
			// (set) Token: 0x06002C89 RID: 11401 RVA: 0x000131CC File Offset: 0x000113CC
			public unsafe bool firstPattern
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_firstPattern);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_firstPattern)) = value;
				}
			}

			// Token: 0x17000F29 RID: 3881
			// (get) Token: 0x06002C8A RID: 11402 RVA: 0x000C7168 File Offset: 0x000C5368
			// (set) Token: 0x06002C8B RID: 11403 RVA: 0x000131E7 File Offset: 0x000113E7
			public unsafe StringBuilder regStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_regStr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_regStr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2A RID: 3882
			// (get) Token: 0x06002C8C RID: 11404 RVA: 0x000C7198 File Offset: 0x000C5398
			// (set) Token: 0x06002C8D RID: 11405 RVA: 0x00013206 File Offset: 0x00011406
			public unsafe XmlSchemaPatternFacet pattern_facet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_pattern_facet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaPatternFacet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_pattern_facet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2B RID: 3883
			// (get) Token: 0x06002C8E RID: 11406 RVA: 0x000C71C8 File Offset: 0x000C53C8
			// (set) Token: 0x06002C8F RID: 11407 RVA: 0x00013225 File Offset: 0x00011425
			public unsafe static Il2CppReferenceArray<FacetsChecker.FacetsCompiler.Map> c_map
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_c_map, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FacetsChecker.FacetsCompiler.Map>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_c_map, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002292 RID: 8850
			private static readonly IntPtr NativeFieldInfoPtr_datatype;

			// Token: 0x04002293 RID: 8851
			private static readonly IntPtr NativeFieldInfoPtr_derivedRestriction;

			// Token: 0x04002294 RID: 8852
			private static readonly IntPtr NativeFieldInfoPtr_baseFlags;

			// Token: 0x04002295 RID: 8853
			private static readonly IntPtr NativeFieldInfoPtr_baseFixedFlags;

			// Token: 0x04002296 RID: 8854
			private static readonly IntPtr NativeFieldInfoPtr_validRestrictionFlags;

			// Token: 0x04002297 RID: 8855
			private static readonly IntPtr NativeFieldInfoPtr_nonNegativeInt;

			// Token: 0x04002298 RID: 8856
			private static readonly IntPtr NativeFieldInfoPtr_builtInType;

			// Token: 0x04002299 RID: 8857
			private static readonly IntPtr NativeFieldInfoPtr_builtInEnum;

			// Token: 0x0400229A RID: 8858
			private static readonly IntPtr NativeFieldInfoPtr_firstPattern;

			// Token: 0x0400229B RID: 8859
			private static readonly IntPtr NativeFieldInfoPtr_regStr;

			// Token: 0x0400229C RID: 8860
			private static readonly IntPtr NativeFieldInfoPtr_pattern_facet;

			// Token: 0x0400229D RID: 8861
			private static readonly IntPtr NativeFieldInfoPtr_c_map;

			// Token: 0x0400229E RID: 8862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0;

			// Token: 0x0400229F RID: 8863
			private static readonly IntPtr NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A0 RID: 8864
			private static readonly IntPtr NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A1 RID: 8865
			private static readonly IntPtr NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A2 RID: 8866
			private static readonly IntPtr NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0;

			// Token: 0x040022A3 RID: 8867
			private static readonly IntPtr NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0;

			// Token: 0x040022A4 RID: 8868
			private static readonly IntPtr NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A5 RID: 8869
			private static readonly IntPtr NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A6 RID: 8870
			private static readonly IntPtr NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A7 RID: 8871
			private static readonly IntPtr NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A8 RID: 8872
			private static readonly IntPtr NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022A9 RID: 8873
			private static readonly IntPtr NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022AA RID: 8874
			private static readonly IntPtr NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x040022AB RID: 8875
			private static readonly IntPtr NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0;

			// Token: 0x040022AC RID: 8876
			private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0;

			// Token: 0x040022AD RID: 8877
			private static readonly IntPtr NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0;

			// Token: 0x040022AE RID: 8878
			private static readonly IntPtr NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0;

			// Token: 0x040022AF RID: 8879
			private static readonly IntPtr NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0;

			// Token: 0x040022B0 RID: 8880
			private static readonly IntPtr NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0;

			// Token: 0x040022B1 RID: 8881
			private static readonly IntPtr NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0;

			// Token: 0x040022B2 RID: 8882
			private static readonly IntPtr NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0;

			// Token: 0x040022B3 RID: 8883
			private static readonly IntPtr NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0;

			// Token: 0x040022B4 RID: 8884
			private static readonly IntPtr NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0;

			// Token: 0x0200026F RID: 623
			public sealed class Map : ValueType
			{
				// Token: 0x06002E18 RID: 11800 RVA: 0x000CAFC8 File Offset: 0x000C91C8
				// Note: this type is marked as 'beforefieldinit'.
				static Map()
				{
					Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "Map");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr);
					FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr, "match");
					FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_replacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr, "replacement");
					FacetsChecker.FacetsCompiler.Map.NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr, 100667204);
				}

				// Token: 0x06002E19 RID: 11801 RVA: 0x000CB030 File Offset: 0x000C9230
				[CallerCount(0)]
				public unsafe Map(char m, string r)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref m;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.Map.NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002E1A RID: 11802 RVA: 0x00014251 File Offset: 0x00012451
				public Map(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002E1B RID: 11803 RVA: 0x0001425A File Offset: 0x0001245A
				public Map()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr))
				{
				}

				// Token: 0x17000F97 RID: 3991
				// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000CB090 File Offset: 0x000C9290
				// (set) Token: 0x06002E1D RID: 11805 RVA: 0x0001426C File Offset: 0x0001246C
				public unsafe char match
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_match);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_match)) = value;
					}
				}

				// Token: 0x17000F98 RID: 3992
				// (get) Token: 0x06002E1E RID: 11806 RVA: 0x000CB0B8 File Offset: 0x000C92B8
				// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00014287 File Offset: 0x00012487
				public unsafe string replacement
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_replacement);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_replacement), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400245E RID: 9310
				private static readonly IntPtr NativeFieldInfoPtr_match;

				// Token: 0x0400245F RID: 9311
				private static readonly IntPtr NativeFieldInfoPtr_replacement;

				// Token: 0x04002460 RID: 9312
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0;
			}
		}
	}
}
