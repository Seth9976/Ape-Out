using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000098 RID: 152
	public class BunkerOutro : MonoBehaviour
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x00068590 File Offset: 0x00066790
		// Note: this type is marked as 'beforefieldinit'.
		static BunkerOutro()
		{
			Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BunkerOutro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr);
			BunkerOutro.NativeFieldInfoPtr_explosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "explosion");
			BunkerOutro.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "cam");
			BunkerOutro.NativeFieldInfoPtr_spd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "spd");
			BunkerOutro.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "timer");
			BunkerOutro.NativeFieldInfoPtr_boost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "boost");
			BunkerOutro.NativeFieldInfoPtr_blowin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "blowin");
			BunkerOutro.NativeFieldInfoPtr_goin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "goin");
			BunkerOutro.NativeFieldInfoPtr_blewUpTruck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "blewUpTruck");
			BunkerOutro.NativeFieldInfoPtr_endTileOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "endTileOn");
			BunkerOutro.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, 100664824);
			BunkerOutro.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, 100664825);
			BunkerOutro.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, 100664826);
			BunkerOutro.NativeMethodInfoPtr_BlowShitUp_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, 100664827);
			BunkerOutro.NativeMethodInfoPtr_KeepIntensDown_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, 100664828);
			BunkerOutro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, 100664829);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000686EC File Offset: 0x000668EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49740, XrefRangeEnd = 49742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00068720 File Offset: 0x00066920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49742, XrefRangeEnd = 49745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00068760 File Offset: 0x00066960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49745, XrefRangeEnd = 49769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00068794 File Offset: 0x00066994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49772, RefRangeEnd = 49773, XrefRangeStart = 49769, XrefRangeEnd = 49772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BlowShitUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro.NativeMethodInfoPtr_BlowShitUp_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000687D4 File Offset: 0x000669D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49773, XrefRangeEnd = 49776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator KeepIntensDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro.NativeMethodInfoPtr_KeepIntensDown_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00068814 File Offset: 0x00066A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunkerOutro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0000D52F File Offset: 0x0000B72F
		public BunkerOutro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00068850 File Offset: 0x00066A50
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x0000D538 File Offset: 0x0000B738
		public unsafe GameObject explosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_explosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_explosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00068880 File Offset: 0x00066A80
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x0000D557 File Offset: 0x0000B757
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x000688B0 File Offset: 0x00066AB0
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x0000D576 File Offset: 0x0000B776
		public unsafe float spd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_spd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_spd)) = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000688D8 File Offset: 0x00066AD8
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x0000D591 File Offset: 0x0000B791
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00068900 File Offset: 0x00066B00
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		public unsafe float boost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_boost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_boost)) = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00068928 File Offset: 0x00066B28
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x0000D5C7 File Offset: 0x0000B7C7
		public unsafe bool blowin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_blowin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_blowin)) = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00068950 File Offset: 0x00066B50
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000D5E2 File Offset: 0x0000B7E2
		public unsafe bool goin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_goin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_goin)) = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00068978 File Offset: 0x00066B78
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x0000D5FD File Offset: 0x0000B7FD
		public unsafe bool blewUpTruck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_blewUpTruck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_blewUpTruck)) = value;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x000689A0 File Offset: 0x00066BA0
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x0000D618 File Offset: 0x0000B818
		public unsafe bool endTileOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_endTileOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro.NativeFieldInfoPtr_endTileOn)) = value;
			}
		}

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeFieldInfoPtr_explosion;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeFieldInfoPtr_spd;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeFieldInfoPtr_boost;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeFieldInfoPtr_blowin;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeFieldInfoPtr_goin;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeFieldInfoPtr_blewUpTruck;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeFieldInfoPtr_endTileOn;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_DoIt_Private_IEnumerator_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_BlowShitUp_Private_IEnumerator_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_KeepIntensDown_Private_IEnumerator_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002E0 RID: 736
		[ObfuscatedName("BunkerOutro+<DoIt>d__10")]
		public sealed class _DoIt_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06004DA0 RID: 19872 RVA: 0x0011D0C8 File Offset: 0x0011B2C8
			// Note: this type is marked as 'beforefieldinit'.
			static _DoIt_d__10()
			{
				Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "<DoIt>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr);
				BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, "<>1__state");
				BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, "<>2__current");
				BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, "<>4__this");
				BunkerOutro._DoIt_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, 100664830);
				BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, 100664831);
				BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, 100664832);
				BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, 100664833);
				BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, 100664834);
				BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr, 100664835);
			}

			// Token: 0x06004DA1 RID: 19873 RVA: 0x0011D1A8 File Offset: 0x0011B3A8
			[CallerCount(0)]
			public unsafe _DoIt_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerOutro._DoIt_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._DoIt_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DA2 RID: 19874 RVA: 0x0011D1F0 File Offset: 0x0011B3F0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DA3 RID: 19875 RVA: 0x0011D224 File Offset: 0x0011B424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49663, XrefRangeEnd = 49693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C49 RID: 7241
			// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x0011D260 File Offset: 0x0011B460
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DA5 RID: 19877 RVA: 0x0011D2A0 File Offset: 0x0011B4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49693, XrefRangeEnd = 49698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C4A RID: 7242
			// (get) Token: 0x06004DA6 RID: 19878 RVA: 0x0011D2D4 File Offset: 0x0011B4D4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._DoIt_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DA7 RID: 19879 RVA: 0x0002D978 File Offset: 0x0002BB78
			public _DoIt_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C46 RID: 7238
			// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x0011D314 File Offset: 0x0011B514
			// (set) Token: 0x06004DA9 RID: 19881 RVA: 0x0002D981 File Offset: 0x0002BB81
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C47 RID: 7239
			// (get) Token: 0x06004DAA RID: 19882 RVA: 0x0011D33C File Offset: 0x0011B53C
			// (set) Token: 0x06004DAB RID: 19883 RVA: 0x0002D99C File Offset: 0x0002BB9C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C48 RID: 7240
			// (get) Token: 0x06004DAC RID: 19884 RVA: 0x0011D36C File Offset: 0x0011B56C
			// (set) Token: 0x06004DAD RID: 19885 RVA: 0x0002D9BB File Offset: 0x0002BBBB
			public unsafe BunkerOutro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunkerOutro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._DoIt_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032D2 RID: 13010
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032D3 RID: 13011
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032D4 RID: 13012
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032D5 RID: 13013
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032D6 RID: 13014
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032D7 RID: 13015
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032D8 RID: 13016
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032D9 RID: 13017
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032DA RID: 13018
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002E1 RID: 737
		[ObfuscatedName("BunkerOutro+<BlowShitUp>d__12")]
		public sealed class _BlowShitUp_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06004DAE RID: 19886 RVA: 0x0011D39C File Offset: 0x0011B59C
			// Note: this type is marked as 'beforefieldinit'.
			static _BlowShitUp_d__12()
			{
				Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "<BlowShitUp>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr);
				BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, "<>1__state");
				BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, "<>2__current");
				BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, "<>4__this");
				BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, 100664836);
				BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, 100664837);
				BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, 100664838);
				BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, 100664839);
				BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, 100664840);
				BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr, 100664841);
			}

			// Token: 0x06004DAF RID: 19887 RVA: 0x0011D47C File Offset: 0x0011B67C
			[CallerCount(0)]
			public unsafe _BlowShitUp_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerOutro._BlowShitUp_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DB0 RID: 19888 RVA: 0x0011D4C4 File Offset: 0x0011B6C4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DB1 RID: 19889 RVA: 0x0011D4F8 File Offset: 0x0011B6F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49698, XrefRangeEnd = 49726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C4E RID: 7246
			// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x0011D534 File Offset: 0x0011B734
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DB3 RID: 19891 RVA: 0x0011D574 File Offset: 0x0011B774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49726, XrefRangeEnd = 49731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C4F RID: 7247
			// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x0011D5A8 File Offset: 0x0011B7A8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._BlowShitUp_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DB5 RID: 19893 RVA: 0x0002D9DA File Offset: 0x0002BBDA
			public _BlowShitUp_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C4B RID: 7243
			// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x0011D5E8 File Offset: 0x0011B7E8
			// (set) Token: 0x06004DB7 RID: 19895 RVA: 0x0002D9E3 File Offset: 0x0002BBE3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C4C RID: 7244
			// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x0011D610 File Offset: 0x0011B810
			// (set) Token: 0x06004DB9 RID: 19897 RVA: 0x0002D9FE File Offset: 0x0002BBFE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C4D RID: 7245
			// (get) Token: 0x06004DBA RID: 19898 RVA: 0x0011D640 File Offset: 0x0011B840
			// (set) Token: 0x06004DBB RID: 19899 RVA: 0x0002DA1D File Offset: 0x0002BC1D
			public unsafe BunkerOutro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunkerOutro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._BlowShitUp_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032DB RID: 13019
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032DC RID: 13020
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032DD RID: 13021
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032DE RID: 13022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032DF RID: 13023
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032E0 RID: 13024
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032E1 RID: 13025
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032E2 RID: 13026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032E3 RID: 13027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002E2 RID: 738
		[ObfuscatedName("BunkerOutro+<KeepIntensDown>d__13")]
		public sealed class _KeepIntensDown_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x06004DBC RID: 19900 RVA: 0x0011D670 File Offset: 0x0011B870
			// Note: this type is marked as 'beforefieldinit'.
			static _KeepIntensDown_d__13()
			{
				Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BunkerOutro>.NativeClassPtr, "<KeepIntensDown>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr);
				BunkerOutro._KeepIntensDown_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, "<>1__state");
				BunkerOutro._KeepIntensDown_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, "<>2__current");
				BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, 100664842);
				BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, 100664843);
				BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, 100664844);
				BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, 100664845);
				BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, 100664846);
				BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr, 100664847);
			}

			// Token: 0x06004DBD RID: 19901 RVA: 0x0011D73C File Offset: 0x0011B93C
			[CallerCount(0)]
			public unsafe _KeepIntensDown_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerOutro._KeepIntensDown_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DBE RID: 19902 RVA: 0x0011D784 File Offset: 0x0011B984
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DBF RID: 19903 RVA: 0x0011D7B8 File Offset: 0x0011B9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49731, XrefRangeEnd = 49735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C52 RID: 7250
			// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x0011D7F4 File Offset: 0x0011B9F4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DC1 RID: 19905 RVA: 0x0011D834 File Offset: 0x0011BA34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49735, XrefRangeEnd = 49740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C53 RID: 7251
			// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x0011D868 File Offset: 0x0011BA68
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerOutro._KeepIntensDown_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DC3 RID: 19907 RVA: 0x0002DA3C File Offset: 0x0002BC3C
			public _KeepIntensDown_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C50 RID: 7248
			// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x0011D8A8 File Offset: 0x0011BAA8
			// (set) Token: 0x06004DC5 RID: 19909 RVA: 0x0002DA45 File Offset: 0x0002BC45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._KeepIntensDown_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._KeepIntensDown_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C51 RID: 7249
			// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x0011D8D0 File Offset: 0x0011BAD0
			// (set) Token: 0x06004DC7 RID: 19911 RVA: 0x0002DA60 File Offset: 0x0002BC60
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._KeepIntensDown_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerOutro._KeepIntensDown_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032E4 RID: 13028
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032E5 RID: 13029
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032E6 RID: 13030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032E7 RID: 13031
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032E8 RID: 13032
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032E9 RID: 13033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032EA RID: 13034
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032EB RID: 13035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
