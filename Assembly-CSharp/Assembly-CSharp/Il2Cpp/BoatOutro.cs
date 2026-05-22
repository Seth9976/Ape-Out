using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200008A RID: 138
	public class BoatOutro : MonoBehaviour
	{
		// Token: 0x06001111 RID: 4369 RVA: 0x00065910 File Offset: 0x00063B10
		// Note: this type is marked as 'beforefieldinit'.
		static BoatOutro()
		{
			Il2CppClassPointerStore<BoatOutro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BoatOutro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr);
			BoatOutro.NativeFieldInfoPtr_car = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, "car");
			BoatOutro.NativeFieldInfoPtr_whiteScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, "whiteScreen");
			BoatOutro.NativeFieldInfoPtr_carSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, "carSpd");
			BoatOutro.NativeFieldInfoPtr_goin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, "goin");
			BoatOutro.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, 100664745);
			BoatOutro.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, 100664746);
			BoatOutro.NativeMethodInfoPtr_Car_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, 100664747);
			BoatOutro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, 100664748);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000659E0 File Offset: 0x00063BE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00065A14 File Offset: 0x00063C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48716, XrefRangeEnd = 48762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00065A48 File Offset: 0x00063C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48762, XrefRangeEnd = 48765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Car()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro.NativeMethodInfoPtr_Car_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00065A88 File Offset: 0x00063C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoatOutro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0000C95D File Offset: 0x0000AB5D
		public BoatOutro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00065AC4 File Offset: 0x00063CC4
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x0000C966 File Offset: 0x0000AB66
		public unsafe GameObject car
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_car);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_car), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00065AF4 File Offset: 0x00063CF4
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x0000C985 File Offset: 0x0000AB85
		public unsafe GameObject whiteScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_whiteScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_whiteScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00065B24 File Offset: 0x00063D24
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		public unsafe float carSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_carSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_carSpd)) = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x00065B4C File Offset: 0x00063D4C
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0000C9BF File Offset: 0x0000ABBF
		public unsafe bool goin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_goin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro.NativeFieldInfoPtr_goin)) = value;
			}
		}

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_car;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_whiteScreen;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_carSpd;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_goin;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_Car_Private_IEnumerator_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DC RID: 732
		[ObfuscatedName("BoatOutro+<Car>d__6")]
		public sealed class _Car_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D68 RID: 19816 RVA: 0x0011C580 File Offset: 0x0011A780
			// Note: this type is marked as 'beforefieldinit'.
			static _Car_d__6()
			{
				Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoatOutro>.NativeClassPtr, "<Car>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr);
				BoatOutro._Car_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, "<>1__state");
				BoatOutro._Car_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, "<>2__current");
				BoatOutro._Car_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, "<>4__this");
				BoatOutro._Car_d__6.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, "<timer>5__2");
				BoatOutro._Car_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, 100664749);
				BoatOutro._Car_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, 100664750);
				BoatOutro._Car_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, 100664751);
				BoatOutro._Car_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, 100664752);
				BoatOutro._Car_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, 100664753);
				BoatOutro._Car_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr, 100664754);
			}

			// Token: 0x06004D69 RID: 19817 RVA: 0x0011C674 File Offset: 0x0011A874
			[CallerCount(0)]
			public unsafe _Car_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatOutro._Car_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro._Car_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D6A RID: 19818 RVA: 0x0011C6BC File Offset: 0x0011A8BC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro._Car_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D6B RID: 19819 RVA: 0x0011C6F0 File Offset: 0x0011A8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48701, XrefRangeEnd = 48711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro._Car_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C36 RID: 7222
			// (get) Token: 0x06004D6C RID: 19820 RVA: 0x0011C72C File Offset: 0x0011A92C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro._Car_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D6D RID: 19821 RVA: 0x0011C76C File Offset: 0x0011A96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48711, XrefRangeEnd = 48716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro._Car_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C37 RID: 7223
			// (get) Token: 0x06004D6E RID: 19822 RVA: 0x0011C7A0 File Offset: 0x0011A9A0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatOutro._Car_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D6F RID: 19823 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
			public _Car_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C32 RID: 7218
			// (get) Token: 0x06004D70 RID: 19824 RVA: 0x0011C7E0 File Offset: 0x0011A9E0
			// (set) Token: 0x06004D71 RID: 19825 RVA: 0x0002D7FD File Offset: 0x0002B9FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C33 RID: 7219
			// (get) Token: 0x06004D72 RID: 19826 RVA: 0x0011C808 File Offset: 0x0011AA08
			// (set) Token: 0x06004D73 RID: 19827 RVA: 0x0002D818 File Offset: 0x0002BA18
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C34 RID: 7220
			// (get) Token: 0x06004D74 RID: 19828 RVA: 0x0011C838 File Offset: 0x0011AA38
			// (set) Token: 0x06004D75 RID: 19829 RVA: 0x0002D837 File Offset: 0x0002BA37
			public unsafe BoatOutro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoatOutro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C35 RID: 7221
			// (get) Token: 0x06004D76 RID: 19830 RVA: 0x0011C868 File Offset: 0x0011AA68
			// (set) Token: 0x06004D77 RID: 19831 RVA: 0x0002D856 File Offset: 0x0002BA56
			public unsafe float _timer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr__timer_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatOutro._Car_d__6.NativeFieldInfoPtr__timer_5__2)) = value;
				}
			}

			// Token: 0x040032AE RID: 12974
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032AF RID: 12975
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032B0 RID: 12976
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032B1 RID: 12977
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__2;

			// Token: 0x040032B2 RID: 12978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032B3 RID: 12979
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032B4 RID: 12980
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032B5 RID: 12981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032B6 RID: 12982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032B7 RID: 12983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
