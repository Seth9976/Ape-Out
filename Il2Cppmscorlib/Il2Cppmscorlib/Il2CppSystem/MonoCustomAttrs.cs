using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000123 RID: 291
	public static class MonoCustomAttrs : Object
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x00083A88 File Offset: 0x00081C88
		// Note: this type is marked as 'beforefieldinit'.
		static MonoCustomAttrs()
		{
			Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoCustomAttrs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr);
			MonoCustomAttrs.NativeFieldInfoPtr_corlib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "corlib");
			MonoCustomAttrs.NativeFieldInfoPtr_usage_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "usage_cache");
			MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "DefaultAttributeUsage");
			MonoCustomAttrs.NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666919);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666920);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666921);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666922);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666923);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666924);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666925);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666926);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666927);
			MonoCustomAttrs.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666928);
			MonoCustomAttrs.NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666929);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_MonoProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666930);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_MonoEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666931);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666932);
			MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666933);
			MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666934);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00083C34 File Offset: 0x00081E34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175641, RefRangeEnd = 175644, XrefRangeStart = 175635, XrefRangeEnd = 175641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUserCattrProvider(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00083C78 File Offset: 0x00081E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175644, XrefRangeEnd = 175645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pseudoAttrs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00083CDC File Offset: 0x00081EDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175702, RefRangeEnd = 175704, XrefRangeStart = 175645, XrefRangeEnd = 175702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00083D34 File Offset: 0x00081F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175704, XrefRangeEnd = 175717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00083D78 File Offset: 0x00081F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175735, RefRangeEnd = 175736, XrefRangeStart = 175717, XrefRangeEnd = 175735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritedOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00083DDC File Offset: 0x00081FDC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 175844, RefRangeEnd = 175858, XrefRangeStart = 175736, XrefRangeEnd = 175844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00083E40 File Offset: 0x00082040
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 175869, RefRangeEnd = 175877, XrefRangeStart = 175858, XrefRangeEnd = 175869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00083E94 File Offset: 0x00082094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175877, XrefRangeEnd = 175884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CustomAttributeData> GetCustomAttributesDataInternal(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00083ED8 File Offset: 0x000820D8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 175899, RefRangeEnd = 175911, XrefRangeStart = 175884, XrefRangeEnd = 175899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00083F1C File Offset: 0x0008211C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 175934, RefRangeEnd = 175945, XrefRangeStart = 175911, XrefRangeEnd = 175934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00083F80 File Offset: 0x00082180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175945, XrefRangeEnd = 175947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(AttributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00083FD4 File Offset: 0x000821D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175958, RefRangeEnd = 175959, XrefRangeStart = 175947, XrefRangeEnd = 175958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetBasePropertyDefinition(MonoProperty property)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_MonoProperty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00084018 File Offset: 0x00082218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175959, XrefRangeEnd = 175964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventInfo GetBaseEventDefinition(MonoEvent evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_MonoEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0008405C File Offset: 0x0008225C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175982, RefRangeEnd = 175985, XrefRangeStart = 175964, XrefRangeEnd = 175982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomAttributeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000840A0 File Offset: 0x000822A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175985, XrefRangeEnd = 176010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x000840E4 File Offset: 0x000822E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176031, RefRangeEnd = 176035, XrefRangeStart = 176010, XrefRangeEnd = 176031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000072E2 File Offset: 0x000054E2
		public MonoCustomAttrs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00084128 File Offset: 0x00082328
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x000072EB File Offset: 0x000054EB
		public unsafe static Assembly corlib
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_corlib, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_corlib, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x00084150 File Offset: 0x00082350
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x000072FD File Offset: 0x000054FD
		public unsafe static Dictionary<Type, AttributeUsageAttribute> usage_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_usage_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, AttributeUsageAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_usage_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00084178 File Offset: 0x00082378
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0000730F File Offset: 0x0000550F
		public unsafe static AttributeUsageAttribute DefaultAttributeUsage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeFieldInfoPtr_corlib;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeFieldInfoPtr_usage_cache;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAttributeUsage;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_MonoProperty_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_MonoEvent_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0;

		// Token: 0x020005AD RID: 1453
		public class AttributeInfo : Object
		{
			// Token: 0x06005159 RID: 20825 RVA: 0x00170900 File Offset: 0x0016EB00
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeInfo()
			{
				Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "AttributeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr);
				MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, "_usage");
				MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, "_inheritanceLevel");
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100666936);
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100666937);
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100666938);
			}

			// Token: 0x0600515A RID: 20826 RVA: 0x00170990 File Offset: 0x0016EB90
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(usage);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritanceLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014CC RID: 5324
			// (get) Token: 0x0600515B RID: 20827 RVA: 0x001709EC File Offset: 0x0016EBEC
			public unsafe AttributeUsageAttribute Usage
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x170014CD RID: 5325
			// (get) Token: 0x0600515C RID: 20828 RVA: 0x00170A2C File Offset: 0x0016EC2C
			public unsafe int InheritanceLevel
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600515D RID: 20829 RVA: 0x0001E84C File Offset: 0x0001CA4C
			public AttributeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014CA RID: 5322
			// (get) Token: 0x0600515E RID: 20830 RVA: 0x00170A68 File Offset: 0x0016EC68
			// (set) Token: 0x0600515F RID: 20831 RVA: 0x0001E855 File Offset: 0x0001CA55
			public unsafe AttributeUsageAttribute _usage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014CB RID: 5323
			// (get) Token: 0x06005160 RID: 20832 RVA: 0x00170A98 File Offset: 0x0016EC98
			// (set) Token: 0x06005161 RID: 20833 RVA: 0x0001E874 File Offset: 0x0001CA74
			public unsafe int _inheritanceLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel)) = value;
				}
			}

			// Token: 0x04004239 RID: 16953
			private static readonly IntPtr NativeFieldInfoPtr__usage;

			// Token: 0x0400423A RID: 16954
			private static readonly IntPtr NativeFieldInfoPtr__inheritanceLevel;

			// Token: 0x0400423B RID: 16955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0;

			// Token: 0x0400423C RID: 16956
			private static readonly IntPtr NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0;

			// Token: 0x0400423D RID: 16957
			private static readonly IntPtr NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0;
		}
	}
}
