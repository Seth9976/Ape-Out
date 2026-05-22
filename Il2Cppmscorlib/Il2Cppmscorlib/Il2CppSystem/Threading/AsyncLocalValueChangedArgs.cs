using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200026C RID: 620
	public sealed class AsyncLocalValueChangedArgs<T> : ValueType
	{
		// Token: 0x06002B2F RID: 11055 RVA: 0x000E0B20 File Offset: 0x000DED20
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncLocalValueChangedArgs()
		{
			Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AsyncLocalValueChangedArgs`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr);
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<PreviousValue>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<CurrentValue>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<ThreadContextChanged>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_PreviousValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670227);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_PreviousValue_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670228);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_CurrentValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670229);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670230);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_ThreadContextChanged_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670231);
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100670232);
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000E0C40 File Offset: 0x000DEE40
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x000E0C80 File Offset: 0x000DEE80
		public unsafe T PreviousValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_PreviousValue_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99329, RefRangeEnd = 99331, XrefRangeStart = 99329, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = value;
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
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_PreviousValue_Private_set_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000E0D14 File Offset: 0x000DEF14
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x000E0D54 File Offset: 0x000DEF54
		public unsafe T CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_get_CurrentValue_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99331, RefRangeEnd = 99333, XrefRangeStart = 99331, XrefRangeEnd = 99333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = value;
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
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x000E0DE8 File Offset: 0x000DEFE8
		public unsafe bool ThreadContextChanged
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr_set_ThreadContextChanged_Private_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000E0E2C File Offset: 0x000DF02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201013, XrefRangeEnd = 201016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = previousValue;
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
					ptr4 = ref previousValue;
				}
				*ptr2 = ref ptr4;
			}
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = currentValue;
				if (!(t2 is string))
				{
					ref T ptr6 = (ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref currentValue;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x0000EEA6 File Offset: 0x0000D0A6
		public AsyncLocalValueChangedArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x0000EEAF File Offset: 0x0000D0AF
		public AsyncLocalValueChangedArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000E0F34 File Offset: 0x000DF134
		// (set) Token: 0x06002B39 RID: 11065 RVA: 0x000E0F5C File Offset: 0x000DF15C
		public unsafe T _PreviousValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000E1004 File Offset: 0x000DF204
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x000E102C File Offset: 0x000DF22C
		public unsafe T _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000E10D4 File Offset: 0x000DF2D4
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x0000EEC1 File Offset: 0x0000D0C1
		public unsafe bool _ThreadContextChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeFieldInfoPtr__PreviousValue_k__BackingField;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeFieldInfoPtr__ThreadContextChanged_k__BackingField;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousValue_Public_get_T_0;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeMethodInfoPtr_set_PreviousValue_Private_set_Void_T_0;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_T_0;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_T_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr_set_ThreadContextChanged_Private_set_Void_Boolean_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0;
	}
}
