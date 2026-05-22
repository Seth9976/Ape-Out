using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001EE RID: 494
	public static class EnumTools : Object
	{
		// Token: 0x06003233 RID: 12851 RVA: 0x000F9ECC File Offset: 0x000F80CC
		// Note: this type is marked as 'beforefieldinit'.
		static EnumTools()
		{
			Il2CppClassPointerStore<EnumTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "EnumTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumTools>.NativeClassPtr);
			EnumTools.NativeMethodInfoPtr_GetName_Public_Static_String_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumTools>.NativeClassPtr, 100675991);
			EnumTools.NativeMethodInfoPtr_ConvertByName_Public_Static_Boolean_TEnumFrom_byref_TEnumTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumTools>.NativeClassPtr, 100675992);
			EnumTools.NativeMethodInfoPtr_GetIntValues_Public_Static_Il2CppStructArray_1_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumTools>.NativeClassPtr, 100675993);
			EnumTools.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumTools>.NativeClassPtr, 100675994);
			EnumTools.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumTools>.NativeClassPtr, 100675995);
			EnumTools.NativeMethodInfoPtr_IsValidUnderlyingType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumTools>.NativeClassPtr, 100675996);
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x000F9F74 File Offset: 0x000F8174
		[CallerCount(0)]
		public unsafe static string GetName<TEnum>(TEnum value) where TEnum : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TEnum ptr4;
				if (!typeof(TEnum).IsValueType)
				{
					TEnum tenum = value;
					if (!(tenum is string))
					{
						ref TEnum ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tenum as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tenum as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumTools.MethodInfoStoreGeneric_GetName_Public_Static_String_TEnum_0<TEnum>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x000F9FFC File Offset: 0x000F81FC
		[CallerCount(0)]
		public unsafe static bool ConvertByName<TEnumFrom, TEnumTo>(TEnumFrom convertFrom, out TEnumTo value) where TEnumFrom : new() where TEnumTo : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TEnumFrom ptr4;
				if (!typeof(TEnumFrom).IsValueType)
				{
					TEnumFrom tenumFrom = convertFrom;
					if (!(tenumFrom is string))
					{
						ref TEnumFrom ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tenumFrom as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tenumFrom as string);
					}
				}
				else
				{
					ptr4 = ref convertFrom;
				}
				*ptr2 = ref ptr4;
			}
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TEnumTo).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumTools.MethodInfoStoreGeneric_ConvertByName_Public_Static_Boolean_TEnumFrom_byref_TEnumTo_0<TEnumFrom, TEnumTo>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TEnumTo).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TEnumTo>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x000FA0D8 File Offset: 0x000F82D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337956, XrefRangeEnd = 337969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetIntValues(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumTools.NativeMethodInfoPtr_GetIntValues_Public_Static_Il2CppStructArray_1_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x000FA11C File Offset: 0x000F831C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337969, RefRangeEnd = 337970, XrefRangeStart = 337969, XrefRangeEnd = 337969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEnum(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumTools.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000FA160 File Offset: 0x000F8360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337970, XrefRangeEnd = 337971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetUnderlyingType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumTools.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000FA1A4 File Offset: 0x000F83A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337971, XrefRangeEnd = 338012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidUnderlyingType(Type underlyingType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumTools.NativeMethodInfoPtr_IsValidUnderlyingType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x00011D05 File Offset: 0x0000FF05
		public EnumTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_TEnum_0;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeMethodInfoPtr_ConvertByName_Public_Static_Boolean_TEnumFrom_byref_TEnumTo_0;

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeMethodInfoPtr_GetIntValues_Public_Static_Il2CppStructArray_1_Int32_Type_0;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeMethodInfoPtr_IsValidUnderlyingType_Public_Static_Boolean_Type_0;

		// Token: 0x02000433 RID: 1075
		private sealed class MethodInfoStoreGeneric_GetName_Public_Static_String_TEnum_0<TEnum>
		{
			// Token: 0x0400437A RID: 17274
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumTools.NativeMethodInfoPtr_GetName_Public_Static_String_TEnum_0, Il2CppClassPointerStore<EnumTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
		}

		// Token: 0x02000434 RID: 1076
		private sealed class MethodInfoStoreGeneric_ConvertByName_Public_Static_Boolean_TEnumFrom_byref_TEnumTo_0<TEnumFrom, TEnumTo>
		{
			// Token: 0x0400437B RID: 17275
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumTools.NativeMethodInfoPtr_ConvertByName_Public_Static_Boolean_TEnumFrom_byref_TEnumTo_0, Il2CppClassPointerStore<EnumTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumFrom>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumTo>.NativeClassPtr))
			}))));
		}
	}
}
