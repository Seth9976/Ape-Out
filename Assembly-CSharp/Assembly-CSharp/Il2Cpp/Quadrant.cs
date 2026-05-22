using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200012A RID: 298
	public class Quadrant : global::UnityEngine.Object
	{
		// Token: 0x06002511 RID: 9489 RVA: 0x0009B510 File Offset: 0x00099710
		// Note: this type is marked as 'beforefieldinit'.
		static Quadrant()
		{
			Il2CppClassPointerStore<Quadrant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Quadrant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quadrant>.NativeClassPtr);
			Quadrant.NativeFieldInfoPtr_guardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, "guardNum");
			Quadrant.NativeFieldInfoPtr_guardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, "guardList");
			Quadrant.NativeFieldInfoPtr_spawnPts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, "spawnPts");
			Quadrant.NativeFieldInfoPtr_squads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, "squads");
			Quadrant.NativeFieldInfoPtr_totalAnimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, "totalAnimals");
			Quadrant.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, 100666243);
			Quadrant.NativeMethodInfoPtr_Clear_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, 100666244);
			Quadrant.NativeMethodInfoPtr_AddGuard_Public_Void_GuardType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, 100666245);
			Quadrant.NativeMethodInfoPtr_AddSquad_Public_Void_Il2CppStructArray_1_GuardType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, 100666246);
			Quadrant.NativeMethodInfoPtr_SpawnGuards_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, 100666247);
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x0009B608 File Offset: 0x00099808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73081, RefRangeEnd = 73082, XrefRangeStart = 73060, XrefRangeEnd = 73081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quadrant(int gNum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quadrant>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0009B650 File Offset: 0x00099850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73086, RefRangeEnd = 73087, XrefRangeStart = 73082, XrefRangeEnd = 73086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(int gNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant.NativeMethodInfoPtr_Clear_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0009B690 File Offset: 0x00099890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73089, RefRangeEnd = 73090, XrefRangeStart = 73087, XrefRangeEnd = 73089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGuard(MapGenerator.GuardType guard, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref guard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant.NativeMethodInfoPtr_AddGuard_Public_Void_GuardType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x0009B6DC File Offset: 0x000998DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73093, RefRangeEnd = 73094, XrefRangeStart = 73090, XrefRangeEnd = 73093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSquad(Il2CppStructArray<MapGenerator.GuardType> guardArr, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guardArr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant.NativeMethodInfoPtr_AddSquad_Public_Void_Il2CppStructArray_1_GuardType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0009B72C File Offset: 0x0009992C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73094, XrefRangeEnd = 73097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SpawnGuards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant.NativeMethodInfoPtr_SpawnGuards_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00019F8F File Offset: 0x0001818F
		public Quadrant(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x0009B76C File Offset: 0x0009996C
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00019F98 File Offset: 0x00018198
		public unsafe int guardNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_guardNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_guardNum)) = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x0009B794 File Offset: 0x00099994
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00019FB3 File Offset: 0x000181B3
		public unsafe List<MapGenerator.GuardType> guardList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_guardList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MapGenerator.GuardType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_guardList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x0009B7C4 File Offset: 0x000999C4
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x00019FD2 File Offset: 0x000181D2
		public unsafe List<Transform> spawnPts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_spawnPts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_spawnPts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0009B7F4 File Offset: 0x000999F4
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00019FF1 File Offset: 0x000181F1
		public unsafe List<Il2CppStructArray<MapGenerator.GuardType>> squads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_squads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<MapGenerator.GuardType>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_squads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x0009B824 File Offset: 0x00099A24
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x0001A010 File Offset: 0x00018210
		public unsafe int totalAnimals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_totalAnimals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant.NativeFieldInfoPtr_totalAnimals)) = value;
			}
		}

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeFieldInfoPtr_guardNum;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeFieldInfoPtr_guardList;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeFieldInfoPtr_spawnPts;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeFieldInfoPtr_squads;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeFieldInfoPtr_totalAnimals;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Int32_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_AddGuard_Public_Void_GuardType_Int32_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_AddSquad_Public_Void_Il2CppStructArray_1_GuardType_Int32_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_SpawnGuards_Public_IEnumerator_0;

		// Token: 0x0200032F RID: 815
		[ObfuscatedName("Quadrant+<SpawnGuards>d__9")]
		public sealed class _SpawnGuards_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x0600516D RID: 20845 RVA: 0x00128B48 File Offset: 0x00126D48
			// Note: this type is marked as 'beforefieldinit'.
			static _SpawnGuards_d__9()
			{
				Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quadrant>.NativeClassPtr, "<SpawnGuards>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr);
				Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, "<>1__state");
				Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, "<>2__current");
				Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, "<>4__this");
				Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, "<i>5__2");
				Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, 100666248);
				Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, 100666249);
				Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, 100666250);
				Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, 100666251);
				Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, 100666252);
				Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr, 100666253);
			}

			// Token: 0x0600516E RID: 20846 RVA: 0x00128C3C File Offset: 0x00126E3C
			[CallerCount(0)]
			public unsafe _SpawnGuards_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quadrant._SpawnGuards_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600516F RID: 20847 RVA: 0x00128C84 File Offset: 0x00126E84
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005170 RID: 20848 RVA: 0x00128CB8 File Offset: 0x00126EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72971, XrefRangeEnd = 73055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DB4 RID: 7604
			// (get) Token: 0x06005171 RID: 20849 RVA: 0x00128CF4 File Offset: 0x00126EF4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005172 RID: 20850 RVA: 0x00128D34 File Offset: 0x00126F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73055, XrefRangeEnd = 73060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DB5 RID: 7605
			// (get) Token: 0x06005173 RID: 20851 RVA: 0x00128D68 File Offset: 0x00126F68
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quadrant._SpawnGuards_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005174 RID: 20852 RVA: 0x0002F702 File Offset: 0x0002D902
			public _SpawnGuards_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DB0 RID: 7600
			// (get) Token: 0x06005175 RID: 20853 RVA: 0x00128DA8 File Offset: 0x00126FA8
			// (set) Token: 0x06005176 RID: 20854 RVA: 0x0002F70B File Offset: 0x0002D90B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DB1 RID: 7601
			// (get) Token: 0x06005177 RID: 20855 RVA: 0x00128DD0 File Offset: 0x00126FD0
			// (set) Token: 0x06005178 RID: 20856 RVA: 0x0002F726 File Offset: 0x0002D926
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB2 RID: 7602
			// (get) Token: 0x06005179 RID: 20857 RVA: 0x00128E00 File Offset: 0x00127000
			// (set) Token: 0x0600517A RID: 20858 RVA: 0x0002F745 File Offset: 0x0002D945
			public unsafe Quadrant __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quadrant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DB3 RID: 7603
			// (get) Token: 0x0600517B RID: 20859 RVA: 0x00128E30 File Offset: 0x00127030
			// (set) Token: 0x0600517C RID: 20860 RVA: 0x0002F764 File Offset: 0x0002D964
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quadrant._SpawnGuards_d__9.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040035E3 RID: 13795
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035E4 RID: 13796
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035E5 RID: 13797
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035E6 RID: 13798
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040035E7 RID: 13799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035E8 RID: 13800
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035E9 RID: 13801
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035EA RID: 13802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035EB RID: 13803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035EC RID: 13804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
