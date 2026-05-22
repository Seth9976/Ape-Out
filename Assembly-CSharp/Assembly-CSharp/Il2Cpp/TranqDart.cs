using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001CA RID: 458
	public class TranqDart : MonoBehaviour
	{
		// Token: 0x06003257 RID: 12887 RVA: 0x000BE830 File Offset: 0x000BCA30
		// Note: this type is marked as 'beforefieldinit'.
		static TranqDart()
		{
			Il2CppClassPointerStore<TranqDart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TranqDart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranqDart>.NativeClassPtr);
			TranqDart.NativeFieldInfoPtr_splashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, "splashPrefab");
			TranqDart.NativeFieldInfoPtr_stuck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, "stuck");
			TranqDart.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, "rb");
			TranqDart.NativeFieldInfoPtr_spd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, "spd");
			TranqDart.NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, "localPos");
			TranqDart.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, 100667204);
			TranqDart.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, 100667205);
			TranqDart.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, 100667206);
			TranqDart.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, 100667207);
			TranqDart.NativeMethodInfoPtr_FallOff_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, 100667208);
			TranqDart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, 100667209);
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000BE93C File Offset: 0x000BCB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85645, XrefRangeEnd = 85702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000BE970 File Offset: 0x000BCB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85702, XrefRangeEnd = 85710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x000BE9A4 File Offset: 0x000BCBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85710, XrefRangeEnd = 85749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter2D(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart.NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x000BE9E8 File Offset: 0x000BCBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85749, XrefRangeEnd = 85757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x000BEA1C File Offset: 0x000BCC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85757, XrefRangeEnd = 85760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FallOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart.NativeMethodInfoPtr_FallOff_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x000BEA5C File Offset: 0x000BCC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TranqDart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranqDart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x000228D1 File Offset: 0x00020AD1
		public TranqDart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x000BEA98 File Offset: 0x000BCC98
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x000228DA File Offset: 0x00020ADA
		public unsafe GameObject splashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_splashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_splashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x000BEAC8 File Offset: 0x000BCCC8
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x000228F9 File Offset: 0x00020AF9
		public unsafe bool stuck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_stuck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_stuck)) = value;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x000BEAF0 File Offset: 0x000BCCF0
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x00022914 File Offset: 0x00020B14
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x000BEB20 File Offset: 0x000BCD20
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x00022933 File Offset: 0x00020B33
		public unsafe float spd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_spd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_spd)) = value;
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x000BEB48 File Offset: 0x000BCD48
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x0002294E File Offset: 0x00020B4E
		public unsafe Vector3 localPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_localPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart.NativeFieldInfoPtr_localPos)) = value;
			}
		}

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeFieldInfoPtr_splashPrefab;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeFieldInfoPtr_stuck;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeFieldInfoPtr_spd;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeFieldInfoPtr_localPos;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Public_Void_Collision2D_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_FallOff_Public_IEnumerator_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000355 RID: 853
		[ObfuscatedName("TranqDart+<FallOff>d__9")]
		public sealed class _FallOff_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x060053AE RID: 21422 RVA: 0x0012F614 File Offset: 0x0012D814
			// Note: this type is marked as 'beforefieldinit'.
			static _FallOff_d__9()
			{
				Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TranqDart>.NativeClassPtr, "<FallOff>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr);
				TranqDart._FallOff_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, "<>1__state");
				TranqDart._FallOff_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, "<>2__current");
				TranqDart._FallOff_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, "<>4__this");
				TranqDart._FallOff_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, 100667210);
				TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, 100667211);
				TranqDart._FallOff_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, 100667212);
				TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, 100667213);
				TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, 100667214);
				TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr, 100667215);
			}

			// Token: 0x060053AF RID: 21423 RVA: 0x0012F6F4 File Offset: 0x0012D8F4
			[CallerCount(0)]
			public unsafe _FallOff_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TranqDart._FallOff_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart._FallOff_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053B0 RID: 21424 RVA: 0x0012F73C File Offset: 0x0012D93C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B1 RID: 21425 RVA: 0x0012F770 File Offset: 0x0012D970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85629, XrefRangeEnd = 85636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart._FallOff_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E85 RID: 7813
			// (get) Token: 0x060053B2 RID: 21426 RVA: 0x0012F7AC File Offset: 0x0012D9AC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053B3 RID: 21427 RVA: 0x0012F7EC File Offset: 0x0012D9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85636, XrefRangeEnd = 85645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E86 RID: 7814
			// (get) Token: 0x060053B4 RID: 21428 RVA: 0x0012F820 File Offset: 0x0012DA20
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TranqDart._FallOff_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053B5 RID: 21429 RVA: 0x00030ABA File Offset: 0x0002ECBA
			public _FallOff_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E82 RID: 7810
			// (get) Token: 0x060053B6 RID: 21430 RVA: 0x0012F860 File Offset: 0x0012DA60
			// (set) Token: 0x060053B7 RID: 21431 RVA: 0x00030AC3 File Offset: 0x0002ECC3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart._FallOff_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart._FallOff_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E83 RID: 7811
			// (get) Token: 0x060053B8 RID: 21432 RVA: 0x0012F888 File Offset: 0x0012DA88
			// (set) Token: 0x060053B9 RID: 21433 RVA: 0x00030ADE File Offset: 0x0002ECDE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart._FallOff_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart._FallOff_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E84 RID: 7812
			// (get) Token: 0x060053BA RID: 21434 RVA: 0x0012F8B8 File Offset: 0x0012DAB8
			// (set) Token: 0x060053BB RID: 21435 RVA: 0x00030AFD File Offset: 0x0002ECFD
			public unsafe TranqDart __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart._FallOff_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TranqDart>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TranqDart._FallOff_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400374A RID: 14154
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400374B RID: 14155
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400374C RID: 14156
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400374D RID: 14157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400374E RID: 14158
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400374F RID: 14159
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003750 RID: 14160
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003751 RID: 14161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003752 RID: 14162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
