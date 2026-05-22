using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200009A RID: 154
	[Serializable]
	public class DefaultBinder : Binder
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00054B48 File Offset: 0x00052D48
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultBinder()
		{
			Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DefaultBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr);
			DefaultBinder.NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665136);
			DefaultBinder.NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665137);
			DefaultBinder.NativeMethodInfoPtr_SelectMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665138);
			DefaultBinder.NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665139);
			DefaultBinder.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665140);
			DefaultBinder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665141);
			DefaultBinder.NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665142);
			DefaultBinder.NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665143);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665144);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665145);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665146);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665147);
			DefaultBinder.NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665148);
			DefaultBinder.NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665149);
			DefaultBinder.NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665150);
			DefaultBinder.NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665151);
			DefaultBinder.NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665152);
			DefaultBinder.NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665153);
			DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665154);
			DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665155);
			DefaultBinder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, 100665156);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00054D1C File Offset: 0x00052F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152671, XrefRangeEnd = 152842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodBase BindToMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, ref Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo cultureInfo, Il2CppStringArray names, out Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			args = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			state = ((intPtr6 == 0) ? null : new Object(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr7) : null;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00054E0C File Offset: 0x0005300C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152842, XrefRangeEnd = 152886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FieldInfo BindToField(BindingFlags bindingAttr, Il2CppReferenceArray<FieldInfo> match, Object value, CultureInfo cultureInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00054E9C File Offset: 0x0005309C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152886, XrefRangeEnd = 152949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodBase SelectMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_SelectMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00054F2C File Offset: 0x0005312C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152949, XrefRangeEnd = 153024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PropertyInfo SelectProperty(BindingFlags bindingAttr, Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> indexes, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00054FD0 File Offset: 0x000531D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153024, XrefRangeEnd = 153031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Object value, Type type, CultureInfo cultureInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00055050 File Offset: 0x00053250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153031, XrefRangeEnd = 153038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReorderArgumentArray(ref Il2CppReferenceArray<Object> args, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultBinder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000550C4 File Offset: 0x000532C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153046, RefRangeEnd = 153047, XrefRangeStart = 153038, XrefRangeEnd = 153046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase ExactBinding(Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0005512C File Offset: 0x0005332C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153047, XrefRangeEnd = 153059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo ExactPropertyBinding(Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000551A8 File Offset: 0x000533A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153085, RefRangeEnd = 153086, XrefRangeStart = 153059, XrefRangeEnd = 153085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecific(Il2CppReferenceArray<ParameterInfo> p1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, Il2CppReferenceArray<ParameterInfo> p2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType2);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0005526C File Offset: 0x0005346C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 153107, RefRangeEnd = 153111, XrefRangeStart = 153086, XrefRangeEnd = 153107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificType(Type c1, Type c2, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000552D4 File Offset: 0x000534D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153115, RefRangeEnd = 153116, XrefRangeStart = 153111, XrefRangeEnd = 153115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificMethod(MethodBase m1, Il2CppStructArray<int> paramOrder1, Type paramArrayType1, MethodBase m2, Il2CppStructArray<int> paramOrder2, Type paramArrayType2, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramOrder2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramArrayType2);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00055398 File Offset: 0x00053598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153118, RefRangeEnd = 153119, XrefRangeStart = 153116, XrefRangeEnd = 153118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cur2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000553EC File Offset: 0x000535EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153118, RefRangeEnd = 153119, XrefRangeStart = 153118, XrefRangeEnd = 153119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cur2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00055440 File Offset: 0x00053640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153122, RefRangeEnd = 153125, XrefRangeStart = 153119, XrefRangeEnd = 153122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00055494 File Offset: 0x00053694
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 153128, RefRangeEnd = 153135, XrefRangeStart = 153125, XrefRangeEnd = 153128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHierarchyDepth(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000554D8 File Offset: 0x000536D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153136, RefRangeEnd = 153138, XrefRangeStart = 153135, XrefRangeEnd = 153136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase FindMostDerivedNewSlotMeth(Il2CppReferenceArray<MethodBase> match, int cMatches)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMatches;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0005552C File Offset: 0x0005372C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153147, RefRangeEnd = 153149, XrefRangeStart = 153138, XrefRangeEnd = 153147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorderParams(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<Object> vars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramOrder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00055574 File Offset: 0x00053774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153157, RefRangeEnd = 153158, XrefRangeStart = 153149, XrefRangeEnd = 153157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateParamOrder(Il2CppStructArray<int> paramOrder, Il2CppReferenceArray<ParameterInfo> pars, Il2CppStringArray names)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paramOrder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pars);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000555DC File Offset: 0x000537DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 153176, RefRangeEnd = 153183, XrefRangeStart = 153158, XrefRangeEnd = 153176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertPrimitive(RuntimeType source, RuntimeType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00055630 File Offset: 0x00053830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153191, RefRangeEnd = 153194, XrefRangeStart = 153183, XrefRangeEnd = 153191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertPrimitiveObjectToType(Object source, RuntimeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00055684 File Offset: 0x00053884
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00004D86 File Offset: 0x00002F86
		public DefaultBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_BindToMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_BindToField_Public_Virtual_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_SelectMethod_Public_Virtual_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_SelectProperty_Public_Virtual_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_CultureInfo_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_ReorderArgumentArray_Public_Virtual_Void_byref_Il2CppReferenceArray_1_Object_Object_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_ExactBinding_Public_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_ExactPropertyBinding_Public_Static_PropertyInfo_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecific_Private_Static_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_ParameterInfo_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificType_Private_Static_Int32_Type_Type_Type_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificMethod_Private_Static_Int32_MethodBase_Il2CppStructArray_1_Int32_Type_MethodBase_Il2CppStructArray_1_Int32_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificField_Private_Static_Int32_FieldInfo_FieldInfo_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_FindMostSpecificProperty_Private_Static_Int32_PropertyInfo_PropertyInfo_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_CompareMethodSigAndName_Internal_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_GetHierarchyDepth_Internal_Static_Int32_Type_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_FindMostDerivedNewSlotMeth_Internal_Static_MethodBase_Il2CppReferenceArray_1_MethodBase_Int32_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_ReorderParams_Private_Static_Void_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_CreateParamOrder_Private_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ParameterInfo_Il2CppStringArray_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertPrimitive_Private_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertPrimitiveObjectToType_Private_Static_Boolean_Object_RuntimeType_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200058F RID: 1423
		public class BinderState : Object
		{
			// Token: 0x0600506D RID: 20589 RVA: 0x0016D8C4 File Offset: 0x0016BAC4
			// Note: this type is marked as 'beforefieldinit'.
			static BinderState()
			{
				Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "BinderState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr);
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_argsMap");
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_originalSize");
				DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, "m_isParamArray");
				DefaultBinder.BinderState.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr, 100665157);
			}

			// Token: 0x0600506E RID: 20590 RVA: 0x0016D940 File Offset: 0x0016BB40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 152667, RefRangeEnd = 152668, XrefRangeStart = 152667, XrefRangeEnd = 152667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BinderState(Il2CppStructArray<int> argsMap, int originalSize, bool isParamArray)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder.BinderState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(argsMap);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isParamArray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.BinderState.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600506F RID: 20591 RVA: 0x0001E0C5 File Offset: 0x0001C2C5
			public BinderState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001483 RID: 5251
			// (get) Token: 0x06005070 RID: 20592 RVA: 0x0016D9A8 File Offset: 0x0016BBA8
			// (set) Token: 0x06005071 RID: 20593 RVA: 0x0001E0CE File Offset: 0x0001C2CE
			public unsafe Il2CppStructArray<int> m_argsMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_argsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001484 RID: 5252
			// (get) Token: 0x06005072 RID: 20594 RVA: 0x0016D9D8 File Offset: 0x0016BBD8
			// (set) Token: 0x06005073 RID: 20595 RVA: 0x0001E0ED File Offset: 0x0001C2ED
			public unsafe int m_originalSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_originalSize)) = value;
				}
			}

			// Token: 0x17001485 RID: 5253
			// (get) Token: 0x06005074 RID: 20596 RVA: 0x0016DA00 File Offset: 0x0016BC00
			// (set) Token: 0x06005075 RID: 20597 RVA: 0x0001E108 File Offset: 0x0001C308
			public unsafe bool m_isParamArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultBinder.BinderState.NativeFieldInfoPtr_m_isParamArray)) = value;
				}
			}

			// Token: 0x040040E9 RID: 16617
			private static readonly IntPtr NativeFieldInfoPtr_m_argsMap;

			// Token: 0x040040EA RID: 16618
			private static readonly IntPtr NativeFieldInfoPtr_m_originalSize;

			// Token: 0x040040EB RID: 16619
			private static readonly IntPtr NativeFieldInfoPtr_m_isParamArray;

			// Token: 0x040040EC RID: 16620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;
		}

		// Token: 0x02000590 RID: 1424
		[ObfuscatedName("System.DefaultBinder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005076 RID: 20598 RVA: 0x0016DA28 File Offset: 0x0016BC28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultBinder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr);
				DefaultBinder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, "<>9");
				DefaultBinder.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, "<>9__3_0");
				DefaultBinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, 100665159);
				DefaultBinder.__c.NativeMethodInfoPtr__SelectProperty_b__3_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr, 100665160);
			}

			// Token: 0x06005077 RID: 20599 RVA: 0x0016DAA4 File Offset: 0x0016BCA4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBinder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005078 RID: 20600 RVA: 0x0016DAE0 File Offset: 0x0016BCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152668, XrefRangeEnd = 152671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectProperty_b__3_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultBinder.__c.NativeMethodInfoPtr__SelectProperty_b__3_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005079 RID: 20601 RVA: 0x0001E123 File Offset: 0x0001C323
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001486 RID: 5254
			// (get) Token: 0x0600507A RID: 20602 RVA: 0x0016DB30 File Offset: 0x0016BD30
			// (set) Token: 0x0600507B RID: 20603 RVA: 0x0001E12C File Offset: 0x0001C32C
			public unsafe static DefaultBinder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultBinder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultBinder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultBinder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001487 RID: 5255
			// (get) Token: 0x0600507C RID: 20604 RVA: 0x0016DB58 File Offset: 0x0016BD58
			// (set) Token: 0x0600507D RID: 20605 RVA: 0x0001E13E File Offset: 0x0001C33E
			public unsafe static Predicate<Type> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultBinder.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultBinder.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040ED RID: 16621
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040040EE RID: 16622
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040040EF RID: 16623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040040F0 RID: 16624
			private static readonly IntPtr NativeMethodInfoPtr__SelectProperty_b__3_0_Internal_Boolean_Type_0;
		}
	}
}
