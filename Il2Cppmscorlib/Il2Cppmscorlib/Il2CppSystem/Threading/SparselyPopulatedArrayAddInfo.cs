using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000260 RID: 608
	public sealed class SparselyPopulatedArrayAddInfo<T> : ValueType where T : class
	{
		// Token: 0x06002A81 RID: 10881 RVA: 0x000DE508 File Offset: 0x000DC708
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArrayAddInfo()
		{
			Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArrayAddInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr);
			SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "m_source");
			SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "m_index");
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100670144);
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100670145);
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Index_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100670146);
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000DE5D8 File Offset: 0x000DC7D8
		[CallerCount(0)]
		public unsafe SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x000DE638 File Offset: 0x000DC838
		public unsafe SparselyPopulatedArrayFragment<T> Source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x000DE67C File Offset: 0x000DC87C
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Index_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x0000EAAE File Offset: 0x0000CCAE
		public SparselyPopulatedArrayAddInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x0000EAB7 File Offset: 0x0000CCB7
		public SparselyPopulatedArrayAddInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000DE6C0 File Offset: 0x000DC8C0
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x0000EAC9 File Offset: 0x0000CCC9
		public unsafe SparselyPopulatedArrayFragment<T> m_source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000DE6F0 File Offset: 0x000DC8F0
		// (set) Token: 0x06002A8A RID: 10890 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		public unsafe int m_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_index)) = value;
			}
		}

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeFieldInfoPtr_m_source;

		// Token: 0x04002563 RID: 9571
		private static readonly IntPtr NativeFieldInfoPtr_m_index;

		// Token: 0x04002564 RID: 9572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0;

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Internal_get_Int32_0;
	}
}
