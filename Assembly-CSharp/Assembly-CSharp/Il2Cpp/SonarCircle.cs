using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200019A RID: 410
	public class SonarCircle : MonoBehaviour
	{
		// Token: 0x06002FDC RID: 12252 RVA: 0x000B8278 File Offset: 0x000B6478
		// Note: this type is marked as 'beforefieldinit'.
		static SonarCircle()
		{
			Il2CppClassPointerStore<SonarCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SonarCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr);
			SonarCircle.NativeFieldInfoPtr_maxRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr, "maxRad");
			SonarCircle.NativeFieldInfoPtr_delaypt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr, "delaypt1");
			SonarCircle.NativeFieldInfoPtr_delaypt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr, "delaypt2");
			SonarCircle.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr, 100667033);
			SonarCircle.NativeMethodInfoPtr_Biggen_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr, 100667034);
			SonarCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr, 100667035);
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000B8320 File Offset: 0x000B6520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83840, XrefRangeEnd = 83863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x000B8354 File Offset: 0x000B6554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83863, XrefRangeEnd = 83866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Biggen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle.NativeMethodInfoPtr_Biggen_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x000B8394 File Offset: 0x000B6594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83866, XrefRangeEnd = 83874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SonarCircle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x00020FC7 File Offset: 0x0001F1C7
		public SonarCircle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x000B83D0 File Offset: 0x000B65D0
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		public unsafe float maxRad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle.NativeFieldInfoPtr_maxRad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle.NativeFieldInfoPtr_maxRad)) = value;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x000B83F8 File Offset: 0x000B65F8
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00020FEB File Offset: 0x0001F1EB
		public unsafe WaitForSeconds delaypt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle.NativeFieldInfoPtr_delaypt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle.NativeFieldInfoPtr_delaypt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x000B8428 File Offset: 0x000B6628
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x0002100A File Offset: 0x0001F20A
		public unsafe WaitForSeconds delaypt2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle.NativeFieldInfoPtr_delaypt2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle.NativeFieldInfoPtr_delaypt2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeFieldInfoPtr_maxRad;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeFieldInfoPtr_delaypt1;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeFieldInfoPtr_delaypt2;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_Biggen_Private_IEnumerator_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200034F RID: 847
		[ObfuscatedName("SonarCircle+<Biggen>d__4")]
		public sealed class _Biggen_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06005368 RID: 21352 RVA: 0x0012E7F0 File Offset: 0x0012C9F0
			// Note: this type is marked as 'beforefieldinit'.
			static _Biggen_d__4()
			{
				Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SonarCircle>.NativeClassPtr, "<Biggen>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr);
				SonarCircle._Biggen_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, "<>1__state");
				SonarCircle._Biggen_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, "<>2__current");
				SonarCircle._Biggen_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, "<>4__this");
				SonarCircle._Biggen_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, 100667036);
				SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, 100667037);
				SonarCircle._Biggen_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, 100667038);
				SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, 100667039);
				SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, 100667040);
				SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr, 100667041);
			}

			// Token: 0x06005369 RID: 21353 RVA: 0x0012E8D0 File Offset: 0x0012CAD0
			[CallerCount(0)]
			public unsafe _Biggen_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SonarCircle._Biggen_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle._Biggen_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600536A RID: 21354 RVA: 0x0012E918 File Offset: 0x0012CB18
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600536B RID: 21355 RVA: 0x0012E94C File Offset: 0x0012CB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83830, XrefRangeEnd = 83835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle._Biggen_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E6C RID: 7788
			// (get) Token: 0x0600536C RID: 21356 RVA: 0x0012E988 File Offset: 0x0012CB88
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600536D RID: 21357 RVA: 0x0012E9C8 File Offset: 0x0012CBC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83835, XrefRangeEnd = 83840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E6D RID: 7789
			// (get) Token: 0x0600536E RID: 21358 RVA: 0x0012E9FC File Offset: 0x0012CBFC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarCircle._Biggen_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600536F RID: 21359 RVA: 0x000308D0 File Offset: 0x0002EAD0
			public _Biggen_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E69 RID: 7785
			// (get) Token: 0x06005370 RID: 21360 RVA: 0x0012EA3C File Offset: 0x0012CC3C
			// (set) Token: 0x06005371 RID: 21361 RVA: 0x000308D9 File Offset: 0x0002EAD9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle._Biggen_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle._Biggen_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E6A RID: 7786
			// (get) Token: 0x06005372 RID: 21362 RVA: 0x0012EA64 File Offset: 0x0012CC64
			// (set) Token: 0x06005373 RID: 21363 RVA: 0x000308F4 File Offset: 0x0002EAF4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle._Biggen_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle._Biggen_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E6B RID: 7787
			// (get) Token: 0x06005374 RID: 21364 RVA: 0x0012EA94 File Offset: 0x0012CC94
			// (set) Token: 0x06005375 RID: 21365 RVA: 0x00030913 File Offset: 0x0002EB13
			public unsafe SonarCircle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle._Biggen_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SonarCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SonarCircle._Biggen_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003710 RID: 14096
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003711 RID: 14097
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003712 RID: 14098
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003713 RID: 14099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003714 RID: 14100
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003715 RID: 14101
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003716 RID: 14102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003717 RID: 14103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003718 RID: 14104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
