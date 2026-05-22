using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025F RID: 607
	public class SparselyPopulatedArray<T> : Object where T : class
	{
		// Token: 0x06002A7A RID: 10874 RVA: 0x000DE300 File Offset: 0x000DC500
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArray()
		{
			Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr);
			SparselyPopulatedArray<T>.NativeFieldInfoPtr_m_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, "m_tail");
			SparselyPopulatedArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100670141);
			SparselyPopulatedArray<T>.NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100670142);
			SparselyPopulatedArray<T>.NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100670143);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000DE3BC File Offset: 0x000DC5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200491, XrefRangeEnd = 200493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArray(int initialSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x000DE404 File Offset: 0x000DC604
		public unsafe SparselyPopulatedArrayFragment<T> Tail
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000DE444 File Offset: 0x000DC644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200499, RefRangeEnd = 200500, XrefRangeStart = 200493, XrefRangeEnd = 200499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayAddInfo<T> Add(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = element;
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
					ptr4 = ref element;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArray<T>.NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SparselyPopulatedArrayAddInfo<T>(intPtr);
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0000EA86 File Offset: 0x0000CC86
		public SparselyPopulatedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000DE4D8 File Offset: 0x000DC6D8
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x0000EA8F File Offset: 0x0000CC8F
		public unsafe SparselyPopulatedArrayFragment<T> m_tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr_m_tail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArray<T>.NativeFieldInfoPtr_m_tail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeFieldInfoPtr_m_tail;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0;
	}
}
