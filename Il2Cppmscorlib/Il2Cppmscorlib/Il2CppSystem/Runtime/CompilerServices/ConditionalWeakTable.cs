using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200043A RID: 1082
	public sealed class ConditionalWeakTable<TKey, TValue> : Object where TKey : class where TValue : class
	{
		// Token: 0x0600437D RID: 17277 RVA: 0x001384C8 File Offset: 0x001366C8
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalWeakTable()
		{
			Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConditionalWeakTable`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr);
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_INITIAL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "INITIAL_SIZE");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_LOAD_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "LOAD_FACTOR");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_COMPACT_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "COMPACT_FACTOR");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_EXPAND_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "EXPAND_FACTOR");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "data");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "_lock");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "size");
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673150);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673151);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673152);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RecomputeSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673153);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673154);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673155);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673156);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673157);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100673158);
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x00138688 File Offset: 0x00136888
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226635, RefRangeEnd = 226638, XrefRangeStart = 226626, XrefRangeEnd = 226635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalWeakTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x001386C4 File Offset: 0x001368C4
		[CallerCount(0)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x001386F8 File Offset: 0x001368F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226638, XrefRangeEnd = 226649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RehashWithoutResize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x0013872C File Offset: 0x0013692C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226649, XrefRangeEnd = 226650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecomputeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RecomputeSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00138760 File Offset: 0x00136960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226650, XrefRangeEnd = 226656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x00138794 File Offset: 0x00136994
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 226667, RefRangeEnd = 226672, XrefRangeStart = 226656, XrefRangeEnd = 226667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00138880 File Offset: 0x00136A80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226683, RefRangeEnd = 226685, XrefRangeStart = 226672, XrefRangeEnd = 226683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x00138918 File Offset: 0x00136B18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226696, RefRangeEnd = 226699, XrefRangeStart = 226685, XrefRangeEnd = 226696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00138A00 File Offset: 0x00136C00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226703, RefRangeEnd = 226705, XrefRangeStart = 226699, XrefRangeEnd = 226703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createValueCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00019A44 File Offset: 0x00017C44
		public ConditionalWeakTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x00138AA8 File Offset: 0x00136CA8
		// (set) Token: 0x06004389 RID: 17289 RVA: 0x00019A4D File Offset: 0x00017C4D
		public unsafe static int INITIAL_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_INITIAL_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_INITIAL_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x00138AC4 File Offset: 0x00136CC4
		// (set) Token: 0x0600438B RID: 17291 RVA: 0x00019A5B File Offset: 0x00017C5B
		public unsafe static float LOAD_FACTOR
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_LOAD_FACTOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_LOAD_FACTOR, (void*)(&value));
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x00138AE0 File Offset: 0x00136CE0
		// (set) Token: 0x0600438D RID: 17293 RVA: 0x00019A69 File Offset: 0x00017C69
		public unsafe static float COMPACT_FACTOR
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_COMPACT_FACTOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_COMPACT_FACTOR, (void*)(&value));
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x00138AFC File Offset: 0x00136CFC
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x00019A77 File Offset: 0x00017C77
		public unsafe static float EXPAND_FACTOR
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_EXPAND_FACTOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_EXPAND_FACTOR, (void*)(&value));
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x00138B18 File Offset: 0x00136D18
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x00019A85 File Offset: 0x00017C85
		public unsafe Il2CppReferenceArray<Ephemeron> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Ephemeron>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x00138B48 File Offset: 0x00136D48
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x00019AA4 File Offset: 0x00017CA4
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x00138B78 File Offset: 0x00136D78
		// (set) Token: 0x06004395 RID: 17301 RVA: 0x00019AC3 File Offset: 0x00017CC3
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x040036CB RID: 14027
		private static readonly IntPtr NativeFieldInfoPtr_INITIAL_SIZE;

		// Token: 0x040036CC RID: 14028
		private static readonly IntPtr NativeFieldInfoPtr_LOAD_FACTOR;

		// Token: 0x040036CD RID: 14029
		private static readonly IntPtr NativeFieldInfoPtr_COMPACT_FACTOR;

		// Token: 0x040036CE RID: 14030
		private static readonly IntPtr NativeFieldInfoPtr_EXPAND_FACTOR;

		// Token: 0x040036CF RID: 14031
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040036D0 RID: 14032
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040036D1 RID: 14033
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040036D2 RID: 14034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036D3 RID: 14035
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040036D4 RID: 14036
		private static readonly IntPtr NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0;

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeSize_Private_Void_0;

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeMethodInfoPtr_Rehash_Private_Void_0;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0;

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0;

		// Token: 0x02000647 RID: 1607
		public sealed class CreateValueCallback : MulticastDelegate
		{
			// Token: 0x06005681 RID: 22145 RVA: 0x00181C40 File Offset: 0x0017FE40
			// Note: this type is marked as 'beforefieldinit'.
			static CreateValueCallback()
			{
				Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "CreateValueCallback"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100673159);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100673160);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TKey_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100673161);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TValue_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100673162);
			}

			// Token: 0x06005682 RID: 22146 RVA: 0x00181D00 File Offset: 0x0017FF00
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateValueCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005683 RID: 22147 RVA: 0x00181D5C File Offset: 0x0017FF5C
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 147104, RefRangeEnd = 147114, XrefRangeStart = 147104, XrefRangeEnd = 147114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TValue Invoke(TKey key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}

			// Token: 0x06005684 RID: 22148 RVA: 0x00181DF4 File Offset: 0x0017FFF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TKey key, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TKey_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005685 RID: 22149 RVA: 0x00181EB4 File Offset: 0x001800B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TValue EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TValue_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}

			// Token: 0x06005686 RID: 22150 RVA: 0x00020FDE File Offset: 0x0001F1DE
			public CreateValueCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005687 RID: 22151 RVA: 0x00020FE7 File Offset: 0x0001F1E7
			public static implicit operator ConditionalWeakTable<TKey, TValue>.CreateValueCallback(Func<TKey, TValue> A_0)
			{
				return DelegateSupport.ConvertDelegate<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>(A_0);
			}

			// Token: 0x06005688 RID: 22152 RVA: 0x00020FEF File Offset: 0x0001F1EF
			public static ConditionalWeakTable<TKey, TValue>.CreateValueCallback operator +(ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_0, ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>();
			}

			// Token: 0x06005689 RID: 22153 RVA: 0x00020FFD File Offset: 0x0001F1FD
			public static ConditionalWeakTable<TKey, TValue>.CreateValueCallback operator -(ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_0, ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>();
				}
				return delegate2;
			}

			// Token: 0x04004591 RID: 17809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004592 RID: 17810
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0;

			// Token: 0x04004593 RID: 17811
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TKey_AsyncCallback_Object_0;

			// Token: 0x04004594 RID: 17812
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TValue_IAsyncResult_0;
		}
	}
}
