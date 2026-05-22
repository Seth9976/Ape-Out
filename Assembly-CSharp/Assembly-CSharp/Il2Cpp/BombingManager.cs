using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200008C RID: 140
	public class BombingManager : MonoBehaviour
	{
		// Token: 0x0600112C RID: 4396 RVA: 0x00065D84 File Offset: 0x00063F84
		// Note: this type is marked as 'beforefieldinit'.
		static BombingManager()
		{
			Il2CppClassPointerStore<BombingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BombingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BombingManager>.NativeClassPtr);
			BombingManager.NativeFieldInfoPtr_explosionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "explosionPrefab");
			BombingManager.NativeFieldInfoPtr_bombPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "bombPrefab");
			BombingManager.NativeFieldInfoPtr_bomb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "bomb");
			BombingManager.NativeFieldInfoPtr_explosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "explosion");
			BombingManager.NativeFieldInfoPtr_pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "pt");
			BombingManager.NativeFieldInfoPtr_goodPalMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "goodPalMat");
			BombingManager.NativeFieldInfoPtr_delay1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "delay1");
			BombingManager.NativeFieldInfoPtr_colMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "colMask");
			BombingManager.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, 100664758);
			BombingManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, 100664759);
			BombingManager.NativeMethodInfoPtr_BombShit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, 100664760);
			BombingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, 100664761);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00065EA4 File Offset: 0x000640A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48878, XrefRangeEnd = 48922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00065ED8 File Offset: 0x000640D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48922, XrefRangeEnd = 48957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00065F0C File Offset: 0x0006410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48957, XrefRangeEnd = 48960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BombShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager.NativeMethodInfoPtr_BombShit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00065F4C File Offset: 0x0006414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48960, XrefRangeEnd = 48966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BombingManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BombingManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0000CA57 File Offset: 0x0000AC57
		public BombingManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00065F88 File Offset: 0x00064188
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x0000CA60 File Offset: 0x0000AC60
		public unsafe GameObject explosionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_explosionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_explosionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00065FB8 File Offset: 0x000641B8
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x0000CA7F File Offset: 0x0000AC7F
		public unsafe GameObject bombPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_bombPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_bombPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00065FE8 File Offset: 0x000641E8
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x0000CA9E File Offset: 0x0000AC9E
		public unsafe Transform bomb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_bomb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_bomb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00066018 File Offset: 0x00064218
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x0000CABD File Offset: 0x0000ACBD
		public unsafe Transform explosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_explosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_explosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00066048 File Offset: 0x00064248
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x0000CADC File Offset: 0x0000ACDC
		public unsafe Vector2 pt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_pt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_pt)) = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00066070 File Offset: 0x00064270
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x0000CAF7 File Offset: 0x0000ACF7
		public unsafe Material goodPalMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_goodPalMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_goodPalMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x000660A0 File Offset: 0x000642A0
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x0000CB16 File Offset: 0x0000AD16
		public unsafe WaitForSeconds delay1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_delay1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_delay1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000660D0 File Offset: 0x000642D0
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x0000CB35 File Offset: 0x0000AD35
		public unsafe int colMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_colMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager.NativeFieldInfoPtr_colMask)) = value;
			}
		}

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_explosionPrefab;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_bombPrefab;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_bomb;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_explosion;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_pt;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_goodPalMat;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_delay1;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_colMask;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_BombShit_Private_IEnumerator_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DD RID: 733
		[ObfuscatedName("BombingManager+<BombShit>d__10")]
		public sealed class _BombShit_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D78 RID: 19832 RVA: 0x0011C890 File Offset: 0x0011AA90
			// Note: this type is marked as 'beforefieldinit'.
			static _BombShit_d__10()
			{
				Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BombingManager>.NativeClassPtr, "<BombShit>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr);
				BombingManager._BombShit_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, "<>1__state");
				BombingManager._BombShit_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, "<>2__current");
				BombingManager._BombShit_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, "<>4__this");
				BombingManager._BombShit_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, 100664762);
				BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, 100664763);
				BombingManager._BombShit_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, 100664764);
				BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, 100664765);
				BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, 100664766);
				BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr, 100664767);
			}

			// Token: 0x06004D79 RID: 19833 RVA: 0x0011C970 File Offset: 0x0011AB70
			[CallerCount(0)]
			public unsafe _BombShit_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BombingManager._BombShit_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager._BombShit_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D7A RID: 19834 RVA: 0x0011C9B8 File Offset: 0x0011ABB8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D7B RID: 19835 RVA: 0x0011C9EC File Offset: 0x0011ABEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48798, XrefRangeEnd = 48873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager._BombShit_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C3B RID: 7227
			// (get) Token: 0x06004D7C RID: 19836 RVA: 0x0011CA28 File Offset: 0x0011AC28
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D7D RID: 19837 RVA: 0x0011CA68 File Offset: 0x0011AC68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48873, XrefRangeEnd = 48878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C3C RID: 7228
			// (get) Token: 0x06004D7E RID: 19838 RVA: 0x0011CA9C File Offset: 0x0011AC9C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombingManager._BombShit_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D7F RID: 19839 RVA: 0x0002D871 File Offset: 0x0002BA71
			public _BombShit_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C38 RID: 7224
			// (get) Token: 0x06004D80 RID: 19840 RVA: 0x0011CADC File Offset: 0x0011ACDC
			// (set) Token: 0x06004D81 RID: 19841 RVA: 0x0002D87A File Offset: 0x0002BA7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager._BombShit_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager._BombShit_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C39 RID: 7225
			// (get) Token: 0x06004D82 RID: 19842 RVA: 0x0011CB04 File Offset: 0x0011AD04
			// (set) Token: 0x06004D83 RID: 19843 RVA: 0x0002D895 File Offset: 0x0002BA95
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager._BombShit_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager._BombShit_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C3A RID: 7226
			// (get) Token: 0x06004D84 RID: 19844 RVA: 0x0011CB34 File Offset: 0x0011AD34
			// (set) Token: 0x06004D85 RID: 19845 RVA: 0x0002D8B4 File Offset: 0x0002BAB4
			public unsafe BombingManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager._BombShit_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BombingManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombingManager._BombShit_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032B8 RID: 12984
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032B9 RID: 12985
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032BA RID: 12986
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032BB RID: 12987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032BC RID: 12988
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032BD RID: 12989
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032BE RID: 12990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032BF RID: 12991
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032C0 RID: 12992
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
