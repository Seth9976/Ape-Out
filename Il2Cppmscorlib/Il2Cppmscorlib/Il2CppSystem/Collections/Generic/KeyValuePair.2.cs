using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048E RID: 1166
	[Serializable]
	public sealed class KeyValuePair<TKey, TValue> : ValueType
	{
		// Token: 0x06004722 RID: 18210 RVA: 0x00147CB8 File Offset: 0x00145EB8
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePair()
		{
			Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyValuePair`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr);
			KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, "key");
			KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, "value");
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673875);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Key_Public_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673876);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Value_Public_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673877);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100673878);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x00147DB0 File Offset: 0x00145FB0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 5426, RefRangeEnd = 5459, XrefRangeStart = 5426, XrefRangeEnd = 5459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair(TKey key, TValue value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
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
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TValue ptr7;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				if (!(tvalue is string))
				{
					ref TValue ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					if ((ref ptr6) != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x00147EA8 File Offset: 0x001460A8
		public unsafe TKey Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Key_Public_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x00147EE8 File Offset: 0x001460E8
		public unsafe TValue Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Value_Public_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x00147F28 File Offset: 0x00146128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230491, XrefRangeEnd = 230497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		public KeyValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0001ADD9 File Offset: 0x00018FD9
		public KeyValuePair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x00147F64 File Offset: 0x00146164
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x00147F8C File Offset: 0x0014618C
		public unsafe TKey key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key);
				Type typeFromHandle = typeof(TKey);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x00148034 File Offset: 0x00146234
		// (set) Token: 0x0600472C RID: 18220 RVA: 0x0014805C File Offset: 0x0014625C
		public unsafe TValue value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value);
				Type typeFromHandle = typeof(TValue);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x040039CF RID: 14799
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040039D0 RID: 14800
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040039D1 RID: 14801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0;

		// Token: 0x040039D2 RID: 14802
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_TKey_0;

		// Token: 0x040039D3 RID: 14803
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_TValue_0;

		// Token: 0x040039D4 RID: 14804
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
