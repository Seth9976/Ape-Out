using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils
{
	// Token: 0x02000211 RID: 529
	public static class EqualityComparerNoAlloc<T> : Object
	{
		// Token: 0x060036EF RID: 14063 RVA: 0x0010FA94 File Offset: 0x0010DC94
		// Note: this type is marked as 'beforefieldinit'.
		static EqualityComparerNoAlloc()
		{
			Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "EqualityComparerNoAlloc`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr);
			EqualityComparerNoAlloc<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, 100676819);
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x0010FB14 File Offset: 0x0010DD14
		public unsafe static IEqualityComparer<T> Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347181, XrefRangeEnd = 347236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_IEqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00012E99 File Offset: 0x00011099
		public EqualityComparerNoAlloc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_IEqualityComparer_1_T_0;

		// Token: 0x020004AD RID: 1197
		public class eNyGQVVnzQhikAQDuQwmMNcCCfi : Object
		{
			// Token: 0x060051B6 RID: 20918 RVA: 0x001738A4 File Offset: 0x00171AA4
			// Note: this type is marked as 'beforefieldinit'.
			static eNyGQVVnzQhikAQDuQwmMNcCCfi()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "eNyGQVVnzQhikAQDuQwmMNcCCfi"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_get_Default_Public_Static_get_eNyGQVVnzQhikAQDuQwmMNcCCfi_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr, 100676820);
				EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr, 100676821);
				EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr, 100676822);
				EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr, 100676823);
				EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr, 100676824);
				EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr, 100676825);
			}

			// Token: 0x17001916 RID: 6422
			// (get) Token: 0x060051B7 RID: 20919 RVA: 0x00173998 File Offset: 0x00171B98
			public unsafe static EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_get_Default_Public_Static_get_eNyGQVVnzQhikAQDuQwmMNcCCfi_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>(intPtr3) : null;
				}
			}

			// Token: 0x060051B8 RID: 20920 RVA: 0x001739CC File Offset: 0x00171BCC
			[CallerCount(0)]
			public unsafe virtual bool Equals(int x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B9 RID: 20921 RVA: 0x00173A24 File Offset: 0x00171C24
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(int obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051BA RID: 20922 RVA: 0x00173A70 File Offset: 0x00171C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347061, XrefRangeEnd = 347069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051BB RID: 20923 RVA: 0x00173AD0 File Offset: 0x00171CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347069, XrefRangeEnd = 347073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051BC RID: 20924 RVA: 0x00173B20 File Offset: 0x00171D20
			[CallerCount(0)]
			public unsafe eNyGQVVnzQhikAQDuQwmMNcCCfi()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x0001D807 File Offset: 0x0001BA07
			public eNyGQVVnzQhikAQDuQwmMNcCCfi(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001915 RID: 6421
			// (get) Token: 0x060051BE RID: 20926 RVA: 0x00173B5C File Offset: 0x00171D5C
			// (set) Token: 0x060051BF RID: 20927 RVA: 0x0001D810 File Offset: 0x0001BA10
			public unsafe static EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.eNyGQVVnzQhikAQDuQwmMNcCCfi.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044B1 RID: 17585
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044B2 RID: 17586
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_eNyGQVVnzQhikAQDuQwmMNcCCfi_T_0;

			// Token: 0x040044B3 RID: 17587
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int32_Int32_0;

			// Token: 0x040044B4 RID: 17588
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Int32_0;

			// Token: 0x040044B5 RID: 17589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044B6 RID: 17590
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044B7 RID: 17591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004AE RID: 1198
		public class NmWuoDcdZSkdpoiLIOauJYBaRdW : Object
		{
			// Token: 0x060051C0 RID: 20928 RVA: 0x00173B84 File Offset: 0x00171D84
			// Note: this type is marked as 'beforefieldinit'.
			static NmWuoDcdZSkdpoiLIOauJYBaRdW()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "NmWuoDcdZSkdpoiLIOauJYBaRdW"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_get_Default_Public_Static_get_NmWuoDcdZSkdpoiLIOauJYBaRdW_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr, 100676826);
				EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr, 100676827);
				EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr, 100676828);
				EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr, 100676829);
				EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr, 100676830);
				EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr, 100676831);
			}

			// Token: 0x17001918 RID: 6424
			// (get) Token: 0x060051C1 RID: 20929 RVA: 0x00173C78 File Offset: 0x00171E78
			public unsafe static EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_get_Default_Public_Static_get_NmWuoDcdZSkdpoiLIOauJYBaRdW_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>(intPtr3) : null;
				}
			}

			// Token: 0x060051C2 RID: 20930 RVA: 0x00173CAC File Offset: 0x00171EAC
			[CallerCount(0)]
			public unsafe virtual bool Equals(ulong x, ulong y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C3 RID: 20931 RVA: 0x00173D04 File Offset: 0x00171F04
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(ulong obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051C4 RID: 20932 RVA: 0x00173D50 File Offset: 0x00171F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347073, XrefRangeEnd = 347081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C5 RID: 20933 RVA: 0x00173DB0 File Offset: 0x00171FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347081, XrefRangeEnd = 347085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051C6 RID: 20934 RVA: 0x00173E00 File Offset: 0x00172000
			[CallerCount(0)]
			public unsafe NmWuoDcdZSkdpoiLIOauJYBaRdW()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051C7 RID: 20935 RVA: 0x0001D822 File Offset: 0x0001BA22
			public NmWuoDcdZSkdpoiLIOauJYBaRdW(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001917 RID: 6423
			// (get) Token: 0x060051C8 RID: 20936 RVA: 0x00173E3C File Offset: 0x0017203C
			// (set) Token: 0x060051C9 RID: 20937 RVA: 0x0001D82B File Offset: 0x0001BA2B
			public unsafe static EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.NmWuoDcdZSkdpoiLIOauJYBaRdW.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044B8 RID: 17592
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044B9 RID: 17593
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_NmWuoDcdZSkdpoiLIOauJYBaRdW_T_0;

			// Token: 0x040044BA RID: 17594
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt64_UInt64_0;

			// Token: 0x040044BB RID: 17595
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt64_0;

			// Token: 0x040044BC RID: 17596
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044BD RID: 17597
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044BE RID: 17598
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004AF RID: 1199
		public class PJICLhHyZtCNXACaTVuOVcUETVVM : Object
		{
			// Token: 0x060051CA RID: 20938 RVA: 0x00173E64 File Offset: 0x00172064
			// Note: this type is marked as 'beforefieldinit'.
			static PJICLhHyZtCNXACaTVuOVcUETVVM()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "PJICLhHyZtCNXACaTVuOVcUETVVM"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_get_Default_Public_Static_get_PJICLhHyZtCNXACaTVuOVcUETVVM_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr, 100676832);
				EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr, 100676833);
				EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr, 100676834);
				EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr, 100676835);
				EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr, 100676836);
				EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr, 100676837);
			}

			// Token: 0x1700191A RID: 6426
			// (get) Token: 0x060051CB RID: 20939 RVA: 0x00173F58 File Offset: 0x00172158
			public unsafe static EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_get_Default_Public_Static_get_PJICLhHyZtCNXACaTVuOVcUETVVM_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>(intPtr3) : null;
				}
			}

			// Token: 0x060051CC RID: 20940 RVA: 0x00173F8C File Offset: 0x0017218C
			[CallerCount(0)]
			public unsafe virtual bool Equals(uint x, uint y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051CD RID: 20941 RVA: 0x00173FE4 File Offset: 0x001721E4
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(uint obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051CE RID: 20942 RVA: 0x00174030 File Offset: 0x00172230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347085, XrefRangeEnd = 347093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051CF RID: 20943 RVA: 0x00174090 File Offset: 0x00172290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347093, XrefRangeEnd = 347097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D0 RID: 20944 RVA: 0x001740E0 File Offset: 0x001722E0
			[CallerCount(0)]
			public unsafe PJICLhHyZtCNXACaTVuOVcUETVVM()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D1 RID: 20945 RVA: 0x0001D83D File Offset: 0x0001BA3D
			public PJICLhHyZtCNXACaTVuOVcUETVVM(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001919 RID: 6425
			// (get) Token: 0x060051D2 RID: 20946 RVA: 0x0017411C File Offset: 0x0017231C
			// (set) Token: 0x060051D3 RID: 20947 RVA: 0x0001D846 File Offset: 0x0001BA46
			public unsafe static EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.PJICLhHyZtCNXACaTVuOVcUETVVM.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044BF RID: 17599
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044C0 RID: 17600
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_PJICLhHyZtCNXACaTVuOVcUETVVM_T_0;

			// Token: 0x040044C1 RID: 17601
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt32_UInt32_0;

			// Token: 0x040044C2 RID: 17602
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt32_0;

			// Token: 0x040044C3 RID: 17603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044C4 RID: 17604
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044C5 RID: 17605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004B0 RID: 1200
		public class wUYRiOYoEehuJSOxCDyCOLTCqIi : Object
		{
			// Token: 0x060051D4 RID: 20948 RVA: 0x00174144 File Offset: 0x00172344
			// Note: this type is marked as 'beforefieldinit'.
			static wUYRiOYoEehuJSOxCDyCOLTCqIi()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "wUYRiOYoEehuJSOxCDyCOLTCqIi"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_get_Default_Public_Static_get_wUYRiOYoEehuJSOxCDyCOLTCqIi_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr, 100676838);
				EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr, 100676839);
				EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr, 100676840);
				EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr, 100676841);
				EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr, 100676842);
				EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr, 100676843);
			}

			// Token: 0x1700191C RID: 6428
			// (get) Token: 0x060051D5 RID: 20949 RVA: 0x00174238 File Offset: 0x00172438
			public unsafe static EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_get_Default_Public_Static_get_wUYRiOYoEehuJSOxCDyCOLTCqIi_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>(intPtr3) : null;
				}
			}

			// Token: 0x060051D6 RID: 20950 RVA: 0x0017426C File Offset: 0x0017246C
			[CallerCount(0)]
			public unsafe virtual bool Equals(ulong x, ulong y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051D7 RID: 20951 RVA: 0x001742C4 File Offset: 0x001724C4
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(ulong obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051D8 RID: 20952 RVA: 0x00174310 File Offset: 0x00172510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347097, XrefRangeEnd = 347105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051D9 RID: 20953 RVA: 0x00174370 File Offset: 0x00172570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347105, XrefRangeEnd = 347109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051DA RID: 20954 RVA: 0x001743C0 File Offset: 0x001725C0
			[CallerCount(0)]
			public unsafe wUYRiOYoEehuJSOxCDyCOLTCqIi()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051DB RID: 20955 RVA: 0x0001D858 File Offset: 0x0001BA58
			public wUYRiOYoEehuJSOxCDyCOLTCqIi(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700191B RID: 6427
			// (get) Token: 0x060051DC RID: 20956 RVA: 0x001743FC File Offset: 0x001725FC
			// (set) Token: 0x060051DD RID: 20957 RVA: 0x0001D861 File Offset: 0x0001BA61
			public unsafe static EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.wUYRiOYoEehuJSOxCDyCOLTCqIi.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044C6 RID: 17606
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044C7 RID: 17607
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_wUYRiOYoEehuJSOxCDyCOLTCqIi_T_0;

			// Token: 0x040044C8 RID: 17608
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UInt64_UInt64_0;

			// Token: 0x040044C9 RID: 17609
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_UInt64_0;

			// Token: 0x040044CA RID: 17610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044CB RID: 17611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044CC RID: 17612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004B1 RID: 1201
		public class bEcAtydcNkOFofFdeSyLKiWTGzkz : Object
		{
			// Token: 0x060051DE RID: 20958 RVA: 0x00174424 File Offset: 0x00172624
			// Note: this type is marked as 'beforefieldinit'.
			static bEcAtydcNkOFofFdeSyLKiWTGzkz()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "bEcAtydcNkOFofFdeSyLKiWTGzkz"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_get_Default_Public_Static_get_bEcAtydcNkOFofFdeSyLKiWTGzkz_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr, 100676844);
				EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr, 100676845);
				EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr, 100676846);
				EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr, 100676847);
				EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr, 100676848);
				EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr, 100676849);
			}

			// Token: 0x1700191E RID: 6430
			// (get) Token: 0x060051DF RID: 20959 RVA: 0x00174518 File Offset: 0x00172718
			public unsafe static EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_get_Default_Public_Static_get_bEcAtydcNkOFofFdeSyLKiWTGzkz_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>(intPtr3) : null;
				}
			}

			// Token: 0x060051E0 RID: 20960 RVA: 0x0017454C File Offset: 0x0017274C
			[CallerCount(0)]
			public unsafe virtual bool Equals(float x, float y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051E1 RID: 20961 RVA: 0x001745A4 File Offset: 0x001727A4
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(float obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051E2 RID: 20962 RVA: 0x001745F0 File Offset: 0x001727F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347109, XrefRangeEnd = 347117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051E3 RID: 20963 RVA: 0x00174650 File Offset: 0x00172850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347117, XrefRangeEnd = 347121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051E4 RID: 20964 RVA: 0x001746A0 File Offset: 0x001728A0
			[CallerCount(0)]
			public unsafe bEcAtydcNkOFofFdeSyLKiWTGzkz()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051E5 RID: 20965 RVA: 0x0001D873 File Offset: 0x0001BA73
			public bEcAtydcNkOFofFdeSyLKiWTGzkz(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700191D RID: 6429
			// (get) Token: 0x060051E6 RID: 20966 RVA: 0x001746DC File Offset: 0x001728DC
			// (set) Token: 0x060051E7 RID: 20967 RVA: 0x0001D87C File Offset: 0x0001BA7C
			public unsafe static EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.bEcAtydcNkOFofFdeSyLKiWTGzkz.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044CD RID: 17613
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044CE RID: 17614
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_bEcAtydcNkOFofFdeSyLKiWTGzkz_T_0;

			// Token: 0x040044CF RID: 17615
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Single_Single_0;

			// Token: 0x040044D0 RID: 17616
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Single_0;

			// Token: 0x040044D1 RID: 17617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044D2 RID: 17618
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044D3 RID: 17619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004B2 RID: 1202
		public class iAJPaqWvIsUKxAXDnGQWHPKlBHaa : Object
		{
			// Token: 0x060051E8 RID: 20968 RVA: 0x00174704 File Offset: 0x00172904
			// Note: this type is marked as 'beforefieldinit'.
			static iAJPaqWvIsUKxAXDnGQWHPKlBHaa()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "iAJPaqWvIsUKxAXDnGQWHPKlBHaa"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_get_Default_Public_Static_get_iAJPaqWvIsUKxAXDnGQWHPKlBHaa_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr, 100676850);
				EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr, 100676851);
				EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr, 100676852);
				EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr, 100676853);
				EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr, 100676854);
				EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr, 100676855);
			}

			// Token: 0x17001920 RID: 6432
			// (get) Token: 0x060051E9 RID: 20969 RVA: 0x001747F8 File Offset: 0x001729F8
			public unsafe static EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_get_Default_Public_Static_get_iAJPaqWvIsUKxAXDnGQWHPKlBHaa_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>(intPtr3) : null;
				}
			}

			// Token: 0x060051EA RID: 20970 RVA: 0x0017482C File Offset: 0x00172A2C
			[CallerCount(0)]
			public unsafe virtual bool Equals(double x, double y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051EB RID: 20971 RVA: 0x00174884 File Offset: 0x00172A84
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(double obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x001748D0 File Offset: 0x00172AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347121, XrefRangeEnd = 347129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051ED RID: 20973 RVA: 0x00174930 File Offset: 0x00172B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347129, XrefRangeEnd = 347133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051EE RID: 20974 RVA: 0x00174980 File Offset: 0x00172B80
			[CallerCount(0)]
			public unsafe iAJPaqWvIsUKxAXDnGQWHPKlBHaa()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051EF RID: 20975 RVA: 0x0001D88E File Offset: 0x0001BA8E
			public iAJPaqWvIsUKxAXDnGQWHPKlBHaa(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700191F RID: 6431
			// (get) Token: 0x060051F0 RID: 20976 RVA: 0x001749BC File Offset: 0x00172BBC
			// (set) Token: 0x060051F1 RID: 20977 RVA: 0x0001D897 File Offset: 0x0001BA97
			public unsafe static EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.iAJPaqWvIsUKxAXDnGQWHPKlBHaa.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044D4 RID: 17620
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044D5 RID: 17621
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_iAJPaqWvIsUKxAXDnGQWHPKlBHaa_T_0;

			// Token: 0x040044D6 RID: 17622
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Double_Double_0;

			// Token: 0x040044D7 RID: 17623
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Double_0;

			// Token: 0x040044D8 RID: 17624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044D9 RID: 17625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044DA RID: 17626
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004B3 RID: 1203
		public class wEcDCVeKPYRItFzJBgmQkhjULttR : Object
		{
			// Token: 0x060051F2 RID: 20978 RVA: 0x001749E4 File Offset: 0x00172BE4
			// Note: this type is marked as 'beforefieldinit'.
			static wEcDCVeKPYRItFzJBgmQkhjULttR()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "wEcDCVeKPYRItFzJBgmQkhjULttR"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_get_Default_Public_Static_get_wEcDCVeKPYRItFzJBgmQkhjULttR_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr, 100676856);
				EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr, 100676857);
				EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr, 100676858);
				EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr, 100676859);
				EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr, 100676860);
				EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr, 100676861);
			}

			// Token: 0x17001922 RID: 6434
			// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00174AD8 File Offset: 0x00172CD8
			public unsafe static EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_get_Default_Public_Static_get_wEcDCVeKPYRItFzJBgmQkhjULttR_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>(intPtr3) : null;
				}
			}

			// Token: 0x060051F4 RID: 20980 RVA: 0x00174B0C File Offset: 0x00172D0C
			[CallerCount(0)]
			public unsafe virtual bool Equals(byte x, byte y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051F5 RID: 20981 RVA: 0x00174B64 File Offset: 0x00172D64
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(byte obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051F6 RID: 20982 RVA: 0x00174BB0 File Offset: 0x00172DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347133, XrefRangeEnd = 347141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051F7 RID: 20983 RVA: 0x00174C10 File Offset: 0x00172E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347141, XrefRangeEnd = 347145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051F8 RID: 20984 RVA: 0x00174C60 File Offset: 0x00172E60
			[CallerCount(0)]
			public unsafe wEcDCVeKPYRItFzJBgmQkhjULttR()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051F9 RID: 20985 RVA: 0x0001D8A9 File Offset: 0x0001BAA9
			public wEcDCVeKPYRItFzJBgmQkhjULttR(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001921 RID: 6433
			// (get) Token: 0x060051FA RID: 20986 RVA: 0x00174C9C File Offset: 0x00172E9C
			// (set) Token: 0x060051FB RID: 20987 RVA: 0x0001D8B2 File Offset: 0x0001BAB2
			public unsafe static EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.wEcDCVeKPYRItFzJBgmQkhjULttR.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044DB RID: 17627
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044DC RID: 17628
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_wEcDCVeKPYRItFzJBgmQkhjULttR_T_0;

			// Token: 0x040044DD RID: 17629
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Byte_Byte_0;

			// Token: 0x040044DE RID: 17630
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Byte_0;

			// Token: 0x040044DF RID: 17631
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044E0 RID: 17632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044E1 RID: 17633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004B4 RID: 1204
		public class nESHfKbGSItdlPMuSJySgdtiHppH : Object
		{
			// Token: 0x060051FC RID: 20988 RVA: 0x00174CC4 File Offset: 0x00172EC4
			// Note: this type is marked as 'beforefieldinit'.
			static nESHfKbGSItdlPMuSJySgdtiHppH()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "nESHfKbGSItdlPMuSJySgdtiHppH"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_get_Default_Public_Static_get_nESHfKbGSItdlPMuSJySgdtiHppH_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr, 100676862);
				EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr, 100676863);
				EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr, 100676864);
				EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr, 100676865);
				EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr, 100676866);
				EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr, 100676867);
			}

			// Token: 0x17001924 RID: 6436
			// (get) Token: 0x060051FD RID: 20989 RVA: 0x00174DB8 File Offset: 0x00172FB8
			public unsafe static EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_get_Default_Public_Static_get_nESHfKbGSItdlPMuSJySgdtiHppH_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>(intPtr3) : null;
				}
			}

			// Token: 0x060051FE RID: 20990 RVA: 0x00174DEC File Offset: 0x00172FEC
			[CallerCount(0)]
			public unsafe virtual bool Equals(sbyte x, sbyte y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SByte_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051FF RID: 20991 RVA: 0x00174E44 File Offset: 0x00173044
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(sbyte obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005200 RID: 20992 RVA: 0x00174E90 File Offset: 0x00173090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347145, XrefRangeEnd = 347153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005201 RID: 20993 RVA: 0x00174EF0 File Offset: 0x001730F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347153, XrefRangeEnd = 347157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005202 RID: 20994 RVA: 0x00174F40 File Offset: 0x00173140
			[CallerCount(0)]
			public unsafe nESHfKbGSItdlPMuSJySgdtiHppH()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005203 RID: 20995 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
			public nESHfKbGSItdlPMuSJySgdtiHppH(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001923 RID: 6435
			// (get) Token: 0x06005204 RID: 20996 RVA: 0x00174F7C File Offset: 0x0017317C
			// (set) Token: 0x06005205 RID: 20997 RVA: 0x0001D8CD File Offset: 0x0001BACD
			public unsafe static EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.nESHfKbGSItdlPMuSJySgdtiHppH.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044E2 RID: 17634
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044E3 RID: 17635
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_nESHfKbGSItdlPMuSJySgdtiHppH_T_0;

			// Token: 0x040044E4 RID: 17636
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SByte_SByte_0;

			// Token: 0x040044E5 RID: 17637
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_SByte_0;

			// Token: 0x040044E6 RID: 17638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044E7 RID: 17639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044E8 RID: 17640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004B5 RID: 1205
		public class UzVcPjbhYLSbhIvhWiCOrZJvpqC : Object
		{
			// Token: 0x06005206 RID: 20998 RVA: 0x00174FA4 File Offset: 0x001731A4
			// Note: this type is marked as 'beforefieldinit'.
			static UzVcPjbhYLSbhIvhWiCOrZJvpqC()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "UzVcPjbhYLSbhIvhWiCOrZJvpqC"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_get_Default_Public_Static_get_UzVcPjbhYLSbhIvhWiCOrZJvpqC_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr, 100676868);
				EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr, 100676869);
				EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr, 100676870);
				EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr, 100676871);
				EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr, 100676872);
				EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr, 100676873);
			}

			// Token: 0x17001926 RID: 6438
			// (get) Token: 0x06005207 RID: 20999 RVA: 0x00175098 File Offset: 0x00173298
			public unsafe static EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_get_Default_Public_Static_get_UzVcPjbhYLSbhIvhWiCOrZJvpqC_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>(intPtr3) : null;
				}
			}

			// Token: 0x06005208 RID: 21000 RVA: 0x001750CC File Offset: 0x001732CC
			[CallerCount(0)]
			public unsafe virtual bool Equals(bool x, bool y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005209 RID: 21001 RVA: 0x00175124 File Offset: 0x00173324
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(bool obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600520A RID: 21002 RVA: 0x00175170 File Offset: 0x00173370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347157, XrefRangeEnd = 347165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600520B RID: 21003 RVA: 0x001751D0 File Offset: 0x001733D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347165, XrefRangeEnd = 347169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600520C RID: 21004 RVA: 0x00175220 File Offset: 0x00173420
			[CallerCount(0)]
			public unsafe UzVcPjbhYLSbhIvhWiCOrZJvpqC()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600520D RID: 21005 RVA: 0x0001D8DF File Offset: 0x0001BADF
			public UzVcPjbhYLSbhIvhWiCOrZJvpqC(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001925 RID: 6437
			// (get) Token: 0x0600520E RID: 21006 RVA: 0x0017525C File Offset: 0x0017345C
			// (set) Token: 0x0600520F RID: 21007 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
			public unsafe static EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.UzVcPjbhYLSbhIvhWiCOrZJvpqC.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044E9 RID: 17641
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044EA RID: 17642
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_UzVcPjbhYLSbhIvhWiCOrZJvpqC_T_0;

			// Token: 0x040044EB RID: 17643
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Boolean_Boolean_0;

			// Token: 0x040044EC RID: 17644
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Boolean_0;

			// Token: 0x040044ED RID: 17645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044EE RID: 17646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044EF RID: 17647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004B6 RID: 1206
		public class WAQOzWLdoBDQzhkMSmhAbPyGLBlC : Object
		{
			// Token: 0x06005210 RID: 21008 RVA: 0x00175284 File Offset: 0x00173484
			// Note: this type is marked as 'beforefieldinit'.
			static WAQOzWLdoBDQzhkMSmhAbPyGLBlC()
			{
				Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>>.NativeClassPtr, "WAQOzWLdoBDQzhkMSmhAbPyGLBlC"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr);
				EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr, "eNxRmYULOLEypsurdrPzmpnXCUdb");
				EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_get_Default_Public_Static_get_WAQOzWLdoBDQzhkMSmhAbPyGLBlC_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr, 100676874);
				EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr, 100676875);
				EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr, 100676876);
				EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr, 100676877);
				EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr, 100676878);
				EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr, 100676879);
			}

			// Token: 0x17001928 RID: 6440
			// (get) Token: 0x06005211 RID: 21009 RVA: 0x00175378 File Offset: 0x00173578
			public unsafe static EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC fdOIlZoUNGDTivZiqDpCzZoybjA
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 346919, RefRangeEnd = 346921, XrefRangeStart = 346919, XrefRangeEnd = 346921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_get_Default_Public_Static_get_WAQOzWLdoBDQzhkMSmhAbPyGLBlC_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>(intPtr3) : null;
				}
			}

			// Token: 0x06005212 RID: 21010 RVA: 0x001753AC File Offset: 0x001735AC
			[CallerCount(0)]
			public unsafe virtual bool Equals(IntPtr x, IntPtr y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005213 RID: 21011 RVA: 0x00175404 File Offset: 0x00173604
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(IntPtr obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref obj;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005214 RID: 21012 RVA: 0x00175450 File Offset: 0x00173650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347169, XrefRangeEnd = 347177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005215 RID: 21013 RVA: 0x001754B0 File Offset: 0x001736B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347177, XrefRangeEnd = 347181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005216 RID: 21014 RVA: 0x00175500 File Offset: 0x00173700
			[CallerCount(0)]
			public unsafe WAQOzWLdoBDQzhkMSmhAbPyGLBlC()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005217 RID: 21015 RVA: 0x0001D8FA File Offset: 0x0001BAFA
			public WAQOzWLdoBDQzhkMSmhAbPyGLBlC(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001927 RID: 6439
			// (get) Token: 0x06005218 RID: 21016 RVA: 0x0017553C File Offset: 0x0017373C
			// (set) Token: 0x06005219 RID: 21017 RVA: 0x0001D903 File Offset: 0x0001BB03
			public unsafe static EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC eNxRmYULOLEypsurdrPzmpnXCUdb
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EqualityComparerNoAlloc<T>.WAQOzWLdoBDQzhkMSmhAbPyGLBlC.NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044F0 RID: 17648
			private static readonly IntPtr NativeFieldInfoPtr_eNxRmYULOLEypsurdrPzmpnXCUdb;

			// Token: 0x040044F1 RID: 17649
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_WAQOzWLdoBDQzhkMSmhAbPyGLBlC_T_0;

			// Token: 0x040044F2 RID: 17650
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IntPtr_IntPtr_0;

			// Token: 0x040044F3 RID: 17651
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_IntPtr_0;

			// Token: 0x040044F4 RID: 17652
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

			// Token: 0x040044F5 RID: 17653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

			// Token: 0x040044F6 RID: 17654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
