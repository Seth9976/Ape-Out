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
	// Token: 0x02000089 RID: 137
	public class BoatIntroTile : MonoBehaviour
	{
		// Token: 0x060010F7 RID: 4343 RVA: 0x00065524 File Offset: 0x00063724
		// Note: this type is marked as 'beforefieldinit'.
		static BoatIntroTile()
		{
			Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BoatIntroTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr);
			BoatIntroTile.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "top");
			BoatIntroTile.NativeFieldInfoPtr_doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "doors");
			BoatIntroTile.NativeFieldInfoPtr_camCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "camCurve");
			BoatIntroTile.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "done");
			BoatIntroTile.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "timer");
			BoatIntroTile.NativeFieldInfoPtr_zoomTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "zoomTime");
			BoatIntroTile.NativeFieldInfoPtr_quads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "quads");
			BoatIntroTile.NativeFieldInfoPtr_foregroundStuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "foregroundStuff");
			BoatIntroTile.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "me");
			BoatIntroTile.NativeFieldInfoPtr_IntroContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "IntroContainer");
			BoatIntroTile.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, 100664735);
			BoatIntroTile.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, 100664736);
			BoatIntroTile.NativeMethodInfoPtr_ZoomOut_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, 100664737);
			BoatIntroTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, 100664738);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0006566C File Offset: 0x0006386C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48642, XrefRangeEnd = 48657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000656A0 File Offset: 0x000638A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48657, XrefRangeEnd = 48697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x000656D4 File Offset: 0x000638D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48700, RefRangeEnd = 48701, XrefRangeStart = 48697, XrefRangeEnd = 48700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ZoomOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile.NativeMethodInfoPtr_ZoomOut_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00065714 File Offset: 0x00063914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoatIntroTile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0000C837 File Offset: 0x0000AA37
		public BoatIntroTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00065750 File Offset: 0x00063950
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0000C840 File Offset: 0x0000AA40
		public unsafe MeshRenderer top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_top);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_top), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x00065780 File Offset: 0x00063980
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0000C85F File Offset: 0x0000AA5F
		public unsafe Il2CppReferenceArray<SwingyDoor> doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SwingyDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x000657B0 File Offset: 0x000639B0
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0000C87E File Offset: 0x0000AA7E
		public unsafe AnimationCurve camCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_camCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_camCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x000657E0 File Offset: 0x000639E0
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x0000C89D File Offset: 0x0000AA9D
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00065808 File Offset: 0x00063A08
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00065830 File Offset: 0x00063A30
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x0000C8D3 File Offset: 0x0000AAD3
		public unsafe float zoomTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_zoomTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_zoomTime)) = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00065858 File Offset: 0x00063A58
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x0000C8EE File Offset: 0x0000AAEE
		public unsafe Il2CppReferenceArray<GameObject> quads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_quads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_quads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00065888 File Offset: 0x00063A88
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x0000C90D File Offset: 0x0000AB0D
		public unsafe Il2CppReferenceArray<ParalaxSimple> foregroundStuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_foregroundStuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParalaxSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_foregroundStuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000658B8 File Offset: 0x00063AB8
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0000C92C File Offset: 0x0000AB2C
		public unsafe static BoatIntroTile me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoatIntroTile.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoatIntroTile>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoatIntroTile.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000658E0 File Offset: 0x00063AE0
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0000C93E File Offset: 0x0000AB3E
		public unsafe Container IntroContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_IntroContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Container>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile.NativeFieldInfoPtr_IntroContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_doors;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_camCurve;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_zoomTime;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_quads;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_foregroundStuff;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeFieldInfoPtr_IntroContainer;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_ZoomOut_Private_IEnumerator_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DB RID: 731
		[ObfuscatedName("BoatIntroTile+<ZoomOut>d__12")]
		public sealed class _ZoomOut_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D5A RID: 19802 RVA: 0x0011C2AC File Offset: 0x0011A4AC
			// Note: this type is marked as 'beforefieldinit'.
			static _ZoomOut_d__12()
			{
				Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoatIntroTile>.NativeClassPtr, "<ZoomOut>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr);
				BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, "<>1__state");
				BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, "<>2__current");
				BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, "<>4__this");
				BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, 100664739);
				BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, 100664740);
				BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, 100664741);
				BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, 100664742);
				BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, 100664743);
				BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr, 100664744);
			}

			// Token: 0x06004D5B RID: 19803 RVA: 0x0011C38C File Offset: 0x0011A58C
			[CallerCount(0)]
			public unsafe _ZoomOut_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoatIntroTile._ZoomOut_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D5C RID: 19804 RVA: 0x0011C3D4 File Offset: 0x0011A5D4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D5D RID: 19805 RVA: 0x0011C408 File Offset: 0x0011A608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48626, XrefRangeEnd = 48637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C30 RID: 7216
			// (get) Token: 0x06004D5E RID: 19806 RVA: 0x0011C444 File Offset: 0x0011A644
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D5F RID: 19807 RVA: 0x0011C484 File Offset: 0x0011A684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48637, XrefRangeEnd = 48642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C31 RID: 7217
			// (get) Token: 0x06004D60 RID: 19808 RVA: 0x0011C4B8 File Offset: 0x0011A6B8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoatIntroTile._ZoomOut_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D61 RID: 19809 RVA: 0x0002D792 File Offset: 0x0002B992
			public _ZoomOut_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C2D RID: 7213
			// (get) Token: 0x06004D62 RID: 19810 RVA: 0x0011C4F8 File Offset: 0x0011A6F8
			// (set) Token: 0x06004D63 RID: 19811 RVA: 0x0002D79B File Offset: 0x0002B99B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C2E RID: 7214
			// (get) Token: 0x06004D64 RID: 19812 RVA: 0x0011C520 File Offset: 0x0011A720
			// (set) Token: 0x06004D65 RID: 19813 RVA: 0x0002D7B6 File Offset: 0x0002B9B6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C2F RID: 7215
			// (get) Token: 0x06004D66 RID: 19814 RVA: 0x0011C550 File Offset: 0x0011A750
			// (set) Token: 0x06004D67 RID: 19815 RVA: 0x0002D7D5 File Offset: 0x0002B9D5
			public unsafe BoatIntroTile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoatIntroTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoatIntroTile._ZoomOut_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032A5 RID: 12965
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032A6 RID: 12966
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032A7 RID: 12967
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032A8 RID: 12968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032A9 RID: 12969
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032AA RID: 12970
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032AB RID: 12971
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032AC RID: 12972
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032AD RID: 12973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
