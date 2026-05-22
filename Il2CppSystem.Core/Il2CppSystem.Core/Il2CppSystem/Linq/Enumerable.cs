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
	// Token: 0x02000007 RID: 7
	public static class Enumerable : Object
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00004B3C File Offset: 0x00002D3C
		// Note: this type is marked as 'beforefieldinit'.
		static Enumerable()
		{
			Il2CppClassPointerStore<Enumerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Enumerable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable>.NativeClassPtr);
			Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663348);
			Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663349);
			Enumerable.NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663350);
			Enumerable.NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663351);
			Enumerable.NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663352);
			Enumerable.NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663353);
			Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663354);
			Enumerable.NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663355);
			Enumerable.NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663356);
			Enumerable.NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663357);
			Enumerable.NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663358);
			Enumerable.NativeMethodInfoPtr_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663359);
			Enumerable.NativeMethodInfoPtr_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663360);
			Enumerable.NativeMethodInfoPtr_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663361);
			Enumerable.NativeMethodInfoPtr_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663362);
			Enumerable.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663363);
			Enumerable.NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663364);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663365);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663366);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663367);
			Enumerable.NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663368);
			Enumerable.NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663369);
			Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663370);
			Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663371);
			Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663372);
			Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663373);
			Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663374);
			Enumerable.NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663375);
			Enumerable.NativeMethodInfoPtr_Range_Public_Static_IEnumerable_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663376);
			Enumerable.NativeMethodInfoPtr_RangeIterator_Private_Static_IEnumerable_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663377);
			Enumerable.NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663378);
			Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663379);
			Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663380);
			Enumerable.NativeMethodInfoPtr_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663381);
			Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663382);
			Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663383);
			Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663384);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004E50 File Offset: 0x00003050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363170, RefRangeEnd = 363172, XrefRangeStart = 363162, XrefRangeEnd = 363170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004EA8 File Offset: 0x000030A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363185, RefRangeEnd = 363186, XrefRangeStart = 363172, XrefRangeEnd = 363185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004F00 File Offset: 0x00003100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363186, XrefRangeEnd = 363190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr3) : null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004F58 File Offset: 0x00003158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363190, XrefRangeEnd = 363194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0<TSource, TMiddle, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr3) : null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004FB0 File Offset: 0x000031B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363194, XrefRangeEnd = 363202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005008 File Offset: 0x00003208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363202, XrefRangeEnd = 363204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005060 File Offset: 0x00003260
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 363206, RefRangeEnd = 363212, XrefRangeStart = 363204, XrefRangeEnd = 363206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000050B8 File Offset: 0x000032B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363212, XrefRangeEnd = 363214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005110 File Offset: 0x00003310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363216, RefRangeEnd = 363218, XrefRangeStart = 363214, XrefRangeEnd = 363216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005168 File Offset: 0x00003368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363218, XrefRangeEnd = 363220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IGrouping<TKey, TSource>>>(intPtr3) : null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000051C0 File Offset: 0x000033C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363220, XrefRangeEnd = 363222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IEqualityComparer_1_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IGrouping<TKey, TSource>>>(intPtr3) : null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005228 File Offset: 0x00003428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363222, XrefRangeEnd = 363230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005280 File Offset: 0x00003480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000052D8 File Offset: 0x000034D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363230, XrefRangeEnd = 363234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000531C File Offset: 0x0000351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363234, XrefRangeEnd = 363236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005374 File Offset: 0x00003574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363236, XrefRangeEnd = 363238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<TSource> ToArray<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000053B0 File Offset: 0x000035B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363238, XrefRangeEnd = 363240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000053F4 File Offset: 0x000035F4
		[CallerCount(0)]
		public unsafe static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TSource>>(intPtr3) : null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000544C File Offset: 0x0000364C
		[CallerCount(0)]
		public unsafe static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementSelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0<TSource, TKey, TElement>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TElement>>(intPtr3) : null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000054B4 File Offset: 0x000036B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363254, RefRangeEnd = 363255, XrefRangeStart = 363240, XrefRangeEnd = 363254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementSelector);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0<TSource, TKey, TElement>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TElement>>(intPtr3) : null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005530 File Offset: 0x00003730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363255, XrefRangeEnd = 363257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005574 File Offset: 0x00003774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363257, XrefRangeEnd = 363259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000055B8 File Offset: 0x000037B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363273, RefRangeEnd = 363274, XrefRangeStart = 363259, XrefRangeEnd = 363273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000055F8 File Offset: 0x000037F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363288, RefRangeEnd = 363290, XrefRangeStart = 363274, XrefRangeEnd = 363288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005638 File Offset: 0x00003838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363290, XrefRangeEnd = 363302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005688 File Offset: 0x00003888
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 363320, RefRangeEnd = 363323, XrefRangeStart = 363302, XrefRangeEnd = 363320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000056C8 File Offset: 0x000038C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363336, RefRangeEnd = 363338, XrefRangeStart = 363323, XrefRangeEnd = 363336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005718 File Offset: 0x00003918
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 363353, RefRangeEnd = 363356, XrefRangeStart = 363338, XrefRangeEnd = 363353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005764 File Offset: 0x00003964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363356, XrefRangeEnd = 363361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> Range(int start, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Range_Public_Static_IEnumerable_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000057B4 File Offset: 0x000039B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363361, XrefRangeEnd = 363366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> RangeIterator(int start, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_RangeIterator_Private_Static_IEnumerable_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005804 File Offset: 0x00003A04
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 146243, RefRangeEnd = 146316, XrefRangeStart = 146243, XrefRangeEnd = 146316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Empty<TResult>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Empty_Public_Static_IEnumerable_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005838 File Offset: 0x00003A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363376, RefRangeEnd = 363377, XrefRangeStart = 363366, XrefRangeEnd = 363376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000587C File Offset: 0x00003A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 363389, RefRangeEnd = 363391, XrefRangeStart = 363377, XrefRangeEnd = 363389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000058D0 File Offset: 0x00003AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363403, RefRangeEnd = 363404, XrefRangeStart = 363391, XrefRangeEnd = 363403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005924 File Offset: 0x00003B24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 363420, RefRangeEnd = 363423, XrefRangeStart = 363404, XrefRangeEnd = 363420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005968 File Offset: 0x00003B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363423, XrefRangeEnd = 363428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TSource ptr4;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = value;
				if (!(tsource is string))
				{
					ref TSource ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tsource as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005A08 File Offset: 0x00003C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363428, XrefRangeEnd = 363443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref TSource ptr4;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = value;
				if (!(tsource is string))
				{
					ref TSource ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tsource as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000021B7 File Offset: 0x000003B7
		public Enumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IEqualityComparer_1_TKey_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_IEnumerable_1_Int32_Int32_Int32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_RangeIterator_Private_Static_IEnumerable_1_Int32_Int32_Int32_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x02000020 RID: 32
		public class Iterator<TSource> : Object
		{
			// Token: 0x0600016A RID: 362 RVA: 0x00008D60 File Offset: 0x00006F60
			// Note: this type is marked as 'beforefieldinit'.
			static Iterator()
			{
				Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "Iterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr);
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "threadId");
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "state");
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "current");
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663385);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663386);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663387);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663388);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663389);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663390);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663391);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663392);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663393);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663394);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663395);
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00008EE0 File Offset: 0x000070E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Iterator()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600016C RID: 364 RVA: 0x00008F1C File Offset: 0x0000711C
			public unsafe virtual TSource Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x0600016D RID: 365 RVA: 0x00008F58 File Offset: 0x00007158
			[CallerCount(0)]
			public unsafe virtual Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00008FA4 File Offset: 0x000071A4
			[CallerCount(0)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016F RID: 367 RVA: 0x00008FE0 File Offset: 0x000071E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<TSource> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000170 RID: 368 RVA: 0x00009020 File Offset: 0x00007220
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00009068 File Offset: 0x00007268
			[CallerCount(0)]
			public unsafe virtual IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TResult>.MethodInfoStoreGeneric_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000172 RID: 370 RVA: 0x000090C4 File Offset: 0x000072C4
			[CallerCount(0)]
			public unsafe virtual IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000173 RID: 371 RVA: 0x00009120 File Offset: 0x00007320
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362937, XrefRangeEnd = 362939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00009160 File Offset: 0x00007360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362939, XrefRangeEnd = 362940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000175 RID: 373 RVA: 0x000091A0 File Offset: 0x000073A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362940, XrefRangeEnd = 362950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000176 RID: 374 RVA: 0x000028DD File Offset: 0x00000ADD
			public Iterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000177 RID: 375 RVA: 0x000091D4 File Offset: 0x000073D4
			// (set) Token: 0x06000178 RID: 376 RVA: 0x000028E6 File Offset: 0x00000AE6
			public unsafe int threadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId)) = value;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000179 RID: 377 RVA: 0x000091FC File Offset: 0x000073FC
			// (set) Token: 0x0600017A RID: 378 RVA: 0x00002901 File Offset: 0x00000B01
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600017B RID: 379 RVA: 0x00009224 File Offset: 0x00007424
			// (set) Token: 0x0600017C RID: 380 RVA: 0x0000924C File Offset: 0x0000744C
			public unsafe TSource current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x0400013C RID: 316
			private static readonly IntPtr NativeFieldInfoPtr_threadId;

			// Token: 0x0400013D RID: 317
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0;

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x04000147 RID: 327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000148 RID: 328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04000149 RID: 329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x02000062 RID: 98
			private sealed class MethodInfoStoreGeneric_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000245 RID: 581
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.Iterator<TResult>.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.Iterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000021 RID: 33
		public class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x0600017D RID: 381 RVA: 0x000092F4 File Offset: 0x000074F4
			// Note: this type is marked as 'beforefieldinit'.
			static WhereEnumerableIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereEnumerableIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "enumerator");
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663396);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663397);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663398);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663399);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663400);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663401);
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00009410 File Offset: 0x00007610
			[CallerCount(0)]
			public unsafe WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00009470 File Offset: 0x00007670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362950, XrefRangeEnd = 362952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000180 RID: 384 RVA: 0x000094BC File Offset: 0x000076BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362952, XrefRangeEnd = 362955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000181 RID: 385 RVA: 0x000094F8 File Offset: 0x000076F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362955, XrefRangeEnd = 362965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00009540 File Offset: 0x00007740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362965, XrefRangeEnd = 362967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000183 RID: 387 RVA: 0x0000959C File Offset: 0x0000779C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362967, XrefRangeEnd = 362969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x06000184 RID: 388 RVA: 0x0000291C File Offset: 0x00000B1C
			public WhereEnumerableIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000185 RID: 389 RVA: 0x000095F8 File Offset: 0x000077F8
			// (set) Token: 0x06000186 RID: 390 RVA: 0x00002925 File Offset: 0x00000B25
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000187 RID: 391 RVA: 0x00009628 File Offset: 0x00007828
			// (set) Token: 0x06000188 RID: 392 RVA: 0x00002944 File Offset: 0x00000B44
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000189 RID: 393 RVA: 0x00009658 File Offset: 0x00007858
			// (set) Token: 0x0600018A RID: 394 RVA: 0x00002963 File Offset: 0x00000B63
			public unsafe IEnumerator<TSource> enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400014A RID: 330
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400014B RID: 331
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x0400014C RID: 332
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x0400014D RID: 333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000151 RID: 337
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x04000152 RID: 338
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000063 RID: 99
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000246 RID: 582
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereEnumerableIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000022 RID: 34
		public class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x0600018B RID: 395 RVA: 0x00009688 File Offset: 0x00007888
			// Note: this type is marked as 'beforefieldinit'.
			static WhereArrayIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereArrayIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "index");
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663402);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663403);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663404);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663405);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663406);
			}

			// Token: 0x0600018C RID: 396 RVA: 0x00009790 File Offset: 0x00007990
			[CallerCount(0)]
			public unsafe WhereArrayIterator(Il2CppArrayBase<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600018D RID: 397 RVA: 0x000097F0 File Offset: 0x000079F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x0600018E RID: 398 RVA: 0x0000983C File Offset: 0x00007A3C
			[CallerCount(0)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600018F RID: 399 RVA: 0x00009884 File Offset: 0x00007A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000190 RID: 400 RVA: 0x000098E0 File Offset: 0x00007AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362969, XrefRangeEnd = 362971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x06000191 RID: 401 RVA: 0x00002982 File Offset: 0x00000B82
			public WhereArrayIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000192 RID: 402 RVA: 0x0000993C File Offset: 0x00007B3C
			// (set) Token: 0x06000193 RID: 403 RVA: 0x0000298B File Offset: 0x00000B8B
			public unsafe Il2CppArrayBase<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source);
					return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000194 RID: 404 RVA: 0x00009964 File Offset: 0x00007B64
			// (set) Token: 0x06000195 RID: 405 RVA: 0x000029AA File Offset: 0x00000BAA
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000196 RID: 406 RVA: 0x00009994 File Offset: 0x00007B94
			// (set) Token: 0x06000197 RID: 407 RVA: 0x000029C9 File Offset: 0x00000BC9
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x04000153 RID: 339
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000154 RID: 340
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000155 RID: 341
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000156 RID: 342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x04000157 RID: 343
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x04000158 RID: 344
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000159 RID: 345
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x0400015A RID: 346
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000064 RID: 100
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000247 RID: 583
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereArrayIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000023 RID: 35
		public class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x06000198 RID: 408 RVA: 0x000099BC File Offset: 0x00007BBC
			// Note: this type is marked as 'beforefieldinit'.
			static WhereListIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereListIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "enumerator");
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663407);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663408);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663409);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663410);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663411);
			}

			// Token: 0x06000199 RID: 409 RVA: 0x00009AC4 File Offset: 0x00007CC4
			[CallerCount(0)]
			public unsafe WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600019A RID: 410 RVA: 0x00009B24 File Offset: 0x00007D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00009B70 File Offset: 0x00007D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362971, XrefRangeEnd = 362974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600019C RID: 412 RVA: 0x00009BB8 File Offset: 0x00007DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00009C14 File Offset: 0x00007E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362974, XrefRangeEnd = 362976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x0600019E RID: 414 RVA: 0x000029E4 File Offset: 0x00000BE4
			public WhereListIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600019F RID: 415 RVA: 0x00009C70 File Offset: 0x00007E70
			// (set) Token: 0x060001A0 RID: 416 RVA: 0x000029ED File Offset: 0x00000BED
			public unsafe List<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060001A1 RID: 417 RVA: 0x00009CA0 File Offset: 0x00007EA0
			// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002A0C File Offset: 0x00000C0C
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060001A3 RID: 419 RVA: 0x00009CD0 File Offset: 0x00007ED0
			// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002A2B File Offset: 0x00000C2B
			public List<TSource>.Enumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator);
					return new List<TSource>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400015B RID: 347
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400015C RID: 348
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x0400015D RID: 349
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x0400015E RID: 350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x0400015F RID: 351
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x04000160 RID: 352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000161 RID: 353
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x04000162 RID: 354
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000065 RID: 101
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000248 RID: 584
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereListIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereListIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000024 RID: 36
		public class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060001A5 RID: 421 RVA: 0x00009D00 File Offset: 0x00007F00
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectEnumerableIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectEnumerableIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "enumerator");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663412);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663413);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663414);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663415);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663416);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663417);
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x00009E40 File Offset: 0x00008040
			[CallerCount(0)]
			public unsafe WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00009EB0 File Offset: 0x000080B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362976, XrefRangeEnd = 362978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00009EFC File Offset: 0x000080FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362978, XrefRangeEnd = 362981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00009F38 File Offset: 0x00008138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362981, XrefRangeEnd = 362991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00009F80 File Offset: 0x00008180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362991, XrefRangeEnd = 362993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (060001AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00009FDC File Offset: 0x000081DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362993, XrefRangeEnd = 362995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00002A59 File Offset: 0x00000C59
			public WhereSelectEnumerableIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A038 File Offset: 0x00008238
			// (set) Token: 0x060001AE RID: 430 RVA: 0x00002A62 File Offset: 0x00000C62
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x060001AF RID: 431 RVA: 0x0000A068 File Offset: 0x00008268
			// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002A81 File Offset: 0x00000C81
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000A098 File Offset: 0x00008298
			// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002AA0 File Offset: 0x00000CA0
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000A0C8 File Offset: 0x000082C8
			// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002ABF File Offset: 0x00000CBF
			public unsafe IEnumerator<TSource> enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000163 RID: 355
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000164 RID: 356
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000166 RID: 358
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x02000066 RID: 102
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06000313 RID: 787 RVA: 0x0000F434 File Offset: 0x0000D634
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06000313)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectEnumerableIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x04000249 RID: 585
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x02000025 RID: 37
		public class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060001B5 RID: 437 RVA: 0x0000A0F8 File Offset: 0x000082F8
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectArrayIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectArrayIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "index");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663418);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663419);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663420);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663421);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663422);
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x0000A224 File Offset: 0x00008424
			[CallerCount(0)]
			public unsafe WhereSelectArrayIterator(Il2CppArrayBase<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x0000A294 File Offset: 0x00008494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x0000A2E0 File Offset: 0x000084E0
			[CallerCount(0)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x0000A328 File Offset: 0x00008528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (060001B9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectArrayIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x0000A384 File Offset: 0x00008584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362995, XrefRangeEnd = 362997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00002ADE File Offset: 0x00000CDE
			public WhereSelectArrayIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060001BC RID: 444 RVA: 0x0000A3E0 File Offset: 0x000085E0
			// (set) Token: 0x060001BD RID: 445 RVA: 0x00002AE7 File Offset: 0x00000CE7
			public unsafe Il2CppArrayBase<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060001BE RID: 446 RVA: 0x0000A408 File Offset: 0x00008608
			// (set) Token: 0x060001BF RID: 447 RVA: 0x00002B06 File Offset: 0x00000D06
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000A438 File Offset: 0x00008638
			// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002B25 File Offset: 0x00000D25
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000A468 File Offset: 0x00008668
			// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002B44 File Offset: 0x00000D44
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400016E RID: 366
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x0400016F RID: 367
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000170 RID: 368
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x04000173 RID: 371
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x02000067 RID: 103
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06000314 RID: 788 RVA: 0x0000F488 File Offset: 0x0000D688
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06000314)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectArrayIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x0400024A RID: 586
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x02000026 RID: 38
		public class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060001C4 RID: 452 RVA: 0x0000A490 File Offset: 0x00008690
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectListIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectListIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "enumerator");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663423);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663424);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663425);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663426);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663427);
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x0000A5BC File Offset: 0x000087BC
			[CallerCount(0)]
			public unsafe WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x0000A62C File Offset: 0x0000882C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x0000A678 File Offset: 0x00008878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362997, XrefRangeEnd = 363000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x0000A6C0 File Offset: 0x000088C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (060001C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectListIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x0000A71C File Offset: 0x0000891C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363000, XrefRangeEnd = 363002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00002B5F File Offset: 0x00000D5F
			public WhereSelectListIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001CB RID: 459 RVA: 0x0000A778 File Offset: 0x00008978
			// (set) Token: 0x060001CC RID: 460 RVA: 0x00002B68 File Offset: 0x00000D68
			public unsafe List<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001CD RID: 461 RVA: 0x0000A7A8 File Offset: 0x000089A8
			// (set) Token: 0x060001CE RID: 462 RVA: 0x00002B87 File Offset: 0x00000D87
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001CF RID: 463 RVA: 0x0000A7D8 File Offset: 0x000089D8
			// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002BA6 File Offset: 0x00000DA6
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000A808 File Offset: 0x00008A08
			// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002BC5 File Offset: 0x00000DC5
			public List<TSource>.Enumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator);
					return new List<TSource>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000176 RID: 374
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x0400017A RID: 378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x0400017B RID: 379
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x0400017C RID: 380
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x0400017D RID: 381
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x0400017E RID: 382
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x02000068 RID: 104
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06000315 RID: 789 RVA: 0x0000F4DC File Offset: 0x0000D6DC
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06000315)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectListIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x0400024B RID: 587
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x02000027 RID: 39
		[ObfuscatedName("System.Linq.Enumerable+<>c__DisplayClass6_0`1")]
		public sealed class __c__DisplayClass6_0<TSource> : Object
		{
			// Token: 0x060001D3 RID: 467 RVA: 0x0000A838 File Offset: 0x00008A38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr);
				Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, "predicate1");
				Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, "predicate2");
				Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, 100663428);
				Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, 100663429);
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x0000A8F0 File Offset: 0x00008AF0
			[CallerCount(0)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0000A92C File Offset: 0x00008B2C
			[CallerCount(0)]
			public unsafe bool _CombinePredicates_b__0(TSource x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TSource ptr4;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = x;
						if (!(tsource is string))
						{
							ref TSource ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tsource as string);
						}
					}
					else
					{
						ptr4 = ref x;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x00002BF3 File Offset: 0x00000DF3
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000A9C4 File Offset: 0x00008BC4
			// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002BFC File Offset: 0x00000DFC
			public unsafe Func<TSource, bool> predicate1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000A9F4 File Offset: 0x00008BF4
			// (set) Token: 0x060001DA RID: 474 RVA: 0x00002C1B File Offset: 0x00000E1B
			public unsafe Func<TSource, bool> predicate2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeFieldInfoPtr_predicate1;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeFieldInfoPtr_predicate2;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0;
		}

		// Token: 0x02000028 RID: 40
		[ObfuscatedName("System.Linq.Enumerable+<>c__DisplayClass7_0`3")]
		public sealed class __c__DisplayClass7_0<TSource, TMiddle, TResult> : Object
		{
			// Token: 0x060001DB RID: 475 RVA: 0x0000AA24 File Offset: 0x00008C24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<>c__DisplayClass7_0`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMiddle>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr);
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, "selector2");
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, "selector1");
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, 100663430);
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, 100663431);
			}

			// Token: 0x060001DC RID: 476 RVA: 0x0000AB00 File Offset: 0x00008D00
			[CallerCount(0)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001DD RID: 477 RVA: 0x0000AB3C File Offset: 0x00008D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363002, XrefRangeEnd = 363009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TResult _CombineSelectors_b__0(TSource x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref TSource ptr4;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = x;
						if (!(tsource is string))
						{
							ref TSource ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
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
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(tsource as string);
						}
					}
					else
					{
						ptr4 = ref x;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x060001DE RID: 478 RVA: 0x00002C3A File Offset: 0x00000E3A
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001DF RID: 479 RVA: 0x0000ABD4 File Offset: 0x00008DD4
			// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002C43 File Offset: 0x00000E43
			public unsafe Func<TMiddle, TResult> selector2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMiddle, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000AC04 File Offset: 0x00008E04
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002C62 File Offset: 0x00000E62
			public unsafe Func<TSource, TMiddle> selector1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TMiddle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeFieldInfoPtr_selector2;

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeFieldInfoPtr_selector1;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0;
		}

		// Token: 0x02000029 RID: 41
		[ObfuscatedName("System.Linq.Enumerable+<SelectManyIterator>d__17`2")]
		public sealed class _SelectManyIterator_d__17<TSource, TResult> : Object
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x0000AC34 File Offset: 0x00008E34
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectManyIterator_d__17()
			{
				Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<SelectManyIterator>d__17`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>3__selector");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663432);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663433);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663434);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663435);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663436);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663437);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663438);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663439);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663440);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663441);
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x0000AE28 File Offset: 0x00009028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363009, XrefRangeEnd = 363011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectManyIterator_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x0000AE70 File Offset: 0x00009070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363011, XrefRangeEnd = 363013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x0000AEA4 File Offset: 0x000090A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363013, XrefRangeEnd = 363031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x0000AEE0 File Offset: 0x000090E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363031, XrefRangeEnd = 363034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x0000AF14 File Offset: 0x00009114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363034, XrefRangeEnd = 363037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000AF48 File Offset: 0x00009148
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x060001EA RID: 490 RVA: 0x0000AF84 File Offset: 0x00009184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363037, XrefRangeEnd = 363042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x060001EB RID: 491 RVA: 0x0000AFB8 File Offset: 0x000091B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001EC RID: 492 RVA: 0x0000AFF8 File Offset: 0x000091F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363042, XrefRangeEnd = 363047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x0000B038 File Offset: 0x00009238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363047, XrefRangeEnd = 363048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00002C81 File Offset: 0x00000E81
			public _SelectManyIterator_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060001EF RID: 495 RVA: 0x0000B078 File Offset: 0x00009278
			// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002C8A File Offset: 0x00000E8A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000B0A0 File Offset: 0x000092A0
			// (set) Token: 0x060001F2 RID: 498 RVA: 0x0000B0C8 File Offset: 0x000092C8
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000B170 File Offset: 0x00009370
			// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002CA5 File Offset: 0x00000EA5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000B198 File Offset: 0x00009398
			// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002CC0 File Offset: 0x00000EC0
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000B1C8 File Offset: 0x000093C8
			// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002CDF File Offset: 0x00000EDF
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000B1F8 File Offset: 0x000093F8
			// (set) Token: 0x060001FA RID: 506 RVA: 0x00002CFE File Offset: 0x00000EFE
			public unsafe Func<TSource, IEnumerable<TResult>> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, IEnumerable<TResult>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060001FB RID: 507 RVA: 0x0000B228 File Offset: 0x00009428
			// (set) Token: 0x060001FC RID: 508 RVA: 0x00002D1D File Offset: 0x00000F1D
			public unsafe Func<TSource, IEnumerable<TResult>> __3__selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, IEnumerable<TResult>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060001FD RID: 509 RVA: 0x0000B258 File Offset: 0x00009458
			// (set) Token: 0x060001FE RID: 510 RVA: 0x00002D3C File Offset: 0x00000F3C
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060001FF RID: 511 RVA: 0x0000B288 File Offset: 0x00009488
			// (set) Token: 0x06000200 RID: 512 RVA: 0x00002D5B File Offset: 0x00000F5B
			public unsafe IEnumerator<TResult> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeFieldInfoPtr___3__selector;

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000192 RID: 402
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000193 RID: 403
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000194 RID: 404
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000195 RID: 405
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000196 RID: 406
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200002A RID: 42
		[ObfuscatedName("System.Linq.Enumerable+<ConcatIterator>d__59`1")]
		public sealed class _ConcatIterator_d__59<TSource> : Object
		{
			// Token: 0x06000201 RID: 513 RVA: 0x0000B2B8 File Offset: 0x000094B8
			// Note: this type is marked as 'beforefieldinit'.
			static _ConcatIterator_d__59()
			{
				Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<ConcatIterator>d__59`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr);
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "first");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>3__first");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "second");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>3__second");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663442);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663443);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663444);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663445);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663446);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663447);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663448);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663449);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663450);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663451);
			}

			// Token: 0x06000202 RID: 514 RVA: 0x0000B488 File Offset: 0x00009688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConcatIterator_d__59(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000203 RID: 515 RVA: 0x0000B4D0 File Offset: 0x000096D0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000204 RID: 516 RVA: 0x0000B504 File Offset: 0x00009704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363048, XrefRangeEnd = 363071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000205 RID: 517 RVA: 0x0000B540 File Offset: 0x00009740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363071, XrefRangeEnd = 363074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0000B574 File Offset: 0x00009774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363074, XrefRangeEnd = 363077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000207 RID: 519 RVA: 0x0000B5A8 File Offset: 0x000097A8
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0000B5E4 File Offset: 0x000097E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363077, XrefRangeEnd = 363082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000209 RID: 521 RVA: 0x0000B618 File Offset: 0x00009818
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0000B658 File Offset: 0x00009858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363082, XrefRangeEnd = 363087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x0600020B RID: 523 RVA: 0x0000B698 File Offset: 0x00009898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363087, XrefRangeEnd = 363088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00002D7A File Offset: 0x00000F7A
			public _ConcatIterator_d__59(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x0600020D RID: 525 RVA: 0x0000B6D8 File Offset: 0x000098D8
			// (set) Token: 0x0600020E RID: 526 RVA: 0x00002D83 File Offset: 0x00000F83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600020F RID: 527 RVA: 0x0000B700 File Offset: 0x00009900
			// (set) Token: 0x06000210 RID: 528 RVA: 0x0000B728 File Offset: 0x00009928
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000211 RID: 529 RVA: 0x0000B7D0 File Offset: 0x000099D0
			// (set) Token: 0x06000212 RID: 530 RVA: 0x00002D9E File Offset: 0x00000F9E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000213 RID: 531 RVA: 0x0000B7F8 File Offset: 0x000099F8
			// (set) Token: 0x06000214 RID: 532 RVA: 0x00002DB9 File Offset: 0x00000FB9
			public unsafe IEnumerable<TSource> first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000215 RID: 533 RVA: 0x0000B828 File Offset: 0x00009A28
			// (set) Token: 0x06000216 RID: 534 RVA: 0x00002DD8 File Offset: 0x00000FD8
			public unsafe IEnumerable<TSource> __3__first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000217 RID: 535 RVA: 0x0000B858 File Offset: 0x00009A58
			// (set) Token: 0x06000218 RID: 536 RVA: 0x00002DF7 File Offset: 0x00000FF7
			public unsafe IEnumerable<TSource> second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000219 RID: 537 RVA: 0x0000B888 File Offset: 0x00009A88
			// (set) Token: 0x0600021A RID: 538 RVA: 0x00002E16 File Offset: 0x00001016
			public unsafe IEnumerable<TSource> __3__second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600021B RID: 539 RVA: 0x0000B8B8 File Offset: 0x00009AB8
			// (set) Token: 0x0600021C RID: 540 RVA: 0x00002E35 File Offset: 0x00001035
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeFieldInfoPtr___3__first;

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeFieldInfoPtr___3__second;

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001A5 RID: 421
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001A6 RID: 422
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040001A7 RID: 423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x040001A8 RID: 424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001A9 RID: 425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001AA RID: 426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x040001AB RID: 427
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200002B RID: 43
		[ObfuscatedName("System.Linq.Enumerable+<DistinctIterator>d__68`1")]
		public sealed class _DistinctIterator_d__68<TSource> : Object
		{
			// Token: 0x0600021D RID: 541 RVA: 0x0000B8E8 File Offset: 0x00009AE8
			// Note: this type is marked as 'beforefieldinit'.
			static _DistinctIterator_d__68()
			{
				Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<DistinctIterator>d__68`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr);
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "comparer");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>3__comparer");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "source");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr__set_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<set>5__1");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663452);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663453);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663454);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663455);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663456);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663457);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663458);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663459);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663460);
			}

			// Token: 0x0600021E RID: 542 RVA: 0x0000BAB8 File Offset: 0x00009CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DistinctIterator_d__68(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600021F RID: 543 RVA: 0x0000BB00 File Offset: 0x00009D00
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000220 RID: 544 RVA: 0x0000BB34 File Offset: 0x00009D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363088, XrefRangeEnd = 363101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000221 RID: 545 RVA: 0x0000BB70 File Offset: 0x00009D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363101, XrefRangeEnd = 363104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000222 RID: 546 RVA: 0x0000BBA4 File Offset: 0x00009DA4
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x06000223 RID: 547 RVA: 0x0000BBE0 File Offset: 0x00009DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363104, XrefRangeEnd = 363109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000224 RID: 548 RVA: 0x0000BC14 File Offset: 0x00009E14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000BC54 File Offset: 0x00009E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363109, XrefRangeEnd = 363114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000226 RID: 550 RVA: 0x0000BC94 File Offset: 0x00009E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363114, XrefRangeEnd = 363115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000227 RID: 551 RVA: 0x00002E54 File Offset: 0x00001054
			public _DistinctIterator_d__68(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000228 RID: 552 RVA: 0x0000BCD4 File Offset: 0x00009ED4
			// (set) Token: 0x06000229 RID: 553 RVA: 0x00002E5D File Offset: 0x0000105D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600022A RID: 554 RVA: 0x0000BCFC File Offset: 0x00009EFC
			// (set) Token: 0x0600022B RID: 555 RVA: 0x0000BD24 File Offset: 0x00009F24
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x0600022C RID: 556 RVA: 0x0000BDCC File Offset: 0x00009FCC
			// (set) Token: 0x0600022D RID: 557 RVA: 0x00002E78 File Offset: 0x00001078
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x0600022E RID: 558 RVA: 0x0000BDF4 File Offset: 0x00009FF4
			// (set) Token: 0x0600022F RID: 559 RVA: 0x00002E93 File Offset: 0x00001093
			public unsafe IEqualityComparer<TSource> comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000230 RID: 560 RVA: 0x0000BE24 File Offset: 0x0000A024
			// (set) Token: 0x06000231 RID: 561 RVA: 0x00002EB2 File Offset: 0x000010B2
			public unsafe IEqualityComparer<TSource> __3__comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000232 RID: 562 RVA: 0x0000BE54 File Offset: 0x0000A054
			// (set) Token: 0x06000233 RID: 563 RVA: 0x00002ED1 File Offset: 0x000010D1
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000234 RID: 564 RVA: 0x0000BE84 File Offset: 0x0000A084
			// (set) Token: 0x06000235 RID: 565 RVA: 0x00002EF0 File Offset: 0x000010F0
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000236 RID: 566 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
			// (set) Token: 0x06000237 RID: 567 RVA: 0x00002F0F File Offset: 0x0000110F
			public unsafe Set<TSource> _set_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr__set_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Set<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr__set_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000238 RID: 568 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
			// (set) Token: 0x06000239 RID: 569 RVA: 0x00002F2E File Offset: 0x0000112E
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001AC RID: 428
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001AD RID: 429
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001AE RID: 430
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040001AF RID: 431
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x040001B0 RID: 432
			private static readonly IntPtr NativeFieldInfoPtr___3__comparer;

			// Token: 0x040001B1 RID: 433
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040001B2 RID: 434
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x040001B3 RID: 435
			private static readonly IntPtr NativeFieldInfoPtr__set_5__1;

			// Token: 0x040001B4 RID: 436
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001BC RID: 444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x040001BD RID: 445
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200002C RID: 44
		[ObfuscatedName("System.Linq.Enumerable+<CastIterator>d__99`1")]
		public sealed class _CastIterator_d__99<TResult> : Object
		{
			// Token: 0x0600023A RID: 570 RVA: 0x0000BF14 File Offset: 0x0000A114
			// Note: this type is marked as 'beforefieldinit'.
			static _CastIterator_d__99()
			{
				Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<CastIterator>d__99`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr);
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "source");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663461);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663462);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663463);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663464);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663465);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663466);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663467);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663468);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663469);
			}

			// Token: 0x0600023B RID: 571 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CastIterator_d__99(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600023C RID: 572 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023D RID: 573 RVA: 0x0000C124 File Offset: 0x0000A324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363115, XrefRangeEnd = 363130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600023E RID: 574 RVA: 0x0000C160 File Offset: 0x0000A360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363130, XrefRangeEnd = 363135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x0600023F RID: 575 RVA: 0x0000C194 File Offset: 0x0000A394
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x06000240 RID: 576 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363135, XrefRangeEnd = 363140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000241 RID: 577 RVA: 0x0000C204 File Offset: 0x0000A404
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000242 RID: 578 RVA: 0x0000C244 File Offset: 0x0000A444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363140, XrefRangeEnd = 363145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x0000C284 File Offset: 0x0000A484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00002F4D File Offset: 0x0000114D
			public _CastIterator_d__99(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000245 RID: 581 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
			// (set) Token: 0x06000246 RID: 582 RVA: 0x00002F56 File Offset: 0x00001156
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000247 RID: 583 RVA: 0x0000C2EC File Offset: 0x0000A4EC
			// (set) Token: 0x06000248 RID: 584 RVA: 0x0000C314 File Offset: 0x0000A514
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000249 RID: 585 RVA: 0x0000C3BC File Offset: 0x0000A5BC
			// (set) Token: 0x0600024A RID: 586 RVA: 0x00002F71 File Offset: 0x00001171
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x0600024B RID: 587 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
			// (set) Token: 0x0600024C RID: 588 RVA: 0x00002F8C File Offset: 0x0000118C
			public unsafe IEnumerable source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600024D RID: 589 RVA: 0x0000C414 File Offset: 0x0000A614
			// (set) Token: 0x0600024E RID: 590 RVA: 0x00002FAB File Offset: 0x000011AB
			public unsafe IEnumerable __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600024F RID: 591 RVA: 0x0000C444 File Offset: 0x0000A644
			// (set) Token: 0x06000250 RID: 592 RVA: 0x00002FCA File Offset: 0x000011CA
			public unsafe IEnumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001BE RID: 446
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001BF RID: 447
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001C0 RID: 448
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040001C1 RID: 449
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040001C2 RID: 450
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x040001C3 RID: 451
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001C4 RID: 452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x040001CC RID: 460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200002D RID: 45
		[ObfuscatedName("System.Linq.Enumerable+<RangeIterator>d__115")]
		public sealed class _RangeIterator_d__115 : Object
		{
			// Token: 0x06000251 RID: 593 RVA: 0x0000C474 File Offset: 0x0000A674
			// Note: this type is marked as 'beforefieldinit'.
			static _RangeIterator_d__115()
			{
				Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<RangeIterator>d__115");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr);
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>1__state");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>2__current");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "start");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>3__start");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr__i_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<i>5__1");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "count");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>3__count");
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663470);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663471);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663472);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663473);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663474);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663475);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663476);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663477);
			}

			// Token: 0x06000252 RID: 594 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RangeIterator_d__115(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000253 RID: 595 RVA: 0x0000C628 File Offset: 0x0000A828
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000254 RID: 596 RVA: 0x0000C65C File Offset: 0x0000A85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363145, XrefRangeEnd = 363146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000255 RID: 597 RVA: 0x0000C698 File Offset: 0x0000A898
			public unsafe int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000256 RID: 598 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363146, XrefRangeEnd = 363151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000257 RID: 599 RVA: 0x0000C708 File Offset: 0x0000A908
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363151, XrefRangeEnd = 363154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000258 RID: 600 RVA: 0x0000C748 File Offset: 0x0000A948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363154, XrefRangeEnd = 363162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x06000259 RID: 601 RVA: 0x0000C788 File Offset: 0x0000A988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600025A RID: 602 RVA: 0x00002FE9 File Offset: 0x000011E9
			public _RangeIterator_d__115(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x0600025B RID: 603 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
			// (set) Token: 0x0600025C RID: 604 RVA: 0x00002FF2 File Offset: 0x000011F2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x0600025D RID: 605 RVA: 0x0000C7F0 File Offset: 0x0000A9F0
			// (set) Token: 0x0600025E RID: 606 RVA: 0x0000300D File Offset: 0x0000120D
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x0600025F RID: 607 RVA: 0x0000C818 File Offset: 0x0000AA18
			// (set) Token: 0x06000260 RID: 608 RVA: 0x00003028 File Offset: 0x00001228
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000261 RID: 609 RVA: 0x0000C840 File Offset: 0x0000AA40
			// (set) Token: 0x06000262 RID: 610 RVA: 0x00003043 File Offset: 0x00001243
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000263 RID: 611 RVA: 0x0000C868 File Offset: 0x0000AA68
			// (set) Token: 0x06000264 RID: 612 RVA: 0x0000305E File Offset: 0x0000125E
			public unsafe int __3__start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__start)) = value;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000265 RID: 613 RVA: 0x0000C890 File Offset: 0x0000AA90
			// (set) Token: 0x06000266 RID: 614 RVA: 0x00003079 File Offset: 0x00001279
			public unsafe int _i_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr__i_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr__i_5__1)) = value;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000267 RID: 615 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
			// (set) Token: 0x06000268 RID: 616 RVA: 0x00003094 File Offset: 0x00001294
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000269 RID: 617 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
			// (set) Token: 0x0600026A RID: 618 RVA: 0x000030AF File Offset: 0x000012AF
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001CF RID: 463
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeFieldInfoPtr___3__start;

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeFieldInfoPtr__i_5__1;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001D6 RID: 470
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001D7 RID: 471
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200002E RID: 46
		private sealed class MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x040001DD RID: 477
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002F RID: 47
		private sealed class MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>
		{
			// Token: 0x040001DE RID: 478
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000030 RID: 48
		private sealed class MethodInfoStoreGeneric_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x040001DF RID: 479
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000031 RID: 49
		private sealed class MethodInfoStoreGeneric_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0<TSource, TMiddle, TResult>
		{
			// Token: 0x040001E0 RID: 480
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMiddle>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000032 RID: 50
		private sealed class MethodInfoStoreGeneric_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>
		{
			// Token: 0x040001E1 RID: 481
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000033 RID: 51
		private sealed class MethodInfoStoreGeneric_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>
		{
			// Token: 0x040001E2 RID: 482
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000034 RID: 52
		private sealed class MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x040001E3 RID: 483
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000035 RID: 53
		private sealed class MethodInfoStoreGeneric_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x040001E4 RID: 484
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000036 RID: 54
		private sealed class MethodInfoStoreGeneric_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x040001E5 RID: 485
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000037 RID: 55
		private sealed class MethodInfoStoreGeneric_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x040001E6 RID: 486
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000038 RID: 56
		private sealed class MethodInfoStoreGeneric_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IEqualityComparer_1_TKey_0<TSource, TKey>
		{
			// Token: 0x040001E7 RID: 487
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IEqualityComparer_1_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000039 RID: 57
		private sealed class MethodInfoStoreGeneric_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001E8 RID: 488
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003A RID: 58
		private sealed class MethodInfoStoreGeneric_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001E9 RID: 489
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003B RID: 59
		private sealed class MethodInfoStoreGeneric_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001EA RID: 490
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003C RID: 60
		private sealed class MethodInfoStoreGeneric_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x040001EB RID: 491
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003D RID: 61
		private sealed class MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001EC RID: 492
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003E RID: 62
		private sealed class MethodInfoStoreGeneric_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001ED RID: 493
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003F RID: 63
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x040001EE RID: 494
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000040 RID: 64
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0<TSource, TKey, TElement>
		{
			// Token: 0x040001EF RID: 495
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000041 RID: 65
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0<TSource, TKey, TElement>
		{
			// Token: 0x040001F0 RID: 496
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000042 RID: 66
		private sealed class MethodInfoStoreGeneric_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x040001F1 RID: 497
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000043 RID: 67
		private sealed class MethodInfoStoreGeneric_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x040001F2 RID: 498
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000044 RID: 68
		private sealed class MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001F3 RID: 499
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000045 RID: 69
		private sealed class MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001F4 RID: 500
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000046 RID: 70
		private sealed class MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x040001F5 RID: 501
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000047 RID: 71
		private sealed class MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001F6 RID: 502
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000048 RID: 72
		private sealed class MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x040001F7 RID: 503
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000049 RID: 73
		private sealed class MethodInfoStoreGeneric_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x040001F8 RID: 504
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004A RID: 74
		private sealed class MethodInfoStoreGeneric_Empty_Public_Static_IEnumerable_1_TResult_0<TResult>
		{
			// Token: 0x040001F9 RID: 505
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004B RID: 75
		private sealed class MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001FA RID: 506
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004C RID: 76
		private sealed class MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x040001FB RID: 507
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004D RID: 77
		private sealed class MethodInfoStoreGeneric_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x040001FC RID: 508
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004E RID: 78
		private sealed class MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x040001FD RID: 509
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004F RID: 79
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0<TSource>
		{
			// Token: 0x040001FE RID: 510
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000050 RID: 80
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x040001FF RID: 511
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}
	}
}
