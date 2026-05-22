using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000261 RID: 609
	public class SparselyPopulatedArrayFragment<T> : Object where T : class
	{
		// Token: 0x06002A8B RID: 10891 RVA: 0x000DE718 File Offset: 0x000DC918
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArrayFragment()
		{
			Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArrayFragment`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr);
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_elements");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_freeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_freeCount");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_next");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_prev");
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100670147);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100670148);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100670149);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100670150);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100670151);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100670152);
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000DE84C File Offset: 0x000DCA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayFragment(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000DE894 File Offset: 0x000DCA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200500, XrefRangeEnd = 200502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prev);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A01 RID: 2561
		public unsafe T this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000DE938 File Offset: 0x000DCB38
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x000DE974 File Offset: 0x000DCB74
		public unsafe SparselyPopulatedArrayFragment<T> Prev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000DE9B4 File Offset: 0x000DCBB4
		[CallerCount(0)]
		public unsafe T SafeAtomicRemove(int index, T expectedElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = expectedElement;
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
				ptr4 = ref expectedElement;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0000EB03 File Offset: 0x0000CD03
		public SparselyPopulatedArrayFragment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000DEA58 File Offset: 0x000DCC58
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		public unsafe Il2CppArrayBase<T> m_elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_elements);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000DEA80 File Offset: 0x000DCC80
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x0000EB2B File Offset: 0x0000CD2B
		public unsafe int m_freeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_freeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_freeCount)) = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000DEAA8 File Offset: 0x000DCCA8
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x0000EB46 File Offset: 0x0000CD46
		public unsafe SparselyPopulatedArrayFragment<T> m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000DEAD8 File Offset: 0x000DCCD8
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x0000EB65 File Offset: 0x0000CD65
		public unsafe SparselyPopulatedArrayFragment<T> m_prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeFieldInfoPtr_m_elements;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeFieldInfoPtr_m_freeCount;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeFieldInfoPtr_m_prev;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0;
	}
}
