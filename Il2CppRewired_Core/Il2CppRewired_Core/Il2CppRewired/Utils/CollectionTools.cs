using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001ED RID: 493
	public static class CollectionTools : Object
	{
		// Token: 0x06003225 RID: 12837 RVA: 0x000F98A4 File Offset: 0x000F7AA4
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionTools()
		{
			Il2CppClassPointerStore<CollectionTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "CollectionTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr);
			CollectionTools.NativeMethodInfoPtr_CreateInverseDictionary_Public_Static_Dictionary_2_TValue_TKey_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675979);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675980);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675981);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675982);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675983);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_TReturn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675984);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675985);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_float_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675986);
			CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_int_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675987);
			CollectionTools.NativeMethodInfoPtr_AddValueSafe_Public_Static_Void_Dictionary_2_String_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675988);
			CollectionTools.NativeMethodInfoPtr_GetValue_Public_Static_T_IEnumerable_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675989);
			CollectionTools.NativeMethodInfoPtr_GetValue_Public_Static_T_IEnumerable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionTools>.NativeClassPtr, 100675990);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000F99C4 File Offset: 0x000F7BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337874, XrefRangeEnd = 337885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TValue, TKey> CreateInverseDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_CreateInverseDictionary_Public_Static_Dictionary_2_TValue_TKey_Dictionary_2_TKey_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TValue, TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000F9A08 File Offset: 0x000F7C08
		[CallerCount(0)]
		public unsafe static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, Object> dictionary, string key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_0<TReturn>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TReturn>(intPtr, false, true);
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000F9A58 File Offset: 0x000F7C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337885, XrefRangeEnd = 337895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, Object> dictionary, string key, out bool success)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &success;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_byref_Boolean_0<TReturn>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TReturn>(intPtr, false, true);
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x000F9AB8 File Offset: 0x000F7CB8
		[CallerCount(0)]
		public unsafe static TValue GetDictionaryValueSafe<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000F9B54 File Offset: 0x000F7D54
		[CallerCount(0)]
		public unsafe static TValue GetDictionaryValueSafe<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, out bool success)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &success;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_byref_Boolean_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000F9C00 File Offset: 0x000F7E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337895, XrefRangeEnd = 337908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDictionaryValueSafe<TReturn>(Dictionary<string, Object> dictionary, string key, ref TReturn value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_TReturn_0<TReturn>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TReturn>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000F9C80 File Offset: 0x000F7E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337908, XrefRangeEnd = 337915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDictionaryValueSafe(Dictionary<string, Object> dictionary, string key, Type type, ref Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000F9D10 File Offset: 0x000F7F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337915, XrefRangeEnd = 337923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDictionaryValueSafe_float(Dictionary<string, Object> dictionary, string key, ref float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_float_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000F9D74 File Offset: 0x000F7F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337923, XrefRangeEnd = 337931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDictionaryValueSafe_int(Dictionary<string, Object> dictionary, string key, ref int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_int_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000F9DD8 File Offset: 0x000F7FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337931, XrefRangeEnd = 337937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddValueSafe(Dictionary<string, Object> data, string key, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.NativeMethodInfoPtr_AddValueSafe_Public_Static_Void_Dictionary_2_String_Object_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x000F9E34 File Offset: 0x000F8034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337937, XrefRangeEnd = 337945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetValue<T>(IEnumerable<T> enumerable, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_GetValue_Public_Static_T_IEnumerable_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x000F9E80 File Offset: 0x000F8080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337945, XrefRangeEnd = 337956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetValue<T>(IEnumerable enumerable, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionTools.MethodInfoStoreGeneric_GetValue_Public_Static_T_IEnumerable_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00011CFC File Offset: 0x0000FEFC
		public CollectionTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeMethodInfoPtr_CreateInverseDictionary_Public_Static_Dictionary_2_TValue_TKey_Dictionary_2_TKey_TValue_0;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_0;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_byref_Boolean_0;

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_byref_Boolean_0;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_TReturn_0;

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_Type_byref_Object_0;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_float_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_Single_0;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryValueSafe_int_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_Int32_0;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeMethodInfoPtr_AddValueSafe_Public_Static_Void_Dictionary_2_String_Object_String_Object_0;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_T_IEnumerable_1_T_Int32_0;

		// Token: 0x04002AC4 RID: 10948
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_T_IEnumerable_Int32_0;

		// Token: 0x0200042B RID: 1067
		private sealed class MethodInfoStoreGeneric_CreateInverseDictionary_Public_Static_Dictionary_2_TValue_TKey_Dictionary_2_TKey_TValue_0<TKey, TValue>
		{
			// Token: 0x04004372 RID: 17266
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_CreateInverseDictionary_Public_Static_Dictionary_2_TValue_TKey_Dictionary_2_TKey_TValue_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200042C RID: 1068
		private sealed class MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_0<TReturn>
		{
			// Token: 0x04004373 RID: 17267
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TReturn>.NativeClassPtr)) }))));
		}

		// Token: 0x0200042D RID: 1069
		private sealed class MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_byref_Boolean_0<TReturn>
		{
			// Token: 0x04004374 RID: 17268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TReturn_Dictionary_2_String_Object_String_byref_Boolean_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TReturn>.NativeClassPtr)) }))));
		}

		// Token: 0x0200042E RID: 1070
		private sealed class MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0<TKey, TValue>
		{
			// Token: 0x04004375 RID: 17269
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200042F RID: 1071
		private sealed class MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_byref_Boolean_0<TKey, TValue>
		{
			// Token: 0x04004376 RID: 17270
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_TValue_Dictionary_2_TKey_TValue_TKey_byref_Boolean_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000430 RID: 1072
		private sealed class MethodInfoStoreGeneric_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_TReturn_0<TReturn>
		{
			// Token: 0x04004377 RID: 17271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_GetDictionaryValueSafe_Public_Static_Boolean_Dictionary_2_String_Object_String_byref_TReturn_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TReturn>.NativeClassPtr)) }))));
		}

		// Token: 0x02000431 RID: 1073
		private sealed class MethodInfoStoreGeneric_GetValue_Public_Static_T_IEnumerable_1_T_Int32_0<T>
		{
			// Token: 0x04004378 RID: 17272
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_GetValue_Public_Static_T_IEnumerable_1_T_Int32_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000432 RID: 1074
		private sealed class MethodInfoStoreGeneric_GetValue_Public_Static_T_IEnumerable_Int32_0<T>
		{
			// Token: 0x04004379 RID: 17273
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionTools.NativeMethodInfoPtr_GetValue_Public_Static_T_IEnumerable_Int32_0, Il2CppClassPointerStore<CollectionTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
