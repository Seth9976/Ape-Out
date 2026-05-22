using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200013E RID: 318
	public class Obstacle : MonoBehaviour
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x0009FBA8 File Offset: 0x0009DDA8
		// Note: this type is marked as 'beforefieldinit'.
		static Obstacle()
		{
			Il2CppClassPointerStore<Obstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Obstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Obstacle>.NativeClassPtr);
			Obstacle.NativeFieldInfoPtr_pathFinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Obstacle>.NativeClassPtr, "pathFinder");
			Obstacle.NativeFieldInfoPtr_myCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Obstacle>.NativeClassPtr, "myCollider");
			Obstacle.NativeFieldInfoPtr_savedBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Obstacle>.NativeClassPtr, "savedBounds");
			Obstacle.NativeFieldInfoPtr_alreadyDidIt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Obstacle>.NativeClassPtr, "alreadyDidIt");
			Obstacle.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Obstacle>.NativeClassPtr, 100666390);
			Obstacle.NativeMethodInfoPtr_UpdateGrid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Obstacle>.NativeClassPtr, 100666391);
			Obstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Obstacle>.NativeClassPtr, 100666392);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0009FC64 File Offset: 0x0009DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74858, XrefRangeEnd = 74875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Obstacle.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x0009FC98 File Offset: 0x0009DE98
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 74887, RefRangeEnd = 74895, XrefRangeStart = 74875, XrefRangeEnd = 74887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Obstacle.NativeMethodInfoPtr_UpdateGrid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x0009FCCC File Offset: 0x0009DECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Obstacle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Obstacle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Obstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x0001AEEF File Offset: 0x000190EF
		public Obstacle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x0009FD08 File Offset: 0x0009DF08
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x0001AEF8 File Offset: 0x000190F8
		public unsafe PathFinding pathFinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_pathFinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathFinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_pathFinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0009FD38 File Offset: 0x0009DF38
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x0001AF17 File Offset: 0x00019117
		public unsafe Collider2D myCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_myCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_myCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0009FD68 File Offset: 0x0009DF68
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x0001AF36 File Offset: 0x00019136
		public unsafe Bounds savedBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_savedBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_savedBounds)) = value;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x0009FD90 File Offset: 0x0009DF90
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x0001AF51 File Offset: 0x00019151
		public unsafe bool alreadyDidIt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_alreadyDidIt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Obstacle.NativeFieldInfoPtr_alreadyDidIt)) = value;
			}
		}

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeFieldInfoPtr_pathFinder;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeFieldInfoPtr_myCollider;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeFieldInfoPtr_savedBounds;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeFieldInfoPtr_alreadyDidIt;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGrid_Public_Void_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
