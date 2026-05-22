using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200015F RID: 351
	public class PlaneShadow : MonoBehaviour
	{
		// Token: 0x060029B3 RID: 10675 RVA: 0x000A7A54 File Offset: 0x000A5C54
		// Note: this type is marked as 'beforefieldinit'.
		static PlaneShadow()
		{
			Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlaneShadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr);
			PlaneShadow.NativeFieldInfoPtr_vect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr, "vect");
			PlaneShadow.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr, "speed");
			PlaneShadow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr, 100666595);
			PlaneShadow.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr, 100666596);
			PlaneShadow.NativeMethodInfoPtr_Reset_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr, 100666597);
			PlaneShadow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr, 100666598);
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000A7AFC File Offset: 0x000A5CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77263, XrefRangeEnd = 77282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000A7B30 File Offset: 0x000A5D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77282, XrefRangeEnd = 77288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000A7B64 File Offset: 0x000A5D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77288, XrefRangeEnd = 77291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow.NativeMethodInfoPtr_Reset_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000A7BA4 File Offset: 0x000A5DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaneShadow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x0001CFE2 File Offset: 0x0001B1E2
		public PlaneShadow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000A7BE0 File Offset: 0x000A5DE0
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x0001CFEB File Offset: 0x0001B1EB
		public unsafe Vector3 vect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow.NativeFieldInfoPtr_vect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow.NativeFieldInfoPtr_vect)) = value;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x000A7C08 File Offset: 0x000A5E08
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x0001D006 File Offset: 0x0001B206
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr_vect;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_IEnumerator_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000342 RID: 834
		[ObfuscatedName("PlaneShadow+<Reset>d__4")]
		public sealed class _Reset_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06005298 RID: 21144 RVA: 0x0012C020 File Offset: 0x0012A220
			// Note: this type is marked as 'beforefieldinit'.
			static _Reset_d__4()
			{
				Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaneShadow>.NativeClassPtr, "<Reset>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr);
				PlaneShadow._Reset_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, "<>1__state");
				PlaneShadow._Reset_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, "<>2__current");
				PlaneShadow._Reset_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, "<>4__this");
				PlaneShadow._Reset_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, 100666599);
				PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, 100666600);
				PlaneShadow._Reset_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, 100666601);
				PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, 100666602);
				PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, 100666603);
				PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr, 100666604);
			}

			// Token: 0x06005299 RID: 21145 RVA: 0x0012C100 File Offset: 0x0012A300
			[CallerCount(0)]
			public unsafe _Reset_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaneShadow._Reset_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow._Reset_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600529A RID: 21146 RVA: 0x0012C148 File Offset: 0x0012A348
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600529B RID: 21147 RVA: 0x0012C17C File Offset: 0x0012A37C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77226, XrefRangeEnd = 77258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow._Reset_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E1E RID: 7710
			// (get) Token: 0x0600529C RID: 21148 RVA: 0x0012C1B8 File Offset: 0x0012A3B8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600529D RID: 21149 RVA: 0x0012C1F8 File Offset: 0x0012A3F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77258, XrefRangeEnd = 77263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E1F RID: 7711
			// (get) Token: 0x0600529E RID: 21150 RVA: 0x0012C22C File Offset: 0x0012A42C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaneShadow._Reset_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600529F RID: 21151 RVA: 0x00030277 File Offset: 0x0002E477
			public _Reset_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E1B RID: 7707
			// (get) Token: 0x060052A0 RID: 21152 RVA: 0x0012C26C File Offset: 0x0012A46C
			// (set) Token: 0x060052A1 RID: 21153 RVA: 0x00030280 File Offset: 0x0002E480
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow._Reset_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow._Reset_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E1C RID: 7708
			// (get) Token: 0x060052A2 RID: 21154 RVA: 0x0012C294 File Offset: 0x0012A494
			// (set) Token: 0x060052A3 RID: 21155 RVA: 0x0003029B File Offset: 0x0002E49B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow._Reset_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow._Reset_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E1D RID: 7709
			// (get) Token: 0x060052A4 RID: 21156 RVA: 0x0012C2C4 File Offset: 0x0012A4C4
			// (set) Token: 0x060052A5 RID: 21157 RVA: 0x000302BA File Offset: 0x0002E4BA
			public unsafe PlaneShadow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow._Reset_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaneShadow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaneShadow._Reset_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400368E RID: 13966
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400368F RID: 13967
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003690 RID: 13968
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003691 RID: 13969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003692 RID: 13970
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003693 RID: 13971
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003694 RID: 13972
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003695 RID: 13973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003696 RID: 13974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
