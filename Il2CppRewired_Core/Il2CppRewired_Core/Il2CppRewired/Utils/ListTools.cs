using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001F1 RID: 497
	public static class ListTools : Object
	{
		// Token: 0x06003251 RID: 12881 RVA: 0x000FA9EC File Offset: 0x000F8BEC
		// Note: this type is marked as 'beforefieldinit'.
		static ListTools()
		{
			Il2CppClassPointerStore<ListTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "ListTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListTools>.NativeClassPtr);
			ListTools.NativeMethodInfoPtr_OffsetAtIndex_Public_Static_Boolean_IList_1_T_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676015);
			ListTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676016);
			ListTools.NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676017);
			ListTools.NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676018);
			ListTools.NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676019);
			ListTools.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676020);
			ListTools.NativeMethodInfoPtr_Combine_Public_Static_List_1_T_IList_1_T_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676021);
			ListTools.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676022);
			ListTools.NativeMethodInfoPtr_ConvertToObjeclist_Public_Static_List_1_Object_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676023);
			ListTools.NativeMethodInfoPtr_Concat_Public_Static_Void_IList_1_T_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676024);
			ListTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Boolean_IList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676025);
			ListTools.NativeMethodInfoPtr_Count_Public_Static_Int32_IList_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676026);
			ListTools.NativeMethodInfoPtr_TryClear_Public_Static_Void_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676027);
			ListTools.NativeMethodInfoPtr_HzZDEIoraGHwVifqaYslENRxHSO_Private_Static_Boolean_IList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676028);
			ListTools.NativeMethodInfoPtr_AddAndCreateList_Public_Static_Int32_byref_IList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676029);
			ListTools.NativeMethodInfoPtr_Find_Public_Static_T_IList_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListTools>.NativeClassPtr, 100676030);
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000FAB5C File Offset: 0x000F8D5C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 338137, RefRangeEnd = 338150, XrefRangeStart = 338129, XrefRangeEnd = 338137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OffsetAtIndex<T>(IList<T> list, int index, bool offsetDown, bool offsetNow = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetDown;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetNow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_OffsetAtIndex_Public_Static_Boolean_IList_1_T_Int32_Boolean_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x000FABC8 File Offset: 0x000F8DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338150, XrefRangeEnd = 338152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> ShallowCopy<T>(List<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_ShallowCopy_Public_Static_List_1_T_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x000FAC0C File Offset: 0x000F8E0C
		[CallerCount(0)]
		public unsafe static bool CopyTo<T>(IList<T> fromList, IList<T> toList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x000FAC60 File Offset: 0x000F8E60
		[CallerCount(0)]
		public unsafe static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromListStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000FACC4 File Offset: 0x000F8EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338152, XrefRangeEnd = 338161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromListStartIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000FAD34 File Offset: 0x000F8F34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338167, RefRangeEnd = 338170, XrefRangeStart = 338161, XrefRangeEnd = 338167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ToArray<T>(IList<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_T_IList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000FAD70 File Offset: 0x000F8F70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338182, RefRangeEnd = 338184, XrefRangeStart = 338170, XrefRangeEnd = 338182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> Combine<T>(IList<T> list1, IList<T> list2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_Combine_Public_Static_List_1_T_IList_1_T_IList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000FADC8 File Offset: 0x000F8FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338184, XrefRangeEnd = 338192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty<T>(IList<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_IList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x000FAE0C File Offset: 0x000F900C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338192, XrefRangeEnd = 338210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Object> ConvertToObjeclist<T>(IList<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_ConvertToObjeclist_Public_Static_List_1_Object_IList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x000FAE50 File Offset: 0x000F9050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338210, XrefRangeEnd = 338220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Concat<T>(IList<T> list1, IList<T> list2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_Concat_Public_Static_Void_IList_1_T_IList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x000FAE98 File Offset: 0x000F9098
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338225, RefRangeEnd = 338235, XrefRangeStart = 338220, XrefRangeEnd = 338225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddIfUnique<T>(IList<T> list, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_AddIfUnique_Public_Static_Boolean_IList_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x000FAF38 File Offset: 0x000F9138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338235, XrefRangeEnd = 338239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count<T>(IList<T> list, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_Count_Public_Static_Int32_IList_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x000FAF8C File Offset: 0x000F918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338239, XrefRangeEnd = 338241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryClear<T>(IList<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_TryClear_Public_Static_Void_IList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x000FAFC4 File Offset: 0x000F91C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338241, XrefRangeEnd = 338243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HzZDEIoraGHwVifqaYslENRxHSO<T>(IList<T> A_0, T A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = A_1;
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
				ptr4 = ref A_1;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_HzZDEIoraGHwVifqaYslENRxHSO_Private_Static_Boolean_IList_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x000FB064 File Offset: 0x000F9264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338243, XrefRangeEnd = 338249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddAndCreateList<T>(ref IList<T> list, T item)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref T ptr5;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr5 = ref item;
			}
			*ptr3 = ref ptr5;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_AddAndCreateList_Public_Static_Int32_byref_IList_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			list = ((intPtr4 == 0) ? null : new IList<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x000FB11C File Offset: 0x000F931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338249, XrefRangeEnd = 338253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Find<T>(IList<T> list, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListTools.MethodInfoStoreGeneric_Find_Public_Static_T_IList_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00011D20 File Offset: 0x0000FF20
		public ListTools(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeMethodInfoPtr_OffsetAtIndex_Public_Static_Boolean_IList_1_T_Int32_Boolean_Boolean_0;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeMethodInfoPtr_ShallowCopy_Public_Static_List_1_T_List_1_T_0;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_0;

		// Token: 0x04002AE0 RID: 10976
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_0;

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_Int32_0;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IList_1_T_0;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_List_1_T_IList_1_T_IList_1_T_0;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_IList_1_T_0;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToObjeclist_Public_Static_List_1_Object_IList_1_T_0;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_Void_IList_1_T_IList_1_T_0;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeMethodInfoPtr_AddIfUnique_Public_Static_Boolean_IList_1_T_T_0;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_IList_1_T_Predicate_1_T_0;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeMethodInfoPtr_TryClear_Public_Static_Void_IList_1_T_0;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeMethodInfoPtr_HzZDEIoraGHwVifqaYslENRxHSO_Private_Static_Boolean_IList_1_T_T_0;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeMethodInfoPtr_AddAndCreateList_Public_Static_Int32_byref_IList_1_T_T_0;

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_T_IList_1_T_Predicate_1_T_0;

		// Token: 0x02000435 RID: 1077
		private sealed class MethodInfoStoreGeneric_OffsetAtIndex_Public_Static_Boolean_IList_1_T_Int32_Boolean_Boolean_0<T>
		{
			// Token: 0x0400437C RID: 17276
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_OffsetAtIndex_Public_Static_Boolean_IList_1_T_Int32_Boolean_Boolean_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000436 RID: 1078
		private sealed class MethodInfoStoreGeneric_ShallowCopy_Public_Static_List_1_T_List_1_T_0<T>
		{
			// Token: 0x0400437D RID: 17277
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_ShallowCopy_Public_Static_List_1_T_List_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000437 RID: 1079
		private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_0<T>
		{
			// Token: 0x0400437E RID: 17278
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000438 RID: 1080
		private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_0<T>
		{
			// Token: 0x0400437F RID: 17279
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000439 RID: 1081
		private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04004380 RID: 17280
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_CopyTo_Public_Static_Boolean_IList_1_T_IList_1_T_Int32_Int32_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200043A RID: 1082
		private sealed class MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_T_IList_1_T_0<T>
		{
			// Token: 0x04004381 RID: 17281
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IList_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200043B RID: 1083
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_List_1_T_IList_1_T_IList_1_T_0<T>
		{
			// Token: 0x04004382 RID: 17282
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_Combine_Public_Static_List_1_T_IList_1_T_IList_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200043C RID: 1084
		private sealed class MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_IList_1_T_0<T>
		{
			// Token: 0x04004383 RID: 17283
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_IList_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200043D RID: 1085
		private sealed class MethodInfoStoreGeneric_ConvertToObjeclist_Public_Static_List_1_Object_IList_1_T_0<T>
		{
			// Token: 0x04004384 RID: 17284
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_ConvertToObjeclist_Public_Static_List_1_Object_IList_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200043E RID: 1086
		private sealed class MethodInfoStoreGeneric_Concat_Public_Static_Void_IList_1_T_IList_1_T_0<T>
		{
			// Token: 0x04004385 RID: 17285
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_Concat_Public_Static_Void_IList_1_T_IList_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200043F RID: 1087
		private sealed class MethodInfoStoreGeneric_AddIfUnique_Public_Static_Boolean_IList_1_T_T_0<T>
		{
			// Token: 0x04004386 RID: 17286
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_AddIfUnique_Public_Static_Boolean_IList_1_T_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000440 RID: 1088
		private sealed class MethodInfoStoreGeneric_Count_Public_Static_Int32_IList_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004387 RID: 17287
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_Count_Public_Static_Int32_IList_1_T_Predicate_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000441 RID: 1089
		private sealed class MethodInfoStoreGeneric_TryClear_Public_Static_Void_IList_1_T_0<T>
		{
			// Token: 0x04004388 RID: 17288
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_TryClear_Public_Static_Void_IList_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000442 RID: 1090
		private sealed class MethodInfoStoreGeneric_HzZDEIoraGHwVifqaYslENRxHSO_Private_Static_Boolean_IList_1_T_T_0<T>
		{
			// Token: 0x04004389 RID: 17289
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_HzZDEIoraGHwVifqaYslENRxHSO_Private_Static_Boolean_IList_1_T_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000443 RID: 1091
		private sealed class MethodInfoStoreGeneric_AddAndCreateList_Public_Static_Int32_byref_IList_1_T_T_0<T>
		{
			// Token: 0x0400438A RID: 17290
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_AddAndCreateList_Public_Static_Int32_byref_IList_1_T_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000444 RID: 1092
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_T_IList_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x0400438B RID: 17291
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListTools.NativeMethodInfoPtr_Find_Public_Static_T_IList_1_T_Predicate_1_T_0, Il2CppClassPointerStore<ListTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
