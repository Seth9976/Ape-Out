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
	// Token: 0x02000114 RID: 276
	public class Lab07LightsUpper : MonoBehaviour
	{
		// Token: 0x0600209A RID: 8346 RVA: 0x0008F740 File Offset: 0x0008D940
		// Note: this type is marked as 'beforefieldinit'.
		static Lab07LightsUpper()
		{
			Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Lab07LightsUpper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr);
			Lab07LightsUpper.NativeFieldInfoPtr_palZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, "palZone");
			Lab07LightsUpper.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, "done");
			Lab07LightsUpper.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, 100665865);
			Lab07LightsUpper.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, 100665866);
			Lab07LightsUpper.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, 100665867);
			Lab07LightsUpper.NativeMethodInfoPtr_FlickerAlpha_Private_IEnumerator_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, 100665868);
			Lab07LightsUpper.NativeMethodInfoPtr_Flicker_Private_IEnumerator_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, 100665869);
			Lab07LightsUpper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, 100665870);
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0008F810 File Offset: 0x0008DA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67884, XrefRangeEnd = 67887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0008F844 File Offset: 0x0008DA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67887, XrefRangeEnd = 67893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0008F888 File Offset: 0x0008DA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67893, XrefRangeEnd = 67896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper.NativeMethodInfoPtr_DoIt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0008F8C8 File Offset: 0x0008DAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67896, XrefRangeEnd = 67899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FlickerAlpha(SpriteRenderer pop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper.NativeMethodInfoPtr_FlickerAlpha_Private_IEnumerator_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x0008F918 File Offset: 0x0008DB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67899, XrefRangeEnd = 67902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flicker(Renderer pop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper.NativeMethodInfoPtr_Flicker_Private_IEnumerator_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0008F968 File Offset: 0x0008DB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lab07LightsUpper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00016CBA File Offset: 0x00014EBA
		public Lab07LightsUpper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x0008F9A4 File Offset: 0x0008DBA4
		// (set) Token: 0x060020A3 RID: 8355 RVA: 0x00016CC3 File Offset: 0x00014EC3
		public unsafe Il2CppReferenceArray<SpriteRenderer> palZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper.NativeFieldInfoPtr_palZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper.NativeFieldInfoPtr_palZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0008F9D4 File Offset: 0x0008DBD4
		// (set) Token: 0x060020A5 RID: 8357 RVA: 0x00016CE2 File Offset: 0x00014EE2
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeFieldInfoPtr_palZone;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_DoIt_Private_IEnumerator_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_FlickerAlpha_Private_IEnumerator_SpriteRenderer_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_Flicker_Private_IEnumerator_Renderer_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000310 RID: 784
		[ObfuscatedName("Lab07LightsUpper+<DoIt>d__4")]
		public sealed class _DoIt_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06004FC2 RID: 20418 RVA: 0x00123A44 File Offset: 0x00121C44
			// Note: this type is marked as 'beforefieldinit'.
			static _DoIt_d__4()
			{
				Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, "<DoIt>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr);
				Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, "<>1__state");
				Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, "<>2__current");
				Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, "<>4__this");
				Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr__prevkills_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, "<prevkills>5__2");
				Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, "<i>5__3");
				Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, 100665871);
				Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, 100665872);
				Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, 100665873);
				Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, 100665874);
				Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, 100665875);
				Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr, 100665876);
			}

			// Token: 0x06004FC3 RID: 20419 RVA: 0x00123B4C File Offset: 0x00121D4C
			[CallerCount(0)]
			public unsafe _DoIt_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lab07LightsUpper._DoIt_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FC4 RID: 20420 RVA: 0x00123B94 File Offset: 0x00121D94
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FC5 RID: 20421 RVA: 0x00123BC8 File Offset: 0x00121DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67826, XrefRangeEnd = 67843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D16 RID: 7446
			// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x00123C04 File Offset: 0x00121E04
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC7 RID: 20423 RVA: 0x00123C44 File Offset: 0x00121E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67843, XrefRangeEnd = 67848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D17 RID: 7447
			// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x00123C78 File Offset: 0x00121E78
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._DoIt_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC9 RID: 20425 RVA: 0x0002E9CA File Offset: 0x0002CBCA
			public _DoIt_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D11 RID: 7441
			// (get) Token: 0x06004FCA RID: 20426 RVA: 0x00123CB8 File Offset: 0x00121EB8
			// (set) Token: 0x06004FCB RID: 20427 RVA: 0x0002E9D3 File Offset: 0x0002CBD3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D12 RID: 7442
			// (get) Token: 0x06004FCC RID: 20428 RVA: 0x00123CE0 File Offset: 0x00121EE0
			// (set) Token: 0x06004FCD RID: 20429 RVA: 0x0002E9EE File Offset: 0x0002CBEE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D13 RID: 7443
			// (get) Token: 0x06004FCE RID: 20430 RVA: 0x00123D10 File Offset: 0x00121F10
			// (set) Token: 0x06004FCF RID: 20431 RVA: 0x0002EA0D File Offset: 0x0002CC0D
			public unsafe Lab07LightsUpper __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lab07LightsUpper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D14 RID: 7444
			// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x00123D40 File Offset: 0x00121F40
			// (set) Token: 0x06004FD1 RID: 20433 RVA: 0x0002EA2C File Offset: 0x0002CC2C
			public unsafe int _prevkills_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr__prevkills_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr__prevkills_5__2)) = value;
				}
			}

			// Token: 0x17001D15 RID: 7445
			// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x00123D68 File Offset: 0x00121F68
			// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x0002EA47 File Offset: 0x0002CC47
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._DoIt_d__4.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040034A2 RID: 13474
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040034A3 RID: 13475
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040034A4 RID: 13476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040034A5 RID: 13477
			private static readonly IntPtr NativeFieldInfoPtr__prevkills_5__2;

			// Token: 0x040034A6 RID: 13478
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040034A7 RID: 13479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040034A8 RID: 13480
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034A9 RID: 13481
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040034AA RID: 13482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040034AB RID: 13483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034AC RID: 13484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000311 RID: 785
		[ObfuscatedName("Lab07LightsUpper+<FlickerAlpha>d__5")]
		public sealed class _FlickerAlpha_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06004FD4 RID: 20436 RVA: 0x00123D90 File Offset: 0x00121F90
			// Note: this type is marked as 'beforefieldinit'.
			static _FlickerAlpha_d__5()
			{
				Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, "<FlickerAlpha>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr);
				Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, "<>1__state");
				Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, "<>2__current");
				Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr_pop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, "pop");
				Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, "<timer>5__2");
				Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, 100665877);
				Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, 100665878);
				Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, 100665879);
				Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, 100665880);
				Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, 100665881);
				Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr, 100665882);
			}

			// Token: 0x06004FD5 RID: 20437 RVA: 0x00123E84 File Offset: 0x00122084
			[CallerCount(0)]
			public unsafe _FlickerAlpha_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lab07LightsUpper._FlickerAlpha_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FD6 RID: 20438 RVA: 0x00123ECC File Offset: 0x001220CC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FD7 RID: 20439 RVA: 0x00123F00 File Offset: 0x00122100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67848, XrefRangeEnd = 67856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D1C RID: 7452
			// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x00123F3C File Offset: 0x0012213C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FD9 RID: 20441 RVA: 0x00123F7C File Offset: 0x0012217C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67856, XrefRangeEnd = 67861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D1D RID: 7453
			// (get) Token: 0x06004FDA RID: 20442 RVA: 0x00123FB0 File Offset: 0x001221B0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._FlickerAlpha_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FDB RID: 20443 RVA: 0x0002EA62 File Offset: 0x0002CC62
			public _FlickerAlpha_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D18 RID: 7448
			// (get) Token: 0x06004FDC RID: 20444 RVA: 0x00123FF0 File Offset: 0x001221F0
			// (set) Token: 0x06004FDD RID: 20445 RVA: 0x0002EA6B File Offset: 0x0002CC6B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D19 RID: 7449
			// (get) Token: 0x06004FDE RID: 20446 RVA: 0x00124018 File Offset: 0x00122218
			// (set) Token: 0x06004FDF RID: 20447 RVA: 0x0002EA86 File Offset: 0x0002CC86
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D1A RID: 7450
			// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x00124048 File Offset: 0x00122248
			// (set) Token: 0x06004FE1 RID: 20449 RVA: 0x0002EAA5 File Offset: 0x0002CCA5
			public unsafe SpriteRenderer pop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr_pop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr_pop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D1B RID: 7451
			// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x00124078 File Offset: 0x00122278
			// (set) Token: 0x06004FE3 RID: 20451 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
			public unsafe float _timer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr__timer_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._FlickerAlpha_d__5.NativeFieldInfoPtr__timer_5__2)) = value;
				}
			}

			// Token: 0x040034AD RID: 13485
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040034AE RID: 13486
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040034AF RID: 13487
			private static readonly IntPtr NativeFieldInfoPtr_pop;

			// Token: 0x040034B0 RID: 13488
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__2;

			// Token: 0x040034B1 RID: 13489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040034B2 RID: 13490
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034B3 RID: 13491
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040034B4 RID: 13492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040034B5 RID: 13493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034B6 RID: 13494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000312 RID: 786
		[ObfuscatedName("Lab07LightsUpper+<Flicker>d__6")]
		public sealed class _Flicker_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06004FE4 RID: 20452 RVA: 0x001240A0 File Offset: 0x001222A0
			// Note: this type is marked as 'beforefieldinit'.
			static _Flicker_d__6()
			{
				Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lab07LightsUpper>.NativeClassPtr, "<Flicker>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr);
				Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, "<>1__state");
				Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, "<>2__current");
				Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, "<>4__this");
				Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr_pop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, "pop");
				Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, 100665883);
				Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, 100665884);
				Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, 100665885);
				Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, 100665886);
				Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, 100665887);
				Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr, 100665888);
			}

			// Token: 0x06004FE5 RID: 20453 RVA: 0x00124194 File Offset: 0x00122394
			[CallerCount(0)]
			public unsafe _Flicker_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lab07LightsUpper._Flicker_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FE6 RID: 20454 RVA: 0x001241DC File Offset: 0x001223DC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FE7 RID: 20455 RVA: 0x00124210 File Offset: 0x00122410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67861, XrefRangeEnd = 67879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D22 RID: 7458
			// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x0012424C File Offset: 0x0012244C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE9 RID: 20457 RVA: 0x0012428C File Offset: 0x0012248C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67879, XrefRangeEnd = 67884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D23 RID: 7459
			// (get) Token: 0x06004FEA RID: 20458 RVA: 0x001242C0 File Offset: 0x001224C0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lab07LightsUpper._Flicker_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FEB RID: 20459 RVA: 0x0002EADF File Offset: 0x0002CCDF
			public _Flicker_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D1E RID: 7454
			// (get) Token: 0x06004FEC RID: 20460 RVA: 0x00124300 File Offset: 0x00122500
			// (set) Token: 0x06004FED RID: 20461 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D1F RID: 7455
			// (get) Token: 0x06004FEE RID: 20462 RVA: 0x00124328 File Offset: 0x00122528
			// (set) Token: 0x06004FEF RID: 20463 RVA: 0x0002EB03 File Offset: 0x0002CD03
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D20 RID: 7456
			// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x00124358 File Offset: 0x00122558
			// (set) Token: 0x06004FF1 RID: 20465 RVA: 0x0002EB22 File Offset: 0x0002CD22
			public unsafe Lab07LightsUpper __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lab07LightsUpper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D21 RID: 7457
			// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x00124388 File Offset: 0x00122588
			// (set) Token: 0x06004FF3 RID: 20467 RVA: 0x0002EB41 File Offset: 0x0002CD41
			public unsafe Renderer pop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr_pop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lab07LightsUpper._Flicker_d__6.NativeFieldInfoPtr_pop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040034B7 RID: 13495
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040034B8 RID: 13496
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040034B9 RID: 13497
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040034BA RID: 13498
			private static readonly IntPtr NativeFieldInfoPtr_pop;

			// Token: 0x040034BB RID: 13499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040034BC RID: 13500
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034BD RID: 13501
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040034BE RID: 13502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040034BF RID: 13503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034C0 RID: 13504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
