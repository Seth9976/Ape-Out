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
	// Token: 0x0200019F RID: 415
	public class SparkAnimator : MonoBehaviour
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x000B8BE8 File Offset: 0x000B6DE8
		// Note: this type is marked as 'beforefieldinit'.
		static SparkAnimator()
		{
			Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SparkAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr);
			SparkAnimator.NativeFieldInfoPtr_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, "bits");
			SparkAnimator.NativeFieldInfoPtr_spd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, "spd");
			SparkAnimator.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, "defPos");
			SparkAnimator.NativeFieldInfoPtr_delay1Over24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, "delay1Over24");
			SparkAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, 100667054);
			SparkAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, 100667055);
			SparkAnimator.NativeMethodInfoPtr_Animate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, 100667056);
			SparkAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, 100667057);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000B8CB8 File Offset: 0x000B6EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84053, XrefRangeEnd = 84082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x000B8CEC File Offset: 0x000B6EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84082, XrefRangeEnd = 84109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x000B8D20 File Offset: 0x000B6F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84109, XrefRangeEnd = 84112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Animate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator.NativeMethodInfoPtr_Animate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x000B8D60 File Offset: 0x000B6F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84112, XrefRangeEnd = 84118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparkAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x000211BC File Offset: 0x0001F3BC
		public SparkAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x000B8D9C File Offset: 0x000B6F9C
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x000211C5 File Offset: 0x0001F3C5
		public unsafe Il2CppReferenceArray<Transform> bits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_bits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_bits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x000B8DCC File Offset: 0x000B6FCC
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x000211E4 File Offset: 0x0001F3E4
		public unsafe float spd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_spd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_spd)) = value;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x000B8DF4 File Offset: 0x000B6FF4
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x000211FF File Offset: 0x0001F3FF
		public unsafe Il2CppStructArray<Vector3> defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_defPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_defPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x000B8E24 File Offset: 0x000B7024
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x0002121E File Offset: 0x0001F41E
		public unsafe WaitForSeconds delay1Over24
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_delay1Over24);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator.NativeFieldInfoPtr_delay1Over24), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr_bits;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr_spd;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeFieldInfoPtr_delay1Over24;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr_Animate_Private_IEnumerator_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000350 RID: 848
		[ObfuscatedName("SparkAnimator+<Animate>d__6")]
		public sealed class _Animate_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06005376 RID: 21366 RVA: 0x0012EAC4 File Offset: 0x0012CCC4
			// Note: this type is marked as 'beforefieldinit'.
			static _Animate_d__6()
			{
				Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SparkAnimator>.NativeClassPtr, "<Animate>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr);
				SparkAnimator._Animate_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, "<>1__state");
				SparkAnimator._Animate_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, "<>2__current");
				SparkAnimator._Animate_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, "<>4__this");
				SparkAnimator._Animate_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, 100667058);
				SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, 100667059);
				SparkAnimator._Animate_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, 100667060);
				SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, 100667061);
				SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, 100667062);
				SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr, 100667063);
			}

			// Token: 0x06005377 RID: 21367 RVA: 0x0012EBA4 File Offset: 0x0012CDA4
			[CallerCount(0)]
			public unsafe _Animate_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparkAnimator._Animate_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator._Animate_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005378 RID: 21368 RVA: 0x0012EBEC File Offset: 0x0012CDEC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005379 RID: 21369 RVA: 0x0012EC20 File Offset: 0x0012CE20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84011, XrefRangeEnd = 84048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator._Animate_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E71 RID: 7793
			// (get) Token: 0x0600537A RID: 21370 RVA: 0x0012EC5C File Offset: 0x0012CE5C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600537B RID: 21371 RVA: 0x0012EC9C File Offset: 0x0012CE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84048, XrefRangeEnd = 84053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E72 RID: 7794
			// (get) Token: 0x0600537C RID: 21372 RVA: 0x0012ECD0 File Offset: 0x0012CED0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparkAnimator._Animate_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600537D RID: 21373 RVA: 0x00030932 File Offset: 0x0002EB32
			public _Animate_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E6E RID: 7790
			// (get) Token: 0x0600537E RID: 21374 RVA: 0x0012ED10 File Offset: 0x0012CF10
			// (set) Token: 0x0600537F RID: 21375 RVA: 0x0003093B File Offset: 0x0002EB3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator._Animate_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator._Animate_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E6F RID: 7791
			// (get) Token: 0x06005380 RID: 21376 RVA: 0x0012ED38 File Offset: 0x0012CF38
			// (set) Token: 0x06005381 RID: 21377 RVA: 0x00030956 File Offset: 0x0002EB56
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator._Animate_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator._Animate_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E70 RID: 7792
			// (get) Token: 0x06005382 RID: 21378 RVA: 0x0012ED68 File Offset: 0x0012CF68
			// (set) Token: 0x06005383 RID: 21379 RVA: 0x00030975 File Offset: 0x0002EB75
			public unsafe SparkAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator._Animate_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparkAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparkAnimator._Animate_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003719 RID: 14105
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400371A RID: 14106
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400371B RID: 14107
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400371C RID: 14108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400371D RID: 14109
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400371E RID: 14110
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400371F RID: 14111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003720 RID: 14112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003721 RID: 14113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
