using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F5 RID: 501
	public static class ReflectionTools : Object
	{
		// Token: 0x06003346 RID: 13126 RVA: 0x000FFE0C File Offset: 0x000FE00C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionTools()
		{
			Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "ReflectionTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr);
			ReflectionTools.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676221);
			ReflectionTools.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676222);
			ReflectionTools.NativeMethodInfoPtr_GetUnderlyingEnumType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676223);
			ReflectionTools.NativeMethodInfoPtr_IsClass_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676224);
			ReflectionTools.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676225);
			ReflectionTools.NativeMethodInfoPtr_IsArray_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676226);
			ReflectionTools.NativeMethodInfoPtr_DoesTypeImplement_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676227);
			ReflectionTools.NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676228);
			ReflectionTools.NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676229);
			ReflectionTools.NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676230);
			ReflectionTools.NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676231);
			ReflectionTools.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676232);
			ReflectionTools.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676233);
			ReflectionTools.NativeMethodInfoPtr_GetMethods_Public_Static_IEnumerable_1_MethodInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676234);
			ReflectionTools.NativeMethodInfoPtr_GetMethods_Public_Static_IEnumerable_1_MethodInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676235);
			ReflectionTools.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676236);
			ReflectionTools.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676237);
			ReflectionTools.NativeMethodInfoPtr_IsAssemblyLoaded_Internal_Static_Boolean_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676238);
			ReflectionTools.NativeMethodInfoPtr_GetTypeInUnityEditorAssembly_Internal_Static_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676239);
			ReflectionTools.NativeMethodInfoPtr_GetTypeInUnityBuildAssembly_Internal_Static_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676240);
			ReflectionTools.NativeMethodInfoPtr_bliqAJZMJUZjeLGpxNeLhueafqr_Private_Static_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676241);
			ReflectionTools.NativeMethodInfoPtr_GetTypeInAssembly_Internal_Static_Type_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676242);
			ReflectionTools.NativeMethodInfoPtr_GetPrivateField_Public_Static_TRet_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676243);
			ReflectionTools.NativeMethodInfoPtr_GetPrivateProperty_Public_Static_TRet_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676244);
			ReflectionTools.NativeMethodInfoPtr_SetPrivateField_Public_Static_Void_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676245);
			ReflectionTools.NativeMethodInfoPtr_SetPrivateProperty_Public_Static_Void_T_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676246);
			ReflectionTools.NativeMethodInfoPtr_CallPrivateMethod_Public_Static_TRet_T_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676247);
			ReflectionTools.NativeMethodInfoPtr_GetMethodInfo_Public_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr, 100676248);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x0010006C File Offset: 0x000FE26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x001000B0 File Offset: 0x000FE2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337969, RefRangeEnd = 337970, XrefRangeStart = 337969, XrefRangeEnd = 337970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEnum(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x001000F4 File Offset: 0x000FE2F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 339132, RefRangeEnd = 339137, XrefRangeStart = 339126, XrefRangeEnd = 339132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetUnderlyingEnumType(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetUnderlyingEnumType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x00100138 File Offset: 0x000FE338
		[CallerCount(0)]
		public unsafe static bool IsClass(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsClass_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x0010017C File Offset: 0x000FE37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339137, XrefRangeEnd = 339138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitive(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x001001C0 File Offset: 0x000FE3C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339139, RefRangeEnd = 339140, XrefRangeStart = 339138, XrefRangeEnd = 339139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArray(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsArray_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00100204 File Offset: 0x000FE404
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 339141, RefRangeEnd = 339156, XrefRangeStart = 339140, XrefRangeEnd = 339141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesTypeImplement(Type type, Type baseOrInterfaceType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseOrInterfaceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_DoesTypeImplement_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00100258 File Offset: 0x000FE458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339156, RefRangeEnd = 339157, XrefRangeStart = 339156, XrefRangeEnd = 339156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0010029C File Offset: 0x000FE49C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339157, RefRangeEnd = 339160, XrefRangeStart = 339157, XrefRangeEnd = 339157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetGenericArguments(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x001002E0 File Offset: 0x000FE4E0
		[CallerCount(0)]
		public unsafe static IEnumerable<FieldInfo> GetFields(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00100324 File Offset: 0x000FE524
		[CallerCount(0)]
		public unsafe static IEnumerable<FieldInfo> GetFields(Type type, ReflectionTools.BindingFlags bindingFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FieldInfo>>(intPtr3) : null;
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00100378 File Offset: 0x000FE578
		[CallerCount(0)]
		public unsafe static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x001003BC File Offset: 0x000FE5BC
		[CallerCount(0)]
		public unsafe static IEnumerable<PropertyInfo> GetProperties(Type type, ReflectionTools.BindingFlags bindingFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PropertyInfo>>(intPtr3) : null;
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x00100410 File Offset: 0x000FE610
		[CallerCount(0)]
		public unsafe static IEnumerable<MethodInfo> GetMethods(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetMethods_Public_Static_IEnumerable_1_MethodInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00100454 File Offset: 0x000FE654
		[CallerCount(0)]
		public unsafe static IEnumerable<MethodInfo> GetMethods(Type type, ReflectionTools.BindingFlags bindingFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetMethods_Public_Static_IEnumerable_1_MethodInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MethodInfo>>(intPtr3) : null;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x001004A8 File Offset: 0x000FE6A8
		[CallerCount(0)]
		public unsafe static bool IsDefined(Type type, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x0010050C File Offset: 0x000FE70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339170, RefRangeEnd = 339171, XrefRangeStart = 339160, XrefRangeEnd = 339170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute<T>(Type type, bool inherit) where T : Attribute
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Type_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00100558 File Offset: 0x000FE758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339188, RefRangeEnd = 339189, XrefRangeStart = 339171, XrefRangeEnd = 339188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useShortName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_IsAssemblyLoaded_Internal_Static_Boolean_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x001005B8 File Offset: 0x000FE7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339189, XrefRangeEnd = 339190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeInUnityEditorAssembly(string classPath, bool ignoreCase = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(classPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetTypeInUnityEditorAssembly_Internal_Static_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x0010060C File Offset: 0x000FE80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339190, XrefRangeEnd = 339191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeInUnityBuildAssembly(string classPath, bool ignoreCase = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(classPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetTypeInUnityBuildAssembly_Internal_Static_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00100660 File Offset: 0x000FE860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339197, RefRangeEnd = 339199, XrefRangeStart = 339191, XrefRangeEnd = 339197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type bliqAJZMJUZjeLGpxNeLhueafqr(string A_0, bool A_1, bool A_2 = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_bliqAJZMJUZjeLGpxNeLhueafqr_Private_Static_Type_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x001006C0 File Offset: 0x000FE8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339199, XrefRangeEnd = 339211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(classPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetTypeInAssembly_Internal_Static_Type_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00100724 File Offset: 0x000FE924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339211, XrefRangeEnd = 339216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TRet GetPrivateField<T, TRet>(T obj, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.MethodInfoStoreGeneric_GetPrivateField_Public_Static_TRet_T_String_0<T, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr, false, true);
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x001007C0 File Offset: 0x000FE9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339216, XrefRangeEnd = 339222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TRet GetPrivateProperty<T, TRet>(T obj, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.MethodInfoStoreGeneric_GetPrivateProperty_Public_Static_TRet_T_String_0<T, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr, false, true);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x0010085C File Offset: 0x000FEA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339222, XrefRangeEnd = 339226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPrivateField<T>(T obj, string name, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.MethodInfoStoreGeneric_SetPrivateField_Public_Static_Void_T_String_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00100904 File Offset: 0x000FEB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339226, XrefRangeEnd = 339230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPrivateProperty<T>(T obj, string name, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.MethodInfoStoreGeneric_SetPrivateProperty_Public_Static_Void_T_String_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x001009AC File Offset: 0x000FEBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339230, XrefRangeEnd = 339236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TRet CallPrivateMethod<T, TRet>(T obj, string name, [Optional] Il2CppReferenceArray<Object> param)
		{
			if (param == null)
			{
				param = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(param);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.MethodInfoStoreGeneric_CallPrivateMethod_Public_Static_TRet_T_String_Il2CppReferenceArray_1_Object_0<T, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr, false, true);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00100A68 File Offset: 0x000FEC68
		[CallerCount(0)]
		public unsafe static MethodInfo GetMethodInfo(Delegate @delegate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@delegate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTools.NativeMethodInfoPtr_GetMethodInfo_Public_Static_MethodInfo_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00011E28 File Offset: 0x00010028
		public static TRet CallPrivateMethod<T, TRet>(T obj, string name, params Object[] param)
		{
			return ReflectionTools.CallPrivateMethod(obj, name, new Il2CppReferenceArray<Object>(param));
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00011E37 File Offset: 0x00010037
		public ReflectionTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0;

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlyingEnumType_Public_Static_Type_Type_0;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeMethodInfoPtr_IsClass_Public_Static_Boolean_Type_0;

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeMethodInfoPtr_IsArray_Public_Static_Boolean_Type_0;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeMethodInfoPtr_DoesTypeImplement_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_0;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_BindingFlags_0;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0;

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_BindingFlags_0;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Static_IEnumerable_1_MethodInfo_Type_0;

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Static_IEnumerable_1_MethodInfo_Type_BindingFlags_0;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Type_Boolean_0;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_T_Type_Boolean_0;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeMethodInfoPtr_IsAssemblyLoaded_Internal_Static_Boolean_String_Boolean_Boolean_0;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInUnityEditorAssembly_Internal_Static_Type_String_Boolean_0;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInUnityBuildAssembly_Internal_Static_Type_String_Boolean_0;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeMethodInfoPtr_bliqAJZMJUZjeLGpxNeLhueafqr_Private_Static_Type_String_Boolean_Boolean_0;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInAssembly_Internal_Static_Type_String_String_Boolean_0;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeMethodInfoPtr_GetPrivateField_Public_Static_TRet_T_String_0;

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeMethodInfoPtr_GetPrivateProperty_Public_Static_TRet_T_String_0;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeMethodInfoPtr_SetPrivateField_Public_Static_Void_T_String_Object_0;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeMethodInfoPtr_SetPrivateProperty_Public_Static_Void_T_String_Object_0;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeMethodInfoPtr_CallPrivateMethod_Public_Static_TRet_T_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Public_Static_MethodInfo_Delegate_0;

		// Token: 0x0200044C RID: 1100
		[OriginalName("Rewired_Core.dll", "", "BindingFlags")]
		[Flags]
		public enum BindingFlags
		{
			// Token: 0x04004394 RID: 17300
			IgnoreCase = 1,
			// Token: 0x04004395 RID: 17301
			DeclaredOnly = 2,
			// Token: 0x04004396 RID: 17302
			Instance = 4,
			// Token: 0x04004397 RID: 17303
			Static = 8,
			// Token: 0x04004398 RID: 17304
			Public = 16,
			// Token: 0x04004399 RID: 17305
			NonPublic = 32,
			// Token: 0x0400439A RID: 17306
			FlattenHierarchy = 64
		}

		// Token: 0x0200044D RID: 1101
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Type_Boolean_0<T>
		{
			// Token: 0x0400439B RID: 17307
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionTools.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Type_Boolean_0, Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200044E RID: 1102
		private sealed class MethodInfoStoreGeneric_GetPrivateField_Public_Static_TRet_T_String_0<T, TRet>
		{
			// Token: 0x0400439C RID: 17308
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionTools.NativeMethodInfoPtr_GetPrivateField_Public_Static_TRet_T_String_0, Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200044F RID: 1103
		private sealed class MethodInfoStoreGeneric_GetPrivateProperty_Public_Static_TRet_T_String_0<T, TRet>
		{
			// Token: 0x0400439D RID: 17309
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionTools.NativeMethodInfoPtr_GetPrivateProperty_Public_Static_TRet_T_String_0, Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000450 RID: 1104
		private sealed class MethodInfoStoreGeneric_SetPrivateField_Public_Static_Void_T_String_Object_0<T>
		{
			// Token: 0x0400439E RID: 17310
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionTools.NativeMethodInfoPtr_SetPrivateField_Public_Static_Void_T_String_Object_0, Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000451 RID: 1105
		private sealed class MethodInfoStoreGeneric_SetPrivateProperty_Public_Static_Void_T_String_Object_0<T>
		{
			// Token: 0x0400439F RID: 17311
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionTools.NativeMethodInfoPtr_SetPrivateProperty_Public_Static_Void_T_String_Object_0, Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000452 RID: 1106
		private sealed class MethodInfoStoreGeneric_CallPrivateMethod_Public_Static_TRet_T_String_Il2CppReferenceArray_1_Object_0<T, TRet>
		{
			// Token: 0x040043A0 RID: 17312
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionTools.NativeMethodInfoPtr_CallPrivateMethod_Public_Static_TRet_T_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<ReflectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}
	}
}
