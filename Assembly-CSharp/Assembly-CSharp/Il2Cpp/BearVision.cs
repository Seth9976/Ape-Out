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
	// Token: 0x02000077 RID: 119
	public class BearVision : MonoBehaviour
	{
		// Token: 0x06000F49 RID: 3913 RVA: 0x000610D8 File Offset: 0x0005F2D8
		// Note: this type is marked as 'beforefieldinit'.
		static BearVision()
		{
			Il2CppClassPointerStore<BearVision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BearVision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearVision>.NativeClassPtr);
			BearVision.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearVision>.NativeClassPtr, "state");
			BearVision.NativeFieldInfoPtr_seeLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearVision>.NativeClassPtr, "seeLayers");
			BearVision.NativeFieldInfoPtr_colArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearVision>.NativeClassPtr, "colArr");
			BearVision.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearVision>.NativeClassPtr, "pts");
			BearVision.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision>.NativeClassPtr, 100664605);
			BearVision.NativeMethodInfoPtr_Scan_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision>.NativeClassPtr, 100664606);
			BearVision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision>.NativeClassPtr, 100664607);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00061194 File Offset: 0x0005F394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46661, XrefRangeEnd = 46671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000611C8 File Offset: 0x0005F3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46671, XrefRangeEnd = 46674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Scan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision.NativeMethodInfoPtr_Scan_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00061208 File Offset: 0x0005F408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46674, XrefRangeEnd = 46680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BearVision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearVision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0000B607 File Offset: 0x00009807
		public BearVision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00061244 File Offset: 0x0005F444
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x0000B610 File Offset: 0x00009810
		public unsafe BearState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BearState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00061274 File Offset: 0x0005F474
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x0000B62F File Offset: 0x0000982F
		public unsafe LayerMask seeLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_seeLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_seeLayers)) = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0006129C File Offset: 0x0005F49C
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x0000B64A File Offset: 0x0000984A
		public unsafe Il2CppReferenceArray<Collider2D> colArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_colArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_colArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x000612CC File Offset: 0x0005F4CC
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x0000B669 File Offset: 0x00009869
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_seeLayers;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_colArr;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Private_IEnumerator_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D4 RID: 724
		[ObfuscatedName("BearVision+<Scan>d__5")]
		public sealed class _Scan_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06004CF4 RID: 19700 RVA: 0x0011AE70 File Offset: 0x00119070
			// Note: this type is marked as 'beforefieldinit'.
			static _Scan_d__5()
			{
				Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BearVision>.NativeClassPtr, "<Scan>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr);
				BearVision._Scan_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, "<>1__state");
				BearVision._Scan_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, "<>2__current");
				BearVision._Scan_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, "<>4__this");
				BearVision._Scan_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, 100664608);
				BearVision._Scan_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, 100664609);
				BearVision._Scan_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, 100664610);
				BearVision._Scan_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, 100664611);
				BearVision._Scan_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, 100664612);
				BearVision._Scan_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr, 100664613);
			}

			// Token: 0x06004CF5 RID: 19701 RVA: 0x0011AF50 File Offset: 0x00119150
			[CallerCount(0)]
			public unsafe _Scan_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearVision._Scan_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision._Scan_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004CF6 RID: 19702 RVA: 0x0011AF98 File Offset: 0x00119198
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision._Scan_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CF7 RID: 19703 RVA: 0x0011AFCC File Offset: 0x001191CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46638, XrefRangeEnd = 46656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision._Scan_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C0B RID: 7179
			// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x0011B008 File Offset: 0x00119208
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision._Scan_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CF9 RID: 19705 RVA: 0x0011B048 File Offset: 0x00119248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46656, XrefRangeEnd = 46661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision._Scan_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C0C RID: 7180
			// (get) Token: 0x06004CFA RID: 19706 RVA: 0x0011B07C File Offset: 0x0011927C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearVision._Scan_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004CFB RID: 19707 RVA: 0x0002D4B2 File Offset: 0x0002B6B2
			public _Scan_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C08 RID: 7176
			// (get) Token: 0x06004CFC RID: 19708 RVA: 0x0011B0BC File Offset: 0x001192BC
			// (set) Token: 0x06004CFD RID: 19709 RVA: 0x0002D4BB File Offset: 0x0002B6BB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision._Scan_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision._Scan_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C09 RID: 7177
			// (get) Token: 0x06004CFE RID: 19710 RVA: 0x0011B0E4 File Offset: 0x001192E4
			// (set) Token: 0x06004CFF RID: 19711 RVA: 0x0002D4D6 File Offset: 0x0002B6D6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision._Scan_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision._Scan_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C0A RID: 7178
			// (get) Token: 0x06004D00 RID: 19712 RVA: 0x0011B114 File Offset: 0x00119314
			// (set) Token: 0x06004D01 RID: 19713 RVA: 0x0002D4F5 File Offset: 0x0002B6F5
			public unsafe BearVision __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision._Scan_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BearVision>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BearVision._Scan_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003264 RID: 12900
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003265 RID: 12901
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003266 RID: 12902
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003267 RID: 12903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003268 RID: 12904
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003269 RID: 12905
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400326A RID: 12906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400326B RID: 12907
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400326C RID: 12908
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
