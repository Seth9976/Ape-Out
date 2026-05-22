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
	// Token: 0x020000AE RID: 174
	public class CopCar : MonoBehaviour
	{
		// Token: 0x06001549 RID: 5449 RVA: 0x00070720 File Offset: 0x0006E920
		// Note: this type is marked as 'beforefieldinit'.
		static CopCar()
		{
			Il2CppClassPointerStore<CopCar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CopCar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopCar>.NativeClassPtr);
			CopCar.NativeFieldInfoPtr_flashers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar>.NativeClassPtr, "flashers");
			CopCar.NativeFieldInfoPtr_dad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar>.NativeClassPtr, "dad");
			CopCar.NativeFieldInfoPtr_sinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar>.NativeClassPtr, "sinOffset");
			CopCar.NativeFieldInfoPtr_flasherTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar>.NativeClassPtr, "flasherTrans");
			CopCar.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar>.NativeClassPtr, 100665074);
			CopCar.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar>.NativeClassPtr, 100665075);
			CopCar.NativeMethodInfoPtr_Flash_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar>.NativeClassPtr, 100665076);
			CopCar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar>.NativeClassPtr, 100665077);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000707F0 File Offset: 0x0006E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53872, XrefRangeEnd = 53893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00070824 File Offset: 0x0006EA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53893, XrefRangeEnd = 53902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00070858 File Offset: 0x0006EA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53902, XrefRangeEnd = 53905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar.NativeMethodInfoPtr_Flash_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00070898 File Offset: 0x0006EA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopCar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopCar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0000F798 File Offset: 0x0000D998
		public CopCar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x000708D4 File Offset: 0x0006EAD4
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0000F7A1 File Offset: 0x0000D9A1
		public unsafe Il2CppReferenceArray<GameObject> flashers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_flashers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_flashers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00070904 File Offset: 0x0006EB04
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		public unsafe OfficeViewManager dad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_dad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfficeViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_dad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00070934 File Offset: 0x0006EB34
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x0000F7DF File Offset: 0x0000D9DF
		public unsafe float sinOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_sinOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_sinOffset)) = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x0007095C File Offset: 0x0006EB5C
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x0000F7FA File Offset: 0x0000D9FA
		public unsafe Il2CppReferenceArray<Transform> flasherTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_flasherTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar.NativeFieldInfoPtr_flasherTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_flashers;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_dad;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_sinOffset;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_flasherTrans;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F0 RID: 752
		[ObfuscatedName("CopCar+<Flash>d__6")]
		public sealed class _Flash_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E8C RID: 20108 RVA: 0x0011FE38 File Offset: 0x0011E038
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__6()
			{
				Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopCar>.NativeClassPtr, "<Flash>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr);
				CopCar._Flash_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, "<>1__state");
				CopCar._Flash_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, "<>2__current");
				CopCar._Flash_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, "<>4__this");
				CopCar._Flash_d__6.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, "<i>5__2");
				CopCar._Flash_d__6.NativeFieldInfoPtr__timer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, "<timer>5__3");
				CopCar._Flash_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, 100665078);
				CopCar._Flash_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, 100665079);
				CopCar._Flash_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, 100665080);
				CopCar._Flash_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, 100665081);
				CopCar._Flash_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, 100665082);
				CopCar._Flash_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr, 100665083);
			}

			// Token: 0x06004E8D RID: 20109 RVA: 0x0011FF40 File Offset: 0x0011E140
			[CallerCount(0)]
			public unsafe _Flash_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopCar._Flash_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar._Flash_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E8E RID: 20110 RVA: 0x0011FF88 File Offset: 0x0011E188
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar._Flash_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E8F RID: 20111 RVA: 0x0011FFBC File Offset: 0x0011E1BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53836, XrefRangeEnd = 53867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar._Flash_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CA3 RID: 7331
			// (get) Token: 0x06004E90 RID: 20112 RVA: 0x0011FFF8 File Offset: 0x0011E1F8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar._Flash_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E91 RID: 20113 RVA: 0x00120038 File Offset: 0x0011E238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53867, XrefRangeEnd = 53872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar._Flash_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CA4 RID: 7332
			// (get) Token: 0x06004E92 RID: 20114 RVA: 0x0012006C File Offset: 0x0011E26C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopCar._Flash_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E93 RID: 20115 RVA: 0x0002E091 File Offset: 0x0002C291
			public _Flash_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C9E RID: 7326
			// (get) Token: 0x06004E94 RID: 20116 RVA: 0x001200AC File Offset: 0x0011E2AC
			// (set) Token: 0x06004E95 RID: 20117 RVA: 0x0002E09A File Offset: 0x0002C29A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C9F RID: 7327
			// (get) Token: 0x06004E96 RID: 20118 RVA: 0x001200D4 File Offset: 0x0011E2D4
			// (set) Token: 0x06004E97 RID: 20119 RVA: 0x0002E0B5 File Offset: 0x0002C2B5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA0 RID: 7328
			// (get) Token: 0x06004E98 RID: 20120 RVA: 0x00120104 File Offset: 0x0011E304
			// (set) Token: 0x06004E99 RID: 20121 RVA: 0x0002E0D4 File Offset: 0x0002C2D4
			public unsafe CopCar __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopCar>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA1 RID: 7329
			// (get) Token: 0x06004E9A RID: 20122 RVA: 0x00120134 File Offset: 0x0011E334
			// (set) Token: 0x06004E9B RID: 20123 RVA: 0x0002E0F3 File Offset: 0x0002C2F3
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x17001CA2 RID: 7330
			// (get) Token: 0x06004E9C RID: 20124 RVA: 0x0012015C File Offset: 0x0011E35C
			// (set) Token: 0x06004E9D RID: 20125 RVA: 0x0002E10E File Offset: 0x0002C30E
			public unsafe float _timer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr__timer_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopCar._Flash_d__6.NativeFieldInfoPtr__timer_5__3)) = value;
				}
			}

			// Token: 0x0400336B RID: 13163
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400336C RID: 13164
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400336D RID: 13165
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400336E RID: 13166
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400336F RID: 13167
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__3;

			// Token: 0x04003370 RID: 13168
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003371 RID: 13169
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003372 RID: 13170
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003373 RID: 13171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003374 RID: 13172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003375 RID: 13173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
