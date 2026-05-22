using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200018E RID: 398
	public class SingleIntroTile : MonoBehaviour
	{
		// Token: 0x06002EF6 RID: 12022 RVA: 0x000B5D5C File Offset: 0x000B3F5C
		// Note: this type is marked as 'beforefieldinit'.
		static SingleIntroTile()
		{
			Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SingleIntroTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr);
			SingleIntroTile.NativeFieldInfoPtr_copCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, "copCar");
			SingleIntroTile.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, "me");
			SingleIntroTile.NativeFieldInfoPtr_cop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, "cop");
			SingleIntroTile.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, 100666981);
			SingleIntroTile.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, 100666982);
			SingleIntroTile.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, 100666983);
			SingleIntroTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, 100666984);
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000B5E18 File Offset: 0x000B4018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83057, XrefRangeEnd = 83059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000B5E4C File Offset: 0x000B404C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83059, XrefRangeEnd = 83067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000B5E90 File Offset: 0x000B4090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83067, XrefRangeEnd = 83070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000B5ED0 File Offset: 0x000B40D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleIntroTile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00020644 File Offset: 0x0001E844
		public SingleIntroTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000B5F0C File Offset: 0x000B410C
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x0002064D File Offset: 0x0001E84D
		public unsafe GameObject copCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile.NativeFieldInfoPtr_copCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile.NativeFieldInfoPtr_copCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x000B5F3C File Offset: 0x000B413C
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x0002066C File Offset: 0x0001E86C
		public unsafe static SingleIntroTile me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SingleIntroTile.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleIntroTile>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SingleIntroTile.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x000B5F64 File Offset: 0x000B4164
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x0002067E File Offset: 0x0001E87E
		public unsafe GuardState cop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile.NativeFieldInfoPtr_cop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile.NativeFieldInfoPtr_cop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr_copCar;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr_cop;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_DoIt_Private_IEnumerator_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200034E RID: 846
		[ObfuscatedName("SingleIntroTile+<DoIt>d__5")]
		public sealed class _DoIt_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x0600535A RID: 21338 RVA: 0x0012E51C File Offset: 0x0012C71C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoIt_d__5()
			{
				Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleIntroTile>.NativeClassPtr, "<DoIt>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr);
				SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, "<>1__state");
				SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, "<>2__current");
				SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, "<>4__this");
				SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, 100666985);
				SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, 100666986);
				SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, 100666987);
				SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, 100666988);
				SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, 100666989);
				SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr, 100666990);
			}

			// Token: 0x0600535B RID: 21339 RVA: 0x0012E5FC File Offset: 0x0012C7FC
			[CallerCount(0)]
			public unsafe _DoIt_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleIntroTile._DoIt_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600535C RID: 21340 RVA: 0x0012E644 File Offset: 0x0012C844
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600535D RID: 21341 RVA: 0x0012E678 File Offset: 0x0012C878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83028, XrefRangeEnd = 83052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E67 RID: 7783
			// (get) Token: 0x0600535E RID: 21342 RVA: 0x0012E6B4 File Offset: 0x0012C8B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600535F RID: 21343 RVA: 0x0012E6F4 File Offset: 0x0012C8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83052, XrefRangeEnd = 83057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E68 RID: 7784
			// (get) Token: 0x06005360 RID: 21344 RVA: 0x0012E728 File Offset: 0x0012C928
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntroTile._DoIt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005361 RID: 21345 RVA: 0x0003086E File Offset: 0x0002EA6E
			public _DoIt_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E64 RID: 7780
			// (get) Token: 0x06005362 RID: 21346 RVA: 0x0012E768 File Offset: 0x0012C968
			// (set) Token: 0x06005363 RID: 21347 RVA: 0x00030877 File Offset: 0x0002EA77
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E65 RID: 7781
			// (get) Token: 0x06005364 RID: 21348 RVA: 0x0012E790 File Offset: 0x0012C990
			// (set) Token: 0x06005365 RID: 21349 RVA: 0x00030892 File Offset: 0x0002EA92
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E66 RID: 7782
			// (get) Token: 0x06005366 RID: 21350 RVA: 0x0012E7C0 File Offset: 0x0012C9C0
			// (set) Token: 0x06005367 RID: 21351 RVA: 0x000308B1 File Offset: 0x0002EAB1
			public unsafe SingleIntroTile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleIntroTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntroTile._DoIt_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003707 RID: 14087
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003708 RID: 14088
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003709 RID: 14089
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400370A RID: 14090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400370B RID: 14091
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400370C RID: 14092
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400370D RID: 14093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400370E RID: 14094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400370F RID: 14095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
