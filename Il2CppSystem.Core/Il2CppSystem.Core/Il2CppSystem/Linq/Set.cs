using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000D RID: 13
	public class Set<TElement> : Object
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x000062A0 File Offset: 0x000044A0
		// Note: this type is marked as 'beforefieldinit'.
		static Set()
		{
			Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Set`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr);
			Set<TElement>.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "buckets");
			Set<TElement>.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "slots");
			Set<TElement>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "count");
			Set<TElement>.NativeFieldInfoPtr_freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "freeList");
			Set<TElement>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "comparer");
			Set<TElement>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663521);
			Set<TElement>.NativeMethodInfoPtr_Add_Public_Boolean_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663522);
			Set<TElement>.NativeMethodInfoPtr_Find_Private_Boolean_TElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663523);
			Set<TElement>.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663524);
			Set<TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663525);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000063D4 File Offset: 0x000045D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363548, XrefRangeEnd = 363553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Set(IEqualityComparer<TElement> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006420 File Offset: 0x00004620
		[CallerCount(0)]
		public unsafe bool Add(TElement value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TElement ptr4;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = value;
					if (!(telement is string))
					{
						ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_Add_Public_Boolean_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000064B8 File Offset: 0x000046B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363553, XrefRangeEnd = 363556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Find(TElement value, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TElement ptr4;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = value;
					if (!(telement is string))
					{
						ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_Find_Private_Boolean_TElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006560 File Offset: 0x00004760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363556, XrefRangeEnd = 363563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006594 File Offset: 0x00004794
		[CallerCount(0)]
		public unsafe int InternalGetHashCode(TElement value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref TElement ptr4;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = value;
					if (!(telement is string))
					{
						ref TElement ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(telement as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002277 File Offset: 0x00000477
		public Set(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000662C File Offset: 0x0000482C
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002280 File Offset: 0x00000480
		public unsafe Il2CppStructArray<int> buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000665C File Offset: 0x0000485C
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000229F File Offset: 0x0000049F
		public unsafe Il2CppReferenceArray<Set<TElement>.Slot> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Set<TElement>.Slot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000668C File Offset: 0x0000488C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000022BE File Offset: 0x000004BE
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000066B4 File Offset: 0x000048B4
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000022D9 File Offset: 0x000004D9
		public unsafe int freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_freeList)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000066DC File Offset: 0x000048DC
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000022F4 File Offset: 0x000004F4
		public unsafe IEqualityComparer<TElement> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_freeList;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TElement_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Boolean_TElement_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_Find_Private_Boolean_TElement_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TElement_0;

		// Token: 0x02000056 RID: 86
		public sealed class Slot : ValueType
		{
			// Token: 0x060002C7 RID: 711 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
			// Note: this type is marked as 'beforefieldinit'.
			static Slot()
			{
				Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "Slot"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr);
				Set<TElement>.Slot.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr, "hashCode");
				Set<TElement>.Slot.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr, "value");
				Set<TElement>.Slot.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr, "next");
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x00003214 File Offset: 0x00001414
			public Slot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0000321D File Offset: 0x0000141D
			public Slot()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr))
			{
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0000E694 File Offset: 0x0000C894
			// (set) Token: 0x060002CB RID: 715 RVA: 0x0000322F File Offset: 0x0000142F
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000E6BC File Offset: 0x0000C8BC
			// (set) Token: 0x060002CD RID: 717 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
			public unsafe TElement value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(TElement);
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

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000E78C File Offset: 0x0000C98C
			// (set) Token: 0x060002CF RID: 719 RVA: 0x0000324A File Offset: 0x0000144A
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeFieldInfoPtr_next;
		}
	}
}
