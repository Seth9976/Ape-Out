using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000087 RID: 135
	public class Boat04Triggerer : MonoBehaviour
	{
		// Token: 0x060010A4 RID: 4260 RVA: 0x000648BC File Offset: 0x00062ABC
		// Note: this type is marked as 'beforefieldinit'.
		static Boat04Triggerer()
		{
			Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Boat04Triggerer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr);
			Boat04Triggerer.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "done");
			Boat04Triggerer.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "defPos");
			Boat04Triggerer.NativeFieldInfoPtr_wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "wall");
			Boat04Triggerer.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "container");
			Boat04Triggerer.NativeFieldInfoPtr_blown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "blown");
			Boat04Triggerer.NativeFieldInfoPtr_resetPlayerHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "resetPlayerHealth");
			Boat04Triggerer.NativeFieldInfoPtr_rocketer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "rocketer");
			Boat04Triggerer.NativeFieldInfoPtr_greenQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "greenQuad");
			Boat04Triggerer.NativeFieldInfoPtr_palTexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "palTexes");
			Boat04Triggerer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, 100664700);
			Boat04Triggerer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, 100664701);
			Boat04Triggerer.NativeMethodInfoPtr_Blow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, 100664702);
			Boat04Triggerer.NativeMethodInfoPtr_RocketGo_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, 100664703);
			Boat04Triggerer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, 100664704);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00064A04 File Offset: 0x00062C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00064A38 File Offset: 0x00062C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48392, XrefRangeEnd = 48435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00064A6C File Offset: 0x00062C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48451, RefRangeEnd = 48452, XrefRangeStart = 48435, XrefRangeEnd = 48451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer.NativeMethodInfoPtr_Blow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00064AA0 File Offset: 0x00062CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48452, XrefRangeEnd = 48455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RocketGo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer.NativeMethodInfoPtr_RocketGo_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00064AE0 File Offset: 0x00062CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Boat04Triggerer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0000C433 File Offset: 0x0000A633
		public Boat04Triggerer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00064B1C File Offset: 0x00062D1C
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x0000C43C File Offset: 0x0000A63C
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00064B44 File Offset: 0x00062D44
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x0000C457 File Offset: 0x0000A657
		public unsafe Vector3 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00064B6C File Offset: 0x00062D6C
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x0000C472 File Offset: 0x0000A672
		public unsafe GameObject wall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_wall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_wall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00064B9C File Offset: 0x00062D9C
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x0000C491 File Offset: 0x0000A691
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00064BCC File Offset: 0x00062DCC
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		public unsafe GameObject blown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_blown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_blown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00064BFC File Offset: 0x00062DFC
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0000C4CF File Offset: 0x0000A6CF
		public unsafe int resetPlayerHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_resetPlayerHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_resetPlayerHealth)) = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00064C24 File Offset: 0x00062E24
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x0000C4EA File Offset: 0x0000A6EA
		public unsafe Il2CppReferenceArray<GuardState> rocketer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_rocketer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuardState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_rocketer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x00064C54 File Offset: 0x00062E54
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x0000C509 File Offset: 0x0000A709
		public unsafe GameObject greenQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_greenQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_greenQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00064C84 File Offset: 0x00062E84
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000C528 File Offset: 0x0000A728
		public unsafe Il2CppReferenceArray<Texture> palTexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_palTexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer.NativeFieldInfoPtr_palTexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_wall;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr_blown;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_resetPlayerHealth;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_rocketer;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr_greenQuad;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr_palTexes;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_Blow_Public_Void_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_RocketGo_Private_IEnumerator_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D7 RID: 727
		[ObfuscatedName("Boat04Triggerer+<RocketGo>d__12")]
		public sealed class _RocketGo_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D1E RID: 19742 RVA: 0x0011B6E4 File Offset: 0x001198E4
			// Note: this type is marked as 'beforefieldinit'.
			static _RocketGo_d__12()
			{
				Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Boat04Triggerer>.NativeClassPtr, "<RocketGo>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr);
				Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, "<>1__state");
				Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, "<>2__current");
				Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, "<>4__this");
				Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, 100664705);
				Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, 100664706);
				Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, 100664707);
				Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, 100664708);
				Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, 100664709);
				Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr, 100664710);
			}

			// Token: 0x06004D1F RID: 19743 RVA: 0x0011B7C4 File Offset: 0x001199C4
			[CallerCount(0)]
			public unsafe _RocketGo_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Boat04Triggerer._RocketGo_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D20 RID: 19744 RVA: 0x0011B80C File Offset: 0x00119A0C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D21 RID: 19745 RVA: 0x0011B840 File Offset: 0x00119A40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48382, XrefRangeEnd = 48387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C1A RID: 7194
			// (get) Token: 0x06004D22 RID: 19746 RVA: 0x0011B87C File Offset: 0x00119A7C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D23 RID: 19747 RVA: 0x0011B8BC File Offset: 0x00119ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48387, XrefRangeEnd = 48392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C1B RID: 7195
			// (get) Token: 0x06004D24 RID: 19748 RVA: 0x0011B8F0 File Offset: 0x00119AF0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat04Triggerer._RocketGo_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D25 RID: 19749 RVA: 0x0002D5D4 File Offset: 0x0002B7D4
			public _RocketGo_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C17 RID: 7191
			// (get) Token: 0x06004D26 RID: 19750 RVA: 0x0011B930 File Offset: 0x00119B30
			// (set) Token: 0x06004D27 RID: 19751 RVA: 0x0002D5DD File Offset: 0x0002B7DD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C18 RID: 7192
			// (get) Token: 0x06004D28 RID: 19752 RVA: 0x0011B958 File Offset: 0x00119B58
			// (set) Token: 0x06004D29 RID: 19753 RVA: 0x0002D5F8 File Offset: 0x0002B7F8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C19 RID: 7193
			// (get) Token: 0x06004D2A RID: 19754 RVA: 0x0011B988 File Offset: 0x00119B88
			// (set) Token: 0x06004D2B RID: 19755 RVA: 0x0002D617 File Offset: 0x0002B817
			public unsafe Boat04Triggerer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Boat04Triggerer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat04Triggerer._RocketGo_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400327F RID: 12927
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003280 RID: 12928
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003281 RID: 12929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003282 RID: 12930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003283 RID: 12931
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003284 RID: 12932
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003285 RID: 12933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003286 RID: 12934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003287 RID: 12935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
