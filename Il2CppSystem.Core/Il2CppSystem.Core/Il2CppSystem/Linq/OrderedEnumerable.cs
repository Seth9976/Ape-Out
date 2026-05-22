using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000F RID: 15
	public class OrderedEnumerable<TElement> : Object
	{
		// Token: 0x060000BE RID: 190 RVA: 0x000069EC File Offset: 0x00004BEC
		// Note: this type is marked as 'beforefieldinit'.
		static OrderedEnumerable()
		{
			Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "OrderedEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr);
			OrderedEnumerable<TElement>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, "source");
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663529);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663530);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663531);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663532);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663533);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006AD0 File Offset: 0x00004CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363574, XrefRangeEnd = 363576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<TElement> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TElement>>(intPtr3) : null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006B10 File Offset: 0x00004D10
		[CallerCount(0)]
		public unsafe virtual EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumerableSorter<TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006B6C File Offset: 0x00004D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006BAC File Offset: 0x00004DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363576, XrefRangeEnd = 363578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IOrderedEnumerable<TElement> System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TKey>.MethodInfoStoreGeneric_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TElement>>(intPtr3) : null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006C1C File Offset: 0x00004E1C
		[CallerCount(0)]
		public unsafe OrderedEnumerable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002398 File Offset: 0x00000598
		public OrderedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00006C58 File Offset: 0x00004E58
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000023A1 File Offset: 0x000005A1
		public unsafe IEnumerable<TElement> source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000057 RID: 87
		[ObfuscatedName("System.Linq.OrderedEnumerable`1+<GetEnumerator>d__1")]
		public sealed class _GetEnumerator_d__1 : Object
		{
			// Token: 0x060002D0 RID: 720 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__1()
			{
				Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, "<GetEnumerator>d__1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>1__state");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>2__current");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>4__this");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<buffer>5__1");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<map>5__2");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<i>5__3");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663534);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663535);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663536);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663537);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663538);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663539);
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000E90C File Offset: 0x0000CB0C
			[CallerCount(0)]
			public unsafe _GetEnumerator_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x0000E954 File Offset: 0x0000CB54
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000E988 File Offset: 0x0000CB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363564, XrefRangeEnd = 363569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
			public unsafe TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
				}
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x0000EA00 File Offset: 0x0000CC00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363569, XrefRangeEnd = 363574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000EA34 File Offset: 0x0000CC34
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00003265 File Offset: 0x00001465
			public _GetEnumerator_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000EA74 File Offset: 0x0000CC74
			// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000326E File Offset: 0x0000146E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060002DA RID: 730 RVA: 0x0000EA9C File Offset: 0x0000CC9C
			// (set) Token: 0x060002DB RID: 731 RVA: 0x0000EAC4 File Offset: 0x0000CCC4
			public unsafe TElement __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current);
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

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x060002DC RID: 732 RVA: 0x0000EB6C File Offset: 0x0000CD6C
			// (set) Token: 0x060002DD RID: 733 RVA: 0x00003289 File Offset: 0x00001489
			public unsafe OrderedEnumerable<TElement> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderedEnumerable<TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x060002DE RID: 734 RVA: 0x0000EB9C File Offset: 0x0000CD9C
			// (set) Token: 0x060002DF RID: 735 RVA: 0x000032A8 File Offset: 0x000014A8
			public Buffer<TElement> _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__1);
					return new Buffer<TElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000EBCC File Offset: 0x0000CDCC
			// (set) Token: 0x060002E1 RID: 737 RVA: 0x000032D6 File Offset: 0x000014D6
			public unsafe Il2CppStructArray<int> _map_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000EBFC File Offset: 0x0000CDFC
			// (set) Token: 0x060002E3 RID: 739 RVA: 0x000032F5 File Offset: 0x000014F5
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeFieldInfoPtr__map_5__2;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000058 RID: 88
		private sealed class MethodInfoStoreGeneric_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0
		{
			// Token: 0x04000236 RID: 566
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OrderedEnumerable<TKey>.NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, Il2CppClassPointerStore<OrderedEnumerable<TKey>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)) }))));
		}
	}
}
