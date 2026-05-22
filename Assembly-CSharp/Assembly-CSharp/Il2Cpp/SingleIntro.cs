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
	// Token: 0x0200018D RID: 397
	public class SingleIntro : MonoBehaviour
	{
		// Token: 0x06002EE8 RID: 12008 RVA: 0x000B5AE8 File Offset: 0x000B3CE8
		// Note: this type is marked as 'beforefieldinit'.
		static SingleIntro()
		{
			Il2CppClassPointerStore<SingleIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SingleIntro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr);
			SingleIntro.NativeFieldInfoPtr_breakIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, "breakIn");
			SingleIntro.NativeFieldInfoPtr_breakOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, "breakOut");
			SingleIntro.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, "played");
			SingleIntro.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, "me");
			SingleIntro.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, 100666971);
			SingleIntro.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, 100666972);
			SingleIntro.NativeMethodInfoPtr_Play_Public_IEnumerator_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, 100666973);
			SingleIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, 100666974);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000B5BB8 File Offset: 0x000B3DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83012, XrefRangeEnd = 83014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x000B5BEC File Offset: 0x000B3DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83014, XrefRangeEnd = 83023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x000B5C20 File Offset: 0x000B3E20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83026, RefRangeEnd = 83028, XrefRangeStart = 83023, XrefRangeEnd = 83026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Play(Il2CppReferenceArray<GameObject> titles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(titles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro.NativeMethodInfoPtr_Play_Public_IEnumerator_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x000B5C70 File Offset: 0x000B3E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleIntro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000205D0 File Offset: 0x0001E7D0
		public SingleIntro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x000B5CAC File Offset: 0x000B3EAC
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x000205D9 File Offset: 0x0001E7D9
		public unsafe Il2CppReferenceArray<GameObject> breakIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro.NativeFieldInfoPtr_breakIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro.NativeFieldInfoPtr_breakIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x000B5CDC File Offset: 0x000B3EDC
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x000205F8 File Offset: 0x0001E7F8
		public unsafe Il2CppReferenceArray<GameObject> breakOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro.NativeFieldInfoPtr_breakOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro.NativeFieldInfoPtr_breakOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x000B5D0C File Offset: 0x000B3F0C
		// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x00020617 File Offset: 0x0001E817
		public unsafe bool played
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro.NativeFieldInfoPtr_played);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro.NativeFieldInfoPtr_played)) = value;
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x000B5D34 File Offset: 0x000B3F34
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x00020632 File Offset: 0x0001E832
		public unsafe static SingleIntro me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SingleIntro.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleIntro>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SingleIntro.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeFieldInfoPtr_breakIn;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeFieldInfoPtr_breakOut;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeFieldInfoPtr_played;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_IEnumerator_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200034D RID: 845
		[ObfuscatedName("SingleIntro+<Play>d__6")]
		public sealed class _Play_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x0600534C RID: 21324 RVA: 0x0012E248 File Offset: 0x0012C448
			// Note: this type is marked as 'beforefieldinit'.
			static _Play_d__6()
			{
				Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleIntro>.NativeClassPtr, "<Play>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr);
				SingleIntro._Play_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, "<>1__state");
				SingleIntro._Play_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, "<>2__current");
				SingleIntro._Play_d__6.NativeFieldInfoPtr_titles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, "titles");
				SingleIntro._Play_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, 100666975);
				SingleIntro._Play_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, 100666976);
				SingleIntro._Play_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, 100666977);
				SingleIntro._Play_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, 100666978);
				SingleIntro._Play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, 100666979);
				SingleIntro._Play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr, 100666980);
			}

			// Token: 0x0600534D RID: 21325 RVA: 0x0012E328 File Offset: 0x0012C528
			[CallerCount(0)]
			public unsafe _Play_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleIntro._Play_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro._Play_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600534E RID: 21326 RVA: 0x0012E370 File Offset: 0x0012C570
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro._Play_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600534F RID: 21327 RVA: 0x0012E3A4 File Offset: 0x0012C5A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83004, XrefRangeEnd = 83007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro._Play_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E62 RID: 7778
			// (get) Token: 0x06005350 RID: 21328 RVA: 0x0012E3E0 File Offset: 0x0012C5E0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro._Play_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005351 RID: 21329 RVA: 0x0012E420 File Offset: 0x0012C620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83007, XrefRangeEnd = 83012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro._Play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E63 RID: 7779
			// (get) Token: 0x06005352 RID: 21330 RVA: 0x0012E454 File Offset: 0x0012C654
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleIntro._Play_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005353 RID: 21331 RVA: 0x0003080C File Offset: 0x0002EA0C
			public _Play_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E5F RID: 7775
			// (get) Token: 0x06005354 RID: 21332 RVA: 0x0012E494 File Offset: 0x0012C694
			// (set) Token: 0x06005355 RID: 21333 RVA: 0x00030815 File Offset: 0x0002EA15
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro._Play_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro._Play_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E60 RID: 7776
			// (get) Token: 0x06005356 RID: 21334 RVA: 0x0012E4BC File Offset: 0x0012C6BC
			// (set) Token: 0x06005357 RID: 21335 RVA: 0x00030830 File Offset: 0x0002EA30
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro._Play_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro._Play_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E61 RID: 7777
			// (get) Token: 0x06005358 RID: 21336 RVA: 0x0012E4EC File Offset: 0x0012C6EC
			// (set) Token: 0x06005359 RID: 21337 RVA: 0x0003084F File Offset: 0x0002EA4F
			public unsafe Il2CppReferenceArray<GameObject> titles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro._Play_d__6.NativeFieldInfoPtr_titles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleIntro._Play_d__6.NativeFieldInfoPtr_titles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036FE RID: 14078
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040036FF RID: 14079
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003700 RID: 14080
			private static readonly IntPtr NativeFieldInfoPtr_titles;

			// Token: 0x04003701 RID: 14081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003702 RID: 14082
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003703 RID: 14083
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003704 RID: 14084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003705 RID: 14085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003706 RID: 14086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
